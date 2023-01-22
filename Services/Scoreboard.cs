using hubdejogos.Models;
using hubdejogos.Views;

namespace hubdejogos.Services{

    public class Scoreboard{
        public Scoreboard(){
        }

        public static void ShowScoreboard(){
            List<Account> accounts = JsonServices.ReadJson();
            List<Account> ticTacToeLeaders = accounts.OrderByDescending(e => e.TicTacToePoints).ToList();
            //List<Account> jogo2Leaders = new List<Account>();
            List<Account> chessLeaders = accounts.OrderByDescending(e => e.ChessPoints).ToList();
            ScoreboardView.ScoreboardScreen(ticTacToeLeaders, chessLeaders);
        }
    }
}