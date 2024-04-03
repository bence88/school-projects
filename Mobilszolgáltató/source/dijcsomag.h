#ifndef DIJCSOMAG_H_INCLUDED
#define DIJCSOMAG_H_INCLUDED

#include "memtrace.h"

//Dijcsomag oszt�ly mely seg�t�g�vel t�rolom, az �gyfelek dijcsomagj�nak adatait
class Dijcsomag{
protected:
    static const int bdij = 5000;       //Az alap dij amit az �gyfeleknek fizetnie kell b�rmelyik d�jcsomag�rt
    static const int hivasdij = 50;     //Telefon�l�s percenk�nti d�ja
    static const int smsdij = 30;       //SMS k�ld�s percenk�nti d�ja
    int lebeszelt_percek;               //Egy adott �gyf�l �ltal lebesz�lt perceknek a sz�ma
    int kuldott_smsek;                  //Egy adott �gyf�l �ltal k�ld�tt SMS-ek a sz�ma
public:
    //Konstruktor
    Dijcsomag(int h, int s);

    //Visszaadja a hivasdij �rt�k�t
    int gethivasdij() const;

    //Visszaadja a smsdij �rt�k�t
    int getsmsdij() const;

    //Visszaadja a bdij �rt�k�t
    int getbdij() const;

    //Visszaadja a lebeszelt_percek sz�m�t
    int getlpercek() const;

    //Visszaadja a kuldott_smsek sz�m�t
    int getksmsek() const;

    //= oper�tor
    Dijcsomag& operator=(const Dijcsomag& d);

    //Destruktor, vitru�lis, hogy a lesz�rmazottak is tudj�k haszn�lni
    virtual ~Dijcsomag();
};

// << oper�tor, ki�rja a c�mhez taroz� �sszes adattagot
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

    //Visszaadja a mobilnetdij �rt�k�t
    int getmobilnetdij() const;

    //Destruktor
    ~MobilNet();
};

class SMSMax : public Dijcsomag{
    static const int ingyensmsek = 10;
public:
    //Konstruktor
    SMSMax(int h, int s);

    //Visszaadja a ingyensmsek �rt�k�t
    int getingyensmsek() const;

    //Destruktor
    ~SMSMax();
};

#endif // DIJCSOMAG_H_INCLUDED
