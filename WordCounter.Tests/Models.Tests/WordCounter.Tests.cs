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
            bool input= WordCount.RepeatCounter("and");
            //Assert
            Assert.AreEqual(true, input);
            
        }
    }
}   