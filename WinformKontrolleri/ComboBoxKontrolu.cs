using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformKontrolleri.Model;

namespace WinformKontrolleri
{
    public partial class ComboBoxKontrolu : Form
    {
        List<Marka> markalar = new List<Marka>();
        public ComboBoxKontrolu()
        {
            InitializeComponent();
            //markalar.Add(new Marka() { ID = -1, Isim = "Marka Seçiniz" });
            markalar.Add(new Marka() { ID = 1, Isim = "Bosh" });
            markalar.Add(new Marka() { ID = 2, Isim = "Milwakie" });
            markalar.Add(new Marka() { ID = 3, Isim = "Hilti" });
            markalar.Add(new Marka() { ID = 4, Isim = "Black Decker" });

            cb_markalar.ValueMember = "ID";
            cb_markalar.DisplayMember = "Isim";
            cb_markalar.DataSource = markalar;
        }

        private void btn_departmanSec_Click(object sender, EventArgs e)
        {
            //string secilen = cb_departman.SelectedItem.ToString();
            string secilen = cb_departman.Text;
            if (secilen != "Seçiniz...")
            {
                lbl_secilenDepartman.Text = secilen;
            }
            else
            {
                lbl_secilenDepartman.Text = "Lütfen Seçim Yapınız";
            }
        }

        private void cb_Egitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cb_Egitim.SelectedItem.ToString();
            lbl_Egitim.Text = secilen;
        }

        private void btn_markaSec_Click(object sender, EventArgs e)
        {
            //string secilen = "ID = " + cb_markalar.SelectedValue.ToString();
            //secilen += "Isim = " + cb_markalar.SelectedItem.ToString();
            Marka m = (Marka)cb_markalar.SelectedItem;

            lbl_markaLabel.Text = "ID = " + m.ID + " Isim = " + m.Isim;
        }

        
    }
}
