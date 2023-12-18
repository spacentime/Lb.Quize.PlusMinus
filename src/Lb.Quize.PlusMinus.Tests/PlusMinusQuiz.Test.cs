namespace Lb.Quize.PlusMinus.Tests
{
    [TestClass]
    public class PlusMinusQuizTest
    {
        PlusMinusQuiz _subject = new PlusMinusQuiz();

        ///        Sample Test Cases
        ///        plusMinus(35132) //-++-
        ///        plusMinus(199)   //not possible
        ///        plusMinus(26712) //-+-- <summary>
        ///        Sample Test Cases
        ///        
        /// </summary>
        /// 
        private void TestNumber(int number, string expected)
        {
            var input = number;

            var actual = _subject.PlusMinus(input);

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]        
        public void TestMethod1()
        {
            TestNumber(5, "Not possible");
        }

       

        [TestMethod]
        public void TestMethod35132()
        {
            TestNumber(35132, "-++-");
        }

        [TestMethod]
        public void TestMethod199()
        {
            TestNumber(199, "Not possible");            
        }


        [TestMethod]
        public void TestMethod26712()
        {
            TestNumber(26712, "-+--");
        }


    }
}