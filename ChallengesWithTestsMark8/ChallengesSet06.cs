using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            return words != null && (ignoreCase ? words.Where(value => value != null).Select(value => value.ToLower()).Contains(word.ToLower())
                                                : words.Contains(word));
        }

        public bool IsPrimeNumber(int num)
        {
            return num > 1 && Enumerable.Range(2, (int)Math.Sqrt(num) - 1).All(divisor => num % divisor != 0);
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var result = str.Where((letter, index) => str.Remove(index, 1).Contains(letter) == false);
            return result.Any() ? str.IndexOf(result.Last()) : -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int tempCount = 1;
            int count = 0;
            for ( int i = 0; i < numbers.Length; i++)
            {
                if(i + 1 < numbers.Length && numbers[i] == numbers[i + 1])
                {
                    tempCount++;
                }
                else if (tempCount > count)
                {
                    count = tempCount;
                    tempCount = 1;
                }
            }
            return count;
            //return numbers.Where((num, index) => (index + 1 < numbers.Length) ? index != 0 && num == numbers[index - 1] || num == numbers[index + 1] == true : num == numbers[index - 1] == true).Count();
        }
        
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            return (elements != null && n > 0) ? elements.Where((element, index) => (index + 1) % n == 0).ToArray() : new double[] { };
        }
    }
}
