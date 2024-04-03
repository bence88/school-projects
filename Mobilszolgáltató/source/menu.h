#ifndef MENU_H_INCLUDED
#define MENU_H_INCLUDED

#include <iostream>
#include "memtrace.h"
#include "rekordlist.h"
#include "rekord.h"

//Kiírja a fõmenüt a kimenetre és a felhasználó elé tárja a választási lehetõségeket.
//A paraméterében megadott Rekodlista& típusú változót megadva használja a Rekodlista osztály további függvényeit
void fomenu(RekordList& Lista);

//Uj rekordok felvételét teszi lehetõvé
//A paraméterében megadott Rekodlista& típusú változóhoz adja hozzá a új rekordokat
void ugyfel_felvetel(RekordList& L);

#endif // MENU_H_INCLUDED
