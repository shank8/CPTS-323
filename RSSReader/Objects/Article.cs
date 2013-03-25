using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
    class Article
    {
        public Article()
        {
            title = "Title";
            link = "Link";
            description = "Description";
        }

        public Article(String title, String link, String desc)
        {
            this.title = title;
            this.link = link;
            this.description = desc;
        }

        

        private String title { get; set; }
        private String link { get; set; }
        private String description { get; set; }

        private String author { get; set; }
        private String category { get; set; }
        private String comments { get; set; }
        private String enclosure { get; set; }
        private String guid { get; set; }
        private String pudDate { get; set; }
        private String source { get; set; }
    }
}
