using System;
using System.Collections.Generic;
using System.Text;

namespace Library.GameObj
{
    public class Grid
    {
        public static int Rows = 5;
        public static int Columns = 5;
        public Square[][] _square;
        public void CreateGrid()
        {
            _square = new Square[Columns][];
            for (int i = 0; i < Columns; i++)
            {
                _square[i] = new Square[Rows];
                for (int j = 0; j < Rows; j++)
                {
                    //create a new square in grid
                    _square[i][j] = new Square() { x = i, y = j };
                    // Console.WriteLine("The Square's position is " + i + "," + j);
                }
            }

        }
        public int GetBoundaryR()
        {
            return Rows;
        }
        public int GetBoundaryC()
        {
            return Columns;
        }
    }
    
}
