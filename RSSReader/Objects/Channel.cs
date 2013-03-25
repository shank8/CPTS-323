using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
    public class Channel
    {
        public Channel()
        {
            Title = "Channel";
            Description = "Description";
            Feeds = new List<Feed>();
        }
        public Channel(String title, String desc)
        {
            this.Title = title;
            this.Description = desc;
            Feeds = new List<Feed>();
        }

        public void Save()
        {
            // This will open up a storage system and save the data
        }
        public void _Add(Feed newfeed)
        {
            this.Feeds.Add(newfeed);
        }


  
        public String Title { get; set; }
        public String Description { get; set; }

     //   public void addFeed(Feed newFeed);
      //  public void removeFeed(Feed remFeed);

        private List<Feed> Feeds;
    }
}
