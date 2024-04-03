using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;

namespace UPVTube.BusinessLogic.Services
{
    public interface IUPVTubeService
    {
        void RegisterNewUser(string Email, string FullName, DateTime LastAccessDate, string Nick, string Password);

        void LogIn(string Nick, string Password);

        void LogOut(string Nick);

        void UploadNewContent(Member member, string contentURI, string descrption, bool isPublic, string title,string Subjects, int SubjectCode);

        List<Content> SearchContent(Member member, DateTime startDate, DateTime endDate, String nick, String title, String subject);

        Content DisplayContent(int id);

        List<Content> GetAllPendingContents(Member member);

        void AddReview(int contentId, string rejectReason, bool reject);

        Member GetLoggedInMember();

        void AddComment(string Text, Content content);

    }
}
