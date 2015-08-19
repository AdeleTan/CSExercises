
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter distance travelled");
            double distance = System.Convert.ToDouble(System.Console.ReadLine());
            double dist90 = (2.40) + (85 * 0.04) + (distance*10 - 90) * 0.05; 
            double dist85 = 2.40 + (distance*10 - 0.5) * 0.04;

            if (distance < 0)
            {
                System.Console.WriteLine("Distance entered is errorenous");
            }
            else if (distance < 0.5)
            {
                System.Console.WriteLine("Your fare is $2.40");
            }

            else if (distance < 9)
            {
                System.Console.WriteLine("Your fare is {0:c}", System.Math.Round(dist85, 2));
            }
          
     else
      {
                System.Console.WriteLine("Your fare is {0:c}", System.Math.Round(dist90, 2));
            }
        }
    }
}

          

