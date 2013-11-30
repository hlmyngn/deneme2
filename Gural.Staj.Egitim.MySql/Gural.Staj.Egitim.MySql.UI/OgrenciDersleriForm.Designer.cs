namespace Gural.Staj.Egitim.MySql.UI
{
    partial class OgrenciDersleriForm
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
            this.dgvDersListesi = new System.Windows.Forms.DataGridView();
            this.dgvSeciliDersListesi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOgrenciAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeciliDersListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDersListesi
            // 
            this.dgvDersListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersListesi.Location = new System.Drawing.Point(12, 36);
            this.dgvDersListesi.Name = "dgvDersListesi";
            this.dgvDersListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersListesi.Size = new System.Drawing.Size(267, 242);
            this.dgvDersListesi.TabIndex = 0;
            // 
            // dgvSeciliDersListesi
            // 
            this.dgvSeciliDersListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeciliDersListesi.Location = new System.Drawing.Point(316, 36);
            this.dgvSeciliDersListesi.Name = "dgvSeciliDersListesi";
            this.dgvSeciliDersListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeciliDersListesi.Size = new System.Drawing.Size(267, 242);
            this.dgvSeciliDersListesi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "KALDIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // lblOgrenciAdi
            // 
            this.lblOgrenciAdi.AutoSize = true;
            this.lblOgrenciAdi.Location = new System.Drawing.Point(86, 15);
            this.lblOgrenciAdi.Name = "lblOgrenciAdi";
            this.lblOgrenciAdi.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciAdi.TabIndex = 6;
            // 
            // OgrenciDersleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 316);
            this.Controls.Add(this.lblOgrenciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSeciliDersListesi);
            this.Controls.Add(this.dgvDersListesi);
            this.Name = "OgrenciDersleriForm";
            this.Text = "OgrenciDersleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeciliDersListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDersListesi;
        private System.Windows.Forms.DataGridView dgvSeciliDersListesi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOgrenciAdi;
    }
}