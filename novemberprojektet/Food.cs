using System;
using Raylib_cs;

namespace novemberprojektet
{
    public class Food: SnakePiece
    {
        Random generator = new Random(500);

        public Food()
        {
            this.piece.height = 10;
            this.piece.width = 10;
            this.piece.x = generator.Next();
            this.piece.y = generator.Next();
        }

        public override void Update()
        {
            //kolla kollission med snakehead, if yes då kör grow annars inget
        }






            


        


    }
}
