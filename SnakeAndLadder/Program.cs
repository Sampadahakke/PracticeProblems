using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Welcome To Snake And Ladder========");
            Game game = new Game();
            game.RollDie();
            game.WinningPosition();
            Console.ReadLine();
        }
    }
}
