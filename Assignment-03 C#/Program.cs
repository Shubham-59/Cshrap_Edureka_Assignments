namespace Assignment_03_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DuplicateElementCounter counter = new DuplicateElementCounter();
            int duplicateCount = counter.CountDuplicates();
            Console.WriteLine("Total number of duplicate elements in the array: " + duplicateCount);

            EligibilityAdmission eligibilityAdmission = new EligibilityAdmission();
            eligibilityAdmission.CheckEligibility();

            ElectricityBillCalculation billCalculation = new ElectricityBillCalculation();
            billCalculation.Electricitybill();
        }
    }
    }

