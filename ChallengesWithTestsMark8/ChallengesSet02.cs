using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 ==0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers != null && numbers.Count() >= 1)
            {
                return numbers.Min() + numbers.Max();
            }
            return 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length; 
        }

        public int Sum(int[] numbers)
        {
            return numbers != null && numbers.Length >= 1 ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers != null && numbers.Length >= 1 ? numbers.Where(n => n % 2 == 0).Sum() : 0;
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers != null && numbers.Count() >= 1 ? numbers.Sum() % 2 != 0 : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            List<int> strg = new List<int>();
            if (number > 0)
            {
                for (int i = 1; i < number; i += 2)
                {
                    strg.Add(i);
                }
                return strg.Count();
            }
            return 0;
        }
    }
}
