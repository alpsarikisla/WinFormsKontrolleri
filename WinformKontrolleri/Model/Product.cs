using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformKontrolleri.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short UnitsInStock { get; set; }
        public short ReorderLevel { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
}
