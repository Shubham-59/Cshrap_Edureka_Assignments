using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    public class DuplicateElementCounter
    {
        public int CountDuplicates()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 6, 7, 8, 2, 9, 9 };
            int duplicateCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    // Check if the current element is a duplicate
                    if (array[i] == array[j])
                    {
                        duplicateCount++;
                        break;
                    }
                }
            }

            return duplicateCount;
        }
    }

}