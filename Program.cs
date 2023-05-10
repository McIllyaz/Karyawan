using System;

namespace ResponsiPemrograman5156
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan_1 = new Karyawan();
            Karyawan karyawan_2 = new Karyawan();
            Karyawan karyawan_3 = new Karyawan();
            Karyawan karyawan_4 = new Karyawan();
            Karyawan karyawan_5 = new Karyawan();


            karyawan_1.NIK = 6471;
            karyawan_1.Nama = "Arya";
            karyawan_1.GajiBulanan = 50000000;

            karyawan_1.Print();
            karyawan_1.naikgaji();
            Console.WriteLine();


            karyawan_2.NIK = 6472;
            karyawan_2.Nama = "Ando";
            karyawan_2.GajiBulanan = 5000000;

            karyawan_2.Print();
            karyawan_2.naikgaji();
            Console.WriteLine();


            karyawan_3.NIK = 6473;
            karyawan_3.Nama = "Ardi";
            karyawan_3.GajiBulanan = 4000000;

            karyawan_3.Print();
            karyawan_3.naikgaji();
            Console.WriteLine();


            karyawan_4.NIK = 6474;
            karyawan_4.Nama = "Ardo";
            karyawan_4.GajiBulanan = 50000000;

            karyawan_4.Print();
            karyawan_4.naikgaji();
            Console.WriteLine();


            karyawan_5.NIK = 6475;
            karyawan_5.Nama = "Andi";
            karyawan_5.GajiBulanan = 4500000;

            karyawan_5.Print();
            karyawan_5.naikgaji();
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}