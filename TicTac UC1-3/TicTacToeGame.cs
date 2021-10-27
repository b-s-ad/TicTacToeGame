using System;

namespace TicTacToeGame
{
    public class TicTacToeGame
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToeGame\n");
            char[]board = createboard();
            TicTacToeGame.chooselettter();
            Console.ReadLine();
            TicTacToeGame.showboard(board);
            Console.ReadLine();
        }

        //uc1
        private static char[] createboard() {
            char[] board = new char[10];
            for (int i = 0; i < 10; i++) {
                board[i] = ' ';

            }
            return board;

        }
        //uc2
        public static void chooselettter()


        {
            Console.WriteLine("choose the letter X or O");

            string choose;
            
            choose = Console.ReadLine();
            
            switch (choose)
            {
                case "O":
                    Console.WriteLine("User is using X");
                    break;
                case "X":
                    Console.WriteLine("computer is using O");
                    break;
                case "o":
                    Console.WriteLine("User is using X");
                    break;
                case "x":
                    Console.WriteLine("computer is using O");
                    break;

                
            }
        }
        //uc3

        public static void showboard(char[]board)
            
        {
            
            
            Console.WriteLine("show the current board");
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("\n---------------");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("\n---------------");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
            Console.WriteLine("\n---------------");

        }
    }
}