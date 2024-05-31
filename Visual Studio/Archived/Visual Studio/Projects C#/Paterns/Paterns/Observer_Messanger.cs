using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
   public interface IMessage
    {
        object GetMessage();
    }

    public class TextMessage : IMessage
    {
        public String Message;
        public MessageType Type { get; set; }
        public TextMessage(String Message)
        {
            this.Message = Message;
        }
        public TextMessage(String Message, MessageType Type)
        {
            this.Message = Message;
            this.Type = Type;
        }
        public object GetMessage()
        {
            return Message;
        }
    }

    public class SMMMeassage : TextMessage
    {
        public SMMMeassage(String Message) : base(Message) { }
        public SMMMeassage(String Message, MessageType Type) : base(Message, Type) { }
    }

    public class CharMessage : IMessage
    {
        char value;
        public CharMessage(char value)
        {
            this.value = value;
        }

        public object GetMessage()
        {
            return value;
        }
    }

    public enum MessageType
    {
        Advertisment,
        Position,
        Action,
        Warning
    }

    public class NumericMessage : IMessage
    {
        double value;
        public NumericMessage(double value)
        {
            this.value = value;
        }

        public object GetMessage()
        {
            return value;
        }
    }

    class ShowObserverM
    {
        public void Show()
        {
            // Источник на события (новости)
            PizzeriaM RoundPizza = new PizzeriaM();

            // Подписчики на события

            PeopleM
               Slave1 = new PeopleM { Name = "Slave1" },
               Slave2 = new PeopleM { Name = "Slave2" };

            SMMM
                 Dungeon = new SMMM { Title = "Dungeon.com" },
                 Gym = new SMMM { Title = "GYM.org" };

            // Подписывание

            RoundPizza.AddObserver(Slave1);
            RoundPizza.AddObserver(Slave2);
            RoundPizza.AddObserver(Dungeon);
            RoundPizza.AddObserver(Gym);

            // Демонстрация

            RoundPizza.NotifyObservers(new SMMMeassage("Всем SLAVES появится в !Круглая пицца!"));
            //Thread.Sleep(2000);

            // Отказ от подписки

            RoundPizza.RemoveObserver(Gym);

            //
            NewspaperM
              SVOBODA = new NewspaperM { Title = "Svoboda" },
              RABSTVO = new NewspaperM { Title = "Rabstvo" };
            RoundPizza.AddObserver(SVOBODA);
            RoundPizza.AddObserver(RABSTVO);
            Console.WriteLine("======================================");

            RoundPizza.NotifyObservers(new TextMessage("Пицца за 300$", MessageType.Warning));
            Console.WriteLine("======================================");
            RoundPizza.NotifyObservers(new NumericMessage(-100));
            Console.WriteLine("======================================");
            RoundPizza.NotifyObservers(new CharMessage('!'));
            Console.WriteLine("======================================");

        }
    }

    public interface IObserverM // Наблюдатель - получатель события
    {
        void HandleEvent(IMessage msg);
    }

    public interface IObservableM // Subject - Источник события
    {
        void AddObserver(IObserverM o);
        void RemoveObserver(IObserverM o);
        void NotifyObservers(IMessage msg);
    }

    public class PizzeriaM : IObservableM
    {
        public List<IObserverM> Observers { get; set; } // Subscribers

        public PizzeriaM()
        {
            Observers = new List<IObserverM>();
        }
        public void AddObserver(IObserverM o)
        {
            Observers.Add(o);
        }

        public void NotifyObservers(IMessage msg)
        {
            foreach (IObserverM o in Observers)
            {
                //if (o as Newspaper != null)
                //{
                    o.HandleEvent(msg);
                //}

            }
        }

        public void RemoveObserver(IObserverM o)
        {
            Observers.Remove(o);
        }
    }


    class PeopleM : IObserverM
    {
        public String Name { get; set; }

        public void HandleEvent(IMessage msg)
        {
            if ((msg as TextMessage)?.Type != MessageType.Warning)
            {
                Console.WriteLine(Name + " got message " + msg.GetMessage());
            }
            else
            {
                Console.WriteLine(Name + " ignored message " + msg.GetMessage());
            }
        }
    }

    class SMMM : IObserverM
    {
        public String Title { get; set; }

        public void HandleEvent(IMessage msg)
        {
            if (msg as SMMMeassage != null)
            {
                Console.WriteLine(Title + " obtain message " + msg.GetMessage());
            }
            
        }
    }

    class NewspaperM : IObserverM
    {
        public String Title { get; set; }

        public void HandleEvent(IMessage msg)
        {
            if (msg as SMMMeassage != null)
            {
                Console.WriteLine(Title + " Receive message " + msg.GetMessage());
            }
        }
    }





}
