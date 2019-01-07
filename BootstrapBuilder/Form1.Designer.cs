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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectWebPanel = new System.Windows.Forms.Panel();
            this.btnContinue = new System.Windows.Forms.Button();
            this.rbSelectedBoot02 = new System.Windows.Forms.RadioButton();
            this.rbSelectedBoot01 = new System.Windows.Forms.RadioButton();
            this.Boot02 = new System.Windows.Forms.PictureBox();
            this.Boot01 = new System.Windows.Forms.PictureBox();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SelectWebPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Boot02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boot01)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnURLPhoto
            // 
            this.btnURLPhoto.Location = new System.Drawing.Point(34, 52);
            this.btnURLPhoto.Name = "btnURLPhoto";
            this.btnURLPhoto.Size = new System.Drawing.Size(166, 25);
            this.btnURLPhoto.TabIndex = 4;
            this.btnURLPhoto.Text = "URL Photo";
            this.btnURLPhoto.UseVisualStyleBackColor = true;
            this.btnURLPhoto.Click += new System.EventHandler(this.btnURLPhoto_Click);
            // 
            // RunHtml
            // 
            this.RunHtml.Location = new System.Drawing.Point(1192, 12);
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
            this.SelectFolder.Location = new System.Drawing.Point(1161, 12);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(25, 23);
            this.SelectFolder.TabIndex = 0;
            this.SelectFolder.Text = "→";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(-7, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 638);
            this.panel1.TabIndex = 6;
            // 
            // SelectWebPanel
            // 
            this.SelectWebPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.SelectWebPanel.Controls.Add(this.btnContinue);
            this.SelectWebPanel.Controls.Add(this.rbSelectedBoot02);
            this.SelectWebPanel.Controls.Add(this.rbSelectedBoot01);
            this.SelectWebPanel.Controls.Add(this.Boot02);
            this.SelectWebPanel.Controls.Add(this.Boot01);
            this.SelectWebPanel.Location = new System.Drawing.Point(203, -4);
            this.SelectWebPanel.Name = "SelectWebPanel";
            this.SelectWebPanel.Size = new System.Drawing.Size(877, 638);
            this.SelectWebPanel.TabIndex = 7;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnContinue.Location = new System.Drawing.Point(639, 308);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(129, 36);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue  →";
            this.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // rbSelectedBoot02
            // 
            this.rbSelectedBoot02.AutoSize = true;
            this.rbSelectedBoot02.Location = new System.Drawing.Point(620, 271);
            this.rbSelectedBoot02.Name = "rbSelectedBoot02";
            this.rbSelectedBoot02.Size = new System.Drawing.Size(59, 17);
            this.rbSelectedBoot02.TabIndex = 3;
            this.rbSelectedBoot02.TabStop = true;
            this.rbSelectedBoot02.Text = "Boot02";
            this.rbSelectedBoot02.UseVisualStyleBackColor = true;
            // 
            // rbSelectedBoot01
            // 
            this.rbSelectedBoot01.AutoSize = true;
            this.rbSelectedBoot01.Location = new System.Drawing.Point(179, 271);
            this.rbSelectedBoot01.Name = "rbSelectedBoot01";
            this.rbSelectedBoot01.Size = new System.Drawing.Size(59, 17);
            this.rbSelectedBoot01.TabIndex = 2;
            this.rbSelectedBoot01.TabStop = true;
            this.rbSelectedBoot01.Text = "Boot01";
            this.rbSelectedBoot01.UseVisualStyleBackColor = true;
            // 
            // Boot02
            // 
            this.Boot02.Image = global::BootstrapBuilder.Properties.Resources.Boot02;
            this.Boot02.Location = new System.Drawing.Point(478, 52);
            this.Boot02.Name = "Boot02";
            this.Boot02.Size = new System.Drawing.Size(351, 212);
            this.Boot02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Boot02.TabIndex = 1;
            this.Boot02.TabStop = false;
            this.Boot02.Click += new System.EventHandler(this.SelectWeb_Click);
            // 
            // Boot01
            // 
            this.Boot01.Image = global::BootstrapBuilder.Properties.Resources.Boot01;
            this.Boot01.Location = new System.Drawing.Point(34, 53);
            this.Boot01.Name = "Boot01";
            this.Boot01.Size = new System.Drawing.Size(349, 212);
            this.Boot01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Boot01.TabIndex = 0;
            this.Boot01.TabStop = false;
            this.Boot01.Click += new System.EventHandler(this.SelectWeb_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.Color.PapayaWhip;
            this.EditPanel.Controls.Add(this.labelTitle);
            this.EditPanel.Controls.Add(this.tbTitle);
            this.EditPanel.Controls.Add(this.btnURLPhoto);
            this.EditPanel.Location = new System.Drawing.Point(203, -4);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(877, 638);
            this.EditPanel.TabIndex = 9;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(80, 18);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(187, 20);
            this.tbTitle.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(31, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(47, 19);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Title:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 628);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.SelectWebPanel);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.RunHtml);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "BootstrapBuilder";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.SelectWebPanel.ResumeLayout(false);
            this.SelectWebPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Boot02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boot01)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnURLPhoto;
        private System.Windows.Forms.Button RunHtml;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SelectWebPanel;
        private System.Windows.Forms.PictureBox Boot01;
        private System.Windows.Forms.PictureBox Boot02;
        private System.Windows.Forms.RadioButton rbSelectedBoot02;
        private System.Windows.Forms.RadioButton rbSelectedBoot01;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox tbTitle;
    }
}

