namespace WinformKontrolleri
{
    partial class KategoriHizliEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(100, 24);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(196, 20);
            this.tb_isim.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(302, 22);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(124, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Kategori Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // KategoriHizliEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 69);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tb_isim);
            this.Controls.Add(this.label1);
            this.Name = "KategoriHizliEkleForm";
            this.Text = "Kategori Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label1;
    }
}