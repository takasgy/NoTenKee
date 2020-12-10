using System;
using System.Collections.Generic;

namespace NoTenKee.Utils
{
    public class CnvertA1ToR1C1Util
    {
        private Dictionary<char, int> dicA1 = new Dictionary<char, int> { 
            { 'A', 1 }, { 'B', 2 }, { 'C', 3 }, { 'D', 4 }, { 'E', 5 }, { 'F', 6 }, { 'G', 7 }, 
            { 'H', 8 }, { 'I', 9 }, { 'J', 10 }, { 'K', 11 }, { 'L', 12 }, { 'M', 13 }, { 'N', 14 }, 
            { 'O', 15 }, { 'P', 16 }, { 'Q', 17 }, { 'R', 18 }, { 'S', 19 }, { 'T', 20 }, { 'U', 21 }, 
            { 'V', 22 }, { 'W', 23 }, { 'X', 24 }, { 'Y', 25 }, { 'Z', 26 } };

        public int Execute(string arg)
        {
            int result = 0;
            char[] arr = arg.ToCharArray();
            Array.Reverse(arr);
            for (int i = 0; i < arg.Length; i++)
            {
                if (i == 0)
                {
                    result = dicA1[arr[i]];
                }
                else
                {
                    result = result + (26 * dicA1[arr[i]]);
                }
            }
            return result;
        }
    }
}
