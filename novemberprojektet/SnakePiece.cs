using System;
using System.Collections.Generic;
using Raylib_cs;

namespace novemberprojektet
{
    public class SnakePiece
    {
        public static List<SnakePiece> pieces = new List<SnakePiece>();
        public Rectangle piece = new Rectangle(0, 0, 10, 10);

        
        public SnakePiece()
        {
            pieces.Add(this);
            
        }

        public SnakePiece(float x, float y)
        {
            pieces.Add(this);
            piece.x = x;
            piece.y = y;
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(piece, Color.BLACK);
        }

        public static void DrawAll()
        {
            foreach (SnakePiece p in pieces)
            {
                p.Draw();
            }
        }

        public virtual void Update()
        {
            
        }

        public static void UpdateAll()
        {
            //foreach satsen skapade problem med att flytta på ormen så jag ändrade så den bara uppdaterar huvudet, för det är ju egentligen den enda som behöver köra uppdate
            /*
            foreach (SnakePiece p in pieces)
            {
                p.Update();
            }*/
            pieces[0].Update();
        }


        
    }
}
