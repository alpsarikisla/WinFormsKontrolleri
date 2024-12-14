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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            GirisForm frm = new GirisForm();
            frm.ShowDialog();

            toolStripStatusLabel1.Text = "Kullanıcı = " + LoginUser.user.FullName;
        }

        private void TSMI_kategori_Click(object sender, EventArgs e)
        {
            DataGridKontrolu frm = new DataGridKontrolu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void TSMI_urunler_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikmi = false;
            foreach (Form item in acikFormlar)
            {
                if (item.GetType() == typeof(UrunlerForm))
                {
                    item.Activate();
                    acikmi = true;
                }
            }
            if (!acikmi)
            {
                UrunlerForm frm = new UrunlerForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
