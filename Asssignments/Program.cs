using Assignments;
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

            DisplayTable displayTable = new DisplayTable();
            displayTable.displayTable(10);

            DisplayNumber100To500Gap3 displayNo=new DisplayNumber100To500Gap3();
            displayNo.displayNumber();

            DisplayIntegers dis=new DisplayIntegers();
            dis.displayIntegerNumber();

            DisplayIntegerSeperateLine display=new DisplayIntegerSeperateLine();
            display.DisplayVariablesOnSeparateLines();

        }
    }
}
