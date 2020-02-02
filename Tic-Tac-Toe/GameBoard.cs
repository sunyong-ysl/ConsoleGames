using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class GameBoard
    {
        private const char playerOnePiece = 'X';
        private const char playerTwoPiece = 'O';
        private string playerTurn = "Player 1"; 
        private char slotOne;
        private char slotTwo;
        private char slotThree;
        private char slotFour;
        private char slotFive;
        private char slotSix;
        private char slotSeven;
        private char slotEight;
        private char slotNine;

   
        public char PlayerOnePiece
        {
            get { return playerOnePiece; }
        }
        public char PlayerTwoPiece
        {
            get { return playerTwoPiece; }
        }

        public char SlotOne
        {
            get { return slotOne; }
            set { slotOne = value; }

        }
        public char SlotTwo
        {
            get { return slotTwo; }
            set { slotTwo = value; }
        }
        public char SlotThree
        {
            get { return slotThree; }
            set { slotThree = value; }
        }
        public char SlotFour
        {
            get { return slotFour; }
            set { slotFour = value; }
        }
        public char SlotFive
        {
            get { return slotFive; }
            set { slotFive = value; }
        }
        public char SlotSix
        {
            get { return slotSix; }
            set { slotSix = value; }
        }
        public char SlotSeven
        {
            get { return slotSeven; }
            set { slotSeven = value; }
        }
        public char SlotEight
        {
            get { return slotEight; }
            set { slotEight = value; }
        }
        public char SlotNine
        {
            get { return slotNine; }
            set { slotNine = value; }
        }

        public string PlayerTurn
        {
            get { return playerTurn; }
            set { playerTurn = value; }
        }

        public void PlayingField()
        {
            Console.Clear();
            string display = @$" 
$$$$$$$$\ $$$$$$\  $$$$$$\        $$$$$$$$\  $$$$$$\   $$$$$$\        $$$$$$$$\  $$$$$$\  $$$$$$$$\ 
\__$$  __|\_$$  _|$$  __$$\       \__$$  __|$$  __$$\ $$  __$$\       \__$$  __|$$  __$$\ $$  _____|
   $$ |     $$ |  $$ /  \__|         $$ |   $$ /  $$ |$$ /  \__|         $$ |   $$ /  $$ |$$ |      
   $$ |     $$ |  $$ |               $$ |   $$$$$$$$ |$$ |               $$ |   $$ |  $$ |$$$$$\    
   $$ |     $$ |  $$ |               $$ |   $$  __$$ |$$ |               $$ |   $$ |  $$ |$$  __|   
   $$ |     $$ |  $$ |  $$\          $$ |   $$ |  $$ |$$ |  $$\          $$ |   $$ |  $$ |$$ |      
   $$ |   $$$$$$\ \$$$$$$  |         $$ |   $$ |  $$ |\$$$$$$  |         $$ |    $$$$$$  |$$$$$$$$\ 
   \__|   \______| \______/          \__|   \__|  \__| \______/          \__|    \______/ \________|
   

                      Reference Board:                                                                             
                                           |                                                         
		          |     |          |          |     |          
		       1  |  2  |  3       |       {SlotOne}  |  {SlotTwo}  |  {SlotThree}
		     _____|_____|_____     |     _____|_____|_____     
		          |     |          |          |     |          
		       4  |  5  |  6       |       {SlotFour}  |  {SlotFive}  |  {SlotSix}       {PlayerTurn}, your turn to play!
		     _____|_____|_____     |     _____|_____|_____     
		          |     |          |          |     |          
		       7  |  8  |  9       |       {SlotSeven}  |  {SlotEight}  |  {SlotNine}       
		          |     |          |          |     |          
					   |
";
            Console.Clear();
            Console.WriteLine(display);
        }

    }
}
