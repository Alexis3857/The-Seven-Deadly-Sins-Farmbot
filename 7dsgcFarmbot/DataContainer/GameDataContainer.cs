namespace DataContainer
{
    // Datas should be splitted in several containers like the UserData class to find them more easily
    // This class will store all the containers and will be the only way to access them
    public sealed class GameDataContainer
    {
        public UserData UserData { get; private set; } = new UserData();

        public DateTime CurrentServerTime
        {
            get
            {
                return _currentServerTime.AddSeconds((double)((float)(DateTime.UtcNow - _baseTime).TotalSeconds));
            }
            set
            {
                _currentServerTime = value;
                _baseTime = DateTime.UtcNow;
            }
        }

        private static volatile GameDataContainer? _instance;

        private static readonly object _syncLock = new object();

        private GameDataContainer()
        {
        }

        public static GameDataContainer Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new GameDataContainer();
                    }
                }
                return _instance;
            }
        }

        private void Clear()
        {
            UserData = new UserData();
        }

        private DateTime _currentServerTime = DateTime.Now;

        private DateTime _baseTime = DateTime.Now;
    }
}
