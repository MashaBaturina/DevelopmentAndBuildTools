using System.Collections.Generic;
using System.Linq;

namespace CheckString
{
   public class Calculator
    {
        public static int GetMaxIndexesDifference(List<int> indexes)
        {
            int max = indexes.ElementAt(0);

            for (int i = 0; i < indexes.Count - 1; i++)
            {
                int difference = indexes[i + 1] - indexes[i];

                if (difference > max)
                {
                    max = difference;
                }
            }

            return max;
        }

        public static List<int> GetIndexesOfRepeatableFollowingChars(char[] arrayOfUserStringChars)
        {
            List<int> indexes = new List<int>();

            for (int i = 0; i < arrayOfUserStringChars.Length - 1; i++)
            {
                if (i == 0)
                {
                    indexes.Add(i);
                }

                if (arrayOfUserStringChars[i] == arrayOfUserStringChars[i + 1])
                {
                    indexes.Add(i + 1);
                }
            }

            return indexes;
        }
    }
}
