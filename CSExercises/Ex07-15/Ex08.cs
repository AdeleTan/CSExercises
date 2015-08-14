using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the temperature in Centigrade scale");
            string Centigrade = System.Console.ReadLine();
            double Centigrade1 = Convert.ToDouble(Centigrade);
            double Fahrenheit = 1.8 * Centigrade1 + 32;
            System.Console.WriteLine("The Fahrenheit equivalent is {0}", Fahrenheit);

        }
    }
}
