using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public class TetrisBoard
    {
        //2d array to store the state of each cell on the grid
        private int[,] board;

        public int Width { get; private set; }
        public int Height { get; private set; }
        

        public TetrisBoard(int width, int height)
        {
            //this.board = board;
            board = new int[width, height];
            Width = width;
            Height = height;
        }

        public int GetCellState(int x, int y)
        {
            return board[x, y];
        }

        //TODO: Implement methods to interact with the game board (e.g. setting cell state)
    }
}
