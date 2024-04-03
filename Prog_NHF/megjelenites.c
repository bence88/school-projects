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

/*Menürendszer melyben a játékos ki tudja választani hogy játszani vagy a ranglistát megnézni szeretné-e.
Ezen felül ha a játék indítása menügomb után kiválaszthatja, hogy milyen nehézségi fokon szeretne játszani a játékkal.
A fuggvény címszerint megadott változókba elmenti a felhasználó által kiválasztott nehézségi szint adatait*/
void menu_1(int *palyameret, int *bombak, char **dlista){
    char menugomb, nehszint, visszagomb;
    while(menugomb != 'k'){
       printf("Menu:\n"
           "Jatek inditasa - \"j\"\n"
           "Dicsoseglista megtekintese - \"d\"\n"
           "Kilepes - \"k\"\n");
           scanf(" %c", &menugomb);
        switch(menugomb){
        case 'j':
            econio_clrscr();
            while(nehszint != 'v'){
                printf("Valassz nehezsegi szintet!\n"
                       "Kezdo(8x8, 9 bomba) - \"1\"\n"
                       "Halado(12x12, 25 bomba) - \"2\"\n"
                       "Tapasztalt(16x16, 50 bomba) - \"3\"\n"
                       "Vissza a menube - \"v\"\n");
                scanf(" %c", &nehszint);
                   switch(nehszint){
                    case '1':
                        *palyameret = 8;
                        *bombak = 9;
                        nehszint = 'v';
                        menugomb = 'k';
                        break;
                    case '2':
                        *palyameret = 12;
                        *bombak = 25;
                        nehszint = 'v';
                        menugomb = 'k';
                        break;
                    case '3':
                        *palyameret = 16;
                        *bombak = 50;
                        nehszint = 'v';
                        menugomb = 'k';
                        break;
                    case 'v':
                        econio_clrscr();
                        break;
                    default:
                        econio_clrscr();
                        printf("Nem jo gombot nyomtal le.\n\n");
                        break;
                   }
                }
                nehszint = 'u';// Hogyha újból a játék menüpontot választjuk egyszeri visszalépés után, akkor ennek a más értékre való átállításával ismételten le tud futni a nehézségválasztó ciklus.
            break;
        case 'd':
            econio_clrscr();
            while(visszagomb != 'v'){
                dicslista_kiir(dlista);
                printf("Vissza - \"v\"\n");
                scanf(" %c", &visszagomb);
                if(visszagomb != 'v'){
                    econio_clrscr();
                    printf("Rossz gombot nyotal le.\n");
                }
            }
            visszagomb = 'u';
            econio_clrscr();
            break;
        case 'k':
            econio_clrscr();
            lista_felszabadit(dlista, 10);
            printf("Kileptel a jatekbol.\n");
            exit(0);
            break;
        default:
            econio_clrscr();
            printf("Nem jo gombot nyomtal le.\n\n");
            break;
        }
    }
}

/*A függvény kirajzolja a megjelenítendõ pályát és a pálya mellett illetve fölött elhelyezkedõ segédindexeket.
Paraméterként megkapja a kirajzolandó pálya méretét és magát a kirajzolnadó pályát.*/
void palya_kirajzol(int meret, Cella **palya){
    printf("Segitseg: \"-\" felfedezetlen cella, \"*\" bomba, \"szokoz\" ures cella, szamok 1-8-ig - kornyezo bombak szama.\n"
           "A palya:\n");
    printf("\t");
    for(int j = 1; j <= meret; j++){ // vízszintes indexek
            printf(" %d\t", j);
    }
        printf("\n\n");
    for(int i = 1; i <= meret; i++){
        printf("%d\t", i);      //függõleges indexek
        for(int j = 0; j < meret; j++){         //cellák
            if(palya[i - 1][j].szomszed_bombak == 0){
                printf("|%c|\t", palya[i - 1][j].kinezet);
            }else{
                printf("|%d|\t", palya[i - 1][j].szomszed_bombak);
            }
        }
        printf("\n\n");
    }
}

/*A függvény automatikusan felfedezi az egymás mellet lévõ üres cellákat.
Paraméterként megkapja kiinduló cella x és y koordináját, és két egyenként egy-egy pályára mutató pointer párost.*/
void cella_felfedez(int x, int y, int meret, Cella **valos, Cella **megjel){
    if(valos[x][y].szomszed_bombak == 0){
        for(int i = -1; i < 2; i++){
            for(int j = -1; j < 2; j++){
                if(kornyezo_cellak(meret, x + i, y + j) || megjel[x + i][y + j].felvanfedezve == true || megjel[x + i][y + j].megvanjelolve == true)
                    continue;
                if(valos[x + i][y + j].szomszed_bombak == 0){
                    megjel[x + i][y + j].kinezet = valos[x + i][y + j].kinezet;
                    megjel[x + i][y + j].felvanfedezve = true;
                    cella_felfedez(x + i, y + j, meret, valos, megjel);
                }else{
                    megjel[x + i][y + j].szomszed_bombak = valos[x + i][y + j].szomszed_bombak;
                    megjel[x + i][y + j].felvanfedezve = true;
                }
            }
        }
    }else{
        megjel[x][y].szomszed_bombak = valos[x][y].szomszed_bombak;
        megjel[x][y].felvanfedezve = true;
    }
}

/*Ez a függvény az idõ mérésére és kiíratására szolgál.
A paraméterként kapott idõtõl mérve irja ki az eltelt idõt, illetve adja vissza az eltelt másodpercek számát.*/
int idomero(clock_t kezdes){
    int mp;
    clock_t eltelt = clock() - kezdes;
    mp = eltelt / CLOCKS_PER_SEC;
    printf("Ido: %02d:%02d\n", mp/60, mp%60);
    return mp;
}

/*Ez a fuggvény egy menüt ir ki, ha a játékos befejezte a játékmenetet(nyert vagy veszített).
Viszatérési értéke egy karakter aminek a függvényében visszadob minket a fõmenübe vagy bezárul a program.*/
char menu_2(){
    char gomb;
    while(gomb != 'k' || gomb != 'f'){
        printf("\nVissza a fomenube - \"f\"\n"
               "Kilepes - \"k\"\n");
        scanf(" %c", &gomb);
        if(gomb == 'k' || gomb == 'f'){
            return gomb;
        }else{
            econio_clrscr();
            printf("Rossz gombot nyomott le, probaja ujra!");
        }
    }
}

/*Ez a függvény kiirja a file-ból beolvasott dicsőséglista elemeit.
Egyetlen paramétere a dicsőséglistára mutató pointer.*/
void dicslista_kiir(char **dlista){
    printf("Helyezes\tido\tnev\n");
        for(int i = 0; dlista[i] != NULL && i < 10; i++){
            printf("%d.\t\t", i + 1);
            printf("%s\n", dlista[i]);
        }
}
