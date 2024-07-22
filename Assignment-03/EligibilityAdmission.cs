using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    public class EligibilityAdmission
    {
       
            public void CheckEligibility()
            {
                Console.WriteLine("Please enter the Maths Marks:");
                int mathsMark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the Physics Marks:");
                int phyMark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the Chemistry Marks:");
                int chiMark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Total Marks in 3 subjects:");
                int totalMarks = mathsMark + phyMark + chiMark;

                Console.WriteLine("Total Marks in Maths and Physics subjects:");
                int totalPhyAndMaths = phyMark + mathsMark;

                if (mathsMark >= 65)
                {
                    if (phyMark >= 55)
                    {
                        if (chiMark >= 50)
                        {
                            if (totalMarks >= 180 || totalPhyAndMaths >= 140)
                            {
                                Console.WriteLine("The candidate is eligible for admission.");
                            }
                            else
                            {
                                Console.WriteLine("The candidate is not eligible for admission due to total marks criteria.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The candidate is not eligible for admission due to Chemistry marks.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The candidate is not eligible for admission due to Physics marks.");
                    }
                }
                else
                {
                    Console.WriteLine("The candidate is not eligible for admission due to Maths marks.");
                }
            }
        }
    }
