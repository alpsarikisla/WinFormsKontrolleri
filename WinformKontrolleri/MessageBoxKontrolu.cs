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
    public partial class btn_kaydetcik : Form
    {
        public btn_kaydetcik()
        {
            InitializeComponent();
        }

        private void btn_standart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("İçerik", "Baslik");
            if (MessageBox.Show("İçerik", "Başlık") == DialogResult.OK)
            {
                MessageBox.Show("Onaylandı");
            }
        }

        private void btn_evetHayir_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Benimle Evlenir misin?", "Evlen", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                MessageBox.Show("Evet Seçildi");
            }
            else
            {
                MessageBox.Show("Hayır Seçildi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydetmek istiyor musun?", "Çıkış", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                MessageBox.Show("Kayıt Edildi", "Kayıt Başarılı");
                Application.Exit();
            }
            if (sonuc == DialogResult.No)
            {
                Application.Exit();
            }
            if(sonuc == DialogResult.Cancel)
            {
                MessageBox.Show("Kullanıcı çıkış işlemini iptal etti", "İptal edildi");
            }
        }

        private void btn_Dene_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Tekrar Denemek ister misin?", "Başarısız", MessageBoxButtons.RetryCancel);
            if (sonuc == DialogResult.Retry)
            {
                MessageBox.Show("Retry seçildi");
            }
            else
            {
                MessageBox.Show("Keşke Deneseydin?");
            }
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Görev Başarılamadı", "Başarısız", MessageBoxButtons.AbortRetryIgnore);
            if (sonuc == DialogResult.Abort)
            {
                MessageBox.Show("Abort seçildi");
            }
            if (sonuc == DialogResult.Retry)
            {
                MessageBox.Show("Retry seçildi");
            }
            if (sonuc == DialogResult.Ignore)
            {
                MessageBox.Show("Ignore seçildi");
            }
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilgilendirme", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_warning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uyarı", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_error_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hata", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nabün", "Question", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_formAc_Click(object sender, EventArgs e)
        {
            MetinAraclari frm_metin = new MetinAraclari();
            frm_metin.Show();
        }

        private void btn_sistemAc_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Diagnostics.Process.Start("calc");
            }
        }

        private void btn_formAc2_Click(object sender, EventArgs e)
        {
            MetinAraclari frm_metin = new MetinAraclari();
            frm_metin.ShowDialog();
        }
    }
}
