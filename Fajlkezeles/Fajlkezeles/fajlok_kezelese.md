# Fájlok kezelése

A fájlok kezelésére alapvetően két módszer van:
 - szöveges fájlok kezelése
 - fájlok kezelése bináris módban

## FileStream, StreamReader

A fájl betöltéséhez deklarálni kell egy FileStream-et.

```C#
 FileStream fajl = new FileStream(@"tesztadat_20k.txt", FileMode.Open);
```
Ezután létre kell hozni egy StreamReader-t, ez fog olvasni a fájlból, soronként.
A korábban megadott FileStream-et (fajl) kell megadni neki, valamint a szöveg kódolását (Encoding.Default)
```C#
StreamReader reader = new StreamReader(fajl, Encoding.Default);
```
Ezt követően egy while ciklussal olvasható a fájl, soronként. A ciklus addig fut, amíg az utolsó sor is be nem lesz olvasva.
```c#
 while (!reader.EndOfStream)
    {
        var sor = reader.ReadLine();
        Console.WriteLine(sor);
    }
```
A beolvasás után be kell zárni a fájlt
```C#
 reader.Close();
```
## Kivételek, kezelésük a programban

A programok működése során sokféle probléma adódhat, ebben az esetben a rendszer ún. exception-öket (kivételeket)  hoz létre. A kivételek kezelésével kell a programozónak úrrá lennie a problémán.

A kivételek elkapásához és kezeléséhez egy külön blokkot kell használni, melynek neve: **try...catch**

```C#
try {

//Ide kerülnek a végrehajtani kívánt, és adott esetben
//kivételt létrehozó műveletek

}
catch()
{
//Itt adjuk meg, hogy mi történjen, ha kivétel 
//keletkezett
}
```

Az előbbi példa try..catch blokkban
```C#
 try
            {
                FileStream fajl = new FileStream(@"tesztadat_20k.txt", FileMode.Open);
                StreamReader reader = new StreamReader(fajl, Encoding.Default);

                while (!reader.EndOfStream)
                {
                    var sor = reader.ReadLine();
                    Console.WriteLine(sor);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
```