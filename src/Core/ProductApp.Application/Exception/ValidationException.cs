using System;
using System.Collections.Generic;

namespace ProductApp.Application.Exception
{
    public class ValidationException : System.Exception
    {

        public ValidationException() : this("Validation error occured")
        {
            
        }

        public ValidationException(String message) : base(message)
        {
            
        }

        public ValidationException(System.Exception ex): this(ex.Message)
        {
            
        }
    }
}