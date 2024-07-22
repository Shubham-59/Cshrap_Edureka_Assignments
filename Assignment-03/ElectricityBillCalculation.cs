using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03
{
    internal class ElectricityBillCalculation
    {
        double electricityBill = 0;
       
        public void Electricitybill()
        {
            Console.WriteLine("Enter The Customer Id:");
            int userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Customer Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter The Electricity Unit Consumed by Customer:");
            float unit = Convert.ToSingle(Console.ReadLine());

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

            double Surcharge = 0;
            if (electricityBill > 400)
            {
                 Surcharge = electricityBill * 0.15;

            }
            double totalAmount = electricityBill + Surcharge;
            if (electricityBill<100)
            {
                electricityBill = 100;
            }
            //Display Result
            Console.WriteLine("Customer ID : " + userId);
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("unit Consumed : " + unit);
            Console.WriteLine("Amount Charges: " );
            Console.WriteLine("Amount Paid By Customer for Surcharge: "+ Surcharge);
           Console.WriteLine("Amout paid by customer total  :" +totalAmount);


        }
    }
}