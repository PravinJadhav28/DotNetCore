using B24MathLibrary;
using System;

namespace MathClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(10, 10);  
            
            Console.ReadKey();
        }
    }
}
