using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformKontrolleri
{
    public partial class FlowLayoutPanelVeUserControl : Form
    {
        string path = "";
        ComboBox cb_goruntulenmeSekli;
        public FlowLayoutPanelVeUserControl()
        {
            InitializeComponent();
            FormDesign();
        }

        private void FormDesign()
        {
            cb_goruntulenmeSekli = new ComboBox();
            cb_goruntulenmeSekli.Location = new Point(20, 370);
            cb_goruntulenmeSekli.Size = new Size(250, 30);
            cb_goruntulenmeSekli.Items.Add("Auto Size");
            cb_goruntulenmeSekli.Items.Add("Center Image");
            cb_goruntulenmeSekli.Items.Add("Normal");
            cb_goruntulenmeSekli.Items.Add("Stretch Image");
            cb_goruntulenmeSekli.Items.Add("Zoom");
            cb_goruntulenmeSekli.SelectedIndexChanged += Cb_goruntulenmeSekli_SelectedIndexChanged;
            cb_goruntulenmeSekli.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.Controls.Add(cb_goruntulenmeSekli);
        }

        private void Cb_goruntulenmeSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_goruntulenmeSekli.SelectedItem.ToString();
            switch (secilen)
            {
                case "Auto Size":
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "Center Image":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "Normal":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Stretch Image":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Zoom":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }

        private void btn_klasorSec_Click(object sender, EventArgs e)
        {
            //pictureBoxIleDoldur();
            UserKontrolIleDoldur();
        }

        private void UserKontrolIleDoldur()
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                DirectoryInfo klasor = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                List<FileInfo> resimler = klasor.GetFiles().ToList();
                foreach (FileInfo item in resimler)
                {
                    if (item.Extension == ".jpg" || item.Extension == ".png" || item.Extension == ".jpeg")
                    {
                        ResimVeIsimControl usercontrol = new ResimVeIsimControl(item.FullName, item.Name);
                        flowLayoutPanel1.Controls.Add(usercontrol);
                    }
                }
            }
        }

        private void pictureBoxIleDoldur()
        {
            DialogResult sonuc = folderBrowserDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;

                DirectoryInfo klasor = new DirectoryInfo(path);
                List<FileInfo> dosyalar = klasor.GetFiles().ToList();
                foreach (FileInfo item in dosyalar)
                {
                    if (item.Extension == ".jpg" || item.Extension == ".png" || item.Extension == ".jpeg")
                    {
                        PictureBox resimtasiyici = new PictureBox();
                        resimtasiyici.Cursor = Cursors.Hand;
                        resimtasiyici.Click += Resimtasiyici_Click;
                        resimtasiyici.SizeMode = PictureBoxSizeMode.Zoom;
                        resimtasiyici.Size = new Size(200, 100);
                        resimtasiyici.ImageLocation = item.FullName;
                        flowLayoutPanel1.Controls.Add(resimtasiyici);
                    }
                }
            }
        }

        private void Resimtasiyici_Click(object sender, EventArgs e)
        {
            PictureBox resim = (PictureBox)sender;
            pictureBox1.ImageLocation = resim.ImageLocation;
        }
    }
}
