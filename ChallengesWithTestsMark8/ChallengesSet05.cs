using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return Enumerable.Range(startNumber + 1, n).Where(number => number % n == 0).First();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            businesses.Where(business => business.TotalRevenue == 0).ToList().ForEach(business => business.Name = "CLOSED");
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            return numbers != null && numbers.Any() && numbers.SequenceEqual(numbers.OrderBy(number => number).ToArray());
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int answer = 0;
            int i = 0;
            while(numbers != null && i < numbers.Length)
            {
                if (numbers[i] % 2 == 0 && i + 1 <= numbers.Length - 1)
                {
                    answer += numbers[i + 1];
                }
                i++;
            }
            return answer;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string answer = "";
            if(words != null)
            {
                words.Where(word => word.Trim() != "").ToList().ForEach(word => answer += $"{word.Trim()} ");
            }
            return (answer.Any()) ? $"{answer.Trim()}." : answer;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            return (elements != null) ? elements.Where((element, index) => (index + 1) % 4 == 0).ToArray() : new double[] { };
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
