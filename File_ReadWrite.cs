using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo
{

    class Dept
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
    }
    class File_ReadWrite
    {
        private static Dept dept;


        static void WriteToFile(Dept dept)
        {
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\FileFolder\test.txt", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(dept.ID);
                    bw.Write(dept.Name);
                    bw.Write(dept.Location);
                    bw.Close();
                    fs.Close();
                    Console.WriteLine("Data added to file");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"E:\FileFolder\test.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadString());
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        /*  static void CreateFolder()
          {
              String path = @"E:\FileFolder";
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
              string path = @"E:\FileFolder\Test1.txt";
              if (File.Exists(path))
              {
                  Console.WriteLine("File Already Created...");
              }
              else
              {
                  Console.WriteLine("File  created...");
              }
          }*/

        static void Main(string[] args)
        {
            Dept dept = new Dept { ID = 101, Name = "HR", Location = "Pune" };
            WriteToFile(dept);
            ReadFromFile();
        }
    }
}
}
