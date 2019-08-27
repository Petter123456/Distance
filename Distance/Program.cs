using System;
using System.Collections.Generic;
using System.Linq;

namespace Distance
{
    class Program
    {
        static string[] Places = new string[] { "Stockholm", "Göteborg", "Oslo", "Luleå", "Helsinki", "Berlin", "Paris" };
        static double[] Latitudes = new double[] { 59.3261917, 57.7010496, 59.8939529, 65.5867395, 60.11021, 52.5069312, 48.859 };
        static double[] Longitudes = new double[] { 17.7018773, 11.6136602, 10.6450348, 22.0422998, 24.7385057, 13.1445521, 2.2069765 };

        static void Main(string[] args)
        {
            string[] route = { "Stockholm", "Göteborg", "Oslo", "Luleå", "Helsinki", "Berlin", "Paris" };

            Console.WriteLine($"{CalculateDistance("Stockholm", "Göteborg")} kilometer mellan Stockholm och Göteborg");
            Console.WriteLine($"{CalculateDistance("Göteborg", "Oslo")} kilometer mellan Göteborg och Oslo");
            Console.WriteLine($"{CalculateDistance("Oslo", "Luleå")} kilometer mellan Oslo och Luleå");
            Console.WriteLine($"{CalculateDistance("Luleå", "Helsinki")} kilometer mellan Luleå och Helsinki");
            Console.WriteLine($"{CalculateDistance("Helsinki", "Berlin")} kilometer mellan Helsinki och Berlin");
            Console.WriteLine($"{CalculateDistance("Berlin", "Paris")} kilometer mellan Berlin och Paris");

            Console.WriteLine($"{RouteDistance(route).ToString()} kilometer för hela rutten.");
            Console.ReadKey();
        }

        static double DistanceBetween(double latitude, double longitude, double latitude2, double longitude2)
        {
            ///Math.Pow = is a Math class method. This method is used to calculate a number raise to the power of some other number.
            ///Math.Sin = is an inbuilt Math class method which returns the sine (https://sv.wikipedia.org/wiki/Sinus)of a given double value argument(specified angle)
            ///Math.Cos = is an inbuilt Math class method which returns the cosine(https://sv.wikipedia.org/wiki/Cosinus) of a given double value argument(specified angle).
            ///Mat.Atan2 = Math.Atan2() is an inbuilt Math class method which returns the angle whose tangent is the quotient of two specified numbers. Basically, it returns an angle θ (measured in radian) whose value lies between -π and π.
            ///Math.Sqrt = is used to square root of the number passed as parameter to the function.
            ///https://www.geeksforgeeks.org/
            // https://sv.wikipedia.org/wiki/Storcirkel

            double latitudeRadian = latitude * Math.PI / 180;
            double latitude2Radian = latitude2 * Math.PI / 180;
            double longtidueRadian = longitude * Math.PI / 180;
            double longtidue2Radian = longitude2 * Math.PI / 180;

            double j = Math.Acos(Math.Sin(latitudeRadian) * Math.Sin(latitude2Radian) + Math.Cos(latitudeRadian) * Math.Cos(latitude2Radian) * Math.Cos(longtidue2Radian - longtidueRadian));

            return j * 6378; //jordens radie i KM 
        }


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

        static double RouteDistance(String[] cities)
        {
            double totalDistance = 0;

            for (int i = 1; i < cities.Length; i++)
            {
                totalDistance += CalculateDistance(cities[i - 1], cities[i]);
            }
            return totalDistance;
        }

        static double Haversine(double latitude, double longitude, double latitude2, double longitude2)
        {
            // distance between latitudes and longitudes 
            double dLat = (Math.PI / 180) * (latitude2 - latitude);
            double dLon = (Math.PI / 180) * (longitude2 - longitude);

            // convert to radians 
            latitude = (Math.PI / 180) * (latitude);
            latitude2 = (Math.PI / 180) * (latitude2);

            // apply formulae https://en.wikipedia.org/wiki/Haversine_formula
            double a = Math.Pow(
                            Math.Sin(dLat / 2), 2) +
                            Math.Pow(Math.Sin(dLon / 2), 2) *
                            Math.Cos(latitude) * Math.Cos(latitude2
                            );
            double rad = 6371;
            double c = 2 * Math.Asin(Math.Sqrt(a));
            return rad * c;
        }
    }
}
