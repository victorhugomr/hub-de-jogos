namespace hubdejogos.Models.Chess.Pieces{

    public class King : Piece{

        public King(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            if(board.SelectedPiece != null){
                //Verifica se o destino é apenas em alguma posição adjacente
                if(Math.Abs(board.SelectedPiece.Line-destinyLine)>1 || (Math.Abs(board.SelectedPiece.Column-destinyColumn)>1)){
                    return false;
                }
                //Verifica se tem peça da mesma cor no caminho
                if(board.GetPiece(destinyLine,destinyColumn)?.Color != null){
                    if(board.GetPiece(destinyLine,destinyColumn).Color == board.SelectedPiece.Color){
                        return false;
                    }
                }
                //Verifica se o destino é igual a origem
                if(board.SelectedPiece.Line == destinyLine && board.SelectedPiece.Column == destinyColumn){
                    return false;
                }
            }
            firstMove = false;
            return true;
        }
    }
}