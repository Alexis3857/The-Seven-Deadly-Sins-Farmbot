using Nettention.Proud;

namespace SevenDSRelayR2C
{
    public class Stub : RmiStub
    {
        public override bool ProcessReceivedMessage(ReceivedMessage pa, object hostTag)
        {
            HostID remoteHostID = pa.RemoteHostID;
            if (remoteHostID == HostID.HostID_None)
            {
                base.ShowUnknownHostIDWarning(remoteHostID);
            }
            Message readOnlyMessage = pa.ReadOnlyMessage;
            int readOffset = readOnlyMessage.ReadOffset;
            RmiID rmiID = RmiID.RmiID_None;
            if (readOnlyMessage.Read(out rmiID))
            {
                switch (rmiID)
                {
                    case Common.CR_CommonCancel:
                        this.ProcessReceivedMessage_CR_CommonCancel(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestForceLogoutOK:
                        this.ProcessReceivedMessage_CR_RequestForceLogoutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLoginOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPJoinOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPExitOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPReadyOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPFightOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPFightOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPSyncOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPReadyTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPReadyTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPJoinTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPJoinTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyUserJoin:
                        this.ProcessReceivedMessage_RC_NotifyDestroyUserJoin(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyUserStateChanged:
                        this.ProcessReceivedMessage_RC_NotifyDestroyUserStateChanged(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyUserExit:
                        this.ProcessReceivedMessage_RC_NotifyDestroyUserExit(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyGameStart:
                        this.ProcessReceivedMessage_RC_NotifyDestroyGameStart(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyIngameStart:
                        this.ProcessReceivedMessage_RC_NotifyDestroyIngameStart(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroySync:
                        this.ProcessReceivedMessage_RC_NotifyDestroySync(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyGameEnd:
                        this.ProcessReceivedMessage_RC_NotifyDestroyGameEnd(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroySelectSkillCard:
                        this.ProcessReceivedMessage_RC_NotifyDestroySelectSkillCard(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyRoundFinish:
                        this.ProcessReceivedMessage_RC_NotifyDestroyRoundFinish(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyDestroyChatEnter:
                        this.ProcessReceivedMessage_RC_NotifyDestroyChatEnter(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_RequestDestroyNeedSync:
                        this.ProcessReceivedMessage_RC_RequestDestroyNeedSync(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyLoginOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyReLoginOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyReLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyRelayReadyOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyRelayReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyLobbySyncOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyLobbySyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyReadyOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyReturnReadyOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyReturnReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyKickOutOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyKickOutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyChangeTeamInfoOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyChangeTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyMemberTeamInfoOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyMemberTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyIngameReadyOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyIngameReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyRoundFinishOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyRoundFinishOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyNeedSyncOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyNeedSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyIngameFinishOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyIngameFinishOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyExitOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestDestroyTestExitOK:
                        this.ProcessReceivedMessage_CR_RequestDestroyTestExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildLoginOK:
                        this.ProcessReceivedMessage_CR_RequestGuildLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildRoomJoinOK:
                        this.ProcessReceivedMessage_CR_RequestGuildRoomJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildRoomOutOK:
                        this.ProcessReceivedMessage_CR_RequestGuildRoomOutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildRoomMemberInfoOK:
                        this.ProcessReceivedMessage_CR_RequestGuildRoomMemberInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildRoomSyncOK:
                        this.ProcessReceivedMessage_CR_RequestGuildRoomSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildRoomMemberInfoSyncOK:
                        this.ProcessReceivedMessage_CR_RequestGuildRoomMemberInfoSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildRoomKickOutMemberOK:
                        this.ProcessReceivedMessage_CR_RequestGuildRoomKickOutMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestGuildRoomLeaveMemberOK:
                        this.ProcessReceivedMessage_CR_RequestGuildRoomLeaveMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildNewMemberOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildNewMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildLeaveMemberOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildLeaveMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildRoomOtherPlayerJoinOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildRoomOtherPlayerOutOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerOutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildRoomOtherPlayerSyncOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildRoomOtherPlayerKickOutMemberOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerKickOutMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyGuildRoomOtherPlayerLeaveMemberOK:
                        this.ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerLeaveMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchLoginOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchLobbySyncOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchLobbySyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchReadyOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchReadyOffOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchReadyOffOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchChangeTeamOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchChangeTeamOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchTeamInfoOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchChangeMatchModeOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchChangeMatchModeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchKickOutOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchKickOutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchStartOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchSyncOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchExitOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchJoin:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchJoin(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchLobbySync:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchLobbySync(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchUserReady:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchUserReady(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchUserReadyOff:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchUserReadyOff(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchUserChangeTeam:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchUserChangeTeam(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchKickedOut:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchKickedOut(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchUserGameStart:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchUserGameStart(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchSync:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchSync(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchChatEnter:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchChatEnter(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchExit:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchExit(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchInGameExit:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchInGameExit(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchChangeMatchMode:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchChangeMatchMode(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchChangeModeID:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchChangeModeID(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchReadyTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchReadyTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchInGameReadyOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchInGameReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchFightOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchFightOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchInGameExitOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchInGameExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchChangeUserModeOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchChangeUserModeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchChangeUserMode:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchChangeUserMode(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerLoginOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerJoinOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerExitOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerReadyOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerFightOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerFightOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerSyncOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerReadyTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerReadyTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLowerJoinTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerJoinTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingConnectOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingConnectOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingLoginOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingJoinOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingExitOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingReadyOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingFightOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingFightOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingSyncOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingReadyTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingReadyTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRankingJoinTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRankingJoinTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchLoginOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchChangeTeamOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchChangeTeamOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchReadyOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchInGameReadyOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchInGameReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchInGameTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchInGameTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchInGameSyncOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchInGameSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchInGameGiveupOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchInGameGiveupOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchInGameExitOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchInGameExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchExitOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentWatcherLoginOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentWatcherLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentWatcherExitOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentWatcherExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchReplayStartOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchReplayStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestTournamentMatchInGameClearOK:
                        this.ProcessReceivedMessage_CR_RequestTournamentMatchInGameClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchJoin:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchJoin(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchChangeTeam:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchChangeTeam(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchReady:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchReady(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchStart:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchStart(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchInGameFight:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchInGameFight(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchInGameSync:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchInGameSync(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchInGameGiveup:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchInGameGiveup(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchInGameExit:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchInGameExit(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchChatEnter:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchChatEnter(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentMatchExit:
                        this.ProcessReceivedMessage_RC_NotifyTournamentMatchExit(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyTournamentWatcherStart:
                        this.ProcessReceivedMessage_RC_NotifyTournamentWatcherStart(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueLoginOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueReLoginOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueReLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueReadyOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueReturnReadyOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueReturnReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueLeaveOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueLeaveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueKickoutOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueKickoutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueGameStartOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueGameStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueBattleSyncOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueBattleSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestSubdueBattleEndOK:
                        this.ProcessReceivedMessage_CR_RequestSubdueBattleEndOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_NotifySubdueSyncOK:
                        this.ProcessReceivedMessage_CR_NotifySubdueSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_NotifySubdueMemberJoinUpdateOK:
                        this.ProcessReceivedMessage_CR_NotifySubdueMemberJoinUpdateOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_NotifySubdueGameStartOK:
                        this.ProcessReceivedMessage_CR_NotifySubdueGameStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_NotifySubdueLoadingCompleteOK:
                        this.ProcessReceivedMessage_CR_NotifySubdueLoadingCompleteOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_NotifySubdueRewardAggregationOK:
                        this.ProcessReceivedMessage_CR_NotifySubdueRewardAggregationOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveLoginOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveLobbySyncOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveLobbySyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveReadyOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveReadyOffOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyOffOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveChangeTeamOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChangeTeamOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveTeamInfoOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveChangeMatchModeOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChangeMatchModeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveKickOutOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveKickOutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveStartOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveSyncOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveExitOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveJoin:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveJoin(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveLobbySync:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveLobbySync(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveUserReady:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserReady(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveUserReadyOff:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserReadyOff(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveUserChangeTeam:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserChangeTeam(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveKickedOut:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveKickedOut(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveUserGameStart:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserGameStart(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveSync:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveSync(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveChatEnter:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChatEnter(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveExit:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveExit(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveInGameExit:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveInGameExit(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveChangeMatchMode:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChangeMatchMode(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveChangeModeID:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChangeModeID(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveReadyTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveInGameReadyOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveFightOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveFightOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveInGameExitOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveChangeUserModeOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChangeUserModeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveChangeUserMode:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChangeUserMode(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveReplayStartOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReplayStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveWatcherStart:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveWatcherStart(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveUserStatusOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveUserStatusOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveUserStatus:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserStatus(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveLobbyHeartBeatOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveLobbyHeartBeatOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveReadyOffAllOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyOffAllOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveInGameClearOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.RC_NotifyFriendlyMatchObserveInGameClear:
                        this.ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveInGameClear(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestFriendlyMatchObserveInGameHeartBeatOK:
                        this.ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameHeartBeatOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitLoginOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitLoginOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitJoinOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitExitOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitReadyOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitReadyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitFightOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitFightOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitSyncOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitReadyTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitReadyTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitChatEnterOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitChatEnterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CR_RequestArenaRealTimePVPLimitJoinTimeOverOK:
                        this.ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitJoinTimeOverOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    default:
                        goto end;
                }
                return true;
            }
        end:
            readOnlyMessage.ReadOffset = readOffset;
            return false;
        }

        private void ProcessReceivedMessage_CR_CommonCancel(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            RmiID packetID;
            CommonPacket.Marshaler.Read(__msg, out packetID);
            string packetName;
            CommonPacket.Marshaler.Read(__msg, out packetName);
            PacketError error;
            CommonPacket.Marshaler.Read(__msg, out error);
            InvalidRequestType invalidRequesttype;
            CommonPacket.Marshaler.Read(__msg, out invalidRequesttype);
            bool isSimpleMessageBox;
            CommonPacket.Marshaler.Read(__msg, out isSimpleMessageBox);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_CommonCancel);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_CommonCancel,
                    rmiName = RmiName_CR_CommonCancel,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_CommonCancel(remote, rmiContext, packetID, packetName, error, invalidRequesttype, isSimpleMessageBox))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_CommonCancel);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_CommonCancel,
                    rmiName = RmiName_CR_CommonCancel,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestForceLogoutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            PacketError error;
            CommonPacket.Marshaler.Read(__msg, out error);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestForceLogoutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestForceLogoutOK,
                    rmiName = RmiName_CR_RequestForceLogoutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestForceLogoutOK(remote, rmiContext, error))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestForceLogoutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestForceLogoutOK,
                    rmiName = RmiName_CR_RequestForceLogoutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLoginOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLoginOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserProfileInfo userInfo;
            CommonPacket.Marshaler.Read(__msg, out userInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPJoinOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPJoinOK(remote, rmiContext, userInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPJoinOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUsn;
            CommonPacket.Marshaler.Read(__msg, out targetUsn);
            bool giveup;
            CommonPacket.Marshaler.Read(__msg, out giveup);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPExitOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPExitOK(remote, rmiContext, targetUsn, giveup))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPExitOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool timeOver;
            CommonPacket.Marshaler.Read(__msg, out timeOver);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPReadyOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPReadyOK(remote, rmiContext, timeOver))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPReadyOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPFightOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPFightOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPFightOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPFightOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPFightOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPFightOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPFightOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPFightOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPSyncOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPSyncOK(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPSyncOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPReadyTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool bSucess;
            CommonPacket.Marshaler.Read(__msg, out bSucess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPReadyTimeOverOK(remote, rmiContext, bSucess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            int stampID;
            CommonPacket.Marshaler.Read(__msg, out stampID);
            string message;
            CommonPacket.Marshaler.Read(__msg, out message);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPChatEnterOK(remote, rmiContext, sendUSN, stampID, message))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPJoinTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPJoinTimeOverOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyUserJoin(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyUserProfileInfo userInfo;
            CommonPacket.Marshaler.Read(__msg, out userInfo);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyUserJoin);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyUserJoin,
                    rmiName = RmiName_RC_NotifyDestroyUserJoin,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyUserJoin(remote, rmiContext, userInfo, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyUserJoin);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyUserJoin,
                    rmiName = RmiName_RC_NotifyDestroyUserJoin,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyUserStateChanged(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyLobbySyncInfo syncInfo;
            CommonPacket.Marshaler.Read(__msg, out syncInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyUserStateChanged);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyUserStateChanged,
                    rmiName = RmiName_RC_NotifyDestroyUserStateChanged,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyUserStateChanged(remote, rmiContext, syncInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyUserStateChanged);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyUserStateChanged,
                    rmiName = RmiName_RC_NotifyDestroyUserStateChanged,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyUserExit(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long exitUSN;
            CommonPacket.Marshaler.Read(__msg, out exitUSN);
            bool isOwner;
            CommonPacket.Marshaler.Read(__msg, out isOwner);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyUserExit);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyUserExit,
                    rmiName = RmiName_RC_NotifyDestroyUserExit,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyUserExit(remote, rmiContext, exitUSN, isOwner))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyUserExit);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyUserExit,
                    rmiName = RmiName_RC_NotifyDestroyUserExit,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyGameStart(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyStartResult startResult;
            CommonPacket.Marshaler.Read(__msg, out startResult);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyGameStart);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyGameStart,
                    rmiName = RmiName_RC_NotifyDestroyGameStart,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyGameStart(remote, rmiContext, startResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyGameStart);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyGameStart,
                    rmiName = RmiName_RC_NotifyDestroyGameStart,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyIngameStart(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyIngameStart);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyIngameStart,
                    rmiName = RmiName_RC_NotifyDestroyIngameStart,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyIngameStart(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyIngameStart);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyIngameStart,
                    rmiName = RmiName_RC_NotifyDestroyIngameStart,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroySync(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroySyncInfo syncInfo;
            CommonPacket.Marshaler.Read(__msg, out syncInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroySync);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroySync,
                    rmiName = RmiName_RC_NotifyDestroySync,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroySync(remote, rmiContext, syncInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroySync);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroySync,
                    rmiName = RmiName_RC_NotifyDestroySync,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyGameEnd(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isClear;
            CommonPacket.Marshaler.Read(__msg, out isClear);
            bool ownerExit;
            CommonPacket.Marshaler.Read(__msg, out ownerExit);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyGameEnd);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyGameEnd,
                    rmiName = RmiName_RC_NotifyDestroyGameEnd,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyGameEnd(remote, rmiContext, isClear, ownerExit))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyGameEnd);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyGameEnd,
                    rmiName = RmiName_RC_NotifyDestroyGameEnd,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroySelectSkillCard(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyCardOrderInfo cardOrderInfo;
            CommonPacket.Marshaler.Read(__msg, out cardOrderInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroySelectSkillCard);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroySelectSkillCard,
                    rmiName = RmiName_RC_NotifyDestroySelectSkillCard,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroySelectSkillCard(remote, rmiContext, cardOrderInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroySelectSkillCard);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroySelectSkillCard,
                    rmiName = RmiName_RC_NotifyDestroySelectSkillCard,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyRoundFinish(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            short roundID;
            CommonPacket.Marshaler.Read(__msg, out roundID);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyRoundFinish);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyRoundFinish,
                    rmiName = RmiName_RC_NotifyDestroyRoundFinish,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyRoundFinish(remote, rmiContext, roundID))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyRoundFinish);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyRoundFinish,
                    rmiName = RmiName_RC_NotifyDestroyRoundFinish,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyDestroyChatEnter(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyChatMessage chatMessage;
            CommonPacket.Marshaler.Read(__msg, out chatMessage);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyDestroyChatEnter);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyChatEnter,
                    rmiName = RmiName_RC_NotifyDestroyChatEnter,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyDestroyChatEnter(remote, rmiContext, chatMessage))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyDestroyChatEnter);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyDestroyChatEnter,
                    rmiName = RmiName_RC_NotifyDestroyChatEnter,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_RequestDestroyNeedSync(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_RC_RequestDestroyNeedSync);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_RequestDestroyNeedSync,
                    rmiName = RmiName_RC_RequestDestroyNeedSync,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_RequestDestroyNeedSync(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_RequestDestroyNeedSync);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_RequestDestroyNeedSync,
                    rmiName = RmiName_RC_RequestDestroyNeedSync,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyLoginOK,
                    rmiName = RmiName_CR_RequestDestroyLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyLoginOK,
                    rmiName = RmiName_CR_RequestDestroyLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyReLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyUserProfileInfo otherPlayerProfileInfo;
            CommonPacket.Marshaler.Read(__msg, out otherPlayerProfileInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyReLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyReLoginOK,
                    rmiName = RmiName_CR_RequestDestroyReLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyReLoginOK(remote, rmiContext, otherPlayerProfileInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyReLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyReLoginOK,
                    rmiName = RmiName_CR_RequestDestroyReLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyRelayReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyUserProfileInfo otherUserProfileInfo;
            CommonPacket.Marshaler.Read(__msg, out otherUserProfileInfo);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyRelayReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyRelayReadyOK,
                    rmiName = RmiName_CR_RequestDestroyRelayReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyRelayReadyOK(remote, rmiContext, otherUserProfileInfo, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyRelayReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyRelayReadyOK,
                    rmiName = RmiName_CR_RequestDestroyRelayReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyLobbySyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyLobbySyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyLobbySyncOK,
                    rmiName = RmiName_CR_RequestDestroyLobbySyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyLobbySyncOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyLobbySyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyLobbySyncOK,
                    rmiName = RmiName_CR_RequestDestroyLobbySyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DestroyChatMessage chatMessage;
            CommonPacket.Marshaler.Read(__msg, out chatMessage);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyChatEnterOK,
                    rmiName = RmiName_CR_RequestDestroyChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyChatEnterOK(remote, rmiContext, chatMessage))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyChatEnterOK,
                    rmiName = RmiName_CR_RequestDestroyChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyReadyOK,
                    rmiName = RmiName_CR_RequestDestroyReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyReadyOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyReadyOK,
                    rmiName = RmiName_CR_RequestDestroyReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyReturnReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyReturnReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyReturnReadyOK,
                    rmiName = RmiName_CR_RequestDestroyReturnReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyReturnReadyOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyReturnReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyReturnReadyOK,
                    rmiName = RmiName_CR_RequestDestroyReturnReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyKickOutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyKickOutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyKickOutOK,
                    rmiName = RmiName_CR_RequestDestroyKickOutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyKickOutOK(remote, rmiContext, usn))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyKickOutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyKickOutOK,
                    rmiName = RmiName_CR_RequestDestroyKickOutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyChangeTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyChangeTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyChangeTeamInfoOK,
                    rmiName = RmiName_CR_RequestDestroyChangeTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyChangeTeamInfoOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyChangeTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyChangeTeamInfoOK,
                    rmiName = RmiName_CR_RequestDestroyChangeTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyMemberTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyMemberTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyMemberTeamInfoOK,
                    rmiName = RmiName_CR_RequestDestroyMemberTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyMemberTeamInfoOK(remote, rmiContext, usn, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyMemberTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyMemberTeamInfoOK,
                    rmiName = RmiName_CR_RequestDestroyMemberTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyIngameReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            short playingRoundID;
            CommonPacket.Marshaler.Read(__msg, out playingRoundID);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyIngameReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyIngameReadyOK,
                    rmiName = RmiName_CR_RequestDestroyIngameReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyIngameReadyOK(remote, rmiContext, playingRoundID))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyIngameReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyIngameReadyOK,
                    rmiName = RmiName_CR_RequestDestroyIngameReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyRoundFinishOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyRoundFinishOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyRoundFinishOK,
                    rmiName = RmiName_CR_RequestDestroyRoundFinishOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyRoundFinishOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyRoundFinishOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyRoundFinishOK,
                    rmiName = RmiName_CR_RequestDestroyRoundFinishOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyNeedSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyNeedSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyNeedSyncOK,
                    rmiName = RmiName_CR_RequestDestroyNeedSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyNeedSyncOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyNeedSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyNeedSyncOK,
                    rmiName = RmiName_CR_RequestDestroyNeedSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyIngameFinishOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<int> stageIdList;
            CommonPacket.Marshaler.Read(__msg, out stageIdList);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyIngameFinishOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyIngameFinishOK,
                    rmiName = RmiName_CR_RequestDestroyIngameFinishOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyIngameFinishOK(remote, rmiContext, stageIdList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyIngameFinishOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyIngameFinishOK,
                    rmiName = RmiName_CR_RequestDestroyIngameFinishOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyExitOK,
                    rmiName = RmiName_CR_RequestDestroyExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyExitOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyExitOK,
                    rmiName = RmiName_CR_RequestDestroyExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestDestroyTestExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestDestroyTestExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyTestExitOK,
                    rmiName = RmiName_CR_RequestDestroyTestExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestDestroyTestExitOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestDestroyTestExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestDestroyTestExitOK,
                    rmiName = RmiName_CR_RequestDestroyTestExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildLoginOK,
                    rmiName = RmiName_CR_RequestGuildLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildLoginOK,
                    rmiName = RmiName_CR_RequestGuildLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildRoomJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildRoomMemberInfo> guildRoomMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out guildRoomMemberInfo);
            List<GuildRoomMemberPointInfo> guildRoomMemberPointInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildRoomMemberPointInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildRoomJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomJoinOK,
                    rmiName = RmiName_CR_RequestGuildRoomJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildRoomJoinOK(remote, rmiContext, guildRoomMemberInfo, guildRoomMemberPointInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildRoomJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomJoinOK,
                    rmiName = RmiName_CR_RequestGuildRoomJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildRoomOutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildRoomOutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomOutOK,
                    rmiName = RmiName_CR_RequestGuildRoomOutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildRoomOutOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildRoomOutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomOutOK,
                    rmiName = RmiName_CR_RequestGuildRoomOutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildRoomMemberInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildRoomMemberInfo> guildRoomMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out guildRoomMemberInfo);
            List<GuildRoomMemberPointInfo> guildRoomMemberPointInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildRoomMemberPointInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildRoomMemberInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomMemberInfoOK,
                    rmiName = RmiName_CR_RequestGuildRoomMemberInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildRoomMemberInfoOK(remote, rmiContext, guildRoomMemberInfo, guildRoomMemberPointInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildRoomMemberInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomMemberInfoOK,
                    rmiName = RmiName_CR_RequestGuildRoomMemberInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildRoomSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildRoomSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomSyncOK,
                    rmiName = RmiName_CR_RequestGuildRoomSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildRoomSyncOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildRoomSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomSyncOK,
                    rmiName = RmiName_CR_RequestGuildRoomSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildRoomMemberInfoSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildRoomMemberInfoSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomMemberInfoSyncOK,
                    rmiName = RmiName_CR_RequestGuildRoomMemberInfoSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildRoomMemberInfoSyncOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildRoomMemberInfoSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomMemberInfoSyncOK,
                    rmiName = RmiName_CR_RequestGuildRoomMemberInfoSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildRoomKickOutMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildRoomKickOutMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomKickOutMemberOK,
                    rmiName = RmiName_CR_RequestGuildRoomKickOutMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildRoomKickOutMemberOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildRoomKickOutMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomKickOutMemberOK,
                    rmiName = RmiName_CR_RequestGuildRoomKickOutMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestGuildRoomLeaveMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestGuildRoomLeaveMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomLeaveMemberOK,
                    rmiName = RmiName_CR_RequestGuildRoomLeaveMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestGuildRoomLeaveMemberOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestGuildRoomLeaveMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestGuildRoomLeaveMemberOK,
                    rmiName = RmiName_CR_RequestGuildRoomLeaveMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildNewMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildRoomMemberInfo newMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out newMemberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildNewMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildNewMemberOK,
                    rmiName = RmiName_RC_NotifyGuildNewMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildNewMemberOK(remote, rmiContext, newMemberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildNewMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildNewMemberOK,
                    rmiName = RmiName_RC_NotifyGuildNewMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildLeaveMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long otherUSN;
            CommonPacket.Marshaler.Read(__msg, out otherUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildLeaveMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildLeaveMemberOK,
                    rmiName = RmiName_RC_NotifyGuildLeaveMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildLeaveMemberOK(remote, rmiContext, otherUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildLeaveMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildLeaveMemberOK,
                    rmiName = RmiName_RC_NotifyGuildLeaveMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo guildMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out guildMemberInfo);
            GuildRoomMemberPointInfo guildRoomMemberPointInfo;
            CommonPacket.Marshaler.Read(__msg, out guildRoomMemberPointInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildRoomOtherPlayerJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerJoinOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildRoomOtherPlayerJoinOK(remote, rmiContext, guildMemberInfo, guildRoomMemberPointInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildRoomOtherPlayerJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerJoinOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerOutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long otherUSN;
            CommonPacket.Marshaler.Read(__msg, out otherUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildRoomOtherPlayerOutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerOutOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerOutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildRoomOtherPlayerOutOK(remote, rmiContext, otherUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildRoomOtherPlayerOutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerOutOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerOutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildRoomMoveInfo> guildRoomMoveInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildRoomMoveInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildRoomOtherPlayerSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerSyncOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildRoomOtherPlayerSyncOK(remote, rmiContext, guildRoomMoveInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildRoomOtherPlayerSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerSyncOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildRoomMemberInfo guildRoomMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out guildRoomMemberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK(remote, rmiContext, guildRoomMemberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerKickOutMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo kickOutGuildMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out kickOutGuildMemberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildRoomOtherPlayerKickOutMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerKickOutMemberOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerKickOutMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildRoomOtherPlayerKickOutMemberOK(remote, rmiContext, kickOutGuildMemberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildRoomOtherPlayerKickOutMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerKickOutMemberOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerKickOutMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyGuildRoomOtherPlayerLeaveMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long leaveUSN;
            CommonPacket.Marshaler.Read(__msg, out leaveUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyGuildRoomOtherPlayerLeaveMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerLeaveMemberOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerLeaveMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyGuildRoomOtherPlayerLeaveMemberOK(remote, rmiContext, leaveUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyGuildRoomOtherPlayerLeaveMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyGuildRoomOtherPlayerLeaveMemberOK,
                    rmiName = RmiName_RC_NotifyGuildRoomOtherPlayerLeaveMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchLoginOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchLoginOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchLobbySyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchSyncInfo otherUserSyncInfo;
            CommonPacket.Marshaler.Read(__msg, out otherUserSyncInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchLobbySyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchLobbySyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchLobbySyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchLobbySyncOK(remote, rmiContext, otherUserSyncInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchLobbySyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchLobbySyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchLobbySyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchReadyOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchReadyOffOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchReadyOffOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchReadyOffOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchReadyOffOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchReadyOffOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchReadyOffOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchReadyOffOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchReadyOffOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchChangeTeamOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchChangeTeamOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChangeTeamOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChangeTeamOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchChangeTeamOK(remote, rmiContext, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchChangeTeamOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChangeTeamOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChangeTeamOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchTeamInfoOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchTeamInfoOK(remote, rmiContext, usn, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchTeamInfoOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchChangeMatchModeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte matchMode;
            CommonPacket.Marshaler.Read(__msg, out matchMode);
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchChangeMatchModeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChangeMatchModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChangeMatchModeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchChangeMatchModeOK(remote, rmiContext, matchMode, modeID))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchChangeMatchModeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChangeMatchModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChangeMatchModeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchKickOutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long kickUSN;
            CommonPacket.Marshaler.Read(__msg, out kickUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchKickOutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchKickOutOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchKickOutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchKickOutOK(remote, rmiContext, kickUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchKickOutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchKickOutOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchKickOutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchStartResult startResult;
            CommonPacket.Marshaler.Read(__msg, out startResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchStartOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchStartOK(remote, rmiContext, startResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchStartOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchSyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchSyncOK(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchSyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUsn;
            CommonPacket.Marshaler.Read(__msg, out targetUsn);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchExitOK(remote, rmiContext, targetUsn))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchChatMessage chatMessage;
            CommonPacket.Marshaler.Read(__msg, out chatMessage);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChatEnterOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchChatEnterOK(remote, rmiContext, chatMessage))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChatEnterOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchJoin(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchUserProfileInfo fmProfileInfo;
            CommonPacket.Marshaler.Read(__msg, out fmProfileInfo);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            bool readyStatus;
            CommonPacket.Marshaler.Read(__msg, out readyStatus);
            byte matchMode;
            CommonPacket.Marshaler.Read(__msg, out matchMode);
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            byte userMode;
            CommonPacket.Marshaler.Read(__msg, out userMode);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchJoin);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchJoin,
                    rmiName = RmiName_RC_NotifyFriendlyMatchJoin,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchJoin(remote, rmiContext, fmProfileInfo, simpleTeamInfo, readyStatus, matchMode, modeID, userMode))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchJoin);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchJoin,
                    rmiName = RmiName_RC_NotifyFriendlyMatchJoin,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchLobbySync(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchSyncInfo syncInfo;
            CommonPacket.Marshaler.Read(__msg, out syncInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchLobbySync);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchLobbySync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchLobbySync,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchLobbySync(remote, rmiContext, syncInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchLobbySync);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchLobbySync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchLobbySync,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchUserReady(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchUserReady);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserReady,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserReady,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchUserReady(remote, rmiContext, usn))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchUserReady);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserReady,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserReady,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchUserReadyOff(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchUserReadyOff);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserReadyOff,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserReadyOff,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchUserReadyOff(remote, rmiContext, usn))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchUserReadyOff);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserReadyOff,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserReadyOff,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchUserChangeTeam(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchUserChangeTeam);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserChangeTeam,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserChangeTeam,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchUserChangeTeam(remote, rmiContext, usn, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchUserChangeTeam);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserChangeTeam,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserChangeTeam,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchKickedOut(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchKickedOut);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchKickedOut,
                    rmiName = RmiName_RC_NotifyFriendlyMatchKickedOut,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchKickedOut(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchKickedOut);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchKickedOut,
                    rmiName = RmiName_RC_NotifyFriendlyMatchKickedOut,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchUserGameStart(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            FriendlyMatchStartResult startResult;
            CommonPacket.Marshaler.Read(__msg, out startResult);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchUserGameStart);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserGameStart,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserGameStart,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchUserGameStart(remote, rmiContext, usn, simpleTeamInfo, startResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchUserGameStart);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchUserGameStart,
                    rmiName = RmiName_RC_NotifyFriendlyMatchUserGameStart,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchSync(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchSync);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchSync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchSync,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchSync(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchSync);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchSync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchSync,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchChatEnter(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchChatMessage chatMessage;
            CommonPacket.Marshaler.Read(__msg, out chatMessage);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchChatEnter);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChatEnter,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChatEnter,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchChatEnter(remote, rmiContext, chatMessage))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchChatEnter);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChatEnter,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChatEnter,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchExit(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long leaveUSN;
            CommonPacket.Marshaler.Read(__msg, out leaveUSN);
            bool isOwner;
            CommonPacket.Marshaler.Read(__msg, out isOwner);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchExit);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchExit,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchExit(remote, rmiContext, leaveUSN, isOwner))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchExit);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchExit,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchInGameExit(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long leaveUSN;
            CommonPacket.Marshaler.Read(__msg, out leaveUSN);
            bool isOwner;
            CommonPacket.Marshaler.Read(__msg, out isOwner);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchInGameExit);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchInGameExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchInGameExit,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchInGameExit(remote, rmiContext, leaveUSN, isOwner))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchInGameExit);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchInGameExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchInGameExit,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchChangeMatchMode(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte matchMode;
            CommonPacket.Marshaler.Read(__msg, out matchMode);
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchChangeMatchMode);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChangeMatchMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChangeMatchMode,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchChangeMatchMode(remote, rmiContext, matchMode, modeID))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchChangeMatchMode);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChangeMatchMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChangeMatchMode,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchChangeModeID(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchChangeModeID);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChangeModeID,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChangeModeID,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchChangeModeID(remote, rmiContext, modeID))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchChangeModeID);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChangeModeID,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChangeModeID,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchReadyTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isSuccess;
            CommonPacket.Marshaler.Read(__msg, out isSuccess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchReadyTimeOverOK(remote, rmiContext, isSuccess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchInGameReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool timeOver;
            CommonPacket.Marshaler.Read(__msg, out timeOver);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchInGameReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchInGameReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchInGameReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchInGameReadyOK(remote, rmiContext, timeOver))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchInGameReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchInGameReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchInGameReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchFightOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchFightOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchFightOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchFightOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchFightOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchFightOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchFightOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchFightOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchInGameExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUSN;
            CommonPacket.Marshaler.Read(__msg, out targetUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchInGameExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchInGameExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchInGameExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchInGameExitOK(remote, rmiContext, targetUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchInGameExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchInGameExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchInGameExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchChangeUserModeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUSN;
            CommonPacket.Marshaler.Read(__msg, out targetUSN);
            byte userMode;
            CommonPacket.Marshaler.Read(__msg, out userMode);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchChangeUserModeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChangeUserModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChangeUserModeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchChangeUserModeOK(remote, rmiContext, targetUSN, userMode))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchChangeUserModeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchChangeUserModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchChangeUserModeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchChangeUserMode(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUSN;
            CommonPacket.Marshaler.Read(__msg, out targetUSN);
            byte userMode;
            CommonPacket.Marshaler.Read(__msg, out userMode);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchChangeUserMode);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChangeUserMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChangeUserMode,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchChangeUserMode(remote, rmiContext, targetUSN, userMode))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchChangeUserMode);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchChangeUserMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchChangeUserMode,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerLoginOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerLoginOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserProfileInfo userInfo;
            CommonPacket.Marshaler.Read(__msg, out userInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerJoinOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerJoinOK(remote, rmiContext, userInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerJoinOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUsn;
            CommonPacket.Marshaler.Read(__msg, out targetUsn);
            bool giveup;
            CommonPacket.Marshaler.Read(__msg, out giveup);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerExitOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerExitOK(remote, rmiContext, targetUsn, giveup))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerExitOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool timeOver;
            CommonPacket.Marshaler.Read(__msg, out timeOver);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerReadyOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerReadyOK(remote, rmiContext, timeOver))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerReadyOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerFightOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerFightOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerFightOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerFightOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerFightOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerFightOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerFightOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerFightOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerSyncOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerSyncOK(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerSyncOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerReadyTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool bSucess;
            CommonPacket.Marshaler.Read(__msg, out bSucess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerReadyTimeOverOK(remote, rmiContext, bSucess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            int stampID;
            CommonPacket.Marshaler.Read(__msg, out stampID);
            string message;
            CommonPacket.Marshaler.Read(__msg, out message);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerChatEnterOK(remote, rmiContext, sendUSN, stampID, message))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLowerJoinTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLowerJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLowerJoinTimeOverOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLowerJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLowerJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLowerJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingConnectOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool connectResult;
            CommonPacket.Marshaler.Read(__msg, out connectResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingConnectOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingConnectOK,
                    rmiName = RmiName_CR_RequestArenaRankingConnectOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingConnectOK(remote, rmiContext, connectResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingConnectOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingConnectOK,
                    rmiName = RmiName_CR_RequestArenaRankingConnectOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingLoginOK,
                    rmiName = RmiName_CR_RequestArenaRankingLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingLoginOK,
                    rmiName = RmiName_CR_RequestArenaRankingLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserProfileInfo userInfo;
            CommonPacket.Marshaler.Read(__msg, out userInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingJoinOK,
                    rmiName = RmiName_CR_RequestArenaRankingJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingJoinOK(remote, rmiContext, userInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingJoinOK,
                    rmiName = RmiName_CR_RequestArenaRankingJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUsn;
            CommonPacket.Marshaler.Read(__msg, out targetUsn);
            bool giveup;
            CommonPacket.Marshaler.Read(__msg, out giveup);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingExitOK,
                    rmiName = RmiName_CR_RequestArenaRankingExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingExitOK(remote, rmiContext, targetUsn, giveup))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingExitOK,
                    rmiName = RmiName_CR_RequestArenaRankingExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool timeOver;
            CommonPacket.Marshaler.Read(__msg, out timeOver);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingReadyOK,
                    rmiName = RmiName_CR_RequestArenaRankingReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingReadyOK(remote, rmiContext, timeOver))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingReadyOK,
                    rmiName = RmiName_CR_RequestArenaRankingReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingFightOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingFightOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingFightOK,
                    rmiName = RmiName_CR_RequestArenaRankingFightOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingFightOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingFightOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingFightOK,
                    rmiName = RmiName_CR_RequestArenaRankingFightOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingSyncOK,
                    rmiName = RmiName_CR_RequestArenaRankingSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingSyncOK(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingSyncOK,
                    rmiName = RmiName_CR_RequestArenaRankingSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingReadyTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool bSucess;
            CommonPacket.Marshaler.Read(__msg, out bSucess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRankingReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingReadyTimeOverOK(remote, rmiContext, bSucess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRankingReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            int stampID;
            CommonPacket.Marshaler.Read(__msg, out stampID);
            string message;
            CommonPacket.Marshaler.Read(__msg, out message);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRankingChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingChatEnterOK(remote, rmiContext, sendUSN, stampID, message))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRankingChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRankingJoinTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRankingJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRankingJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRankingJoinTimeOverOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRankingJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRankingJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRankingJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchLoginOK,
                    rmiName = RmiName_CR_RequestTournamentMatchLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchLoginOK,
                    rmiName = RmiName_CR_RequestTournamentMatchLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchChangeTeamOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<byte> teamSlotIndexList;
            CommonPacket.Marshaler.Read(__msg, out teamSlotIndexList);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchChangeTeamOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchChangeTeamOK,
                    rmiName = RmiName_CR_RequestTournamentMatchChangeTeamOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchChangeTeamOK(remote, rmiContext, teamSlotIndexList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchChangeTeamOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchChangeTeamOK,
                    rmiName = RmiName_CR_RequestTournamentMatchChangeTeamOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool readyStatus;
            CommonPacket.Marshaler.Read(__msg, out readyStatus);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchReadyOK,
                    rmiName = RmiName_CR_RequestTournamentMatchReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchReadyOK(remote, rmiContext, readyStatus))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchReadyOK,
                    rmiName = RmiName_CR_RequestTournamentMatchReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchInGameReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool timeOver;
            CommonPacket.Marshaler.Read(__msg, out timeOver);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchInGameReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameReadyOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchInGameReadyOK(remote, rmiContext, timeOver))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchInGameReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameReadyOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchInGameTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isSuccess;
            CommonPacket.Marshaler.Read(__msg, out isSuccess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchInGameTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameTimeOverOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchInGameTimeOverOK(remote, rmiContext, isSuccess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchInGameTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameTimeOverOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchInGameSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchInGameSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameSyncOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchInGameSyncOK(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchInGameSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameSyncOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchInGameGiveupOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchInGameGiveupOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameGiveupOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameGiveupOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchInGameGiveupOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchInGameGiveupOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameGiveupOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameGiveupOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchInGameExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentMatchInfo matchInfo;
            CommonPacket.Marshaler.Read(__msg, out matchInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchInGameExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameExitOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchInGameExitOK(remote, rmiContext, matchInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchInGameExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameExitOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int stampID;
            CommonPacket.Marshaler.Read(__msg, out stampID);
            string message;
            CommonPacket.Marshaler.Read(__msg, out message);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchChatEnterOK,
                    rmiName = RmiName_CR_RequestTournamentMatchChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchChatEnterOK(remote, rmiContext, stampID, message))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchChatEnterOK,
                    rmiName = RmiName_CR_RequestTournamentMatchChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isSuspend;
            CommonPacket.Marshaler.Read(__msg, out isSuspend);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchExitOK,
                    rmiName = RmiName_CR_RequestTournamentMatchExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchExitOK(remote, rmiContext, isSuspend))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchExitOK,
                    rmiName = RmiName_CR_RequestTournamentMatchExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentWatcherLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentWatcherLoginResult loginResult;
            CommonPacket.Marshaler.Read(__msg, out loginResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentWatcherLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentWatcherLoginOK,
                    rmiName = RmiName_CR_RequestTournamentWatcherLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentWatcherLoginOK(remote, rmiContext, loginResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentWatcherLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentWatcherLoginOK,
                    rmiName = RmiName_CR_RequestTournamentWatcherLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentWatcherExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentWatcherExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentWatcherExitOK,
                    rmiName = RmiName_CR_RequestTournamentWatcherExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentWatcherExitOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentWatcherExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentWatcherExitOK,
                    rmiName = RmiName_CR_RequestTournamentWatcherExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchReplayStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchReplayStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchReplayStartOK,
                    rmiName = RmiName_CR_RequestTournamentMatchReplayStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchReplayStartOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchReplayStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchReplayStartOK,
                    rmiName = RmiName_CR_RequestTournamentMatchReplayStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestTournamentMatchInGameClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestTournamentMatchInGameClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameClearOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestTournamentMatchInGameClearOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestTournamentMatchInGameClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestTournamentMatchInGameClearOK,
                    rmiName = RmiName_CR_RequestTournamentMatchInGameClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchJoin(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentMatchUserProfileInfo otherProfileInfo;
            CommonPacket.Marshaler.Read(__msg, out otherProfileInfo);
            OtherPlayerSimpleTeamInfo otherTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out otherTeamInfo);
            bool otherReadyStatus;
            CommonPacket.Marshaler.Read(__msg, out otherReadyStatus);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchJoin);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchJoin,
                    rmiName = RmiName_RC_NotifyTournamentMatchJoin,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchJoin(remote, rmiContext, otherProfileInfo, otherTeamInfo, otherReadyStatus))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchJoin);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchJoin,
                    rmiName = RmiName_RC_NotifyTournamentMatchJoin,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchChangeTeam(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long otherUSN;
            CommonPacket.Marshaler.Read(__msg, out otherUSN);
            List<byte> teamSlotIndexList;
            CommonPacket.Marshaler.Read(__msg, out teamSlotIndexList);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchChangeTeam);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchChangeTeam,
                    rmiName = RmiName_RC_NotifyTournamentMatchChangeTeam,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchChangeTeam(remote, rmiContext, otherUSN, teamSlotIndexList))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchChangeTeam);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchChangeTeam,
                    rmiName = RmiName_RC_NotifyTournamentMatchChangeTeam,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchReady(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long otherUSN;
            CommonPacket.Marshaler.Read(__msg, out otherUSN);
            bool readyStatus;
            CommonPacket.Marshaler.Read(__msg, out readyStatus);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchReady);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchReady,
                    rmiName = RmiName_RC_NotifyTournamentMatchReady,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchReady(remote, rmiContext, otherUSN, readyStatus))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchReady);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchReady,
                    rmiName = RmiName_RC_NotifyTournamentMatchReady,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchStart(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentMatchStartResult startResult;
            CommonPacket.Marshaler.Read(__msg, out startResult);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchStart);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchStart,
                    rmiName = RmiName_RC_NotifyTournamentMatchStart,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchStart(remote, rmiContext, startResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchStart);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchStart,
                    rmiName = RmiName_RC_NotifyTournamentMatchStart,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchInGameFight(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchInGameFight);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameFight,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameFight,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchInGameFight(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchInGameFight);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameFight,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameFight,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchInGameSync(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            byte currentPlayIndex;
            CommonPacket.Marshaler.Read(__msg, out currentPlayIndex);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            string replaySync;
            CommonPacket.Marshaler.Read(__msg, out replaySync);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchInGameSync);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameSync,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameSync,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchInGameSync(remote, rmiContext, sendUSN, currentPlayIndex, strSync, replaySync))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchInGameSync);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameSync,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameSync,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchInGameGiveup(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long giveupUSN;
            CommonPacket.Marshaler.Read(__msg, out giveupUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchInGameGiveup);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameGiveup,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameGiveup,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchInGameGiveup(remote, rmiContext, giveupUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchInGameGiveup);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameGiveup,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameGiveup,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchInGameExit(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long leaveUSN;
            CommonPacket.Marshaler.Read(__msg, out leaveUSN);
            TournamentMatchInfo matchInfo;
            CommonPacket.Marshaler.Read(__msg, out matchInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchInGameExit);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameExit,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameExit,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchInGameExit(remote, rmiContext, leaveUSN, matchInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchInGameExit);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchInGameExit,
                    rmiName = RmiName_RC_NotifyTournamentMatchInGameExit,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchChatEnter(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            int stampID;
            CommonPacket.Marshaler.Read(__msg, out stampID);
            string message;
            CommonPacket.Marshaler.Read(__msg, out message);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchChatEnter);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchChatEnter,
                    rmiName = RmiName_RC_NotifyTournamentMatchChatEnter,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchChatEnter(remote, rmiContext, sendUSN, stampID, message))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchChatEnter);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchChatEnter,
                    rmiName = RmiName_RC_NotifyTournamentMatchChatEnter,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentMatchExit(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long leaveUSN;
            CommonPacket.Marshaler.Read(__msg, out leaveUSN);
            TournamentMatchInfo matchInfo;
            CommonPacket.Marshaler.Read(__msg, out matchInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentMatchExit);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchExit,
                    rmiName = RmiName_RC_NotifyTournamentMatchExit,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentMatchExit(remote, rmiContext, leaveUSN, matchInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentMatchExit);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentMatchExit,
                    rmiName = RmiName_RC_NotifyTournamentMatchExit,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyTournamentWatcherStart(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte currentPlayIndex;
            CommonPacket.Marshaler.Read(__msg, out currentPlayIndex);
            ReplayBytesInfo replayBytesInfo;
            CommonPacket.Marshaler.Read(__msg, out replayBytesInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyTournamentWatcherStart);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentWatcherStart,
                    rmiName = RmiName_RC_NotifyTournamentWatcherStart,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyTournamentWatcherStart(remote, rmiContext, currentPlayIndex, replayBytesInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyTournamentWatcherStart);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyTournamentWatcherStart,
                    rmiName = RmiName_RC_NotifyTournamentWatcherStart,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int position;
            CommonPacket.Marshaler.Read(__msg, out position);
            List<BossWarUserProfileInfo> memberProfileList;
            CommonPacket.Marshaler.Read(__msg, out memberProfileList);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueLoginOK,
                    rmiName = RmiName_CR_RequestSubdueLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueLoginOK(remote, rmiContext, position, memberProfileList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueLoginOK,
                    rmiName = RmiName_CR_RequestSubdueLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueReLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueReLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueReLoginOK,
                    rmiName = RmiName_CR_RequestSubdueReLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueReLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueReLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueReLoginOK,
                    rmiName = RmiName_CR_RequestSubdueReLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueReadyOK,
                    rmiName = RmiName_CR_RequestSubdueReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueReadyOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueReadyOK,
                    rmiName = RmiName_CR_RequestSubdueReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueReturnReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueReturnReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueReturnReadyOK,
                    rmiName = RmiName_CR_RequestSubdueReturnReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueReturnReadyOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueReturnReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueReturnReadyOK,
                    rmiName = RmiName_CR_RequestSubdueReturnReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueLeaveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueLeaveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueLeaveOK,
                    rmiName = RmiName_CR_RequestSubdueLeaveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueLeaveOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueLeaveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueLeaveOK,
                    rmiName = RmiName_CR_RequestSubdueLeaveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueKickoutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueKickoutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueKickoutOK,
                    rmiName = RmiName_CR_RequestSubdueKickoutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueKickoutOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueKickoutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueKickoutOK,
                    rmiName = RmiName_CR_RequestSubdueKickoutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueGameStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueGameStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueGameStartOK,
                    rmiName = RmiName_CR_RequestSubdueGameStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueGameStartOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueGameStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueGameStartOK,
                    rmiName = RmiName_CR_RequestSubdueGameStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueBattleSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            SubdueBossBattleSyncResult battleSyncResult;
            CommonPacket.Marshaler.Read(__msg, out battleSyncResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueBattleSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueBattleSyncOK,
                    rmiName = RmiName_CR_RequestSubdueBattleSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueBattleSyncOK(remote, rmiContext, battleSyncResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueBattleSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueBattleSyncOK,
                    rmiName = RmiName_CR_RequestSubdueBattleSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestSubdueBattleEndOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isWait;
            CommonPacket.Marshaler.Read(__msg, out isWait);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestSubdueBattleEndOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueBattleEndOK,
                    rmiName = RmiName_CR_RequestSubdueBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestSubdueBattleEndOK(remote, rmiContext, isWait))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestSubdueBattleEndOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestSubdueBattleEndOK,
                    rmiName = RmiName_CR_RequestSubdueBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_NotifySubdueSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            BossWarNotifyType notifyType;
            CommonPacket.Marshaler.Read(__msg, out notifyType);
            long notifyValue1;
            CommonPacket.Marshaler.Read(__msg, out notifyValue1);
            long notifyValue2;
            CommonPacket.Marshaler.Read(__msg, out notifyValue2);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_NotifySubdueSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueSyncOK,
                    rmiName = RmiName_CR_NotifySubdueSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_NotifySubdueSyncOK(remote, rmiContext, usn, notifyType, notifyValue1, notifyValue2))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_NotifySubdueSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueSyncOK,
                    rmiName = RmiName_CR_NotifySubdueSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_NotifySubdueMemberJoinUpdateOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            BossWarUserProfileInfo joinMemberProfile;
            CommonPacket.Marshaler.Read(__msg, out joinMemberProfile);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_NotifySubdueMemberJoinUpdateOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueMemberJoinUpdateOK,
                    rmiName = RmiName_CR_NotifySubdueMemberJoinUpdateOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_NotifySubdueMemberJoinUpdateOK(remote, rmiContext, joinMemberProfile))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_NotifySubdueMemberJoinUpdateOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueMemberJoinUpdateOK,
                    rmiName = RmiName_CR_NotifySubdueMemberJoinUpdateOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_NotifySubdueGameStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            BossWarStartResult startResult;
            CommonPacket.Marshaler.Read(__msg, out startResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_NotifySubdueGameStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueGameStartOK,
                    rmiName = RmiName_CR_NotifySubdueGameStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_NotifySubdueGameStartOK(remote, rmiContext, startResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_NotifySubdueGameStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueGameStartOK,
                    rmiName = RmiName_CR_NotifySubdueGameStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_NotifySubdueLoadingCompleteOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int remainSeconds;
            CommonPacket.Marshaler.Read(__msg, out remainSeconds);
            bool loadingSuccess;
            CommonPacket.Marshaler.Read(__msg, out loadingSuccess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_NotifySubdueLoadingCompleteOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueLoadingCompleteOK,
                    rmiName = RmiName_CR_NotifySubdueLoadingCompleteOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_NotifySubdueLoadingCompleteOK(remote, rmiContext, remainSeconds, loadingSuccess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_NotifySubdueLoadingCompleteOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueLoadingCompleteOK,
                    rmiName = RmiName_CR_NotifySubdueLoadingCompleteOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_NotifySubdueRewardAggregationOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isRecvRewardOK;
            CommonPacket.Marshaler.Read(__msg, out isRecvRewardOK);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_NotifySubdueRewardAggregationOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueRewardAggregationOK,
                    rmiName = RmiName_CR_NotifySubdueRewardAggregationOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_NotifySubdueRewardAggregationOK(remote, rmiContext, isRecvRewardOK))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_NotifySubdueRewardAggregationOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_NotifySubdueRewardAggregationOK,
                    rmiName = RmiName_CR_NotifySubdueRewardAggregationOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveLoginOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveLoginOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveLobbySyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchSyncInfo otherUserSyncInfo;
            CommonPacket.Marshaler.Read(__msg, out otherUserSyncInfo);
            int syncBattlePoint;
            CommonPacket.Marshaler.Read(__msg, out syncBattlePoint);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveLobbySyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveLobbySyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveLobbySyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveLobbySyncOK(remote, rmiContext, otherUserSyncInfo, syncBattlePoint))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveLobbySyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveLobbySyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveLobbySyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveReadyOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyOffOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveReadyOffOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyOffOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyOffOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveReadyOffOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveReadyOffOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyOffOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyOffOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChangeTeamOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveChangeTeamOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChangeTeamOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChangeTeamOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveChangeTeamOK(remote, rmiContext, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveChangeTeamOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChangeTeamOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChangeTeamOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveTeamInfoOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveTeamInfoOK(remote, rmiContext, usn, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveTeamInfoOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChangeMatchModeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte matchMode;
            CommonPacket.Marshaler.Read(__msg, out matchMode);
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            byte passiveID;
            CommonPacket.Marshaler.Read(__msg, out passiveID);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveChangeMatchModeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChangeMatchModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChangeMatchModeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveChangeMatchModeOK(remote, rmiContext, matchMode, modeID, passiveID))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveChangeMatchModeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChangeMatchModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChangeMatchModeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveKickOutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long kickUSN;
            CommonPacket.Marshaler.Read(__msg, out kickUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveKickOutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveKickOutOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveKickOutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveKickOutOK(remote, rmiContext, kickUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveKickOutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveKickOutOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveKickOutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchStartResult startResult;
            CommonPacket.Marshaler.Read(__msg, out startResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveStartOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveStartOK(remote, rmiContext, startResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveStartOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveSyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveSyncOK(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveSyncOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUsn;
            CommonPacket.Marshaler.Read(__msg, out targetUsn);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveExitOK(remote, rmiContext, targetUsn))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchChatMessage chatMessage;
            CommonPacket.Marshaler.Read(__msg, out chatMessage);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChatEnterOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveChatEnterOK(remote, rmiContext, chatMessage))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChatEnterOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveJoin(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchUserProfileInfo fmProfileInfo;
            CommonPacket.Marshaler.Read(__msg, out fmProfileInfo);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            bool readyStatus;
            CommonPacket.Marshaler.Read(__msg, out readyStatus);
            byte matchMode;
            CommonPacket.Marshaler.Read(__msg, out matchMode);
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            byte passiveID;
            CommonPacket.Marshaler.Read(__msg, out passiveID);
            byte userMode;
            CommonPacket.Marshaler.Read(__msg, out userMode);
            bool isRoomOwner;
            CommonPacket.Marshaler.Read(__msg, out isRoomOwner);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveJoin);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveJoin,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveJoin,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveJoin(remote, rmiContext, fmProfileInfo, simpleTeamInfo, readyStatus, matchMode, modeID, passiveID, userMode, isRoomOwner))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveJoin);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveJoin,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveJoin,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveLobbySync(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchSyncInfo syncInfo;
            CommonPacket.Marshaler.Read(__msg, out syncInfo);
            int syncBattlePoint;
            CommonPacket.Marshaler.Read(__msg, out syncBattlePoint);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveLobbySync);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveLobbySync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveLobbySync,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveLobbySync(remote, rmiContext, syncInfo, syncBattlePoint))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveLobbySync);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveLobbySync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveLobbySync,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserReady(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveUserReady);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserReady,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserReady,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveUserReady(remote, rmiContext, usn))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveUserReady);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserReady,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserReady,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserReadyOff(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveUserReadyOff);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserReadyOff,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserReadyOff,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveUserReadyOff(remote, rmiContext, usn))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveUserReadyOff);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserReadyOff,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserReadyOff,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserChangeTeam(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveUserChangeTeam);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserChangeTeam,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserChangeTeam,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveUserChangeTeam(remote, rmiContext, usn, simpleTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveUserChangeTeam);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserChangeTeam,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserChangeTeam,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveKickedOut(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveKickedOut);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveKickedOut,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveKickedOut,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveKickedOut(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveKickedOut);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveKickedOut,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveKickedOut,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserGameStart(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            OtherPlayerSimpleTeamInfo simpleTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out simpleTeamInfo);
            List<FriendlyMatchObserveStartResult> startResultList;
            CommonPacket.Marshaler.Read(__msg, out startResultList);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveUserGameStart);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserGameStart,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserGameStart,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveUserGameStart(remote, rmiContext, usn, simpleTeamInfo, startResultList))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveUserGameStart);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserGameStart,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserGameStart,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveSync(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            string replaySync;
            CommonPacket.Marshaler.Read(__msg, out replaySync);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveSync);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveSync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveSync,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveSync(remote, rmiContext, sendUSN, strSync, replaySync))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveSync);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveSync,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveSync,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChatEnter(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchChatMessage chatMessage;
            CommonPacket.Marshaler.Read(__msg, out chatMessage);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveChatEnter);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChatEnter,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChatEnter,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveChatEnter(remote, rmiContext, chatMessage))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveChatEnter);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChatEnter,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChatEnter,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveExit(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long leaveUSN;
            CommonPacket.Marshaler.Read(__msg, out leaveUSN);
            bool isOwner;
            CommonPacket.Marshaler.Read(__msg, out isOwner);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveExit);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveExit,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveExit(remote, rmiContext, leaveUSN, isOwner))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveExit);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveExit,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveInGameExit(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long leaveUSN;
            CommonPacket.Marshaler.Read(__msg, out leaveUSN);
            bool isOwner;
            CommonPacket.Marshaler.Read(__msg, out isOwner);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveInGameExit);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveInGameExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveInGameExit,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveInGameExit(remote, rmiContext, leaveUSN, isOwner))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveInGameExit);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveInGameExit,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveInGameExit,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChangeMatchMode(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte matchMode;
            CommonPacket.Marshaler.Read(__msg, out matchMode);
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            byte passiveID;
            CommonPacket.Marshaler.Read(__msg, out passiveID);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveChangeMatchMode);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChangeMatchMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChangeMatchMode,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveChangeMatchMode(remote, rmiContext, matchMode, modeID, passiveID))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveChangeMatchMode);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChangeMatchMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChangeMatchMode,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChangeModeID(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte modeID;
            CommonPacket.Marshaler.Read(__msg, out modeID);
            byte passiveID;
            CommonPacket.Marshaler.Read(__msg, out passiveID);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveChangeModeID);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChangeModeID,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChangeModeID,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveChangeModeID(remote, rmiContext, modeID, passiveID))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveChangeModeID);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChangeModeID,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChangeModeID,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isSuccess;
            CommonPacket.Marshaler.Read(__msg, out isSuccess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveReadyTimeOverOK(remote, rmiContext, isSuccess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool timeOver;
            CommonPacket.Marshaler.Read(__msg, out timeOver);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveInGameReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveInGameReadyOK(remote, rmiContext, timeOver))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveInGameReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameReadyOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveFightOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveFightOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveFightOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveFightOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveFightOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveFightOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveFightOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveFightOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUSN;
            CommonPacket.Marshaler.Read(__msg, out targetUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveInGameExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveInGameExitOK(remote, rmiContext, targetUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveInGameExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameExitOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveChangeUserModeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUSN;
            CommonPacket.Marshaler.Read(__msg, out targetUSN);
            byte userMode;
            CommonPacket.Marshaler.Read(__msg, out userMode);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveChangeUserModeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChangeUserModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChangeUserModeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveChangeUserModeOK(remote, rmiContext, targetUSN, userMode))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveChangeUserModeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveChangeUserModeOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveChangeUserModeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveChangeUserMode(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUSN;
            CommonPacket.Marshaler.Read(__msg, out targetUSN);
            byte userMode;
            CommonPacket.Marshaler.Read(__msg, out userMode);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveChangeUserMode);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChangeUserMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChangeUserMode,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveChangeUserMode(remote, rmiContext, targetUSN, userMode))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveChangeUserMode);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveChangeUserMode,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveChangeUserMode,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReplayStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveReplayStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReplayStartOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReplayStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveReplayStartOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveReplayStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReplayStartOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReplayStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveWatcherStart(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ReplayBytesInfo replayBytesInfo;
            CommonPacket.Marshaler.Read(__msg, out replayBytesInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveWatcherStart);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveWatcherStart,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveWatcherStart,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveWatcherStart(remote, rmiContext, replayBytesInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveWatcherStart);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveWatcherStart,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveWatcherStart,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveUserStatusOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchUserStatusInfo userStatusInfo;
            CommonPacket.Marshaler.Read(__msg, out userStatusInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveUserStatusOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveUserStatusOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveUserStatusOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveUserStatusOK(remote, rmiContext, userStatusInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveUserStatusOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveUserStatusOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveUserStatusOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveUserStatus(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            FriendlyMatchUserStatusInfo userStatusInfo;
            CommonPacket.Marshaler.Read(__msg, out userStatusInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveUserStatus);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserStatus,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserStatus,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveUserStatus(remote, rmiContext, userStatusInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveUserStatus);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveUserStatus,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveUserStatus,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveLobbyHeartBeatOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveLobbyHeartBeatOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveLobbyHeartBeatOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveLobbyHeartBeatOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveLobbyHeartBeatOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveLobbyHeartBeatOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveLobbyHeartBeatOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveLobbyHeartBeatOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveReadyOffAllOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveReadyOffAllOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyOffAllOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyOffAllOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveReadyOffAllOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveReadyOffAllOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveReadyOffAllOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveReadyOffAllOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveInGameClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameClearOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveInGameClearOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveInGameClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameClearOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_RC_NotifyFriendlyMatchObserveInGameClear(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_RC_NotifyFriendlyMatchObserveInGameClear);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveInGameClear,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveInGameClear,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.RC_NotifyFriendlyMatchObserveInGameClear(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_RC_NotifyFriendlyMatchObserveInGameClear);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.RC_NotifyFriendlyMatchObserveInGameClear,
                    rmiName = RmiName_RC_NotifyFriendlyMatchObserveInGameClear,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestFriendlyMatchObserveInGameHeartBeatOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestFriendlyMatchObserveInGameHeartBeatOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameHeartBeatOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameHeartBeatOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestFriendlyMatchObserveInGameHeartBeatOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestFriendlyMatchObserveInGameHeartBeatOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestFriendlyMatchObserveInGameHeartBeatOK,
                    rmiName = RmiName_CR_RequestFriendlyMatchObserveInGameHeartBeatOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitLoginOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitLoginOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitLoginOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitLoginOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitLoginOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitLoginOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitLoginOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitLoginOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserProfileInfo userInfo;
            CommonPacket.Marshaler.Read(__msg, out userInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitJoinOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitJoinOK(remote, rmiContext, userInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitJoinOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUsn;
            CommonPacket.Marshaler.Read(__msg, out targetUsn);
            bool giveup;
            CommonPacket.Marshaler.Read(__msg, out giveup);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitExitOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitExitOK(remote, rmiContext, targetUsn, giveup))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitExitOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitReadyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool timeOver;
            CommonPacket.Marshaler.Read(__msg, out timeOver);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitReadyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitReadyOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitReadyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitReadyOK(remote, rmiContext, timeOver))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitReadyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitReadyOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitReadyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitFightOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitFightOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitFightOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitFightOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitFightOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitFightOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitFightOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitFightOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            string strSync;
            CommonPacket.Marshaler.Read(__msg, out strSync);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitSyncOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitSyncOK(remote, rmiContext, sendUSN, strSync))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitSyncOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitReadyTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool bSucess;
            CommonPacket.Marshaler.Read(__msg, out bSucess);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitReadyTimeOverOK(remote, rmiContext, bSucess))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitReadyTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitReadyTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitReadyTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitChatEnterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long sendUSN;
            CommonPacket.Marshaler.Read(__msg, out sendUSN);
            int stampID;
            CommonPacket.Marshaler.Read(__msg, out stampID);
            string message;
            CommonPacket.Marshaler.Read(__msg, out message);
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitChatEnterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitChatEnterOK(remote, rmiContext, sendUSN, stampID, message))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitChatEnterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitChatEnterOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitChatEnterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CR_RequestArenaRealTimePVPLimitJoinTimeOverOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CR_RequestArenaRealTimePVPLimitJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CR_RequestArenaRealTimePVPLimitJoinTimeOverOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CR_RequestArenaRealTimePVPLimitJoinTimeOverOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CR_RequestArenaRealTimePVPLimitJoinTimeOverOK,
                    rmiName = RmiName_CR_RequestArenaRealTimePVPLimitJoinTimeOverOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        public override RmiID[] GetRmiIDList
        {
            get
            {
                return Common.RmiIDList;
            }
        }

        public RmiStub.AfterRmiInvocationDelegate AfterRmiInvocation = delegate (AfterRmiSummary summary)
        {
        };

        public RmiStub.BeforeRmiInvocationDelegate BeforeRmiInvocation = delegate (BeforeRmiSummary summary)
        {
        };

        public Stub.CR_CommonCancelDelegate CR_CommonCancel = (HostID remote, RmiContext rmiContext, RmiID packetID, string packetName, PacketError error, InvalidRequestType invalidRequesttype, bool isSimpleMessageBox) => false;

        public Stub.CR_RequestForceLogoutOKDelegate CR_RequestForceLogoutOK = (HostID remote, RmiContext rmiContext, PacketError error) => false;

        public Stub.CR_RequestArenaRealTimePVPLoginOKDelegate CR_RequestArenaRealTimePVPLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRealTimePVPJoinOKDelegate CR_RequestArenaRealTimePVPJoinOK = (HostID remote, RmiContext rmiContext, UserProfileInfo userInfo) => false;

        public Stub.CR_RequestArenaRealTimePVPExitOKDelegate CR_RequestArenaRealTimePVPExitOK = (HostID remote, RmiContext rmiContext, long targetUsn, bool giveup) => false;

        public Stub.CR_RequestArenaRealTimePVPReadyOKDelegate CR_RequestArenaRealTimePVPReadyOK = (HostID remote, RmiContext rmiContext, bool timeOver) => false;

        public Stub.CR_RequestArenaRealTimePVPFightOKDelegate CR_RequestArenaRealTimePVPFightOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRealTimePVPSyncOKDelegate CR_RequestArenaRealTimePVPSyncOK = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.CR_RequestArenaRealTimePVPReadyTimeOverOKDelegate CR_RequestArenaRealTimePVPReadyTimeOverOK = (HostID remote, RmiContext rmiContext, bool bSucess) => false;

        public Stub.CR_RequestArenaRealTimePVPChatEnterOKDelegate CR_RequestArenaRealTimePVPChatEnterOK = (HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message) => false;

        public Stub.CR_RequestArenaRealTimePVPJoinTimeOverOKDelegate CR_RequestArenaRealTimePVPJoinTimeOverOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyDestroyUserJoinDelegate RC_NotifyDestroyUserJoin = (HostID remote, RmiContext rmiContext, DestroyUserProfileInfo userInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.RC_NotifyDestroyUserStateChangedDelegate RC_NotifyDestroyUserStateChanged = (HostID remote, RmiContext rmiContext, DestroyLobbySyncInfo syncInfo) => false;

        public Stub.RC_NotifyDestroyUserExitDelegate RC_NotifyDestroyUserExit = (HostID remote, RmiContext rmiContext, long exitUSN, bool isOwner) => false;

        public Stub.RC_NotifyDestroyGameStartDelegate RC_NotifyDestroyGameStart = (HostID remote, RmiContext rmiContext, DestroyStartResult startResult) => false;

        public Stub.RC_NotifyDestroyIngameStartDelegate RC_NotifyDestroyIngameStart = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyDestroySyncDelegate RC_NotifyDestroySync = (HostID remote, RmiContext rmiContext, DestroySyncInfo syncInfo) => false;

        public Stub.RC_NotifyDestroyGameEndDelegate RC_NotifyDestroyGameEnd = (HostID remote, RmiContext rmiContext, bool isClear, bool ownerExit) => false;

        public Stub.RC_NotifyDestroySelectSkillCardDelegate RC_NotifyDestroySelectSkillCard = (HostID remote, RmiContext rmiContext, DestroyCardOrderInfo cardOrderInfo) => false;

        public Stub.RC_NotifyDestroyRoundFinishDelegate RC_NotifyDestroyRoundFinish = (HostID remote, RmiContext rmiContext, short roundID) => false;

        public Stub.RC_NotifyDestroyChatEnterDelegate RC_NotifyDestroyChatEnter = (HostID remote, RmiContext rmiContext, DestroyChatMessage chatMessage) => false;

        public Stub.RC_RequestDestroyNeedSyncDelegate RC_RequestDestroyNeedSync = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyLoginOKDelegate CR_RequestDestroyLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyReLoginOKDelegate CR_RequestDestroyReLoginOK = (HostID remote, RmiContext rmiContext, DestroyUserProfileInfo otherPlayerProfileInfo) => false;

        public Stub.CR_RequestDestroyRelayReadyOKDelegate CR_RequestDestroyRelayReadyOK = (HostID remote, RmiContext rmiContext, DestroyUserProfileInfo otherUserProfileInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.CR_RequestDestroyLobbySyncOKDelegate CR_RequestDestroyLobbySyncOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyChatEnterOKDelegate CR_RequestDestroyChatEnterOK = (HostID remote, RmiContext rmiContext, DestroyChatMessage chatMessage) => false;

        public Stub.CR_RequestDestroyReadyOKDelegate CR_RequestDestroyReadyOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyReturnReadyOKDelegate CR_RequestDestroyReturnReadyOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyKickOutOKDelegate CR_RequestDestroyKickOutOK = (HostID remote, RmiContext rmiContext, long usn) => false;

        public Stub.CR_RequestDestroyChangeTeamInfoOKDelegate CR_RequestDestroyChangeTeamInfoOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyMemberTeamInfoOKDelegate CR_RequestDestroyMemberTeamInfoOK = (HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.CR_RequestDestroyIngameReadyOKDelegate CR_RequestDestroyIngameReadyOK = (HostID remote, RmiContext rmiContext, short playingRoundID) => false;

        public Stub.CR_RequestDestroyRoundFinishOKDelegate CR_RequestDestroyRoundFinishOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyNeedSyncOKDelegate CR_RequestDestroyNeedSyncOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyIngameFinishOKDelegate CR_RequestDestroyIngameFinishOK = (HostID remote, RmiContext rmiContext, List<int> stageIdList) => false;

        public Stub.CR_RequestDestroyExitOKDelegate CR_RequestDestroyExitOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestDestroyTestExitOKDelegate CR_RequestDestroyTestExitOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestGuildLoginOKDelegate CR_RequestGuildLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestGuildRoomJoinOKDelegate CR_RequestGuildRoomJoinOK = (HostID remote, RmiContext rmiContext, List<GuildRoomMemberInfo> guildRoomMemberInfo, List<GuildRoomMemberPointInfo> guildRoomMemberPointInfoList) => false;

        public Stub.CR_RequestGuildRoomOutOKDelegate CR_RequestGuildRoomOutOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestGuildRoomMemberInfoOKDelegate CR_RequestGuildRoomMemberInfoOK = (HostID remote, RmiContext rmiContext, List<GuildRoomMemberInfo> guildRoomMemberInfo, List<GuildRoomMemberPointInfo> guildRoomMemberPointInfoList) => false;

        public Stub.CR_RequestGuildRoomSyncOKDelegate CR_RequestGuildRoomSyncOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestGuildRoomMemberInfoSyncOKDelegate CR_RequestGuildRoomMemberInfoSyncOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestGuildRoomKickOutMemberOKDelegate CR_RequestGuildRoomKickOutMemberOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestGuildRoomLeaveMemberOKDelegate CR_RequestGuildRoomLeaveMemberOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyGuildNewMemberOKDelegate RC_NotifyGuildNewMemberOK = (HostID remote, RmiContext rmiContext, GuildRoomMemberInfo newMemberInfo) => false;

        public Stub.RC_NotifyGuildLeaveMemberOKDelegate RC_NotifyGuildLeaveMemberOK = (HostID remote, RmiContext rmiContext, long otherUSN) => false;

        public Stub.RC_NotifyGuildRoomOtherPlayerJoinOKDelegate RC_NotifyGuildRoomOtherPlayerJoinOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo guildMemberInfo, GuildRoomMemberPointInfo guildRoomMemberPointInfo) => false;

        public Stub.RC_NotifyGuildRoomOtherPlayerOutOKDelegate RC_NotifyGuildRoomOtherPlayerOutOK = (HostID remote, RmiContext rmiContext, long otherUSN) => false;

        public Stub.RC_NotifyGuildRoomOtherPlayerSyncOKDelegate RC_NotifyGuildRoomOtherPlayerSyncOK = (HostID remote, RmiContext rmiContext, List<GuildRoomMoveInfo> guildRoomMoveInfoList) => false;

        public Stub.RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOKDelegate RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK = (HostID remote, RmiContext rmiContext, GuildRoomMemberInfo guildRoomMemberInfo) => false;

        public Stub.RC_NotifyGuildRoomOtherPlayerKickOutMemberOKDelegate RC_NotifyGuildRoomOtherPlayerKickOutMemberOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo kickOutGuildMemberInfo) => false;

        public Stub.RC_NotifyGuildRoomOtherPlayerLeaveMemberOKDelegate RC_NotifyGuildRoomOtherPlayerLeaveMemberOK = (HostID remote, RmiContext rmiContext, long leaveUSN) => false;

        public Stub.CR_RequestFriendlyMatchLoginOKDelegate CR_RequestFriendlyMatchLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchLobbySyncOKDelegate CR_RequestFriendlyMatchLobbySyncOK = (HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo otherUserSyncInfo) => false;

        public Stub.CR_RequestFriendlyMatchReadyOKDelegate CR_RequestFriendlyMatchReadyOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchReadyOffOKDelegate CR_RequestFriendlyMatchReadyOffOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchChangeTeamOKDelegate CR_RequestFriendlyMatchChangeTeamOK = (HostID remote, RmiContext rmiContext, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.CR_RequestFriendlyMatchTeamInfoOKDelegate CR_RequestFriendlyMatchTeamInfoOK = (HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.CR_RequestFriendlyMatchChangeMatchModeOKDelegate CR_RequestFriendlyMatchChangeMatchModeOK = (HostID remote, RmiContext rmiContext, byte matchMode, byte modeID) => false;

        public Stub.CR_RequestFriendlyMatchKickOutOKDelegate CR_RequestFriendlyMatchKickOutOK = (HostID remote, RmiContext rmiContext, long kickUSN) => false;

        public Stub.CR_RequestFriendlyMatchStartOKDelegate CR_RequestFriendlyMatchStartOK = (HostID remote, RmiContext rmiContext, FriendlyMatchStartResult startResult) => false;

        public Stub.CR_RequestFriendlyMatchSyncOKDelegate CR_RequestFriendlyMatchSyncOK = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.CR_RequestFriendlyMatchExitOKDelegate CR_RequestFriendlyMatchExitOK = (HostID remote, RmiContext rmiContext, long targetUsn) => false;

        public Stub.CR_RequestFriendlyMatchChatEnterOKDelegate CR_RequestFriendlyMatchChatEnterOK = (HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage) => false;

        public Stub.RC_NotifyFriendlyMatchJoinDelegate RC_NotifyFriendlyMatchJoin = (HostID remote, RmiContext rmiContext, FriendlyMatchUserProfileInfo fmProfileInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo, bool readyStatus, byte matchMode, byte modeID, byte userMode) => false;

        public Stub.RC_NotifyFriendlyMatchLobbySyncDelegate RC_NotifyFriendlyMatchLobbySync = (HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo syncInfo) => false;

        public Stub.RC_NotifyFriendlyMatchUserReadyDelegate RC_NotifyFriendlyMatchUserReady = (HostID remote, RmiContext rmiContext, long usn) => false;

        public Stub.RC_NotifyFriendlyMatchUserReadyOffDelegate RC_NotifyFriendlyMatchUserReadyOff = (HostID remote, RmiContext rmiContext, long usn) => false;

        public Stub.RC_NotifyFriendlyMatchUserChangeTeamDelegate RC_NotifyFriendlyMatchUserChangeTeam = (HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.RC_NotifyFriendlyMatchKickedOutDelegate RC_NotifyFriendlyMatchKickedOut = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyFriendlyMatchUserGameStartDelegate RC_NotifyFriendlyMatchUserGameStart = (HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo, FriendlyMatchStartResult startResult) => false;

        public Stub.RC_NotifyFriendlyMatchSyncDelegate RC_NotifyFriendlyMatchSync = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.RC_NotifyFriendlyMatchChatEnterDelegate RC_NotifyFriendlyMatchChatEnter = (HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage) => false;

        public Stub.RC_NotifyFriendlyMatchExitDelegate RC_NotifyFriendlyMatchExit = (HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner) => false;

        public Stub.RC_NotifyFriendlyMatchInGameExitDelegate RC_NotifyFriendlyMatchInGameExit = (HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner) => false;

        public Stub.RC_NotifyFriendlyMatchChangeMatchModeDelegate RC_NotifyFriendlyMatchChangeMatchMode = (HostID remote, RmiContext rmiContext, byte matchMode, byte modeID) => false;

        public Stub.RC_NotifyFriendlyMatchChangeModeIDDelegate RC_NotifyFriendlyMatchChangeModeID = (HostID remote, RmiContext rmiContext, byte modeID) => false;

        public Stub.CR_RequestFriendlyMatchReadyTimeOverOKDelegate CR_RequestFriendlyMatchReadyTimeOverOK = (HostID remote, RmiContext rmiContext, bool isSuccess) => false;

        public Stub.CR_RequestFriendlyMatchInGameReadyOKDelegate CR_RequestFriendlyMatchInGameReadyOK = (HostID remote, RmiContext rmiContext, bool timeOver) => false;

        public Stub.CR_RequestFriendlyMatchFightOKDelegate CR_RequestFriendlyMatchFightOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchInGameExitOKDelegate CR_RequestFriendlyMatchInGameExitOK = (HostID remote, RmiContext rmiContext, long targetUSN) => false;

        public Stub.CR_RequestFriendlyMatchChangeUserModeOKDelegate CR_RequestFriendlyMatchChangeUserModeOK = (HostID remote, RmiContext rmiContext, long targetUSN, byte userMode) => false;

        public Stub.RC_NotifyFriendlyMatchChangeUserModeDelegate RC_NotifyFriendlyMatchChangeUserMode = (HostID remote, RmiContext rmiContext, long targetUSN, byte userMode) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerLoginOKDelegate CR_RequestArenaRealTimePVPLowerLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerJoinOKDelegate CR_RequestArenaRealTimePVPLowerJoinOK = (HostID remote, RmiContext rmiContext, UserProfileInfo userInfo) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerExitOKDelegate CR_RequestArenaRealTimePVPLowerExitOK = (HostID remote, RmiContext rmiContext, long targetUsn, bool giveup) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerReadyOKDelegate CR_RequestArenaRealTimePVPLowerReadyOK = (HostID remote, RmiContext rmiContext, bool timeOver) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerFightOKDelegate CR_RequestArenaRealTimePVPLowerFightOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerSyncOKDelegate CR_RequestArenaRealTimePVPLowerSyncOK = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerReadyTimeOverOKDelegate CR_RequestArenaRealTimePVPLowerReadyTimeOverOK = (HostID remote, RmiContext rmiContext, bool bSucess) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerChatEnterOKDelegate CR_RequestArenaRealTimePVPLowerChatEnterOK = (HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message) => false;

        public Stub.CR_RequestArenaRealTimePVPLowerJoinTimeOverOKDelegate CR_RequestArenaRealTimePVPLowerJoinTimeOverOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRankingConnectOKDelegate CR_RequestArenaRankingConnectOK = (HostID remote, RmiContext rmiContext, bool connectResult) => false;

        public Stub.CR_RequestArenaRankingLoginOKDelegate CR_RequestArenaRankingLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRankingJoinOKDelegate CR_RequestArenaRankingJoinOK = (HostID remote, RmiContext rmiContext, UserProfileInfo userInfo) => false;

        public Stub.CR_RequestArenaRankingExitOKDelegate CR_RequestArenaRankingExitOK = (HostID remote, RmiContext rmiContext, long targetUsn, bool giveup) => false;

        public Stub.CR_RequestArenaRankingReadyOKDelegate CR_RequestArenaRankingReadyOK = (HostID remote, RmiContext rmiContext, bool timeOver) => false;

        public Stub.CR_RequestArenaRankingFightOKDelegate CR_RequestArenaRankingFightOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRankingSyncOKDelegate CR_RequestArenaRankingSyncOK = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.CR_RequestArenaRankingReadyTimeOverOKDelegate CR_RequestArenaRankingReadyTimeOverOK = (HostID remote, RmiContext rmiContext, bool bSucess) => false;

        public Stub.CR_RequestArenaRankingChatEnterOKDelegate CR_RequestArenaRankingChatEnterOK = (HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message) => false;

        public Stub.CR_RequestArenaRankingJoinTimeOverOKDelegate CR_RequestArenaRankingJoinTimeOverOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestTournamentMatchLoginOKDelegate CR_RequestTournamentMatchLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestTournamentMatchChangeTeamOKDelegate CR_RequestTournamentMatchChangeTeamOK = (HostID remote, RmiContext rmiContext, List<byte> teamSlotIndexList) => false;

        public Stub.CR_RequestTournamentMatchReadyOKDelegate CR_RequestTournamentMatchReadyOK = (HostID remote, RmiContext rmiContext, bool readyStatus) => false;

        public Stub.CR_RequestTournamentMatchInGameReadyOKDelegate CR_RequestTournamentMatchInGameReadyOK = (HostID remote, RmiContext rmiContext, bool timeOver) => false;

        public Stub.CR_RequestTournamentMatchInGameTimeOverOKDelegate CR_RequestTournamentMatchInGameTimeOverOK = (HostID remote, RmiContext rmiContext, bool isSuccess) => false;

        public Stub.CR_RequestTournamentMatchInGameSyncOKDelegate CR_RequestTournamentMatchInGameSyncOK = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.CR_RequestTournamentMatchInGameGiveupOKDelegate CR_RequestTournamentMatchInGameGiveupOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestTournamentMatchInGameExitOKDelegate CR_RequestTournamentMatchInGameExitOK = (HostID remote, RmiContext rmiContext, TournamentMatchInfo matchInfo) => false;

        public Stub.CR_RequestTournamentMatchChatEnterOKDelegate CR_RequestTournamentMatchChatEnterOK = (HostID remote, RmiContext rmiContext, int stampID, string message) => false;

        public Stub.CR_RequestTournamentMatchExitOKDelegate CR_RequestTournamentMatchExitOK = (HostID remote, RmiContext rmiContext, bool isSuspend) => false;

        public Stub.CR_RequestTournamentWatcherLoginOKDelegate CR_RequestTournamentWatcherLoginOK = (HostID remote, RmiContext rmiContext, TournamentWatcherLoginResult loginResult) => false;

        public Stub.CR_RequestTournamentWatcherExitOKDelegate CR_RequestTournamentWatcherExitOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestTournamentMatchReplayStartOKDelegate CR_RequestTournamentMatchReplayStartOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestTournamentMatchInGameClearOKDelegate CR_RequestTournamentMatchInGameClearOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyTournamentMatchJoinDelegate RC_NotifyTournamentMatchJoin = (HostID remote, RmiContext rmiContext, TournamentMatchUserProfileInfo otherProfileInfo, OtherPlayerSimpleTeamInfo otherTeamInfo, bool otherReadyStatus) => false;

        public Stub.RC_NotifyTournamentMatchChangeTeamDelegate RC_NotifyTournamentMatchChangeTeam = (HostID remote, RmiContext rmiContext, long otherUSN, List<byte> teamSlotIndexList) => false;

        public Stub.RC_NotifyTournamentMatchReadyDelegate RC_NotifyTournamentMatchReady = (HostID remote, RmiContext rmiContext, long otherUSN, bool readyStatus) => false;

        public Stub.RC_NotifyTournamentMatchStartDelegate RC_NotifyTournamentMatchStart = (HostID remote, RmiContext rmiContext, TournamentMatchStartResult startResult) => false;

        public Stub.RC_NotifyTournamentMatchInGameFightDelegate RC_NotifyTournamentMatchInGameFight = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyTournamentMatchInGameSyncDelegate RC_NotifyTournamentMatchInGameSync = (HostID remote, RmiContext rmiContext, long sendUSN, byte currentPlayIndex, string strSync, string replaySync) => false;

        public Stub.RC_NotifyTournamentMatchInGameGiveupDelegate RC_NotifyTournamentMatchInGameGiveup = (HostID remote, RmiContext rmiContext, long giveupUSN) => false;

        public Stub.RC_NotifyTournamentMatchInGameExitDelegate RC_NotifyTournamentMatchInGameExit = (HostID remote, RmiContext rmiContext, long leaveUSN, TournamentMatchInfo matchInfo) => false;

        public Stub.RC_NotifyTournamentMatchChatEnterDelegate RC_NotifyTournamentMatchChatEnter = (HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message) => false;

        public Stub.RC_NotifyTournamentMatchExitDelegate RC_NotifyTournamentMatchExit = (HostID remote, RmiContext rmiContext, long leaveUSN, TournamentMatchInfo matchInfo) => false;

        public Stub.RC_NotifyTournamentWatcherStartDelegate RC_NotifyTournamentWatcherStart = (HostID remote, RmiContext rmiContext, byte currentPlayIndex, ReplayBytesInfo replayBytesInfo) => false;

        public Stub.CR_RequestSubdueLoginOKDelegate CR_RequestSubdueLoginOK = (HostID remote, RmiContext rmiContext, int position, List<BossWarUserProfileInfo> memberProfileList) => false;

        public Stub.CR_RequestSubdueReLoginOKDelegate CR_RequestSubdueReLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestSubdueReadyOKDelegate CR_RequestSubdueReadyOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestSubdueReturnReadyOKDelegate CR_RequestSubdueReturnReadyOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestSubdueLeaveOKDelegate CR_RequestSubdueLeaveOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestSubdueKickoutOKDelegate CR_RequestSubdueKickoutOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestSubdueGameStartOKDelegate CR_RequestSubdueGameStartOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestSubdueBattleSyncOKDelegate CR_RequestSubdueBattleSyncOK = (HostID remote, RmiContext rmiContext, SubdueBossBattleSyncResult battleSyncResult) => false;

        public Stub.CR_RequestSubdueBattleEndOKDelegate CR_RequestSubdueBattleEndOK = (HostID remote, RmiContext rmiContext, bool isWait) => false;

        public Stub.CR_NotifySubdueSyncOKDelegate CR_NotifySubdueSyncOK = (HostID remote, RmiContext rmiContext, long usn, BossWarNotifyType notifyType, long notifyValue1, long notifyValue2) => false;

        public Stub.CR_NotifySubdueMemberJoinUpdateOKDelegate CR_NotifySubdueMemberJoinUpdateOK = (HostID remote, RmiContext rmiContext, BossWarUserProfileInfo joinMemberProfile) => false;

        public Stub.CR_NotifySubdueGameStartOKDelegate CR_NotifySubdueGameStartOK = (HostID remote, RmiContext rmiContext, BossWarStartResult startResult) => false;

        public Stub.CR_NotifySubdueLoadingCompleteOKDelegate CR_NotifySubdueLoadingCompleteOK = (HostID remote, RmiContext rmiContext, int remainSeconds, bool loadingSuccess) => false;

        public Stub.CR_NotifySubdueRewardAggregationOKDelegate CR_NotifySubdueRewardAggregationOK = (HostID remote, RmiContext rmiContext, bool isRecvRewardOK) => false;

        public Stub.CR_RequestFriendlyMatchObserveLoginOKDelegate CR_RequestFriendlyMatchObserveLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchObserveLobbySyncOKDelegate CR_RequestFriendlyMatchObserveLobbySyncOK = (HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo otherUserSyncInfo, int syncBattlePoint) => false;

        public Stub.CR_RequestFriendlyMatchObserveReadyOKDelegate CR_RequestFriendlyMatchObserveReadyOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchObserveReadyOffOKDelegate CR_RequestFriendlyMatchObserveReadyOffOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchObserveChangeTeamOKDelegate CR_RequestFriendlyMatchObserveChangeTeamOK = (HostID remote, RmiContext rmiContext, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.CR_RequestFriendlyMatchObserveTeamInfoOKDelegate CR_RequestFriendlyMatchObserveTeamInfoOK = (HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.CR_RequestFriendlyMatchObserveChangeMatchModeOKDelegate CR_RequestFriendlyMatchObserveChangeMatchModeOK = (HostID remote, RmiContext rmiContext, byte matchMode, byte modeID, byte passiveID) => false;

        public Stub.CR_RequestFriendlyMatchObserveKickOutOKDelegate CR_RequestFriendlyMatchObserveKickOutOK = (HostID remote, RmiContext rmiContext, long kickUSN) => false;

        public Stub.CR_RequestFriendlyMatchObserveStartOKDelegate CR_RequestFriendlyMatchObserveStartOK = (HostID remote, RmiContext rmiContext, FriendlyMatchStartResult startResult) => false;

        public Stub.CR_RequestFriendlyMatchObserveSyncOKDelegate CR_RequestFriendlyMatchObserveSyncOK = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.CR_RequestFriendlyMatchObserveExitOKDelegate CR_RequestFriendlyMatchObserveExitOK = (HostID remote, RmiContext rmiContext, long targetUsn) => false;

        public Stub.CR_RequestFriendlyMatchObserveChatEnterOKDelegate CR_RequestFriendlyMatchObserveChatEnterOK = (HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage) => false;

        public Stub.RC_NotifyFriendlyMatchObserveJoinDelegate RC_NotifyFriendlyMatchObserveJoin = (HostID remote, RmiContext rmiContext, FriendlyMatchUserProfileInfo fmProfileInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo, bool readyStatus, byte matchMode, byte modeID, byte passiveID, byte userMode, bool isRoomOwner) => false;

        public Stub.RC_NotifyFriendlyMatchObserveLobbySyncDelegate RC_NotifyFriendlyMatchObserveLobbySync = (HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo syncInfo, int syncBattlePoint) => false;

        public Stub.RC_NotifyFriendlyMatchObserveUserReadyDelegate RC_NotifyFriendlyMatchObserveUserReady = (HostID remote, RmiContext rmiContext, long usn) => false;

        public Stub.RC_NotifyFriendlyMatchObserveUserReadyOffDelegate RC_NotifyFriendlyMatchObserveUserReadyOff = (HostID remote, RmiContext rmiContext, long usn) => false;

        public Stub.RC_NotifyFriendlyMatchObserveUserChangeTeamDelegate RC_NotifyFriendlyMatchObserveUserChangeTeam = (HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo) => false;

        public Stub.RC_NotifyFriendlyMatchObserveKickedOutDelegate RC_NotifyFriendlyMatchObserveKickedOut = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyFriendlyMatchObserveUserGameStartDelegate RC_NotifyFriendlyMatchObserveUserGameStart = (HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo, List<FriendlyMatchObserveStartResult> startResultList) => false;

        public Stub.RC_NotifyFriendlyMatchObserveSyncDelegate RC_NotifyFriendlyMatchObserveSync = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync, string replaySync) => false;

        public Stub.RC_NotifyFriendlyMatchObserveChatEnterDelegate RC_NotifyFriendlyMatchObserveChatEnter = (HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage) => false;

        public Stub.RC_NotifyFriendlyMatchObserveExitDelegate RC_NotifyFriendlyMatchObserveExit = (HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner) => false;

        public Stub.RC_NotifyFriendlyMatchObserveInGameExitDelegate RC_NotifyFriendlyMatchObserveInGameExit = (HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner) => false;

        public Stub.RC_NotifyFriendlyMatchObserveChangeMatchModeDelegate RC_NotifyFriendlyMatchObserveChangeMatchMode = (HostID remote, RmiContext rmiContext, byte matchMode, byte modeID, byte passiveID) => false;

        public Stub.RC_NotifyFriendlyMatchObserveChangeModeIDDelegate RC_NotifyFriendlyMatchObserveChangeModeID = (HostID remote, RmiContext rmiContext, byte modeID, byte passiveID) => false;

        public Stub.CR_RequestFriendlyMatchObserveReadyTimeOverOKDelegate CR_RequestFriendlyMatchObserveReadyTimeOverOK = (HostID remote, RmiContext rmiContext, bool isSuccess) => false;

        public Stub.CR_RequestFriendlyMatchObserveInGameReadyOKDelegate CR_RequestFriendlyMatchObserveInGameReadyOK = (HostID remote, RmiContext rmiContext, bool timeOver) => false;

        public Stub.CR_RequestFriendlyMatchObserveFightOKDelegate CR_RequestFriendlyMatchObserveFightOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchObserveInGameExitOKDelegate CR_RequestFriendlyMatchObserveInGameExitOK = (HostID remote, RmiContext rmiContext, long targetUSN) => false;

        public Stub.CR_RequestFriendlyMatchObserveChangeUserModeOKDelegate CR_RequestFriendlyMatchObserveChangeUserModeOK = (HostID remote, RmiContext rmiContext, long targetUSN, byte userMode) => false;

        public Stub.RC_NotifyFriendlyMatchObserveChangeUserModeDelegate RC_NotifyFriendlyMatchObserveChangeUserMode = (HostID remote, RmiContext rmiContext, long targetUSN, byte userMode) => false;

        public Stub.CR_RequestFriendlyMatchObserveReplayStartOKDelegate CR_RequestFriendlyMatchObserveReplayStartOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyFriendlyMatchObserveWatcherStartDelegate RC_NotifyFriendlyMatchObserveWatcherStart = (HostID remote, RmiContext rmiContext, ReplayBytesInfo replayBytesInfo) => false;

        public Stub.CR_RequestFriendlyMatchObserveUserStatusOKDelegate CR_RequestFriendlyMatchObserveUserStatusOK = (HostID remote, RmiContext rmiContext, FriendlyMatchUserStatusInfo userStatusInfo) => false;

        public Stub.RC_NotifyFriendlyMatchObserveUserStatusDelegate RC_NotifyFriendlyMatchObserveUserStatus = (HostID remote, RmiContext rmiContext, FriendlyMatchUserStatusInfo userStatusInfo) => false;

        public Stub.CR_RequestFriendlyMatchObserveLobbyHeartBeatOKDelegate CR_RequestFriendlyMatchObserveLobbyHeartBeatOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchObserveReadyOffAllOKDelegate CR_RequestFriendlyMatchObserveReadyOffAllOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchObserveInGameClearOKDelegate CR_RequestFriendlyMatchObserveInGameClearOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.RC_NotifyFriendlyMatchObserveInGameClearDelegate RC_NotifyFriendlyMatchObserveInGameClear = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestFriendlyMatchObserveInGameHeartBeatOKDelegate CR_RequestFriendlyMatchObserveInGameHeartBeatOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitLoginOKDelegate CR_RequestArenaRealTimePVPLimitLoginOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitJoinOKDelegate CR_RequestArenaRealTimePVPLimitJoinOK = (HostID remote, RmiContext rmiContext, UserProfileInfo userInfo) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitExitOKDelegate CR_RequestArenaRealTimePVPLimitExitOK = (HostID remote, RmiContext rmiContext, long targetUsn, bool giveup) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitReadyOKDelegate CR_RequestArenaRealTimePVPLimitReadyOK = (HostID remote, RmiContext rmiContext, bool timeOver) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitFightOKDelegate CR_RequestArenaRealTimePVPLimitFightOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitSyncOKDelegate CR_RequestArenaRealTimePVPLimitSyncOK = (HostID remote, RmiContext rmiContext, long sendUSN, string strSync) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitReadyTimeOverOKDelegate CR_RequestArenaRealTimePVPLimitReadyTimeOverOK = (HostID remote, RmiContext rmiContext, bool bSucess) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitChatEnterOKDelegate CR_RequestArenaRealTimePVPLimitChatEnterOK = (HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message) => false;

        public Stub.CR_RequestArenaRealTimePVPLimitJoinTimeOverOKDelegate CR_RequestArenaRealTimePVPLimitJoinTimeOverOK = (HostID remote, RmiContext rmiContext) => false;

        public const string RmiName_CR_CommonCancel = "CR_CommonCancel";

        public const string RmiName_CR_RequestForceLogoutOK = "CR_RequestForceLogoutOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLoginOK = "CR_RequestArenaRealTimePVPLoginOK";

        public const string RmiName_CR_RequestArenaRealTimePVPJoinOK = "CR_RequestArenaRealTimePVPJoinOK";

        public const string RmiName_CR_RequestArenaRealTimePVPExitOK = "CR_RequestArenaRealTimePVPExitOK";

        public const string RmiName_CR_RequestArenaRealTimePVPReadyOK = "CR_RequestArenaRealTimePVPReadyOK";

        public const string RmiName_CR_RequestArenaRealTimePVPFightOK = "CR_RequestArenaRealTimePVPFightOK";

        public const string RmiName_CR_RequestArenaRealTimePVPSyncOK = "CR_RequestArenaRealTimePVPSyncOK";

        public const string RmiName_CR_RequestArenaRealTimePVPReadyTimeOverOK = "CR_RequestArenaRealTimePVPReadyTimeOverOK";

        public const string RmiName_CR_RequestArenaRealTimePVPChatEnterOK = "CR_RequestArenaRealTimePVPChatEnterOK";

        public const string RmiName_CR_RequestArenaRealTimePVPJoinTimeOverOK = "CR_RequestArenaRealTimePVPJoinTimeOverOK";

        public const string RmiName_RC_NotifyDestroyUserJoin = "RC_NotifyDestroyUserJoin";

        public const string RmiName_RC_NotifyDestroyUserStateChanged = "RC_NotifyDestroyUserStateChanged";

        public const string RmiName_RC_NotifyDestroyUserExit = "RC_NotifyDestroyUserExit";

        public const string RmiName_RC_NotifyDestroyGameStart = "RC_NotifyDestroyGameStart";

        public const string RmiName_RC_NotifyDestroyIngameStart = "RC_NotifyDestroyIngameStart";

        public const string RmiName_RC_NotifyDestroySync = "RC_NotifyDestroySync";

        public const string RmiName_RC_NotifyDestroyGameEnd = "RC_NotifyDestroyGameEnd";

        public const string RmiName_RC_NotifyDestroySelectSkillCard = "RC_NotifyDestroySelectSkillCard";

        public const string RmiName_RC_NotifyDestroyRoundFinish = "RC_NotifyDestroyRoundFinish";

        public const string RmiName_RC_NotifyDestroyChatEnter = "RC_NotifyDestroyChatEnter";

        public const string RmiName_RC_RequestDestroyNeedSync = "RC_RequestDestroyNeedSync";

        public const string RmiName_CR_RequestDestroyLoginOK = "CR_RequestDestroyLoginOK";

        public const string RmiName_CR_RequestDestroyReLoginOK = "CR_RequestDestroyReLoginOK";

        public const string RmiName_CR_RequestDestroyRelayReadyOK = "CR_RequestDestroyRelayReadyOK";

        public const string RmiName_CR_RequestDestroyLobbySyncOK = "CR_RequestDestroyLobbySyncOK";

        public const string RmiName_CR_RequestDestroyChatEnterOK = "CR_RequestDestroyChatEnterOK";

        public const string RmiName_CR_RequestDestroyReadyOK = "CR_RequestDestroyReadyOK";

        public const string RmiName_CR_RequestDestroyReturnReadyOK = "CR_RequestDestroyReturnReadyOK";

        public const string RmiName_CR_RequestDestroyKickOutOK = "CR_RequestDestroyKickOutOK";

        public const string RmiName_CR_RequestDestroyChangeTeamInfoOK = "CR_RequestDestroyChangeTeamInfoOK";

        public const string RmiName_CR_RequestDestroyMemberTeamInfoOK = "CR_RequestDestroyMemberTeamInfoOK";

        public const string RmiName_CR_RequestDestroyIngameReadyOK = "CR_RequestDestroyIngameReadyOK";

        public const string RmiName_CR_RequestDestroyRoundFinishOK = "CR_RequestDestroyRoundFinishOK";

        public const string RmiName_CR_RequestDestroyNeedSyncOK = "CR_RequestDestroyNeedSyncOK";

        public const string RmiName_CR_RequestDestroyIngameFinishOK = "CR_RequestDestroyIngameFinishOK";

        public const string RmiName_CR_RequestDestroyExitOK = "CR_RequestDestroyExitOK";

        public const string RmiName_CR_RequestDestroyTestExitOK = "CR_RequestDestroyTestExitOK";

        public const string RmiName_CR_RequestGuildLoginOK = "CR_RequestGuildLoginOK";

        public const string RmiName_CR_RequestGuildRoomJoinOK = "CR_RequestGuildRoomJoinOK";

        public const string RmiName_CR_RequestGuildRoomOutOK = "CR_RequestGuildRoomOutOK";

        public const string RmiName_CR_RequestGuildRoomMemberInfoOK = "CR_RequestGuildRoomMemberInfoOK";

        public const string RmiName_CR_RequestGuildRoomSyncOK = "CR_RequestGuildRoomSyncOK";

        public const string RmiName_CR_RequestGuildRoomMemberInfoSyncOK = "CR_RequestGuildRoomMemberInfoSyncOK";

        public const string RmiName_CR_RequestGuildRoomKickOutMemberOK = "CR_RequestGuildRoomKickOutMemberOK";

        public const string RmiName_CR_RequestGuildRoomLeaveMemberOK = "CR_RequestGuildRoomLeaveMemberOK";

        public const string RmiName_RC_NotifyGuildNewMemberOK = "RC_NotifyGuildNewMemberOK";

        public const string RmiName_RC_NotifyGuildLeaveMemberOK = "RC_NotifyGuildLeaveMemberOK";

        public const string RmiName_RC_NotifyGuildRoomOtherPlayerJoinOK = "RC_NotifyGuildRoomOtherPlayerJoinOK";

        public const string RmiName_RC_NotifyGuildRoomOtherPlayerOutOK = "RC_NotifyGuildRoomOtherPlayerOutOK";

        public const string RmiName_RC_NotifyGuildRoomOtherPlayerSyncOK = "RC_NotifyGuildRoomOtherPlayerSyncOK";

        public const string RmiName_RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK = "RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOK";

        public const string RmiName_RC_NotifyGuildRoomOtherPlayerKickOutMemberOK = "RC_NotifyGuildRoomOtherPlayerKickOutMemberOK";

        public const string RmiName_RC_NotifyGuildRoomOtherPlayerLeaveMemberOK = "RC_NotifyGuildRoomOtherPlayerLeaveMemberOK";

        public const string RmiName_CR_RequestFriendlyMatchLoginOK = "CR_RequestFriendlyMatchLoginOK";

        public const string RmiName_CR_RequestFriendlyMatchLobbySyncOK = "CR_RequestFriendlyMatchLobbySyncOK";

        public const string RmiName_CR_RequestFriendlyMatchReadyOK = "CR_RequestFriendlyMatchReadyOK";

        public const string RmiName_CR_RequestFriendlyMatchReadyOffOK = "CR_RequestFriendlyMatchReadyOffOK";

        public const string RmiName_CR_RequestFriendlyMatchChangeTeamOK = "CR_RequestFriendlyMatchChangeTeamOK";

        public const string RmiName_CR_RequestFriendlyMatchTeamInfoOK = "CR_RequestFriendlyMatchTeamInfoOK";

        public const string RmiName_CR_RequestFriendlyMatchChangeMatchModeOK = "CR_RequestFriendlyMatchChangeMatchModeOK";

        public const string RmiName_CR_RequestFriendlyMatchKickOutOK = "CR_RequestFriendlyMatchKickOutOK";

        public const string RmiName_CR_RequestFriendlyMatchStartOK = "CR_RequestFriendlyMatchStartOK";

        public const string RmiName_CR_RequestFriendlyMatchSyncOK = "CR_RequestFriendlyMatchSyncOK";

        public const string RmiName_CR_RequestFriendlyMatchExitOK = "CR_RequestFriendlyMatchExitOK";

        public const string RmiName_CR_RequestFriendlyMatchChatEnterOK = "CR_RequestFriendlyMatchChatEnterOK";

        public const string RmiName_RC_NotifyFriendlyMatchJoin = "RC_NotifyFriendlyMatchJoin";

        public const string RmiName_RC_NotifyFriendlyMatchLobbySync = "RC_NotifyFriendlyMatchLobbySync";

        public const string RmiName_RC_NotifyFriendlyMatchUserReady = "RC_NotifyFriendlyMatchUserReady";

        public const string RmiName_RC_NotifyFriendlyMatchUserReadyOff = "RC_NotifyFriendlyMatchUserReadyOff";

        public const string RmiName_RC_NotifyFriendlyMatchUserChangeTeam = "RC_NotifyFriendlyMatchUserChangeTeam";

        public const string RmiName_RC_NotifyFriendlyMatchKickedOut = "RC_NotifyFriendlyMatchKickedOut";

        public const string RmiName_RC_NotifyFriendlyMatchUserGameStart = "RC_NotifyFriendlyMatchUserGameStart";

        public const string RmiName_RC_NotifyFriendlyMatchSync = "RC_NotifyFriendlyMatchSync";

        public const string RmiName_RC_NotifyFriendlyMatchChatEnter = "RC_NotifyFriendlyMatchChatEnter";

        public const string RmiName_RC_NotifyFriendlyMatchExit = "RC_NotifyFriendlyMatchExit";

        public const string RmiName_RC_NotifyFriendlyMatchInGameExit = "RC_NotifyFriendlyMatchInGameExit";

        public const string RmiName_RC_NotifyFriendlyMatchChangeMatchMode = "RC_NotifyFriendlyMatchChangeMatchMode";

        public const string RmiName_RC_NotifyFriendlyMatchChangeModeID = "RC_NotifyFriendlyMatchChangeModeID";

        public const string RmiName_CR_RequestFriendlyMatchReadyTimeOverOK = "CR_RequestFriendlyMatchReadyTimeOverOK";

        public const string RmiName_CR_RequestFriendlyMatchInGameReadyOK = "CR_RequestFriendlyMatchInGameReadyOK";

        public const string RmiName_CR_RequestFriendlyMatchFightOK = "CR_RequestFriendlyMatchFightOK";

        public const string RmiName_CR_RequestFriendlyMatchInGameExitOK = "CR_RequestFriendlyMatchInGameExitOK";

        public const string RmiName_CR_RequestFriendlyMatchChangeUserModeOK = "CR_RequestFriendlyMatchChangeUserModeOK";

        public const string RmiName_RC_NotifyFriendlyMatchChangeUserMode = "RC_NotifyFriendlyMatchChangeUserMode";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerLoginOK = "CR_RequestArenaRealTimePVPLowerLoginOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerJoinOK = "CR_RequestArenaRealTimePVPLowerJoinOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerExitOK = "CR_RequestArenaRealTimePVPLowerExitOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerReadyOK = "CR_RequestArenaRealTimePVPLowerReadyOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerFightOK = "CR_RequestArenaRealTimePVPLowerFightOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerSyncOK = "CR_RequestArenaRealTimePVPLowerSyncOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerReadyTimeOverOK = "CR_RequestArenaRealTimePVPLowerReadyTimeOverOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerChatEnterOK = "CR_RequestArenaRealTimePVPLowerChatEnterOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerJoinTimeOverOK = "CR_RequestArenaRealTimePVPLowerJoinTimeOverOK";

        public const string RmiName_CR_RequestArenaRankingConnectOK = "CR_RequestArenaRankingConnectOK";

        public const string RmiName_CR_RequestArenaRankingLoginOK = "CR_RequestArenaRankingLoginOK";

        public const string RmiName_CR_RequestArenaRankingJoinOK = "CR_RequestArenaRankingJoinOK";

        public const string RmiName_CR_RequestArenaRankingExitOK = "CR_RequestArenaRankingExitOK";

        public const string RmiName_CR_RequestArenaRankingReadyOK = "CR_RequestArenaRankingReadyOK";

        public const string RmiName_CR_RequestArenaRankingFightOK = "CR_RequestArenaRankingFightOK";

        public const string RmiName_CR_RequestArenaRankingSyncOK = "CR_RequestArenaRankingSyncOK";

        public const string RmiName_CR_RequestArenaRankingReadyTimeOverOK = "CR_RequestArenaRankingReadyTimeOverOK";

        public const string RmiName_CR_RequestArenaRankingChatEnterOK = "CR_RequestArenaRankingChatEnterOK";

        public const string RmiName_CR_RequestArenaRankingJoinTimeOverOK = "CR_RequestArenaRankingJoinTimeOverOK";

        public const string RmiName_CR_RequestTournamentMatchLoginOK = "CR_RequestTournamentMatchLoginOK";

        public const string RmiName_CR_RequestTournamentMatchChangeTeamOK = "CR_RequestTournamentMatchChangeTeamOK";

        public const string RmiName_CR_RequestTournamentMatchReadyOK = "CR_RequestTournamentMatchReadyOK";

        public const string RmiName_CR_RequestTournamentMatchInGameReadyOK = "CR_RequestTournamentMatchInGameReadyOK";

        public const string RmiName_CR_RequestTournamentMatchInGameTimeOverOK = "CR_RequestTournamentMatchInGameTimeOverOK";

        public const string RmiName_CR_RequestTournamentMatchInGameSyncOK = "CR_RequestTournamentMatchInGameSyncOK";

        public const string RmiName_CR_RequestTournamentMatchInGameGiveupOK = "CR_RequestTournamentMatchInGameGiveupOK";

        public const string RmiName_CR_RequestTournamentMatchInGameExitOK = "CR_RequestTournamentMatchInGameExitOK";

        public const string RmiName_CR_RequestTournamentMatchChatEnterOK = "CR_RequestTournamentMatchChatEnterOK";

        public const string RmiName_CR_RequestTournamentMatchExitOK = "CR_RequestTournamentMatchExitOK";

        public const string RmiName_CR_RequestTournamentWatcherLoginOK = "CR_RequestTournamentWatcherLoginOK";

        public const string RmiName_CR_RequestTournamentWatcherExitOK = "CR_RequestTournamentWatcherExitOK";

        public const string RmiName_CR_RequestTournamentMatchReplayStartOK = "CR_RequestTournamentMatchReplayStartOK";

        public const string RmiName_CR_RequestTournamentMatchInGameClearOK = "CR_RequestTournamentMatchInGameClearOK";

        public const string RmiName_RC_NotifyTournamentMatchJoin = "RC_NotifyTournamentMatchJoin";

        public const string RmiName_RC_NotifyTournamentMatchChangeTeam = "RC_NotifyTournamentMatchChangeTeam";

        public const string RmiName_RC_NotifyTournamentMatchReady = "RC_NotifyTournamentMatchReady";

        public const string RmiName_RC_NotifyTournamentMatchStart = "RC_NotifyTournamentMatchStart";

        public const string RmiName_RC_NotifyTournamentMatchInGameFight = "RC_NotifyTournamentMatchInGameFight";

        public const string RmiName_RC_NotifyTournamentMatchInGameSync = "RC_NotifyTournamentMatchInGameSync";

        public const string RmiName_RC_NotifyTournamentMatchInGameGiveup = "RC_NotifyTournamentMatchInGameGiveup";

        public const string RmiName_RC_NotifyTournamentMatchInGameExit = "RC_NotifyTournamentMatchInGameExit";

        public const string RmiName_RC_NotifyTournamentMatchChatEnter = "RC_NotifyTournamentMatchChatEnter";

        public const string RmiName_RC_NotifyTournamentMatchExit = "RC_NotifyTournamentMatchExit";

        public const string RmiName_RC_NotifyTournamentWatcherStart = "RC_NotifyTournamentWatcherStart";

        public const string RmiName_CR_RequestSubdueLoginOK = "CR_RequestSubdueLoginOK";

        public const string RmiName_CR_RequestSubdueReLoginOK = "CR_RequestSubdueReLoginOK";

        public const string RmiName_CR_RequestSubdueReadyOK = "CR_RequestSubdueReadyOK";

        public const string RmiName_CR_RequestSubdueReturnReadyOK = "CR_RequestSubdueReturnReadyOK";

        public const string RmiName_CR_RequestSubdueLeaveOK = "CR_RequestSubdueLeaveOK";

        public const string RmiName_CR_RequestSubdueKickoutOK = "CR_RequestSubdueKickoutOK";

        public const string RmiName_CR_RequestSubdueGameStartOK = "CR_RequestSubdueGameStartOK";

        public const string RmiName_CR_RequestSubdueBattleSyncOK = "CR_RequestSubdueBattleSyncOK";

        public const string RmiName_CR_RequestSubdueBattleEndOK = "CR_RequestSubdueBattleEndOK";

        public const string RmiName_CR_NotifySubdueSyncOK = "CR_NotifySubdueSyncOK";

        public const string RmiName_CR_NotifySubdueMemberJoinUpdateOK = "CR_NotifySubdueMemberJoinUpdateOK";

        public const string RmiName_CR_NotifySubdueGameStartOK = "CR_NotifySubdueGameStartOK";

        public const string RmiName_CR_NotifySubdueLoadingCompleteOK = "CR_NotifySubdueLoadingCompleteOK";

        public const string RmiName_CR_NotifySubdueRewardAggregationOK = "CR_NotifySubdueRewardAggregationOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveLoginOK = "CR_RequestFriendlyMatchObserveLoginOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveLobbySyncOK = "CR_RequestFriendlyMatchObserveLobbySyncOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveReadyOK = "CR_RequestFriendlyMatchObserveReadyOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveReadyOffOK = "CR_RequestFriendlyMatchObserveReadyOffOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveChangeTeamOK = "CR_RequestFriendlyMatchObserveChangeTeamOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveTeamInfoOK = "CR_RequestFriendlyMatchObserveTeamInfoOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveChangeMatchModeOK = "CR_RequestFriendlyMatchObserveChangeMatchModeOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveKickOutOK = "CR_RequestFriendlyMatchObserveKickOutOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveStartOK = "CR_RequestFriendlyMatchObserveStartOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveSyncOK = "CR_RequestFriendlyMatchObserveSyncOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveExitOK = "CR_RequestFriendlyMatchObserveExitOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveChatEnterOK = "CR_RequestFriendlyMatchObserveChatEnterOK";

        public const string RmiName_RC_NotifyFriendlyMatchObserveJoin = "RC_NotifyFriendlyMatchObserveJoin";

        public const string RmiName_RC_NotifyFriendlyMatchObserveLobbySync = "RC_NotifyFriendlyMatchObserveLobbySync";

        public const string RmiName_RC_NotifyFriendlyMatchObserveUserReady = "RC_NotifyFriendlyMatchObserveUserReady";

        public const string RmiName_RC_NotifyFriendlyMatchObserveUserReadyOff = "RC_NotifyFriendlyMatchObserveUserReadyOff";

        public const string RmiName_RC_NotifyFriendlyMatchObserveUserChangeTeam = "RC_NotifyFriendlyMatchObserveUserChangeTeam";

        public const string RmiName_RC_NotifyFriendlyMatchObserveKickedOut = "RC_NotifyFriendlyMatchObserveKickedOut";

        public const string RmiName_RC_NotifyFriendlyMatchObserveUserGameStart = "RC_NotifyFriendlyMatchObserveUserGameStart";

        public const string RmiName_RC_NotifyFriendlyMatchObserveSync = "RC_NotifyFriendlyMatchObserveSync";

        public const string RmiName_RC_NotifyFriendlyMatchObserveChatEnter = "RC_NotifyFriendlyMatchObserveChatEnter";

        public const string RmiName_RC_NotifyFriendlyMatchObserveExit = "RC_NotifyFriendlyMatchObserveExit";

        public const string RmiName_RC_NotifyFriendlyMatchObserveInGameExit = "RC_NotifyFriendlyMatchObserveInGameExit";

        public const string RmiName_RC_NotifyFriendlyMatchObserveChangeMatchMode = "RC_NotifyFriendlyMatchObserveChangeMatchMode";

        public const string RmiName_RC_NotifyFriendlyMatchObserveChangeModeID = "RC_NotifyFriendlyMatchObserveChangeModeID";

        public const string RmiName_CR_RequestFriendlyMatchObserveReadyTimeOverOK = "CR_RequestFriendlyMatchObserveReadyTimeOverOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameReadyOK = "CR_RequestFriendlyMatchObserveInGameReadyOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveFightOK = "CR_RequestFriendlyMatchObserveFightOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameExitOK = "CR_RequestFriendlyMatchObserveInGameExitOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveChangeUserModeOK = "CR_RequestFriendlyMatchObserveChangeUserModeOK";

        public const string RmiName_RC_NotifyFriendlyMatchObserveChangeUserMode = "RC_NotifyFriendlyMatchObserveChangeUserMode";

        public const string RmiName_CR_RequestFriendlyMatchObserveReplayStartOK = "CR_RequestFriendlyMatchObserveReplayStartOK";

        public const string RmiName_RC_NotifyFriendlyMatchObserveWatcherStart = "RC_NotifyFriendlyMatchObserveWatcherStart";

        public const string RmiName_CR_RequestFriendlyMatchObserveUserStatusOK = "CR_RequestFriendlyMatchObserveUserStatusOK";

        public const string RmiName_RC_NotifyFriendlyMatchObserveUserStatus = "RC_NotifyFriendlyMatchObserveUserStatus";

        public const string RmiName_CR_RequestFriendlyMatchObserveLobbyHeartBeatOK = "CR_RequestFriendlyMatchObserveLobbyHeartBeatOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveReadyOffAllOK = "CR_RequestFriendlyMatchObserveReadyOffAllOK";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameClearOK = "CR_RequestFriendlyMatchObserveInGameClearOK";

        public const string RmiName_RC_NotifyFriendlyMatchObserveInGameClear = "RC_NotifyFriendlyMatchObserveInGameClear";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameHeartBeatOK = "CR_RequestFriendlyMatchObserveInGameHeartBeatOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitLoginOK = "CR_RequestArenaRealTimePVPLimitLoginOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitJoinOK = "CR_RequestArenaRealTimePVPLimitJoinOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitExitOK = "CR_RequestArenaRealTimePVPLimitExitOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitReadyOK = "CR_RequestArenaRealTimePVPLimitReadyOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitFightOK = "CR_RequestArenaRealTimePVPLimitFightOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitSyncOK = "CR_RequestArenaRealTimePVPLimitSyncOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitReadyTimeOverOK = "CR_RequestArenaRealTimePVPLimitReadyTimeOverOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitChatEnterOK = "CR_RequestArenaRealTimePVPLimitChatEnterOK";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitJoinTimeOverOK = "CR_RequestArenaRealTimePVPLimitJoinTimeOverOK";

        public const string RmiName_First = "CR_CommonCancel";

        public delegate bool CR_CommonCancelDelegate(HostID remote, RmiContext rmiContext, RmiID packetID, string packetName, PacketError error, InvalidRequestType invalidRequesttype, bool isSimpleMessageBox);

        public delegate bool CR_RequestForceLogoutOKDelegate(HostID remote, RmiContext rmiContext, PacketError error);

        public delegate bool CR_RequestArenaRealTimePVPLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRealTimePVPJoinOKDelegate(HostID remote, RmiContext rmiContext, UserProfileInfo userInfo);

        public delegate bool CR_RequestArenaRealTimePVPExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUsn, bool giveup);

        public delegate bool CR_RequestArenaRealTimePVPReadyOKDelegate(HostID remote, RmiContext rmiContext, bool timeOver);

        public delegate bool CR_RequestArenaRealTimePVPFightOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRealTimePVPSyncOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool CR_RequestArenaRealTimePVPReadyTimeOverOKDelegate(HostID remote, RmiContext rmiContext, bool bSucess);

        public delegate bool CR_RequestArenaRealTimePVPChatEnterOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message);

        public delegate bool CR_RequestArenaRealTimePVPJoinTimeOverOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyDestroyUserJoinDelegate(HostID remote, RmiContext rmiContext, DestroyUserProfileInfo userInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool RC_NotifyDestroyUserStateChangedDelegate(HostID remote, RmiContext rmiContext, DestroyLobbySyncInfo syncInfo);

        public delegate bool RC_NotifyDestroyUserExitDelegate(HostID remote, RmiContext rmiContext, long exitUSN, bool isOwner);

        public delegate bool RC_NotifyDestroyGameStartDelegate(HostID remote, RmiContext rmiContext, DestroyStartResult startResult);

        public delegate bool RC_NotifyDestroyIngameStartDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyDestroySyncDelegate(HostID remote, RmiContext rmiContext, DestroySyncInfo syncInfo);

        public delegate bool RC_NotifyDestroyGameEndDelegate(HostID remote, RmiContext rmiContext, bool isClear, bool ownerExit);

        public delegate bool RC_NotifyDestroySelectSkillCardDelegate(HostID remote, RmiContext rmiContext, DestroyCardOrderInfo cardOrderInfo);

        public delegate bool RC_NotifyDestroyRoundFinishDelegate(HostID remote, RmiContext rmiContext, short roundID);

        public delegate bool RC_NotifyDestroyChatEnterDelegate(HostID remote, RmiContext rmiContext, DestroyChatMessage chatMessage);

        public delegate bool RC_RequestDestroyNeedSyncDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyReLoginOKDelegate(HostID remote, RmiContext rmiContext, DestroyUserProfileInfo otherPlayerProfileInfo);

        public delegate bool CR_RequestDestroyRelayReadyOKDelegate(HostID remote, RmiContext rmiContext, DestroyUserProfileInfo otherUserProfileInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool CR_RequestDestroyLobbySyncOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyChatEnterOKDelegate(HostID remote, RmiContext rmiContext, DestroyChatMessage chatMessage);

        public delegate bool CR_RequestDestroyReadyOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyReturnReadyOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyKickOutOKDelegate(HostID remote, RmiContext rmiContext, long usn);

        public delegate bool CR_RequestDestroyChangeTeamInfoOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyMemberTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool CR_RequestDestroyIngameReadyOKDelegate(HostID remote, RmiContext rmiContext, short playingRoundID);

        public delegate bool CR_RequestDestroyRoundFinishOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyNeedSyncOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyIngameFinishOKDelegate(HostID remote, RmiContext rmiContext, List<int> stageIdList);

        public delegate bool CR_RequestDestroyExitOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestDestroyTestExitOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestGuildLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestGuildRoomJoinOKDelegate(HostID remote, RmiContext rmiContext, List<GuildRoomMemberInfo> guildRoomMemberInfo, List<GuildRoomMemberPointInfo> guildRoomMemberPointInfoList);

        public delegate bool CR_RequestGuildRoomOutOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestGuildRoomMemberInfoOKDelegate(HostID remote, RmiContext rmiContext, List<GuildRoomMemberInfo> guildRoomMemberInfo, List<GuildRoomMemberPointInfo> guildRoomMemberPointInfoList);

        public delegate bool CR_RequestGuildRoomSyncOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestGuildRoomMemberInfoSyncOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestGuildRoomKickOutMemberOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestGuildRoomLeaveMemberOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyGuildNewMemberOKDelegate(HostID remote, RmiContext rmiContext, GuildRoomMemberInfo newMemberInfo);

        public delegate bool RC_NotifyGuildLeaveMemberOKDelegate(HostID remote, RmiContext rmiContext, long otherUSN);

        public delegate bool RC_NotifyGuildRoomOtherPlayerJoinOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo guildMemberInfo, GuildRoomMemberPointInfo guildRoomMemberPointInfo);

        public delegate bool RC_NotifyGuildRoomOtherPlayerOutOKDelegate(HostID remote, RmiContext rmiContext, long otherUSN);

        public delegate bool RC_NotifyGuildRoomOtherPlayerSyncOKDelegate(HostID remote, RmiContext rmiContext, List<GuildRoomMoveInfo> guildRoomMoveInfoList);

        public delegate bool RC_NotifyGuildRoomOtherPlayerMemberInfoSyncOKDelegate(HostID remote, RmiContext rmiContext, GuildRoomMemberInfo guildRoomMemberInfo);

        public delegate bool RC_NotifyGuildRoomOtherPlayerKickOutMemberOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo kickOutGuildMemberInfo);

        public delegate bool RC_NotifyGuildRoomOtherPlayerLeaveMemberOKDelegate(HostID remote, RmiContext rmiContext, long leaveUSN);

        public delegate bool CR_RequestFriendlyMatchLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchLobbySyncOKDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo otherUserSyncInfo);

        public delegate bool CR_RequestFriendlyMatchReadyOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchReadyOffOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchChangeTeamOKDelegate(HostID remote, RmiContext rmiContext, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool CR_RequestFriendlyMatchTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool CR_RequestFriendlyMatchChangeMatchModeOKDelegate(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID);

        public delegate bool CR_RequestFriendlyMatchKickOutOKDelegate(HostID remote, RmiContext rmiContext, long kickUSN);

        public delegate bool CR_RequestFriendlyMatchStartOKDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchStartResult startResult);

        public delegate bool CR_RequestFriendlyMatchSyncOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool CR_RequestFriendlyMatchExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUsn);

        public delegate bool CR_RequestFriendlyMatchChatEnterOKDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage);

        public delegate bool RC_NotifyFriendlyMatchJoinDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchUserProfileInfo fmProfileInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo, bool readyStatus, byte matchMode, byte modeID, byte userMode);

        public delegate bool RC_NotifyFriendlyMatchLobbySyncDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo syncInfo);

        public delegate bool RC_NotifyFriendlyMatchUserReadyDelegate(HostID remote, RmiContext rmiContext, long usn);

        public delegate bool RC_NotifyFriendlyMatchUserReadyOffDelegate(HostID remote, RmiContext rmiContext, long usn);

        public delegate bool RC_NotifyFriendlyMatchUserChangeTeamDelegate(HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool RC_NotifyFriendlyMatchKickedOutDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyFriendlyMatchUserGameStartDelegate(HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo, FriendlyMatchStartResult startResult);

        public delegate bool RC_NotifyFriendlyMatchSyncDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool RC_NotifyFriendlyMatchChatEnterDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage);

        public delegate bool RC_NotifyFriendlyMatchExitDelegate(HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner);

        public delegate bool RC_NotifyFriendlyMatchInGameExitDelegate(HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner);

        public delegate bool RC_NotifyFriendlyMatchChangeMatchModeDelegate(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID);

        public delegate bool RC_NotifyFriendlyMatchChangeModeIDDelegate(HostID remote, RmiContext rmiContext, byte modeID);

        public delegate bool CR_RequestFriendlyMatchReadyTimeOverOKDelegate(HostID remote, RmiContext rmiContext, bool isSuccess);

        public delegate bool CR_RequestFriendlyMatchInGameReadyOKDelegate(HostID remote, RmiContext rmiContext, bool timeOver);

        public delegate bool CR_RequestFriendlyMatchFightOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchInGameExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUSN);

        public delegate bool CR_RequestFriendlyMatchChangeUserModeOKDelegate(HostID remote, RmiContext rmiContext, long targetUSN, byte userMode);

        public delegate bool RC_NotifyFriendlyMatchChangeUserModeDelegate(HostID remote, RmiContext rmiContext, long targetUSN, byte userMode);

        public delegate bool CR_RequestArenaRealTimePVPLowerLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRealTimePVPLowerJoinOKDelegate(HostID remote, RmiContext rmiContext, UserProfileInfo userInfo);

        public delegate bool CR_RequestArenaRealTimePVPLowerExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUsn, bool giveup);

        public delegate bool CR_RequestArenaRealTimePVPLowerReadyOKDelegate(HostID remote, RmiContext rmiContext, bool timeOver);

        public delegate bool CR_RequestArenaRealTimePVPLowerFightOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRealTimePVPLowerSyncOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool CR_RequestArenaRealTimePVPLowerReadyTimeOverOKDelegate(HostID remote, RmiContext rmiContext, bool bSucess);

        public delegate bool CR_RequestArenaRealTimePVPLowerChatEnterOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message);

        public delegate bool CR_RequestArenaRealTimePVPLowerJoinTimeOverOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRankingConnectOKDelegate(HostID remote, RmiContext rmiContext, bool connectResult);

        public delegate bool CR_RequestArenaRankingLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRankingJoinOKDelegate(HostID remote, RmiContext rmiContext, UserProfileInfo userInfo);

        public delegate bool CR_RequestArenaRankingExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUsn, bool giveup);

        public delegate bool CR_RequestArenaRankingReadyOKDelegate(HostID remote, RmiContext rmiContext, bool timeOver);

        public delegate bool CR_RequestArenaRankingFightOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRankingSyncOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool CR_RequestArenaRankingReadyTimeOverOKDelegate(HostID remote, RmiContext rmiContext, bool bSucess);

        public delegate bool CR_RequestArenaRankingChatEnterOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message);

        public delegate bool CR_RequestArenaRankingJoinTimeOverOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestTournamentMatchLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestTournamentMatchChangeTeamOKDelegate(HostID remote, RmiContext rmiContext, List<byte> teamSlotIndexList);

        public delegate bool CR_RequestTournamentMatchReadyOKDelegate(HostID remote, RmiContext rmiContext, bool readyStatus);

        public delegate bool CR_RequestTournamentMatchInGameReadyOKDelegate(HostID remote, RmiContext rmiContext, bool timeOver);

        public delegate bool CR_RequestTournamentMatchInGameTimeOverOKDelegate(HostID remote, RmiContext rmiContext, bool isSuccess);

        public delegate bool CR_RequestTournamentMatchInGameSyncOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool CR_RequestTournamentMatchInGameGiveupOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestTournamentMatchInGameExitOKDelegate(HostID remote, RmiContext rmiContext, TournamentMatchInfo matchInfo);

        public delegate bool CR_RequestTournamentMatchChatEnterOKDelegate(HostID remote, RmiContext rmiContext, int stampID, string message);

        public delegate bool CR_RequestTournamentMatchExitOKDelegate(HostID remote, RmiContext rmiContext, bool isSuspend);

        public delegate bool CR_RequestTournamentWatcherLoginOKDelegate(HostID remote, RmiContext rmiContext, TournamentWatcherLoginResult loginResult);

        public delegate bool CR_RequestTournamentWatcherExitOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestTournamentMatchReplayStartOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestTournamentMatchInGameClearOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyTournamentMatchJoinDelegate(HostID remote, RmiContext rmiContext, TournamentMatchUserProfileInfo otherProfileInfo, OtherPlayerSimpleTeamInfo otherTeamInfo, bool otherReadyStatus);

        public delegate bool RC_NotifyTournamentMatchChangeTeamDelegate(HostID remote, RmiContext rmiContext, long otherUSN, List<byte> teamSlotIndexList);

        public delegate bool RC_NotifyTournamentMatchReadyDelegate(HostID remote, RmiContext rmiContext, long otherUSN, bool readyStatus);

        public delegate bool RC_NotifyTournamentMatchStartDelegate(HostID remote, RmiContext rmiContext, TournamentMatchStartResult startResult);

        public delegate bool RC_NotifyTournamentMatchInGameFightDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyTournamentMatchInGameSyncDelegate(HostID remote, RmiContext rmiContext, long sendUSN, byte currentPlayIndex, string strSync, string replaySync);

        public delegate bool RC_NotifyTournamentMatchInGameGiveupDelegate(HostID remote, RmiContext rmiContext, long giveupUSN);

        public delegate bool RC_NotifyTournamentMatchInGameExitDelegate(HostID remote, RmiContext rmiContext, long leaveUSN, TournamentMatchInfo matchInfo);

        public delegate bool RC_NotifyTournamentMatchChatEnterDelegate(HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message);

        public delegate bool RC_NotifyTournamentMatchExitDelegate(HostID remote, RmiContext rmiContext, long leaveUSN, TournamentMatchInfo matchInfo);

        public delegate bool RC_NotifyTournamentWatcherStartDelegate(HostID remote, RmiContext rmiContext, byte currentPlayIndex, ReplayBytesInfo replayBytesInfo);

        public delegate bool CR_RequestSubdueLoginOKDelegate(HostID remote, RmiContext rmiContext, int position, List<BossWarUserProfileInfo> memberProfileList);

        public delegate bool CR_RequestSubdueReLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestSubdueReadyOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestSubdueReturnReadyOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestSubdueLeaveOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestSubdueKickoutOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestSubdueGameStartOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestSubdueBattleSyncOKDelegate(HostID remote, RmiContext rmiContext, SubdueBossBattleSyncResult battleSyncResult);

        public delegate bool CR_RequestSubdueBattleEndOKDelegate(HostID remote, RmiContext rmiContext, bool isWait);

        public delegate bool CR_NotifySubdueSyncOKDelegate(HostID remote, RmiContext rmiContext, long usn, BossWarNotifyType notifyType, long notifyValue1, long notifyValue2);

        public delegate bool CR_NotifySubdueMemberJoinUpdateOKDelegate(HostID remote, RmiContext rmiContext, BossWarUserProfileInfo joinMemberProfile);

        public delegate bool CR_NotifySubdueGameStartOKDelegate(HostID remote, RmiContext rmiContext, BossWarStartResult startResult);

        public delegate bool CR_NotifySubdueLoadingCompleteOKDelegate(HostID remote, RmiContext rmiContext, int remainSeconds, bool loadingSuccess);

        public delegate bool CR_NotifySubdueRewardAggregationOKDelegate(HostID remote, RmiContext rmiContext, bool isRecvRewardOK);

        public delegate bool CR_RequestFriendlyMatchObserveLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchObserveLobbySyncOKDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo otherUserSyncInfo, int syncBattlePoint);

        public delegate bool CR_RequestFriendlyMatchObserveReadyOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchObserveReadyOffOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchObserveChangeTeamOKDelegate(HostID remote, RmiContext rmiContext, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool CR_RequestFriendlyMatchObserveTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool CR_RequestFriendlyMatchObserveChangeMatchModeOKDelegate(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID, byte passiveID);

        public delegate bool CR_RequestFriendlyMatchObserveKickOutOKDelegate(HostID remote, RmiContext rmiContext, long kickUSN);

        public delegate bool CR_RequestFriendlyMatchObserveStartOKDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchStartResult startResult);

        public delegate bool CR_RequestFriendlyMatchObserveSyncOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool CR_RequestFriendlyMatchObserveExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUsn);

        public delegate bool CR_RequestFriendlyMatchObserveChatEnterOKDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage);

        public delegate bool RC_NotifyFriendlyMatchObserveJoinDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchUserProfileInfo fmProfileInfo, OtherPlayerSimpleTeamInfo simpleTeamInfo, bool readyStatus, byte matchMode, byte modeID, byte passiveID, byte userMode, bool isRoomOwner);

        public delegate bool RC_NotifyFriendlyMatchObserveLobbySyncDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo syncInfo, int syncBattlePoint);

        public delegate bool RC_NotifyFriendlyMatchObserveUserReadyDelegate(HostID remote, RmiContext rmiContext, long usn);

        public delegate bool RC_NotifyFriendlyMatchObserveUserReadyOffDelegate(HostID remote, RmiContext rmiContext, long usn);

        public delegate bool RC_NotifyFriendlyMatchObserveUserChangeTeamDelegate(HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo);

        public delegate bool RC_NotifyFriendlyMatchObserveKickedOutDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyFriendlyMatchObserveUserGameStartDelegate(HostID remote, RmiContext rmiContext, long usn, OtherPlayerSimpleTeamInfo simpleTeamInfo, List<FriendlyMatchObserveStartResult> startResultList);

        public delegate bool RC_NotifyFriendlyMatchObserveSyncDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync, string replaySync);

        public delegate bool RC_NotifyFriendlyMatchObserveChatEnterDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchChatMessage chatMessage);

        public delegate bool RC_NotifyFriendlyMatchObserveExitDelegate(HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner);

        public delegate bool RC_NotifyFriendlyMatchObserveInGameExitDelegate(HostID remote, RmiContext rmiContext, long leaveUSN, bool isOwner);

        public delegate bool RC_NotifyFriendlyMatchObserveChangeMatchModeDelegate(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID, byte passiveID);

        public delegate bool RC_NotifyFriendlyMatchObserveChangeModeIDDelegate(HostID remote, RmiContext rmiContext, byte modeID, byte passiveID);

        public delegate bool CR_RequestFriendlyMatchObserveReadyTimeOverOKDelegate(HostID remote, RmiContext rmiContext, bool isSuccess);

        public delegate bool CR_RequestFriendlyMatchObserveInGameReadyOKDelegate(HostID remote, RmiContext rmiContext, bool timeOver);

        public delegate bool CR_RequestFriendlyMatchObserveFightOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchObserveInGameExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUSN);

        public delegate bool CR_RequestFriendlyMatchObserveChangeUserModeOKDelegate(HostID remote, RmiContext rmiContext, long targetUSN, byte userMode);

        public delegate bool RC_NotifyFriendlyMatchObserveChangeUserModeDelegate(HostID remote, RmiContext rmiContext, long targetUSN, byte userMode);

        public delegate bool CR_RequestFriendlyMatchObserveReplayStartOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyFriendlyMatchObserveWatcherStartDelegate(HostID remote, RmiContext rmiContext, ReplayBytesInfo replayBytesInfo);

        public delegate bool CR_RequestFriendlyMatchObserveUserStatusOKDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchUserStatusInfo userStatusInfo);

        public delegate bool RC_NotifyFriendlyMatchObserveUserStatusDelegate(HostID remote, RmiContext rmiContext, FriendlyMatchUserStatusInfo userStatusInfo);

        public delegate bool CR_RequestFriendlyMatchObserveLobbyHeartBeatOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchObserveReadyOffAllOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchObserveInGameClearOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool RC_NotifyFriendlyMatchObserveInGameClearDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestFriendlyMatchObserveInGameHeartBeatOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRealTimePVPLimitLoginOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRealTimePVPLimitJoinOKDelegate(HostID remote, RmiContext rmiContext, UserProfileInfo userInfo);

        public delegate bool CR_RequestArenaRealTimePVPLimitExitOKDelegate(HostID remote, RmiContext rmiContext, long targetUsn, bool giveup);

        public delegate bool CR_RequestArenaRealTimePVPLimitReadyOKDelegate(HostID remote, RmiContext rmiContext, bool timeOver);

        public delegate bool CR_RequestArenaRealTimePVPLimitFightOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CR_RequestArenaRealTimePVPLimitSyncOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, string strSync);

        public delegate bool CR_RequestArenaRealTimePVPLimitReadyTimeOverOKDelegate(HostID remote, RmiContext rmiContext, bool bSucess);

        public delegate bool CR_RequestArenaRealTimePVPLimitChatEnterOKDelegate(HostID remote, RmiContext rmiContext, long sendUSN, int stampID, string message);

        public delegate bool CR_RequestArenaRealTimePVPLimitJoinTimeOverOKDelegate(HostID remote, RmiContext rmiContext);
    }
}