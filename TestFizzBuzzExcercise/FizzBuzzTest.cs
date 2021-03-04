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
            int counter = 0;
            string line;
            int[] entry = new int[100];

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"{..\..\..\..\..\..\Resources\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                entry[counter] = int.Parse(line);
                counter++;
            }

            file.Close();

            string expected = "";

            foreach (var number in entry)
            {
                string resutl = "";

                if (number % 3 == 0)
                {
                    resutl += "Fizz";
                }

                if (number % 5 == 0)
                {
                    resutl += "Buzz";
                }

                if (!string.IsNullOrWhiteSpace(resutl))
                {
                    expected += resutl;
                }
                else
                {
                    expected += number.ToString();
                }
            }

            string actual = Program.RunProcess(entry);

            Assert.Equal(expected, actual);
        }
    }
}
