#ifndef SEGED_H
#define SEGED_H

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include <string.h>
#include "econio.h"
#include "debugmalloc.h"

/*Ez a strukt�ra a j�t�kt�r �p�t�eleme, mely megadja, hogy egy adott cella bomba-e, fel van-e fedezve, meg van-e jel�lve, h�ny darab
szomsz�dos cell�ja van, illetve hogy hogyan n�z ki ki az aktu�lis cella megjelen�t�skor.*/
typedef struct Cella{
    bool bomba;
    bool felvanfedezve;
    bool megvanjelolve;
    int szomszed_bombak;
    char kinezet;
} Cella;

/*Ennek a v�ltoz�nak a seg�ts�g�vel van sz�montartva, hogy egy adott j�t�kos a j�t�knak �pp melyik f�zis�ban van.*/
typedef enum Jatekallas{
    nyert,
    folyamatban,
    vesztett
}Jatekallas;

void palya_feltolt(int meret, Cella **palya, char c);
bool kornyezo_cellak(int max, int x,int y);
void palya_generator(int meret, Cella **palya, char c, int bombak_szama);
bool nyert_e(Cella **palya, int bombak, int meret);
int jatekmenet(Jatekallas j, Cella **palya_v, Cella **palya_m, int meret, int bombak);
char *jnev_beolvas();
void ujrekordot_felvesz(int mp, char *jnev, char **dlista);
char **dicslista_elment();

#endif
