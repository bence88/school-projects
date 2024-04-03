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

Cella **palya_megjelenitett;
Cella **palya_valos;
int meret, bomba_szam;
Jatekallas j = folyamatban;
char menugomb;
char *jnev;
int mp;
char **dlista;

int main(){
    econio_set_title("Aknakereso");
    printf("Udvozollek a jatekban!\n");

    while(menugomb != 'k'){
        dlista = dicslista_elment();

        menu_1(&meret, &bomba_szam, dlista); //Menü kiírása

        econio_clrscr();

        palya_megjelenitett = palyafoglal(meret); //Pályák helyének lefoglalása a memóriában
        palya_valos = palyafoglal(meret);

        palya_feltolt(meret, palya_megjelenitett, '-'); //Megjelenítendő pálya változóinak feltöltése a megfelelő értékekkel

        palya_generator(meret, palya_valos, ' ', bomba_szam);

        jnev = jnev_beolvas();

        mp = jatekmenet(j, palya_valos, palya_megjelenitett, meret, bomba_szam);

        ujrekordot_felvesz(mp, jnev, dlista);

        palyafelszabadit(palya_megjelenitett); //Lefoglalt memóriaterületek felszabadítása
        palyafelszabadit(palya_valos);
        free(jnev);
        lista_felszabadit(dlista, 10);

        menugomb = menu_2();
        econio_clrscr();
        econio_textcolor(COL_WHITE);
    }
    return 0;
}
