namespace hubdejogos.Models.Chess.Pieces{

    public class Pawn : Piece{

        public Pawn(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            if(board.Turn == Color.WHITE){
                //valida movimento vertical
                if(board.SelectedPiece != null && board.SelectedPiece.Column == destinyColumn){
                    //verifica se há uma peça no caminho
                    for(int i=board.SelectedPiece.Line+1; i<=destinyLine; i++){
                        if(board.GetPiece(i,destinyColumn) != null){
                            return false;
                        }
                    }
                    if(firstMove){
                        //verifica se andou 1 ou 2 casa no primeiro movimento
                        if(destinyLine - board.SelectedPiece.Line > 2 || destinyLine - board.SelectedPiece.Line < 1){
                            return false;
                        }
                    }
                    //verifica se andou mais de 1 casa
                    else if(destinyLine - board.SelectedPiece.Line != 1){
                        return false;
                    }
                }
                //valida movimento de eliminar peça na diagonal
                else if(board.SelectedPiece != null && Math.Abs(board.SelectedPiece.Column - destinyColumn) == 1){
                    if(Math.Abs(board.SelectedPiece.Line - destinyLine) != 1){
                        return false;
                    }
                    else if(board.Position[destinyLine,destinyColumn] == null || board.Position[destinyLine,destinyColumn].Color != Color.BLACK){
                        return false;
                    }
                }
                else{
                    return false;
                }
            }
            else if(board.Turn == Color.BLACK){
                if(board.SelectedPiece != null && board.SelectedPiece.Column == destinyColumn){
                    for(int i=board.SelectedPiece.Line-1; i>=destinyLine; i--){
                        if(board.GetPiece(i,destinyColumn) != null){
                            return false;
                        }
                    }
                    if(firstMove){
                        if(board.SelectedPiece.Line - destinyLine > 2 || board.SelectedPiece.Line - destinyLine < 1){
                            return false;
                        }
                    }
                    else if(board.SelectedPiece.Line - destinyLine != 1){
                        return false;
                    }
                }
                else if(board.SelectedPiece != null && Math.Abs(board.SelectedPiece.Column - destinyColumn) == 1){
                    if(Math.Abs(board.SelectedPiece.Line - destinyLine) != 1){
                        return false;
                    }
                    else if(board.Position[destinyLine,destinyColumn] == null || board.Position[destinyLine,destinyColumn].Color != Color.WHITE){
                        return false;
                    }
                }
                else{
                    return false;
                }
            }
            else{
                return false;
            }
            firstMove = false;
            return true;
        }
    }
}