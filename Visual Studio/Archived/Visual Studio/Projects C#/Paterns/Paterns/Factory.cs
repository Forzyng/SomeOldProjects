using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
    class ShowFactory
    {
        public void Show()
        {
            Console.WriteLine("Hey yo, We have here some real good stuff: ");
            foreach (int coderValue in Enum.GetValues(typeof(Coders)))
            {
                Console.WriteLine(
                    "{0} - {1}",
                    coderValue,
                    Enum.GetName(typeof(Coders), coderValue));
            }
            Console.Write("U Need To Choose> ");
            int lang = 0;
            do
            {
                lang = Console.ReadKey(true).KeyChar - '0';
            } while (lang < 0 || lang > 3);
           
            Console.WriteLine("\n\n\n==================---------RES---------==================");

            Coder ConcreteCoder = new CodersFactory().CreateFactory((Coders)lang);
            Code ConcreteCode = ConcreteCoder.CreateCode("out <- Privet Poroshenko");
            Console.WriteLine("{0} --- {1}", ConcreteCode.GetCode(), ConcreteCode.GetAdditionalInfo());

            //Coder cppCoder = new CppCoder();
            //Code cppCode = cppCoder.CreateCode("out <- Hello world!");

            //Console.WriteLine(cppCode.GetCode());


            //Coder sharpCoder = new SharpCoder();
            //Code sharpCode = sharpCoder.CreateCode("out <- Hello world!" );

            //Console.WriteLine(sharpCode.GetCode());
            //Console.ReadKey(true);
        }
    }
    public enum Coders
    {
        Cpp,
        Sharp,
        Java,
        C
    }

    public class CodersFactory
    {
        public Coder CreateFactory(Coders coder)
        {
            switch (coder)
            {
                case Coders.Cpp:
                    return new CppCoder();
                case Coders.Sharp:
                    return new SharpCoder();
                case Coders.Java:
                    return new JavaCoder();
                case Coders.C:
                    return new CCoder();
            }
            return null;
        }
    }

    public interface Coder // Creator
    {
        Code CreateCode(String algo);
    }
    public interface Code // Product
    {
        String GetCode();
        String GetAdditionalInfo();
    }


    public class CppCode : Code //  concreteProductA
    {
        String code;
        String[] headers;

        public String GetCode() => code;
        public String[] GetHeader() => headers;
        public string GetAdditionalInfo() => String.Join(", ", headers);

        public CppCode(String code, String[] headers)
        {
            this.code = code;
            this.headers = headers;
        }
    }
    public class CppCoder : Coder // concreteCreatorA
    {
        public Code CreateCode(String algo)
        {
            return new CppCode
                (
                "std::cout(\"" + algo.Substring(algo.IndexOf("<-") + 2) + "\");", new string[] {"stdio.h", "iostream"}
                );
        }
    }


    public class SharpCode : Code // concreteProductB
    {
        String code;
        String AppConfig;

        public String GetCode() => code;
        public String GetAppConfig() => AppConfig;

        public string GetAdditionalInfo() => AppConfig;

        public SharpCode(String code, String AppConfig)
        {
            this.code = code;
            this.AppConfig = AppConfig;
            
        }
    }
    public class SharpCoder : Coder // concreteCreatorB
    {
        public Code CreateCode(String algo)
        {
            return new SharpCode
                (
                "Console.WriteLine(\"" + algo.Substring(algo.IndexOf("<-") + 2) + "\");", "<CONFIGURATION>"
                );
        }
    }


    public class JavaCode : Code 
    {
        String code;
        double version;

        public String GetCode() => code;
        public double GetVersion() => version;

        public string GetAdditionalInfo() => version.ToString();


        public JavaCode(String code, double version)
        {
            this.code = code;
            this.version = version;
        }
    }
    public class JavaCoder : Coder
    {
        public Code CreateCode(String algo)
        {
            return new JavaCode
                (
                "System.out.print(\"" + algo.Substring(algo.IndexOf("<-") + 2) + "\");", 5
                );
        }
    }


    public class CCode : Code
    {
        String code;
        String version;

        public String GetCode() => code;
        public String GetVersion() => version;

        public string GetAdditionalInfo() => version.ToString();


        public CCode(String code, String version)
        {
            this.code = code;
            this.version = version;
        }
    }
    public class CCoder : Coder
    {
        public Code CreateCode(String algo)
        {
            return new CCode
                (
                "puts(\"" + algo.Substring(algo.IndexOf("<-") + 2) + "\");", "<Last version>"
                );
        }
    }

}

/*
 * 
 * Задача - кодирование, используя синтаксис языка программирования
 * 
 * out <- Hello
 * CPP : std::cout("Hello")
 * C#  : Console.Write("Hello")
 * Java: System.out.print("Hello")
 * C   : puts("Hello")
 * 
 * 
 * Решение 1
 * class CppCode  {String Code; String[] headers }
 * class CppCoder {String CreateCode (String algolCode) }
 * 
 * class SharpCode  {String Code; String AppConfig }
 * class SharpCoder {String CreateCode (String algolCode) }
 * 
 * class JavaCode  {String Code; int version }
 * class JavaCoder {String CreateCode (String algolCode) }
 * 
 * -- Плохая расширяемость, невозможность переключаться "На лету"
 * 
 * Решение 2.
 * Фабрика: 
 * а) Общий интерфейс для Coder
 * б) Общий интерфейс для Code
 * 
 */
