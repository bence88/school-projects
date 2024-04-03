#ifndef REKORDLIST_H_INCLUDED
#define REKORDLIST_H_INCLUDED

#include "memtrace.h"
#include "rekord.h"

//Rekordlista osztályban tárolom el a már felvett ügyfeleket egy tömbben
class RekordList{
    static const size_t maxmeret = 100;     //tömb maximális mérete
    Rekord* lista[maxmeret];                //Rekord* típusú maxméret nagyságú tároló tömb
    size_t db;                              //A tömbben lévõ rekordok száma

    RekordList(const RekordList& rhs);
    RekordList& operator=(const RekordList& rhs);
public:
    //Konstruktor
    RekordList();

    //Visszaadja a db nevû változót
    size_t size() const;

    //Egy paraméterben megadott rekord pointert ad hozzá a listához a függvény
    void hozzaad(Rekord *r);

    //A listában lévõ összes rekordot kiírja a kimenetre
    void kilistaz() const;

    //Egy maraméterben megadott int típusú index megadásával kitörli az adott elemet a listából
    void torol(int idx);

    //Egy maraméterben megadott int típusú index megadásával a függvény lehetõvé teszi a felhasználó számára,
    //hogy az adott indexû rekord valamelyik adattagját megváltoztassa
    void modosit(int idx);

    //[] operátor, Rekordlista típusú változók indexelélét teszi lehetõvé
    Rekord& operator[](int idx);

    //Destruktor
    ~RekordList();
};

#endif // REKORDLIST_H_INCLUDED
