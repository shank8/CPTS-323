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
            this.setBtn = new System.Windows.Forms.Button();
            this.remBtn = new System.Windows.Forms.Button();
            this.titleFilter = new System.Windows.Forms.RadioButton();
            this.dateFilter = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // channelTree
            // 
            this.channelTree.Location = new System.Drawing.Point(16, 113);
            this.channelTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.channelTree.Name = "channelTree";
            this.channelTree.Size = new System.Drawing.Size(332, 511);
            this.channelTree.TabIndex = 0;
            this.channelTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.channelTree_NodeMouseDoubleClick);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(357, 191);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(907, 434);
            this.webBrowser.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(16, 15);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 58);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Channel";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.setBtn.ForeColor = System.Drawing.Color.Black;
            this.setBtn.Location = new System.Drawing.Point(244, 15);
            this.setBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(105, 58);
            this.setBtn.TabIndex = 4;
            this.setBtn.Text = "Settings";
            this.setBtn.UseVisualStyleBackColor = true;
            // 
            // remBtn
            // 
            this.remBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.remBtn.ForeColor = System.Drawing.Color.Black;
            this.remBtn.Location = new System.Drawing.Point(124, 15);
            this.remBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(112, 58);
            this.remBtn.TabIndex = 3;
            this.remBtn.Text = "Remove Channel";
            this.remBtn.UseVisualStyleBackColor = true;
            this.remBtn.Click += new System.EventHandler(this.remBtn_Click);
            // 
            // titleFilter
            // 
            this.titleFilter.AutoSize = true;
            this.titleFilter.Location = new System.Drawing.Point(16, 85);
            this.titleFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titleFilter.Name = "titleFilter";
            this.titleFilter.Size = new System.Drawing.Size(105, 21);
            this.titleFilter.TabIndex = 5;
            this.titleFilter.TabStop = true;
            this.titleFilter.Text = "Sort by Title";
            this.titleFilter.UseVisualStyleBackColor = true;
            // 
            // dateFilter
            // 
            this.dateFilter.AutoSize = true;
            this.dateFilter.Location = new System.Drawing.Point(132, 85);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(108, 21);
            this.dateFilter.TabIndex = 6;
            this.dateFilter.TabStop = true;
            this.dateFilter.Text = "Sort by Date";
            this.dateFilter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "TEST ME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1280, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.titleFilter);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.remBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.channelTree);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "k";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView channelTree;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.RadioButton titleFilter;
        private System.Windows.Forms.RadioButton dateFilter;
        private System.Windows.Forms.ToolStripMenuItem add = new System.Windows.Forms.ToolStripMenuItem("Add Feed");
        private System.Windows.Forms.Button button1;
        

    }
}