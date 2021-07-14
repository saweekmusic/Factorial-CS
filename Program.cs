using System;

namespace Factorial
{
    public static class Kata
    {
        public static int Factorial(int n)
        {
            int sum = 1;
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            } 
            else if (n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    sum *= i;
                }

                return sum;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FactorialTests.tests(1, Kata.Factorial(0));
            FactorialTests.tests(1, Kata.Factorial(1));
            FactorialTests.tests(2, Kata.Factorial(2));
            FactorialTests.tests(0, Kata.Factorial(13));
            FactorialTests.tests(0, Kata.Factorial(-1));
        }
    }

    public class FactorialTests
    {
        public static void tests(int a, int b) {
            if (a == b)
            {
                Console.WriteLine("Correct!");
            }
            else Console.WriteLine("Incorrect!");
        }
    }
}
