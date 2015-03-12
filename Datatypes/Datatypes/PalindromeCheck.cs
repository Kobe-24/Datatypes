using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    public class PalindromeCheck
    {
        public bool IsPalindrome(string word)
        {
            if (word.Length == 0 || word.Length == 1) return false;


            int startPointer = 0;
            int endPointer = word.Length - 1;
            for (int i = 0; i < word.Length; i++)
            {
                if (startPointer == endPointer) break;

                if (word[startPointer] != word[endPointer])
                {
                    return false;
                }
                startPointer++;
                endPointer--;

            }

            return true;
        }

    }
}
