using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5.models
{
    public class GlossList
    { 
    public string GlossEntry { get; set; }
    }
    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public string GlossSee { get; set; }
    }
    public class GlossaryItem_103022300058
    {
        public GlossEntry glossentry { get; set; }
        public string para { get; set; }
        public string[] GlossSeeAlso { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_3_103022300058.json");

            string jsonString = File.ReadAllText(filePath);

            GlossaryItem_103022300058 glossaryBintang = JsonSerializer.Deserialize<GlossaryItem_103022300058>(jsonString);

            Console.WriteLine("\nGlossary Item:");

            for (int i = 0; i <= 0; i++)
            {
                //Console.WriteLine($"<{member.nim}> <{member.firstName} {member.lastName}> ({member.age} {member.gender})");
                Console.WriteLine(glossaryBintang.GlossSeeAlso[i]);
            }
        }

    }
}
