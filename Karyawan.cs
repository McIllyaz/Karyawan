using System;
namespace ResponsiPemrograman5156
{
	class Karyawan
	{
		public int NIK { get; set; }
		public string Nama { get; set; }
		private int gajiBulanan;


		public int GajiBulanan
		{
            get { return gajiBulanan; }
            set { gajiBulanan = value < 0 ? 0 : value; }
        }


		public void Print()
		{
			Console.WriteLine("NIK\t: {0}", NIK);
			Console.WriteLine("Nama\t: {0}", Nama);
			Console.WriteLine("Gaji\t: {0}", GajiBulanan);
		}

		public void naikgaji()
		{
			GajiBulanan += (int)(GajiBulanan * 0.1);
            Console.WriteLine("+ 10%\t: {0}", GajiBulanan);
        }
	}
}

