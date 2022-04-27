using System;

namespace Solarisin.VCTools
{
    internal static class Utility
    {
        public static int[] CountLetters(string message)
        {
            int[] letters = new int[26];

            // Initialize the counts...
            for (int i = 0; i < 26; i++)
                letters[i] = 0;

            // Count the letters...
            foreach (char c in message.ToUpper())
            {
                if (c >= 65 && c <= 90)
                {
                    int idx = c - 65;
                    letters[idx]++;
                }
            }
            return letters;
        }

        public static bool IsValidInteger(string text)
        {
            bool canConvert = int.TryParse(text, out _);
            return canConvert;
        }

        public static string StripIllegalChars(string text)
        {
            string result = "";
            foreach (char c in text.ToUpper())
            {
                if (c.CompareTo('A') >= 0 && c.CompareTo('Z') <= 0)
                {
                    result += c;
                }
            }
            return result;
        }

        public static double GetFriedman(string message)
        {
            string stripped = StripIllegalChars(message);
            int[] arrayOfInt = CountLetters(message);
            double msgLen = stripped.Length;

            double value = 0.0;
            for (int k = 0; k < 26; k++)
            {
                value += arrayOfInt[k] / msgLen * ((arrayOfInt[k] - 1) / (msgLen - 1.0D));
            }
            return value;
        }

        public static string[] StripAlphabets(string message, int length)
        {
            string[] result = new string[length];
            char[] lettersArray = message.ToCharArray();
            for (int i = 0; i < length; i++)
            {
                var pageArray = new char[Convert.ToInt32(message.Length / length) + 1];
                for (int j = i, k = 0; j < message.Length; j += length, k++)
                {
                    pageArray[k] = lettersArray[j];
                }
                result[i] = new string(pageArray);
            }
            return result;
        }
    }
}
