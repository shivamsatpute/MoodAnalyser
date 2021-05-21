using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserPrb;


namespace MoodAnalyserPrb
{
    [TestClass]
    public class UnitTest3
    {
        //TC 1.1
        [TestMethod]
        public void AnalyseMood_ShouldReturn_Sad()
        {
            
            string expected = "sad";
            MoodAnalyser obj = new MoodAnalyser("I am in sad Mood");
           
            string actual = obj.Analyser();

           
            Assert.AreEqual(expected, actual);
        }

       //TC 1.2
        [TestMethod]
        public void Given_Happymood_Expecting_Happy_Result() 
        {
            MoodAnalyser mood = new MoodAnalyser("I am in happy mood");
            string expected = "happy";

            string actual = mood.Analyser();   
            Assert.AreEqual(expected, actual); 
        }
    }
}