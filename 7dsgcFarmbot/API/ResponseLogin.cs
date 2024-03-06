namespace API
{
    public class ResponseLogin
    {
        public string? authorizationProvider;

        public string? accessToken;

        public Player? player;

        public List<CipherKey>? cipherKeyList;

        public class Player
        {
            public string? deviceKey;

            public string? playerId;

            public string? gameCode;

            public string? gameRegion;

            public string? statusCode;

            public string? joinedCountryCode;

            public int isNewPlayer;
        }

        public class CipherKey
        {
            public string? cipherType;

            public string? secretKey;

            public string? aesInitVec;
        }
    }
}
