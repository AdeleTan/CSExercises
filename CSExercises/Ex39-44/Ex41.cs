using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            int i, s1Len, s2Len;
            s1Len = s1.Length;
            s2Len = s2.Length;

            for (i = 0; i <= s1Len-1; i++)
            {
                if (s1.Substring(i, s2Len) == s2)
                {
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

    }
}

