using System.Collections;

namespace LabWorkFive
{
    class MyMatrix
    {
        public int _m;
        public int _n;
        public int[,] _data;
        public MyMatrix(int m, int n)
        {
            _m = m;
            _n = n;
            Console.WriteLine("Please, input random generation key");
            int ch = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            _data = new int[_m, _n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _data[i, j] = random.Next(ch);
                }
            }
        }
        public void Fill()
        {
            Random random = new Random();
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _data[i, j] = random.Next();
                }
            }
        }

        public MyMatrix ChangeSize(int m, int n)
        {
            MyMatrix a = new MyMatrix(m, n);
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < _m && j < _n)
                    {
                        a._data[i, j] = _data[i, j];
                    }
                    else
                    {
                        a._data[i, j] = random.Next();
                    }
                }
            }
            return a;
        }
        public void ShowPartialy(int m1, int m2, int n1, int n2)
        {
            for (int i = m1; i < m2; i++)
            {
                for (int j = n1; j < n2; j++)
                {
                    Console.Write(this._data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void Show()
        {
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    Console.Write(this._data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int index1, int index2]
        {
            get
            {

                return _data[index1, index2];
            }
            set
            {
                _data[index1, index2] = value;
            }
        }
    }
}
