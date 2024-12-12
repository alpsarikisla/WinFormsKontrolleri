using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformKontrolleri.Model;

namespace WinformKontrolleri
{
    public partial class GirisForm : Form
    {
        bool islogin = false;
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //using otomatik olarak try-finally komutları üretir
            if (!string.IsNullOrEmpty(tb_userName.Text) && !string.IsNullOrEmpty(tb_password.Text))
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=true"))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT EmployeeID,FirstName,LastName, FirstName+' '+LastName FROM Employees WHERE UserName = @un AND Password = @pss";
                    cmd.Parameters.AddWithValue("@un",tb_userName.Text);
                    cmd.Parameters.AddWithValue("@pss", tb_password.Text);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    User u = null;
                    while (reader.Read())
                    {
                        u = new User();
                        u.ID = reader.GetInt32(0);
                        u.Name = reader.GetString(1);
                        u.Surname = reader.GetString(2);
                        u.FullName = reader.GetString(3);
                    }
                    if (u!= null)
                    {
                        LoginUser.user = u;
                        islogin = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }//using parantezi bittiği anda using içerisinde oluşturulan nesneyi Dispose eder(Yok eder)
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (islogin== false)
            {
                Application.Exit();
            }
        }
    }
}
