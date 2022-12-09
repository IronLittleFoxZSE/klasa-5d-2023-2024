using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginWpfApp.Validation.TypesOfValidation
{
    public class ValidateStringRequiredCharacters : ISpecyficValidation<string>
    {
        private List<char> requiredCharacters;

        public ValidateStringRequiredCharacters(List<char> requiredCharacters)
        {
            this.requiredCharacters = requiredCharacters;
        }

        public bool Validate(string value, out string message)
        {
            message = "";
            

            if (!value.ToCharArray().Any(c => requiredCharacters.Contains(c)))
            {
                message = $"Ciąg znaków nie zawiera jednego wymaganego znaku: {string.Join(", ", requiredCharacters)}";
                return false;
            }
            return true;
        }
    }
}
