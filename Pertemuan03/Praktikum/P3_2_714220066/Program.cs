using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan jumlah Anak Ayam");
        int jumlahAnakAyam = Convert.ToInt16(Console.ReadLine());

        if (jumlahAnakAyam <= 10 && jumlahAnakAyam >= 0)
        {
            while (jumlahAnakAyam > 0)
            {
                Console.WriteLine($"Anak ayam turunlah {jumlahAnakAyam}, mati satu tinggal {jumlahAnakAyam - 1}");
                jumlahAnakAyam--;
            }
        }
        else
        {
            Console.WriteLine("Emang kasihan sih anak ayamnya, masukin 0-10 aja.");
        }
    }
}