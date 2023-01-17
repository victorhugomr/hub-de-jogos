using hubdejogos.Models.Chess.Pieces;

namespace hubdejogos.Models.Chess{

    public class Board{
        
        private Piece[,] Position { get; set; }
        private Piece? SelectedPiece { get; set; } = null;
        private Color Turn = Color.WHITE;

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
        }

        public Piece GetPiece(int line, int column){
            return Position[line, column];
        }

        public void AddPiece(Piece piece, int line, int column){
            Position[line, column] = piece;
        }

        public void SelectPiece(Piece piece){
            /* if(piece.isSelected()){
            }
            else{
            } */
        }

        public void MovePiece(Piece piece, int line, int column){
        }

        public void shiftTurn(){
            if(Turn == Color.WHITE){
                Turn = Color.BLACK;
            }
            else if(Turn == Color.BLACK){
                Turn = Color.WHITE;
            }
        }
    }
}