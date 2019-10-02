using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "Sepatu";
            product.harga = "80.000";
            product.warna = "Abu Abu";
            ProductView productView= (ProductView)product;

        }
    }
}
