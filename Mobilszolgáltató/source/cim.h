#ifndef CIM_H_INCLUDED
#define CIM_H_INCLUDED

#include "memtrace.h"
#include "string.h"

//Cim oszt�ly melyet az �gyfelek pontos c�m�nek elt�rol�s�ra hazsn�lok
struct Cim{
    String varos;   //String t�pus� v�ltoz� melyben a v�osevet t�rolom
    String utca;    //String t�pus� v�ltoz� melyben az utca nev�t t�rolom
    int hazszam;    //int t�pus� v�ltoz� melyben a h�zsz�mot t�rolom
    int irSzam;     //int t�pus� v�ltoz� melyben a ir�ny�t�sz�mot t�rolom

    //Konstruktor
    Cim(const String& v, const String& u, int h, int i);

    //Visszaadja a varos nev� v�ltoz�t
    const String& getvaros() const;

    //Visszaadja az utca nev� v�ltoz�t
    const String& getutca() const;

    //Visszaadja a hazszam nev� v�ltoz�t
    int gethazszam() const;

    //Visszaadja a irSzam nev� v�ltoz�t
    int getirszam() const;

    //= oper�tor, Cim t�pus� adat elemeit m�solja bele a v�ltoz�kba
    Cim& operator=(const Cim& c);

    //Destruktor
    ~Cim();
};

// << oper�tor, ki�rja a c�mhez taroz� �sszes adattagot
std::ostream& operator<<(std::ostream& os, const Cim& c);

#endif // CIM_H_INCLUDED
