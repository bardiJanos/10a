# Lottójáték készítése

Minden lottójátékban meg kell adni adott számú tippet.
Minden lottójátékban megadott számok közül sorsolnak a tippek számával megegyező számú nyerőszámot.

A tippek és a nyerőszámok összehasonlítása alapján lehet meghatározni a találatokat.

**Fontosabb feladatok:**

**adatszerkezetek meghatározása**

tömbök: tippek, nyeroszamok 

elemszámukat a program futásakor határozzuk meg!

**szükséges változók** 

-  hány tippel játszunk
-  hány számból húzunk 
-  találatok száma

**1. lépés**

A tippek számának,és a számtérnek a meghatározása.

**2.lépés**

A tippek bekérése

A tippnek a következőknek kell megfelelnie:
- legyen a megadott határok (1..szamTer) között
- a tippeknek egyedinek kell lennie (ha már szerepel a tippek között, újra be kell kérni)
- addig kell a bekérést folytatni, amíg minden tipp egyedi nem lesz.

**3.lépés**

Tippek listázása

**4.lépés**
Nyerőszámok sorsolása
-hasonlít a tippeléshez, de itt csak arra kell figyelni, hogy
egy már kisorsolt számot ne tegyünk ismét a nyerőszámok közé

**5.lépés**
Nyerőszámok listázása

**6.lépés**
Találatok meghatározása

Módosítsa a programot úgy, hogy a tippek bekérése
után adott számú találatig fusson!








