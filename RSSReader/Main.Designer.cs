namespace RSSReader
{
    partial class RSSReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSSReader));
            this.mapViewBtn = new System.Windows.Forms.Button();
            this.regViewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.mainTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapViewBtn
            // 
            this.mapViewBtn.BackColor = System.Drawing.Color.White;
            this.mapViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapViewBtn.BackgroundImage")));
            this.mapViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mapViewBtn.Location = new System.Drawing.Point(180, 165);
            this.mapViewBtn.Name = "mapViewBtn";
            this.mapViewBtn.Size = new System.Drawing.Size(150, 150);
            this.mapViewBtn.TabIndex = 0;
            this.mapViewBtn.UseVisualStyleBackColor = false;
            this.mapViewBtn.Click += new System.EventHandler(this.mapViewBtn_Click);
            // 
            // regViewBtn
            // 
            this.regViewBtn.BackColor = System.Drawing.Color.White;
            this.regViewBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regViewBtn.BackgroundImage")));
            this.regViewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.regViewBtn.Location = new System.Drawing.Point(476, 165);
            this.regViewBtn.Name = "regViewBtn";
            this.regViewBtn.Size = new System.Drawing.Size(150, 150);
            this.regViewBtn.TabIndex = 1;
            this.regViewBtn.Text = "Regular View";
            this.regViewBtn.UseVisualStyleBackColor = false;
            this.regViewBtn.Click += new System.EventHandler(this.regViewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Map View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(510, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "List View";
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.BackgroundImage")));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settingsBtn.Location = new System.Drawing.Point(700, 394);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(75, 75);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Segoe Marker", 28F);
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(272, 43);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(250, 44);
            this.mainTitle.TabIndex = 5;
            this.mainTitle.Text = "RSS Reader 3000";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainTitle.Click += new System.EventHandler(this.regViewBtn_Click);
            // 
            // RSSReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(787, 481);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regViewBtn);
            this.Controls.Add(this.mapViewBtn);
            this.Font = new System.Drawing.Font("Segoe Marker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RSSReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS Reader 3000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mapViewBtn;
        private System.Windows.Forms.Button regViewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Label mainTitle;
    }
}

