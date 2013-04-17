using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSReader.Objects;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using LoadHandler;
using SaveHandler;

namespace RSSReader
{
    public partial class addChannel : Form
    {
        public addChannel(TreeView tree, List<Channel> channels)
        {

            InitializeComponent();
            this.channels = channels;
            this.treeView = tree;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            // I want to access the channelTree treeView here
            channel = new Channel(this.channelTitle.Text, this.channelDesc.Text);

            // Save the info to an XML doc
           // channel.Save();


            channels.Add(channel);

            // Now add it to the tree view
            treeView.Nodes.Add(channel.mTitle);

            SaveXML newXMLSave = new SaveXML();
            newXMLSave.toXMLDoc(channels);

            this.Close();
        }

        private Channel channel;
        private List<Channel> channels;
        private TreeView treeView;
   
    }
}
