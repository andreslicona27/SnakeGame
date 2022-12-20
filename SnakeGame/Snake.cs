using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Snake
    {
        // PROPERTIES
        private int snakeSize;
        private int speed;
        private int posX;
        private int posY;

        // SETTERS / GETTERS
        public int SnakeSize
        {
            get
            {
                return snakeSize;
            }
            set
            {
                this.snakeSize = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public int PosX
        {
            get
            {
                return posX;
            }
            set
            {
                this.posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return posY;
            }
            set
            {
                this.posY = value;
            }
        }

        // BUILDER 
        public Snake(int PositionX, int PositionY)
        {
            SnakeSize = 3;
            Speed = 30;
            this.PosX = PositionX;
            this.PosY = PositionY;
        }

        // FUNCTIONS
        public void SnakeMove(int direction)
        {
            if(direction == 0)
            {
                // up
            }
            else if(direction == 1)
            {
                // rigth
            }
            else if (direction == 2)
            {
                // left
            }
            else
            {
                // down 
            }

        }

        public void SnakeGrow()
        {
            this.snakeSize += 1;
        }

        public void DrawSnake()
        {

        }

        public void SnakeCrash()
        {

        }

    }
}
