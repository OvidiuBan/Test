using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SimpleProblem3
{
    public class MethodProblem3
    {
        public bool ThereAreDuplicates(int[] a)
        {
            int gaussSum = 0, actualSum = 0;
            BigInteger multiply = 1, factorial = 1;
            int size = a.Length;
            for (int i = 0; i < size; i++)
            {
                actualSum += a[i];
                if (multiply == 0)
                    multiply = 1;
                multiply *= a[i];
                if (factorial == 0)
                    factorial = 1;
                factorial *= (i + 1);
            }
            gaussSum = size * (size + 1) / 2;
            if (gaussSum != actualSum)

                return true;
            else
                if (multiply != factorial)
                    return true;
            return false;
        }
        
      
       
    }
}
