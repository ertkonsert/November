using System;
using System.Collections.Generic;
using Raylib_cs;

namespace novemberprojektet
{
    public class Snake: SnakePiece
    {
        Rectangle head = new Rectangle(250, 250, 10, 10);
        public bool alive = true;
        public float xMovement = 10f;
        public float yMovement = 10f;
        string direction = "up";


        public Snake()
        {
            pieces.Add(this);

            this.piece.height = 10;
            this.piece.width = 10;
            this.piece.x = 250;
            this.piece.y = 250;
        }


        float timerMaxValue = 0.5f;
        float timerCurrentValue = 0.5f;


        public override void Update()
        {   
            timerCurrentValue -= Raylib.GetFrameTime();
            if (timerCurrentValue < 0)
            {
               Move();
               timerCurrentValue = timerMaxValue;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) == true && direction != "right")
            {
                direction = "left";
                Raylib.DrawText("LEFT", 200,200,10, Color.BLACK);
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) == true && direction != "left")
            {
                direction = "right";
                Raylib.DrawText("right", 200,200,10, Color.BLACK);

            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP) == true && direction != "down")
            {
                direction = "up";
                Raylib.DrawText("UP", 200,200,10, Color.BLACK);
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN) == true && direction != "up")
            {
                direction = "down";
                Raylib.DrawText("DOWN", 200,200,10, Color.BLACK);
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
















    }
}
