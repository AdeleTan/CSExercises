using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter salary of employee");

            string salary = System.Console.ReadLine();
            double salary1 = Convert.ToDouble(salary);
          
            double housing = (1.0/10) * salary1;
     
            double transportation = (3.0 / 100) * salary1;

            double income = salary1 + housing + transportation;

            System.Console.WriteLine("The employee's total income is the total of salary {0:c}, housing allowance {1:c}, transportation allowance {2:c} : {3:c}", salary1, housing, transportation, income);
       

        }
    }
}
