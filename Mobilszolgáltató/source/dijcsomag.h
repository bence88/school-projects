#ifndef DIJCSOMAG_H_INCLUDED
#define DIJCSOMAG_H_INCLUDED

#include "memtrace.h"

//Dijcsomag osztály mely segítégével tárolom, az ügyfelek dijcsomagjának adatait
class Dijcsomag{
protected:
    static const int bdij = 5000;       //Az alap dij amit az ügyfeleknek fizetnie kell bármelyik díjcsomagért
    static const int hivasdij = 50;     //Telefonálás percenkénti díja
    static const int smsdij = 30;       //SMS küldés percenkénti díja
    int lebeszelt_percek;               //Egy adott ügyfél által lebeszélt perceknek a száma
    int kuldott_smsek;                  //Egy adott ügyfél által küldött SMS-ek a száma
public:
    //Konstruktor
    Dijcsomag(int h, int s);

    //Visszaadja a hivasdij értékét
    int gethivasdij() const;

    //Visszaadja a smsdij értékét
    int getsmsdij() const;

    //Visszaadja a bdij értékét
    int getbdij() const;

    //Visszaadja a lebeszelt_percek számát
    int getlpercek() const;

    //Visszaadja a kuldott_smsek számát
    int getksmsek() const;

    //= operátor
    Dijcsomag& operator=(const Dijcsomag& d);

    //Destruktor, vitruális, hogy a leszármazottak is tudják használni
    virtual ~Dijcsomag();
};

// << operátor, kiírja a címhez tarozó összes adattagot
std::ostream& operator<<(std::ostream& os, const Dijcsomag& d);


class Alap : public Dijcsomag{

public:
    //Konstruktor
    Alap(int h, int s);

    //Destruktor
    ~Alap();
};


class MobilNet : public Dijcsomag{
    static const int mobilnetdij = 2000;
public:
    //Konstruktor
    MobilNet(int h, int s);

    //Visszaadja a mobilnetdij értékét
    int getmobilnetdij() const;

    //Destruktor
    ~MobilNet();
};

class SMSMax : public Dijcsomag{
    static const int ingyensmsek = 10;
public:
    //Konstruktor
    SMSMax(int h, int s);

    //Visszaadja a ingyensmsek értékét
    int getingyensmsek() const;

    //Destruktor
    ~SMSMax();
};

#endif // DIJCSOMAG_H_INCLUDED
