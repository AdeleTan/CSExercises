using System;
namespace CSExercises
{
    public class Ex22
    {


        public static void Main(string[] args)
        {
            int A;
            int Aoriginal;
            int Boriginal;
            int B;
            int HCF;
            int LCM;

            Console.Write("Enter A:");
            A = Aoriginal = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter B:");
            B = Boriginal = Convert.ToInt32(Console.ReadLine());
            int LargerNum, SmallerNum;
            if (A > B)
            
            {
                SmallerNum = Boriginal;
                LargerNum = Aoriginal;
            }
            else
            {
                SmallerNum = Aoriginal;
                LargerNum = Boriginal;
            }
        while (LargerNum != SmallerNum)    
        {
            LargerNum = LargerNum - SmallerNum;
            if (LargerNum < 0) { LargerNum = SmallerNum - LargerNum; } 
        }
            
            HCF = SmallerNum;
            LCM = ((Aoriginal * Boriginal) / HCF);
            Console.WriteLine("HCF: " + HCF);
            Console.WriteLine("LCM: " + LCM);
            string exit = Console.ReadLine();

        }
    }
}