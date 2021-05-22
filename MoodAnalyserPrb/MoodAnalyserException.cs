using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPrb
{
   public class MoodAnalyserException: Exception
    {
        ExceptionType type; 
        public string message;

        public enum ExceptionType  
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION, CONSTRUCTOR_NOT_FOUND, CLASS_NOT_FOUND, NO_SUCH_METHOD, NO_SUCH_FIELD, NULL_MESSAGE, FIELD_NULL, NULL
        }
        public MoodAnalyserException(ExceptionType type, string message) : base(message)  
        {
            this.type = type;
        }
    }
}

