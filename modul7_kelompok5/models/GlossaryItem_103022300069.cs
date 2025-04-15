using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//using static modul7_kelompok5.models.Glossary;

namespace modul7_kelompok5.models
{
    public class GlossaryItem
    {
        [JsonPropertyName("glossary")]
        public Glossary Glossary { get; set; }
    }

    public class Glossary
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("GlossDiv")]
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("GlossList")]
        public GlossList GlossList { get; set; }
    }

    public class GlossList
    {
        [JsonPropertyName("GlossEntry")]
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossEntry
    {
        [JsonPropertyName("ID")]
        public string ID { get; set; }

        [JsonPropertyName("SortAs")]
        public string SortAs { get; set; }

        [JsonPropertyName("GlossTerm")]
        public string GlossTerm { get; set; }

        [JsonPropertyName("Acronym")]
        public string Acronym { get; set; }

        [JsonPropertyName("Abbrev")]
        public string Abbrev { get; set; }

        [JsonPropertyName("GlossDef")]
        public GlossDef GlossDef { get; set; }

        [JsonPropertyName("GlossSee")]
        public string GlossSee { get; set; }
    }

    public class GlossDef
    {
        [JsonPropertyName("para")]
        public string Para { get; set; }

        [JsonPropertyName("GlossSeeAlso")]
        public string[] GlossSeeAlso { get; set; }
    }

    class GlossaryItem_103022300069
    {
        public Glossary glossary { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_3_103022300069.json");

            string jsonString = File.ReadAllText(filePath);

            GlossaryItem_103022300069 glossaryHafizh = JsonSerializer.Deserialize<GlossaryItem_103022300069>(jsonString);

            Console.WriteLine($"{glossaryHafizh.glossary.GlossDiv.GlossList.GlossEntry.ID}");
            
        }
    }
}
