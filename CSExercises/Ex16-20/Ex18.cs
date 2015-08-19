namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your score");
            int score = System.Convert.ToInt32(System.Console.ReadLine());

            if ((score > 0) && (score < 100))
            {
                if (score > 79) 
                {
                    System.Console.WriteLine("You scored {0} marks which is A grade", score);
                }
                else if (score > 59)
                {
                    System.Console.WriteLine("You scored {0} marks which is B grade", score);
                }
                else if (score > 39)
                {
                    System.Console.WriteLine("You scored {0} marks which is C grade", score);
                }
                else if (score >= 0)
                {
                    System.Console.WriteLine("You scored {0} marks which is F grade", score);
                }

                          }
            else
            {
                System.Console.WriteLine("Your score is out of range");
            }
            string exit = System.Console.ReadLine();
        }
    }

}