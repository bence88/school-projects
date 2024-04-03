#ifndef MEMORIAKEZELES_H_INCLUDED
#define MEMORIAKEZELES_H_INCLUDED

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include <string.h>
#include "econio.h"
#include "debugmalloc.h"

#include "jatek_logika.h"

Cella **palyafoglal(int oldal);
void palyafelszabadit(Cella **palya);
char **lista_foglal(int mag, int szel);
void lista_felszabadit(char **lista, int mag);

#endif // MEMORIAKEZELES_H_INCLUDED
