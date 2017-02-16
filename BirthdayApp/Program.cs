using BirthdayApp.Services;
using System;

namespace BirthdayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which problem would you like to calculate?");
            Console.WriteLine("1. Birthday Problem");
            Console.WriteLine("2. Coupon Problem");

            int selection;

            do
            {
                Console.WriteLine("Enter choise");
            }
            while (!int.TryParse(Console.ReadLine(), out selection));

            Console.Clear();

            if (selection == 1)
            {
                birthdayProblem();
            } else
            {
                couponProblem();
            }

        }

        public static void birthdayProblem()
        {
            int numberOfTests = 1000;
            int values = 0;

            Birthday b = new Birthday();
            int n;
            double v, d;

            do
            {
                Console.WriteLine("Enter value n");
            }
            while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 0; i < numberOfTests; i++)
            {
                values += b.testBirthdayProblem(n);
            }

            values = values / numberOfTests;
            v = b.calcBirthdayProblem(n);
            Console.WriteLine("The number of numbers before 2 alike should be around: " + v);
            Console.WriteLine("Actual count before 2 alike in average during " + numberOfTests + " tests, was: " + values);

            d = (values > v) ? values - v : v - values;
            Console.WriteLine("Difference between calculated value and tested value was: " + d);

            while (true) { }
        }

        public static void couponProblem()
        {
            int numberOfTests = 1000;
            int values = 0;

            Coupon c = new Coupon();
            int n;
            double v, d;

            do
            {
                Console.WriteLine("Enter value n");
            }
            while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 0; i < numberOfTests; i++)
            {
                values += c.testCouponProblem(n);
            }

            values = values / numberOfTests;
            v = c.calcCouponProblem(n);
            Console.WriteLine("The number of numbers before all have been generated should be: " + v);
            Console.WriteLine("Actual count before all values appear were in avg on " + numberOfTests + " tests: " + values);

            d = (values > v) ? values - v : v - values;
            Console.WriteLine("Difference between calculated value and tested value was: " + d);

            while (true) { }
        }
    }
}
