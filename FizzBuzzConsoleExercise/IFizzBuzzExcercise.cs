using FizzBuzzConsoleExercise.Utils;

namespace FizzBuzzConsoleExercise
{
    public interface IFizzBuzzExcercise
    {
        public string Excercise([ValidationData] int[] array);
    }
}
