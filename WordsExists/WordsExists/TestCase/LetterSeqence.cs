using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordsExists;

namespace SortingTables.Tests
{
    [TestClass]
    public class LetterSeqence
    {
        [TestMethod]
        public void WordsExist_True()
        {
            // Arrange
            char[][] board = {
                new char[] { 'A','B','C','E' },
                new char[] { 'S','F','C','S' },
                new char[] { 'A','D','E','E' }
            };
            string word = "ABCCED";

            //Act
            Gridcharacters WordsExists = new Gridcharacters();
            bool nResult = WordsExists.Exist(board, word);

            //Assert
            Assert.IsTrue(nResult);

        }

        [TestMethod]
        public void WordsExist_False()
        {
            // Arrange
            char[][] board = {
                new char[] { 'A','B','C','E' },
                new char[] { 'S','F','C','S' },
                new char[] { 'A','D','E','E' }
            };
            string word = "ABCCEDR";

            //Act
            Gridcharacters WordsExists = new Gridcharacters();
            bool nResult = WordsExists.Exist(board, word);

            //Assert
            Assert.IsFalse(nResult);
        }
    }
}
