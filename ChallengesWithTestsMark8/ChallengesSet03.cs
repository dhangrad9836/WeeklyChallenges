using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool IsAnotherPalindrome(string word)
        {
            //is word a palindrome
            //think of a word as an example - ie: "racecar"

            //is the reverese of the word the same reversed

            //how do i reverese a word or a string
            //write for loop to loop through the parameter 'word' backwards
            //remeber keep looping until it's false
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                //store the letters in reversed variable as we loop backwards
                reversed += word[i];
            }

            //now check if 'word' is equal to 'reversed'
            if (word == reversed)
            {
                return true;
            }
            return false;

        }

        public bool IsAPalindrome(string word)
        {
            //return true;
            //1. Is the word a palindrome
            //2. Think of a word as an example ie: racecar
            //3. Is the reverse of the word ie: racecar the same in reverse?
            //4. How do you reverse the word.
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            if (reversed == word)
            {
                return true;
            }
            return false;
        }

        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;

            foreach (var number in numbers)
            {
                //check if number is odd then add it to the sum
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            //check if sum is odd
            // return sum % 2 != 0; shorthand of below
            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsNumber)
                && password.Any(char.IsUpper)
                && password.Any(char.IsLower) ? true : false;
            //create three bool variables for isLetter, isDigit, isUpper
            //bool isLetter = false;
            //bool isDigit = false;
            //bool isUpper = false;

            ////loop through the password and check each letter for isLetter, isDigit, isUpper
            //foreach(var letter in password)
            //{
            //    if (char.IsLower(letter))
            //    {
            //        isLetter = true;
            //    }

            //    if (char.IsUpper(letter))
            //    {
            //        isUpper = true;
            //    }

            //    if (char.IsDigit(letter))
            //    {
            //        isDigit = true;
            //    }
            //}
            //return isLetter && isUpper && isDigit;
        }

        public char GetFirstLetterOfString(string val)
        {
            //return val[0];
            return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            //return val[val.Length- 1];
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            //so population is 100 numbers
            //int[] myArray = new int[50];     //half will be odd
            //int index = 0; //seperate value for index that will run 50 times and will not be out of bounds of our array
            var odds = new List<int>();
            //we inc this index if i is odd...so i will iterate 100 times but index will only inc up to 50 times for odd values
            //we can loop through 100 times with our i index value 
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray(); ;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
