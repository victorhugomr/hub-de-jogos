using hubdejogos.Models;
using hubdejogos.Models.TicTacToe;
using hubdejogos.Services;
using hubdejogos.Views.TicTacToe;

namespace hubdejogos.Services{

    public class TicTacToe{
        public Board board;
        private bool endGame;
        private char turn;
        private int movesQuantity;

        public TicTacToe(){
            board = new Board();
            endGame = false;
            turn = 'X';
            movesQuantity = 0;
        }

        public void NewGame(Account player1, Account player2){
            while(!endGame){
                TicTacToeView.showBoard(board);
                choosePosition();
                endGame = isEndGame(player1, player2);
            }
        }

        private void choosePosition()
        {
            TicTacToeView.choosePositionScreen();
            int chosenPosition = getPosition();
            while(!isAvailable(chosenPosition)){
                chosenPosition = getPosition();
            }
            signalMove(chosenPosition);
        }

        private int getPosition()
        {
            int.TryParse(s:Console.ReadLine(), out int chosenPosition);
            while(chosenPosition < 1 || chosenPosition > 9){
                TicTacToeView.showBoard(board);
                Console.WriteLine("\nPosição inválida! Por favor, indique uma posição válida. (Pressione um número entre 1 a 9 e, em seguida, a tecla ENTER)");
                int.TryParse(s:Console.ReadLine(), out chosenPosition);
            }
            return chosenPosition;
        }

        private bool isAvailable(int chosenPosition)
        {
            //int index = chosenPosition - 1;
            if(board.position[chosenPosition-1] == 'X' || board.position[chosenPosition-1] == 'O'){
                TicTacToeView.showBoard(board);
                Console.WriteLine("\nPosição inválida! Por favor, indique uma posição que ainda não foi escolhida.");
                return false;
            }
            else{
                return true;
            }
        }

        private void signalMove(int chosenPosition)
        {
            //int index = chosenPosition - 1;
            board.position[chosenPosition-1] = turn;
            movesQuantity += 1;
        }


        private bool checkHorizontal(Account player1, Account player2)
        {
            if(board.position[0] == board.position[1] && board.position[0] == board.position[2])
                return true;
            else if(board.position[3] == board.position[4] && board.position[3] == board.position[5])
                return true;
            else if(board.position[6] == board.position[7] && board.position[6] == board.position[8])
                return true;
            else
                return false;

        }

        private bool checkVertical(Account player1, Account player2)
        {
            if(board.position[0] == board.position[3] && board.position[0] == board.position[6]){
                if(board.position[0] == 'X'){
                    player1.TicTacToePoints += 1;
                }
                else if(board.position[0] == 'O'){
                    player2.TicTacToePoints += 1;
                }
                return true;
            }
            else if(board.position[1] == board.position[4] && board.position[1] == board.position[7]){
                if(board.position[1] == 'X'){
                    player1.TicTacToePoints += 1;
                }
                else if(board.position[0] == 'O'){
                    player2.TicTacToePoints += 1;
                }
                return true;
            }
            else if(board.position[2] == board.position[5] && board.position[2] == board.position[8]){
                if(board.position[2] == 'X'){
                    player1.TicTacToePoints += 1;
                }
                else if(board.position[0] == 'O'){
                    player2.TicTacToePoints += 1;
                }
                return true;
            }
            else
                return false;
        }

        private bool checkDiagonal(Account player1, Account player2)
        {
            if(board.position[0] == board.position[4] && board.position[0] == board.position[8]){
                if(board.position[0] == 'X'){
                    player1.TicTacToePoints += 1;
                }
                else if(board.position[0] == 'O'){
                    player2.TicTacToePoints += 1;
                }
                return true;
            }
            else if(board.position[2] == board.position[4] && board.position[2] == board.position[6]){
                if(board.position[2] == 'X'){
                    player1.TicTacToePoints += 1;
                }
                else if(board.position[0] == 'O'){
                    player2.TicTacToePoints += 1;
                }
                return true;
            }
            else
                return false;
        }

        private bool checkDraw()
        {
            if(movesQuantity >= 9)
                return true;
            else
                return false;
        }

        private void shiftTurn()
        {
            if(turn == 'X'){
                turn = 'O';
            }
            else if(turn == 'O'){
                turn = 'X';
            }
        }

        private bool isEndGame(Account player1, Account player2)
        {
            if(movesQuantity >= 5){
                if(checkHorizontal(player1, player2) || checkVertical(player1, player2) || checkDiagonal(player1, player2)){
                    TicTacToeView.showBoard(board);
                    JsonServices.UpdateScoreJson(player1);
                    JsonServices.UpdateScoreJson(player2);
                    TicTacToeView.victoryScreen();
                    return true;
                }
                else if(checkDraw()){
                    TicTacToeView.showBoard(board);
                    TicTacToeView.drawScreen();
                    return true;
                }
            }
            shiftTurn();
            return false;
        }
    }
}