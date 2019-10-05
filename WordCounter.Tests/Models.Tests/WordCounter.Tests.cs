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
            bool input = WordCount.SetValue("and", "and then");
            //Assert
            Assert.AreEqual(true, input);
            
        }
        [TestMethod]
        public void WordCounter_WhenUserEntersWordWillItCountTheWordOccurances_And_1()
        {
            //Arrange
            char[] WordInput = word.ToCharArray("and");
            char[] SentenceInput = sentence.ToCharArray("And then and");
            //Act
            int Counter = WordCount.RepeatCounter( WordInput,SentenceInput);
            //Assert
            Assert.AreEqual(2, Counter);

        }
    }
}   