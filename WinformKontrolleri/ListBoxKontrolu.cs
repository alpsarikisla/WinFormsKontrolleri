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
    public partial class ListBoxKontrolu : Form
    {
        public ListBoxKontrolu()
        {
            InitializeComponent();
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            //string secilen = lb_sehirListe.SelectedItem.ToString();
            //lbl_ekran.Text = secilen;

            string secilenler = "";
            foreach (var item in lb_sehirListe.SelectedItems)
            {
                secilenler += ", " + item.ToString();
            }
            lbl_ekran.Text = secilenler;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_sehir.Text))
            {
                lb_sehirListe.Items.Add(tb_sehir.Text);
                tb_sehir.Text = "";
            }
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            var liste = lb_sehirListe.SelectedItems;

            foreach (var item in liste)
            {
                lb_sehirListe2.Items.Add(item);
            }

            for (int i = lb_sehirListe.SelectedIndices.Count-1; i >= 0; i--)
            {
                int item = lb_sehirListe.SelectedIndices[i];
                lb_sehirListe.Items.RemoveAt(item);
            }
        }
    }
}
