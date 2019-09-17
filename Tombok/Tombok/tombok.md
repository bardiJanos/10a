# Tömbök
A tömb olyan adatszerkezet, amely több (adott számú) azonos típusú elemet tartalmaz.

## Tömb deklarálása
**10 elemű, integer típusú számot tud tárolni. Ennél a deklarálásnál az elemszámot adtuk meg.**
```C#
int[] szoveg = new int[10];
```
**deklarálás a var kulcsszóval**
```C#
var szamok2 = new int[10];
```

**deklarálás az elemek megadásával**
```C#
int[] szamok3 = {1,2,3,4,5};
```

**tömbök indexelése**
Meg kell adni a [] zárójelek között annak az elemnek az indexét (sorszámát), amelyre hivatkozni akarunk.
pl.
```C#
szamok[0] = 121;
```
**Tömb feltöltése értékekkel**
A tömb feltöltését ciklusban végezzük, erre a **for** ciklus a legalkalmasabb. A ciklus annyiszor fog lefutni, amennyi tömbelem van.
```C#
for (int i = 0; i < szamok.Length; i++)
    {
        szamok[i] = 222;
    }
```
**A tömb elemeinek kiíratásakor is végig kell menni a teljes tömbön**
```C#
for (int i = 0; i < szamok.Length; i++)
    {
        Console.WriteLine(szamok[i]);
    }
```