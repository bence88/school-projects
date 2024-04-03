#ifndef MEGJELENITES_H_INCLUDED
#define MEGJELENITES_H_INCLUDED

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include <string.h>
#include "econio.h"
#include "debugmalloc.h"

#include "jatek_logika.h"

void menu_1(int *palyameret, int *bombak, char **dlista);
void palya_kirajzol(int meret, Cella **palya);
void cella_felfedez(int x, int y, int meret, Cella **valos, Cella **megjel);
int idomero(clock_t kezdes);
char menu_2();
void dicslista_kiir(char **dlista);

#endif // MEGJELENITES_H_INCLUDED
