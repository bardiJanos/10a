# String-ek

Karakterek tárolására szolgáló adattípus.

**Deklaráció**
```c#
String szoveg="Minta szöveg";
var masikSzoveg="Másik minta szöveg";
```
A String típus karaktereire egyenként is lehet hivatkozni.

pl. a **szoveg** változó első karakterének kiíratása:

```C#
Console.WriteLine(szoveg[0]);
```
**Műveletek string változókkal:**

 - Milyen hosszú a string?

 ```c#
 Console.WriteLine(szoveg.Length);
 ```
 - kisbetűsre alakítás
 ```c#
 Console.WriteLine(szoveg.ToLower());
 ```
  - nagybetűsre alakítás
 ```c#
 Console.WriteLine(szoveg.ToUpper());
 ```
**Szövegek összehasonlítása**

**Szöveg rész szövege**
```c#
Console.WriteLine(szoveg.Substring(2,6));
```

**Karakterek cseréje**
  ```c#
  Console.WriteLine(szoveg.Replace('m','n'));
  ```

**Szóközök eltüntetése**
```c#
Console.WriteLine(szoveg.Replace(" ", ""));
```
