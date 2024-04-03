#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include <string.h>
#include "econio.h"
#include "debugmalloc.h"

#include "jatek_logika.h"
#include "memoriakezeles.h"
#include "megjelenites.h"

/*A játék pályájához szükséges mátrix dinamikus lefoglalása.
A fuggvény nem kap külön szélességet és magasságot, mivel a játéktér ugyanolyan széles, mint amilyen magas.
Lefoglal a megadott méretben sorfolytonos leképezéssel helyet a memóriában, amely a játékhoz szükséges pályát fogja tartalmazni,
és visszatér a lefoglalt pályára mutató pointerrel.*/
Cella **palyafoglal(int oldal){
    Cella **palya;
    palya = (Cella**) malloc(sizeof(Cella*) * oldal);
        if(palya == NULL){
            printf("A memoriat nem sikerult lefoglalni.");
        }
    palya[0] = (Cella*) malloc(oldal * oldal * sizeof(Cella));
        if(palya[0] == NULL){
            printf("A memoriat nem sikerult lefoglalni.");
        }
    for(int i = 1; i < oldal; i++){
        palya[i] = palya[0] + i * oldal;
    }
    return palya;
}

/*A függvény felszabadítja a játék nehézségének kiválasztása során lefoglalt diamikus memóriaterületet, azzal hogy megadjuk neki a
lefoglalt terület címét.*/
void palyafelszabadit(Cella **palya){
    free(palya[0]);
    free(palya);
}

/*A függvény a dicsõséglistának foglal helyet a memóriában. Paraméterként megkapja ,hogy hány eleme legyen a listának(mag),
és hogy az elemek milyen szélesek legyenek. Végül visszatér a listára mutató pointerrel.*/
char **lista_foglal(int mag, int szel){
    char **lista;
    lista = (char**) malloc(sizeof(char*) * mag);
    for(int y = 0; y < mag; y++){
        lista[y] = (char*) malloc(sizeof(char) * szel);
    }
    return lista;
}

/*A függvény felszabadítja a dicsõséglistának lefoglalt memóriaterületet.
A paraméterei a felszabadítandó lista pointere és a lista magassága, azaz elemeinek a száma.*/
void lista_felszabadit(char **lista, int mag){
    for(int y = 0; y < mag; y++){
        free(lista[y]);
    }
    free(lista);
}
