namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            DuplicateElementCounter counter = new DuplicateElementCounter();
            int duplicateCount = counter.CountDuplicates();
            Console.WriteLine("Total number of duplicate elements in the array: " + duplicateCount);

            //EligibilityAdmission eligibility = new EligibilityAdmission();
            //eligibility.CheckEligibility();

            ElectricityBillCalculation electricityBill=new ElectricityBillCalculation();
            electricityBill.Electricitybill();
        }
    }
}