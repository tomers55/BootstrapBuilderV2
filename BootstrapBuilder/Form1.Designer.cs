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
            this.SelectFolder = new System.Windows.Forms.Button();
            this.RunHtml = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbFilesList = new System.Windows.Forms.TextBox();
            this.btnURLPhoto = new System.Windows.Forms.Button();
            this.btnImportPhoto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(17, 18);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(25, 23);
            this.SelectFolder.TabIndex = 0;
            this.SelectFolder.Text = "→";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // RunHtml
            // 
            this.RunHtml.Location = new System.Drawing.Point(48, 18);
            this.RunHtml.Name = "RunHtml";
            this.RunHtml.Size = new System.Drawing.Size(25, 23);
            this.RunHtml.TabIndex = 1;
            this.RunHtml.TabStop = false;
            this.RunHtml.Text = "►";
            this.RunHtml.UseVisualStyleBackColor = true;
            this.RunHtml.Click += new System.EventHandler(this.RunHtml_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbFilesList);
            this.panel1.Controls.Add(this.SelectFolder);
            this.panel1.Controls.Add(this.RunHtml);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 497);
            this.panel1.TabIndex = 3;
            // 
            // tbFilesList
            // 
            this.tbFilesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFilesList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilesList.Location = new System.Drawing.Point(17, 47);
            this.tbFilesList.Multiline = true;
            this.tbFilesList.Name = "tbFilesList";
            this.tbFilesList.Size = new System.Drawing.Size(137, 291);
            this.tbFilesList.TabIndex = 4;
            // 
            // btnURLPhoto
            // 
            this.btnURLPhoto.Location = new System.Drawing.Point(170, 12);
            this.btnURLPhoto.Name = "btnURLPhoto";
            this.btnURLPhoto.Size = new System.Drawing.Size(129, 34);
            this.btnURLPhoto.TabIndex = 4;
            this.btnURLPhoto.Text = "URL Photo";
            this.btnURLPhoto.UseVisualStyleBackColor = true;
            this.btnURLPhoto.Click += new System.EventHandler(this.btnURLPhoto_Click);
            // 
            // btnImportPhoto
            // 
            this.btnImportPhoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImportPhoto.Location = new System.Drawing.Point(170, 52);
            this.btnImportPhoto.Name = "btnImportPhoto";
            this.btnImportPhoto.Size = new System.Drawing.Size(129, 34);
            this.btnImportPhoto.TabIndex = 5;
            this.btnImportPhoto.Text = "Import Photo";
            this.btnImportPhoto.UseVisualStyleBackColor = true;
            this.btnImportPhoto.Click += new System.EventHandler(this.btnImportPhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 480);
            this.Controls.Add(this.btnImportPhoto);
            this.Controls.Add(this.btnURLPhoto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BootstrapBuilder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Button RunHtml;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbFilesList;
        private System.Windows.Forms.Button btnURLPhoto;
        private System.Windows.Forms.Button btnImportPhoto;
    }
}

