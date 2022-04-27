using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCTools
{
    class Utility
    {
        public static int[] CountLetters(string i_message)
        {
            string message = i_message.ToUpper();

            int[] letters = new int[26];

            // Initialize the counts...
            for (int i = 0; i < 26; i++)
                letters[i] = 0;

            // Count the letters...
            foreach (char c in message)
            {
                if (c >= 65 && c <= 90)
                {
                    int idx = c - 65;
                    letters[idx]++;
                }
            }
            return letters;
        }

        public static bool IsValidInteger(String text)
        {
            int number = 0;
            bool canConvert = int.TryParse(text, out number);
            return canConvert;
        }

        public static string StripIllegalChars(String text)
        {
            String result = "";
            foreach (char c in text.ToUpper())
            {
                if (c.CompareTo('A') >= 0 && c.CompareTo('Z') <= 0)
                {
                    result += c;
                }
            }
            return result;
        }

        public static double GetFriedman(String message)
        {
            String stripped = StripIllegalChars(message);
            int[] arrayOfInt = CountLetters(message);
            double msgLen = stripped.Length;

            double value = 0.0;
            for (int k = 0; k < 26; k++)
            {
                value += arrayOfInt[k] / msgLen * ((arrayOfInt[k] - 1) / (msgLen - 1.0D));
            }
            return value;
        }

        public static String[] StripAlphabets(String message, int length)
        {
            String[] result = new String[length];
            char[] lettersArry = message.ToCharArray();
            char[] pageArry = null;
            for (int i = 0; i < length; i++)
            {
                pageArry = new char[Convert.ToInt32(message.Length / length) + 1];
                for (int j = i, k = 0; j < message.Length; j += length, k++)
                {
                    pageArry[k] = lettersArry[j];
                }
                result[i] = new String(pageArry);
            }
            return result;
        }
    }
}
