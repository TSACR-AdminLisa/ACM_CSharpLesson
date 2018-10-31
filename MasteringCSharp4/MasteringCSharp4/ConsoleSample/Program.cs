using System;
using System.Collections.Generic;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic of System.Dynamic
            dynamic x = "Hello";
            Console.WriteLine(x.Length);
            x = new int[] { 10, 20, 30 };
            Console.WriteLine(x.Length);
            Console.Read();        }
    }
}
