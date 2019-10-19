using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounter
    {

        [TestMethod]
        public void RepeatCounter_CountsWords_Int()
        {
            //This method will test if our repeat Counter can count words,
        
            //Arrange

            //Create instance of our RepeatRepeatCounter object
            //Call its constructor to pass in word and sentence
            RepeatCounter testRepeatCounter = new RepeatCounter("Hi", "Hi, im hailey. Say hi to your mother for me");

            //Act

            //Create a variable for the expected count, set its value to 2
            //because we should expect for the method to find 'dog' twice in the sentence
            int expected = 2;

            //Create a variable for the actual count by calling the method
            //Our method should be written to return an int and NOT be static
            int actual = testCounter.WordCount();

            //Assert

            //Test whether the actual count that we got matches the expected count of 2
            Assert.AreEqual(expected, actual);
        }
      
    }
}   