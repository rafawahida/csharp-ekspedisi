using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_kel8
{
    public class Point
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string IDgudang { get; set; }

        public Point(string name, double latitude, double longitude, string iDgudang)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            IDgudang = iDgudang;
        }

    }
}
