# Növekményes (for,foreach) ciklus

Ennél a ciklusnál a végrehajtások száma ismert.

**1.példa**
Írjunk egy 30x lefutó ciklust! Írjuk ki a ciklusváltozó értékét!

Megoldás:
```C#
for (int i = 1; i <= 30; i++)
    {
        Console.WriteLine($"ciklusváltozó:{i}");
    }
```

**Ugyanez a ciklus számoljon visszafelé!**
```C#
 for(int i=30;i>=0; i--)
    {
        Console.WriteLine(i);
    }
```

