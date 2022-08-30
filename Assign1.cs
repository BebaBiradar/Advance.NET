using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo
{

    // Create a class Course with Id, Name & Fees properties,
    // Create a file to Write course details using BianaryWriter &
    // read the same using BinaryReader.
    public class Course
    {
        int id;
        String name;
        int fee;
        //  public int ID { get=>id; set=>id=value; }
        //public String Name { get=>name; set=>name=value; }
        // public int Fee { get=>fee; set=>fee=value; }
        public int Id { get; set; }
        public String Name { get; set; }
        public int Fee { get; set; }
    }
    class Assign1
    {
        static void CreateFolder()
        {
            String path = @"D:\FileFolder";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already Created...");
            }
            else
            {
                Console.WriteLine("Folder created...");
            }

        }
        static void CreateFile()
        {
            string path = @"D:\FileFolder\text1.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Already Created...");
            }
            else
            {
                Console.WriteLine("File  created...");
            }
        }
        static void WriteToFile(Course cs)
        {

            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\text1.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(cs.Id);
                bw.Write(cs.Name);
                bw.Write(cs.Fee);
                bw.Close();
                fs.Close();
                Console.WriteLine("Data added to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void ReadFile()
        {
            FileStream fs = new FileStream(@"D:\FileFolder\text1.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            br.Close();
            fs.Close();

        }
        static void Main(string[] args)
        {
            Course cs = new Course { Id = 1, Name = "JAVA", Fee = 12000 };
            WriteToFile(cs);
            ReadFile();
        }
    }
}
}
