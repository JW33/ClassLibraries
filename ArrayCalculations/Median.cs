
using System.Collections.Generic;

namespace ArrayCalculations
{
    public static class Median
    {
        //--------------------------------------------------------------------
        // Median
        //--------------------------------------------------------------------

        /// <summary>
        /// Returns the median (or middle) of the elements in the array
        /// </summary>
        public static double GetMedian(this int[] array)
        {
            if (array.Length % 2 == 0)
            {
                double left = array[(array.Length / 2) + 1];
                double right = array[array.Length / 2];

                return (left + right) / 2;
            }
            else
            {
                return array[array.Length / 2];
            }
        }

        /// <summary>
        /// Returns the median (or middle) of the elements in the array
        /// </summary>
        public static double GetMedian(this double[] array)
        {
            if (array.Length % 2 == 0)
            {
                double left = array[(array.Length / 2) + 1];
                double right = array[array.Length / 2];

                return (left + right) / 2;
            }
            else
            {
                return array[array.Length / 2];
            }
        }

        /// <summary>
        /// Returns the median (or middle) of the elements in the array
        /// </summary>
        public static double GetMedian(this List<int> list)
        {
            if (list.Count % 2 == 0)
            {
                double left = list[(list.Count / 2) + 1];
                double right = list[list.Count / 2];

                return (left + right) / 2;
            }
            else
            {
                return list[list.Count / 2];
            }
        }

        /// <summary>
        /// Returns the median (or middle) of the elements in the array
        /// </summary>
        public static double GetMedian(this List<double> list)
        {
            if (list.Count % 2 == 0)
            {
                double left = list[(list.Count / 2) + 1];
                double right = list[list.Count / 2];

                return (left + right) / 2;
            }
            else
            {
                return list[list.Count / 2];
            }
        }
    }
}
