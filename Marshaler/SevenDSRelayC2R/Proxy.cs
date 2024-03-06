using Nettention.Proud;

namespace SevenDSRelayC2R
{
    public class Proxy : RmiProxy
    {
        public bool CR_RequestArenaRealTimePVPLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLogin, Common.CR_RequestArenaRealTimePVPLogin);
        }

        public bool CR_RequestArenaRealTimePVPReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPReady, Common.CR_RequestArenaRealTimePVPReady);
        }

        public bool CR_RequestArenaRealTimePVPSync(HostID remote, RmiContext rmiContext, string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPSync);
            CommonPacket.Marshaler.Write(message, strSync);
            CommonPacket.Marshaler.Write(message, pvpSkillDataInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPSync, Common.CR_RequestArenaRealTimePVPSync);
        }

        public bool CR_RequestArenaRealTimePVPExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPExit, Common.CR_RequestArenaRealTimePVPExit);
        }

        public bool CR_RequestArenaRealTimePVPReadyTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPReadyTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPReadyTimeOver, Common.CR_RequestArenaRealTimePVPReadyTimeOver);
        }

        public bool CR_RequestArenaRealTimePVPChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPChatEnter, Common.CR_RequestArenaRealTimePVPChatEnter);
        }

        public bool CR_RequestArenaRealTimePVPJoinTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPJoinTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPJoinTimeOver, Common.CR_RequestArenaRealTimePVPJoinTimeOver);
        }

        public bool CR_RequestDestroyLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            CommonPacket.Marshaler.Write(message, simpleTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyLogin, Common.CR_RequestDestroyLogin);
        }

        public bool CR_RequestDestroyReLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyReLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyReLogin, Common.CR_RequestDestroyReLogin);
        }

        public bool CR_RequestDestroyRelayReady(HostID remote, RmiContext rmiContext, bool isReLogin)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyRelayReady);
            CommonPacket.Marshaler.Write(message, isReLogin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyRelayReady, Common.CR_RequestDestroyRelayReady);
        }

        public bool CR_RequestDestroyLobbySync(HostID remote, RmiContext rmiContext, DestroyLobbySyncInfo syncInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyLobbySync);
            CommonPacket.Marshaler.Write(message, syncInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyLobbySync, Common.CR_RequestDestroyLobbySync);
        }

        public bool CR_RequestDestroyChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyChatEnter, Common.CR_RequestDestroyChatEnter);
        }

        public bool CR_RequestDestroyReady(HostID remote, RmiContext rmiContext, byte teamIndex, int foodItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyReady);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, foodItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyReady, Common.CR_RequestDestroyReady);
        }

        public bool CR_RequestDestroyReturnReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyReturnReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyReturnReady, Common.CR_RequestDestroyReturnReady);
        }

        public bool CR_RequestDestroyKickOut(HostID remote, RmiContext rmiContext, long kickUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyKickOut);
            CommonPacket.Marshaler.Write(message, kickUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyKickOut, Common.CR_RequestDestroyKickOut);
        }

        public bool CR_RequestDestroyChangeTeamInfo(HostID remote, RmiContext rmiContext, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyChangeTeamInfo);
            CommonPacket.Marshaler.Write(message, simpleTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyChangeTeamInfo, Common.CR_RequestDestroyChangeTeamInfo);
        }

        public bool CR_RequestDestroyMemberTeamInfo(HostID remote, RmiContext rmiContext, long usn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyMemberTeamInfo);
            CommonPacket.Marshaler.Write(message, usn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyMemberTeamInfo, Common.CR_RequestDestroyMemberTeamInfo);
        }

        public bool CR_RequestDestroyStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyStart, Common.CR_RequestDestroyStart);
        }

        public bool CR_RequestDestroyIngameReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyIngameReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyIngameReady, Common.CR_RequestDestroyIngameReady);
        }

        public bool CR_RequestDestroySelectSkillCard(HostID remote, RmiContext rmiContext, DestroyCardSelectionInfo cardSelectionInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroySelectSkillCard);
            CommonPacket.Marshaler.Write(message, cardSelectionInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroySelectSkillCard, Common.CR_RequestDestroySelectSkillCard);
        }

        public bool CR_RequestDestroyRoundFinish(HostID remote, RmiContext rmiContext, short roundID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyRoundFinish);
            CommonPacket.Marshaler.Write(message, roundID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyRoundFinish, Common.CR_RequestDestroyRoundFinish);
        }

        public bool CR_RequestDestroyNeedSync(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyNeedSync);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyNeedSync, Common.CR_RequestDestroyNeedSync);
        }

        public bool CR_RequestDestroySync(HostID remote, RmiContext rmiContext, DestroySyncInfo syncInfo, bool isUserRequested)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroySync);
            CommonPacket.Marshaler.Write(message, syncInfo);
            CommonPacket.Marshaler.Write(message, isUserRequested);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroySync, Common.CR_RequestDestroySync);
        }

        public bool CR_RequestDestroyIngameFinish(HostID remote, RmiContext rmiContext, DestroyClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyIngameFinish);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyIngameFinish, Common.CR_RequestDestroyIngameFinish);
        }

        public bool CR_RequestDestroyExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyExit, Common.CR_RequestDestroyExit);
        }

        public bool CR_RequestDestroyTestExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestDestroyTestExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestDestroyTestExit, Common.CR_RequestDestroyTestExit);
        }

        public bool CR_RequestGuildLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest, GuildMemberInfo guildMemberInfo, GuildRoomMemberInfo guildRoomMemberInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            CommonPacket.Marshaler.Write(message, guildMemberInfo);
            CommonPacket.Marshaler.Write(message, guildRoomMemberInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildLogin, Common.CR_RequestGuildLogin);
        }

        public bool CR_RequestGuildRoomJoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildRoomJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildRoomJoin, Common.CR_RequestGuildRoomJoin);
        }

        public bool CR_RequestGuildRoomOut(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildRoomOut);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildRoomOut, Common.CR_RequestGuildRoomOut);
        }

        public bool CR_RequestGuildRoomMemberInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildRoomMemberInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildRoomMemberInfo, Common.CR_RequestGuildRoomMemberInfo);
        }

        public bool CR_RequestGuildRoomSync(HostID remote, RmiContext rmiContext, GuildRoomPoint point)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildRoomSync);
            CommonPacket.Marshaler.Write(message, point);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildRoomSync, Common.CR_RequestGuildRoomSync);
        }

        public bool CR_RequestGuildRoomMemberInfoSync(HostID remote, RmiContext rmiContext, GuildRoomMemberInfo guildRoomMemberInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildRoomMemberInfoSync);
            CommonPacket.Marshaler.Write(message, guildRoomMemberInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildRoomMemberInfoSync, Common.CR_RequestGuildRoomMemberInfoSync);
        }

        public bool CR_RequestGuildRoomKickOutMember(HostID remote, RmiContext rmiContext, GuildMemberInfo kickOutGuildMemberInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildRoomKickOutMember);
            CommonPacket.Marshaler.Write(message, kickOutGuildMemberInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildRoomKickOutMember, Common.CR_RequestGuildRoomKickOutMember);
        }

        public bool CR_RequestGuildRoomLeaveMember(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestGuildRoomLeaveMember);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestGuildRoomLeaveMember, Common.CR_RequestGuildRoomLeaveMember);
        }

        public bool CR_RequestFriendlyMatchLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            CommonPacket.Marshaler.Write(message, simpleTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchLogin, Common.CR_RequestFriendlyMatchLogin);
        }

        public bool CR_RequestFriendlyMatchLobbySync(HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo syncInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchLobbySync);
            CommonPacket.Marshaler.Write(message, syncInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchLobbySync, Common.CR_RequestFriendlyMatchLobbySync);
        }

        public bool CR_RequestFriendlyMatchReady(HostID remote, RmiContext rmiContext, byte teamIndex, int foodItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchReady);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, foodItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchReady, Common.CR_RequestFriendlyMatchReady);
        }

        public bool CR_RequestFriendlyMatchReadyOff(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchReadyOff);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchReadyOff, Common.CR_RequestFriendlyMatchReadyOff);
        }

        public bool CR_RequestFriendlyMatchChangeTeam(HostID remote, RmiContext rmiContext, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchChangeTeam);
            CommonPacket.Marshaler.Write(message, simpleTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchChangeTeam, Common.CR_RequestFriendlyMatchChangeTeam);
        }

        public bool CR_RequestFriendlyMatchChangeMatchMode(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchChangeMatchMode);
            CommonPacket.Marshaler.Write(message, matchMode);
            CommonPacket.Marshaler.Write(message, modeID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchChangeMatchMode, Common.CR_RequestFriendlyMatchChangeMatchMode);
        }

        public bool CR_RequestFriendlyMatchTeamInfo(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchTeamInfo);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchTeamInfo, Common.CR_RequestFriendlyMatchTeamInfo);
        }

        public bool CR_RequestFriendlyMatchKickOut(HostID remote, RmiContext rmiContext, long kickUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchKickOut);
            CommonPacket.Marshaler.Write(message, kickUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchKickOut, Common.CR_RequestFriendlyMatchKickOut);
        }

        public bool CR_RequestFriendlyMatchStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchStart, Common.CR_RequestFriendlyMatchStart);
        }

        public bool CR_RequestFriendlyMatchSync(HostID remote, RmiContext rmiContext, string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchSync);
            CommonPacket.Marshaler.Write(message, strSync);
            CommonPacket.Marshaler.Write(message, pvpSkillDataInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchSync, Common.CR_RequestFriendlyMatchSync);
        }

        public bool CR_RequestFriendlyMatchExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchExit, Common.CR_RequestFriendlyMatchExit);
        }

        public bool CR_RequestFriendlyMatchChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchChatEnter, Common.CR_RequestFriendlyMatchChatEnter);
        }

        public bool CR_RequestFriendlyMatchReadyTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchReadyTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchReadyTimeOver, Common.CR_RequestFriendlyMatchReadyTimeOver);
        }

        public bool CR_RequestFriendlyMatchInGameReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchInGameReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchInGameReady, Common.CR_RequestFriendlyMatchInGameReady);
        }

        public bool CR_RequestFriendlyMatchInGameExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchInGameExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchInGameExit, Common.CR_RequestFriendlyMatchInGameExit);
        }

        public bool CR_RequestFriendlyMatchChangeUserMode(HostID remote, RmiContext rmiContext, long targetUSN, byte userMode)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchChangeUserMode);
            CommonPacket.Marshaler.Write(message, targetUSN);
            CommonPacket.Marshaler.Write(message, userMode);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchChangeUserMode, Common.CR_RequestFriendlyMatchChangeUserMode);
        }

        public bool CR_RequestArenaRealTimePVPLowerLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLowerLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLowerLogin, Common.CR_RequestArenaRealTimePVPLowerLogin);
        }

        public bool CR_RequestArenaRealTimePVPLowerReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLowerReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLowerReady, Common.CR_RequestArenaRealTimePVPLowerReady);
        }

        public bool CR_RequestArenaRealTimePVPLowerSync(HostID remote, RmiContext rmiContext, string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLowerSync);
            CommonPacket.Marshaler.Write(message, strSync);
            CommonPacket.Marshaler.Write(message, pvpSkillDataInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLowerSync, Common.CR_RequestArenaRealTimePVPLowerSync);
        }

        public bool CR_RequestArenaRealTimePVPLowerExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLowerExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLowerExit, Common.CR_RequestArenaRealTimePVPLowerExit);
        }

        public bool CR_RequestArenaRealTimePVPLowerReadyTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLowerReadyTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLowerReadyTimeOver, Common.CR_RequestArenaRealTimePVPLowerReadyTimeOver);
        }

        public bool CR_RequestArenaRealTimePVPLowerChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLowerChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLowerChatEnter, Common.CR_RequestArenaRealTimePVPLowerChatEnter);
        }

        public bool CR_RequestArenaRealTimePVPLowerJoinTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLowerJoinTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLowerJoinTimeOver, Common.CR_RequestArenaRealTimePVPLowerJoinTimeOver);
        }

        public bool CR_RequestArenaRankingConnect(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingConnect);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingConnect, Common.CR_RequestArenaRankingConnect);
        }

        public bool CR_RequestArenaRankingLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingLogin, Common.CR_RequestArenaRankingLogin);
        }

        public bool CR_RequestArenaRankingReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingReady, Common.CR_RequestArenaRankingReady);
        }

        public bool CR_RequestArenaRankingSync(HostID remote, RmiContext rmiContext, string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingSync);
            CommonPacket.Marshaler.Write(message, strSync);
            CommonPacket.Marshaler.Write(message, pvpSkillDataInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingSync, Common.CR_RequestArenaRankingSync);
        }

        public bool CR_RequestArenaRankingExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingExit, Common.CR_RequestArenaRankingExit);
        }

        public bool CR_RequestArenaRankingReadyTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingReadyTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingReadyTimeOver, Common.CR_RequestArenaRankingReadyTimeOver);
        }

        public bool CR_RequestArenaRankingChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingChatEnter, Common.CR_RequestArenaRankingChatEnter);
        }

        public bool CR_RequestArenaRankingJoinTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRankingJoinTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRankingJoinTimeOver, Common.CR_RequestArenaRankingJoinTimeOver);
        }

        public bool CR_RequestTournamentMatchLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo teamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            CommonPacket.Marshaler.Write(message, teamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchLogin, Common.CR_RequestTournamentMatchLogin);
        }

        public bool CR_RequestTournamentMatchChangeTeam(HostID remote, RmiContext rmiContext, List<byte> teamSlotIndexList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchChangeTeam);
            CommonPacket.Marshaler.Write(message, teamSlotIndexList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchChangeTeam, Common.CR_RequestTournamentMatchChangeTeam);
        }

        public bool CR_RequestTournamentMatchReady(HostID remote, RmiContext rmiContext, bool readyStatus, byte teamIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchReady);
            CommonPacket.Marshaler.Write(message, readyStatus);
            CommonPacket.Marshaler.Write(message, teamIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchReady, Common.CR_RequestTournamentMatchReady);
        }

        public bool CR_RequestTournamentMatchInGameReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchInGameReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchInGameReady, Common.CR_RequestTournamentMatchInGameReady);
        }

        public bool CR_RequestTournamentMatchInGameTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchInGameTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchInGameTimeOver, Common.CR_RequestTournamentMatchInGameTimeOver);
        }

        public bool CR_RequestTournamentMatchInGameSync(HostID remote, RmiContext rmiContext, string strSync, PvpSkillDataInfo pvpSkillDataInfo, string replaySync)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchInGameSync);
            CommonPacket.Marshaler.Write(message, strSync);
            CommonPacket.Marshaler.Write(message, pvpSkillDataInfo);
            CommonPacket.Marshaler.Write(message, replaySync);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchInGameSync, Common.CR_RequestTournamentMatchInGameSync);
        }

        public bool CR_RequestTournamentMatchInGameGiveup(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchInGameGiveup);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchInGameGiveup, Common.CR_RequestTournamentMatchInGameGiveup);
        }

        public bool CR_RequestTournamentMatchInGameExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchInGameExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchInGameExit, Common.CR_RequestTournamentMatchInGameExit);
        }

        public bool CR_RequestTournamentMatchChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchChatEnter, Common.CR_RequestTournamentMatchChatEnter);
        }

        public bool CR_RequestTournamentMatchExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchExit, Common.CR_RequestTournamentMatchExit);
        }

        public bool CR_RequestTournamentWatcherLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentWatcherLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentWatcherLogin, Common.CR_RequestTournamentWatcherLogin);
        }

        public bool CR_RequestTournamentWatcherExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentWatcherExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentWatcherExit, Common.CR_RequestTournamentWatcherExit);
        }

        public bool CR_RequestTournamentMatchReplayStart(HostID remote, RmiContext rmiContext, ReplayBytesInfo replayBytesInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchReplayStart);
            CommonPacket.Marshaler.Write(message, replayBytesInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchReplayStart, Common.CR_RequestTournamentMatchReplayStart);
        }

        public bool CR_RequestTournamentMatchInGameClear(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestTournamentMatchInGameClear);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestTournamentMatchInGameClear, Common.CR_RequestTournamentMatchInGameClear);
        }

        public bool CR_RequestSubdueLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueLogin, Common.CR_RequestSubdueLogin);
        }

        public bool CR_requestSubdueReLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_requestSubdueReLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_requestSubdueReLogin, Common.CR_requestSubdueReLogin);
        }

        public bool CR_RequestSubdueReady(HostID remote, RmiContext rmiContext, int teamPower, int foodId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueReady);
            CommonPacket.Marshaler.Write(message, teamPower);
            CommonPacket.Marshaler.Write(message, foodId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueReady, Common.CR_RequestSubdueReady);
        }

        public bool CR_RequestSubdueReturnReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueReturnReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueReturnReady, Common.CR_RequestSubdueReturnReady);
        }

        public bool CR_RequestSubdueLeave(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueLeave);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueLeave, Common.CR_RequestSubdueLeave);
        }

        public bool CR_RequestSubdueKickout(HostID remote, RmiContext rmiContext, long kickUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueKickout);
            CommonPacket.Marshaler.Write(message, kickUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueKickout, Common.CR_RequestSubdueKickout);
        }

        public bool CR_RequestSubdueGameStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueGameStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueGameStart, Common.CR_RequestSubdueGameStart);
        }

        public bool CR_RequestSubdueBattleSync(HostID remote, RmiContext rmiContext, List<BossWarSync> syncList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueBattleSync);
            CommonPacket.Marshaler.Write(message, syncList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueBattleSync, Common.CR_RequestSubdueBattleSync);
        }

        public bool CR_RequestSubdueBattleEnd(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestSubdueBattleEnd);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestSubdueBattleEnd, Common.CR_RequestSubdueBattleEnd);
        }

        public bool CR_RequestFriendlyMatchObserveLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            CommonPacket.Marshaler.Write(message, simpleTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveLogin, Common.CR_RequestFriendlyMatchObserveLogin);
        }

        public bool CR_RequestFriendlyMatchObserveLobbySync(HostID remote, RmiContext rmiContext, FriendlyMatchSyncInfo syncInfo, int syncBattlePoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveLobbySync);
            CommonPacket.Marshaler.Write(message, syncInfo);
            CommonPacket.Marshaler.Write(message, syncBattlePoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveLobbySync, Common.CR_RequestFriendlyMatchObserveLobbySync);
        }

        public bool CR_RequestFriendlyMatchObserveReady(HostID remote, RmiContext rmiContext, byte teamIndex, int foodItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveReady);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, foodItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveReady, Common.CR_RequestFriendlyMatchObserveReady);
        }

        public bool CR_RequestFriendlyMatchObserveReadyOff(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveReadyOff);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveReadyOff, Common.CR_RequestFriendlyMatchObserveReadyOff);
        }

        public bool CR_RequestFriendlyMatchObserveChangeTeam(HostID remote, RmiContext rmiContext, OtherPlayerSimpleTeamInfo simpleTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveChangeTeam);
            CommonPacket.Marshaler.Write(message, simpleTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveChangeTeam, Common.CR_RequestFriendlyMatchObserveChangeTeam);
        }

        public bool CR_RequestFriendlyMatchObserveChangeMatchMode(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID, byte passiveID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveChangeMatchMode);
            CommonPacket.Marshaler.Write(message, matchMode);
            CommonPacket.Marshaler.Write(message, modeID);
            CommonPacket.Marshaler.Write(message, passiveID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveChangeMatchMode, Common.CR_RequestFriendlyMatchObserveChangeMatchMode);
        }

        public bool CR_RequestFriendlyMatchObserveTeamInfo(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveTeamInfo);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveTeamInfo, Common.CR_RequestFriendlyMatchObserveTeamInfo);
        }

        public bool CR_RequestFriendlyMatchObserveKickOut(HostID remote, RmiContext rmiContext, long kickUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveKickOut);
            CommonPacket.Marshaler.Write(message, kickUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveKickOut, Common.CR_RequestFriendlyMatchObserveKickOut);
        }

        public bool CR_RequestFriendlyMatchObserveStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveStart, Common.CR_RequestFriendlyMatchObserveStart);
        }

        public bool CR_RequestFriendlyMatchObserveSync(HostID remote, RmiContext rmiContext, string strSync, PvpSkillDataInfo pvpSkillDataInfo, string replaySync)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveSync);
            CommonPacket.Marshaler.Write(message, strSync);
            CommonPacket.Marshaler.Write(message, pvpSkillDataInfo);
            CommonPacket.Marshaler.Write(message, replaySync);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveSync, Common.CR_RequestFriendlyMatchObserveSync);
        }

        public bool CR_RequestFriendlyMatchObserveExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveExit, Common.CR_RequestFriendlyMatchObserveExit);
        }

        public bool CR_RequestFriendlyMatchObserveChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveChatEnter, Common.CR_RequestFriendlyMatchObserveChatEnter);
        }

        public bool CR_RequestFriendlyMatchObserveReadyTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveReadyTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveReadyTimeOver, Common.CR_RequestFriendlyMatchObserveReadyTimeOver);
        }

        public bool CR_RequestFriendlyMatchObserveInGameReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveInGameReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveInGameReady, Common.CR_RequestFriendlyMatchObserveInGameReady);
        }

        public bool CR_RequestFriendlyMatchObserveInGameExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveInGameExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveInGameExit, Common.CR_RequestFriendlyMatchObserveInGameExit);
        }

        public bool CR_RequestFriendlyMatchObserveChangeUserMode(HostID remote, RmiContext rmiContext, long targetUSN, byte userMode)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveChangeUserMode);
            CommonPacket.Marshaler.Write(message, targetUSN);
            CommonPacket.Marshaler.Write(message, userMode);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveChangeUserMode, Common.CR_RequestFriendlyMatchObserveChangeUserMode);
        }

        public bool CR_RequestFriendlyMatchObserveReplayStart(HostID remote, RmiContext rmiContext, ReplayBytesInfo replayBytesInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveReplayStart);
            CommonPacket.Marshaler.Write(message, replayBytesInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveReplayStart, Common.CR_RequestFriendlyMatchObserveReplayStart);
        }

        public bool CR_RequestFriendlyMatchObserveUserStatus(HostID remote, RmiContext rmiContext, byte status)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveUserStatus);
            CommonPacket.Marshaler.Write(message, status);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveUserStatus, Common.CR_RequestFriendlyMatchObserveUserStatus);
        }

        public bool CR_RequestFriendlyMatchObserveLobbyHeartBeat(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveLobbyHeartBeat);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveLobbyHeartBeat, Common.CR_RequestFriendlyMatchObserveLobbyHeartBeat);
        }

        public bool CR_RequestFriendlyMatchObserveReadyOffAll(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveReadyOffAll);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveReadyOffAll, Common.CR_RequestFriendlyMatchObserveReadyOffAll);
        }

        public bool CR_RequestFriendlyMatchObserveInGameClear(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveInGameClear);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveInGameClear, Common.CR_RequestFriendlyMatchObserveInGameClear);
        }

        public bool CR_RequestFriendlyMatchObserveInGameHeartBeat(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestFriendlyMatchObserveInGameHeartBeat);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestFriendlyMatchObserveInGameHeartBeat, Common.CR_RequestFriendlyMatchObserveInGameHeartBeat);
        }

        public bool CR_RequestArenaRealTimePVPLimitLogin(HostID remote, RmiContext rmiContext, RelayConnRequest connRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLimitLogin);
            CommonPacket.Marshaler.Write(message, connRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLimitLogin, Common.CR_RequestArenaRealTimePVPLimitLogin);
        }

        public bool CR_RequestArenaRealTimePVPLimitReady(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLimitReady);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLimitReady, Common.CR_RequestArenaRealTimePVPLimitReady);
        }

        public bool CR_RequestArenaRealTimePVPLimitSync(HostID remote, RmiContext rmiContext, string strSync, PvpSkillDataInfo pvpSkillDataInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLimitSync);
            CommonPacket.Marshaler.Write(message, strSync);
            CommonPacket.Marshaler.Write(message, pvpSkillDataInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLimitSync, Common.CR_RequestArenaRealTimePVPLimitSync);
        }

        public bool CR_RequestArenaRealTimePVPLimitExit(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLimitExit);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLimitExit, Common.CR_RequestArenaRealTimePVPLimitExit);
        }

        public bool CR_RequestArenaRealTimePVPLimitReadyTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLimitReadyTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLimitReadyTimeOver, Common.CR_RequestArenaRealTimePVPLimitReadyTimeOver);
        }

        public bool CR_RequestArenaRealTimePVPLimitChatEnter(HostID remote, RmiContext rmiContext, int stampID, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLimitChatEnter);
            CommonPacket.Marshaler.Write(message, stampID);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLimitChatEnter, Common.CR_RequestArenaRealTimePVPLimitChatEnter);
        }

        public bool CR_RequestArenaRealTimePVPLimitJoinTimeOver(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CR_RequestArenaRealTimePVPLimitJoinTimeOver);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CR_RequestArenaRealTimePVPLimitJoinTimeOver, Common.CR_RequestArenaRealTimePVPLimitJoinTimeOver);
        }

        public override RmiID[] GetRmiIDList()
        {
            return Common.RmiIDList;
        }

        public const string RmiName_CR_RequestArenaRealTimePVPLogin = "CR_RequestArenaRealTimePVPLogin";

        public const string RmiName_CR_RequestArenaRealTimePVPReady = "CR_RequestArenaRealTimePVPReady";

        public const string RmiName_CR_RequestArenaRealTimePVPSync = "CR_RequestArenaRealTimePVPSync";

        public const string RmiName_CR_RequestArenaRealTimePVPExit = "CR_RequestArenaRealTimePVPExit";

        public const string RmiName_CR_RequestArenaRealTimePVPReadyTimeOver = "CR_RequestArenaRealTimePVPReadyTimeOver";

        public const string RmiName_CR_RequestArenaRealTimePVPChatEnter = "CR_RequestArenaRealTimePVPChatEnter";

        public const string RmiName_CR_RequestArenaRealTimePVPJoinTimeOver = "CR_RequestArenaRealTimePVPJoinTimeOver";

        public const string RmiName_CR_RequestDestroyLogin = "CR_RequestDestroyLogin";

        public const string RmiName_CR_RequestDestroyReLogin = "CR_RequestDestroyReLogin";

        public const string RmiName_CR_RequestDestroyRelayReady = "CR_RequestDestroyRelayReady";

        public const string RmiName_CR_RequestDestroyLobbySync = "CR_RequestDestroyLobbySync";

        public const string RmiName_CR_RequestDestroyChatEnter = "CR_RequestDestroyChatEnter";

        public const string RmiName_CR_RequestDestroyReady = "CR_RequestDestroyReady";

        public const string RmiName_CR_RequestDestroyReturnReady = "CR_RequestDestroyReturnReady";

        public const string RmiName_CR_RequestDestroyKickOut = "CR_RequestDestroyKickOut";

        public const string RmiName_CR_RequestDestroyChangeTeamInfo = "CR_RequestDestroyChangeTeamInfo";

        public const string RmiName_CR_RequestDestroyMemberTeamInfo = "CR_RequestDestroyMemberTeamInfo";

        public const string RmiName_CR_RequestDestroyStart = "CR_RequestDestroyStart";

        public const string RmiName_CR_RequestDestroyIngameReady = "CR_RequestDestroyIngameReady";

        public const string RmiName_CR_RequestDestroySelectSkillCard = "CR_RequestDestroySelectSkillCard";

        public const string RmiName_CR_RequestDestroyRoundFinish = "CR_RequestDestroyRoundFinish";

        public const string RmiName_CR_RequestDestroyNeedSync = "CR_RequestDestroyNeedSync";

        public const string RmiName_CR_RequestDestroySync = "CR_RequestDestroySync";

        public const string RmiName_CR_RequestDestroyIngameFinish = "CR_RequestDestroyIngameFinish";

        public const string RmiName_CR_RequestDestroyExit = "CR_RequestDestroyExit";

        public const string RmiName_CR_RequestDestroyTestExit = "CR_RequestDestroyTestExit";

        public const string RmiName_CR_RequestGuildLogin = "CR_RequestGuildLogin";

        public const string RmiName_CR_RequestGuildRoomJoin = "CR_RequestGuildRoomJoin";

        public const string RmiName_CR_RequestGuildRoomOut = "CR_RequestGuildRoomOut";

        public const string RmiName_CR_RequestGuildRoomMemberInfo = "CR_RequestGuildRoomMemberInfo";

        public const string RmiName_CR_RequestGuildRoomSync = "CR_RequestGuildRoomSync";

        public const string RmiName_CR_RequestGuildRoomMemberInfoSync = "CR_RequestGuildRoomMemberInfoSync";

        public const string RmiName_CR_RequestGuildRoomKickOutMember = "CR_RequestGuildRoomKickOutMember";

        public const string RmiName_CR_RequestGuildRoomLeaveMember = "CR_RequestGuildRoomLeaveMember";

        public const string RmiName_CR_RequestFriendlyMatchLogin = "CR_RequestFriendlyMatchLogin";

        public const string RmiName_CR_RequestFriendlyMatchLobbySync = "CR_RequestFriendlyMatchLobbySync";

        public const string RmiName_CR_RequestFriendlyMatchReady = "CR_RequestFriendlyMatchReady";

        public const string RmiName_CR_RequestFriendlyMatchReadyOff = "CR_RequestFriendlyMatchReadyOff";

        public const string RmiName_CR_RequestFriendlyMatchChangeTeam = "CR_RequestFriendlyMatchChangeTeam";

        public const string RmiName_CR_RequestFriendlyMatchChangeMatchMode = "CR_RequestFriendlyMatchChangeMatchMode";

        public const string RmiName_CR_RequestFriendlyMatchTeamInfo = "CR_RequestFriendlyMatchTeamInfo";

        public const string RmiName_CR_RequestFriendlyMatchKickOut = "CR_RequestFriendlyMatchKickOut";

        public const string RmiName_CR_RequestFriendlyMatchStart = "CR_RequestFriendlyMatchStart";

        public const string RmiName_CR_RequestFriendlyMatchSync = "CR_RequestFriendlyMatchSync";

        public const string RmiName_CR_RequestFriendlyMatchExit = "CR_RequestFriendlyMatchExit";

        public const string RmiName_CR_RequestFriendlyMatchChatEnter = "CR_RequestFriendlyMatchChatEnter";

        public const string RmiName_CR_RequestFriendlyMatchReadyTimeOver = "CR_RequestFriendlyMatchReadyTimeOver";

        public const string RmiName_CR_RequestFriendlyMatchInGameReady = "CR_RequestFriendlyMatchInGameReady";

        public const string RmiName_CR_RequestFriendlyMatchInGameExit = "CR_RequestFriendlyMatchInGameExit";

        public const string RmiName_CR_RequestFriendlyMatchChangeUserMode = "CR_RequestFriendlyMatchChangeUserMode";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerLogin = "CR_RequestArenaRealTimePVPLowerLogin";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerReady = "CR_RequestArenaRealTimePVPLowerReady";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerSync = "CR_RequestArenaRealTimePVPLowerSync";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerExit = "CR_RequestArenaRealTimePVPLowerExit";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerReadyTimeOver = "CR_RequestArenaRealTimePVPLowerReadyTimeOver";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerChatEnter = "CR_RequestArenaRealTimePVPLowerChatEnter";

        public const string RmiName_CR_RequestArenaRealTimePVPLowerJoinTimeOver = "CR_RequestArenaRealTimePVPLowerJoinTimeOver";

        public const string RmiName_CR_RequestArenaRankingConnect = "CR_RequestArenaRankingConnect";

        public const string RmiName_CR_RequestArenaRankingLogin = "CR_RequestArenaRankingLogin";

        public const string RmiName_CR_RequestArenaRankingReady = "CR_RequestArenaRankingReady";

        public const string RmiName_CR_RequestArenaRankingSync = "CR_RequestArenaRankingSync";

        public const string RmiName_CR_RequestArenaRankingExit = "CR_RequestArenaRankingExit";

        public const string RmiName_CR_RequestArenaRankingReadyTimeOver = "CR_RequestArenaRankingReadyTimeOver";

        public const string RmiName_CR_RequestArenaRankingChatEnter = "CR_RequestArenaRankingChatEnter";

        public const string RmiName_CR_RequestArenaRankingJoinTimeOver = "CR_RequestArenaRankingJoinTimeOver";

        public const string RmiName_CR_RequestTournamentMatchLogin = "CR_RequestTournamentMatchLogin";

        public const string RmiName_CR_RequestTournamentMatchChangeTeam = "CR_RequestTournamentMatchChangeTeam";

        public const string RmiName_CR_RequestTournamentMatchReady = "CR_RequestTournamentMatchReady";

        public const string RmiName_CR_RequestTournamentMatchInGameReady = "CR_RequestTournamentMatchInGameReady";

        public const string RmiName_CR_RequestTournamentMatchInGameTimeOver = "CR_RequestTournamentMatchInGameTimeOver";

        public const string RmiName_CR_RequestTournamentMatchInGameSync = "CR_RequestTournamentMatchInGameSync";

        public const string RmiName_CR_RequestTournamentMatchInGameGiveup = "CR_RequestTournamentMatchInGameGiveup";

        public const string RmiName_CR_RequestTournamentMatchInGameExit = "CR_RequestTournamentMatchInGameExit";

        public const string RmiName_CR_RequestTournamentMatchChatEnter = "CR_RequestTournamentMatchChatEnter";

        public const string RmiName_CR_RequestTournamentMatchExit = "CR_RequestTournamentMatchExit";

        public const string RmiName_CR_RequestTournamentWatcherLogin = "CR_RequestTournamentWatcherLogin";

        public const string RmiName_CR_RequestTournamentWatcherExit = "CR_RequestTournamentWatcherExit";

        public const string RmiName_CR_RequestTournamentMatchReplayStart = "CR_RequestTournamentMatchReplayStart";

        public const string RmiName_CR_RequestTournamentMatchInGameClear = "CR_RequestTournamentMatchInGameClear";

        public const string RmiName_CR_RequestSubdueLogin = "CR_RequestSubdueLogin";

        public const string RmiName_CR_requestSubdueReLogin = "CR_requestSubdueReLogin";

        public const string RmiName_CR_RequestSubdueReady = "CR_RequestSubdueReady";

        public const string RmiName_CR_RequestSubdueReturnReady = "CR_RequestSubdueReturnReady";

        public const string RmiName_CR_RequestSubdueLeave = "CR_RequestSubdueLeave";

        public const string RmiName_CR_RequestSubdueKickout = "CR_RequestSubdueKickout";

        public const string RmiName_CR_RequestSubdueGameStart = "CR_RequestSubdueGameStart";

        public const string RmiName_CR_RequestSubdueBattleSync = "CR_RequestSubdueBattleSync";

        public const string RmiName_CR_RequestSubdueBattleEnd = "CR_RequestSubdueBattleEnd";

        public const string RmiName_CR_RequestFriendlyMatchObserveLogin = "CR_RequestFriendlyMatchObserveLogin";

        public const string RmiName_CR_RequestFriendlyMatchObserveLobbySync = "CR_RequestFriendlyMatchObserveLobbySync";

        public const string RmiName_CR_RequestFriendlyMatchObserveReady = "CR_RequestFriendlyMatchObserveReady";

        public const string RmiName_CR_RequestFriendlyMatchObserveReadyOff = "CR_RequestFriendlyMatchObserveReadyOff";

        public const string RmiName_CR_RequestFriendlyMatchObserveChangeTeam = "CR_RequestFriendlyMatchObserveChangeTeam";

        public const string RmiName_CR_RequestFriendlyMatchObserveChangeMatchMode = "CR_RequestFriendlyMatchObserveChangeMatchMode";

        public const string RmiName_CR_RequestFriendlyMatchObserveTeamInfo = "CR_RequestFriendlyMatchObserveTeamInfo";

        public const string RmiName_CR_RequestFriendlyMatchObserveKickOut = "CR_RequestFriendlyMatchObserveKickOut";

        public const string RmiName_CR_RequestFriendlyMatchObserveStart = "CR_RequestFriendlyMatchObserveStart";

        public const string RmiName_CR_RequestFriendlyMatchObserveSync = "CR_RequestFriendlyMatchObserveSync";

        public const string RmiName_CR_RequestFriendlyMatchObserveExit = "CR_RequestFriendlyMatchObserveExit";

        public const string RmiName_CR_RequestFriendlyMatchObserveChatEnter = "CR_RequestFriendlyMatchObserveChatEnter";

        public const string RmiName_CR_RequestFriendlyMatchObserveReadyTimeOver = "CR_RequestFriendlyMatchObserveReadyTimeOver";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameReady = "CR_RequestFriendlyMatchObserveInGameReady";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameExit = "CR_RequestFriendlyMatchObserveInGameExit";

        public const string RmiName_CR_RequestFriendlyMatchObserveChangeUserMode = "CR_RequestFriendlyMatchObserveChangeUserMode";

        public const string RmiName_CR_RequestFriendlyMatchObserveReplayStart = "CR_RequestFriendlyMatchObserveReplayStart";

        public const string RmiName_CR_RequestFriendlyMatchObserveUserStatus = "CR_RequestFriendlyMatchObserveUserStatus";

        public const string RmiName_CR_RequestFriendlyMatchObserveLobbyHeartBeat = "CR_RequestFriendlyMatchObserveLobbyHeartBeat";

        public const string RmiName_CR_RequestFriendlyMatchObserveReadyOffAll = "CR_RequestFriendlyMatchObserveReadyOffAll";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameClear = "CR_RequestFriendlyMatchObserveInGameClear";

        public const string RmiName_CR_RequestFriendlyMatchObserveInGameHeartBeat = "CR_RequestFriendlyMatchObserveInGameHeartBeat";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitLogin = "CR_RequestArenaRealTimePVPLimitLogin";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitReady = "CR_RequestArenaRealTimePVPLimitReady";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitSync = "CR_RequestArenaRealTimePVPLimitSync";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitExit = "CR_RequestArenaRealTimePVPLimitExit";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitReadyTimeOver = "CR_RequestArenaRealTimePVPLimitReadyTimeOver";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitChatEnter = "CR_RequestArenaRealTimePVPLimitChatEnter";

        public const string RmiName_CR_RequestArenaRealTimePVPLimitJoinTimeOver = "CR_RequestArenaRealTimePVPLimitJoinTimeOver";

        public const string RmiName_First = "CR_RequestArenaRealTimePVPLogin";

    }
}
