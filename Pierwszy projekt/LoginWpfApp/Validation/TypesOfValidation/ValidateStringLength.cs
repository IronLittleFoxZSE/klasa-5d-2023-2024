using System;
using System.Collections.Generic;
using System.Text;

namespace LoginWpfApp.Validation.TypesOfValidation
{
    public class ValidateStringLength : ISpecyficValidation<string>
    {
        private int minStringLength;

        public ValidateStringLength(int minStringLength)
        {
            this.minStringLength = minStringLength;
        }

        public bool Validate(string value, out string message)
        {
            message = "";
            if (value.Length < minStringLength)
            {
                message = $"Ciąg znaków jest za któtki.\nWymagane jest {minStringLength} znaków.";
                return false;
            }
            return true;
        }
    }
}
