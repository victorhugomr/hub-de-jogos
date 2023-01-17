using hubdejogos.Models;
using hubdejogos.Views;

namespace hubdejogos.Services{

    public class Start{

        public Start(){
        }

        Account player1 = new Account();
        Account player2 = new Account();

        public void StartMenu(){
            int option;
            do{
                Menu.MenuView();
                int.TryParse(Console.ReadLine(), out option);

                switch(option){
                    case 1:
                        TicTacToe ticTacToe = new TicTacToe();
                        ticTacToe.NewGame();
                        break;
                    case 2:
                        //Jogo2 jogo2 = new Jogo2();
                        //jogo2.NewGame();
                        break;
                    case 3:
                        Chess chess = new Chess();
                        chess.NewGame();
                        break;
                    case 4:
                        //Scoreboard();
                        break;
                    case 5:
                        AccountLogin.Login(player1, player2);
                        break;
                    case 6:
                        AccountSettings.CreateAccount();
                        break;
                    case 0:
                        Console.Clear();
                        break;
                }
            }while(option != 0);
        }
    }
}