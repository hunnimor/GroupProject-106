using GroupProject_106;
using System.Drawing;

namespace GroupProject_106

{
    public class Polishnotationstests
    {
        [Fact]   
        
        public void GetPriorityTest()
        {
            //проверка работы небольшого класса testpriority

            //Arrange
            PostfixNotationExpression testcase;
            testcase = new PostfixNotationExpression();
            int expected = 0;
            //Act
            int actual = testcase.GetPriority(")");
            //Assert
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

    public class QuadratureUnitTests
    {
        [Fact]
        public void RombergTestSquare()

        {
            //проверка обычной параболы через метод Ромберга
            Quadrature testcase = new Quadrature("x * x");
            double expected = 18;
            double actual = testcase.romberg(-3, 3, 1E-3, 1, 4, true);
            Assert.Equal(expected, actual, 0.01);
        }


        [Fact]
        public void RombergTestDivisionByZero()

        {
            Quadrature testcase = new Quadrature("1 / x");
            double expected = 0;
            double actual = testcase.romberg(-3, 3, 1E-3, 1, 4, true);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RombergTestSin2x()

        {
            Quadrature testcase = new Quadrature("sin(2 * x)");
            double expected = 0.02;
            double actual = testcase.romberg(0, 3, 1E-3, 1, 4, true);
            Assert.Equal(expected, actual, 0.01);
        }

        [Fact]
        public void RombergTestSmak80StrangeFunction()

        {
            Quadrature testcase = new Quadrature("sin(2 * x) ^2 - cos(3*x^4)");
            double expected = 0.315;
            double actual = testcase.romberg(1, 2, 1E-3, 1, 4, true);
            Assert.Equal(expected, actual, 0.01);

        }



    }
    
}