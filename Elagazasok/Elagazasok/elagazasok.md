# Elágazások (eset szétválasztás)

## Elágazások típusai:
### Egyszeres egyágú

példa 1: Megvizsgáljuk, hogy a értéke pozitív-e.
```C#
int a = 12;
if (a>0)
{
    Console.WriteLine("Pozitív szám");
}
```
### Egyszeres kétágú

```C#
if (a>=0)
{
    Console.WriteLine("Pozitív szám");
}
else
{
    Console.WriteLine("Negatív szám");
}
```

### Többszörös

Az előző példa javítása, kezeljük megfelelően a 0-át!

```c#
if (a>0)
{
    Console.WriteLine("Pozitív szám");
}
else if (a==0)
{
    Console.WriteLine("Nulla");
}
else
{
    Console.WriteLine("Negatív szám");
}
```
**Példa hibás többszörös szelekióra**

```C#
  a = 25;
            //
            if (a>10)
            {
                Console.WriteLine("10-nél nagyobb");
            }
            else if (a>20)
            {
                Console.WriteLine("20-nál nagyobb");
            }
            else if (a>30)
            {
                Console.WriteLine("30-nál nagyobb");
            }
            else
            {
                Console.WriteLine("Nem nagyobb mint 10");
            }
```

A fenti szelekció a feltételek megfogalmazása miatt sosem jut el az else if ágakra.

**A fenti példa javítás után**

```C#
  a = 25;
            //
            if (a>10 && a<=20)
            {
                Console.WriteLine("10-nél nagyobb");
            }
            else if (a>20 && a<=30)
            {
                Console.WriteLine("20-nál nagyobb");
            }
            else if (a>30)
            {
                Console.WriteLine("30-nál nagyobb");
            }
            else
            {
                Console.WriteLine("Nem nagyobb mint 10");
            }
```
**Többszörös szelekció, switch**
Egy változó adott értéke esetén végrehajtandó tevékenységek végrehajtására. Ha nincs egyezés, akkod a default eset hajtódik végre.
```C#
ConsoleKey bill = ConsoleKey.DownArrow;

            switch (bill)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Up");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down");
                    break;
                default:
                    Console.WriteLine(bill);
                    break;
            }
```