using System;

namespace ClassLibraryForHomeWork
{
    public class LibraryFromTask
    {
        public static void ChoosingJobTask()
        {
            int taskNumber;

            Console.WriteLine("Choosing a task №: ");
            string temp = Console.ReadLine();

            bool success = int.TryParse(temp, out taskNumber);

            if (success)
            {
                taskNumber = Convert.ToInt32(temp);
                switch (taskNumber)
                {
                    case 1:
                        Console.Write($"User enters 2 numbers (A and B){Environment.NewLine}");
                        break;
                    case 2:
                        Console.Write($"User enters 2 numbers (X and Y){Environment.NewLine}");
                        break;
                    case 3:
                        Console.Write($"The user enters 3 numbers (A, B and C){Environment.NewLine}");
                        break;
                    case 4:
                        Console.Write($"The user enters 3 numbers (A, B and C){Environment.NewLine}");
                        break;
                    default:
                        Console.Write($"Thank you for the attention! Have a nice day{Environment.NewLine}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input Error! Enter whole numbers");
            }
        }

        public static (int numbera, int numberb, int numberc, int numberd) InputWhithConsole()
        {
            int enterNumberCount;
            int numbera = 0;
            int numberb = 0;
            int numberc = 0;
            int numberd = 0;

            Console.WriteLine("How many digits do need to enter for the calculation? Enter the number: ");
            string temp = Console.ReadLine();

            bool success = int.TryParse(temp, out enterNumberCount);

            if (success)
            {
                enterNumberCount = Convert.ToInt32(temp);
                switch (enterNumberCount)
                {
                    case 1:
                        Console.Write("Enter number 1: ");
                        numbera = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Enter number 1: ");
                        numbera = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        numberb = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Enter number 1: ");
                        numbera = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        numberb = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number 3: ");
                        numberc = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Enter number 1: ");
                        numbera = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        numberb = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number 3: ");
                        numberc = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter number 4: ");
                        numberd = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.Write("Thank you for the attention! Have a nice day");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input Error! Enter whole numbers");
            }

            return (numbera, numberb, numberc, numberd);
        }

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

        public static string QuarterNumber(int a, int b)
        {
            string result;
            if (a < 0 && b < 0)
            {
                result = "First Quarter";
            }
            else if (a < 0 && b > 0)
            {
                result = "Second Quarter";
            }
            else if (a > 0 && b < 0)
            {
                result = "Third Quarter";
            }
            else if (a > 0 && b > 0)
            {
                result = "Fourth Quarter";
            }
            else if (a == 0 && b == 0)
            {
                result = "Center point";
            }
            else
            {
                result = "One of the points lies on the axis";
            }

            return result;
        }

        public static (int a, int b, int c) NumberSort(int a, int b, int c)
        {
            int temp;
            
            if (b < a)
            {
                temp = b;
                b = a;
                a = temp;

                if (b > c)
                {
                    temp = b;
                    b = c;
                    c = temp;
                }
            }
            else if (b > c)
            {
                temp = b;
                b = c;
                c = temp;

                if (a > c)
                {
                    temp = a;
                    c = a;
                    a = temp;
                }
            }

            return (a, b, c);
        }

        public static (double? x1, double? x2) QuadraticEquations(int a, int b, int c)
        {
            double d = b * b - 4 * a * c;
            if (d == 0)
            {
                double x = -b / (2 * a);

                return (x, x);
            }
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);

                return (x1, x2);
            }
            else
            {
                return (null, null);
            }
        }
    }
}