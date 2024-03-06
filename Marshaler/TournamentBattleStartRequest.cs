public class TournamentBattleStartRequest
{
    public int roomSN;
    public int battlePowerPoint;
    public OtherPlayerTeamInfo teamInfo = new OtherPlayerTeamInfo();
    public List<SkinStatInfo> skinStatInfoList = new List<SkinStatInfo>();
    public long otherUSN;
    public byte otherTeamIndex;
}