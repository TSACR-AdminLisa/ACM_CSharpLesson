// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleCalculator.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SimpleCalculator type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



namespace Calculator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;

    /// <summary>
    /// The simple calculator.
    /// </summary>
    public static class SimpleCalculator
    {
        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        /// <param name="b">
        /// The b.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// The multiply.
        /// </summary>
        /// <param name="a">
        /// The a.
        /// </param>
        /// <param name="b">
        /// The b.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
