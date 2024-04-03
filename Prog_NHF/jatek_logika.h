#ifndef SEGED_H
#define SEGED_H

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include <string.h>
#include "econio.h"
#include "debugmalloc.h"

/*Ez a struktúra a játéktér építõeleme, mely megadja, hogy egy adott cella bomba-e, fel van-e fedezve, meg van-e jelölve, hány darab
szomszédos cellája van, illetve hogy hogyan néz ki ki az aktuális cella megjelenítéskor.*/
typedef struct Cella{
    bool bomba;
    bool felvanfedezve;
    bool megvanjelolve;
    int szomszed_bombak;
    char kinezet;
} Cella;

/*Ennek a változónak a segítségével van számontartva, hogy egy adott játékos a játéknak épp melyik fázisában van.*/
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
