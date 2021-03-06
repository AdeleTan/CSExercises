using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int i, j;
            string firstStudentName, BestStudentScore;
            int firstStudentMarks, BestScore;
            string[] Name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] Marks = new[] { 62, 9, 75, 82, 55 };

            Console.WriteLine("Name \t Marks");
            for (i = 0; i < Name.Length; i++)
                Console.WriteLine("{0}\t {1}", Name[i], Marks[i]);

            // Sort by Name
            Console.WriteLine("Name \t Marks");
            for (i = 0; i < Name.Length - 1; i++)
            {
                firstStudentName = Name[i];
                firstStudentMarks = Marks[i];

                for (j = i + 1; j < Name.Length; j++)
                {
                    int check = Name[j].CompareTo(Name[i]);

                    if (check == -1)
                    // explaination of SWAP
                    //Betty (Name [1]) and Adele (Name [2]) to be sorted to Adele (Name [1]) then Betty (Name [2])
                    //temp = Name [1];
                    //when condition of Name [2] < Name [1] is met;
                    //temp = Name[2]; temp that is earlier assigned as Betty, I will now assign it with a value as Adele
                    //Name [2] = Name [1]; Name [2] that used to hold a value of Adele, I will now assigned it a value of Betty
                    //Name [1] = temp; temp that nows holds a value of Adele, I am now assigning this value to Name [1] 
                    {
                        firstStudentName = Name[j];
                        Name[j] = Name[i];
                        Name[i] = firstStudentName;
                        firstStudentMarks = Marks[j];
                        Marks[j] = Marks[i];
                        Marks[i] = firstStudentMarks;
                    }
                }
            }

            for (i = 0; i < Name.Length; i++)
            {
                Console.WriteLine("{0}\t {1}", Name[i], Marks[i]);
            }

            // Sorting value
            Console.WriteLine("Name \t Marks");
            for (i = 0; i < Marks.Length - 1; i++)
            {
                BestScore = Marks[i];
                BestStudentScore = Name[i];

                for (j = i + 1; j < Marks.Length; j++)
                {
                    if (Marks[i] < Marks[j])
                    {
                        BestScore = Marks[j];
                        Marks[j] = Marks[i];
                        Marks[i] = BestScore;
                        BestStudentScore = Name[j];
                        Name[j] = Name[i];
                        Name[i] = BestStudentScore;
                    }
                }
            }
            for (i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine("{0}\t {1}", Name[i], Marks[i]);
            }
        }
    }
}