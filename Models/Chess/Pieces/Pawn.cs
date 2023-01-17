namespace hubdejogos.Models.Chess.Pieces{

    public class Pawn : Piece{

        private bool firstMove = true;

        public Pawn(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(int destinyLine, int destinyColumn){
            /* if(){
                return false;
            } */
            return true;
        }
    }
}