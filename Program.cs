using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_kelompok_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302204036 d = new DataMahasiswa_1302204036();

            d.ReadJSON();

            Console.WriteLine();

            TimMahasiswa_1302204036 s = new TimMahasiswa_1302204036();

            s.ReadJSON();

        }
    }
}
