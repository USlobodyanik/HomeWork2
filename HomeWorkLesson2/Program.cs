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

            (double? x1, double? x2) = LibraryFromTask.QuadraticEquations(
                (int)numbera, 
                (int)numberb, 
                (int)numberc);
            Console.WriteLine($"Result {x1}, {x2}");
        }
    }
}