using System;
using System.Collections.Generic;
using System.Linq;

namespace SortSearchLibrary
{
    public static class InsertionSort
    {
        public static List<int> Sort(List<int> list)
        {
            for (int i = 1; i < list.Count(); i++)
            {
                int value = list[i];
                int readPosition = i - 1;
                while (list[readPosition] > value)
                {
                    readPosition--;
                    if (readPosition < 0) break;
                }
                list.RemoveAt(i);
                list.Insert(readPosition + 1, value);
            }
            return list;
        }
    }
}
