using System;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Get_Returns_Fizz_for_5()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Get(5);

            Assert.Equal("Buzz", result);
        }
    }
}
