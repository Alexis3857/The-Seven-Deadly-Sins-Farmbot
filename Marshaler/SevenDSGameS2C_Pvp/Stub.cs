using Nettention.Proud;

namespace SevenDSGameS2C_Pvp
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
                    case Common.CG_RequestArenaRealTimePvpLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpJoinOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpTopRankerListOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpTopRankerListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLastRankerListOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLastRankerListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpMatchingOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpMatchingOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpBattleEndOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpBattleEndOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpRollbackOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpRollbackOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpIngameBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpIngameBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerJoinOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerTopRankerListOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerTopRankerListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerMatchingOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerMatchingOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerBattleEndOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerBattleEndOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpAllInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpAllInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLastRankerBattleInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLastRankerBattleInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLastRankerBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLastRankerBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerRollbackOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerRollbackOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLowerIngameBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerIngameBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingJoinOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingTopRankerListOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingTopRankerListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingMatchingOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingMatchingOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingBattleEndOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingBattleEndOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingIngameBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingIngameBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingDefenceTeamUpdateOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingDefenceTeamUpdateOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPvpSeasonInfoOK:
                        this.ProcessReceivedMessage_CG_RequestPvpSeasonInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPvpSeasonHistoryOK:
                        this.ProcessReceivedMessage_CG_RequestPvpSeasonHistoryOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCurrentTopRankingOK:
                        this.ProcessReceivedMessage_CG_RequestCurrentTopRankingOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestLastTopRankingOK:
                        this.ProcessReceivedMessage_CG_RequestLastTopRankingOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPvpAbuseReportOK:
                        this.ProcessReceivedMessage_CG_RequestPvpAbuseReportOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPvpAllRewardOK:
                        this.ProcessReceivedMessage_CG_RequestPvpAllRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPvpAllJoinOK:
                        this.ProcessReceivedMessage_CG_RequestPvpAllJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRankingServerconnectOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRankingServerconnectOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAreanRankingJoinTimeOverServerOK:
                        this.ProcessReceivedMessage_CG_RequestAreanRankingJoinTimeOverServerOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashTeamSlotChangeOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashTeamSlotChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashDefenceTeamUpdateOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashDefenceTeamUpdateOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashJoinOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashOpponentListOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashOpponentListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashOpponentListReloadOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashOpponentListReloadOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashOpponentTeamInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashOpponentTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashMatchJoinOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashMatchJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashMatchBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashMatchBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashMatchBattleEndOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashMatchBattleEndOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashWinRewardOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashWinRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashBestRefreshOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashBestRefreshOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashBestRewardOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashBestRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashRecordListOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashRecordListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashRankRewardOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashRankRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashRankInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashRankInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashMatchInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashMatchInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentListOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentProgressInfoOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentProgressInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentResultInfoOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentResultInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentMatchJoinOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentMatchJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentMatchBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentMatchBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentMatchBattleEndOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentMatchBattleEndOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentMatchExitOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentMatchExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.GC_NotifyTournamentProgressChange:
                        this.ProcessReceivedMessage_GC_NotifyTournamentProgressChange(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentRewardOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.GC_NotifyTournamentMatchSuspend:
                        this.ProcessReceivedMessage_GC_NotifyTournamentMatchSuspend(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentPlayerTeamSlotChangeOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentPlayerTeamSlotChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentPlayerTeamInfoOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentPlayerTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentCheerOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentCheerOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentCheerListOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentCheerListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentWatcherJoinOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentWatcherJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentWatcherExitOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentWatcherExitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentMatchPlayInfoOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentMatchPlayInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestTournamentReplayInfoOK:
                        this.ProcessReceivedMessage_CG_RequestTournamentReplayInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitJoinOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitJoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitMatchingOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitMatchingOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitBattleEndOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitBattleEndOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitIngameBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitIngameBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitTeamChangeOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitTeamChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitTopRankerListOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitTopRankerListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpLimitRankRewardOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitRankRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
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

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLobbyInfo);
            APInfo leagueTicketInfo;
            CommonPacket.Marshaler.Read(__msg, out leagueTicketInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLobbyInfoOK(remote, rmiContext, arenaRealTimePvpLobbyInfo, leagueTicketInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpJoinOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpJoinOK(remote, rmiContext, arenaRealTimePvpLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpJoinOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpTopRankerListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList;
            CommonPacket.Marshaler.Read(__msg, out rankerUserInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpTopRankerListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpTopRankerListOK(remote, rmiContext, rankerUserInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpTopRankerListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLastRankerListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpLowerRankerList;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLowerRankerList);
            List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpRankerList;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpRankerList);
            List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpLimitRankerList;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLimitRankerList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLastRankerListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLastRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLastRankerListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLastRankerListOK(remote, rmiContext, arenaRealTimePvpLowerRankerList, arenaRealTimePvpRankerList, arenaRealTimePvpLimitRankerList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLastRankerListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLastRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLastRankerListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpMatchingOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpMatchingOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpMatchingOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpMatchingOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpMatchingOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpMatchingOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpBattleStartResult battleStartResult;
            CommonPacket.Marshaler.Read(__msg, out battleStartResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpBattleStartOK(remote, rmiContext, battleStartResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpBattleEndOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpBattleEndResult battleEndResult;
            CommonPacket.Marshaler.Read(__msg, out battleEndResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpBattleEndOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpBattleEndOK(remote, rmiContext, battleEndResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpBattleEndOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpRollbackOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ApRewardInfo apRewardInfo;
            CommonPacket.Marshaler.Read(__msg, out apRewardInfo);
            ItemResultInfo rollbakItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out rollbakItemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpRollbackOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpRollbackOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpRollbackOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpRollbackOK(remote, rmiContext, apRewardInfo, rollbakItemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpRollbackOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpRollbackOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpRollbackOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpIngameBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpGameStartResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpIngameBattleStartOK(remote, rmiContext, pvpGameStartResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLobbyInfo);
            APInfo leagueTicketInfo;
            CommonPacket.Marshaler.Read(__msg, out leagueTicketInfo);
            UserTeam eventUserTeam;
            CommonPacket.Marshaler.Read(__msg, out eventUserTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerLobbyInfoOK(remote, rmiContext, arenaRealTimePvpLobbyInfo, leagueTicketInfo, eventUserTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLobbyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerJoinOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerJoinOK(remote, rmiContext, arenaRealTimePvpLobbyInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerJoinOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerTopRankerListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList;
            CommonPacket.Marshaler.Read(__msg, out rankerUserInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerTopRankerListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerTopRankerListOK(remote, rmiContext, rankerUserInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerTopRankerListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerMatchingOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerMatchingOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerMatchingOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerMatchingOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerMatchingOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerMatchingOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpBattleStartResult battleStartResult;
            CommonPacket.Marshaler.Read(__msg, out battleStartResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerBattleStartOK(remote, rmiContext, battleStartResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerBattleEndOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpBattleEndResult battleEndResult;
            CommonPacket.Marshaler.Read(__msg, out battleEndResult);
            bool enterPvpUpper;
            CommonPacket.Marshaler.Read(__msg, out enterPvpUpper);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerBattleEndOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerBattleEndOK(remote, rmiContext, battleEndResult, enterPvpUpper))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerBattleEndOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpAllInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvp_LoginInfo arenaRealTimePvpSimpleInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpSimpleInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpAllInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpAllInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpAllInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpAllInfoOK(remote, rmiContext, arenaRealTimePvpSimpleInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpAllInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpAllInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpAllInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLastRankerBattleInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte rank;
            CommonPacket.Marshaler.Read(__msg, out rank);
            ArenaLeagueOpponentInfo oppUserInfo;
            CommonPacket.Marshaler.Read(__msg, out oppUserInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLastRankerBattleInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLastRankerBattleInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLastRankerBattleInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLastRankerBattleInfoOK(remote, rmiContext, rank, oppUserInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLastRankerBattleInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLastRankerBattleInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLastRankerBattleInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLastRankerBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpRankerBattleStartResult battleStartResult;
            CommonPacket.Marshaler.Read(__msg, out battleStartResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLastRankerBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLastRankerBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLastRankerBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLastRankerBattleStartOK(remote, rmiContext, battleStartResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLastRankerBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLastRankerBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLastRankerBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerRollbackOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ApRewardInfo apRewardInfo;
            CommonPacket.Marshaler.Read(__msg, out apRewardInfo);
            ItemResultInfo rollbakItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out rollbakItemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerRollbackOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerRollbackOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerRollbackOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerRollbackOK(remote, rmiContext, apRewardInfo, rollbakItemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerRollbackOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerRollbackOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerRollbackOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLowerIngameBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpGameStartResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLowerIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLowerIngameBattleStartOK(remote, rmiContext, pvpGameStartResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLowerIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLowerIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLowerIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRankingLobbyInfo arenaRankingLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRankingLobbyInfo);
            APInfo leagueTicketInfo;
            CommonPacket.Marshaler.Read(__msg, out leagueTicketInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRankingLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingLobbyInfoOK(remote, rmiContext, arenaRankingLobbyInfo, leagueTicketInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRankingLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRankingLobbyInfo arenaRankingLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRankingLobbyInfo);
            List<UserTeam> arenaReankingTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out arenaReankingTeamInfoList);
            OtherPlayerTeamInfo arenaRankingDefenceTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRankingDefenceTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingJoinOK,
                    rmiName = RmiName_CG_RequestArenaRankingJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingJoinOK(remote, rmiContext, arenaRankingLobbyInfo, arenaReankingTeamInfoList, arenaRankingDefenceTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingJoinOK,
                    rmiName = RmiName_CG_RequestArenaRankingJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingTopRankerListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList;
            CommonPacket.Marshaler.Read(__msg, out rankerUserInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingTopRankerListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRankingTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingTopRankerListOK(remote, rmiContext, rankerUserInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingTopRankerListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRankingTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingMatchingOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool matchingAble;
            CommonPacket.Marshaler.Read(__msg, out matchingAble);
            RelayServerInfo arenaRankingRelayServerInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRankingRelayServerInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingMatchingOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRankingMatchingOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingMatchingOK(remote, rmiContext, matchingAble, arenaRankingRelayServerInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingMatchingOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRankingMatchingOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpBattleStartResult battleStartResult;
            CommonPacket.Marshaler.Read(__msg, out battleStartResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRankingBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingBattleStartOK(remote, rmiContext, battleStartResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRankingBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingBattleEndOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRankingBattleEndResult battleEndResult;
            CommonPacket.Marshaler.Read(__msg, out battleEndResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingBattleEndOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRankingBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingBattleEndOK(remote, rmiContext, battleEndResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingBattleEndOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRankingBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingIngameBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpGameStartResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRankingIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingIngameBattleStartOK(remote, rmiContext, pvpGameStartResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRankingIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingDefenceTeamUpdateOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            OtherPlayerTeamInfo otherTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out otherTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingDefenceTeamUpdateOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingDefenceTeamUpdateOK,
                    rmiName = RmiName_CG_RequestArenaRankingDefenceTeamUpdateOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingDefenceTeamUpdateOK(remote, rmiContext, otherTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingDefenceTeamUpdateOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingDefenceTeamUpdateOK,
                    rmiName = RmiName_CG_RequestArenaRankingDefenceTeamUpdateOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPvpSeasonInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int mySeasonPoint;
            CommonPacket.Marshaler.Read(__msg, out mySeasonPoint);
            int mySeasonRank;
            CommonPacket.Marshaler.Read(__msg, out mySeasonRank);
            List<PvpSeasonLastWeeklyUserInfo> pvpRankList;
            CommonPacket.Marshaler.Read(__msg, out pvpRankList);
            PvpSeasonRewardInfo pvpSeasonRewardInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpSeasonRewardInfo);
            PvpSeasonLastWeekInfo pvpSeasonLastWeekInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpSeasonLastWeekInfo);
            int currentSeasonID;
            CommonPacket.Marshaler.Read(__msg, out currentSeasonID);
            int arenaRealTimedecisionRemainSEC;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimedecisionRemainSEC);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPvpSeasonInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpSeasonInfoOK,
                    rmiName = RmiName_CG_RequestPvpSeasonInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPvpSeasonInfoOK(remote, rmiContext, mySeasonPoint, mySeasonRank, pvpRankList, pvpSeasonRewardInfo, pvpSeasonLastWeekInfo, currentSeasonID, arenaRealTimedecisionRemainSEC))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPvpSeasonInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpSeasonInfoOK,
                    rmiName = RmiName_CG_RequestPvpSeasonInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPvpSeasonHistoryOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int selectSeasonID;
            CommonPacket.Marshaler.Read(__msg, out selectSeasonID);
            List<PvpSeasonHistoryInfo> pvpSeasonHistoryInfoList;
            CommonPacket.Marshaler.Read(__msg, out pvpSeasonHistoryInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPvpSeasonHistoryOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpSeasonHistoryOK,
                    rmiName = RmiName_CG_RequestPvpSeasonHistoryOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPvpSeasonHistoryOK(remote, rmiContext, selectSeasonID, pvpSeasonHistoryInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPvpSeasonHistoryOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpSeasonHistoryOK,
                    rmiName = RmiName_CG_RequestPvpSeasonHistoryOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCurrentTopRankingOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            PVPRankingInfo pvpRankingInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpRankingInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCurrentTopRankingOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCurrentTopRankingOK,
                    rmiName = RmiName_CG_RequestCurrentTopRankingOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCurrentTopRankingOK(remote, rmiContext, pvpRankingInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCurrentTopRankingOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCurrentTopRankingOK,
                    rmiName = RmiName_CG_RequestCurrentTopRankingOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestLastTopRankingOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            PVPRankingInfo pvpRankingInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpRankingInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestLastTopRankingOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestLastTopRankingOK,
                    rmiName = RmiName_CG_RequestLastTopRankingOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestLastTopRankingOK(remote, rmiContext, pvpRankingInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestLastTopRankingOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestLastTopRankingOK,
                    rmiName = RmiName_CG_RequestLastTopRankingOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPvpAbuseReportOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPvpAbuseReportOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpAbuseReportOK,
                    rmiName = RmiName_CG_RequestPvpAbuseReportOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPvpAbuseReportOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPvpAbuseReportOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpAbuseReportOK,
                    rmiName = RmiName_CG_RequestPvpAbuseReportOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPvpAllRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaAllRewardResultInfo lowerResultInfo;
            CommonPacket.Marshaler.Read(__msg, out lowerResultInfo);
            ArenaAllRewardResultInfo upperResultInfo;
            CommonPacket.Marshaler.Read(__msg, out upperResultInfo);
            ArenaAllRewardResultInfo rankingResultInfo;
            CommonPacket.Marshaler.Read(__msg, out rankingResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPvpAllRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpAllRewardOK,
                    rmiName = RmiName_CG_RequestPvpAllRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPvpAllRewardOK(remote, rmiContext, lowerResultInfo, upperResultInfo, rankingResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPvpAllRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpAllRewardOK,
                    rmiName = RmiName_CG_RequestPvpAllRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPvpAllJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool lowerJoin;
            CommonPacket.Marshaler.Read(__msg, out lowerJoin);
            bool upperJoin;
            CommonPacket.Marshaler.Read(__msg, out upperJoin);
            bool rankingJoin;
            CommonPacket.Marshaler.Read(__msg, out rankingJoin);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPvpAllJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpAllJoinOK,
                    rmiName = RmiName_CG_RequestPvpAllJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPvpAllJoinOK(remote, rmiContext, lowerJoin, upperJoin, rankingJoin, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPvpAllJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPvpAllJoinOK,
                    rmiName = RmiName_CG_RequestPvpAllJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRankingServerconnectOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRankingLobbyInfo arenaRankingLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRankingLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRankingServerconnectOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingServerconnectOK,
                    rmiName = RmiName_CG_RequestArenaRankingServerconnectOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRankingServerconnectOK(remote, rmiContext, arenaRankingLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRankingServerconnectOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRankingServerconnectOK,
                    rmiName = RmiName_CG_RequestArenaRankingServerconnectOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAreanRankingJoinTimeOverServerOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRankingLobbyInfo arenaRankingLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRankingLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAreanRankingJoinTimeOverServerOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAreanRankingJoinTimeOverServerOK,
                    rmiName = RmiName_CG_RequestAreanRankingJoinTimeOverServerOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAreanRankingJoinTimeOverServerOK(remote, rmiContext, arenaRankingLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAreanRankingJoinTimeOverServerOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAreanRankingJoinTimeOverServerOK,
                    rmiName = RmiName_CG_RequestAreanRankingJoinTimeOverServerOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashTeamSlotChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashTeamSlotChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashTeamSlotChangeOK,
                    rmiName = RmiName_CG_RequestArenaSmashTeamSlotChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashTeamSlotChangeOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashTeamSlotChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashTeamSlotChangeOK,
                    rmiName = RmiName_CG_RequestArenaSmashTeamSlotChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashDefenceTeamUpdateOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<OtherPlayerTeamInfo> arenaSmashDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashDefenceTeamInfoList);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            byte teamUpdateCount;
            CommonPacket.Marshaler.Read(__msg, out teamUpdateCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashDefenceTeamUpdateOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashDefenceTeamUpdateOK,
                    rmiName = RmiName_CG_RequestArenaSmashDefenceTeamUpdateOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashDefenceTeamUpdateOK(remote, rmiContext, arenaSmashDefenceTeamInfoList, useItemResultInfoList, teamUpdateCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashDefenceTeamUpdateOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashDefenceTeamUpdateOK,
                    rmiName = RmiName_CG_RequestArenaSmashDefenceTeamUpdateOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte teamIndex;
            CommonPacket.Marshaler.Read(__msg, out teamIndex);
            int foodBuffItemID;
            CommonPacket.Marshaler.Read(__msg, out foodBuffItemID);
            OtherPlayerTeamInfo arenaSmashDefenceTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashDefenceTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK,
                    rmiName = RmiName_CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK(remote, rmiContext, teamIndex, foodBuffItemID, arenaSmashDefenceTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK,
                    rmiName = RmiName_CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashLobbyInfo arenaSmashLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashLobbyInfo);
            List<OtherPlayerTeamInfo> arenaSmashTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashLobbyInfoOK(remote, rmiContext, arenaSmashLobbyInfo, arenaSmashTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashUserInfo arenaSmashUserInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashUserInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashJoinOK,
                    rmiName = RmiName_CG_RequestArenaSmashJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashJoinOK(remote, rmiContext, arenaSmashUserInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashJoinOK,
                    rmiName = RmiName_CG_RequestArenaSmashJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashOpponentListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int userRank;
            CommonPacket.Marshaler.Read(__msg, out userRank);
            int totalCount;
            CommonPacket.Marshaler.Read(__msg, out totalCount);
            List<ArenaSmashOpponentInfo> opponentInfoList;
            CommonPacket.Marshaler.Read(__msg, out opponentInfoList);
            int opponentListExpireRemainSec;
            CommonPacket.Marshaler.Read(__msg, out opponentListExpireRemainSec);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashOpponentListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOpponentListOK,
                    rmiName = RmiName_CG_RequestArenaSmashOpponentListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashOpponentListOK(remote, rmiContext, userRank, totalCount, opponentInfoList, opponentListExpireRemainSec))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashOpponentListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOpponentListOK,
                    rmiName = RmiName_CG_RequestArenaSmashOpponentListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashOpponentListReloadOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int userRank;
            CommonPacket.Marshaler.Read(__msg, out userRank);
            int totalCount;
            CommonPacket.Marshaler.Read(__msg, out totalCount);
            List<ArenaSmashOpponentInfo> opponentInfoList;
            CommonPacket.Marshaler.Read(__msg, out opponentInfoList);
            int opponentListRemainSec;
            CommonPacket.Marshaler.Read(__msg, out opponentListRemainSec);
            int opponentListExpireRemainSec;
            CommonPacket.Marshaler.Read(__msg, out opponentListExpireRemainSec);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashOpponentListReloadOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOpponentListReloadOK,
                    rmiName = RmiName_CG_RequestArenaSmashOpponentListReloadOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashOpponentListReloadOK(remote, rmiContext, userRank, totalCount, opponentInfoList, opponentListRemainSec, opponentListExpireRemainSec))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashOpponentListReloadOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOpponentListReloadOK,
                    rmiName = RmiName_CG_RequestArenaSmashOpponentListReloadOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashOpponentTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashOpponentInfo opponentInfo;
            CommonPacket.Marshaler.Read(__msg, out opponentInfo);
            List<OtherPlayerTeamInfo> otherPlayerTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out otherPlayerTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashOpponentTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOpponentTeamInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashOpponentTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashOpponentTeamInfoOK(remote, rmiContext, opponentInfo, otherPlayerTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashOpponentTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOpponentTeamInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashOpponentTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashMatchJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashOpponentInfo opponentInfo;
            CommonPacket.Marshaler.Read(__msg, out opponentInfo);
            List<OtherPlayerTeamInfo> otherPlayerTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out otherPlayerTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashMatchJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchJoinOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashMatchJoinOK(remote, rmiContext, opponentInfo, otherPlayerTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashMatchJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchJoinOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashMatchBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashBattleStartResult battleStartResult;
            CommonPacket.Marshaler.Read(__msg, out battleStartResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashMatchBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashMatchBattleStartOK(remote, rmiContext, battleStartResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashMatchBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashMatchBattleEndOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashBattleEndResult battleEndResult;
            CommonPacket.Marshaler.Read(__msg, out battleEndResult);
            long recordSN;
            CommonPacket.Marshaler.Read(__msg, out recordSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashMatchBattleEndOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashMatchBattleEndOK(remote, rmiContext, battleEndResult, recordSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashMatchBattleEndOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashWinRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte winRewardPoint;
            CommonPacket.Marshaler.Read(__msg, out winRewardPoint);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            bool arenaSmashRewardAble;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashRewardAble);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashWinRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashWinRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashWinRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashWinRewardOK(remote, rmiContext, winRewardPoint, rewardItemInfoList, missionResult, arenaSmashRewardAble))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashWinRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashWinRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashWinRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashBestRefreshOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashUserInfo arenaSmashUserInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashUserInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashBestRefreshOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashBestRefreshOK,
                    rmiName = RmiName_CG_RequestArenaSmashBestRefreshOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashBestRefreshOK(remote, rmiContext, arenaSmashUserInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashBestRefreshOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashBestRefreshOK,
                    rmiName = RmiName_CG_RequestArenaSmashBestRefreshOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashBestRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int bestRank;
            CommonPacket.Marshaler.Read(__msg, out bestRank);
            bool bestReward;
            CommonPacket.Marshaler.Read(__msg, out bestReward);
            int bestResetRaminSec;
            CommonPacket.Marshaler.Read(__msg, out bestResetRaminSec);
            int rewardBestRank;
            CommonPacket.Marshaler.Read(__msg, out rewardBestRank);
            int rewardTotalCount;
            CommonPacket.Marshaler.Read(__msg, out rewardTotalCount);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            bool arenaSmashRewardAble;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashRewardAble);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashBestRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashBestRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashBestRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashBestRewardOK(remote, rmiContext, bestRank, bestReward, bestResetRaminSec, rewardBestRank, rewardTotalCount, rewardItemInfoList, missionResult, arenaSmashRewardAble))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashBestRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashBestRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashBestRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashRecordListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ArenaSmashRecordInfo> recordInfoList;
            CommonPacket.Marshaler.Read(__msg, out recordInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashRecordListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashRecordListOK,
                    rmiName = RmiName_CG_RequestArenaSmashRecordListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashRecordListOK(remote, rmiContext, recordInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashRecordListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashRecordListOK,
                    rmiName = RmiName_CG_RequestArenaSmashRecordListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte teamIndex;
            CommonPacket.Marshaler.Read(__msg, out teamIndex);
            int foodBuffItemID;
            CommonPacket.Marshaler.Read(__msg, out foodBuffItemID);
            ItemResultInfo itemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK,
                    rmiName = RmiName_CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK(remote, rmiContext, teamIndex, foodBuffItemID, itemResultInfo, missionResult, questProgressInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK,
                    rmiName = RmiName_CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashRankRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int userRank;
            CommonPacket.Marshaler.Read(__msg, out userRank);
            int serverUserRank;
            CommonPacket.Marshaler.Read(__msg, out serverUserRank);
            bool bestReward;
            CommonPacket.Marshaler.Read(__msg, out bestReward);
            int bestResetRaminSec;
            CommonPacket.Marshaler.Read(__msg, out bestResetRaminSec);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            bool arenaSmashRewardAble;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashRewardAble);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashRankRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashRankRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashRankRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashRankRewardOK(remote, rmiContext, userRank, serverUserRank, bestReward, bestResetRaminSec, rewardItemInfoList, missionResult, arenaSmashRewardAble))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashRankRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashRankRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashRankRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashRankInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ArenaSmashRankInfo> arenaSmashRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashRankInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashRankInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashRankInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashRankInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashRankInfoOK(remote, rmiContext, arenaSmashRankInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashRankInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashRankInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashRankInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashMatchInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int totalCount;
            CommonPacket.Marshaler.Read(__msg, out totalCount);
            ArenaSmashUserInfo arenaSmashUserInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashUserInfo);
            List<ArenaSmashOpponentInfo> opponentInfoList;
            CommonPacket.Marshaler.Read(__msg, out opponentInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashMatchInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashMatchInfoOK(remote, rmiContext, totalCount, arenaSmashUserInfo, opponentInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashMatchInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashMatchInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashMatchInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<TournamentDisplayInfo> displayInfoList;
            CommonPacket.Marshaler.Read(__msg, out displayInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentListOK,
                    rmiName = RmiName_CG_RequestTournamentListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentListOK(remote, rmiContext, displayInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentListOK,
                    rmiName = RmiName_CG_RequestTournamentListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentProgressInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentProgressInfo progressInfo;
            CommonPacket.Marshaler.Read(__msg, out progressInfo);
            List<TournamentPlayerInfo> playerList;
            CommonPacket.Marshaler.Read(__msg, out playerList);
            List<TournamentMatchInfo> matchList;
            CommonPacket.Marshaler.Read(__msg, out matchList);
            List<TournamentPlayerCheerInfo> cheerList;
            CommonPacket.Marshaler.Read(__msg, out cheerList);
            long cheerPlayerUSN;
            CommonPacket.Marshaler.Read(__msg, out cheerPlayerUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentProgressInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentProgressInfoOK,
                    rmiName = RmiName_CG_RequestTournamentProgressInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentProgressInfoOK(remote, rmiContext, progressInfo, playerList, matchList, cheerList, cheerPlayerUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentProgressInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentProgressInfoOK,
                    rmiName = RmiName_CG_RequestTournamentProgressInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentResultInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentProgressInfo progressInfo;
            CommonPacket.Marshaler.Read(__msg, out progressInfo);
            List<TournamentPlayerInfo> playerList;
            CommonPacket.Marshaler.Read(__msg, out playerList);
            List<TournamentMatchInfo> matchList;
            CommonPacket.Marshaler.Read(__msg, out matchList);
            bool isRankReward;
            CommonPacket.Marshaler.Read(__msg, out isRankReward);
            List<TournamentPlayerCheerInfo> cheerList;
            CommonPacket.Marshaler.Read(__msg, out cheerList);
            long cheerPlayerUSN;
            CommonPacket.Marshaler.Read(__msg, out cheerPlayerUSN);
            bool isCheerReward;
            CommonPacket.Marshaler.Read(__msg, out isCheerReward);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentResultInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentResultInfoOK,
                    rmiName = RmiName_CG_RequestTournamentResultInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentResultInfoOK(remote, rmiContext, progressInfo, playerList, matchList, isRankReward, cheerList, cheerPlayerUSN, isCheerReward))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentResultInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentResultInfoOK,
                    rmiName = RmiName_CG_RequestTournamentResultInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentMatchJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int tournamentSEQ;
            CommonPacket.Marshaler.Read(__msg, out tournamentSEQ);
            TournamentMatchInfo matchInfo;
            CommonPacket.Marshaler.Read(__msg, out matchInfo);
            TournamentMatchJoinResult joinResult;
            CommonPacket.Marshaler.Read(__msg, out joinResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentMatchJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchJoinOK,
                    rmiName = RmiName_CG_RequestTournamentMatchJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentMatchJoinOK(remote, rmiContext, tournamentSEQ, matchInfo, joinResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentMatchJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchJoinOK,
                    rmiName = RmiName_CG_RequestTournamentMatchJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentMatchBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentBattleStartResult battleStartResult;
            CommonPacket.Marshaler.Read(__msg, out battleStartResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentMatchBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchBattleStartOK,
                    rmiName = RmiName_CG_RequestTournamentMatchBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentMatchBattleStartOK(remote, rmiContext, battleStartResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentMatchBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchBattleStartOK,
                    rmiName = RmiName_CG_RequestTournamentMatchBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentMatchBattleEndOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentBattleEndResult battleEndResult;
            CommonPacket.Marshaler.Read(__msg, out battleEndResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentMatchBattleEndOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchBattleEndOK,
                    rmiName = RmiName_CG_RequestTournamentMatchBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentMatchBattleEndOK(remote, rmiContext, battleEndResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentMatchBattleEndOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchBattleEndOK,
                    rmiName = RmiName_CG_RequestTournamentMatchBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentMatchExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentMatchExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchExitOK,
                    rmiName = RmiName_CG_RequestTournamentMatchExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentMatchExitOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentMatchExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchExitOK,
                    rmiName = RmiName_CG_RequestTournamentMatchExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_GC_NotifyTournamentProgressChange(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentProgressInfo progressInfo;
            CommonPacket.Marshaler.Read(__msg, out progressInfo);
            List<TournamentPlayerInfo> playerList;
            CommonPacket.Marshaler.Read(__msg, out playerList);
            List<TournamentMatchInfo> matchList;
            CommonPacket.Marshaler.Read(__msg, out matchList);
            base.core.PostCheckReadMessage(__msg, RmiName_GC_NotifyTournamentProgressChange);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.GC_NotifyTournamentProgressChange,
                    rmiName = RmiName_GC_NotifyTournamentProgressChange,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.GC_NotifyTournamentProgressChange(remote, rmiContext, progressInfo, playerList, matchList))
                base.core.ShowNotImplementedRmiWarning(RmiName_GC_NotifyTournamentProgressChange);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.GC_NotifyTournamentProgressChange,
                    rmiName = RmiName_GC_NotifyTournamentProgressChange,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int tournamentSEQ;
            CommonPacket.Marshaler.Read(__msg, out tournamentSEQ);
            int tournamentRank;
            CommonPacket.Marshaler.Read(__msg, out tournamentRank);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            bool isPlayer;
            CommonPacket.Marshaler.Read(__msg, out isPlayer);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentRewardOK,
                    rmiName = RmiName_CG_RequestTournamentRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentRewardOK(remote, rmiContext, tournamentSEQ, tournamentRank, rewardItemInfoList, isPlayer, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentRewardOK,
                    rmiName = RmiName_CG_RequestTournamentRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_GC_NotifyTournamentMatchSuspend(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TournamentMatchSuspendResult suspendResult;
            CommonPacket.Marshaler.Read(__msg, out suspendResult);
            base.core.PostCheckReadMessage(__msg, RmiName_GC_NotifyTournamentMatchSuspend);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.GC_NotifyTournamentMatchSuspend,
                    rmiName = RmiName_GC_NotifyTournamentMatchSuspend,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.GC_NotifyTournamentMatchSuspend(remote, rmiContext, suspendResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_GC_NotifyTournamentMatchSuspend);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.GC_NotifyTournamentMatchSuspend,
                    rmiName = RmiName_GC_NotifyTournamentMatchSuspend,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentPlayerTeamSlotChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<OtherPlayerTeamInfo> tournamentTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out tournamentTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentPlayerTeamSlotChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentPlayerTeamSlotChangeOK,
                    rmiName = RmiName_CG_RequestTournamentPlayerTeamSlotChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentPlayerTeamSlotChangeOK(remote, rmiContext, tournamentTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentPlayerTeamSlotChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentPlayerTeamSlotChangeOK,
                    rmiName = RmiName_CG_RequestTournamentPlayerTeamSlotChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentPlayerTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<OtherPlayerTeamInfo> otherPlayerTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out otherPlayerTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentPlayerTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentPlayerTeamInfoOK,
                    rmiName = RmiName_CG_RequestTournamentPlayerTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentPlayerTeamInfoOK(remote, rmiContext, otherPlayerTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentPlayerTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentPlayerTeamInfoOK,
                    rmiName = RmiName_CG_RequestTournamentPlayerTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentCheerOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int tournamentSEQ;
            CommonPacket.Marshaler.Read(__msg, out tournamentSEQ);
            TournamentPlayerCheerInfo cheerInfo;
            CommonPacket.Marshaler.Read(__msg, out cheerInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentCheerOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentCheerOK,
                    rmiName = RmiName_CG_RequestTournamentCheerOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentCheerOK(remote, rmiContext, tournamentSEQ, cheerInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentCheerOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentCheerOK,
                    rmiName = RmiName_CG_RequestTournamentCheerOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentCheerListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int tournamentSEQ;
            CommonPacket.Marshaler.Read(__msg, out tournamentSEQ);
            List<TournamentPlayerCheerInfo> cheerList;
            CommonPacket.Marshaler.Read(__msg, out cheerList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentCheerListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentCheerListOK,
                    rmiName = RmiName_CG_RequestTournamentCheerListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentCheerListOK(remote, rmiContext, tournamentSEQ, cheerList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentCheerListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentCheerListOK,
                    rmiName = RmiName_CG_RequestTournamentCheerListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentWatcherJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int tournamentSEQ;
            CommonPacket.Marshaler.Read(__msg, out tournamentSEQ);
            TournamentMatchInfo matchInfo;
            CommonPacket.Marshaler.Read(__msg, out matchInfo);
            TournamentMatchWatcherJoinResult joinResult;
            CommonPacket.Marshaler.Read(__msg, out joinResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentWatcherJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentWatcherJoinOK,
                    rmiName = RmiName_CG_RequestTournamentWatcherJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentWatcherJoinOK(remote, rmiContext, tournamentSEQ, matchInfo, joinResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentWatcherJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentWatcherJoinOK,
                    rmiName = RmiName_CG_RequestTournamentWatcherJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentWatcherExitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentWatcherExitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentWatcherExitOK,
                    rmiName = RmiName_CG_RequestTournamentWatcherExitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentWatcherExitOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentWatcherExitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentWatcherExitOK,
                    rmiName = RmiName_CG_RequestTournamentWatcherExitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentMatchPlayInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int tournamentSEQ;
            CommonPacket.Marshaler.Read(__msg, out tournamentSEQ);
            TournamentMatchInfo matchInfo;
            CommonPacket.Marshaler.Read(__msg, out matchInfo);
            List<TournamentMatchPlayInfo> playInfoList;
            CommonPacket.Marshaler.Read(__msg, out playInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentMatchPlayInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchPlayInfoOK,
                    rmiName = RmiName_CG_RequestTournamentMatchPlayInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentMatchPlayInfoOK(remote, rmiContext, tournamentSEQ, matchInfo, playInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentMatchPlayInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentMatchPlayInfoOK,
                    rmiName = RmiName_CG_RequestTournamentMatchPlayInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestTournamentReplayInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int tournamentSEQ;
            CommonPacket.Marshaler.Read(__msg, out tournamentSEQ);
            long replaySEQ;
            CommonPacket.Marshaler.Read(__msg, out replaySEQ);
            ReplayBytesInfo replayBytesInfo;
            CommonPacket.Marshaler.Read(__msg, out replayBytesInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestTournamentReplayInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentReplayInfoOK,
                    rmiName = RmiName_CG_RequestTournamentReplayInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestTournamentReplayInfoOK(remote, rmiContext, tournamentSEQ, replaySEQ, replayBytesInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestTournamentReplayInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestTournamentReplayInfoOK,
                    rmiName = RmiName_CG_RequestTournamentReplayInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLobbyInfo);
            List<ArenaRealTimePVPLimitHeroCost> heroCostList;
            CommonPacket.Marshaler.Read(__msg, out heroCostList);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            APInfo leagueTicketInfo;
            CommonPacket.Marshaler.Read(__msg, out leagueTicketInfo);
            byte dailyPlayCount;
            CommonPacket.Marshaler.Read(__msg, out dailyPlayCount);
            byte dailyRewardCount;
            CommonPacket.Marshaler.Read(__msg, out dailyRewardCount);
            ArenaRealTimePvpLimitMyRankInfo myRankInfo;
            CommonPacket.Marshaler.Read(__msg, out myRankInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitLobbyInfoOK(remote, rmiContext, arenaRealTimePvpLobbyInfo, heroCostList, userTeam, leagueTicketInfo, dailyPlayCount, dailyRewardCount, myRankInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitLobbyInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitJoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpLobbyInfo);
            List<ArenaRealTimePVPLimitHeroCost> heroCostList;
            CommonPacket.Marshaler.Read(__msg, out heroCostList);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitJoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitJoinOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitJoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitJoinOK(remote, rmiContext, arenaRealTimePvpLobbyInfo, heroCostList, userTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitJoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitJoinOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitJoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitMatchingOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitMatchingOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitMatchingOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitMatchingOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitMatchingOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitMatchingOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitMatchingOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpBattleStartResult battleStartResult;
            CommonPacket.Marshaler.Read(__msg, out battleStartResult);
            int passiveId;
            CommonPacket.Marshaler.Read(__msg, out passiveId);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitBattleStartOK(remote, rmiContext, battleStartResult, passiveId))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitBattleEndOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpBattleEndResult battleEndResult;
            CommonPacket.Marshaler.Read(__msg, out battleEndResult);
            byte dailyPlayCount;
            CommonPacket.Marshaler.Read(__msg, out dailyPlayCount);
            byte dailyRewardCount;
            CommonPacket.Marshaler.Read(__msg, out dailyRewardCount);
            byte dailyRewardCountMax;
            CommonPacket.Marshaler.Read(__msg, out dailyRewardCountMax);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitBattleEndOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitBattleEndOK(remote, rmiContext, battleEndResult, dailyPlayCount, dailyRewardCount, dailyRewardCountMax))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitBattleEndOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitBattleEndOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitBattleEndOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitIngameBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out pvpGameStartResultInfo);
            ItemResultInfo itemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitIngameBattleStartOK(remote, rmiContext, pvpGameStartResultInfo, itemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitTeamChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitTeamChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitTeamChangeOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitTeamChangeOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitTeamChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitTeamChangeOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitTopRankerListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList;
            CommonPacket.Marshaler.Read(__msg, out rankerUserInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitTopRankerListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitTopRankerListOK(remote, rmiContext, rankerUserInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitTopRankerListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitTopRankerListOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitTopRankerListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpLimitRankRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaAllRewardResultInfo limitResultInfo;
            CommonPacket.Marshaler.Read(__msg, out limitResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpLimitRankRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitRankRewardOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitRankRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpLimitRankRewardOK(remote, rmiContext, limitResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpLimitRankRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpLimitRankRewardOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpLimitRankRewardOK,
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

        public Stub.CG_RequestArenaRealTimePvpLobbyInfoOKDelegate CG_RequestArenaRealTimePvpLobbyInfoOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, APInfo leagueTicketInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpJoinOKDelegate CG_RequestArenaRealTimePvpJoinOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpTopRankerListOKDelegate CG_RequestArenaRealTimePvpTopRankerListOK = (HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList) => false;

        public Stub.CG_RequestArenaRealTimePvpLastRankerListOKDelegate CG_RequestArenaRealTimePvpLastRankerListOK = (HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpLowerRankerList, List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpRankerList, List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpLimitRankerList) => false;

        public Stub.CG_RequestArenaRealTimePvpMatchingOKDelegate CG_RequestArenaRealTimePvpMatchingOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestArenaRealTimePvpBattleStartOKDelegate CG_RequestArenaRealTimePvpBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult) => false;

        public Stub.CG_RequestArenaRealTimePvpBattleEndOKDelegate CG_RequestArenaRealTimePvpBattleEndOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleEndResult battleEndResult) => false;

        public Stub.CG_RequestArenaRealTimePvpRollbackOKDelegate CG_RequestArenaRealTimePvpRollbackOK = (HostID remote, RmiContext rmiContext, ApRewardInfo apRewardInfo, ItemResultInfo rollbakItemResultInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpIngameBattleStartOKDelegate CG_RequestArenaRealTimePvpIngameBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerLobbyInfoOKDelegate CG_RequestArenaRealTimePvpLowerLobbyInfoOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, APInfo leagueTicketInfo, UserTeam eventUserTeam) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerJoinOKDelegate CG_RequestArenaRealTimePvpLowerJoinOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, MissionResult missionResult) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerTopRankerListOKDelegate CG_RequestArenaRealTimePvpLowerTopRankerListOK = (HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerMatchingOKDelegate CG_RequestArenaRealTimePvpLowerMatchingOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerBattleStartOKDelegate CG_RequestArenaRealTimePvpLowerBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerBattleEndOKDelegate CG_RequestArenaRealTimePvpLowerBattleEndOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleEndResult battleEndResult, bool enterPvpUpper) => false;

        public Stub.CG_RequestArenaRealTimePvpAllInfoOKDelegate CG_RequestArenaRealTimePvpAllInfoOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvp_LoginInfo arenaRealTimePvpSimpleInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpLastRankerBattleInfoOKDelegate CG_RequestArenaRealTimePvpLastRankerBattleInfoOK = (HostID remote, RmiContext rmiContext, byte rank, ArenaLeagueOpponentInfo oppUserInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpLastRankerBattleStartOKDelegate CG_RequestArenaRealTimePvpLastRankerBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpRankerBattleStartResult battleStartResult) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerRollbackOKDelegate CG_RequestArenaRealTimePvpLowerRollbackOK = (HostID remote, RmiContext rmiContext, ApRewardInfo apRewardInfo, ItemResultInfo rollbakItemResultInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpLowerIngameBattleStartOKDelegate CG_RequestArenaRealTimePvpLowerIngameBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo) => false;

        public Stub.CG_RequestArenaRankingLobbyInfoOKDelegate CG_RequestArenaRankingLobbyInfoOK = (HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo, APInfo leagueTicketInfo) => false;

        public Stub.CG_RequestArenaRankingJoinOKDelegate CG_RequestArenaRankingJoinOK = (HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo, List<UserTeam> arenaReankingTeamInfoList, OtherPlayerTeamInfo arenaRankingDefenceTeamInfo) => false;

        public Stub.CG_RequestArenaRankingTopRankerListOKDelegate CG_RequestArenaRankingTopRankerListOK = (HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList) => false;

        public Stub.CG_RequestArenaRankingMatchingOKDelegate CG_RequestArenaRankingMatchingOK = (HostID remote, RmiContext rmiContext, bool matchingAble, RelayServerInfo arenaRankingRelayServerInfo) => false;

        public Stub.CG_RequestArenaRankingBattleStartOKDelegate CG_RequestArenaRankingBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult) => false;

        public Stub.CG_RequestArenaRankingBattleEndOKDelegate CG_RequestArenaRankingBattleEndOK = (HostID remote, RmiContext rmiContext, ArenaRankingBattleEndResult battleEndResult) => false;

        public Stub.CG_RequestArenaRankingIngameBattleStartOKDelegate CG_RequestArenaRankingIngameBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo) => false;

        public Stub.CG_RequestArenaRankingDefenceTeamUpdateOKDelegate CG_RequestArenaRankingDefenceTeamUpdateOK = (HostID remote, RmiContext rmiContext, OtherPlayerTeamInfo otherTeamInfo) => false;

        public Stub.CG_RequestPvpSeasonInfoOKDelegate CG_RequestPvpSeasonInfoOK = (HostID remote, RmiContext rmiContext, int mySeasonPoint, int mySeasonRank, List<PvpSeasonLastWeeklyUserInfo> pvpRankList, PvpSeasonRewardInfo pvpSeasonRewardInfo, PvpSeasonLastWeekInfo pvpSeasonLastWeekInfo, int currentSeasonID, int arenaRealTimedecisionRemainSEC) => false;

        public Stub.CG_RequestPvpSeasonHistoryOKDelegate CG_RequestPvpSeasonHistoryOK = (HostID remote, RmiContext rmiContext, int selectSeasonID, List<PvpSeasonHistoryInfo> pvpSeasonHistoryInfoList) => false;

        public Stub.CG_RequestCurrentTopRankingOKDelegate CG_RequestCurrentTopRankingOK = (HostID remote, RmiContext rmiContext, PVPRankingInfo pvpRankingInfo) => false;

        public Stub.CG_RequestLastTopRankingOKDelegate CG_RequestLastTopRankingOK = (HostID remote, RmiContext rmiContext, PVPRankingInfo pvpRankingInfo) => false;

        public Stub.CG_RequestPvpAbuseReportOKDelegate CG_RequestPvpAbuseReportOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestPvpAllRewardOKDelegate CG_RequestPvpAllRewardOK = (HostID remote, RmiContext rmiContext, ArenaAllRewardResultInfo lowerResultInfo, ArenaAllRewardResultInfo upperResultInfo, ArenaAllRewardResultInfo rankingResultInfo) => false;

        public Stub.CG_RequestPvpAllJoinOKDelegate CG_RequestPvpAllJoinOK = (HostID remote, RmiContext rmiContext, bool lowerJoin, bool upperJoin, bool rankingJoin, MissionResult missionResult) => false;

        public Stub.CG_RequestArenaRankingServerconnectOKDelegate CG_RequestArenaRankingServerconnectOK = (HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo) => false;

        public Stub.CG_RequestAreanRankingJoinTimeOverServerOKDelegate CG_RequestAreanRankingJoinTimeOverServerOK = (HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo) => false;

        public Stub.CG_RequestArenaSmashTeamSlotChangeOKDelegate CG_RequestArenaSmashTeamSlotChangeOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestArenaSmashDefenceTeamUpdateOKDelegate CG_RequestArenaSmashDefenceTeamUpdateOK = (HostID remote, RmiContext rmiContext, List<OtherPlayerTeamInfo> arenaSmashDefenceTeamInfoList, List<ItemResultInfo> useItemResultInfoList, byte teamUpdateCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOKDelegate CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK = (HostID remote, RmiContext rmiContext, byte teamIndex, int foodBuffItemID, OtherPlayerTeamInfo arenaSmashDefenceTeamInfo) => false;

        public Stub.CG_RequestArenaSmashLobbyInfoOKDelegate CG_RequestArenaSmashLobbyInfoOK = (HostID remote, RmiContext rmiContext, ArenaSmashLobbyInfo arenaSmashLobbyInfo, List<OtherPlayerTeamInfo> arenaSmashTeamInfoList) => false;

        public Stub.CG_RequestArenaSmashJoinOKDelegate CG_RequestArenaSmashJoinOK = (HostID remote, RmiContext rmiContext, ArenaSmashUserInfo arenaSmashUserInfo) => false;

        public Stub.CG_RequestArenaSmashOpponentListOKDelegate CG_RequestArenaSmashOpponentListOK = (HostID remote, RmiContext rmiContext, int userRank, int totalCount, List<ArenaSmashOpponentInfo> opponentInfoList, int opponentListExpireRemainSec) => false;

        public Stub.CG_RequestArenaSmashOpponentListReloadOKDelegate CG_RequestArenaSmashOpponentListReloadOK = (HostID remote, RmiContext rmiContext, int userRank, int totalCount, List<ArenaSmashOpponentInfo> opponentInfoList, int opponentListRemainSec, int opponentListExpireRemainSec) => false;

        public Stub.CG_RequestArenaSmashOpponentTeamInfoOKDelegate CG_RequestArenaSmashOpponentTeamInfoOK = (HostID remote, RmiContext rmiContext, ArenaSmashOpponentInfo opponentInfo, List<OtherPlayerTeamInfo> otherPlayerTeamInfoList) => false;

        public Stub.CG_RequestArenaSmashMatchJoinOKDelegate CG_RequestArenaSmashMatchJoinOK = (HostID remote, RmiContext rmiContext, ArenaSmashOpponentInfo opponentInfo, List<OtherPlayerTeamInfo> otherPlayerTeamInfoList) => false;

        public Stub.CG_RequestArenaSmashMatchBattleStartOKDelegate CG_RequestArenaSmashMatchBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaSmashBattleStartResult battleStartResult) => false;

        public Stub.CG_RequestArenaSmashMatchBattleEndOKDelegate CG_RequestArenaSmashMatchBattleEndOK = (HostID remote, RmiContext rmiContext, ArenaSmashBattleEndResult battleEndResult, long recordSN) => false;

        public Stub.CG_RequestArenaSmashWinRewardOKDelegate CG_RequestArenaSmashWinRewardOK = (HostID remote, RmiContext rmiContext, byte winRewardPoint, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, bool arenaSmashRewardAble) => false;

        public Stub.CG_RequestArenaSmashBestRefreshOKDelegate CG_RequestArenaSmashBestRefreshOK = (HostID remote, RmiContext rmiContext, ArenaSmashUserInfo arenaSmashUserInfo) => false;

        public Stub.CG_RequestArenaSmashBestRewardOKDelegate CG_RequestArenaSmashBestRewardOK = (HostID remote, RmiContext rmiContext, int bestRank, bool bestReward, int bestResetRaminSec, int rewardBestRank, int rewardTotalCount, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, bool arenaSmashRewardAble) => false;

        public Stub.CG_RequestArenaSmashRecordListOKDelegate CG_RequestArenaSmashRecordListOK = (HostID remote, RmiContext rmiContext, List<ArenaSmashRecordInfo> recordInfoList) => false;

        public Stub.CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOKDelegate CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK = (HostID remote, RmiContext rmiContext, byte teamIndex, int foodBuffItemID, ItemResultInfo itemResultInfo, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList) => false;

        public Stub.CG_RequestArenaSmashRankRewardOKDelegate CG_RequestArenaSmashRankRewardOK = (HostID remote, RmiContext rmiContext, int userRank, int serverUserRank, bool bestReward, int bestResetRaminSec, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, bool arenaSmashRewardAble) => false;

        public Stub.CG_RequestArenaSmashRankInfoOKDelegate CG_RequestArenaSmashRankInfoOK = (HostID remote, RmiContext rmiContext, List<ArenaSmashRankInfo> arenaSmashRankInfoList) => false;

        public Stub.CG_RequestArenaSmashMatchInfoOKDelegate CG_RequestArenaSmashMatchInfoOK = (HostID remote, RmiContext rmiContext, int totalCount, ArenaSmashUserInfo arenaSmashUserInfo, List<ArenaSmashOpponentInfo> opponentInfoList) => false;

        public Stub.CG_RequestTournamentListOKDelegate CG_RequestTournamentListOK = (HostID remote, RmiContext rmiContext, List<TournamentDisplayInfo> displayInfoList) => false;

        public Stub.CG_RequestTournamentProgressInfoOKDelegate CG_RequestTournamentProgressInfoOK = (HostID remote, RmiContext rmiContext, TournamentProgressInfo progressInfo, List<TournamentPlayerInfo> playerList, List<TournamentMatchInfo> matchList, List<TournamentPlayerCheerInfo> cheerList, long cheerPlayerUSN) => false;

        public Stub.CG_RequestTournamentResultInfoOKDelegate CG_RequestTournamentResultInfoOK = (HostID remote, RmiContext rmiContext, TournamentProgressInfo progressInfo, List<TournamentPlayerInfo> playerList, List<TournamentMatchInfo> matchList, bool isRankReward, List<TournamentPlayerCheerInfo> cheerList, long cheerPlayerUSN, bool isCheerReward) => false;

        public Stub.CG_RequestTournamentMatchJoinOKDelegate CG_RequestTournamentMatchJoinOK = (HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentMatchInfo matchInfo, TournamentMatchJoinResult joinResult) => false;

        public Stub.CG_RequestTournamentMatchBattleStartOKDelegate CG_RequestTournamentMatchBattleStartOK = (HostID remote, RmiContext rmiContext, TournamentBattleStartResult battleStartResult) => false;

        public Stub.CG_RequestTournamentMatchBattleEndOKDelegate CG_RequestTournamentMatchBattleEndOK = (HostID remote, RmiContext rmiContext, TournamentBattleEndResult battleEndResult) => false;

        public Stub.CG_RequestTournamentMatchExitOKDelegate CG_RequestTournamentMatchExitOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.GC_NotifyTournamentProgressChangeDelegate GC_NotifyTournamentProgressChange = (HostID remote, RmiContext rmiContext, TournamentProgressInfo progressInfo, List<TournamentPlayerInfo> playerList, List<TournamentMatchInfo> matchList) => false;

        public Stub.CG_RequestTournamentRewardOKDelegate CG_RequestTournamentRewardOK = (HostID remote, RmiContext rmiContext, int tournamentSEQ, int tournamentRank, List<ItemResultInfo> rewardItemInfoList, bool isPlayer, MissionResult missionResult) => false;

        public Stub.GC_NotifyTournamentMatchSuspendDelegate GC_NotifyTournamentMatchSuspend = (HostID remote, RmiContext rmiContext, TournamentMatchSuspendResult suspendResult) => false;

        public Stub.CG_RequestTournamentPlayerTeamSlotChangeOKDelegate CG_RequestTournamentPlayerTeamSlotChangeOK = (HostID remote, RmiContext rmiContext, List<OtherPlayerTeamInfo> tournamentTeamInfoList) => false;

        public Stub.CG_RequestTournamentPlayerTeamInfoOKDelegate CG_RequestTournamentPlayerTeamInfoOK = (HostID remote, RmiContext rmiContext, List<OtherPlayerTeamInfo> otherPlayerTeamInfoList) => false;

        public Stub.CG_RequestTournamentCheerOKDelegate CG_RequestTournamentCheerOK = (HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentPlayerCheerInfo cheerInfo) => false;

        public Stub.CG_RequestTournamentCheerListOKDelegate CG_RequestTournamentCheerListOK = (HostID remote, RmiContext rmiContext, int tournamentSEQ, List<TournamentPlayerCheerInfo> cheerList) => false;

        public Stub.CG_RequestTournamentWatcherJoinOKDelegate CG_RequestTournamentWatcherJoinOK = (HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentMatchInfo matchInfo, TournamentMatchWatcherJoinResult joinResult) => false;

        public Stub.CG_RequestTournamentWatcherExitOKDelegate CG_RequestTournamentWatcherExitOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestTournamentMatchPlayInfoOKDelegate CG_RequestTournamentMatchPlayInfoOK = (HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentMatchInfo matchInfo, List<TournamentMatchPlayInfo> playInfoList) => false;

        public Stub.CG_RequestTournamentReplayInfoOKDelegate CG_RequestTournamentReplayInfoOK = (HostID remote, RmiContext rmiContext, int tournamentSEQ, long replaySEQ, ReplayBytesInfo replayBytesInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitLobbyInfoOKDelegate CG_RequestArenaRealTimePvpLimitLobbyInfoOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, List<ArenaRealTimePVPLimitHeroCost> heroCostList, UserTeam userTeam, APInfo leagueTicketInfo, byte dailyPlayCount, byte dailyRewardCount, ArenaRealTimePvpLimitMyRankInfo myRankInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitJoinOKDelegate CG_RequestArenaRealTimePvpLimitJoinOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, List<ArenaRealTimePVPLimitHeroCost> heroCostList, UserTeam userTeam) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitMatchingOKDelegate CG_RequestArenaRealTimePvpLimitMatchingOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitBattleStartOKDelegate CG_RequestArenaRealTimePvpLimitBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult, int passiveId) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitBattleEndOKDelegate CG_RequestArenaRealTimePvpLimitBattleEndOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleEndResult battleEndResult, byte dailyPlayCount, byte dailyRewardCount, byte dailyRewardCountMax) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitIngameBattleStartOKDelegate CG_RequestArenaRealTimePvpLimitIngameBattleStartOK = (HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo, ItemResultInfo itemResultInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitTeamChangeOKDelegate CG_RequestArenaRealTimePvpLimitTeamChangeOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitTopRankerListOKDelegate CG_RequestArenaRealTimePvpLimitTopRankerListOK = (HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList) => false;

        public Stub.CG_RequestArenaRealTimePvpLimitRankRewardOKDelegate CG_RequestArenaRealTimePvpLimitRankRewardOK = (HostID remote, RmiContext rmiContext, ArenaAllRewardResultInfo limitResultInfo) => false;

        public const string RmiName_CG_RequestArenaRealTimePvpLobbyInfoOK = "CG_RequestArenaRealTimePvpLobbyInfoOK";

        public const string RmiName_CG_RequestArenaRealTimePvpJoinOK = "CG_RequestArenaRealTimePvpJoinOK";

        public const string RmiName_CG_RequestArenaRealTimePvpTopRankerListOK = "CG_RequestArenaRealTimePvpTopRankerListOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLastRankerListOK = "CG_RequestArenaRealTimePvpLastRankerListOK";

        public const string RmiName_CG_RequestArenaRealTimePvpMatchingOK = "CG_RequestArenaRealTimePvpMatchingOK";

        public const string RmiName_CG_RequestArenaRealTimePvpBattleStartOK = "CG_RequestArenaRealTimePvpBattleStartOK";

        public const string RmiName_CG_RequestArenaRealTimePvpBattleEndOK = "CG_RequestArenaRealTimePvpBattleEndOK";

        public const string RmiName_CG_RequestArenaRealTimePvpRollbackOK = "CG_RequestArenaRealTimePvpRollbackOK";

        public const string RmiName_CG_RequestArenaRealTimePvpIngameBattleStartOK = "CG_RequestArenaRealTimePvpIngameBattleStartOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerLobbyInfoOK = "CG_RequestArenaRealTimePvpLowerLobbyInfoOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerJoinOK = "CG_RequestArenaRealTimePvpLowerJoinOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerTopRankerListOK = "CG_RequestArenaRealTimePvpLowerTopRankerListOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerMatchingOK = "CG_RequestArenaRealTimePvpLowerMatchingOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerBattleStartOK = "CG_RequestArenaRealTimePvpLowerBattleStartOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerBattleEndOK = "CG_RequestArenaRealTimePvpLowerBattleEndOK";

        public const string RmiName_CG_RequestArenaRealTimePvpAllInfoOK = "CG_RequestArenaRealTimePvpAllInfoOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLastRankerBattleInfoOK = "CG_RequestArenaRealTimePvpLastRankerBattleInfoOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLastRankerBattleStartOK = "CG_RequestArenaRealTimePvpLastRankerBattleStartOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerRollbackOK = "CG_RequestArenaRealTimePvpLowerRollbackOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerIngameBattleStartOK = "CG_RequestArenaRealTimePvpLowerIngameBattleStartOK";

        public const string RmiName_CG_RequestArenaRankingLobbyInfoOK = "CG_RequestArenaRankingLobbyInfoOK";

        public const string RmiName_CG_RequestArenaRankingJoinOK = "CG_RequestArenaRankingJoinOK";

        public const string RmiName_CG_RequestArenaRankingTopRankerListOK = "CG_RequestArenaRankingTopRankerListOK";

        public const string RmiName_CG_RequestArenaRankingMatchingOK = "CG_RequestArenaRankingMatchingOK";

        public const string RmiName_CG_RequestArenaRankingBattleStartOK = "CG_RequestArenaRankingBattleStartOK";

        public const string RmiName_CG_RequestArenaRankingBattleEndOK = "CG_RequestArenaRankingBattleEndOK";

        public const string RmiName_CG_RequestArenaRankingIngameBattleStartOK = "CG_RequestArenaRankingIngameBattleStartOK";

        public const string RmiName_CG_RequestArenaRankingDefenceTeamUpdateOK = "CG_RequestArenaRankingDefenceTeamUpdateOK";

        public const string RmiName_CG_RequestPvpSeasonInfoOK = "CG_RequestPvpSeasonInfoOK";

        public const string RmiName_CG_RequestPvpSeasonHistoryOK = "CG_RequestPvpSeasonHistoryOK";

        public const string RmiName_CG_RequestCurrentTopRankingOK = "CG_RequestCurrentTopRankingOK";

        public const string RmiName_CG_RequestLastTopRankingOK = "CG_RequestLastTopRankingOK";

        public const string RmiName_CG_RequestPvpAbuseReportOK = "CG_RequestPvpAbuseReportOK";

        public const string RmiName_CG_RequestPvpAllRewardOK = "CG_RequestPvpAllRewardOK";

        public const string RmiName_CG_RequestPvpAllJoinOK = "CG_RequestPvpAllJoinOK";

        public const string RmiName_CG_RequestArenaRankingServerconnectOK = "CG_RequestArenaRankingServerconnectOK";

        public const string RmiName_CG_RequestAreanRankingJoinTimeOverServerOK = "CG_RequestAreanRankingJoinTimeOverServerOK";

        public const string RmiName_CG_RequestArenaSmashTeamSlotChangeOK = "CG_RequestArenaSmashTeamSlotChangeOK";

        public const string RmiName_CG_RequestArenaSmashDefenceTeamUpdateOK = "CG_RequestArenaSmashDefenceTeamUpdateOK";

        public const string RmiName_CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK = "CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOK";

        public const string RmiName_CG_RequestArenaSmashLobbyInfoOK = "CG_RequestArenaSmashLobbyInfoOK";

        public const string RmiName_CG_RequestArenaSmashJoinOK = "CG_RequestArenaSmashJoinOK";

        public const string RmiName_CG_RequestArenaSmashOpponentListOK = "CG_RequestArenaSmashOpponentListOK";

        public const string RmiName_CG_RequestArenaSmashOpponentListReloadOK = "CG_RequestArenaSmashOpponentListReloadOK";

        public const string RmiName_CG_RequestArenaSmashOpponentTeamInfoOK = "CG_RequestArenaSmashOpponentTeamInfoOK";

        public const string RmiName_CG_RequestArenaSmashMatchJoinOK = "CG_RequestArenaSmashMatchJoinOK";

        public const string RmiName_CG_RequestArenaSmashMatchBattleStartOK = "CG_RequestArenaSmashMatchBattleStartOK";

        public const string RmiName_CG_RequestArenaSmashMatchBattleEndOK = "CG_RequestArenaSmashMatchBattleEndOK";

        public const string RmiName_CG_RequestArenaSmashWinRewardOK = "CG_RequestArenaSmashWinRewardOK";

        public const string RmiName_CG_RequestArenaSmashBestRefreshOK = "CG_RequestArenaSmashBestRefreshOK";

        public const string RmiName_CG_RequestArenaSmashBestRewardOK = "CG_RequestArenaSmashBestRewardOK";

        public const string RmiName_CG_RequestArenaSmashRecordListOK = "CG_RequestArenaSmashRecordListOK";

        public const string RmiName_CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK = "CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOK";

        public const string RmiName_CG_RequestArenaSmashRankRewardOK = "CG_RequestArenaSmashRankRewardOK";

        public const string RmiName_CG_RequestArenaSmashRankInfoOK = "CG_RequestArenaSmashRankInfoOK";

        public const string RmiName_CG_RequestArenaSmashMatchInfoOK = "CG_RequestArenaSmashMatchInfoOK";

        public const string RmiName_CG_RequestTournamentListOK = "CG_RequestTournamentListOK";

        public const string RmiName_CG_RequestTournamentProgressInfoOK = "CG_RequestTournamentProgressInfoOK";

        public const string RmiName_CG_RequestTournamentResultInfoOK = "CG_RequestTournamentResultInfoOK";

        public const string RmiName_CG_RequestTournamentMatchJoinOK = "CG_RequestTournamentMatchJoinOK";

        public const string RmiName_CG_RequestTournamentMatchBattleStartOK = "CG_RequestTournamentMatchBattleStartOK";

        public const string RmiName_CG_RequestTournamentMatchBattleEndOK = "CG_RequestTournamentMatchBattleEndOK";

        public const string RmiName_CG_RequestTournamentMatchExitOK = "CG_RequestTournamentMatchExitOK";

        public const string RmiName_GC_NotifyTournamentProgressChange = "GC_NotifyTournamentProgressChange";

        public const string RmiName_CG_RequestTournamentRewardOK = "CG_RequestTournamentRewardOK";

        public const string RmiName_GC_NotifyTournamentMatchSuspend = "GC_NotifyTournamentMatchSuspend";

        public const string RmiName_CG_RequestTournamentPlayerTeamSlotChangeOK = "CG_RequestTournamentPlayerTeamSlotChangeOK";

        public const string RmiName_CG_RequestTournamentPlayerTeamInfoOK = "CG_RequestTournamentPlayerTeamInfoOK";

        public const string RmiName_CG_RequestTournamentCheerOK = "CG_RequestTournamentCheerOK";

        public const string RmiName_CG_RequestTournamentCheerListOK = "CG_RequestTournamentCheerListOK";

        public const string RmiName_CG_RequestTournamentWatcherJoinOK = "CG_RequestTournamentWatcherJoinOK";

        public const string RmiName_CG_RequestTournamentWatcherExitOK = "CG_RequestTournamentWatcherExitOK";

        public const string RmiName_CG_RequestTournamentMatchPlayInfoOK = "CG_RequestTournamentMatchPlayInfoOK";

        public const string RmiName_CG_RequestTournamentReplayInfoOK = "CG_RequestTournamentReplayInfoOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitLobbyInfoOK = "CG_RequestArenaRealTimePvpLimitLobbyInfoOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitJoinOK = "CG_RequestArenaRealTimePvpLimitJoinOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitMatchingOK = "CG_RequestArenaRealTimePvpLimitMatchingOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitBattleStartOK = "CG_RequestArenaRealTimePvpLimitBattleStartOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitBattleEndOK = "CG_RequestArenaRealTimePvpLimitBattleEndOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitIngameBattleStartOK = "CG_RequestArenaRealTimePvpLimitIngameBattleStartOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitTeamChangeOK = "CG_RequestArenaRealTimePvpLimitTeamChangeOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitTopRankerListOK = "CG_RequestArenaRealTimePvpLimitTopRankerListOK";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitRankRewardOK = "CG_RequestArenaRealTimePvpLimitRankRewardOK";

        public const string RmiName_First = "CG_RequestArenaRealTimePvpLobbyInfoOK";

        public delegate bool CG_RequestArenaRealTimePvpLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, APInfo leagueTicketInfo);

        public delegate bool CG_RequestArenaRealTimePvpJoinOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo);

        public delegate bool CG_RequestArenaRealTimePvpTopRankerListOKDelegate(HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList);

        public delegate bool CG_RequestArenaRealTimePvpLastRankerListOKDelegate(HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpLowerRankerList, List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpRankerList, List<ArenaRealTimePvpOpponentUserInfo> arenaRealTimePvpLimitRankerList);

        public delegate bool CG_RequestArenaRealTimePvpMatchingOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestArenaRealTimePvpBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult);

        public delegate bool CG_RequestArenaRealTimePvpBattleEndOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleEndResult battleEndResult);

        public delegate bool CG_RequestArenaRealTimePvpRollbackOKDelegate(HostID remote, RmiContext rmiContext, ApRewardInfo apRewardInfo, ItemResultInfo rollbakItemResultInfo);

        public delegate bool CG_RequestArenaRealTimePvpIngameBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo);

        public delegate bool CG_RequestArenaRealTimePvpLowerLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, APInfo leagueTicketInfo, UserTeam eventUserTeam);

        public delegate bool CG_RequestArenaRealTimePvpLowerJoinOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, MissionResult missionResult);

        public delegate bool CG_RequestArenaRealTimePvpLowerTopRankerListOKDelegate(HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList);

        public delegate bool CG_RequestArenaRealTimePvpLowerMatchingOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestArenaRealTimePvpLowerBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult);

        public delegate bool CG_RequestArenaRealTimePvpLowerBattleEndOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleEndResult battleEndResult, bool enterPvpUpper);

        public delegate bool CG_RequestArenaRealTimePvpAllInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvp_LoginInfo arenaRealTimePvpSimpleInfo);

        public delegate bool CG_RequestArenaRealTimePvpLastRankerBattleInfoOKDelegate(HostID remote, RmiContext rmiContext, byte rank, ArenaLeagueOpponentInfo oppUserInfo);

        public delegate bool CG_RequestArenaRealTimePvpLastRankerBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpRankerBattleStartResult battleStartResult);

        public delegate bool CG_RequestArenaRealTimePvpLowerRollbackOKDelegate(HostID remote, RmiContext rmiContext, ApRewardInfo apRewardInfo, ItemResultInfo rollbakItemResultInfo);

        public delegate bool CG_RequestArenaRealTimePvpLowerIngameBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo);

        public delegate bool CG_RequestArenaRankingLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo, APInfo leagueTicketInfo);

        public delegate bool CG_RequestArenaRankingJoinOKDelegate(HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo, List<UserTeam> arenaReankingTeamInfoList, OtherPlayerTeamInfo arenaRankingDefenceTeamInfo);

        public delegate bool CG_RequestArenaRankingTopRankerListOKDelegate(HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList);

        public delegate bool CG_RequestArenaRankingMatchingOKDelegate(HostID remote, RmiContext rmiContext, bool matchingAble, RelayServerInfo arenaRankingRelayServerInfo);

        public delegate bool CG_RequestArenaRankingBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult);

        public delegate bool CG_RequestArenaRankingBattleEndOKDelegate(HostID remote, RmiContext rmiContext, ArenaRankingBattleEndResult battleEndResult);

        public delegate bool CG_RequestArenaRankingIngameBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo);

        public delegate bool CG_RequestArenaRankingDefenceTeamUpdateOKDelegate(HostID remote, RmiContext rmiContext, OtherPlayerTeamInfo otherTeamInfo);

        public delegate bool CG_RequestPvpSeasonInfoOKDelegate(HostID remote, RmiContext rmiContext, int mySeasonPoint, int mySeasonRank, List<PvpSeasonLastWeeklyUserInfo> pvpRankList, PvpSeasonRewardInfo pvpSeasonRewardInfo, PvpSeasonLastWeekInfo pvpSeasonLastWeekInfo, int currentSeasonID, int arenaRealTimedecisionRemainSEC);

        public delegate bool CG_RequestPvpSeasonHistoryOKDelegate(HostID remote, RmiContext rmiContext, int selectSeasonID, List<PvpSeasonHistoryInfo> pvpSeasonHistoryInfoList);

        public delegate bool CG_RequestCurrentTopRankingOKDelegate(HostID remote, RmiContext rmiContext, PVPRankingInfo pvpRankingInfo);

        public delegate bool CG_RequestLastTopRankingOKDelegate(HostID remote, RmiContext rmiContext, PVPRankingInfo pvpRankingInfo);

        public delegate bool CG_RequestPvpAbuseReportOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestPvpAllRewardOKDelegate(HostID remote, RmiContext rmiContext, ArenaAllRewardResultInfo lowerResultInfo, ArenaAllRewardResultInfo upperResultInfo, ArenaAllRewardResultInfo rankingResultInfo);

        public delegate bool CG_RequestPvpAllJoinOKDelegate(HostID remote, RmiContext rmiContext, bool lowerJoin, bool upperJoin, bool rankingJoin, MissionResult missionResult);

        public delegate bool CG_RequestArenaRankingServerconnectOKDelegate(HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo);

        public delegate bool CG_RequestAreanRankingJoinTimeOverServerOKDelegate(HostID remote, RmiContext rmiContext, ArenaRankingLobbyInfo arenaRankingLobbyInfo);

        public delegate bool CG_RequestArenaSmashTeamSlotChangeOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestArenaSmashDefenceTeamUpdateOKDelegate(HostID remote, RmiContext rmiContext, List<OtherPlayerTeamInfo> arenaSmashDefenceTeamInfoList, List<ItemResultInfo> useItemResultInfoList, byte teamUpdateCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestArenaSmashDefenceTeamFoodBuffUpdateOKDelegate(HostID remote, RmiContext rmiContext, byte teamIndex, int foodBuffItemID, OtherPlayerTeamInfo arenaSmashDefenceTeamInfo);

        public delegate bool CG_RequestArenaSmashLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashLobbyInfo arenaSmashLobbyInfo, List<OtherPlayerTeamInfo> arenaSmashTeamInfoList);

        public delegate bool CG_RequestArenaSmashJoinOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashUserInfo arenaSmashUserInfo);

        public delegate bool CG_RequestArenaSmashOpponentListOKDelegate(HostID remote, RmiContext rmiContext, int userRank, int totalCount, List<ArenaSmashOpponentInfo> opponentInfoList, int opponentListExpireRemainSec);

        public delegate bool CG_RequestArenaSmashOpponentListReloadOKDelegate(HostID remote, RmiContext rmiContext, int userRank, int totalCount, List<ArenaSmashOpponentInfo> opponentInfoList, int opponentListRemainSec, int opponentListExpireRemainSec);

        public delegate bool CG_RequestArenaSmashOpponentTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashOpponentInfo opponentInfo, List<OtherPlayerTeamInfo> otherPlayerTeamInfoList);

        public delegate bool CG_RequestArenaSmashMatchJoinOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashOpponentInfo opponentInfo, List<OtherPlayerTeamInfo> otherPlayerTeamInfoList);

        public delegate bool CG_RequestArenaSmashMatchBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashBattleStartResult battleStartResult);

        public delegate bool CG_RequestArenaSmashMatchBattleEndOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashBattleEndResult battleEndResult, long recordSN);

        public delegate bool CG_RequestArenaSmashWinRewardOKDelegate(HostID remote, RmiContext rmiContext, byte winRewardPoint, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, bool arenaSmashRewardAble);

        public delegate bool CG_RequestArenaSmashBestRefreshOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashUserInfo arenaSmashUserInfo);

        public delegate bool CG_RequestArenaSmashBestRewardOKDelegate(HostID remote, RmiContext rmiContext, int bestRank, bool bestReward, int bestResetRaminSec, int rewardBestRank, int rewardTotalCount, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, bool arenaSmashRewardAble);

        public delegate bool CG_RequestArenaSmashRecordListOKDelegate(HostID remote, RmiContext rmiContext, List<ArenaSmashRecordInfo> recordInfoList);

        public delegate bool CG_RequestArenaSmashOffenseTeamFoodBuffUpdateOKDelegate(HostID remote, RmiContext rmiContext, byte teamIndex, int foodBuffItemID, ItemResultInfo itemResultInfo, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList);

        public delegate bool CG_RequestArenaSmashRankRewardOKDelegate(HostID remote, RmiContext rmiContext, int userRank, int serverUserRank, bool bestReward, int bestResetRaminSec, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, bool arenaSmashRewardAble);

        public delegate bool CG_RequestArenaSmashRankInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ArenaSmashRankInfo> arenaSmashRankInfoList);

        public delegate bool CG_RequestArenaSmashMatchInfoOKDelegate(HostID remote, RmiContext rmiContext, int totalCount, ArenaSmashUserInfo arenaSmashUserInfo, List<ArenaSmashOpponentInfo> opponentInfoList);

        public delegate bool CG_RequestTournamentListOKDelegate(HostID remote, RmiContext rmiContext, List<TournamentDisplayInfo> displayInfoList);

        public delegate bool CG_RequestTournamentProgressInfoOKDelegate(HostID remote, RmiContext rmiContext, TournamentProgressInfo progressInfo, List<TournamentPlayerInfo> playerList, List<TournamentMatchInfo> matchList, List<TournamentPlayerCheerInfo> cheerList, long cheerPlayerUSN);

        public delegate bool CG_RequestTournamentResultInfoOKDelegate(HostID remote, RmiContext rmiContext, TournamentProgressInfo progressInfo, List<TournamentPlayerInfo> playerList, List<TournamentMatchInfo> matchList, bool isRankReward, List<TournamentPlayerCheerInfo> cheerList, long cheerPlayerUSN, bool isCheerReward);

        public delegate bool CG_RequestTournamentMatchJoinOKDelegate(HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentMatchInfo matchInfo, TournamentMatchJoinResult joinResult);

        public delegate bool CG_RequestTournamentMatchBattleStartOKDelegate(HostID remote, RmiContext rmiContext, TournamentBattleStartResult battleStartResult);

        public delegate bool CG_RequestTournamentMatchBattleEndOKDelegate(HostID remote, RmiContext rmiContext, TournamentBattleEndResult battleEndResult);

        public delegate bool CG_RequestTournamentMatchExitOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool GC_NotifyTournamentProgressChangeDelegate(HostID remote, RmiContext rmiContext, TournamentProgressInfo progressInfo, List<TournamentPlayerInfo> playerList, List<TournamentMatchInfo> matchList);

        public delegate bool CG_RequestTournamentRewardOKDelegate(HostID remote, RmiContext rmiContext, int tournamentSEQ, int tournamentRank, List<ItemResultInfo> rewardItemInfoList, bool isPlayer, MissionResult missionResult);

        public delegate bool GC_NotifyTournamentMatchSuspendDelegate(HostID remote, RmiContext rmiContext, TournamentMatchSuspendResult suspendResult);

        public delegate bool CG_RequestTournamentPlayerTeamSlotChangeOKDelegate(HostID remote, RmiContext rmiContext, List<OtherPlayerTeamInfo> tournamentTeamInfoList);

        public delegate bool CG_RequestTournamentPlayerTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, List<OtherPlayerTeamInfo> otherPlayerTeamInfoList);

        public delegate bool CG_RequestTournamentCheerOKDelegate(HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentPlayerCheerInfo cheerInfo);

        public delegate bool CG_RequestTournamentCheerListOKDelegate(HostID remote, RmiContext rmiContext, int tournamentSEQ, List<TournamentPlayerCheerInfo> cheerList);

        public delegate bool CG_RequestTournamentWatcherJoinOKDelegate(HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentMatchInfo matchInfo, TournamentMatchWatcherJoinResult joinResult);

        public delegate bool CG_RequestTournamentWatcherExitOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestTournamentMatchPlayInfoOKDelegate(HostID remote, RmiContext rmiContext, int tournamentSEQ, TournamentMatchInfo matchInfo, List<TournamentMatchPlayInfo> playInfoList);

        public delegate bool CG_RequestTournamentReplayInfoOKDelegate(HostID remote, RmiContext rmiContext, int tournamentSEQ, long replaySEQ, ReplayBytesInfo replayBytesInfo);

        public delegate bool CG_RequestArenaRealTimePvpLimitLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, List<ArenaRealTimePVPLimitHeroCost> heroCostList, UserTeam userTeam, APInfo leagueTicketInfo, byte dailyPlayCount, byte dailyRewardCount, ArenaRealTimePvpLimitMyRankInfo myRankInfo);

        public delegate bool CG_RequestArenaRealTimePvpLimitJoinOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpLobbyInfo arenaRealTimePvpLobbyInfo, List<ArenaRealTimePVPLimitHeroCost> heroCostList, UserTeam userTeam);

        public delegate bool CG_RequestArenaRealTimePvpLimitMatchingOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestArenaRealTimePvpLimitBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleStartResult battleStartResult, int passiveId);

        public delegate bool CG_RequestArenaRealTimePvpLimitBattleEndOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpBattleEndResult battleEndResult, byte dailyPlayCount, byte dailyRewardCount, byte dailyRewardCountMax);

        public delegate bool CG_RequestArenaRealTimePvpLimitIngameBattleStartOKDelegate(HostID remote, RmiContext rmiContext, ArenaRealTimePvpGameStartResultInfo pvpGameStartResultInfo, ItemResultInfo itemResultInfo);

        public delegate bool CG_RequestArenaRealTimePvpLimitTeamChangeOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestArenaRealTimePvpLimitTopRankerListOKDelegate(HostID remote, RmiContext rmiContext, List<ArenaRealTimePvpOpponentUserInfo> rankerUserInfoList);

        public delegate bool CG_RequestArenaRealTimePvpLimitRankRewardOKDelegate(HostID remote, RmiContext rmiContext, ArenaAllRewardResultInfo limitResultInfo);
    }
}