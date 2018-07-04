using System;
using System.Collections.Generic;
using System.Text;

namespace SortSearchLibrary
{
    public class LinearSearch
    {
        public static int? Search(List<int> list, int item)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == item)
                {
                    return i;
                }
            }
            return null;
        }
    }
}
