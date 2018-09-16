using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEFizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    { 
        [Test]
        public void DoFizzBuzz_Returns_Fizz()
        {
            var suit = new FizzBuzz();

            var result = suit.DoFizzBuzz(6, 6);

            const string expected = "fizz";

            Assert.That(result, Is.EqualTo(expected));
            Assert.That(result.Length, Is.EqualTo(4));
        }

        [Test]
        public void DoFizzBuzz_Returns_Buzz()
        {
            var suit = new FizzBuzz();

            var result = suit.DoFizzBuzz(5, 5);

            const string expected = "buzz";

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void DoFizzBuzz_Returns_Integer()
        {
            var suit = new FizzBuzz();

            var result = suit.DoFizzBuzz(4, 4);

            const string expected = "4";

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0,0)]
        [TestCase(15,15)]
        [TestCase(45,45)]
        public void DoFizzBuzz_Returns_FizzBuzz(int lowerBound, int upperBound)
        {
            var suit = new FizzBuzz();

            var result = suit.DoFizzBuzz(lowerBound, upperBound);

            const string expected = "fizzbuzz";
            
            Assert.That(result.Trim(), Is.EqualTo(expected));
        }

        [TestCase(0,3, ExpectedResult = "fizzbuzz 1 2 lucky")]
        [TestCase(3,5, ExpectedResult = "lucky 4 buzz")]
        [TestCase(9,15, ExpectedResult = "fizz buzz 11 fizz lucky 14 fizzbuzz")]
        [TestCase(1,20, ExpectedResult = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz")]
        public string DoFizzBuzz_Returns_Expected(int lowerBound, int upperBound)
        {
            var suit = new FizzBuzz();

            var result = suit.DoFizzBuzz(lowerBound, upperBound);

            return result;
        }

        [Test]
        public void DoFizzBuzz_Returns_lucky()
        {
            var suit = new FizzBuzz();

            var result = suit.DoFizzBuzz(3, 3);

            const string expected = "lucky";

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
