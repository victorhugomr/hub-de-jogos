namespace hubdejogos.Models.Chess.Pieces{

    public class Rook : Piece{

        public Rook(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(int destinyLine, int destinyColumn){
            /* if(){
                return false;
            } */
            return true;
        }
    }
}