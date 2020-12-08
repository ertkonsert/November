using System;
using System.Collections.Generic;
using Raylib_cs;

namespace novemberprojektet
{
    public class SnakePiece
    {
        public static List<SnakePiece> pieces = new List<SnakePiece>();
        public Rectangle piece = new Rectangle();

        
        public SnakePiece()
        {
            pieces.Add(this);
            
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
            foreach (SnakePiece p in pieces)
            {
                p.Update();
            }
        }


        
    }
}
