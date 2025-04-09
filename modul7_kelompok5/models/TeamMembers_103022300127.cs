using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5.models
{
    class Members
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public String nim { get; set; }
    }
    class TeamMembers_103022300127 {
        public List<Members> members { get; set; }

        public void ReadJSON() {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_2_103022300127.json");

            string jsonString = File.ReadAllText(filePath);

            TeamMembers_103022300127 memberlist = JsonSerializer.Deserialize<TeamMembers_103022300127>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var members in memberlist.members)
            {
                Console.WriteLine($"{members.nim} {members.firstName} {members.lastName} {members.age} {members.gender}");
            }
        }
    }
}
        
    

    

