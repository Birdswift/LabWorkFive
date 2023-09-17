using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkFive
{
     class MyList<T>
    {
        T[] list;
        int amount;
        public MyList()
        {
            list = new T[0];
            amount = 0;
        }
        public void Add(T elem)
        {
            amount++;
            Array.Resize(ref list, amount);
            list[amount - 1] = elem;
        }

        public T this[int index1]
        {
            get
            {
                return list[index1];
            }
        }
        public int GetAmount { get { return amount; } }
    }
}
