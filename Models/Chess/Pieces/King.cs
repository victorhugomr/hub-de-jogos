namespace hubdejogos.Models.Chess.Pieces{

    public class King : Piece{

        public King(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(int destinyLine, int destinyColumn){
            /* if(){
                return false;
            } */
            return true;
        }
    }
}