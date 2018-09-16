using System.Text;
using static EEFizzBuzz.Constants;

namespace EEFizzBuzz
{
    public class FizzBuzz
    {
        private readonly IReport _report;

        public FizzBuzz(IReport report)
        {
            _report = report;
        }

        internal string DoFizzBuzz(int lowerBound, int upperBound)
        {
            var output = new StringBuilder();

            for (var i = lowerBound; i <= upperBound; i++)
            {
                output.Append(GetCorrectString(i));
            }

            return output.ToString().Trim();
        }

        public string FizzBuzzer(int lowerBound, int upperBound)
        {
            var fizzBuzz = DoFizzBuzz(lowerBound, upperBound);

            var report = _report.GetReport(fizzBuzz);

            return fizzBuzz + " " + report.Trim();
        }

        private static string GetCorrectString(int number)
        {
            if (ContainsNumberThree(number))
                return $"{Lucky} ";

            if (IsDivisableBy(number, 15))
                return $"{Fizz}{Buzz} ";

            if (IsDivisableBy(number, 5))
                return $"{Buzz} ";

            return IsDivisableBy(number, 3) 
                ? $"{Fizz} " 
                : $"{number} ";
        }

        private static bool IsDivisableBy(int number, int divisibleBy)
        {
            return number % divisibleBy == 0;
        }

        private static bool ContainsNumberThree(int number)
        {
            var strNumber = number.ToString();

            return strNumber.Contains("3");
        }
    }
}
