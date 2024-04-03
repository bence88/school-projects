#ifndef STRING_H_INCLUDED
#define STRING_H_INCLUDED

#include "memtrace.h"

//Saját string osztály
class String {
    char *tartalom;
    int hossz;
public:
    //Paraméter nélküli konstruktor:
    String();

    //Konstruktor, karaterből készít stringet
    String(char ch);

    //Char*-ból készít string típusú változót
    String(const char *szoveg);

    //Másoló konstruktor: String-bõl készít (createString)
    String(const String& str);

    //Sztring hosszát adja vissza.
    int gethossz() const;

    //C-sztringet ad vissza
    const char* c_str() const;

    //Értékadó operátor
    String& operator=(const String& str);

    //Index operátor
    char& operator[](int idx);

    //Index operátor
    const char& operator[](int idx) const;

    // + operator, egy karatert ad a meglévő string-hez
    String operator+(char c) const;

    //+ operátor, ami a String-hez jobbról karaktert ad
    String operator+(const String& str) const;

    //Destruktor
    ~String();
};

//Egyenlõség vizsgálat
bool operator==(const String& lhs, const String& rhs);

// << operator, amivel a szabvanyos kimenetre irjuk a string osztály változóit
std::ostream& operator<<(std::ostream& os, const String& s);

// << operátor, ami beolvas az istreamről egy String típusú változót
std::istream& operator>>(std::istream& is, String& s);

#endif // STRING_H_INCLUDED
