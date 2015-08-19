namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("Please enter your name");
            string name = System.Console.ReadLine();
            
            System.Console.WriteLine ("Please enter your gender (M or F) ");
           char gender = System.Convert.ToChar(System.Console.ReadLine());
           
            if (gender == char.Parse("M"))
                System.Console.WriteLine ("Good Morning, Mr {0}",name);

            else if (gender == char.Parse("F"))
                System.Console.WriteLine ("Good Morning, Ms {0}", name);

            else 
            System.Console.WriteLine ("You enter a wrong value for gender");
        }}

     }
