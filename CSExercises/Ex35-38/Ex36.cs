using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string Tphrase;
            string input = "";
            string output = "";
            bool IsPalindrome = false;
            
            Console.WriteLine("Please enter a phrase to test if it is a \"Palindrome\"?");
            string s = Console.ReadLine();
            Tphrase = s.ToLower ();

            for (int i = 0; i < Tphrase.Length; i++)
            {
                if ((Tphrase[i] != '.')  && (Tphrase [i] !='/') && (Tphrase [i] != ' '))
                {
                    input += Tphrase[i];
                }
            }
            
             for (int i = Tphrase.Length -1 ; i >= 0; i--)
            {
                if ((Tphrase[i] != '.')  && (Tphrase [i] !='/') && (Tphrase [i] != ' '))
                {
                    output += Tphrase[i];
                }
            }
            if (input == output)               
            {
                IsPalindrome = true;
            }
            if (IsPalindrome)

                Console.WriteLine("The phrase is a \"Palindrome\"");
            else
                Console.WriteLine("The prhase is not a \"Palindrome\"");
            
        }
            }

                 
        }
   

