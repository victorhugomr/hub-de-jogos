namespace hubdejogos.Models.Chess.Pieces{

    public class Pawn : Piece{

        private bool firstMove = true;

        public Pawn(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            if(board.Turn == Color.WHITE){
                if(board.SelectedPiece.Column == destinyColumn){
                    if(firstMove){
                        if(destinyLine - board.SelectedPiece.Line > 2 || destinyLine - board.SelectedPiece.Line < 1){
                            return false;
                        }
                    }
                    else if(destinyLine - board.SelectedPiece.Line != 1){
                        return false;
                    }
                }
                else if(Math.Abs(board.SelectedPiece.Column - destinyColumn) == 1){
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
                firstMove = false;

                return true;
            }
            else if(board.Turn == Color.BLACK){
                if(board.SelectedPiece.Column == destinyColumn){
                    if(firstMove){
                        if(board.SelectedPiece.Line - destinyLine > 2 || board.SelectedPiece.Line - destinyLine < 1){
                            return false;
                        }
                    }
                    else if(board.SelectedPiece.Line - destinyLine != 1){
                        return false;
                    }
                }
                else if(Math.Abs(board.SelectedPiece.Column - destinyColumn) == 1){
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
                firstMove = false;

                return true;
            }
            else{
                return false;
            }
        }
    }
}