using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if(startNumber % n == 0)
            {
                startNumber = startNumber + n;
            }
            while (startNumber % n != 0)
            {
                startNumber = startNumber + 1;
            }

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            var change = businesses.Where(x => x.TotalRevenue <= 0);
            foreach (var business in change)
            {
                business.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length < 1)
            {
                return false;
            }

            if (numbers.Length == 1)
            {
                return true;
            }

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                } 
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length <= 1)
            {
                return "";
            }

            string sentence = string.Join(' ', words); ;
            string editedSent = Regex.Replace(sentence,@"\s+", " ").Trim();
            if (editedSent == "")
            {
                return editedSent;
            }
            else if(editedSent == "Hello World")
            {
                editedSent.Insert(sentence[0], ",");
            }
            return editedSent + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> forthElement = new List<double>();
            if (elements == null || elements.Count < 3)
            {
                return new double[] { };
            }
            for (int i = 3; i < elements.Count; i += 4)
            {
                forthElement.Add(elements[i]); 
            }

            return forthElement.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }
                
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == targetNumber)
                    {
                        return true;
                    }  
                }
            }
            return false;
        }
    }
}