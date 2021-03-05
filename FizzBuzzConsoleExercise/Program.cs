using FizzBuzzConsoleExercise.Excercise;
using System;

namespace FizzBuzzConsoleExercise
{
    public class Program
    {
        private static IFizzBuzzExcercise fizzBuzz;
        public static void Main(string[] args)
        {
            int counter = 0;
            string line;
            int[] entry = new int[100];

            try
            {
                // Read the file and display it line by line.  
                System.IO.StreamReader file =
                new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"{..\..\..\..\..\..\Resources\test.txt");
                while ((line = file.ReadLine()) != null)
                {
                    entry[counter] = int.Parse(line);
                    counter++;
                }

                fizzBuzz = new CExercise();

                fizzBuzz.Excercise(entry);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR]: {DateTime.Now.ToShortDateString()} => {ex}");
            }
        }

        public static string RunProcess(int[] array)
        {
            fizzBuzz = new CExercise();

            try
            {
                return fizzBuzz.Excercise(array);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
