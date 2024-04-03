#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <time.h>
#include <string.h>
#include "econio.h"
#include "debugmalloc.h"

#include "jatek_logika.h"
#include "memoriakezeles.h"

/*A fuggvény feltölti a megjelenítendő játéktér egyes celláinak vátozóit.
Paraméterként megkapja a pálya méretét, a feltöltednő pályát, valamint kap egy karaktert,
amivel az összes cella kinézetét beállítja arra az adott karakterre.*/
void palya_feltolt(int meret, Cella **palya, char c){
    for(int i = 0; i < meret; i++){
        for(int j = 0; j < meret; j++){
            palya[i][j].kinezet = c;
            palya[i][j].bomba = false;
            palya[i][j].felvanfedezve = false;
            palya[i][j].megvanjelolve = false;
            palya[i][j].szomszed_bombak = 0;
        }
    }
}

/*Ez a függvény megnézi, hogy egy adott koordinátájú cella rajta van-e a pályán, vagy túl van indexelve.
Paraméterként megkapja a pályameretet, valamint a vizsgálandó cella x és y koordinátáját.
Végül visszatér a megfelelő logikai értékkel.*/
bool kornyezo_cellak(int meret, int x,int y){
    if(x<0 || y<0 || x >= meret || y >= meret)
        return true;
    return false;
}

/*A függvény először kitölti az argumentumban megadott karakterrel az előre lefoglalt memóriaterületet.
Ezután véletlenszerűen generált koordinátákra bombákat helyez el, majd a maradék mezőkbe beleírja,
hogy az egyes cellák körül hány bomba található.
Paraméterként megkapja a pálya méretét, a pályára mutató pointert, egy karaktert amivel minden más művelet előtt feltölti a pályát,
illetve hogy hány bombát kell szétszórnia a pályán.*/
void palya_generator(int meret, Cella **palya, char c, int bombak_szama){
    palya_feltolt(meret, palya, c);
    srand(time(NULL));
    for(int b = 0; b < bombak_szama; b++){
        int x, y;
        x = rand() % meret;
        y = rand() % meret;
        if(!palya[x][y].bomba){
            palya[x][y].bomba = true;
            palya[x][y].kinezet = '*';
        }else{
        b--;
        }
    }
    for(int x = 0; x < meret; x++){ //két for cilus végigmegy a pályán
        for(int y = 0; y < meret; y++){
            palya[x][y].szomszed_bombak = 0;
            if(!palya[x][y].bomba){
                for(int i = -1; i < 2; i++){ //két for ciklus megnézi hogy egy adott mező körül hány bomba van
                    for(int j = -1; j < 2; j++){
                        if((i==0 && j==0) || kornyezo_cellak(meret, x + i, y + j))
                            continue;
                        if(palya[x + i][y + j].bomba)
                            palya[x][y].szomszed_bombak++;
                    }
                }
                if(palya[x][y].szomszed_bombak > 0)
                    palya[x][y].kinezet = palya[x][y].szomszed_bombak;
            }
        }
    }
}

/*Megnézi, hogy nyert- e már a felhasználó, úgy hogy megvizygálja hogy a felfedezettlen cellák száma
megeggyezik-e az adott pályán található bombák számával.
Paraméterként megkapja a pályára mutató pointert és a méretét, valamint hogy hány bomba van a pályán.
Legvégül visszatér a megfelelő logikai értékkel.*/
bool nyert_e(Cella **palya, int bombak, int meret){
    int nincs_felfedezve = 0;
    for(int x = 0; x < meret; x++){
        for(int y = 0; y < meret; y++){
            if(!palya[x][y].felvanfedezve)
                nincs_felfedezve++;
        }
    }
    if(nincs_felfedezve == bombak)
        return true;
    return false;
}

/*A függvény maga a játék futtatását végzi. Vizsálja hogy vesztett vagy nyert-e már a játékos vagy még folyamatban van a játék.
Másrészről kezeli azt is hogy a játékos a megadott koordinátát felfedni, megjelölni akar vagy éppen jelölést szeretne eltávolítani.
Paraméterként kap egy a játékállást tároló felsorolt típusú változót, két egyenként egy pályára mutató pointert és egy bombaszámot.
Vissaztérési értéke pedig az, hogy egy játékos mennyi idő alatt vitt végig egy adott pályát.
Viszont ha vesztett a játékos akkor a visszatérési érték 0.*/
int jatekmenet(Jatekallas j, Cella **palya_v, Cella **palya_m, int meret, int bombak){
    clock_t kezdeti_ido = clock();
    int eltelt_mp = idomero(kezdeti_ido);
    int x, y;
    char FelvMeg;
    econio_clrscr();
    while(j == folyamatban){
        eltelt_mp = idomero(kezdeti_ido);
        palya_kirajzol(meret, palya_m);
        printf("Add meg egy cella koordinatajat (sorszam szokoz oszlopszam formaban): ");
        scanf(" %d %d", &x, &y);
        x -= 1;
        y -= 1;
        printf("Ezt a cellat:"
               "-felfedni akarod - \"f\"\n"
               "-jelolest akarsz ratenni - \"m\"\n"
               "-jelolest akarsz levenni - \"l\"\n"
               "Nyomd meg a megfelelo gombot: ");
        scanf(" %c", &FelvMeg);

        econio_clrscr();
        switch(FelvMeg){
            case 'f':
                if(palya_v[x][y].bomba){
                    econio_textcolor(COL_RED);
                    eltelt_mp = idomero(kezdeti_ido);
                    palya_kirajzol(meret, palya_v);
                    printf("Bombara leptel, a jateknak vege. Tobb szerencset a kovetkezo menethez! :D\n\n");
                    j = vesztett;
                }else{
                    cella_felfedez(x, y, meret, palya_v, palya_m);
                    eltelt_mp = idomero(kezdeti_ido);
                    //palya_kirajzol(meret, palya_m);
                }
                if(nyert_e(palya_m, bombak, meret)){
                    econio_clrscr();
                    econio_textcolor(COL_GREEN);
                    eltelt_mp = idomero(kezdeti_ido);
                    palya_kirajzol(meret, palya_v);
                    printf("Gratulalok, nyertel!\n");
                    return eltelt_mp;
                    j = nyert;
                }
                break;
            case 'm':
                if(palya_m[x][y].megvanjelolve == false){
                    palya_m[x][y].megvanjelolve = true;
                    palya_m[x][y].kinezet = '!';
                    eltelt_mp = idomero(kezdeti_ido);
                    //palya_kirajzol(meret, palya_m);
                }else{
                    printf("A cella meg van jelolve, nem lehet megjelolni megegyszer.\n");
                    eltelt_mp = idomero(kezdeti_ido);
                    //palya_kirajzol(meret, palya_m);
                }
                break;
            case 'l':
                if(palya_m[x][y].megvanjelolve == true){
                    palya_m[x][y].megvanjelolve = false;
                    palya_m[x][y].kinezet = '-';
                    eltelt_mp = idomero(kezdeti_ido);
                    //palya_kirajzol(meret, palya_m);
                }else{
                    printf("A cella nincs felfedezve, nem lehet jelolest levenni.\n");
                    eltelt_mp = idomero(kezdeti_ido);
                    //palya_kirajzol(meret, palya_m);
                }
                break;
            default:
                printf("Nem jo gombot nyomtal le.\n\n");
                break;
        }
    }
    return 0;
}

/*A függvény belolvas egy karaktersorozatot addig amig nem nyom entert a felhasználó.
Visszatérési értéke pedig egy string, amiben a felhasználó által begépelt karaktersorozat található.*/
char *jnev_beolvas(){
    printf("Adj meg egy jatekosnevet: ");
    int n = 1;
    char betu;
    char *jnev = (char*) malloc(sizeof(char) * n);
        if(jnev == NULL){
            printf("Nem sikerult memoriat lefoglalni.");
        }
    scanf(" %c", &betu);
    while(betu != '\n'){
        n++;
        jnev = realloc(jnev, sizeof(char) * n);
        jnev[n - 2] = betu;
        jnev[n - 1] = '\0';
        scanf("%c", &betu);
    }
    return jnev;
}

/*A függvény paraméterként kap egy számot, mely másodpercet tartalmaz, kap egy stringet mely a játékos nevét tartalmazza,
valamint kap egy file-bol beolvasott listára mutató pointert. A függvény létrehoz egy stringet melyet a dicsőséglista megfelelő helyére beszúr.*/
void ujrekordot_felvesz(int mp, char *jnev, char **dlista){
    if(mp != 0){
            char ujrekord[6 + strlen(jnev) + 1];
            char perc[3];
            char masodperc[3];
            sprintf(masodperc, "%02d", mp%60);
            sprintf(perc, "%02d", mp/60);

            strcpy(ujrekord, perc);
            ujrekord[2] = ':';
            strcat(ujrekord, masodperc);
            ujrekord[5] = '\t';
            ujrekord[6] = '\0';
            strcat(ujrekord, jnev);

            int i = 0;
            while(strcmp(ujrekord, dlista[i]) == 1){
            i++;
            }
            FILE *dicslista;
            dicslista = fopen("dicslista.txt", "w");
                if(dicslista == NULL){
                    perror("Nem sikerult megnyitni a fajlt!");
                }
            for(int j = 0; j < i; j++){
                fprintf(dicslista, dlista[j]);
            }
            if(i < 10){
                fprintf(dicslista, ujrekord);
                fprintf(dicslista, "\n");
                for(int j = i; j < 9; j++){
                    fprintf(dicslista, dlista[j]);
                }
            }
            fclose(dicslista);
        }
}

/*A függvény file-ból beolvas beolvasott szöveget, melyet dinamikusan foglalt memóriába lement.
Visszatérési értékként pedig a többdimenziós tömbbre mutató pointert ad, melyben a szoveg sorai vannak eltárolva.*/
char **dicslista_elment(){
    FILE *dicslista;

    dicslista = fopen("dicslista.txt", "r");
        if(dicslista == NULL){
            perror("Nem sikerult megnyitni a fajlt!");
        }

    char c;
    int sorszam = 0;
    for(c = getc(dicslista); c != EOF; c = getc(dicslista)){
        if(c == '\n'){
            sorszam++;
        }
    }
    fseek(dicslista, 0, SEEK_SET);

    char **dlista = lista_foglal(10, 0);

    int i = 0;
    char sor[101];
    while(i < sorszam){
        fgets(sor, 101, dicslista);
        dlista[i] = realloc(dlista[i], sizeof(char) * (strlen(sor) + 1));
        strcpy(dlista[i], sor);
        i++;
    }
    fclose(dicslista);
    return dlista;
}
