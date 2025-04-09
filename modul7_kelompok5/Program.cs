using System;
using modul7_kelompok5;
using modul7_kelompok5.models;

namespace modul7_kelompok5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300069 hafizh = new DataMahasiswa_103022300069();
            TeamMembers_103022300069 timHafizh = new TeamMembers_103022300069();
            GlossaryItem_103022300069 glossaryHafizh = new GlossaryItem_103022300069();
            hafizh.ReadJSON();
            Console.WriteLine("");
            timHafizh.ReadJSON();
            Console.WriteLine("");
            glossaryHafizh.ReadJSON();
        }
    }
}
