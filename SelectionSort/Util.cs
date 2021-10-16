using System;
using System.Collections.Generic;

namespace Ventus
{
    public static class Util
    {
        public static void SelectionSort<T>(IList<T> list) where T : IComparable<T>
        {
            for (var i = 0; i < list.Count - 1; i++)
            {
                var k = i;
                for (var j = i + 1; j < list.Count; j++)
                {
                    var cmp = list[j].CompareTo(list[k]);
                    if (cmp < 0)
                        k = j;
                }
                if (k != i)
                {
                    var x = list[i];
                    list[i] = list[k];
                    list[k] = x;
                }
            }
        }
    }
}
