namespace MMS
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ditheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderedDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sierraDitheringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxHist_1 = new System.Windows.Forms.PictureBox();
            this.pBoxRed = new System.Windows.Forms.PictureBox();
            this.pBoxGreen = new System.Windows.Forms.PictureBox();
            this.pBoxBlue = new System.Windows.Forms.PictureBox();
            this.pBoxReconstructed = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHist_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReconstructed)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ditheringToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ditheringToolStripMenuItem
            // 
            this.ditheringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderedDitheringToolStripMenuItem,
            this.sierraDitheringToolStripMenuItem});
            this.ditheringToolStripMenuItem.Name = "ditheringToolStripMenuItem";
            this.ditheringToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ditheringToolStripMenuItem.Text = "Dither";
            // 
            // orderedDitheringToolStripMenuItem
            // 
            this.orderedDitheringToolStripMenuItem.Name = "orderedDitheringToolStripMenuItem";
            this.orderedDitheringToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.orderedDitheringToolStripMenuItem.Text = "FloydSteinberg Dithering";
            this.orderedDitheringToolStripMenuItem.Click += new System.EventHandler(this.orderedDitheringToolStripMenuItem_Click);
            // 
            // sierraDitheringToolStripMenuItem
            // 
            this.sierraDitheringToolStripMenuItem.Name = "sierraDitheringToolStripMenuItem";
            this.sierraDitheringToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.sierraDitheringToolStripMenuItem.Text = "Bill Atkinson algorithm";
            this.sierraDitheringToolStripMenuItem.Click += new System.EventHandler(this.sierraDitheringToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 685);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxHist_1
            // 
            this.pBoxHist_1.Location = new System.Drawing.Point(906, 56);
            this.pBoxHist_1.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxHist_1.Name = "pBoxHist_1";
            this.pBoxHist_1.Size = new System.Drawing.Size(255, 280);
            this.pBoxHist_1.TabIndex = 3;
            this.pBoxHist_1.TabStop = false;
            // 
            // pBoxRed
            // 
            this.pBoxRed.Location = new System.Drawing.Point(1216, 56);
            this.pBoxRed.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxRed.Name = "pBoxRed";
            this.pBoxRed.Size = new System.Drawing.Size(266, 280);
            this.pBoxRed.TabIndex = 4;
            this.pBoxRed.TabStop = false;
            // 
            // pBoxGreen
            // 
            this.pBoxGreen.Location = new System.Drawing.Point(906, 414);
            this.pBoxGreen.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxGreen.Name = "pBoxGreen";
            this.pBoxGreen.Size = new System.Drawing.Size(266, 280);
            this.pBoxGreen.TabIndex = 5;
            this.pBoxGreen.TabStop = false;
            // 
            // pBoxBlue
            // 
            this.pBoxBlue.Location = new System.Drawing.Point(1236, 414);
            this.pBoxBlue.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxBlue.Name = "pBoxBlue";
            this.pBoxBlue.Size = new System.Drawing.Size(246, 280);
            this.pBoxBlue.TabIndex = 6;
            this.pBoxBlue.TabStop = false;
            // 
            // pBoxReconstructed
            // 
            this.pBoxReconstructed.Location = new System.Drawing.Point(428, 29);
            this.pBoxReconstructed.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxReconstructed.Name = "pBoxReconstructed";
            this.pBoxReconstructed.Size = new System.Drawing.Size(459, 681);
            this.pBoxReconstructed.TabIndex = 11;
            this.pBoxReconstructed.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1510, 748);
            this.Controls.Add(this.pBoxReconstructed);
            this.Controls.Add(this.pBoxBlue);
            this.Controls.Add(this.pBoxGreen);
            this.Controls.Add(this.pBoxRed);
            this.Controls.Add(this.pBoxHist_1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxHist_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxReconstructed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
       public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pBoxHist_1;
        public System.Windows.Forms.PictureBox pBoxRed;
        public System.Windows.Forms.PictureBox pBoxGreen;
        public System.Windows.Forms.PictureBox pBoxBlue;
        private System.Windows.Forms.ToolStripMenuItem ditheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderedDitheringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sierraDitheringToolStripMenuItem;
        public System.Windows.Forms.PictureBox pBoxReconstructed;
    }
}

