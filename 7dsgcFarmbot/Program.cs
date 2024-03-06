using API;
using DataContainer;
using GameClient;
using System.Text;

namespace _7dsgcFarmbot
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //Change the input and output encoding to display korean and japanese characters
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            DataTableManager.Instance.Initialize();
            AccountInfo acc = AccountInfo.ParseAccountInfo("account.json");
            ConfigurationData config = await APIClient.GetConfiguration(acc.GameCode);
            GeoIPData? geo = await APIClient.GetGeoIP();
            AuthData auth = new AuthData(acc, config, geo);
            if (acc.GameCode == GameCode.nanakr)
            {
                LocalizationManager.Initialize("Localization/Korean.sqlite");
            }
            else
            {
                LocalizationManager.Initialize("Localization/Japanese.sqlite");
            }
            if (!await auth.Authenticate())
            {
                throw new Exception("Failed to log in...");
            }
            PacketManager.Instance.Connect(config.IP, config.Port);
            while (!PacketManager.Instance.IsConnected || PacketManager.Instance.IsForceDisconnected)
            {
                await Task.Delay(10);
            }
            PacketManager.Instance.GameClient.RequestSecurityToken();
            PacketManager.Instance.GameClient.RequestNetmarbleAuth(auth.PlayerID, auth.AccessToken, string.Empty, config.ClientVersion, ClientDeviceType.Windows, 1, auth.SDKInfo, (int)acc.GameCode);
            auth.SDKInfo.sdkADID = GameDataContainer.Instance.UserData.AuthKey.ToString();
            string exeHash, assemblyHash;
            GetGameHash(acc.GameCode, out exeHash, out assemblyHash);
            PacketManager.Instance.GameClient.RequestLogin(GameDataContainer.Instance.UserData.Usn, auth.SDKInfo, new VersionInfo() { cdnVersion = config.PatchVersion, clientVersion = config.ClientVersion }, string.Empty, DateTime.Now.Ticks, exeHash, assemblyHash, (LanguageType)acc.GameCode, (int)acc.GameCode);
            await Task.Delay(Timeout.Infinite);
        }

        // Using the SHA256 algorithm:
        // exeHash is the hash of the file "7dsgc.exe" and assemblyHash the hashes of the files "GameAssembly.dll" and "global-metadata.dat" separated by a ;
        // These two hashes are used in the login request PacketManager.Instance.GameClient.RequestLogin (arguments patchName and patchData)
        // Even if the hashes are incorrect the login works but it's better to use the correct ones
        private static void GetGameHash(GameCode game, out string exeHash, out string assemblyHash)
        {
            if (game == GameCode.nanakr)  // v2.47.0
            {
                exeHash = "DwVLmBODc5Z2oU1z5gqkNqJoT6qGqvhlew77jkNdNXQ=";
                assemblyHash = "p/nD8obPRI2+k9PRBzBkhzR2eVYmi56RSdT+popK9w8=;d8yXdiSDTMdYd9YNXqHNJg6ixT0/VcL0nn0jdOwnbEU=";
                return;
            }
            else if (game == GameCode.nanatsunotaizai)  // v2.40.0 (update asap)
            {
                exeHash = "kFZCeARe1x/vvjb6hUwCN4lE5LbwPZsxYoF9L/fZDNw=";
                assemblyHash = "B0g58QWL04+1CKZvIt6nj1YSByIG9UN5gST/nLxwSlM=;xTU6NLSX335bcjglpo5lZd+jgv2yRr442HYHARav3dU=";
                return;
            }
            throw new ArgumentException($"Can't get game hash of game: {game}");
            //SHA256 sha256 = SHA256.Create();
            //using (FileStream fs = new FileStream("7dsgc.exe", FileMode.Open, FileAccess.Read))
            //{
            //    exeHash = Convert.ToBase64String(sha256.ComputeHash(fs));
            //}
            //string gameAssemblyHash, metadataHash;
            //using (FileStream fs = new FileStream("GameAssembly.dll", FileMode.Open, FileAccess.Read))
            //{
            //    gameAssemblyHash = Convert.ToBase64String(sha256.ComputeHash(fs));
            //}
            //using (FileStream fs = new FileStream("global-metadata.dat", FileMode.Open, FileAccess.Read))
            //{
            //    metadataHash = Convert.ToBase64String(sha256.ComputeHash(fs));
            //}
            //assemblyHash = string.Concat(gameAssemblyHash, ";", metadataHash);
        }
    }
}