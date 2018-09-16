using System;
using System.Collections.Generic;
using System.Text;
using static EEFizzBuzz.Constants;

namespace EEFizzBuzz
{
    public class Report : IReport
    {
        private readonly IDictionary<string, int> _measurementsDict;

        public Report()
        {
            _measurementsDict = new Dictionary<string, int>
            {
                {Fizz, 0},
                {Buzz, 0},
                {$"{Fizz}{Buzz}", 0},
                {Lucky, 0},
                {Integer, 0}
            };
        }

        public string GetReport(string fizzBuzzOutput)
        {
            if (string.IsNullOrEmpty(fizzBuzzOutput))
            {
                throw new ArgumentNullException(nameof(fizzBuzzOutput));
            }

            CalculateReport(fizzBuzzOutput);
            return FormatReport();
        }

        private string FormatReport()
        {
            var output = new StringBuilder();

            foreach (var measurement in _measurementsDict)
                output.AppendFormat($"{measurement.Key}: {measurement.Value} ");

            return output.ToString();
        }

        private void CalculateReport(string fizzBuzzOutput)
        {
            var fizzBuzz = fizzBuzzOutput.Split(' ');

            foreach (var f in fizzBuzz) GetMeasurements(f);
        }

        private static bool IsNumber(string toCheck)
        {
            return int.TryParse(toCheck, out var number);
        }

        private void GetMeasurements(string toCheck)
        {
            switch (toCheck)
            {
                case string s when IsNumber(s):
                    _measurementsDict[Integer] += 1;
                    break;
                case string s when s == Lucky:
                    _measurementsDict[Lucky] += 1;
                    break;
                case string s when s == Buzz:
                    _measurementsDict[Buzz] += 1;
                    break;
                case string s when s == Fizz:
                    _measurementsDict[Fizz] += 1;
                    break;
                case string s when s == Buzz:
                    _measurementsDict[Buzz] += 1;
                    break;
                case string s when s == $"{Fizz}{Buzz}":
                    _measurementsDict[$"{Fizz}{Buzz}"] += 1;
                    break;
            }
        }
    }
}