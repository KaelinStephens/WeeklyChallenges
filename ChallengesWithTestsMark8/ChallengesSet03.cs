using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int num;
            bool x;
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Sum() < 0)
            { 
                num = numbers.Sum() * -1;
                x = num % 2 == 1;
                return x;
            }
            else
            {
                x = numbers.Sum() % 2 == 1;
                return x;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool num = false;
            bool containsAll = false;
            foreach (var character in password)
            {
                if (Char.IsUpper(character))
                {
                    upper = true;
                }
                else if (Char.IsLower(character))
                {
                    lower = true;
                }
                else if (Char.IsNumber(character))
                {
                    num = true;
                }
            }

            if (upper == true && lower == true && num == true)
            {
                containsAll = true;
            }

            return containsAll;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums[nums.Length -1];
            var first = nums[0];
            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsBelow100 = new List<int>() {1};
            for (int i = 2; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    oddsBelow100.Add(i);
                }
            }

            return oddsBelow100.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
