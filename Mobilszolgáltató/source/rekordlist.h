#ifndef REKORDLIST_H_INCLUDED
#define REKORDLIST_H_INCLUDED

#include "memtrace.h"
#include "rekord.h"

//Rekordlista oszt�lyban t�rolom el a m�r felvett �gyfeleket egy t�mbben
class RekordList{
    static const size_t maxmeret = 100;     //t�mb maxim�lis m�rete
    Rekord* lista[maxmeret];                //Rekord* t�pus� maxm�ret nagys�g� t�rol� t�mb
    size_t db;                              //A t�mbben l�v� rekordok sz�ma

    RekordList(const RekordList& rhs);
    RekordList& operator=(const RekordList& rhs);
public:
    //Konstruktor
    RekordList();

    //Visszaadja a db nev� v�ltoz�t
    size_t size() const;

    //Egy param�terben megadott rekord pointert ad hozz� a list�hoz a f�ggv�ny
    void hozzaad(Rekord *r);

    //A list�ban l�v� �sszes rekordot ki�rja a kimenetre
    void kilistaz() const;

    //Egy maram�terben megadott int t�pus� index megad�s�val kit�rli az adott elemet a list�b�l
    void torol(int idx);

    //Egy maram�terben megadott int t�pus� index megad�s�val a f�ggv�ny lehet�v� teszi a felhaszn�l� sz�m�ra,
    //hogy az adott index� rekord valamelyik adattagj�t megv�ltoztassa
    void modosit(int idx);

    //[] oper�tor, Rekordlista t�pus� v�ltoz�k indexel�l�t teszi lehet�v�
    Rekord& operator[](int idx);

    //Destruktor
    ~RekordList();
};

#endif // REKORDLIST_H_INCLUDED
