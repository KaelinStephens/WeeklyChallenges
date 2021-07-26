using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            try
            {
                if (numbers.Length == 0)
                {
                    return false;
                }

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        return false;
                    }
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            return numbers == null ? 0: numbers.Where((c,i) => i>0 && numbers[i - 1] % 2 == 0).Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence;
            try
            {
                if (words.Length == 0)
                {
                    return "";
                }

                words = words.Where(c => c.Trim() != "").ToArray();
                if (words.Length == 0)
                {
                    return "";
                }
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].TrimEnd(' ').TrimEnd(' ');
                }

                words[words.Length - 1] = $"{words[words.Length - 1]}.";
                sentence = string.Join(" ", words).Replace("  ", " ");
            }
            catch (NullReferenceException)
            {
                return "";
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] x = new double[0];
            return elements == null || elements.Count == 0 ? x : elements.Where((c) => (elements.IndexOf(c) % 4) - 3 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 0; x < nums.Length; x++)
                {
                    if (i != x)
                    {
                        if (nums[i] + nums[x] == targetNumber)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
