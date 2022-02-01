using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1: Gambler\n" +  "Enter 2: Generate coupons\n" + "Enter 3: Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Gambler gambler = new Gambler();
                        gambler.GamblerSimulation();
                        break;
                    case 2:
                        GenerateCoupons coupon= new GenerateCoupons();
                        coupon.Coupons();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter correct option\n");
                        break;

                }
            }
        }
    }
}
