using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to convert a given sentence to title case");
            string s = Console.ReadLine();
            string sUpper = s.ToUpper();
            string s1, sUpper1;
            char[]output = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                s1 = s.Substring(i, 1);
                sUpper1 = sUpper.Substring(i, 1);
                if (s1[i] == sUpper1[i])
                {
                    output[i] = s1[i];
                }
                else
                    output[i] = sUpper1[i];
                Console.WriteLine("{0}", output[i]);
            }
            }
            }
}
