using System;
using System.Collections.Generic;
using System.Text;

namespace Library.GameObj
{
    public class Square
    {
        public int x = 0;
        public int y = 0;
        public bool mine = false;
        public bool exit = false;
       
        public void setMine()
        {
            mine = true;
        }
        public void setExit()
        {
            exit = true;
        }
        public bool getMine()
        {
            return mine;
        }
        public bool getExit()
        {
            return exit;
        }
    }
    
}
