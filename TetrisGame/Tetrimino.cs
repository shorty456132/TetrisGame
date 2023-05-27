using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public class Tetrimino
    { 
        //Define the shape of the tetrimino. the X & Y props represent the current position of the tetrimino
        public List<int[]> Shape { get; private set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Tetrimino(List<int[]> shape)
        {
            Shape = shape;
            X = 0;
            Y = 0;
        }

        public void RotateClockwise()
        { }
        public void MoveLeft() { }
        public void MoveRight() { }
        public void MoveDown() { }
    }
}
