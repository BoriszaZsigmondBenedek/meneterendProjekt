## 4. Menetrend
Az ország keleti felében évekkel ezelõtt bevezették az ütemes menetrendet. Ez azt jelenti,
hogy a végállomásról minden órában ugyanakkor indulnak a vonatok és menetrend szerint
minden állomásra ugyanakkor érkeznek. A jól tervezhetõ utazás miatt nõtt az utazók száma.
A `adat.json` fájlban rögzítették a Szeged-Budapest vonal néhány vonatának indulási és
érkezési adatait. A fájl soraiban öt, tabulátorral elválasztott érték található, négy egész szám és
egy karakter. Az elsõ szám a vonatazonosító, a második az állomásazonosító, a harmadik és
negyedik egy idõpont órája és perce. A karakter pedig azt jelzi, hogy a vonat az adott állomásra
érkezik (E) vagy éppen indul (I) a megadott idõben.
A sorok száma legfeljebb 1000, a vonatok és az állomások azonosítója pedig egy 0 és 20
közötti egész szám. Az óra értéke 0 és 23, a perc 0 és 59 közötti érték. Az állomások 0-tól
távolság, a vonatok 1-tõl indulási idõ szerint növekvõen sorszámozottak, minden értéket
felvesznek.
A fájl a vonatok tényleges útját rögzíti. Az adatok idõrendben szerepelnek, azon belül pedig
– az induló állomás kivételével – az érkezés mindig megelõzi az indulást. Tudjuk, hogy minden
vonat a 0. állomásról indul, és eléri a végállomást, közben minden állomáson megáll, és egyik
vonat sem elõzi meg a másikat.
Például:
```
2 0 6 45 I
1 4 6 49 E
1 4 6 50 I
2 1 6 58 E
1 5 7 0 E
```
Az elsõ sorból leolvasható, hogy a 2. vonat a kiinduló állomásról 6 óra 45 perckor indul.
A következõ sorban pedig az szerepel, hogy az 1. vonat 6 óra 49 perckor érkezik a 4. állomásra.
Készítsen programot, amely a vonat.txt állomány adatait felhasználva az alábbi
kérdésekre válaszol! A program forráskódját mentse menetrend néven! (A program
megírásakor a felhasználó által megadott adatok helyességét, érvényességét nem kell
ellenõriznie, feltételezheti, hogy a rendelkezésre álló adatok a leírtaknak megfelelnek.)
A képernyõre írást igénylõ részfeladatok eredményének megjelenítése elõtt írja a képernyõre
a feladat sorszámát ``(például: 5. feladat)``! Ha a felhasználótól kér be adatot, jelenítse meg
a képernyõn, hogy milyen értéket vár! Az ékezetmentes kiírás is elfogadott.

### 1. 
Olvassa be és tárolja el a adat.json fájl tartalmát!

### 2. 
Írja a képernyõre a fájlban tárolt vonatok és állomások darabszámát – a kezdõ és végállomást is beleértve!

### 3. 
Határozza meg, hogy melyik állomáson állt legtöbbet vonat! Adja meg a vonat és az állomás azonosítóját, valamint az állás idejét! Ha több ilyen volt, elég csak az egyiket megadnia.

### 4. 
Olvassa be egy vonat azonosítóját, valamint egy idõpont óra és perc értékét! A késõbbi feladatokban használja ezeket!

### 5. 
Ezen a vonalon az elõírt menetidõ 2 óra 22 perc. Írja a képernyõre, hogy a beolvasott
azonosítójú vonat hány perccel tért el ettõl! Például: „A(z) 5. vonat útja 2 perccel rövidebb
volt az elõírtnál.”, „A(z) 5. vonat útja pontosan az elõírt ideig tartott.” vagy „A(z) 5. vonat
útja 3 perccel hosszabb volt az elõírtnál.”
Informatika
emelt szint
1912 gyakorlati vizsga 11 / 12 2020. május 18.
Azonosító
jel:

### 6. 
Írja a haladX.txt fájlba, hogy a beolvasott azonosítójú vonat melyik állomásra mikor
érkezett! A fájlnévben az X helyére a beolvasott vonatazonosító kerüljön!

### 7. 
Adja meg, hogy a beolvasott idõpontban úton lévõ, azaz a már elindult, de a végállomást
még el nem érõ vonatok közül melyik hol tartott! A tesztelés során a következõ idõpontokra
érdemes figyelni: 6:50, 8:45, 9:05, 10:04, 10:20.
Minta a szöveges kimenetek kialakításához:
```
2. feladat
Az állomások száma: 11
A vonatok száma: 12
3. feladat
A(z) 5. vonat a(z) 6. állomáson 10 percet állt.
4. feladat
Adja meg egy vonat azonosítóját! 2
Adjon meg egy idõpontot (óra perc)! 7 16
5. feladat
A(z) 2. vonat útja 2 perccel hosszabb volt az elõírtnál.
7. feladat
A(z) 1. vonat a 6. állomáson állt.
A(z) 2. vonat a 2. és a 3. állomás között járt.
```
### A halad2.txt fájl tartalma:
```
1. állomás: 6:58
2. állomás: 7:11
3. állomás: 7:31
4. állomás: 7:48
5. állomás: 7:59
6. állomás: 8:11
7. állomás: 8:45
8. állomás: 8:51
9. állomás: 9:0
10. állomás: 9:9
```