using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220066
{
    class Program
    {
        static void Main(string[] args)
        {
            Uang uang = new Uang("Uang");
            uang.Cashier();

            Logam logam = new Logam("Logam", "Rp. 50, Rp. 100, Rp. 200, dan Rp. 500");
            logam.Cashier();

            Kertas kertas = new Kertas("Kertas", "Rp. 1000, Rp. 2000, Rp. 5000, Rp. 10000, Rp. 20000, Rp. 50000, Rp. 75000, dan Rp. 100000");
            kertas.Cashier();

        }

    }
}
