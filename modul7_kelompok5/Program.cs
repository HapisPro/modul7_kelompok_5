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
            bintang.ReadJSON();
            Console.WriteLine("");
        }
    }
}