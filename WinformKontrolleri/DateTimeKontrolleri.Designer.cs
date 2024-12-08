namespace WinformKontrolleri
{
    partial class DateTimeKontrolleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_Dogum = new System.Windows.Forms.DateTimePicker();
            this.btn_TarihGetir = new System.Windows.Forms.Button();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.lbl_KisaTarih = new System.Windows.Forms.Label();
            this.lbl_uzunTarih = new System.Windows.Forms.Label();
            this.nud_saat = new System.Windows.Forms.NumericUpDown();
            this.nud_dakika = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_uretilen = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mc_takvim = new System.Windows.Forms.MonthCalendar();
            this.btn_aralik = new System.Windows.Forms.Button();
            this.lbl_aralik = new System.Windows.Forms.Label();
            this.lbl_tarihfark = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nud_dakika);
            this.groupBox1.Controls.Add(this.nud_saat);
            this.groupBox1.Controls.Add(this.lbl_uretilen);
            this.groupBox1.Controls.Add(this.lbl_uzunTarih);
            this.groupBox1.Controls.Add(this.lbl_KisaTarih);
            this.groupBox1.Controls.Add(this.lbl_Tarih);
            this.groupBox1.Controls.Add(this.btn_TarihGetir);
            this.groupBox1.Controls.Add(this.dtp_Dogum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doğum Tarihi";
            // 
            // dtp_Dogum
            // 
            this.dtp_Dogum.Location = new System.Drawing.Point(17, 28);
            this.dtp_Dogum.Name = "dtp_Dogum";
            this.dtp_Dogum.Size = new System.Drawing.Size(200, 20);
            this.dtp_Dogum.TabIndex = 0;
            // 
            // btn_TarihGetir
            // 
            this.btn_TarihGetir.Location = new System.Drawing.Point(223, 25);
            this.btn_TarihGetir.Name = "btn_TarihGetir";
            this.btn_TarihGetir.Size = new System.Drawing.Size(75, 23);
            this.btn_TarihGetir.TabIndex = 1;
            this.btn_TarihGetir.Text = "Tarih Getir";
            this.btn_TarihGetir.UseVisualStyleBackColor = true;
            this.btn_TarihGetir.Click += new System.EventHandler(this.btn_TarihGetir_Click);
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(14, 93);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(47, 13);
            this.lbl_Tarih.TabIndex = 2;
            this.lbl_Tarih.Text = "lbl_Tarih";
            // 
            // lbl_KisaTarih
            // 
            this.lbl_KisaTarih.AutoSize = true;
            this.lbl_KisaTarih.Location = new System.Drawing.Point(14, 112);
            this.lbl_KisaTarih.Name = "lbl_KisaTarih";
            this.lbl_KisaTarih.Size = new System.Drawing.Size(67, 13);
            this.lbl_KisaTarih.TabIndex = 2;
            this.lbl_KisaTarih.Text = "lbl_KisaTarih";
            // 
            // lbl_uzunTarih
            // 
            this.lbl_uzunTarih.AutoSize = true;
            this.lbl_uzunTarih.Location = new System.Drawing.Point(14, 131);
            this.lbl_uzunTarih.Name = "lbl_uzunTarih";
            this.lbl_uzunTarih.Size = new System.Drawing.Size(70, 13);
            this.lbl_uzunTarih.TabIndex = 2;
            this.lbl_uzunTarih.Text = "lbl_uzunTarih";
            // 
            // nud_saat
            // 
            this.nud_saat.Location = new System.Drawing.Point(17, 54);
            this.nud_saat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_saat.Name = "nud_saat";
            this.nud_saat.Size = new System.Drawing.Size(92, 20);
            this.nud_saat.TabIndex = 3;
            // 
            // nud_dakika
            // 
            this.nud_dakika.Location = new System.Drawing.Point(131, 54);
            this.nud_dakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_dakika.Name = "nud_dakika";
            this.nud_dakika.Size = new System.Drawing.Size(86, 20);
            this.nud_dakika.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // lbl_uretilen
            // 
            this.lbl_uretilen.AutoSize = true;
            this.lbl_uretilen.Location = new System.Drawing.Point(14, 150);
            this.lbl_uretilen.Name = "lbl_uretilen";
            this.lbl_uretilen.Size = new System.Drawing.Size(57, 13);
            this.lbl_uretilen.TabIndex = 2;
            this.lbl_uretilen.Text = "lbl_uretilen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_tarihfark);
            this.groupBox2.Controls.Add(this.lbl_aralik);
            this.groupBox2.Controls.Add(this.btn_aralik);
            this.groupBox2.Controls.Add(this.mc_takvim);
            this.groupBox2.Location = new System.Drawing.Point(334, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralama";
            // 
            // mc_takvim
            // 
            this.mc_takvim.Location = new System.Drawing.Point(12, 20);
            this.mc_takvim.Name = "mc_takvim";
            this.mc_takvim.TabIndex = 1;
            // 
            // btn_aralik
            // 
            this.btn_aralik.Location = new System.Drawing.Point(288, 29);
            this.btn_aralik.Name = "btn_aralik";
            this.btn_aralik.Size = new System.Drawing.Size(75, 23);
            this.btn_aralik.TabIndex = 2;
            this.btn_aralik.Text = "Aralık Getir";
            this.btn_aralik.UseVisualStyleBackColor = true;
            this.btn_aralik.Click += new System.EventHandler(this.btn_aralik_Click);
            // 
            // lbl_aralik
            // 
            this.lbl_aralik.AutoSize = true;
            this.lbl_aralik.Location = new System.Drawing.Point(288, 61);
            this.lbl_aralik.Name = "lbl_aralik";
            this.lbl_aralik.Size = new System.Drawing.Size(48, 13);
            this.lbl_aralik.TabIndex = 3;
            this.lbl_aralik.Text = "lbl_aralik";
            // 
            // lbl_tarihfark
            // 
            this.lbl_tarihfark.AutoSize = true;
            this.lbl_tarihfark.Location = new System.Drawing.Point(288, 80);
            this.lbl_tarihfark.Name = "lbl_tarihfark";
            this.lbl_tarihfark.Size = new System.Drawing.Size(61, 13);
            this.lbl_tarihfark.TabIndex = 3;
            this.lbl_tarihfark.Text = "lbl_tarihfark";
            // 
            // DateTimeKontrolleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DateTimeKontrolleri";
            this.Text = "DateTimeKontrolleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_saat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dakika)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_Dogum;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Button btn_TarihGetir;
        private System.Windows.Forms.Label lbl_uzunTarih;
        private System.Windows.Forms.Label lbl_KisaTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_dakika;
        private System.Windows.Forms.NumericUpDown nud_saat;
        private System.Windows.Forms.Label lbl_uretilen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_aralik;
        private System.Windows.Forms.Button btn_aralik;
        private System.Windows.Forms.MonthCalendar mc_takvim;
        private System.Windows.Forms.Label lbl_tarihfark;
    }
}