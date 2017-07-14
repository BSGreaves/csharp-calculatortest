using System;
using Xunit;

namespace Calculator.Test
{
    public class CalcShould
    {
        private Calc _calc;

        public CalcShould()
        {
            _calc = new Calc();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            int sum = _calc.AddTwoIntegers(54, 29);
            Assert.Equal(sum, 83);
        }

        [Fact]
        public void SubtractAnInteger ()
        {
            int remainder = _calc.SubtractAnInteger(10, 4);
            Assert.Equal(remainder, 6);
        }

        [Fact]
        public void MultiplyTwoIntegers()
        {
            int product = _calc.MultiplyTwoIntegers(3, 6);
            Assert.Equal(product, 18);
        }

        [Fact]
        public void DivideAnInteger()
        {
            int result = _calc.DivideAnInteger(15, 3);
            Assert.Equal(result, 5);
        }
    }
}