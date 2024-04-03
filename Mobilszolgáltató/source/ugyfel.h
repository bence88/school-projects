#ifndef UGYFEL_H_INCLUDED
#define UGYFEL_H_INCLUDED

#include "memtrace.h"
#include "cim.h"
#include "string.h"

//Ugyfel osztály melyben au egyes ügyfelek személyes adatait tárolom
class Ugyfel{
    String nev;         //Az ügyfél neve String típusú változóban eltárolva
    Cim cim;            //Az ügyfél címe Cim típusú változóban eltárolva
    String telszam;     //Az ügyfél telefonszáma String típusú változóban eltárolva
public:
    //Konstruktor
    Ugyfel(const String& n, Cim c, const String& t);

    //Visszaadja a nev valtozo tartalmat
    const String& getnev() const;

    //Visszaadja a cim valtozo tartalmat
    const Cim& getcim() const;

    //Visszaadja a telszam valtozo tartalmat
    const String& gettelszam() const;

    // = operator
    Ugyfel& operator=(const Ugyfel& u);

    //Destruktor
    ~Ugyfel();
};

// << operator, amivel a szabvanyos kimenetre irjuk a Ugyfel osztály változóit
std::ostream& operator<<(std::ostream& os, const Ugyfel& u);

#endif // UGYFEL_H_INCLUDED
