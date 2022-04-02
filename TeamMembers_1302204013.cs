using System;
using System.IO;
using Newtonsoft.Json;

namespace modul6_kelompok_6
{
    class TeamMembers_1302204013
    {
        public TeamMember[] Members { get; set; }

        public void ReadJson()
        {
            string fileName = "jurnal6_2_nim.json";

            string jsonString = File.ReadAllText(fileName);

            TeamMembers_1302204013 jsonData = JsonSerializer.Deserialize<TeamMembers_1302204013>(jsonString);

            this.Members = jsonData.Members;

            this.info();
        }

        public void info()
        {
            Console.WriteLine("Team member list:");
            foreach (var team in Members)
            {
                team.info();
            }
        }

        class TeamMember
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
}
