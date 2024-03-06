using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API
{
    public class APIClient  // Used to do requests to the game web servers
    {
        public const string NMGeoIPURL = "https://apis.netmarble.com/gmc2/geoip?apiKey=AwORVufU8TLhUK1eDFxZA8cu9GayykwPVRMLvBQOwWUOOcraSy2RPGCb9O7PKSuZ";  // Used to get location from ip

        private const string ConfigURL = "http://{0}.gcdn.netmarble.com/{0}/config/{1}";  // URL to config files. {0} = game code {1} = resource name

        public const string ConfigDecryptionKey = "funnypaw-Nanatsunotaizai-CDN-key";  // Key to decrypt config files

        public const string KoreaUserAgent = "FunBox/1.4.3 ClientID/seven_deadly_sins_kr";

        public const string JapanUserAgent = "FunBox/1.4.3 ClientID/seven_deadly_sins_jp";

        private readonly string _authUrl;

        private readonly string _projectKey;  // Used in requests body for the server to distinguish games

        private readonly string _clientKey;  // Used in requests headers, the server will respond with an error if incorrect

        private readonly string _userAgent;  // Used in requests headers, either KoreaUserAgent or JapanUserAgent

        private static readonly HttpClient Client = new HttpClient();

        public APIClient(GameCode gameCode, ConfigurationData config)
        {
            switch (gameCode)
            {
                case GameCode.nanakr:
                    _userAgent = KoreaUserAgent;
                    break;
                case GameCode.nanatsunotaizai:
                    _userAgent = JapanUserAgent;
                    break;
                default:
                    throw new ArgumentException($"Game code {gameCode} is invalid, it must be either {GameCode.nanakr} or {GameCode.nanatsunotaizai}.");
            }
            _authUrl = config.ServerURL;
            _projectKey = config.ProjectKey;
            _clientKey = config.ClientKey;
        }

        public static async Task<ConfigurationData> GetConfiguration(GameCode gameCode)
        {
            Client.DefaultRequestHeaders.Clear();
            string encryptedConfig = await Client.GetStringAsync(string.Format(ConfigURL, gameCode, "configuration"));
            return new ConfigurationData(OpenSSLCryptographer.Decrypt(encryptedConfig, ConfigDecryptionKey));
        }

        public static async Task<NoticeData> GetNotice(GameCode gameCode)
        {
            Client.DefaultRequestHeaders.Clear();
            string encryptedNotice = await Client.GetStringAsync(string.Format(ConfigURL, gameCode, "notice"));
            return new NoticeData(OpenSSLCryptographer.Decrypt(encryptedNotice, ConfigDecryptionKey));
        }

        public static async Task<URLConfigurationData> GetUrlConfiguration(GameCode gameCode)
        {
            Client.DefaultRequestHeaders.Clear();
            string encryptedUrlConfig = await Client.GetStringAsync(string.Format(ConfigURL, gameCode, "url_configuration"));
            return new URLConfigurationData(OpenSSLCryptographer.Decrypt(encryptedUrlConfig, ConfigDecryptionKey));
        }

        public static async Task<GuideConfigurationData> GetGuideConfigurationData(GameCode gameCode)
        {
            Client.DefaultRequestHeaders.Clear();
            string encryptedGuideConfig = await Client.GetStringAsync(string.Format(ConfigURL, gameCode, "guide_configuration"));
            return new GuideConfigurationData(OpenSSLCryptographer.Decrypt(encryptedGuideConfig, ConfigDecryptionKey));
        }

        public static async Task<List<string>> GetWhitelist(GameCode gameCode)
        {
            Client.DefaultRequestHeaders.Clear();
            string encryptedWhitelist = await Client.GetStringAsync(string.Format(ConfigURL, gameCode, "whitelist.json"));
            List<string> whitelistedPids = new List<string>();
            try
            {
                JToken jsonData = JObject.Parse(encryptedWhitelist)["pids"]!;
                foreach (string? pid in jsonData)
                {
                    if (pid != null)
                    {
                        whitelistedPids.Add(OpenSSLCryptographer.Decrypt(pid, ConfigDecryptionKey));
                    }
                }
            }
            catch
            {
                throw new Exception("Failed to parse the whitelist response");
            }
            return whitelistedPids;
        }

        public static async Task<GeoIPData?> GetGeoIP()  // This method does not throw because invalid geo data does not prevent the program from working
        {
            Client.DefaultRequestHeaders.Clear();
            string respStr = await Client.GetStringAsync(NMGeoIPURL);
            JObject jsonData = JObject.Parse(respStr);
            try
            {
                return JsonConvert.DeserializeObject<GeoIPData>(jsonData["resultData"]!.ToString());
            }
            catch
            {
                return null;
            }
        }

        // Returns the access token and encryption keys of the given player id and device key
        // Throws an exception if the request fails or the server responds with an error
        public async Task<ResponseLogin?> Login(string playerId, string deviceKey, string countryCode)
        {
            SetHeaders();
            RequestBase<RequestLogin> jsonContent = new RequestBase<RequestLogin>()
            {
                projectKey = _projectKey,
                authorizationProvider = "netmarble",
                providerParams = new RequestLogin()
                {
                    deviceKey = deviceKey,
                    playerId = playerId,
                    countryCode = countryCode
                }
            };
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(jsonContent), null, "application/json");
            HttpResponseMessage httpResponseMessage = await Client.PostAsync($"{_authUrl}/api/interlock/login", stringContent);
            string strResp = await httpResponseMessage.Content.ReadAsStringAsync();
            Logger.Log($"[APIClient-Login] {strResp}");
            ResponseBase<ResponseLogin>? parsedResp = JsonConvert.DeserializeObject<ResponseBase<ResponseLogin>>(strResp);
            if (parsedResp == null || parsedResp.code != 0)
            {
                throw new Exception($"Failed to login : {((parsedResp != null && parsedResp.errmsg != null) ? parsedResp.errmsg : string.Empty)}");
            }
            return parsedResp.data;
        }

        // If the sync code and password from the arguments are correct, returns the associated player id and device key
        // Throws an exception if the request fails or the server responds with an error
        public async Task<ResponseVerify?> VerifySync(string playerId, string deviceKey, string syncCode, string password, string secretKey, string initVec, string gameToken)
        {
            SetHeaders();
            string encryptedPassword = AESEncrypter.Encrypt(password, secretKey, initVec);
            RequestBase<RequestVerify> jsonContent = new RequestBase<RequestVerify>()
            {
                projectKey = _projectKey,
                authorizationProvider = "netmarble_ja1",
                providerParams = new RequestVerify()
                {
                    deviceKey = deviceKey,
                    gameToken = gameToken,
                    playerId = playerId,
                    transferCode = syncCode,
                    password = encryptedPassword
                }
            };
            StringContent stringContent = new(JsonConvert.SerializeObject(jsonContent), null, "application/json");
            HttpResponseMessage httpResponseMessage = await Client.PostAsync($"{_authUrl}/api/interlock/verify", stringContent);
            string strResp = await httpResponseMessage.Content.ReadAsStringAsync();
            Logger.Log($"[APIClient-VerifySync] {strResp}");
            ResponseBase<ResponseVerify>? parsedResp = JsonConvert.DeserializeObject<ResponseBase<ResponseVerify>>(strResp);
            if (parsedResp == null || parsedResp.code != 0)
            {
                throw new Exception($"Failed to verify sync: {((parsedResp != null && parsedResp.errmsg != null) ? parsedResp.errmsg : string.Empty)}");
            }
            return parsedResp.data;
        }

        private void SetHeaders()
        {
            Client.DefaultRequestHeaders.Clear();
            Client.DefaultRequestHeaders.Add("FUNSDK_HEADER_KEY", _clientKey);
            Client.DefaultRequestHeaders.Add("User-Agent", _userAgent);
            Client.DefaultRequestHeaders.Add("X-Unity-Version", "2020.3.26f1");
        }
    }
}
