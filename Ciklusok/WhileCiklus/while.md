# Elöltesztelő (while) ciklus

**Az elöltesztelő ciklus**

A belépési feltétel fogja meghatározni azt, hogy a ciklus hányszor hajtódik végre, nem feltétlenül fogjuk tudni a végrehajtások számát.

A for ciklusnál látott példa elöltesztelő ciklussal:

```C#
int szam = 1;

while (szam<=30)
    {                
        Console.WriteLine(szam);
        szam++;
    }
```

A ciklust bizonyos feltételek esetén megszakíthatjuk:

```C#
   int szam = 1;

            while (szam<=30)
            {
                
                if (szam==10)
                {
                    //kilépés a ciklusból
                    break;
                }
                Console.WriteLine(szam);
                szam++;
            }
```