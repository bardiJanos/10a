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
### Undefined
Ha egy változót deklarálunk, de nem adunk neki értéket, akkor a változó értékére hivatkozva **undefined** szöveget kapunk.

```javascript
var nev;
```
A **nev** változó értékére hivatkozva **undefined**-et kapnánk.


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
### Nevek megjelenítése listaként,az UL és LI HTML tagek felhasználásával
```javascript
    var nevek=["Ubul","Huba","Zénó","Elek"];
   
   document.write("<UL>")
   
    for(i=0;i<nevek.length;i++){
                document.write("<LI>"+nevek[i]+"</LI>");            
    }
   
   document.write("</UL>")
```
## ALERT és PROMPT
Az ALERT funkció segítségével szöveges üzenetet tartalmazó ablakot nyithatunk  a böngészőben.

A PROMPT funkció segítségével felhasználói adatot kérhetünk be, amelyet egy változóban eltárolhatunk, később az értékét felhasználhatjuk.

```HTML
<html>
    <head>
        <title>Prompt, alert, függvények</title>
    </head>
    <body>
        <script>
            var nev=prompt("Add meg a nevedet!:");
            alert("A megadott név: "+nev);
            document.write("<H1>Szia "+nev+"</H1>");
        </script>
    </body>

</html>
```

###Számok bekérése prompt-al, konverzió

Ha szám típusú értékeket akarunk bekérni, akkor a művelet elvégzése előtt a számokat a parseInt, vagy a parseFloat függvényekkel
számmá kell alakítani, ellenkező esetben a program összefűzi őket mint string típusú adatokat;

```HTML
 <script>
     var a=prompt("Adj meg egy számot:");
     var b=prompt("Adj meg egy másik számot:");
          
     document.write("<P>"+(parseInt(a)+parseInt(b))+"</P>"); 
            
 </script>
```
## Függvények a JavaScript-ben

Más programnyelvekhez hasonlóan, a JS-ben is használhatunk függvényeket. A függvények lehetnek visszatérési érték nélküliek, vagy visszatérési értékkel rendelkezőek. A visszatérési értékkel rendelkező függvényekben szerepelnie kell a return utasításnak.

```html
<script>
      var a=prompt("Adj meg egy számot:");
      var b=prompt("Adj meg egy másik számot:");
            
      function osszead(a,b)
      {
          return parseInt(a)+parseInt(b);
      }
            
var osszeg=osszead(a,b);
    document.write("<P>"+osszeg+"</P>"); 
</script>
```
A legegyszerűbb függvény így néz ki JS-ben

```html
<script>
    
    function osszead(){
        document.write(10+20);    
    }
    osszead();
</script>
```
Ne feledjük a függvényt nem elég deklarálni, meg is kell hívni, hogy végrehajtódjon (**osszead()**)
Azok a függvények, amelyek rendelkeznek visszatérési értékkel (van benne return) azok állhatnak értékadó kifejezés jobb oldalán. 

Egyszerű példa: km/h-ban megadott sebesség átalakítása m/s-ra. Készítünk egy egyszerű függvényt, amely a paraméterben megadott km/h értéket átszámítja m/s-ra és ezzel visszatér. Az egyszerűség kedvéért az adatbekérést a **prompt**, a kiírást az **alert** funkciókkal valósítjuk meg.

```html
<HTML>
    <HEAD>
        <TITLE>Függvények, függvények mindenütt!
        </TITLE>
        
    </HEAD>
    <BODY>
        <H1>Sebesség átszámítás</H1>
        <SCRIPT>
            function kmh2ms(kmh)
            {
                return kmh/3.6;
            }
            var sebkmh=prompt("A sebesség km/h-ban:");
            alert("A sebesség: "+kmh2ms(sebkmh)+  "m/s");
            
        </SCRIPT>
    </BODY>
</HTML>
```
A JavaScript lehetőséget ad arra is, hogy általános függvényeket írjunk, mint pl. az átlag. Ha általános függvényt írunk, akkor nincs paraméterlista. A paramétereket híváskor ,-vel elválasztva adjuk át a függvénynek. Ebben az esetben az **arguments** tömb tartalmazza az átadott paramétereket innen lehet az értéküket kiolvasni. 

Erre példa a következő:

```HTML
<HTML>
    <HEAD>
        <TITLE>Függvények, függvények mindenütt!
        </TITLE>
        
    </HEAD>
    <BODY>
        <H1>Általános függvények</H1>
        <SCRIPT>
            
                        
            function atlag()
            {
                var osszeg=0;
                for(i=0;i<arguments.length;i++){
                    osszeg=osszeg+arguments[i];
                }
                return osszeg/arguments.length;
            }
            
            document.writeln(atlag(10,20,30));
            document.writeln(atlag(20,40));
            document.writeln(atlag(40,58,79,86,113,221));
            
        </SCRIPT>
    </BODY>
</HTML>
```
# A DOM (Document Object Model)
(2020.04.06)

A DOM egy nyelv és platformfüggetlen objektummodell, amely többek között a HTML, XHTML, XML és velük rokon nyelvek szerkezetét, és az objektumaikkal kapcsolatos műveleteket, interakciókat modellezi. A DOM egymással szülő-gyerek kapcsolatban álló objektumok rendszere. A dokumentum valamennyi összetevőjét, valamint tartalmát magában foglalja.

## Nézzünk egy egyszerű weboldalt

```html
<html>
	<head>
	        <title>
	            Document Object Model(DOM)
	        </title>
	    </head>
	    <body>
	        <H1>Document Object Model</H1>
	        <P id="bekezdes">Bekezdés</P>
	        <UL>
	            <LI>1</LI>
	            <LI>2</LI>
	            <LI>3</LI>
	            <LI>4</LI>
	            <LI>5</LI>
	        </UL>
	        	    
	    </body>
	
</html>
```
Belátható, hogy ha ez a fájl mondjuk ***lista.html*** néven van valahol elmentve fájlként, akkor ezt a fájlt felfoghatjuk a **document**-nek. A **\<HTML>..\</HTML>** elem szülő lesz, hiszen az összes többi elemet ez tartalmazza. 
A **\<HEAD>..\</HEAD>** elem egyrészt gyerek elem lesz, hiszen ez  a **\<HTML>** elem gyereke, viszont a **\<TITLE>** szempontjából szülő elem. A **\<BODY>** elem a **\<HTML>** elem gyereke, viszont pl. szülője a **\<H1>** elemnek.

Az egyes elemeknek lehetnek tulajdonságaik, más néven attribútumaik. Ismerjük az **\<IMG>** elemet, amely kép beszúrására szolgál. 
Például:
```HTML
<IMG SRC="light.jpg">
```
Az **SRC** az **\<IMG>** elem paramétere, és megadja a megjelenítendő kép elérési útját.

A JavaScript nyelv segítségével ezt a DOM modellt manipulálhatjuk. Lekérdezhetünk elemeket, megváltoztathatjuk a paramétereiket, tartalmukat. Hozzáadhatunk új elemeket, törölhetünk elemeket.

## Elemek elérése

Alapvetően három módon érhetünk el elemeket:
 - id alapján a **document.getElementById(id)** utasítással.
 - Az elem neve alapján a **document.getElementsByTagName(nev)**
 - Stílusa alapján a **document.getElementsByClassName(class)**; 

Az elemekről megállapíthatóak hogy mely elemeknek a szülöi, gyermekei, vannak-e gyerek elemeik stb.

 - **element.childNodes** az elem gyerek elemeit adja vissza egy tömbben
 - **element.firstChild** az első gyerek elemet adja vissza
 - **element.lastChild** az utolsó gyerek elemet adja vissza
 - **element.hasChildNodes** logikai értéket ad vissza, ha van gyereke az elemnek, akkor TRUE
 - **element.nextSibling** a következő elem ugyanazon a szinten, pl. a következő listaelem
 - **element.previousSibling** az előző elem ugyanazon a szinten
 - **element.parentNode** a szülő elemet adja vissza
 
 
## Elemek elérése, módosítása

Először nézzük az elérést id alapján. A HTML szabályai szerint az id egy egyedi azonosító, és nincs a dokumentumban két egyforma id, ezért az id mindig ***egy*** adott elemet jelent. A példában van egy \<P> elem (ami egy szöveges bekezdés), ehhez tartozik egy id, aminek értéke **"bekezdes"**.

### Készítsünk egy scriptet, ami eléri és módosítja ennek a bekezdésnek a tartalmát:

```HTML
<SCRIPT>
	var szoveg=document.getElementById("bekezdes");	            
	szoveg.innerHTML="DOM";
</SCRIPT>
```
Látható, hogy az elem a **szoveg** nevű változóba kerül, majd az **innerHTML** tulajdonság értékét módosítjuk (azaz a kiválasztott elem tartalmát).

### Elérés az elem neve alapján

Nézzük meg, hogy a Címsor1 elem tartalmát hogyan lehetne elérni. Itt nincsen Id, tehát Id alapján nem tudjuk elérni, csak az elem neve (**H1**) alapján. Az előző példát folytatva: 

```HTML
<<SCRIPT>
	var szoveg=document.getElementById("bekezdes");	            
	szoveg.innerHTML="DOM";
	
	var cimsor=document.getElementsByTagName("H1");
	cimsor[0].innerHTML="DOM";	
</SCRIPT>
```
Itt eredményként egy tömböt kapunk vissza. A **cimsor** nevű változó tehát most egy olyan tömb amelynek 1 eleme van. 

Mi a helyzet, ha több elem van? Nézzük a lista elemeit. Ezek most számok 1-től 5-ig. Szorozzuk meg a lista elemeit 2-vel!

```HTML
<<SCRIPT>
        var szoveg=document.getElementById("bekezdes");             
        szoveg.innerHTML="DOM";        

        var cimsor=document.getElementsByTagName("H1");
        cimsor[0].innerHTML="DOM";      

	 var elemek=document.getElementsByTagName("LI");

	 for(i=0;i<elemek.length;i++){
	         elemek[i].innerHTML=parseInt(elemek[i].innerHTML)*2;               
	 }


</SCRIPT>
```
Itt is egy tömböt kapunk az elemek változóban. Ezen kell végig menni a for ciklussal. Az elemeket számként értelmezzük a parseInt paranccsal, így a művelet a kívánt eredményt fogja adni.

## Elemek létrehozása,törlése (2020.04.20.)

Bármikor tudunk a Javascriptben új elemeket létrehozni, erre a **document.createElement()**  parancs szolgál. A zárójelek közé azt az elemet kell beírnunk, amilyet létre akarunk hozni.
Például: 
```js
var bekezdes=document.createElement("p");
```
A fenti parancs egy bekezdést **\<P>..\</P>** fog létrehozni.
Az új elemnek adhatunk valami tartalmat, mondjuk egy szöveget:
```js
bekezdes.innerHTML="Ez egy bekezdés";
```
Az elem egyenlőre nem jelenik meg a weboldalban, hiszen nincs hozzárendelve egyenlőre a weboldal egyik eleméhez sem. 

Tegyük fel, hogy a weboldalban létezik a következő elem:
```html
<DIV id=szovegek>
</DIV>
```
Ezt az elemet el tudjuk érni, és hozzá tudjuk adni az előbb létrehozott elemet:
```js
var szovegek=document.getElementById("szovegek");
szovegek.appentChild(bekezdes);
```
A **\<DIV>** elem most így néz ki:

```html
<DIV id=szovegek>
	<P>Ez egy bekezdés</P>
</DIV>
```

Látható, hogy a \<P> a \<DIV> gyerek eleme. A \<P> szempontjából a \<DIV> szülő elem.

Ha el akarjuk távolítani az előbb hozzáadott elemet akkor az a következő módon lehetséges:
```js
szovegek.removeChild(bekezdes);
```

### Példa

Adott egy HTML fájl részlete:

```html
<DIV id=adatok>
	<P id=elso>Első adat</P>
	<P id=masodik>Második adat</P>
</DIV>	
```
Adjunk hozzá egy harmadik bekezdést, majd töröljük az elsőt!

A \<script>..\</script> tag-be a következő utasítások kerülnének:

```js
var adatok=document.getElementById("adatok");
var elso=document.getElementById("elso");
var harmadik=document.createElement("p");
harmadik.innerHTML="Harmadik bekezdés";
adatok.removeChild(elso);
adatok.appendChild(harmadik);
```
**Az eredmény:**

```HTML
<DIV id=adatok>
        <P id=masodik>Második adat</P>
	<P>Harmadik bekezdés</P>
</DIV>  
```
## Az elemek paraméterei (attribútumai). Elérésük, módosításuk (2020.04.27)

A HTML elemek számos paramétert tartalmazhatnak, melyek elérhetőek manipulálhatóak Javascript-ből is természetesen.

Nézzük a következő HTML dokumentumot:
```HTML
<HTML>
    <HEAD>
        <meta lang="hu" charset="utf-8">
        <TITLE>Attribútumok
        </TITLE>
       
    </HEAD>
    <BODY>
    <H1 id="nev">Attribútumok</H1>
	    
        <img id="kep" src="tesztkerdesek.png" width="120" height="120">         
	    
	    
        <script>
        </script
    </BODY>
</HTML>

```
A \<H1> elemben egyetlen paramétert láthatunk, aminek a neve **id**, az értéke(**value**) ***nev***

A címsor 1 alatt egy kép van beszúrva, ennél az elemnél 4db paramétert számolhatunk össze, ezek: **id,src,width,height**

**Hogyan lehet ezeket az attribútumokat JS programból elérni, módosítani?**

A \<SCRIPT> elembe a következőket írjuk:

```js
var kep=document.getElementById("kep");    
```
Ezzel a kep változóba került a kep id-val megjelölt elem bekerül.

Hogyan tudjuk megmondani, hogy hány db attribútuma van az elemnek?

```js
var attribs=document.getElementById("kep").attributes.length;
Console.log(attribs);
```
A konzolt megnyitva láthatjuk, hogy az érték 4

**Hogyan tudjuk elérni az egyes attribútumokat?**

Az attribútumokat a megadás sorrendjáben lehet elérni, a számozás természetesen 0-val indul. 
Írassuk konzolra az első elem nevét, és értékét!

```js
console.log(kep.attributes[0].name);
console.log(kep.attributes[0].value);
```
Az attribútumok elérhetőek közvetlenebb módon is (a nevük alapján).

```js
console.log(kep.src);
```

Az attribútumok értéke módosítható is

```js
kep.width=240;
kep.heidht=240;
```
Az attribútumok manipulálásával sok mindent lehet kezdeni. Kicserélhetjük a képet, megváltoztathatjuk a szélességét, magasságát, egy elem stílusát megváltoztathatjuk, stb.

## Mintafeladat elemek elérésére, attribútumok módosítására (2020.05.04.)

A feladathoz való képek : [kapcsolo_be](kapcsolo_be.png), [kapcsolo_ki](kapcsolo_ki.png), [izzo_be](bulb_on.png), [izzo_ki](bulb_off.png)

A korábbi alkalommal is láttunk példát HTML elemek elérésére és módosítására. Nem csak az elem tartalma, hanem az elem paraméterei is elérhetőek, módosíthatóak.

Ebben a feladatban 4 db képfájl segítségével kell megvalósítani egy olyan weboldalt, ahol egy kapcsoló segítégével tudunk egy égőt ki és bekapcsolni.

Az egyes állapotok megjelenítésére képfájlokat használunk (kapcsolo_be.png,kapcsolo_ki.png,bulb_on.png,bulb_off.png)

A feladatot egy JavaScript függvény segítségével fogjuk megoldani.

Először a html fájlt kell elkészíteni a neve legyen **lampa.html**. Egy táblázatba kerül a két kép, egymás alá, középre igazítva.

Tartalma a következő legyen:

```HTML
<HTML>

<head>
    <title>
        Light feladat
    </title>
</head>

<Body>
    <table align=center>
        <tr>
            <td align=center><img id="bulb" src="bulb_off.png"></td>
        </tr>
        <tr>
            <td align=center>
                <img id="kapcsolo" src="kapcsolo_ki.png" >
            </td>
        </tr>

    </table>
       
        
    
</Body>

</HTML>
```

A **</TABLE>** alá kerüljön a <SCRIPT></SCRIPT> elem, ebbe kerül a JS függvény.

```HTML
<SCRIPT>
    function kapcsol(){
    
    
    }

</SCRIPT>    
```

Minden további utasítás a függvényen belülre kell hogy kerüljön!

Először meg kell szereznünk azt az információt, hogy jelenleg melyik kép van betöltve. Az egyes képekhez id van rendelve, az égő képét tartalmazó <IMG> elemnél "bulb", a kapcsolónál pedig "kapcsolo" az id értéke.
    
A **bulb** változóba beolvassuk a "bulb azonosítójú elemet".

```Javascript
var bulb=document.getElementById("bulb");
```
A **kapcsolo** változóba pedig a "kapcsolo" azonosítójú elemet.

```Javascript
var kapcsolo=document.getElementById("kapcsolo");
```
Ezeknél a változókon belül az src tartalmazza a kép elérési útvonalát (pl. bulb.src). Ügyelni kell arra, hogy annak ellenére, hogy a weboldalban realtív megadással van megadva a kép elérési útja, a változóban teljes elérési utat kapunk, meghajtóval, mappanevekkel, viszont nekünk csak a fájlnév kell.

Mi a megoldás? Kezeket fel!

Igen, a "/" karakterek mentén felvágjuk az elérési utat, ennek eredménye egy tömb, és csak az utolsó elemet használjuk majd fel összehasonlításra. Ezeket eltároljuk külön változókba:

```javascript
var bulb_src=bulb.src.split("/");
bulb_src=bulb_src[bulb_src.length-1];

 var kapcsolo_src=kapcsolo.src.split("/");
 kapcsolo_src=kapcsolo_src[kapcsolo_src.length-1];

```

Már csak egy elágazásra van szükség a be ill. a kikapcsolt állapot megkülönböztetésére. Ha a kikapcsolt állapot az aktuális, akkor betöltjük a bekapcsolt állapotot jelentő képeket az égőhöz illetve a kapcsolóhoz, és fordítva (az egyes <IMG> elemek src paraméterét változtatjuk gyakorlatilag).

```javascript
 if(bulb_src=="bulb_off.png"){
            
     bulb.src="bulb_on.png";
     kapcsolo.src="kapcsolo_be.png";
           
} 
else {
            
      bulb.src="bulb_off.png";
      kapcsolo.src="kapcsolo_ki.png";
      
}
```

A függvény kész mást nem kell írni bele, azonban ahhoz hogy működjön a kapcsolót megjelenítő <IMG> elem onclick eseményéhez hozzá is kell rendelni az alábbi módon.
    
```HTML
<img id="kapcsolo" src="kapcsolo_ki.png" onclick="kapcsol()">
```

Készen is van.
