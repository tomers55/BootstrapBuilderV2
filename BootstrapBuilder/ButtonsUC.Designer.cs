namespace BootstrapBuilder
{
    partial class ButtonsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P1 = new System.Windows.Forms.Panel();
            this.EditTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P2 = new System.Windows.Forms.Panel();
            this.P3 = new System.Windows.Forms.Panel();
            this.P4 = new System.Windows.Forms.Panel();
            this.P5 = new System.Windows.Forms.Panel();
            this.P6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.SystemColors.Highlight;
            this.P1.Controls.Add(this.panel1);
            this.P1.Controls.Add(this.EditTitle);
            this.P1.Controls.Add(this.pictureBox1);
            this.P1.Dock = System.Windows.Forms.DockStyle.Top;
            this.P1.Location = new System.Drawing.Point(0, 0);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(233, 78);
            this.P1.TabIndex = 0;
            this.P1.MouseEnter += new System.EventHandler(this.MouseHoverPanel);
            this.P1.MouseHover += new System.EventHandler(this.MouseLeavePanel);
            // 
            // EditTitle
            // 
            this.EditTitle.AutoSize = true;
            this.EditTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.EditTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditTitle.Location = new System.Drawing.Point(69, 28);
            this.EditTitle.Name = "EditTitle";
            this.EditTitle.Size = new System.Drawing.Size(87, 25);
            this.EditTitle.TabIndex = 1;
            this.EditTitle.Text = "Edit Title";
            this.EditTitle.MouseEnter += new System.EventHandler(this.MouseEnterLabel);
            this.EditTitle.MouseHover += new System.EventHandler(this.MouseLeaveLabel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BootstrapBuilder.Properties.Resources.centeralignment;
            this.pictureBox1.Location = new System.Drawing.Point(33, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.SystemColors.Highlight;
            this.P2.Dock = System.Windows.Forms.DockStyle.Top;
            this.P2.Location = new System.Drawing.Point(0, 78);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(233, 100);
            this.P2.TabIndex = 1;
            // 
            // P3
            // 
            this.P3.BackColor = System.Drawing.SystemColors.Highlight;
            this.P3.Dock = System.Windows.Forms.DockStyle.Top;
            this.P3.Location = new System.Drawing.Point(0, 178);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(233, 100);
            this.P3.TabIndex = 2;
            // 
            // P4
            // 
            this.P4.BackColor = System.Drawing.SystemColors.Highlight;
            this.P4.Dock = System.Windows.Forms.DockStyle.Top;
            this.P4.Location = new System.Drawing.Point(0, 278);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(233, 100);
            this.P4.TabIndex = 3;
            // 
            // P5
            // 
            this.P5.BackColor = System.Drawing.SystemColors.Highlight;
            this.P5.Dock = System.Windows.Forms.DockStyle.Top;
            this.P5.Location = new System.Drawing.Point(0, 378);
            this.P5.Name = "P5";
            this.P5.Size = new System.Drawing.Size(233, 100);
            this.P5.TabIndex = 4;
            // 
            // P6
            // 
            this.P6.BackColor = System.Drawing.SystemColors.Highlight;
            this.P6.Dock = System.Windows.Forms.DockStyle.Top;
            this.P6.Location = new System.Drawing.Point(0, 478);
            this.P6.Name = "P6";
            this.P6.Size = new System.Drawing.Size(233, 100);
            this.P6.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 78);
            this.panel1.TabIndex = 2;
            // 
            // ButtonsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.P6);
            this.Controls.Add(this.P5);
            this.Controls.Add(this.P4);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Name = "ButtonsUC";
            this.Size = new System.Drawing.Size(233, 601);
            this.P1.ResumeLayout(false);
            this.P1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.Panel P3;
        private System.Windows.Forms.Panel P4;
        private System.Windows.Forms.Panel P5;
        private System.Windows.Forms.Panel P6;
        private System.Windows.Forms.Label EditTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
