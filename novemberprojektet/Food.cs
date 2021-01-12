using System;
using Raylib_cs;

namespace novemberprojektet
{
    public class Food
    {
        Random generator = new Random(500);
        Rectangle piece = new Rectangle();

        public Food()
        {
            this.piece.height = 10;
            this.piece.width = 10;
            this.piece.x = 200;
            this.piece.y = 200;

        }
        
        public void Update()
        {
            //Raylib.DrawRectangleRec(this.piece, Color.RED);
            //bool eaten = Raylib.CheckCollisionPointRec(this.piece, piece));

            //kolla kollission med snakehead, if yes då kör grow annars inget
        }






            


        


    }
}
