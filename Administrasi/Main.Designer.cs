namespace Administrasi
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.dataMuridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGuruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mataPelajaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1094, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMuridToolStripMenuItem,
            this.dataGuruToolStripMenuItem,
            this.jadwalToolStripMenuItem,
            this.mataPelajaranToolStripMenuItem,
            this.kelasToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(36, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // dataMuridToolStripMenuItem
            // 
            this.dataMuridToolStripMenuItem.Name = "dataMuridToolStripMenuItem";
            this.dataMuridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataMuridToolStripMenuItem.Text = "Data Murid";
            this.dataMuridToolStripMenuItem.Click += new System.EventHandler(this.dataMuridToolStripMenuItem_Click);
            // 
            // dataGuruToolStripMenuItem
            // 
            this.dataGuruToolStripMenuItem.Name = "dataGuruToolStripMenuItem";
            this.dataGuruToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataGuruToolStripMenuItem.Text = "Data Guru";
            this.dataGuruToolStripMenuItem.Click += new System.EventHandler(this.dataGuruToolStripMenuItem_Click);
            // 
            // jadwalToolStripMenuItem
            // 
            this.jadwalToolStripMenuItem.Name = "jadwalToolStripMenuItem";
            this.jadwalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jadwalToolStripMenuItem.Text = "Jadwal";
            this.jadwalToolStripMenuItem.Click += new System.EventHandler(this.jadwalToolStripMenuItem_Click);
            // 
            // mataPelajaranToolStripMenuItem
            // 
            this.mataPelajaranToolStripMenuItem.Name = "mataPelajaranToolStripMenuItem";
            this.mataPelajaranToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mataPelajaranToolStripMenuItem.Text = "Mata Pelajaran";
            this.mataPelajaranToolStripMenuItem.Click += new System.EventHandler(this.mataPelajaranToolStripMenuItem_Click);
            // 
            // kelasToolStripMenuItem
            // 
            this.kelasToolStripMenuItem.Name = "kelasToolStripMenuItem";
            this.kelasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kelasToolStripMenuItem.Text = "Kelas";
            this.kelasToolStripMenuItem.Click += new System.EventHandler(this.kelasToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 389);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem dataMuridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataGuruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mataPelajaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelasToolStripMenuItem;
    }
}

