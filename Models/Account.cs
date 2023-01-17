namespace hubdejogos.Models{

    public class Account{
        public string? Name { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        public int ChessPoints { get; set; }
        public int TicTacToePoints { get; set; }

        public Account(){
            ChessPoints = 0;
            TicTacToePoints = 0;
        }
    }
}