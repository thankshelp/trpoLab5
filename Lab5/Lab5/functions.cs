using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class functions
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public double con(double a)
        {
          return a * 2.54;
            
        }

        public bool chet(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int max(int[] m)
        {
            int max = 0;
            for(int i = 0; i < 5; i++)
            {
                if (m[i] > max)
                    max = m[i];
            }
            return max;
        }

        public int ost(int a, int b)
        {
            return a % b;
        }

    }
}
