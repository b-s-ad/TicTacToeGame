using System;

namespace TicTacToeGame
{
    public class TicTacToeGame
    {

        public static void Main(string[] args)
        {
            char[]board = createboard();
            
        }

        //uc1
        private static char[] createboard() { 
            char[]board = new char[10];
            for (int i = 0; i < 10; i++){
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
           switch(choose)
            {
                case "O":
                    Console.WriteLine("User is using X");
                    break;
                case "X":
                    Console.WriteLine("computer is using O");
                    break;

            }
        }
        //uc3

        private static void showboard(char[]board)

        {
            Console.WriteLine("show the current board");
            Console.WriteLine("board[1]\t" + "board[2]\t" + "board[3]\t");
            Console.WriteLine("\n");
            Console.WriteLine("board[4]\t" + "board[5]\t" + "board[6]\t");
            Console.WriteLine("\n");
            Console.WriteLine("board[7]\t" + "board[8]\t" + "board[9]\t");
            Console.WriteLine("\n");

        }
}
}