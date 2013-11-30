namespace Gural.Staj.Egitim.MySql.UI
{
    partial class NotForm
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
            this.btn_NotEkle = new System.Windows.Forms.Button();
            this.txtVize1 = new System.Windows.Forms.TextBox();
            this.txtVize2 = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNotGoruntule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotGoruntule)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NotEkle
            // 
            this.btn_NotEkle.Location = new System.Drawing.Point(95, 99);
            this.btn_NotEkle.Name = "btn_NotEkle";
            this.btn_NotEkle.Size = new System.Drawing.Size(86, 29);
            this.btn_NotEkle.TabIndex = 0;
            this.btn_NotEkle.Text = "EKLE";
            this.btn_NotEkle.UseVisualStyleBackColor = true;
            this.btn_NotEkle.Click += new System.EventHandler(this.btn_NotEkle_Click);
            // 
            // txtVize1
            // 
            this.txtVize1.Location = new System.Drawing.Point(140, 9);
            this.txtVize1.Name = "txtVize1";
            this.txtVize1.Size = new System.Drawing.Size(41, 20);
            this.txtVize1.TabIndex = 1;
            // 
            // txtVize2
            // 
            this.txtVize2.Location = new System.Drawing.Point(140, 35);
            this.txtVize2.Name = "txtVize2";
            this.txtVize2.Size = new System.Drawing.Size(41, 20);
            this.txtVize2.TabIndex = 2;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(140, 61);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(41, 20);
            this.txtFinal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vize 1 :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vize 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Final :";
            // 
            // dgvNotGoruntule
            // 
            this.dgvNotGoruntule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotGoruntule.Location = new System.Drawing.Point(12, 134);
            this.dgvNotGoruntule.Name = "dgvNotGoruntule";
            this.dgvNotGoruntule.Size = new System.Drawing.Size(260, 116);
            this.dgvNotGoruntule.TabIndex = 7;
            // 
            // NotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dgvNotGoruntule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize2);
            this.Controls.Add(this.txtVize1);
            this.Controls.Add(this.btn_NotEkle);
            this.Name = "NotForm";
            this.Text = "NotForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotGoruntule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NotEkle;
        private System.Windows.Forms.TextBox txtVize1;
        private System.Windows.Forms.TextBox txtVize2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNotGoruntule;
    }
}