using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5.models
{
    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
    }
    class _GlossaryItem_103022300003
    {
        string filePath = Path.GetFullPath("../../../../datas/jurnal7_3_103022300003.json");
        //string jsonString = File.ReadAllText(filePath);

        TeamMembers_103022300003 memberList = JsonSerializer.Deserialize<TeamMembers_103022300003>(jsonString);
    }
}
