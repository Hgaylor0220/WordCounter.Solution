using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;

namespace Game.Test
{
    [TestClass]
    public class WordCountTest
    {
      
        [TestMethod]
        public void WordCounter_CanUserEnterAWord_And()
        {
            //Arrange

            //Act
            bool input = WordCount.SetValue("hello", "and then");
            //Assert
            Assert.AreEqual(true, input);
            
        }
        [TestMethod]
        public void WordCounter_WhenUserEntersWordWillItCountTheWordOccurances_And_1()
        {
            //Arrange
            string WordInput= "like";
            string SentenceInput = "um like I totally like pizza like a lot";

            //Act
            bool input = WordCount.SetValue(WordInput, SentenceInput);
            int Counter = WordCount.RepeatCounter(WordInput, SentenceInput);
            //Assert
            Assert.AreEqual(3, Counter);
        }
    }
}   