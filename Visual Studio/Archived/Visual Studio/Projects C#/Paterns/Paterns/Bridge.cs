using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paterns
{
    class ShowBridge
    {
        public void Show()
        {
            new Teacher().CheckTask();
            Console.WriteLine("=======");
            new Assistant().CheckTask();
        }
    }

    class Teacher
    {
        ILesson lesson;
        public void CheckTask()
        {
            lesson = new Physmat();
            Console.WriteLine(lesson.DoTask(100));
            lesson = new BioChem();
            Console.WriteLine(lesson.DoTask(80));
        }
    }

    interface ILesson
    {
        int DoTask(int value);
    }

    class Physmat : ILesson
    {
        public int DoTask(int value)
        {
            return Rnd.NextInt((int)(0.8*value), value);
        }
    }

    class BioChem : ILesson
    {
        public int DoTask(int value)
        {
            return Rnd.NextInt((int)(0.8 * value), value);
        }
    }

    class Assistant 
    {
        ILesson lesson;
        public void CheckTask()
        {
            lesson = new Physmat();
            Console.WriteLine(lesson.DoTask(80));
            lesson = new BioChem();
            Console.WriteLine(lesson.DoTask(80));
        }
    }

    class Genious : ILesson
    {
        public int DoTask(int value)
        {
            return Rnd.NextInt(0, value);
        }
    }


}

//Мост - "Оценитель"
// С одной стороны - Предмет (по разным предметам разные задания)
// С другой Группа (для разных групп критерии отличаются)