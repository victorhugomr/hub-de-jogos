using hubdejogos.Models;

namespace hubdejogos.Views{

    public class ScoreboardView{
        public ScoreboardView(){
        }

        public static void ScoreboardScreen(List<Account> ticTacToeLeaders, List<Account> chessLeaders){
            int podiumPlace = 1;
            Console.Clear();
            Console.WriteLine("* * * * * * *  TIC TAC TOE  * * * * * * * *");
            Console.WriteLine("*               NOME            PONTOS    *");
            Console.WriteLine("*                                         *");
            foreach(Account account in ticTacToeLeaders){
                if(account?.TicTacToePoints != null){
                    Console.WriteLine($"* {podiumPlace}º lugar\t{account.Nickname} \t{account.TicTacToePoints} pontos  *");
                    podiumPlace += 1;
                }
            }
            Console.WriteLine("*                                         *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");

            podiumPlace = 1;
            Console.WriteLine();
            Console.WriteLine("* * * * * * * * C H E S S * * * * * * * * *");
            Console.WriteLine("*               NOME            PONTOS    *");
            Console.WriteLine("*                                         *");
            foreach(Account account in chessLeaders){
                if(account?.ChessPoints != null){
                    Console.WriteLine($"* {podiumPlace}º lugar\t{account.Nickname} \t{account.ChessPoints} pontos  *");
                    podiumPlace += 1;
                }
            }
            Console.WriteLine("*                                         *");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");

            Console.WriteLine("\nPressione ENTER para retornar ao menu inicial.");
            Console.ReadLine();
        }
    }
}