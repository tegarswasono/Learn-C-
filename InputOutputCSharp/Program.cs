using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Nama: ");
            var nama = Console.ReadLine();

            Console.Write("Masukkan Alamat: ");
            var alamat = Console.ReadLine();

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Nama: "+nama);
            Console.WriteLine("Alamat: "+alamat);
        }
    }
}
