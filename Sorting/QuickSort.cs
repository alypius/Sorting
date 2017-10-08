using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sorting
{
    public class QuickSort
    {
        private static Func<T, bool> InvertPredicate<T>(Func<T, bool> predicate)
        {
            return (T val) => !predicate(val);
        }

        private static Tuple<T[], T[]> Parition<T>(IEnumerable<T> list, Func<T, bool> predicate)
        {
            return Tuple.Create(list.Where(predicate).ToArray(), list.Where(InvertPredicate(predicate)).ToArray());
        }

        public static IEnumerable<T> Sort<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            if (list.Count() < 2)
                return list;

            var partition = list.First();
            var partitioned = Parition(list.Skip(1), it => it.CompareTo(partition) <= 0);

            return Sort(partitioned.Item1)
                .Concat(new[] { partition })
                .Concat(Sort(partitioned.Item2));
        }
    }
}
