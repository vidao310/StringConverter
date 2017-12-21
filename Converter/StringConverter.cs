using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Converter
{
    public class StringConverter
    {
         public static String Convert(string input)
         {
             var splitWords = WordFinder(input);
             var convertWords = WordConverter(splitWords);
             var result = WordBuilder(convertWords);

             return result;
         }
         protected static List<String> WordFinder(string input)
        {
            List<String> result = new List<String>();

            //Split words by regex pattern
            String[] subStrings = Regex.Split(input, @"([a-zA-Z]+)", RegexOptions.IgnoreCase);
            foreach (string s in subStrings)
            {
                result.Add(s);
            }
            return result;

        }

        protected static List<String> WordConverter(List<String> input)
        {
            List<String> result = new List<String>();

            foreach(string s in input)
            {
                if(Regex.IsMatch(s, "[a-zA-Z]") && s.ToCharArray().Length>1)
                {
                    Char[] chars = s.ToCharArray();
                    string convertedWord = chars[0] + (chars.Length-2).ToString() + chars[chars.Length - 1];
                    result.Add(convertedWord);
                }
                else
                    result.Add(s);
            }
    
            return result;
        }

        protected static String WordBuilder(List<String> input)
        {
            string result = String.Join("", input);
            return result;
        }
    }
}


           