using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortSearchLibrary
{
    public static class ShellSort
    {
        public static List<int> Sort(List<int> list)
        {
            for (int i = list.Count / 2; i > 0; i /= 2)
            {
                list = Shellsort(list, i);
            }
            return InsertionSort.Sort(list);
        }

        private static List<int> Shellsort(List<int> list, int gap)
        {
            for (int i = 0; i < list.Count() - gap; i++)
            {
                int value = list[i];
                int sortPosition = i + gap;

                if (value > list[sortPosition])
                {
                    int sortValue = list[sortPosition];

                    list.Insert(sortPosition, value);
                    list.RemoveAt(sortPosition + 1);

                    list.RemoveAt(i);
                    list.Insert(i, sortValue);
                }
            }
            return list;
        }
    }
}
