using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProblem3;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestProblem2
    {
        [TestMethod]
        
            public void TwoLargestNumbersTest()
        {
            int[] a = new int[] { 0,2,4};
            MethodProblem2 method = new MethodProblem2();
            int[] actualMax =method.TwoLargestNumbers(a);
            Assert.AreNotEqual(actualMax[0], int.MinValue, "Empty Array");
            Assert.AreNotEqual(actualMax[1], int.MinValue, "Just One Element In Array");
            int[] expectedMax = new int[] {4,2}; 
            Assert.AreEqual(actualMax[0], expectedMax[0], "Different Max 1!");
            Assert.AreEqual(actualMax[1], expectedMax[1], "Different Max 2!");
           
        }
        
    }
}
