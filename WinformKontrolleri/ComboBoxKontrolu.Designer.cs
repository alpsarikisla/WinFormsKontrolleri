namespace WinformKontrolleri
{
    partial class ComboBoxKontrolu
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
            this.cb_departman = new System.Windows.Forms.ComboBox();
            this.btn_departmanSec = new System.Windows.Forms.Button();
            this.lbl_secilenDepartman = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Egitim = new System.Windows.Forms.ComboBox();
            this.lbl_Egitim = new System.Windows.Forms.Label();
            this.cb_markalar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_markaSec = new System.Windows.Forms.Button();
            this.lbl_markaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman Seçiniz";
            // 
            // cb_departman
            // 
            this.cb_departman.FormattingEnabled = true;
            this.cb_departman.Items.AddRange(new object[] {
            "Satış",
            "Muhasebe",
            "Levazım",
            "İnsan Kaynakları"});
            this.cb_departman.Location = new System.Drawing.Point(34, 149);
            this.cb_departman.Name = "cb_departman";
            this.cb_departman.Size = new System.Drawing.Size(179, 21);
            this.cb_departman.TabIndex = 1;
            this.cb_departman.Text = "Seçiniz...";
            // 
            // btn_departmanSec
            // 
            this.btn_departmanSec.Location = new System.Drawing.Point(219, 147);
            this.btn_departmanSec.Name = "btn_departmanSec";
            this.btn_departmanSec.Size = new System.Drawing.Size(75, 23);
            this.btn_departmanSec.TabIndex = 2;
            this.btn_departmanSec.Text = "Seç";
            this.btn_departmanSec.UseVisualStyleBackColor = true;
            this.btn_departmanSec.Click += new System.EventHandler(this.btn_departmanSec_Click);
            // 
            // lbl_secilenDepartman
            // 
            this.lbl_secilenDepartman.AutoSize = true;
            this.lbl_secilenDepartman.Location = new System.Drawing.Point(302, 152);
            this.lbl_secilenDepartman.Name = "lbl_secilenDepartman";
            this.lbl_secilenDepartman.Size = new System.Drawing.Size(35, 13);
            this.lbl_secilenDepartman.TabIndex = 3;
            this.lbl_secilenDepartman.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Katılınacak Eğitim";
            // 
            // cb_Egitim
            // 
            this.cb_Egitim.FormattingEnabled = true;
            this.cb_Egitim.Items.AddRange(new object[] {
            "Yazılım Uzmanlığı",
            "İleri Yazılım Uzmanlığı",
            "İleri Sürüş Eğitimi",
            "Domates Yetiştiriciliği"});
            this.cb_Egitim.Location = new System.Drawing.Point(34, 217);
            this.cb_Egitim.Name = "cb_Egitim";
            this.cb_Egitim.Size = new System.Drawing.Size(179, 21);
            this.cb_Egitim.TabIndex = 5;
            this.cb_Egitim.SelectedIndexChanged += new System.EventHandler(this.cb_Egitim_SelectedIndexChanged);
            // 
            // lbl_Egitim
            // 
            this.lbl_Egitim.AutoSize = true;
            this.lbl_Egitim.Location = new System.Drawing.Point(219, 220);
            this.lbl_Egitim.Name = "lbl_Egitim";
            this.lbl_Egitim.Size = new System.Drawing.Size(35, 13);
            this.lbl_Egitim.TabIndex = 6;
            this.lbl_Egitim.Text = "label3";
            // 
            // cb_markalar
            // 
            this.cb_markalar.FormattingEnabled = true;
            this.cb_markalar.Location = new System.Drawing.Point(34, 286);
            this.cb_markalar.Name = "cb_markalar";
            this.cb_markalar.Size = new System.Drawing.Size(179, 21);
            this.cb_markalar.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marka Seçiniz...";
            // 
            // btn_markaSec
            // 
            this.btn_markaSec.Location = new System.Drawing.Point(222, 286);
            this.btn_markaSec.Name = "btn_markaSec";
            this.btn_markaSec.Size = new System.Drawing.Size(75, 23);
            this.btn_markaSec.TabIndex = 9;
            this.btn_markaSec.Text = "Seç";
            this.btn_markaSec.UseVisualStyleBackColor = true;
            this.btn_markaSec.Click += new System.EventHandler(this.btn_markaSec_Click);
            // 
            // lbl_markaLabel
            // 
            this.lbl_markaLabel.AutoSize = true;
            this.lbl_markaLabel.Location = new System.Drawing.Point(302, 289);
            this.lbl_markaLabel.Name = "lbl_markaLabel";
            this.lbl_markaLabel.Size = new System.Drawing.Size(35, 13);
            this.lbl_markaLabel.TabIndex = 10;
            this.lbl_markaLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 50);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birden çok seçenek arasından bir\r\nseçeneği seçmemizi sağlayan yapıdır.";
            // 
            // ComboBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_markaLabel);
            this.Controls.Add(this.btn_markaSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_markalar);
            this.Controls.Add(this.lbl_Egitim);
            this.Controls.Add(this.cb_Egitim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_secilenDepartman);
            this.Controls.Add(this.btn_departmanSec);
            this.Controls.Add(this.cb_departman);
            this.Controls.Add(this.label1);
            this.Name = "ComboBoxKontrolu";
            this.Text = "ComboBoxKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_departman;
        private System.Windows.Forms.Button btn_departmanSec;
        private System.Windows.Forms.Label lbl_secilenDepartman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Egitim;
        private System.Windows.Forms.Label lbl_Egitim;
        private System.Windows.Forms.ComboBox cb_markalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_markaSec;
        private System.Windows.Forms.Label lbl_markaLabel;
        private System.Windows.Forms.Label label4;
    }
}