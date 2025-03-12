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
                Console.WriteLine($"{ namaProduk,-18} { KodeProduk.getKodeProduk(produk)}");
            }

            FanLaptop fan = new FanLaptop();
            Console.WriteLine("\nSimulasi Perubahan Fan Laptop");
            fan.ActivateState(FanLaptop.Trigger.Mode_Up);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
            fan.ActivateState(FanLaptop.Trigger.Mode_Up);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
            fan.ActivateState(FanLaptop.Trigger.Mode_Down);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
            fan.ActivateState(FanLaptop.Trigger.Mode_Down);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
            fan.ActivateState(FanLaptop.Trigger.Turbo_Shortcut);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
            fan.ActivateState(FanLaptop.Trigger.Mode_Down);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
            fan.ActivateState(FanLaptop.Trigger.Mode_Up);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
            fan.ActivateState(FanLaptop.Trigger.Turbo_Shortcut);
            Console.WriteLine($"Fan Laptop saat ini: {fan.CurrentState}");
        }
    }
}
