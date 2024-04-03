#ifndef REKORD_H_INCLUDED
#define REKORD_H_INCLUDED

#include "memtrace.h"
#include "ugyfel.h"
#include "dijcsomag.h"

//enum v�ltoz� melynek seg�ts�g�vel elt�rolom a rekord oszt�lyban, hogy milyen dijcsomagja van egy adott �gyfelnek
enum Dcs{alap, mnet, smax};

//Rekord oszt�lyban t�rolok minden egy adott �gyf�llel kapcsolatos adatot
class Rekord{
    Ugyfel ugyf;        //Ugyfel t�pus� v�ltoz�ban t�rolom az �gyf�l szem��lyes adatait
    Dijcsomag dijcs;    //Dijcsomag t�pus� v�ltoz�ban t�rolom az �gyf�l dijcsomag�val kapcsolatos adatokat
    Dcs csomag;         //Dcs enum t�pus� v�ltoz�ban t�rolom el, hogy egy �gyf�lnek milyenfajta dijcsomaggal rendelkezik
public:

    //Konstruktor
    Rekord(Ugyfel u, Dijcsomag d, Dcs cs);

    //Visszaadja az ugyf nev� v�ltoz�t
    Ugyfel getugyf()const;

    //Visszaadja az dijcs nev� v�ltoz�t
    Dijcsomag getdijcs() const;

    //Visszaadja az csomag nev� v�ltoz�t
    Dcs getcsomag() const;

    //= oper�tor, Rekord t�pus� adat elemeit m�solja bele az oszt�ly v�ltoz�iba
    Rekord& operator=(const Rekord& r);

    //Destruktor
    ~Rekord();
};

// << oper�tor, ki�rja a rekordhoz taroz� �sszes adattagot
std::ostream& operator<<(std::ostream& os, const Rekord& c);

#endif // REKORD_H_INCLUDED
