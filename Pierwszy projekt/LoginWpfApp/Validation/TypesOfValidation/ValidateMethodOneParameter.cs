using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfApp.Validation.TypesOfValidation
{
    class ValidateMethodOneParameter<T> : ISpecyficValidation<List<T>>
    {
        Func<T, bool> funcTwoParameters;
        string message;
        public ValidateMethodOneParameter(Func<T, bool> funcTwoParameters, string message)
        {
            this.funcTwoParameters = funcTwoParameters;
            this.message = message;
        }

        public bool Validate(List<T> value, out string message)
        {
            if (!funcTwoParameters(value[0]))
            {
                message = this.message;
                return false;
            }
            message = "";
            return true;
        }
    }
}
