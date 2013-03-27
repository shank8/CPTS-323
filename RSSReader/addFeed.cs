using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSReader.Objects;

namespace RSSReader
{
    public partial class addFeed : Form
    {
        public addFeed(TreeNode cur, TreeView tree, List<Channel> channels)
        {
            InitializeComponent();
            this.selected = cur;
            this.treeView = tree;
            this.channels = channels;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            feed = new Feed(this.feedTitle.Text, this.feedDesc.Text, this.feedUrl.Text);
            //feed = new Feed();
            feed.mTitle = this.feedTitle.Text;


            // Save feed to xml
            //feed.Save();

            // Add the feed to the correct channel
            foreach (Channel c in channels)
            {
                if (c.mTitle == selected.Text)
                {
                    c._Add(feed);
                }
            }

            // Add feed to current channel
            selected.Nodes.Add(feed.mTitle);

            this.Close();

        }

        private TreeNode selected;
        private Feed feed;
        private TreeView treeView;
        List<Channel> channels;
    }
}
