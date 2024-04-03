#include <iostream>

#include "memtrace.h"
#include "rekord.h"

Rekord::Rekord(Ugyfel u, Dijcsomag d, Dcs cs)
    :ugyf(u), dijcs(d), csomag(cs)
{}

Ugyfel Rekord::getugyf() const{
    return ugyf;
}

Dijcsomag Rekord::getdijcs() const{
    return dijcs;
}

Dcs Rekord::getcsomag() const{
    return csomag;
}

Rekord& Rekord::operator=(const Rekord& r){
    if(this != &r){
        ugyf = r.ugyf;
        dijcs = r.dijcs;
        csomag = r.csomag;
    }
    return *this;
}

Rekord::~Rekord(){}

std::ostream& operator<<(std::ostream& os, const Rekord& c){
    int a = c.getdijcs().getbdij() + (c.getdijcs().getlpercek() * c.getdijcs().gethivasdij()) + (c.getdijcs().getksmsek() * c.getdijcs().getsmsdij());
    int m = c.getdijcs().getbdij() + (c.getdijcs().getlpercek() * c.getdijcs().gethivasdij()) + (c.getdijcs().getksmsek() * c.getdijcs().getsmsdij()) + 2000;
    int s;

    if(c.getdijcs().getksmsek() <= 10){
        s = c.getdijcs().getbdij() + (c.getdijcs().getlpercek() * c.getdijcs().gethivasdij());
    }else{
        s = c.getdijcs().getbdij() + (c.getdijcs().getlpercek() * c.getdijcs().gethivasdij()) + (c.getdijcs().getksmsek() * c.getdijcs().getsmsdij()) - (10 * c.getdijcs().getsmsdij());
    }

    os << c.getugyf() << c.getdijcs();
    if(c.getcsomag() == alap){
        os << " Alap" << " Fizetendo: " << a;
    }else if(c.getcsomag() == mnet){
        os << " MobilNet" << " Fizetendo: " << m;
    }else{
        os << " SMSMax" << " Fizetendo: " << s;
    }
    return os;
}
