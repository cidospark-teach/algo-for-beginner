using System;

namespace Helper
{
    public class Challenge
    {
        public static void DetermineParlindrome(string str)
        {

            // return early if string is empty
            if (string.IsNullOrWhiteSpace(str))
                Console.WriteLine("Empty string");

            // set a counter for marking where the first index is each time in the loop
            var counter = 0;
            var lastCounter = str.Length - 1; // counter to mark where the last index is each time in the loop

            // get half of the length of the string to determine, we loop over it only once
            // since we are marking two indexes at once
            var len = (str.Length - 1) / 2;
            len = len % 2 == 0 ? len : len + 1;

            string ans = "Yes it's a parlindrome!";

            // traverse the array of characters
            for (int i = 0; i <= len; i++)
            {
                if (str[counter] != str[lastCounter])
                {
                    ans = "No it's not a parlindrome...";
                    break;
                }

                counter++;
                lastCounter--;
            }

            Console.WriteLine(ans);
        }
    }
}