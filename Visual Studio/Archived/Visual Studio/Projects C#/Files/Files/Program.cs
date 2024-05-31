using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Работа с файлами
 * 1. Организация файлов (файловая система)
 * 2. Хранение данных (запись, чтение)
 * 
 */

using System.IO; // Input-Output

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Хранение данных
            // Прямой доступ
            String FileName1 = "File1.txt";
            String FileName2 = "File2.txt";
            String FileName3 = "File3.txt";
            String str1 = "String 1\r\nString 2\r\nString 3";
            String[] lines = { "Line 1", "Line 2", "Line 3" };

            #region Write
            //bool rewrite = false;
            //if(File.Exists(FileName1))
            //{
            //    Console.WriteLine("Overwrite? (Y/N): ");
            //    char c = Console.ReadKey().KeyChar;
            //    if(c == 'Y' || c != 'y')
            //    {
            //        rewrite = false;
            //        Console.WriteLine();
            //    }
            //}

            //if(rewrite)
            //{
            //    File.WriteAllText(FileName1, str1);
            //}

            //File.WriteAllLines(FileName2, lines);
            //File.WriteAllBytes(FileName3, Encoding.ASCII.GetBytes(str1));
            ////File.AppendAllText
            #endregion

            #region Read
            String[] lines2 = File.ReadAllLines(FileName2);
            foreach (String s in lines2)
            {
                Console.WriteLine(s);
            }
             //var list2 = lines2.ToList();
             //list2.Insert(2, "Additonal line");
             //File.WriteAllLines(FileName2, list2);
            //Console.WriteLine();
            //string secondLine = File.ReadLines("File3.txt").Skip(1).First();
            ////IEnumerable<string> result = File.ReadLines("File3.txt").Skip(0).Take(1);
            ////foreach (string str in result)
            ////{
            ////    Console.WriteLine(str);
            ////}
            //Console.WriteLine(secondLine);
            //Console.WriteLine();
            //Console.WriteLine("Done");
            //Console.WriteLine();

            //File.WriteAllText(FileName1, File.ReadAllText(FileName1).Replace(' ', '-'));
            //Console.WriteLine(File.ReadAllText(FileName1));
            #endregion


            //using (StreamWriter writer = new StreamWriter(FileName3))
            //using (StreamReader reader = new StreamReader(FileName1))
            //{
            //    //Console.WriteLine(reader.ReadToEnd());
            //    int c;
            //    while ((c = reader.Read()) != -1)
            //    {
            //        Console.WriteLine(c == '-' ? ' ' : (char)c);
            //    };
            //    writer.Write(c == '-' ? ' ' : (char)c);

            //}









            Console.ReadKey(true);
        }
            static void Main1(string[] args)
        {
            // 1. Организация файлов
            String dirName = @"..\..\";
            String[] dir = Directory.GetFiles("./"); // /bin/debug
            foreach(String f in dir)
            {
                Console.WriteLine( f + " " + File.GetCreationTime(f) + " " + File.GetAttributes(f));
            }

            Console.WriteLine("================================");

            foreach (String d in Directory.GetDirectories(dirName))
            {
                Console.WriteLine(d + "<DIR>" + d.Length);
            }

            Console.WriteLine("================================");

            DirectoryInfo di = new DirectoryInfo(dirName);
            FileInfo[] fi = di.GetFiles();
            foreach (var f in fi)
            {
                Console.WriteLine(f.Name + " " + f.CreationTime + " " + f.Length);
            }

            Console.WriteLine("================================");

            foreach (var d in di.GetDirectories())
            {
                Console.WriteLine(d.Name + " " + d.LastWriteTime);
            }


            Console.ReadKey(true);
        }
    }
}
