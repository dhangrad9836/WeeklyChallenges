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
            //add the params into a string
            //find the length of each string and use .Min() to find shortest length
            List<int> smallestString = new List<int>();
            smallestString.Add(str1.Length);
            smallestString.Add(str2.Length);
            smallestString.Add(str3.Length);
            smallestString.Add(str4.Length);
            return smallestString.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //List<int> smallestNumber = new List<int> { number1, number2, number3, number4 };
            //return smallestNumber.Min();
            var smallest = number1;
            var list = new List<int> { number1, number2, number3, number4 };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallest)
                {
                    //make list[i] the new smallest number
                    smallest = list[i];
                }
            }
            return smallest;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //first check out the Business class declaration rt click- check definition/declaration
            //you see that it's using a Name property so all we need to do is just set biz.Name = "TrueCoders";
            biz.Name = "TrueCoders";
        }

        //two sides must be greater than the third size
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0)
            //{
            //    return false;
            //}
            if ((sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength1) && (sideLength2 + sideLength3 > sideLength1))
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double num = 0;
            var testNum = double.TryParse(input, out num);
            return testNum;
        }

        //we are checking if there are more null values vs non-null ie: int, string, etc in the array
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //we need to loop throught the array and check if we have more "null" in the array which then is true
            var nullCount = 0;
            var nonNullCount = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
                else
                {
                    nonNullCount++;
                }
            }//end foreach

            if (nullCount > nonNullCount)
            {
                return true;
            }


            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            var totalAvgEvens = 0;
            var count = 0;

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    totalAvgEvens += num;
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }

            //we need to parse totalAvgEvens into a double as the avg values can be double
            return (double)totalAvgEvens / count;

        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            //use recursive call until base case is resolved to calculate the factorial
            return number * Factorial(number - 1);


        }
    }
}
