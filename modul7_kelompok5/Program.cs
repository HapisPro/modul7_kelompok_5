using System;
using modul7_kelompok5;
using modul7_kelompok5.models;

namespace modul7_kelompok5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300058 bintang = new DataMahasiswa_103022300058();
            TeamMembers_103022300058 teamBintang = new TeamMembers_103022300058();
            GlossaryItem_103022300058 gloss = new GlossaryItem_103022300058();
            bintang.ReadJSON();
            Console.WriteLine("");
            teamBintang.ReadJSON();
            Console.WriteLine("");
            gloss.ReadJSON();
        }
    }
}