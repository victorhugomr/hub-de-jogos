using hubdejogos.Services;
using hubdejogos.Models.Chess.Pieces;
using hubdejogos.Views.Chess;

namespace hubdejogos.Models.Chess{

    public class Board{
        
        public Piece[,] Position { get; set; }
        public Piece? SelectedPiece { get; set; } = null;
        public Color Turn { get; set; }

        public Board(){
            Position = new Piece[8,8];
            Position[0,0] = new Rook(0,0,Color.WHITE,"T");
            Position[0,1] = new Knight(0,1,Color.WHITE,"H");
            Position[0,2] = new Bishop(0,2,Color.WHITE,"B");
            Position[0,3] = new Queen(0,3,Color.WHITE,"Q");
            Position[0,4] = new King(0,4,Color.WHITE,"K");
            Position[0,5] = new Bishop(0,5,Color.WHITE,"B");
            Position[0,6] = new Knight(0,6,Color.WHITE,"H");
            Position[0,7] = new Rook(0,7,Color.WHITE,"T");
            for(int j=0; j<=7; j++){
                Position[1,j] = new Pawn(1,j,Color.WHITE,"P");
            }
            Position[7,0] = new Rook(7,0,Color.BLACK,"T");
            Position[7,1] = new Knight(7,1,Color.BLACK,"H");
            Position[7,2] = new Bishop(7,2,Color.BLACK,"B");
            Position[7,3] = new Queen(7,3,Color.BLACK,"Q");
            Position[7,4] = new King(7,4,Color.BLACK,"K");
            Position[7,5] = new Bishop(7,5,Color.BLACK,"B");
            Position[7,6] = new Knight(7,6,Color.BLACK,"H");
            Position[7,7] = new Rook(7,7,Color.BLACK,"T");
            for(int j=0; j<=7; j++){
                Position[6,j] = new Pawn(6,j,Color.BLACK,"P");
            }
            Turn = Color.WHITE;
        }

        public static void MovePiece(Board board){
            int destinyLine;
            int destinyColumn;

            do{
                board.SelectPiece(board);
                SelectDestiny(board, out destinyLine, out destinyColumn);
            }while(!board.isValidDestiny(board, destinyLine, destinyColumn));
            board.RemovePiece(board);
            board.AddPiece(board, destinyLine, destinyColumn);
        }

        public Piece GetPiece(int line, int column){
            return Position[line,column];
        }

        public static int GetLine(Board board){
            int line;
            do{
                int.TryParse(Console.ReadLine(), out line);
                if(line<1 || line>8){
                    ChessView.showBoard(board);
                    ChessView.InvalidLine();
                }
            }while(line<1 || line>8);

            return line-1; //transforma a linha inserida pelo usuário em index
        }

        public static int GetColumn(Board board){
            int column;
            do{
                int.TryParse(Console.ReadLine(), out column);
                if(column<1 || column>8){
                    ChessView.showBoard(board);
                    ChessView.InvalidColumn();
                }
            }while(column<1 || column>8);

            return column-1; //transforma a coluna inserida pelo usuário em index
        }

        public void AddPiece(Board board, int destinyLine, int destinyColumn){
            if(SelectedPiece != null){
                Position[destinyLine, destinyColumn] = SelectedPiece;
                SelectedPiece.Line = destinyLine;
                SelectedPiece.Column = destinyColumn;
            }
        }

        public void RemovePiece(Board board){
            if(SelectedPiece != null)
                Position[SelectedPiece.Line, SelectedPiece.Column] = null;
        }

        public void SelectPiece(Board board){
            int line;
            int column;

            do{
                do{
                    ChessView.showBoard(board);
                    ChessView.SelectPieceLine();
                    line = GetLine(board);
                    ChessView.showBoard(board);
                    ChessView.SelectPieceColumn();
                    column = GetColumn(board);
                    if(Position[line,column] == null){
                        ChessView.showBoard(board);
                        ChessView.InvalidPiece();
                    }
                }while(Position[line,column] == null);
                    
                if(Position[line,column].Color != Turn){
                    ChessView.showBoard(board);
                    ChessView.InvalidTurn();
                }
            }while(Position[line,column].Color != Turn);

            SelectedPiece = GetPiece(line, column);
        }

        public static void SelectDestiny(Board board, out int destinyLine, out int destinyColumn){
            do{
                ChessView.showBoard(board);
                ChessView.SelectDestinyLine();
                destinyLine = GetLine(board);
                ChessView.showBoard(board);
                ChessView.SelectDestinyColumn();
                destinyColumn = GetColumn(board);
                if((destinyLine>7 || destinyLine<0) || (destinyColumn>7 || destinyColumn<0)){
                    //Destino fora do Tabuleiro
                }
            }while((destinyLine>7 || destinyLine<0) || (destinyColumn>7 || destinyColumn<0));
        }

        public bool isValidDestiny(Board board, int destinyLine, int destinyColumn){
            if(SelectedPiece != null)
                return SelectedPiece.moveValidate(board, destinyLine, destinyColumn);
            else
                return false;
        }

        public static void ShiftTurn(Board board){
            if(board.Turn == Color.WHITE){
                board.Turn = Color.BLACK;
            }
            else if(board.Turn == Color.BLACK){
                board.Turn = Color.WHITE;
            }
        }

        public bool isEndGame(Board board, Account player1, Account player2){
            int kingsCount=0;
            Color kingsColor = new Color();
            for(int i=0; i<=7; i++){
                for(int j=0; j<=7; j++){
                    if(board.Position[i,j] != null && board.Position[i,j].Image == "K"){
                        kingsCount += 1;
                        kingsColor = board.Position[i,j].Color;
                    }
                }
            }
            if(kingsCount==1){
                if(kingsColor == Color.WHITE){
                    player1.ChessPoints += 1;
                    ChessView.showBoard(board);
                    JsonServices.UpdateScoreJson(player1);
                    ChessView.Player1Victory();
                }
                else if(kingsColor == Color.BLACK){
                    player2.ChessPoints += 1;
                    ChessView.showBoard(board);
                    JsonServices.UpdateScoreJson(player2);
                    ChessView.Player2Victory();
                }
                return true;
            }
            else{
                return false;
            }
        }
    }
}