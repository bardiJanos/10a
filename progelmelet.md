# Programozás elmélet 

## Ebben a tanévben C# és JavaScript
---
## 1.év 
 - HTML+CSS
 - algoritmizálás
 - algoritmus elemek
  - utasítás
  - elágazás
  - ciklusok
  - elemi algoritmusok
  
## Fejlesztő környezetek
 - SharpDevelop (ingyenes, szolidan fapados)
 - Visual Studio Code (ingyenes, fordítás, futtatás kicsit nehézkes)
 - Microsoft Visual Studio 2015,2017 (a legjobban használható, a Community Edition ingyenes, csak egy Microsoft fiók kell hozzá)
 
 ## Mit lehet írni vele?
  - konzol alkalmazás
  - grafikus alkalmazás
  - webalkalmazás
  - mobil alkalmazás (Android)
  
 # Változó típuok
 
 ## Érték típusok
 
  ## Egész számok tárolása
   - int előjeles 32 bit
   - short előjeles 16 bit
   - long előjeles 64 bit
   -uint előjel nélküli 32 bit
   -ushort előjel nélküli 16 bit
   -ulong előjel nélküli 64 bit
  
## Deklarálás
```C#
int szam;
int masikSzam = 12;
uint eSzam = 34;
short rovid = 3345;
long hosszu = 2423445;
Int32 szam32 = 23455;
```

## Min, max értékek kiíratása

```c#
Console.WriteLine($"Előjeles 16bit:min:{Int16.MinValue},max:{Int16.MaxValue}");
Console.WriteLine($"Előjel nélküli 16bit:min:{UInt16.MinValue},max:{UInt16.MaxValue}");

Console.WriteLine($"Előjeles 32bit:min:{Int32.MinValue},max:{Int32.MaxValue}");
Console.WriteLine($"Előjel nélküli 32bit:min:{UInt32.MinValue},max:{UInt32.MaxValue}");
```

## Tört számok (lebegőpontos) számok tárolása


**egyszeres pontosságú, 32 bites**
```C#
float nemEgesz32 = 105.1287697369263926392936936f;
```

**kétszeres pontosságú, 64 bites**

```C#
double nemEgsze64 = 105.1287697369263926392936936;
```

**decimális**
```C#
decimal nemEgesz64 = 105.1287697369263926392936936m;
```
**Pénzügyi alkalmazások esetén (kerekítési problémák miatt) a decimal típust kell használni. Egyéb esetekre elég a float ill. a double.**

**Logikai típus (igaz/hamis)**
```C#            
 bool logikai;
 logikai = true;
 logikai = false;
 ```

 **Szöveg típus**
```C# 
String szoveg = "Csodálatos hétfő reggel..";
```

**Egy string karaktereire egyenkét is lehet hivatkozni**
pl. első karakterének kiíratása
C#-ban az elemek számozása 0-val kezdődik!!!
```C#
Console.WriteLine(szoveg[0]);
Console.WriteLine(szoveg[1]);
```

**Műveletek stringekkel**

**Szöveg hossza:**
```C#
Console.WriteLine(szoveg.Length);
```

**Van a szoveg string-ben hétfő?**
```C#
Console.WriteLine(szoveg.Contains("hétfő"));
```

**ugyanaz, csak változóval**
```C#
string keresett = "Hétfő";
Console.WriteLine(szoveg.Contains(keresett));
Console.WriteLine(szoveg.StartsWith(keresett));
```

**Karakter cseréje a szövegben**
```C#
Console.WriteLine(szoveg.Replace('o','ö'));
```

**Szóközök eltüntetése**

```C#
Console.WriteLine(szoveg.Replace(" ",""));
```
**Szövegrész kiemelése adott karakter pozíciótól**
```c#
Console.WriteLine(szoveg.Substring(3));
```

**adott karakter pozíciótól, a megadott darab karakter kiemelése**
```c#
Console.WriteLine(szoveg.Substring(3,5));
```
```c#
string hetfo = szoveg.Substring(11,5);
Console.WriteLine(hetfo);
```
            
**kisbetűsre alakítás**
```c#
Console.WriteLine(szoveg.ToLower());
```
**nagybetűsre alakítás**
```c#
Console.WriteLine(szoveg.ToUpper());
```

**Karakter típus**
```C#            
Char karakter = 'h';
```
