namespace pert5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            persegi persegi = new persegi();
            persegi.sisi = 10;
            Console.WriteLine("persegi.sisi{0});
        }

        static void createPegawai()
        {
            Pegawai pegawai = new Pegawai();
            Console.WriteLine("Masukan nama anda:");
            pegawai.nama = Console.ReadLine();
            Console.WriteLine("Masukan nama anda:");
            pegawai.nama = Console.ReadLine();
            Console.Write(" pilih jenis anda P/L:");
            string jns = ""; double jH, GH;
            if (Console.ReadLine() == "p")
            { pegawai.jnskel = true; jns = "Perempuan"; }
            else { pegawai.jnskel = false; jns = "Laki-laki"; }

            Console.WriteLine("Masukan umur anda:");
            pegawai.umur = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Berapa hari anda bekerja bulan ini:");
            jH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Berapa gaji harian anda:");
            GH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Selamat {0},{1},umur {2}, tinggal di {3}", pegawai.nama, jns,
                pegawai.umur, pegawai.alamat);
            Console.WriteLine("Gaji anda bulan ini adalah: {0}", pegawai.hitGaji(jH, GH));
        }
        


        

    }

    class Pegawai
    {
        public string nama, alamat;
        public bool jnskel;
        public int umur;

        public double hitGaji(double jm1H, double Ngaji)
        {
            return jm1H * Ngaji;
        }
    }
}
