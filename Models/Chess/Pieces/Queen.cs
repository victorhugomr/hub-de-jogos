namespace hubdejogos.Models.Chess.Pieces{

    public class Queen : Piece{

        public Queen(int line, int column, Color color, string image) : base(line, column, color, image){
        }

        public override bool moveValidate(Board board, int destinyLine, int destinyColumn){
            if(board.SelectedPiece?.Line != destinyLine && board.SelectedPiece?.Column != destinyColumn){
                if(board.SelectedPiece?.Line < destinyLine){
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
                else if(board.SelectedPiece?.Line > destinyLine){
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
            }
            else if(board.SelectedPiece?.Line == destinyLine){
                if(board.SelectedPiece.Column < destinyColumn){
                    //Verifica se o caminho está livre
                    for(int i=board.SelectedPiece.Column; i<destinyColumn; i++){
                        if(board.GetPiece(destinyLine,i) != null && (board.GetPiece(destinyLine,i).Color == board.SelectedPiece.Color)){
                            return false;
                        }
                        else if(board.GetPiece(destinyLine,i) != null && board.GetPiece(destinyLine,i).Color != board.SelectedPiece.Color){
                            if(i != destinyColumn){
                                return false;
                            }
                        }
                    }
                }
                else{
                    if(board.SelectedPiece.Column > destinyColumn){
                        //Verifica se o caminho está livre
                        for(int i=board.SelectedPiece.Column+1; i>destinyColumn; i--){
                            if(board.GetPiece(destinyLine,i) != null && (board.GetPiece(destinyLine,i).Color == board.SelectedPiece.Color)){
                                return false;
                            }
                            else if(board.GetPiece(destinyLine,i) != null && board.GetPiece(destinyLine,i).Color != board.SelectedPiece.Color){
                                if(i != destinyColumn){
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            else if(board.SelectedPiece?.Column == destinyColumn){
                if(board.SelectedPiece.Line < destinyLine){
                    //Verifica se o caminho está livre
                    for(int i=board.SelectedPiece.Line+1; i<destinyLine; i++){
                        if(board.GetPiece(i,destinyColumn) != null && (board.GetPiece(i,destinyColumn).Color == board.SelectedPiece.Color)){
                            return false;
                        }
                        else if(board.GetPiece(i,destinyColumn) != null && board.GetPiece(i,destinyColumn).Color != board.SelectedPiece.Color){
                            if(i != destinyLine){
                                return false;
                            }
                        }
                    }
                }
                else{
                    if(board.SelectedPiece.Line > destinyLine){
                        //Verifica se o caminho está livre
                        for(int i=board.SelectedPiece.Line; i>destinyLine; i--){
                            Console.WriteLine(board.GetPiece(i,destinyColumn).Color);
                            Console.WriteLine(board.SelectedPiece.Color);
                            Console.ReadLine();
                            if(board.GetPiece(i,destinyColumn) != null && (board.GetPiece(i,destinyColumn).Color == board.SelectedPiece.Color)){
                                return false;
                            }
                            else if(board.GetPiece(i,destinyColumn) != null && board.GetPiece(i,destinyColumn).Color != board.SelectedPiece.Color){
                                if(i != destinyLine){
                                    return false;
                                }
                            }
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

            return true;
        }
    }
}