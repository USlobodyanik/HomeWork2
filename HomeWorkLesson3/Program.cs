using System;

namespace HomeWorkLesson3
{
    class Program
    {
        static int RaisingNumberPower(int a, int b)
        {
            int degree = 1;
            for (int i = 1; i <= b; i++)
            {
                degree *= a;
            }

            return (degree);
        }

        //static string DivisionNumber(int a)
        //{
        //    string str1 = $"Number {a} divide to: ";
        //    string str2 = null;

        //    for (int i = 1000; i >= a; i--)
        //    {
        //        if (i % a == 0)
        //        {
        //            str2 = Convert.ToString(i);
        //        }
        //    }
        //}

        static int SumNumber(int a, int b)
        {
            int min;
            int max;
            int result = 0;

            if (a > b)
            {
                min = b;
                max = a;
            }
            else
            {
                min = a;
                max = b;
            }

            for (int i = max; i > min; i--)
            {
                if (i % 7 == 0)
                {
                    result = i + max;
                    return result;
                }
                else
                {
                    return result;
                }
            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine($"The result of raising numbers to a power : {RaisingNumberPower(3,2)}");
            //Console.WriteLine($"The number is divided by : {DivisionNumber(20)}");

            Console.WriteLine(SumNumber(23, 59));
        }
    }
}
