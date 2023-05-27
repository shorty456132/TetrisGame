using Microsoft.Maui.Controls;

namespace TetrisGame;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		InitializeGame();
	}

    private void InitializeGame()
    {
		var tetrisGame = new TetrisGame(10, 20);
        tetrisGame.GameOver += TetrisGame_GameOver;
        DrawGameBoard(tetrisGame);
    }

    private void DrawGameBoard(TetrisGame tetrisGame)
    {
        try
        {
            gameGrid.Children.Clear();

            //Iterate through the game board cells
            for (int row = 0; row < tetrisGame.Board.Height; row++)
            {
                for (int col = 0; col < tetrisGame.Board.Width; col++)
                {
                    var cell = new BoxView();
                    cell.BackgroundColor = GetCellColor(tetrisGame.Board.GetCellState(col, row));
                    cell.Margin = new Thickness(1);
                    Grid.SetRow(cell, row);
                    Grid.SetColumn(cell, col);
                    gameGrid.Children.Add(cell);
                }
            }
        }
        catch(Exception ex)
        {
            throw new NotImplementedException();
        }
    }

    private Color GetCellColor(int cellState)
    {
        //TODO: Define colors for different cell states (e.g., empty, filled)

        //example: 
        if (cellState == 0)
            return Color.FromArgb("#FFFFFF");
        else
            return Color.FromArgb("#000000");
    }

    private void TetrisGame_GameOver(object sender, GameOverEventArgs e)
    {
    }
}

