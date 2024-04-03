#include <iostream>

#include "memtrace.h"
#include "cim.h"

Cim::Cim(const String& v, const String& u, int h, int i)
    :varos(v), utca(u), hazszam(h), irSzam(i)
{}

const String& Cim::getvaros() const{
    return varos;
}

const String& Cim::getutca() const{
    return utca;
}

int Cim::gethazszam() const{
    return hazszam;
}

int Cim::getirszam() const{
    return irSzam;
}

Cim& Cim::operator=(const Cim& c){
    if(this != &c){
        varos = c.varos;
        utca = c.utca;
        hazszam = c.hazszam;
        irSzam = c.irSzam;
    }
    return *this;
}

Cim::~Cim(){}

std::ostream& operator<<(std::ostream& os, const Cim& c){
    return os << c.getvaros() << " " << c.getutca() << " " << c.gethazszam() << ". " <<c.getirszam();
}

