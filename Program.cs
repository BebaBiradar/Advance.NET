using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo
{
    //Using DirectoryInfo & file info class
    class Program
    {
        static void CreateFolder()
        {
            string path = @"E:\Advance C sharpe\TestFolder";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already exits");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder is created");
            }
        }
        static void FileCreate()
        {
            string path = @"E:\Advance C sharpe\FileFolder\TestFile.txt";
            if (Directory.Exists(path))
            {
                Console.WriteLine("File folder is already exits");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("File folder is Created");
            }
        }
        public class Course
        {
            int id;
            string name;
            int fees;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public int Fees { get => fees; set => fees = value; }
        }
        class AssignmentBinryWrRd
        {
            static void FileToWrite(Course cs)
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\Advance C sharpe\TestFolder\TextFile2", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(cs.Id);
                    bw.Write(cs.Name);
                    bw.Write(cs.Fees);
                    fs.Close();
                    bw.Close();
                    Console.WriteLine("File is create");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void ReadFromFile()
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\Advance C sharpee\TestFolder\TextFile1", FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    Console.WriteLine(br.ReadInt32());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadInt32());

                    br.Close();
                    fs.Close();
                    //Console.WriteLine("File is open");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void Main(string[] args)
            {
                Course cs = new Course { Id = 1, Name = "Riya", Fees = 10000 };
                FileToWrite(cs);
                ReadFromFile();
                Console.ReadLine();
            }
        }
    }
}
}
