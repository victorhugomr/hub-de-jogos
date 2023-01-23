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
                        if(board.Position[i,j].Color == Color.WHITE){
                            Console.Write(board.GetPiece(i,j).Image);
                        }
                        else{
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(board.GetPiece(i,j).Image);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n    A B C D E F G H\n");
        }

        public static void SelectPieceLine(){
            Console.WriteLine("Por favor, insira a LINHA da PEÇA que deseja movimentar");
        }

        public static void SelectPieceColumn(){
            Console.WriteLine("Por favor, insira a COLUNA da PEÇA que deseja movimentar");
        }

        public static void SelectDestinyLine(){
            Console.WriteLine("Por favor, insira a LINHA de DESTINO");
        }

        public static void SelectDestinyColumn(){
            Console.WriteLine("Por favor, insira a COLUNA de DESTINO");
        }

        public static void InvalidTurn(){
            Console.WriteLine("A peça selecionada é inválida. Não é o turno desse jogador");
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
        }

        public static void InvalidLine(){
            Console.WriteLine("A linha selecionada é inválida. Por favor, digite um número de 1 a 8.");
        }

        public static void InvalidColumn(){
            Console.WriteLine("A coluna selecionada é inválida. Por favor, digite um número de 1 a 8.");
        }

        public static void InvalidPiece(){
            Console.WriteLine("A posição selecionada é inválida. Não possui uma peça válida nessa posição");
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
        }

        internal static void Player1Victory(){
            Console.WriteLine("Vitória do Jogador 1 !!!");
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
        }

        internal static void Player2Victory(){
            Console.WriteLine("Vitória do Jogador 2 !!!");
            Console.WriteLine("\nPressione ENTER para continuar");
            Console.ReadLine();
        }
    }
}