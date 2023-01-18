using hubdejogos.Models.Chess;
using hubdejogos.Views.Chess;

namespace hubdejogos.Services{

    public class Chess{
        public Board board;

        public Chess(){
            board = new Board();
        }

        public void NewGame(){
            while(!board.isEndGame()){
                ChessView.showBoard(board);
                Board.SelectPiece(board);
                Board.MovePiece(board);
                Board.ShiftTurn(board);
            }
        }
    }
}