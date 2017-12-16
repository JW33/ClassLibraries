
using ArrayCalculations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ArrayCalculationsTests
{
    [TestClass]
    class MedianTests
    {
        int[] intTestArray = { 1, 2, 3, 4 };
        double[] doubleTestArray = { 1.0, 2.0, 3.0, 4.0 };
        List<int> intTestList = new List<int> { 1, 2, 3, 4 };
        List<double> doubleTestList = new List<double> { 1.0, 2.0, 3.0, 4.0 };

        //--------------------------------------------------------------------
        // int[]
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMedianIntArray_Test()
        {
            double result = Median.GetMedian(intTestArray);

            Assert.AreEqual(2.5, result);
        }


        //--------------------------------------------------------------------
        // double[]
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMedianDoubleArray_Test()
        {
            double result = Median.GetMedian(doubleTestArray);

            Assert.AreEqual(2.5, result);
        }


        //--------------------------------------------------------------------
        // List<int>
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMedianIntList_Test()
        {
            double result = Median.GetMedian(intTestList);

            Assert.AreEqual(2.5, result);
        }


        //--------------------------------------------------------------------
        // List<double>
        //--------------------------------------------------------------------
        [TestMethod]
        public void GetMedianDoubleList_Test()
        {
            double result = Median.GetMedian(doubleTestList);

            Assert.AreEqual(2.5, result);
        }
    }
}
