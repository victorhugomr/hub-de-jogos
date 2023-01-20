namespace hubdejogos.Models.Chess.Pieces{

    public class Knight : Piece{

        public Knight(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
           /*  if(){
                
            }
            //Verifica se o destino é igual a origem
            if(board.SelectedPiece.Line == destinyLine && board.SelectedPiece.Column == destinyColumn){
                return false;
            } */

            return true;
        }
    }
}