using GroupProject_106;
using System.Drawing;

namespace GroupProject_106

{
    public class Polishnotationstests
    {
        [Fact]   
        
        public void GetPriorityTest()
        {
            PostfixNotationExpression testcase;
            testcase = new PostfixNotationExpression();
            int expected = 0;
            int actual = testcase.GetPriority(")");
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void SeparateTestUnar() {
            //проверка на унарный минус
            PostfixNotationExpression testcase;
            testcase = new PostfixNotationExpression();
            List<string> expected = new List<string>(new string[] { "-1", "+", "1" }); 
            List <string> actual = testcase.Separate("-x + x", 1);
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void SeparateTestMinus()
        {
            //проверка на обычный минус
            PostfixNotationExpression testcase;
            testcase = new PostfixNotationExpression();
            List<string> expected = new List<string>(new string[] { "3", "-", "1" });
            List<string> actual = testcase.Separate("x - 1", 3);
            Assert.Equal(expected, actual);
        }


    }
    
}