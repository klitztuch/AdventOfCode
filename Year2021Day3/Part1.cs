using System;
using System.Collections;
using System.Linq;

namespace Day3
{

    public static class Part1
    {
        public static int Calculate(BitArray[] input)
        {
            var bitLength = input.First().Length;
            var gamma = 0;
            var epsilon = 0;
            var gammaCount = new int[bitLength];
            var epsilonCount = new int[bitLength];
            var gammaBinary = new BitArray(bitLength);
            var epsilonBinary = new BitArray(bitLength);

            foreach (var bitArray in input)
            {
                for (var i = 0; i < bitArray.Count; i++)
                {
                    if (bitArray[i])
                    {
                        gammaCount[i]++;
                        epsilonCount[i]--;
                    }
                    else
                    {
                        gammaCount[i]--;
                        epsilonCount[i]++;
                    }
                }
            }

            for (int i = 0; i < gammaCount.Length; i++)
            {
                switch (gammaCount[i])
                {
                    case > 0:
                        gammaBinary[i] = true;
                        break;
                    case < 0:
                        gammaBinary[i] = false;
                        break;
                    default:
                        break;
                }
            }
            
            for (int i = 0; i < epsilonCount.Length; i++)
            {
                switch (epsilonCount[i])
                {
                    case > 0:
                        epsilonBinary[i] = true;
                        break;
                    case < 0:
                        epsilonBinary[i] = false;
                        break;
                    default:
                        break;
                }
            }
            
            
            int[] gammaArray = new int[1];
            gammaBinary.CopyTo(gammaArray, 0);
            // epsilonBinary.CopyTo(array, 1);
            int[] epsilonArray = new int[1];
            epsilonBinary.CopyTo(epsilonArray, 0);
            gamma = gammaArray[0];
            epsilon = epsilonArray[0];
            

            return gamma * epsilon;
        }
    }
}