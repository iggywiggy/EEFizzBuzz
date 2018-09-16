using System.Text;

namespace EEFizzBuzz
{
    public class FizzBuzz
    {
        private const string Fizz = "fizz";
        private const string Buzz = "buzz";
        private const string Lucky = "lucky";

        public string DoFizzBuzz(int lowerBound, int upperBound)
        {
            var output = new StringBuilder();

            for (var i = lowerBound; i <= upperBound; i++)
            {
                output.Append(GetFizzBuzz(i));
            }

            return output.ToString().Trim();
        }

        private static string GetFizzBuzz(int number)
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
