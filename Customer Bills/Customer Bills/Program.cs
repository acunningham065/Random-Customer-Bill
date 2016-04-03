using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Algorithm
             * Repeat
             * Create Customer unit
             * Total exc VAT
             * VAT
             * Total inc VAt
             * Print All
             * until all bills processed
             * End
             */


            //Decalartion of Variables

            int maxCustomer = 50;
            Random rnd = new Random();
            decimal vatRate = 0.06m;
            Stopwatch sw = new Stopwatch();

            //Start Stopwatch
            sw.Start(); 

            //Generate bills
            for (int currentBill = 0; currentBill < maxCustomer; currentBill++)
            {

                GenerateACustomerBill(rnd, vatRate, currentBill);

            }//End For loop

            sw.Stop(); //Stop Watch
            Console.WriteLine("Job Complete in " + sw.Elapsed.ToString() + " seconds");
            Console.ReadKey();
        }



        private static void GenerateACustomerBill(Random rnd, decimal vatRate, int currentBill)
        {
            //Calculate Units used
            decimal oldUnits = rnd.Next(50, 1001);
            decimal newUnits = rnd.Next(5000, 10001);
            decimal unitsUsed = newUnits-oldUnits;

            decimal customerBill = unitsUsed * 0.17m;

            decimal vatAmount = customerBill * vatRate;
            decimal totalIncVat = customerBill + vatAmount;

            Console.WriteLine("Bill of customer " + (currentBill + 1));

            Console.WriteLine("");

            Console.WriteLine("Total exc. VAT = " + customerBill);
            Console.WriteLine("VAT Amount = " + vatAmount);
            Console.WriteLine("Total inc. VAT = " + totalIncVat);

            Console.WriteLine("");
        }
    }
}
