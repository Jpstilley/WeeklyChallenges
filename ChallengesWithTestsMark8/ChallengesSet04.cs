﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(number => number % 2 == 0).Sum() - numbers.Where(number => number % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new List<string>() { str1, str2, str3, str4 }.OrderBy(word => word.Length).First().Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new List<int>() { number1, number2, number3, number4 }.OrderBy(number => number).First();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var sides = new List<int>(){ sideLength1, sideLength2, sideLength3 }.OrderBy(side => side).ToList();
            return !sides.Contains(0) && (sides[0] + sides[1] > sides[2]);  
        }

        public bool IsStringANumber(string input)
        {
            double answer;
            return double.TryParse(input, out answer);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Length / 2 < objs.Count(value => value == null);
        }

        public double AverageEvens(int[] numbers)
        {
            return (numbers != null && numbers.Where(number => number % 2 == 0).Count() != 0)
                ? numbers.Where(number => number % 2 == 0).Average() : 0;
        }

        public int Factorial(int number)
        {
            return (number == 0) ? 1 : Enumerable.Range(1, number).Aggregate((i, j) => i * j);
        }
    }
}
