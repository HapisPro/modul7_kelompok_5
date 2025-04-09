using modul7_kelompok5.models;
using System;

namespace tpmodul7_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300127 Hizkia = new DataMahasiswa_103022300127();
            TeamMembers_103022300127 TeamHizkia = new TeamMembers_103022300127();
            GlossaryItem_103022300127 GlossaryHizkia = new GlossaryItem_103022300127();
            Hizkia.ReadJSON();
            Console.WriteLine("");
            TeamHizkia.ReadJSON();
            Console.WriteLine();
            GlossaryHizkia.ReadJSON();
            Console.WriteLine();
        }
    }
}