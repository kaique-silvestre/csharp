using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagementProgram
{
    internal class FileManagement
    {
        public static string folderpath = @"C:\dados\";
        public static string filepath = @"C:\dados\exercicios.txt";
        public static void CreateFile()
        {
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
            }
            if (!File.Exists(filepath))
            {
                using var fs = new FileStream(filepath, FileMode.Create);
                Console.WriteLine("The file has been created");
            }
            else
            {
                Console.WriteLine("[ATENTION]: The Folder and the File already exist");
            }
        }
        public static void AppendText(string? Text)
        {
            using var fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine(Text);
            }
        }
        public static void ReadText()
        {
            using var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            using (var sr = new StreamReader(fs))
            {
                var FileText = sr.ReadToEnd();
                Console.WriteLine(FileText);
            }
        }
        public static void SearchText()
        {
            Console.WriteLine("Type the text you want to find in the file");
            string? Text = Console.ReadLine();
            Console.WriteLine();
            
            using var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            using (var sr = new StreamReader(fs))
            {
                var count = 0;
                var found = false;
                while (!sr.EndOfStream)
                {
                    count++;
                    var result = sr.ReadLine();
                    if (result.Contains(Text))
                    {
                        Console.WriteLine($"Line {count}: {result}");
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("\nThere's no such text in the file");
                }
            }
        }
    }
}
