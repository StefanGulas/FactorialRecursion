using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialRecursion;

namespace FactorialRecursion.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Factorial7()
        {
            //Arrange
            int factorialOf = 7;
            long expectedValue = 5040;
            //Act
            long actualValue = Program.factorial(factorialOf);
            //Assert
            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
