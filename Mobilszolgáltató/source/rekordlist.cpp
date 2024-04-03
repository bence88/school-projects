#include <iostream>

#include "memtrace.h"
#include "rekordlist.h"

using std::cout;
using std::cin;
using std::endl;

RekordList::RekordList()
    :db(0)
{}

size_t RekordList::size() const{
    return db;
}

void RekordList::hozzaad(Rekord *r){
    if(db == 100){
        delete r;
        throw "Megtelt a rendelkezesre allo hely!";
        return;
    }
    db++;
    lista[db - 1] = r;
}

void RekordList::kilistaz() const{
    if(db == 0){
        cout << "Nincs felvett elem!";
        return;
    }
    cout << "\n";
    for(int i = 0; i < (int)db; i++){
        cout << i << ". " << *lista[i] <<"\n\n";
    }
}

void RekordList::torol(int idx){
    if(db == 0){
        cout << "Nincs meg semmilyen adat a rendszerben!";
    }
    if(idx < 0 || idx >= (int)db){
        throw "Nem jo indexet adott meg!";
        return;
    }else{
        if(db == 1){
            delete lista[0];
            db--;
        }else{
            int n = 0;
            Rekord* tmp[maxmeret];
            for(int i = 0; i < (int)db; i++){
                if(i == idx){
                    delete lista[i];
                }else{
                    tmp[n++] = lista[i];
                }
            }
            for(int i = 0; i < (int)db - 1; i++){
                lista[i] = tmp[i];
            }
            db--;
        }

    }
}

void RekordList::modosit(int idx){
    String seged3, uj_szoveg;
    char m_gomb;
    int uj_szam;
    int bezar = 0;

    Dcs cs = lista[idx]->getcsomag();
    while(bezar == 0){
        cout << "\nAz alabbi rekordban tud valtoztatasokat eszkozolni: " << endl;
        cout << idx << ". " << *lista[idx] <<"\n";
        cout << "\nValassza ki melyik adatot szeretne megvaltoztatni!" << endl;
        cout << "Nev - \"n\"" << endl;
        cout << "Varos - \"v\"" << endl;
        cout << "Utca - \"u\"" << endl;
        cout << "Hazszam - \"h\"" << endl;
        cout << "Iranyitoszam - \"i\"" << endl;
        cout << "Telefonszam - \"t\"" << endl;
        cout << "Lebeszelt percek szama - \"l\"" << endl;
        cout << "Kuldott sms-ek szama - \"s\"" << endl;
        cin >> seged3;
        m_gomb = seged3[0];
        switch(m_gomb){
            case 'n':{
                cout << "\nIrja be az uj nevet!" << endl;
                cin >> uj_szoveg;
                Rekord r(Ugyfel(uj_szoveg, Cim(lista[idx]->getugyf().getcim()), lista[idx]->getugyf().gettelszam()),lista[idx]->getdijcs(), cs);
                *lista[idx] = r;
                bezar = 1;
                break;
            }
            case 'v':{
                cout << "\nIrja be az uj varost!" << endl;
                cin >> uj_szoveg;
                Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(uj_szoveg, lista[idx]->getugyf().getcim().getutca(), lista[idx]->getugyf().getcim().gethazszam(), lista[idx]->getugyf().getcim().getirszam()), lista[idx]->getugyf().gettelszam()),lista[idx]->getdijcs(), cs);
                *lista[idx] = r;
                bezar = 1;
                break;
            }
            case 'u':{
                cout << "\nIrja be az uj utcat!" << endl;
                cin >> uj_szoveg;
                Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim().getvaros(), uj_szoveg, lista[idx]->getugyf().getcim().gethazszam(), lista[idx]->getugyf().getcim().getirszam()), lista[idx]->getugyf().gettelszam()),lista[idx]->getdijcs(), cs);
                *lista[idx] = r;
                bezar = 1;
                break;
            }
            case 'h':{
                cout << "\nIrja be az uj hazszamot!" << endl;
                cin >> uj_szam;
                Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim().getvaros(), lista[idx]->getugyf().getcim().getutca(), uj_szam, lista[idx]->getugyf().getcim().getirszam()), lista[idx]->getugyf().gettelszam()),lista[idx]->getdijcs(), cs);
                *lista[idx] = r;
                bezar = 1;
                break;
            }
            case 'i':{
                cout << "\nIrja be az uj iranyitoszamot!" << endl;
                cin >> uj_szam;
                Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim().getvaros(), lista[idx]->getugyf().getcim().getutca(), lista[idx]->getugyf().getcim().gethazszam(), uj_szam), lista[idx]->getugyf().gettelszam()),lista[idx]->getdijcs(), cs);
                *lista[idx] = r;
                bezar = 1;
                break;
            }
            case 't':{
                cout << "\nIrja be az uj telefonszamot!" << endl;
                cin >> uj_szoveg;
                Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim()), uj_szoveg),lista[idx]->getdijcs(), cs);
                *lista[idx] = r;
                bezar = 1;
                break;
            }
            case 'l':{
                cout << "\nIrja be a lebeszelt percek mennyiseget!" << endl;
                cin >> uj_szam;
                if(cs == alap){
                    Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim()), lista[idx]->getugyf().gettelszam()), Alap(uj_szam, lista[idx]->getdijcs().getksmsek()), cs);
                    *lista[idx] = r;
                }else if(cs == mnet){
                    Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim()), lista[idx]->getugyf().gettelszam()), MobilNet(uj_szam, lista[idx]->getdijcs().getksmsek()), cs);
                    *lista[idx] = r;
                }else{
                    Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim()), lista[idx]->getugyf().gettelszam()), SMSMax(uj_szam, lista[idx]->getdijcs().getksmsek()), cs);
                    *lista[idx] = r;
                }
                bezar = 1;
                break;
            }
            case 's':{
                cout << "\nIrja be a kuldott sms-ek mennyiseget!" << endl;
                cin >> uj_szam;
                if(cs == alap){
                    Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim()), lista[idx]->getugyf().gettelszam()), Alap(lista[idx]->getdijcs().getlpercek(), uj_szam), cs);
                    *lista[idx] = r;
                }else if(cs == mnet){
                    Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim()), lista[idx]->getugyf().gettelszam()), MobilNet(lista[idx]->getdijcs().getlpercek(), uj_szam), cs);
                    *lista[idx] = r;
                }else{
                    Rekord r(Ugyfel(lista[idx]->getugyf().getnev(), Cim(lista[idx]->getugyf().getcim()), lista[idx]->getugyf().gettelszam()), SMSMax(lista[idx]->getdijcs().getlpercek(), uj_szam), cs);
                    *lista[idx] = r;
                }
                bezar = 1;
                break;
            }
            default:
                cout << "Rossz gombot nyomott le!" <<endl;
                break;
        }
    }
}

Rekord& RekordList::operator[](int idx){
    if(idx < 0 || idx >= (int)db){
        throw "Hiba!";
    }
    return *lista[idx];
}

RekordList::~RekordList(){
    for(int i = 0; i < (int)db; i++){
        delete lista[i];
    }
}


