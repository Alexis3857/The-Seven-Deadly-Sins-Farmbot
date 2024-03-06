using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace _7dsgcFarmbot
{
    public sealed class AccountInfo  // Contains the sync code, password and game version of an account
    {
        public string SyncCode { get; }

        public string Password { get; }

        public GameCode GameCode { get; }

        private const string SyncInfoRegex = @"^[a-zA-Z0-9]+$";

        private const int SyncCodeLength = 8;

        private const int PasswordMinLength = 6;

        private const int PasswordMaxLength = 14;

        private AccountInfo(string syncCode, string password, GameCode gameCode)
        {
            SyncCode = syncCode;
            Password = password;
            GameCode = gameCode;
        }

        // The class AccountInfo can only be created with this method
        // The user must have created a json file fileName with the properties : sync_code, password and game_code
        // Throws an exception if the file fileName doesn't exist or if its content is invalid
        public static AccountInfo ParseAccountInfo(string fileName)
        {
            string syncCode, password, strGameCode;
            try
            {
                JObject jsonData = JObject.Parse(File.ReadAllText(fileName));
                syncCode = (string)jsonData["sync_code"];
                password = (string)jsonData["password"];
                strGameCode = (string)jsonData["game_code"];
            }
            catch
            {
                throw new Exception($"The file {fileName} does not exist or its content is malformed.");
            }
            GameCode gameCode;
            if (syncCode == null || syncCode.Length != SyncCodeLength || !Regex.IsMatch(syncCode, SyncInfoRegex) ||
                password == null || password.Length < PasswordMinLength || password.Length > PasswordMaxLength || !Regex.IsMatch(password, SyncInfoRegex) ||
                strGameCode == null || (gameCode = strGameCode == "nanakr" ? GameCode.nanakr : strGameCode == "nanatsunotaizai" ? GameCode.nanatsunotaizai : GameCode.invalid) == GameCode.invalid)
            {
                throw new Exception($"The file {fileName} contains invalid data.");
            }

            return new AccountInfo(syncCode, password, gameCode);
        }
    }
}
