namespace Gural.Staj.Egitim.MySql.UI
{
    partial class DersEkle
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
            this.btn_DersEkle = new System.Windows.Forms.Button();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDersGöster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersGöster)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DersEkle
            // 
            this.btn_DersEkle.Location = new System.Drawing.Point(84, 47);
            this.btn_DersEkle.Name = "btn_DersEkle";
            this.btn_DersEkle.Size = new System.Drawing.Size(114, 24);
            this.btn_DersEkle.TabIndex = 0;
            this.btn_DersEkle.Text = "EKLE";
            this.btn_DersEkle.UseVisualStyleBackColor = true;
            this.btn_DersEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(84, 12);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(114, 20);
            this.txtDersAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ders Adı :";
            // 
            // dgvDersGöster
            // 
            this.dgvDersGöster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersGöster.Location = new System.Drawing.Point(11, 92);
            this.dgvDersGöster.Name = "dgvDersGöster";
            this.dgvDersGöster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDersGöster.Size = new System.Drawing.Size(263, 149);
            this.dgvDersGöster.TabIndex = 3;
            // 
            // DersEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dgvDersGöster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.btn_DersEkle);
            this.Name = "DersEkle";
            this.Text = "DersEkle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersGöster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DersEkle;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDersGöster;
    }
}