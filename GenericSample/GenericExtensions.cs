using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSample
{
    public static class GenericExtensions
    {
        public static List<T> ToList<T>(this IEnumerable<T> source)
        {
              return new List<T>(source);
        }
    }
}
