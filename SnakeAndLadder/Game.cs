using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Game
    {
        public int position = 0;
        Random random = new Random();
        static int count = 0;
        
        

        public void RollDie()
        {
            count++;
            int rollDie=random.Next(1,7);
            Console.WriteLine("\nNumber on dice = " + rollDie);
            position += rollDie;
            Console.WriteLine("Your position is " + position);
            if(position < 100)
            OptionCheck(rollDie);
            ExactWinningPosition(rollDie);

        } 

        public void OptionCheck(int rollDie)
        {
            int option = random.Next(0, 3);
            switch (option)
            {
                case 0:
                    Console.WriteLine("Sorry!! No Play!");
                   break;
                case 1:
                    Console.WriteLine("Wow!! You Got A Ladder!");
                    position += rollDie;
                    Console.WriteLine("Now your position is " + position);
                    break ;
                case 2:
                    Console.WriteLine("Oh No!! Snake Trap!");
                    position -= rollDie;
                    Console.WriteLine("Now your position is " + position);

                     break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }

        public void WinningPosition()
        {
            while (position < 100)
            {
                RollDie();
            }
            
        }

        public void ExactWinningPosition(int rollDie)
        {
            if(position > 100)
            {
                Console.WriteLine("Oh!! You cant go ahead of 100");
                position -= rollDie;
                Console.WriteLine("So your position is " + position);
            }
            if(position < 0)
            {
                Console.WriteLine("Sorry!! You are at 0 position");
                position = 0; 
            }
            if(position == 100)
            {

                Console.WriteLine("Congrats!!You Won!!");
                Console.WriteLine("No of times dice rolled = " + count);
            }
        }

    }
}
