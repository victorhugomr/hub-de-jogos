using System.Text.Json;

using hubdejogos.Models;

namespace hubdejogos.Services{

    public class JsonServices{
        
        public static void WriteJson(List<Account> accounts){
            string path = Path.Combine(Directory.GetCurrentDirectory() + @"\accounts.json");
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(accounts, options);
            var file = File.CreateText(path);
            file.Write(json);
            file.Close();
        }

        public static List<Account> ReadJson(){
            string path = Path.Combine(Directory.GetCurrentDirectory() + @"\accounts.json");
            List<Account> accounts = new List<Account>();
            string json = File.ReadAllText(path);
            accounts = JsonSerializer.Deserialize<List<Account>>(json)!;

            return accounts;
        }

        public static void UpdateScoreJson(Account player){
            List<Account> accounts = ReadJson();

            foreach(Account account in accounts){
                if(player.Nickname == account.Nickname){
                    account.TicTacToePoints = player.TicTacToePoints;
                    //account.Jogo2Points = player.Jogo2Points;
                    account.ChessPoints = player.ChessPoints;
                }
            }
            WriteJson(accounts);
        }
    }
}