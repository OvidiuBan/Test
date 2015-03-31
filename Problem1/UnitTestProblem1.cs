using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProblem3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestProblem1
    {
        [TestMethod]

        public void SumOfEvenNumberTests()
        {
            int[] a = new int[] { 1, 2, 3, 4 };
            MethodProblem1 method = new MethodProblem1();
            int actualSum = method.SumOfEvenNumbers(a);
            int expectedSum = 6;
            Assert.AreEqual(expectedSum, actualSum, "Wrong sum of even numbers!");
        }
       
    }
}
