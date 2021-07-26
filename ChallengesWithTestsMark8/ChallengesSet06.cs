using System;
using System.Collections.Generic;
using System.Linq;

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
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
