#include <iostream>

#include "memtrace.h"
#include "gtest_lite.h"
#include "dijcsomag.h"
#include "cim.h"
#include "rekord.h"
#include "ugyfel.h"
#include "rekordlist.h"
#include "menu.h"
#include "fajlkezeles.h"

#define KAPCSOLO 1

using std::cout;
using std::cin;
using std::endl;

int main(){

#if KAPCSOLO == 0
    RekordList Lista;

    fajl_beolvas(Lista);

    fomenu(Lista);

    fajlba_kiir(Lista);

#endif // KAPCSOLO

//Tesztesetek
#if KAPCSOLO == 1

    Dcs x = alap;
    String s("Kaposvár");
    int i = s.gethossz();
    String z;
    z = s;
    String w('a');
    Cim k("Tiszafured", "Borsoskert_u", 9, 5350);
    Cim c(z, "Dombovari_u", i, 4444);
    k = c;
    Ugyfel u("Peti", Cim("Sopron", "Uborka_u", 23, 8888), "123456789");
    Ugyfel a("Csaba", c, "111111111");
    u = a;
    Dijcsomag cs(10, 20);
    Dijcsomag zs(20, 30);
    cs = zs;
    Rekord valami(a, cs, x);
    Rekord barmi(Ugyfel("Bence", Cim("Tiszafured", "Borsoskert_u", 9, 5350), "06204026666"), Alap(10, 10), alap);
    barmi = valami;

    RekordList Lista;

    Lista.hozzaad(new Rekord(Ugyfel("Bence", Cim("Tiszafured", "Borsoskert_u", 9, 5350), "06204026666"), Alap(10, 10), alap));
    Lista.hozzaad(new Rekord(Ugyfel("Peti", Cim("Sopron", "Uborka_u", 23, 8888), "123456789"), MobilNet(20, 20), mnet));
    Lista.hozzaad(new Rekord(Ugyfel("Boti", Cim("Budapest", "Kolbasz_u", 85, 1111), "1212121212"), SMSMax(30, 30), smax));

    Lista.kilistaz();

    TEST(TEST, lista_meret){
        EXPECT_EQ((size_t)3, Lista.size());
        EXPECT_NE((size_t)4, Lista.size());
    } ENDM

    TEST(TEST, index_op){
        EXPECT_THROW(Lista[3], const char*);
        EXPECT_NO_THROW(Lista[2]);
    } ENDM

    TEST(TEST, hozzaad1){
        EXPECT_EQ((size_t)3, Lista.size());
    }ENDM

    Lista.hozzaad(new Rekord(Ugyfel("Akos", Cim("Eger", "Krumpli_u", 13, 5432), "5252525252"), SMSMax(40, 40), alap));

    TEST(TEST, hozzaad2){
        EXPECT_EQ((size_t)4, Lista.size());
    }ENDM

    TEST(TEST, torles1){
        EXPECT_THROW(Lista.torol(4), const char*);
        EXPECT_EQ((size_t)4, Lista.size());
    } ENDM

    Lista.torol(3);

    TEST(TEST, torles2){
        EXPECT_EQ((size_t)3, Lista.size());
    } ENDM

    TEST(TEST, string_t){
        EXPECT_TRUE(w == s[1]);
    } ENDM

    fajlba_kiir(Lista);
    Lista.torol(0);
    Lista.torol(0);
    Lista.torol(0);
    fajl_beolvas(Lista);

    TEST(TEST, fajlkezeles){
        EXPECT_EQ((size_t)3, Lista.size());
    } ENDM

#endif // KAPCSOLO

    return 0;
}
