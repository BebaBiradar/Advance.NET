using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
//using System.Runtime.Serialization.Formatters.Json;
using System.IO;
using System.Text.Json;


namespace SerializationDemo
{

    public class Student3
    {
        int rollno;
        string name;
        double percentage;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }
    }
    class JSON_Demo
    {
        static void JsonSerializationWrite(Student3 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\JsonFile.soap", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Student3>(fs, stud);

                Console.WriteLine("Json data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void JsonSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\JsonFile.soap", FileMode.Open, FileAccess.Read);

                Student3 stud = JsonSerializer.Deserialize<Student3>(fs);
                Console.WriteLine(stud.Rollno);
                Console.WriteLine(stud.Name);
                Console.WriteLine(stud.Percentage);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Student3 stud = new Student3 { Rollno = 103, Name = "Ashwini", Percentage = 89 };
            JsonSerializationWrite(stud);
            JsonSerializationRead();
            Console.ReadLine();
        }
    }
}
}
