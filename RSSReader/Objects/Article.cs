using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace RSSReader.Objects
{
    public class Article
    {
        public Article()
        {
            mTitle = "";
            mLink = "";
            mDescription = "";
            mCity = null;
        }

        public void Clean()
        {
            string pattern = "(\\<(/?[^\\>]+)\\>)";
            string replace = "";

            Regex rgx = new Regex(pattern);
            mDescription = rgx.Replace(mDescription, replace);
            Console.WriteLine("Description is " + mDescription);
            

        }

        public bool isIncomplete()
        {
               if(( mTitle == "" ) || (mLink == "" ) || (mDescription == "" ) || ( mCity == null ) )
                   return true;

               return false;
        }

        public string mTitle { get; set; }
        public string mLink { get; set; }
        public string mDescription { get; set; }
        public System.DateTimeOffset mPubDate { get; set; }
        public City mCity { get; set; }


    }
}
