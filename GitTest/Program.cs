using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GitTest
{
    class Program
    {
        public static void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }
        public static void PrintHello()
        {
            Console.WriteLine("Hello World");
        }
        static void Main(string[] args)
        {
            Program.PrintHello();
        }
    }
}
