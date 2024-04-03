#ifndef MENU_H_INCLUDED
#define MENU_H_INCLUDED

#include <iostream>
#include "memtrace.h"
#include "rekordlist.h"
#include "rekord.h"

//Ki�rja a f�men�t a kimenetre �s a felhaszn�l� el� t�rja a v�laszt�si lehet�s�geket.
//A param�ter�ben megadott Rekodlista& t�pus� v�ltoz�t megadva haszn�lja a Rekodlista oszt�ly tov�bbi f�ggv�nyeit
void fomenu(RekordList& Lista);

//Uj rekordok felv�tel�t teszi lehet�v�
//A param�ter�ben megadott Rekodlista& t�pus� v�ltoz�hoz adja hozz� a �j rekordokat
void ugyfel_felvetel(RekordList& L);

#endif // MENU_H_INCLUDED
