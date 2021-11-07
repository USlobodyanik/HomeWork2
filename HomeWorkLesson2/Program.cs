using System;

namespace HomeWorkLesson2
{
    class Program
    {
        public static int MathTwoNumber(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int InputWhithConsole()
        {
            Console.WriteLine("How many entering number? Enter number");
            int enterNumberCount = Convert.ToInt32(Console.ReadLine());
            return enterNumberCount;
        }

        static void Main(string[] args)
        {
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(InputWhithConsole());
        }
    }
}
