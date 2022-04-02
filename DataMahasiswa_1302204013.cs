using Newtonsoft.Json;
using System;
using System.IO;


namespace modul6_kelompok_6
{
    internal class DataMahasiswa_1302204013
    {
        public class DataMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string courses { get; set; }
        }

        public static void ReadJson()
        {
           
            string file = "/Users/luthfi/Desktop/Kuliah/Semester 4/Konstruksi Perangkat Lunak/Modul6/modul6_kelompok_6/modul6_kelompok_6/jurnal6_1_1302204013.json";

            string str = File.ReadAllText(file);

            DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(str);

            Console.WriteLine($"Nama depan {dataMahasiswa.firstName} nama belakang {dataMahasiswa.lastName} gender {dataMahasiswa.gender} beralamat di {dataMahasiswa.address} mengambil matkul {dataMahasiswa.courses}");
        }
    }
}
