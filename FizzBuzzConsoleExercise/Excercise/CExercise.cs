using System;

namespace FizzBuzzConsoleExercise.Excercise
{
    internal class CExercise : IFizzBuzzExcercise
    {
        public string Excercise(int[] array)
        {
            string result = "";

            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            
            if (array.Length != 100)
            {
                throw new ArgumentOutOfRangeException(nameof(array), array.Length, "Argument out of range.");
            }

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
                    Console.WriteLine(line);
                }
                else
                {
                    result += number.ToString();
                    Console.WriteLine(number);
                }
            }

            return result;
        }
    }
}
