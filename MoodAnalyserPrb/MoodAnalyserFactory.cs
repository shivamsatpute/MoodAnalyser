using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyserPrb
{
    public class MoodAnalyserFactory
    {
        public object CreateMoodAnalyserObject(string className, string constructor)
        {
            
            string pattern = @"." + constructor + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {

                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyserType = assembly.GetType(className);
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;
                }
                catch (NullReferenceException)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CLASS_NOT_FOUND, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor not found");
            }
        }


    }
}
