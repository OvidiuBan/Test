using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProblem3
{
    public class MethodProblem1
    {
        public int SumOfEvenNumbers(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    sum += a[i];
            }
            return sum;
        }
    }
}
