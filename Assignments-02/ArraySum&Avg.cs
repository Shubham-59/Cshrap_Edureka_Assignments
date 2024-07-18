using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignments_02
  {internal class ArraySum_Avg
    {
        public void sunOfArray()
        {
            int sum = 0;
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            for (int i = 0;i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average=sum/arr.Length;
            
            Console.WriteLine("The sum of the array elements is: " + sum);

            Console.WriteLine("The Average of the array elements is: " + average);
        }
    }
}