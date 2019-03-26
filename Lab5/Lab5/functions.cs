using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class functions
    {
        public double con(double a)
        {
            if (a >= double.MaxValue) throw new ArgumentException("Превышение максимального значения типа данных");
            if (a <= 0) throw new ArgumentException("Число должно быть > 0");
          return a * 2.54;
           
        }

        public bool chet(int a)
        {
            return (a % 2 == 0) ? true : false;
        }

        public int max(int[] m)
        {
            if (m.Length == 0) throw new ArgumentException("Массив пуст");

            int max = int.MinValue;
            for(int i = 0; i < 5; i++)
            {
                if (m[i] > max)
                    max = m[i];
            }
            return max;
        }

        public int ost(int a, int b)
        {
            if (b == 0) throw new ArgumentException("Делитель должен быть не равен 0");

            return a % b;
        }

    }
}
