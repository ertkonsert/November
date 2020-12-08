using System;
using System.Collections.Generic;
using Raylib_cs;

namespace novemberprojektet
{
    public class SnakeHead: SnakePiece
    {
        Rectangle head = new Rectangle(250, 250, 10, 10);
        public bool alive = true;
        public float xMovement = 10f;
        public float yMovement = 10f;
        string direction = "up";


        public SnakeHead()
        {
            pieces.Add(this);

            this.piece.height = 10;
            this.piece.width = 10;
            this.piece.x = 250;
            this.piece.y = 250;
        }


        float timerMaxValue = 0.4f;
        float timerCurrentValue = 0.4f;


        public override void Update()
        {   
            timerCurrentValue -= Raylib.GetFrameTime();
            if (timerCurrentValue < 0)
            {
               Move();
               timerCurrentValue = timerMaxValue;
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT) == true && direction != "right")
            {
                direction = "left";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT) == true && direction != "left")
            {
                direction = "right";

            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_UP) == true && direction != "down")
            {
                direction = "up";
            }

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_DOWN) == true && direction != "up")
            {
                direction = "down";
            }

            

        }

        public void Move()
        {
            if (direction == "left")
            {
                this.piece.x -= xMovement;
            }

            else if (direction == "right")
            {
                this.piece.x += xMovement;
            }

            else if (direction == "up")
            {
                this.piece.y -= yMovement;
            }

            else if (direction == "down")
            {
                this.piece.y += yMovement;
            }        
            
            
        }

        public void Grow()
        {
            
        }














    }
}
