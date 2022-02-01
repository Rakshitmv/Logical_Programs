using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class GenerateCoupons
    {
        int newCoupon;

        public bool isCouponPresent(int coupon, int[] couponsArr)
        {
            bool isCouponPresent = false;
            for (int i = 0; i < couponsArr.Length; i++)
            {
                if (couponsArr[i] == coupon)
                {
                    isCouponPresent = true;
                }
            }
            return isCouponPresent;
        }
        public void Coupons()
        {
            Console.WriteLine("Enter the number of coupons you want to generate: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int max = num;
            int[] couponsArr = new int[num];
            int i = 0;
            Random random = new Random();

            while (num > 0 && i < max)
            {
                newCoupon = random.Next();

                if (isCouponPresent(newCoupon, couponsArr))
                {
                    newCoupon = random.Next();
                }
                else
                {
                    couponsArr[i++] = random.Next();
                }
                num--;
            }

            Console.WriteLine("The distinct coupons generated are: ");
            for (int j = 0; j < max; j++)
            {
                Console.Write(couponsArr[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
