using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] MthofYear = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] MthlySales = new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200 };
            int TSales = 0;

            for (int i = 0; i < MthofYear.Length; i++)
            {
                Console.WriteLine("Enter Sales for {0} : \t {1} ", MthofYear[i], MthlySales[i]);
            }

            {//SWAP 
                for (int green = 0; green < MthofYear.Length - 1; green++)
                {
                    for (int red = green + 1; red < MthofYear.Length; red++)
                    {
                        if (MthlySales[red] < MthlySales[green])
                        {
                            int temp = MthlySales[red];
                            MthlySales[red] = MthlySales[green];
                            MthlySales[green] = temp;
                        }
                    }
                }
                Console.WriteLine("Maximum Sales: {0}", MthlySales[11]);
                Console.WriteLine("Minimum Sales: {0}", MthlySales[0]);

             for (int k = 0; k < MthlySales.Length; k++)
                 {
                            TSales = TSales + MthlySales[k];
                 }
                 Console.WriteLine("AvgSales: {0}", TSales / 12);

                    }
                }




            }
        }



