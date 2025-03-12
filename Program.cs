using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300088
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Produk Elektronik  Kode Produk");
            Console.WriteLine(" ");
            foreach (KodeProduk.Produk produk in Enum.GetValues(typeof(KodeProduk.Produk)))
            {
                string namaProduk = produk.ToString();
                Console.WriteLine($"{ namaProduk,-14} { KodeProduk.getKodeProduk(produk)}");
            }
        }
    }
}
