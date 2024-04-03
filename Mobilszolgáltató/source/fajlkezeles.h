#ifndef FAJLKEZELES_H_INCLUDED
#define FAJLKEZELES_H_INCLUDED

#include <iostream>
#include <fstream>

#include "memtrace.h"
#include "string.h"
#include "rekordlist.h"

//A paraméterében megadott Rekodlista& típusú változóba beolvassa a két fülön fájlba megadott adatokat(ugyfel.txt, dijcsomag.txt)
void fajl_beolvas(RekordList& L);

//A paraméterében megadott Rekodlistac típusú változóból írja ki az adatokat két külön fájlba (ugyfel.txt, dijcsomag.txt)
void fajlba_kiir(RekordList& L);

#endif // FAJLKEZELES_H_INCLUDED
