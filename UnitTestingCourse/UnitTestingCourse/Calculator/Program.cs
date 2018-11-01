// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Calculator
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a calculator, for example we have a Sum: {0}", SimpleCalculator.Add(3, 7));
            Console.WriteLine("and a Multiply {0}", SimpleCalculator.Multiply(3, 7));
            Console.ReadLine();
        }
    }
}
