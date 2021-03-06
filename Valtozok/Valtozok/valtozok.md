﻿# Változók a programban

A változó értékek tárolására szolgál a programban.
Gyakorlatilag a memória egy részét jelenti, amelyet
egy névvel azonosítunk.

## Változók típusai

- egész számok
- tört számok
- egyetlen betű (karakter)
- különböző hosszúságú szövegek
- logikai érték (igaz/hamis)

## Kiíró utasítás

**Ezzel tudunk valamilyen üzentet, vagy egy változó értékét megjeleníteni.**

```C#
Console.WriteLine("Gyá!");
```

Az eredmény megtekintéséhez szükség van arra, hogy a program várakozzon pl. egy gomb leütésére:
```c#
Console.ReadKey();
```
## Változók létrehozása(deklaráció)

**szam** nevű, int típusú változó létrehozása
```C#
int szam;
```

**Értékadás**, a bal oldali változó kapja meg a jobb
oldalon lévő értéket

```C#
szam = 117;
```
**2019.09.10**

**A változó a deklarációkor is kaphat értéket:**

```C#
int szam=12;
```

**Név konvenciók**

 - a változó neve legyen kisbetűs
 - ha több névből áll, akkor a szóhatáron lévő betű legyen nagybetűs pl.masikSzam
 - ne kezdődjön számmal, vagy más írásjellel
 - ne legyen benne ékezet

**Változók maximális, minimális értéke**

Az adott típus pl. **Int32** esetén az **Int32.MaxValue** illetve az **Int32.MinValue** értékekkel lehet megtudni, hogy a típus milyen határok között tud értékeket tárolni.

Mindez egy kiíró utasításba csomagolva:
```c#
Console.WriteLine($"Int32 max:{Int32.MaxValue} Int32 min:{Int32.MinValue}");
```
**Nem egész számokat tároló változó típusok:**

 - float (egyszeres pontosságú, 32 bites)
 - double (kétszeres pontosságú, 64 bites)
 - decimal (decimális, 128 bites)

```C#
float egyszeres = 15.39445456466525443f;
double ketszeres = 15.39445456466525443;
decimal dec = 15.39445456466525443m;
```

**Deklarálás a VAR kulcsszóval**

```C#
 var kellEgyValtozo = 35.664456346;
```
Ebben az esetben a fordító automatikusan a megfelelő típust rendeli a változóhoz, amit a megadott érték alapján állapít meg.

**Szöveg típus**

Egy karakterláncot (szöveget) tárol.

```C#
String szoveg = "Valami Szöveg";
```

**Karakter típus**

Egyetlen karaktert tud tárolni.
```C#
Char karakter = 'a';
```

**Logikai típus**

Logikai értéket(igaz/hamis) tud tárolni.

```C#
Boolean logikai = true;
bool logikai2 = false;
```

