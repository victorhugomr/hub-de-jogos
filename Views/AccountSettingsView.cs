using hubdejogos.Models;

namespace hubdejogos.Views{

    public class AccountSettingsView{
        public AccountSettingsView(){
        }

        public static void CreateAccountName(){
            Console.Clear();
            Console.WriteLine("CreateAccountName");
        }

        internal static void CreateAccountLogin(){
            Console.Clear();
            Console.WriteLine("CreateAccountLogin");
        }

        internal static void CreateAccountPassword(){
            Console.Clear();
            Console.WriteLine("CreateAccountPassword");
        }

        internal static void LoginScreen(){
            Console.Clear();
            Console.WriteLine("TELA DE LOGIN\n");
            Console.WriteLine("(O primeiro jogador a realizar o login será considerado o Jogador 1)\n");
            Console.WriteLine("Por favor, insira o nickname cadastrado.");
        }

        internal static void PasswordScreen(){
            Console.Clear();
            Console.WriteLine("TELA DE LOGIN\n");
            Console.WriteLine("Por favor, insira sua senha.");
        }

        internal static void UserNotFound(){
            Console.Clear();
            Console.WriteLine("Desculpe, o usuário inserido não foi encontrado na base de dados. \n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        internal static void PasswordDoesntMatch(){
            Console.Clear();
            Console.WriteLine("A senha inserida não confere. Verifique se a senha está sendo digitada corretamente. \n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        internal static void LoginSuccessfulScreen(){
            Console.Clear();
            Console.WriteLine("Login realizado com sucesso. \n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        internal static void PlayersLoggedIn(){
            Console.Clear();
            Console.WriteLine("Não foi possível realizar o login, pois todos os jogadores estão logados.");
            Console.WriteLine("Se quiser entrar com outro usuário, é necessário realizar o logout. \n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}