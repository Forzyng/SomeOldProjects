using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Encodings.Web;

namespace Reflex
{
    class Program
    {
        static Dictionary<String, String> CreateDictionary(Dictionary<String, String> EngRus)
        {
            EngRus = new Dictionary<string, string>();
            EngRus.Add("Language", "Язык");
            EngRus.Add("Landscape", "Ландшафт");
            EngRus.Add("Array", "Массив");
            EngRus.Add("Variable", "Переменная");
            EngRus.Add("Variant", "Вариант");
            return EngRus;
        }
        static void Main(string[] args)
        {
            Dictionary<String, String> EngRus = new Dictionary<string, string>();
            #region Create | Output
            //EngRus.Add("Language", "Язык"); // = new Dictionary<string, string>()
            //EngRus.Add("Landscape", "Ландшафт");
            //EngRus.Add("Array", "Массив");
            //EngRus.Add("Variable", "Переменная");
            //EngRus.Add("Variant", "Вариант");

            //var query1 = from pair in EngRus
            //             select pair;

            //foreach( var pair in query1)
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    Console.WriteLine("=============================");
            //    Console.Write("| ");
            //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //    Console.Write("{0, -9} ", pair.Key);
            //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    Console.Write("-|- ");
            //    Console.ForegroundColor = ConsoleColor.DarkGray;
            //    Console.Write("{0, -11} ", pair.Value);
            //    Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    Console.WriteLine("|");
            //}
            #endregion
            //EngRus = CreateDictionary(EngRus);
            ConsoleKeyInfo info;
            do
            {
                ShowMenuDictionary();
                do
                {
                    info = Console.ReadKey(true);
                } while (info.KeyChar < '0' || info.KeyChar > '7');
                Console.WriteLine();
                Console.WriteLine();
                switch (info.KeyChar)
                {
                    case '0':
                        Console.WriteLine("Bye!");
                        break;
                    case '1':
                        FindWord(EngRus);
                        break;
                    case '2':
                        SaveJson(EngRus);
                        ShowCaseSave("Json");
                        break;
                    case '3':
                        EngRus = LoadJson(EngRus);
                        ShowCaseLoad("Json");
                        break;
                    case '4':
                        SaveBin(EngRus);
                        ShowCaseSave("Bin");
                        break;
                    case '5':
                        EngRus = LoadBin(EngRus);
                        ShowCaseLoad("Bin");
                        break;
                    case '6':
                        EngRus = AddRecord(EngRus);
                        break;
                    case '7':
                        ShowCaseShow(EngRus);
                        break;
                }
            } while (info.KeyChar != '0');

            Console.ReadKey(true);
        }

        static void ShowMenuDictionary()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t\t\t===================================\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\n\t\t\t\t\tPress any Key> ");
            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t████  ████  ███  ███  ████  █  █");
            Console.WriteLine("\t\t\t\t\t█  █  █  █   █    █   █  █  ██ █   █");
            Console.WriteLine("\t\t\t\t\t████  █      █    █   █  █  █ ██");
            Console.WriteLine("\t\t\t\t\t█  █  █  █   █    █   █  █  █  █   █");
            Console.WriteLine("\t\t\t\t\t█  █  ████   █   ███  ████  █  █");
            
            //1
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t1) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Find word");
            Console.ForegroundColor = ConsoleColor.DarkRed;

            //2
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t\t2) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Save in Json");

            //3

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t3) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Load From Json");

            //4
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t\t4) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Save in Bin");

            //5
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t5) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Load From Bin");

            //6
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t\t6) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Add new words");

            //7
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t7) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Show");

            //0
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t\t0) ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Exit");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nPress Key> ");
        }

        static void ShowCaseLoad(String name)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t\t\t==============================");
            Console.Write("\t\t\t\t\t|");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Dictionary Loaded From ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("{0, -4}", name);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" |");
            Console.WriteLine("\t\t\t\t\t==============================");
            Console.WriteLine();
        }

        static void ShowCaseSave(String name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t\t\t==========================");
            Console.Write("\t\t\t\t\t|");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Dictionary saved in ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("{0, -4}", name);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|");
            Console.WriteLine("\t\t\t\t\t==========================");
            Console.WriteLine();
        }

        static void ShowCaseShow(Dictionary<String, String> EngRus)
        {
            Console.Clear();
            ConsoleKeyInfo info1;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t1) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Show Eng");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t\t2) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Show Rus");
            Console.WriteLine();
            Console.Write("\t\t\t\t\tPress Key> ");
            do
            {
                info1 = Console.ReadKey(true);
            } while (info1.KeyChar < '1' || info1.KeyChar > '2');
            if (info1.KeyChar == '1')
            {
                ShowDictionaryEng(EngRus);
            }
            if (info1.KeyChar == '2')
            {
                ShowDictionaryRus(EngRus);
            }
        }




        static void FindWord(Dictionary<String, String> EngRus)
        {

            Console.Clear();
            ConsoleKeyInfo info1;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t1) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Find ENG word");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t\t\t\t\t\t2) ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("- ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Find RUS word");
            Console.WriteLine();
            Console.Write("\t\t\t\t\tPress Key> ");
            do
            {
                info1 = Console.ReadKey(true);
            } while (info1.KeyChar < '1' || info1.KeyChar > '2');
            if (info1.KeyChar == '1')
            {
                FindWordEng(EngRus);
            }
            if (info1.KeyChar == '2')
            {
                FindWordRus(EngRus);
            }

        }
        static void FindWordEng(Dictionary<String, String> EngRus)
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n\t\t\t\t\tEnglish: ");
            String EngWord = Console.ReadLine();
            ShowDictionaryUP("ENG", "RUS");
           
            var query1 = from pair in EngRus
                         where pair.Key.ToLower().Equals(EngWord.ToLower())
                         select pair;
          
           
            foreach (var s in query1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t\t\t\t===================================");
                Console.Write("\t\t\t\t\t| ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("{0, -13} ", s.Key);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("-|- ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("{0, -13} ", s.Value);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("|");
            }
            if (query1.Count() == 0)
            {
                var query2 = from pair in EngRus
                             where pair.Key.ToLower().Contains(EngWord.ToLower())
                             select pair;

                foreach (var s in query2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\t\t\t\t\t===================================");
                    Console.Write("\t\t\t\t\t| ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("{0, -13} ", s.Key);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("-|- ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("{0, -13} ", s.Value);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("|");
                }
            }

        }


        static void FindWordRus(Dictionary<String, String> EngRus)
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\n\t\t\t\t\tRussian: ");
            String RusWord = Console.ReadLine();
            ShowDictionaryUP("RUS", "ENG");

            var query1 = from pair in EngRus
                         where pair.Value.ToLower().Equals(RusWord.ToLower())
                         select pair;

            foreach (var s in query1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t\t\t\t===================================");
                Console.Write("\t\t\t\t\t| ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("{0, -13} ", s.Value);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("-|- ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("{0, -13} ", s.Key);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("|");
            }
            if (query1.Count() == 0)
            {
                var query2 = from pair in EngRus
                             where pair.Value.ToLower().Contains(RusWord.ToLower())
                             select pair;

                foreach (var s in query2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\t\t\t\t\t===================================");
                    Console.Write("\t\t\t\t\t| ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("{0, -13} ", s.Value);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("-|- ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("{0, -13} ", s.Key);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("|");
                }
            }

        }


        static void SaveJson(Dictionary<String, String> EngRus)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            using (StreamWriter writer = new StreamWriter("Dictionary.json"))
            {
                writer.Write(JsonSerializer.Serialize(EngRus, EngRus.GetType(), options));
            }
        }

        static void SaveBin(Dictionary<String, String> EngRus)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            using (FileStream writer = new FileStream("Dictionary.bin", FileMode.Create))
            {
                serializer.Serialize(writer, EngRus);
            }
        }

        static Dictionary<String, String> LoadBin(Dictionary<String, String> EngRus)
        {

            BinaryFormatter formatt = new BinaryFormatter();
            using (FileStream reader = new FileStream("Dictionary.bin", FileMode.Open))
            {
                EngRus = (Dictionary<String, String>)formatt.Deserialize(reader);
            }
            return EngRus;
        }

        static Dictionary<String, String> LoadJson(Dictionary<String, String> EngRus)
        {
            using(StreamReader reader = new StreamReader("Dictionary.json"))
            {
                EngRus = (Dictionary<String, String>)JsonSerializer.Deserialize(reader.ReadToEnd(), typeof(Dictionary<String, String>));
            }
            return EngRus;
        }

        static Dictionary<String, String> AddRecord(Dictionary<String, String> EngRus)
        {
            Console.Write("\nEnglish: ");
            String Eng = Console.ReadLine();
            Console.Write("\nRussian: ");
            String Rus = Console.ReadLine();
            EngRus.Add(Eng, Rus);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nAdded");
            Console.WriteLine();
            return EngRus;
        }

        static void ShowDictionaryEng(Dictionary<String, String> EngRus)
        {

            ShowDictionaryUP("ENG", "RUS");

            var query1 = from pair in EngRus
                         orderby pair.Key
                         select pair;

            foreach (var pair in query1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t\t\t\t===================================");
                Console.Write("\t\t\t\t\t| ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("{0, -13} ", pair.Key);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("-|- ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("{0, -13} ", pair.Value);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("|");
            }
        }
        static void ShowDictionaryRus(Dictionary<String, String> EngRus)
        {
            ShowDictionaryUP("RUS", "ENG");
            var query1 = from pair in EngRus
                         orderby pair.Value
                         select pair;

            foreach (var pair in query1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\t\t\t\t\t===================================");
                Console.Write("\t\t\t\t\t| ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("{0, -13} ", pair.Value);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("-|- ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("{0, -13} ", pair.Key);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("|");
            }
        }

        static void ShowDictionaryUP(String name, String name1)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\t\t\t\t\t===================================");
            Console.Write("\t\t\t\t\t| ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("{0, -13}", name);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("--|-- ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("{0, -13}", name1);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("|");
        }
    }



    //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Data));

    //            // 3. Файл
    //            using (StreamWriter TextWriter = new StreamWriter(FileName))
    //            {
    //                // 4. Сериализация - сохранения данных
    //                xmlSerializer.Serialize(TextWriter, data);
    //            }
    //Console.WriteLine("============================");

    //// Десериализация - восстановление объекта из сохраненного состояния
    //Data data2;
    //using (StreamReader textReader = new StreamReader(FileName))
    //{
    //    data2 = (Data)xmlSerializer.Deserialize(textReader);
    //}
    //Console.WriteLine(data2);


    /*
     * Serialization - построение последовательности
     * DeSerialization - обратный процес
     * Есть несколько сериализаторов
     * BinaryFormatter
     * XmlSerializer
     * JsonSerializer
     * 
     * LINQ
     * query - запрос/ объект - инструкция / праило для select
     * 
     * C#
     * ссылочный - объекты размещаютя в HEAP, в переменных хранятся адреса
     * ООП
     * Новые инструменты LINQ, Serialize, NuGet
     * 
     * .NET - платформа )среда выполнения, промежуточное ПО между операционной системой)
     * + Кроссплатформенность (независимость от "железа")
     * + Управляемые ресурсы (GC, try-catch)
     * - Плохая обратная совместимость
     * - Требуется установка (доп. ПО)
     * 
     */



}
