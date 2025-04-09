using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok5.models
{
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Courses
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class DataMahasiswa_103022300127
    {
        public Address address { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_1_103022300127.json");

            string jsonString = File.ReadAllText(filePath);

            DataMahasiswa_103022300127 dataHizkia = JsonSerializer.Deserialize<DataMahasiswa_103022300127>(jsonString);
            Console.WriteLine($"Nama: {dataHizkia.firstName} {dataHizkia.lastName} \nUmur: {dataHizkia.age} \nKelamin: {dataHizkia.gender} " +
                $"\nAlamat: {dataHizkia.address.streetAddress}, {dataHizkia.address.city}, {dataHizkia.address.state}");

            Console.WriteLine("\nMata Kuliah:");
            int i = 1;
            foreach (var course in dataHizkia.courses)
            {
                Console.WriteLine($"MK{i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}   