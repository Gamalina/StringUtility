using System;

namespace StringUtility
{
    public class StringUtility
    {

        public int CountOccurences(string stringToCheck, string stringToFind)
        {
            var stringAsCharArray = stringToCheck?.ToCharArray();
            var stringToCheckForAsChar = stringToFind.ToCharArray()[0];
            var occuranceCount = 0;

            for (var characterIndex = 0; characterIndex < stringAsCharArray?.GetLength(0); characterIndex++)
            {
                if (stringAsCharArray[characterIndex] == stringToCheckForAsChar)
                {
                    occuranceCount++;
                }
            }
            return occuranceCount;

        }
    }
}
