using System;
using System.Collections.Generic;
using System.Text;

namespace LoginWpfApp.Validation
{
    public interface IValidationTypes
    {
        string Name { get; set; }
        bool Validate(out string message);
    }
}
