using System;

class PersegiNiBoss
{
    static void Main()
    {
        do
        {
            Console.WriteLine("Pilih operasi:");
            Console.WriteLine("1. Menghitung luas persegi");
            Console.WriteLine("2. Menghitung keliling persegi");

            // Membaca pilihan pengguna
            int pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    HitungLuasPersegi();
                    break;
                case 2:
                    HitungKelilingPersegi();
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    break;
            }
            Console.WriteLine("Ulangi Proses? Y/N");
        } 
        while (Console.ReadLine() == "Y" || Console.ReadLine() == "y");
    }

    static void HitungLuasPersegi()
    {
        Console.WriteLine("Masukkan panjang sisi persegi:");
        double sisi = Convert.ToDouble(Console.ReadLine());
        double luas = sisi * sisi;
        Console.WriteLine("Luas persegi adalah: " + luas);
    }

    static void HitungKelilingPersegi()
    {
        Console.WriteLine("Masukkan panjang sisi persegi:");
        double sisi = Convert.ToDouble(Console.ReadLine());
        double keliling = 4 * sisi;
        Console.WriteLine("Keliling persegi adalah: " + keliling);
    }
}