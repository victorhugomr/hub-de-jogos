namespace hubdejogos.Views{

    public class Menu{
        public Menu(){
        }

        public static void MenuView(){
            Console.Clear();
            Console.WriteLine("*** BEM-VINDO AO HUB DE JOGOS ***\n");
            Console.WriteLine("1. Jogo da Velha");
            Console.WriteLine("2. Jogo 2");
            Console.WriteLine("3. Xadrez");
            Console.WriteLine("4. Placares");
            Console.WriteLine("5. Criar conta");
            Console.WriteLine("6. Fazer login");
            Console.WriteLine("7. Fazer logout");
            Console.WriteLine("0. Sair\n");
        }

        internal static void StartView(){
            Console.WriteLine("Escolha uma opção:");
        }

        internal static void NotLoggedIn(){
            MenuView();
            Console.WriteLine("É necessário que 2 jogadores estejam devidamente logados. Por favor, realize o login dos jogadores e tente novamente. Escolha novamente uma opção.");
            Console.WriteLine("\n\nPressione ENTER para continuar.");
            Console.ReadLine();
        }
    }
}