using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controls.Test
{
    class TestException : Exception
    {
        public enum ErrorCode
        {
            FAILED_TO_LOAD
        }

        public static Dictionary<ErrorCode, String> codeMessageMap = new Dictionary<ErrorCode, string>
        {
            {ErrorCode.FAILED_TO_LOAD, "An error occured attempting to load the test" }
        };
       
        
        public TestException(ErrorCode code, string message, Exception innerException) : base(message, innerException)
        {
            UserFriendlyError = codeMessageMap[code];
        }

        string UserFriendlyError
        {
            get;set;
        }
    }
}
