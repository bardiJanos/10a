# Változók a programban

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
