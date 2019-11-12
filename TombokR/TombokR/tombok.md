# Tömbök, véletlen számok létrehozása

Az alap algoritmusok gyakorlásához először létrehozunk egy 200 elemű tömböt.

```C#
int[] szamok = new int[200];
```

Véletlen számokkal akarjuk feltölteni a tömböt, ehhez inicializálni kell
a véletlenszám-generátort.
```C#
Random rand = new Random();
```
A tömb feltöltését ciklussal végezzük:

```C#
for (int i = 0; i < szamok.Length; i++)
{
    szamok[i] = rand.Next(-100, 101);
}
```

Az elemek kiíratását szintén ciklussal végezzük:

```C#
for (int i = 0; i < szamok.Length; i++)
{
    Console.WriteLine(szamok[i]);
}
```

**Feladat: mennyi a negatív számok aránya?**

Kell egy változó, amelyben gyűjtjük a negatív értékek darabszámát
```C#
 int negativDb = 0;
```
Ciklussal végig kell menni a tömbön, egy elágazás segítségével csak a nullánál kisebb elemeket dolgozzuk fel
```C#
for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i]<0)
        {
            //ha a tömb eleme kisebb mint 0, akkor a negatív
            //számok darabszámát tartalmazó változó értékét
            //1-el növeljük
            negativDb++;
        }
}
```
Kiíratjuk az eredményt. Mivel egész típusok esetén az eredmény 0 lenne a törtrész elvesztése miatt
ezért a **(double)** típuskényszerítéssel megváltoztatjuk az eredmény típusát.

```C#
Console.WriteLine($"Negatív elemek aránya:{(double)negativDb/szamok.Length}");
```
**A tömb pozitív elemeinek darabszáma, átlaga**

```c#
int pozitivDb = 0;
int pozitivOsszeg = 0;

for (int i = 0; i < szamok.Length; i++)
{
    if (szamok[i] >= 0)
    {
        pozitivDb++;
        pozitivOsszeg = pozitivOsszeg + szamok[i];
    }
}

Console.WriteLine($"Pozitív elemek aránya:{(double)pozitivDb / szamok.Length * 100} %");
Console.WriteLine($"Pozitív elemek átlaga:{(double)pozitivOsszeg/pozitivDb}");
```