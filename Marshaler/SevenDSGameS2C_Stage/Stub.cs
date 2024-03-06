using Nettention.Proud;

namespace SevenDSGameS2C_Stage
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
                    case Common.CG_RequestStageInfoOK:
                        this.ProcessReceivedMessage_CG_RequestStageInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestRecommandHeroOK:
                        this.ProcessReceivedMessage_CG_RequestRecommandHeroOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestIngameBattleStartOK:
                        this.ProcessReceivedMessage_CG_RequestIngameBattleStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestStageRejoinOK:
                        this.ProcessReceivedMessage_CG_RequestStageRejoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Main_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Main_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Main_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Free_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Free_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Free_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestHawkRunStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestHawkRunStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestHawkRunStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestHawkRunStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestEventStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Quest_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Quest_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Quest_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Quest_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Quest_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Quest_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Week_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Week_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Week_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Memorial_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Memorial_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Memorial_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Memorial_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Memorial_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Memorial_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Limited_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Limited_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Limited_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Limited_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Limited_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Limited_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_ExtraStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Main_ExtraStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_ExtraStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Main_ExtraStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_ExtraStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Main_ExtraStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_ExtraStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_ExtraStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_ExtraStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_ExtraStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_ExtraStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_ExtraStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestRewardStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestRewardStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_AnotherMain_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_AnotherMain_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_AnotherMain_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_AnotherMain_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_AnotherMain_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_AnotherMain_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Reverse_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Reverse_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Reverse_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Reverse_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Reverse_Star_RewardOK:
                        this.ProcessReceivedMessage_CG_Request_Reverse_Star_RewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Reverse_Group_RewardOK:
                        this.ProcessReceivedMessage_CG_Request_Reverse_Group_RewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_Stage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_Free_Stage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_Stage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_Week_Stage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_Stage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_Stage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_EventStage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_Week_EventStage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DisasterBoss_Stage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_EventAreaStage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_Free_EventAreaStage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Training_Stage_ClearTicketOK:
                        this.ProcessReceivedMessage_CG_Request_Training_Stage_ClearTicketOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_EventAreaStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Main_EventAreaStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_EventAreaStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Main_EventAreaStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_EventAreaStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Main_EventAreaStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_EventAreaStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Free_EventAreaStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_EventAreaStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Free_EventAreaStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_EventAreaStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Free_EventAreaStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventAreaRewardStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestEventAreaRewardStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Free_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Free_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Free_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_ListEventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Main_ListEventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_ListEventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Main_ListEventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Main_ListEventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Main_ListEventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_ListEventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Free_ListEventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_ListEventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Free_ListEventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_ListEventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Free_ListEventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_EventMainStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_EventMainStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_EventMainStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_EventMainStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_EventMainStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_EventMainStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_EventFreeStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_EventFreeStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_EventFreeStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_EventFreeStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_EventFreeStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_EventFreeStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Limited_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Limited_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Limited_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Limited_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Limited_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Limited_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Boss_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Boss_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Monthly_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Monthly_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Monthly_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Monthly_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Monthly_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Monthly_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestMonthlyStagePointRewardOK:
                        this.ProcessReceivedMessage_CG_RequestMonthlyStagePointRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_ChallengeBoss_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_ChallengeBoss_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_ChallengeBoss_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_ChallengeBoss_EventStage_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_ChallengeBoss_Event_Point_RewardOK:
                        this.ProcessReceivedMessage_CG_Request_ChallengeBoss_Event_Point_RewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Training_Stage_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_Training_Stage_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Training_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Training_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Training_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Training_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Training_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Training_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Training_Stage_OpenOK:
                        this.ProcessReceivedMessage_CG_Request_Training_Stage_OpenOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Training_Stage_RefreshOK:
                        this.ProcessReceivedMessage_CG_Request_Training_Stage_RefreshOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeekStageGaugeRewardOK:
                        this.ProcessReceivedMessage_CG_RequestWeekStageGaugeRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestStageEndLogOK:
                        this.ProcessReceivedMessage_CG_RequestStageEndLogOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_SingleSiege_ExtraStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_SingleSiege_ExtraStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_SingleSiege_ExtraStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_SingleSiege_ExtraStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_SingleSiege_ExtraStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_SingleSiege_ExtraStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Season_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Season_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Season_Rank_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Season_Rank_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Score_RewardOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Score_RewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Stage_Fame_StartOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Stage_Fame_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK:
                        this.ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_Lobby_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_Lobby_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_Rank_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_Rank_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_LastWeek_Rank_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_LastWeek_Rank_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_Time_RefreshOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_Time_RefreshOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DisasterBoss_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DisasterBoss_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DisasterBoss_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Week_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Week_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Week_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Week_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Tower_Stage_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_Tower_Stage_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Tower_Stage_Set_Play_DeckOK:
                        this.ProcessReceivedMessage_CG_Request_Tower_Stage_Set_Play_DeckOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Tower_Stage_ResetOK:
                        this.ProcessReceivedMessage_CG_Request_Tower_Stage_ResetOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Tower_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Tower_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Tower_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Tower_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Lobby_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Lobby_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Squad_ChangeOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Squad_ChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Squad_InitOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Squad_InitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Team_ChangeOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Team_ChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Main_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Main_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Main_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Main_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Free_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Free_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Free_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Free_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Reward_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Reward_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_RejoinOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_RejoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Blitz_EventStage_Rejoin_CancelOK:
                        this.ProcessReceivedMessage_CG_Request_Blitz_EventStage_Rejoin_CancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_Once_EventAreaStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Free_Once_EventAreaStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_Once_EventAreaStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Free_Once_EventAreaStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Free_Once_EventAreaStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Free_Once_EventAreaStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_NorthMain_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_NorthMain_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_NorthMain_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_NorthMain_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_NorthMain_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_NorthMain_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_North_Free_Once_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_North_Free_Once_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_North_Free_Once_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_North_Free_Once_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_North_Free_Once_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_North_Free_Once_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Another_Free_Once_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Another_Free_Once_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Another_Free_Once_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Another_Free_Once_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Another_Free_Once_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Another_Free_Once_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Tower_Stage_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Tower_Stage_ResetOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_ResetOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Tower_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Tower_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_Off_Season_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_Off_Season_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_GuildBoss_Off_Season_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_GuildBoss_Off_Season_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestFinalBossVowUpdateOK:
                        this.ProcessReceivedMessage_CG_RequestFinalBossVowUpdateOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DescentBoss_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_DescentBoss_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DescentBoss_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_DescentBoss_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DescentBoss_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_DescentBoss_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_DescentBoss_Event_Point_RewardOK:
                        this.ProcessReceivedMessage_CG_Request_DescentBoss_Event_Point_RewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeekStageCoinOpenOK:
                        this.ProcessReceivedMessage_CG_RequestWeekStageCoinOpenOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestYggdrasilTowerStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestYggdrasilTowerStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestYggdrasilTowerStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestYggdrasilTowerStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Yggdrasil_Tower_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Yggdrasil_Tower_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Season_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Season_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_InitOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_InitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Team_SaveOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Team_SaveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Stage_RejoinOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Stage_RejoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Stage_Rejoin_CancelOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Stage_Rejoin_CancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Use_Reset_ItemOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Use_Reset_ItemOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Challenge_RewardOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Challenge_RewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureNest_Select_GroupOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureNest_Select_GroupOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestMercenaryListOK:
                        this.ProcessReceivedMessage_CG_RequestMercenaryListOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestMercenaryInfoOK:
                        this.ProcessReceivedMessage_CG_RequestMercenaryInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeekStageKeyOpenOK:
                        this.ProcessReceivedMessage_CG_RequestWeekStageKeyOpenOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaInfoOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaStartOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaTeamSelectOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaTeamSelectOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaTeamChangeOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaTeamChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaStageContinueOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaRestartOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaRestartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventKOFBritanniaStageRejoinCancelOK:
                        this.ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageRejoinCancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarInfoOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarRefreshOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarRefreshOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarTeamSelectOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarTeamSelectOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarExtraStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarExtraStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarExtraStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarExtraStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarRewardOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarDonationOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarDonationOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestAncientWarRankInfoOK:
                        this.ProcessReceivedMessage_CG_RequestAncientWarRankInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeStageRejoinOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeStageRejoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeStageRejoinCancelOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeStageRejoinCancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeStageReChallengeOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeStageReChallengeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeStageReChallengeCancelOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeStageReChallengeCancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Conquest_EventStage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Conquest_EventStage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Conquest_EventStage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Conquest_EventStage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Conquest_EventStage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Conquest_EventStage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Main_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Main_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Main_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Main_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Main_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Main_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Free_Once_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Free_Once_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Free_Once_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Free_Once_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_Disaster_Free_Once_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_Disaster_Free_Once_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_Season_InfoOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_Season_InfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_Stage_StartOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_StartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_Stage_ClearOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_ClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_Stage_ContinueOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_ContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_InitOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_InitOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_Team_SaveOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_Team_SaveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_Stage_RejoinOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_RejoinOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK:
                        this.ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDemonLordStageOpenOK:
                        this.ProcessReceivedMessage_CG_RequestDemonLordStageOpenOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDemonLordStageStartOK:
                        this.ProcessReceivedMessage_CG_RequestDemonLordStageStartOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDemonLordStageClearOK:
                        this.ProcessReceivedMessage_CG_RequestDemonLordStageClearOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDemonLordStageContinueOK:
                        this.ProcessReceivedMessage_CG_RequestDemonLordStageContinueOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDemonLordStageCoinOpenOK:
                        this.ProcessReceivedMessage_CG_RequestDemonLordStageCoinOpenOK(readOnlyMessage, pa, hostTag, remoteHostID);
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

        private void ProcessReceivedMessage_CG_RequestStageInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageInfo stageInfo;
            CommonPacket.Marshaler.Read(__msg, out stageInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestStageInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestStageInfoOK,
                    rmiName = RmiName_CG_RequestStageInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestStageInfoOK(remote, rmiContext, stageInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestStageInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestStageInfoOK,
                    rmiName = RmiName_CG_RequestStageInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestRecommandHeroOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            RecommandHeroRequestInfo requestInfo;
            CommonPacket.Marshaler.Read(__msg, out requestInfo);
            RecommandHeroInfo recommandHeroInfo;
            CommonPacket.Marshaler.Read(__msg, out recommandHeroInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestRecommandHeroOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestRecommandHeroOK,
                    rmiName = RmiName_CG_RequestRecommandHeroOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestRecommandHeroOK(remote, rmiContext, requestInfo, recommandHeroInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestRecommandHeroOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestRecommandHeroOK,
                    rmiName = RmiName_CG_RequestRecommandHeroOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestIngameBattleStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestIngameBattleStartOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestIngameBattleStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestIngameBattleStartOK,
                    rmiName = RmiName_CG_RequestIngameBattleStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestStageRejoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestStageRejoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestStageRejoinOK,
                    rmiName = RmiName_CG_RequestStageRejoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestStageRejoinOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestStageRejoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestStageRejoinOK,
                    rmiName = RmiName_CG_RequestStageRejoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Main_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Main_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            bool isFirstMainStageClear;
            CommonPacket.Marshaler.Read(__msg, out isFirstMainStageClear);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, isFirstMainStageClear, userPackageMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo freeStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out freeStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Free_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_Stage_StartOK(remote, rmiContext, freeStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Free_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo freeStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out freeStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_Stage_ClearOK(remote, rmiContext, freeStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestHawkRunStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo hawkRunStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out hawkRunStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestHawkRunStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestHawkRunStageStartOK,
                    rmiName = RmiName_CG_RequestHawkRunStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestHawkRunStageStartOK(remote, rmiContext, hawkRunStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestHawkRunStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestHawkRunStageStartOK,
                    rmiName = RmiName_CG_RequestHawkRunStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestHawkRunStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo runStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out runStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestHawkRunStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestHawkRunStageClearOK,
                    rmiName = RmiName_CG_RequestHawkRunStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestHawkRunStageClearOK(remote, rmiContext, runStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestHawkRunStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestHawkRunStageClearOK,
                    rmiName = RmiName_CG_RequestHawkRunStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventStageClearOK,
                    rmiName = RmiName_CG_RequestEventStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventStageClearOK(remote, rmiContext, eventStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventStageClearOK,
                    rmiName = RmiName_CG_RequestEventStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Quest_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo questStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out questStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Quest_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Quest_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Quest_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Quest_Stage_StartOK(remote, rmiContext, questStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Quest_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Quest_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Quest_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Quest_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo questStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out questStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Quest_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Quest_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Quest_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Quest_Stage_ClearOK(remote, rmiContext, questStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Quest_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Quest_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Quest_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Quest_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Quest_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Quest_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Quest_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Quest_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Quest_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Quest_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Quest_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo weekStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out weekStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            ItemResultInfo useKeyItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out useKeyItemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Week_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_Stage_StartOK(remote, rmiContext, weekStageStartResultInfo, paybackEventresultInfo, useKeyItemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Week_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo weekStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out weekStageClearResultInfo);
            bool isFirstWeeklyStage;
            CommonPacket.Marshaler.Read(__msg, out isFirstWeeklyStage);
            List<APInfo> apInfoList;
            CommonPacket.Marshaler.Read(__msg, out apInfoList);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Week_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_Stage_ClearOK(remote, rmiContext, weekStageClearResultInfo, isFirstWeeklyStage, apInfoList, userPackageMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Week_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Week_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Week_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo bossStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out bossStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_Stage_StartOK(remote, rmiContext, bossStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo bossClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out bossClearResultInfo);
            bool isDestroyDiscovered;
            CommonPacket.Marshaler.Read(__msg, out isDestroyDiscovered);
            DestroyDiscoverInfo discoverInfo;
            CommonPacket.Marshaler.Read(__msg, out discoverInfo);
            bool isFirstBoss;
            CommonPacket.Marshaler.Read(__msg, out isFirstBoss);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_Stage_ClearOK(remote, rmiContext, bossClearResultInfo, isDestroyDiscovered, discoverInfo, isFirstBoss, userPackageMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Memorial_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo memorialStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out memorialStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Memorial_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Memorial_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Memorial_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Memorial_Stage_StartOK(remote, rmiContext, memorialStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Memorial_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Memorial_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Memorial_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Memorial_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo memorialClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out memorialClearResultInfo);
            UserSkin userSkin;
            CommonPacket.Marshaler.Read(__msg, out userSkin);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Memorial_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Memorial_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Memorial_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Memorial_Stage_ClearOK(remote, rmiContext, memorialClearResultInfo, userSkin))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Memorial_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Memorial_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Memorial_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Memorial_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Memorial_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Memorial_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Memorial_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Memorial_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Memorial_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Memorial_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Memorial_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Limited_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo limitedStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out limitedStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Limited_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Limited_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Limited_Stage_StartOK(remote, rmiContext, limitedStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Limited_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Limited_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Limited_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo limitedStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out limitedStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Limited_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Limited_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Limited_Stage_ClearOK(remote, rmiContext, limitedStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Limited_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Limited_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Limited_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Limited_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Limited_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Limited_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Limited_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Limited_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_ExtraStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo extraMainStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out extraMainStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_ExtraStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ExtraStage_StartOK,
                    rmiName = RmiName_CG_Request_Main_ExtraStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_ExtraStage_StartOK(remote, rmiContext, extraMainStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_ExtraStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ExtraStage_StartOK,
                    rmiName = RmiName_CG_Request_Main_ExtraStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_ExtraStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo extraMainStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out extraMainStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_ExtraStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ExtraStage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_ExtraStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_ExtraStage_ClearOK(remote, rmiContext, extraMainStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_ExtraStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ExtraStage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_ExtraStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_ExtraStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_ExtraStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ExtraStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_ExtraStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_ExtraStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_ExtraStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ExtraStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_ExtraStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_ExtraStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo extraBossStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out extraBossStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_ExtraStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_ExtraStage_StartOK,
                    rmiName = RmiName_CG_Request_Boss_ExtraStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_ExtraStage_StartOK(remote, rmiContext, extraBossStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_ExtraStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_ExtraStage_StartOK,
                    rmiName = RmiName_CG_Request_Boss_ExtraStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_ExtraStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo extraBossStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out extraBossStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_ExtraStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_ExtraStage_ClearOK,
                    rmiName = RmiName_CG_Request_Boss_ExtraStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_ExtraStage_ClearOK(remote, rmiContext, extraBossStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_ExtraStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_ExtraStage_ClearOK,
                    rmiName = RmiName_CG_Request_Boss_ExtraStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_ExtraStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_ExtraStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_ExtraStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Boss_ExtraStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_ExtraStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_ExtraStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_ExtraStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Boss_ExtraStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestRewardStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo rewardStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out rewardStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestRewardStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestRewardStageClearOK,
                    rmiName = RmiName_CG_RequestRewardStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestRewardStageClearOK(remote, rmiContext, rewardStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestRewardStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestRewardStageClearOK,
                    rmiName = RmiName_CG_RequestRewardStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_AnotherMain_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_AnotherMain_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_AnotherMain_Stage_StartOK,
                    rmiName = RmiName_CG_Request_AnotherMain_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_AnotherMain_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_AnotherMain_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_AnotherMain_Stage_StartOK,
                    rmiName = RmiName_CG_Request_AnotherMain_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_AnotherMain_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_AnotherMain_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_AnotherMain_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_AnotherMain_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_AnotherMain_Stage_ClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_AnotherMain_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_AnotherMain_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_AnotherMain_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_AnotherMain_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_AnotherMain_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_AnotherMain_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_AnotherMain_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_AnotherMain_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_AnotherMain_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_AnotherMain_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_AnotherMain_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Reverse_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Reverse_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Reverse_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Reverse_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Reverse_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Reverse_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Reverse_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            ReverseGroupInfo userGroupInfo;
            CommonPacket.Marshaler.Read(__msg, out userGroupInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Reverse_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Reverse_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Reverse_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, userGroupInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Reverse_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Reverse_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Reverse_Star_RewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            short seasonID;
            CommonPacket.Marshaler.Read(__msg, out seasonID);
            byte rewardedIndex;
            CommonPacket.Marshaler.Read(__msg, out rewardedIndex);
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Reverse_Star_RewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Star_RewardOK,
                    rmiName = RmiName_CG_Request_Reverse_Star_RewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Reverse_Star_RewardOK(remote, rmiContext, seasonID, rewardedIndex, getItemResultInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Reverse_Star_RewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Star_RewardOK,
                    rmiName = RmiName_CG_Request_Reverse_Star_RewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Reverse_Group_RewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            short rewardID;
            CommonPacket.Marshaler.Read(__msg, out rewardID);
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Reverse_Group_RewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Group_RewardOK,
                    rmiName = RmiName_CG_Request_Reverse_Group_RewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Reverse_Group_RewardOK(remote, rmiContext, rewardID, getItemResultInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Reverse_Group_RewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Reverse_Group_RewardOK,
                    rmiName = RmiName_CG_Request_Reverse_Group_RewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_Stage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Free_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_Stage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Free_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_Stage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            List<APInfo> apInfoList;
            CommonPacket.Marshaler.Read(__msg, out apInfoList);
            UserADViewInfo adViewRouletteInfo;
            CommonPacket.Marshaler.Read(__msg, out adViewRouletteInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Week_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_Stage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, apInfoList, adViewRouletteInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Week_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_Stage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            bool isDestroyDiscovered;
            CommonPacket.Marshaler.Read(__msg, out isDestroyDiscovered);
            DestroyDiscoverInfo discoverInfo;
            CommonPacket.Marshaler.Read(__msg, out discoverInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            bool isBatchPlay;
            CommonPacket.Marshaler.Read(__msg, out isBatchPlay);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_Stage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, isDestroyDiscovered, discoverInfo, paybackEventResultInfo, isBatchPlay))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Boss_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_EventStage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_EventStage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_EventStage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_EventStage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            bool isDestroyDiscovered;
            CommonPacket.Marshaler.Read(__msg, out isDestroyDiscovered);
            DestroyDisasterDicoverInfo destroyDiscoverInfo;
            CommonPacket.Marshaler.Read(__msg, out destroyDiscoverInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DisasterBoss_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DisasterBoss_Stage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, isDestroyDiscovered, destroyDiscoverInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DisasterBoss_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_EventAreaStage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_EventAreaStage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_EventAreaStage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_EventAreaStage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            List<APInfo> apInfoList;
            CommonPacket.Marshaler.Read(__msg, out apInfoList);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, apInfoList, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Training_Stage_ClearTicketOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearTicketResult ticketClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out ticketClearResultInfo);
            TrainingStageSlotInfo clearStageSlotInfo;
            CommonPacket.Marshaler.Read(__msg, out clearStageSlotInfo);
            List<TrainingStageSlotInfo> openStageSlotInfoList;
            CommonPacket.Marshaler.Read(__msg, out openStageSlotInfoList);
            List<UserSkin> updateSkinList;
            CommonPacket.Marshaler.Read(__msg, out updateSkinList);
            TrainingStageInGameMissionClearInfo trainingStageIngameMissionClearInfo;
            CommonPacket.Marshaler.Read(__msg, out trainingStageIngameMissionClearInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Training_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Training_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Training_Stage_ClearTicketOK(remote, rmiContext, ticketClearResultInfo, clearStageSlotInfo, openStageSlotInfoList, updateSkinList, trainingStageIngameMissionClearInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Training_Stage_ClearTicketOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_ClearTicketOK,
                    rmiName = RmiName_CG_Request_Training_Stage_ClearTicketOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_EventAreaStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventAreaStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventAreaStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_EventAreaStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_EventAreaStage_StartOK,
                    rmiName = RmiName_CG_Request_Main_EventAreaStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_EventAreaStage_StartOK(remote, rmiContext, eventAreaStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_EventAreaStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_EventAreaStage_StartOK,
                    rmiName = RmiName_CG_Request_Main_EventAreaStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_EventAreaStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventAreaStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventAreaStageClearResultInfo);
            UserWorldAreaStageEventInfo userWorldAreaStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userWorldAreaStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_EventAreaStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_EventAreaStage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_EventAreaStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_EventAreaStage_ClearOK(remote, rmiContext, eventAreaStageClearResultInfo, userWorldAreaStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_EventAreaStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_EventAreaStage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_EventAreaStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_EventAreaStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_EventAreaStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_EventAreaStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_EventAreaStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_EventAreaStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_EventAreaStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_EventAreaStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_EventAreaStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_EventAreaStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventAreaFreeStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventAreaFreeStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_EventAreaStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_EventAreaStage_StartOK(remote, rmiContext, eventAreaFreeStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_EventAreaStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_EventAreaStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventAreaFreeStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventAreaFreeStageClearResultInfo);
            UserWorldAreaStageEventInfo userWorldAreaStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userWorldAreaStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_EventAreaStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_EventAreaStage_ClearOK(remote, rmiContext, eventAreaFreeStageClearResultInfo, userWorldAreaStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_EventAreaStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_EventAreaStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_EventAreaStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_EventAreaStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_EventAreaStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventAreaStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_EventAreaStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventAreaRewardStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventAreaRewardStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventAreaRewardStageClearResultInfo);
            UserWorldAreaStageEventInfo userWorldAreaStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userWorldAreaStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventAreaRewardStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventAreaRewardStageClearOK,
                    rmiName = RmiName_CG_RequestEventAreaRewardStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventAreaRewardStageClearOK(remote, rmiContext, eventAreaRewardStageClearResultInfo, userWorldAreaStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventAreaRewardStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventAreaRewardStageClearOK,
                    rmiName = RmiName_CG_RequestEventAreaRewardStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventFreeStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventFreeStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_EventStage_StartOK(remote, rmiContext, eventFreeStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventFreeStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventFreeStageClearResultInfo);
            UserFreeStageEventInfo userFreeStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userFreeStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_EventStage_ClearOK(remote, rmiContext, eventFreeStageClearResultInfo, userFreeStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_ListEventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventListMainStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventListMainStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_ListEventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ListEventStage_StartOK,
                    rmiName = RmiName_CG_Request_Main_ListEventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_ListEventStage_StartOK(remote, rmiContext, eventListMainStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_ListEventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ListEventStage_StartOK,
                    rmiName = RmiName_CG_Request_Main_ListEventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_ListEventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventListMainStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventListMainStageClearResultInfo);
            UserListStageEventInfo userListStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userListStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_ListEventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ListEventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_ListEventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_ListEventStage_ClearOK(remote, rmiContext, eventListMainStageClearResultInfo, userListStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_ListEventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ListEventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Main_ListEventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Main_ListEventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Main_ListEventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ListEventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_ListEventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Main_ListEventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Main_ListEventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Main_ListEventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Main_ListEventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_ListEventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventListFreeStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventListFreeStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_ListEventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_ListEventStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_ListEventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_ListEventStage_StartOK(remote, rmiContext, eventListFreeStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_ListEventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_ListEventStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_ListEventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_ListEventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventListFreeStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventListFreeStageClearResultInfo);
            UserListStageEventInfo userListStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userListStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_ListEventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_ListEventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_ListEventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_ListEventStage_ClearOK(remote, rmiContext, eventListFreeStageClearResultInfo, userListStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_ListEventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_ListEventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_ListEventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_ListEventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_ListEventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_ListEventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_ListEventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_ListEventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_ListEventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_ListEventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_ListEventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_EventMainStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventFinalBossMainStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventFinalBossMainStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_EventMainStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventMainStage_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventMainStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_EventMainStage_StartOK(remote, rmiContext, eventFinalBossMainStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_EventMainStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventMainStage_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventMainStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_EventMainStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventFinalBossMainStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventFinalBossMainStageClearResultInfo);
            UserFinalBossStageEventInfo userFinalBossStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userFinalBossStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_EventMainStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventMainStage_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventMainStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_EventMainStage_ClearOK(remote, rmiContext, eventFinalBossMainStageClearResultInfo, userFinalBossStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_EventMainStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventMainStage_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventMainStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_EventMainStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_EventMainStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventMainStage_ContinueOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventMainStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_EventMainStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_EventMainStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventMainStage_ContinueOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventMainStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_EventFreeStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventFinalBossFreeStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventFinalBossFreeStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_EventFreeStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventFreeStage_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventFreeStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_EventFreeStage_StartOK(remote, rmiContext, eventFinalBossFreeStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_EventFreeStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventFreeStage_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventFreeStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_EventFreeStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventFinalBossFreeStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventFinalBossFreeStageClearResultInfo);
            UserFinalBossStageEventInfo userFinalBossStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userFinalBossStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_EventFreeStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventFreeStage_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventFreeStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_EventFreeStage_ClearOK(remote, rmiContext, eventFinalBossFreeStageClearResultInfo, userFinalBossStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_EventFreeStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventFreeStage_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventFreeStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_EventFreeStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_EventFreeStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventFreeStage_ContinueOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventFreeStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_EventFreeStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_EventFreeStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_EventFreeStage_ContinueOK,
                    rmiName = RmiName_CG_Request_FinalBoss_EventFreeStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Limited_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventLimitedStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventLimitedStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Limited_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Limited_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Limited_EventStage_StartOK(remote, rmiContext, eventLimitedStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Limited_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Limited_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Limited_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventLimitedStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventLimitedStageClearResultInfo);
            UserWorldAreaStageEventInfo userWorldAreaStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userWorldAreaStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Limited_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Limited_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Limited_EventStage_ClearOK(remote, rmiContext, eventLimitedStageClearResultInfo, userWorldAreaStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Limited_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Limited_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Limited_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Limited_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Limited_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Limited_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Limited_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Limited_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Limited_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventBossStageStartResultInf;
            CommonPacket.Marshaler.Read(__msg, out eventBossStageStartResultInf);
            PaybackEventResultInfo paybackEventresultInfoo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfoo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Boss_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_EventStage_StartOK(remote, rmiContext, eventBossStageStartResultInf, paybackEventresultInfoo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Boss_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventBossStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventBossStageClearResultInfo);
            bool isDestroyDiscovered;
            CommonPacket.Marshaler.Read(__msg, out isDestroyDiscovered);
            DestroyDiscoverInfo eventDiscoverInfo;
            CommonPacket.Marshaler.Read(__msg, out eventDiscoverInfo);
            bool isFirstBoss;
            CommonPacket.Marshaler.Read(__msg, out isFirstBoss);
            UserWorldAreaStageEventInfo userWorldAreaStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userWorldAreaStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Boss_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_EventStage_ClearOK(remote, rmiContext, eventBossStageClearResultInfo, isDestroyDiscovered, eventDiscoverInfo, isFirstBoss, userWorldAreaStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Boss_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Boss_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Boss_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Boss_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Boss_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Boss_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Boss_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Boss_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Monthly_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo monthlyStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out monthlyStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Monthly_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Monthly_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Monthly_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Monthly_EventStage_StartOK(remote, rmiContext, monthlyStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Monthly_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Monthly_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Monthly_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Monthly_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventLimitedStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventLimitedStageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Monthly_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Monthly_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Monthly_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Monthly_EventStage_ClearOK(remote, rmiContext, eventLimitedStageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Monthly_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Monthly_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Monthly_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Monthly_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Monthly_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Monthly_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Monthly_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Monthly_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Monthly_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Monthly_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Monthly_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestMonthlyStagePointRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte rewardIndex;
            CommonPacket.Marshaler.Read(__msg, out rewardIndex);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestMonthlyStagePointRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestMonthlyStagePointRewardOK,
                    rmiName = RmiName_CG_RequestMonthlyStagePointRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestMonthlyStagePointRewardOK(remote, rmiContext, rewardIndex, getItemResultInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestMonthlyStagePointRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestMonthlyStagePointRewardOK,
                    rmiName = RmiName_CG_RequestMonthlyStagePointRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_ChallengeBoss_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_ChallengeBoss_EventStage_StartOK(remote, rmiContext, stageStartResultInfo, userPlayCountEventInfoList, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_ChallengeBoss_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            ChallengeBossEventStageClearResultInfo resultInfo;
            CommonPacket.Marshaler.Read(__msg, out resultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_ChallengeBoss_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_ChallengeBoss_EventStage_ClearOK(remote, rmiContext, stageClearResultInfo, resultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_ChallengeBoss_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_ChallengeBoss_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_ChallengeBoss_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_ChallengeBoss_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_ChallengeBoss_EventStage_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendEventChallengeBossLobbyInfo info;
            CommonPacket.Marshaler.Read(__msg, out info);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_ChallengeBoss_EventStage_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_InfoOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_ChallengeBoss_EventStage_InfoOK(remote, rmiContext, info))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_ChallengeBoss_EventStage_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_EventStage_InfoOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_EventStage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_ChallengeBoss_Event_Point_RewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ChallengeBossEventInfoToClientSend info;
            CommonPacket.Marshaler.Read(__msg, out info);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            PaybackEventResultInfo m_paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out m_paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_ChallengeBoss_Event_Point_RewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_Event_Point_RewardOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_Event_Point_RewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_ChallengeBoss_Event_Point_RewardOK(remote, rmiContext, info, getItemResultInfoList, m_paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_ChallengeBoss_Event_Point_RewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_ChallengeBoss_Event_Point_RewardOK,
                    rmiName = RmiName_CG_Request_ChallengeBoss_Event_Point_RewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Training_Stage_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TrainingStageInfo trainingStageInfo;
            CommonPacket.Marshaler.Read(__msg, out trainingStageInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Training_Stage_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_InfoOK,
                    rmiName = RmiName_CG_Request_Training_Stage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Training_Stage_InfoOK(remote, rmiContext, trainingStageInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Training_Stage_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_InfoOK,
                    rmiName = RmiName_CG_Request_Training_Stage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Training_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Training_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Training_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Training_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Training_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Training_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Training_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            TrainingStageSlotInfo clearStageSlotInfo;
            CommonPacket.Marshaler.Read(__msg, out clearStageSlotInfo);
            List<TrainingStageSlotInfo> openStageSlotInfoList;
            CommonPacket.Marshaler.Read(__msg, out openStageSlotInfoList);
            List<UserSkin> updateSkinList;
            CommonPacket.Marshaler.Read(__msg, out updateSkinList);
            TrainingStageInGameMissionClearInfo trainingStageIngameMissionClearInfo;
            CommonPacket.Marshaler.Read(__msg, out trainingStageIngameMissionClearInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Training_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Training_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Training_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, clearStageSlotInfo, openStageSlotInfoList, updateSkinList, trainingStageIngameMissionClearInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Training_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Training_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Training_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Training_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Training_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Training_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Training_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Training_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Training_Stage_OpenOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TrainingStageInfo trainingStageInfo;
            CommonPacket.Marshaler.Read(__msg, out trainingStageInfo);
            APInfo apInfo;
            CommonPacket.Marshaler.Read(__msg, out apInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Training_Stage_OpenOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_OpenOK,
                    rmiName = RmiName_CG_Request_Training_Stage_OpenOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Training_Stage_OpenOK(remote, rmiContext, trainingStageInfo, apInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Training_Stage_OpenOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_OpenOK,
                    rmiName = RmiName_CG_Request_Training_Stage_OpenOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Training_Stage_RefreshOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TrainingStageInfo trainingStageInfo;
            CommonPacket.Marshaler.Read(__msg, out trainingStageInfo);
            List<ItemResultInfo> useResultItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out useResultItemInfoList);
            List<TrainingStageSlotInfo> updatedStageList;
            CommonPacket.Marshaler.Read(__msg, out updatedStageList);
            int resultDailyResetCount;
            CommonPacket.Marshaler.Read(__msg, out resultDailyResetCount);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Training_Stage_RefreshOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_RefreshOK,
                    rmiName = RmiName_CG_Request_Training_Stage_RefreshOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Training_Stage_RefreshOK(remote, rmiContext, trainingStageInfo, useResultItemInfoList, updatedStageList, resultDailyResetCount))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Training_Stage_RefreshOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Training_Stage_RefreshOK,
                    rmiName = RmiName_CG_Request_Training_Stage_RefreshOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeekStageGaugeRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            WeekStageGroupType weekStageGroupType;
            CommonPacket.Marshaler.Read(__msg, out weekStageGroupType);
            int groupID;
            CommonPacket.Marshaler.Read(__msg, out groupID);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeekStageGaugeRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageGaugeRewardOK,
                    rmiName = RmiName_CG_RequestWeekStageGaugeRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeekStageGaugeRewardOK(remote, rmiContext, getItemResultInfoList, weekStageGroupType, groupID, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeekStageGaugeRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageGaugeRewardOK,
                    rmiName = RmiName_CG_RequestWeekStageGaugeRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestStageEndLogOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestStageEndLogOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestStageEndLogOK,
                    rmiName = RmiName_CG_RequestStageEndLogOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestStageEndLogOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestStageEndLogOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestStageEndLogOK,
                    rmiName = RmiName_CG_RequestStageEndLogOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_SingleSiege_ExtraStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_SingleSiege_ExtraStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_SingleSiege_ExtraStage_StartOK,
                    rmiName = RmiName_CG_Request_SingleSiege_ExtraStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_SingleSiege_ExtraStage_StartOK(remote, rmiContext, startResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_SingleSiege_ExtraStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_SingleSiege_ExtraStage_StartOK,
                    rmiName = RmiName_CG_Request_SingleSiege_ExtraStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_SingleSiege_ExtraStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            DestroyClearResult destroyClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out destroyClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_SingleSiege_ExtraStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_SingleSiege_ExtraStage_ClearOK,
                    rmiName = RmiName_CG_Request_SingleSiege_ExtraStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_SingleSiege_ExtraStage_ClearOK(remote, rmiContext, stageClearResultInfo, destroyClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_SingleSiege_ExtraStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_SingleSiege_ExtraStage_ClearOK,
                    rmiName = RmiName_CG_Request_SingleSiege_ExtraStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_SingleSiege_ExtraStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_SingleSiege_ExtraStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_SingleSiege_ExtraStage_ContinueOK,
                    rmiName = RmiName_CG_Request_SingleSiege_ExtraStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_SingleSiege_ExtraStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_SingleSiege_ExtraStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_SingleSiege_ExtraStage_ContinueOK,
                    rmiName = RmiName_CG_Request_SingleSiege_ExtraStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Stage_StartOK(remote, rmiContext, startResultInfo, userPlayCountEventInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            FinalBossStageResult finalBossStageResult;
            CommonPacket.Marshaler.Read(__msg, out finalBossStageResult);
            List<int> clearFinalBossMissionIDList;
            CommonPacket.Marshaler.Read(__msg, out clearFinalBossMissionIDList);
            List<int> clearFinalBossVowIDList;
            CommonPacket.Marshaler.Read(__msg, out clearFinalBossVowIDList);
            RedisFinalBossRankInfo redisFinalBossRankInfo;
            CommonPacket.Marshaler.Read(__msg, out redisFinalBossRankInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, finalBossStageResult, clearFinalBossMissionIDList, clearFinalBossVowIDList, redisFinalBossRankInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Season_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendFinalBossSeasonInfo clientSendFinalBossSeasonInfo;
            CommonPacket.Marshaler.Read(__msg, out clientSendFinalBossSeasonInfo);
            List<ItemResultInfo> clearItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out clearItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Season_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Season_InfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Season_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Season_InfoOK(remote, rmiContext, clientSendFinalBossSeasonInfo, clearItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Season_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Season_InfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Season_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Season_Rank_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ClientSendFinalBossRankInfo> clientSendFinalBossRankInfoListTop100;
            CommonPacket.Marshaler.Read(__msg, out clientSendFinalBossRankInfoListTop100);
            List<ClientSendFinalBossRankHeroInfo> clientSendFinalBossHeroRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out clientSendFinalBossHeroRankInfoList);
            FinalBossUserRankInfo userFinalBossRankInfo;
            CommonPacket.Marshaler.Read(__msg, out userFinalBossRankInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Season_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Season_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Season_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Season_Rank_InfoOK(remote, rmiContext, clientSendFinalBossRankInfoListTop100, clientSendFinalBossHeroRankInfoList, userFinalBossRankInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Season_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Season_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Season_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Score_RewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int seasonID;
            CommonPacket.Marshaler.Read(__msg, out seasonID);
            int bossGroupID;
            CommonPacket.Marshaler.Read(__msg, out bossGroupID);
            int lastScoreRewardOrder;
            CommonPacket.Marshaler.Read(__msg, out lastScoreRewardOrder);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Score_RewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Score_RewardOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Score_RewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Score_RewardOK(remote, rmiContext, seasonID, bossGroupID, lastScoreRewardOrder, getItemResultInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Score_RewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Score_RewardOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Score_RewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Stage_Fame_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Stage_Fame_StartOK(remote, rmiContext, startResultInfo, userPlayCountEventInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Stage_Fame_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_StartOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            FinalBossStageResult finalBossStageResult;
            CommonPacket.Marshaler.Read(__msg, out finalBossStageResult);
            FameResultInfo oldFameInfo;
            CommonPacket.Marshaler.Read(__msg, out oldFameInfo);
            FameResultInfo newFameInfo;
            CommonPacket.Marshaler.Read(__msg, out newFameInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Stage_Fame_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Stage_Fame_ClearOK(remote, rmiContext, stageClearResultInfo, finalBossStageResult, oldFameInfo, newFameInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Stage_Fame_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_ClearOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int fameID;
            CommonPacket.Marshaler.Read(__msg, out fameID);
            FameResultInfo userFameInfo;
            CommonPacket.Marshaler.Read(__msg, out userFameInfo);
            List<FinalBossFameRankingInfo> finalBossFameRankingInfoList;
            CommonPacket.Marshaler.Read(__msg, out finalBossFameRankingInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK(remote, rmiContext, fameID, userFameInfo, finalBossFameRankingInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int fameID;
            CommonPacket.Marshaler.Read(__msg, out fameID);
            FameResultInfo nowFameResultInfo;
            CommonPacket.Marshaler.Read(__msg, out nowFameResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK(remote, rmiContext, fameID, nowFameResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK,
                    rmiName = RmiName_CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_Stage_StartOK(remote, rmiContext, startResultInfo, userPlayCountEventInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            GuildRewardResult guildBossClearRewardResult;
            CommonPacket.Marshaler.Read(__msg, out guildBossClearRewardResult);
            short currentGuildBossSeq;
            CommonPacket.Marshaler.Read(__msg, out currentGuildBossSeq);
            List<int> clearGuildBossMissionIDList;
            CommonPacket.Marshaler.Read(__msg, out clearGuildBossMissionIDList);
            GuildBossRankPoint updateGuildBossRankPoint;
            CommonPacket.Marshaler.Read(__msg, out updateGuildBossRankPoint);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, guildBossClearRewardResult, currentGuildBossSeq, clearGuildBossMissionIDList, updateGuildBossRankPoint))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_Lobby_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendGuildBossLobbyInfo clientSendGuildBossLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out clientSendGuildBossLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_Lobby_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Lobby_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Lobby_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_Lobby_InfoOK(remote, rmiContext, clientSendGuildBossLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_Lobby_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Lobby_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Lobby_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_Rank_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendGuildBossLobbyInfo clientSendGuildBossLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out clientSendGuildBossLobbyInfo);
            List<ClientSendGuildRankInfo> clientSendGuildRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out clientSendGuildRankInfoList);
            List<GuildWarSelectionInfo> guildWarSelectionInfoList;
            CommonPacket.Marshaler.Read(__msg, out guildWarSelectionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_Rank_InfoOK(remote, rmiContext, clientSendGuildBossLobbyInfo, clientSendGuildRankInfoList, guildWarSelectionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_LastWeek_Rank_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GuildRankRedisInfo guildRankInfo;
            CommonPacket.Marshaler.Read(__msg, out guildRankInfo);
            List<ClientSendGuildRankInfo> clientSendGuildRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out clientSendGuildRankInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_LastWeek_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_LastWeek_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_LastWeek_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_LastWeek_Rank_InfoOK(remote, rmiContext, guildRankInfo, clientSendGuildRankInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_LastWeek_Rank_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_LastWeek_Rank_InfoOK,
                    rmiName = RmiName_CG_Request_GuildBoss_LastWeek_Rank_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_Time_RefreshOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int guildRankStartRemainSec;
            CommonPacket.Marshaler.Read(__msg, out guildRankStartRemainSec);
            int guildRankEndRemainSec;
            CommonPacket.Marshaler.Read(__msg, out guildRankEndRemainSec);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_Time_RefreshOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Time_RefreshOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Time_RefreshOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_Time_RefreshOK(remote, rmiContext, guildRankStartRemainSec, guildRankEndRemainSec))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_Time_RefreshOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Time_RefreshOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Time_RefreshOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DisasterBoss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DisasterBoss_Stage_StartOK(remote, rmiContext, startResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DisasterBoss_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_StartOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            bool isDestroyDiscovered;
            CommonPacket.Marshaler.Read(__msg, out isDestroyDiscovered);
            DestroyDisasterDicoverInfo disasterDiscoverInfo;
            CommonPacket.Marshaler.Read(__msg, out disasterDiscoverInfo);
            bool isFirstClear;
            CommonPacket.Marshaler.Read(__msg, out isFirstClear);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DisasterBoss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DisasterBoss_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, isDestroyDiscovered, disasterDiscoverInfo, isFirstClear))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DisasterBoss_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DisasterBoss_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DisasterBoss_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DisasterBoss_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DisasterBoss_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DisasterBoss_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_DisasterBoss_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_EventStage_StartOK(remote, rmiContext, startResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventWeekStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventWeekStageClearResultInfo);
            UserWeeklyStageEventInfo userWeekStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeekStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_EventStage_ClearOK(remote, rmiContext, eventWeekStageClearResultInfo, userWeekStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Week_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Week_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Week_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Week_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Week_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Week_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Tower_Stage_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TowerStageInfo towerInfo;
            CommonPacket.Marshaler.Read(__msg, out towerInfo);
            TowerStageHeroInfo towerStageHeroInfo;
            CommonPacket.Marshaler.Read(__msg, out towerStageHeroInfo);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Tower_Stage_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_InfoOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Tower_Stage_InfoOK(remote, rmiContext, towerInfo, towerStageHeroInfo, userTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Tower_Stage_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_InfoOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Tower_Stage_Set_Play_DeckOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TowerStageHeroInfo towerStageHeroInfo;
            CommonPacket.Marshaler.Read(__msg, out towerStageHeroInfo);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Tower_Stage_Set_Play_DeckOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_Set_Play_DeckOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_Set_Play_DeckOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Tower_Stage_Set_Play_DeckOK(remote, rmiContext, towerStageHeroInfo, userTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Tower_Stage_Set_Play_DeckOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_Set_Play_DeckOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_Set_Play_DeckOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Tower_Stage_ResetOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TowerStageInfo towerInfo;
            CommonPacket.Marshaler.Read(__msg, out towerInfo);
            TowerStageHeroInfo towerStageHeroInfo;
            CommonPacket.Marshaler.Read(__msg, out towerStageHeroInfo);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Tower_Stage_ResetOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_ResetOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_ResetOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Tower_Stage_ResetOK(remote, rmiContext, towerInfo, towerStageHeroInfo, userTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Tower_Stage_ResetOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_ResetOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_ResetOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Tower_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Tower_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Tower_Stage_StartOK(remote, rmiContext, startResultInfo, userPlayCountEventInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Tower_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Tower_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            int clearStageID;
            CommonPacket.Marshaler.Read(__msg, out clearStageID);
            int recvReardStageID;
            CommonPacket.Marshaler.Read(__msg, out recvReardStageID);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Tower_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Tower_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, clearStageID, recvReardStageID))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Tower_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Tower_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Tower_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Lobby_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            ClientSendBlitzStageEventInfo userBlitzStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBlitzStageEventInfo);
            string rejoinData;
            CommonPacket.Marshaler.Read(__msg, out rejoinData);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Lobby_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Lobby_InfoOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Lobby_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Lobby_InfoOK(remote, rmiContext, eventSEQ, userBlitzStageEventInfo, rejoinData))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Lobby_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Lobby_InfoOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Lobby_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Squad_ChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            BlitzSquadInfo blitzSquadInfo;
            CommonPacket.Marshaler.Read(__msg, out blitzSquadInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Squad_ChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Squad_ChangeOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Squad_ChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Squad_ChangeOK(remote, rmiContext, eventSEQ, blitzSquadInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Squad_ChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Squad_ChangeOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Squad_ChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Squad_InitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            BlitzSquadInfo blitzSquadInfo;
            CommonPacket.Marshaler.Read(__msg, out blitzSquadInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Squad_InitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Squad_InitOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Squad_InitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Squad_InitOK(remote, rmiContext, eventSEQ, blitzSquadInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Squad_InitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Squad_InitOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Squad_InitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Team_ChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Team_ChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Team_ChangeOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Team_ChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Team_ChangeOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Team_ChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Team_ChangeOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Team_ChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Main_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Main_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Main_StartOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Main_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Main_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Main_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Main_StartOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Main_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Main_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            ClientSendBlitzStageEventInfo userBlitzStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBlitzStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Main_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Main_ClearOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Main_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Main_ClearOK(remote, rmiContext, stageClearResultInfo, eventSEQ, userBlitzStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Main_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Main_ClearOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Main_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Free_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Free_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Free_StartOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Free_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Free_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Free_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Free_StartOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Free_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Free_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            ClientSendBlitzStageEventInfo userBlitzStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBlitzStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Free_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Free_ClearOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Free_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Free_ClearOK(remote, rmiContext, stageClearResultInfo, eventSEQ, userBlitzStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Free_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Free_ClearOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Free_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Reward_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            ClientSendBlitzStageEventInfo userBlitzStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBlitzStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Reward_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Reward_ClearOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Reward_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Reward_ClearOK(remote, rmiContext, stageClearResultInfo, eventSEQ, userBlitzStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Reward_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Reward_ClearOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Reward_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_RejoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_RejoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_RejoinOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_RejoinOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_RejoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_RejoinOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Blitz_EventStage_Rejoin_CancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            ClientSendBlitzStageEventInfo userBlitzStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBlitzStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Blitz_EventStage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Blitz_EventStage_Rejoin_CancelOK(remote, rmiContext, eventSEQ, userBlitzStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Blitz_EventStage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Blitz_EventStage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_Blitz_EventStage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_Once_EventAreaStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo eventAreaFreeOnceStageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventAreaFreeOnceStageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_Once_EventAreaStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Once_EventAreaStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_Once_EventAreaStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_Once_EventAreaStage_StartOK(remote, rmiContext, eventAreaFreeOnceStageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_Once_EventAreaStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Once_EventAreaStage_StartOK,
                    rmiName = RmiName_CG_Request_Free_Once_EventAreaStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_Once_EventAreaStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo eventAreaFreeOnceStageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out eventAreaFreeOnceStageClearResultInfo);
            UserWorldAreaStageEventInfo userWorldAreaStageEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userWorldAreaStageEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_Once_EventAreaStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Once_EventAreaStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_Once_EventAreaStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_Once_EventAreaStage_ClearOK(remote, rmiContext, eventAreaFreeOnceStageClearResultInfo, userWorldAreaStageEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_Once_EventAreaStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Once_EventAreaStage_ClearOK,
                    rmiName = RmiName_CG_Request_Free_Once_EventAreaStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Free_Once_EventAreaStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Free_Once_EventAreaStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Once_EventAreaStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_Once_EventAreaStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Free_Once_EventAreaStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Free_Once_EventAreaStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Free_Once_EventAreaStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Free_Once_EventAreaStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_NorthMain_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_NorthMain_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_NorthMain_Stage_StartOK,
                    rmiName = RmiName_CG_Request_NorthMain_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_NorthMain_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_NorthMain_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_NorthMain_Stage_StartOK,
                    rmiName = RmiName_CG_Request_NorthMain_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_NorthMain_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_NorthMain_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_NorthMain_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_NorthMain_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_NorthMain_Stage_ClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_NorthMain_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_NorthMain_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_NorthMain_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_NorthMain_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_NorthMain_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_NorthMain_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_NorthMain_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_NorthMain_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_NorthMain_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_NorthMain_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_NorthMain_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_North_Free_Once_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_North_Free_Once_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_North_Free_Once_Stage_StartOK,
                    rmiName = RmiName_CG_Request_North_Free_Once_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_North_Free_Once_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_North_Free_Once_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_North_Free_Once_Stage_StartOK,
                    rmiName = RmiName_CG_Request_North_Free_Once_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_North_Free_Once_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_North_Free_Once_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_North_Free_Once_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_North_Free_Once_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_North_Free_Once_Stage_ClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_North_Free_Once_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_North_Free_Once_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_North_Free_Once_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_North_Free_Once_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_North_Free_Once_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_North_Free_Once_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_North_Free_Once_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_North_Free_Once_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_North_Free_Once_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_North_Free_Once_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_North_Free_Once_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Another_Free_Once_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Another_Free_Once_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Another_Free_Once_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Another_Free_Once_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Another_Free_Once_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Another_Free_Once_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Another_Free_Once_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Another_Free_Once_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Another_Free_Once_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Another_Free_Once_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Another_Free_Once_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Another_Free_Once_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Another_Free_Once_Stage_ClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Another_Free_Once_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Another_Free_Once_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Another_Free_Once_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Another_Free_Once_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Another_Free_Once_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Another_Free_Once_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Another_Free_Once_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Another_Free_Once_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Another_Free_Once_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Another_Free_Once_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Another_Free_Once_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TowerStageInfo towerInfo;
            CommonPacket.Marshaler.Read(__msg, out towerInfo);
            TowerStageHeroInfo towerStageHeroInfo;
            CommonPacket.Marshaler.Read(__msg, out towerStageHeroInfo);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Tower_Stage_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_InfoOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Tower_Stage_InfoOK(remote, rmiContext, towerInfo, towerStageHeroInfo, userTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Tower_Stage_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_InfoOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TowerStageHeroInfo towerStageHeroInfo;
            CommonPacket.Marshaler.Read(__msg, out towerStageHeroInfo);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK(remote, rmiContext, towerStageHeroInfo, userTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_ResetOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            TowerStageInfo towerInfo;
            CommonPacket.Marshaler.Read(__msg, out towerInfo);
            TowerStageHeroInfo towerStageHeroInfo;
            CommonPacket.Marshaler.Read(__msg, out towerStageHeroInfo);
            UserTeam userTeam;
            CommonPacket.Marshaler.Read(__msg, out userTeam);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Tower_Stage_ResetOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_ResetOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_ResetOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Tower_Stage_ResetOK(remote, rmiContext, towerInfo, towerStageHeroInfo, userTeam))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Tower_Stage_ResetOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_ResetOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_ResetOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Tower_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Tower_Stage_StartOK(remote, rmiContext, startResultInfo, userPlayCountEventInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Tower_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Tower_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            int clearStageID;
            CommonPacket.Marshaler.Read(__msg, out clearStageID);
            int recvReardStageID;
            CommonPacket.Marshaler.Read(__msg, out recvReardStageID);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Tower_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Tower_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, clearStageID, recvReardStageID))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Tower_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Tower_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Disaster_Tower_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_Off_Season_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_Off_Season_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Off_Season_Stage_StartOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Off_Season_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_Off_Season_Stage_StartOK(remote, rmiContext, startResultInfo, userPlayCountEventInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_Off_Season_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Off_Season_Stage_StartOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Off_Season_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_GuildBoss_Off_Season_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            GuildRewardResult guildBossClearRewardResult;
            CommonPacket.Marshaler.Read(__msg, out guildBossClearRewardResult);
            short currentGuildBossSeq;
            CommonPacket.Marshaler.Read(__msg, out currentGuildBossSeq);
            List<int> clearGuildBossMissionIDList;
            CommonPacket.Marshaler.Read(__msg, out clearGuildBossMissionIDList);
            GuildBossOffSeasonRankPoint updateGuildBossOffSeasonRankPoint;
            CommonPacket.Marshaler.Read(__msg, out updateGuildBossOffSeasonRankPoint);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_GuildBoss_Off_Season_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Off_Season_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Off_Season_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_GuildBoss_Off_Season_Stage_ClearOK(remote, rmiContext, stageClearResultInfo, guildBossClearRewardResult, currentGuildBossSeq, clearGuildBossMissionIDList, updateGuildBossOffSeasonRankPoint))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_GuildBoss_Off_Season_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_GuildBoss_Off_Season_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_GuildBoss_Off_Season_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestFinalBossVowUpdateOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int stageId;
            CommonPacket.Marshaler.Read(__msg, out stageId);
            List<int> vowIdList;
            CommonPacket.Marshaler.Read(__msg, out vowIdList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestFinalBossVowUpdateOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestFinalBossVowUpdateOK,
                    rmiName = RmiName_CG_RequestFinalBossVowUpdateOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestFinalBossVowUpdateOK(remote, rmiContext, stageId, vowIdList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestFinalBossVowUpdateOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestFinalBossVowUpdateOK,
                    rmiName = RmiName_CG_RequestFinalBossVowUpdateOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DescentBoss_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DescentBoss_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_DescentBoss_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DescentBoss_EventStage_StartOK(remote, rmiContext, stageStartResultInfo, userPlayCountEventInfoList, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DescentBoss_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_DescentBoss_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DescentBoss_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            EventDescentBossEventStageClearResultInfo resultInfo;
            CommonPacket.Marshaler.Read(__msg, out resultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DescentBoss_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_DescentBoss_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DescentBoss_EventStage_ClearOK(remote, rmiContext, stageClearResultInfo, resultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DescentBoss_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_DescentBoss_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DescentBoss_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DescentBoss_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_DescentBoss_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DescentBoss_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DescentBoss_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_DescentBoss_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_DescentBoss_Event_Point_RewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            DescentBossEventInfoToClientSend info;
            CommonPacket.Marshaler.Read(__msg, out info);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            PaybackEventResultInfo m_paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out m_paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_DescentBoss_Event_Point_RewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_Event_Point_RewardOK,
                    rmiName = RmiName_CG_Request_DescentBoss_Event_Point_RewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_DescentBoss_Event_Point_RewardOK(remote, rmiContext, info, getItemResultInfoList, m_paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_DescentBoss_Event_Point_RewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_DescentBoss_Event_Point_RewardOK,
                    rmiName = RmiName_CG_Request_DescentBoss_Event_Point_RewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeekStageCoinOpenOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int areaID;
            CommonPacket.Marshaler.Read(__msg, out areaID);
            int remainKeyOpenTimeSec;
            CommonPacket.Marshaler.Read(__msg, out remainKeyOpenTimeSec);
            int remainWeekResetTimeSec;
            CommonPacket.Marshaler.Read(__msg, out remainWeekResetTimeSec);
            int coinDungeonWeekOpenCount;
            CommonPacket.Marshaler.Read(__msg, out coinDungeonWeekOpenCount);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeekStageCoinOpenOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageCoinOpenOK,
                    rmiName = RmiName_CG_RequestWeekStageCoinOpenOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeekStageCoinOpenOK(remote, rmiContext, areaID, remainKeyOpenTimeSec, remainWeekResetTimeSec, coinDungeonWeekOpenCount, useItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeekStageCoinOpenOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageCoinOpenOK,
                    rmiName = RmiName_CG_RequestWeekStageCoinOpenOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestYggdrasilTowerStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            YggdrasilTowerStageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestYggdrasilTowerStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerStageStartOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestYggdrasilTowerStageStartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestYggdrasilTowerStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerStageStartOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestYggdrasilTowerStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            YggdrasilTowerStageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            List<int> clearMissionIDList;
            CommonPacket.Marshaler.Read(__msg, out clearMissionIDList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestYggdrasilTowerStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerStageClearOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestYggdrasilTowerStageClearOK(remote, rmiContext, stageClearResultInfo, clearMissionIDList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestYggdrasilTowerStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerStageClearOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Yggdrasil_Tower_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Yggdrasil_Tower_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Yggdrasil_Tower_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Yggdrasil_Tower_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Yggdrasil_Tower_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Yggdrasil_Tower_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Yggdrasil_Tower_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Yggdrasil_Tower_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Season_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int selectedGroupID;
            CommonPacket.Marshaler.Read(__msg, out selectedGroupID);
            List<ClientSendCreatureNestStageInfo> ClientSendCreatureNestStageInfoList;
            CommonPacket.Marshaler.Read(__msg, out ClientSendCreatureNestStageInfoList);
            int remainWeekResetSec;
            CommonPacket.Marshaler.Read(__msg, out remainWeekResetSec);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Season_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Season_InfoOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Season_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Season_InfoOK(remote, rmiContext, selectedGroupID, ClientSendCreatureNestStageInfoList, remainWeekResetSec))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Season_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Season_InfoOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Season_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            CreatureNestStageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_StartOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Stage_StartOK(remote, rmiContext, startResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_StartOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            CreatureNestStageClearResultInfo clearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out clearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Stage_ClearOK(remote, rmiContext, clearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_InitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo clientCreatureNestInfo;
            CommonPacket.Marshaler.Read(__msg, out clientCreatureNestInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_InitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_InitOK,
                    rmiName = RmiName_CG_Request_CreatureNest_InitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_InitOK(remote, rmiContext, clientCreatureNestInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_InitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_InitOK,
                    rmiName = RmiName_CG_Request_CreatureNest_InitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Team_SaveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo clientCreatureNestInfo;
            CommonPacket.Marshaler.Read(__msg, out clientCreatureNestInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Team_SaveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Team_SaveOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Team_SaveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Team_SaveOK(remote, rmiContext, clientCreatureNestInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Team_SaveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Team_SaveOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Team_SaveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Stage_RejoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo;
            CommonPacket.Marshaler.Read(__msg, out ClientSendCreatureNestStageInfo);
            List<CreatureNestStagePassiveInfo> activePassiveSkillInfoList;
            CommonPacket.Marshaler.Read(__msg, out activePassiveSkillInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Stage_RejoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_RejoinOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Stage_RejoinOK(remote, rmiContext, ClientSendCreatureNestStageInfo, activePassiveSkillInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Stage_RejoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_RejoinOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Stage_Rejoin_CancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo;
            CommonPacket.Marshaler.Read(__msg, out ClientSendCreatureNestStageInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Stage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Stage_Rejoin_CancelOK(remote, rmiContext, ClientSendCreatureNestStageInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Stage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Stage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Stage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Use_Reset_ItemOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ItemResultInfo needItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out needItemResultInfo);
            int selectedGroupID;
            CommonPacket.Marshaler.Read(__msg, out selectedGroupID);
            ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo;
            CommonPacket.Marshaler.Read(__msg, out ClientSendCreatureNestStageInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Use_Reset_ItemOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Use_Reset_ItemOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Use_Reset_ItemOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Use_Reset_ItemOK(remote, rmiContext, needItemResultInfo, selectedGroupID, ClientSendCreatureNestStageInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Use_Reset_ItemOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Use_Reset_ItemOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Use_Reset_ItemOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Challenge_RewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            ItemResultInfo rewardItemInfo;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Challenge_RewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Challenge_RewardOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Challenge_RewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Challenge_RewardOK(remote, rmiContext, groupID, rewardItemInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Challenge_RewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Challenge_RewardOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Challenge_RewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureNest_Select_GroupOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int groupId;
            CommonPacket.Marshaler.Read(__msg, out groupId);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureNest_Select_GroupOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Select_GroupOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Select_GroupOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureNest_Select_GroupOK(remote, rmiContext, groupId))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureNest_Select_GroupOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureNest_Select_GroupOK,
                    rmiName = RmiName_CG_Request_CreatureNest_Select_GroupOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestMercenaryListOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<MercenaryInfo> mercenaryInfoList;
            CommonPacket.Marshaler.Read(__msg, out mercenaryInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestMercenaryListOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestMercenaryListOK,
                    rmiName = RmiName_CG_RequestMercenaryListOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestMercenaryListOK(remote, rmiContext, mercenaryInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestMercenaryListOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestMercenaryListOK,
                    rmiName = RmiName_CG_RequestMercenaryListOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestMercenaryInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            MercenaryDetailInfo mercenaryDetailInfo;
            CommonPacket.Marshaler.Read(__msg, out mercenaryDetailInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestMercenaryInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestMercenaryInfoOK,
                    rmiName = RmiName_CG_RequestMercenaryInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestMercenaryInfoOK(remote, rmiContext, mercenaryDetailInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestMercenaryInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestMercenaryInfoOK,
                    rmiName = RmiName_CG_RequestMercenaryInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeekStageKeyOpenOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int areaID;
            CommonPacket.Marshaler.Read(__msg, out areaID);
            int remainKeyOpenTimeSec;
            CommonPacket.Marshaler.Read(__msg, out remainKeyOpenTimeSec);
            ItemResultInfo useItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeekStageKeyOpenOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageKeyOpenOK,
                    rmiName = RmiName_CG_RequestWeekStageKeyOpenOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeekStageKeyOpenOK(remote, rmiContext, areaID, remainKeyOpenTimeSec, useItemResultInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeekStageKeyOpenOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageKeyOpenOK,
                    rmiName = RmiName_CG_RequestWeekStageKeyOpenOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaInfoOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaInfoOK(remote, rmiContext, userKOFBritanniaEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaInfoOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStartOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaStartOK(remote, rmiContext, userKOFBritanniaEventInfo, useItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStartOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaTeamSelectOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaTeamSelectOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaTeamSelectOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaTeamSelectOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaTeamSelectOK(remote, rmiContext, userKOFBritanniaEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaTeamSelectOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaTeamSelectOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaTeamSelectOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaTeamChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            UserTeamChangeInfo userTeamChangeInfo;
            CommonPacket.Marshaler.Read(__msg, out userTeamChangeInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaTeamChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaTeamChangeOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaTeamChangeOK(remote, rmiContext, userKOFBritanniaEventInfo, userTeamChangeInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaTeamChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaTeamChangeOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaTeamChangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            ItemResultInfo useItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageStartOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaStageStartOK(remote, rmiContext, stageStartResultInfo, paybackEventresultInfo, userKOFBritanniaEventInfo, useItemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageStartOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            KOFBritanniaStageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageClearOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaStageClearOK(remote, rmiContext, stageClearResultInfo, userKOFBritanniaEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageClearOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaStageContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageContinueOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaStageContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaStageContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageContinueOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaRestartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaRestartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaRestartOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaRestartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaRestartOK(remote, rmiContext, userKOFBritanniaEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaRestartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaRestartOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaRestartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventKOFBritanniaStageRejoinCancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserKOFBritanniaEventInfo userKOFBritanniaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userKOFBritanniaEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventKOFBritanniaStageRejoinCancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageRejoinCancelOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageRejoinCancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventKOFBritanniaStageRejoinCancelOK(remote, rmiContext, userKOFBritanniaEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventKOFBritanniaStageRejoinCancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventKOFBritanniaStageRejoinCancelOK,
                    rmiName = RmiName_CG_RequestEventKOFBritanniaStageRejoinCancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserAncientWarInfo userAnceintWarInfo;
            CommonPacket.Marshaler.Read(__msg, out userAnceintWarInfo);
            AncientWarInfo ancientWarInfo;
            CommonPacket.Marshaler.Read(__msg, out ancientWarInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarInfoOK,
                    rmiName = RmiName_CG_RequestAncientWarInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarInfoOK(remote, rmiContext, userAnceintWarInfo, ancientWarInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarInfoOK,
                    rmiName = RmiName_CG_RequestAncientWarInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarRefreshOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            AncientWarInfo ancientWarInfo;
            CommonPacket.Marshaler.Read(__msg, out ancientWarInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarRefreshOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarRefreshOK,
                    rmiName = RmiName_CG_RequestAncientWarRefreshOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarRefreshOK(remote, rmiContext, ancientWarInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarRefreshOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarRefreshOK,
                    rmiName = RmiName_CG_RequestAncientWarRefreshOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarTeamSelectOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserAncientWarInfo userAncientWarInfo;
            CommonPacket.Marshaler.Read(__msg, out userAncientWarInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarTeamSelectOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarTeamSelectOK,
                    rmiName = RmiName_CG_RequestAncientWarTeamSelectOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarTeamSelectOK(remote, rmiContext, userAncientWarInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarTeamSelectOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarTeamSelectOK,
                    rmiName = RmiName_CG_RequestAncientWarTeamSelectOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            AncientWarStageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarStageStartOK,
                    rmiName = RmiName_CG_RequestAncientWarStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarStageStartOK(remote, rmiContext, stageStartResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarStageStartOK,
                    rmiName = RmiName_CG_RequestAncientWarStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            AncientWarStageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarStageClearOK,
                    rmiName = RmiName_CG_RequestAncientWarStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarStageClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarStageClearOK,
                    rmiName = RmiName_CG_RequestAncientWarStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarExtraStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            AncientWarExtraStageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarExtraStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarExtraStageStartOK,
                    rmiName = RmiName_CG_RequestAncientWarExtraStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarExtraStageStartOK(remote, rmiContext, stageStartResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarExtraStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarExtraStageStartOK,
                    rmiName = RmiName_CG_RequestAncientWarExtraStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarExtraStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            AncientWarExtraStageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarExtraStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarExtraStageClearOK,
                    rmiName = RmiName_CG_RequestAncientWarExtraStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarExtraStageClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarExtraStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarExtraStageClearOK,
                    rmiName = RmiName_CG_RequestAncientWarExtraStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte rewardIndex;
            CommonPacket.Marshaler.Read(__msg, out rewardIndex);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarRewardOK,
                    rmiName = RmiName_CG_RequestAncientWarRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarRewardOK(remote, rmiContext, rewardIndex, getItemResultInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarRewardOK,
                    rmiName = RmiName_CG_RequestAncientWarRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarDonationOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ItemResultInfo useItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfo);
            UserAncientWarInfo userAnceintWarInfo;
            CommonPacket.Marshaler.Read(__msg, out userAnceintWarInfo);
            AncientWarInfo ancientWarInfo;
            CommonPacket.Marshaler.Read(__msg, out ancientWarInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarDonationOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarDonationOK,
                    rmiName = RmiName_CG_RequestAncientWarDonationOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarDonationOK(remote, rmiContext, useItemResultInfo, userAnceintWarInfo, ancientWarInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarDonationOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarDonationOK,
                    rmiName = RmiName_CG_RequestAncientWarDonationOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestAncientWarRankInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<AncientWarUserRankInfo> ancientWarUserRankInfoList;
            CommonPacket.Marshaler.Read(__msg, out ancientWarUserRankInfoList);
            RedisAncientWarUserRankInfo userAncientWarRankInfo;
            CommonPacket.Marshaler.Read(__msg, out userAncientWarRankInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestAncientWarRankInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarRankInfoOK,
                    rmiName = RmiName_CG_RequestAncientWarRankInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestAncientWarRankInfoOK(remote, rmiContext, ancientWarUserRankInfoList, userAncientWarRankInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestAncientWarRankInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestAncientWarRankInfoOK,
                    rmiName = RmiName_CG_RequestAncientWarRankInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            UserMazeEventInfo userMazeEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userMazeEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageStartOK,
                    rmiName = RmiName_CG_RequestEventMazeStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeStageStartOK(remote, rmiContext, stageStartResultInfo, userMazeEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageStartOK,
                    rmiName = RmiName_CG_RequestEventMazeStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            UserMazeEventInfo userMazeEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userMazeEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageClearOK,
                    rmiName = RmiName_CG_RequestEventMazeStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeStageClearOK(remote, rmiContext, stageClearResultInfo, userMazeEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageClearOK,
                    rmiName = RmiName_CG_RequestEventMazeStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeStageRejoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserMazeEventInfo userMazeEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userMazeEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeStageRejoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageRejoinOK,
                    rmiName = RmiName_CG_RequestEventMazeStageRejoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeStageRejoinOK(remote, rmiContext, userMazeEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeStageRejoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageRejoinOK,
                    rmiName = RmiName_CG_RequestEventMazeStageRejoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeStageRejoinCancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserMazeEventInfo userMazeEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userMazeEventInfo);
            ItemResultInfo useItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeStageRejoinCancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageRejoinCancelOK,
                    rmiName = RmiName_CG_RequestEventMazeStageRejoinCancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeStageRejoinCancelOK(remote, rmiContext, userMazeEventInfo, useItemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeStageRejoinCancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageRejoinCancelOK,
                    rmiName = RmiName_CG_RequestEventMazeStageRejoinCancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeStageReChallengeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            UserMazeEventInfo userMazeEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userMazeEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeStageReChallengeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageReChallengeOK,
                    rmiName = RmiName_CG_RequestEventMazeStageReChallengeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeStageReChallengeOK(remote, rmiContext, stageStartResultInfo, userMazeEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeStageReChallengeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageReChallengeOK,
                    rmiName = RmiName_CG_RequestEventMazeStageReChallengeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeStageReChallengeCancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserMazeEventInfo userMazeEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userMazeEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeStageReChallengeCancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageReChallengeCancelOK,
                    rmiName = RmiName_CG_RequestEventMazeStageReChallengeCancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeStageReChallengeCancelOK(remote, rmiContext, userMazeEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeStageReChallengeCancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeStageReChallengeCancelOK,
                    rmiName = RmiName_CG_RequestEventMazeStageReChallengeCancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Conquest_EventStage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Conquest_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Conquest_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Conquest_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Conquest_EventStage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Conquest_EventStage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Conquest_EventStage_StartOK,
                    rmiName = RmiName_CG_Request_Conquest_EventStage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Conquest_EventStage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            UserEventConquesClientSendInfo userEventConquestClientSendInfo;
            CommonPacket.Marshaler.Read(__msg, out userEventConquestClientSendInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Conquest_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Conquest_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Conquest_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Conquest_EventStage_ClearOK(remote, rmiContext, stageClearResultInfo, userEventConquestClientSendInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Conquest_EventStage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Conquest_EventStage_ClearOK,
                    rmiName = RmiName_CG_Request_Conquest_EventStage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Conquest_EventStage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Conquest_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Conquest_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Conquest_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Conquest_EventStage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Conquest_EventStage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Conquest_EventStage_ContinueOK,
                    rmiName = RmiName_CG_Request_Conquest_EventStage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Main_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Main_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Main_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Disaster_Main_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Main_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Main_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Main_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Disaster_Main_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Main_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Main_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Main_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Disaster_Main_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Main_Stage_ClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Main_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Main_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Disaster_Main_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Main_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Main_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Main_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Disaster_Main_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Main_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Main_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Main_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Disaster_Main_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Free_Once_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Free_Once_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Free_Once_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Disaster_Free_Once_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Free_Once_Stage_StartOK(remote, rmiContext, stageStartResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Free_Once_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Free_Once_Stage_StartOK,
                    rmiName = RmiName_CG_Request_Disaster_Free_Once_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Free_Once_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Free_Once_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Free_Once_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Disaster_Free_Once_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Free_Once_Stage_ClearOK(remote, rmiContext, stageClearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Free_Once_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Free_Once_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_Disaster_Free_Once_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_Disaster_Free_Once_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_Disaster_Free_Once_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Free_Once_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Disaster_Free_Once_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_Disaster_Free_Once_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_Disaster_Free_Once_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_Disaster_Free_Once_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_Disaster_Free_Once_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_Season_InfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ClientSendCreatureNestStageInfo> ClientSendCreatureNestStageInfoList;
            CommonPacket.Marshaler.Read(__msg, out ClientSendCreatureNestStageInfoList);
            CreatureNestColosseumSeasonInfo seasonInfo;
            CommonPacket.Marshaler.Read(__msg, out seasonInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_Season_InfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Season_InfoOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Season_InfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_Season_InfoOK(remote, rmiContext, ClientSendCreatureNestStageInfoList, seasonInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_Season_InfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Season_InfoOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Season_InfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_StartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            CreatureNestStageStartResultInfo startResultInfo;
            CommonPacket.Marshaler.Read(__msg, out startResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_StartOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_Stage_StartOK(remote, rmiContext, startResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_Stage_StartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_StartOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_StartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_ClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            CreatureNestStageClearResultInfo clearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out clearResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_Stage_ClearOK(remote, rmiContext, clearResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_Stage_ClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_ClearOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_ClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_ContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_Stage_ContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_Stage_ContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_ContinueOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_ContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_InitOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo clientCreatureNestInfo;
            CommonPacket.Marshaler.Read(__msg, out clientCreatureNestInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_InitOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_InitOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_InitOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_InitOK(remote, rmiContext, clientCreatureNestInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_InitOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_InitOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_InitOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_Team_SaveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo clientCreatureNestInfo;
            CommonPacket.Marshaler.Read(__msg, out clientCreatureNestInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_Team_SaveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Team_SaveOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Team_SaveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_Team_SaveOK(remote, rmiContext, clientCreatureNestInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_Team_SaveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Team_SaveOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Team_SaveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_RejoinOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo;
            CommonPacket.Marshaler.Read(__msg, out ClientSendCreatureNestStageInfo);
            List<CreatureNestStagePassiveInfo> activePassiveSkillInfoList;
            CommonPacket.Marshaler.Read(__msg, out activePassiveSkillInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_Stage_RejoinOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_RejoinOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_Stage_RejoinOK(remote, rmiContext, ClientSendCreatureNestStageInfo, activePassiveSkillInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_Stage_RejoinOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_RejoinOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_RejoinOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo;
            CommonPacket.Marshaler.Read(__msg, out ClientSendCreatureNestStageInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK(remote, rmiContext, ClientSendCreatureNestStageInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK,
                    rmiName = RmiName_CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDemonLordStageOpenOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserDemonLordInfoToClientSend userDemonLordInfo;
            CommonPacket.Marshaler.Read(__msg, out userDemonLordInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDemonLordStageOpenOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageOpenOK,
                    rmiName = RmiName_CG_RequestDemonLordStageOpenOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDemonLordStageOpenOK(remote, rmiContext, userDemonLordInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDemonLordStageOpenOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageOpenOK,
                    rmiName = RmiName_CG_RequestDemonLordStageOpenOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDemonLordStageStartOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageStartResultInfo stageStartResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageStartResultInfo);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDemonLordStageStartOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageStartOK,
                    rmiName = RmiName_CG_RequestDemonLordStageStartOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDemonLordStageStartOK(remote, rmiContext, stageStartResultInfo, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDemonLordStageStartOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageStartOK,
                    rmiName = RmiName_CG_RequestDemonLordStageStartOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDemonLordStageClearOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            StageClearResultInfo stageClearResultInfo;
            CommonPacket.Marshaler.Read(__msg, out stageClearResultInfo);
            UserDemonLordInfoToClientSend userDemonLordInfo;
            CommonPacket.Marshaler.Read(__msg, out userDemonLordInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDemonLordStageClearOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageClearOK,
                    rmiName = RmiName_CG_RequestDemonLordStageClearOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDemonLordStageClearOK(remote, rmiContext, stageClearResultInfo, userDemonLordInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDemonLordStageClearOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageClearOK,
                    rmiName = RmiName_CG_RequestDemonLordStageClearOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDemonLordStageContinueOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            short continueCount;
            CommonPacket.Marshaler.Read(__msg, out continueCount);
            PaybackEventResultInfo paybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDemonLordStageContinueOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageContinueOK,
                    rmiName = RmiName_CG_RequestDemonLordStageContinueOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDemonLordStageContinueOK(remote, rmiContext, useItemResultInfoList, continueCount, paybackEventResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDemonLordStageContinueOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageContinueOK,
                    rmiName = RmiName_CG_RequestDemonLordStageContinueOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDemonLordStageCoinOpenOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            UserDemonLordInfoToClientSend userDemonLordInfo;
            CommonPacket.Marshaler.Read(__msg, out userDemonLordInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDemonLordStageCoinOpenOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageCoinOpenOK,
                    rmiName = RmiName_CG_RequestDemonLordStageCoinOpenOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDemonLordStageCoinOpenOK(remote, rmiContext, useItemResultInfoList, userDemonLordInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDemonLordStageCoinOpenOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDemonLordStageCoinOpenOK,
                    rmiName = RmiName_CG_RequestDemonLordStageCoinOpenOK,
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

        public Stub.CG_RequestStageInfoOKDelegate CG_RequestStageInfoOK = (HostID remote, RmiContext rmiContext, StageInfo stageInfo) => false;

        public Stub.CG_RequestRecommandHeroOKDelegate CG_RequestRecommandHeroOK = (HostID remote, RmiContext rmiContext, RecommandHeroRequestInfo requestInfo, RecommandHeroInfo recommandHeroInfo) => false;

        public Stub.CG_RequestIngameBattleStartOKDelegate CG_RequestIngameBattleStartOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_RequestStageRejoinOKDelegate CG_RequestStageRejoinOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_Request_Main_Stage_StartOKDelegate CG_Request_Main_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Main_Stage_ClearOKDelegate CG_Request_Main_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, bool isFirstMainStageClear, List<UserPackageMissionInfo> userPackageMissionInfoList) => false;

        public Stub.CG_Request_Main_Stage_ContinueOKDelegate CG_Request_Main_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_Stage_StartOKDelegate CG_Request_Free_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo freeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_Stage_ClearOKDelegate CG_Request_Free_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo freeStageClearResultInfo) => false;

        public Stub.CG_Request_Free_Stage_ContinueOKDelegate CG_Request_Free_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestHawkRunStageStartOKDelegate CG_RequestHawkRunStageStartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo hawkRunStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestHawkRunStageClearOKDelegate CG_RequestHawkRunStageClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo runStageClearResultInfo) => false;

        public Stub.CG_RequestEventStageClearOKDelegate CG_RequestEventStageClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventStageClearResultInfo) => false;

        public Stub.CG_Request_Quest_Stage_StartOKDelegate CG_Request_Quest_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo questStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Quest_Stage_ClearOKDelegate CG_Request_Quest_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo questStageClearResultInfo) => false;

        public Stub.CG_Request_Quest_Stage_ContinueOKDelegate CG_Request_Quest_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Week_Stage_StartOKDelegate CG_Request_Week_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo weekStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo, ItemResultInfo useKeyItemResultInfo) => false;

        public Stub.CG_Request_Week_Stage_ClearOKDelegate CG_Request_Week_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo weekStageClearResultInfo, bool isFirstWeeklyStage, List<APInfo> apInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList) => false;

        public Stub.CG_Request_Week_Stage_ContinueOKDelegate CG_Request_Week_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Boss_Stage_StartOKDelegate CG_Request_Boss_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo bossStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Boss_Stage_ClearOKDelegate CG_Request_Boss_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo bossClearResultInfo, bool isDestroyDiscovered, DestroyDiscoverInfo discoverInfo, bool isFirstBoss, List<UserPackageMissionInfo> userPackageMissionInfoList) => false;

        public Stub.CG_Request_Boss_Stage_ContinueOKDelegate CG_Request_Boss_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Memorial_Stage_StartOKDelegate CG_Request_Memorial_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo memorialStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Memorial_Stage_ClearOKDelegate CG_Request_Memorial_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo memorialClearResultInfo, UserSkin userSkin) => false;

        public Stub.CG_Request_Memorial_Stage_ContinueOKDelegate CG_Request_Memorial_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Limited_Stage_StartOKDelegate CG_Request_Limited_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo limitedStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Limited_Stage_ClearOKDelegate CG_Request_Limited_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo limitedStageClearResultInfo) => false;

        public Stub.CG_Request_Limited_Stage_ContinueOKDelegate CG_Request_Limited_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Main_ExtraStage_StartOKDelegate CG_Request_Main_ExtraStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo extraMainStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Main_ExtraStage_ClearOKDelegate CG_Request_Main_ExtraStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo extraMainStageClearResultInfo) => false;

        public Stub.CG_Request_Main_ExtraStage_ContinueOKDelegate CG_Request_Main_ExtraStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Boss_ExtraStage_StartOKDelegate CG_Request_Boss_ExtraStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo extraBossStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Boss_ExtraStage_ClearOKDelegate CG_Request_Boss_ExtraStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo extraBossStageClearResultInfo) => false;

        public Stub.CG_Request_Boss_ExtraStage_ContinueOKDelegate CG_Request_Boss_ExtraStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestRewardStageClearOKDelegate CG_RequestRewardStageClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo rewardStageClearResultInfo) => false;

        public Stub.CG_Request_AnotherMain_Stage_StartOKDelegate CG_Request_AnotherMain_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_AnotherMain_Stage_ClearOKDelegate CG_Request_AnotherMain_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_Request_AnotherMain_Stage_ContinueOKDelegate CG_Request_AnotherMain_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Reverse_Stage_StartOKDelegate CG_Request_Reverse_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Reverse_Stage_ClearOKDelegate CG_Request_Reverse_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, ReverseGroupInfo userGroupInfo) => false;

        public Stub.CG_Request_Reverse_Star_RewardOKDelegate CG_Request_Reverse_Star_RewardOK = (HostID remote, RmiContext rmiContext, short seasonID, byte rewardedIndex, ItemResultInfo getItemResultInfo, MissionResult missionResult) => false;

        public Stub.CG_Request_Reverse_Group_RewardOKDelegate CG_Request_Reverse_Group_RewardOK = (HostID remote, RmiContext rmiContext, short rewardID, ItemResultInfo getItemResultInfo, MissionResult missionResult) => false;

        public Stub.CG_Request_Free_Stage_ClearTicketOKDelegate CG_Request_Free_Stage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Week_Stage_ClearTicketOKDelegate CG_Request_Week_Stage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, List<APInfo> apInfoList, UserADViewInfo adViewRouletteInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Boss_Stage_ClearTicketOKDelegate CG_Request_Boss_Stage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, bool isDestroyDiscovered, DestroyDiscoverInfo discoverInfo, PaybackEventResultInfo paybackEventResultInfo, bool isBatchPlay) => false;

        public Stub.CG_Request_Week_EventStage_ClearTicketOKDelegate CG_Request_Week_EventStage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_DisasterBoss_Stage_ClearTicketOKDelegate CG_Request_DisasterBoss_Stage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, bool isDestroyDiscovered, DestroyDisasterDicoverInfo destroyDiscoverInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Free_EventAreaStage_ClearTicketOKDelegate CG_Request_Free_EventAreaStage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Yggdrasil_Tower_Stage_ClearTicketOKDelegate CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, List<APInfo> apInfoList, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Training_Stage_ClearTicketOKDelegate CG_Request_Training_Stage_ClearTicketOK = (HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, TrainingStageSlotInfo clearStageSlotInfo, List<TrainingStageSlotInfo> openStageSlotInfoList, List<UserSkin> updateSkinList, TrainingStageInGameMissionClearInfo trainingStageIngameMissionClearInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Main_EventAreaStage_StartOKDelegate CG_Request_Main_EventAreaStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventAreaStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Main_EventAreaStage_ClearOKDelegate CG_Request_Main_EventAreaStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo) => false;

        public Stub.CG_Request_Main_EventAreaStage_ContinueOKDelegate CG_Request_Main_EventAreaStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_EventAreaStage_StartOKDelegate CG_Request_Free_EventAreaStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventAreaFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_EventAreaStage_ClearOKDelegate CG_Request_Free_EventAreaStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaFreeStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo) => false;

        public Stub.CG_Request_Free_EventAreaStage_ContinueOKDelegate CG_Request_Free_EventAreaStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestEventAreaRewardStageClearOKDelegate CG_RequestEventAreaRewardStageClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaRewardStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo) => false;

        public Stub.CG_Request_Free_EventStage_StartOKDelegate CG_Request_Free_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_EventStage_ClearOKDelegate CG_Request_Free_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventFreeStageClearResultInfo, UserFreeStageEventInfo userFreeStageEventInfo) => false;

        public Stub.CG_Request_Free_EventStage_ContinueOKDelegate CG_Request_Free_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Main_ListEventStage_StartOKDelegate CG_Request_Main_ListEventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventListMainStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Main_ListEventStage_ClearOKDelegate CG_Request_Main_ListEventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventListMainStageClearResultInfo, UserListStageEventInfo userListStageEventInfo) => false;

        public Stub.CG_Request_Main_ListEventStage_ContinueOKDelegate CG_Request_Main_ListEventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_ListEventStage_StartOKDelegate CG_Request_Free_ListEventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventListFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_ListEventStage_ClearOKDelegate CG_Request_Free_ListEventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventListFreeStageClearResultInfo, UserListStageEventInfo userListStageEventInfo) => false;

        public Stub.CG_Request_Free_ListEventStage_ContinueOKDelegate CG_Request_Free_ListEventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_EventMainStage_StartOKDelegate CG_Request_FinalBoss_EventMainStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventFinalBossMainStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_EventMainStage_ClearOKDelegate CG_Request_FinalBoss_EventMainStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventFinalBossMainStageClearResultInfo, UserFinalBossStageEventInfo userFinalBossStageEventInfo) => false;

        public Stub.CG_Request_FinalBoss_EventMainStage_ContinueOKDelegate CG_Request_FinalBoss_EventMainStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_EventFreeStage_StartOKDelegate CG_Request_FinalBoss_EventFreeStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventFinalBossFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_EventFreeStage_ClearOKDelegate CG_Request_FinalBoss_EventFreeStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventFinalBossFreeStageClearResultInfo, UserFinalBossStageEventInfo userFinalBossStageEventInfo) => false;

        public Stub.CG_Request_FinalBoss_EventFreeStage_ContinueOKDelegate CG_Request_FinalBoss_EventFreeStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Limited_EventStage_StartOKDelegate CG_Request_Limited_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventLimitedStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Limited_EventStage_ClearOKDelegate CG_Request_Limited_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventLimitedStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo) => false;

        public Stub.CG_Request_Limited_EventStage_ContinueOKDelegate CG_Request_Limited_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Boss_EventStage_StartOKDelegate CG_Request_Boss_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventBossStageStartResultInf, PaybackEventResultInfo paybackEventresultInfoo) => false;

        public Stub.CG_Request_Boss_EventStage_ClearOKDelegate CG_Request_Boss_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventBossStageClearResultInfo, bool isDestroyDiscovered, DestroyDiscoverInfo eventDiscoverInfo, bool isFirstBoss, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo) => false;

        public Stub.CG_Request_Boss_EventStage_ContinueOKDelegate CG_Request_Boss_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Monthly_EventStage_StartOKDelegate CG_Request_Monthly_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo monthlyStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Monthly_EventStage_ClearOKDelegate CG_Request_Monthly_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventLimitedStageClearResultInfo) => false;

        public Stub.CG_Request_Monthly_EventStage_ContinueOKDelegate CG_Request_Monthly_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestMonthlyStagePointRewardOKDelegate CG_RequestMonthlyStagePointRewardOK = (HostID remote, RmiContext rmiContext, byte rewardIndex, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult) => false;

        public Stub.CG_Request_ChallengeBoss_EventStage_StartOKDelegate CG_Request_ChallengeBoss_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_ChallengeBoss_EventStage_ClearOKDelegate CG_Request_ChallengeBoss_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, ChallengeBossEventStageClearResultInfo resultInfo) => false;

        public Stub.CG_Request_ChallengeBoss_EventStage_ContinueOKDelegate CG_Request_ChallengeBoss_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_ChallengeBoss_EventStage_InfoOKDelegate CG_Request_ChallengeBoss_EventStage_InfoOK = (HostID remote, RmiContext rmiContext, ClientSendEventChallengeBossLobbyInfo info) => false;

        public Stub.CG_Request_ChallengeBoss_Event_Point_RewardOKDelegate CG_Request_ChallengeBoss_Event_Point_RewardOK = (HostID remote, RmiContext rmiContext, ChallengeBossEventInfoToClientSend info, List<ItemResultInfo> getItemResultInfoList, PaybackEventResultInfo m_paybackEventResultInfo) => false;

        public Stub.CG_Request_Training_Stage_InfoOKDelegate CG_Request_Training_Stage_InfoOK = (HostID remote, RmiContext rmiContext, TrainingStageInfo trainingStageInfo) => false;

        public Stub.CG_Request_Training_Stage_StartOKDelegate CG_Request_Training_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Training_Stage_ClearOKDelegate CG_Request_Training_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, TrainingStageSlotInfo clearStageSlotInfo, List<TrainingStageSlotInfo> openStageSlotInfoList, List<UserSkin> updateSkinList, TrainingStageInGameMissionClearInfo trainingStageIngameMissionClearInfo) => false;

        public Stub.CG_Request_Training_Stage_ContinueOKDelegate CG_Request_Training_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Training_Stage_OpenOKDelegate CG_Request_Training_Stage_OpenOK = (HostID remote, RmiContext rmiContext, TrainingStageInfo trainingStageInfo, APInfo apInfo) => false;

        public Stub.CG_Request_Training_Stage_RefreshOKDelegate CG_Request_Training_Stage_RefreshOK = (HostID remote, RmiContext rmiContext, TrainingStageInfo trainingStageInfo, List<ItemResultInfo> useResultItemInfoList, List<TrainingStageSlotInfo> updatedStageList, int resultDailyResetCount) => false;

        public Stub.CG_RequestWeekStageGaugeRewardOKDelegate CG_RequestWeekStageGaugeRewardOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> getItemResultInfoList, WeekStageGroupType weekStageGroupType, int groupID, MissionResult missionResult) => false;

        public Stub.CG_RequestStageEndLogOKDelegate CG_RequestStageEndLogOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_Request_SingleSiege_ExtraStage_StartOKDelegate CG_Request_SingleSiege_ExtraStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_SingleSiege_ExtraStage_ClearOKDelegate CG_Request_SingleSiege_ExtraStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, DestroyClearResult destroyClearResultInfo) => false;

        public Stub.CG_Request_SingleSiege_ExtraStage_ContinueOKDelegate CG_Request_SingleSiege_ExtraStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_Stage_StartOKDelegate CG_Request_FinalBoss_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_Stage_ClearOKDelegate CG_Request_FinalBoss_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, FinalBossStageResult finalBossStageResult, List<int> clearFinalBossMissionIDList, List<int> clearFinalBossVowIDList, RedisFinalBossRankInfo redisFinalBossRankInfo) => false;

        public Stub.CG_Request_FinalBoss_Stage_ContinueOKDelegate CG_Request_FinalBoss_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_Season_InfoOKDelegate CG_Request_FinalBoss_Season_InfoOK = (HostID remote, RmiContext rmiContext, ClientSendFinalBossSeasonInfo clientSendFinalBossSeasonInfo, List<ItemResultInfo> clearItemResultInfoList) => false;

        public Stub.CG_Request_FinalBoss_Season_Rank_InfoOKDelegate CG_Request_FinalBoss_Season_Rank_InfoOK = (HostID remote, RmiContext rmiContext, List<ClientSendFinalBossRankInfo> clientSendFinalBossRankInfoListTop100, List<ClientSendFinalBossRankHeroInfo> clientSendFinalBossHeroRankInfoList, FinalBossUserRankInfo userFinalBossRankInfo) => false;

        public Stub.CG_Request_FinalBoss_Score_RewardOKDelegate CG_Request_FinalBoss_Score_RewardOK = (HostID remote, RmiContext rmiContext, int seasonID, int bossGroupID, int lastScoreRewardOrder, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult) => false;

        public Stub.CG_Request_FinalBoss_Stage_Fame_StartOKDelegate CG_Request_FinalBoss_Stage_Fame_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_FinalBoss_Stage_Fame_ClearOKDelegate CG_Request_FinalBoss_Stage_Fame_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, FinalBossStageResult finalBossStageResult, FameResultInfo oldFameInfo, FameResultInfo newFameInfo) => false;

        public Stub.CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOKDelegate CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK = (HostID remote, RmiContext rmiContext, int fameID, FameResultInfo userFameInfo, List<FinalBossFameRankingInfo> finalBossFameRankingInfoList) => false;

        public Stub.CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOKDelegate CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK = (HostID remote, RmiContext rmiContext, int fameID, FameResultInfo nowFameResultInfo) => false;

        public Stub.CG_Request_GuildBoss_Stage_StartOKDelegate CG_Request_GuildBoss_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_GuildBoss_Stage_ClearOKDelegate CG_Request_GuildBoss_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, GuildRewardResult guildBossClearRewardResult, short currentGuildBossSeq, List<int> clearGuildBossMissionIDList, GuildBossRankPoint updateGuildBossRankPoint) => false;

        public Stub.CG_Request_GuildBoss_Lobby_InfoOKDelegate CG_Request_GuildBoss_Lobby_InfoOK = (HostID remote, RmiContext rmiContext, ClientSendGuildBossLobbyInfo clientSendGuildBossLobbyInfo) => false;

        public Stub.CG_Request_GuildBoss_Rank_InfoOKDelegate CG_Request_GuildBoss_Rank_InfoOK = (HostID remote, RmiContext rmiContext, ClientSendGuildBossLobbyInfo clientSendGuildBossLobbyInfo, List<ClientSendGuildRankInfo> clientSendGuildRankInfoList, List<GuildWarSelectionInfo> guildWarSelectionInfoList) => false;

        public Stub.CG_Request_GuildBoss_LastWeek_Rank_InfoOKDelegate CG_Request_GuildBoss_LastWeek_Rank_InfoOK = (HostID remote, RmiContext rmiContext, GuildRankRedisInfo guildRankInfo, List<ClientSendGuildRankInfo> clientSendGuildRankInfoList) => false;

        public Stub.CG_Request_GuildBoss_Time_RefreshOKDelegate CG_Request_GuildBoss_Time_RefreshOK = (HostID remote, RmiContext rmiContext, int guildRankStartRemainSec, int guildRankEndRemainSec) => false;

        public Stub.CG_Request_DisasterBoss_Stage_StartOKDelegate CG_Request_DisasterBoss_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_DisasterBoss_Stage_ClearOKDelegate CG_Request_DisasterBoss_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, bool isDestroyDiscovered, DestroyDisasterDicoverInfo disasterDiscoverInfo, bool isFirstClear) => false;

        public Stub.CG_Request_DisasterBoss_Stage_ContinueOKDelegate CG_Request_DisasterBoss_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Week_EventStage_StartOKDelegate CG_Request_Week_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Week_EventStage_ClearOKDelegate CG_Request_Week_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventWeekStageClearResultInfo, UserWeeklyStageEventInfo userWeekStageEventInfo) => false;

        public Stub.CG_Request_Week_EventStage_ContinueOKDelegate CG_Request_Week_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Tower_Stage_InfoOKDelegate CG_Request_Tower_Stage_InfoOK = (HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam) => false;

        public Stub.CG_Request_Tower_Stage_Set_Play_DeckOKDelegate CG_Request_Tower_Stage_Set_Play_DeckOK = (HostID remote, RmiContext rmiContext, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam) => false;

        public Stub.CG_Request_Tower_Stage_ResetOKDelegate CG_Request_Tower_Stage_ResetOK = (HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam) => false;

        public Stub.CG_Request_Tower_Stage_StartOKDelegate CG_Request_Tower_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Tower_Stage_ClearOKDelegate CG_Request_Tower_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int clearStageID, int recvReardStageID) => false;

        public Stub.CG_Request_Blitz_EventStage_Lobby_InfoOKDelegate CG_Request_Blitz_EventStage_Lobby_InfoOK = (HostID remote, RmiContext rmiContext, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo, string rejoinData) => false;

        public Stub.CG_Request_Blitz_EventStage_Squad_ChangeOKDelegate CG_Request_Blitz_EventStage_Squad_ChangeOK = (HostID remote, RmiContext rmiContext, int eventSEQ, BlitzSquadInfo blitzSquadInfo) => false;

        public Stub.CG_Request_Blitz_EventStage_Squad_InitOKDelegate CG_Request_Blitz_EventStage_Squad_InitOK = (HostID remote, RmiContext rmiContext, int eventSEQ, BlitzSquadInfo blitzSquadInfo) => false;

        public Stub.CG_Request_Blitz_EventStage_Team_ChangeOKDelegate CG_Request_Blitz_EventStage_Team_ChangeOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_Request_Blitz_EventStage_Main_StartOKDelegate CG_Request_Blitz_EventStage_Main_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Blitz_EventStage_Main_ClearOKDelegate CG_Request_Blitz_EventStage_Main_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo) => false;

        public Stub.CG_Request_Blitz_EventStage_Free_StartOKDelegate CG_Request_Blitz_EventStage_Free_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Blitz_EventStage_Free_ClearOKDelegate CG_Request_Blitz_EventStage_Free_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo) => false;

        public Stub.CG_Request_Blitz_EventStage_Reward_ClearOKDelegate CG_Request_Blitz_EventStage_Reward_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo) => false;

        public Stub.CG_Request_Blitz_EventStage_RejoinOKDelegate CG_Request_Blitz_EventStage_RejoinOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CG_Request_Blitz_EventStage_Rejoin_CancelOKDelegate CG_Request_Blitz_EventStage_Rejoin_CancelOK = (HostID remote, RmiContext rmiContext, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo) => false;

        public Stub.CG_Request_Free_Once_EventAreaStage_StartOKDelegate CG_Request_Free_Once_EventAreaStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo eventAreaFreeOnceStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Free_Once_EventAreaStage_ClearOKDelegate CG_Request_Free_Once_EventAreaStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaFreeOnceStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo) => false;

        public Stub.CG_Request_Free_Once_EventAreaStage_ContinueOKDelegate CG_Request_Free_Once_EventAreaStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_NorthMain_Stage_StartOKDelegate CG_Request_NorthMain_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_NorthMain_Stage_ClearOKDelegate CG_Request_NorthMain_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_Request_NorthMain_Stage_ContinueOKDelegate CG_Request_NorthMain_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_North_Free_Once_Stage_StartOKDelegate CG_Request_North_Free_Once_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_North_Free_Once_Stage_ClearOKDelegate CG_Request_North_Free_Once_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_Request_North_Free_Once_Stage_ContinueOKDelegate CG_Request_North_Free_Once_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Another_Free_Once_Stage_StartOKDelegate CG_Request_Another_Free_Once_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Another_Free_Once_Stage_ClearOKDelegate CG_Request_Another_Free_Once_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_Request_Another_Free_Once_Stage_ContinueOKDelegate CG_Request_Another_Free_Once_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Disaster_Tower_Stage_InfoOKDelegate CG_Request_Disaster_Tower_Stage_InfoOK = (HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam) => false;

        public Stub.CG_Request_Disaster_Tower_Stage_Set_Play_DeckOKDelegate CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK = (HostID remote, RmiContext rmiContext, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam) => false;

        public Stub.CG_Request_Disaster_Tower_Stage_ResetOKDelegate CG_Request_Disaster_Tower_Stage_ResetOK = (HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam) => false;

        public Stub.CG_Request_Disaster_Tower_Stage_StartOKDelegate CG_Request_Disaster_Tower_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_Disaster_Tower_Stage_ClearOKDelegate CG_Request_Disaster_Tower_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int clearStageID, int recvReardStageID) => false;

        public Stub.CG_Request_GuildBoss_Off_Season_Stage_StartOKDelegate CG_Request_GuildBoss_Off_Season_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_GuildBoss_Off_Season_Stage_ClearOKDelegate CG_Request_GuildBoss_Off_Season_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, GuildRewardResult guildBossClearRewardResult, short currentGuildBossSeq, List<int> clearGuildBossMissionIDList, GuildBossOffSeasonRankPoint updateGuildBossOffSeasonRankPoint) => false;

        public Stub.CG_RequestFinalBossVowUpdateOKDelegate CG_RequestFinalBossVowUpdateOK = (HostID remote, RmiContext rmiContext, int stageId, List<int> vowIdList) => false;

        public Stub.CG_Request_DescentBoss_EventStage_StartOKDelegate CG_Request_DescentBoss_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_DescentBoss_EventStage_ClearOKDelegate CG_Request_DescentBoss_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, EventDescentBossEventStageClearResultInfo resultInfo) => false;

        public Stub.CG_Request_DescentBoss_EventStage_ContinueOKDelegate CG_Request_DescentBoss_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_DescentBoss_Event_Point_RewardOKDelegate CG_Request_DescentBoss_Event_Point_RewardOK = (HostID remote, RmiContext rmiContext, DescentBossEventInfoToClientSend info, List<ItemResultInfo> getItemResultInfoList, PaybackEventResultInfo m_paybackEventResultInfo) => false;

        public Stub.CG_RequestWeekStageCoinOpenOKDelegate CG_RequestWeekStageCoinOpenOK = (HostID remote, RmiContext rmiContext, int areaID, int remainKeyOpenTimeSec, int remainWeekResetTimeSec, int coinDungeonWeekOpenCount, List<ItemResultInfo> useItemResultInfoList) => false;

        public Stub.CG_RequestYggdrasilTowerStageStartOKDelegate CG_RequestYggdrasilTowerStageStartOK = (HostID remote, RmiContext rmiContext, YggdrasilTowerStageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestYggdrasilTowerStageClearOKDelegate CG_RequestYggdrasilTowerStageClearOK = (HostID remote, RmiContext rmiContext, YggdrasilTowerStageClearResultInfo stageClearResultInfo, List<int> clearMissionIDList) => false;

        public Stub.CG_Request_Yggdrasil_Tower_Stage_ContinueOKDelegate CG_Request_Yggdrasil_Tower_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_CreatureNest_Season_InfoOKDelegate CG_Request_CreatureNest_Season_InfoOK = (HostID remote, RmiContext rmiContext, int selectedGroupID, List<ClientSendCreatureNestStageInfo> ClientSendCreatureNestStageInfoList, int remainWeekResetSec) => false;

        public Stub.CG_Request_CreatureNest_Stage_StartOKDelegate CG_Request_CreatureNest_Stage_StartOK = (HostID remote, RmiContext rmiContext, CreatureNestStageStartResultInfo startResultInfo) => false;

        public Stub.CG_Request_CreatureNest_Stage_ClearOKDelegate CG_Request_CreatureNest_Stage_ClearOK = (HostID remote, RmiContext rmiContext, CreatureNestStageClearResultInfo clearResultInfo) => false;

        public Stub.CG_Request_CreatureNest_Stage_ContinueOKDelegate CG_Request_CreatureNest_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_CreatureNest_InitOKDelegate CG_Request_CreatureNest_InitOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo) => false;

        public Stub.CG_Request_CreatureNest_Team_SaveOKDelegate CG_Request_CreatureNest_Team_SaveOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo) => false;

        public Stub.CG_Request_CreatureNest_Stage_RejoinOKDelegate CG_Request_CreatureNest_Stage_RejoinOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo, List<CreatureNestStagePassiveInfo> activePassiveSkillInfoList) => false;

        public Stub.CG_Request_CreatureNest_Stage_Rejoin_CancelOKDelegate CG_Request_CreatureNest_Stage_Rejoin_CancelOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo) => false;

        public Stub.CG_Request_CreatureNest_Use_Reset_ItemOKDelegate CG_Request_CreatureNest_Use_Reset_ItemOK = (HostID remote, RmiContext rmiContext, ItemResultInfo needItemResultInfo, int selectedGroupID, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo, MissionResult missionResult) => false;

        public Stub.CG_Request_CreatureNest_Challenge_RewardOKDelegate CG_Request_CreatureNest_Challenge_RewardOK = (HostID remote, RmiContext rmiContext, int groupID, ItemResultInfo rewardItemInfo, MissionResult missionResult) => false;

        public Stub.CG_Request_CreatureNest_Select_GroupOKDelegate CG_Request_CreatureNest_Select_GroupOK = (HostID remote, RmiContext rmiContext, int groupId) => false;

        public Stub.CG_RequestMercenaryListOKDelegate CG_RequestMercenaryListOK = (HostID remote, RmiContext rmiContext, List<MercenaryInfo> mercenaryInfoList) => false;

        public Stub.CG_RequestMercenaryInfoOKDelegate CG_RequestMercenaryInfoOK = (HostID remote, RmiContext rmiContext, MercenaryDetailInfo mercenaryDetailInfo) => false;

        public Stub.CG_RequestWeekStageKeyOpenOKDelegate CG_RequestWeekStageKeyOpenOK = (HostID remote, RmiContext rmiContext, int areaID, int remainKeyOpenTimeSec, ItemResultInfo useItemResultInfo, MissionResult missionResult) => false;

        public Stub.CG_RequestEventKOFBritanniaInfoOKDelegate CG_RequestEventKOFBritanniaInfoOK = (HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo) => false;

        public Stub.CG_RequestEventKOFBritanniaStartOKDelegate CG_RequestEventKOFBritanniaStartOK = (HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo, List<ItemResultInfo> useItemResultInfoList) => false;

        public Stub.CG_RequestEventKOFBritanniaTeamSelectOKDelegate CG_RequestEventKOFBritanniaTeamSelectOK = (HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo) => false;

        public Stub.CG_RequestEventKOFBritanniaTeamChangeOKDelegate CG_RequestEventKOFBritanniaTeamChangeOK = (HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo, UserTeamChangeInfo userTeamChangeInfo) => false;

        public Stub.CG_RequestEventKOFBritanniaStageStartOKDelegate CG_RequestEventKOFBritanniaStageStartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo, ItemResultInfo useItemResultInfo) => false;

        public Stub.CG_RequestEventKOFBritanniaStageClearOKDelegate CG_RequestEventKOFBritanniaStageClearOK = (HostID remote, RmiContext rmiContext, KOFBritanniaStageClearResultInfo stageClearResultInfo, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo) => false;

        public Stub.CG_RequestEventKOFBritanniaStageContinueOKDelegate CG_RequestEventKOFBritanniaStageContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestEventKOFBritanniaRestartOKDelegate CG_RequestEventKOFBritanniaRestartOK = (HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo) => false;

        public Stub.CG_RequestEventKOFBritanniaStageRejoinCancelOKDelegate CG_RequestEventKOFBritanniaStageRejoinCancelOK = (HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo) => false;

        public Stub.CG_RequestAncientWarInfoOKDelegate CG_RequestAncientWarInfoOK = (HostID remote, RmiContext rmiContext, UserAncientWarInfo userAnceintWarInfo, AncientWarInfo ancientWarInfo) => false;

        public Stub.CG_RequestAncientWarRefreshOKDelegate CG_RequestAncientWarRefreshOK = (HostID remote, RmiContext rmiContext, AncientWarInfo ancientWarInfo) => false;

        public Stub.CG_RequestAncientWarTeamSelectOKDelegate CG_RequestAncientWarTeamSelectOK = (HostID remote, RmiContext rmiContext, UserAncientWarInfo userAncientWarInfo) => false;

        public Stub.CG_RequestAncientWarStageStartOKDelegate CG_RequestAncientWarStageStartOK = (HostID remote, RmiContext rmiContext, AncientWarStageStartResultInfo stageStartResultInfo) => false;

        public Stub.CG_RequestAncientWarStageClearOKDelegate CG_RequestAncientWarStageClearOK = (HostID remote, RmiContext rmiContext, AncientWarStageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_RequestAncientWarExtraStageStartOKDelegate CG_RequestAncientWarExtraStageStartOK = (HostID remote, RmiContext rmiContext, AncientWarExtraStageStartResultInfo stageStartResultInfo) => false;

        public Stub.CG_RequestAncientWarExtraStageClearOKDelegate CG_RequestAncientWarExtraStageClearOK = (HostID remote, RmiContext rmiContext, AncientWarExtraStageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_RequestAncientWarRewardOKDelegate CG_RequestAncientWarRewardOK = (HostID remote, RmiContext rmiContext, byte rewardIndex, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestAncientWarDonationOKDelegate CG_RequestAncientWarDonationOK = (HostID remote, RmiContext rmiContext, ItemResultInfo useItemResultInfo, UserAncientWarInfo userAnceintWarInfo, AncientWarInfo ancientWarInfo) => false;

        public Stub.CG_RequestAncientWarRankInfoOKDelegate CG_RequestAncientWarRankInfoOK = (HostID remote, RmiContext rmiContext, List<AncientWarUserRankInfo> ancientWarUserRankInfoList, RedisAncientWarUserRankInfo userAncientWarRankInfo) => false;

        public Stub.CG_RequestEventMazeStageStartOKDelegate CG_RequestEventMazeStageStartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, UserMazeEventInfo userMazeEventInfo) => false;

        public Stub.CG_RequestEventMazeStageClearOKDelegate CG_RequestEventMazeStageClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, UserMazeEventInfo userMazeEventInfo) => false;

        public Stub.CG_RequestEventMazeStageRejoinOKDelegate CG_RequestEventMazeStageRejoinOK = (HostID remote, RmiContext rmiContext, UserMazeEventInfo userMazeEventInfo) => false;

        public Stub.CG_RequestEventMazeStageRejoinCancelOKDelegate CG_RequestEventMazeStageRejoinCancelOK = (HostID remote, RmiContext rmiContext, UserMazeEventInfo userMazeEventInfo, ItemResultInfo useItemResultInfo) => false;

        public Stub.CG_RequestEventMazeStageReChallengeOKDelegate CG_RequestEventMazeStageReChallengeOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, UserMazeEventInfo userMazeEventInfo) => false;

        public Stub.CG_RequestEventMazeStageReChallengeCancelOKDelegate CG_RequestEventMazeStageReChallengeCancelOK = (HostID remote, RmiContext rmiContext, UserMazeEventInfo userMazeEventInfo) => false;

        public Stub.CG_Request_Conquest_EventStage_StartOKDelegate CG_Request_Conquest_EventStage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Conquest_EventStage_ClearOKDelegate CG_Request_Conquest_EventStage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, UserEventConquesClientSendInfo userEventConquestClientSendInfo) => false;

        public Stub.CG_Request_Conquest_EventStage_ContinueOKDelegate CG_Request_Conquest_EventStage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Disaster_Main_Stage_StartOKDelegate CG_Request_Disaster_Main_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Disaster_Main_Stage_ClearOKDelegate CG_Request_Disaster_Main_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_Request_Disaster_Main_Stage_ContinueOKDelegate CG_Request_Disaster_Main_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Disaster_Free_Once_Stage_StartOKDelegate CG_Request_Disaster_Free_Once_Stage_StartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_Disaster_Free_Once_Stage_ClearOKDelegate CG_Request_Disaster_Free_Once_Stage_ClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo) => false;

        public Stub.CG_Request_Disaster_Free_Once_Stage_ContinueOKDelegate CG_Request_Disaster_Free_Once_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_Request_CreatureColosseum_Season_InfoOKDelegate CG_Request_CreatureColosseum_Season_InfoOK = (HostID remote, RmiContext rmiContext, List<ClientSendCreatureNestStageInfo> ClientSendCreatureNestStageInfoList, CreatureNestColosseumSeasonInfo seasonInfo) => false;

        public Stub.CG_Request_CreatureColosseum_Stage_StartOKDelegate CG_Request_CreatureColosseum_Stage_StartOK = (HostID remote, RmiContext rmiContext, CreatureNestStageStartResultInfo startResultInfo) => false;

        public Stub.CG_Request_CreatureColosseum_Stage_ClearOKDelegate CG_Request_CreatureColosseum_Stage_ClearOK = (HostID remote, RmiContext rmiContext, CreatureNestStageClearResultInfo clearResultInfo) => false;

        public Stub.CG_Request_CreatureColosseum_Stage_ContinueOKDelegate CG_Request_CreatureColosseum_Stage_ContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_Request_CreatureColosseum_InitOKDelegate CG_Request_CreatureColosseum_InitOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo) => false;

        public Stub.CG_Request_CreatureColosseum_Team_SaveOKDelegate CG_Request_CreatureColosseum_Team_SaveOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo) => false;

        public Stub.CG_Request_CreatureColosseum_Stage_RejoinOKDelegate CG_Request_CreatureColosseum_Stage_RejoinOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo, List<CreatureNestStagePassiveInfo> activePassiveSkillInfoList) => false;

        public Stub.CG_Request_CreatureColosseum_Stage_Rejoin_CancelOKDelegate CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK = (HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo) => false;

        public Stub.CG_RequestDemonLordStageOpenOKDelegate CG_RequestDemonLordStageOpenOK = (HostID remote, RmiContext rmiContext, UserDemonLordInfoToClientSend userDemonLordInfo) => false;

        public Stub.CG_RequestDemonLordStageStartOKDelegate CG_RequestDemonLordStageStartOK = (HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_RequestDemonLordStageClearOKDelegate CG_RequestDemonLordStageClearOK = (HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, UserDemonLordInfoToClientSend userDemonLordInfo) => false;

        public Stub.CG_RequestDemonLordStageContinueOKDelegate CG_RequestDemonLordStageContinueOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo) => false;

        public Stub.CG_RequestDemonLordStageCoinOpenOKDelegate CG_RequestDemonLordStageCoinOpenOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, UserDemonLordInfoToClientSend userDemonLordInfo, MissionResult missionResult) => false;

        public const string RmiName_CG_RequestStageInfoOK = "CG_RequestStageInfoOK";

        public const string RmiName_CG_RequestRecommandHeroOK = "CG_RequestRecommandHeroOK";

        public const string RmiName_CG_RequestIngameBattleStartOK = "CG_RequestIngameBattleStartOK";

        public const string RmiName_CG_RequestStageRejoinOK = "CG_RequestStageRejoinOK";

        public const string RmiName_CG_Request_Main_Stage_StartOK = "CG_Request_Main_Stage_StartOK";

        public const string RmiName_CG_Request_Main_Stage_ClearOK = "CG_Request_Main_Stage_ClearOK";

        public const string RmiName_CG_Request_Main_Stage_ContinueOK = "CG_Request_Main_Stage_ContinueOK";

        public const string RmiName_CG_Request_Free_Stage_StartOK = "CG_Request_Free_Stage_StartOK";

        public const string RmiName_CG_Request_Free_Stage_ClearOK = "CG_Request_Free_Stage_ClearOK";

        public const string RmiName_CG_Request_Free_Stage_ContinueOK = "CG_Request_Free_Stage_ContinueOK";

        public const string RmiName_CG_RequestHawkRunStageStartOK = "CG_RequestHawkRunStageStartOK";

        public const string RmiName_CG_RequestHawkRunStageClearOK = "CG_RequestHawkRunStageClearOK";

        public const string RmiName_CG_RequestEventStageClearOK = "CG_RequestEventStageClearOK";

        public const string RmiName_CG_Request_Quest_Stage_StartOK = "CG_Request_Quest_Stage_StartOK";

        public const string RmiName_CG_Request_Quest_Stage_ClearOK = "CG_Request_Quest_Stage_ClearOK";

        public const string RmiName_CG_Request_Quest_Stage_ContinueOK = "CG_Request_Quest_Stage_ContinueOK";

        public const string RmiName_CG_Request_Week_Stage_StartOK = "CG_Request_Week_Stage_StartOK";

        public const string RmiName_CG_Request_Week_Stage_ClearOK = "CG_Request_Week_Stage_ClearOK";

        public const string RmiName_CG_Request_Week_Stage_ContinueOK = "CG_Request_Week_Stage_ContinueOK";

        public const string RmiName_CG_Request_Boss_Stage_StartOK = "CG_Request_Boss_Stage_StartOK";

        public const string RmiName_CG_Request_Boss_Stage_ClearOK = "CG_Request_Boss_Stage_ClearOK";

        public const string RmiName_CG_Request_Boss_Stage_ContinueOK = "CG_Request_Boss_Stage_ContinueOK";

        public const string RmiName_CG_Request_Memorial_Stage_StartOK = "CG_Request_Memorial_Stage_StartOK";

        public const string RmiName_CG_Request_Memorial_Stage_ClearOK = "CG_Request_Memorial_Stage_ClearOK";

        public const string RmiName_CG_Request_Memorial_Stage_ContinueOK = "CG_Request_Memorial_Stage_ContinueOK";

        public const string RmiName_CG_Request_Limited_Stage_StartOK = "CG_Request_Limited_Stage_StartOK";

        public const string RmiName_CG_Request_Limited_Stage_ClearOK = "CG_Request_Limited_Stage_ClearOK";

        public const string RmiName_CG_Request_Limited_Stage_ContinueOK = "CG_Request_Limited_Stage_ContinueOK";

        public const string RmiName_CG_Request_Main_ExtraStage_StartOK = "CG_Request_Main_ExtraStage_StartOK";

        public const string RmiName_CG_Request_Main_ExtraStage_ClearOK = "CG_Request_Main_ExtraStage_ClearOK";

        public const string RmiName_CG_Request_Main_ExtraStage_ContinueOK = "CG_Request_Main_ExtraStage_ContinueOK";

        public const string RmiName_CG_Request_Boss_ExtraStage_StartOK = "CG_Request_Boss_ExtraStage_StartOK";

        public const string RmiName_CG_Request_Boss_ExtraStage_ClearOK = "CG_Request_Boss_ExtraStage_ClearOK";

        public const string RmiName_CG_Request_Boss_ExtraStage_ContinueOK = "CG_Request_Boss_ExtraStage_ContinueOK";

        public const string RmiName_CG_RequestRewardStageClearOK = "CG_RequestRewardStageClearOK";

        public const string RmiName_CG_Request_AnotherMain_Stage_StartOK = "CG_Request_AnotherMain_Stage_StartOK";

        public const string RmiName_CG_Request_AnotherMain_Stage_ClearOK = "CG_Request_AnotherMain_Stage_ClearOK";

        public const string RmiName_CG_Request_AnotherMain_Stage_ContinueOK = "CG_Request_AnotherMain_Stage_ContinueOK";

        public const string RmiName_CG_Request_Reverse_Stage_StartOK = "CG_Request_Reverse_Stage_StartOK";

        public const string RmiName_CG_Request_Reverse_Stage_ClearOK = "CG_Request_Reverse_Stage_ClearOK";

        public const string RmiName_CG_Request_Reverse_Star_RewardOK = "CG_Request_Reverse_Star_RewardOK";

        public const string RmiName_CG_Request_Reverse_Group_RewardOK = "CG_Request_Reverse_Group_RewardOK";

        public const string RmiName_CG_Request_Free_Stage_ClearTicketOK = "CG_Request_Free_Stage_ClearTicketOK";

        public const string RmiName_CG_Request_Week_Stage_ClearTicketOK = "CG_Request_Week_Stage_ClearTicketOK";

        public const string RmiName_CG_Request_Boss_Stage_ClearTicketOK = "CG_Request_Boss_Stage_ClearTicketOK";

        public const string RmiName_CG_Request_Week_EventStage_ClearTicketOK = "CG_Request_Week_EventStage_ClearTicketOK";

        public const string RmiName_CG_Request_DisasterBoss_Stage_ClearTicketOK = "CG_Request_DisasterBoss_Stage_ClearTicketOK";

        public const string RmiName_CG_Request_Free_EventAreaStage_ClearTicketOK = "CG_Request_Free_EventAreaStage_ClearTicketOK";

        public const string RmiName_CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK = "CG_Request_Yggdrasil_Tower_Stage_ClearTicketOK";

        public const string RmiName_CG_Request_Training_Stage_ClearTicketOK = "CG_Request_Training_Stage_ClearTicketOK";

        public const string RmiName_CG_Request_Main_EventAreaStage_StartOK = "CG_Request_Main_EventAreaStage_StartOK";

        public const string RmiName_CG_Request_Main_EventAreaStage_ClearOK = "CG_Request_Main_EventAreaStage_ClearOK";

        public const string RmiName_CG_Request_Main_EventAreaStage_ContinueOK = "CG_Request_Main_EventAreaStage_ContinueOK";

        public const string RmiName_CG_Request_Free_EventAreaStage_StartOK = "CG_Request_Free_EventAreaStage_StartOK";

        public const string RmiName_CG_Request_Free_EventAreaStage_ClearOK = "CG_Request_Free_EventAreaStage_ClearOK";

        public const string RmiName_CG_Request_Free_EventAreaStage_ContinueOK = "CG_Request_Free_EventAreaStage_ContinueOK";

        public const string RmiName_CG_RequestEventAreaRewardStageClearOK = "CG_RequestEventAreaRewardStageClearOK";

        public const string RmiName_CG_Request_Free_EventStage_StartOK = "CG_Request_Free_EventStage_StartOK";

        public const string RmiName_CG_Request_Free_EventStage_ClearOK = "CG_Request_Free_EventStage_ClearOK";

        public const string RmiName_CG_Request_Free_EventStage_ContinueOK = "CG_Request_Free_EventStage_ContinueOK";

        public const string RmiName_CG_Request_Main_ListEventStage_StartOK = "CG_Request_Main_ListEventStage_StartOK";

        public const string RmiName_CG_Request_Main_ListEventStage_ClearOK = "CG_Request_Main_ListEventStage_ClearOK";

        public const string RmiName_CG_Request_Main_ListEventStage_ContinueOK = "CG_Request_Main_ListEventStage_ContinueOK";

        public const string RmiName_CG_Request_Free_ListEventStage_StartOK = "CG_Request_Free_ListEventStage_StartOK";

        public const string RmiName_CG_Request_Free_ListEventStage_ClearOK = "CG_Request_Free_ListEventStage_ClearOK";

        public const string RmiName_CG_Request_Free_ListEventStage_ContinueOK = "CG_Request_Free_ListEventStage_ContinueOK";

        public const string RmiName_CG_Request_FinalBoss_EventMainStage_StartOK = "CG_Request_FinalBoss_EventMainStage_StartOK";

        public const string RmiName_CG_Request_FinalBoss_EventMainStage_ClearOK = "CG_Request_FinalBoss_EventMainStage_ClearOK";

        public const string RmiName_CG_Request_FinalBoss_EventMainStage_ContinueOK = "CG_Request_FinalBoss_EventMainStage_ContinueOK";

        public const string RmiName_CG_Request_FinalBoss_EventFreeStage_StartOK = "CG_Request_FinalBoss_EventFreeStage_StartOK";

        public const string RmiName_CG_Request_FinalBoss_EventFreeStage_ClearOK = "CG_Request_FinalBoss_EventFreeStage_ClearOK";

        public const string RmiName_CG_Request_FinalBoss_EventFreeStage_ContinueOK = "CG_Request_FinalBoss_EventFreeStage_ContinueOK";

        public const string RmiName_CG_Request_Limited_EventStage_StartOK = "CG_Request_Limited_EventStage_StartOK";

        public const string RmiName_CG_Request_Limited_EventStage_ClearOK = "CG_Request_Limited_EventStage_ClearOK";

        public const string RmiName_CG_Request_Limited_EventStage_ContinueOK = "CG_Request_Limited_EventStage_ContinueOK";

        public const string RmiName_CG_Request_Boss_EventStage_StartOK = "CG_Request_Boss_EventStage_StartOK";

        public const string RmiName_CG_Request_Boss_EventStage_ClearOK = "CG_Request_Boss_EventStage_ClearOK";

        public const string RmiName_CG_Request_Boss_EventStage_ContinueOK = "CG_Request_Boss_EventStage_ContinueOK";

        public const string RmiName_CG_Request_Monthly_EventStage_StartOK = "CG_Request_Monthly_EventStage_StartOK";

        public const string RmiName_CG_Request_Monthly_EventStage_ClearOK = "CG_Request_Monthly_EventStage_ClearOK";

        public const string RmiName_CG_Request_Monthly_EventStage_ContinueOK = "CG_Request_Monthly_EventStage_ContinueOK";

        public const string RmiName_CG_RequestMonthlyStagePointRewardOK = "CG_RequestMonthlyStagePointRewardOK";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_StartOK = "CG_Request_ChallengeBoss_EventStage_StartOK";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_ClearOK = "CG_Request_ChallengeBoss_EventStage_ClearOK";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_ContinueOK = "CG_Request_ChallengeBoss_EventStage_ContinueOK";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_InfoOK = "CG_Request_ChallengeBoss_EventStage_InfoOK";

        public const string RmiName_CG_Request_ChallengeBoss_Event_Point_RewardOK = "CG_Request_ChallengeBoss_Event_Point_RewardOK";

        public const string RmiName_CG_Request_Training_Stage_InfoOK = "CG_Request_Training_Stage_InfoOK";

        public const string RmiName_CG_Request_Training_Stage_StartOK = "CG_Request_Training_Stage_StartOK";

        public const string RmiName_CG_Request_Training_Stage_ClearOK = "CG_Request_Training_Stage_ClearOK";

        public const string RmiName_CG_Request_Training_Stage_ContinueOK = "CG_Request_Training_Stage_ContinueOK";

        public const string RmiName_CG_Request_Training_Stage_OpenOK = "CG_Request_Training_Stage_OpenOK";

        public const string RmiName_CG_Request_Training_Stage_RefreshOK = "CG_Request_Training_Stage_RefreshOK";

        public const string RmiName_CG_RequestWeekStageGaugeRewardOK = "CG_RequestWeekStageGaugeRewardOK";

        public const string RmiName_CG_RequestStageEndLogOK = "CG_RequestStageEndLogOK";

        public const string RmiName_CG_Request_SingleSiege_ExtraStage_StartOK = "CG_Request_SingleSiege_ExtraStage_StartOK";

        public const string RmiName_CG_Request_SingleSiege_ExtraStage_ClearOK = "CG_Request_SingleSiege_ExtraStage_ClearOK";

        public const string RmiName_CG_Request_SingleSiege_ExtraStage_ContinueOK = "CG_Request_SingleSiege_ExtraStage_ContinueOK";

        public const string RmiName_CG_Request_FinalBoss_Stage_StartOK = "CG_Request_FinalBoss_Stage_StartOK";

        public const string RmiName_CG_Request_FinalBoss_Stage_ClearOK = "CG_Request_FinalBoss_Stage_ClearOK";

        public const string RmiName_CG_Request_FinalBoss_Stage_ContinueOK = "CG_Request_FinalBoss_Stage_ContinueOK";

        public const string RmiName_CG_Request_FinalBoss_Season_InfoOK = "CG_Request_FinalBoss_Season_InfoOK";

        public const string RmiName_CG_Request_FinalBoss_Season_Rank_InfoOK = "CG_Request_FinalBoss_Season_Rank_InfoOK";

        public const string RmiName_CG_Request_FinalBoss_Score_RewardOK = "CG_Request_FinalBoss_Score_RewardOK";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_StartOK = "CG_Request_FinalBoss_Stage_Fame_StartOK";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_ClearOK = "CG_Request_FinalBoss_Stage_Fame_ClearOK";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK = "CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOK";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK = "CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOK";

        public const string RmiName_CG_Request_GuildBoss_Stage_StartOK = "CG_Request_GuildBoss_Stage_StartOK";

        public const string RmiName_CG_Request_GuildBoss_Stage_ClearOK = "CG_Request_GuildBoss_Stage_ClearOK";

        public const string RmiName_CG_Request_GuildBoss_Lobby_InfoOK = "CG_Request_GuildBoss_Lobby_InfoOK";

        public const string RmiName_CG_Request_GuildBoss_Rank_InfoOK = "CG_Request_GuildBoss_Rank_InfoOK";

        public const string RmiName_CG_Request_GuildBoss_LastWeek_Rank_InfoOK = "CG_Request_GuildBoss_LastWeek_Rank_InfoOK";

        public const string RmiName_CG_Request_GuildBoss_Time_RefreshOK = "CG_Request_GuildBoss_Time_RefreshOK";

        public const string RmiName_CG_Request_DisasterBoss_Stage_StartOK = "CG_Request_DisasterBoss_Stage_StartOK";

        public const string RmiName_CG_Request_DisasterBoss_Stage_ClearOK = "CG_Request_DisasterBoss_Stage_ClearOK";

        public const string RmiName_CG_Request_DisasterBoss_Stage_ContinueOK = "CG_Request_DisasterBoss_Stage_ContinueOK";

        public const string RmiName_CG_Request_Week_EventStage_StartOK = "CG_Request_Week_EventStage_StartOK";

        public const string RmiName_CG_Request_Week_EventStage_ClearOK = "CG_Request_Week_EventStage_ClearOK";

        public const string RmiName_CG_Request_Week_EventStage_ContinueOK = "CG_Request_Week_EventStage_ContinueOK";

        public const string RmiName_CG_Request_Tower_Stage_InfoOK = "CG_Request_Tower_Stage_InfoOK";

        public const string RmiName_CG_Request_Tower_Stage_Set_Play_DeckOK = "CG_Request_Tower_Stage_Set_Play_DeckOK";

        public const string RmiName_CG_Request_Tower_Stage_ResetOK = "CG_Request_Tower_Stage_ResetOK";

        public const string RmiName_CG_Request_Tower_Stage_StartOK = "CG_Request_Tower_Stage_StartOK";

        public const string RmiName_CG_Request_Tower_Stage_ClearOK = "CG_Request_Tower_Stage_ClearOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Lobby_InfoOK = "CG_Request_Blitz_EventStage_Lobby_InfoOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Squad_ChangeOK = "CG_Request_Blitz_EventStage_Squad_ChangeOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Squad_InitOK = "CG_Request_Blitz_EventStage_Squad_InitOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Team_ChangeOK = "CG_Request_Blitz_EventStage_Team_ChangeOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Main_StartOK = "CG_Request_Blitz_EventStage_Main_StartOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Main_ClearOK = "CG_Request_Blitz_EventStage_Main_ClearOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Free_StartOK = "CG_Request_Blitz_EventStage_Free_StartOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Free_ClearOK = "CG_Request_Blitz_EventStage_Free_ClearOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Reward_ClearOK = "CG_Request_Blitz_EventStage_Reward_ClearOK";

        public const string RmiName_CG_Request_Blitz_EventStage_RejoinOK = "CG_Request_Blitz_EventStage_RejoinOK";

        public const string RmiName_CG_Request_Blitz_EventStage_Rejoin_CancelOK = "CG_Request_Blitz_EventStage_Rejoin_CancelOK";

        public const string RmiName_CG_Request_Free_Once_EventAreaStage_StartOK = "CG_Request_Free_Once_EventAreaStage_StartOK";

        public const string RmiName_CG_Request_Free_Once_EventAreaStage_ClearOK = "CG_Request_Free_Once_EventAreaStage_ClearOK";

        public const string RmiName_CG_Request_Free_Once_EventAreaStage_ContinueOK = "CG_Request_Free_Once_EventAreaStage_ContinueOK";

        public const string RmiName_CG_Request_NorthMain_Stage_StartOK = "CG_Request_NorthMain_Stage_StartOK";

        public const string RmiName_CG_Request_NorthMain_Stage_ClearOK = "CG_Request_NorthMain_Stage_ClearOK";

        public const string RmiName_CG_Request_NorthMain_Stage_ContinueOK = "CG_Request_NorthMain_Stage_ContinueOK";

        public const string RmiName_CG_Request_North_Free_Once_Stage_StartOK = "CG_Request_North_Free_Once_Stage_StartOK";

        public const string RmiName_CG_Request_North_Free_Once_Stage_ClearOK = "CG_Request_North_Free_Once_Stage_ClearOK";

        public const string RmiName_CG_Request_North_Free_Once_Stage_ContinueOK = "CG_Request_North_Free_Once_Stage_ContinueOK";

        public const string RmiName_CG_Request_Another_Free_Once_Stage_StartOK = "CG_Request_Another_Free_Once_Stage_StartOK";

        public const string RmiName_CG_Request_Another_Free_Once_Stage_ClearOK = "CG_Request_Another_Free_Once_Stage_ClearOK";

        public const string RmiName_CG_Request_Another_Free_Once_Stage_ContinueOK = "CG_Request_Another_Free_Once_Stage_ContinueOK";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_InfoOK = "CG_Request_Disaster_Tower_Stage_InfoOK";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK = "CG_Request_Disaster_Tower_Stage_Set_Play_DeckOK";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_ResetOK = "CG_Request_Disaster_Tower_Stage_ResetOK";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_StartOK = "CG_Request_Disaster_Tower_Stage_StartOK";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_ClearOK = "CG_Request_Disaster_Tower_Stage_ClearOK";

        public const string RmiName_CG_Request_GuildBoss_Off_Season_Stage_StartOK = "CG_Request_GuildBoss_Off_Season_Stage_StartOK";

        public const string RmiName_CG_Request_GuildBoss_Off_Season_Stage_ClearOK = "CG_Request_GuildBoss_Off_Season_Stage_ClearOK";

        public const string RmiName_CG_RequestFinalBossVowUpdateOK = "CG_RequestFinalBossVowUpdateOK";

        public const string RmiName_CG_Request_DescentBoss_EventStage_StartOK = "CG_Request_DescentBoss_EventStage_StartOK";

        public const string RmiName_CG_Request_DescentBoss_EventStage_ClearOK = "CG_Request_DescentBoss_EventStage_ClearOK";

        public const string RmiName_CG_Request_DescentBoss_EventStage_ContinueOK = "CG_Request_DescentBoss_EventStage_ContinueOK";

        public const string RmiName_CG_Request_DescentBoss_Event_Point_RewardOK = "CG_Request_DescentBoss_Event_Point_RewardOK";

        public const string RmiName_CG_RequestWeekStageCoinOpenOK = "CG_RequestWeekStageCoinOpenOK";

        public const string RmiName_CG_RequestYggdrasilTowerStageStartOK = "CG_RequestYggdrasilTowerStageStartOK";

        public const string RmiName_CG_RequestYggdrasilTowerStageClearOK = "CG_RequestYggdrasilTowerStageClearOK";

        public const string RmiName_CG_Request_Yggdrasil_Tower_Stage_ContinueOK = "CG_Request_Yggdrasil_Tower_Stage_ContinueOK";

        public const string RmiName_CG_Request_CreatureNest_Season_InfoOK = "CG_Request_CreatureNest_Season_InfoOK";

        public const string RmiName_CG_Request_CreatureNest_Stage_StartOK = "CG_Request_CreatureNest_Stage_StartOK";

        public const string RmiName_CG_Request_CreatureNest_Stage_ClearOK = "CG_Request_CreatureNest_Stage_ClearOK";

        public const string RmiName_CG_Request_CreatureNest_Stage_ContinueOK = "CG_Request_CreatureNest_Stage_ContinueOK";

        public const string RmiName_CG_Request_CreatureNest_InitOK = "CG_Request_CreatureNest_InitOK";

        public const string RmiName_CG_Request_CreatureNest_Team_SaveOK = "CG_Request_CreatureNest_Team_SaveOK";

        public const string RmiName_CG_Request_CreatureNest_Stage_RejoinOK = "CG_Request_CreatureNest_Stage_RejoinOK";

        public const string RmiName_CG_Request_CreatureNest_Stage_Rejoin_CancelOK = "CG_Request_CreatureNest_Stage_Rejoin_CancelOK";

        public const string RmiName_CG_Request_CreatureNest_Use_Reset_ItemOK = "CG_Request_CreatureNest_Use_Reset_ItemOK";

        public const string RmiName_CG_Request_CreatureNest_Challenge_RewardOK = "CG_Request_CreatureNest_Challenge_RewardOK";

        public const string RmiName_CG_Request_CreatureNest_Select_GroupOK = "CG_Request_CreatureNest_Select_GroupOK";

        public const string RmiName_CG_RequestMercenaryListOK = "CG_RequestMercenaryListOK";

        public const string RmiName_CG_RequestMercenaryInfoOK = "CG_RequestMercenaryInfoOK";

        public const string RmiName_CG_RequestWeekStageKeyOpenOK = "CG_RequestWeekStageKeyOpenOK";

        public const string RmiName_CG_RequestEventKOFBritanniaInfoOK = "CG_RequestEventKOFBritanniaInfoOK";

        public const string RmiName_CG_RequestEventKOFBritanniaStartOK = "CG_RequestEventKOFBritanniaStartOK";

        public const string RmiName_CG_RequestEventKOFBritanniaTeamSelectOK = "CG_RequestEventKOFBritanniaTeamSelectOK";

        public const string RmiName_CG_RequestEventKOFBritanniaTeamChangeOK = "CG_RequestEventKOFBritanniaTeamChangeOK";

        public const string RmiName_CG_RequestEventKOFBritanniaStageStartOK = "CG_RequestEventKOFBritanniaStageStartOK";

        public const string RmiName_CG_RequestEventKOFBritanniaStageClearOK = "CG_RequestEventKOFBritanniaStageClearOK";

        public const string RmiName_CG_RequestEventKOFBritanniaStageContinueOK = "CG_RequestEventKOFBritanniaStageContinueOK";

        public const string RmiName_CG_RequestEventKOFBritanniaRestartOK = "CG_RequestEventKOFBritanniaRestartOK";

        public const string RmiName_CG_RequestEventKOFBritanniaStageRejoinCancelOK = "CG_RequestEventKOFBritanniaStageRejoinCancelOK";

        public const string RmiName_CG_RequestAncientWarInfoOK = "CG_RequestAncientWarInfoOK";

        public const string RmiName_CG_RequestAncientWarRefreshOK = "CG_RequestAncientWarRefreshOK";

        public const string RmiName_CG_RequestAncientWarTeamSelectOK = "CG_RequestAncientWarTeamSelectOK";

        public const string RmiName_CG_RequestAncientWarStageStartOK = "CG_RequestAncientWarStageStartOK";

        public const string RmiName_CG_RequestAncientWarStageClearOK = "CG_RequestAncientWarStageClearOK";

        public const string RmiName_CG_RequestAncientWarExtraStageStartOK = "CG_RequestAncientWarExtraStageStartOK";

        public const string RmiName_CG_RequestAncientWarExtraStageClearOK = "CG_RequestAncientWarExtraStageClearOK";

        public const string RmiName_CG_RequestAncientWarRewardOK = "CG_RequestAncientWarRewardOK";

        public const string RmiName_CG_RequestAncientWarDonationOK = "CG_RequestAncientWarDonationOK";

        public const string RmiName_CG_RequestAncientWarRankInfoOK = "CG_RequestAncientWarRankInfoOK";

        public const string RmiName_CG_RequestEventMazeStageStartOK = "CG_RequestEventMazeStageStartOK";

        public const string RmiName_CG_RequestEventMazeStageClearOK = "CG_RequestEventMazeStageClearOK";

        public const string RmiName_CG_RequestEventMazeStageRejoinOK = "CG_RequestEventMazeStageRejoinOK";

        public const string RmiName_CG_RequestEventMazeStageRejoinCancelOK = "CG_RequestEventMazeStageRejoinCancelOK";

        public const string RmiName_CG_RequestEventMazeStageReChallengeOK = "CG_RequestEventMazeStageReChallengeOK";

        public const string RmiName_CG_RequestEventMazeStageReChallengeCancelOK = "CG_RequestEventMazeStageReChallengeCancelOK";

        public const string RmiName_CG_Request_Conquest_EventStage_StartOK = "CG_Request_Conquest_EventStage_StartOK";

        public const string RmiName_CG_Request_Conquest_EventStage_ClearOK = "CG_Request_Conquest_EventStage_ClearOK";

        public const string RmiName_CG_Request_Conquest_EventStage_ContinueOK = "CG_Request_Conquest_EventStage_ContinueOK";

        public const string RmiName_CG_Request_Disaster_Main_Stage_StartOK = "CG_Request_Disaster_Main_Stage_StartOK";

        public const string RmiName_CG_Request_Disaster_Main_Stage_ClearOK = "CG_Request_Disaster_Main_Stage_ClearOK";

        public const string RmiName_CG_Request_Disaster_Main_Stage_ContinueOK = "CG_Request_Disaster_Main_Stage_ContinueOK";

        public const string RmiName_CG_Request_Disaster_Free_Once_Stage_StartOK = "CG_Request_Disaster_Free_Once_Stage_StartOK";

        public const string RmiName_CG_Request_Disaster_Free_Once_Stage_ClearOK = "CG_Request_Disaster_Free_Once_Stage_ClearOK";

        public const string RmiName_CG_Request_Disaster_Free_Once_Stage_ContinueOK = "CG_Request_Disaster_Free_Once_Stage_ContinueOK";

        public const string RmiName_CG_Request_CreatureColosseum_Season_InfoOK = "CG_Request_CreatureColosseum_Season_InfoOK";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_StartOK = "CG_Request_CreatureColosseum_Stage_StartOK";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_ClearOK = "CG_Request_CreatureColosseum_Stage_ClearOK";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_ContinueOK = "CG_Request_CreatureColosseum_Stage_ContinueOK";

        public const string RmiName_CG_Request_CreatureColosseum_InitOK = "CG_Request_CreatureColosseum_InitOK";

        public const string RmiName_CG_Request_CreatureColosseum_Team_SaveOK = "CG_Request_CreatureColosseum_Team_SaveOK";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_RejoinOK = "CG_Request_CreatureColosseum_Stage_RejoinOK";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK = "CG_Request_CreatureColosseum_Stage_Rejoin_CancelOK";

        public const string RmiName_CG_RequestDemonLordStageOpenOK = "CG_RequestDemonLordStageOpenOK";

        public const string RmiName_CG_RequestDemonLordStageStartOK = "CG_RequestDemonLordStageStartOK";

        public const string RmiName_CG_RequestDemonLordStageClearOK = "CG_RequestDemonLordStageClearOK";

        public const string RmiName_CG_RequestDemonLordStageContinueOK = "CG_RequestDemonLordStageContinueOK";

        public const string RmiName_CG_RequestDemonLordStageCoinOpenOK = "CG_RequestDemonLordStageCoinOpenOK";

        public const string RmiName_First = "CG_RequestStageInfoOK";

        public delegate bool CG_RequestStageInfoOKDelegate(HostID remote, RmiContext rmiContext, StageInfo stageInfo);

        public delegate bool CG_RequestRecommandHeroOKDelegate(HostID remote, RmiContext rmiContext, RecommandHeroRequestInfo requestInfo, RecommandHeroInfo recommandHeroInfo);

        public delegate bool CG_RequestIngameBattleStartOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_RequestStageRejoinOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_Request_Main_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Main_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, bool isFirstMainStageClear, List<UserPackageMissionInfo> userPackageMissionInfoList);

        public delegate bool CG_Request_Main_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo freeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo freeStageClearResultInfo);

        public delegate bool CG_Request_Free_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestHawkRunStageStartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo hawkRunStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestHawkRunStageClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo runStageClearResultInfo);

        public delegate bool CG_RequestEventStageClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventStageClearResultInfo);

        public delegate bool CG_Request_Quest_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo questStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Quest_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo questStageClearResultInfo);

        public delegate bool CG_Request_Quest_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Week_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo weekStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo, ItemResultInfo useKeyItemResultInfo);

        public delegate bool CG_Request_Week_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo weekStageClearResultInfo, bool isFirstWeeklyStage, List<APInfo> apInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList);

        public delegate bool CG_Request_Week_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Boss_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo bossStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Boss_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo bossClearResultInfo, bool isDestroyDiscovered, DestroyDiscoverInfo discoverInfo, bool isFirstBoss, List<UserPackageMissionInfo> userPackageMissionInfoList);

        public delegate bool CG_Request_Boss_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Memorial_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo memorialStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Memorial_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo memorialClearResultInfo, UserSkin userSkin);

        public delegate bool CG_Request_Memorial_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Limited_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo limitedStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Limited_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo limitedStageClearResultInfo);

        public delegate bool CG_Request_Limited_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Main_ExtraStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo extraMainStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Main_ExtraStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo extraMainStageClearResultInfo);

        public delegate bool CG_Request_Main_ExtraStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Boss_ExtraStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo extraBossStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Boss_ExtraStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo extraBossStageClearResultInfo);

        public delegate bool CG_Request_Boss_ExtraStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestRewardStageClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo rewardStageClearResultInfo);

        public delegate bool CG_Request_AnotherMain_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_AnotherMain_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo);

        public delegate bool CG_Request_AnotherMain_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Reverse_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Reverse_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, ReverseGroupInfo userGroupInfo);

        public delegate bool CG_Request_Reverse_Star_RewardOKDelegate(HostID remote, RmiContext rmiContext, short seasonID, byte rewardedIndex, ItemResultInfo getItemResultInfo, MissionResult missionResult);

        public delegate bool CG_Request_Reverse_Group_RewardOKDelegate(HostID remote, RmiContext rmiContext, short rewardID, ItemResultInfo getItemResultInfo, MissionResult missionResult);

        public delegate bool CG_Request_Free_Stage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Week_Stage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, List<APInfo> apInfoList, UserADViewInfo adViewRouletteInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Boss_Stage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, bool isDestroyDiscovered, DestroyDiscoverInfo discoverInfo, PaybackEventResultInfo paybackEventResultInfo, bool isBatchPlay);

        public delegate bool CG_Request_Week_EventStage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_DisasterBoss_Stage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, bool isDestroyDiscovered, DestroyDisasterDicoverInfo destroyDiscoverInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Free_EventAreaStage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Yggdrasil_Tower_Stage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, List<APInfo> apInfoList, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Training_Stage_ClearTicketOKDelegate(HostID remote, RmiContext rmiContext, StageClearTicketResult ticketClearResultInfo, TrainingStageSlotInfo clearStageSlotInfo, List<TrainingStageSlotInfo> openStageSlotInfoList, List<UserSkin> updateSkinList, TrainingStageInGameMissionClearInfo trainingStageIngameMissionClearInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Main_EventAreaStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventAreaStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Main_EventAreaStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo);

        public delegate bool CG_Request_Main_EventAreaStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_EventAreaStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventAreaFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_EventAreaStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaFreeStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo);

        public delegate bool CG_Request_Free_EventAreaStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestEventAreaRewardStageClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaRewardStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo);

        public delegate bool CG_Request_Free_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventFreeStageClearResultInfo, UserFreeStageEventInfo userFreeStageEventInfo);

        public delegate bool CG_Request_Free_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Main_ListEventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventListMainStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Main_ListEventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventListMainStageClearResultInfo, UserListStageEventInfo userListStageEventInfo);

        public delegate bool CG_Request_Main_ListEventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_ListEventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventListFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_ListEventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventListFreeStageClearResultInfo, UserListStageEventInfo userListStageEventInfo);

        public delegate bool CG_Request_Free_ListEventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_EventMainStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventFinalBossMainStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_EventMainStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventFinalBossMainStageClearResultInfo, UserFinalBossStageEventInfo userFinalBossStageEventInfo);

        public delegate bool CG_Request_FinalBoss_EventMainStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_EventFreeStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventFinalBossFreeStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_EventFreeStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventFinalBossFreeStageClearResultInfo, UserFinalBossStageEventInfo userFinalBossStageEventInfo);

        public delegate bool CG_Request_FinalBoss_EventFreeStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Limited_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventLimitedStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Limited_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventLimitedStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo);

        public delegate bool CG_Request_Limited_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Boss_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventBossStageStartResultInf, PaybackEventResultInfo paybackEventresultInfoo);

        public delegate bool CG_Request_Boss_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventBossStageClearResultInfo, bool isDestroyDiscovered, DestroyDiscoverInfo eventDiscoverInfo, bool isFirstBoss, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo);

        public delegate bool CG_Request_Boss_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Monthly_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo monthlyStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Monthly_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventLimitedStageClearResultInfo);

        public delegate bool CG_Request_Monthly_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestMonthlyStagePointRewardOKDelegate(HostID remote, RmiContext rmiContext, byte rewardIndex, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult);

        public delegate bool CG_Request_ChallengeBoss_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_ChallengeBoss_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, ChallengeBossEventStageClearResultInfo resultInfo);

        public delegate bool CG_Request_ChallengeBoss_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_ChallengeBoss_EventStage_InfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendEventChallengeBossLobbyInfo info);

        public delegate bool CG_Request_ChallengeBoss_Event_Point_RewardOKDelegate(HostID remote, RmiContext rmiContext, ChallengeBossEventInfoToClientSend info, List<ItemResultInfo> getItemResultInfoList, PaybackEventResultInfo m_paybackEventResultInfo);

        public delegate bool CG_Request_Training_Stage_InfoOKDelegate(HostID remote, RmiContext rmiContext, TrainingStageInfo trainingStageInfo);

        public delegate bool CG_Request_Training_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Training_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, TrainingStageSlotInfo clearStageSlotInfo, List<TrainingStageSlotInfo> openStageSlotInfoList, List<UserSkin> updateSkinList, TrainingStageInGameMissionClearInfo trainingStageIngameMissionClearInfo);

        public delegate bool CG_Request_Training_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Training_Stage_OpenOKDelegate(HostID remote, RmiContext rmiContext, TrainingStageInfo trainingStageInfo, APInfo apInfo);

        public delegate bool CG_Request_Training_Stage_RefreshOKDelegate(HostID remote, RmiContext rmiContext, TrainingStageInfo trainingStageInfo, List<ItemResultInfo> useResultItemInfoList, List<TrainingStageSlotInfo> updatedStageList, int resultDailyResetCount);

        public delegate bool CG_RequestWeekStageGaugeRewardOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> getItemResultInfoList, WeekStageGroupType weekStageGroupType, int groupID, MissionResult missionResult);

        public delegate bool CG_RequestStageEndLogOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_Request_SingleSiege_ExtraStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_SingleSiege_ExtraStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, DestroyClearResult destroyClearResultInfo);

        public delegate bool CG_Request_SingleSiege_ExtraStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, FinalBossStageResult finalBossStageResult, List<int> clearFinalBossMissionIDList, List<int> clearFinalBossVowIDList, RedisFinalBossRankInfo redisFinalBossRankInfo);

        public delegate bool CG_Request_FinalBoss_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_Season_InfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendFinalBossSeasonInfo clientSendFinalBossSeasonInfo, List<ItemResultInfo> clearItemResultInfoList);

        public delegate bool CG_Request_FinalBoss_Season_Rank_InfoOKDelegate(HostID remote, RmiContext rmiContext, List<ClientSendFinalBossRankInfo> clientSendFinalBossRankInfoListTop100, List<ClientSendFinalBossRankHeroInfo> clientSendFinalBossHeroRankInfoList, FinalBossUserRankInfo userFinalBossRankInfo);

        public delegate bool CG_Request_FinalBoss_Score_RewardOKDelegate(HostID remote, RmiContext rmiContext, int seasonID, int bossGroupID, int lastScoreRewardOrder, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult);

        public delegate bool CG_Request_FinalBoss_Stage_Fame_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_FinalBoss_Stage_Fame_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, FinalBossStageResult finalBossStageResult, FameResultInfo oldFameInfo, FameResultInfo newFameInfo);

        public delegate bool CG_Request_FinalBoss_Stage_Fame_Season_Rank_InfoOKDelegate(HostID remote, RmiContext rmiContext, int fameID, FameResultInfo userFameInfo, List<FinalBossFameRankingInfo> finalBossFameRankingInfoList);

        public delegate bool CG_Request_FinalBoss_Stage_Fame_MyScoreInfoOKDelegate(HostID remote, RmiContext rmiContext, int fameID, FameResultInfo nowFameResultInfo);

        public delegate bool CG_Request_GuildBoss_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_GuildBoss_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, GuildRewardResult guildBossClearRewardResult, short currentGuildBossSeq, List<int> clearGuildBossMissionIDList, GuildBossRankPoint updateGuildBossRankPoint);

        public delegate bool CG_Request_GuildBoss_Lobby_InfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendGuildBossLobbyInfo clientSendGuildBossLobbyInfo);

        public delegate bool CG_Request_GuildBoss_Rank_InfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendGuildBossLobbyInfo clientSendGuildBossLobbyInfo, List<ClientSendGuildRankInfo> clientSendGuildRankInfoList, List<GuildWarSelectionInfo> guildWarSelectionInfoList);

        public delegate bool CG_Request_GuildBoss_LastWeek_Rank_InfoOKDelegate(HostID remote, RmiContext rmiContext, GuildRankRedisInfo guildRankInfo, List<ClientSendGuildRankInfo> clientSendGuildRankInfoList);

        public delegate bool CG_Request_GuildBoss_Time_RefreshOKDelegate(HostID remote, RmiContext rmiContext, int guildRankStartRemainSec, int guildRankEndRemainSec);

        public delegate bool CG_Request_DisasterBoss_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_DisasterBoss_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, bool isDestroyDiscovered, DestroyDisasterDicoverInfo disasterDiscoverInfo, bool isFirstClear);

        public delegate bool CG_Request_DisasterBoss_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Week_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Week_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventWeekStageClearResultInfo, UserWeeklyStageEventInfo userWeekStageEventInfo);

        public delegate bool CG_Request_Week_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Tower_Stage_InfoOKDelegate(HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam);

        public delegate bool CG_Request_Tower_Stage_Set_Play_DeckOKDelegate(HostID remote, RmiContext rmiContext, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam);

        public delegate bool CG_Request_Tower_Stage_ResetOKDelegate(HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam);

        public delegate bool CG_Request_Tower_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Tower_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int clearStageID, int recvReardStageID);

        public delegate bool CG_Request_Blitz_EventStage_Lobby_InfoOKDelegate(HostID remote, RmiContext rmiContext, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo, string rejoinData);

        public delegate bool CG_Request_Blitz_EventStage_Squad_ChangeOKDelegate(HostID remote, RmiContext rmiContext, int eventSEQ, BlitzSquadInfo blitzSquadInfo);

        public delegate bool CG_Request_Blitz_EventStage_Squad_InitOKDelegate(HostID remote, RmiContext rmiContext, int eventSEQ, BlitzSquadInfo blitzSquadInfo);

        public delegate bool CG_Request_Blitz_EventStage_Team_ChangeOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_Request_Blitz_EventStage_Main_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Blitz_EventStage_Main_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo);

        public delegate bool CG_Request_Blitz_EventStage_Free_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Blitz_EventStage_Free_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo);

        public delegate bool CG_Request_Blitz_EventStage_Reward_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo);

        public delegate bool CG_Request_Blitz_EventStage_RejoinOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CG_Request_Blitz_EventStage_Rejoin_CancelOKDelegate(HostID remote, RmiContext rmiContext, int eventSEQ, ClientSendBlitzStageEventInfo userBlitzStageEventInfo);

        public delegate bool CG_Request_Free_Once_EventAreaStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo eventAreaFreeOnceStageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Free_Once_EventAreaStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo eventAreaFreeOnceStageClearResultInfo, UserWorldAreaStageEventInfo userWorldAreaStageEventInfo);

        public delegate bool CG_Request_Free_Once_EventAreaStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_NorthMain_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_NorthMain_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo);

        public delegate bool CG_Request_NorthMain_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_North_Free_Once_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_North_Free_Once_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo);

        public delegate bool CG_Request_North_Free_Once_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Another_Free_Once_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Another_Free_Once_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo);

        public delegate bool CG_Request_Another_Free_Once_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Disaster_Tower_Stage_InfoOKDelegate(HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam);

        public delegate bool CG_Request_Disaster_Tower_Stage_Set_Play_DeckOKDelegate(HostID remote, RmiContext rmiContext, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam);

        public delegate bool CG_Request_Disaster_Tower_Stage_ResetOKDelegate(HostID remote, RmiContext rmiContext, TowerStageInfo towerInfo, TowerStageHeroInfo towerStageHeroInfo, UserTeam userTeam);

        public delegate bool CG_Request_Disaster_Tower_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_Disaster_Tower_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, int clearStageID, int recvReardStageID);

        public delegate bool CG_Request_GuildBoss_Off_Season_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo startResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_GuildBoss_Off_Season_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, GuildRewardResult guildBossClearRewardResult, short currentGuildBossSeq, List<int> clearGuildBossMissionIDList, GuildBossOffSeasonRankPoint updateGuildBossOffSeasonRankPoint);

        public delegate bool CG_RequestFinalBossVowUpdateOKDelegate(HostID remote, RmiContext rmiContext, int stageId, List<int> vowIdList);

        public delegate bool CG_Request_DescentBoss_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_DescentBoss_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, EventDescentBossEventStageClearResultInfo resultInfo);

        public delegate bool CG_Request_DescentBoss_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_DescentBoss_Event_Point_RewardOKDelegate(HostID remote, RmiContext rmiContext, DescentBossEventInfoToClientSend info, List<ItemResultInfo> getItemResultInfoList, PaybackEventResultInfo m_paybackEventResultInfo);

        public delegate bool CG_RequestWeekStageCoinOpenOKDelegate(HostID remote, RmiContext rmiContext, int areaID, int remainKeyOpenTimeSec, int remainWeekResetTimeSec, int coinDungeonWeekOpenCount, List<ItemResultInfo> useItemResultInfoList);

        public delegate bool CG_RequestYggdrasilTowerStageStartOKDelegate(HostID remote, RmiContext rmiContext, YggdrasilTowerStageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestYggdrasilTowerStageClearOKDelegate(HostID remote, RmiContext rmiContext, YggdrasilTowerStageClearResultInfo stageClearResultInfo, List<int> clearMissionIDList);

        public delegate bool CG_Request_Yggdrasil_Tower_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_CreatureNest_Season_InfoOKDelegate(HostID remote, RmiContext rmiContext, int selectedGroupID, List<ClientSendCreatureNestStageInfo> ClientSendCreatureNestStageInfoList, int remainWeekResetSec);

        public delegate bool CG_Request_CreatureNest_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, CreatureNestStageStartResultInfo startResultInfo);

        public delegate bool CG_Request_CreatureNest_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, CreatureNestStageClearResultInfo clearResultInfo);

        public delegate bool CG_Request_CreatureNest_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_CreatureNest_InitOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo);

        public delegate bool CG_Request_CreatureNest_Team_SaveOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo);

        public delegate bool CG_Request_CreatureNest_Stage_RejoinOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo, List<CreatureNestStagePassiveInfo> activePassiveSkillInfoList);

        public delegate bool CG_Request_CreatureNest_Stage_Rejoin_CancelOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo);

        public delegate bool CG_Request_CreatureNest_Use_Reset_ItemOKDelegate(HostID remote, RmiContext rmiContext, ItemResultInfo needItemResultInfo, int selectedGroupID, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo, MissionResult missionResult);

        public delegate bool CG_Request_CreatureNest_Challenge_RewardOKDelegate(HostID remote, RmiContext rmiContext, int groupID, ItemResultInfo rewardItemInfo, MissionResult missionResult);

        public delegate bool CG_Request_CreatureNest_Select_GroupOKDelegate(HostID remote, RmiContext rmiContext, int groupId);

        public delegate bool CG_RequestMercenaryListOKDelegate(HostID remote, RmiContext rmiContext, List<MercenaryInfo> mercenaryInfoList);

        public delegate bool CG_RequestMercenaryInfoOKDelegate(HostID remote, RmiContext rmiContext, MercenaryDetailInfo mercenaryDetailInfo);

        public delegate bool CG_RequestWeekStageKeyOpenOKDelegate(HostID remote, RmiContext rmiContext, int areaID, int remainKeyOpenTimeSec, ItemResultInfo useItemResultInfo, MissionResult missionResult);

        public delegate bool CG_RequestEventKOFBritanniaInfoOKDelegate(HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo);

        public delegate bool CG_RequestEventKOFBritanniaStartOKDelegate(HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo, List<ItemResultInfo> useItemResultInfoList);

        public delegate bool CG_RequestEventKOFBritanniaTeamSelectOKDelegate(HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo);

        public delegate bool CG_RequestEventKOFBritanniaTeamChangeOKDelegate(HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo, UserTeamChangeInfo userTeamChangeInfo);

        public delegate bool CG_RequestEventKOFBritanniaStageStartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventresultInfo, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo, ItemResultInfo useItemResultInfo);

        public delegate bool CG_RequestEventKOFBritanniaStageClearOKDelegate(HostID remote, RmiContext rmiContext, KOFBritanniaStageClearResultInfo stageClearResultInfo, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo);

        public delegate bool CG_RequestEventKOFBritanniaStageContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestEventKOFBritanniaRestartOKDelegate(HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo);

        public delegate bool CG_RequestEventKOFBritanniaStageRejoinCancelOKDelegate(HostID remote, RmiContext rmiContext, UserKOFBritanniaEventInfo userKOFBritanniaEventInfo);

        public delegate bool CG_RequestAncientWarInfoOKDelegate(HostID remote, RmiContext rmiContext, UserAncientWarInfo userAnceintWarInfo, AncientWarInfo ancientWarInfo);

        public delegate bool CG_RequestAncientWarRefreshOKDelegate(HostID remote, RmiContext rmiContext, AncientWarInfo ancientWarInfo);

        public delegate bool CG_RequestAncientWarTeamSelectOKDelegate(HostID remote, RmiContext rmiContext, UserAncientWarInfo userAncientWarInfo);

        public delegate bool CG_RequestAncientWarStageStartOKDelegate(HostID remote, RmiContext rmiContext, AncientWarStageStartResultInfo stageStartResultInfo);

        public delegate bool CG_RequestAncientWarStageClearOKDelegate(HostID remote, RmiContext rmiContext, AncientWarStageClearResultInfo stageClearResultInfo);

        public delegate bool CG_RequestAncientWarExtraStageStartOKDelegate(HostID remote, RmiContext rmiContext, AncientWarExtraStageStartResultInfo stageStartResultInfo);

        public delegate bool CG_RequestAncientWarExtraStageClearOKDelegate(HostID remote, RmiContext rmiContext, AncientWarExtraStageClearResultInfo stageClearResultInfo);

        public delegate bool CG_RequestAncientWarRewardOKDelegate(HostID remote, RmiContext rmiContext, byte rewardIndex, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult);

        public delegate bool CG_RequestAncientWarDonationOKDelegate(HostID remote, RmiContext rmiContext, ItemResultInfo useItemResultInfo, UserAncientWarInfo userAnceintWarInfo, AncientWarInfo ancientWarInfo);

        public delegate bool CG_RequestAncientWarRankInfoOKDelegate(HostID remote, RmiContext rmiContext, List<AncientWarUserRankInfo> ancientWarUserRankInfoList, RedisAncientWarUserRankInfo userAncientWarRankInfo);

        public delegate bool CG_RequestEventMazeStageStartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, UserMazeEventInfo userMazeEventInfo);

        public delegate bool CG_RequestEventMazeStageClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, UserMazeEventInfo userMazeEventInfo);

        public delegate bool CG_RequestEventMazeStageRejoinOKDelegate(HostID remote, RmiContext rmiContext, UserMazeEventInfo userMazeEventInfo);

        public delegate bool CG_RequestEventMazeStageRejoinCancelOKDelegate(HostID remote, RmiContext rmiContext, UserMazeEventInfo userMazeEventInfo, ItemResultInfo useItemResultInfo);

        public delegate bool CG_RequestEventMazeStageReChallengeOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, UserMazeEventInfo userMazeEventInfo);

        public delegate bool CG_RequestEventMazeStageReChallengeCancelOKDelegate(HostID remote, RmiContext rmiContext, UserMazeEventInfo userMazeEventInfo);

        public delegate bool CG_Request_Conquest_EventStage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Conquest_EventStage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, UserEventConquesClientSendInfo userEventConquestClientSendInfo);

        public delegate bool CG_Request_Conquest_EventStage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Disaster_Main_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Disaster_Main_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo);

        public delegate bool CG_Request_Disaster_Main_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Disaster_Free_Once_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_Disaster_Free_Once_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo);

        public delegate bool CG_Request_Disaster_Free_Once_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_Request_CreatureColosseum_Season_InfoOKDelegate(HostID remote, RmiContext rmiContext, List<ClientSendCreatureNestStageInfo> ClientSendCreatureNestStageInfoList, CreatureNestColosseumSeasonInfo seasonInfo);

        public delegate bool CG_Request_CreatureColosseum_Stage_StartOKDelegate(HostID remote, RmiContext rmiContext, CreatureNestStageStartResultInfo startResultInfo);

        public delegate bool CG_Request_CreatureColosseum_Stage_ClearOKDelegate(HostID remote, RmiContext rmiContext, CreatureNestStageClearResultInfo clearResultInfo);

        public delegate bool CG_Request_CreatureColosseum_Stage_ContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_Request_CreatureColosseum_InitOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo);

        public delegate bool CG_Request_CreatureColosseum_Team_SaveOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo clientCreatureNestInfo);

        public delegate bool CG_Request_CreatureColosseum_Stage_RejoinOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo, List<CreatureNestStagePassiveInfo> activePassiveSkillInfoList);

        public delegate bool CG_Request_CreatureColosseum_Stage_Rejoin_CancelOKDelegate(HostID remote, RmiContext rmiContext, ClientSendCreatureNestStageInfo ClientSendCreatureNestStageInfo);

        public delegate bool CG_RequestDemonLordStageOpenOKDelegate(HostID remote, RmiContext rmiContext, UserDemonLordInfoToClientSend userDemonLordInfo);

        public delegate bool CG_RequestDemonLordStageStartOKDelegate(HostID remote, RmiContext rmiContext, StageStartResultInfo stageStartResultInfo, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_RequestDemonLordStageClearOKDelegate(HostID remote, RmiContext rmiContext, StageClearResultInfo stageClearResultInfo, UserDemonLordInfoToClientSend userDemonLordInfo);

        public delegate bool CG_RequestDemonLordStageContinueOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, short continueCount, PaybackEventResultInfo paybackEventResultInfo);

        public delegate bool CG_RequestDemonLordStageCoinOpenOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, UserDemonLordInfoToClientSend userDemonLordInfo, MissionResult missionResult);
    }
}