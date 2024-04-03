#ifndef FAJLKEZELES_H_INCLUDED
#define FAJLKEZELES_H_INCLUDED

#include <iostream>
#include <fstream>

#include "memtrace.h"
#include "string.h"
#include "rekordlist.h"

//A param�ter�ben megadott Rekodlista& t�pus� v�ltoz�ba beolvassa a k�t f�l�n f�jlba megadott adatokat(ugyfel.txt, dijcsomag.txt)
void fajl_beolvas(RekordList& L);

//A param�ter�ben megadott Rekodlistac t�pus� v�ltoz�b�l �rja ki az adatokat k�t k�l�n f�jlba (ugyfel.txt, dijcsomag.txt)
void fajlba_kiir(RekordList& L);

#endif // FAJLKEZELES_H_INCLUDED
