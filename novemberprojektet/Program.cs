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
            //Hade tänkt göra en pausskärm där man därifrån kan stänga spelet, därför
            Raylib.SetExitKey(0);

            SnakeHead snek = new SnakeHead();
            Food yum = new Food();


            while (!Raylib.WindowShouldClose())
            {
                

                SnakePiece.UpdateAll();

                Raylib.BeginDrawing();
                
                Raylib.ClearBackground(grassGreen);
                
                


                
                

                SnakePiece.DrawAll();
                    
                
                Raylib.EndDrawing();


                
                
                
                
      
            }

        }
    }
}
