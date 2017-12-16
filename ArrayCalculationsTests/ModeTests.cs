
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ArrayCalculations;

namespace ArrayCalculationsTests
{
    [TestClass]
    public class ModeTests
    {
        int[] intTestArray = { 1, 2, 3, 4, 5 };
        int[] intTestArray2 = { 1, 2, 3, 3, 4 };
        int[] intTestArray3 = { 1, 2, 3, 3, 4, 4 };
        int[] intTestArray4 = { 1, 2, 3, 3, 4, 4, 4 };

        double[] doubleTestArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        double[] doubleTestArray2 = { 1.0, 2.0, 3.0, 3.0, 4.0 };
        double[] doubleTestArray3 = { 1.0, 2.0, 3.0, 3.0, 4.0, 4.0 };
        double[] doubleTestArray4 = { 1.0, 2.0, 3.0, 3.0, 4.0, 4.0, 4.0 };

        List<int> intTestList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> intTestList2 = new List<int> { 1, 2, 3, 3, 4 };
        List<int> intTestList3 = new List<int> { 1, 2, 3, 3, 4, 4 };
        List<int> intTestList4 = new List<int> { 1, 2, 3, 3, 4, 4, 4 };

        List<double> doubleTestList = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
        List<double> doubleTestList2 = new List<double> { 1.0, 2.0, 3.0, 3.0, 4.0 };
        List<double> doubleTestList3 = new List<double> { 1.0, 2.0, 3.0, 3.0, 4.0, 4.0 };
        List<double> doubleTestList4 = new List<double> { 1.0, 2.0, 3.0, 3.0, 4.0, 4.0, 4.0 };


        //--------------------------------------------------------------------
        // int[]
        //--------------------------------------------------------------------
        [TestMethod]
        public void CheckForNoMode_Test()
        {
            List<int> list = new List<int>() { -1 };

            CollectionAssert.AreEqual(list, Mode.GetMode(intTestArray));
        }

        [TestMethod]
        public void CheckForOneMode_Test()
        {
            List<int> list = new List<int>() { 3 };

            CollectionAssert.AreEqual(list, Mode.GetMode(intTestArray2));
        }

        [TestMethod]
        public void CheckForTwoMode_Test()
        {
            List<int> list = new List<int>() { 3, 4 };

            CollectionAssert.AreEqual(list, Mode.GetMode(intTestArray3));
        }

        [TestMethod]
        public void CheckForMultipleMode_Test()
        {
            List<int> list = new List<int>() { 4 };

            CollectionAssert.AreEqual(list, Mode.GetMode(intTestArray4));
        }


        //--------------------------------------------------------------------
        // double[]
        //--------------------------------------------------------------------
        [TestMethod]
        public void CheckForNoMode_Test2()
        {
            List<int> list = new List<int>() { -1 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestArray));
        }

        [TestMethod]
        public void CheckForOneMode_Test2()
        {
            List<int> list = new List<int>() { 3 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestArray2));
        }

        [TestMethod]
        public void CheckForTwoMode_Test2()
        {
            List<int> list = new List<int>() { 3, 4 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestArray3));
        }

        [TestMethod]
        public void CheckForMultipleMode_Test2()
        {
            List<int> list = new List<int>() { 4 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestArray4));
        }


        //--------------------------------------------------------------------
        // List<int>
        //--------------------------------------------------------------------
        [TestMethod]
        public void CheckForNoMode_Test3()
        {
            List<int> list = new List<int>() { -1 };

            CollectionAssert.AreEqual(list, Mode.GetMode(intTestList));
        }

        [TestMethod]
        public void CheckForOneMode_Test3()
        {
            List<int> list = new List<int>() { 3 };

            CollectionAssert.AreEqual(list, Mode.GetMode(intTestList2));
        }

        [TestMethod]
        public void CheckForTwoMode_Test3()
        {
            List<int> list = new List<int>() { 3, 4 };

            CollectionAssert.AreEqual(list, Mode.GetMode(intTestList3));
        }

        [TestMethod]
        public void CheckForMultipleMode_Test3()
        {
            List<int> list = new List<int>() { 4 };

            CollectionAssert.AreEquivalent(list, Mode.GetMode(intTestList4));
        }


        //--------------------------------------------------------------------
        // List<double>
        //--------------------------------------------------------------------
        [TestMethod]
        public void CheckForNoMode_Test4()
        {
            List<int> list = new List<int>() { -1 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestList));
        }

        [TestMethod]
        public void CheckForOneMode_Test4()
        {
            List<int> list = new List<int>() { 3 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestList2));
        }

        [TestMethod]
        public void CheckForTwoMode_Test4()
        {
            List<int> list = new List<int>() { 3, 4 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestList3));
        }

        [TestMethod]
        public void CheckForMultipleMode_Test4()
        {
            List<int> list = new List<int>() { 4 };

            CollectionAssert.AreEqual(list, Mode.GetMode(doubleTestList4));
        }
    }
}
