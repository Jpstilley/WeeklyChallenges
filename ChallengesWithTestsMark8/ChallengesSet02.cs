using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return (numbers != null && numbers.Count() != 0) ? numbers.Min() + numbers.Max() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length - str2.Length > 0) ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers != null) ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            return (numbers != null) ? numbers.Where(value => value % 2 == 0).Sum() : 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers != null) ? numbers.Sum() % 2 != 0 : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number > 0) ? number / 2 : 0;
        }
    }
}
