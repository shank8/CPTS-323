using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace RSSReader
{
    public class City
    {
       
        public City( double longitude = 0, double latitude = 0, string name = "")
        {
            mName = name;
            mLongitude = longitude;
            mLatitude = latitude;
        }
           
        public string mName;
        public double mLongitude; 
        public double mLatitude; 
        
    }
}
