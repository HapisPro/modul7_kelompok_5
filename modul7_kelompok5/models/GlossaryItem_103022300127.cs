using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5.models
{
    public class GlossDef {
        public string para { get; set; }
        public string GlossSeeAlso { get; set; }
    }
    public class GlossEntry {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }
    public class GlossList {
        public GlossEntry GlossEntry { get; set; }
    }
    public class GlossDiv{
        public string title { get; set; }
        public GlossList GlossList;
    }
    public class glossary { 
        public string title { get; set; }
        public GlossDiv glossDiv;
    }
    class GlossaryItem_103022300127
    {
        public glossary glos { get; set; }
        public void ReadJSON() {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_3_103022300127.json");

            string jsonString = File.ReadAllText(filePath);

            GlossaryItem_103022300127 glossary = JsonSerializer.Deserialize<GlossaryItem_103022300127>(jsonString);
            Console.WriteLine($"{glos.title} {glos.glossDiv.title} {glos.glossDiv.GlossList.GlossEntry.ID}" +
                $" {glos.glossDiv.GlossList.GlossEntry.SortAs} " +
                $"{glos.glossDiv.GlossList.GlossEntry.GlossTerm}" +
                $"{glos.glossDiv.GlossList.GlossEntry.Acronym} " +
                $"{glos.glossDiv.GlossList.GlossEntry.Abbrev} " +
                $"{glos.glossDiv.GlossList.GlossEntry.GlossDef.para} {glos.glossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso}" +
                $"{glos.glossDiv.GlossList.GlossEntry.GlossSee}");
        }
    }
}
