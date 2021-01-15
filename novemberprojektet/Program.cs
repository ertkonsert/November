using System;
using Raylib_cs;

namespace novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Raylib.InitWindow(500, 500, "Snek");
            Raylib.SetTargetFPS(60);
            Color grassGreen = new Color(177, 245, 139, 255);
            //Hade tänkt göra en pausskärm där man därifrån kan stänga spelet, därför är den satt till 0
            Raylib.SetExitKey(0);

            //skapar ormhuvudet
            SnakeHead snek = new SnakeHead();
            //skapar mat
            Food yum = new Food();
            //ger maten referens till huvudet så den kan påverka huvudet
            yum.head = snek;

            while (!Raylib.WindowShouldClose())
            {
                
                //update för maten 
                yum.Update();
                //update för ormen
                SnakePiece.UpdateAll();

                //raylib börjar rita ut
                Raylib.BeginDrawing();
                
                //sätter bakgrundsfärgen till grön
                Raylib.ClearBackground(grassGreen);
                
                


                
                
                //ritar ut alla ormbitar
                SnakePiece.DrawAll();
                    
                //raylib slutar rita ut
                Raylib.EndDrawing();


                
                
                
                
      
            }

        }
    }
}
