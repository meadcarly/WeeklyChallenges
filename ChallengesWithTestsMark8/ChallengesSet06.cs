using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //check if the word is in the string
            //check if the casing needs to be ignored
            //return true or false 
            if (words == null || words.Any() == false)
            {
                return false;
            }
            foreach (var wordle in words)
            {
                if(ignoreCase)
                {
                    if(string.Equals(wordle, word, StringComparison.OrdinalIgnoreCase))
                    {
                    
                        return true;
                    }
                }
                else
                {
                    if (wordle == word)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            var a = 2;
            if (num <= 1)
            {
                return false;
            }

            if (num == 2)
            {
                return true;
            }

            if (num % a == 0)
            {
                return false;
            }
            
            while(a < num)
            {
                if (num % a == 0)
                {
                    return false;
                }
                a++;
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            /*if (str.Length == 0 || str == null)
            {
                return -1;
            }

            int[] lastIndex = new int[256];
            int[] countMatches = new int[256];

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                countMatches[c]++;
                lastIndex[c] = i;
            }

            int lastUniqueIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (countMatches[c] == 1)
                {
                    lastUniqueIndex = Math.Max(lastUniqueIndex, lastIndex[c]);
                }
            }

            return lastUniqueIndex;*/
            var lastIndex = str.Select((c, i) => new { Char = c, Index = i }).GroupBy(x => x.Char)
                .Where(g => g.Count() == 1).Select(g => g.Last().Index).ToList();
            return lastIndex.Count > 0 ? lastIndex.Max() : -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int maxCount = 1;
            int currentCount = 1;
            int currentNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (currentNumber == numbers[i])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentNumber = numbers[i];
                    currentCount = 1;
                }
            }

            maxCount = Math.Max(maxCount, currentCount);
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count < n - 1 || n < 1)
            {
                return new double[] { };
            }

            List<double> nthElements = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                nthElements.Add(elements[i]);
            }
            return nthElements.ToArray();
        }
    }
}