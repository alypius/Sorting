using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorting;

namespace AlgorithmsTest.Sorting
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void QuickSortBasic()
        {
            CollectionAssert.AreEqual(
                new int[] { },
                QuickSort.Sort(new int[] { }).ToArray()
            );

            CollectionAssert.AreEqual(
                new int[] { 1, 2, 3, 4, 5 },
                QuickSort.Sort(new int[] { 2, 3, 5, 1, 4 }).ToArray()
            );

            CollectionAssert.AreEqual(
                new int[] { 2, 4, 6, 8 },
                QuickSort.Sort(new int[] { 6, 2, 8, 4 }).ToArray()
            );
        }
    }
}
