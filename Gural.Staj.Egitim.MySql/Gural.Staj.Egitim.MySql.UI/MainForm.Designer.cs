namespace Gural.Staj.Egitim.MySql.UI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOgrenci = new System.Windows.Forms.ToolStripMenuItem();
            this.miOgrenciEkleGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.miNotEkleGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miDersEkleGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOgrenci,
            this.dersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOgrenci
            // 
            this.tsmiOgrenci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOgrenciEkleGuncelle,
            this.miNotEkleGüncelleToolStripMenuItem});
            this.tsmiOgrenci.Name = "tsmiOgrenci";
            this.tsmiOgrenci.Size = new System.Drawing.Size(61, 20);
            this.tsmiOgrenci.Text = "Ogrenci";
            // 
            // miOgrenciEkleGuncelle
            // 
            this.miOgrenciEkleGuncelle.Name = "miOgrenciEkleGuncelle";
            this.miOgrenciEkleGuncelle.Size = new System.Drawing.Size(191, 22);
            this.miOgrenciEkleGuncelle.Text = "Ogrenci Ekle/Guncelle";
            this.miOgrenciEkleGuncelle.Click += new System.EventHandler(this.miOgrenciEkleGuncelle_Click_1);
            // 
            // miNotEkleGüncelleToolStripMenuItem
            // 
            this.miNotEkleGüncelleToolStripMenuItem.Name = "miNotEkleGüncelleToolStripMenuItem";
            this.miNotEkleGüncelleToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.miNotEkleGüncelleToolStripMenuItem.Text = "Not Ekle/Güncelle";
            this.miNotEkleGüncelleToolStripMenuItem.Click += new System.EventHandler(this.miNotEkleGüncelleToolStripMenuItem_Click);
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDersEkleGüncelleToolStripMenuItem});
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dersToolStripMenuItem.Text = "Ders";
            // 
            // miDersEkleGüncelleToolStripMenuItem
            // 
            this.miDersEkleGüncelleToolStripMenuItem.Name = "miDersEkleGüncelleToolStripMenuItem";
            this.miDersEkleGüncelleToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.miDersEkleGüncelleToolStripMenuItem.Text = "Ders Ekle/Güncelle";
            this.miDersEkleGüncelleToolStripMenuItem.Click += new System.EventHandler(this.miDersEkleGüncelleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(435, 287);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRENCİ BİLGİ SİSTEMİ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOgrenci;
        private System.Windows.Forms.ToolStripMenuItem miOgrenciEkleGuncelle;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miDersEkleGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNotEkleGüncelleToolStripMenuItem;
    }
}