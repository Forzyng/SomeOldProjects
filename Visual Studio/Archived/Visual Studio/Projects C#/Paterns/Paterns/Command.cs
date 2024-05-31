using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
    //class ShowCommand
    //{
    //    public void Show()
    //    {
    //        var rnd = new Random(); // Backend
    //        Console.WriteLine("\n\t\t1) - Random bool");
    //        Console.WriteLine("\t\t2) - Random Int");
    //        int choice = Console.ReadKey(true).KeyChar;
    //        if(choice == '1') // Frontend взаимодействие с пользователем
    //        {
    //            Console.WriteLine // Frontend
    //                (rnd.Next(2) == 0); // Backend
    //        }
    //        else
    //        {
    //            Console.WriteLine(rnd.Next());
    //            // Если
    //        }

    //        Console.WriteLine("\n\t\t1) - Random 0 - 10");
    //        Console.WriteLine("\t\t2) - Random 10 - 20");
    //        choice = Console.ReadKey(true).KeyChar;
    //        if (choice == '1')
    //        {
    //            Console.WriteLine(rnd.Next(11)); // DRY - Don`t Repeat Yourself
    //        }
    //        else
    //        {
    //            Console.WriteLine(rnd.Next(11, 21));
    //        }
    //    }
    //}

    abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
    // конкретная команда
    class CommandTo10 : Command
    {
        ReceiverCom receiver;
        public CommandTo10(ReceiverCom r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.OperationIntTo10();
        }

        public override void Undo()
        {
            //receiver = null;
        }
    }

    class CommandTo20 : Command
    {
        ReceiverCom receiver;
        public CommandTo20(ReceiverCom r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.OperationIntTo20();
        }

        public override void Undo()
        {
            //receiver = null;
        }
    }

    class CommandBool : Command
    {
        ReceiverCom receiver;
        public CommandBool(ReceiverCom r)
        {
            receiver = r;
        }
        public override void Execute()
        {
            receiver.OperationBool();
        }

        public override void Undo()
        {
            //receiver = null;
        }
    }

    // получатель команды
    class ReceiverCom
    {
        public void OperationIntTo10()
        {
            var rnd = new Random();
            Console.WriteLine(rnd.Next(11));
        }
        public void OperationIntTo20()
        {
            var rnd = new Random();
            Console.WriteLine(rnd.Next(11, 21));
        }
        public void OperationBool()
        {
            var rnd = new Random();
            Console.WriteLine(rnd.Next(2) == 0); 
        }
    }
    // инициатор команды
    class Invoker
    {
        Command command;
        public void SetCommand(Command c)
        {
            command = c;
        }
        public void Run()
        {
            command.Execute();
        }
        public void Cancel()
        {
            command.Undo();
        }
    }
    class User
    {
        public void Show()
        {
            Invoker invoker = new Invoker();
            ReceiverCom receiver = new ReceiverCom();

            Console.WriteLine("\n\t\t1) - Random bool");
            Console.WriteLine("\t\t2) - Random Int");
            int choice = Console.ReadKey(true).KeyChar;
            if (choice == '1') 
            {
                CommandBool command = new CommandBool(receiver);
                invoker.SetCommand(command);
            }
            else
            {
                Console.WriteLine("\n\t\t1) - Random 0 - 10");
                Console.WriteLine("\t\t2) - Random 10 - 20");
                choice = Console.ReadKey(true).KeyChar;
                if (choice == '1')
                {
                    CommandTo10 command = new CommandTo10(receiver);
                    invoker.SetCommand(command);
                }
                else
                {
                    CommandTo20 command = new CommandTo20(receiver);
                    invoker.SetCommand(command);
                }

            }

           
            invoker.Run();
        }

    }
}
