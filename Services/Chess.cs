using hubdejogos.Models;
using hubdejogos.Models.Chess;
using hubdejogos.Views.Chess;

namespace hubdejogos.Services{

    public class Chess{
        public Board board;

        public Chess(){
            board = new Board();
        }

        public void NewGame(Account player1, Account player2){
            while(!board.isEndGame(board, player1, player2)){
                ChessView.showBoard(board);
                Board.MovePiece(board);
                Board.ShiftTurn(board);
            }
        }
    }
}