using hubdejogos.Models.TicTacToe;

namespace hubdejogos.Views.TicTacToe{

    public class TicTacToeView{

        public static void showBoard(Board board){
            Console.Clear();
            Console.WriteLine($"{board.position[0]} {board.position[1]} {board.position[2]}");
            Console.WriteLine($"{board.position[3]} {board.position[4]} {board.position[5]}");
            Console.WriteLine($"{board.position[6]} {board.position[7]} {board.position[8]}");
        }

        public static void choosePositionScreen(){
            Console.WriteLine($"\nVEZ DO \"jogador\": Em qual posição deseja jogar?");
        }

        public static void victoryScreen(){
            Console.WriteLine("\nFim de jogo (vitória). Pressione ENTER para retornar ao menu.");
            Console.ReadLine();
        }

        public static void drawScreen(){
            Console.WriteLine("\nFim de jogo (empate). Pressione ENTER para retornar ao menu.");
            Console.ReadLine();
        }
    }
}