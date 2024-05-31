using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 * Pattern Builder (Строитель)
 * StringBuilder
 * 
 * Задание: разработать систему для вывода сообщений
 * обычное сообщение "текст"
 * сообщение об ошибке !!"текст"
 * важное сообщение -="текст"=-
 * важное сообщение об ошибке -=!!"текст"=-
 * особое важное / особая ошибка / особая важная ошибка
 * цветное сообщение
 * сообщение со смайликом "текст"))
 * 
 * Идея 1 (Плохая) создать множество класоов под все комбинации
 * 
 * Идея 2 (Шаблон)
 * 
 */

namespace Paterns
{
    interface MessageBuilder
    {
        void SetText(String text);
        void SetHighPriority();
        void SetErrorStatus();
        void SetSpecial();
        void SetForeColor(ConsoleColor color);
        void SetBackColor(ConsoleColor color);
    }

    interface FluidMessageBuilder
    {
        FluidMessageBuilder SetText(String text);
        FluidMessageBuilder SetHighPriority();
        FluidMessageBuilder SetErrorStatus();
        FluidMessageBuilder SetSpecial();
        FluidMessageBuilder SetForeColor(ConsoleColor color);
        FluidMessageBuilder SetBackColor(ConsoleColor color);
        void ShowMessage();
    }

    class FluidBuilder : FluidMessageBuilder
    {
        String text;
        public FluidMessageBuilder SetBackColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            return this;
        }

        public FluidMessageBuilder SetErrorStatus()
        {
            text = "!!" + text;
            return this;
        }

        public FluidMessageBuilder SetForeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            return this;
        }

        public FluidMessageBuilder SetHighPriority()
        {
            text = text.ToUpper();
            return this;
        }

        public FluidMessageBuilder SetSpecial()
        {
            text = "-=" + text + "=-";
            return this;
        }

        public FluidMessageBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public void ShowMessage()
        {
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    class ConsoleMessageBuilder : MessageBuilder
    {
        String text;
        public void SetBackColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void SetErrorStatus()
        {
            text = "!!" + text;
        }

        public void SetForeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void SetHighPriority()
        {
            text = text.ToUpper();
        }

        public void SetSpecial()
        {
            text = "-=" + text + "=-";
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void ShowMessage()
        {
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }

    class WindowMessageBuilder : MessageBuilder
    {
        String text;

        public void SetBackColor(ConsoleColor color)
        {
            throw new NotImplementedException();
        }

        public void SetErrorStatus()
        {
            text = "!!" + text;
        }

        public void SetForeColor(ConsoleColor color)
        {
            throw new NotImplementedException();
        }

        public void SetHighPriority()
        {
            text = text.ToUpper();
        }

        public void SetSpecial()
        {
            text = "-=" + text + "=-";
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void ShowMessage()
        {
            Console.WriteLine(System.Windows.Forms.MessageBox.Show(text));
        }
    }

    public class ShowBuilder
    {
        public void Show()
        {
            var cmb = new ConsoleMessageBuilder();
            cmb.SetText("vazhno");
            cmb.SetSpecial();
            cmb.SetHighPriority();
            cmb.SetForeColor(Console.ForegroundColor = ConsoleColor.Red);
            cmb.ShowMessage();

            //var cmb2 = new WindowMessageBuilder();
            //cmb2.SetText("vazhno");
            //cmb2.SetSpecial();
            //cmb2.SetHighPriority();
            //cmb2.ShowMessage();

            //var cmb3 = new FluidBuilder();
            //cmb3.SetText("OwO");
          
            //cmb3.SetBackColor(Console.ForegroundColor = ConsoleColor.White);
            //cmb3.SetForeColor(Console.ForegroundColor = ConsoleColor.Red);
            //cmb3.ShowMessage();
        }

    }

}
