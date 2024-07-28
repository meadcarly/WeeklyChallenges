using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var addEven = numbers.Where(x => x % 2 == 0).Sum(x => x);
            var subtractOdd = numbers.Where(x => x % 2 != 0).Sum(x => x);
            var addEvenSubtractOdd = addEven - subtractOdd;
            return addEvenSubtractOdd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> allTheStrings = new List<string> { str1, str2, str3, str4 };
            var lengthOfShortestString = allTheStrings.Min(x => x.Length);
            return lengthOfShortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> allTheIntegers = new List<int> {number1, number2, number3, number4};
            var smallestNumber = allTheIntegers.Min(x => x);
            return smallestNumber;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            var changeBusinessName = "TrueCoders";
            biz.Name = changeBusinessName;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
                
            }
            if (!(sideLength1 + sideLength2 > sideLength3))
            {
                return false;
            }
            if (!(sideLength3 + sideLength2 > sideLength1))
            {
                return false;
            }
            if (!(sideLength1 + sideLength1 > sideLength2))
            {
                return false;
            }

            return true;
        }

        public bool IsStringANumber(string input)
        {
            double check;
            if (double.TryParse(input, out check))
            {
                return true;
            }

            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullTotal = 0;
            var nonNullTotal = 0;
            foreach(var input in objs)
            {
                if (input == null)
                {
                    nullTotal += 1;
                }
                else
                {
                    nonNullTotal += 1;
                }
            }
            if (nullTotal > nonNullTotal)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = numbers.Where(x => x % 2 == 0);
            if (!evens.Any())
            {
                return 0;
            }

            return evens.Average(x => x);
        }

        public int Factorial(int number)
        {
            var factorialTotal = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }
            if (number == 0)
            {
                return 1;
            }
            for (int i = 1; i <= number; i++)
            {
                factorialTotal *= i;
            }
            return factorialTotal;
        }
    }
}
