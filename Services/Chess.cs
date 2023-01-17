using hubdejogos.Models.Chess;
using hubdejogos.Views.Chess;

namespace hubdejogos.Services{

    public class Chess{
        public Board board;
        public Chess(){
            board = new Board();
        }

        public void NewGame(){
            ChessView.showBoard(board);
        }
    }
}