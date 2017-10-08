using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorting;

namespace AlgorithmsTest.Sorting
{
    [TestClass]
    public class HeapSortTest
    {
        [TestMethod]
        public void HeapSortWithPriorityQueue()
        {
            CollectionAssert.AreEqual(
                new int[] { },
                HeapSort.WithPriorityQueue(new int[] { }).ToArray()
            );

            CollectionAssert.AreEqual(
                new int[] { 1, 2, 3, 4, 5 },
                HeapSort.WithPriorityQueue(new int[] { 2, 3, 5, 1, 4 }).ToArray()
            );

            CollectionAssert.AreEqual(
                new int[] { 2, 4, 6, 8 },
                HeapSort.WithPriorityQueue(new int[] { 6, 2, 8, 4 }).ToArray()
            );
        }
    }
}
