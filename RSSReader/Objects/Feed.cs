using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;
using System.IO;
using System.ServiceModel.Syndication;
using System.Data;

namespace RSSReader.Objects
{
    public class Feed
    {
       public Feed( String title, String description, String url)
        {
            mURL = url;
            mTitle = title;
            mDescription = description;
        }


        public void refresh(int numArticles)
        {
            mArticles = new List<Article>();

            var reader = XmlReader.Create(mURL);

            var feed = SyndicationFeed.Load(reader);

            //Loop through all items in the SyndicationFeed
            foreach (var i in feed.Items)
            {
                Article new_article = new Article();
                new_article.mTitle = i.Title.Text;
                new_article.mTitle = i.Summary.Text;
                new_article.mPubDate = i.PublishDate;
                new_article.mDescription = i.Summary.Text;
                new_article.mLink = i.Id;
                mArticles.Add(new_article);

                if (mArticles.Count() >= (numArticles))
                    return;
            }
        }


        public string mTitle;
        public string mURL;
        public string mDescription;
        public List<Article> mArticles;
    }
}
