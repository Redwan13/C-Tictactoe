using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class board
    {
        private char[,] gameBoard = new char[3,3];

        public board()
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }
        }
        public int Put(char x, char[] pos)
        {
            int i = 0, j = 0;

            if(pos[0] == 'A')
            {
                i = 0;
            }
            else if(pos[0] == 'B')
            {
                i = 1;
            }
            else if(pos[0] == 'C')
            {
                i = 2;
            }

            if(pos[1] == '1')
            {
                j = 0;
            }
            else if (pos[1] == '2')
            {
                j = 1;
            }
            else if (pos[1] == '3')
            {
                j = 2;
            }

            if(gameBoard[j, i] == '-')
            {
                gameBoard[j, i] = x;
                return 1;
            }
            else
            {
                Console.WriteLine("Position occuppied!");
                return 0;
            }
        }

        public bool finished()
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if(gameBoard[i,j] == '-')
                    {
                        return false;
                    }
                    
                }
            }

            return true;
        }

        public void printBoard()
        {
            Console.WriteLine("  A | B | C");
            Console.WriteLine("1 " + gameBoard[0, 0] + " | " + gameBoard[0, 1] + " | " + gameBoard[0, 2]);
            Console.WriteLine("2 " + gameBoard[1, 0] + " | " + gameBoard[1, 1] + " | " + gameBoard[1, 2]);
            Console.WriteLine("3 " + gameBoard[2, 0] + " | " + gameBoard[2, 1] + " | " + gameBoard[2, 2]);
        }

        public int IsWon()
        {


            if ((gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X') || (gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X') || (gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X') || (gameBoard[0, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 2] == 'X') || (gameBoard[0, 2] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 0] == 'X') || (gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X') || (gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X') || (gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X'))
            {
                return 1;
            }
            else if ((gameBoard[0, 0] == 'O' && gameBoard[0, 1] == 'O' && gameBoard[0, 2] == 'O') || (gameBoard[0, 0] == 'O' && gameBoard[1, 0] == 'O' && gameBoard[2, 0] == 'O') || (gameBoard[0, 1] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 1] == 'O') || (gameBoard[0, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 2] == 'O') || (gameBoard[0, 2] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 0] == 'O') || (gameBoard[0, 2] == 'O' && gameBoard[1, 2] == 'O' && gameBoard[2, 2] == 'O') || (gameBoard[2, 0] == 'O' && gameBoard[2, 1] == 'O' && gameBoard[2, 2] == 'O') || (gameBoard[1, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[1, 2] == 'O'))
            {
                return 0;
            }
            else if (finished())
            {
                return -1;
            }
            else
            {
                return 3;
            }


        }


    }
}
