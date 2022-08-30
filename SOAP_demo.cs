using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace SerializationDemo
{

    [Serializable]
    public class Student2
    {
        int rollno;
        string name;
        double percentage;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Name { get => name; set => name = value; }
        public double Percentage { get => percentage; set => percentage = value; }
    }
    class SOAP_demo
    {
        static void SoapSerializationWrite(Student2 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\SoapFile.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, stud);
                Console.WriteLine("Soap data added");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void SoapSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\SoapFile.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                Student2 stud = (Student2)sf.Deserialize(fs);
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
            Student2 stud = new Student2 { Rollno = 103, Name = "Ashwini", Percentage = 89 };
            SoapSerializationWrite(stud);
            SoapSerializationRead();
            Console.ReadLine();
        }
    }
}

