using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayApp.Services
{
    class Coupon
    {
        private Random ran = new Random();

        /// <summary>
        /// Return a random number between 0 and n - 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private int generateRandomValue(int n)
        {
            return ran.Next(n);
        }

        /// <summary>
        /// Test the coupon problem by filling a list with all possible values, 
        /// then grap a new random value until all values have occured at least once,
        /// and then return the count.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int testCouponProblem(int n)
        {
            HashSet<int> l = new HashSet<int>();
            int count = 0;

            //Fill a hashset up with all the values
            for (int i = 0; i < n; i++)
            {
                l.Add(i);
            }

            while (l.Count != 0)
            {
                //Generate a random value between 0 and n
                int randomVal = generateRandomValue(n);
                if (l.Contains(randomVal)) { l.Remove(randomVal); }
                count++;
            }
            

            return count;
        }

        /// <summary>
        /// Calculate the Coupon Problem value from the equation
        /// N * (1/1 + 1/2 +... 1/N)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double calcCouponProblem(int n)
        {
            double fraction = .0; 
            for (int i = 1; i <= n; i++)
            {
                double value = (1 / (double)i);
                fraction += value;
            }
            return n * fraction;
        }
    }
}
