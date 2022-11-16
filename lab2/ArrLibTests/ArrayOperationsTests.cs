using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrLib.Tests
{
    [TestClass()]
    public class ArrayOperationsTests
    {
        [TestMethod()]
        public void SubtractuionTest()
        {
            int[] arr1 = { -4, -92, 0, 14, 22, 9, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { -4, 4, 0, 14, 22, 9, 12, 3, 4, 89, 6, 7 };
            ArrayOperations arrToOper = new ArrayOperations(arr1);
            int[] subtr = arrToOper.Subtractuion(arr2);
            int[] answer = { -92, 2, 5 };
            Assert.IsTrue(Enumerable.SequenceEqual(subtr, answer));
        }
        [TestMethod()]
        public void SubtractuionTest2()
        {
            int[] arr1 = { -4, -92, 0, 14, 22, 9, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { -4, 4, 0, 14, 22, 9, 12, 3, 4, 89, 6, 7 };
            ArrayOperations arrToOper = new ArrayOperations(arr1);
            int[] subtr = arrToOper.Subtractuion(arr2);
            int[] answer = { -92, 2, 5 };
            Assert.IsTrue(Enumerable.SequenceEqual(subtr, answer));
        }
        [TestMethod()]
        public void SubtractuionTest1()
        {
            int[] arr1 = { 0, 65, -5, 34, 120, 65, 0, 1, -70, 43, 222, 123 };
            int[] arr2 = { 324, 454, 0, 555, 124, 987, 122, 564, 77, 0, 0, 0 };
            ArrayOperations arrToOper = new ArrayOperations(arr1);
            int[] subtr = arrToOper.Subtractuion(arr2);
            int[] answer = {65,-5,34,120,1,-70,43,222,123};
            Assert.IsTrue(Enumerable.SequenceEqual(subtr, answer));
        }
        [TestMethod()]
        public void SummTest1()
        {
            int[] arr1 = { 665, 655, 0, -1, 333, -555, 0, 0, 4, 45, 77, 30 };
            int[] arr2 = { 665, 655, 0, -1, 333, -555, 0, 0, 4, 45, 77, 30 };
            int[] answer = { 665, 655, 0, -1, 333, -555, 4, 45, 77, 30 };
            ArrayOperations arrToOper = new ArrayOperations(arr1);
            int[] summ = arrToOper.Summ(arr2);
            Assert.IsTrue(Enumerable.SequenceEqual(summ, answer));
        }
    }
}