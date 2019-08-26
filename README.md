# Distance
Labb3 ITHSDistanceCalculation


Lab 3
Ni ska skriva en funktion som räknar ut avståndet mellan två orter. Laborationen ska utföras i grupper om två.
Uppgiften
För att lösa uppgiften behöver ni skriva fler än en funktion.

1 Skriv en funktion som räknar ut avståndet mellan två positioner. En position består av latitud och longitud. Använd datatypen double för att representera latitud och longitud. Funktionen behöver alltså så många parametrar som behövs för att beskriva två positioner och den ska returnera en double.

Longitud och latitude är vinklar, så avståndet ska också bli en vinkel.
Avståndet mellan två positioner p1: (x1 ,y1) och p2: (x2, y2) räknas ut med Pythagoras sats:
distance = Math.sqrt( (x1 - x2)2 + (y1 - y2)2  )

Det går att räkna om vinkeln till meter genom att utgå från att 360 grader motsvarar jordklotets omkrets.

Till er hjälp får ni flera arrayer, som ska placeras ovanför funktionen Main:
static string[] Places = new string[] { "Stockholm", "Göteborg", "Oslo", "Luleå", "Helsinki", "Berlin", "Paris" };
static double[] Latitudes = new double[] { 59.3261917, 57.7010496, 59.8939529, 65.5867395, 60.11021, 52.5069312, 48.859 };
static double[] Longitudes = new double[] { 17.7018773, 11.6136602, 10.6450348, 22.0422998, 24.7385057, 13.1445521, 2.2069765 };
OBS: latitud och longitud var förväxlade i en tidigare version

Använd funktionen Array.indexOf för att hitta vilket index som ett element förekommer på. Exempel:
Array.IndexOf(Places, "Oslo") == 2 

2 Skriv en funktion som räknar ut avståndet mellan två städer. Funktionen ska ta två strängar som parametrar och returnera en double. Använd den första funktionen och de globala arrayvariablerna med platsnamn, latitud och longitud.

3 Skriv en funktion som räknar ut avståndet för en rutt. Funktionen ska ta en array som parameter. Arrayen ska innehålla städer, som ska besökas i den ordning de står. Exempel: för att mäta avståndet på rutten ["Stockholm", "Reykyavik", "Paris"] så blir det avståndet mellan Stockholm och Reykyavik plus avståndet mellan Reykyavik och Paris.

Observera att avstånden ni får kommer att avvika från det rätta svaret, eftersom jordytan är böjd. Gör gärna (frivilligt) en annan version av avståndsfunktionen som använder Haversine och räknar rätt.
Inlämning
Ni ska lämna in en .cs-fil genom att skicka den på slack till Pontus
Högst upp i filen ska det finnas en kommentar med båda namnen på de som gjort labben
Dessut
