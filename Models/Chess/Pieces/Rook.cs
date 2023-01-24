namespace hubdejogos.Models.Chess.Pieces{

    public class Rook : Piece{

        public Rook(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            int i;

            if(board.SelectedPiece?.Line == destinyLine){
                if(board.SelectedPiece.Column < destinyColumn){
                    //Verifica se o caminho está livre
                    for(i=board.SelectedPiece.Column+1; i<=destinyColumn; i++){
                        if(board.GetPiece(destinyLine,i) != null && (board.GetPiece(destinyLine,i).Color == board.SelectedPiece.Color)){
                            return false;
                        }
                    }
                    //Elimina a peça, caso seja de uma cor diferente
                    if(i == destinyColumn && board.GetPiece(destinyLine,i).Color != board.SelectedPiece.Color){
                        firstMove = false;
                        return true;
                    }
                }
                else{
                    if(board.SelectedPiece.Column > destinyColumn){
                        //Verifica se o caminho está livre
                        for(i=board.SelectedPiece.Column-1; i>=destinyColumn; i--){
                            if(board.GetPiece(destinyLine,i) != null && (board.GetPiece(destinyLine,i).Color == board.SelectedPiece.Color)){
                                return false;
                            }
                        }
                        //Elimina a peça, caso seja de uma cor diferente
                        if(i == destinyColumn && board.GetPiece(destinyLine,i).Color != board.SelectedPiece.Color){
                            firstMove = false;
                            return true;
                        }
                    }
                }

            }
            else if(board.SelectedPiece?.Column == destinyColumn){
                if(board.SelectedPiece.Line < destinyLine){
                    //Verifica se o caminho está livre
                    for(i=board.SelectedPiece.Line+1; i<=destinyLine; i++){
                        if(board.GetPiece(i,destinyColumn) != null && (board.GetPiece(i,destinyColumn).Color == board.SelectedPiece.Color)){
                            return false;
                        }
                    }
                    //Elimina a peça, caso seja de uma cor diferente
                    if(i == destinyLine && board.GetPiece(i,destinyColumn).Color != board.SelectedPiece.Color){
                        return true;
                    }
                }
                else{
                    if(board.SelectedPiece.Line > destinyLine){
                        //Verifica se o caminho está livre
                        for(i=board.SelectedPiece.Line-1; i>=destinyLine; i--){
                            if(board.GetPiece(i,destinyColumn) != null && (board.GetPiece(i,destinyColumn).Color == board.SelectedPiece.Color)){
                                return false;
                            }
                        }
                        //Elimina a peça, caso seja de uma cor diferente
                        if(i == destinyLine && board.GetPiece(i,destinyColumn).Color != board.SelectedPiece.Color){
                            return true;
                        }
                    }
                }
                

            }
            else{
                return false;
            }
            //Verifica se o destino é igual a origem
            if(board.SelectedPiece.Line == destinyLine && board.SelectedPiece.Column == destinyColumn){
                return false;
            }
            firstMove = false;
            return true;
        }
    }
}