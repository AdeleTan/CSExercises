using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase");
            string phrase = Console.ReadLine();
            string lcphrase = phrase.ToLower();
            string vowels = "aeiou";
            int i, j;
            string s, v;


            int count = 0;
            for (i = 0; i < lcphrase.Length; i++)
            {
                s = lcphrase.Substring(i, 1);

                for (j = 0; j < vowels.Length; j++)
                {
                    v = vowels.Substring(j, 1);

                    {
                        if (s == v)
                        { count++; }
                    }
                }
            }
            Console.WriteLine("The total nos. of vowels in the phrase is {0}", count);

            

            for (j = 0; j < vowels.Length; j++)
            {
                v = vowels.Substring(j, 1);
                count = 0;
                for (i = 0; i < lcphrase.Length; i++)
                {
                    s = lcphrase.Substring(i, 1);
                  
                    {
                        if (v == s)
                        { count++; }
                    }
                }
                Console.WriteLine("The number of {0} in the phrase is {1}", v, count);

            }
        }
    }
    }
    