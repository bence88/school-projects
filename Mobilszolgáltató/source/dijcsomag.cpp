#include <iostream>

#include "memtrace.h"
#include "dijcsomag.h"

//-------Dijcsomag osztály----------

Dijcsomag::Dijcsomag(int h, int s)
    :lebeszelt_percek(h), kuldott_smsek(s)
{}

int Dijcsomag::gethivasdij() const{
    return hivasdij;
}

int Dijcsomag::getsmsdij() const{
    return smsdij;
}

int Dijcsomag::getbdij() const{
    return bdij;
}

int Dijcsomag::getlpercek() const{
    return lebeszelt_percek;
}

int Dijcsomag::getksmsek() const{
    return kuldott_smsek;
}

Dijcsomag& Dijcsomag::operator=(const Dijcsomag& d){
    if(this != &d){
        lebeszelt_percek = d.lebeszelt_percek;
        kuldott_smsek = d.kuldott_smsek;
    }
    return *this;
}

Dijcsomag::~Dijcsomag(){}

std::ostream& operator<<(std::ostream& os, const Dijcsomag& d){
    return os << " Lebeszelt percek: " << d.getlpercek() << " Kuldott sms-ek szama: " << d.getksmsek();
}


//-------Alap osztály----------


Alap::Alap(int h, int s)
    :Dijcsomag(h, s)
{}

Alap::~Alap(){}


//-------MobilNet osztály----------


MobilNet::MobilNet(int h, int s)
    :Dijcsomag(h, s)
{}

int MobilNet::getmobilnetdij() const{
    return mobilnetdij;
}

MobilNet::~MobilNet(){}


//-------SMSMax osztály----------


SMSMax::SMSMax(int h, int s)
    :Dijcsomag(h, s)
{}

int SMSMax::getingyensmsek() const{
    return ingyensmsek;
}

SMSMax::~SMSMax(){}

