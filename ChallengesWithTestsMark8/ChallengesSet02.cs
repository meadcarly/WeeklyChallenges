using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

    public bool CountOfElementsIsEven(string[] vals)
        {
            int count = vals.Length;
            if (count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            
            double max = numbers.Max();
            double min = numbers.Min();
            
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    sum += num;
                }
            }
            else
            {
                sum = 0;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sumEven = 0;
            if (numbers != null)
            {
                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sumEven += num;
                    }
                    else
                    {
                        sumEven += 0;
                    }
                }
            }
            else
            {
                sumEven = 0;
            }
            return sumEven;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sumIsOdd = 0;
            if (numbers != null)
            {
                foreach (int numb in numbers)
                {
                    sumIsOdd += numb;
                }
            }
            else
            {
                return false;
            }

            if (sumIsOdd % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            if (number > 0)
            {
                count = number / 2;
            }
            else
            {
                count = 0;
            }

            return count;
        }
    }
}
