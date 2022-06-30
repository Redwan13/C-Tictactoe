using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            board b = new board();
            char[] inpBuff = new char[2];
            String temp;
            

            b.printBoard();

            Player p1 = new Player("Player1");
            Player p2 = new Player("Player2");

            while(!b.finished())
            {
                
                if (b.IsWon() == 1)
                {
                    Console.WriteLine("Player 1 Wins!");
                    break;
                }
                if (b.IsWon() == 0)
                {
                    Console.WriteLine("Player 2 Wins!");
                    break;
                }
                if (b.IsWon() == 3)
                {
                    Console.WriteLine("\n" + p1.name + " Turn: ");
                    temp = Console.ReadLine();
                    temp = temp.ToUpper();
                    inpBuff = temp.ToCharArray();

                    p1.PlayerMove(b, inpBuff, 'X');

                    b.printBoard();

                    Console.WriteLine("\n" + p2.name + " Turn: ");
                    temp = Console.ReadLine();
                    temp = temp.ToUpper();
                    inpBuff = temp.ToCharArray();

                    p2.PlayerMove(b, inpBuff, 'O');
                    b.printBoard();
                }
                
                
            }

            if (b.IsWon() == -1) Console.WriteLine("Match Draw!");
        }
    }
}
