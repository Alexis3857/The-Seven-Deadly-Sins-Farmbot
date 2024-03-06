using Nettention.Proud;

namespace SevenDSGameS2C_Guild
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
                    case Common.CG_RequestGuildInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildRecommendListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildRecommendListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildInfoWithMemberListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildInfoWithMemberListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildSearchByNameOK:
                        this.ProcessReceivedMessage_CG_RequestGuildSearchByNameOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildCreateOK:
                        this.ProcessReceivedMessage_CG_RequestGuildCreateOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildDisbandOK:
                        this.ProcessReceivedMessage_CG_RequestGuildDisbandOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildApplicantListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildApplicantListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildApplyOK:
                        this.ProcessReceivedMessage_CG_RequestGuildApplyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildReturnApplicationOK:
                        this.ProcessReceivedMessage_CG_RequestGuildReturnApplicationOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildAcceptApplicantOK:
                        this.ProcessReceivedMessage_CG_RequestGuildAcceptApplicantOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildRejectApplicantOK:
                        this.ProcessReceivedMessage_CG_RequestGuildRejectApplicantOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildLevelUpOK:
                        this.ProcessReceivedMessage_CG_RequestGuildLevelUpOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildChangeNameOK:
                        this.ProcessReceivedMessage_CG_RequestGuildChangeNameOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildChangeBoardOK:
                        this.ProcessReceivedMessage_CG_RequestGuildChangeBoardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildChangeMasterOK:
                        this.ProcessReceivedMessage_CG_RequestGuildChangeMasterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildChangeMemberGradeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildChangeMemberGradeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildKickOutMemberOK:
                        this.ProcessReceivedMessage_CG_RequestGuildKickOutMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildLeaveOK:
                        this.ProcessReceivedMessage_CG_RequestGuildLeaveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildUserInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildUserInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildAttendanceStatusOK:
                        this.ProcessReceivedMessage_CG_RequestGuildAttendanceStatusOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildRoomInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildRoomInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildAttendanceOK:
                        this.ProcessReceivedMessage_CG_RequestGuildAttendanceOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildAttendanceRewardOK:
                        this.ProcessReceivedMessage_CG_RequestGuildAttendanceRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.GC_NotifyGuildKickout:
                        this.ProcessReceivedMessage_GC_NotifyGuildKickout(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildDonationOK:
                        this.ProcessReceivedMessage_CG_RequestGuildDonationOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildDonationInitializeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildDonationInitializeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildMissionInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildMissionInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildMissionRewardOK:
                        this.ProcessReceivedMessage_CG_RequestGuildMissionRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.GC_NotifyGuildAcceptApplicantOK:
                        this.ProcessReceivedMessage_GC_NotifyGuildAcceptApplicantOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildDonationInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildDonationInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildSkillInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildSkillInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildSkillLevelUpOK:
                        this.ProcessReceivedMessage_CG_RequestGuildSkillLevelUpOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildSkillUseOK:
                        this.ProcessReceivedMessage_CG_RequestGuildSkillUseOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildSkillDisuseOK:
                        this.ProcessReceivedMessage_CG_RequestGuildSkillDisuseOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildSkillUseInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildSkillUseInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildBossRankPointRewardOK:
                        this.ProcessReceivedMessage_CG_RequestGuildBossRankPointRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildBattlePointRegisterOK:
                        this.ProcessReceivedMessage_CG_RequestGuildBattlePointRegisterOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildBattlePointMemeberRankListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildBattlePointMemeberRankListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildBattlePointGuildRankListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildBattlePointGuildRankListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildBattlePointUserRankListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildBattlePointUserRankListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildInvitationReceivedListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildInvitationReceivedListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildInvitationSendOK:
                        this.ProcessReceivedMessage_CG_RequestGuildInvitationSendOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildInvitationRemoveOK:
                        this.ProcessReceivedMessage_CG_RequestGuildInvitationRemoveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildInvitationSetOptionOK:
                        this.ProcessReceivedMessage_CG_RequestGuildInvitationSetOptionOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildMarkInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildMarkInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.GC_NotifyGuildRejectApplicantOK:
                        this.ProcessReceivedMessage_GC_NotifyGuildRejectApplicantOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildRecruitListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildRecruitListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildRecruitApplyOK:
                        this.ProcessReceivedMessage_CG_RequestGuildRecruitApplyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildRecruitCancelOK:
                        this.ProcessReceivedMessage_CG_RequestGuildRecruitCancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarRankInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarRankInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarVersusRecordInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarVersusRecordInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarGuildMemberListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarGuildMemberListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarWorldMapInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarWorldMapInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarAttackSquadChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarAttackSquadChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarDefenceTeamChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarRegionBonusScoreChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarRegionBonusScoreChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarAreaGuildMemberChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarAreaGuildMemberChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarBattleRecordInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarBattleRecordInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildWar_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_GuildWar_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildWar_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_GuildWar_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildWar_Stage_RejoinOK:
                        this.ProcessReceivedMessage_CG_Request_GuildWar_Stage_RejoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildWar_Stage_HeroStatus_SyncOK:
                        this.ProcessReceivedMessage_CG_Request_GuildWar_Stage_HeroStatus_SyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarBattlePrepareInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarBattlePrepareInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarAttackTeamChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarAttackTeamChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarDefenceSlotExpandOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarDefenceSlotExpandOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarSquadSlotExpandOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarSquadSlotExpandOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarAttackTeamInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarAttackTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarDefenceTeamInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarAttackTeamBuffRegistOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarAttackTeamBuffRegistOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarDefenceTeamBuffRegistOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamBuffRegistOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildWar_Stage_Rejoin_CancelOK:
                        this.ProcessReceivedMessage_CG_Request_GuildWar_Stage_Rejoin_CancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarDefenceTeamInfoAllOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamInfoAllOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarRankInfoAllOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarRankInfoAllOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarDefenceTeamSaveOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamSaveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarMagicAreaRegistOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarMagicAreaRegistOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarDefenceTeamSaveAllOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamSaveAllOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowerLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowerLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarCostumeRewardOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarCostumeRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarRegionAttackPriorityChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarRegionAttackPriorityChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarBattleSettingChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarBattleSettingChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarBattleSettingChangeInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarBattleSettingChangeInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarNonSeasonBattlePrepareInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarNonSeasonBattlePrepareInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarNonSeasonDefenceTeamChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarNonSeasonDefenceTeamChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarNonSeasonAttackSquadChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarNonSeasonAttackSquadChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarUserInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarUserInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarRecommandDefenceTeamInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarRecommandDefenceTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarRecommandDefenceTeamRegistOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarRecommandDefenceTeamRegistOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowLobbyInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowLobbyInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowApplyOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowApplyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowAttackTeamChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowAttackTeamChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowDefenceTeamChangeOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowDefenceTeamChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowAreaDeployGuildMemberOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowAreaDeployGuildMemberOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowAreaInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowAreaInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowStageRejoinOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowStageRejoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowStageRejoinCancelOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowStageRejoinCancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowStageSyncOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowStageSyncOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowDefenceTeamSaveAllOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowDefenceTeamSaveAllOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowBattleRecordInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowBattleRecordInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowMemberListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowMemberListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowDefenceTeamInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowDefenceTeamInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowAreaInfoListOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowAreaInfoListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildWarLowRecordInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildWarLowRecordInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGuildShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestGuildShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildShopResetOK:
                        this.ProcessReceivedMessage_CG_RequestGuildShopResetOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_User_Rank_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_User_Rank_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_User_Rank_Info_RangeOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_User_Rank_Info_RangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGuildOrderAPRewardBoxOK:
                        this.ProcessReceivedMessage_CG_RequestGuildOrderAPRewardBoxOK(readOnlyMessage, pa, hostTag, remoteHostID);
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

        private void ProcessReceivedMessage_CG_RequestGuildInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            GuildMemberInfo guildMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out guildMemberInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInfoOK,
                    rmiName = RmiName_CG_RequestGuildInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildInfoOK(remote, rmiContext, guildInfo, guildMemberInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInfoOK,
                    rmiName = RmiName_CG_RequestGuildInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildRecommendListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildInfo> guildInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildRecommendListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecommendListOK,
                    rmiName = RmiName_CG_RequestGuildRecommendListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildRecommendListOK(remote, rmiContext, guildInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildRecommendListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecommendListOK,
                    rmiName = RmiName_CG_RequestGuildRecommendListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildInfoWithMemberListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            List<GuildMemberInfo> guildMemberInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildMemberInfoList);
            int registerTeamBattlePoint;
            CommonPacket.Marshaler.Read(__msg, out registerTeamBattlePoint);
            int registerAccountBattlePoint;
            CommonPacket.Marshaler.Read(__msg, out registerAccountBattlePoint);
            byte guildWarType;
            CommonPacket.Marshaler.Read(__msg, out guildWarType);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildInfoWithMemberListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInfoWithMemberListOK,
                    rmiName = RmiName_CG_RequestGuildInfoWithMemberListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildInfoWithMemberListOK(remote, rmiContext, guildInfo, guildMemberInfoList, registerTeamBattlePoint, registerAccountBattlePoint, guildWarType))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildInfoWithMemberListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInfoWithMemberListOK,
                    rmiName = RmiName_CG_RequestGuildInfoWithMemberListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildSearchByNameOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildSearchByNameOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSearchByNameOK,
                    rmiName = RmiName_CG_RequestGuildSearchByNameOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildSearchByNameOK(remote, rmiContext, guildInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildSearchByNameOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSearchByNameOK,
                    rmiName = RmiName_CG_RequestGuildSearchByNameOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildCreateOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            ItemResultInfo itemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfo);
            GuildAttendanceStatus guildAttendanceStatus;
            CommonPacket.Marshaler.Read(__msg, out guildAttendanceStatus);
            List<QuestProgressInfo> questProgressList;
            CommonPacket.Marshaler.Read(__msg, out questProgressList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<UserGuildOrderMissionInfo> userGuildOrderMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userGuildOrderMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildCreateOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildCreateOK,
                    rmiName = RmiName_CG_RequestGuildCreateOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildCreateOK(remote, rmiContext, guildInfo, memberInfo, itemResultInfo, guildAttendanceStatus, questProgressList, missionResult, paybackEventresultInfo, userGuildOrderMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildCreateOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildCreateOK,
                    rmiName = RmiName_CG_RequestGuildCreateOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildDisbandOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildDisbandOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDisbandOK,
                    rmiName = RmiName_CG_RequestGuildDisbandOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildDisbandOK(remote, rmiContext, memberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildDisbandOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDisbandOK,
                    rmiName = RmiName_CG_RequestGuildDisbandOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildApplicantListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildMemberInfo> applicantList;
            CommonPacket.Marshaler.Read(__msg, out applicantList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildApplicantListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildApplicantListOK,
                    rmiName = RmiName_CG_RequestGuildApplicantListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildApplicantListOK(remote, rmiContext, applicantList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildApplicantListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildApplicantListOK,
                    rmiName = RmiName_CG_RequestGuildApplicantListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildApplyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            GuildAttendanceStatus guildAttendanceStatus;
            CommonPacket.Marshaler.Read(__msg, out guildAttendanceStatus);
            List<QuestProgressInfo> questProgressList;
            CommonPacket.Marshaler.Read(__msg, out questProgressList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            byte guildWarType;
            CommonPacket.Marshaler.Read(__msg, out guildWarType);
            List<UserGuildOrderMissionInfo> userGuildOrderMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userGuildOrderMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildApplyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildApplyOK,
                    rmiName = RmiName_CG_RequestGuildApplyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildApplyOK(remote, rmiContext, guildInfo, memberInfo, guildAttendanceStatus, questProgressList, missionResult, guildWarType, userGuildOrderMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildApplyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildApplyOK,
                    rmiName = RmiName_CG_RequestGuildApplyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildReturnApplicationOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildReturnApplicationOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildReturnApplicationOK,
                    rmiName = RmiName_CG_RequestGuildReturnApplicationOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildReturnApplicationOK(remote, rmiContext, memberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildReturnApplicationOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildReturnApplicationOK,
                    rmiName = RmiName_CG_RequestGuildReturnApplicationOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildAcceptApplicantOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildAcceptApplicantOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAcceptApplicantOK,
                    rmiName = RmiName_CG_RequestGuildAcceptApplicantOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildAcceptApplicantOK(remote, rmiContext, memberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildAcceptApplicantOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAcceptApplicantOK,
                    rmiName = RmiName_CG_RequestGuildAcceptApplicantOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildRejectApplicantOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildRejectApplicantOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRejectApplicantOK,
                    rmiName = RmiName_CG_RequestGuildRejectApplicantOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildRejectApplicantOK(remote, rmiContext, memberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildRejectApplicantOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRejectApplicantOK,
                    rmiName = RmiName_CG_RequestGuildRejectApplicantOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildLevelUpOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildLevelUpOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildLevelUpOK,
                    rmiName = RmiName_CG_RequestGuildLevelUpOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildLevelUpOK(remote, rmiContext, guildInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildLevelUpOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildLevelUpOK,
                    rmiName = RmiName_CG_RequestGuildLevelUpOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildChangeNameOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildChangeNameOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeNameOK,
                    rmiName = RmiName_CG_RequestGuildChangeNameOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildChangeNameOK(remote, rmiContext, guildInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildChangeNameOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeNameOK,
                    rmiName = RmiName_CG_RequestGuildChangeNameOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildChangeBoardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildChangeBoardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeBoardOK,
                    rmiName = RmiName_CG_RequestGuildChangeBoardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildChangeBoardOK(remote, rmiContext, guildInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildChangeBoardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeBoardOK,
                    rmiName = RmiName_CG_RequestGuildChangeBoardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildChangeMasterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            long newMasterUSN;
            CommonPacket.Marshaler.Read(__msg, out newMasterUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildChangeMasterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeMasterOK,
                    rmiName = RmiName_CG_RequestGuildChangeMasterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildChangeMasterOK(remote, rmiContext, guildInfo, memberInfo, newMasterUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildChangeMasterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeMasterOK,
                    rmiName = RmiName_CG_RequestGuildChangeMasterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildChangeMemberGradeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildChangeMemberGradeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeMemberGradeOK,
                    rmiName = RmiName_CG_RequestGuildChangeMemberGradeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildChangeMemberGradeOK(remote, rmiContext, memberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildChangeMemberGradeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildChangeMemberGradeOK,
                    rmiName = RmiName_CG_RequestGuildChangeMemberGradeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildKickOutMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            GuildMemberInfo kickOutGuildMemberInfo;
            CommonPacket.Marshaler.Read(__msg, out kickOutGuildMemberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildKickOutMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildKickOutMemberOK,
                    rmiName = RmiName_CG_RequestGuildKickOutMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildKickOutMemberOK(remote, rmiContext, guildInfo, kickOutGuildMemberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildKickOutMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildKickOutMemberOK,
                    rmiName = RmiName_CG_RequestGuildKickOutMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildLeaveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildLeaveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildLeaveOK,
                    rmiName = RmiName_CG_RequestGuildLeaveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildLeaveOK(remote, rmiContext, memberInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildLeaveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildLeaveOK,
                    rmiName = RmiName_CG_RequestGuildLeaveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildUserInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int playerExp;
            CommonPacket.Marshaler.Read(__msg, out playerExp);
            int mainSkinExp;
            CommonPacket.Marshaler.Read(__msg, out mainSkinExp);
            string wantToSay;
            CommonPacket.Marshaler.Read(__msg, out wantToSay);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildUserInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildUserInfoOK,
                    rmiName = RmiName_CG_RequestGuildUserInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildUserInfoOK(remote, rmiContext, playerExp, mainSkinExp, wantToSay))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildUserInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildUserInfoOK,
                    rmiName = RmiName_CG_RequestGuildUserInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildAttendanceStatusOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildAttendanceStatus guildAttendanceStatus;
            CommonPacket.Marshaler.Read(__msg, out guildAttendanceStatus);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildAttendanceStatusOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAttendanceStatusOK,
                    rmiName = RmiName_CG_RequestGuildAttendanceStatusOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildAttendanceStatusOK(remote, rmiContext, guildAttendanceStatus))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildAttendanceStatusOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAttendanceStatusOK,
                    rmiName = RmiName_CG_RequestGuildAttendanceStatusOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildRoomInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildRoomInfo guildRoomInfo;
            CommonPacket.Marshaler.Read(__msg, out guildRoomInfo);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildRoomInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRoomInfoOK,
                    rmiName = RmiName_CG_RequestGuildRoomInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildRoomInfoOK(remote, rmiContext, guildRoomInfo, questProgressInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildRoomInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRoomInfoOK,
                    rmiName = RmiName_CG_RequestGuildRoomInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildAttendanceOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildAttendanceResult guildAttendanceResult;
            CommonPacket.Marshaler.Read(__msg, out guildAttendanceResult);
            GuildBattlePointRegisteredResult guildBattlePointRegisteredResult;
            CommonPacket.Marshaler.Read(__msg, out guildBattlePointRegisteredResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildAttendanceOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAttendanceOK,
                    rmiName = RmiName_CG_RequestGuildAttendanceOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildAttendanceOK(remote, rmiContext, guildAttendanceResult, guildBattlePointRegisteredResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildAttendanceOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAttendanceOK,
                    rmiName = RmiName_CG_RequestGuildAttendanceOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildAttendanceRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> rewardItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildAttendanceRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAttendanceRewardOK,
                    rmiName = RmiName_CG_RequestGuildAttendanceRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildAttendanceRewardOK(remote, rmiContext, rewardItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildAttendanceRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildAttendanceRewardOK,
                    rmiName = RmiName_CG_RequestGuildAttendanceRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_GC_NotifyGuildKickout(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_GC_NotifyGuildKickout);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.GC_NotifyGuildKickout,
                    rmiName = RmiName_GC_NotifyGuildKickout,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.GC_NotifyGuildKickout(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_GC_NotifyGuildKickout);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.GC_NotifyGuildKickout,
                    rmiName = RmiName_GC_NotifyGuildKickout,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildDonationOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildDonationResult guildDonationResult;
            CommonPacket.Marshaler.Read(__msg, out guildDonationResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildDonationOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDonationOK,
                    rmiName = RmiName_CG_RequestGuildDonationOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildDonationOK(remote, rmiContext, guildDonationResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildDonationOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDonationOK,
                    rmiName = RmiName_CG_RequestGuildDonationOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildDonationInitializeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildDonationInitializeResult guildDonationInitializeResult;
            CommonPacket.Marshaler.Read(__msg, out guildDonationInitializeResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildDonationInitializeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDonationInitializeOK,
                    rmiName = RmiName_CG_RequestGuildDonationInitializeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildDonationInitializeOK(remote, rmiContext, guildDonationInitializeResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildDonationInitializeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDonationInitializeOK,
                    rmiName = RmiName_CG_RequestGuildDonationInitializeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildMissionInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildMissionInfo> guildMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildMissionInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildMissionInfoOK,
                    rmiName = RmiName_CG_RequestGuildMissionInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildMissionInfoOK(remote, rmiContext, guildMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildMissionInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildMissionInfoOK,
                    rmiName = RmiName_CG_RequestGuildMissionInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildMissionRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildMissionRewardResult guildMissionRewardResult;
            CommonPacket.Marshaler.Read(__msg, out guildMissionRewardResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildMissionRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildMissionRewardOK,
                    rmiName = RmiName_CG_RequestGuildMissionRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildMissionRewardOK(remote, rmiContext, guildMissionRewardResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildMissionRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildMissionRewardOK,
                    rmiName = RmiName_CG_RequestGuildMissionRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_GC_NotifyGuildAcceptApplicantOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            GuildMemberInfo memberInfo;
            CommonPacket.Marshaler.Read(__msg, out memberInfo);
            List<QuestProgressInfo> questProgressList;
            CommonPacket.Marshaler.Read(__msg, out questProgressList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_GC_NotifyGuildAcceptApplicantOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.GC_NotifyGuildAcceptApplicantOK,
                    rmiName = RmiName_GC_NotifyGuildAcceptApplicantOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.GC_NotifyGuildAcceptApplicantOK(remote, rmiContext, guildInfo, memberInfo, questProgressList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_GC_NotifyGuildAcceptApplicantOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.GC_NotifyGuildAcceptApplicantOK,
                    rmiName = RmiName_GC_NotifyGuildAcceptApplicantOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildDonationInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int currentGuildExp;
            CommonPacket.Marshaler.Read(__msg, out currentGuildExp);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildDonationInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDonationInfoOK,
                    rmiName = RmiName_CG_RequestGuildDonationInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildDonationInfoOK(remote, rmiContext, currentGuildExp))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildDonationInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildDonationInfoOK,
                    rmiName = RmiName_CG_RequestGuildDonationInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildSkillInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildSkillUseInfo guildSkillUseInfo;
            CommonPacket.Marshaler.Read(__msg, out guildSkillUseInfo);
            List<GuildSkillInfo> guildSkillList;
            CommonPacket.Marshaler.Read(__msg, out guildSkillList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildSkillInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillInfoOK,
                    rmiName = RmiName_CG_RequestGuildSkillInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildSkillInfoOK(remote, rmiContext, guildSkillUseInfo, guildSkillList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildSkillInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillInfoOK,
                    rmiName = RmiName_CG_RequestGuildSkillInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildSkillLevelUpOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int guildSkillPoint;
            CommonPacket.Marshaler.Read(__msg, out guildSkillPoint);
            GuildSkillInfo guildSkillInfo;
            CommonPacket.Marshaler.Read(__msg, out guildSkillInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildSkillLevelUpOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillLevelUpOK,
                    rmiName = RmiName_CG_RequestGuildSkillLevelUpOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildSkillLevelUpOK(remote, rmiContext, guildSkillPoint, guildSkillInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildSkillLevelUpOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillLevelUpOK,
                    rmiName = RmiName_CG_RequestGuildSkillLevelUpOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildSkillUseOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildSkillInfo guildSkillInfo;
            CommonPacket.Marshaler.Read(__msg, out guildSkillInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildSkillUseOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillUseOK,
                    rmiName = RmiName_CG_RequestGuildSkillUseOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildSkillUseOK(remote, rmiContext, guildSkillInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildSkillUseOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillUseOK,
                    rmiName = RmiName_CG_RequestGuildSkillUseOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildSkillDisuseOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte slotNo;
            CommonPacket.Marshaler.Read(__msg, out slotNo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildSkillDisuseOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillDisuseOK,
                    rmiName = RmiName_CG_RequestGuildSkillDisuseOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildSkillDisuseOK(remote, rmiContext, slotNo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildSkillDisuseOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillDisuseOK,
                    rmiName = RmiName_CG_RequestGuildSkillDisuseOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildSkillUseInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildSkillUseInfo guildSkillUseInfo;
            CommonPacket.Marshaler.Read(__msg, out guildSkillUseInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildSkillUseInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillUseInfoOK,
                    rmiName = RmiName_CG_RequestGuildSkillUseInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildSkillUseInfoOK(remote, rmiContext, guildSkillUseInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildSkillUseInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildSkillUseInfoOK,
                    rmiName = RmiName_CG_RequestGuildSkillUseInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildBossRankPointRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            short rewardOrder;
            CommonPacket.Marshaler.Read(__msg, out rewardOrder);
            bool isNormal;
            CommonPacket.Marshaler.Read(__msg, out isNormal);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildBossRankPointRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBossRankPointRewardOK,
                    rmiName = RmiName_CG_RequestGuildBossRankPointRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildBossRankPointRewardOK(remote, rmiContext, rewardOrder, isNormal, rewardItemInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildBossRankPointRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBossRankPointRewardOK,
                    rmiName = RmiName_CG_RequestGuildBossRankPointRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildBattlePointRegisterOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildBattlePointType type;
            CommonPacket.Marshaler.Read(__msg, out type);
            int registerBattlePoint;
            CommonPacket.Marshaler.Read(__msg, out registerBattlePoint);
            int guildBattlePoint;
            CommonPacket.Marshaler.Read(__msg, out guildBattlePoint);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildBattlePointRegisterOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointRegisterOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointRegisterOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildBattlePointRegisterOK(remote, rmiContext, type, registerBattlePoint, guildBattlePoint))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildBattlePointRegisterOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointRegisterOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointRegisterOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildBattlePointMemeberRankListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildBattlePointType type;
            CommonPacket.Marshaler.Read(__msg, out type);
            GuildBPMemberRankInfo myRankInfo;
            CommonPacket.Marshaler.Read(__msg, out myRankInfo);
            int totalCount;
            CommonPacket.Marshaler.Read(__msg, out totalCount);
            List<GuildBPMemberRankInfo> rankInfoList;
            CommonPacket.Marshaler.Read(__msg, out rankInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildBattlePointMemeberRankListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointMemeberRankListOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointMemeberRankListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildBattlePointMemeberRankListOK(remote, rmiContext, type, myRankInfo, totalCount, rankInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildBattlePointMemeberRankListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointMemeberRankListOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointMemeberRankListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildBattlePointGuildRankListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildBattlePointType type;
            CommonPacket.Marshaler.Read(__msg, out type);
            GuildBPGuildRankInfo myRankInfo;
            CommonPacket.Marshaler.Read(__msg, out myRankInfo);
            int totalCount;
            CommonPacket.Marshaler.Read(__msg, out totalCount);
            List<GuildBPGuildRankInfo> rankInfoList;
            CommonPacket.Marshaler.Read(__msg, out rankInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildBattlePointGuildRankListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointGuildRankListOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointGuildRankListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildBattlePointGuildRankListOK(remote, rmiContext, type, myRankInfo, totalCount, rankInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildBattlePointGuildRankListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointGuildRankListOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointGuildRankListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildBattlePointUserRankListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildBattlePointType type;
            CommonPacket.Marshaler.Read(__msg, out type);
            GuildBPUserRankInfo myRankInfo;
            CommonPacket.Marshaler.Read(__msg, out myRankInfo);
            int totalCount;
            CommonPacket.Marshaler.Read(__msg, out totalCount);
            List<GuildBPUserRankInfo> rankInfoList;
            CommonPacket.Marshaler.Read(__msg, out rankInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildBattlePointUserRankListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointUserRankListOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointUserRankListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildBattlePointUserRankListOK(remote, rmiContext, type, myRankInfo, totalCount, rankInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildBattlePointUserRankListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildBattlePointUserRankListOK,
                    rmiName = RmiName_CG_RequestGuildBattlePointUserRankListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildInvitationReceivedListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildInfo> guildInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildInvitationReceivedListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationReceivedListOK,
                    rmiName = RmiName_CG_RequestGuildInvitationReceivedListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildInvitationReceivedListOK(remote, rmiContext, guildInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildInvitationReceivedListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationReceivedListOK,
                    rmiName = RmiName_CG_RequestGuildInvitationReceivedListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildInvitationSendOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildInvitationSendOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationSendOK,
                    rmiName = RmiName_CG_RequestGuildInvitationSendOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildInvitationSendOK(remote, rmiContext, targetUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildInvitationSendOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationSendOK,
                    rmiName = RmiName_CG_RequestGuildInvitationSendOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildInvitationRemoveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int guildSN;
            CommonPacket.Marshaler.Read(__msg, out guildSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildInvitationRemoveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationRemoveOK,
                    rmiName = RmiName_CG_RequestGuildInvitationRemoveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildInvitationRemoveOK(remote, rmiContext, guildSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildInvitationRemoveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationRemoveOK,
                    rmiName = RmiName_CG_RequestGuildInvitationRemoveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildInvitationSetOptionOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            bool isGuildInvitationOn;
            CommonPacket.Marshaler.Read(__msg, out isGuildInvitationOn);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildInvitationSetOptionOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationSetOptionOK,
                    rmiName = RmiName_CG_RequestGuildInvitationSetOptionOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildInvitationSetOptionOK(remote, rmiContext, isGuildInvitationOn))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildInvitationSetOptionOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildInvitationSetOptionOK,
                    rmiName = RmiName_CG_RequestGuildInvitationSetOptionOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildMarkInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<int> markIdList;
            CommonPacket.Marshaler.Read(__msg, out markIdList);
            List<int> getMarkIdList;
            CommonPacket.Marshaler.Read(__msg, out getMarkIdList);
            List<GuildGroupMissionInfo> missionInfoList;
            CommonPacket.Marshaler.Read(__msg, out missionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildMarkInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildMarkInfoOK,
                    rmiName = RmiName_CG_RequestGuildMarkInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildMarkInfoOK(remote, rmiContext, markIdList, getMarkIdList, missionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildMarkInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildMarkInfoOK,
                    rmiName = RmiName_CG_RequestGuildMarkInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_GC_NotifyGuildRejectApplicantOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_GC_NotifyGuildRejectApplicantOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.GC_NotifyGuildRejectApplicantOK,
                    rmiName = RmiName_GC_NotifyGuildRejectApplicantOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.GC_NotifyGuildRejectApplicantOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_GC_NotifyGuildRejectApplicantOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.GC_NotifyGuildRejectApplicantOK,
                    rmiName = RmiName_GC_NotifyGuildRejectApplicantOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildRecruitListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildInfo> guildInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildRecruitListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecruitListOK,
                    rmiName = RmiName_CG_RequestGuildRecruitListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildRecruitListOK(remote, rmiContext, guildInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildRecruitListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecruitListOK,
                    rmiName = RmiName_CG_RequestGuildRecruitListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildRecruitApplyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            ItemResultInfo itemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildRecruitApplyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecruitApplyOK,
                    rmiName = RmiName_CG_RequestGuildRecruitApplyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildRecruitApplyOK(remote, rmiContext, guildInfo, itemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildRecruitApplyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecruitApplyOK,
                    rmiName = RmiName_CG_RequestGuildRecruitApplyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildRecruitCancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildRecruitCancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecruitCancelOK,
                    rmiName = RmiName_CG_RequestGuildRecruitCancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildRecruitCancelOK(remote, rmiContext, guildInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildRecruitCancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildRecruitCancelOK,
                    rmiName = RmiName_CG_RequestGuildRecruitCancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarLobbyInfo guildWarLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLobbyInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLobbyInfoOK(remote, rmiContext, guildWarLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLobbyInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarRankInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarLeagueRankInfo guildWarLeagueRankInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLeagueRankInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarRankInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRankInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarRankInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarRankInfoOK(remote, rmiContext, guildWarLeagueRankInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarRankInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRankInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarRankInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarVersusRecordInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildInfo> guildInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildInfoList);
            List<GuildWarVersusRecord> guildWarVersusRecordList;
            CommonPacket.Marshaler.Read(__msg, out guildWarVersusRecordList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarVersusRecordInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarVersusRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarVersusRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarVersusRecordInfoOK(remote, rmiContext, guildInfoList, guildWarVersusRecordList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarVersusRecordInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarVersusRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarVersusRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarGuildMemberListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildInfo guildInfo;
            CommonPacket.Marshaler.Read(__msg, out guildInfo);
            List<GuildMemberInfo> guildMemberInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildMemberInfoList);
            List<GuildWarMemberInfo> guildWarMemberInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarMemberInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarGuildMemberListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarGuildMemberListOK,
                    rmiName = RmiName_CG_RequestGuildWarGuildMemberListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarGuildMemberListOK(remote, rmiContext, guildInfo, guildMemberInfoList, guildWarMemberInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarGuildMemberListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarGuildMemberListOK,
                    rmiName = RmiName_CG_RequestGuildWarGuildMemberListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarWorldMapInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            GuildWarWorldMapInfo guildWarWorldMapInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarWorldMapInfo);
            List<UserTeamChangeInfo> userTeamChangeInfoList;
            CommonPacket.Marshaler.Read(__msg, out userTeamChangeInfoList);
            GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarBattleSettingChangeInfo);
            GuildMemberGrade grade;
            CommonPacket.Marshaler.Read(__msg, out grade);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarWorldMapInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarWorldMapInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarWorldMapInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarWorldMapInfoOK(remote, rmiContext, season, guildWarWorldMapInfo, userTeamChangeInfoList, guildWarBattleSettingChangeInfo, grade))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarWorldMapInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarWorldMapInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarWorldMapInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarAttackSquadChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            List<GuildWarSquadSlot> updateGuildWarSquadSlotList;
            CommonPacket.Marshaler.Read(__msg, out updateGuildWarSquadSlotList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarAttackSquadChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackSquadChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackSquadChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarAttackSquadChangeOK(remote, rmiContext, season, updateGuildWarSquadSlotList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarAttackSquadChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackSquadChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackSquadChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            UserTeamChangeInfo userTeamChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out userTeamChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarDefenceTeamChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarDefenceTeamChangeOK(remote, rmiContext, season, userTeamChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarDefenceTeamChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarRegionBonusScoreChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            int regionID;
            CommonPacket.Marshaler.Read(__msg, out regionID);
            int bonusScore;
            CommonPacket.Marshaler.Read(__msg, out bonusScore);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarRegionBonusScoreChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRegionBonusScoreChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarRegionBonusScoreChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarRegionBonusScoreChangeOK(remote, rmiContext, season, regionID, bonusScore))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarRegionBonusScoreChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRegionBonusScoreChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarRegionBonusScoreChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarAreaGuildMemberChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            List<int> swapAreaIDList;
            CommonPacket.Marshaler.Read(__msg, out swapAreaIDList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarAreaGuildMemberChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAreaGuildMemberChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarAreaGuildMemberChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarAreaGuildMemberChangeOK(remote, rmiContext, season, swapAreaIDList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarAreaGuildMemberChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAreaGuildMemberChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarAreaGuildMemberChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarBattleRecordInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            int guildSN;
            CommonPacket.Marshaler.Read(__msg, out guildSN);
            int areaID;
            CommonPacket.Marshaler.Read(__msg, out areaID);
            List<GuildWarBattleRecord> GuildWarBattleRecordList;
            CommonPacket.Marshaler.Read(__msg, out GuildWarBattleRecordList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarBattleRecordInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattleRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarBattleRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarBattleRecordInfoOK(remote, rmiContext, season, guildSN, areaID, GuildWarBattleRecordList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarBattleRecordInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattleRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarBattleRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildWar_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarStageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildWar_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_StartOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildWar_Stage_StartOK(remote, rmiContext, stageStartResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildWar_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_StartOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildWar_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarStageClearResultInfo guildWarStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarStageClearResultInfo);
            List<int> clearMissionIDList;
            CommonPacket.Marshaler.Read(__msg, out clearMissionIDList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildWar_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildWar_Stage_ClearOK(remote, rmiContext, guildWarStageClearResultInfo, clearMissionIDList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildWar_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildWar_Stage_RejoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarStageRejoinResultInfo guildWarStageRejoinResultInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarStageRejoinResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildWar_Stage_RejoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_RejoinOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildWar_Stage_RejoinOK(remote, rmiContext, guildWarStageRejoinResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildWar_Stage_RejoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_RejoinOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildWar_Stage_HeroStatus_SyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildWar_Stage_HeroStatus_SyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_HeroStatus_SyncOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_HeroStatus_SyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildWar_Stage_HeroStatus_SyncOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildWar_Stage_HeroStatus_SyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_HeroStatus_SyncOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_HeroStatus_SyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarBattlePrepareInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            GuildWarBattlePrepareInfo guildWarBattlePrepareInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarBattlePrepareInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarBattlePrepareInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattlePrepareInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarBattlePrepareInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarBattlePrepareInfoOK(remote, rmiContext, season, guildWarBattlePrepareInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarBattlePrepareInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattlePrepareInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarBattlePrepareInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarAttackTeamChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            UserTeamChangeInfo userTeamChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out userTeamChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarAttackTeamChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarAttackTeamChangeOK(remote, rmiContext, season, userTeamChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarAttackTeamChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarDefenceSlotExpandOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            byte updateDefenceBMSlotCount;
            CommonPacket.Marshaler.Read(__msg, out updateDefenceBMSlotCount);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarDefenceSlotExpandOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceSlotExpandOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceSlotExpandOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarDefenceSlotExpandOK(remote, rmiContext, season, updateDefenceBMSlotCount, useItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarDefenceSlotExpandOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceSlotExpandOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceSlotExpandOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarSquadSlotExpandOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            byte updateSquadBMSlotCount;
            CommonPacket.Marshaler.Read(__msg, out updateSquadBMSlotCount);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarSquadSlotExpandOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarSquadSlotExpandOK,
                    rmiName = RmiName_CG_RequestGuildWarSquadSlotExpandOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarSquadSlotExpandOK(remote, rmiContext, season, updateSquadBMSlotCount, useItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarSquadSlotExpandOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarSquadSlotExpandOK,
                    rmiName = RmiName_CG_RequestGuildWarSquadSlotExpandOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarAttackTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            List<UserTeam> guildWarAttackUserTeamList;
            CommonPacket.Marshaler.Read(__msg, out guildWarAttackUserTeamList);
            List<GuildWarSquadSlot> guildWarSquadSlotList;
            CommonPacket.Marshaler.Read(__msg, out guildWarSquadSlotList);
            List<GuildWarTeamBuff> guildWarAttackTeamBuffList;
            CommonPacket.Marshaler.Read(__msg, out guildWarAttackTeamBuffList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarAttackTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarAttackTeamInfoOK(remote, rmiContext, season, guildWarAttackUserTeamList, guildWarSquadSlotList, guildWarAttackTeamBuffList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarAttackTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            int guildSN;
            CommonPacket.Marshaler.Read(__msg, out guildSN);
            long deployUSN;
            CommonPacket.Marshaler.Read(__msg, out deployUSN);
            List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarDefenceTeamInfoList);
            List<GuildWarTeamBuff> guildWarDefenceTeamBuffList;
            CommonPacket.Marshaler.Read(__msg, out guildWarDefenceTeamBuffList);
            List<GuildWarHero> guildWarHeorList;
            CommonPacket.Marshaler.Read(__msg, out guildWarHeorList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarDefenceTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarDefenceTeamInfoOK(remote, rmiContext, season, guildSN, deployUSN, guildWarDefenceTeamInfoList, guildWarDefenceTeamBuffList, guildWarHeorList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarDefenceTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarAttackTeamBuffRegistOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            List<GuildWarTeamBuff> registGuildWarTeamBuffList;
            CommonPacket.Marshaler.Read(__msg, out registGuildWarTeamBuffList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarAttackTeamBuffRegistOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackTeamBuffRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackTeamBuffRegistOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarAttackTeamBuffRegistOK(remote, rmiContext, season, registGuildWarTeamBuffList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarAttackTeamBuffRegistOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarAttackTeamBuffRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarAttackTeamBuffRegistOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamBuffRegistOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            byte teamIndex;
            CommonPacket.Marshaler.Read(__msg, out teamIndex);
            List<GuildWarTeamBuff> registGuildWarTeamBuffList;
            CommonPacket.Marshaler.Read(__msg, out registGuildWarTeamBuffList);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarDefenceTeamBuffRegistOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamBuffRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamBuffRegistOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarDefenceTeamBuffRegistOK(remote, rmiContext, season, teamIndex, registGuildWarTeamBuffList, useItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarDefenceTeamBuffRegistOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamBuffRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamBuffRegistOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildWar_Stage_Rejoin_CancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildWar_Stage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildWar_Stage_Rejoin_CancelOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildWar_Stage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildWar_Stage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_GuildWar_Stage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamInfoAllOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            int guildSN;
            CommonPacket.Marshaler.Read(__msg, out guildSN);
            List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarDefenceTeamInfoList);
            List<GuildWarTeamBuff> guildWarDefenceTeamBuffList;
            CommonPacket.Marshaler.Read(__msg, out guildWarDefenceTeamBuffList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarDefenceTeamInfoAllOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamInfoAllOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamInfoAllOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarDefenceTeamInfoAllOK(remote, rmiContext, season, guildSN, guildWarDefenceTeamInfoList, guildWarDefenceTeamBuffList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarDefenceTeamInfoAllOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamInfoAllOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamInfoAllOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarRankInfoAllOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarLeagueRankInfo> guildWarLeagueRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLeagueRankInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarRankInfoAllOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRankInfoAllOK,
                    rmiName = RmiName_CG_RequestGuildWarRankInfoAllOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarRankInfoAllOK(remote, rmiContext, guildWarLeagueRankInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarRankInfoAllOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRankInfoAllOK,
                    rmiName = RmiName_CG_RequestGuildWarRankInfoAllOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamSaveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarDefenceTeamInfo savedGuildWarDefenceTeamInfo;
            CommonPacket.Marshaler.Read(__msg, out savedGuildWarDefenceTeamInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarDefenceTeamSaveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamSaveOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamSaveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarDefenceTeamSaveOK(remote, rmiContext, savedGuildWarDefenceTeamInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarDefenceTeamSaveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamSaveOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamSaveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarMagicAreaRegistOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int magicAreaID;
            CommonPacket.Marshaler.Read(__msg, out magicAreaID);
            int magicBuffID;
            CommonPacket.Marshaler.Read(__msg, out magicBuffID);
            List<GuildWarRegionInfo> updateGuildWarRegionInfoList;
            CommonPacket.Marshaler.Read(__msg, out updateGuildWarRegionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarMagicAreaRegistOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarMagicAreaRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarMagicAreaRegistOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarMagicAreaRegistOK(remote, rmiContext, magicAreaID, magicBuffID, updateGuildWarRegionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarMagicAreaRegistOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarMagicAreaRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarMagicAreaRegistOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarDefenceTeamSaveAllOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarDefenceTeamInfo> savedGuildWarDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out savedGuildWarDefenceTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarDefenceTeamSaveAllOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamSaveAllOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamSaveAllOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarDefenceTeamSaveAllOK(remote, rmiContext, savedGuildWarDefenceTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarDefenceTeamSaveAllOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarDefenceTeamSaveAllOK,
                    rmiName = RmiName_CG_RequestGuildWarDefenceTeamSaveAllOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowerLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarLobbyInfo guildWarLowerLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowerLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowerLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowerLobbyInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowerLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowerLobbyInfoOK(remote, rmiContext, guildWarLowerLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowerLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowerLobbyInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowerLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarCostumeRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> costumeRewardItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out costumeRewardItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarCostumeRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarCostumeRewardOK,
                    rmiName = RmiName_CG_RequestGuildWarCostumeRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarCostumeRewardOK(remote, rmiContext, costumeRewardItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarCostumeRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarCostumeRewardOK,
                    rmiName = RmiName_CG_RequestGuildWarCostumeRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarRegionAttackPriorityChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarRegionInfo> updateGuildWarRegionInfoList;
            CommonPacket.Marshaler.Read(__msg, out updateGuildWarRegionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarRegionAttackPriorityChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRegionAttackPriorityChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarRegionAttackPriorityChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarRegionAttackPriorityChangeOK(remote, rmiContext, updateGuildWarRegionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarRegionAttackPriorityChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRegionAttackPriorityChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarRegionAttackPriorityChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarBattleSettingChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarBattleSettingChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarBattleSettingChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattleSettingChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarBattleSettingChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarBattleSettingChangeOK(remote, rmiContext, guildWarBattleSettingChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarBattleSettingChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattleSettingChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarBattleSettingChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarBattleSettingChangeInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarBattleSettingChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarBattleSettingChangeInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattleSettingChangeInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarBattleSettingChangeInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarBattleSettingChangeInfoOK(remote, rmiContext, guildWarBattleSettingChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarBattleSettingChangeInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarBattleSettingChangeInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarBattleSettingChangeInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarNonSeasonBattlePrepareInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarBattlePrepareInfo guildWarBattlePrepareInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarBattlePrepareInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarNonSeasonBattlePrepareInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonBattlePrepareInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonBattlePrepareInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarNonSeasonBattlePrepareInfoOK(remote, rmiContext, guildWarBattlePrepareInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarNonSeasonBattlePrepareInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonBattlePrepareInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonBattlePrepareInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarNonSeasonDefenceTeamChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserTeamChangeInfo userTeamChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out userTeamChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarNonSeasonDefenceTeamChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonDefenceTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonDefenceTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarNonSeasonDefenceTeamChangeOK(remote, rmiContext, userTeamChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarNonSeasonDefenceTeamChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonDefenceTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonDefenceTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarDefenceTeamInfo> savedGuildWarDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out savedGuildWarDefenceTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK(remote, rmiContext, savedGuildWarDefenceTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarNonSeasonAttackSquadChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarSquadSlot> updateGuildWarSquadSlotList;
            CommonPacket.Marshaler.Read(__msg, out updateGuildWarSquadSlotList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarNonSeasonAttackSquadChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonAttackSquadChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonAttackSquadChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarNonSeasonAttackSquadChangeOK(remote, rmiContext, updateGuildWarSquadSlotList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarNonSeasonAttackSquadChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarNonSeasonAttackSquadChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarNonSeasonAttackSquadChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarUserInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendGuildWarInfo clientSendGuildWarInfo;
            CommonPacket.Marshaler.Read(__msg, out clientSendGuildWarInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarUserInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarUserInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarUserInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarUserInfoOK(remote, rmiContext, clientSendGuildWarInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarUserInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarUserInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarUserInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarRecommandDefenceTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarRecommandDefenceTeamInfo> guildWarRecommandDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarRecommandDefenceTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarRecommandDefenceTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRecommandDefenceTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarRecommandDefenceTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarRecommandDefenceTeamInfoOK(remote, rmiContext, guildWarRecommandDefenceTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarRecommandDefenceTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRecommandDefenceTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarRecommandDefenceTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarRecommandDefenceTeamRegistOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarRecommandDefenceTeamInfo> guildWarRecommandDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarRecommandDefenceTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarRecommandDefenceTeamRegistOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRecommandDefenceTeamRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarRecommandDefenceTeamRegistOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarRecommandDefenceTeamRegistOK(remote, rmiContext, guildWarRecommandDefenceTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarRecommandDefenceTeamRegistOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarRecommandDefenceTeamRegistOK,
                    rmiName = RmiName_CG_RequestGuildWarRecommandDefenceTeamRegistOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowLobbyInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarLowLobbyInfo guildWarLowLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowLobbyInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowLobbyInfoOK(remote, rmiContext, guildWarLowLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowLobbyInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowLobbyInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowLobbyInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowApplyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarLowAreaInfo> guildWarLowAreaInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowAreaInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowApplyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowApplyOK,
                    rmiName = RmiName_CG_RequestGuildWarLowApplyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowApplyOK(remote, rmiContext, guildWarLowAreaInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowApplyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowApplyOK,
                    rmiName = RmiName_CG_RequestGuildWarLowApplyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowAttackTeamChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            UserTeamChangeInfo userTeamChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out userTeamChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowAttackTeamChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAttackTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAttackTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowAttackTeamChangeOK(remote, rmiContext, season, userTeamChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowAttackTeamChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAttackTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAttackTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowDefenceTeamChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            UserTeamChangeInfo userTeamChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out userTeamChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowDefenceTeamChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowDefenceTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarLowDefenceTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowDefenceTeamChangeOK(remote, rmiContext, season, userTeamChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowDefenceTeamChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowDefenceTeamChangeOK,
                    rmiName = RmiName_CG_RequestGuildWarLowDefenceTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowAreaDeployGuildMemberOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            int areaID;
            CommonPacket.Marshaler.Read(__msg, out areaID);
            long deployUSN;
            CommonPacket.Marshaler.Read(__msg, out deployUSN);
            List<GuildWarLowAreaInfo> guildWarLowAreaInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowAreaInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowAreaDeployGuildMemberOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAreaDeployGuildMemberOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAreaDeployGuildMemberOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowAreaDeployGuildMemberOK(remote, rmiContext, season, areaID, deployUSN, guildWarLowAreaInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowAreaDeployGuildMemberOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAreaDeployGuildMemberOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAreaDeployGuildMemberOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowAreaInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int season;
            CommonPacket.Marshaler.Read(__msg, out season);
            int targetGuildSN;
            CommonPacket.Marshaler.Read(__msg, out targetGuildSN);
            int areaID;
            CommonPacket.Marshaler.Read(__msg, out areaID);
            GuildWarLowAreaInfo guildWarLowAreaInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowAreaInfo);
            List<GuildWarLowMemberInfo> guildWarLowMemberInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowMemberInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowAreaInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAreaInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAreaInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowAreaInfoOK(remote, rmiContext, season, targetGuildSN, areaID, guildWarLowAreaInfo, guildWarLowMemberInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowAreaInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAreaInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAreaInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarLowStageStartResultInfo guildWarLowStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowStageStartResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageStartOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowStageStartOK(remote, rmiContext, guildWarLowStageStartResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageStartOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarLowStageClearResultInfo guildWarLowStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowStageClearResultInfo);
            List<int> clearMissionIDList;
            CommonPacket.Marshaler.Read(__msg, out clearMissionIDList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageClearOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowStageClearOK(remote, rmiContext, guildWarLowStageClearResultInfo, clearMissionIDList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageClearOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowStageRejoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildWarLowStageRejoinResultInfo guildWarLowStageRejoinResultInfo;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowStageRejoinResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowStageRejoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageRejoinOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageRejoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowStageRejoinOK(remote, rmiContext, guildWarLowStageRejoinResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowStageRejoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageRejoinOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageRejoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowStageRejoinCancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowStageRejoinCancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageRejoinCancelOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageRejoinCancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowStageRejoinCancelOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowStageRejoinCancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageRejoinCancelOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageRejoinCancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowStageSyncOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowStageSyncOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageSyncOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageSyncOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowStageSyncOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowStageSyncOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowStageSyncOK,
                    rmiName = RmiName_CG_RequestGuildWarLowStageSyncOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowDefenceTeamSaveAllOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarLowDefenceTeamInfo> savedGuildWarLowDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out savedGuildWarLowDefenceTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowDefenceTeamSaveAllOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowDefenceTeamSaveAllOK,
                    rmiName = RmiName_CG_RequestGuildWarLowDefenceTeamSaveAllOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowDefenceTeamSaveAllOK(remote, rmiContext, savedGuildWarLowDefenceTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowDefenceTeamSaveAllOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowDefenceTeamSaveAllOK,
                    rmiName = RmiName_CG_RequestGuildWarLowDefenceTeamSaveAllOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowBattleRecordInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int guildSN;
            CommonPacket.Marshaler.Read(__msg, out guildSN);
            long deployUSN;
            CommonPacket.Marshaler.Read(__msg, out deployUSN);
            List<GuildWarLowBattleRecord> guildWarLowBattleRecordList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowBattleRecordList);
            List<GuildWarLowDefenceTeamInfo> guildWarLowDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowDefenceTeamInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowBattleRecordInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowBattleRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowBattleRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowBattleRecordInfoOK(remote, rmiContext, guildSN, deployUSN, guildWarLowBattleRecordList, guildWarLowDefenceTeamInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowBattleRecordInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowBattleRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowBattleRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowMemberListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int guildSN;
            CommonPacket.Marshaler.Read(__msg, out guildSN);
            List<GuildWarLowMemberInfo> guildWarLowMemberList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowMemberList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowMemberListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowMemberListOK,
                    rmiName = RmiName_CG_RequestGuildWarLowMemberListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowMemberListOK(remote, rmiContext, guildSN, guildWarLowMemberList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowMemberListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowMemberListOK,
                    rmiName = RmiName_CG_RequestGuildWarLowMemberListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowDefenceTeamInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int guildSN;
            CommonPacket.Marshaler.Read(__msg, out guildSN);
            long deployUSN;
            CommonPacket.Marshaler.Read(__msg, out deployUSN);
            List<GuildWarLowDefenceTeamInfo> guildWarLowDefenceTeamInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowDefenceTeamInfoList);
            List<GuildWarLowHero> guildWarLowHeroList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowHeroList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowDefenceTeamInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowDefenceTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowDefenceTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowDefenceTeamInfoOK(remote, rmiContext, guildSN, deployUSN, guildWarLowDefenceTeamInfoList, guildWarLowHeroList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowDefenceTeamInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowDefenceTeamInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowDefenceTeamInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowAreaInfoListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int targetGuildSN;
            CommonPacket.Marshaler.Read(__msg, out targetGuildSN);
            List<GuildWarLowAreaInfo> guildWarLowAreaInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowAreaInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowAreaInfoListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAreaInfoListOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAreaInfoListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowAreaInfoListOK(remote, rmiContext, targetGuildSN, guildWarLowAreaInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowAreaInfoListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowAreaInfoListOK,
                    rmiName = RmiName_CG_RequestGuildWarLowAreaInfoListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildWarLowRecordInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<GuildWarLowInfo> guildWarLowInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarLowInfoList);
            List<ClientSendGuildWarLowMemberRankInfo> prevRankList;
            CommonPacket.Marshaler.Read(__msg, out prevRankList);
            List<ClientSendGuildWarLowMemberRankInfo> rankList;
            CommonPacket.Marshaler.Read(__msg, out rankList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildWarLowRecordInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildWarLowRecordInfoOK(remote, rmiContext, guildWarLowInfoList, prevRankList, rankList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildWarLowRecordInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildWarLowRecordInfoOK,
                    rmiName = RmiName_CG_RequestGuildWarLowRecordInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int remainSec;
            CommonPacket.Marshaler.Read(__msg, out remainSec);
            List<ShopBuyInfo> guildShopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildShopBuyInfoList);
            byte guildShopResetCount;
            CommonPacket.Marshaler.Read(__msg, out guildShopResetCount);
            int currentGuildExp;
            CommonPacket.Marshaler.Read(__msg, out currentGuildExp);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildShopInfoOK,
                    rmiName = RmiName_CG_RequestGuildShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildShopInfoOK(remote, rmiContext, remainSec, guildShopBuyInfoList, guildShopResetCount, currentGuildExp))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildShopInfoOK,
                    rmiName = RmiName_CG_RequestGuildShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ShopBuyInfo> shopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            int currentGuildExp;
            CommonPacket.Marshaler.Read(__msg, out currentGuildExp);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildShopBuyOK,
                    rmiName = RmiName_CG_RequestGuildShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildShopBuyOK(remote, rmiContext, shopBuyInfoList, missionResult, useItemResultInfoList, getItemResultInfoList, currentGuildExp, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildShopBuyOK,
                    rmiName = RmiName_CG_RequestGuildShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildShopResetOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> itemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfoList);
            byte guildShopResetCount;
            CommonPacket.Marshaler.Read(__msg, out guildShopResetCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            UserADViewInfo updateUserADViewInfo;
            CommonPacket.Marshaler.Read(__msg, out updateUserADViewInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildShopResetOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildShopResetOK,
                    rmiName = RmiName_CG_RequestGuildShopResetOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildShopResetOK(remote, rmiContext, itemResultInfoList, guildShopResetCount, paybackEventresultInfo, updateUserADViewInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildShopResetOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildShopResetOK,
                    rmiName = RmiName_CG_RequestGuildShopResetOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_User_Rank_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildBossDifficulty difficulty;
            CommonPacket.Marshaler.Read(__msg, out difficulty);
            List<ClientSendGuildBossRankInfo> clientGuildBossRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out clientGuildBossRankInfoList);
            RedisGuildBossRankInfo redisGuildBossRankInfo;
            CommonPacket.Marshaler.Read(__msg, out redisGuildBossRankInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_User_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_User_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_User_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_User_Rank_InfoOK(remote, rmiContext, difficulty, clientGuildBossRankInfoList, redisGuildBossRankInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_User_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_User_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_User_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_User_Rank_Info_RangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildBossDifficulty difficulty;
            CommonPacket.Marshaler.Read(__msg, out difficulty);
            List<ClientSendGuildBossRankInfo> clientGuildBossRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out clientGuildBossRankInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_User_Rank_Info_RangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_User_Rank_Info_RangeOK,
                    rmiName = RmiName_CG_Request_GuildBoss_User_Rank_Info_RangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_User_Rank_Info_RangeOK(remote, rmiContext, difficulty, clientGuildBossRankInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_User_Rank_Info_RangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_User_Rank_Info_RangeOK,
                    rmiName = RmiName_CG_Request_GuildBoss_User_Rank_Info_RangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGuildOrderAPRewardBoxOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int groupID;
            CommonPacket.Marshaler.Read(__msg, out groupID);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            List<ItemResultInfo> getFixItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getFixItemResultInfoList);
            List<ItemResultInfo> getRandomItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getRandomItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGuildOrderAPRewardBoxOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildOrderAPRewardBoxOK,
                    rmiName = RmiName_CG_RequestGuildOrderAPRewardBoxOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGuildOrderAPRewardBoxOK(remote, rmiContext, groupID, useItemResultInfoList, getFixItemResultInfoList, getRandomItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGuildOrderAPRewardBoxOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGuildOrderAPRewardBoxOK,
                    rmiName = RmiName_CG_RequestGuildOrderAPRewardBoxOK,
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

        public Stub.CG_RequestGuildInfoOKDelegate CG_RequestGuildInfoOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo guildMemberInfo, MissionResult missionResult) => false;

        public Stub.CG_RequestGuildRecommendListOKDelegate CG_RequestGuildRecommendListOK = (HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList) => false;

        public Stub.CG_RequestGuildInfoWithMemberListOKDelegate CG_RequestGuildInfoWithMemberListOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, List<GuildMemberInfo> guildMemberInfoList, int registerTeamBattlePoint, int registerAccountBattlePoint, byte guildWarType) => false;

        public Stub.CG_RequestGuildSearchByNameOKDelegate CG_RequestGuildSearchByNameOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo) => false;

        public Stub.CG_RequestGuildCreateOKDelegate CG_RequestGuildCreateOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, ItemResultInfo itemResultInfo, GuildAttendanceStatus guildAttendanceStatus, List<QuestProgressInfo> questProgressList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<UserGuildOrderMissionInfo> userGuildOrderMissionInfoList) => false;

        public Stub.CG_RequestGuildDisbandOKDelegate CG_RequestGuildDisbandOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo) => false;

        public Stub.CG_RequestGuildApplicantListOKDelegate CG_RequestGuildApplicantListOK = (HostID remote, RmiContext rmiContext, List<GuildMemberInfo> applicantList) => false;

        public Stub.CG_RequestGuildApplyOKDelegate CG_RequestGuildApplyOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, GuildAttendanceStatus guildAttendanceStatus, List<QuestProgressInfo> questProgressList, MissionResult missionResult, byte guildWarType, List<UserGuildOrderMissionInfo> userGuildOrderMissionInfoList) => false;

        public Stub.CG_RequestGuildReturnApplicationOKDelegate CG_RequestGuildReturnApplicationOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo) => false;

        public Stub.CG_RequestGuildAcceptApplicantOKDelegate CG_RequestGuildAcceptApplicantOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo) => false;

        public Stub.CG_RequestGuildRejectApplicantOKDelegate CG_RequestGuildRejectApplicantOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo) => false;

        public Stub.CG_RequestGuildLevelUpOKDelegate CG_RequestGuildLevelUpOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo) => false;

        public Stub.CG_RequestGuildChangeNameOKDelegate CG_RequestGuildChangeNameOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo) => false;

        public Stub.CG_RequestGuildChangeBoardOKDelegate CG_RequestGuildChangeBoardOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo) => false;

        public Stub.CG_RequestGuildChangeMasterOKDelegate CG_RequestGuildChangeMasterOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, long newMasterUSN) => false;

        public Stub.CG_RequestGuildChangeMemberGradeOKDelegate CG_RequestGuildChangeMemberGradeOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo) => false;

        public Stub.CG_RequestGuildKickOutMemberOKDelegate CG_RequestGuildKickOutMemberOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo kickOutGuildMemberInfo) => false;

        public Stub.CG_RequestGuildLeaveOKDelegate CG_RequestGuildLeaveOK = (HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo) => false;

        public Stub.CG_RequestGuildUserInfoOKDelegate CG_RequestGuildUserInfoOK = (HostID remote, RmiContext rmiContext, int playerExp, int mainSkinExp, string wantToSay) => false;

        public Stub.CG_RequestGuildAttendanceStatusOKDelegate CG_RequestGuildAttendanceStatusOK = (HostID remote, RmiContext rmiContext, GuildAttendanceStatus guildAttendanceStatus) => false;

        public Stub.CG_RequestGuildRoomInfoOKDelegate CG_RequestGuildRoomInfoOK = (HostID remote, RmiContext rmiContext, GuildRoomInfo guildRoomInfo, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestGuildAttendanceOKDelegate CG_RequestGuildAttendanceOK = (HostID remote, RmiContext rmiContext, GuildAttendanceResult guildAttendanceResult, GuildBattlePointRegisteredResult guildBattlePointRegisteredResult) => false;

        public Stub.CG_RequestGuildAttendanceRewardOKDelegate CG_RequestGuildAttendanceRewardOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> rewardItemResultInfoList) => false;

        public Stub.GC_NotifyGuildKickoutDelegate GC_NotifyGuildKickout = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestGuildDonationOKDelegate CG_RequestGuildDonationOK = (HostID remote, RmiContext rmiContext, GuildDonationResult guildDonationResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestGuildDonationInitializeOKDelegate CG_RequestGuildDonationInitializeOK = (HostID remote, RmiContext rmiContext, GuildDonationInitializeResult guildDonationInitializeResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestGuildMissionInfoOKDelegate CG_RequestGuildMissionInfoOK = (HostID remote, RmiContext rmiContext, List<GuildMissionInfo> guildMissionInfoList) => false;

        public Stub.CG_RequestGuildMissionRewardOKDelegate CG_RequestGuildMissionRewardOK = (HostID remote, RmiContext rmiContext, GuildMissionRewardResult guildMissionRewardResult) => false;

        public Stub.GC_NotifyGuildAcceptApplicantOKDelegate GC_NotifyGuildAcceptApplicantOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, List<QuestProgressInfo> questProgressList, MissionResult missionResult) => false;

        public Stub.CG_RequestGuildDonationInfoOKDelegate CG_RequestGuildDonationInfoOK = (HostID remote, RmiContext rmiContext, int currentGuildExp) => false;

        public Stub.CG_RequestGuildSkillInfoOKDelegate CG_RequestGuildSkillInfoOK = (HostID remote, RmiContext rmiContext, GuildSkillUseInfo guildSkillUseInfo, List<GuildSkillInfo> guildSkillList) => false;

        public Stub.CG_RequestGuildSkillLevelUpOKDelegate CG_RequestGuildSkillLevelUpOK = (HostID remote, RmiContext rmiContext, int guildSkillPoint, GuildSkillInfo guildSkillInfo) => false;

        public Stub.CG_RequestGuildSkillUseOKDelegate CG_RequestGuildSkillUseOK = (HostID remote, RmiContext rmiContext, GuildSkillInfo guildSkillInfo) => false;

        public Stub.CG_RequestGuildSkillDisuseOKDelegate CG_RequestGuildSkillDisuseOK = (HostID remote, RmiContext rmiContext, byte slotNo) => false;

        public Stub.CG_RequestGuildSkillUseInfoOKDelegate CG_RequestGuildSkillUseInfoOK = (HostID remote, RmiContext rmiContext, GuildSkillUseInfo guildSkillUseInfo) => false;

        public Stub.CG_RequestGuildBossRankPointRewardOKDelegate CG_RequestGuildBossRankPointRewardOK = (HostID remote, RmiContext rmiContext, short rewardOrder, bool isNormal, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestGuildBattlePointRegisterOKDelegate CG_RequestGuildBattlePointRegisterOK = (HostID remote, RmiContext rmiContext, GuildBattlePointType type, int registerBattlePoint, int guildBattlePoint) => false;

        public Stub.CG_RequestGuildBattlePointMemeberRankListOKDelegate CG_RequestGuildBattlePointMemeberRankListOK = (HostID remote, RmiContext rmiContext, GuildBattlePointType type, GuildBPMemberRankInfo myRankInfo, int totalCount, List<GuildBPMemberRankInfo> rankInfoList) => false;

        public Stub.CG_RequestGuildBattlePointGuildRankListOKDelegate CG_RequestGuildBattlePointGuildRankListOK = (HostID remote, RmiContext rmiContext, GuildBattlePointType type, GuildBPGuildRankInfo myRankInfo, int totalCount, List<GuildBPGuildRankInfo> rankInfoList) => false;

        public Stub.CG_RequestGuildBattlePointUserRankListOKDelegate CG_RequestGuildBattlePointUserRankListOK = (HostID remote, RmiContext rmiContext, GuildBattlePointType type, GuildBPUserRankInfo myRankInfo, int totalCount, List<GuildBPUserRankInfo> rankInfoList) => false;

        public Stub.CG_RequestGuildInvitationReceivedListOKDelegate CG_RequestGuildInvitationReceivedListOK = (HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList) => false;

        public Stub.CG_RequestGuildInvitationSendOKDelegate CG_RequestGuildInvitationSendOK = (HostID remote, RmiContext rmiContext, long targetUSN) => false;

        public Stub.CG_RequestGuildInvitationRemoveOKDelegate CG_RequestGuildInvitationRemoveOK = (HostID remote, RmiContext rmiContext, int guildSN) => false;

        public Stub.CG_RequestGuildInvitationSetOptionOKDelegate CG_RequestGuildInvitationSetOptionOK = (HostID remote, RmiContext rmiContext, bool isGuildInvitationOn) => false;

        public Stub.CG_RequestGuildMarkInfoOKDelegate CG_RequestGuildMarkInfoOK = (HostID remote, RmiContext rmiContext, List<int> markIdList, List<int> getMarkIdList, List<GuildGroupMissionInfo> missionInfoList) => false;

        public Stub.GC_NotifyGuildRejectApplicantOKDelegate GC_NotifyGuildRejectApplicantOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestGuildRecruitListOKDelegate CG_RequestGuildRecruitListOK = (HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList) => false;

        public Stub.CG_RequestGuildRecruitApplyOKDelegate CG_RequestGuildRecruitApplyOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, ItemResultInfo itemResultInfo) => false;

        public Stub.CG_RequestGuildRecruitCancelOKDelegate CG_RequestGuildRecruitCancelOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo) => false;

        public Stub.CG_RequestGuildWarLobbyInfoOKDelegate CG_RequestGuildWarLobbyInfoOK = (HostID remote, RmiContext rmiContext, GuildWarLobbyInfo guildWarLobbyInfo) => false;

        public Stub.CG_RequestGuildWarRankInfoOKDelegate CG_RequestGuildWarRankInfoOK = (HostID remote, RmiContext rmiContext, GuildWarLeagueRankInfo guildWarLeagueRankInfo) => false;

        public Stub.CG_RequestGuildWarVersusRecordInfoOKDelegate CG_RequestGuildWarVersusRecordInfoOK = (HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList, List<GuildWarVersusRecord> guildWarVersusRecordList) => false;

        public Stub.CG_RequestGuildWarGuildMemberListOKDelegate CG_RequestGuildWarGuildMemberListOK = (HostID remote, RmiContext rmiContext, GuildInfo guildInfo, List<GuildMemberInfo> guildMemberInfoList, List<GuildWarMemberInfo> guildWarMemberInfoList) => false;

        public Stub.CG_RequestGuildWarWorldMapInfoOKDelegate CG_RequestGuildWarWorldMapInfoOK = (HostID remote, RmiContext rmiContext, int season, GuildWarWorldMapInfo guildWarWorldMapInfo, List<UserTeamChangeInfo> userTeamChangeInfoList, GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo, GuildMemberGrade grade) => false;

        public Stub.CG_RequestGuildWarAttackSquadChangeOKDelegate CG_RequestGuildWarAttackSquadChangeOK = (HostID remote, RmiContext rmiContext, int season, List<GuildWarSquadSlot> updateGuildWarSquadSlotList) => false;

        public Stub.CG_RequestGuildWarDefenceTeamChangeOKDelegate CG_RequestGuildWarDefenceTeamChangeOK = (HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo) => false;

        public Stub.CG_RequestGuildWarRegionBonusScoreChangeOKDelegate CG_RequestGuildWarRegionBonusScoreChangeOK = (HostID remote, RmiContext rmiContext, int season, int regionID, int bonusScore) => false;

        public Stub.CG_RequestGuildWarAreaGuildMemberChangeOKDelegate CG_RequestGuildWarAreaGuildMemberChangeOK = (HostID remote, RmiContext rmiContext, int season, List<int> swapAreaIDList) => false;

        public Stub.CG_RequestGuildWarBattleRecordInfoOKDelegate CG_RequestGuildWarBattleRecordInfoOK = (HostID remote, RmiContext rmiContext, int season, int guildSN, int areaID, List<GuildWarBattleRecord> GuildWarBattleRecordList) => false;

        public Stub.CG_Request_GuildWar_Stage_StartOKDelegate CG_Request_GuildWar_Stage_StartOK = (HostID remote, RmiContext rmiContext, GuildWarStageStartResultInfo stageStartResultInfo) => false;

        public Stub.CG_Request_GuildWar_Stage_ClearOKDelegate CG_Request_GuildWar_Stage_ClearOK = (HostID remote, RmiContext rmiContext, GuildWarStageClearResultInfo guildWarStageClearResultInfo, List<int> clearMissionIDList) => false;

        public Stub.CG_Request_GuildWar_Stage_RejoinOKDelegate CG_Request_GuildWar_Stage_RejoinOK = (HostID remote, RmiContext rmiContext, GuildWarStageRejoinResultInfo guildWarStageRejoinResultInfo) => false;

        public Stub.CG_Request_GuildWar_Stage_HeroStatus_SyncOKDelegate CG_Request_GuildWar_Stage_HeroStatus_SyncOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestGuildWarBattlePrepareInfoOKDelegate CG_RequestGuildWarBattlePrepareInfoOK = (HostID remote, RmiContext rmiContext, int season, GuildWarBattlePrepareInfo guildWarBattlePrepareInfo) => false;

        public Stub.CG_RequestGuildWarAttackTeamChangeOKDelegate CG_RequestGuildWarAttackTeamChangeOK = (HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo) => false;

        public Stub.CG_RequestGuildWarDefenceSlotExpandOKDelegate CG_RequestGuildWarDefenceSlotExpandOK = (HostID remote, RmiContext rmiContext, int season, byte updateDefenceBMSlotCount, List<ItemResultInfo> useItemResultInfoList) => false;

        public Stub.CG_RequestGuildWarSquadSlotExpandOKDelegate CG_RequestGuildWarSquadSlotExpandOK = (HostID remote, RmiContext rmiContext, int season, byte updateSquadBMSlotCount, List<ItemResultInfo> useItemResultInfoList) => false;

        public Stub.CG_RequestGuildWarAttackTeamInfoOKDelegate CG_RequestGuildWarAttackTeamInfoOK = (HostID remote, RmiContext rmiContext, int season, List<UserTeam> guildWarAttackUserTeamList, List<GuildWarSquadSlot> guildWarSquadSlotList, List<GuildWarTeamBuff> guildWarAttackTeamBuffList) => false;

        public Stub.CG_RequestGuildWarDefenceTeamInfoOKDelegate CG_RequestGuildWarDefenceTeamInfoOK = (HostID remote, RmiContext rmiContext, int season, int guildSN, long deployUSN, List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList, List<GuildWarTeamBuff> guildWarDefenceTeamBuffList, List<GuildWarHero> guildWarHeorList) => false;

        public Stub.CG_RequestGuildWarAttackTeamBuffRegistOKDelegate CG_RequestGuildWarAttackTeamBuffRegistOK = (HostID remote, RmiContext rmiContext, int season, List<GuildWarTeamBuff> registGuildWarTeamBuffList) => false;

        public Stub.CG_RequestGuildWarDefenceTeamBuffRegistOKDelegate CG_RequestGuildWarDefenceTeamBuffRegistOK = (HostID remote, RmiContext rmiContext, int season, byte teamIndex, List<GuildWarTeamBuff> registGuildWarTeamBuffList, List<ItemResultInfo> useItemResultInfoList) => false;

        public Stub.CG_Request_GuildWar_Stage_Rejoin_CancelOKDelegate CG_Request_GuildWar_Stage_Rejoin_CancelOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestGuildWarDefenceTeamInfoAllOKDelegate CG_RequestGuildWarDefenceTeamInfoAllOK = (HostID remote, RmiContext rmiContext, int season, int guildSN, List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList, List<GuildWarTeamBuff> guildWarDefenceTeamBuffList) => false;

        public Stub.CG_RequestGuildWarRankInfoAllOKDelegate CG_RequestGuildWarRankInfoAllOK = (HostID remote, RmiContext rmiContext, List<GuildWarLeagueRankInfo> guildWarLeagueRankInfoList) => false;

        public Stub.CG_RequestGuildWarDefenceTeamSaveOKDelegate CG_RequestGuildWarDefenceTeamSaveOK = (HostID remote, RmiContext rmiContext, GuildWarDefenceTeamInfo savedGuildWarDefenceTeamInfo) => false;

        public Stub.CG_RequestGuildWarMagicAreaRegistOKDelegate CG_RequestGuildWarMagicAreaRegistOK = (HostID remote, RmiContext rmiContext, int magicAreaID, int magicBuffID, List<GuildWarRegionInfo> updateGuildWarRegionInfoList) => false;

        public Stub.CG_RequestGuildWarDefenceTeamSaveAllOKDelegate CG_RequestGuildWarDefenceTeamSaveAllOK = (HostID remote, RmiContext rmiContext, List<GuildWarDefenceTeamInfo> savedGuildWarDefenceTeamInfoList) => false;

        public Stub.CG_RequestGuildWarLowerLobbyInfoOKDelegate CG_RequestGuildWarLowerLobbyInfoOK = (HostID remote, RmiContext rmiContext, GuildWarLobbyInfo guildWarLowerLobbyInfo) => false;

        public Stub.CG_RequestGuildWarCostumeRewardOKDelegate CG_RequestGuildWarCostumeRewardOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> costumeRewardItemResultInfoList) => false;

        public Stub.CG_RequestGuildWarRegionAttackPriorityChangeOKDelegate CG_RequestGuildWarRegionAttackPriorityChangeOK = (HostID remote, RmiContext rmiContext, List<GuildWarRegionInfo> updateGuildWarRegionInfoList) => false;

        public Stub.CG_RequestGuildWarBattleSettingChangeOKDelegate CG_RequestGuildWarBattleSettingChangeOK = (HostID remote, RmiContext rmiContext, GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo) => false;

        public Stub.CG_RequestGuildWarBattleSettingChangeInfoOKDelegate CG_RequestGuildWarBattleSettingChangeInfoOK = (HostID remote, RmiContext rmiContext, GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo) => false;

        public Stub.CG_RequestGuildWarNonSeasonBattlePrepareInfoOKDelegate CG_RequestGuildWarNonSeasonBattlePrepareInfoOK = (HostID remote, RmiContext rmiContext, GuildWarBattlePrepareInfo guildWarBattlePrepareInfo) => false;

        public Stub.CG_RequestGuildWarNonSeasonDefenceTeamChangeOKDelegate CG_RequestGuildWarNonSeasonDefenceTeamChangeOK = (HostID remote, RmiContext rmiContext, UserTeamChangeInfo userTeamChangeInfo) => false;

        public Stub.CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOKDelegate CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK = (HostID remote, RmiContext rmiContext, List<GuildWarDefenceTeamInfo> savedGuildWarDefenceTeamInfoList) => false;

        public Stub.CG_RequestGuildWarNonSeasonAttackSquadChangeOKDelegate CG_RequestGuildWarNonSeasonAttackSquadChangeOK = (HostID remote, RmiContext rmiContext, List<GuildWarSquadSlot> updateGuildWarSquadSlotList) => false;

        public Stub.CG_RequestGuildWarUserInfoOKDelegate CG_RequestGuildWarUserInfoOK = (HostID remote, RmiContext rmiContext, ClientSendGuildWarInfo clientSendGuildWarInfo) => false;

        public Stub.CG_RequestGuildWarRecommandDefenceTeamInfoOKDelegate CG_RequestGuildWarRecommandDefenceTeamInfoOK = (HostID remote, RmiContext rmiContext, List<GuildWarRecommandDefenceTeamInfo> guildWarRecommandDefenceTeamInfoList) => false;

        public Stub.CG_RequestGuildWarRecommandDefenceTeamRegistOKDelegate CG_RequestGuildWarRecommandDefenceTeamRegistOK = (HostID remote, RmiContext rmiContext, List<GuildWarRecommandDefenceTeamInfo> guildWarRecommandDefenceTeamInfoList) => false;

        public Stub.CG_RequestGuildWarLowLobbyInfoOKDelegate CG_RequestGuildWarLowLobbyInfoOK = (HostID remote, RmiContext rmiContext, GuildWarLowLobbyInfo guildWarLowLobbyInfo) => false;

        public Stub.CG_RequestGuildWarLowApplyOKDelegate CG_RequestGuildWarLowApplyOK = (HostID remote, RmiContext rmiContext, List<GuildWarLowAreaInfo> guildWarLowAreaInfoList) => false;

        public Stub.CG_RequestGuildWarLowAttackTeamChangeOKDelegate CG_RequestGuildWarLowAttackTeamChangeOK = (HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo) => false;

        public Stub.CG_RequestGuildWarLowDefenceTeamChangeOKDelegate CG_RequestGuildWarLowDefenceTeamChangeOK = (HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo) => false;

        public Stub.CG_RequestGuildWarLowAreaDeployGuildMemberOKDelegate CG_RequestGuildWarLowAreaDeployGuildMemberOK = (HostID remote, RmiContext rmiContext, int season, int areaID, long deployUSN, List<GuildWarLowAreaInfo> guildWarLowAreaInfoList) => false;

        public Stub.CG_RequestGuildWarLowAreaInfoOKDelegate CG_RequestGuildWarLowAreaInfoOK = (HostID remote, RmiContext rmiContext, int season, int targetGuildSN, int areaID, GuildWarLowAreaInfo guildWarLowAreaInfo, List<GuildWarLowMemberInfo> guildWarLowMemberInfoList) => false;

        public Stub.CG_RequestGuildWarLowStageStartOKDelegate CG_RequestGuildWarLowStageStartOK = (HostID remote, RmiContext rmiContext, GuildWarLowStageStartResultInfo guildWarLowStageStartResultInfo) => false;

        public Stub.CG_RequestGuildWarLowStageClearOKDelegate CG_RequestGuildWarLowStageClearOK = (HostID remote, RmiContext rmiContext, GuildWarLowStageClearResultInfo guildWarLowStageClearResultInfo, List<int> clearMissionIDList) => false;

        public Stub.CG_RequestGuildWarLowStageRejoinOKDelegate CG_RequestGuildWarLowStageRejoinOK = (HostID remote, RmiContext rmiContext, GuildWarLowStageRejoinResultInfo guildWarLowStageRejoinResultInfo) => false;

        public Stub.CG_RequestGuildWarLowStageRejoinCancelOKDelegate CG_RequestGuildWarLowStageRejoinCancelOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestGuildWarLowStageSyncOKDelegate CG_RequestGuildWarLowStageSyncOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestGuildWarLowDefenceTeamSaveAllOKDelegate CG_RequestGuildWarLowDefenceTeamSaveAllOK = (HostID remote, RmiContext rmiContext, List<GuildWarLowDefenceTeamInfo> savedGuildWarLowDefenceTeamInfoList) => false;

        public Stub.CG_RequestGuildWarLowBattleRecordInfoOKDelegate CG_RequestGuildWarLowBattleRecordInfoOK = (HostID remote, RmiContext rmiContext, int guildSN, long deployUSN, List<GuildWarLowBattleRecord> guildWarLowBattleRecordList, List<GuildWarLowDefenceTeamInfo> guildWarLowDefenceTeamInfoList) => false;

        public Stub.CG_RequestGuildWarLowMemberListOKDelegate CG_RequestGuildWarLowMemberListOK = (HostID remote, RmiContext rmiContext, int guildSN, List<GuildWarLowMemberInfo> guildWarLowMemberList) => false;

        public Stub.CG_RequestGuildWarLowDefenceTeamInfoOKDelegate CG_RequestGuildWarLowDefenceTeamInfoOK = (HostID remote, RmiContext rmiContext, int guildSN, long deployUSN, List<GuildWarLowDefenceTeamInfo> guildWarLowDefenceTeamInfoList, List<GuildWarLowHero> guildWarLowHeroList) => false;

        public Stub.CG_RequestGuildWarLowAreaInfoListOKDelegate CG_RequestGuildWarLowAreaInfoListOK = (HostID remote, RmiContext rmiContext, int targetGuildSN, List<GuildWarLowAreaInfo> guildWarLowAreaInfoList) => false;

        public Stub.CG_RequestGuildWarLowRecordInfoOKDelegate CG_RequestGuildWarLowRecordInfoOK = (HostID remote, RmiContext rmiContext, List<GuildWarLowInfo> guildWarLowInfoList, List<ClientSendGuildWarLowMemberRankInfo> prevRankList, List<ClientSendGuildWarLowMemberRankInfo> rankList) => false;

        public Stub.CG_RequestGuildShopInfoOKDelegate CG_RequestGuildShopInfoOK = (HostID remote, RmiContext rmiContext, int remainSec, List<ShopBuyInfo> guildShopBuyInfoList, byte guildShopResetCount, int currentGuildExp) => false;

        public Stub.CG_RequestGuildShopBuyOKDelegate CG_RequestGuildShopBuyOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, MissionResult missionResult, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, int currentGuildExp, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestGuildShopResetOKDelegate CG_RequestGuildShopResetOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> itemResultInfoList, byte guildShopResetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo) => false;

        public Stub.CG_Request_GuildBoss_User_Rank_InfoOKDelegate CG_Request_GuildBoss_User_Rank_InfoOK = (HostID remote, RmiContext rmiContext, GuildBossDifficulty difficulty, List<ClientSendGuildBossRankInfo> clientGuildBossRankInfoList, RedisGuildBossRankInfo redisGuildBossRankInfo) => false;

        public Stub.CG_Request_GuildBoss_User_Rank_Info_RangeOKDelegate CG_Request_GuildBoss_User_Rank_Info_RangeOK = (HostID remote, RmiContext rmiContext, GuildBossDifficulty difficulty, List<ClientSendGuildBossRankInfo> clientGuildBossRankInfoList) => false;

        public Stub.CG_RequestGuildOrderAPRewardBoxOKDelegate CG_RequestGuildOrderAPRewardBoxOK = (HostID remote, RmiContext rmiContext, int groupID, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getFixItemResultInfoList, List<ItemResultInfo> getRandomItemResultInfoList) => false;

        public const string RmiName_CG_RequestGuildInfoOK = "CG_RequestGuildInfoOK";

        public const string RmiName_CG_RequestGuildRecommendListOK = "CG_RequestGuildRecommendListOK";

        public const string RmiName_CG_RequestGuildInfoWithMemberListOK = "CG_RequestGuildInfoWithMemberListOK";

        public const string RmiName_CG_RequestGuildSearchByNameOK = "CG_RequestGuildSearchByNameOK";

        public const string RmiName_CG_RequestGuildCreateOK = "CG_RequestGuildCreateOK";

        public const string RmiName_CG_RequestGuildDisbandOK = "CG_RequestGuildDisbandOK";

        public const string RmiName_CG_RequestGuildApplicantListOK = "CG_RequestGuildApplicantListOK";

        public const string RmiName_CG_RequestGuildApplyOK = "CG_RequestGuildApplyOK";

        public const string RmiName_CG_RequestGuildReturnApplicationOK = "CG_RequestGuildReturnApplicationOK";

        public const string RmiName_CG_RequestGuildAcceptApplicantOK = "CG_RequestGuildAcceptApplicantOK";

        public const string RmiName_CG_RequestGuildRejectApplicantOK = "CG_RequestGuildRejectApplicantOK";

        public const string RmiName_CG_RequestGuildLevelUpOK = "CG_RequestGuildLevelUpOK";

        public const string RmiName_CG_RequestGuildChangeNameOK = "CG_RequestGuildChangeNameOK";

        public const string RmiName_CG_RequestGuildChangeBoardOK = "CG_RequestGuildChangeBoardOK";

        public const string RmiName_CG_RequestGuildChangeMasterOK = "CG_RequestGuildChangeMasterOK";

        public const string RmiName_CG_RequestGuildChangeMemberGradeOK = "CG_RequestGuildChangeMemberGradeOK";

        public const string RmiName_CG_RequestGuildKickOutMemberOK = "CG_RequestGuildKickOutMemberOK";

        public const string RmiName_CG_RequestGuildLeaveOK = "CG_RequestGuildLeaveOK";

        public const string RmiName_CG_RequestGuildUserInfoOK = "CG_RequestGuildUserInfoOK";

        public const string RmiName_CG_RequestGuildAttendanceStatusOK = "CG_RequestGuildAttendanceStatusOK";

        public const string RmiName_CG_RequestGuildRoomInfoOK = "CG_RequestGuildRoomInfoOK";

        public const string RmiName_CG_RequestGuildAttendanceOK = "CG_RequestGuildAttendanceOK";

        public const string RmiName_CG_RequestGuildAttendanceRewardOK = "CG_RequestGuildAttendanceRewardOK";

        public const string RmiName_GC_NotifyGuildKickout = "GC_NotifyGuildKickout";

        public const string RmiName_CG_RequestGuildDonationOK = "CG_RequestGuildDonationOK";

        public const string RmiName_CG_RequestGuildDonationInitializeOK = "CG_RequestGuildDonationInitializeOK";

        public const string RmiName_CG_RequestGuildMissionInfoOK = "CG_RequestGuildMissionInfoOK";

        public const string RmiName_CG_RequestGuildMissionRewardOK = "CG_RequestGuildMissionRewardOK";

        public const string RmiName_GC_NotifyGuildAcceptApplicantOK = "GC_NotifyGuildAcceptApplicantOK";

        public const string RmiName_CG_RequestGuildDonationInfoOK = "CG_RequestGuildDonationInfoOK";

        public const string RmiName_CG_RequestGuildSkillInfoOK = "CG_RequestGuildSkillInfoOK";

        public const string RmiName_CG_RequestGuildSkillLevelUpOK = "CG_RequestGuildSkillLevelUpOK";

        public const string RmiName_CG_RequestGuildSkillUseOK = "CG_RequestGuildSkillUseOK";

        public const string RmiName_CG_RequestGuildSkillDisuseOK = "CG_RequestGuildSkillDisuseOK";

        public const string RmiName_CG_RequestGuildSkillUseInfoOK = "CG_RequestGuildSkillUseInfoOK";

        public const string RmiName_CG_RequestGuildBossRankPointRewardOK = "CG_RequestGuildBossRankPointRewardOK";

        public const string RmiName_CG_RequestGuildBattlePointRegisterOK = "CG_RequestGuildBattlePointRegisterOK";

        public const string RmiName_CG_RequestGuildBattlePointMemeberRankListOK = "CG_RequestGuildBattlePointMemeberRankListOK";

        public const string RmiName_CG_RequestGuildBattlePointGuildRankListOK = "CG_RequestGuildBattlePointGuildRankListOK";

        public const string RmiName_CG_RequestGuildBattlePointUserRankListOK = "CG_RequestGuildBattlePointUserRankListOK";

        public const string RmiName_CG_RequestGuildInvitationReceivedListOK = "CG_RequestGuildInvitationReceivedListOK";

        public const string RmiName_CG_RequestGuildInvitationSendOK = "CG_RequestGuildInvitationSendOK";

        public const string RmiName_CG_RequestGuildInvitationRemoveOK = "CG_RequestGuildInvitationRemoveOK";

        public const string RmiName_CG_RequestGuildInvitationSetOptionOK = "CG_RequestGuildInvitationSetOptionOK";

        public const string RmiName_CG_RequestGuildMarkInfoOK = "CG_RequestGuildMarkInfoOK";

        public const string RmiName_GC_NotifyGuildRejectApplicantOK = "GC_NotifyGuildRejectApplicantOK";

        public const string RmiName_CG_RequestGuildRecruitListOK = "CG_RequestGuildRecruitListOK";

        public const string RmiName_CG_RequestGuildRecruitApplyOK = "CG_RequestGuildRecruitApplyOK";

        public const string RmiName_CG_RequestGuildRecruitCancelOK = "CG_RequestGuildRecruitCancelOK";

        public const string RmiName_CG_RequestGuildWarLobbyInfoOK = "CG_RequestGuildWarLobbyInfoOK";

        public const string RmiName_CG_RequestGuildWarRankInfoOK = "CG_RequestGuildWarRankInfoOK";

        public const string RmiName_CG_RequestGuildWarVersusRecordInfoOK = "CG_RequestGuildWarVersusRecordInfoOK";

        public const string RmiName_CG_RequestGuildWarGuildMemberListOK = "CG_RequestGuildWarGuildMemberListOK";

        public const string RmiName_CG_RequestGuildWarWorldMapInfoOK = "CG_RequestGuildWarWorldMapInfoOK";

        public const string RmiName_CG_RequestGuildWarAttackSquadChangeOK = "CG_RequestGuildWarAttackSquadChangeOK";

        public const string RmiName_CG_RequestGuildWarDefenceTeamChangeOK = "CG_RequestGuildWarDefenceTeamChangeOK";

        public const string RmiName_CG_RequestGuildWarRegionBonusScoreChangeOK = "CG_RequestGuildWarRegionBonusScoreChangeOK";

        public const string RmiName_CG_RequestGuildWarAreaGuildMemberChangeOK = "CG_RequestGuildWarAreaGuildMemberChangeOK";

        public const string RmiName_CG_RequestGuildWarBattleRecordInfoOK = "CG_RequestGuildWarBattleRecordInfoOK";

        public const string RmiName_CG_Request_GuildWar_Stage_StartOK = "CG_Request_GuildWar_Stage_StartOK";

        public const string RmiName_CG_Request_GuildWar_Stage_ClearOK = "CG_Request_GuildWar_Stage_ClearOK";

        public const string RmiName_CG_Request_GuildWar_Stage_RejoinOK = "CG_Request_GuildWar_Stage_RejoinOK";

        public const string RmiName_CG_Request_GuildWar_Stage_HeroStatus_SyncOK = "CG_Request_GuildWar_Stage_HeroStatus_SyncOK";

        public const string RmiName_CG_RequestGuildWarBattlePrepareInfoOK = "CG_RequestGuildWarBattlePrepareInfoOK";

        public const string RmiName_CG_RequestGuildWarAttackTeamChangeOK = "CG_RequestGuildWarAttackTeamChangeOK";

        public const string RmiName_CG_RequestGuildWarDefenceSlotExpandOK = "CG_RequestGuildWarDefenceSlotExpandOK";

        public const string RmiName_CG_RequestGuildWarSquadSlotExpandOK = "CG_RequestGuildWarSquadSlotExpandOK";

        public const string RmiName_CG_RequestGuildWarAttackTeamInfoOK = "CG_RequestGuildWarAttackTeamInfoOK";

        public const string RmiName_CG_RequestGuildWarDefenceTeamInfoOK = "CG_RequestGuildWarDefenceTeamInfoOK";

        public const string RmiName_CG_RequestGuildWarAttackTeamBuffRegistOK = "CG_RequestGuildWarAttackTeamBuffRegistOK";

        public const string RmiName_CG_RequestGuildWarDefenceTeamBuffRegistOK = "CG_RequestGuildWarDefenceTeamBuffRegistOK";

        public const string RmiName_CG_Request_GuildWar_Stage_Rejoin_CancelOK = "CG_Request_GuildWar_Stage_Rejoin_CancelOK";

        public const string RmiName_CG_RequestGuildWarDefenceTeamInfoAllOK = "CG_RequestGuildWarDefenceTeamInfoAllOK";

        public const string RmiName_CG_RequestGuildWarRankInfoAllOK = "CG_RequestGuildWarRankInfoAllOK";

        public const string RmiName_CG_RequestGuildWarDefenceTeamSaveOK = "CG_RequestGuildWarDefenceTeamSaveOK";

        public const string RmiName_CG_RequestGuildWarMagicAreaRegistOK = "CG_RequestGuildWarMagicAreaRegistOK";

        public const string RmiName_CG_RequestGuildWarDefenceTeamSaveAllOK = "CG_RequestGuildWarDefenceTeamSaveAllOK";

        public const string RmiName_CG_RequestGuildWarLowerLobbyInfoOK = "CG_RequestGuildWarLowerLobbyInfoOK";

        public const string RmiName_CG_RequestGuildWarCostumeRewardOK = "CG_RequestGuildWarCostumeRewardOK";

        public const string RmiName_CG_RequestGuildWarRegionAttackPriorityChangeOK = "CG_RequestGuildWarRegionAttackPriorityChangeOK";

        public const string RmiName_CG_RequestGuildWarBattleSettingChangeOK = "CG_RequestGuildWarBattleSettingChangeOK";

        public const string RmiName_CG_RequestGuildWarBattleSettingChangeInfoOK = "CG_RequestGuildWarBattleSettingChangeInfoOK";

        public const string RmiName_CG_RequestGuildWarNonSeasonBattlePrepareInfoOK = "CG_RequestGuildWarNonSeasonBattlePrepareInfoOK";

        public const string RmiName_CG_RequestGuildWarNonSeasonDefenceTeamChangeOK = "CG_RequestGuildWarNonSeasonDefenceTeamChangeOK";

        public const string RmiName_CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK = "CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOK";

        public const string RmiName_CG_RequestGuildWarNonSeasonAttackSquadChangeOK = "CG_RequestGuildWarNonSeasonAttackSquadChangeOK";

        public const string RmiName_CG_RequestGuildWarUserInfoOK = "CG_RequestGuildWarUserInfoOK";

        public const string RmiName_CG_RequestGuildWarRecommandDefenceTeamInfoOK = "CG_RequestGuildWarRecommandDefenceTeamInfoOK";

        public const string RmiName_CG_RequestGuildWarRecommandDefenceTeamRegistOK = "CG_RequestGuildWarRecommandDefenceTeamRegistOK";

        public const string RmiName_CG_RequestGuildWarLowLobbyInfoOK = "CG_RequestGuildWarLowLobbyInfoOK";

        public const string RmiName_CG_RequestGuildWarLowApplyOK = "CG_RequestGuildWarLowApplyOK";

        public const string RmiName_CG_RequestGuildWarLowAttackTeamChangeOK = "CG_RequestGuildWarLowAttackTeamChangeOK";

        public const string RmiName_CG_RequestGuildWarLowDefenceTeamChangeOK = "CG_RequestGuildWarLowDefenceTeamChangeOK";

        public const string RmiName_CG_RequestGuildWarLowAreaDeployGuildMemberOK = "CG_RequestGuildWarLowAreaDeployGuildMemberOK";

        public const string RmiName_CG_RequestGuildWarLowAreaInfoOK = "CG_RequestGuildWarLowAreaInfoOK";

        public const string RmiName_CG_RequestGuildWarLowStageStartOK = "CG_RequestGuildWarLowStageStartOK";

        public const string RmiName_CG_RequestGuildWarLowStageClearOK = "CG_RequestGuildWarLowStageClearOK";

        public const string RmiName_CG_RequestGuildWarLowStageRejoinOK = "CG_RequestGuildWarLowStageRejoinOK";

        public const string RmiName_CG_RequestGuildWarLowStageRejoinCancelOK = "CG_RequestGuildWarLowStageRejoinCancelOK";

        public const string RmiName_CG_RequestGuildWarLowStageSyncOK = "CG_RequestGuildWarLowStageSyncOK";

        public const string RmiName_CG_RequestGuildWarLowDefenceTeamSaveAllOK = "CG_RequestGuildWarLowDefenceTeamSaveAllOK";

        public const string RmiName_CG_RequestGuildWarLowBattleRecordInfoOK = "CG_RequestGuildWarLowBattleRecordInfoOK";

        public const string RmiName_CG_RequestGuildWarLowMemberListOK = "CG_RequestGuildWarLowMemberListOK";

        public const string RmiName_CG_RequestGuildWarLowDefenceTeamInfoOK = "CG_RequestGuildWarLowDefenceTeamInfoOK";

        public const string RmiName_CG_RequestGuildWarLowAreaInfoListOK = "CG_RequestGuildWarLowAreaInfoListOK";

        public const string RmiName_CG_RequestGuildWarLowRecordInfoOK = "CG_RequestGuildWarLowRecordInfoOK";

        public const string RmiName_CG_RequestGuildShopInfoOK = "CG_RequestGuildShopInfoOK";

        public const string RmiName_CG_RequestGuildShopBuyOK = "CG_RequestGuildShopBuyOK";

        public const string RmiName_CG_RequestGuildShopResetOK = "CG_RequestGuildShopResetOK";

        public const string RmiName_CG_Request_GuildBoss_User_Rank_InfoOK = "CG_Request_GuildBoss_User_Rank_InfoOK";

        public const string RmiName_CG_Request_GuildBoss_User_Rank_Info_RangeOK = "CG_Request_GuildBoss_User_Rank_Info_RangeOK";

        public const string RmiName_CG_RequestGuildOrderAPRewardBoxOK = "CG_RequestGuildOrderAPRewardBoxOK";

        public const string RmiName_First = "CG_RequestGuildInfoOK";

        public delegate bool CG_RequestGuildInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo guildMemberInfo, MissionResult missionResult);

        public delegate bool CG_RequestGuildRecommendListOKDelegate(HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList);

        public delegate bool CG_RequestGuildInfoWithMemberListOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, List<GuildMemberInfo> guildMemberInfoList, int registerTeamBattlePoint, int registerAccountBattlePoint, byte guildWarType);

        public delegate bool CG_RequestGuildSearchByNameOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo);

        public delegate bool CG_RequestGuildCreateOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, ItemResultInfo itemResultInfo, GuildAttendanceStatus guildAttendanceStatus, List<QuestProgressInfo> questProgressList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<UserGuildOrderMissionInfo> userGuildOrderMissionInfoList);

        public delegate bool CG_RequestGuildDisbandOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo);

        public delegate bool CG_RequestGuildApplicantListOKDelegate(HostID remote, RmiContext rmiContext, List<GuildMemberInfo> applicantList);

        public delegate bool CG_RequestGuildApplyOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, GuildAttendanceStatus guildAttendanceStatus, List<QuestProgressInfo> questProgressList, MissionResult missionResult, byte guildWarType, List<UserGuildOrderMissionInfo> userGuildOrderMissionInfoList);

        public delegate bool CG_RequestGuildReturnApplicationOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo);

        public delegate bool CG_RequestGuildAcceptApplicantOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo);

        public delegate bool CG_RequestGuildRejectApplicantOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo);

        public delegate bool CG_RequestGuildLevelUpOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo);

        public delegate bool CG_RequestGuildChangeNameOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo);

        public delegate bool CG_RequestGuildChangeBoardOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo);

        public delegate bool CG_RequestGuildChangeMasterOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, long newMasterUSN);

        public delegate bool CG_RequestGuildChangeMemberGradeOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo);

        public delegate bool CG_RequestGuildKickOutMemberOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo kickOutGuildMemberInfo);

        public delegate bool CG_RequestGuildLeaveOKDelegate(HostID remote, RmiContext rmiContext, GuildMemberInfo memberInfo);

        public delegate bool CG_RequestGuildUserInfoOKDelegate(HostID remote, RmiContext rmiContext, int playerExp, int mainSkinExp, string wantToSay);

        public delegate bool CG_RequestGuildAttendanceStatusOKDelegate(HostID remote, RmiContext rmiContext, GuildAttendanceStatus guildAttendanceStatus);

        public delegate bool CG_RequestGuildRoomInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildRoomInfo guildRoomInfo, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult);

        public delegate bool CG_RequestGuildAttendanceOKDelegate(HostID remote, RmiContext rmiContext, GuildAttendanceResult guildAttendanceResult, GuildBattlePointRegisteredResult guildBattlePointRegisteredResult);

        public delegate bool CG_RequestGuildAttendanceRewardOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> rewardItemResultInfoList);

        public delegate bool GC_NotifyGuildKickoutDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestGuildDonationOKDelegate(HostID remote, RmiContext rmiContext, GuildDonationResult guildDonationResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestGuildDonationInitializeOKDelegate(HostID remote, RmiContext rmiContext, GuildDonationInitializeResult guildDonationInitializeResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestGuildMissionInfoOKDelegate(HostID remote, RmiContext rmiContext, List<GuildMissionInfo> guildMissionInfoList);

        public delegate bool CG_RequestGuildMissionRewardOKDelegate(HostID remote, RmiContext rmiContext, GuildMissionRewardResult guildMissionRewardResult);

        public delegate bool GC_NotifyGuildAcceptApplicantOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, GuildMemberInfo memberInfo, List<QuestProgressInfo> questProgressList, MissionResult missionResult);

        public delegate bool CG_RequestGuildDonationInfoOKDelegate(HostID remote, RmiContext rmiContext, int currentGuildExp);

        public delegate bool CG_RequestGuildSkillInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildSkillUseInfo guildSkillUseInfo, List<GuildSkillInfo> guildSkillList);

        public delegate bool CG_RequestGuildSkillLevelUpOKDelegate(HostID remote, RmiContext rmiContext, int guildSkillPoint, GuildSkillInfo guildSkillInfo);

        public delegate bool CG_RequestGuildSkillUseOKDelegate(HostID remote, RmiContext rmiContext, GuildSkillInfo guildSkillInfo);

        public delegate bool CG_RequestGuildSkillDisuseOKDelegate(HostID remote, RmiContext rmiContext, byte slotNo);

        public delegate bool CG_RequestGuildSkillUseInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildSkillUseInfo guildSkillUseInfo);

        public delegate bool CG_RequestGuildBossRankPointRewardOKDelegate(HostID remote, RmiContext rmiContext, short rewardOrder, bool isNormal, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult);

        public delegate bool CG_RequestGuildBattlePointRegisterOKDelegate(HostID remote, RmiContext rmiContext, GuildBattlePointType type, int registerBattlePoint, int guildBattlePoint);

        public delegate bool CG_RequestGuildBattlePointMemeberRankListOKDelegate(HostID remote, RmiContext rmiContext, GuildBattlePointType type, GuildBPMemberRankInfo myRankInfo, int totalCount, List<GuildBPMemberRankInfo> rankInfoList);

        public delegate bool CG_RequestGuildBattlePointGuildRankListOKDelegate(HostID remote, RmiContext rmiContext, GuildBattlePointType type, GuildBPGuildRankInfo myRankInfo, int totalCount, List<GuildBPGuildRankInfo> rankInfoList);

        public delegate bool CG_RequestGuildBattlePointUserRankListOKDelegate(HostID remote, RmiContext rmiContext, GuildBattlePointType type, GuildBPUserRankInfo myRankInfo, int totalCount, List<GuildBPUserRankInfo> rankInfoList);

        public delegate bool CG_RequestGuildInvitationReceivedListOKDelegate(HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList);

        public delegate bool CG_RequestGuildInvitationSendOKDelegate(HostID remote, RmiContext rmiContext, long targetUSN);

        public delegate bool CG_RequestGuildInvitationRemoveOKDelegate(HostID remote, RmiContext rmiContext, int guildSN);

        public delegate bool CG_RequestGuildInvitationSetOptionOKDelegate(HostID remote, RmiContext rmiContext, bool isGuildInvitationOn);

        public delegate bool CG_RequestGuildMarkInfoOKDelegate(HostID remote, RmiContext rmiContext, List<int> markIdList, List<int> getMarkIdList, List<GuildGroupMissionInfo> missionInfoList);

        public delegate bool GC_NotifyGuildRejectApplicantOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestGuildRecruitListOKDelegate(HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList);

        public delegate bool CG_RequestGuildRecruitApplyOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, ItemResultInfo itemResultInfo);

        public delegate bool CG_RequestGuildRecruitCancelOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo);

        public delegate bool CG_RequestGuildWarLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildWarLobbyInfo guildWarLobbyInfo);

        public delegate bool CG_RequestGuildWarRankInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildWarLeagueRankInfo guildWarLeagueRankInfo);

        public delegate bool CG_RequestGuildWarVersusRecordInfoOKDelegate(HostID remote, RmiContext rmiContext, List<GuildInfo> guildInfoList, List<GuildWarVersusRecord> guildWarVersusRecordList);

        public delegate bool CG_RequestGuildWarGuildMemberListOKDelegate(HostID remote, RmiContext rmiContext, GuildInfo guildInfo, List<GuildMemberInfo> guildMemberInfoList, List<GuildWarMemberInfo> guildWarMemberInfoList);

        public delegate bool CG_RequestGuildWarWorldMapInfoOKDelegate(HostID remote, RmiContext rmiContext, int season, GuildWarWorldMapInfo guildWarWorldMapInfo, List<UserTeamChangeInfo> userTeamChangeInfoList, GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo, GuildMemberGrade grade);

        public delegate bool CG_RequestGuildWarAttackSquadChangeOKDelegate(HostID remote, RmiContext rmiContext, int season, List<GuildWarSquadSlot> updateGuildWarSquadSlotList);

        public delegate bool CG_RequestGuildWarDefenceTeamChangeOKDelegate(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo);

        public delegate bool CG_RequestGuildWarRegionBonusScoreChangeOKDelegate(HostID remote, RmiContext rmiContext, int season, int regionID, int bonusScore);

        public delegate bool CG_RequestGuildWarAreaGuildMemberChangeOKDelegate(HostID remote, RmiContext rmiContext, int season, List<int> swapAreaIDList);

        public delegate bool CG_RequestGuildWarBattleRecordInfoOKDelegate(HostID remote, RmiContext rmiContext, int season, int guildSN, int areaID, List<GuildWarBattleRecord> GuildWarBattleRecordList);

        public delegate bool CG_Request_GuildWar_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, GuildWarStageStartResultInfo stageStartResultInfo);

        public delegate bool CG_Request_GuildWar_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, GuildWarStageClearResultInfo guildWarStageClearResultInfo, List<int> clearMissionIDList);

        public delegate bool CG_Request_GuildWar_Stage_RejoinOKDelegate(HostID remote, RmiContext rmiContext, GuildWarStageRejoinResultInfo guildWarStageRejoinResultInfo);

        public delegate bool CG_Request_GuildWar_Stage_HeroStatus_SyncOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestGuildWarBattlePrepareInfoOKDelegate(HostID remote, RmiContext rmiContext, int season, GuildWarBattlePrepareInfo guildWarBattlePrepareInfo);

        public delegate bool CG_RequestGuildWarAttackTeamChangeOKDelegate(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo);

        public delegate bool CG_RequestGuildWarDefenceSlotExpandOKDelegate(HostID remote, RmiContext rmiContext, int season, byte updateDefenceBMSlotCount, List<ItemResultInfo> useItemResultInfoList);

        public delegate bool CG_RequestGuildWarSquadSlotExpandOKDelegate(HostID remote, RmiContext rmiContext, int season, byte updateSquadBMSlotCount, List<ItemResultInfo> useItemResultInfoList);

        public delegate bool CG_RequestGuildWarAttackTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, int season, List<UserTeam> guildWarAttackUserTeamList, List<GuildWarSquadSlot> guildWarSquadSlotList, List<GuildWarTeamBuff> guildWarAttackTeamBuffList);

        public delegate bool CG_RequestGuildWarDefenceTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, int season, int guildSN, long deployUSN, List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList, List<GuildWarTeamBuff> guildWarDefenceTeamBuffList, List<GuildWarHero> guildWarHeorList);

        public delegate bool CG_RequestGuildWarAttackTeamBuffRegistOKDelegate(HostID remote, RmiContext rmiContext, int season, List<GuildWarTeamBuff> registGuildWarTeamBuffList);

        public delegate bool CG_RequestGuildWarDefenceTeamBuffRegistOKDelegate(HostID remote, RmiContext rmiContext, int season, byte teamIndex, List<GuildWarTeamBuff> registGuildWarTeamBuffList, List<ItemResultInfo> useItemResultInfoList);

        public delegate bool CG_Request_GuildWar_Stage_Rejoin_CancelOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestGuildWarDefenceTeamInfoAllOKDelegate(HostID remote, RmiContext rmiContext, int season, int guildSN, List<GuildWarDefenceTeamInfo> guildWarDefenceTeamInfoList, List<GuildWarTeamBuff> guildWarDefenceTeamBuffList);

        public delegate bool CG_RequestGuildWarRankInfoAllOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarLeagueRankInfo> guildWarLeagueRankInfoList);

        public delegate bool CG_RequestGuildWarDefenceTeamSaveOKDelegate(HostID remote, RmiContext rmiContext, GuildWarDefenceTeamInfo savedGuildWarDefenceTeamInfo);

        public delegate bool CG_RequestGuildWarMagicAreaRegistOKDelegate(HostID remote, RmiContext rmiContext, int magicAreaID, int magicBuffID, List<GuildWarRegionInfo> updateGuildWarRegionInfoList);

        public delegate bool CG_RequestGuildWarDefenceTeamSaveAllOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarDefenceTeamInfo> savedGuildWarDefenceTeamInfoList);

        public delegate bool CG_RequestGuildWarLowerLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildWarLobbyInfo guildWarLowerLobbyInfo);

        public delegate bool CG_RequestGuildWarCostumeRewardOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> costumeRewardItemResultInfoList);

        public delegate bool CG_RequestGuildWarRegionAttackPriorityChangeOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarRegionInfo> updateGuildWarRegionInfoList);

        public delegate bool CG_RequestGuildWarBattleSettingChangeOKDelegate(HostID remote, RmiContext rmiContext, GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo);

        public delegate bool CG_RequestGuildWarBattleSettingChangeInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildWarBattleSettingChangeInfo guildWarBattleSettingChangeInfo);

        public delegate bool CG_RequestGuildWarNonSeasonBattlePrepareInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildWarBattlePrepareInfo guildWarBattlePrepareInfo);

        public delegate bool CG_RequestGuildWarNonSeasonDefenceTeamChangeOKDelegate(HostID remote, RmiContext rmiContext, UserTeamChangeInfo userTeamChangeInfo);

        public delegate bool CG_RequestGuildWarNonSeasonDefenceTeamSaveAllOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarDefenceTeamInfo> savedGuildWarDefenceTeamInfoList);

        public delegate bool CG_RequestGuildWarNonSeasonAttackSquadChangeOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarSquadSlot> updateGuildWarSquadSlotList);

        public delegate bool CG_RequestGuildWarUserInfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendGuildWarInfo clientSendGuildWarInfo);

        public delegate bool CG_RequestGuildWarRecommandDefenceTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarRecommandDefenceTeamInfo> guildWarRecommandDefenceTeamInfoList);

        public delegate bool CG_RequestGuildWarRecommandDefenceTeamRegistOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarRecommandDefenceTeamInfo> guildWarRecommandDefenceTeamInfoList);

        public delegate bool CG_RequestGuildWarLowLobbyInfoOKDelegate(HostID remote, RmiContext rmiContext, GuildWarLowLobbyInfo guildWarLowLobbyInfo);

        public delegate bool CG_RequestGuildWarLowApplyOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarLowAreaInfo> guildWarLowAreaInfoList);

        public delegate bool CG_RequestGuildWarLowAttackTeamChangeOKDelegate(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo);

        public delegate bool CG_RequestGuildWarLowDefenceTeamChangeOKDelegate(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo);

        public delegate bool CG_RequestGuildWarLowAreaDeployGuildMemberOKDelegate(HostID remote, RmiContext rmiContext, int season, int areaID, long deployUSN, List<GuildWarLowAreaInfo> guildWarLowAreaInfoList);

        public delegate bool CG_RequestGuildWarLowAreaInfoOKDelegate(HostID remote, RmiContext rmiContext, int season, int targetGuildSN, int areaID, GuildWarLowAreaInfo guildWarLowAreaInfo, List<GuildWarLowMemberInfo> guildWarLowMemberInfoList);

        public delegate bool CG_RequestGuildWarLowStageStartOKDelegate(HostID remote, RmiContext rmiContext, GuildWarLowStageStartResultInfo guildWarLowStageStartResultInfo);

        public delegate bool CG_RequestGuildWarLowStageClearOKDelegate(HostID remote, RmiContext rmiContext, GuildWarLowStageClearResultInfo guildWarLowStageClearResultInfo, List<int> clearMissionIDList);

        public delegate bool CG_RequestGuildWarLowStageRejoinOKDelegate(HostID remote, RmiContext rmiContext, GuildWarLowStageRejoinResultInfo guildWarLowStageRejoinResultInfo);

        public delegate bool CG_RequestGuildWarLowStageRejoinCancelOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestGuildWarLowStageSyncOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestGuildWarLowDefenceTeamSaveAllOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarLowDefenceTeamInfo> savedGuildWarLowDefenceTeamInfoList);

        public delegate bool CG_RequestGuildWarLowBattleRecordInfoOKDelegate(HostID remote, RmiContext rmiContext, int guildSN, long deployUSN, List<GuildWarLowBattleRecord> guildWarLowBattleRecordList, List<GuildWarLowDefenceTeamInfo> guildWarLowDefenceTeamInfoList);

        public delegate bool CG_RequestGuildWarLowMemberListOKDelegate(HostID remote, RmiContext rmiContext, int guildSN, List<GuildWarLowMemberInfo> guildWarLowMemberList);

        public delegate bool CG_RequestGuildWarLowDefenceTeamInfoOKDelegate(HostID remote, RmiContext rmiContext, int guildSN, long deployUSN, List<GuildWarLowDefenceTeamInfo> guildWarLowDefenceTeamInfoList, List<GuildWarLowHero> guildWarLowHeroList);

        public delegate bool CG_RequestGuildWarLowAreaInfoListOKDelegate(HostID remote, RmiContext rmiContext, int targetGuildSN, List<GuildWarLowAreaInfo> guildWarLowAreaInfoList);

        public delegate bool CG_RequestGuildWarLowRecordInfoOKDelegate(HostID remote, RmiContext rmiContext, List<GuildWarLowInfo> guildWarLowInfoList, List<ClientSendGuildWarLowMemberRankInfo> prevRankList, List<ClientSendGuildWarLowMemberRankInfo> rankList);

        public delegate bool CG_RequestGuildShopInfoOKDelegate(HostID remote, RmiContext rmiContext, int remainSec, List<ShopBuyInfo> guildShopBuyInfoList, byte guildShopResetCount, int currentGuildExp);

        public delegate bool CG_RequestGuildShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, MissionResult missionResult, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, int currentGuildExp, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestGuildShopResetOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> itemResultInfoList, byte guildShopResetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo);

        public delegate bool CG_Request_GuildBoss_User_Rank_InfoOKDelegate(HostID remote, RmiContext rmiContext, GuildBossDifficulty difficulty, List<ClientSendGuildBossRankInfo> clientGuildBossRankInfoList, RedisGuildBossRankInfo redisGuildBossRankInfo);

        public delegate bool CG_Request_GuildBoss_User_Rank_Info_RangeOKDelegate(HostID remote, RmiContext rmiContext, GuildBossDifficulty difficulty, List<ClientSendGuildBossRankInfo> clientGuildBossRankInfoList);

        public delegate bool CG_RequestGuildOrderAPRewardBoxOKDelegate(HostID remote, RmiContext rmiContext, int groupID, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getFixItemResultInfoList, List<ItemResultInfo> getRandomItemResultInfoList);
    }
}