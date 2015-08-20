using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] Database = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            for (int Green = 0; Green < Database.Length - 1; Green++)
            {
                for (int Red = Green + 1; Red < Database.Length; Red++)
                {
                    if (Database[Red] < Database[Green])
                    {
                        int temp = Database[Red];
                        Database[Red] = Database[Green];
                        Database[Green] = temp;
                    }
                }
            }
            for (int i = 0; i < Database.Length; i++)
            {
                Console.WriteLine("{0}\t", Database[i]);
            }
        }
    }
}