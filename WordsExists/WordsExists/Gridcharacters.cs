using System;

namespace WordsExists
{
    internal class Gridcharacters
    {
        public bool Exist(char[][] board, string strWord)
        {
            int nRows = board.Length;
            int nCols = board[0].Length;

            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nCols; j++)
                {
                    if (board[i][j] == strWord[0] && LetterSequencely(i, j, 0))
                    {
                        return true;
                    }
                }
            }

            bool LetterSequencely(int nRowWise, int nColWise, int nIndexWise)
            {
                if (nIndexWise == strWord.Length)
                {
                    return true;
                }

                if (nRowWise < 0 || nRowWise >= nRows || nColWise < 0 || nColWise >= nCols || board[nRowWise][nColWise] != strWord[nIndexWise])
                {
                    return false;
                }

                char CTemp = board[nRowWise][nColWise];
                board[nRowWise][nColWise] = '*';

                bool bFoundChar = LetterSequencely(nRowWise + 1, nColWise, nIndexWise + 1) ||
                                  LetterSequencely(nRowWise - 1, nColWise, nIndexWise + 1) ||
                                  LetterSequencely(nRowWise, nColWise + 1, nIndexWise + 1) ||
                                  LetterSequencely(nRowWise, nColWise - 1, nIndexWise + 1);

                board[nRowWise][nColWise] = CTemp; 
                return bFoundChar;
            }
            return false;
        }
    }
}
