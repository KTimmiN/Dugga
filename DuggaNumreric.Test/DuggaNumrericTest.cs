using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DuggaNumreric.Test
{
    [TestClass]
    public class DuggaNumrericTest
    {
        private NumrericNumbers _numrericNumbers = new NumrericNumbers();
        [TestMethod]
        public void NumrericInputCheckIfHasShortcut()
        {
            //Arrange
            string value = "1k";
            string expected = "1000";

            //Act
            string actual = _numrericNumbers.DuggaNumreric(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NumrericInputCheckIfHasNoShortCut()
        {
            //Arrange
            string value = "100";
            string expected = "100";

            //Act
            string actual = _numrericNumbers.DuggaNumreric(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NumrericInputCheckIfHasShortCutButNoDigits()
        {
            //Arrange
            string value = "k";
            string expected = "1000";

            //Act
            string actual = _numrericNumbers.DuggaNumreric(value);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NumrericInputThrowArgumentExceptionIfEmptyString()
        {
            //Arrange
            string value = "";

            //Act
            string actual = _numrericNumbers.DuggaNumreric(value);
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void NumrericInputThrowArgumentNullException()
        {
            //Arrange
            string value = null;

            //Act
            string actual = _numrericNumbers.DuggaNumreric(value);
        }
    }
}
