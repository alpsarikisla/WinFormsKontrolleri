namespace WinformKontrolleri
{
    partial class UrunlerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_barkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tedarikci = new System.Windows.Forms.ComboBox();
            this.btn_kategoriFormAc = new System.Windows.Forms.Button();
            this.btn_tedarikciFormAc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.tb_paketleme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_guvenlikstok = new System.Windows.Forms.NumericUpDown();
            this.cb_satistami = new System.Windows.Forms.CheckBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikstok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1052, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.cb_satistami);
            this.groupBox1.Controls.Add(this.nud_guvenlikstok);
            this.groupBox1.Controls.Add(this.nud_stok);
            this.groupBox1.Controls.Add(this.btn_tedarikciFormAc);
            this.groupBox1.Controls.Add(this.btn_kategoriFormAc);
            this.groupBox1.Controls.Add(this.cb_tedarikci);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_kategori);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.tb_paketleme);
            this.groupBox1.Controls.Add(this.tb_barkod);
            this.groupBox1.Controls.Add(this.tb_fiyat);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 167);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(65, 27);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(191, 20);
            this.tb_id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // tb_barkod
            // 
            this.tb_barkod.Location = new System.Drawing.Point(65, 53);
            this.tb_barkod.Name = "tb_barkod";
            this.tb_barkod.Size = new System.Drawing.Size(191, 20);
            this.tb_barkod.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod:";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(65, 79);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(191, 20);
            this.tb_isim.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "İsim:";
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(374, 27);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(191, 21);
            this.cb_kategori.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tedarikçi:";
            // 
            // cb_tedarikci
            // 
            this.cb_tedarikci.FormattingEnabled = true;
            this.cb_tedarikci.Location = new System.Drawing.Point(374, 54);
            this.cb_tedarikci.Name = "cb_tedarikci";
            this.cb_tedarikci.Size = new System.Drawing.Size(191, 21);
            this.cb_tedarikci.TabIndex = 2;
            // 
            // btn_kategoriFormAc
            // 
            this.btn_kategoriFormAc.Location = new System.Drawing.Point(571, 25);
            this.btn_kategoriFormAc.Name = "btn_kategoriFormAc";
            this.btn_kategoriFormAc.Size = new System.Drawing.Size(38, 23);
            this.btn_kategoriFormAc.TabIndex = 3;
            this.btn_kategoriFormAc.Text = "+";
            this.btn_kategoriFormAc.UseVisualStyleBackColor = true;
            this.btn_kategoriFormAc.Click += new System.EventHandler(this.btn_kategoriFormAc_Click);
            // 
            // btn_tedarikciFormAc
            // 
            this.btn_tedarikciFormAc.Location = new System.Drawing.Point(571, 52);
            this.btn_tedarikciFormAc.Name = "btn_tedarikciFormAc";
            this.btn_tedarikciFormAc.Size = new System.Drawing.Size(38, 23);
            this.btn_tedarikciFormAc.TabIndex = 3;
            this.btn_tedarikciFormAc.Text = "+";
            this.btn_tedarikciFormAc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(695, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Stok:";
            // 
            // nud_stok
            // 
            this.nud_stok.Location = new System.Drawing.Point(736, 55);
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(191, 20);
            this.nud_stok.TabIndex = 4;
            // 
            // tb_paketleme
            // 
            this.tb_paketleme.Location = new System.Drawing.Point(374, 81);
            this.tb_paketleme.Name = "tb_paketleme";
            this.tb_paketleme.Size = new System.Drawing.Size(191, 20);
            this.tb_paketleme.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Paketleme:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Güvenlik Stoğu:";
            // 
            // nud_guvenlikstok
            // 
            this.nud_guvenlikstok.Location = new System.Drawing.Point(736, 82);
            this.nud_guvenlikstok.Name = "nud_guvenlikstok";
            this.nud_guvenlikstok.Size = new System.Drawing.Size(191, 20);
            this.nud_guvenlikstok.TabIndex = 4;
            // 
            // cb_satistami
            // 
            this.cb_satistami.AutoSize = true;
            this.cb_satistami.Location = new System.Drawing.Point(736, 114);
            this.cb_satistami.Name = "cb_satistami";
            this.cb_satistami.Size = new System.Drawing.Size(86, 17);
            this.cb_satistami.TabIndex = 5;
            this.cb_satistami.Text = "Satış Devam";
            this.cb_satistami.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(828, 114);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(99, 23);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "Ürün Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(736, 29);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(191, 20);
            this.tb_fiyat.TabIndex = 0;
            this.tb_fiyat.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Fiyat:";
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrunlerForm";
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_guvenlikstok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tedarikciFormAc;
        private System.Windows.Forms.Button btn_kategoriFormAc;
        private System.Windows.Forms.ComboBox cb_tedarikci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.TextBox tb_barkod;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.NumericUpDown nud_guvenlikstok;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_paketleme;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.CheckBox cb_satistami;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_fiyat;
    }
}