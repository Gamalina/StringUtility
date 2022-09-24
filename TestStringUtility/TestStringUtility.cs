using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtility;

namespace TestStringUtility
{
    [TestClass]
    public class TestStringUtility
    {
        [TestMethod]
        public void Should_Find_OneY_In_Mysterious()
        {
            string stringToCheck = "Mysterious";
            string stringToFind = "y";
            int expectedResult = 1;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Should_Find_Two_S_In_Mysterious()
        {
            string stringToCheck = "Mysterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Search_Should_Be_Case_Sensitive_Lower()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "s"; // Lower Letter
            int expectedResult = 2;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck.ToLower(), stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Search_Should_Be_Case_Sensitive_Upper()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "S"; // Upper Letter
            int expectedResult = 2;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck.ToUpper(), stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Should_Be_Able_To_Handle_Nulls()
        {
            string stringToCheck = null;
            string stringToFind = "null";
            int expectedResult = 0;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Should_Be_Able_To_Find_Nothing_In_String()
        {
            string stringToCheck = " ";
            string stringToFind = " ";
            int expectedResult = 1;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Should_Be_Able_To_Find_String_Length_Of_One()
        {
            string stringToCheck = "1";
            string stringToFind = "1";
            int expectedResult = stringToCheck.Length;

            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }
        // Confused as f... I have tried with if statement. Tried Count. Tried a lot of things, but I cannot make it work. ExpectedResult always returns True. And I cant make it actaulResult = true
        [TestMethod]
        public void Should_Be_Able_To_Find_String_Length_Of_Twelve()
        {
            string stringToCheck = "12";
            string stringToFind = "12";
            var expectedResult = stringToFind.Length > 1;
            
            StringUtility.StringUtility classUnderTest = new StringUtility.StringUtility();

            int actualResult = classUnderTest.CountOccurences(stringToCheck, stringToFind);
            

            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
