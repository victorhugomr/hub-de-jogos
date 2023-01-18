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

        public Piece GetPiece(int line, int column){
            return Position[line,column];
        }

        public static int GetLine(){
            int line;
            do{
                int.TryParse(Console.ReadLine(), out line);
                if(line<1 || line>8){
                    //Erro: essa linha não existe
                }
            }while(line<1 || line>8);

            return line-1;
        }

        public static int GetColumn(){
            int column;
            do{
                int.TryParse(Console.ReadLine(), out column);
                if(column<1 || column>8){
                    //Erro: essa coluna não existe
                }
            }while(column<1 || column>8);

            return column-1; //transforma o inserido pelo usuário em index
        }

        public static void AddPiece(Board board, int destinyLine, int destinyColumn){
            board.Position[destinyLine, destinyColumn] = board.SelectedPiece;
            board.SelectedPiece.Line = destinyLine;
            board.SelectedPiece.Column = destinyColumn;
        }

        public static void RemovePiece(Board board){
            board.Position[board.SelectedPiece.Line, board.SelectedPiece.Column] = null;
        }

        public static void SelectPiece(Board board){
            int line;
            int column;

            do{
                do{
                    ChessView.showBoard(board);
                    ChessView.SelectPieceLine();
                    line = GetLine();
                    ChessView.showBoard(board);
                    ChessView.SelectPieceColumn();
                    column = GetColumn();
                    if(board.Position[line,column] == null){
                        ChessView.showBoard(board);
                        ChessView.InvalidPiece();
                    }
                }while(board.Position[line,column] == null);
                
                if(board.Position[line,column].Color != board.Turn){
                    ChessView.showBoard(board);
                    ChessView.InvalidTurn();
                }
            }while(board.Position[line,column].Color != board.Turn);
            
            board.SelectedPiece = board.GetPiece(line, column);
        }

        public static void MovePiece(Board board){
            int destinyLine;
            int destinyColumn;
            bool isValid = false;

            do{
                ChessView.showBoard(board);
                ChessView.SelectDestinyLine();
                destinyLine = GetLine();
                ChessView.showBoard(board);
                ChessView.SelectDestinyColumn();
                destinyColumn = GetColumn();

                isValid = board.SelectedPiece.moveValidate(board, destinyLine, destinyColumn);
                if(!isValid){
                    //Esse destino não é válido
                }
            }while(!isValid);
            RemovePiece(board);
            AddPiece(board, destinyLine, destinyColumn);
        }

        public static void ShiftTurn(Board board){
            if(board.Turn == Color.WHITE){
                board.Turn = Color.BLACK;
            }
            else if(board.Turn == Color.BLACK){
                board.Turn = Color.WHITE;
            }
        }

        public bool isEndGame(){
            return false;
        }
    }
}