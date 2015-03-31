using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProblem3
{
   public class MethodProblem2
    {
       public int[] TwoLargestNumbers(int[] a)
       {
           int[] maxnumbers = new int[2];
           maxnumbers[0] = maxnumbers[1] = int.MinValue;

           for (int i = 0; i < a.Length; i++)
           {

               if (a[i] > maxnumbers[0])
               {
                   maxnumbers[1] = maxnumbers[0];
                   maxnumbers[0] = a[i];

               }
               else
               {
                   if (a[i] > maxnumbers[1])
                       maxnumbers[1] = a[i];
               }

           }
           return maxnumbers;
       }
    }
}
