using System;
namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {

            int i;
            string Ns = "";
            char[] c_arr = new char[s.Length];
           
            for (i = 0; i <= s.Length; i++)
            {
               c_arr [i] = Convert.ToChar(s.Substring(i,0));

                if (c_arr[i] == c1)
                {
                   c_arr[i] = c2;
                }
             }
            Ns = Convert.ToString(c_arr[i]);
            return Ns;                         
        }
    }
}
