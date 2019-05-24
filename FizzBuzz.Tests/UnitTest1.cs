using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_Fizz_for_3()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Get(3);

            Assert.Equal("Fizz", result);
        }
    }
}
