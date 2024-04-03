#include <iostream>
#include <cstring>

#include "memtrace.h"
#include "string.h"

String::String()
    :tartalom(0), hossz(0)
{}

String::String(char ch) {
    hossz = 1;
    tartalom = new char[hossz+1];
    tartalom[0] = ch;
    tartalom[1] = '\0';
}

int String::gethossz() const{
    return hossz;
}

String::~String(){
    delete [] tartalom;
}

const char* String::c_str() const{
    if(tartalom == NULL){
        return "";
    }
    return tartalom;
}

String::String(const char *szoveg){
    hossz = strlen(szoveg);
    tartalom = new char[hossz + 1];
    strcpy(tartalom, szoveg);
    tartalom[hossz] = '\0';
}

String::String(const String& str){
    hossz = str.hossz;
    tartalom = new char[hossz + 1];
    strcpy(tartalom, str.tartalom);
}

String& String::operator=(const String& str){
    if(this != &str){
        hossz = str.hossz;
        delete[] tartalom;
        tartalom = new char[hossz + 1];
        strcpy(tartalom, str.tartalom);
        tartalom[hossz] = '\0';
    }
    return *this;
}

char& String::operator[](int idx){
    return tartalom[idx];
}

const char& String::operator[](int idx) const {
    return tartalom[idx];
}

String String::operator+(char c) const {
    return *this + String(c);
}

String String::operator+(const String& str) const{
        String uj;
        uj.hossz = hossz + str.hossz;
        uj.tartalom = new char[uj.hossz + 1];
        strcpy(uj.tartalom, tartalom);
        strcat(uj.tartalom, str.tartalom);
        uj.tartalom[uj.hossz] = '\0';
        return uj;
    }

bool operator==(const String& lhs, const String& rhs){
    if(lhs.gethossz() != rhs.gethossz()){
        return false;
    }
    for(int i = 0; i < lhs.gethossz(); i++){
        if(lhs[i] != rhs[i]){
            return false;
        }
    }
    return true;
}

std::ostream& operator<<(std::ostream& os, const String& s) {
        return os << s.c_str();
}

std::istream& operator>>(std::istream& is, String& s) {
    unsigned char ch;
    s = String("");            // üres string, ehhez fûzünk hozzá
	std::ios_base::fmtflags fl = is.flags(); // eltesszük a régi flag-eket
	is.setf(std::ios_base::skipws);			// az elején eldobjuk a ws-t
    while (is >> ch) {
	    is.unsetf(std::ios_base::skipws);	// utána pedig már nem
        if (isspace(ch)) {
            is.putback(ch);             // na ezt nem kérjük
            break;
        } else {
            s = s + ch;               // végére fûzzük a karaktert
        }
    }
	is.setf(fl);						// visszaállítjuk a flag-eket
    return is;
}

