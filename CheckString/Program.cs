using System;

namespace CheckString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userInput = StringHelper.ConcatenateStringsIntoOneString(args);

            char[] arrayOfUserInputChars = userInput.ToCharArray();

            int maxIndexesDifference = Calculator.GetMaxIndexesDifference(arrayOfUserInputChars);

            Console.WriteLine(maxIndexesDifference);
        }
    }
}
