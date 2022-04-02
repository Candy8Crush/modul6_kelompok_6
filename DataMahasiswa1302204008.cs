using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace modul6_kelompok_6
{
    internal class DataMahasiswa1302204008
    {
        public static void ReadJson()
        {
            public static void ReadJson()
            {
                //ngga tau cara install packagenya, pas klik manage nuget packages ngga kebuka-buka
                String jString = File.ReadAllText("jurnal6_1_1302204008.json");
                dynamic mahasiswa = JsonConvert.DeserializeObject(jString);
                Console.WriteLine(mahasiswa.firstname + " " + mahasiswa.lastname + " dengan umur " + mahasiswa.age + " dari " + mahasiswa.address);
            }

        }

        public class namaMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string age { get; set; }
            public string address { get; set; }
            public string courses { get; set; }

        }

    }
