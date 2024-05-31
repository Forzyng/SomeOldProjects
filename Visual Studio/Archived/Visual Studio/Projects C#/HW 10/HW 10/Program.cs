using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace HW_10
{
    public static class FileHelper
    {
        public static void GetAllFiles(string rootDirectory, string fileExtention, List<string> files)
        {
            string[] directories = Directory.GetDirectories(rootDirectory);
            files.AddRange(Directory.GetFiles(rootDirectory, fileExtention));

            foreach (string path in directories)
                GetAllFiles(path, fileExtention, files);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int SIZE = 0;


            string dirName = @"..\..\";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);
            int directoryCount = System.IO.Directory.GetDirectories(dirName).Length;

            Console.WriteLine(" Том в устройстве " + dirInfo.Root + " не имеет метки.");
            Console.WriteLine(" Серийный номер тома: VVVV-1111 ");
            Console.WriteLine();
            Console.WriteLine("Содержимое папки {0}", dirInfo.FullName);
            Console.WriteLine();
            FileInfo[] fi = dirInfo.GetFiles();


            foreach (var f in fi)
            {
                DateTime now = f.CreationTime;
                Console.WriteLine("{0:g}", now + " \t\t\t" + f.Length + " " +  f.Name);
                SIZE += (int)f.Length;
            }
            foreach (var d in dirInfo.GetDirectories())
            {
                Console.WriteLine(d.LastWriteTime + "\t <DIR> \t\t" + d.Name );
                SIZE += d.GetDirectories().Length;
            }
            Console.WriteLine("\t\t " +  fi.Length + "  Файлов\t\t" + SIZE + " байт");
            DriveInfo di = new DriveInfo(@"D:\");
            Console.WriteLine("\t\t " + Directory.GetDirectories(dirName).Length + "  Папок\t" + di.AvailableFreeSpace.ToString() + " байт свободно");
            Console.WriteLine();
            Console.Write(dirInfo.FullName);
            Console.WriteLine();
            Console.WriteLine();





            Console.WriteLine("Dictionary: ");
            Dictionary<String, String> dict = new Dictionary<string, string>();
            String FileName1 = "Dictionary.txt";
            String s10 = "";
            String s11 = "";


            List<String> slova = new List<string>();
            using (StreamReader sr = new StreamReader(FileName1))
            {
                while (!sr.EndOfStream)
                    slova.Add(sr.ReadLine());
            }
            string[] name = slova[0].Split(' ');
            string[] value = slova[1].Split(' ');



            for(int f = 0; f < slova.Count; f++)
            {
                name = slova[f].Split(' ');
                for (int i = 0; i < slova.Count; i++)
                {
                    if (i == 0)
                    {
                        s10 = Convert.ToString(name[i]);
                    }
                    else
                    {
                        s11 = Convert.ToString(name[i]);
                    }

                }
                dict.Add(s10, s11);
            }

            
            foreach (KeyValuePair<String, String> keyValue in dict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }



            Console.ReadKey(true);
        }
    }
}
