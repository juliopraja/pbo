namespace pertemuan_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
             NilNilai();   

        }
        private static void NilNilai()
        {

            int Nkehadiran;
            double Ntugas, Nuts, Nuas, NTotal;
            string YN = "Y";
            do
            {
               

                Console.WriteLine("Masukkan nilai kehadiran:");
                Nkehadiran = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Masukkan nilai tugas:");
                Ntugas = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Masukkan nilai uts:");
                Nuts = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Masukkan nilai uas:");
                Nuas = Convert.ToInt16(Console.ReadLine());
                NTotal = (Nkehadiran * 0.1) + (Ntugas * 0.2) + (Nuts * 0.3) + (Nuas * 0.4);
                Console.WriteLine("Nilai akhir anda adalah:{0}", NTotal);
                Console.WriteLine("Mau hitung nilai lagi Y/N only:");
                YN = Console.ReadLine();

            } while (YN.ToLower() == "y");
           
        }
        private static void Konversi()
        {
            int nil;
            Console.WriteLine("Masukkan nilai antara 1-100:");
            nil = Convert.ToInt32(Console.ReadLine());
            if (nil <= 10)

            {
                double dNil = Convert.ToDouble(nil);
                string str = "Gacor!";
                Console.WriteLine("Convert to double success: {0},{1}", dNil, str);
            }
            else if (nil > 10 && nil <= 100)
            {
                float fNil = Convert.ToSingle(nil);
                Console.WriteLine("Convert to float success: {0}", fNil);
            }
            else { Console.WriteLine("diluar nalar!"); }
        }
    }
}
