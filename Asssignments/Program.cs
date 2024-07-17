using CSharpAssignments;

namespace Asssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayHelloMessage helloMessage = new DisplayHelloMessage();
            helloMessage.ShowMessage();

            DisplayArithmeticOperations arithmeticOperations = new DisplayArithmeticOperations();
            arithmeticOperations.ShowOperations(10, 2);

            DisplayArithmeticWithChoice arithmeticWithChoice = new DisplayArithmeticWithChoice();
            arithmeticWithChoice.ShowOperationWithChoice(10, 2, '-');

            DisplayNameMultipleTimes nameMultipleTimes = new DisplayNameMultipleTimes();
            nameMultipleTimes.ShowNameMultipleTimes("Shubham");

            DisplayEvenNumbers evenNumbers = new DisplayEvenNumbers();
            evenNumbers.ShowEvenNumbers();

            DisplayOddNumbers oddNumbers = new DisplayOddNumbers();
            oddNumbers.ShowOddNumbers();

        }
    }
}
