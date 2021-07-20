using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;
            foreach (int num in numbers)
            {
                answer = (num % 2 == 0 ? answer + num : answer - num);
            }

            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var shortest = new List<int>() {str1.Length, str2.Length, str3.Length, str4.Length};
            return shortest.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var shortest = new List<int>() {number1, number2, number3, number4 };
            return shortest.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1
                ? true
                : false);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double x);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int x = 0;
           foreach(var obj in objs)
           {
               if (obj == null)
               {
                   x++;
               }
           }

           return x > (objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            try
            {
                return numbers.Where(c => c % 2 == 0).Average();
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
            catch (InvalidOperationException)
            {
                return 0;
            }
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return (number == 1 || number == 0 ? 1 : number * Factorial(number - 1));
        }
    }
}
