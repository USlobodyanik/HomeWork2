using ClassLibraryForHomeWork;
using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryFromTask.ChoosingJobTask();
            (int numbera, int numberb, int numberc, int numberd) = LibraryFromTask.InputWhithConsole();

            (double x, double y) = Convert.ToDouble(LibraryFromTask.QuadraticEquations((int)numbera, (int)numberb, (int)numberc),(int)numberd));
            Console.WriteLine($"Result {x}, {y}");
        }
    }
}