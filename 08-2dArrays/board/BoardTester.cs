using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // make a new instance of the board game 
        Board b = new Board();
        b.board[0, 0] = Board.WOOD;
    }
}

