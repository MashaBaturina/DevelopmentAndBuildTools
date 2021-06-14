using System;
using System.Collections.Generic;

namespace CheckString
{
    public class Program
    {
        public static void Main(string[] args)
        {          
            string userString = args[0];

            char[] arrayOfUserStringChars = userString.ToCharArray();

            List<int> userStringIndexesOfRepeatableFollowingChars = Calculator.GetIndexesOfRepeatableFollowingChars(arrayOfUserStringChars);

            int maxIndexesDifference = Calculator.GetMaxIndexesDifference(userStringIndexesOfRepeatableFollowingChars);

            Console.WriteLine(maxIndexesDifference);
        }
    }
}
