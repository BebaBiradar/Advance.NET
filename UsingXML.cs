using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Xml;
using System.Xml.Serialization;

namespace SerializationDemo
{
    [Serializable]
    public class Student1
    {
        public int rno { get; set; }
        public String name { get; set; }
        public int percentage { get; set; }
    }

    class UsingXML
    {
        static void XmlSerializationWrite(Student1 stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\XmlFile.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Student1));
                xs.Serialize(fs, stud);
                Console.WriteLine("Xml data added..");
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void XmlSerializationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\XmlFile.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Student1));
                Student1 stud = (Student1)xs.Deserialize(fs);
                Console.WriteLine(stud.rno);
                Console.WriteLine(stud.name);
                Console.WriteLine(stud.percentage);
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Student1 stud1 = new Student1 { rno = 111, name = "Ashwini", percentage = 88 };
            XmlSerializationWrite(stud1);
            XmlSerializationRead();
            Console.ReadLine();
        }

    }
}
}
