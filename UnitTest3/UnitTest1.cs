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

        // TC 4.1

        [TestMethod]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            MoodAnalyserFactory factory = new MoodAnalyserFactory();
            object obj = factory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        // TC 4.2
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NOClassException()
        {
            string expected = "Class not found";
            try
            {
                string message = null;
                object moodAnalyser = new MoodAnalyser(message);
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                object obj = factory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        // TC 4.3
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException()
        {
            string expected = "Constructor not found";
            try
            {
                string message = null;
                object moodAnalyser = new MoodAnalyser(message);
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                object obj = factory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        // TC 5.1
        [TestMethod]
        public void Given_MoodAnalyzer_Using_Reflection_Return_ParameterConstructor()  //Method
        {
            string message = "I am in happy mood";
            MoodAnalyser expected = new MoodAnalyser("I am in happy mood"); //Create object and arrange 
            object obj = null;
            //string actual = "";
            // string expected = "Mood should not be empty";

            try
            {
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", message);
            }
            catch (MoodAnalyserException exception)
            {

            }
            obj.Equals(expected);

        }

        // TC 5.2
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NoClassException_UsingParameterizedConstrucor()
        {
            string expected = "Class not found";
            object obj = null;
            try
            {
                string message = "Happy";

                object moodAnalyser = new MoodAnalyser(message);
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", message);
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }

        // TC 
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException_UsingParameterizedConstrucor()
        {
            string expected = "Constructor not found";
            object obj = null;
            try
            {
                string message = "Happy";

                object moodAnalyser = new MoodAnalyser(message);
                MoodAnalyserFactory factory = new MoodAnalyserFactory();
                obj = factory.CreateMoodAnalyserParameterObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", message);
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}