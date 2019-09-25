using System;
using System.Collections.Generic;
using System.Text;

namespace Library.GameObj
{
    public class Exit
    {
        int x = 0;
        int y = 0;
        public void setPos()
        {
            // should be random between row and column in grid excluding trutle start pos
            // check grid to see if exit is on mine!!!
            
            while (x == 0 && y == 0)
            {
                x = RandomNumber(0, 5);
                y = RandomNumber(0, 5);
            }

           // Console.WriteLine("The Exit's position is " + x + "," + y);
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public int getPosY()
        {
            return y;
        }
        public int getPosX()
        {
            return x;
        }

    }
}
