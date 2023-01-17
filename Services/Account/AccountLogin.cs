using hubdejogos.Models;
using hubdejogos.Views;

namespace hubdejogos.Services{

    public class AccountLogin{
        public AccountLogin(){
        }
        public static void Login(Account player1, Account player2){
            List<Account> accounts = JsonServices.ReadJson(Path.Combine(Directory.GetCurrentDirectory() + @"\accounts.json"));

            AccountSettingsView.LoginScreen();
			string? nickname = Console.ReadLine();
            if(NicknameExists(accounts, nickname)){
                AccountSettingsView.PasswordScreen();
                string? password = Console.ReadLine();
                int index = GetIndex(accounts, nickname);
                if(password == accounts[index].Password){
                    if(player1.Nickname == null){
                        player1 = accounts[index];
                        AccountSettingsView.LoginSuccessfulScreen();
                    }
                    else if(player2.Nickname == null){
                        player2 = accounts[index];
                        AccountSettingsView.LoginSuccessfulScreen();
                    }
                    else{
                        AccountSettingsView.PlayerFullScreen();
                    }
                }
            }
            else{
                //Nickname não foi encontrado na base de dados.
            }
        }

        private static int GetIndex(List<Account> accounts, string? nickname){
            return accounts.FindIndex(a => a.Nickname == nickname);
        }

        private static bool NicknameExists(List<Account> accounts, string? nickname){
			foreach(Account item in accounts){
				if(nickname == item.Nickname){
					return true;
				}
			}
			return false;
   		}
    }
}