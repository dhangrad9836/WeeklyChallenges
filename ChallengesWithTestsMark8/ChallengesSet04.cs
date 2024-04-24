using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
                else if (numbers[i] % 2 != 0)
                {
                    {
                        sum -= numbers[i];
                    }
                }
            }
            return sum;

            //LINQ version
            //return numbers.Where(x => % 2 == 0).Sum() - numbers.Where(x => % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> smallestString = new List<int>();
            smallestString.Add(str1.Length);
            smallestString.Add(str2.Length);
            smallestString.Add(str3.Length);
            smallestString.Add(str4.Length);
            return smallestString.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
