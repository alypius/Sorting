using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class MergeSort
    {
        private static IList<T> Merge<T>(IList<T> first, IList<T> second) where T : IComparable<T>
        {
            var i = 0;
            var j = 0;
            var firstCount = first.Count;
            var secondCount = second.Count;
            var list = new List<T>();

            while (list.Count < (firstCount + secondCount))
            {
                if (j >= secondCount || (i < firstCount && first[i].CompareTo(second[j]) < 0))
                    list.Add(first[i++]);
                else
                    list.Add(second[j++]);
            }

            return list;
        }

        private static IList<T> GetSorted<T>(IList<T> list, int startIndex, int endIndex) where T : IComparable<T>
        {
            if (startIndex >= endIndex)
                return startIndex == endIndex
                    ? new List<T>() { list[startIndex] }
                    : new List<T>() { };

            var midpoint = (startIndex + endIndex) / 2;
            return Merge(
                GetSorted(list, startIndex, midpoint),
                GetSorted(list, Math.Min(midpoint + 1, endIndex), endIndex));
        }

        public static IList<T> Sort<T>(IList<T> list) where T : IComparable<T>
        {
            return GetSorted(list, 0, list.Count - 1);
        }
    }
}
