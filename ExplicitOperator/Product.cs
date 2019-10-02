using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitOperator
{
    public class ProductView
    {
        public string name { set; get; } 
        public string harga { set; get; } 
        public string warna { set; get; }
        public static explicit operator ProductView(Product obj)
        {
            ProductView dto = new ProductView();
            dto.name = obj.name;
            dto.harga = "Rp. " + obj.harga;
            dto.warna = obj.warna;
            return dto;
        }
    }
    public class Product
    {
        public string name { set; get; }
        public string harga { set; get; }
        public string warna { set; get; }
    }
}
