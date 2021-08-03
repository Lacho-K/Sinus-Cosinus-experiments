using System;
namespace Sin_Cos_and_stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            Console.WriteLine(sin(radians));
            Console.WriteLine(Math.Sin(radians));
        }
        static double CalcPI(int n)
        {
            double pi = 0;
            for (int k = 0; k < n; k++)
            {
                pi += Math.Pow(-1, k) / (2 * k + 1);
            }
            pi *= 4;
            return pi;
        }

        static double sin(double x)
        {
            double result = 0;
            for (int n = 0; n < 10; n++)
            {
                result += Math.Pow(-1, n) * (Math.Pow(x, 2 * n + 1) / Factorial(2 * n + 1));
            }
            return result;
        }
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static double ConvertRadiansToDegrees(double radians)
        {
            double degrees = (180 / Math.PI) * radians;
            return (degrees);
        }
    }
}
