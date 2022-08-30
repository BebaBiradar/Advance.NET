using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo
{
    class Assign2
    {
        static void CreateFolder()
        {
            String path = @"D:\FileFolder";
            DirectoryInfo ds = new DirectoryInfo(path);
            if (ds.Exists)
            {
                Console.WriteLine("Already present....");
            }
            else
            {
                Console.WriteLine("Folder Created...");
            }

        }
        static void CreateFile()
        {
            String path = @"D:\FileFolder\text2.txt";
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                Console.WriteLine("Already file present...");
            }
            else
            {
                Console.WriteLine("New file Created...");
            }
        }
        static void WriteFileusingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\text2.txt ", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter String:");
                String s = Console.ReadLine();
                sw.WriteLine(s);
                sw.Close();
                fs.Close();
                Console.WriteLine("String inserted...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\FileFolder\text2.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void Main(string[] args)
        {
            CreateFolder();
            CreateFile();
            WriteFileusingStream();
            ReadFromFileUsingStream();
        }

    }
}
}
