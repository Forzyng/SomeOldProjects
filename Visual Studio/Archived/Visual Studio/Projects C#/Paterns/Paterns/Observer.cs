using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Paterns
{
    class ShowObserver
    {
        public void Show()
        {
            // Источник на события (новости)
            Pizzeria RoundPizza = new Pizzeria();

            // Подписчики на события

            People
               Slave1 = new People { Name = "Slave1" },
               Slave2 = new People { Name = "Slave2" };

            SMM
                 Dungeon = new SMM { Title = "Dungeon.com" },
                 Gym = new SMM { Title = "GYM.org" };
          
            // Подписывание

            RoundPizza.AddObserver(Slave1);
            RoundPizza.AddObserver(Slave2);
            RoundPizza.AddObserver(Dungeon);
            RoundPizza.AddObserver(Gym);

            // Демонстрация

            RoundPizza.NotifyObservers("Всем SLAVES появится в !Круглая пицца!");
            Thread.Sleep(2000);

            // Отказ от подписки

            RoundPizza.RemoveObserver(Gym);

            //
            Newspaper
              SVOBODA = new Newspaper { Title = "Svoboda" },
              RABSTVO = new Newspaper { Title = "Rabstvo" };
            NewsMaker
                RABOTODATEL1 = new NewsMaker { Name = "RABOTODATEL1" },
                RABOTODATEL2 = new NewsMaker { Name = "RABOTODATEL2" };
            RoundPizza.AddObserver(SVOBODA);
            RoundPizza.AddObserver(RABSTVO);
            RoundPizza.AddObserver(RABOTODATEL1);
            RoundPizza.AddObserver(RABOTODATEL2);
            Console.WriteLine("======================================");

            RoundPizza.NotifyObservers("Пицца за 300$");
            Console.WriteLine("======================================");

        }
    }

    public interface IObserver // Наблюдатель - получатель события
    {
        void HandleEvent(string msg);
    }

    public interface IObservable // Subject - Источник события
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers(string msg);
    }

    public class Pizzeria : IObservable
    {
        public List<IObserver> Observers { get; set; } // Subscribers

        public Pizzeria()
        {
            Observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            Observers.Add(o);
        }

        public void NotifyObservers(String msg)
        {
           foreach(IObserver o in Observers)
            {
               
                    o.HandleEvent(msg);
                
               
            }
        }

        public void RemoveObserver(IObserver o)
        {
            Observers.Remove(o);
        }
    }


    class People : IObserver
    {
        public String Name { get; set; }

        public void HandleEvent(string msg)
        {
            Console.WriteLine(Name + " got message " + msg);
        }
    }

    class SMM : IObserver
    {
        public String Title { get; set; }

        public void HandleEvent(string msg)
        {
            Console.WriteLine(Title + " obtain message " + msg);
        }
    }

    class Newspaper : IObserver
    {
        public String Title { get; set; }

        public void HandleEvent(string msg)
        {
            Console.WriteLine(Title + " Receive message " + msg);
        }
    }

    class NewsMaker : IObserver
    {
        public String Name { get; set; }

        public void HandleEvent(string msg)
        {
            Console.WriteLine(Name + " Took message " + msg);
        }
    }
}

/*
 * 
 * Шаблон "Наблюдатель" - Observer
 * Реализация событийной модели
 * - Центр формирования события, принимает решение о "событии"
 * - Обработчики (подписчики) регистрируются на оповещение о событии
 * - Центр при "событии" оповещает подписчиков, точнее, запускает
 * определенный метод в каждом из них
 * 
 * People   <- |     got msg           - ConcreteObserver1: IObserver
 * SMM      <- |     obtain msg        - ConcreteObserver2: IObserver
 *             |     receive msg
 *             |
 * Pizzeria - "New Rest Opens!" - Subject: IObservable
 * 
 */