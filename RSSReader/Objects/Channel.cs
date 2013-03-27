using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSReader.Objects
{
    public class Channel
    {
        public Channel(string title, string description)
        {
            mTitle = title;
            mDescription = description;

            if (mDescription == "")
                mDescription = "No Description";

            if (mTitle == "")
                mTitle = "No Title";

            mFeeds = new List<Feed>();

        }

        public void _Add ( Feed newFeed )
        {
            mFeeds.Add(newFeed);
        }

        public string mTitle;
        public string mDescription;
        public List<Feed> mFeeds;
    }
}
