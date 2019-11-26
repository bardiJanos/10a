# Függvények, azaz alprogramok

A függvény/alprogram olyan kódot tartalmaz amelyre a program futása során többször is szükség van. Nem lenne célszerű ezeket az ismétlődő tevékenységeket annyiszor leírni, ahányszor szükség van rájuk, mert ez nagyon átláthatatlanná tenné a programot. Célszerű a programban minden ismétlődő tevékenységet kirakni egy alprogramba. Ezt követően a főprogramból bármikor meghívhatjuk az alprogramot. 

**A függvény a főprogramon kívülre kell hogy kerüljön!**

A függvények végrehajthatnak tevékenységeket anélkül, hogy valami változóértéket visszaadnának.
Ez a függvény nevében a **VOID** kulcsszó jelzi.

Olyan eset is lehetséges, hogy a függvény kiszámol, meghatároz valamilyen értéket, és ezt visszaadja.
Ebben az esetben a függvénynek lesz visszatérési értéke, melynek típusát meg kell adni a függvény létrehozásakor.

A függvény lehet paraméteres, vagy paraméter nélküli.
A paraméteres függvénynek átadunk értékeket, amelyeket a függvényben fel akarunk használni.

**Paraméter és visszatérési érték nélküli függvény**
```C#
 public static void HanyCsillag()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("*");
            }
        }
```

**Paraméteres, visszatérési érték nélküli függvényre példa**

A paraméterek gyakorlatilag változók. Értéküket valamilyen módon felhasználjuk a függvény tevékenységeiben.

```C#
public static void HanyCsillag(int hanycsillag,Boolean melle,string mit)
        {
            for (int i = 0; i < hanycsillag; i++)
            {
                if (melle)
                {
                    Console.Write(mit+" ");
                } else
                {
                    Console.WriteLine(mit);
                }
                
            }
            Console.WriteLine();
        }
```
**Paraméteres visszatérési értékkel rendelkező függvény**

Ezek a függvények kiszámolnak/meghatároznak valamilyen értéket, és ezt visszaadják.
Az ilyen függvényeknek van visszatérési értékük, és szerepelhetnek értékadó utasítások jobb oldalán.

Ez a függvény a paraméterben megkapott egész szám négyzetét adja vissza. A visszaadott érték **int** típusú.

```C#
 public static int Negyzet(int szam)
        {
            return szam * szam;
        }
```


