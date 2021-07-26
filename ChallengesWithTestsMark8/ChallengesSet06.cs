using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            switch (ignoreCase)
            {
                case true:
                   word = word.ToLower();
                   try
                   {
                       foreach (var w in words)
                       {
                           if (w.ToLower() == word)
                           {
                               return true;
                           }
                       }

                       break;
                   }
                   catch (NullReferenceException)
                   {
                       return false;
                   }
                case false:
                    return words.Contains(word);
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1 || num == null)
                return false; 
            if (num == 2)
            {
                return true;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            List<char> unique = new List<char>();
            for (int i = 0 ; i < str.Length ; i++)
            {
                int x = 0;
                for (int t =0 ; t < str.Length ; t++)
                {
                    if (str[i] == str[t] && i != t)
                    {
                        x++;
                    }
                }
                if( x == 0)
                {
                    unique.Add(str[i]);
                }
            }

            if (unique.Count == 0 || unique == null)
            {
                return -1;
            }
            var n = unique[unique.Count - 1];
            return str.IndexOf(n);
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int x = 0;      //tracks current number's count
            int y = 0;      //tracks largest consecutive count
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    x++;
                }
                else
                {
                    if (x > 0 && x >= y)
                    {
                        y = x+1;
                    }
                    x = 0;
                }

                if (i == numbers.Length - 1 && x >= y)
                {
                    y = x + 1;
                }
            }

            return y;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] x = new double[0];
            return elements == null || elements.Count == 0 ? x : elements.Where((c) => (elements.IndexOf(c) % n) - (n-1) == 0).ToArray();
        }
    }
}
