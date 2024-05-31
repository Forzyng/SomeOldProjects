using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
    class ShowSingleton
    {
        public void Show()
        {
            // var rnd = new Singleton(); - NO
            var rnd = Singleton.GetInstance();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Generate());
            }
            var rnd2 = Singleton.GetInstance();
            Console.WriteLine(rnd == rnd2);

            rnd2.Seed(654321);
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd2.Generate());
            }
            Console.ReadKey(true);
        }
    }


    class Singleton
    {
        // Ссылка на единственный объект
        private static Singleton instance;

        // Получение ссылки
        public static Singleton GetInstance() 
        { 
            if(instance == null) // Если запрос первый - создание объекта
            {
                instance = new Singleton();
            } // Иначе возвращаем ссылку на ранее созданный объект
            return instance;
        }

        // Предотвращаем возможность создания других объектов
        private Singleton()
        {
            this.num = 100500;
        }

        // Динамическая (объектная) часть
        uint num;
        public uint Generate()
        {
            num = num * num % 123456;
            return num;
        }

        public void Seed(uint seed)
        {
            num = seed;
        }
    }
}

/*
 * 
 * Singlton (Одиночка)
 * Паттерн, обеспечивающий возможность создания
 * только одного объекта из класса
 * 
 * Используется для ресурсоемких объектов
 * на подобие сетевых подключений, ГПСЧ
 * 
 */
