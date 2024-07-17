using System;

namespace CSharpAssignments
{
    public class DisplayArithmeticWithChoice
    {
        public void ShowOperationWithChoice(int a, int b, char operation)
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Addition: {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"Subtraction: {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"Product: {a * b}");
                    break;
                case '/':
                    Console.WriteLine($"Quotient: {a / b}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
