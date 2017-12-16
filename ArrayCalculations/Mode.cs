
using System.Collections.Generic;

namespace ArrayCalculations
{
    public static class Mode
    {
        //--------------------------------------------------------------------
        // Mode
        //--------------------------------------------------------------------

        /// <summary>
        /// Returns the mode (or hightest occurance) of the elements in the array
        /// </summary>
        public static List<int> GetMode(this int[] array)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int x = 0; x < array.Length; x++)
            {
                if (dictionary.ContainsKey(array[x]))
                {
                    dictionary[array[x]]++;
                }
                else
                {
                    dictionary.Add(array[x], 1);
                }
            }

            double hightestCount = 0;
            foreach (var y in dictionary)
            {
                if (y.Value > hightestCount)
                {
                    hightestCount = y.Value;
                }
            }

            if (hightestCount == 1)
                return new List<int> { -1 };

            List<int> returnList = new List<int>();
            foreach (var x in dictionary)
            {
                if (x.Value == hightestCount)
                {
                    returnList.Add(x.Key);
                }
            }
            return returnList;
        }


        /// <summary>
        /// Returns the mode (or hightest occurance) of the elements in the array
        /// </summary>
        public static List<int> GetMode(this double[] array)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int x = 0; x < array.Length; x++)
            {
                if (dictionary.ContainsKey((int)array[x]))
                {
                    dictionary[(int)array[x]]++;
                }
                else
                {
                    dictionary.Add((int)array[x], 1);
                }
            }

            double hightestCount = 0;
            foreach (var y in dictionary)
            {
                if (y.Value > hightestCount)
                {
                    hightestCount = y.Value;
                }
            }

            if (hightestCount == 1)
                return new List<int> { -1 };

            List<int> returnList = new List<int>();
            foreach (var x in dictionary)
            {
                if (x.Value == hightestCount)
                {
                    returnList.Add(x.Key);
                }
            }
            return returnList;
        }

        /// <summary>
        /// Returns the mode (or hightest occurance) of the elements in the array
        /// </summary>
        public static List<int> GetMode(this List<int> list)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int x = 0; x < list.Count; x++)
            {
                if (dictionary.ContainsKey(list[x]))
                {
                    dictionary[list[x]]++;
                }
                else
                {
                    dictionary.Add(list[x], 1);
                }
            }

            double hightestCount = 0;
            foreach (var y in dictionary)
            {
                if (y.Value > hightestCount)
                {
                    hightestCount = y.Value;
                }
            }

            if (hightestCount == 1)
                return new List<int> { -1 };

            List<int> returnList = new List<int>();
            foreach (var x in dictionary)
            {
                if (x.Value == hightestCount)
                {
                    returnList.Add(x.Key);
                }
            }
            return returnList;
        }

        /// <summary>
        /// Returns the mode (or hightest occurance) of the elements in the array
        /// </summary>
        public static List<int> GetMode(this List<double> list)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int x = 0; x < list.Count; x++)
            {
                if (dictionary.ContainsKey((int)list[x]))
                {
                    dictionary[(int)list[x]]++;
                }
                else
                {
                    dictionary.Add((int)list[x], 1);
                }
            }

            double hightestCount = 0;
            foreach (var y in dictionary)
            {
                if (y.Value > hightestCount)
                {
                    hightestCount = y.Value;
                }
            }

            if (hightestCount == 1)
                return new List<int> { -1 };

            List<int> returnList = new List<int>();
            foreach (var x in dictionary)
            {
                if (x.Value == hightestCount)
                {
                    returnList.Add(x.Key);
                }
            }
            return returnList;
        }
    }
}
