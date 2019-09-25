using System;
using System.Collections.Generic;
using System.Text;

namespace Library.GameObj
{
    public class Turtle
    {
        public int posX, posY;
        public bool alive = true;

        public void setPos(int x, int y)
        {
            posX = x;
            posY = y;
            Console.WriteLine("The Turtle's position is "+ x +","+ y); 
        }

        public int getPosX()
        {
            return posX;
        }
        public int getPosY()
        {
            return posY;
        }

        public void Move(int r, int c)
        {
            //check boundary 
            int ran = RandomNumber(0, 4);

            // move turtle up if boundary allows
            if (ran == 0 && posX > 0)
            {
                setPos(posX - 1, posY);
            }
            // move turtle down if boundary allows
            if (ran == 1 && posX < r-1)
            {
                setPos(posX +1, posY);
            }
            // move turtle right if boundary allows
            if (ran == 2 && posY < c-1)
            {
                setPos(posX, posY+1);
            }
            // move turtle left if boundary allows
            if (ran == 3 && posY > 0)
            {
                setPos(posX, posY-1);
            }

        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
