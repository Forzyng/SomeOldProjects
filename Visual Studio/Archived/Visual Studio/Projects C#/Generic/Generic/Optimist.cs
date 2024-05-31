using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    /*
     * 
     * Оптимум - объединяющий термин для
     * минимум и максимум
     * 
     */



    class Optimist <T>
    {
        T[] data;
        public Optimist()
        {

        }

        public void SetData(T[] data)
        {
            this.data = data;
        }

        public T FindMin()
        {
            T m = data[0];
            for(int i = 1; i < data.Length; i++)
            {
                if(Convert.ToDouble(data[i]) < Convert.ToDouble(m))
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
                if (Convert.ToDouble(data[i]) > Convert.ToDouble(m))
                {
                    m = data[i];
                }
            }
            return m;
        }


    }

    


}
