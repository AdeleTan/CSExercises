using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int i, s1Len, s2Len;
            s1Len = s1.Length;
            s2Len = s2.Length;

            for (i = 0; i < s1Len - 1; i++)
            {
                if (s1.Substring(i, s2Len) == s2)
                {
                    return i;
                }
                else
                    return -1;
            }
            return -1;

        }
    }
}
