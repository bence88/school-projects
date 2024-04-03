using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;
using UPVTube.Persistence;
using UPVTube.Services;

namespace UPVTube.BusinessLogic.Services
{
    public class UPVTubeService : IUPVTubeService
    {
        private readonly IDAL Dal;
        private Member Logged;

        public UPVTubeService(IDAL dal)
        {
            this.Dal = dal;
        }

        public void LogIn(string Nick, string Password)
        {
            Member user = this.Dal.GetById<Member>(Nick);
            //if (string.IsNullOrEmpty(Nick) || string.IsNullOrEmpty(Password))
            //{
            //    throw new ServiceException("Please fill out all the fields");
            //}
            //else 
            if (user == null)
            {
                throw new ServiceException("The nick does not exist");
            }
            else if (Password == user.Password)
            {
                Logged = user;
            }
            else throw new ServiceException("The password is incorrect");
        }

        public void LogOut(string Nick)
        {
            if (Logged == null)
            {
                throw new ServiceException("The nick is not logged");
            }
            else
            {
                Logged.LastAccessDate = DateTime.Now;
                Dal.Commit();
                Logged = null;
            }
        }

        public void UploadNewContent(Member member, string contentURI, string description, bool isPublic, string title, string SubjectName, int SubjectCode)
        {
            if (member != Logged)
            {
                throw new ServiceException("The member is not logged");
            }            
            else if (!Domains.IsUPVMemberDomain(member.Email))
            {
                throw new ServiceException("Not an UPV member!");
            }
            else if (!(title != "" && description != "" && contentURI != ""))
            {
                throw new ServiceException("Missing informations");
            }
            else
            {
                Content c = new Content(contentURI, description, isPublic, title, DateTime.Now, member);
                /* foreach(Subject subject in Subjects)
                 {
                     c.Subjects.Add(subject);
                 }*/
                Subject subject = this.Dal.GetById<Subject>(SubjectCode);

                if (subject == null)
                {
                    subject  = new Subject(SubjectCode,string.Concat(SubjectCode.ToString(),SubjectName),SubjectName);
                }
                else if (subject.Name != SubjectName)
                {
                    throw new ServiceException("Subject name and Subject code doesn't match");
                }
                c.Subjects.Add(subject);
                
                member.AddContent(c);
                Dal.Insert<Content>(c);
                Dal.Commit();
            }

        }

        public void RegisterNewUser(string Email, string FullName, DateTime LastAccessDate, string Nick, string Password)
        {   
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Nick) || string.IsNullOrEmpty(Password))
            {
                throw new ServiceException("Please fill in all the fields");
            }
            else if (Dal.GetById<Member>(Nick) != null)
            {
                throw new ServiceException("The nick is already in use");

            }
            else if (Dal.GetById<Member>(Email) != null)
            {
                throw new ServiceException("The email is already in use");
            }
            else
            {
                Dal.Insert<Member>(new Member(Email, FullName, LastAccessDate, Nick, Password));
                Dal.Commit();
            }
        }

        public List<Content> SearchContent(Member member, DateTime startDate, DateTime endDate, String nick, String title, String subject)
        {
            List<Content> content;
            if (member != Logged)
            {
                throw new ServiceException("The member is not logged");
            }
            else
            {
                content = Dal.GetWhere<Content>(c => (c.Authorized == Authorized.Yes)).ToList();

                if (!Domains.IsUPVMemberDomain(member.Email))
                {
                    content = content.Where<Content>(c => (c.IsPublic == true)).ToList();
                }

                if (startDate != null || endDate != null)
                {
                    content = content.Where<Content>(c => (DateTime.Compare(startDate, c.UploadDate) <= 0)).ToList();
                    content = content.Where<Content>(c => (DateTime.Compare(endDate.AddDays(1), c.UploadDate) >= 0)).ToList();
                }

                if (nick != "")
                {
                    content = content.Where<Content>(c => (c.Owner.Nick.Contains(nick))).ToList();
                }

                if (title != "")
                {
                    content = content.Where<Content>(c => (c.Title.Contains(title))).ToList();
                }

                if (subject != "")
                {
                    content = content.Where<Content>(c => (c.Subjects.Any(s => s.FullName.Contains(subject)))).ToList(); //Left here c.Subjects.Contains(subject)
                }

            }
            content = content.OrderBy(c => c.UploadDate).ToList();
            return content;
        }

        public Content DisplayContent(int id)
        {
            Content content = this.Dal.GetById<Content>(id);
            return content;
        }

        public List<Content> GetAllPendingContents(Member member)
        {
            if (member != Logged)
            {
                throw new ServiceException("The member is not logged");
            }
            if (!Domains.IsTeacherDomain(member.Email))
            {
                throw new ServiceException("Not an UPV Lecturer");
            }
            List<Content> contents;
            contents = Dal.GetWhere<Content>(c => (c.Authorized == Authorized.Pending)).ToList();

            return contents;
        }

        public void AddReview(int contentId, string rejectReason, bool reject)
        {
            if (!Domains.IsTeacherDomain(Logged.Email))
            {
                return;
            }

            Content c = Dal.GetById<Content>(contentId);

            if (!reject)
            {
                c.Authorized = Authorized.Yes;
            }
            else
            {
                c.Authorized = Authorized.No;
                Evaluation evaluation = new Evaluation(DateTime.Now, rejectReason, Logged, c);
                Dal.Insert(evaluation);
            }
            
            Dal.Commit();
        }

        public Member GetLoggedInMember()
        {
            return Logged;
        }

        public void AddComment(string Text, Content content)
        {
            Comment comment = new Comment(Text, DateTime.Now, content, Logged);
            Dal.Insert(comment);
            Dal.Commit();
        }

    }
}

