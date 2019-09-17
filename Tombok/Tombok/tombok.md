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
**Véletlen számok létrehozása, majd a tömb feltöltése ilyen számokkal**
```C#
  
            Random rand = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(1,101);
            }
```
**Listázás, az elemek sorszámát is megjelenítjük**
```C#
for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine($"{i}:{szamok[i]}");
            }
```
**Listázás elöltesztelő ciklussal**
```C#

var szamlalo = 0;
while (szamlalo<szamok.Length)
    {
        Console.WriteLine($"{szamlalo}:{szamok[szamlalo]}");
        szamlalo++;
    }
```

**Visszafelé számoló for ciklus**
```C#
for (int i = szamok.Length-1; i>=0  ; i--)
    {
        Console.WriteLine($"{i}:{szamok[i]}");
    }
```

**Kiíratás, eltérő színekkel jelöljük a pozitív és a negatív számokat**
```C#
for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if (szamok[i]>0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                
                Console.WriteLine($"{i}:{szamok[i]}");
                Console.ResetColor();
            }
```