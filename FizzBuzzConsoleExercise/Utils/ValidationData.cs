using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzConsoleExercise.Utils
{
    [AttributeUsage(AttributeTargets.Parameter)]
    internal class ValidationData : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int[] array = value as int[];
            if (array == null || array.Length <= 0)
            {
                return false;
            }
            else if (array.Length > 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture, ErrorMessageString, name);
        }
    }
}
