namespace BootstrapBuilder
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbMinimise = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMeximized = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeximized)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.panel3);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1403, 82);
            this.TopPanel.TabIndex = 2;
            this.TopPanel.DoubleClick += new System.EventHandler(this.FullSizeWindow);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.pbMinimise);
            this.panel3.Controls.Add(this.pbClose);
            this.panel3.Controls.Add(this.pbMeximized);
            this.panel3.Location = new System.Drawing.Point(1318, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 23);
            this.panel3.TabIndex = 1;
            // 
            // pbMinimise
            // 
            this.pbMinimise.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimise.Image")));
            this.pbMinimise.Location = new System.Drawing.Point(0, 0);
            this.pbMinimise.Name = "pbMinimise";
            this.pbMinimise.Size = new System.Drawing.Size(22, 23);
            this.pbMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMinimise.TabIndex = 3;
            this.pbMinimise.TabStop = false;
            this.pbMinimise.Click += new System.EventHandler(this.MinimiseWindow);
            this.pbMinimise.MouseLeave += new System.EventHandler(this.MouseControlersLeaveEvent);
            this.pbMinimise.MouseHover += new System.EventHandler(this.MouseControlersOverEvent);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = global::BootstrapBuilder.Properties.Resources.cancel_3_;
            this.pbClose.Location = new System.Drawing.Point(58, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(26, 23);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.ExitProgram);
            this.pbClose.MouseLeave += new System.EventHandler(this.MouseControlersLeaveEvent);
            this.pbClose.MouseHover += new System.EventHandler(this.MouseControlersOverEvent);
            // 
            // pbMeximized
            // 
            this.pbMeximized.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbMeximized.Image = global::BootstrapBuilder.Properties.Resources.full_screen;
            this.pbMeximized.Location = new System.Drawing.Point(28, 0);
            this.pbMeximized.Name = "pbMeximized";
            this.pbMeximized.Size = new System.Drawing.Size(24, 23);
            this.pbMeximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMeximized.TabIndex = 2;
            this.pbMeximized.TabStop = false;
            this.pbMeximized.Click += new System.EventHandler(this.FullSizeWindow);
            this.pbMeximized.MouseLeave += new System.EventHandler(this.MouseControlersLeaveEvent);
            this.pbMeximized.MouseHover += new System.EventHandler(this.MouseControlersOverEvent);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 631);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1403, 24);
            this.panel5.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 549);
            this.panel1.TabIndex = 4;
            this.panel1.DoubleClick += new System.EventHandler(this.FullSizeWindow);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(454, 212);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.SelectedListViewValue);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Project Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dated";
            this.columnHeader2.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add New Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewProject);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BootstrapBuilder.Properties.Resources.speed32;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "BootStrapBuilder";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 655);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TopPanel);
            this.Name = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_FormLoad);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeximized)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbMinimise;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMeximized;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}