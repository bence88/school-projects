#include <iostream>
#include <fstream>

#include "memtrace.h"
#include "fajlkezeles.h"
#include "string.h"
#include "rekordlist.h"

using std::endl;
using std::cin;
using std::ios;

void fajl_beolvas(RekordList& L){

    std::ifstream dijcs;

    dijcs.open("dijcsomag.txt");

    int lpercek, ksmsek;
    int tomb[100][2];
    int idx = 0;
    while(dijcs >> lpercek){
        dijcs >> ksmsek;

        tomb[idx][0] = lpercek;
        tomb[idx][1] = ksmsek;
        idx++;
    }
    dijcs.close();

    std::ifstream ugyf;

    ugyf.open("ugyfel.txt");

    String nev, telszam, varos, utca, csomag;
    int hazszam, irszam;
    int i = 0;
    while(ugyf >> nev){
        ugyf >> varos;
        ugyf >> utca;
        ugyf >> hazszam;
        ugyf >> irszam;
        ugyf >> telszam;
        ugyf >> csomag;

        String seged_a("alap");
        String seged_b("mnet");
        if(csomag == seged_a){
            L.hozzaad(new Rekord(Ugyfel(nev, Cim(varos, utca, hazszam, irszam), telszam), Alap(tomb[i][0], tomb[i][1]), alap));
        }else if(csomag == seged_b){
            L.hozzaad(new Rekord(Ugyfel(nev, Cim(varos, utca, hazszam, irszam), telszam), MobilNet(tomb[i][0], tomb[i][1]), mnet));
        }else{
            L.hozzaad(new Rekord(Ugyfel(nev, Cim(varos, utca, hazszam, irszam), telszam), SMSMax(tomb[i][0], tomb[i][1]), smax));
        }
        i++;
    }
    ugyf.close();
}

void fajlba_kiir(RekordList& L){
    std::ofstream ugyf;

    ugyf.open("ugyfel.txt");

    for(int idx = 0; idx < (int)L.size(); idx++){
        ugyf << L[idx].getugyf().getnev() << " ";
        ugyf << L[idx].getugyf().getcim().getvaros() << " ";
        ugyf << L[idx].getugyf().getcim().getutca() << " ";
        ugyf << L[idx].getugyf().getcim().gethazszam() << " ";
        ugyf << L[idx].getugyf().getcim().getirszam() << " ";
        ugyf << L[idx].getugyf().gettelszam() << " ";
        if(L[idx].getcsomag() == 0){
            ugyf << "alap" << "\n";
        }else if(L[idx].getcsomag() == 1){
            ugyf << "mnet" << "\n";
        }else{
            ugyf << "smax" << "\n";
        }

    }
    ugyf.close();

    std::ofstream dijcs;

    dijcs.open("dijcsomag.txt");

    for(int i = 0; i < (int)L.size(); i++){
        dijcs << L[i].getdijcs().getlpercek() << " ";
        dijcs << L[i].getdijcs().getksmsek() << " ";
    }
    dijcs.close();
}
