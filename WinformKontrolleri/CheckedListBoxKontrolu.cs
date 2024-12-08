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
    public partial class CheckedListBoxKontrolu : Form
    {
        public CheckedListBoxKontrolu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string diller = "";

            foreach (var item in clb_diller.CheckedItems)
            {
                diller += item.ToString() + " ";
            }
            lbl_ekran.Text = diller;
        }
    }
}
