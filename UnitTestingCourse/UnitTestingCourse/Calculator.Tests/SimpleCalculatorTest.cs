// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SimpleCalculatorTest.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the SimpleCalculatorTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Calculator.Tests
{
    using System;

    using NUnit.Framework;

    /// <summary>
    /// The simple calculator test.
    /// </summary>
    [TestFixture]
    public class SimpleCalculatorTest
    {
        /// <summary>
        /// The should add two numbers.
        /// </summary>
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var result = SimpleCalculator.Add(2, 3);

            Assert.That(result, Is.EqualTo(5));
        }

        /// <summary>
        /// The should multiply two numbers.
        /// </summary>
        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var result = SimpleCalculator.Multiply(2, 3);

            Assert.That(result, Is.EqualTo(6));
        }
    }
}
