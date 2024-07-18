using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class DisplayTable
    {
        public void displayTable(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}");
            for (int i=1;i<=10;i++)
            {

                Console.WriteLine(i *number);
            }
        }

    }
}
