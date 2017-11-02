using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSample
{
    public static class QueueExtensions
    {
        public static Queue<T> ToQueue<T>(this List<T> source)
        {
            var queue = new Queue<T>(source.Count);
            foreach (var item in source)
            {
               queue.Enque(item); 
            }
            return queue;
        }
    }
}
