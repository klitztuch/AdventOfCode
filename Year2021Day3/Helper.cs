using System.Collections;
using System.IO;
using System.Linq;

namespace Day3
{
    public static class Helper
    {
        public static BitArray[] File2BitArrays(string fileName)
        {
            return File.ReadAllLines(fileName).Select(o =>
            {
                var bitArray = new BitArray(o.Length);
                for (int i = 0; i < o.Length; i++)
                {
                    bitArray[i] = o[i] == '1';
                }

                return bitArray;
            })
                .ToArray();
        }
    }
}