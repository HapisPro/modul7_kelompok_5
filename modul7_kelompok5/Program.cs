using modul7_kelompok5.models;
using System;

namespace tpmodul7_kelompok_5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_103022300127 Hizkia = new DataMahasiswa_103022300127();
            Hizkia.ReadJSON();
            Console.WriteLine(""); ;
        }
    }
}