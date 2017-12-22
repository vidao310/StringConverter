using System;
using System.Collections.Generic;
using System.Linq;
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

            //Split words by regex pattern (group of alphabetic characters)
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

            //Convert each found word with given spec: first char + count of DISTINCT letters between first-last char + last char
            //Keep the original orders of words and non-alphabetic chars.
            foreach(string s in input)
            {
                if(Regex.IsMatch(s, "[a-zA-Z]") && s.ToCharArray().Length>1)
                {
                    Char[] chars = s.ToCharArray();
                    string subString = s.Substring(1, chars.Length-2);

                    //Get count of Distinct Letters (regardless of Upper/Lower case)
                    int distinctLettersCount = subString.ToLower().Distinct().Count();

                    string convertedWord = chars[0] + distinctLettersCount.ToString() + chars[chars.Length - 1];
                    result.Add(convertedWord);
                }
                else
                    result.Add(s);
            }
    
            return result;
        }

        protected static String WordBuilder(List<String> input)
        {
            //Join the converted words together as final result
            string result = String.Join("", input);
            return result;
        }
    }
}


           