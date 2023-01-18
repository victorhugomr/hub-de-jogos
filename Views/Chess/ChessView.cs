using hubdejogos.Models.Chess;

namespace hubdejogos.Views.Chess{

    public class ChessView{

        public static void showBoard(Board board){
            Console.Clear();
            for(int i=7; i>=0; i--){
                Console.Write($"{i+1}   ");
                for(int j=0; j<=7; j++){
                    if(board.GetPiece(i,j) == null){
                        Console.Write("-");
                    }
                    else{
                        Console.Write(board.GetPiece(i,j).Image);
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n    A B C D E F G H\n");
        }

        public static void SelectLineScreen(){
            Console.WriteLine("Por favor, insira a linha da peça que deseja movimentar");
        }

        public static void SelectColumnScreen(){
            Console.WriteLine("Por favor, insira a coluna da peça que deseja movimentar");
        }
    }
}