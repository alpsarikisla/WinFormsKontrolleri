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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }

        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            GridDoldur();
            dataGridView1.AutoSize = true;
            cb_kategori.DisplayMember = "Name";
            cb_kategori.ValueMember = "ID";
            ComboBoxDoldur();
            //dataGridView1.Columns[0].Width = 200;
        }
        public void GridDoldur()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=true"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT P.ProductID, P.ProductName,  P.ProductBarcodeNumber, P.SupplierID, S.CompanyName, P.CategoryID, C.CategoryName, P.QuantityPerUnit, P.UnitsInStock, P.UnitPrice, P.ReorderLevel,P.Discontinued FROM Products AS P JOIN Suppliers AS S ON P.SupplierID = S.SupplierID JOIN Categories AS C ON P.CategoryID = C.CategoryID";
                con.Open();
                DataTable dt = new DataTable();
               
                dt.Columns.Add("ID");
                dt.Columns.Add("Barkod");
                dt.Columns.Add("İsim");
                dt.Columns.Add("Kategori");
                dt.Columns.Add("Tedarikçi");
                dt.Columns.Add("Paketleme");
                dt.Columns.Add("Fiyat");
                dt.Columns.Add("Stok");
                dt.Columns.Add("Güvenlik Stok");
                dt.Columns.Add("Satışta mı");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string barkod = reader.IsDBNull(2) ? " ": reader.GetString(2);
                    string isim = reader.GetString(1);
                    string kategori = reader.GetString(6);
                    string tedarikci = reader.GetString(4);
                    string paketleme = reader.GetString(7);
                    short stok = reader.GetInt16(8);
                    decimal fiyat = reader.GetDecimal(9);
                    short guvenlikstogu = reader.GetInt16(10);
                    string satistami = reader.GetBoolean(11) ? "Satışa kapalı":"Satışta";
                    dt.Rows.Add(id, barkod, isim, kategori, tedarikci, paketleme, fiyat, stok, guvenlikstogu, satistami);
                }
                dataGridView1.DataSource = dt;
            }

        }
        public void ComboBoxDoldur()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=true"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(new Category()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Description = reader.IsDBNull(2) ? "" : reader.GetString(2)
                    });

                }
                cb_kategori.DataSource = categories;
                //foreach (Category item in categories)
                //{
                //    cb_kategori.Items.Add(item);
                //}
            }
        }

        private void btn_kategoriFormAc_Click(object sender, EventArgs e)
        {
            KategoriHizliEkleForm frm = new KategoriHizliEkleForm();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            //cb_kategori.Items.Clear();
            ComboBoxDoldur();
        }
    }
}
