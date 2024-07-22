using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool val in vals)
            {
                if (!val)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            
            if (sum % 2 == 0)
            {
                return false;
            }
                
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var hasUpper = false;
            var hasLower = false;
            var hasNumber = false;
            foreach (char a in password)
            {
                if (char.IsUpper(a))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(a))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(a))
                {
                    hasNumber = true;
                }

                if (hasUpper && hasLower && hasNumber)
                {
                    return true;
                }
            }
            return false;
        }

            public char GetFirstLetterOfString(string val)
            {
                    char firstLetter = val[0];
                    return firstLetter;
            }

            public char GetLastLetterOfString(string val)
            {
                char lastLetter = val[val.Length - 1];
                return lastLetter;
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
                return nums[nums.Length - 1] - nums[0];
            }

            public int[] GetOddsBelow100()
            {
                int[] oddList = new int[50];
                int index = 0;
                for(int i = 0; i < 100; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddList[index] = i;
                        index++;
                    }
                }

                return oddList;
            }

           public void ChangeAllElementsToUppercase(string[] words)
           {
               for(int i = 0; i < words.Length; i++)
               {
                   words[i] = words[i].ToUpper();
               }

               foreach(string word in words)
               {
                   Console.WriteLine(word);
               }
           }
    }
}
