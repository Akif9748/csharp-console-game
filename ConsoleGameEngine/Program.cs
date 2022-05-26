using System;


namespace ConsoleGameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Config of game
            int[] pos = { 0, 0 };
            char character = ' ';

            //Count of key presses:
            int moves = 0;

            ConsoleGame game = new ConsoleGame();
            ConsoleKeyInfo keyInfo;
            
            //First render:
            game.Set(pos[0], pos[1], character);

            while (true)
            {


                keyInfo = Console.ReadKey();

                //For exit:
                if (keyInfo.KeyChar == 'c')
                {
                    game.Clear();
                    Console.WriteLine("Game finished with " + moves + " moves.");
                    Console.ReadLine();
                    break;
                }
                else
                {

                    //Reset map:
                    game.Reset();

                    //Change pos:
                    switch (keyInfo.Key.ToString())
                    {
                        case "LeftArrow":
                            if (pos[0] > 0) pos[0] -= 1;
                            break;

                        case "RightArrow":
                            if (pos[0] < game.x - 1) pos[0] += 1;
                            break;

                        case "UpArrow":
                            if (pos[1] > 0) pos[1] -= 1;
                            break;

                        case "DownArrow":
                            if (pos[1] < game.y - 1) pos[1] += 1;
                            break;

                        default:
                            break;

                    }

                    //SET and RENDER:
                    game.Set(pos[0], pos[1], character);
                    moves++;
                }

            }
        }
    }
}
