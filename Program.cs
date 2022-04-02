using System;
using System.IO;
using Newtonsoft.Json;

namespace modul6_kelompok_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string json = File.ReadAllText(@"C:\\Users\\user\\Downloads\\Rian\\Semester 4\\KPL\\PRAKTIKUM\\modul6_kelompok_6\\jurnal6_1_1302200040.json");
            DataMahasiswa1302200040 data = JsonSerializer.Deserialize<DataMahasiswa1302200040>(json);
            Console.WriteLine(data);

            string json2 = File.ReadAllText(@"C:\\Users\\user\\Downloads\\Rian\\Semester 4\\KPL\\PRAKTIKUM\\modul6_kelompok_6\\jurnal6_2_1302200040.json");
            DataMahasiswa1302200040 data2 = JsonSerializer.Deserialize<DataMahasiswa1302200040>(json2);
            Console.WriteLine(data2);

            string json3 = File.ReadAllText(@"C:\\Users\\user\\Downloads\\Rian\\Semester 4\\KPL\\PRAKTIKUM\\modul6_kelompok_6\\jurnal6_3_1302200040.json");
            DataMahasiswa1302200040 data3 = JsonSerializer.Deserialize<DataMahasiswa1302200040>(json3);
            Console.WriteLine(data2);
        }
    }
}
