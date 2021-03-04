using FizzBuzzConsoleExercise.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzConsoleExercise
{
    public interface IFizzBuzzExcercise
    {
        public string Excercise([ValidationData] int[] array);
    }
}
