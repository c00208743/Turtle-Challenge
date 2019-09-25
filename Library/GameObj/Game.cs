using System;
using System.Collections.Generic;
using System.Text;

namespace Library.GameObj
{
    public class Game
    {
        
        private Grid _grid;
        private Turtle _turtle;
        private Mine _mine;
        private Mine _mineTwo;
        private Exit _exit;

        private Game()
        {
            _grid = new Grid();
            _turtle = new Turtle();
            _mine = new Mine();
            _mineTwo = new Mine();
            _exit = new Exit();
            Initialize();
        }
        public static Game CreateNewGame()
        {
           // Console.WriteLine("Hello Game!")
            return new Game();
        }

        public void Start()
        {
            bool gameOver = false;

            //game loop
            while (_turtle.alive == true || gameOver == true){
                
                int row = _grid.GetBoundaryR();
                int column = _grid.GetBoundaryC();

                _turtle.Move(row, column);

                //get play pos chack pos against grid for mine
                int turtleX =_turtle.getPosX();
                int turtleY = _turtle.getPosY();
                if (_grid._square[turtleX][turtleY].getMine() == true)
                {
                    _turtle.alive = false;
                }

                if (_grid._square[turtleX][turtleY].getExit() == true)
                {
                    gameOver = true;
                }
                
            }

            if (gameOver == true)
            {
                Console.WriteLine("The turtle left saftely");
            }
            if (_turtle.alive == false)
            {
                Console.WriteLine("The turtle found a mine");
            }


        }

        public void Initialize()
        {
            //initialize grid
            _grid.CreateGrid();

            //set mines
            _mine.setPos();
            _mineTwo.setPos();

            //first mine in grid
            int mineX = _mine.getPosX();
            int mineY = _mine.getPosY();
            _grid._square[mineX][mineY].setMine();

            //second mine in grid
            mineX = _mineTwo.getPosX();
            mineY = _mineTwo.getPosY();
            _grid._square[mineX][mineY].setMine();

            //set exit 
            _exit.setPos();
            int exitX = _exit.getPosX();
            int exitY = _exit.getPosY();
            _grid._square[exitX][exitY].setExit();

            //set turtle starting position
            _turtle.setPos(0,0);
            
        }

    }
}
