using System;
using Raylib_cs;

namespace novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jag har gjort variabler av fönsterstorlekarna så jag lätt kan ändra det sen
            int windowSizeX = 1000;
            int windowSizeY = 1000; 
            Raylib.InitWindow(windowSizeX, windowSizeY, "Snek");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                
                Raylib.ClearBackground(Color.GREEN);
      
                Raylib.DrawCircle(100,100,100,Color.MAGENTA);
      
                Raylib.EndDrawing();
            }

        }
    }
}
