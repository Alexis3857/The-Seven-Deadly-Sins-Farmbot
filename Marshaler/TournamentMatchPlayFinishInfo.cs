public class TournamentMatchPlayFinishInfo
{
    public int SEQ;
    public short matchIndex;
    public TournamentMatchState matchState;
    public int matchRoomSN;
    public long matchWinnerUSN;
    public TournamentMatchResultState matchResultState;
    public byte playIndex;
    public long playWinnerUSN;
    public TournamentMatchResultState playResultState;
    public long replaySEQ;
    public int relaySessionKey;
}