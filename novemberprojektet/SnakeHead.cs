using System;
using System.Collections.Generic;
using Raylib_cs;

namespace novemberprojektet
{
    public class SnakeHead: SnakePiece
    {
        public bool alive = true;
        public float xMovement = 10f;
        public float yMovement = 10f;
        string direction = "up";

        //konstruktorn, skapar en liten fyrkant som är ormhuvudet och placerar den i mitten av spelfönstret
        public SnakeHead()
        {
            pieces.Add(this);

            this.piece.height = 10;
            this.piece.width = 10;
            this.piece.x = 250;
            this.piece.y = 250;
        }


        //timervariabler för att reglera ormens krälhastighet
        float timerMaxValue = 0.4f;
        float timerCurrentValue = 0.4f;


        public override void Update()
        {   
            //kollar om det är dags att flytta på ormen
            timerCurrentValue -= Raylib.GetFrameTime();
            if (timerCurrentValue < 0)
            {
                //kör Move() som flyttar på ormen och sedan resettas timern
               Move();
               timerCurrentValue = timerMaxValue;
            }

            //if satser som kollar om man håller ned en av piltangenterna
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

        //metod som flyttar på ormen
        public void Move()
        {
            //flytta ormens kropp fram ett steg
            pieces[pieces.Count-1].piece.x = pieces[0].piece.x;
            pieces[pieces.Count-1].piece.y = pieces[0].piece.y;
            pieces.Insert(1, pieces[pieces.Count-1]);
            pieces.RemoveAt(pieces.Count-1);
            
            
            //flytta huvudet

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

        //metod som lägger till nya bitar på ormen
        public void Grow()
        {
            SnakePiece newPiece = new SnakePiece(this.piece.x, this.piece.y);
            
            Console.WriteLine(pieces[pieces.Count-1].piece.x);
        }


        











    }
}
