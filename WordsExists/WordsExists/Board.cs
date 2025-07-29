using System;
using WordsExists;

public class Board
{
    public static void Main(string[] args)
    {
        char[][] board =
        {
                new char[] { 'A','B','C','E' },
                new char[] { 'S','F','C','S' },
                new char[] { 'A','D','E','E' }
        };

        Console.WriteLine("Enter the word:");
        string strWord = Console.ReadLine();

        Gridcharacters WordsExists = new Gridcharacters();
        bool bResult = WordsExists.Exist(board, strWord);

        if (bResult)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}