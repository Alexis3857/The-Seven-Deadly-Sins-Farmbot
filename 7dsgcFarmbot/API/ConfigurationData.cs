using Newtonsoft.Json;

namespace API
{
    public class ConfigurationData  // Contains the necessary info to communicate with the auth server and the game server
    {
        public int ClientVersion { get; }  // The version of the game as an int ("2.47.0" -> 24700)

        public int PatchVersion { get; }  // Patch version changes at every game update dl (ingame data dl NOT game version update)

        public string IP { get; }  // Game server ip

        public ushort Port { get; }  // Game server port

        public string ServerURL { get; }  // Auth server url

        public string ProjectKey { get; }  // String to distinguish the JP and KR versions

        public string ClientKey { get; }  // Required to communicate with the auth server

        public ConfigurationData(string jsonText)
        {
            JsonConvert.PopulateObject(jsonText, this);
            World.WorldInfo? server = null;
            // The null check below are for the data 
            if (version is null || version.windows is null || version.windows.max_allows is null || patch is null || patch.windows is null || patch.windows.version is null || world2 is null || world2.world_info is null || funsettings is null || funsettings.windows is null || funsettings.windows.server_url is null || funsettings.windows.project_key is null || funsettings.windows.client_key is null || (server = world2.world_info.Find(s => s.name == "REAL")) == null || server.ip is null)
            {
                throw new Exception("Failed to parse ConfigurationData");
            }
            string[] versionArray = version.windows.max_allows.ToString().Split(".");  // ["2", "36", "0"]
            ClientVersion = int.Parse(versionArray[0]) * 10000 + int.Parse(versionArray[1]) * 100 + int.Parse(versionArray[2]);  // 23600
            PatchVersion = int.Parse(patch.windows.version);
            IP = server.ip;
            Port = server.port;
            ServerURL = funsettings.windows.server_url;
            ProjectKey = funsettings.windows.project_key;
            ClientKey = funsettings.windows.client_key;
        }

        // Json structure
        [JsonProperty]
        private readonly Version? version;

        [JsonProperty]
        private readonly Patch? patch;

        [JsonProperty]
        private readonly World? world2;

        [JsonProperty]
        private readonly FunSettings? funsettings;

        public class Version
        {
            [JsonProperty]
            public VersionInfo? windows;

            public class VersionInfo
            {
                [JsonProperty]
                public string? max_allows;
            }
        }

        public class Patch
        {
            [JsonProperty]
            public PatchInfo? windows;

            public class PatchInfo
            {
                [JsonProperty]
                public string? relative_sub;

                [JsonProperty]
                public string? version;
            }
        }

        public class World
        {
            [JsonProperty]
            public List<WorldInfo>? world_info;

            public class WorldInfo
            {
                [JsonProperty]
                public string? name;

                [JsonProperty]
                public string? ip;

                [JsonProperty]
                public ushort port;
            }
        }

        public class FunSettings
        {
            [JsonProperty]
            public FunSettingsInfo? windows;

            public class FunSettingsInfo
            {
                [JsonProperty]
                public string? server_url;

                [JsonProperty]
                public string? project_key;

                [JsonProperty]
                public string? client_key;
            }
        }
    }
}
