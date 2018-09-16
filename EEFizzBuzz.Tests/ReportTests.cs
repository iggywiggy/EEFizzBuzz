using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace EEFizzBuzz.Tests
{
    public class ReportTests
    {
        [Test]
        public void GetReport_Throws_ArgumentNullException_Null()
        {
            Assert.Throws<ArgumentNullException>(() => new Report().GetReport(null));
        }

        [Test]
        public void GetReport_Throws_ArgumentNullException_StringIsEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => new Report().GetReport(string.Empty));
        }

        [TestCase("lucky 1 2", ExpectedResult = "fizz: 0 buzz: 0 fizzbuzz: 0 lucky: 1 integer: 2 ")]
        [TestCase("lucky fizz buzz 3 fizzbuzz fizz buzz 5", ExpectedResult = "fizz: 2 buzz: 2 fizzbuzz: 1 lucky: 1 integer: 2 ")]
        public string GetReport_CorrectOutput(string input)
        {
            var suit = new Report();

           return suit.GetReport(input);
        }
    }
}
