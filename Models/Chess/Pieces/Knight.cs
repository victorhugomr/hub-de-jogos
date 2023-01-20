namespace hubdejogos.Models.Chess.Pieces{

    public class Knight : Piece{

        public Knight(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            if(board.SelectedPiece != null){
                if(Math.Abs(board.SelectedPiece.Line - destinyLine) == 1){
                    if(Math.Abs(board.SelectedPiece.Column - destinyColumn) != 2){
                        return false;
                    }
                    if(board.Position[destinyLine,destinyColumn] != null){
                        if(board.Position[destinyLine,destinyColumn].Color == board.SelectedPiece.Color){
                            return false;
                        }
                    }
                }
                else if(Math.Abs(board.SelectedPiece.Line - destinyLine) == 2){
                    if(Math.Abs(board.SelectedPiece.Column - destinyColumn) != 1){
                        return false;
                    }
                    if(board.Position[destinyLine,destinyColumn] != null){
                        if(board.Position[destinyLine,destinyColumn].Color == board.SelectedPiece.Color){
                            return false;
                        }
                    }
                }
                else{
                    return false;
                }
            }
            //Verifica se o destino é igual a origem
            if(board.SelectedPiece?.Line == destinyLine && board.SelectedPiece.Column == destinyColumn){
                return false;
            }

            return true;
        }
    }
}