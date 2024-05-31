using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Управление ресурсам. Освобождение ресурсов
 * Ресурсы (ПК, ОС) то, из-за чего приложение может работать неправильно / не заработать
 * Память: (кол-во)
 * RAM,
 * Network, (очередь)
 * HDD,
 * SDD,
 * FDD
 * ОС (считанные экземпляры)
 * Открытые файлы
 * Открытые подключения
 * Графические ресурсы
 * 
 * 
 * ! Ресурсы перечисленного типа ограничены
 * и после использования их необходимо освобождать
 * Потоки (Threads)
 * 
 * RAM. - управляемые ресурсы (managed)
 * Обслуживается .NET - лучше не трогать
 * 
 * ОС (файлы) - неуправляемые ресурсы
 * Освобождаем - мы
 * 
 */

namespace ResourcesDisposition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример управляемого ресурса
            Console.WriteLine(GC.GetTotalMemory(false));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new char[] { 'H', 'e', 'l', 'l', 'o' });
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));

            // В cpp - это утечка памяти
            // в .NET - это зачистит Сборщик Мусора (GC Garbage Collector)

            var s = new char[] { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine(s);
            Console.WriteLine(GC.GetTotalMemory(false));

            // "Утечкой памяти" в ссылочных языках называют обратную ситуацию:
            // сохранение ссылки на уже ненужный объект
            // Рекомендуется (если нет возможности реорганизовать код)

            s = null;

            // Неуправляемые ресурсы (отданные на управление нам)
            // Для таких ресурсов разработан интерфей IDisposable
            // И окружение using(){}, после работы которого
            // автоматически вызываеться метод Dispose()
            // + локализация именованного объекта устраняет "Утечку памяти" 

            using (Disp res = new Disp(1))
            {
                res.Use();
                Console.ReadKey(true);
            }

            // Заменяет 

            Disp res2 = new Disp(2);
            res2.Use();
            res2.Dispose(); // Освобождение неуправляемых
            res2 = null; // -//- управляемых - на объект нет ссылок
            GC.Collect();



            Console.ReadKey(true);
        }
    }

    class Disp : IDisposable
    {
        public int n;
        public Disp(int n)
        {
            this.n = n;
        }
        public void Dispose()
        {
            Console.WriteLine("Resourced  Disposed - " + n);
        }
        public void Use()
        {
            Console.WriteLine("Recourse in use - " + n);
        }
        ~Disp() // Финализатор - НЕ деструктор
        {
            // ! Срабатывание не гарантируется
            Console.WriteLine("Bye... - " + n);
        }
    }



}
