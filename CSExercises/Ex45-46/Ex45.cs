using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int i = 0;
            double amt, amt100;
            int amtI;


            int[] Denomination = new int[] { 100, 50, 20, 10, 5 };

            int[] CountofDenomination = new int[5];
           

            Console.WriteLine("Please input an amount in dollar.cents");
            amt = Convert.ToDouble(Console.ReadLine());
            amt100 = amt * 100;
            amtI = Convert.ToInt32(amt100);
           
            

            for (i = 0; i <= 4; i++)
            {
                CountofDenomination[i] = amtI / Denomination[i]; 
                amtI = amtI % Denomination[i];
            }
           for (i = 0; i <= 4; i++)
            {
            
            Console.WriteLine("The number of {0} cents demonimation is {1}", Denomination[i], CountofDenomination[i]);
            }
            }
        }
    }


    
