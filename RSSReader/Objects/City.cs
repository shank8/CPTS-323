using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
   public  class City
    {

        public City(double longitude = 0, double lattitude = 0, string name = "")
        {
            mName = name;
            mLongitude = longitude;
            mLattitude = lattitude;
        }

        public string mName;
        public double mLongitude;
        public double mLattitude;

    }
}
