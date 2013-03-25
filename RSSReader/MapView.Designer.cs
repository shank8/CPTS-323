namespace RSSReader
{
    partial class MapView
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
            this.treeView = new System.Windows.Forms.TreeView();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.addBtn = new System.Windows.Forms.Button();
            this.setBtn = new System.Windows.Forms.Button();
            this.remBtn = new System.Windows.Forms.Button();
            this.titleFilter = new System.Windows.Forms.RadioButton();
            this.dateFilter = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 92);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(250, 416);
            this.treeView.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(268, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(680, 496);
            this.webBrowser.TabIndex = 1;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.addBtn.ForeColor = System.Drawing.Color.Black;
            this.addBtn.Location = new System.Drawing.Point(12, 12);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 47);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "Add Channel";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // setBtn
            // 
            this.setBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.setBtn.ForeColor = System.Drawing.Color.Black;
            this.setBtn.Location = new System.Drawing.Point(183, 12);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(79, 47);
            this.setBtn.TabIndex = 4;
            this.setBtn.Text = "Settings";
            this.setBtn.UseVisualStyleBackColor = true;
            // 
            // remBtn
            // 
            this.remBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.remBtn.ForeColor = System.Drawing.Color.Black;
            this.remBtn.Location = new System.Drawing.Point(93, 12);
            this.remBtn.Name = "remBtn";
            this.remBtn.Size = new System.Drawing.Size(84, 47);
            this.remBtn.TabIndex = 3;
            this.remBtn.Text = "Remove Channel";
            this.remBtn.UseVisualStyleBackColor = true;
            this.remBtn.Click += new System.EventHandler(this.remBtn_Click);
            // 
            // titleFilter
            // 
            this.titleFilter.AutoSize = true;
            this.titleFilter.Location = new System.Drawing.Point(12, 69);
            this.titleFilter.Name = "titleFilter";
            this.titleFilter.Size = new System.Drawing.Size(81, 17);
            this.titleFilter.TabIndex = 5;
            this.titleFilter.TabStop = true;
            this.titleFilter.Text = "Sort by Title";
            this.titleFilter.UseVisualStyleBackColor = true;
            // 
            // dateFilter
            // 
            this.dateFilter.AutoSize = true;
            this.dateFilter.Location = new System.Drawing.Point(99, 69);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(84, 17);
            this.dateFilter.TabIndex = 6;
            this.dateFilter.TabStop = true;
            this.dateFilter.Text = "Sort by Date";
            this.dateFilter.UseVisualStyleBackColor = true;
            // 
            // MapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(960, 522);
            this.Controls.Add(this.dateFilter);
            this.Controls.Add(this.titleFilter);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.remBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.treeView);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "k";
            this.Load += new System.EventHandler(this.MapView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Button remBtn;
        private System.Windows.Forms.RadioButton titleFilter;
        private System.Windows.Forms.RadioButton dateFilter;
    }
}