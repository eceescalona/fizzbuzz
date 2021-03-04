using FizzBuzzConsoleExercise.Utils;
using System;

namespace FizzBuzzConsoleExercise.Excercise
{
    internal class CExercise : IFizzBuzzExcercise
    {
        public string Excercise([ValidationData(ErrorMessage = "Argument out of range")] int[] array)
        {
            string result = "";

            foreach (var number in array)
            {
                string line = "";

                if (number % 3 == 0)
                {
                    line += "Fizz";
                }

                if (number % 5 == 0)
                {
                    line += "Buzz";
                }

                if (!string.IsNullOrWhiteSpace(line))
                {
                    result += line;
                }
                else
                {
                    result += number.ToString();
                }
            }

            return result;
        }
    }
}
