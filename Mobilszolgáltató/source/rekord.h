#ifndef REKORD_H_INCLUDED
#define REKORD_H_INCLUDED

#include "memtrace.h"
#include "ugyfel.h"
#include "dijcsomag.h"

//enum változó melynek segítségével eltárolom a rekord osztályban, hogy milyen dijcsomagja van egy adott ügyfelnek
enum Dcs{alap, mnet, smax};

//Rekord osztályban tárolok minden egy adott ügyféllel kapcsolatos adatot
class Rekord{
    Ugyfel ugyf;        //Ugyfel típusú változóban tárolom az ügyfél szeméélyes adatait
    Dijcsomag dijcs;    //Dijcsomag típusú változóban tárolom az ügyfél dijcsomagával kapcsolatos adatokat
    Dcs csomag;         //Dcs enum típusú változóban tárolom el, hogy egy ügyfélnek milyenfajta dijcsomaggal rendelkezik
public:

    //Konstruktor
    Rekord(Ugyfel u, Dijcsomag d, Dcs cs);

    //Visszaadja az ugyf nevû változót
    Ugyfel getugyf()const;

    //Visszaadja az dijcs nevû változót
    Dijcsomag getdijcs() const;

    //Visszaadja az csomag nevû változót
    Dcs getcsomag() const;

    //= operátor, Rekord típusú adat elemeit másolja bele az osztály változóiba
    Rekord& operator=(const Rekord& r);

    //Destruktor
    ~Rekord();
};

// << operátor, kiírja a rekordhoz tarozó összes adattagot
std::ostream& operator<<(std::ostream& os, const Rekord& c);

#endif // REKORD_H_INCLUDED
