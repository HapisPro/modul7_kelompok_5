﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5.models
{
    public class Members
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
    class TeamMembers_103022300069
    {
        public List<Members> members { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_2_103022300069.json");

            string jsonString = File.ReadAllText(filePath);

            TeamMembers_103022300069 timHafizh = JsonSerializer.Deserialize<TeamMembers_103022300069>(jsonString);
           
            Console.WriteLine("\nTeam member list:");
            int i = 1;
            foreach (var member in timHafizh.members)
            {
                Console.WriteLine($"<{member.nim}> <{member.firstName} {member.lastName}> ({member.age} {member.gender})");
                i++;
            }
        }
    }
}
