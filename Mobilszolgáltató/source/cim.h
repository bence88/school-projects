#ifndef CIM_H_INCLUDED
#define CIM_H_INCLUDED

#include "memtrace.h"
#include "string.h"

//Cim osztály melyet az ügyfelek pontos címének eltárolására hazsnálok
struct Cim{
    String varos;   //String típusú változó melyben a váosevet tárolom
    String utca;    //String típusú változó melyben az utca nevét tárolom
    int hazszam;    //int típusú változó melyben a házszámot tárolom
    int irSzam;     //int típusú változó melyben a irányítószámot tárolom

    //Konstruktor
    Cim(const String& v, const String& u, int h, int i);

    //Visszaadja a varos nevû változót
    const String& getvaros() const;

    //Visszaadja az utca nevû változót
    const String& getutca() const;

    //Visszaadja a hazszam nevû változót
    int gethazszam() const;

    //Visszaadja a irSzam nevû változót
    int getirszam() const;

    //= operátor, Cim típusú adat elemeit másolja bele a változókba
    Cim& operator=(const Cim& c);

    //Destruktor
    ~Cim();
};

// << operátor, kiírja a címhez tarozó összes adattagot
std::ostream& operator<<(std::ostream& os, const Cim& c);

#endif // CIM_H_INCLUDED
