using System;

namespace TicTacToeGame 
{
    public class TicTacToeGame
    {

        public static void Main(string[] args)
        {
            char[] board = createboard();
            
        }

        //uc1
        private static char[] createboard() { 
            char[] board = new char[10];
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
}
}