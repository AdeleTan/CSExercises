using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            int i, F = 1;
            for (i = 1; i <= n; i++)
            {
                F = F * i;
            }
         return F;   
        }
    }
}
