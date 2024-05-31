using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
    class ShowChain
    {
        public void Show()
        {
            // Создаем приемник
            var receiver = new Receiver();

            // Создаем цепочку обработчиков
            var r1 = new RandomHandler();
            var r2 = new RandomHandler();
            var r3 = new RandomHandler();
            var r4 = new OddEventHandler();
            var r5 = new OddEventHandler();

            // Добавляем их в приемник
            receiver.Add(r1);
            receiver.Add(r2);
            receiver.Add(r3);

            // Добавить без сохранения переменной

            receiver.Add(new RandomHandler());
            receiver.Add(new RandomHandler());
            receiver.Add(new RandomHandler());
            receiver.Add(new RandomHandler());
            receiver.Add(r4);
            receiver.Add(r5);

            //
            receiver.InsertBefore(new DoNothingHandler(), r2);
            receiver.Remove(r1);
            receiver.Remove(r2);
            receiver.Remove(r5);
            // Запускаем обработку
            receiver.Handle(100501);
            Console.WriteLine("=====================");
            receiver.Handle(100500);
        }
    }

    class Receiver
    {
        IHandler head;
        public bool Handle(int Event)
        {
            IHandler tmp = head; // tmp - ссылка на "звено", начинаем с головы
            while (tmp != null)
            {
                if(tmp.HandleEvent(Event))
                {
                    return true;
                }
                tmp = tmp.GetNext();
            }
            return false;
        }
        public void Add(IHandler handler)
        {
            if(head == null)
            {
                head = handler;
            }
            else
            {
                IHandler tmp = head; // tmp - ссылка на "звено", начинаем с головы
                while (tmp.GetNext() != null)
                {
                    tmp = tmp.GetNext(); // Передвигаем ссылку на следующее звено
                    // после цикла tmp - ссылка на последнее "звено"

                    
                }
                // В последнем звене устанавливаем (вместо null) ссылку на переданный handler
                tmp.SetNext(handler); // то есть tmp перестает быть последним
            }
        }
        public void Remove(IHandler handler)
        {
            if (handler == head)
            {
                head = handler.GetNext(); // сохранить ссылку на новую "голову"
            }
            else
            {
                IHandler tmp = head;
                while (tmp.GetNext() != handler)
                {
                    tmp = tmp.GetNext();
                    if (tmp == null)
                    {
                        throw new KeyNotFoundException("there`s no link");
                    }
                }
                tmp.SetNext(handler.GetNext()); 
            }
        }



        public void InsertBefore(IHandler handler, IHandler link)
        {
            // Insert handler before link - встроить обработчик перед указанным звеном
            // 1. Ищем это звено
            
            // a) Если необходимо встраивать перед "головой"
            if(link == head)
            {
                handler.SetNext(head); // Следующий за handler обработчик должен быть прошлой "головой"
                head = handler; // сохранить ссылку на новую "голову"
            }
            else
            {
                IHandler tmp = head;
                while (tmp.GetNext() != link)
                {
                    tmp = tmp.GetNext();
                    if(tmp == null)
                    {
                        throw new KeyNotFoundException("there`s no link");
                    }
                }
                handler.SetNext(tmp.GetNext());
                tmp.SetNext(handler);
                






            }
           
        }
     
    }

    public interface IHandler // Обработчик. Начало
    {
        void SetNext(IHandler handler); // не здаются поля / свойства
        IHandler GetNext(); //Вместо next, т.к. в интерфейсе

        bool HandleEvent(int Event); // ~ данные
    }

    abstract class  BaseHandler : IHandler 
    {
        IHandler next;
        public IHandler GetNext() => next;
        public void SetNext(IHandler handler)
        {
            next = handler;
        }
        public abstract bool HandleEvent(int Event);
    }

    class Rnd
    {
        static Random random;
        static public bool NextBool()
        {
            if(random == null)
            {
                random = new Random();
            }
            return random.Next(0, 1000) == 0;
        }

        static public int NextInt(int min, int max)
        {
            if(random == null)
            {
                random = new Random();
            }
            return random.Next(min, max + 1);
        }
    }

    class RandomHandler : BaseHandler
    {
       
        public override bool HandleEvent(int Event)
        {
            bool res = Rnd.NextBool();
            Console.WriteLine("RandomHandler - " + res);
            return res;
        }
    }

    class OddEventHandler : BaseHandler
    {

        public override bool HandleEvent(int Event)
        {
            bool res = (Event % 2) == 0;
            Console.WriteLine("OddEventHandler - " + res);
            return res;
        }
    }

    class DoNothingHandler : BaseHandler
    {
        public override bool HandleEvent(int Event)
        {
            Console.WriteLine("I am doing nothing...");
            return false;
        }
    }


}

/*
 * 
 * Chain-of-responsibility pattern
 * 
 *      1. "Всплытие" событий - каскад обработчиков,
 *      передающих событие до тех пор
 *      один из них не обработает событие
 *      
 *      2. Каскадная обработка запросов
 *      
 * Реализация
 * Суть - связанный список "передай дальше"
 * Sender - посылает событие / запрос
 * Receiver - запускает цепочку обработчиков
 * Handler - обработчик
 *      
 */