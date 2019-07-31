using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 1; 
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
            //while loop above doing same as for loop below but the for loop is more compact and easier to manage


            for (int a = 1; a <= 5; a++) // three things in paranthecies, value, condition, increment 
            {
                Console.WriteLine(a);

            }

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 }; // for loop with array

            for (int a = 0; a < luckyNumbers.Length; a++) // three things in paranthecies, value, condition, increment 
            {
                Console.WriteLine(luckyNumbers[a]);

            }


            Console.ReadLine();
        }
    }
}
