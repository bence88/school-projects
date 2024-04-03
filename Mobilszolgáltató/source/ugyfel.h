#ifndef UGYFEL_H_INCLUDED
#define UGYFEL_H_INCLUDED

#include "memtrace.h"
#include "cim.h"
#include "string.h"

//Ugyfel oszt�ly melyben au egyes �gyfelek szem�lyes adatait t�rolom
class Ugyfel{
    String nev;         //Az �gyf�l neve String t�pus� v�ltoz�ban elt�rolva
    Cim cim;            //Az �gyf�l c�me Cim t�pus� v�ltoz�ban elt�rolva
    String telszam;     //Az �gyf�l telefonsz�ma String t�pus� v�ltoz�ban elt�rolva
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

// << operator, amivel a szabvanyos kimenetre irjuk a Ugyfel oszt�ly v�ltoz�it
std::ostream& operator<<(std::ostream& os, const Ugyfel& u);

#endif // UGYFEL_H_INCLUDED
