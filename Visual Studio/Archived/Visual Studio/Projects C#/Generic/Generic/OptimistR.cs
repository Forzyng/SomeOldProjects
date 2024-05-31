using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public interface IReliable
    {
        bool LessThan(IReliable obj);
        bool GreaterThan(IReliable obj);
    }
    class OptimistR <T> where T : IReliable
    {
        T[] data;
        public void SetData(T[] data)
        {
            this.data = data;
        }

        public T FindMin()
        {
            T m = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].LessThan(m))
                {
                    m = data[i];
                }
            }
            return m;
        }

        public T FindMax()
        {
            T m = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].GreaterThan(m))
                {
                    m = data[i];
                }
            }
            return m;
        }
    }

    public class Number : IReliable
    {
        public double Value { get; set; }
        public bool GreaterThan(IReliable obj)
        {
            return this.Value > (obj as Number).Value;
        }
        public override string ToString()
        {
            return Value.ToString(); 
        }
        public bool LessThan(IReliable obj)
        {
            return this.Value < (obj as Number).Value;
        }
    }

    // Другой путь
    class OptimistU
    {
        public IReliable FindMin(IReliable[] data)
        {
            IReliable m = data[0];
            for(int i = 1; i < data.Length; i ++)
            {
                if (data[i].LessThan(m))
                {
                    m = data[i];
                }
            }
            return m;
        }

        public IReliable FindMax(IReliable[] data)
        {
            IReliable m = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i].GreaterThan(m))
                {
                    m = data[i];
                }
            }
            return m;
        }
    }





}
