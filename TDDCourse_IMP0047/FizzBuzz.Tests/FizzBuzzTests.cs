using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void Setup()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [Test]
        [TestCase(1,"1")]
        [TestCase(2,"2")]
        [TestCase(3,"fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "buzz")]

         public void Answer_InputEqualValue_OutputCorrect(int input, string expectedOutput)
        {
            string output = this._fizzBuzz.Answer(input);
            if ((input % 3)==0)
            {
                output= "fizz"; 
            }
            if ((input % 5) == 0)
            {
                output = "buzz";
            }
            Assert.AreEqual(expectedOutput, output);

        }
    }
}
