using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicException.Exceptions
{
    public class ScubaException : Exception
    {
        private string _message;
        private string _userName;
        public override string Message => _message;


        public ScubaException(string message) : base(message)
        {
            _userName = Environment.UserName;
            _message = $"hey {_userName}, {message}";


        }
    }
}
