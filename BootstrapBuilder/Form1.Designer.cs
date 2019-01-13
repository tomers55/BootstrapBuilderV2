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
            this.typebox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playbutton = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // typebox
            // 
            this.typebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.typebox.Image = global::BootstrapBuilder.Properties.Resources.typebox;
            this.typebox.Location = new System.Drawing.Point(10, 179);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(30, 30);
            this.typebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.typebox.TabIndex = 7;
            this.typebox.TabStop = false;
            this.typebox.Click += new System.EventHandler(this.typebox_Click);
            this.typebox.MouseLeave += new System.EventHandler(this.MouseLeaveEvent);
            this.typebox.MouseHover += new System.EventHandler(this.MouseOverEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::BootstrapBuilder.Properties.Resources.speed_1_1;
            this.pictureBox1.Location = new System.Drawing.Point(405, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // playbutton
            // 
            this.playbutton.Image = global::BootstrapBuilder.Properties.Resources.playbutton;
            this.playbutton.Location = new System.Drawing.Point(10, 85);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(32, 32);
            this.playbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.playbutton.TabIndex = 11;
            this.playbutton.TabStop = false;
            this.playbutton.Click += new System.EventHandler(this.RunHtml_Click);
            this.playbutton.MouseLeave += new System.EventHandler(this.MouseLeaveEvent);
            this.playbutton.MouseHover += new System.EventHandler(this.MouseOverEvent);
            // 
            // image
            // 
            this.image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.image.Image = global::BootstrapBuilder.Properties.Resources.image;
            this.image.Location = new System.Drawing.Point(10, 132);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(32, 32);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 12;
            this.image.TabStop = false;
            this.image.MouseLeave += new System.EventHandler(this.MouseLeaveEvent);
            this.image.MouseHover += new System.EventHandler(this.MouseOverEvent);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(186, 185);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(224, 20);
            this.tbTitle.TabIndex = 13;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTitle.Location = new System.Drawing.Point(45, 184);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(140, 19);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Enter You Web Title:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1048, 549);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.image);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.typebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "BootStrapBuilder";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.SystemColors.InactiveBorder;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.typebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox typebox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox playbutton;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lbTitle;
    }
}

