using System;
using System.Collections.Generic;
using Algorithms.DataStructures;

namespace Algorithms.Sorting
{
    public class HeapSort
    {
        public static IEnumerable<T> WithPriorityQueue<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            var priorityQueue = new PriorityQueue<T>();
            foreach (var e in list)
                priorityQueue.Enqueue(e);

            var sortedList = new List<T>();
            while (priorityQueue.Count > 0)
                sortedList.Add(priorityQueue.Dequeue());

            return sortedList;
        }
    }
}
