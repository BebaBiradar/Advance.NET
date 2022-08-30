using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoDemo
{
    class File_Folder


        static void CreateFolder()
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
        string path = @"E:\FileFolder\Test.txt";
        if (File.Exists(path))
        {
            Console.WriteLine("File Already Created...");
        }
        else
        {
            Console.WriteLine("File  created...");
        }
    }

    // class File_Folder

    static void Main(string[] args)
    {
        File_Folder.CreateFolder();
        File_Folder.CreateFile();
    }
}
    }
}
