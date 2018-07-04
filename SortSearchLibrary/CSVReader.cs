using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SortSearchLibrary
{
    public class CSVReader
    {
       public static List<int> ReadCSV(string filePath) => File.ReadAllLines(filePath).ToList().Select(S => int.Parse(S)).ToList();
    }
}
