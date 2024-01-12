// AdultValidator.cs
using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public class AdultValidatorAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value is int age)
        {
            return age >= 18;
        }

        return false;
    }
}
