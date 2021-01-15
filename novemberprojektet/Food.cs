using System;
using Raylib_cs;

namespace novemberprojektet
{
    public class Food
    {
        Random generator = new Random();
        Rectangle piece = new Rectangle();
        public SnakeHead head;

        public Food()
        {
            this.piece.height = 10;
            this.piece.width = 10;
            this.piece.x = 200;
            this.piece.y = 200;

        }
        
        public void Update()
        {
            Raylib.DrawRectangleRec(this.piece, Color.RED);
            bool eaten = Raylib.CheckCollisionRecs(this.piece, head.piece);
            if (eaten == true)
            {
                head.Grow();
                this.piece.x = generator.Next(50)*10;
                this.piece.y = generator.Next(50)*10;
            }
            //kolla kollission med snakehead, if yes då kör grow annars inget
        }






            


        


    }
}
