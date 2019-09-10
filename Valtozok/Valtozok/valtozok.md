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