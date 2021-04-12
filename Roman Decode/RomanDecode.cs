using System.Collections.Generic;

namespace Roman_Decode
{
    public class RomanDecode
    {
        private static Dictionary<char, int> RomansCodes = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int Solution(string roman)
        {
            roman = roman.ToUpper().Trim();
            int total = 0, minus = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int current = RomansCodes[roman[i]] - minus;

                if (i == roman.Length - 1 || current + minus >= RomansCodes[roman[i + 1]])
                {
                    total += current;
                    minus = 0;
                }
                else
                {
                    minus = current;
                }
            }

            return total;
        }
    }
}