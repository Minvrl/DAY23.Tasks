using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAY23.Tasks
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 != 0;
        }

        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static bool IsContaintsDigit(this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i])) return true;
            }
            return false;
        }

        public static string ToCapitalize(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            char firstLetter = char.ToUpper(str[0]);
            return firstLetter + str.Substring(1).ToLower();
        }


        public static int[] GetValueIndexes(this string str, char chr)
        {
            int[] indexes = new int[0];    
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = i;
                }
            }

            return indexes;
        }

        public static string GetFirstSentence(this string text)
        {
            int endIndex = text.IndexOf('.');
            int startIndex = 0;
            int length = endIndex - startIndex;

            return text.Substring(startIndex, length);
        }

        public static string GetSecondWord(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            int startIndex = str.IndexOf(' ');

            if (startIndex == -1)
            {
                return null;  
            }

            startIndex++;  

            int endIndex = str.IndexOf(' ', startIndex);

            if (endIndex == -1)
            {
                return str.Substring(startIndex);  
            }

            int length = endIndex - startIndex;
            return str.Substring(startIndex, length);
        }


        public static string FixSpacing(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return str;  
            }

            StringBuilder result = new StringBuilder();
            bool isSpace = false;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (char.IsWhiteSpace(c))
                {
                    isSpace = true;
                }
                else
                {
                    if (isSpace)
                    {
                        result.Append(' ');  
                        isSpace = false;
                    }

                    result.Append(c);
                }
            }

            return result.ToString().Trim();  
        }

    }
}
