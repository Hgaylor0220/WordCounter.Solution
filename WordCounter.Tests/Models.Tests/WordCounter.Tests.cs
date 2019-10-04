using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System;

namespace Game.Test
{
    [TestClass]
    public class WordCountTest : IDisposable
    {
        public void Dispose()
        {
            WordCount.ClearAll();
        }

        [TestMethod]
        public void WordCounter_CanUserEnterAWord_And()
        {
            //Arrange
            
            //Act
            bool input= WordCount.RepeatCounter("and")
            //Assert
            Assert.AreEqual(and, true);
            
        }