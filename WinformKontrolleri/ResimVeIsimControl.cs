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
    public partial class ResimVeIsimControl : UserControl
    {
        public ResimVeIsimControl()
        {
            InitializeComponent();
        }
        public ResimVeIsimControl(string imagepath, string name)
        {
            InitializeComponent();
            pictureBox1.ImageLocation = imagepath;
            label1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
