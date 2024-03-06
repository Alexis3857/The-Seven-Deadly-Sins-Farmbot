using API;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace _7dsgcFarmbot
{
    public class AuthData
    {
        public string PlayerID
        {
            get
            {
                if (string.IsNullOrEmpty(_playerId))
                {
                    return GetRandomHex(32);
                }
                return _playerId;
            }
            private set
            {
                _playerId = value;
            }
        }

        public string DeviceKey
        {
            get
            {
                if (string.IsNullOrEmpty(_deviceKey))
                {
                    return GetRandomHex(32);
                }
                return _deviceKey;
            }
            private set
            {
                _deviceKey = value;
            }
        }

        public string AccessToken { get; private set; } = string.Empty;

        private string SecretKey { get; set; } = string.Empty;

        private string AesInitVec { get; set; } = string.Empty;

        public NetmarbleSDKInfo SDKInfo { get; }

        private APIClient APIClient { get; }

        private AccountInfo Account { get; }

        private static Random RNG { get; } = new Random();

        public AuthData(AccountInfo account, ConfigurationData config, GeoIPData? geoData)
        {
            Account = account;
            APIClient = new APIClient(account.GameCode, config);
            SDKInfo = new NetmarbleSDKInfo()
            {
                UDID = GetDeviceUniqueIdentifier(),
                OS = "3",
                timeZone = DateTime.Now.ToString("zzz")  // Get the local time zone in this format : +02:00
            };
            if (geoData != null && geoData.isoCountry != null)
            {
                SDKInfo.countryCode = geoData.isoCountry;
                SDKInfo.joinedCountryCode = geoData.isoCountry;
            }
        }

        public async Task<bool> Authenticate()
        {
            // Login once with random player info to get the SecretKey and AesInitVec to encrypt the password
            // Verify the sync code and password to get the correct player info
            // Login with the correct player info to get the access token of that user at that moment
            return await Login() && await Verify() && await Login();
        }

        private async Task<bool> Login()
        {
            try
            {
                ResponseLogin? login = await APIClient.Login(PlayerID, DeviceKey, SDKInfo.countryCode);
                if (login == null || login.accessToken == null ||
                login.player == null || login.player.playerId == null || login.player.deviceKey == null ||
                login.cipherKeyList == null || login.cipherKeyList.Count == 0 ||
                login.cipherKeyList[0].secretKey == null || login.cipherKeyList[0].aesInitVec == null)
                {
                    ConsoleWriter.WriteLine("{FC=Red}The login data could not be parsed.");
                    return false;
                }
                AccessToken = login.accessToken;
                PlayerID = login.player.playerId;
                DeviceKey = login.player.deviceKey;
                SecretKey = login.cipherKeyList[0].secretKey!;  // This shows a null warning even tho we made sure it's not null
                AesInitVec = login.cipherKeyList[0].aesInitVec!;  // Same
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteLine($"{{FC=Red}}{ex.Message}");
                return false;
            }
            return true;
        }

        private async Task<bool> Verify()
        {
            try
            {
                ResponseVerify? authInfo = await APIClient.VerifySync(PlayerID, DeviceKey, Account.SyncCode, Account.Password, SecretKey, AesInitVec, AccessToken);
                if (authInfo == null || authInfo.playerId == null || authInfo.deviceKey == null)
                {
                    ConsoleWriter.WriteLine("{FC=Red}The auth data could not be parsed.");
                    return false;
                }
                PlayerID = authInfo.playerId;
                DeviceKey = authInfo.deviceKey;
                return true;
            }
            catch (Exception ex)
            {
                ConsoleWriter.WriteLine($"{{FC=Red}}{ex}");
                return false;
            }
        }

        private static string GetRandomHex(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(RNG.Next(0, 16).ToString("X"));
            }
            return sb.ToString();
        }

        // Method taken from https://stackoverflow.com/a/66187334, only works on Windows
        private static string GetDeviceUniqueIdentifier()
        {
            string ret = string.Empty;
            string concatStr = string.Empty;
            try
            {
                using ManagementObjectSearcher searcherBb = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (var obj in searcherBb.Get())
                {
                    concatStr += (string)obj.Properties["SerialNumber"].Value ?? string.Empty;
                }

                using ManagementObjectSearcher searcherBios = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
                foreach (var obj in searcherBios.Get())
                {
                    concatStr += (string)obj.Properties["SerialNumber"].Value ?? string.Empty;
                }

                using ManagementObjectSearcher searcherOs = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
                foreach (var obj in searcherOs.Get())
                {
                    concatStr += (string)obj.Properties["SerialNumber"].Value ?? string.Empty;
                }

                using var sha1 = SHA1.Create();
                ret = string.Join("", sha1.ComputeHash(Encoding.UTF8.GetBytes(concatStr)).Select(b => b.ToString("x2")));
                return ret;
            }
            catch (Exception e)
            {
                Logger.Log(e.ToString());
                ConsoleWriter.WriteLine("{FC=Yellow}Failed to generate the device unique identifier.");  // An invalid id doesn't prevent anything so we can ignore
                return string.Empty;
            }
        }

        private string _playerId = string.Empty;

        private string _deviceKey = string.Empty;
    }
}
