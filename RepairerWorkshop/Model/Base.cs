using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairerWorkshop.Model
{
    public class Base<T>
        where T : Base<T>
    {
        public static Dictionary<int, T> Items = new Dictionary<int, T>();
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
