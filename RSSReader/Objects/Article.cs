using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
    public class Article
    {
        public Article() { }


        public string mTitle { get; set; }
        public string mLink { get; set; }
        public string mDescription { get; set; }
        public System.DateTimeOffset mPubDate { get; set; }
        public City mCity { get; set; }


    }
}
