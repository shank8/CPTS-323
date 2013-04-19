using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


///     THIS IS RYANS

namespace RSSReader.Objects
{
    public class Article
    {
        public Article(string title, string desc, System.DateTimeOffset pubDate, string link)
        {
            mTitle = title;
            mLink = link;
            mDescription = desc;
            mPubDate = pubDate;
        }

        public void Clean()
        {
            string pattern = "(\\<(/?[^\\>]+)\\>)";
            string replace = "";

            Regex rgx = new Regex(pattern);
            mDescription = rgx.Replace(mDescription, replace);
     
            

        }

        public bool isIncomplete()
        {
               if(( mTitle == "" ) || (mLink == "" ) || (mDescription == "" ) )
                   return true;

               return false;
        }

        public string mTitle { get; set; }
        public string mLink { get; set; }
        public string mDescription { get; set; }
        public System.DateTimeOffset mPubDate { get; set; }


    }
}
