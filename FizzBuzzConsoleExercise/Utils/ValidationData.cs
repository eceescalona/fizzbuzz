using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzzConsoleExercise.Utils
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
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
            return string.Format("The {0} parameter is not valid.", nameof(name));
        }
    }
}
