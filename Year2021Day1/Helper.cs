using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Day1
{
    public static class Helper
    {
        public static int[] File2IntArray(string fileName)
        {
            return Array.ConvertAll(File.ReadAllLines(fileName), int.Parse);
        }
    }
}