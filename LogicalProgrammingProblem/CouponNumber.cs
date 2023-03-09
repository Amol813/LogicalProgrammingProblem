using System;

namespace LogicalProgrammingProblem
{
    public class CouponNumber
    {
        public int Distinctcoupon(int num)
        {
            int[] arr = new int[10];
            Random random = new Random();
            arr[0] = random.Next(0, num);
            for (int i = 1; i < 10; i++)
            {
                int coupon = random.Next(0, num);
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] != coupon)
                    {
                        arr[i] = coupon;
                    }
                    else
                    {
                        i--;
                        break;
                    }
                }
            }
            return arr[9];
        }
    }
}
