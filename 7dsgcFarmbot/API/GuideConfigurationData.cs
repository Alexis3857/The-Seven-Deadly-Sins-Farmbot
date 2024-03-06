using Newtonsoft.Json.Linq;
using System.Text;

namespace API
{
    public class GuideConfigurationData  // Stores guide number ie https://guide.netmarble.com/nanagb#cont/3662 with nanagb being the game code and 3662 the guide number
    {
        private Dictionary<string, string> DictGuides { get; }

        public GuideConfigurationData(string jsonText)
        {

            try
            {
                DictGuides = new Dictionary<string, string>();
                JToken jsonData = JObject.Parse(jsonText)["live"]!;  // dev also exists instead of live
                foreach (JProperty item in jsonData)
                {
                    if (!DictGuides.ContainsKey(item.Name))
                    {
                        DictGuides.Add(item.Name, item.Value.ToString());
                    }
                }
            }
            catch
            {
                throw new Exception("Failed to parse GuideConfigurationData");
            }
        }

        public bool GetGuideData(string key, out string data)
        {
            if (DictGuides != null && DictGuides.ContainsKey(key) && !string.IsNullOrEmpty(DictGuides[key]))
            {
                data = DictGuides[key];
                return true;
            }
            data = "";
            return false;
        }

        public string GetGuideDataOrThrow(string key)
        {
            return DictGuides[key];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("{");
            foreach (string text in DictGuides.Keys)
            {
                stringBuilder.AppendFormat("{0} : {1}, ", text, DictGuides[text]);
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }
}
