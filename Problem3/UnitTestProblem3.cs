using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleProblem3;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestProblem3
    {
        [TestMethod]
        public void Arrays_WithDuplicates_ShouldFail()
        {
            int[] a = new int[] { 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 60, 59, 58, 1, 2, 3, 4, 57, 5, 56, 6, 55, 7, 54, 53, 52, 51, 50, 49, 8, 9, 10, 48, 47, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 46, 45, 44, 43, 42, 41, 40, 21, 22, 23, 39, 24, 38, 25, 37, 36, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35 };
            MethodProblem3 method = new MethodProblem3();
            bool actual = method.ThereAreDuplicates(a);
            bool expected = false; //no duplicates are expected!
            Assert.AreEqual(expected, actual, "There are duplicates!");
        }
    }
}
