#include <iostream>

#include "memtrace.h"
#include "ugyfel.h"

Ugyfel::Ugyfel(const String& n, Cim c, const String& t)
    :nev(n), cim(c), telszam(t)
{}

const String& Ugyfel::getnev() const{
    return nev;
}

const Cim& Ugyfel::getcim() const{
    return cim;
}

const String& Ugyfel::gettelszam() const{
    return telszam;
}

Ugyfel& Ugyfel::operator=(const Ugyfel& u){
    if(this != &u){
        nev = u.nev;
        cim = u.cim;
        telszam = u.telszam;
    }
    return *this;
}

Ugyfel::~Ugyfel(){}

std::ostream& operator<<(std::ostream& os, const Ugyfel& u){
    return os << "Nev: " << u.getnev() << " Cim: " << u.getcim() << " Telefonszam: " << u.gettelszam();
}
