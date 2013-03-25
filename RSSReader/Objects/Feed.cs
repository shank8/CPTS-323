using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
    public class Feed
    {
        public Feed()
        {
            Title = "Title";
            Description = "Description";
            Link = "Link";
        }

        public Feed(String title, String desc, String link)
        {
            this.Title = title;
            this.Description = desc;
            this.Link = link;
        }

        public void Save(){
            // Save xml here
        }

      //  public void addArticle(Article newArt);
        //public void remArticle(Article remArt);


        public String Title { get; set; }
  
        public String Description { get; set; }

        public String Link { get; set; }


        private List<Article> artList;
    }
}
