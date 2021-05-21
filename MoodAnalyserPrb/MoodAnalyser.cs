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


        public MoodAnalyser(string message) 
        {
            this.message = message;

        }
        public string Analyser()  
        {
            try 
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
            catch
            {
                return "happy";
            }
        }
    }
}
