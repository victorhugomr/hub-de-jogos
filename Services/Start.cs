using hubdejogos.Models;
using hubdejogos.Views;

namespace hubdejogos.Services{

    public class Start{

        Account player1 = new Account();
        Account player2 = new Account();

        public Start(){
        }

        public void StartMenu(){
            int option;
            do{
                Menu.MenuView();
                Menu.StartView();
                int.TryParse(Console.ReadLine(), out option);

                switch(option){
                    case 1:
                        if(player1?.Nickname == null || player2?.Nickname == null){
                            Menu.NotLoggedIn();
                        }
                        else{
                            TicTacToe ticTacToe = new TicTacToe();
                            ticTacToe.NewGame(player1, player2);
                        }
                        break;
                    case 2:
                        /* if(player1 == null || player2 == null){
                            Menu.NotLoggedIn();
                            int.TryParse(Console.ReadLine(), out option);
                        }
                        else{
                            Jogo2 jogo2 = new Jogo2();
                            jogo2.NewGame();
                        } */
                            break;
                    case 3:
                        if(player1?.Nickname == null || player2?.Nickname == null){
                            Menu.NotLoggedIn();
                        }
                        else{
                            Chess chess = new Chess();
                            chess.NewGame(player1, player2);
                        }
                            break;
                    case 4:
                        Scoreboard.ShowScoreboard();
                        break;
                    case 5:
                        AccountSettings.CreateAccount();
                        break;
                    case 6:
                        if(player1?.Nickname == null){
                            player1 = AccountLogin.Login();
                        }
                        else if(player2?.Nickname == null){
                            player2 = AccountLogin.Login();
                        }
                        else{
                            //Os 2 jogadores já estão logados. Se quiser entrar com outro jogador, é necessário realizar o logout.
                            AccountSettingsView.PlayersLoggedIn();
                        }
                        break;
                    case 7:
                        if(player1?.Nickname == null && player2?.Nickname == null){
                            AccountSettingsView.PlayersNotLoggedIn();
                        }
                        else{
                            AccountLogin.Logout(player1, player2);
                        }
                        break;
                    case 0:
                        Console.Clear();
                        break;
                }
            }while(option != 0);
        }
    }
}