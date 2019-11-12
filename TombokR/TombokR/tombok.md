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

