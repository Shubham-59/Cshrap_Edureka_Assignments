using System;

namespace CSharpAssignments
{
    public class DisplayEvenNumbers
    {
        public void ShowEvenNumbers()
        {
            Console.WriteLine("Even numbers using for loop:");
            for (int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Even numbers using while loop:");
            int j = 0;
            while (j <= 20)
            {
                Console.WriteLine(j);
                j += 2;
            }

            Console.WriteLine("Even numbers using do-while loop:");
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k += 2;
            } while (k <= 20);
        }
    }
}
