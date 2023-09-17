using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkFive
{
    class Program
    {
        static public void Main()
        {
            MyMatrix matrix1 = new MyMatrix(5, 6);
            matrix1.Show();
            matrix1.Fill();
            Console.WriteLine("After filling");
            matrix1.Show();
            matrix1.ChangeSize(10, 10);
            Console.WriteLine("New size");
            matrix1.Show();
            matrix1.ShowPartialy(2, 2, 5, 5);



            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.WriteLine("MyList");
            for(int i = 0; i < list.GetAmount; i++)
            {
                Console.WriteLine(list[i]);
            }

            MyDictionary<int, string> dict = new MyDictionary<int, string>();
            dict.Add(0, "Apple");
            dict.Add(1, "Banana");
            dict.Add(2, "Coconut");
            Console.WriteLine("MyDictionary");
            for (int i = 0; i < dict.GetAmount; i++)
            {
                Console.WriteLine(dict[i]);
            }
            foreach(var diction in dict)
            {
                Console.WriteLine(diction);
            }
        }
    }
}
