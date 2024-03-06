using Nettention.Proud;

namespace GameClient
{
    public class RelayClient : ClientBase
    {
        private RmiContext RELIABLESEND = RmiContext.FastEncryptedReliableSend;

        private RmiContext SECURE_RELIABLE_SEND = RmiContext.SecureReliableSend;

        private HostID SERVER = HostID.HostID_Server;

        public RelayProxy SendProxy { get; } = new RelayProxy();

        private RelayPacketHandler PacketHandler { get; } = new RelayPacketHandler();

        public void Initialize()
        {
            Logger.Log("[RelayClient-Initialize]");
            InitializeNetClient();
            // Attach RMI proxy and stub to NetClient object
            AttachProxy(SendProxy);  // From client to server
            AttachStub(PacketHandler.R2CStub);  // From server to client
        }

        // Event that occurs after the connection attempt
        // It doesn't mean that the connection was accepted
        protected override void OnJoinServerComplete(ErrorInfo errorInfo, ByteArray replyFromServer)
        {
            RelayPacketManager.Instance.OnJoinServerComplete(errorInfo);
        }

        // Event that occurs when the connection is terminated
        // Not called when the users diconnect themselves
        protected override void OnLeaveServer(ErrorInfo errorInfo)
        {
            RelayPacketManager.Instance.OnLeaveServer(errorInfo);
        }

        // Event that occurs when an internal error has occured
        protected override void OnError(ErrorInfo errorInfo)
        {
            Console.WriteLine("[RelayClient-OnError] " + errorInfo.errorType);
        }

        // Event that occurs when an internal error has occured, with a priority lower than Error
        protected override void OnWarning(ErrorInfo errorInfo)
        {
            Console.WriteLine("[RelayClient-OnWarning] " + errorInfo.errorType);
        }

        // Event that occurs when an internal notification has occured. It does not indicate a problem.
        protected override void OnInformation(ErrorInfo errorInfo)
        {
            Console.WriteLine("[RelayClient-OnInformation] " + errorInfo.errorType);
        }

        // When a method called by a ProudNet dll throws an exception it will be catched and OnException will be called at the next client FrameMove
        protected override void OnException(HostID remote, Exception exception)
        {
            throw exception;
        }

        protected override void OnServerHandOverOffline(RemoteOfflineEventArgs args)
        {
            base.OnServerHandOverOffline(args);
        }

        protected override void OnServerHandOverOnline(RemoteOnlineEventArgs args)
        {
            base.OnServerHandOverOnline(args);
        }

        public void RequestArenaRealTimePVPLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestArenaRealTimePVPLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestArenaRealTimePVPReady()
        {
            SendProxy.CR_RequestArenaRealTimePVPReady(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPSync(string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            SendProxy.CR_RequestArenaRealTimePVPSync(SERVER, SECURE_RELIABLE_SEND, strSync, pvpSkillDataInfo);
        }

        public void RequestArenaRealTimePVPExit()
        {
            SendProxy.CR_RequestArenaRealTimePVPExit(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPReadyTimeOver()
        {
            SendProxy.CR_RequestArenaRealTimePVPReadyTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestArenaRealTimePVPChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestArenaRealTimePVPJoinTimeOver()
        {
            SendProxy.CR_RequestArenaRealTimePVPJoinTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestDestroyLogin(RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            SendProxy.CR_RequestDestroyLogin(SERVER, RELIABLESEND, connRequest, simpleTeamInfo);
        }

        public void RequestDestroyReLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestDestroyReLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestDestroyRelayReady(bool isReLogin)
        {
            SendProxy.CR_RequestDestroyRelayReady(SERVER, RELIABLESEND, isReLogin);
        }

        public void RequestDestroyLobbySync(DestroyLobbySyncInfo syncInfo)
        {
            SendProxy.CR_RequestDestroyLobbySync(SERVER, RELIABLESEND, syncInfo);
        }

        public void RequestDestroyChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestDestroyChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestDestroyReady(byte teamIndex, int foodItemID)
        {
            SendProxy.CR_RequestDestroyReady(SERVER, RELIABLESEND, teamIndex, foodItemID);
        }

        public void RequestDestroyReturnReady()
        {
            SendProxy.CR_RequestDestroyReturnReady(SERVER, RELIABLESEND);
        }

        public void RequestDestroyKickOut(long kickUSN)
        {
            SendProxy.CR_RequestDestroyKickOut(SERVER, RELIABLESEND, kickUSN);
        }

        public void RequestDestroyChangeTeamInfo(OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            SendProxy.CR_RequestDestroyChangeTeamInfo(SERVER, RELIABLESEND, simpleTeamInfo);
        }

        public void RequestDestroyMemberTeamInfo(long usn)
        {
            SendProxy.CR_RequestDestroyMemberTeamInfo(SERVER, RELIABLESEND, usn);
        }

        public void RequestDestroyStart()
        {
            SendProxy.CR_RequestDestroyStart(SERVER, RELIABLESEND);
        }

        public void RequestDestroyIngameReady()
        {
            SendProxy.CR_RequestDestroyIngameReady(SERVER, RELIABLESEND);
        }

        public void RequestDestroySelectSkillCard(DestroyCardSelectionInfo cardSelectionInfo)
        {
            SendProxy.CR_RequestDestroySelectSkillCard(SERVER, RELIABLESEND, cardSelectionInfo);
        }

        public void RequestDestroyRoundFinish(short roundID)
        {
            SendProxy.CR_RequestDestroyRoundFinish(SERVER, RELIABLESEND, roundID);
        }

        public void RequestDestroyNeedSync()
        {
            SendProxy.CR_RequestDestroyNeedSync(SERVER, RELIABLESEND);
        }

        public void RequestDestroySync(DestroySyncInfo syncInfo, bool isUserRequested)
        {
            SendProxy.CR_RequestDestroySync(SERVER, RELIABLESEND, syncInfo, isUserRequested);
        }

        public void RequestDestroyIngameFinish(DestroyClearRequest clearRequest)
        {
            SendProxy.CR_RequestDestroyIngameFinish(SERVER, RELIABLESEND, clearRequest);
        }

        public void RequestDestroyExit()
        {
            SendProxy.CR_RequestDestroyExit(SERVER, RELIABLESEND);
        }

        public void RequestDestroyTestExit()
        {
            SendProxy.CR_RequestDestroyTestExit(SERVER, RELIABLESEND);
        }

        public void RequestGuildLogin(RelayConnRequest connRequest, GuildMemberInfo guildMemberInfo, GuildRoomMemberInfo guildRoomMemberInfo)
        {
            SendProxy.CR_RequestGuildLogin(SERVER, RELIABLESEND, connRequest, guildMemberInfo, guildRoomMemberInfo);
        }

        public void RequestGuildRoomJoin()
        {
            SendProxy.CR_RequestGuildRoomJoin(SERVER, RELIABLESEND);
        }

        public void RequestGuildRoomOut()
        {
            SendProxy.CR_RequestGuildRoomOut(SERVER, RELIABLESEND);
        }

        public void RequestGuildRoomMemberInfo()
        {
            SendProxy.CR_RequestGuildRoomMemberInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildRoomSync(GuildRoomPoint point)
        {
            SendProxy.CR_RequestGuildRoomSync(SERVER, RELIABLESEND, point);
        }

        public void RequestGuildRoomMemberInfoSync(GuildRoomMemberInfo guildRoomMemberInfo)
        {
            SendProxy.CR_RequestGuildRoomMemberInfoSync(SERVER, RELIABLESEND, guildRoomMemberInfo);
        }

        public void RequestGuildRoomKickOutMember(GuildMemberInfo kickOutGuildMemberInfo)
        {
            SendProxy.CR_RequestGuildRoomKickOutMember(SERVER, RELIABLESEND, kickOutGuildMemberInfo);
        }

        public void RequestGuildRoomLeaveMember()
        {
            SendProxy.CR_RequestGuildRoomLeaveMember(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchLogin(RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            SendProxy.CR_RequestFriendlyMatchLogin(SERVER, RELIABLESEND, connRequest, simpleTeamInfo);
        }

        public void RequestFriendlyMatchLobbySync(FriendlyMatchSyncInfo syncInfo)
        {
            SendProxy.CR_RequestFriendlyMatchLobbySync(SERVER, RELIABLESEND, syncInfo);
        }

        public void RequestFriendlyMatchReady(byte teamIndex, int foodItemID)
        {
            SendProxy.CR_RequestFriendlyMatchReady(SERVER, RELIABLESEND, teamIndex, foodItemID);
        }

        public void RequestFriendlyMatchReadyOff()
        {
            SendProxy.CR_RequestFriendlyMatchReadyOff(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchChangeTeam(OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            SendProxy.CR_RequestFriendlyMatchChangeTeam(SERVER, RELIABLESEND, simpleTeamInfo);
        }

        public void RequestFriendlyMatchChangeMatchMode(byte matchMode, byte modeID)
        {
            SendProxy.CR_RequestFriendlyMatchChangeMatchMode(SERVER, RELIABLESEND, matchMode, modeID);
        }

        public void RequestFriendlyMatchTeamInfo(long targetUSN)
        {
            SendProxy.CR_RequestFriendlyMatchTeamInfo(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestFriendlyMatchKickOut(long kickUSN)
        {
            SendProxy.CR_RequestFriendlyMatchKickOut(SERVER, RELIABLESEND, kickUSN);
        }

        public void RequestFriendlyMatchStart()
        {
            SendProxy.CR_RequestFriendlyMatchStart(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchSync(string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            SendProxy.CR_RequestFriendlyMatchSync(SERVER, RELIABLESEND, strSync, pvpSkillDataInfo);
        }

        public void RequestFriendlyMatchExit()
        {
            SendProxy.CR_RequestFriendlyMatchExit(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestFriendlyMatchChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestFriendlyMatchReadyTimeOver()
        {
            SendProxy.CR_RequestFriendlyMatchReadyTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchInGameReady()
        {
            SendProxy.CR_RequestFriendlyMatchInGameReady(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchInGameExit()
        {
            SendProxy.CR_RequestFriendlyMatchInGameExit(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchChangeUserMode(long targetUSN, byte userMode)
        {
            SendProxy.CR_RequestFriendlyMatchChangeUserMode(SERVER, RELIABLESEND, targetUSN, userMode);
        }

        public void RequestArenaRealTimePVPLowerLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestArenaRealTimePVPLowerLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestArenaRealTimePVPLowerReady()
        {
            SendProxy.CR_RequestArenaRealTimePVPLowerReady(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPLowerSync(string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            SendProxy.CR_RequestArenaRealTimePVPLowerSync(SERVER, SECURE_RELIABLE_SEND, strSync, pvpSkillDataInfo);
        }

        public void RequestArenaRealTimePVPLowerExit()
        {
            SendProxy.CR_RequestArenaRealTimePVPLowerExit(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPLowerReadyTimeOver()
        {
            SendProxy.CR_RequestArenaRealTimePVPLowerReadyTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPLowerChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestArenaRealTimePVPLowerChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestArenaRealTimePVPLowerJoinTimeOver()
        {
            SendProxy.CR_RequestArenaRealTimePVPLowerJoinTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingConnect(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestArenaRankingConnect(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestArenaRankingLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestArenaRankingLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestArenaRankingReady()
        {
            SendProxy.CR_RequestArenaRankingReady(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingSync(string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            SendProxy.CR_RequestArenaRankingSync(SERVER, SECURE_RELIABLE_SEND, strSync, pvpSkillDataInfo);
        }

        public void RequestArenaRankingExit()
        {
            SendProxy.CR_RequestArenaRankingExit(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingReadyTimeOver()
        {
            SendProxy.CR_RequestArenaRankingReadyTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestArenaRankingChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestArenaRankingJoinTimeOver()
        {
            SendProxy.CR_RequestArenaRankingJoinTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestTournamentMatchLogin(RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo teamInfo)
        {
            SendProxy.CR_RequestTournamentMatchLogin(SERVER, RELIABLESEND, connRequest, teamInfo);
        }

        public void RequestTournamentMatchChangeTeam(List<byte> teamSlotIndexList)
        {
            SendProxy.CR_RequestTournamentMatchChangeTeam(SERVER, RELIABLESEND, teamSlotIndexList);
        }

        public void RequestTournamentMatchReady(bool readyStatus, byte teamIndex)
        {
            SendProxy.CR_RequestTournamentMatchReady(SERVER, RELIABLESEND, readyStatus, teamIndex);
        }

        public void RequestTournamentMatchInGameReady()
        {
            SendProxy.CR_RequestTournamentMatchInGameReady(SERVER, RELIABLESEND);
        }

        public void RequestTournamentMatchInGameTimeOver()
        {
            SendProxy.CR_RequestTournamentMatchInGameTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestTournamentMatchInGameSync(string strSync, PvpSkillDataInfo pvpSkillDataInfo, string replaySync)
        {
            SendProxy.CR_RequestTournamentMatchInGameSync(SERVER, RELIABLESEND, strSync, pvpSkillDataInfo, replaySync);
        }

        public void RequestTournamentMatchInGameGiveup()
        {
            SendProxy.CR_RequestTournamentMatchInGameGiveup(SERVER, RELIABLESEND);
        }

        public void RequestTournamentMatchInGameExit()
        {
            SendProxy.CR_RequestTournamentMatchInGameExit(SERVER, RELIABLESEND);
        }

        public void RequestTournamentMatchChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestTournamentMatchChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestTournamentMatchExit()
        {
            SendProxy.CR_RequestTournamentMatchExit(SERVER, RELIABLESEND);
        }

        public void RequestTournamentWatcherLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestTournamentWatcherLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestTournamentWatcherExit()
        {
            SendProxy.CR_RequestTournamentWatcherExit(SERVER, RELIABLESEND);
        }

        public void RequestTournamentMatchReplayStart(ReplayBytesInfo replayBytesInfo)
        {
            SendProxy.CR_RequestTournamentMatchReplayStart(SERVER, RELIABLESEND, replayBytesInfo);
        }

        public void RequestTournamentMatchInGameClear()
        {
            SendProxy.CR_RequestTournamentMatchInGameClear(SERVER, RELIABLESEND);
        }

        public void RequestSubdueLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestSubdueLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void requestSubdueReLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_requestSubdueReLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestSubdueReady(int teamPower, int foodId)
        {
            SendProxy.CR_RequestSubdueReady(SERVER, RELIABLESEND, teamPower, foodId);
        }

        public void RequestSubdueReturnReady()
        {
            SendProxy.CR_RequestSubdueReturnReady(SERVER, RELIABLESEND);
        }

        public void RequestSubdueLeave()
        {
            SendProxy.CR_RequestSubdueLeave(SERVER, RELIABLESEND);
        }

        public void RequestSubdueKickout(long kickUSN)
        {
            SendProxy.CR_RequestSubdueKickout(SERVER, RELIABLESEND, kickUSN);
        }

        public void RequestSubdueGameStart()
        {
            SendProxy.CR_RequestSubdueGameStart(SERVER, RELIABLESEND);
        }

        public void RequestSubdueBattleSync(List<BossWarSync> syncList)
        {
            SendProxy.CR_RequestSubdueBattleSync(SERVER, RELIABLESEND, syncList);
        }

        public void RequestSubdueBattleEnd()
        {
            SendProxy.CR_RequestSubdueBattleEnd(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveLogin(RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            SendProxy.CR_RequestFriendlyMatchObserveLogin(SERVER, RELIABLESEND, connRequest, simpleTeamInfo);
        }

        public void RequestFriendlyMatchObserveLobbySync(FriendlyMatchSyncInfo syncInfo, int syncBattlePoint)
        {
            SendProxy.CR_RequestFriendlyMatchObserveLobbySync(SERVER, RELIABLESEND, syncInfo, syncBattlePoint);
        }

        public void RequestFriendlyMatchObserveReady(byte teamIndex, int foodItemID)
        {
            SendProxy.CR_RequestFriendlyMatchObserveReady(SERVER, RELIABLESEND, teamIndex, foodItemID);
        }

        public void RequestFriendlyMatchObserveReadyOff()
        {
            SendProxy.CR_RequestFriendlyMatchObserveReadyOff(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveChangeTeam(OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            SendProxy.CR_RequestFriendlyMatchObserveChangeTeam(SERVER, RELIABLESEND, simpleTeamInfo);
        }

        public void RequestFriendlyMatchObserveChangeMatchMode(byte matchMode, byte modeID, byte passiveID)
        {
            SendProxy.CR_RequestFriendlyMatchObserveChangeMatchMode(SERVER, RELIABLESEND, matchMode, modeID, passiveID);
        }

        public void RequestFriendlyMatchObserveTeamInfo(long targetUSN)
        {
            SendProxy.CR_RequestFriendlyMatchObserveTeamInfo(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestFriendlyMatchObserveKickOut(long kickUSN)
        {
            SendProxy.CR_RequestFriendlyMatchObserveKickOut(SERVER, RELIABLESEND, kickUSN);
        }

        public void RequestFriendlyMatchObserveStart()
        {
            SendProxy.CR_RequestFriendlyMatchObserveStart(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveSync(string strSync, PvpSkillDataInfo pvpSkillDataInfo, string replaySync)
        {
            SendProxy.CR_RequestFriendlyMatchObserveSync(SERVER, RELIABLESEND, strSync, pvpSkillDataInfo, replaySync);
        }

        public void RequestFriendlyMatchObserveExit()
        {
            SendProxy.CR_RequestFriendlyMatchObserveExit(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestFriendlyMatchObserveChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestFriendlyMatchObserveReadyTimeOver()
        {
            SendProxy.CR_RequestFriendlyMatchObserveReadyTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveInGameReady()
        {
            SendProxy.CR_RequestFriendlyMatchObserveInGameReady(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveInGameExit()
        {
            SendProxy.CR_RequestFriendlyMatchObserveInGameExit(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveChangeUserMode(long targetUSN, byte userMode)
        {
            SendProxy.CR_RequestFriendlyMatchObserveChangeUserMode(SERVER, RELIABLESEND, targetUSN, userMode);
        }

        public void RequestFriendlyMatchObserveReplayStart(ReplayBytesInfo replayBytesInfo)
        {
            SendProxy.CR_RequestFriendlyMatchObserveReplayStart(SERVER, RELIABLESEND, replayBytesInfo);
        }

        public void RequestFriendlyMatchObserveUserStatus(byte status)
        {
            SendProxy.CR_RequestFriendlyMatchObserveUserStatus(SERVER, RELIABLESEND, status);
        }

        public void RequestFriendlyMatchObserveLobbyHeartBeat()
        {
            SendProxy.CR_RequestFriendlyMatchObserveLobbyHeartBeat(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveReadyOffAll()
        {
            SendProxy.CR_RequestFriendlyMatchObserveReadyOffAll(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveInGameClear()
        {
            SendProxy.CR_RequestFriendlyMatchObserveInGameClear(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveInGameHeartBeat()
        {
            SendProxy.CR_RequestFriendlyMatchObserveInGameHeartBeat(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPLimitLogin(RelayConnRequest connRequest)
        {
            SendProxy.CR_RequestArenaRealTimePVPLimitLogin(SERVER, RELIABLESEND, connRequest);
        }

        public void RequestArenaRealTimePVPLimitReady()
        {
            SendProxy.CR_RequestArenaRealTimePVPLimitReady(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPLimitSync(string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            SendProxy.CR_RequestArenaRealTimePVPLimitSync(SERVER, RELIABLESEND, strSync, pvpSkillDataInfo);
        }

        public void RequestArenaRealTimePVPLimitExit()
        {
            SendProxy.CR_RequestArenaRealTimePVPLimitExit(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPLimitReadyTimeOver()
        {
            SendProxy.CR_RequestArenaRealTimePVPLimitReadyTimeOver(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePVPLimitChatEnter(int stampID, string message)
        {
            SendProxy.CR_RequestArenaRealTimePVPLimitChatEnter(SERVER, RELIABLESEND, stampID, message);
        }

        public void RequestArenaRealTimePVPLimitJoinTimeOver()
        {
            SendProxy.CR_RequestArenaRealTimePVPLimitJoinTimeOver(SERVER, RELIABLESEND);
        }
    }
}
