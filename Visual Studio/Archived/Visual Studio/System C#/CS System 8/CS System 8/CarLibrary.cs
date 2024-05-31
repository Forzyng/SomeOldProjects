using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CS_System_8
{
    public class CarLibrary
    {
        private List<Car> cars;
        public List<Car> Cars => cars;
        public CarLibrary()
        {
            cars = new List<Car>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Car car in cars)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString();
        }
        public bool SaveToStream(Stream stream)
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(stream, cars);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }

        public bool LoadFromStream(Stream stream, bool cleartoload = true)
        {
            List<Car> buf = new List<Car>();
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                if(cleartoload)
                {
                    cars.Clear();
                }
                buf = (List<Car>)bf.Deserialize(stream);
                cars.AddRange(buf);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
