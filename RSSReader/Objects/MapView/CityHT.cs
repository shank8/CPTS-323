using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;


using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;




namespace RSSReader
{
    class CityHT
    {
        public CityHT()
        {
            mCities = new Hashtable();
        }


        public void FileParse(StreamReader reader)
        {
            string line;
            int i = 0;

            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split('\t');

                if (( words.Length >= 11) && (words[7].Length > 4) && (words[8].Length > 4) )
                {
                    words[7] = words[7].Remove((words[7].Count() - 2)); //Lattitude: get rid of the Degree character and Direction Character
                    words[8] = words[8].Remove((words[8].Count() - 2)); //Longitude: get rid of the Degree character and Direction Character  
                    City newCity = new City(Convert.ToDouble(words[8]), Convert.ToDouble(words[7]), words[1]);
                  
                    if (!mCities.Contains(newCity.mName))
                        mCities.Add(newCity.mName, newCity);

                  //  MessageBox.Show("Added: " + newCity.mName + "\nLattitude: " + newCity.mLattitude + "\nLongitude: " + newCity.mLongitude);
                }              
            }
        }

        public City getCity(String ArticleTitle)
        {
            string[] words = ArticleTitle.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (mCities.Contains(words[i]))
                {
                    return (City)mCities[words[i]];
                }
            }

            return null;
        }

        public Hashtable mCities;
    }
}
