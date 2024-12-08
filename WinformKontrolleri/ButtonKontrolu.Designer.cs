namespace WinformKontrolleri
{
    partial class ButtonKontrolu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_tikla = new System.Windows.Forms.Button();
            this.btn_banana = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Standart Buton";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(126, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 70);
            this.button2.TabIndex = 0;
            this.button2.Text = "Şişman Buton";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(240, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 70);
            this.button3.TabIndex = 1;
            this.button3.Text = "Renkli Button";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btn_tikla
            // 
            this.btn_tikla.Location = new System.Drawing.Point(12, 128);
            this.btn_tikla.Name = "btn_tikla";
            this.btn_tikla.Size = new System.Drawing.Size(75, 23);
            this.btn_tikla.TabIndex = 3;
            this.btn_tikla.Text = "Tıkla";
            this.btn_tikla.UseVisualStyleBackColor = true;
            this.btn_tikla.Click += new System.EventHandler(this.btn_tikla_Click);
            // 
            // btn_banana
            // 
            this.btn_banana.BackgroundImage = global::WinformKontrolleri.Properties.Resources.pngimg_com___banana_PNG842;
            this.btn_banana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_banana.Location = new System.Drawing.Point(341, 184);
            this.btn_banana.Name = "btn_banana";
            this.btn_banana.Size = new System.Drawing.Size(161, 110);
            this.btn_banana.TabIndex = 4;
            this.btn_banana.UseVisualStyleBackColor = true;
            this.btn_banana.Click += new System.EventHandler(this.btn_banana_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WinformKontrolleri.Properties.Resources.LogoSingle;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(368, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 70);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_counter.Location = new System.Drawing.Point(411, 307);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(23, 25);
            this.lbl_counter.TabIndex = 5;
            this.lbl_counter.Text = "0";
            // 
            // ButtonKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.btn_banana);
            this.Controls.Add(this.btn_tikla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ButtonKontrolu";
            this.Text = "ButtonKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_tikla;
        private System.Windows.Forms.Button btn_banana;
        private System.Windows.Forms.Label lbl_counter;
    }
}