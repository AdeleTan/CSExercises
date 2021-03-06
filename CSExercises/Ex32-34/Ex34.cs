using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] Marks = new int[,]{{56,84,68,29}, {94,73,31,89}, {41,63,36,90}, {99,9,18,17},{62,3,65,75},{40,96,53,23},
                                {81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};
            string[] Student = new string[] { "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "S11", "S12" };
            int[] Total_Marks = new int[12];
            int[] Avg_Marks = new int[12];
            int[] Total_Student_Avg = new int[12];
            string[] Subject = new string[] { "Subject1", "Subject2", "Subject3", "Subject4" };
            int i, j;
            for (i = 0; i <= Student.Length - 1; i++)
            {
                Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4}", Student[i], Marks[i, 0], Marks[i, 1], Marks[i, 2], Marks[i, 3]);
            }
            /////////////////////////////////////////////
            i = 0; j = 0;
            Console.WriteLine("Total Scores of Sub1 to Sub4 for Students");
            for (i = 0; i <= Student.Length - 1; i++)
            {
                Total_Marks[i] = 0;

                for (j = 0; j <= 3; j++)
                {
                    Total_Marks[i] = Total_Marks[i] + Marks[i, j];
                }
                Console.WriteLine("{0} \t{1}", Student[i], Total_Marks[i]);
            }
           

                ////////////////////////////////////////////

                i = 0; j = 0;

            Console.WriteLine("Average Score of Marks for Each Subject");
  
            for (j = 0; j <= Subject.Length - 1; j++)
            {
                Avg_Marks[j] = 0;
                int SubjectTotal = 0;
                for (i = 0; i <= Student.Length - 1; i++)
                {
                    SubjectTotal = SubjectTotal + Marks[i, j];
                 }
                Avg_Marks[j] = SubjectTotal / 12;
                Console.WriteLine("{0} \t{1} ", Subject[j], Avg_Marks [j]);
               
            }
            
            //////////////////////////////////////////////
            int sum = 0;
            for (i = 0; i <= Student.Length - 1; i++)
            {
                sum += Total_Marks[i];
            }

            Console.WriteLine("The overall average score of all students for all subjects is {0}", sum / 12);
        }
    }
}