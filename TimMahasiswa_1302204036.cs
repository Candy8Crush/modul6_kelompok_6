using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_kelompok_6
{
    class TimMahasiswa_1302204036
    {
        public TimMahasiswa[] mahasiswa { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal6_2_1302204036.json";

            string jsonString = File.ReadAllText(fileName);

            TimMahasiswa_1302204036 jsonData = JsonSerializer.Deserialize<TimMahasiswa_1302204036>(jsonString);

            this.mahasiswa = jsonData.mahasiswa;

            this.info();
        }

        public void info()
        {
            Console.WriteLine("List tim mahasiswa:");
            foreach (var team in members)
            {
                team.info();
            }
        }
    }

    class TimMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public void info()
        {
            Console.WriteLine(this.nim + " " + this.firstName + " " + this.lastName + " (" + this.age + " " + this.gender + ")");
        }
    }
}