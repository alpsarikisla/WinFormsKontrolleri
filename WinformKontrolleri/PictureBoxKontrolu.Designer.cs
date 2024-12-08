namespace WinformKontrolleri
{
    partial class PictureBoxKontrolu
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
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.cb_sizemode = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_sizemode);
            this.groupBox1.Controls.Add(this.pb_resim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resim";
            // 
            // pb_resim
            // 
            this.pb_resim.Location = new System.Drawing.Point(6, 19);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(317, 206);
            this.pb_resim.TabIndex = 0;
            this.pb_resim.TabStop = false;
            // 
            // cb_sizemode
            // 
            this.cb_sizemode.FormattingEnabled = true;
            this.cb_sizemode.Items.AddRange(new object[] {
            "Öylece Bırah",
            "Resmi Sığdır",
            "Resmi Esnet",
            "Resmi Ortala"});
            this.cb_sizemode.Location = new System.Drawing.Point(6, 231);
            this.cb_sizemode.Name = "cb_sizemode";
            this.cb_sizemode.Size = new System.Drawing.Size(218, 21);
            this.cb_sizemode.TabIndex = 1;
            this.cb_sizemode.SelectedIndexChanged += new System.EventHandler(this.cb_sizemode_SelectedIndexChanged);
            // 
            // PictureBoxKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "PictureBoxKontrolu";
            this.Text = "PictureBoxKontrolu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.ComboBox cb_sizemode;
    }
}