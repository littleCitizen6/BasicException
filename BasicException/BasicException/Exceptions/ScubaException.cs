using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicException.Exceptions
{
    public class ScubaException : Exception
    {
        private string _userName;
        public override string Message => $"hey {_userName}, you have a scuba exception please check your scuba ";
        public ScubaException()
        {
            _userName = Environment.UserName;
        }

        
    }
}
