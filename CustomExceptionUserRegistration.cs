using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public  class CustomExceptionUserRegistration:Exception
    {
        public enum ExceptionType
        {
            INVALID_NAME,INVALID_EMAIL,INVALID_PHONE,INVALID_PASSWORD_MIN8CHAR_1UPPER,NULL_MESSAGE
        }
        private readonly ExceptionType type;   
        public CustomExceptionUserRegistration(ExceptionType type,string message):base(message)
        {
            this.type= type;
        }
    }
}
