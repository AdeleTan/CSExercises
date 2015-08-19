using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the distance travelled");
            double fare = Convert.ToDouble(System.Console.ReadLine());

            double fare1 = 2.4 + (0.4 * fare);

            System.Console.WriteLine("The fare for the distance travelled is {0:###}", System.Math.Ceiling(fare1));
 
        }
    }
}
