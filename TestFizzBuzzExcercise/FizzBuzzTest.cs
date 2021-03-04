using System;
using Xunit;
using FizzBuzzConsoleExercise;

namespace TestFizzBuzzExcercise
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Test1()
        {
            int[] entry = new int[100];
            for (int i = 0; i < entry.Length; i++)
            {
                entry[i] = i + 1;
            }

            string expected = "";

            foreach (var number in entry)
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
                    expected += line;
                }
                else
                {
                    expected += number.ToString();
                }
            }

            Program.Main(null);
            string actual = Program.RunProcess(entry);

            Assert.Equal(expected, actual);
        }
    }
}
