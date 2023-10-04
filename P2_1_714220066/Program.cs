using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hexane
{
    class Program
    {
        static void Main()
        {
            Console.Write("Masukkan angka pertama: ");
            double angkaPertama = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double angkaKedua = Convert.ToDouble(Console.ReadLine());

            double hasilTambah = angkaPertama + angkaKedua;
            double hasilKurang = angkaPertama - angkaKedua;
            double hasilKali = angkaPertama * angkaKedua;

            // Menghindari pembagian oleh nol
            double hasilBagi = (angkaKedua != 0) ? angkaPertama / angkaKedua : 0;

            Console.WriteLine($"{angkaPertama} + {angkaKedua} = {hasilTambah}");
            Console.WriteLine($"{angkaPertama} - {angkaKedua} = {hasilKurang}");
            Console.WriteLine($"{angkaPertama} * {angkaKedua} = {hasilKali}");
            Console.WriteLine($"{angkaPertama} / {angkaKedua} = {hasilBagi}");
            Console.ReadLine();
        }
    }
}


