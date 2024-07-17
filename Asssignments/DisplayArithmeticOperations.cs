using System;

namespace CSharpAssignments
{
    public class DisplayArithmeticOperations
    {
        public void ShowOperations(int a, int b)
        {
            Console.WriteLine($"Addition: {a + b}");
            Console.WriteLine($"Subtraction: {a - b}");
            Console.WriteLine($"Product: {a * b}");
            Console.WriteLine($"Quotient: {a / b}");
        }
    }
}
