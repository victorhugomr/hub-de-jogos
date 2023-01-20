namespace hubdejogos.Models.Chess.Pieces{

    public class Bishop : Piece{

        public Bishop(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            if(board.SelectedPiece != null){
                if(board.SelectedPiece.Line < destinyLine){
                    if(board.SelectedPiece.Column < destinyColumn){
                        int i;
                        int j=board.SelectedPiece.Column;
                        for(i=board.SelectedPiece.Line; i<destinyLine;){
                            i+=1;
                            j+=1;
                            if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color == board.SelectedPiece.Color){
                                return false;
                            }
                            else if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color != board.SelectedPiece.Color){
                                if(i != destinyLine && j != destinyColumn){
                                    return false;
                                }
                            }
                        }
                        if(i != destinyLine || j != destinyColumn){
                            return false;
                        }
                    }
                    else if(board.SelectedPiece.Column > destinyColumn){
                        int i;
                        int j=board.SelectedPiece.Column;
                        for(i=board.SelectedPiece.Line; i<destinyLine;){
                            i+=1;
                            j-=1;
                            if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color == board.SelectedPiece.Color){
                                return false;
                            }
                            else if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color != board.SelectedPiece.Color){
                                if(i != destinyLine && j != destinyColumn){
                                    return false;
                                }
                            }
                        }
                        if(i != destinyLine || j != destinyColumn){
                            return false;
                        }
                    }
                    else{
                        return false;
                    }
                }
                else if(board.SelectedPiece.Line > destinyLine){
                    if(board.SelectedPiece.Column > destinyColumn){
                        int i;
                        int j=board.SelectedPiece.Column;
                        for(i=board.SelectedPiece.Line; i>destinyLine;){
                            i-=1;
                            j-=1;
                            if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color == board.SelectedPiece.Color){
                                return false;
                            }
                            else if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color != board.SelectedPiece.Color){
                                if(i != destinyLine && j != destinyColumn){
                                    return false;
                                }
                            }
                        }
                        if(i != destinyLine || j != destinyColumn){
                            return false;
                        }
                    }
                    else if(board.SelectedPiece.Column < destinyColumn){
                        int i;
                        int j=board.SelectedPiece.Column;
                        for(i=board.SelectedPiece.Line; i>destinyLine;){
                            i-=1;
                            j+=1;
                            if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color == board.SelectedPiece.Color){
                                return false;
                            }
                            else if(board.GetPiece(i,j) != null && board.GetPiece(i,j).Color != board.SelectedPiece.Color){
                                if(i != destinyLine && j != destinyColumn){
                                    return false;
                                }
                            }
                        }
                        if(i != destinyLine || j != destinyColumn){
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
                //Verifica se o destino é igual a origem
                if(board.SelectedPiece.Line == destinyLine && board.SelectedPiece.Column == destinyColumn){
                    return false;
                }
            }

            return true;
        }
    }
}