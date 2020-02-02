using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class GamePlay
    {
        private int playerCount = 1;
        private string currentPlayer = $"Player 1";
        private bool gameStatus = false;
        private bool endStatus = false;
        public bool endGame()
        {
            bool checkInput = false;
            char j = '\0';
            while (checkInput == false)
            {

                Console.Write("Would you like to play again (Y/N): ");
                string k = null;
                try
                {
                    k = Console.ReadLine();
                    while (k.Length != 1)
                    {
                        k = "a";
                    }
                }
                catch
                {
                    Console.WriteLine("Fix your code");
                }
                j = Convert.ToChar(k.ToLower());
                if (j == 'y')
                {
                    checkInput = true;
                }
                else if (j == 'n')
                {
                    checkInput = true;
                }
                else
                {
                    checkInput = false;
                }
            }
            if (j == 'y')
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Thank you for playing!");
                return false;
            }
        }
        public void RequestPlayerInput(GameBoard b)
        {
            char[] allSlots = new char[] { b.SlotOne, b.SlotTwo, b.SlotThree, b.SlotFour, b.SlotFive, b.SlotSix, b.SlotSeven, b.SlotEight, b.SlotNine };
            bool slotChecker = false;
            while (slotChecker == false)
            {
                Console.Write("Pick a slot to place your piece (1-9): ");
                if (currentPlayer == "Player 1")
                {
                    bool testInput = false;
                    int j = 0;
                    while (testInput == false)
                    {
                        try
                        {
                            j = Convert.ToInt32(Console.ReadLine());
                            if (j <= 0 || j >= 10)
                            {
                                Console.WriteLine("Number must be between 1-9");
                            }
                            else
                            {
                                testInput = true;
                            }
                        }
                        catch
                        {
                            Console.Write("Please enter a number: ");
                        }
                    }
                    int c = j - 1;
                    if (allSlots[c] != '\0')
                    {
                        Console.WriteLine("Slot is taken.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        slotChecker = true;
                        switch (j)
                        {
                            case 1:
                                b.SlotOne = 'X';
                                break;
                            case 2:
                                b.SlotTwo = 'X';
                                break;
                            case 3:
                                b.SlotThree = 'X';
                                break;
                            case 4:
                                b.SlotFour = 'X';
                                break;
                            case 5:
                                b.SlotFive = 'X';
                                break;
                            case 6:
                                b.SlotSix = 'X';
                                break;
                            case 7:
                                b.SlotSeven = 'X';
                                break;
                            case 8:
                                b.SlotEight = 'X';
                                break;
                            case 9:
                                b.SlotNine = 'X';
                                break;
                        }
                    }
                }

                else if (currentPlayer == "Player 2")
                {
                    bool testInput = false;
                    int j = 0;
                    while (testInput == false)
                    {
                        try
                        {
                            j = Convert.ToInt32(Console.ReadLine());
                            if (j <= 0 || j >= 10)
                            {
                                Console.WriteLine("Number must be in between 1-9");
                            }
                            else
                            {
                                testInput = true;
                            }
                        }
                        catch
                        {
                            Console.Write("Please enter a number: ");
                        }
                    }
                    int c = j - 1;
                    if (allSlots[c] != '\0')
                    {
                        Console.WriteLine("Slot is taken.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey(true);
                    }
                    else
                    {
                        slotChecker = true;
                        switch (j)
                        {
                            case 1:
                                b.SlotOne = 'O';
                                break;
                            case 2:
                                b.SlotTwo = 'O';
                                break;
                            case 3:
                                b.SlotThree = 'O';
                                break;
                            case 4:
                                b.SlotFour = 'O';
                                break;
                            case 5:
                                b.SlotFive = 'O';
                                break;
                            case 6:
                                b.SlotSix = 'O';
                                break;
                            case 7:
                                b.SlotSeven = 'O';
                                break;
                            case 8:
                                b.SlotEight = 'O';
                                break;
                            case 9:
                                b.SlotNine = 'O';
                                break;
                        }
                    }

                }
            }
        }
        public GameBoard StartGame(char y)
        {
            var newGame = new GameBoard();
            if (y == 'y')
            {
                GameStatus = true;
            }

            else if (y == 'n')
            {
                GameStatus = false;
            }
            return newGame;
        }
        public string PlayerTracker(GameBoard a)
        {
            // This runs after every turn inside another method
            if (playerCount == 1)
            {
                playerCount++;
            }
            else
            {
                playerCount--;
            }
            currentPlayer = $"Player {playerCount}";
            a.PlayerTurn = currentPlayer;
            return currentPlayer;
        }
        public int PlayerWinStatus(GameBoard p)
        {
            char[] allSlots = new char[] { p.SlotOne, p.SlotTwo, p.SlotThree, p.SlotFour, p.SlotFive, p.SlotSix, p.SlotSeven, p.SlotEight, p.SlotNine };
            const int playerWin = 1;
            const int gameStillGoing = 2;
            const int staleMate = 3;

            if ((p.SlotOne == p.PlayerOnePiece && p.SlotTwo == p.PlayerOnePiece && p.SlotThree == p.PlayerOnePiece) || (p.SlotOne == p.PlayerTwoPiece && p.SlotTwo == p.PlayerTwoPiece && p.SlotThree == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if ((p.SlotOne == p.PlayerOnePiece && p.SlotFour == p.PlayerOnePiece && p.SlotSeven == p.PlayerOnePiece) || (p.SlotOne == p.PlayerTwoPiece && p.SlotFour == p.PlayerTwoPiece && p.SlotSeven == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if ((p.SlotOne == p.PlayerOnePiece && p.SlotFive == p.PlayerOnePiece && p.SlotNine == p.PlayerOnePiece) || (p.SlotOne == p.PlayerTwoPiece && p.SlotFive == p.PlayerTwoPiece && p.SlotNine == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if ((p.SlotFive == p.PlayerOnePiece && p.SlotTwo == p.PlayerOnePiece && p.SlotEight == p.PlayerOnePiece) || (p.SlotFive == p.PlayerTwoPiece && p.SlotTwo == p.PlayerTwoPiece && p.SlotEight == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if ((p.SlotSix == p.PlayerOnePiece && p.SlotNine == p.PlayerOnePiece && p.SlotThree == p.PlayerOnePiece) || (p.SlotSix == p.PlayerTwoPiece && p.SlotNine == p.PlayerTwoPiece && p.SlotThree == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if ((p.SlotFour == p.PlayerOnePiece && p.SlotFive == p.PlayerOnePiece && p.SlotSix == p.PlayerOnePiece) || (p.SlotFour == p.PlayerTwoPiece && p.SlotFive == p.PlayerTwoPiece && p.SlotSix == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if ((p.SlotSeven == p.PlayerOnePiece && p.SlotEight == p.PlayerOnePiece && p.SlotNine == p.PlayerOnePiece) || (p.SlotSeven == p.PlayerTwoPiece && p.SlotEight == p.PlayerTwoPiece && p.SlotNine == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if ((p.SlotFive == p.PlayerOnePiece && p.SlotSeven == p.PlayerOnePiece && p.SlotThree == p.PlayerOnePiece) || (p.SlotFive == p.PlayerTwoPiece && p.SlotSeven == p.PlayerTwoPiece && p.SlotThree == p.PlayerTwoPiece))
            {
                Console.WriteLine($"{currentPlayer} wins, you lose");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return playerWin;
            }
            else if (p.SlotOne != '\0' && p.SlotTwo != '\0' && p.SlotThree != '\0' && p.SlotFour != '\0' && p.SlotFive != '\0' && p.SlotSix != '\0' && p.SlotSeven != '\0' && p.SlotEight != '\0' && p.SlotNine != '\0')
            {
                Console.WriteLine("Game is a stalemate, please play again");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                return staleMate;
            }
            else
            {
                PlayerTracker(p);
                return gameStillGoing;
            }

        }
        public int PlayerCount
        {
            get { return playerCount; }
            set { playerCount = value; }
        }
        public string CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }
        public bool GameStatus
        {
            get { return gameStatus; }
            set { gameStatus = value; }
        }
        public bool EndStatus
        { 
            get { return endStatus; }
            set { endStatus = value; }
        }


    }
}






