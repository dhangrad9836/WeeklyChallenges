using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //test if char c is the ascii value of 'a' or greater than or equal to 'z'
            //or //test if char c is the ascii value of 'A' or greater than or equal to 'Z'
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            return false;
            //test


        }

        public bool CharacterIsNotALetter(char c)
        {
            //test if char c is not the ascii value of 'a' or greater than or equal to 'z'
            //or //test if char c is not the ascii value of 'A' or greater than or equal to 'Z'
            if (!(c >= 'a' && c <= 'z') || !(c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            return false;


        }


        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        //make sure to add Using.System.Linq;
        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            //use linq to filter out the min and max number and add together
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                //declare a total variable
                int total = 0;
                foreach (int num in numbers)
                {
                    total += num;
                }
                return total;
            }
        }

        public int SumEvens(int[] numbers)
        {
            //if value is null return 0
            if (numbers == null)
            {
                return 0;
            }
            //total variable to keep track of total
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {   //check if index is even if yes then add that 
                //value at that index to the total 
                if (numbers[i] % 2 == 0)
                    total += numbers[i];
            }
            return total;
            //using LINQ
            // return numbers.Where(number => number % 2 == 0).Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int totalSum = 0;
            foreach (int num in numbers)
            {
                totalSum += num;
            }
            if (totalSum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                //we are checking for efficiency here. We don't want to use a for loop b/c looping
                //through large numbers ie: 2000000000000 would take forever and lots of resources
                //so plain logic..if we have a number and divide it by half ...half of the numbers are positive and even
                return number / 2;
            }


        }
    }
}
