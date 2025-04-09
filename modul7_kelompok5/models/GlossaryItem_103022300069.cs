using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using static modul7_kelompok5.models.Glossary;

namespace modul7_kelompok5.models
{
    public class Glossary
    {
        public string title { get; set; }
        public GLossDiv glossdiv { get; set; }
        public class GLossDiv
        {
            public string title { get; set; }
            public GlossList glosslist { get; set; }

            public class GlossList
            {
                public GlossEntry glossentry { get; set; }
                public class GlossEntry
                {
                    public string ID { get; set; }
                    public string SortAs { get; set; }
                    public string GlossTerm { get; set; }
                    public string Acronym { get; set; }
                    public GlossDef glossdef { get; set; }
                    public class GlossDef
                    {
                        public string para { get; set; }
                        public string[] GlossSeeAlso { get; set; }
                    }
                    public string GlossSee { get; set; }
                }
            }
        }
    }
    class GlossaryItem_103022300069
    {
        public Glossary glossary { get; set; }
        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_3_103022300069.json");

            string jsonString = File.ReadAllText(filePath);

            GlossaryItem_103022300069 glossaryHafizh = JsonSerializer.Deserialize<GlossaryItem_103022300069>(jsonString);

            Console.WriteLine($"{glossaryHafizh.glossary.title}");
            
        }
    }
}
