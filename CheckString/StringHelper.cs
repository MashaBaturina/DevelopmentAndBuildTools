namespace CheckString
{
    public static class StringHelper
    {
        public static string ConcatenateStringsIntoOneString(string[] arrayOfStrings)
        {
            string result = "";

            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                result += arrayOfStrings[i];
            }

            return result;
        }
    }
}
