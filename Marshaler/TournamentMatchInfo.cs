public class TournamentMatchInfo
{
    public short roundIndex;
    public short matchIndex;
    public TournamentMatchState matchState;
    public int matchStateRemainSec;
    public long playerUSN1;
    public long playerUSN2;
    public long winnerUSN;
    public TournamentMatchResultState resultState;
    public byte playerWin1;
    public byte playerWin2;
}