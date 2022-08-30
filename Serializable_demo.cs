using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationDemo
{

    [Serializable]
    public class Student
    {
        public int rno { get; set; }
        public String name { get; set; }
        public int percentage { get; set; }
    }
    class Serializable_demo
    {
        static void BinarySerilizationWrite(Student stud)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\BinaryFile.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, stud);
                Console.WriteLine("Binary data Added....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void BinarySerilizationRead()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\BinaryFile.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Student stud = (Student)bf.Deserialize(fs);
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
        Student stud = new Student { rno = 101, name = "Ashwini", percentage = 89 };
        // CreateFolder();
        // CreateFile();

         BinarySerilizationWrite(stud);
        BinarySerilizationRead();
    }
}
