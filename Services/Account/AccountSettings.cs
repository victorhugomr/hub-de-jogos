using hubdejogos.Models;
using hubdejogos.Views;

namespace hubdejogos.Services{

    public class AccountSettings{
        public AccountSettings(){
        }

        public static void CreateAccount(){
            Account newAccount = new Account();

            AccountSettingsView.CreateAccountName();
            newAccount.Name = Console.ReadLine();
            
            AccountSettingsView.CreateAccountLogin();
            newAccount.Nickname = Console.ReadLine();

            AccountSettingsView.CreateAccountPassword();
            newAccount.Password = Console.ReadLine();
            
            string path = Path.Combine(Directory.GetCurrentDirectory() + @"\accounts.json");
            List<Account> accounts = new List<Account>();

            if(File.Exists(path)){
                if(new FileInfo(path).Length != 0){
                    accounts = JsonServices.ReadJson(path);
                }
            }
            else{
                File.Create(path).Close();
            }
            accounts.Add(newAccount);
            JsonServices.WriteJson(accounts, path);
        }

        public void ChangePassword(){
        }
    }
}