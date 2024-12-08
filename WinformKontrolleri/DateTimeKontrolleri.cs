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
    public partial class DateTimeKontrolleri : Form
    {
        public DateTimeKontrolleri()
        {
            InitializeComponent();
            mc_takvim.MaxSelectionCount = 10;
            //mc_takvim.ShowToday = false;
            // mc_takvim.ShowTodayCircle = false;
            mc_takvim.ShowWeekNumbers = true;
            
        }

        private void btn_TarihGetir_Click(object sender, EventArgs e)
        {
            DateTime secilen = dtp_Dogum.Value;

            int saat = Convert.ToInt32(nud_saat.Value);
            int Dakika = Convert.ToInt32(nud_dakika.Value);

            lbl_Tarih.Text = secilen.ToString();
            lbl_KisaTarih.Text = secilen.ToShortDateString();//Sadece Tarih
            lbl_uzunTarih.Text = secilen.ToLongDateString();

            DateTime uretilen = Convert.ToDateTime(secilen.ToShortDateString() + " " + saat + ":" + Dakika);
            lbl_uretilen.Text = uretilen.ToString();
        }

        private void btn_aralik_Click(object sender, EventArgs e)
        {
            string aralik = mc_takvim.SelectionStart.ToShortDateString() + " - " + mc_takvim.SelectionEnd.ToShortDateString();
            lbl_aralik.Text = aralik;

            TimeSpan ts =  mc_takvim.SelectionEnd - mc_takvim.SelectionStart;
            int gun = Convert.ToInt32(ts.TotalDays);
            lbl_tarihfark.Text = gun.ToString();
        }
    }
}
