namespace hubdejogos.Views{

    public class Menu{
        public Menu(){
        }

        public static void MenuView(){
            Console.Clear();
            Console.WriteLine("*** BEM-VINDO AO HUB DE JOGOS ***\n");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Jogo da Velha");
            Console.WriteLine("2. Jogo 2");
            Console.WriteLine("3. Xadrez");
            Console.WriteLine("4. Placares");
            Console.WriteLine("5. Fazer login");
            Console.WriteLine("6. Criar conta");
            Console.WriteLine("0. Sair");
        }
    }
}