using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
