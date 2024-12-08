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
    public partial class MetinAraclari : Form
    {
        public MetinAraclari()
        {
            InitializeComponent();
           
        }

        private void tb_sinirli_TextChanged(object sender, EventArgs e)
        {
            int count = tb_sinirli.Text.Length;
            lbl_count.Text = Convert.ToString(20 - count);
        }
    }
}
