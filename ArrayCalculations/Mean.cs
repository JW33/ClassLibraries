
using System.Collections.Generic;

namespace ArrayCalculations
{
    public static class Mean
    {
        //--------------------------------------------------------------------
        // Mean
        //--------------------------------------------------------------------

        /// <summary>
        /// Returns the mean (or average) of the elements in the array
        /// </summary>
        public static double GetMean(this int[] array)
        {
            double total = 0;
            for (int x = 0; x < array.Length; x++)
            {
                total += array[x];
            }
            return total / array.Length;
        }

        /// <summary>
        /// Returns the mean (or average) of the elements in the array
        /// </summary>
        public static double GetMean(this double[] array)
        {
            double total = 0;
            for (int x = 0; x < array.Length; x++)
            {
                total += array[x];
            }
            return total / array.Length;
        }

        /// <summary>
        /// Returns the mean (or average) of the elements in the list
        /// </summary>
        public static double GetMean(this List<double> list)
        {
            double total = 0;
            for (int x = 0; x < list.Count; x++)
            {
                total += list[x];
            }
            return total / list.Count;
        }

        /// <summary>
        /// Returns the mean (or average) of the elements in the list
        /// </summary>
        public static double GetMean(this List<int> list)
        {
            double total = 0;
            for (int x = 0; x < list.Count; x++)
            {
                total += list[x];
            }
            return total / list.Count;
        }
    }
}
