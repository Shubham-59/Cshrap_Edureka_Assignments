using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_C_
{
    internal class ElectricityBillCalculation
    {
        public void Electricitybill()
        {
            Console.WriteLine("Enter The Customer Id:");
            int userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Customer Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter The Electricity Unit Consumed by Customer:");
            float unit = Convert.ToSingle(Console.ReadLine());

            double electricityBill = 0;

            // Calculate bill based on unit ranges
            if (unit <= 199)
            {
                electricityBill = unit * 1.20;
            }
            else if (unit >= 200 && unit < 400)
            {
                electricityBill = unit * 1.50;
            }
            else if (unit >= 400 && unit < 600)
            {
                electricityBill = unit * 1.80;
            }
            else if (unit >= 600)
            {
                electricityBill = unit * 2.00;
            }

          
            double surcharge = 0;
            if (electricityBill > 400)
            {
                surcharge = electricityBill * 0.15;
            }

            double totalAmount = electricityBill + surcharge;

            
            if (totalAmount < 100)
            {
                totalAmount = 100;
            }

            // Display results
            Console.WriteLine("Customer ID: " + userId);
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Unit Consumed : " + unit);
            Console.WriteLine($"Amount Charges @Rs");
            Console.WriteLine("Surcharge Amount : "+ surcharge);
            Console.WriteLine("Net Amount Paid By the Customer : " + totalAmount);
        }
    }

}

