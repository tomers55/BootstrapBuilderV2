namespace BootstrapBuilder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnURLPhoto = new System.Windows.Forms.Button();
            this.RunHtml = new System.Windows.Forms.Button();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnURLPhoto
            // 
            this.btnURLPhoto.Location = new System.Drawing.Point(1193, 78);
            this.btnURLPhoto.Name = "btnURLPhoto";
            this.btnURLPhoto.Size = new System.Drawing.Size(25, 25);
            this.btnURLPhoto.TabIndex = 4;
            this.btnURLPhoto.Text = "URL Photo";
            this.btnURLPhoto.UseVisualStyleBackColor = true;
            this.btnURLPhoto.Click += new System.EventHandler(this.btnURLPhoto_Click);
            // 
            // RunHtml
            // 
            this.RunHtml.Location = new System.Drawing.Point(1193, 49);
            this.RunHtml.Name = "RunHtml";
            this.RunHtml.Size = new System.Drawing.Size(25, 23);
            this.RunHtml.TabIndex = 1;
            this.RunHtml.TabStop = false;
            this.RunHtml.Text = "►";
            this.RunHtml.UseVisualStyleBackColor = true;
            this.RunHtml.Click += new System.EventHandler(this.RunHtml_Click);
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(1162, 49);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(25, 23);
            this.SelectFolder.TabIndex = 0;
            this.SelectFolder.Text = "→";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.MouseLeaveEvent);
            this.pictureBox1.MouseHover += new System.EventHandler(this.MouseOverEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1237, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnURLPhoto);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.RunHtml);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnURLPhoto;
        private System.Windows.Forms.Button RunHtml;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

