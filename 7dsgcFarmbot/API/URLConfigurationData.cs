using Newtonsoft.Json.Linq;

namespace API
{
    public class URLConfigurationData
    {
        private Dictionary<string, string> DictURL { get; }

        public URLConfigurationData(string jsonText)  // Stores several netmarble url like SNS etc..
        {
            try
            {
                DictURL = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                JToken jsonData = JObject.Parse(jsonText)["default"];
                foreach (JProperty item in jsonData)
                {
                    if (!DictURL.ContainsKey(item.Name))
                    {
                        DictURL.Add(item.Name, item.Value.ToString());
                    }
                }
            }
            catch
            {
                throw new Exception("Failed to parse URLConfigurationData");
            }
        }

        public bool GetURLData(string key, out string data)
        {
            if (DictURL != null && DictURL.ContainsKey(key) && !string.IsNullOrEmpty(DictURL[key]))
            {
                data = DictURL[key];
                return true;
            }
            data = "";
            return false;
        }

        public string GetURLData(string key)
        {
            if (DictURL != null && DictURL.ContainsKey(key) && !string.IsNullOrEmpty(DictURL[key]))
            {
                return DictURL[key];
            }
            return "";
        }

        public string GetURLDataOrThrow(string key)
        {
            return DictURL[key];
        }
    }
}
