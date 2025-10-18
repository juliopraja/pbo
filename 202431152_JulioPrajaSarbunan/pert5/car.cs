using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pert5
{
    internal class car
    {
        string model, color;
        int year;

        public void honk()
        {
            Console.WriteLine("Mobil model{0}, warna {1}, tahun {2}, Honk.....Honk",
                model,color,year);
        }
    }
}
