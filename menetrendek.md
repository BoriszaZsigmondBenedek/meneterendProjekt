## 4. Menetrend
Az orsz�g keleti fel�ben �vekkel ezel�tt bevezett�k az �temes menetrendet. Ez azt jelenti,
hogy a v�g�llom�sr�l minden �r�ban ugyanakkor indulnak a vonatok �s menetrend szerint
minden �llom�sra ugyanakkor �rkeznek. A j�l tervezhet� utaz�s miatt n�tt az utaz�k sz�ma.
A `adat.json` f�jlban r�gz�tett�k a Szeged-Budapest vonal n�h�ny vonat�nak indul�si �s
�rkez�si adatait. A f�jl soraiban �t, tabul�torral elv�lasztott �rt�k tal�lhat�, n�gy eg�sz sz�m �s
egy karakter. Az els� sz�m a vonatazonos�t�, a m�sodik az �llom�sazonos�t�, a harmadik �s
negyedik egy id�pont �r�ja �s perce. A karakter pedig azt jelzi, hogy a vonat az adott �llom�sra
�rkezik (E) vagy �ppen indul (I) a megadott id�ben.
A sorok sz�ma legfeljebb 1000, a vonatok �s az �llom�sok azonos�t�ja pedig egy 0 �s 20
k�z�tti eg�sz sz�m. Az �ra �rt�ke 0 �s 23, a perc 0 �s 59 k�z�tti �rt�k. Az �llom�sok 0-t�l
t�vols�g, a vonatok 1-t�l indul�si id� szerint n�vekv�en sorsz�mozottak, minden �rt�ket
felvesznek.
A f�jl a vonatok t�nyleges �tj�t r�gz�ti. Az adatok id�rendben szerepelnek, azon bel�l pedig
� az indul� �llom�s kiv�tel�vel � az �rkez�s mindig megel�zi az indul�st. Tudjuk, hogy minden
vonat a 0. �llom�sr�l indul, �s el�ri a v�g�llom�st, k�zben minden �llom�son meg�ll, �s egyik
vonat sem el�zi meg a m�sikat.
P�ld�ul:
```
2 0 6 45 I
1 4 6 49 E
1 4 6 50 I
2 1 6 58 E
1 5 7 0 E
```
Az els� sorb�l leolvashat�, hogy a 2. vonat a kiindul� �llom�sr�l 6 �ra 45 perckor indul.
A k�vetkez� sorban pedig az szerepel, hogy az 1. vonat 6 �ra 49 perckor �rkezik a 4. �llom�sra.
K�sz�tsen programot, amely a vonat.txt �llom�ny adatait felhaszn�lva az al�bbi
k�rd�sekre v�laszol! A program forr�sk�dj�t mentse menetrend n�ven! (A program
meg�r�sakor a felhaszn�l� �ltal megadott adatok helyess�g�t, �rv�nyess�g�t nem kell
ellen�riznie, felt�telezheti, hogy a rendelkez�sre �ll� adatok a le�rtaknak megfelelnek.)
A k�perny�re �r�st ig�nyl� r�szfeladatok eredm�ny�nek megjelen�t�se el�tt �rja a k�perny�re
a feladat sorsz�m�t ``(p�ld�ul: 5. feladat)``! Ha a felhaszn�l�t�l k�r be adatot, jelen�tse meg
a k�perny�n, hogy milyen �rt�ket v�r! Az �kezetmentes ki�r�s is elfogadott.

### 1. 
Olvassa be �s t�rolja el a adat.json f�jl tartalm�t!

### 2. 
�rja a k�perny�re a f�jlban t�rolt vonatok �s �llom�sok darabsz�m�t � a kezd� �s v�g�llom�st is bele�rtve!

### 3. 
Hat�rozza meg, hogy melyik �llom�son �llt legt�bbet vonat! Adja meg a vonat �s az �llom�s azonos�t�j�t, valamint az �ll�s idej�t! Ha t�bb ilyen volt, el�g csak az egyiket megadnia.

### 4. 
Olvassa be egy vonat azonos�t�j�t, valamint egy id�pont �ra �s perc �rt�k�t! A k�s�bbi feladatokban haszn�lja ezeket!

### 5. 
Ezen a vonalon az el��rt menetid� 2 �ra 22 perc. �rja a k�perny�re, hogy a beolvasott
azonos�t�j� vonat h�ny perccel t�rt el ett�l! P�ld�ul: �A(z) 5. vonat �tja 2 perccel r�videbb
volt az el��rtn�l.�, �A(z) 5. vonat �tja pontosan az el��rt ideig tartott.� vagy �A(z) 5. vonat
�tja 3 perccel hosszabb volt az el��rtn�l.�
Informatika
emelt szint
1912 gyakorlati vizsga 11 / 12 2020. m�jus 18.
Azonos�t�
jel:

### 6. 
�rja a haladX.txt f�jlba, hogy a beolvasott azonos�t�j� vonat melyik �llom�sra mikor
�rkezett! A f�jln�vben az X hely�re a beolvasott vonatazonos�t� ker�lj�n!

### 7. 
Adja meg, hogy a beolvasott id�pontban �ton l�v�, azaz a m�r elindult, de a v�g�llom�st
m�g el nem �r� vonatok k�z�l melyik hol tartott! A tesztel�s sor�n a k�vetkez� id�pontokra
�rdemes figyelni: 6:50, 8:45, 9:05, 10:04, 10:20.
Minta a sz�veges kimenetek kialak�t�s�hoz:
```
2. feladat
Az �llom�sok sz�ma: 11
A vonatok sz�ma: 12
3. feladat
A(z) 5. vonat a(z) 6. �llom�son 10 percet �llt.
4. feladat
Adja meg egy vonat azonos�t�j�t! 2
Adjon meg egy id�pontot (�ra perc)! 7 16
5. feladat
A(z) 2. vonat �tja 2 perccel hosszabb volt az el��rtn�l.
7. feladat
A(z) 1. vonat a 6. �llom�son �llt.
A(z) 2. vonat a 2. �s a 3. �llom�s k�z�tt j�rt.
```
### A halad2.txt f�jl tartalma:
```
1. �llom�s: 6:58
2. �llom�s: 7:11
3. �llom�s: 7:31
4. �llom�s: 7:48
5. �llom�s: 7:59
6. �llom�s: 8:11
7. �llom�s: 8:45
8. �llom�s: 8:51
9. �llom�s: 9:0
10. �llom�s: 9:9
```