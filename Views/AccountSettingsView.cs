namespace hubdejogos.Views{

    public class AccountSettingsView{
        public AccountSettingsView(){
        }

        public static void CreateAccountName(){
            Console.Clear();
            Console.WriteLine("CreateAccountName");
        }

        public static void CreateAccountLogin(){
            Console.Clear();
            Console.WriteLine("CreateAccountLogin");
        }

        public static void CreateAccountPassword(){
            Console.Clear();
            Console.WriteLine("CreateAccountPassword");
        }

        public static void LoginScreen(){
            Console.Clear();
            Console.WriteLine("TELA DE LOGIN\n");
            Console.WriteLine("Por favor, insira o nickname cadastrado.");
        }

        public static void PasswordScreen(){
            Console.Clear();
            Console.WriteLine("TELA DE LOGIN\n");
            Console.WriteLine("Por favor, insira sua senha.");
        }

        public static void LoginSuccessfulScreen(){
            Console.Clear();
            Console.WriteLine("Login realizado com sucesso. \n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }

        public static void PlayerFullScreen(){
            Console.Clear();
            Console.WriteLine("Não foi possível realizar o login, pois todos os jogadores estão logados. \n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}