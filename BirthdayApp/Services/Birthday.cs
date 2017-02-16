using System;
using System.Collections.Generic;

namespace BirthdayApp.Services
{
    class Birthday
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
        /// Test the birthday problem by filling random numbers into a list until there are two similar values, 
        /// then return the count before two similar values occur.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int testBirthdayProblem(int n)
        {
            HashSet<int> l = new HashSet<int>();
            int count = 0;
            bool match = false;

            do
            {
                int value = generateRandomValue(n);
                if(l.Contains(value)) { match = true; }
                else { l.Add(value); count++; }
            } while (!match);
            
            return count;
        }

        /// <summary>
        /// Calculate the Birtday Problem value from the equation
        /// B approx = Sqrt of PI * n divided by 2
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public double calcBirthdayProblem(int n)
        {
            return Math.Sqrt((Math.PI * n) / 2);
        }
    }
}
