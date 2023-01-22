using hubdejogos.Models;
using hubdejogos.Views;

namespace hubdejogos.Services{

    public class AccountLogin{
        public AccountLogin(){
        }
        public static Account Login(){
            List<Account> accounts = JsonServices.ReadJson();

            AccountSettingsView.LoginScreen();
			string? nickname = Console.ReadLine();
            if(NicknameExists(accounts, nickname)){
                AccountSettingsView.PasswordScreen();
                string? password = Console.ReadLine();
                int index = GetIndex(accounts, nickname);
                if(password == accounts[index].Password){
                    AccountSettingsView.LoginSuccessfulScreen();
                    return accounts[index];
                }
                else{
                    AccountSettingsView.PasswordDoesntMatch();
                    return new Account();
                }
            }
            else{
                //Nickname não foi encontrado na base de dados.
                AccountSettingsView.UserNotFound();
                return new Account();
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