using Newtonsoft.Json.Linq;

namespace API
{
    public class NoticeData  // Contains info about the previous or the next maintenance
    {
        public string Title { get; }

        public string Message { get; }

        public bool PrintPeriod { get; }

        private bool Enable { get; }

        private DateTime StartUTC { get; }

        private DateTime EndUTC { get; }

        public NoticeData(string jsonText)
        {
            StartUTC = DateTime.UtcNow;
            EndUTC = DateTime.UtcNow;
            Title = "";
            Message = "";
            PrintPeriod = true;
            Enable = true;
            JObject jsonData = JObject.Parse(jsonText);
            try
            {
                JToken windowsData = jsonData["windows"]!;
                if (windowsData.Contains("enable"))
                {
                    Enable = Convert.ToBoolean(windowsData["enable"]!.ToString());
                }
                if (windowsData.Contains("print_period"))
                {
                    PrintPeriod = Convert.ToBoolean(windowsData["print_period"]!.ToString());
                }
                StartUTC = DateTime.Parse(windowsData["start_utc"]!.ToString());
                EndUTC = DateTime.Parse(windowsData["end_utc"]!.ToString());
                Title = windowsData["title_string"]!.ToString();
                Message = windowsData["message_string"]!.ToString();
            }
            catch
            {
                throw new Exception("Failed to parse NoticeData");
            }
            finally
            {
                if (StartUTC.Kind != DateTimeKind.Utc)
                {
                    StartUTC = StartUTC.ToUniversalTime();
                }
                if (EndUTC.Kind != DateTimeKind.Utc)
                {
                    EndUTC = EndUTC.ToUniversalTime();
                }
            }
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Message) && !(EndUTC < StartUTC);
        }

        public bool OnNotice(long adjustTicks, long nowTicks)
        {
            return Enable && nowTicks >= StartUTC.AddTicks(adjustTicks).Ticks && EndUTC.AddTicks(adjustTicks).Ticks >= nowTicks;
        }

        public string GetPeriod()
        {
            return $"{StartUTC} ~ {EndUTC}";
        }
    }

}