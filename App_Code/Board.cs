﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Board
{
    public const string userSymbol = "X";
    public const string computerSymbol = "O";
    public const string empty = "";
    private string[,] board = new string[3, 3];

    public Board()
    {
        Reset();
    }

    public string GetSquare(int row, int col)
    {
        return board[row, col];
    }

    public void SetSquare(int row, int col, string value)
    {
        board[row, col] = value;
    }

    public void Reset()
    {
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                board[r, c] = "";
            }
        }
    }

    // take form related code out of this method
    public void MakeComputerMove()
    {
        Random gen = new Random();
        int row;
        int column;
        do
        {
            row = gen.Next(0, 3);
            column = gen.Next(0, 3);
        } while (board[row, column] != empty);

        board[row, column] = computerSymbol;
    }

    public bool IsRowWinner(int row)
    {
        if (board[row, 0] == board[row, 1]
                && board[row, 1] == board[row, 2]
                && board[row, 0] != empty)
        {
            return true;
        }
        else
            return false;
    }

    public bool IsAnyRowWinner()
    {
        return IsRowWinner(0) || IsRowWinner(1) || IsRowWinner(2);
    }

    public bool IsColumnWinner(int col)
    {
        if (board[0, col] == board[1, col]
                && board[1, col] == board[2, col]
                && board[0, col] != empty)
        {
            return true;
        }
        else
            return false;
    }

    public bool IsAnyColumnWinner()
    {
        return IsColumnWinner(0) || IsColumnWinner(1) || IsColumnWinner(2);
    }

    public bool IsDiagonal1Winner()
    {
        if (board[0, 0] == board[1, 1] &&
            board[1, 1] == board[2, 2] &&
            board[0, 0] != empty)
            return true;
        else
            return false;
    }

    public bool IsDiagonal2Winner()
    {
        if (board[0, 2] == board[1, 1] &&
            board[1, 1] == board[2, 0] &&
            board[0, 2] != empty)
            return true;
        else
            return false;

    }

    public bool IsAnyDiagonalWinner()
    {
        if (IsDiagonal1Winner())
        {
            return true;
        }
        else if (IsDiagonal2Winner())
        {
            return true;
        }
        else
            return false;

    }

    public bool IsWinner()
    {
        return IsAnyRowWinner() ||
                IsAnyColumnWinner() ||
                IsAnyDiagonalWinner();
    }

    public bool IsFull()
    {
        for (int row = 0; row < 3; row++)
            for (int col = 0; col < 3; col++)
                if (board[row, col] == empty)
                    return false;
        return true;

    }

    public bool IsTie()
    {
        return (IsFull() && !(IsWinner()));
    }
}
