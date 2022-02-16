using System;

namespace ConsoleGameTest
{
    class ConsoleGame
    {

        public char[][] map;
        public char character;
        public int x, y;

        public ConsoleGame(int x = 16, int y = 8, char chr = '█')
        {

            map = CreateMap(x, y, chr);
            this.x = x;
            this.y = y;
            character = chr;

        }



        public void Reset()
        {
            map = CreateMap(this.x, this.y, this.character);
        }
        /**
        * Clear the console
        */
        public void Clear()
        {
            Console.Clear();
        }
        /**
        * Render the map
        */

        public void Render()
        {
            Clear();

            string write = "";

            foreach (char[] line in map)
            {

                string str = string.Join("", line) + "\n";
                write += str;

            }
            Console.Write(write);


        }



        public void Set(int x = 0, int y = 0, char character = ' ')
        {
            map[y][x] = character;
            Render();
        }


        public char Get(int x, int y)
        {
            return map[y][x];
        }




        private char[][] CreateMap(int x, int y, char character)
        {
            char[][] arr = new char[y][];

            for (int line = 0; line < y; line++)
            {


                char[] arr2 = new char[x];


                for (int i = 0; i < x; i++)
                {
                    arr2[i] = character;
                }


                arr[line] = arr2;
            }

            return arr;
        }





    }
}