namespace RSSReader
{
    partial class ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.channelTree = new System.Windows.Forms.TreeView();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.addBtn = new System.Windows.Forms.Button();
            this.remBtn = new System.Windows.Forms.Button();
            this.ArticleTreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every5MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every10MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.every15MinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.everyHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // channelTree
            // 
            this.channelTree.Location = new System.Drawing.Point(16, 113);
            this.channelTree.Margin = new System.Windows.Forms.Padding(4);
            this.channelTree.Name = "channelTree";
            this.channelTree.Size = new System.Drawing.Size(332, 511);
            this.channelTree.TabIndex = 0;
            this.channelTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.channelTree_AfterSelect);
            this.channelTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.channelTree_NodeMouseDoubleClick);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(357, 191);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(907, 434);
            this.webBrowser.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(16, 47);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 46);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Channel";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // remBtn
            // 
            this.remBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.remBtn.ForeColor = System.Drawing.Color.Black;
            this.remBtn.Location = new System.Drawing.Point(133, 47);
            this.remBtn.Margin = new System.Windows.Forms.Padding(4);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(104, 46);
            this.remBtn.TabIndex = 3;
            this.remBtn.Text = "Remove Channel";
            this.remBtn.UseVisualStyleBackColor = true;
            this.remBtn.Click += new System.EventHandler(this.remBtn_Click);
            // 
            // ArticleTreeView
            // 
            this.ArticleTreeView.Location = new System.Drawing.Point(357, 47);
            this.ArticleTreeView.Name = "ArticleTreeView";
            this.ArticleTreeView.Size = new System.Drawing.Size(907, 125);
            this.ArticleTreeView.TabIndex = 8;
            this.ArticleTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ArticleTreeView_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.hIToolStripMenuItem,
            this.addToolStripMenuItem,
            this.herroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.helloToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helloToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helloToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // hIToolStripMenuItem
            // 
            this.hIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filerToolStripMenuItem,
            this.refreshRateToolStripMenuItem});
            this.hIToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hIToolStripMenuItem.Name = "hIToolStripMenuItem";
            this.hIToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.hIToolStripMenuItem.Text = "Settings";
            // 
            // filerToolStripMenuItem
            // 
            this.filerToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.filerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byNameToolStripMenuItem,
            this.byDateToolStripMenuItem});
            this.filerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filerToolStripMenuItem.Name = "filerToolStripMenuItem";
            this.filerToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.filerToolStripMenuItem.Text = "Filter";
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.byNameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.byNameToolStripMenuItem.Text = "By Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // byDateToolStripMenuItem
            // 
            this.byDateToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.byDateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.byDateToolStripMenuItem.Name = "byDateToolStripMenuItem";
            this.byDateToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.byDateToolStripMenuItem.Text = "By Date";
            this.byDateToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // refreshRateToolStripMenuItem
            // 
            this.refreshRateToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.refreshRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.every5MinutesToolStripMenuItem,
            this.every10MinutesToolStripMenuItem,
            this.every15MinutesToolStripMenuItem,
            this.everyHourToolStripMenuItem});
            this.refreshRateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.refreshRateToolStripMenuItem.Name = "refreshRateToolStripMenuItem";
            this.refreshRateToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.refreshRateToolStripMenuItem.Text = "Refresh Rate";
            // 
            // every5MinutesToolStripMenuItem
            // 
            this.every5MinutesToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.every5MinutesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.every5MinutesToolStripMenuItem.Name = "every5MinutesToolStripMenuItem";
            this.every5MinutesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.every5MinutesToolStripMenuItem.Text = "Every 5 Minutes";
            // 
            // every10MinutesToolStripMenuItem
            // 
            this.every10MinutesToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.every10MinutesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.every10MinutesToolStripMenuItem.Name = "every10MinutesToolStripMenuItem";
            this.every10MinutesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.every10MinutesToolStripMenuItem.Text = "Every 10 Minutes";
            // 
            // every15MinutesToolStripMenuItem
            // 
            this.every15MinutesToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.every15MinutesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.every15MinutesToolStripMenuItem.Name = "every15MinutesToolStripMenuItem";
            this.every15MinutesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.every15MinutesToolStripMenuItem.Text = "Every 15 Minutes";
            // 
            // everyHourToolStripMenuItem
            // 
            this.everyHourToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.everyHourToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.everyHourToolStripMenuItem.Name = "everyHourToolStripMenuItem";
            this.everyHourToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.everyHourToolStripMenuItem.Text = "Every Hour";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.channelToolStripMenuItem,
            this.feedToolStripMenuItem});
            this.addToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // channelToolStripMenuItem
            // 
            this.channelToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.channelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.channelToolStripMenuItem.Name = "channelToolStripMenuItem";
            this.channelToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.channelToolStripMenuItem.Text = "Channel";
            // 
            // feedToolStripMenuItem
            // 
            this.feedToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.feedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.feedToolStripMenuItem.Name = "feedToolStripMenuItem";
            this.feedToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.feedToolStripMenuItem.Text = "Feed";
            // 
            // herroToolStripMenuItem
            // 
            this.herroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.herroToolStripMenuItem.Name = "herroToolStripMenuItem";
            this.herroToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.herroToolStripMenuItem.Text = "Edit";
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1280, 642);
            this.Controls.Add(this.ArticleTreeView);
            this.Controls.Add(this.remBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.channelTree);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "k";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView channelTree;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.ToolStripMenuItem add = new System.Windows.Forms.ToolStripMenuItem("Add Feed");
        private System.Windows.Forms.TreeView ArticleTreeView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every5MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every10MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem every15MinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem everyHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedToolStripMenuItem;
        

    }
}