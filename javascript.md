# Javascript ismeretek

HTML,CSS - leíró nyelvek, a dokumentum szerkezetének, valamint a formázásának leírására használják.

A Javascript egy script nyelv, amely a böngészőkben (és szerver oldalon is) képes futni. Mivel script nyelv, sorról sorra kerülnek az végrehajtásra az utasításai. 
Felhasználási köre rendkívül széles. Alapvetően azért jött létre, hogy bizonyos feladatokat a felhasználói oldalon el lehessen végezni (pl. beviteli mezők ellenőrzése, interaktivitás biztosítása). 

Számos framework (keretrendszer) alapját is képezi , JQuery, Angular JS, Vue JS, Bootstrap...

A Javascript kód helyet kaphat a weboldalon belül a <SCRIPT></SCRIPT> tageken belül, illetve külön fájlokban is.

## Egy alap html oldal forrása:
```HTML
<HTML>
    <HEAD>
        <title>
            Javascript alapok
        </title>
       
    </HEAD>
    <BODY>
        <H1>JS alapok</H1>
       
    </BODY>
</HTML>
```

## A script-tagek elhelyezése a weboldalba
```HTML
<HTML>
    <HEAD>
        <title>
            Javascript alapok
        </title>
       <script>
           document.write("Hell-o");
        </script>
    </HEAD>
    <BODY>
        <H1>JS alapok</H1>
       <script>
           document.write("<H2>Hell-ooo</H2>");
        </script>
    </BODY>
</HTML>
```
## Írás a konzolba js programmal
A Javascript program tud a konzolba is írni, ha arra van szükségünk (hasznos lehet hibakereséskor, vagy változók értékének a követésekor).
```javascript
console.log("Hell-o again");
```
## Változók a JS programban

A js-ben nagyjából ugyanazok a változó típusok használhatóak, mint bármilyen más programban. A változókat a VAR kulcsszó használatával tudjuk létrehozni.
A változó típusok:
 - számok (egész vagy törtszámok, a számrendszer lehet decimális,oktális,hexadecimális)
 - szöveg (literál, vagy objektum)
 - logikai (TRUE,FALSE)
 - felsorolási típus 

### Szám típusok
```javascript
var a=119;
var b=67.89;
```
### Szöveg típus
Két szöveget a + műveleti jellel össze tudunk fűzni.
```javascript
 var szoveg='Valami szöveg';
 var sz2=' és még valami..'
           
 document.writeln(szoveg+sz2);
```           
### Logikai típus
```javascript
var igazsag=true;
```
### Tömbök JS-ben
A tömb alaphelyzetben ugyanúgy működik, mint minden más programozási nyelvben, a tömb elemére az indexével tudunk hivatkozni.
A tömb elemeinek a megjelenítésére a for ciklust használjuk ugyanúgy, mint C#-ban. A tömb elemeinek kezdőértékét a [] zárójelek között adhajtuk meg.
```javascript
<HTML>
    <HEAD>
        <TITLE>Javascript alapok 2
        </TITLE>
        <SCRIPT>
            var szamok=[1,26,78,43,39,51];
            for(i=0;i<szamok.length;i++) {
                document.write(szamok[i]+" ");
            }
            
        </SCRIPT>
    </HEAD>
    <BODY>
        
        
    </BODY>
</HTML>
```
### Nevek megjelenítése listaként,az <UL> és <LI> HTML tagek felhasználásával
```javascript
    var nevek=["Ubul","Huba","Zénó","Elek"];
   
   document.write("<UL>")
   
    for(i=0;i<nevek.length;i++){
                document.write("<LI>"+nevek[i]+"</LI>");            
    }
   
   document.write("</UL>")
```
