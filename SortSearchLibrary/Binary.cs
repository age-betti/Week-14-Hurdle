using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearchLibrary
{
    public class Binary
    {
        public static int? Search(List<int> list, int item)
        {
            int min = 0;
            int mid;
            int max = list.Count - 1;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (list[mid] > item)
                {
                    max = mid - 1;
                }
                else if (list[mid] < item)
                {
                    min = mid + 1;
                }
                else if (list[mid] == item)
                {
                    return mid;
                }
            }
            return null;
        }
    }
}
