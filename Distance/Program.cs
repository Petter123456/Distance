using System;

namespace Distance
{
    class Program
    {
        static string[] Places = new string[] { "Stockholm", "Göteborg", "Oslo", "Luleå", "Helsinki", "Berlin", "Paris" };
        static double[] Latitudes = new double[] { 59.3261917, 57.7010496, 59.8939529, 65.5867395, 60.11021, 52.5069312, 48.859 };
        static double[] Longitudes = new double[] { 17.7018773, 11.6136602, 10.6450348, 22.0422998, 24.7385057, 13.1445521, 2.2069765 };


        static void Main(string[] args)
        {
            //Console.WriteLine(CalculateDistance("Stockholm", "Göteborg"));

            string[] theArray = { "Stockholm", "Göteborg"};

            Console.WriteLine(RouteDistance(theArray));
            Console.ReadKey();

        }

        static double DistanceBetween(double latitude, double longitude, double latitude2, double longitude2)
        {
            /////hwww.it-swarm.net/sv/android/berakna-avstandet-mellan-tva-geografiska-platser/941767008/
            double radian = Math.PI / 180;

            double dlong = (longitude - longitude2) * radian;
            double dlat = (latitude - latitude2) * radian;
            double a = Math.Pow(Math.Sin(dlat / 2.0), 2) + Math.Cos(latitude2 * radian)* Math.Cos(latitude * radian) * Math.Pow(Math.Sin(dlong / 2.0), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double d = 6367 * c;
            return d;
        }

        //2 Skriv en funktion som räknar ut avståndet mellan två städer.Funktionen ska ta två strängar som parametrar och returnera en double. 
        //Använd den första funktionen och de globala arrayvariablerna med platsnamn, latitud och longitud..

        static double CalculateDistance(string city1, string city2)
        {
            double city1Long = 0;
            double city1Lat = 0;
            double city2Long = 0;
            double city2Lat = 0;



            for (int i = 0; i < Places.Length; i++)
            {
                if(Places[i] == city1)
                {
                    city1Lat = Latitudes[i];
                    city1Long = Longitudes[i];
                }
                else if (Places[i] == city2)
                {
                    city2Lat = Latitudes[i];
                    city2Long = Longitudes[i];
                }
            };

            return DistanceBetween(city1Lat, city1Long, city2Lat, city2Long);
        }

        //3 Skriv en funktion som räknar ut avståndet för en rutt.Funktionen ska ta en array som parameter. Arrayen ska innehålla städer, som ska besökas i den ordning de står. 
        //Exempel: för att mäta avståndet på rutten ["Stockholm", "Reykyavik", "Paris"] så blir det avståndet mellan Stockholm och Reykyavik plus avståndet mellan Reykyavik och Paris.
        //Observera att avstånden ni får kommer att avvika från det rätta svaret, eftersom jordytan är böjd. 
        //Gör gärna (frivilligt) en annan version av avståndsfunktionen som använder Haversine och räknar rätt
        static string RouteDistance(string[] cities){

            var x = "";

            for (int i = 0; i < cities.Length; i++)
            {
                x = cities[i];
                Console.WriteLine(cities[i]);
            }
            

            return x; 

            
        }
      

    }
}
