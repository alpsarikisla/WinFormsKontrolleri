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
    public partial class ButtonKontrolu : Form
    {
        public ButtonKontrolu()
        {
            InitializeComponent();
        }

        private void btn_tikla_Click(object sender, EventArgs e)
        {
            this.Text = "Tıkladım Noolmuş";
            btn_tikla.Text = "Heeeeee";
            button1.Text = button2.Text = button3.Text = "Heeeeee";

        }

        private void btn_banana_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(lbl_counter.Text);
            sayi += 1;
            lbl_counter.Text = Convert.ToString(sayi);
        }
    }
}
