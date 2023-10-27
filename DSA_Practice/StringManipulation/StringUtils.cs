using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_Practice.StringManipulation
{
    public class StringUtils
    {
        public static int VowelCount(string str)
        {
            if (str == null) return 0;
            str = str.ToLower();
            string vowel = "aeiou";
            int count = 0;
            foreach (var c in str)
                if (vowel.IndexOf(c) != -1)
                    count++;

            return count;
        }
        
        // hello
        public static string Reverse(string str)
        {
            StringBuilder rev = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev.Append(str[i]);
            }

            return rev.ToString();
        }
        
        // Tree are beautiful
        public static string ReverseWorld(string word)
        {
            if (word == null)
                return "";
            string[] separators = { " " };
            string[] words = word.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder reverseWorld = new StringBuilder();
            for (int i = words.Length-1; i >=0; i--)
            {
                reverseWorld.Append(words[i]+" ");
            }

            return reverseWorld.ToString();
        }

        // abcd, dabc, abcd add - abcdbcda
        public static bool isRotation(string str1, string str2)
        {
            return (str1.Length == str2.Length && (str1 + str2).Contains(str2));
        }

        // aabcd
        public static string removeDuplicated(string str)
        {
            if (str == null)
                return "";
            HashSet<Char> set = new HashSet<char>();
            StringBuilder builder = new StringBuilder();
            
            //string str1 = "";
            foreach (var ch in str)
            {
                if (!set.Contains(ch))
                {
                    set.Add(ch);
                    builder.Append(ch);
                }
                
                // if (!str1.Contains(ch.ToString()))
                //     str1 += ch;
            }
            
            return builder.ToString();
            // return str1;
        }
        
        // aaabbc
        public static char MostRepeatedCharater(string str)
        {
            var table = new Hashtable();
            foreach (var c in str)
            {
                if (!table.ContainsKey(c))
                    table.Add(c, 1);
                else
                    table[c] = (int)table[c] + 1;
            }
            char maxChar = Char.MaxValue;
            int maxValue = 0;
            foreach (DictionaryEntry dictionaryEntry in table)
            {
                if ((int)dictionaryEntry.Value > maxValue)
                {
                    maxValue = (int)dictionaryEntry.Value;
                    maxChar = (char)dictionaryEntry.Key;
                }
            }
            return maxChar;
        }

        public static string Capitalize(string sentence)
        {
            string[] seperator = { " " } ;
            string[] words = sentence.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                char[] ch = word.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    if (i == 0)
                    {
                        builder.Append(ch[i].ToString().ToUpper());
                        continue;
                    }
                    builder.Append(ch[i].ToString().ToLower());
                }
                builder.Append(" ");
            }

            return builder.ToString();
        }

        // abcd , dcca
        public static bool Anagram(string str1, string str2)
        {
            str2 = removeDuplicated(str2);
            if (str1.Length != str2.Length) 
                return false;
            bool yes = true;
            foreach (char c in str2)
            {
                if(str1.Contains(c))
                    continue;
                yes = false;
            }
            return yes;
        }

        // ABCBA
        public static bool isPalindromByCompareString(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left++] != str[right--])
                    return false;
            }

            return true;
        }
        
        // Print first index in an array
        public int PrintFirstIndexInArray(int[] arr, int x)
        {
            return PrintFirstIndex(arr, x, 0);
        }
        private int PrintFirstIndex(int[] arr, int x, int i)
        {
            if (i == arr.Length)
                return -1;
            if (arr[i] == x)
                return i;
            return PrintFirstIndex(arr, x, i+1);
        }
    }
}