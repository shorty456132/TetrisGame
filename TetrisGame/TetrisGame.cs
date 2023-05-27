using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public class TetrisGame
    {
        private TetrisBoard board;
        private Tetrimino currentTetrimino;
        private Random random;

        public event EventHandler<GameOverEventArgs> GameOver;

        public TetrisGame(int width, int height)
        {
            board = new TetrisBoard(width, height);
            random = new Random();
            SpawnNewTetrimino();
        }

        public void MoveLeft()
        {
            //TODO: Implement left movement
        }
        public void MoveRight()
        {

        }
        public void Rotate() { }
        public void Drop() { }
        private void SpawnNewTetrimino() { }
        private bool IsGameOver() 
        {
            return false;
        }
        private void OnGameOver()
        {
            GameOver?.Invoke(this, new GameOverEventArgs());
        }
    }

    public class GameOverEventArgs : EventArgs 
    { 
        
    }
}
