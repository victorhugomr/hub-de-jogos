using System.Text.Json;

using hubdejogos.Models;

namespace hubdejogos.Services{

    public class JsonServices{
        
        public static void WriteJson(List<Account> accounts, string path){
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(accounts, options);
            var file = File.CreateText(path);
            file.Write(json);
            file.Close();
        }

        public static List<Account> ReadJson(string path){
            List<Account> accounts = new List<Account>();
            string json = File.ReadAllText(path);
            accounts = JsonSerializer.Deserialize<List<Account>>(json)!;

            return accounts;
        }

    }
}