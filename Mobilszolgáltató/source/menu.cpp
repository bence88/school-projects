#include <iostream>

#include "memtrace.h"
#include "menu.h"
#include "rekordlist.h"

using std::cout;
using std::cin;
using std::endl;

void ugyfel_felvetel(RekordList& L){
    String nev, varos, utca, telszam;
    int hazszam, irszam;
    char valasztogomb;
    String seged2;

    cout << "Adja meg az ugyfel nevet, a vezetek es keresztnev kozott \"_\" jellel elvalsztva: ";
    cin >> nev;
    cout << "Adja meg az ugyfel cimet!\nVaros: ";
    cin >> varos;
    cout << "\nUtca: ";
    cin >> utca;
    cout << "\nHazszam: ";
    cin >> hazszam;
    cout << "\nIranyitoszam: ";
    cin >> irszam;
    cout << "\nAdja meg az ugyfel telefonszamat: ";
    cin >> telszam;
    while(valasztogomb != 'a' || valasztogomb != 'n' || valasztogomb != 's'){
        cout << "\nAdja meg milyen dijcsomagot kivan az ugyfel!" << endl;
        cout << "Alap - \"a\"" << endl;
        cout << "MobilNet - \"n\"" << endl;
        cout << "SMSMax - \"s\"" << endl;
        cin >> seged2;
        valasztogomb = seged2[0];
        switch(valasztogomb){
            case 'a':
                cout << "Az Alap csomagot valaszotta!" << endl;
                L.hozzaad(new Rekord(Ugyfel(nev, Cim(varos, utca, hazszam, irszam), telszam), Alap(0, 0), alap));
                break;
            case 'n':
                cout << "A MobilNet csomagot valaszotta!" << endl;
                L.hozzaad(new Rekord(Ugyfel(nev, Cim(varos, utca, hazszam, irszam), telszam), MobilNet(0, 0), mnet));
                break;
            case 's':
                cout << "Az SMSMax csomagot valaszotta!" << endl;
                L.hozzaad(new Rekord(Ugyfel(nev, Cim(varos, utca, hazszam, irszam), telszam), SMSMax(0, 0), smax));
                break;
            default:
                cout << "Rossz gombot nyomott le!" <<endl;
                break;
        }
    }
}

void fomenu(RekordList& Lista){
    int kilepes = 1;
    char menugomb;
    String seged;
    int torles_idx, modosit_idx;
    while(kilepes == 1){
        cout << "\tFomenu\n" << endl;
        cout << "Uj ugyfel felvetele - \"u\"" << endl;
        cout << "Meglevo ugyfel torlese - \"t\"" << endl;
        cout << "Ugyfelek kilistazasa - \"l\"" << endl;
        cout << "Meglevo ugyfel adatanak modositasa - \"m\"" << endl;
        cout << "Kilepes - \"k\"" << endl;
        cin >> seged;
        menugomb = seged[0];
        switch(menugomb){
            case 'u':
                ugyfel_felvetel(Lista);
                break;
            case 't':
                Lista.kilistaz();
                cout << "\nAdja meg a sorszamat annak az ugyfelnek, amelyiket torolni kivanja: ";
                cin >> torles_idx;
                try{
                    Lista.torol(torles_idx);
                }catch(const char* hiba){
                    cout << hiba << "\n";
                }
                break;
            case 'l':
                Lista.kilistaz();
                cout << "\n";
                break;
            case 'm':
                Lista.kilistaz();
                cout << "\nAdja meg a sorszamat annak az ugyfelnek, amelyiket modositani kivanja: ";
                cin >> modosit_idx;
                if(modosit_idx < 0 || modosit_idx > (int)Lista.size()){
                    cout << "\nNem letezo indexet adott meg\n";
                    break;
                }
                Lista.modosit(modosit_idx);
                break;
            case 'k':
                kilepes = 0;
                break;
            default:
                cout << "Rossz gombot nyomott le!" <<endl;
                break;
        }
    }
}
