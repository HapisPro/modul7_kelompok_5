using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

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
    public class DataMahasiswa_103022300058
    {
        public Address address { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Courses> courses { get; set; }

        public void ReadJSON()
        {
            string filePath = Path.GetFullPath("../../../../datas/jurnal7_1_103022300058.json");

            string jsonString = File.ReadAllText(filePath);

            DataMahasiswa_103022300058 dataBintang = JsonSerializer.Deserialize<DataMahasiswa_103022300058>(jsonString);
            Console.WriteLine($"Nama: {dataBintang.firstName} {dataBintang.lastName} \nUmur: {dataBintang.age} \nKelamin: {dataBintang.gender} " +
                $"\nAlamat: {dataBintang.address.streetAddress}, {dataBintang.address.city}, {dataBintang.address.state}");

            Console.WriteLine("\nMata Kuliah:");
            int i = 1;
            foreach (var course in dataBintang.courses)
            {
                Console.WriteLine($"MK{i} {course.code} - {course.name}");
                i++;
            }
        }
    }
}
