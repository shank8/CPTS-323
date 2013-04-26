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

       public void Filter(int filterType)
       {
           if (filterType == 1) // by name
           {
               mArticles.Sort(delegate(Article c1, Article c2) { return c1.mTitle.CompareTo(c2.mTitle); });
           }
           else
           {
               mArticles.Sort(delegate(Article c1, Article c2) { return c1.mPubDate.CompareTo(c2.mPubDate); });
           }
       }
        public void refresh(int numArticles)
        {
            mArticles = new List<Article>();

            if( mURL == "" )
            {
               mURL = "http://rss.cnn.com/rss/cnn_topstories.rss";
            }

            var reader = XmlReader.Create(mURL);
         

            var feed = SyndicationFeed.Load(reader);

            //Loop through all items in the SyndicationFeed
            foreach (var i in feed.Items)
            {
                Article new_article = new Article("", "", DateTime.Today, "");
                if (i.Title.Text != null)
                    new_article.mTitle = i.Title.Text;
                if (i.PublishDate != null)
                    new_article.mPubDate = i.PublishDate;
                if (i.Summary != null)
                    new_article.mDescription = i.Summary.Text;
                if (i.Links[0].Uri.ToString() != null)
                    new_article.mLink = i.Links[0].Uri.ToString();
             
           
                new_article.Clean();
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
