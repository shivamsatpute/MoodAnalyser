using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserPrb
{ 
    public class MoodAnalyser
    {
        public string message;

        public MoodAnalyser()
        {


        }
        public MoodAnalyser(string message) 
        {
            this.message = message;

        }
        public string Analyser()  
        {
            try 
            {
                if (this.message.Equals(string.Empty))
                {

                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else
                {
                    if (this.message.ToLower().Contains("happy"))
                    {
                        return "happy";
                    }
                    else
                    {
                        return "sad";
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }
        }
    }
}
