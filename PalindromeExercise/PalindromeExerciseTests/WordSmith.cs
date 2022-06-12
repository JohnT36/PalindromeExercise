using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExerciseTests
{
    internal class WordSmith
    {

        public bool IsPalindrome(string word)
        {
            var reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            { reversed += word[i]; }
            if (reversed == word)
            { return true; }
            return false;
        }
    }
}
