using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programStatus = true;
            while (programStatus == true)
            {
                GamePlay a = new GamePlay();
                while (a.GameStatus == false)
                {
                    GameBoard board = (a.StartGame(Welcome.DisplayWelcomeScreen()));
                    int gameStatus = 0;

                    while (gameStatus == 0 || gameStatus == 2)
                    {
                        board.PlayingField();
                        a.RequestPlayerInput(board);
                        board.PlayingField();
                        gameStatus = a.PlayerWinStatus(board);
                    }
                }
                programStatus = a.endGame();
            }
        }
    }
}


