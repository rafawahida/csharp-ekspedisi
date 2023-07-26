using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_kel8
{
    public class CalculateDistancee
    {
        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double earthRadius = 6371; // Earth's radius in kilometers

            double latDiff = DegreesToRadians(lat2 - lat1);
            double lonDiff = DegreesToRadians(lon2 - lon1);

            double a = Math.Sin(latDiff / 2) * Math.Sin(latDiff / 2) +
                       Math.Cos(DegreesToRadians(lat1)) * Math.Cos(DegreesToRadians(lat2)) *
                       Math.Sin(lonDiff / 2) * Math.Sin(lonDiff / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = earthRadius * c;

            // Bulatkan jarak menjadi dua desimal
            distance = Math.Round(distance, 2);

            return distance;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

    }
}

