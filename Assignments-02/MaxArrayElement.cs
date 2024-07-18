using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_02
{
    internal class MaxArrayElement
    {


        public void MaxArray()
        {
            int[] numbers = { 3, 5, 7, 2, 8, -1, 4, 10, 12 };

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("The maximum element in the array is: " + max);
        }
    }
}