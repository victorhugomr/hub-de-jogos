namespace hubdejogos.Models.Chess.Pieces{

    public class Bishop : Piece{

        public Bishop(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            /* if(){
                return false;
            } */
            return true;
        }
    }
}