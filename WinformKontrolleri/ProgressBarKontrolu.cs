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
    public partial class ProgressBarKontrolu : Form
    {
        public ProgressBarKontrolu()
        {
            InitializeComponent();
        }

        private void btn_ilerle_Click(object sender, EventArgs e)
        {
            if (pb_cubuk.Value != 100)
            {
                pb_cubuk.Value += 10;
            }
            else
            {
                MessageBox.Show("Bitti Yaw Bitti", "Höd!!!!");
            }
        }

        private void ProgressBarKontrolu_Load(object sender, EventArgs e)
        {
            Doldur();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Doldur();
        }
        private void Doldur()
        {
            DateTime tarih = DateTime.Now;
            lbl_tarih.Text = tarih.ToString();

            pb_saat.Value = tarih.Hour;
            lb_saat.Text = tarih.Hour.ToString();

            pb_dakika.Value = tarih.Minute;
            lb_dakika.Text = tarih.Minute.ToString();

            pb_saniye.Value = tarih.Second;
            lb_saniye.Text = tarih.Second.ToString();
        }

       
    }
}
