using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformKontrolleri
{
    public partial class PictureBoxKontrolu : Form
    {
        public PictureBoxKontrolu()
        {
            InitializeComponent();
            //pb_resim.ImageLocation = "../../Images/6c4be534-bd89-4116-9541-9cf344c6743f.png";
            pb_resim.ImageLocation = "../../Images/resim.jpg";
            pb_resim.SizeMode = PictureBoxSizeMode.Zoom;
            cb_sizemode.SelectedIndex = 1;
        }

        private void cb_sizemode_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilen = cb_sizemode.SelectedItem.ToString();
            switch (secilen)
            {
                case "Öylece Bırah":
                    pb_resim.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Resmi Sığdır":
                    pb_resim.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "Resmi Esnet":
                    pb_resim.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Resmi Ortala":
                    pb_resim.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                default:
                    break;
            }
        }
    }
}
