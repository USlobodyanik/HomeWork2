using System;

namespace ClassLibraryForHomeWork
{
    public class LibraryFromTask
    {
        public static void ChoosingJobTask()
        {
            int taskNumber = 0;
            int result;
            string strResult;
            int? numbera = null;
            int? numberb = null;
            int? numberc = null;
            int? numberd = null;

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
                        (numbera, numberb, numberc, numberd) = InputWhithConsole(taskNumber);
                        result = MathTwoNumber((int)numbera, (int)numberb);
                        Console.WriteLine($"Rusult for Task1/ Math two numbers: {result}");
                        break;
                    case 2:
                        Console.Write($"User enters 2 numbers (X and Y){Environment.NewLine}");
                        (numbera, numberb, numberc, numberd) = InputWhithConsole(taskNumber);
                        strResult = QuarterNumber((int)numbera, (int)numberb);
                        Console.WriteLine($"Rusult for Task2/ Quarter Number: {strResult}");
                        break;
                    case 3:
                        Console.Write($"The user enters 3 numbers (A, B and C){Environment.NewLine}");
                        (numbera, numberb, numberc, numberd) = InputWhithConsole(taskNumber);
                        (int minNumber, int secondNumber, int maxNumber) = NumberSort((int)numbera, (int)numberb, (int)numberc);
                        Console.WriteLine($"Rusult for Task3/ Number sort: " +
                            $"{minNumber} " +
                            $"{secondNumber} " +
                            $"{maxNumber}");
                        break;
                    case 4:
                        Console.Write($"The user enters 3 numbers (A, B and C){Environment.NewLine}");
                        (numbera, numberb, numberc, numberd) = InputWhithConsole(taskNumber);
                        (double? x1, double? x2) = QuadraticEquations((int)numbera, (int)numberb, (int)numberc);
                        Console.WriteLine($"Rusult for Task4/ Quadratic Equations: {Environment.NewLine}" +
                            $" X1 = {x1}; X2 = {x1}");
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

        public static (int? numbera, int? numberb, int? numberc, int? numberd) InputWhithConsole(int selectedTask)
        {
            int enterNumberCount = 0;
            int? numbera = null;
            int? numberb = null;
            int? numberc = null;
            int? numberd = null;

            switch(selectedTask)
            {
                case 1:
                    enterNumberCount = 2;
                    break;
                case 2:
                    enterNumberCount = 2;
                    break;
                case 3:
                    enterNumberCount = 3;
                    break;
                case 4:
                    enterNumberCount = 3;
                    break;
                default:
                    Console.Write($"Thank you for the attention! Have a nice day{Environment.NewLine}");
                    break;
            }

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