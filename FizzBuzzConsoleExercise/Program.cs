using FizzBuzzConsoleExercise.Excercise;
using System;

namespace FizzBuzzConsoleExercise
{
    public class Program
    {
        private static IFizzBuzzExcercise fizzBuzz;
        public static void Main(string[] args)
        {
            fizzBuzz = new CExercise();
        }

        public static string RunProcess(int[] array)
        {
            return fizzBuzz.Excercise(array);
        }
    }
}
