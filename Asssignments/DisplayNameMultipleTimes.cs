using System;

namespace CSharpAssignments
{
    public class DisplayNameMultipleTimes
    {
        public void ShowNameMultipleTimes(string name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(name);
            }
        }
    }
}
