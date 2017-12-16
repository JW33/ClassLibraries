
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ArrayCalculations;

namespace ArrayCalculationsTests
{
    [TestClass]
    public class MeanTests
    {
        int[] intTestArray = { 1, 2, 3, 4, 5 };
        int[] intTestArray2 = { 1, 2, 3, 4 };

        double[] doubleTestArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
        double[] doubleTestArray2 = { 1.0, 2.0, 3.0, 4.0 };

        List<int> intTestList = new List<int> { 1, 2, 3, 4, 5 };
        List<int> intTestList2 = new List<int> { 1, 2, 3, 4 };

        List<double> doubleTestList = new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 };
        List<double> doubleTestList2 = new List<double> { 1.0, 2.0, 3.0, 4.0 };

        //--------------------------------------------------------------------
        // int[]
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMeanIntArray_Test()
        {
            double result = Mean.GetMean(intTestArray);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetMeanIntArray_Test2()
        {

            double result = Mean.GetMean(intTestArray2);

            Assert.AreEqual(2.5, result);
        }


        //--------------------------------------------------------------------
        // double[]
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMeanDoubleArray_Test()
        {
            double result = Mean.GetMean(doubleTestArray);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetMeanDoubleArray_Test2()
        {
            double result = Mean.GetMean(doubleTestArray2);

            Assert.AreEqual(2.5, result);
        }

        //--------------------------------------------------------------------
        // List<int>
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMeanIntList_Test()
        {
            double result = Mean.GetMean(intTestList);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetMeanIntList_Test2()
        {
            double result = Mean.GetMean(intTestList2);

            Assert.AreEqual(2.5, result);
        }

        //--------------------------------------------------------------------
        // List<double>
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMeanDoubleList_Test()
        {
            double result = Mean.GetMean(doubleTestList);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetMeanDoubleList_Test2()
        {
            double result = Mean.GetMean(doubleTestList2);

            Assert.AreEqual(2.5, result);
        }
    }
}
