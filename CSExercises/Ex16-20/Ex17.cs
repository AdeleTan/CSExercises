namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter your name");
            string name = System.Console.ReadLine();

            System.Console.WriteLine("Please enter your gender (M or F) ");
            char gender = System.Convert.ToChar(System.Console.ReadLine());
            
            System.Console.WriteLine("Please enter your age");
            int age = System.Convert.ToInt32(System.Console.ReadLine());

            if (gender == char.Parse("M")) 
            {                
                if (age >= 40)
                {
                System.Console.WriteLine("Good Morning, Uncle {0}", name);
                }
                 
                else
                System.Console.WriteLine ("Good Morning Mr {0}", name);
            }

            else if (gender == char.Parse("F"))
            {

                if (age >= 40)
                {
                    System.Console.WriteLine("Good Morning, Aunty {0}", name);
                }

                else
                    System.Console.WriteLine("Good Morning Ms {0}", name);

            }
            else
                System.Console.WriteLine("You enter a wrong value for gender");  
        }
    }
}