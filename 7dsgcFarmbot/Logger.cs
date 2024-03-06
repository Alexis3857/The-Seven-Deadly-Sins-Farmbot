using GameClient;

public static class Logger
{
    private const bool ShowLog = true;

    private const int LogMessageCount = 10;

    public static void Log(string message)
    {
        if (ShowLog)
        {
            Console.WriteLine(message);
        }
    }

    public static void LogMessage(PacketManager.RmiMessage message)
    {
        for (int i = _lastSendMessages.Length - 1; i > 0; i--)
        {
            _lastSendMessages[i] = _lastSendMessages[i - 1];
        }
        _lastSendMessages[0] = message;
    }

    private static PacketManager.RmiMessage[] _lastSendMessages = new PacketManager.RmiMessage[LogMessageCount];
}