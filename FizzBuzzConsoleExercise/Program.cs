using FizzBuzzConsoleExercise.Excercise;
using System;

namespace FizzBuzzConsoleExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[args.Length];
            IFizzBuzzExcercise fizzBuzz = new CExercise();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(args[i]);
            }

            fizzBuzz.Excercise(array);
        }
    }
}
