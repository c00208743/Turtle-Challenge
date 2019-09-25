using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Library.GameObj
{
    public class Turtle
    {
        public int posX, posY;
        public bool alive = true;
        static readonly string textFile = @"C:/Users/jmurphy/Desktop/TurtleChallenge/TurtleChallenge/Directions.txt";
        string[] lines;

        public void setPos(int x, int y)
        {
            posX = x;
            posY = y;
            Console.WriteLine("The Turtle's position is "+ x +","+ y);

            if (File.Exists(textFile))
            {
                //test
                lines = File.ReadAllLines(textFile);

                // Read entire text file content in one string  
               // foreach (string line in lines)
                  //  Console.WriteLine(line);
            }
            else {
                Console.WriteLine("Error Directions not found");
            }

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
          
            foreach (string line in lines) 
            {
                // move turtle up if boundary allows
                if (line == "up" && posX > 0)
                    {
                    setPos(posX - 1, posY);
                }
                // move turtle down if boundary allows
                if (line == "down" && posX < r - 1)
                {
                    setPos(posX + 1, posY);
                }
                // move turtle right if boundary allows
                if (line == "right" && posY < c - 1)
                {
                    setPos(posX, posY + 1);
                }
                // move turtle left if boundary allows
                if (line == "left" && posY > 0)
                {
                    setPos(posX, posY - 1);
                }
            }
            
        }
       
    }
}
