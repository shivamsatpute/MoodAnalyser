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
        // UC2
       
        [TestMethod]
        public void Given_Nullmood_Expecting_Exception_Result()  
        {
            MoodAnalyser mood = new MoodAnalyser(null); 
            string expected = "Object reference not set to an instance of an object.";

            string actual = mood.Analyser();   

            Assert.AreEqual(expected, actual);  
        }

        //TC 2.1
        [TestMethod]
        public void Given_Nullmood_Expecting_happy_Result()  
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "happy";

            string actual = mood.Analyser();    

            Assert.AreEqual(expected, actual); 


        }
        //TC: 3.1
        [TestMethod]
        public void Given_Nullmood_Using_CustomExpection_Return_Null()  
        {
            MoodAnalyser mood = new MoodAnalyser(null); 
            string actual = "";

            try
            {
                actual = mood.Analyser();   

            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);  
            }
        }
        // TC 3.2
        [TestMethod]
        public void Given_Emptymood_Using_CustomExpection_Return_Empty() 
        {

            string actual = "";

            try
            {
                string message = string.Empty;
                MoodAnalyser mood = new MoodAnalyser(message); 
                actual = mood.Analyser();    

            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual("Mood should not be empty", exception.Message);  
            }

        }
    }
}