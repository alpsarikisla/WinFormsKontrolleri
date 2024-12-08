namespace WinformKontrolleri
{
    partial class MDIIcinAnaForm
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metinİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MetinAraclariForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_MetinEditoruAc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.metinİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // metinİşlemleriToolStripMenuItem
            // 
            this.metinİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_MetinAraclariForm,
            this.TSMI_MetinEditoruAc});
            this.metinİşlemleriToolStripMenuItem.Name = "metinİşlemleriToolStripMenuItem";
            this.metinİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.metinİşlemleriToolStripMenuItem.Text = "Metin İşlemleri";
            // 
            // TSMI_MetinAraclariForm
            // 
            this.TSMI_MetinAraclariForm.Name = "TSMI_MetinAraclariForm";
            this.TSMI_MetinAraclariForm.Size = new System.Drawing.Size(180, 22);
            this.TSMI_MetinAraclariForm.Text = "Metin Araçları";
            this.TSMI_MetinAraclariForm.Click += new System.EventHandler(this.TSMI_MetinAraclariForm_Click);
            // 
            // TSMI_MetinEditoruAc
            // 
            this.TSMI_MetinEditoruAc.Name = "TSMI_MetinEditoruAc";
            this.TSMI_MetinEditoruAc.Size = new System.Drawing.Size(180, 22);
            this.TSMI_MetinEditoruAc.Text = "Metin Editörü";
            this.TSMI_MetinEditoruAc.Click += new System.EventHandler(this.TSMI_MetinEditoruAc_Click);
            // 
            // MDIIcinAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIIcinAnaForm";
            this.Text = "MDIIcinAnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metinİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MetinAraclariForm;
        private System.Windows.Forms.ToolStripMenuItem TSMI_MetinEditoruAc;
    }
}