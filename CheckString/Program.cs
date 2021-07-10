using System;

namespace CheckString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userString = StringHelper.ConcatenateStringsIntoOneString(args);

            char[] arrayOfUserStringChars = userString.ToCharArray();

            int maxIndexesDifference = Calculator.GetMaxIndexesDifference(arrayOfUserStringChars);

            Console.WriteLine(maxIndexesDifference);
        }
    }
}
