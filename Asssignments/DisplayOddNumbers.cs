using System;

namespace CSharpAssignments
{
    public class DisplayOddNumbers
    {
        public void ShowOddNumbers()
        {
            Console.WriteLine("Odd numbers using for loop:");
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Odd numbers using while loop:");
            int j = 1;
            while (j < 20)
            {
                Console.WriteLine(j);
                j += 2;
            }

            Console.WriteLine("Odd numbers using do-while loop:");
            int k = 1;
            do
            {
                Console.WriteLine(k);
                k += 2;
            } while (k < 20);
        }
    }
}
