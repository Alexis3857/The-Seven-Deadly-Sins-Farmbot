using Nettention.Proud;

namespace CommonPacket
{
    public partial class Marshaler : Nettention.Proud.Marshaler
    {
        public static void Read(Message msg, out RmiID en)
        {
            msg.Read(out en);
        }

        public static void Read(Message msg, out ADViewContentType en)
        {
            byte num;
            msg.Read(out num);
            en = (ADViewContentType)num;
        }

        public static void Read(Message msg, out List<ADViewContentType> list)
        {
            list = new List<ADViewContentType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ADViewContentType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AICustomizingActionInfo ty)
        {
            ty = new AICustomizingActionInfo();
            Marshaler.Read(msg, out ty.priority);
            Marshaler.Read(msg, out ty.detailInfo);
        }

        public static void Read(Message msg, out List<AICustomizingActionInfo> list)
        {
            list = new List<AICustomizingActionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AICustomizingActionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AICustomizingDetailInfo ty)
        {
            ty = new AICustomizingDetailInfo();
            Marshaler.Read(msg, out ty.costID);
            Marshaler.Read(msg, out ty.skillID);
            Marshaler.Read(msg, out ty.targetID);
            Marshaler.Read(msg, out ty.allowDuplicationID);
            Marshaler.Read(msg, out ty.conditionIDList);
            Marshaler.Read(msg, out ty.moveID);
            Marshaler.Read(msg, out ty.moveConditionID);
        }

        public static void Read(Message msg, out List<AICustomizingDetailInfo> list)
        {
            list = new List<AICustomizingDetailInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AICustomizingDetailInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AICustomizingGroupInfo ty)
        {
            ty = new AICustomizingGroupInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.priority);
            Marshaler.Read(msg, out ty.actionInfoList);
        }

        public static void Read(Message msg, out List<AICustomizingGroupInfo> list)
        {
            list = new List<AICustomizingGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AICustomizingGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AICustomizingInfo ty)
        {
            ty = new AICustomizingInfo();
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.iconID);
            Marshaler.Read(msg, out ty.isDefault);
            Marshaler.Read(msg, out ty.groupInfoList);
        }

        public static void Read(Message msg, out List<AICustomizingInfo> list)
        {
            list = new List<AICustomizingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AICustomizingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarAreaInfo ty)
        {
            ty = new AncientWarAreaInfo();
            Marshaler.Read(msg, out ty.areaId);
            Marshaler.Read(msg, out ty.goddessScore);
            Marshaler.Read(msg, out ty.demonScore);
        }

        public static void Read(Message msg, out List<AncientWarAreaInfo> list)
        {
            list = new List<AncientWarAreaInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarAreaInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarExtraStageClearRequestInfo ty)
        {
            ty = new AncientWarExtraStageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageClearRequestInfo);
            Marshaler.Read(msg, out ty.ingameBattlePointRequest);
        }

        public static void Read(Message msg, out List<AncientWarExtraStageClearRequestInfo> list)
        {
            list = new List<AncientWarExtraStageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarExtraStageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarExtraStageClearResultInfo ty)
        {
            ty = new AncientWarExtraStageClearResultInfo();
            Marshaler.Read(msg, out ty.stageClearResultInfo);
            Marshaler.Read(msg, out ty.stageScoreInfo);
            Marshaler.Read(msg, out ty.clearMissionIdList);
            Marshaler.Read(msg, out ty.userAncientWarInfo);
        }

        public static void Read(Message msg, out List<AncientWarExtraStageClearResultInfo> list)
        {
            list = new List<AncientWarExtraStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarExtraStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarExtraStageStartRequestInfo ty)
        {
            ty = new AncientWarExtraStageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageStartRequestInfo);
        }

        public static void Read(Message msg, out List<AncientWarExtraStageStartRequestInfo> list)
        {
            list = new List<AncientWarExtraStageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarExtraStageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarExtraStageStartResultInfo ty)
        {
            ty = new AncientWarExtraStageStartResultInfo();
            Marshaler.Read(msg, out ty.stageStartResultInfo);
            Marshaler.Read(msg, out ty.useKeyItemResultInfo);
        }

        public static void Read(Message msg, out List<AncientWarExtraStageStartResultInfo> list)
        {
            list = new List<AncientWarExtraStageStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarExtraStageStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarInfo ty)
        {
            ty = new AncientWarInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.goddessScore);
            Marshaler.Read(msg, out ty.demonScore);
            Marshaler.Read(msg, out ty.areaInfoList);
        }

        public static void Read(Message msg, out List<AncientWarInfo> list)
        {
            list = new List<AncientWarInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarStageClearRequestInfo ty)
        {
            ty = new AncientWarStageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageClearRequestInfo);
            Marshaler.Read(msg, out ty.ingameBattlePointRequest);
        }

        public static void Read(Message msg, out List<AncientWarStageClearRequestInfo> list)
        {
            list = new List<AncientWarStageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarStageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarStageClearResultInfo ty)
        {
            ty = new AncientWarStageClearResultInfo();
            Marshaler.Read(msg, out ty.stageClearResultInfo);
            Marshaler.Read(msg, out ty.stageScoreInfo);
            Marshaler.Read(msg, out ty.clearMissionIdList);
            Marshaler.Read(msg, out ty.userAncientWarInfo);
        }

        public static void Read(Message msg, out List<AncientWarStageClearResultInfo> list)
        {
            list = new List<AncientWarStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarStageScoreInfo ty)
        {
            ty = new AncientWarStageScoreInfo();
            Marshaler.Read(msg, out ty.boostValue);
            Marshaler.Read(msg, out ty.clearScore);
            Marshaler.Read(msg, out ty.damageScore);
            Marshaler.Read(msg, out ty.missionScore);
            Marshaler.Read(msg, out ty.lifeScore);
            Marshaler.Read(msg, out ty.totalScore);
        }

        public static void Read(Message msg, out List<AncientWarStageScoreInfo> list)
        {
            list = new List<AncientWarStageScoreInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarStageScoreInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarStageStartRequestInfo ty)
        {
            ty = new AncientWarStageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageStartRequestInfo);
        }

        public static void Read(Message msg, out List<AncientWarStageStartRequestInfo> list)
        {
            list = new List<AncientWarStageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarStageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarStageStartResultInfo ty)
        {
            ty = new AncientWarStageStartResultInfo();
            Marshaler.Read(msg, out ty.stageStartResultInfo);
        }

        public static void Read(Message msg, out List<AncientWarStageStartResultInfo> list)
        {
            list = new List<AncientWarStageStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarStageStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarStageType en)
        {
            byte num;
            msg.Read(out num);
            en = (AncientWarStageType)num;
        }

        public static void Read(Message msg, out List<AncientWarStageType> list)
        {
            list = new List<AncientWarStageType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarStageType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarState en)
        {
            byte num;
            msg.Read(out num);
            en = (AncientWarState)num;
        }

        public static void Read(Message msg, out List<AncientWarState> list)
        {
            list = new List<AncientWarState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarTeamType en)
        {
            byte num;
            msg.Read(out num);
            en = (AncientWarTeamType)num;
        }

        public static void Read(Message msg, out List<AncientWarTeamType> list)
        {
            list = new List<AncientWarTeamType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarTeamType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AncientWarUserRankInfo ty)
        {
            ty = new AncientWarUserRankInfo();
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.redisAncientWarUserRankInfo);
        }

        public static void Read(Message msg, out List<AncientWarUserRankInfo> list)
        {
            list = new List<AncientWarUserRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AncientWarUserRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AnotherQuestClearResultInfo ty)
        {
            ty = new AnotherQuestClearResultInfo();
            Marshaler.Read(msg, out ty.questID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.removeItemResultInfoList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.apRewardInfoList);
        }

        public static void Read(Message msg, out List<AnotherQuestClearResultInfo> list)
        {
            list = new List<AnotherQuestClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AnotherQuestClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out APInfo ty)
        {
            ty = new APInfo();
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.count);
            Marshaler.Read(msg, out ty.updateTime);
            Marshaler.Read(msg, out ty.remainSecondToRecharge);
        }

        public static void Read(Message msg, out List<APInfo> list)
        {
            list = new List<APInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                APInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ApRewardInfo ty)
        {
            ty = new ApRewardInfo();
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.getApCount);
        }

        public static void Read(Message msg, out List<ApRewardInfo> list)
        {
            list = new List<ApRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ApRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out APType en)
        {
            byte num;
            msg.Read(out num);
            en = (APType)num;
        }

        public static void Read(Message msg, out List<APType> list)
        {
            list = new List<APType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                APType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AreaType en)
        {
            int num;
            msg.Read(out num);
            en = (AreaType)num;
        }

        public static void Read(Message msg, out List<AreaType> list)
        {
            list = new List<AreaType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AreaType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaAllRewardResultInfo ty)
        {
            ty = new ArenaAllRewardResultInfo();
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumber);
            Marshaler.Read(msg, out ty.rankingPoint);
            Marshaler.Read(msg, out ty.rewardRank);
            Marshaler.Read(msg, out ty.totalPlayCount);
            Marshaler.Read(msg, out ty.totalWinCount);
            Marshaler.Read(msg, out ty.attackPlayCount);
            Marshaler.Read(msg, out ty.attackWinCount);
            Marshaler.Read(msg, out ty.defencePlayCount);
            Marshaler.Read(msg, out ty.defenceWinCount);
            Marshaler.Read(msg, out ty.rewardItemList);
            Marshaler.Read(msg, out ty.rewardSeasonPoint);
            Marshaler.Read(msg, out ty.totalRankCount);
            Marshaler.Read(msg, out ty.rewardPvpLimitSeasonId);
        }

        public static void Read(Message msg, out List<ArenaAllRewardResultInfo> list)
        {
            list = new List<ArenaAllRewardResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaAllRewardResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaDecisionHistoryData ty)
        {
            ty = new ArenaDecisionHistoryData();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.battleType);
            Marshaler.Read(msg, out ty.battleResult);
            Marshaler.Read(msg, out ty.changePoint);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.targetUSN);
            Marshaler.Read(msg, out ty.targetNickname);
            Marshaler.Read(msg, out ty.targetRankLevel);
            Marshaler.Read(msg, out ty.targetMainHeroID);
            Marshaler.Read(msg, out ty.targetGuildName);
            Marshaler.Read(msg, out ty.targetGuildIconID);
            Marshaler.Read(msg, out ty.targetGuildSubIconID);
            Marshaler.Read(msg, out ty.targetGuildBackgroundID);
        }

        public static void Read(Message msg, out List<ArenaDecisionHistoryData> list)
        {
            list = new List<ArenaDecisionHistoryData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaDecisionHistoryData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaDecisionMatchingData ty)
        {
            ty = new ArenaDecisionMatchingData();
            Marshaler.Read(msg, out ty.targetUSN);
            Marshaler.Read(msg, out ty.targetNickname);
            Marshaler.Read(msg, out ty.targetRankExp);
            Marshaler.Read(msg, out ty.targetMainHeroID);
            Marshaler.Read(msg, out ty.targetGuildName);
            Marshaler.Read(msg, out ty.targetGuildIconID);
            Marshaler.Read(msg, out ty.targetGuildSubIconID);
            Marshaler.Read(msg, out ty.targetGuildBackgroundID);
            Marshaler.Read(msg, out ty.matchingType);
        }

        public static void Read(Message msg, out List<ArenaDecisionMatchingData> list)
        {
            list = new List<ArenaDecisionMatchingData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaDecisionMatchingData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaDecisionMatchingSimpleInfo ty)
        {
            ty = new ArenaDecisionMatchingSimpleInfo();
            Marshaler.Read(msg, out ty.arenaRealTimePvpOppUserInfo);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
        }

        public static void Read(Message msg, out List<ArenaDecisionMatchingSimpleInfo> list)
        {
            list = new List<ArenaDecisionMatchingSimpleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaDecisionMatchingSimpleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaDecisionMatchingType en)
        {
            byte num;
            msg.Read(out num);
            en = (ArenaDecisionMatchingType)num;
        }

        public static void Read(Message msg, out List<ArenaDecisionMatchingType> list)
        {
            list = new List<ArenaDecisionMatchingType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaDecisionMatchingType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueEventType en)
        {
            byte num;
            msg.Read(out num);
            en = (ArenaLeagueEventType)num;
        }

        public static void Read(Message msg, out List<ArenaLeagueEventType> list)
        {
            list = new List<ArenaLeagueEventType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueEventType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueGrade en)
        {
            byte num;
            msg.Read(out num);
            en = (ArenaLeagueGrade)num;
        }

        public static void Read(Message msg, out List<ArenaLeagueGrade> list)
        {
            list = new List<ArenaLeagueGrade>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueGrade item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueInfo ty)
        {
            ty = new ArenaLeagueInfo();
            Marshaler.Read(msg, out ty.leagueID);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumer);
            Marshaler.Read(msg, out ty.userCount);
            Marshaler.Read(msg, out ty.namePrefixID);
            Marshaler.Read(msg, out ty.namePostfixID);
        }

        public static void Read(Message msg, out List<ArenaLeagueInfo> list)
        {
            list = new List<ArenaLeagueInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueLobbyInfo ty)
        {
            ty = new ArenaLeagueLobbyInfo();
            Marshaler.Read(msg, out ty.leagueUserInfo);
            Marshaler.Read(msg, out ty.matchInfoList);
            Marshaler.Read(msg, out ty.missionInfo);
            Marshaler.Read(msg, out ty.shopBuyInfoList);
            Marshaler.Read(msg, out ty.rewardItemList);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.prevGrade);
            Marshaler.Read(msg, out ty.prevGradeNumber);
        }

        public static void Read(Message msg, out List<ArenaLeagueLobbyInfo> list)
        {
            list = new List<ArenaLeagueLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueMatchInfo ty)
        {
            ty = new ArenaLeagueMatchInfo();
            Marshaler.Read(msg, out ty.oppUserInfo);
            Marshaler.Read(msg, out ty.matchResult);
        }

        public static void Read(Message msg, out List<ArenaLeagueMatchInfo> list)
        {
            list = new List<ArenaLeagueMatchInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueMatchInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueMatchRecord ty)
        {
            ty = new ArenaLeagueMatchRecord();
            Marshaler.Read(msg, out ty.oppUSN);
            Marshaler.Read(msg, out ty.oppNickName);
            Marshaler.Read(msg, out ty.oppExp);
            Marshaler.Read(msg, out ty.oppHeroID);
            Marshaler.Read(msg, out ty.matchResult);
            Marshaler.Read(msg, out ty.attack);
            Marshaler.Read(msg, out ty.myRankPointChangeValue);
            Marshaler.Read(msg, out ty.recordTime);
        }

        public static void Read(Message msg, out List<ArenaLeagueMatchRecord> list)
        {
            list = new List<ArenaLeagueMatchRecord>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueMatchRecord item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueMissionInfo ty)
        {
            ty = new ArenaLeagueMissionInfo();
            Marshaler.Read(msg, out ty.missionClearCount);
            Marshaler.Read(msg, out ty.matchCount);
            Marshaler.Read(msg, out ty.winCount);
            Marshaler.Read(msg, out ty.winningStreakCount);
            Marshaler.Read(msg, out ty.getRewardMissionIDList);
        }

        public static void Read(Message msg, out List<ArenaLeagueMissionInfo> list)
        {
            list = new List<ArenaLeagueMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueNotifyResult ty)
        {
            ty = new ArenaLeagueNotifyResult();
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.leagueInfo);
            Marshaler.Read(msg, out ty.matchInfoList);
        }

        public static void Read(Message msg, out List<ArenaLeagueNotifyResult> list)
        {
            list = new List<ArenaLeagueNotifyResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueNotifyResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueOpponentInfo ty)
        {
            ty = new ArenaLeagueOpponentInfo();
            Marshaler.Read(msg, out ty.userInfo);
            Marshaler.Read(msg, out ty.teamInfo);
        }

        public static void Read(Message msg, out List<ArenaLeagueOpponentInfo> list)
        {
            list = new List<ArenaLeagueOpponentInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueOpponentInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueOpponentUserInfo ty)
        {
            ty = new ArenaLeagueOpponentUserInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.leagueSeq);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumber);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.winCount);
            Marshaler.Read(msg, out ty.playCount);
            Marshaler.Read(msg, out ty.totalWinCount);
            Marshaler.Read(msg, out ty.totalPlayCount);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<ArenaLeagueOpponentUserInfo> list)
        {
            list = new List<ArenaLeagueOpponentUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueOpponentUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaLeagueUserInfo ty)
        {
            ty = new ArenaLeagueUserInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.leagueSeq);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumber);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.leagueID);
            Marshaler.Read(msg, out ty.namePrefixID);
            Marshaler.Read(msg, out ty.namePostfixID);
            Marshaler.Read(msg, out ty.winningStreak);
            Marshaler.Read(msg, out ty.winCount);
            Marshaler.Read(msg, out ty.playCount);
            Marshaler.Read(msg, out ty.totalWinCount);
            Marshaler.Read(msg, out ty.totalPlayCount);
            Marshaler.Read(msg, out ty.remainSecToBuffEnd);
            Marshaler.Read(msg, out ty.remainSecToFreeRefresh);
            Marshaler.Read(msg, out ty.remainSecToLeagueEnd);
            Marshaler.Read(msg, out ty.remainSecToShopRefresh);
            Marshaler.Read(msg, out ty.isPromotion);
            Marshaler.Read(msg, out ty.promotionWinCount);
            Marshaler.Read(msg, out ty.promotionPlayCount);
            Marshaler.Read(msg, out ty.isRewardReceived);
        }

        public static void Read(Message msg, out List<ArenaLeagueUserInfo> list)
        {
            list = new List<ArenaLeagueUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaLeagueUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRankingBattleEndResult ty)
        {
            ty = new ArenaRankingBattleEndResult();
            Marshaler.Read(msg, out ty.arenaRankingLobbyInfo);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.getRankPoint);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.getCoinItemResultInfo);
            Marshaler.Read(msg, out ty.getCoinCount);
            Marshaler.Read(msg, out ty.increaseCoinCountByBuff);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.isFirstPVP);
            Marshaler.Read(msg, out ty.usedFoodID);
            Marshaler.Read(msg, out ty.adViewRouletteInfo);
            Marshaler.Read(msg, out ty.pvpWinCountEventInfoList);
            Marshaler.Read(msg, out ty.isAbuseDetect);
        }

        public static void Read(Message msg, out List<ArenaRankingBattleEndResult> list)
        {
            list = new List<ArenaRankingBattleEndResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRankingBattleEndResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRankingJoinStatus en)
        {
            byte num;
            msg.Read(out num);
            en = (ArenaRankingJoinStatus)num;
        }

        public static void Read(Message msg, out List<ArenaRankingJoinStatus> list)
        {
            list = new List<ArenaRankingJoinStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRankingJoinStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRankingLobbyInfo ty)
        {
            ty = new ArenaRankingLobbyInfo();
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.attackPlayCount);
            Marshaler.Read(msg, out ty.attackWinCount);
            Marshaler.Read(msg, out ty.defencePlayCount);
            Marshaler.Read(msg, out ty.defenceWinCount);
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.joinStatus);
            Marshaler.Read(msg, out ty.arenaRankingRewardInfo);
            Marshaler.Read(msg, out ty.seasonPvpPassiveID);
            Marshaler.Read(msg, out ty.seasonPvpModeID);
        }

        public static void Read(Message msg, out List<ArenaRankingLobbyInfo> list)
        {
            list = new List<ArenaRankingLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRankingLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpBattleEndResult ty)
        {
            ty = new ArenaRealTimePvpBattleEndResult();
            Marshaler.Read(msg, out ty.arenaRealTimePvpLobbyInfo);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.getRankPoint);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.getCoinItemResultInfo);
            Marshaler.Read(msg, out ty.getCoinCount);
            Marshaler.Read(msg, out ty.increaseCoinCountByBuff);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.isFirstPVP);
            Marshaler.Read(msg, out ty.usedFoodID);
            Marshaler.Read(msg, out ty.adViewRouletteInfo);
            Marshaler.Read(msg, out ty.pvpWinCountEventInfoList);
            Marshaler.Read(msg, out ty.isAbuseDetect);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpBattleEndResult> list)
        {
            list = new List<ArenaRealTimePvpBattleEndResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpBattleEndResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpBattleStartResult ty)
        {
            ty = new ArenaRealTimePvpBattleStartResult();
            Marshaler.Read(msg, out ty.arenaRealTimePvpOppUserInfo);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.isCPU);
            Marshaler.Read(msg, out ty.firstAttackUSN);
            Marshaler.Read(msg, out ty.changeRankPoint);
            Marshaler.Read(msg, out ty.getCoinItemResultInfo);
            Marshaler.Read(msg, out ty.isBuffUsed);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.useItemResultInfo);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.userPlayCountEventInfoList);
            Marshaler.Read(msg, out ty.isPlacementMatching);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpBattleStartResult> list)
        {
            list = new List<ArenaRealTimePvpBattleStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpBattleStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePVPClearRequest ty)
        {
            ty = new ArenaRealTimePVPClearRequest();
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.targetSkinStatInfoList);
            Marshaler.Read(msg, out ty.missionRequest);
        }

        public static void Read(Message msg, out List<ArenaRealTimePVPClearRequest> list)
        {
            list = new List<ArenaRealTimePVPClearRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePVPClearRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpGameStartResultInfo ty)
        {
            ty = new ArenaRealTimePvpGameStartResultInfo();
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.getCoinItemResultInfo);
            Marshaler.Read(msg, out ty.useItemResultInfo);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.userPlayCountEventInfoList);
            Marshaler.Read(msg, out ty.foodBuffInfo);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpGameStartResultInfo> list)
        {
            list = new List<ArenaRealTimePvpGameStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpGameStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpInfo ty)
        {
            ty = new ArenaRealTimePvpInfo();
            Marshaler.Read(msg, out ty.needJoin);
            Marshaler.Read(msg, out ty.arenaRealTimePvpRemainSec);
            Marshaler.Read(msg, out ty.arenaRealTimeDecisionRemainSec);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.prevGrade);
            Marshaler.Read(msg, out ty.prevGradeNumber);
            Marshaler.Read(msg, out ty.placementMatchList);
            Marshaler.Read(msg, out ty.arenaRealTimePvpLimitHeroCostRemainTimeSec);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpInfo> list)
        {
            list = new List<ArenaRealTimePvpInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpLastRankerStatueInfo ty)
        {
            ty = new ArenaRealTimePvpLastRankerStatueInfo();
            Marshaler.Read(msg, out ty.lastRank);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.skinCostumeGroup);
            Marshaler.Read(msg, out ty.weaponCostumeGroup);
            Marshaler.Read(msg, out ty.headCostumeGroup);
            Marshaler.Read(msg, out ty.isHelmetOpen);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBackgroundID);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumber);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpLastRankerStatueInfo> list)
        {
            list = new List<ArenaRealTimePvpLastRankerStatueInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpLastRankerStatueInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpLeagueInfo ty)
        {
            ty = new ArenaRealTimePvpLeagueInfo();
            Marshaler.Read(msg, out ty.leagueID);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumber);
            Marshaler.Read(msg, out ty.userCount);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpLeagueInfo> list)
        {
            list = new List<ArenaRealTimePvpLeagueInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpLeagueInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePVPLimitHeroCost ty)
        {
            ty = new ArenaRealTimePVPLimitHeroCost();
            Marshaler.Read(msg, out ty.heroId);
            Marshaler.Read(msg, out ty.cost);
        }

        public static void Read(Message msg, out List<ArenaRealTimePVPLimitHeroCost> list)
        {
            list = new List<ArenaRealTimePVPLimitHeroCost>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePVPLimitHeroCost item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpLimitMyRankInfo ty)
        {
            ty = new ArenaRealTimePvpLimitMyRankInfo();
            Marshaler.Read(msg, out ty.myRank);
            Marshaler.Read(msg, out ty.totalRankCount);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpLimitMyRankInfo> list)
        {
            list = new List<ArenaRealTimePvpLimitMyRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpLimitMyRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpLobbyInfo ty)
        {
            ty = new ArenaRealTimePvpLobbyInfo();
            Marshaler.Read(msg, out ty.arenaRealTimeUserInfo);
            Marshaler.Read(msg, out ty.arenaRealTimePvpInfo);
            Marshaler.Read(msg, out ty.arenaRealTimePvpRewardInfo);
            Marshaler.Read(msg, out ty.decisionFirstFlag);
            Marshaler.Read(msg, out ty.seasonPvpPassiveID);
            Marshaler.Read(msg, out ty.seasonPvpModeID);
            Marshaler.Read(msg, out ty.lowerLeagueTableID);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpLobbyInfo> list)
        {
            list = new List<ArenaRealTimePvpLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpOpponentUserInfo ty)
        {
            ty = new ArenaRealTimePvpOpponentUserInfo();
            //Marshaler.Read(msg, out ty.beforeOppUSN);
            //Marshaler.Read(msg, out ty.leagueID);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.leagueSeq);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumber);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.totalWinCount);
            Marshaler.Read(msg, out ty.totalPlayCount);
            Marshaler.Read(msg, out ty.totalDefencePlayCount);
            Marshaler.Read(msg, out ty.lastRank);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.isNpcData);
            Marshaler.Read(msg, out ty.playTitleID);
            Marshaler.Read(msg, out ty.attackPlayCount);
            Marshaler.Read(msg, out ty.attackWinCount);
            Marshaler.Read(msg, out ty.defencePlayCount);
            Marshaler.Read(msg, out ty.defenceWinCount);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpOpponentUserInfo> list)
        {
            list = new List<ArenaRealTimePvpOpponentUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpOpponentUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpRankerBattleStartResult ty)
        {
            ty = new ArenaRealTimePvpRankerBattleStartResult();
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.oppUserInfo);
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.isBuffUsed);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpRankerBattleStartResult> list)
        {
            list = new List<ArenaRealTimePvpRankerBattleStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpRankerBattleStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpRewardInfo ty)
        {
            ty = new ArenaRealTimePvpRewardInfo();
            Marshaler.Read(msg, out ty.rewardReceived);
            Marshaler.Read(msg, out ty.rewardRank);
            Marshaler.Read(msg, out ty.rewardItemList);
            Marshaler.Read(msg, out ty.rewardSeasonPoint);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpRewardInfo> list)
        {
            list = new List<ArenaRealTimePvpRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvpShopBuyInfo ty)
        {
            ty = new ArenaRealTimePvpShopBuyInfo();
            Marshaler.Read(msg, out ty.shopID);
            Marshaler.Read(msg, out ty.buyCount);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvpShopBuyInfo> list)
        {
            list = new List<ArenaRealTimePvpShopBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvpShopBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimePvp_LoginInfo ty)
        {
            ty = new ArenaRealTimePvp_LoginInfo();
            Marshaler.Read(msg, out ty.upperGrade);
            Marshaler.Read(msg, out ty.upperGradeNumber);
            Marshaler.Read(msg, out ty.upperRankPoint);
            Marshaler.Read(msg, out ty.upperTotalWinCount);
            Marshaler.Read(msg, out ty.upperTotalPlayCount);
            Marshaler.Read(msg, out ty.upperJoinAble);
            Marshaler.Read(msg, out ty.upperRewardAble);
            Marshaler.Read(msg, out ty.lowerGrade);
            Marshaler.Read(msg, out ty.lowerGradeNumber);
            Marshaler.Read(msg, out ty.lowerRankPoint);
            Marshaler.Read(msg, out ty.lowerTotalWinCount);
            Marshaler.Read(msg, out ty.lowerTotalPlayCount);
            Marshaler.Read(msg, out ty.lowerJoinAble);
            Marshaler.Read(msg, out ty.lowerRewardAble);
            Marshaler.Read(msg, out ty.arenaRealTimePvpLowerRemainSEC);
            Marshaler.Read(msg, out ty.arenaRealTimePvpRemainSEC);
            Marshaler.Read(msg, out ty.arenaRealTimedecisionRemainSEC);
            Marshaler.Read(msg, out ty.pvpSeasonRewardAble);
            Marshaler.Read(msg, out ty.pvpSeasonID);
            Marshaler.Read(msg, out ty.rankingRewardAble);
            Marshaler.Read(msg, out ty.rankingJoinAble);
            Marshaler.Read(msg, out ty.limitRankPoint);
            Marshaler.Read(msg, out ty.limitTotalWinCount);
            Marshaler.Read(msg, out ty.limitTotalPlayCount);
            Marshaler.Read(msg, out ty.limitJoinAble);
            Marshaler.Read(msg, out ty.limitRewardAble);
            Marshaler.Read(msg, out ty.arenaRealTimePvpLimitRemainSec);
        }

        public static void Read(Message msg, out List<ArenaRealTimePvp_LoginInfo> list)
        {
            list = new List<ArenaRealTimePvp_LoginInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimePvp_LoginInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaRealTimeUserInfo ty)
        {
            ty = new ArenaRealTimeUserInfo();
            Marshaler.Read(msg, out ty.arenaRealTimePvpRankPoint);
            Marshaler.Read(msg, out ty.arenaRealTimePvpGrade);
            Marshaler.Read(msg, out ty.arenaRealTimePvpGradeNumber);
            Marshaler.Read(msg, out ty.arenaRealTimePvpLeagueID);
            Marshaler.Read(msg, out ty.totalWinCount);
            Marshaler.Read(msg, out ty.totalPlayCount);
            Marshaler.Read(msg, out ty.realTimePvpPromotion);
            Marshaler.Read(msg, out ty.realTimePvpPromotionPlayCount);
            Marshaler.Read(msg, out ty.realTimePvpPromotionWinCount);
            Marshaler.Read(msg, out ty.lastRank);
            Marshaler.Read(msg, out ty.lastDecisionRankPoint);
            Marshaler.Read(msg, out ty.attackWinCount);
            Marshaler.Read(msg, out ty.attackTotalPlayCount);
            Marshaler.Read(msg, out ty.defenceWinCount);
            Marshaler.Read(msg, out ty.defenceTotalPlayCount);
            Marshaler.Read(msg, out ty.winStreak);
        }

        public static void Read(Message msg, out List<ArenaRealTimeUserInfo> list)
        {
            list = new List<ArenaRealTimeUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaRealTimeUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashBattleEndRequest ty)
        {
            ty = new ArenaSmashBattleEndRequest();
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.opponentUSN);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.opponentSkinStatInfoList);
            Marshaler.Read(msg, out ty.missionRequest);
            Marshaler.Read(msg, out ty.isAutoPlay);
            Marshaler.Read(msg, out ty.turnCount);
        }

        public static void Read(Message msg, out List<ArenaSmashBattleEndRequest> list)
        {
            list = new List<ArenaSmashBattleEndRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashBattleEndRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashBattleEndResult ty)
        {
            ty = new ArenaSmashBattleEndResult();
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.userWin);
            Marshaler.Read(msg, out ty.opponentWin);
            Marshaler.Read(msg, out ty.isMatchPlay);
            Marshaler.Read(msg, out ty.arenaSmashUserInfo);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.adViewRouletteInfo);
        }

        public static void Read(Message msg, out List<ArenaSmashBattleEndResult> list)
        {
            list = new List<ArenaSmashBattleEndResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashBattleEndResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashBattleStartRequest ty)
        {
            ty = new ArenaSmashBattleStartRequest();
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.opponentUSN);
        }

        public static void Read(Message msg, out List<ArenaSmashBattleStartRequest> list)
        {
            list = new List<ArenaSmashBattleStartRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashBattleStartRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashBattleStartResult ty)
        {
            ty = new ArenaSmashBattleStartResult();
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.foodBuffItemID);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.userPlayCountEventInfoList);
        }

        public static void Read(Message msg, out List<ArenaSmashBattleStartResult> list)
        {
            list = new List<ArenaSmashBattleStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashBattleStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashLobbyInfo ty)
        {
            ty = new ArenaSmashLobbyInfo();
            Marshaler.Read(msg, out ty.arenaSmashUserInfo);
            Marshaler.Read(msg, out ty.needJoin);
            Marshaler.Read(msg, out ty.needTeamSetting);
            Marshaler.Read(msg, out ty.weeklyResetStartRaminSec);
            Marshaler.Read(msg, out ty.weeklyResetEndRemainSec);
            Marshaler.Read(msg, out ty.pvpModeList);
        }

        public static void Read(Message msg, out List<ArenaSmashLobbyInfo> list)
        {
            list = new List<ArenaSmashLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashOpponentInfo ty)
        {
            ty = new ArenaSmashOpponentInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.matchResult);
        }

        public static void Read(Message msg, out List<ArenaSmashOpponentInfo> list)
        {
            list = new List<ArenaSmashOpponentInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashOpponentInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashRankInfo ty)
        {
            ty = new ArenaSmashRankInfo();
            Marshaler.Read(msg, out ty.rankInfo);
            Marshaler.Read(msg, out ty.teamInfoList);
        }

        public static void Read(Message msg, out List<ArenaSmashRankInfo> list)
        {
            list = new List<ArenaSmashRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashRecordInfo ty)
        {
            ty = new ArenaSmashRecordInfo();
            Marshaler.Read(msg, out ty.recordSN);
            Marshaler.Read(msg, out ty.isPlayer);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.prevRank);
            Marshaler.Read(msg, out ty.opponentUSN);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
        }

        public static void Read(Message msg, out List<ArenaSmashRecordInfo> list)
        {
            list = new List<ArenaSmashRecordInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashRecordInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashShopInfo ty)
        {
            ty = new ArenaSmashShopInfo();
            Marshaler.Read(msg, out ty.shopGrade);
            Marshaler.Read(msg, out ty.shopRewardID);
            Marshaler.Read(msg, out ty.shopRewardPoint);
        }

        public static void Read(Message msg, out List<ArenaSmashShopInfo> list)
        {
            list = new List<ArenaSmashShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ArenaSmashUserInfo ty)
        {
            ty = new ArenaSmashUserInfo();
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.winRewardPoint);
            Marshaler.Read(msg, out ty.bestRank);
            Marshaler.Read(msg, out ty.bestReward);
            Marshaler.Read(msg, out ty.bestResetRaminSec);
            Marshaler.Read(msg, out ty.opponentListRemainSec);
            Marshaler.Read(msg, out ty.opponentListExpireRemainSec);
        }

        public static void Read(Message msg, out List<ArenaSmashUserInfo> list)
        {
            list = new List<ArenaSmashUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ArenaSmashUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AttendanceResult ty)
        {
            ty = new AttendanceResult();
            Marshaler.Read(msg, out ty.attendanceInfo);
            Marshaler.Read(msg, out ty.rewardItemInfoList);
            Marshaler.Read(msg, out ty.apRewardInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.preRegistationRewardList);
        }

        public static void Read(Message msg, out List<AttendanceResult> list)
        {
            list = new List<AttendanceResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AttendanceResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out AttendanceType en)
        {
            byte num;
            msg.Read(out num);
            en = (AttendanceType)num;
        }

        public static void Read(Message msg, out List<AttendanceType> list)
        {
            list = new List<AttendanceType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                AttendanceType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BalloonInfo ty)
        {
            ty = new BalloonInfo();
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.rewardId);
            Marshaler.Read(msg, out ty.isPop);
        }

        public static void Read(Message msg, out List<BalloonInfo> list)
        {
            list = new List<BalloonInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BalloonInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BasePointInfo ty)
        {
            ty = new BasePointInfo();
            Marshaler.Read(msg, out ty.basePointID);
            Marshaler.Read(msg, out ty.fellowshipExp);
            Marshaler.Read(msg, out ty.trigger);
            Marshaler.Read(msg, out ty.uniqueInteractiveFlag);
            Marshaler.Read(msg, out ty.lastClearLoopQuestID);
            Marshaler.Read(msg, out ty.loopRandomQuestID);
            Marshaler.Read(msg, out ty.overDonationValue);
            Marshaler.Read(msg, out ty.disableDropInteractiveList);
        }

        public static void Read(Message msg, out List<BasePointInfo> list)
        {
            list = new List<BasePointInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BasePointInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BasePointRefreshInfo ty)
        {
            ty = new BasePointRefreshInfo();
            Marshaler.Read(msg, out ty.isGuildKickOut);
            Marshaler.Read(msg, out ty.guildMemberInfo);
            Marshaler.Read(msg, out ty.lobbyReddotInfo);
            Marshaler.Read(msg, out ty.prevTopGuildRankInfoList);
            Marshaler.Read(msg, out ty.lobbyRandomShopInfo);
        }

        public static void Read(Message msg, out List<BasePointRefreshInfo> list)
        {
            list = new List<BasePointRefreshInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BasePointRefreshInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BattleSkinInfo ty)
        {
            ty = new BattleSkinInfo();
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.heroAliveStatus);
            Marshaler.Read(msg, out ty.isBestPlayer);
            Marshaler.Read(msg, out ty.power);
            Marshaler.Read(msg, out ty.teamIndex);
        }

        public static void Read(Message msg, out List<BattleSkinInfo> list)
        {
            list = new List<BattleSkinInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BattleSkinInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BattleSkinResultInfo ty)
        {
            ty = new BattleSkinResultInfo();
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinExp);
            Marshaler.Read(msg, out ty.skinGetExp);
            Marshaler.Read(msg, out ty.skinBuffExp);
            Marshaler.Read(msg, out ty.isBestPlayer);
        }

        public static void Read(Message msg, out List<BattleSkinResultInfo> list)
        {
            list = new List<BattleSkinResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BattleSkinResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BillingInitializeResultInfo ty)
        {
            ty = new BillingInitializeResultInfo();
            Marshaler.Read(msg, out ty.resCode);
            Marshaler.Read(msg, out ty.transactionID);
            Marshaler.Read(msg, out ty.resultString);
            Marshaler.Read(msg, out ty.pcTransactionID);
        }

        public static void Read(Message msg, out List<BillingInitializeResultInfo> list)
        {
            list = new List<BillingInitializeResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BillingInitializeResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BillingRemainTRResultInfo ty)
        {
            ty = new BillingRemainTRResultInfo();
            Marshaler.Read(msg, out ty.resCode);
            Marshaler.Read(msg, out ty.isPurchase);
            Marshaler.Read(msg, out ty.resultString);
        }

        public static void Read(Message msg, out List<BillingRemainTRResultInfo> list)
        {
            list = new List<BillingRemainTRResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BillingRemainTRResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BillingResCode en)
        {
            short num;
            msg.Read(out num);
            en = (BillingResCode)num;
        }

        public static void Read(Message msg, out List<BillingResCode> list)
        {
            list = new List<BillingResCode>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BillingResCode item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BillingResultCode en)
        {
            int num;
            msg.Read(out num);
            en = (BillingResultCode)num;
        }

        public static void Read(Message msg, out List<BillingResultCode> list)
        {
            list = new List<BillingResultCode>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BillingResultCode item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BillingVerifyRequestInfo ty)
        {
            ty = new BillingVerifyRequestInfo();
            Marshaler.Read(msg, out ty.verifyType);
            Marshaler.Read(msg, out ty.purchases);
            Marshaler.Read(msg, out ty.packageID);
            Marshaler.Read(msg, out ty.isPurchase);
            Marshaler.Read(msg, out ty.tid);
            Marshaler.Read(msg, out ty.market);
            Marshaler.Read(msg, out ty.currencyType);
            Marshaler.Read(msg, out ty.iapItemType);
        }

        public static void Read(Message msg, out List<BillingVerifyRequestInfo> list)
        {
            list = new List<BillingVerifyRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BillingVerifyRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BillingVerifyResultInfo ty)
        {
            ty = new BillingVerifyResultInfo();
            Marshaler.Read(msg, out ty.resCode);
            Marshaler.Read(msg, out ty.resultCode);
            Marshaler.Read(msg, out ty.transactionID);
            Marshaler.Read(msg, out ty.resultString);
            Marshaler.Read(msg, out ty.isPurchase);
            Marshaler.Read(msg, out ty.promoFlag);
            Marshaler.Read(msg, out ty.gppFlag);
            Marshaler.Read(msg, out ty.pcTransactionID);
        }

        public static void Read(Message msg, out List<BillingVerifyResultInfo> list)
        {
            list = new List<BillingVerifyResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BillingVerifyResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BillingVerifyType en)
        {
            int num;
            msg.Read(out num);
            en = (BillingVerifyType)num;
        }

        public static void Read(Message msg, out List<BillingVerifyType> list)
        {
            list = new List<BillingVerifyType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BillingVerifyType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BlitzHeroInfo ty)
        {
            ty = new BlitzHeroInfo();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.status);
            Marshaler.Read(msg, out ty.type);
        }

        public static void Read(Message msg, out List<BlitzHeroInfo> list)
        {
            list = new List<BlitzHeroInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BlitzHeroInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BlitzHeroType en)
        {
            byte num;
            msg.Read(out num);
            en = (BlitzHeroType)num;
        }

        public static void Read(Message msg, out List<BlitzHeroType> list)
        {
            list = new List<BlitzHeroType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BlitzHeroType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BlitzMonsterInfo ty)
        {
            ty = new BlitzMonsterInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.monsterID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDie);
        }

        public static void Read(Message msg, out List<BlitzMonsterInfo> list)
        {
            list = new List<BlitzMonsterInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BlitzMonsterInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BlitzSquadInfo ty)
        {
            ty = new BlitzSquadInfo();
            Marshaler.Read(msg, out ty.remainSquadChageCount);
            Marshaler.Read(msg, out ty.remainSquadInitCount);
            Marshaler.Read(msg, out ty.heroInfoList);
        }

        public static void Read(Message msg, out List<BlitzSquadInfo> list)
        {
            list = new List<BlitzSquadInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BlitzSquadInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BlitzTeamSlotInfo ty)
        {
            ty = new BlitzTeamSlotInfo();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.heroGroupID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.fateHeroID);
            Marshaler.Read(msg, out ty.fateHeroGroupID);
            Marshaler.Read(msg, out ty.fateSkinID);
        }

        public static void Read(Message msg, out List<BlitzTeamSlotInfo> list)
        {
            list = new List<BlitzTeamSlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BlitzTeamSlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BoassWarLoadingSendInfo ty)
        {
            ty = new BoassWarLoadingSendInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.roomSN);
        }

        public static void Read(Message msg, out List<BoassWarLoadingSendInfo> list)
        {
            list = new List<BoassWarLoadingSendInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BoassWarLoadingSendInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out List<bool> list)
        {
            list = new List<bool>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                bool item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarBattleStartResult ty)
        {
            ty = new BossWarBattleStartResult();
            Marshaler.Read(msg, out ty.useItemResultInfoList);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<BossWarBattleStartResult> list)
        {
            list = new List<BossWarBattleStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarBattleStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarBattleSyncType en)
        {
            byte num;
            msg.Read(out num);
            en = (BossWarBattleSyncType)num;
        }

        public static void Read(Message msg, out List<BossWarBattleSyncType> list)
        {
            list = new List<BossWarBattleSyncType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarBattleSyncType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarClientSendGameInfo ty)
        {
            ty = new BossWarClientSendGameInfo();
            Marshaler.Read(msg, out ty.gameSN);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.hostUSN);
            Marshaler.Read(msg, out ty.hostNickname);
            Marshaler.Read(msg, out ty.hostUserExp);
            Marshaler.Read(msg, out ty.hostSkinID);
        }

        public static void Read(Message msg, out List<BossWarClientSendGameInfo> list)
        {
            list = new List<BossWarClientSendGameInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarClientSendGameInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarGameState en)
        {
            byte num;
            msg.Read(out num);
            en = (BossWarGameState)num;
        }

        public static void Read(Message msg, out List<BossWarGameState> list)
        {
            list = new List<BossWarGameState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarGameState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarGroupInfo ty)
        {
            ty = new BossWarGroupInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.remainEndSec);
        }

        public static void Read(Message msg, out List<BossWarGroupInfo> list)
        {
            list = new List<BossWarGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarJoinMemberInfo ty)
        {
            ty = new BossWarJoinMemberInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.isHost);
            Marshaler.Read(msg, out ty.position);
            Marshaler.Read(msg, out ty.userState);
            Marshaler.Read(msg, out ty.teamPower);
            Marshaler.Read(msg, out ty.useFoodId);
        }

        public static void Read(Message msg, out List<BossWarJoinMemberInfo> list)
        {
            list = new List<BossWarJoinMemberInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarJoinMemberInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarJoinResult ty)
        {
            ty = new BossWarJoinResult();
            Marshaler.Read(msg, out ty.gameSN);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.stageMonsterInfoList);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
        }

        public static void Read(Message msg, out List<BossWarJoinResult> list)
        {
            list = new List<BossWarJoinResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarJoinResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarLobbySyncInfo ty)
        {
            ty = new BossWarLobbySyncInfo();
            Marshaler.Read(msg, out ty.notifyType);
            Marshaler.Read(msg, out ty.usn);
        }

        public static void Read(Message msg, out List<BossWarLobbySyncInfo> list)
        {
            list = new List<BossWarLobbySyncInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarLobbySyncInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarNotifyType en)
        {
            byte num;
            msg.Read(out num);
            en = (BossWarNotifyType)num;
        }

        public static void Read(Message msg, out List<BossWarNotifyType> list)
        {
            list = new List<BossWarNotifyType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarNotifyType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarStartResult ty)
        {
            ty = new BossWarStartResult();
            Marshaler.Read(msg, out ty.gameSN);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.ingameSeed);
        }

        public static void Read(Message msg, out List<BossWarStartResult> list)
        {
            list = new List<BossWarStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarSubState en)
        {
            byte num;
            msg.Read(out num);
            en = (BossWarSubState)num;
        }

        public static void Read(Message msg, out List<BossWarSubState> list)
        {
            list = new List<BossWarSubState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarSubState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarSync ty)
        {
            ty = new BossWarSync();
            Marshaler.Read(msg, out ty.syncType);
            Marshaler.Read(msg, out ty.syncValue);
        }

        public static void Read(Message msg, out List<BossWarSync> list)
        {
            list = new List<BossWarSync>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarSync item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarUserProfileInfo ty)
        {
            ty = new BossWarUserProfileInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.position);
            Marshaler.Read(msg, out ty.isHost);
            Marshaler.Read(msg, out ty.userState);
            Marshaler.Read(msg, out ty.teamPower);
            Marshaler.Read(msg, out ty.useFoodId);
        }

        public static void Read(Message msg, out List<BossWarUserProfileInfo> list)
        {
            list = new List<BossWarUserProfileInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarUserProfileInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out BossWarUserState en)
        {
            byte num;
            msg.Read(out num);
            en = (BossWarUserState)num;
        }

        public static void Read(Message msg, out List<BossWarUserState> list)
        {
            list = new List<BossWarUserState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                BossWarUserState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out byte[] array)
        {
            int num = 0;
            msg.ReadScalar(ref num);
            array = new byte[num];
            for (int i = 0; i < num; i++)
            {
                byte item;
                Marshaler.Read(msg, out item);
                array[i] = item;
            }
        }

        public static void Read(Message msg, out List<byte> list)
        {
            list = new List<byte>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                byte item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ByteArrayInfo ty)
        {
            ty = new ByteArrayInfo();
            Marshaler.Read(msg, out ty.data);
        }

        public static void Read(Message msg, out List<ByteArrayInfo> list)
        {
            list = new List<ByteArrayInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ByteArrayInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ChallengeBossEventInfoToClientSend ty)
        {
            ty = new ChallengeBossEventInfoToClientSend();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.expireDate);
            Marshaler.Read(msg, out ty.bossStage);
            Marshaler.Read(msg, out ty.rewardIndex);
            Marshaler.Read(msg, out ty.currentEventChallengeBossSeq);
            Marshaler.Read(msg, out ty.remainSkinUsedSEQResetSec);
            Marshaler.Read(msg, out ty.currentMissionGroupID);
        }

        public static void Read(Message msg, out List<ChallengeBossEventInfoToClientSend> list)
        {
            list = new List<ChallengeBossEventInfoToClientSend>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ChallengeBossEventInfoToClientSend item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ChallengeBossEventStageClearResultInfo ty)
        {
            ty = new ChallengeBossEventStageClearResultInfo();
            Marshaler.Read(msg, out ty.userChallengeBossEventInfoForClient);
            Marshaler.Read(msg, out ty.clearMissionIDList);
            Marshaler.Read(msg, out ty.addPoint);
            Marshaler.Read(msg, out ty.addBonusPoint);
        }

        public static void Read(Message msg, out List<ChallengeBossEventStageClearResultInfo> list)
        {
            list = new List<ChallengeBossEventStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ChallengeBossEventStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ChannelUserInfo ty)
        {
            ty = new ChannelUserInfo();
            Marshaler.Read(msg, out ty.netmarblePlayerID);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.userNickName);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.lastLoginTime);
            Marshaler.Read(msg, out ty.isAdditionalDownloadNeeded);
        }

        public static void Read(Message msg, out List<ChannelUserInfo> list)
        {
            list = new List<ChannelUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ChannelUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ChatInfo ty)
        {
            ty = new ChatInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.msg);
            Marshaler.Read(msg, out ty.extraData);
            Marshaler.Read(msg, out ty.stamp);
            Marshaler.Read(msg, out ty.guildMemberGrade);
            Marshaler.Read(msg, out ty.date);
        }

        public static void Read(Message msg, out List<ChatInfo> list)
        {
            list = new List<ChatInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ChatInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ChatMsgType en)
        {
            byte num;
            msg.Read(out num);
            en = (ChatMsgType)num;
        }

        public static void Read(Message msg, out List<ChatMsgType> list)
        {
            list = new List<ChatMsgType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ChatMsgType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ChatQuickMessageInfo ty)
        {
            ty = new ChatQuickMessageInfo();
            Marshaler.Read(msg, out ty.slotNumber);
            Marshaler.Read(msg, out ty.message);
        }

        public static void Read(Message msg, out List<ChatQuickMessageInfo> list)
        {
            list = new List<ChatQuickMessageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ChatQuickMessageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ChatStampBookmarkInfo ty)
        {
            ty = new ChatStampBookmarkInfo();
            Marshaler.Read(msg, out ty.stampSlot);
            Marshaler.Read(msg, out ty.stampIDList);
        }

        public static void Read(Message msg, out List<ChatStampBookmarkInfo> list)
        {
            list = new List<ChatStampBookmarkInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ChatStampBookmarkInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CheatResult ty)
        {
            ty = new CheatResult();
            Marshaler.Read(msg, out ty.itemResultInfoList);
            Marshaler.Read(msg, out ty.sideStageClearInfoList);
            Marshaler.Read(msg, out ty.dailyReset);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainStageTopClearID);
            Marshaler.Read(msg, out ty.guildPoint);
            Marshaler.Read(msg, out ty.userTeamList);
            Marshaler.Read(msg, out ty.clearQuestID);
            Marshaler.Read(msg, out ty.removeQuestID);
            Marshaler.Read(msg, out ty.destroyDiscoverInfo);
            Marshaler.Read(msg, out ty.userTutorialInfoList);
            Marshaler.Read(msg, out ty.userNpcList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.destroyCheatInfo);
            Marshaler.Read(msg, out ty.apRewardInfo);
            Marshaler.Read(msg, out ty.userQuestProgressInfoList);
            Marshaler.Read(msg, out ty.userRecipeInfo);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.stageInfo);
            Marshaler.Read(msg, out ty.cheatType);
            Marshaler.Read(msg, out ty.cheatMessage);
            Marshaler.Read(msg, out ty.currentTimeAttackMissionDays);
            Marshaler.Read(msg, out ty.gachaGaugeInfo);
        }

        public static void Read(Message msg, out List<CheatResult> list)
        {
            list = new List<CheatResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CheatResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CheerGroupInfo ty)
        {
            ty = new CheerGroupInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.cheerCount);
        }

        public static void Read(Message msg, out List<CheerGroupInfo> list)
        {
            list = new List<CheerGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CheerGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientDeviceType en)
        {
            byte num;
            msg.Read(out num);
            en = (ClientDeviceType)num;
        }

        public static void Read(Message msg, out List<ClientDeviceType> list)
        {
            list = new List<ClientDeviceType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientDeviceType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSeasonPassRankRewardInfo ty)
        {
            ty = new ClientSeasonPassRankRewardInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.buySeasonPassPackageID);
            Marshaler.Read(msg, out ty.rankRewardInfoList);
        }

        public static void Read(Message msg, out List<ClientSeasonPassRankRewardInfo> list)
        {
            list = new List<ClientSeasonPassRankRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSeasonPassRankRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendArenaSmashRankInfo ty)
        {
            ty = new ClientSendArenaSmashRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
        }

        public static void Read(Message msg, out List<ClientSendArenaSmashRankInfo> list)
        {
            list = new List<ClientSendArenaSmashRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendArenaSmashRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendArenaSmashRankTeamInfo ty)
        {
            ty = new ClientSendArenaSmashRankTeamInfo();
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.skinIDList);
        }

        public static void Read(Message msg, out List<ClientSendArenaSmashRankTeamInfo> list)
        {
            list = new List<ClientSendArenaSmashRankTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendArenaSmashRankTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendBlitzStageEventInfo ty)
        {
            ty = new ClientSendBlitzStageEventInfo();
            Marshaler.Read(msg, out ty.blitzStageEventInfo);
            Marshaler.Read(msg, out ty.blitzStageSquadInfo);
            Marshaler.Read(msg, out ty.blitzStageMonsterInfoList);
            Marshaler.Read(msg, out ty.blitzStageTeamSlotInfoList);
        }

        public static void Read(Message msg, out List<ClientSendBlitzStageEventInfo> list)
        {
            list = new List<ClientSendBlitzStageEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendBlitzStageEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendBossWarInfo ty)
        {
            ty = new ClientSendBossWarInfo();
            Marshaler.Read(msg, out ty.bossWarInfoList);
            Marshaler.Read(msg, out ty.subdueBossPlayInfoList);
        }

        public static void Read(Message msg, out List<ClientSendBossWarInfo> list)
        {
            list = new List<ClientSendBossWarInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendBossWarInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendCreatureNestStageInfo ty)
        {
            ty = new ClientSendCreatureNestStageInfo();
            Marshaler.Read(msg, out ty.userCreatureNestStageInfo);
            Marshaler.Read(msg, out ty.savedTeamInfo);
            Marshaler.Read(msg, out ty.heroSyncInfoList);
        }

        public static void Read(Message msg, out List<ClientSendCreatureNestStageInfo> list)
        {
            list = new List<ClientSendCreatureNestStageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendCreatureNestStageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventAttendanceInfo ty)
        {
            ty = new ClientSendEventAttendanceInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.lastRewardIndex);
            Marshaler.Read(msg, out ty.dayFixRewardDay);
            Marshaler.Read(msg, out ty.isRewardedToday);
            Marshaler.Read(msg, out ty.endRemainSec);
        }

        public static void Read(Message msg, out List<ClientSendEventAttendanceInfo> list)
        {
            list = new List<ClientSendEventAttendanceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventAttendanceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventChallengeBossLobbyInfo ty)
        {
            ty = new ClientSendEventChallengeBossLobbyInfo();
            Marshaler.Read(msg, out ty.sendInfo);
        }

        public static void Read(Message msg, out List<ClientSendEventChallengeBossLobbyInfo> list)
        {
            list = new List<ClientSendEventChallengeBossLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventChallengeBossLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventConfirmGameInfo ty)
        {
            ty = new ClientSendEventConfirmGameInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.totalScore);
            Marshaler.Read(msg, out ty.totalScoreRewardFlag);
            Marshaler.Read(msg, out ty.highScore);
            Marshaler.Read(msg, out ty.userEventConfirmGameRecordInfoList);
        }

        public static void Read(Message msg, out List<ClientSendEventConfirmGameInfo> list)
        {
            list = new List<ClientSendEventConfirmGameInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventConfirmGameInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventDiceInfo ty)
        {
            ty = new ClientSendEventDiceInfo();
            Marshaler.Read(msg, out ty.userEventDiceInfo);
        }

        public static void Read(Message msg, out List<ClientSendEventDiceInfo> list)
        {
            list = new List<ClientSendEventDiceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventDiceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventLobbyGiftInfo ty)
        {
            ty = new ClientSendEventLobbyGiftInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.lastRewardIndex);
            Marshaler.Read(msg, out ty.isRewardedToday);
        }

        public static void Read(Message msg, out List<ClientSendEventLobbyGiftInfo> list)
        {
            list = new List<ClientSendEventLobbyGiftInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventLobbyGiftInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventMazeSeasonShopInfo ty)
        {
            ty = new ClientSendEventMazeSeasonShopInfo();
            Marshaler.Read(msg, out ty.eventMazeSeasonShopInfoList);
            Marshaler.Read(msg, out ty.eventMazeSeasonShopBuyInfoList);
        }

        public static void Read(Message msg, out List<ClientSendEventMazeSeasonShopInfo> list)
        {
            list = new List<ClientSendEventMazeSeasonShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventMazeSeasonShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventMissionInfo ty)
        {
            ty = new ClientSendEventMissionInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.chainID);
            Marshaler.Read(msg, out ty.rewardChainIndex);
            Marshaler.Read(msg, out ty.progressValue);
        }

        public static void Read(Message msg, out List<ClientSendEventMissionInfo> list)
        {
            list = new List<ClientSendEventMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventMoleGameInfo ty)
        {
            ty = new ClientSendEventMoleGameInfo();
            Marshaler.Read(msg, out ty.userEventMoleGameInfo);
            Marshaler.Read(msg, out ty.userEventMoleGameRecordInfoList);
        }

        public static void Read(Message msg, out List<ClientSendEventMoleGameInfo> list)
        {
            list = new List<ClientSendEventMoleGameInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventMoleGameInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendEventPuzzleInfo ty)
        {
            ty = new ClientSendEventPuzzleInfo();
            Marshaler.Read(msg, out ty.userPuzzleInfo);
            Marshaler.Read(msg, out ty.userPuzzleBlockInfoList);
            Marshaler.Read(msg, out ty.eventPuzzleAPInfo);
        }

        public static void Read(Message msg, out List<ClientSendEventPuzzleInfo> list)
        {
            list = new List<ClientSendEventPuzzleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendEventPuzzleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendFinalBossDifficultyRankInfo ty)
        {
            ty = new ClientSendFinalBossDifficultyRankInfo();
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.redisFinalBossDifficultyRankInfo);
        }

        public static void Read(Message msg, out List<ClientSendFinalBossDifficultyRankInfo> list)
        {
            list = new List<ClientSendFinalBossDifficultyRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendFinalBossDifficultyRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendFinalBossRankHeroInfo ty)
        {
            ty = new ClientSendFinalBossRankHeroInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.skinIDList);
        }

        public static void Read(Message msg, out List<ClientSendFinalBossRankHeroInfo> list)
        {
            list = new List<ClientSendFinalBossRankHeroInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendFinalBossRankHeroInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendFinalBossRankInfo ty)
        {
            ty = new ClientSendFinalBossRankInfo();
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.redisFinalBossRankInfo);
        }

        public static void Read(Message msg, out List<ClientSendFinalBossRankInfo> list)
        {
            list = new List<ClientSendFinalBossRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendFinalBossRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendFinalBossSeasonInfo ty)
        {
            ty = new ClientSendFinalBossSeasonInfo();
            Marshaler.Read(msg, out ty.currentSeasonID);
            Marshaler.Read(msg, out ty.currentFinalBossStageFlag);
            Marshaler.Read(msg, out ty.finalBossGroupInfoList);
            Marshaler.Read(msg, out ty.remainFinalBossInitSec);
            Marshaler.Read(msg, out ty.currentFinalBossPointItemCount);
            Marshaler.Read(msg, out ty.finalBossSeasonInfoList);
            Marshaler.Read(msg, out ty.finalBossBattleScoreInfoList);
            Marshaler.Read(msg, out ty.prevSeasonID);
            Marshaler.Read(msg, out ty.finalBossRankRewardOccured);
            Marshaler.Read(msg, out ty.finalBossVowInfoList);
        }

        public static void Read(Message msg, out List<ClientSendFinalBossSeasonInfo> list)
        {
            list = new List<ClientSendFinalBossSeasonInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendFinalBossSeasonInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendFinalBossSeasonShopInfo ty)
        {
            ty = new ClientSendFinalBossSeasonShopInfo();
            Marshaler.Read(msg, out ty.finalBossSeasonShopInfoList);
            Marshaler.Read(msg, out ty.finalBossSeasonShopBuyInfoList);
        }

        public static void Read(Message msg, out List<ClientSendFinalBossSeasonShopInfo> list)
        {
            list = new List<ClientSendFinalBossSeasonShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendFinalBossSeasonShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendGuildBossLobbyInfo ty)
        {
            ty = new ClientSendGuildBossLobbyInfo();
            Marshaler.Read(msg, out ty.startRemainSec);
            Marshaler.Read(msg, out ty.endRamainSec);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.totalRankUpCount);
            Marshaler.Read(msg, out ty.currentRankPoint);
            Marshaler.Read(msg, out ty.userWeeklyContribution);
            Marshaler.Read(msg, out ty.currentMissionGroupID);
            Marshaler.Read(msg, out ty.stageLocked);
            Marshaler.Read(msg, out ty.currentGuildBossSeq);
            Marshaler.Read(msg, out ty.isJoinFirstWeek);
            Marshaler.Read(msg, out ty.currentSeasonGroup);
            Marshaler.Read(msg, out ty.guildBossRankPointList);
            Marshaler.Read(msg, out ty.guildBossRankPointReward);
            Marshaler.Read(msg, out ty.guildBossOffSeasonRankPointList);
            Marshaler.Read(msg, out ty.currentSeasonID);
            Marshaler.Read(msg, out ty.guildBossRankInfoList);
            Marshaler.Read(msg, out ty.joinFirstWeekRemainSec);
            Marshaler.Read(msg, out ty.guildBossOffSeasonInfoList);
            Marshaler.Read(msg, out ty.isGuildBossHellOpened);
        }

        public static void Read(Message msg, out List<ClientSendGuildBossLobbyInfo> list)
        {
            list = new List<ClientSendGuildBossLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendGuildBossLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendGuildBossRankInfo ty)
        {
            ty = new ClientSendGuildBossRankInfo();
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.redisGuildBossRankInfo);
            Marshaler.Read(msg, out ty.guildInvitationState);
        }

        public static void Read(Message msg, out List<ClientSendGuildBossRankInfo> list)
        {
            list = new List<ClientSendGuildBossRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendGuildBossRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendGuildRankInfo ty)
        {
            ty = new ClientSendGuildRankInfo();
            Marshaler.Read(msg, out ty.guildRankInfo);
            Marshaler.Read(msg, out ty.guildInfo);
        }

        public static void Read(Message msg, out List<ClientSendGuildRankInfo> list)
        {
            list = new List<ClientSendGuildRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendGuildRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendGuildWarInfo ty)
        {
            ty = new ClientSendGuildWarInfo();
            Marshaler.Read(msg, out ty.guildWarScheduleInfo);
            Marshaler.Read(msg, out ty.nextGuildWarScheduleInfo);
            Marshaler.Read(msg, out ty.isGuildWarSelected);
            Marshaler.Read(msg, out ty.isGuildWarPrevSeasonSelected);
            Marshaler.Read(msg, out ty.isGuildWarPlayable);
            Marshaler.Read(msg, out ty.guildWarType);
        }

        public static void Read(Message msg, out List<ClientSendGuildWarInfo> list)
        {
            list = new List<ClientSendGuildWarInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendGuildWarInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendGuildWarLowMemberRankInfo ty)
        {
            ty = new ClientSendGuildWarLowMemberRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.score);
        }

        public static void Read(Message msg, out List<ClientSendGuildWarLowMemberRankInfo> list)
        {
            list = new List<ClientSendGuildWarLowMemberRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendGuildWarLowMemberRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendHeroLeagueInfo ty)
        {
            ty = new ClientSendHeroLeagueInfo();
            Marshaler.Read(msg, out ty.remainSeasonInitSec);
            Marshaler.Read(msg, out ty.remainWeekInitSec);
            Marshaler.Read(msg, out ty.week);
            Marshaler.Read(msg, out ty.heroLeagueInfo);
            Marshaler.Read(msg, out ty.heroLeagueSeasonInfo);
            Marshaler.Read(msg, out ty.heroLeagueHeroList);
            Marshaler.Read(msg, out ty.heroLeagueSeasonBuffInfo);
            Marshaler.Read(msg, out ty.heroLeagueSpecialBuffInfoList);
        }

        public static void Read(Message msg, out List<ClientSendHeroLeagueInfo> list)
        {
            list = new List<ClientSendHeroLeagueInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendHeroLeagueInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendHeroLeagueSeasonShopInfo ty)
        {
            ty = new ClientSendHeroLeagueSeasonShopInfo();
            Marshaler.Read(msg, out ty.heroLeagueSeasonShopInfoList);
            Marshaler.Read(msg, out ty.heroLeagueSeasonShopBuyInfoList);
        }

        public static void Read(Message msg, out List<ClientSendHeroLeagueSeasonShopInfo> list)
        {
            list = new List<ClientSendHeroLeagueSeasonShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendHeroLeagueSeasonShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendMissionInfo ty)
        {
            ty = new ClientSendMissionInfo();
            Marshaler.Read(msg, out ty.chainID);
            Marshaler.Read(msg, out ty.rewardChainIndex);
            Marshaler.Read(msg, out ty.progressValue);
        }

        public static void Read(Message msg, out List<ClientSendMissionInfo> list)
        {
            list = new List<ClientSendMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendPlayTitleMissionInfo ty)
        {
            ty = new ClientSendPlayTitleMissionInfo();
            Marshaler.Read(msg, out ty.missionID);
            Marshaler.Read(msg, out ty.progressValue);
        }

        public static void Read(Message msg, out List<ClientSendPlayTitleMissionInfo> list)
        {
            list = new List<ClientSendPlayTitleMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendPlayTitleMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendTimeMissionEventInfo ty)
        {
            ty = new ClientSendTimeMissionEventInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.remainSec);
        }

        public static void Read(Message msg, out List<ClientSendTimeMissionEventInfo> list)
        {
            list = new List<ClientSendTimeMissionEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendTimeMissionEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSendUserAttendanceInfo ty)
        {
            ty = new ClientSendUserAttendanceInfo();
            Marshaler.Read(msg, out ty.isRewardedToday);
            Marshaler.Read(msg, out ty.attendanceType);
            Marshaler.Read(msg, out ty.attendanceGroup);
            Marshaler.Read(msg, out ty.rewardIndex);
            Marshaler.Read(msg, out ty.welcomeRewardIndex);
            Marshaler.Read(msg, out ty.comebackMissionEnable);
            Marshaler.Read(msg, out ty.combackEndRemainSec);
            Marshaler.Read(msg, out ty.pvpComebackMissionEnable);
            Marshaler.Read(msg, out ty.pvpCombackEndRemainSec);
            Marshaler.Read(msg, out ty.lastRewardedType);
            Marshaler.Read(msg, out ty.lastRewardedGroup);
            Marshaler.Read(msg, out ty.lastRewardedIndex);
        }

        public static void Read(Message msg, out List<ClientSendUserAttendanceInfo> list)
        {
            list = new List<ClientSendUserAttendanceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSendUserAttendanceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSyncGuildWarHero ty)
        {
            ty = new ClientSyncGuildWarHero();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
            //Marshaler.Read(msg, out ty.guildSN);
        }

        public static void Read(Message msg, out List<ClientSyncGuildWarHero> list)
        {
            list = new List<ClientSyncGuildWarHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSyncGuildWarHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSyncGuildWarLowHero ty)
        {
            ty = new ClientSyncGuildWarLowHero();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
            //Marshaler.Read(msg, out ty.guildSN);
        }

        public static void Read(Message msg, out List<ClientSyncGuildWarLowHero> list)
        {
            list = new List<ClientSyncGuildWarLowHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSyncGuildWarLowHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ClientSyncHeroLeagueHero ty)
        {
            ty = new ClientSyncHeroLeagueHero();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
        }

        public static void Read(Message msg, out List<ClientSyncHeroLeagueHero> list)
        {
            list = new List<ClientSyncHeroLeagueHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ClientSyncHeroLeagueHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CoinshopDailySlotInfo ty)
        {
            ty = new CoinshopDailySlotInfo();
            Marshaler.Read(msg, out ty.shopID);
            Marshaler.Read(msg, out ty.slotIndex);
            Marshaler.Read(msg, out ty.buyCount);
        }

        public static void Read(Message msg, out List<CoinshopDailySlotInfo> list)
        {
            list = new List<CoinshopDailySlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CoinshopDailySlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CoinShopPeriodBuyLimitType en)
        {
            int num;
            msg.Read(out num);
            en = (CoinShopPeriodBuyLimitType)num;
        }

        public static void Read(Message msg, out List<CoinShopPeriodBuyLimitType> list)
        {
            list = new List<CoinShopPeriodBuyLimitType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CoinShopPeriodBuyLimitType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CoinShopRotationInfo ty)
        {
            ty = new CoinShopRotationInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.coinShopBuyInfoList);
        }

        public static void Read(Message msg, out List<CoinShopRotationInfo> list)
        {
            list = new List<CoinShopRotationInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CoinShopRotationInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CoinShopRotationTabInfo ty)
        {
            ty = new CoinShopRotationTabInfo();
            Marshaler.Read(msg, out ty.platinumCoinTab);
            Marshaler.Read(msg, out ty.goldCoinTab);
            Marshaler.Read(msg, out ty.silverCoinTab);
            Marshaler.Read(msg, out ty.friendCoinTab);
        }

        public static void Read(Message msg, out List<CoinShopRotationTabInfo> list)
        {
            list = new List<CoinShopRotationTabInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CoinShopRotationTabInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ConstellationChaosInfo ty)
        {
            ty = new ConstellationChaosInfo();
            Marshaler.Read(msg, out ty.itemResultInfo);
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.isRecharge);
        }

        public static void Read(Message msg, out List<ConstellationChaosInfo> list)
        {
            list = new List<ConstellationChaosInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ConstellationChaosInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ConstellationInfo ty)
        {
            ty = new ConstellationInfo();
            Marshaler.Read(msg, out ty.groupId);
            Marshaler.Read(msg, out ty.stoneInfoList);
        }

        public static void Read(Message msg, out List<ConstellationInfo> list)
        {
            list = new List<ConstellationInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ConstellationInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ConstellationManaStoneColorType en)
        {
            sbyte num;
            msg.Read(out num);
            en = (ConstellationManaStoneColorType)num;
        }

        public static void Read(Message msg, out List<ConstellationManaStoneColorType> list)
        {
            list = new List<ConstellationManaStoneColorType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ConstellationManaStoneColorType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ConstellationStoneInfo ty)
        {
            ty = new ConstellationStoneInfo();
            Marshaler.Read(msg, out ty.stoneId);
            Marshaler.Read(msg, out ty.status);
            Marshaler.Read(msg, out ty.isLock);
        }

        public static void Read(Message msg, out List<ConstellationStoneInfo> list)
        {
            list = new List<ConstellationStoneInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ConstellationStoneInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ConstellationStoneStatus ty)
        {
            ty = new ConstellationStoneStatus();
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.value);
        }

        public static void Read(Message msg, out List<ConstellationStoneStatus> list)
        {
            list = new List<ConstellationStoneStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ConstellationStoneStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ConstellationSystemInfo ty)
        {
            ty = new ConstellationSystemInfo();
            Marshaler.Read(msg, out ty.growthPoint);
            Marshaler.Read(msg, out ty.constellationInfoList);
        }

        public static void Read(Message msg, out List<ConstellationSystemInfo> list)
        {
            list = new List<ConstellationSystemInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ConstellationSystemInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CookingHeroInfo ty)
        {
            ty = new CookingHeroInfo();
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.cookingHeroID);
            Marshaler.Read(msg, out ty.fellowshipPoint);
            Marshaler.Read(msg, out ty.getCount);
            Marshaler.Read(msg, out ty.visitType);
        }

        public static void Read(Message msg, out List<CookingHeroInfo> list)
        {
            list = new List<CookingHeroInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CookingHeroInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CookingHeroVisit en)
        {
            byte num;
            msg.Read(out num);
            en = (CookingHeroVisit)num;
        }

        public static void Read(Message msg, out List<CookingHeroVisit> list)
        {
            list = new List<CookingHeroVisit>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CookingHeroVisit item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CookingInfo ty)
        {
            ty = new CookingInfo();
            Marshaler.Read(msg, out ty.cookingID);
            Marshaler.Read(msg, out ty.cookingPoint);
            Marshaler.Read(msg, out ty.remainSec);
        }

        public static void Read(Message msg, out List<CookingInfo> list)
        {
            list = new List<CookingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CookingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CookingRequest ty)
        {
            ty = new CookingRequest();
            Marshaler.Read(msg, out ty.npcID);
            Marshaler.Read(msg, out ty.materialItemIDList);
            Marshaler.Read(msg, out ty.cookingCount);
            Marshaler.Read(msg, out ty.isImmediately);
        }

        public static void Read(Message msg, out List<CookingRequest> list)
        {
            list = new List<CookingRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CookingRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CookingResult ty)
        {
            ty = new CookingResult();
            Marshaler.Read(msg, out ty.successType);
            Marshaler.Read(msg, out ty.dailyMeliodasCookingCount);
            Marshaler.Read(msg, out ty.useMaterialItemInfoList);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.userRecipeInfo);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.cookingCount);
            Marshaler.Read(msg, out ty.npcResult);
            Marshaler.Read(msg, out ty.isImmediately);
        }

        public static void Read(Message msg, out List<CookingResult> list)
        {
            list = new List<CookingResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CookingResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumeAutoRegisterInfo ty)
        {
            ty = new CostumeAutoRegisterInfo();
            Marshaler.Read(msg, out ty.targetSkinID);
            Marshaler.Read(msg, out ty.targetCostumeIDList);
            Marshaler.Read(msg, out ty.slotIndexList);
        }

        public static void Read(Message msg, out List<CostumeAutoRegisterInfo> list)
        {
            list = new List<CostumeAutoRegisterInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumeAutoRegisterInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumeCraftUpgradeInfo ty)
        {
            ty = new CostumeCraftUpgradeInfo();
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.upgrade);
        }

        public static void Read(Message msg, out List<CostumeCraftUpgradeInfo> list)
        {
            list = new List<CostumeCraftUpgradeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumeCraftUpgradeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumeCraftUpgradeType en)
        {
            byte num;
            msg.Read(out num);
            en = (CostumeCraftUpgradeType)num;
        }

        public static void Read(Message msg, out List<CostumeCraftUpgradeType> list)
        {
            list = new List<CostumeCraftUpgradeType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumeCraftUpgradeType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumePackageBuyInfo ty)
        {
            ty = new CostumePackageBuyInfo();
            Marshaler.Read(msg, out ty.shopID);
            Marshaler.Read(msg, out ty.costumePackagePriceType);
        }

        public static void Read(Message msg, out List<CostumePackageBuyInfo> list)
        {
            list = new List<CostumePackageBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumePackageBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumePackagePriceType en)
        {
            byte num;
            msg.Read(out num);
            en = (CostumePackagePriceType)num;
        }

        public static void Read(Message msg, out List<CostumePackagePriceType> list)
        {
            list = new List<CostumePackagePriceType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumePackagePriceType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumeResultInfo ty)
        {
            ty = new CostumeResultInfo();
            Marshaler.Read(msg, out ty.resultCotumeType);
            Marshaler.Read(msg, out ty.skinCostumeResultInfo);
            Marshaler.Read(msg, out ty.weaponCostumeResultInfo);
            Marshaler.Read(msg, out ty.headCostumeResultInfo);
        }

        public static void Read(Message msg, out List<CostumeResultInfo> list)
        {
            list = new List<CostumeResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumeResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumeShopProductType en)
        {
            byte num;
            msg.Read(out num);
            en = (CostumeShopProductType)num;
        }

        public static void Read(Message msg, out List<CostumeShopProductType> list)
        {
            list = new List<CostumeShopProductType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumeShopProductType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CostumeType en)
        {
            int num;
            msg.Read(out num);
            en = (CostumeType)num;
        }

        public static void Read(Message msg, out List<CostumeType> list)
        {
            list = new List<CostumeType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CostumeType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CreatureNestChallengeRewardStatus en)
        {
            byte num;
            msg.Read(out num);
            en = (CreatureNestChallengeRewardStatus)num;
        }

        public static void Read(Message msg, out List<CreatureNestChallengeRewardStatus> list)
        {
            list = new List<CreatureNestChallengeRewardStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CreatureNestChallengeRewardStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CreatureNestColosseumSeasonInfo ty)
        {
            ty = new CreatureNestColosseumSeasonInfo();
            Marshaler.Read(msg, out ty.currentSeasonID);
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.initializedItemResultInfoList);
        }

        public static void Read(Message msg, out List<CreatureNestColosseumSeasonInfo> list)
        {
            list = new List<CreatureNestColosseumSeasonInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CreatureNestColosseumSeasonInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CreatureNestStageClearRequestInfo ty)
        {
            ty = new CreatureNestStageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageClearRequestInfo);
            Marshaler.Read(msg, out ty.ingameBattlePointRequest);
            Marshaler.Read(msg, out ty.statUserSkinList);
            Marshaler.Read(msg, out ty.heroSyncInfoList);
        }

        public static void Read(Message msg, out List<CreatureNestStageClearRequestInfo> list)
        {
            list = new List<CreatureNestStageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CreatureNestStageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CreatureNestStageClearResultInfo ty)
        {
            ty = new CreatureNestStageClearResultInfo();
            Marshaler.Read(msg, out ty.stageClearResultInfo);
            Marshaler.Read(msg, out ty.clientSendCreatureNestStageInfo);
        }

        public static void Read(Message msg, out List<CreatureNestStageClearResultInfo> list)
        {
            list = new List<CreatureNestStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CreatureNestStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CreatureNestStagePassiveInfo ty)
        {
            ty = new CreatureNestStagePassiveInfo();
            Marshaler.Read(msg, out ty.phase);
            Marshaler.Read(msg, out ty.passiveID);
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.isNewPassive);
        }

        public static void Read(Message msg, out List<CreatureNestStagePassiveInfo> list)
        {
            list = new List<CreatureNestStagePassiveInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CreatureNestStagePassiveInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CreatureNestStageStartRequestInfo ty)
        {
            ty = new CreatureNestStageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageStartRequestInfo);
        }

        public static void Read(Message msg, out List<CreatureNestStageStartRequestInfo> list)
        {
            list = new List<CreatureNestStageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CreatureNestStageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out CreatureNestStageStartResultInfo ty)
        {
            ty = new CreatureNestStageStartResultInfo();
            Marshaler.Read(msg, out ty.stageStartResultInfo);
            Marshaler.Read(msg, out ty.userPlayCountEventInfoList);
            Marshaler.Read(msg, out ty.paybackEventresultInfo);
            Marshaler.Read(msg, out ty.activePassiveSkillInfoList);
            Marshaler.Read(msg, out ty.clientSendCreatureNestStageInfo);
        }

        public static void Read(Message msg, out List<CreatureNestStageStartResultInfo> list)
        {
            list = new List<CreatureNestStageStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                CreatureNestStageStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DailyFreeGambleInfoClientSend ty)
        {
            ty = new DailyFreeGambleInfoClientSend();
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.freeCount);
            Marshaler.Read(msg, out ty.remainSec);
        }

        public static void Read(Message msg, out List<DailyFreeGambleInfoClientSend> list)
        {
            list = new List<DailyFreeGambleInfoClientSend>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DailyFreeGambleInfoClientSend item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DateTimeKind en)
        {
            int num;
            msg.Read(out num);
            en = (DateTimeKind)num;
        }

        public static void Read(Message msg, out List<DateTimeKind> list)
        {
            list = new List<DateTimeKind>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DateTimeKind item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DateTime ty)
        {
            long ticks;
            Marshaler.Read(msg, out ticks);
            int kind;
            Marshaler.Read(msg, out kind);
            ty = new DateTime(ticks, (DateTimeKind)kind);
        }

        public static void Read(Message msg, out List<DateTime> list)
        {
            list = new List<DateTime>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DateTime item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DayOfWeek en)
        {
            byte num;
            msg.Read(out num);
            en = (DayOfWeek)num;
        }

        public static void Read(Message msg, out List<DayOfWeek> list)
        {
            list = new List<DayOfWeek>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DayOfWeek item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DescentBossEventInfoToClientSend ty)
        {
            ty = new DescentBossEventInfoToClientSend();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.expireDate);
            Marshaler.Read(msg, out ty.bossStage);
            Marshaler.Read(msg, out ty.rewardIndex);
            Marshaler.Read(msg, out ty.currentMissionGroupID);
        }

        public static void Read(Message msg, out List<DescentBossEventInfoToClientSend> list)
        {
            list = new List<DescentBossEventInfoToClientSend>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DescentBossEventInfoToClientSend item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyBattleStartResult ty)
        {
            ty = new DestroyBattleStartResult();
            Marshaler.Read(msg, out ty.isBuffUsed);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.useItemResultInfo);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.otherTeamInfo);
            Marshaler.Read(msg, out ty.usedEventLobbyBuffIdList);
        }

        public static void Read(Message msg, out List<DestroyBattleStartResult> list)
        {
            list = new List<DestroyBattleStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyBattleStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyCardOrderInfo ty)
        {
            ty = new DestroyCardOrderInfo();
            Marshaler.Read(msg, out ty.roundID);
            Marshaler.Read(msg, out ty.cardInfoList);
        }

        public static void Read(Message msg, out List<DestroyCardOrderInfo> list)
        {
            list = new List<DestroyCardOrderInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyCardOrderInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyCardSelectionInfo ty)
        {
            ty = new DestroyCardSelectionInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.roundID);
            Marshaler.Read(msg, out ty.selectedCardIndex);
            Marshaler.Read(msg, out ty.autoInput);
            Marshaler.Read(msg, out ty.targetCampList);
            Marshaler.Read(msg, out ty.targetIndexList);
            Marshaler.Read(msg, out ty.isMove);
            Marshaler.Read(msg, out ty.targetCardIndex);
        }

        public static void Read(Message msg, out List<DestroyCardSelectionInfo> list)
        {
            list = new List<DestroyCardSelectionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyCardSelectionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyChatMessage ty)
        {
            ty = new DestroyChatMessage();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.chatType);
            Marshaler.Read(msg, out ty.stampID);
            Marshaler.Read(msg, out ty.message);
            Marshaler.Read(msg, out ty.chatDate);
        }

        public static void Read(Message msg, out List<DestroyChatMessage> list)
        {
            list = new List<DestroyChatMessage>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyChatMessage item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyChatType en)
        {
            byte num;
            msg.Read(out num);
            en = (DestroyChatType)num;
        }

        public static void Read(Message msg, out List<DestroyChatType> list)
        {
            list = new List<DestroyChatType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyChatType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyCheatInfo ty)
        {
            ty = new DestroyCheatInfo();
            Marshaler.Read(msg, out ty.readyUserUSN);
            Marshaler.Read(msg, out ty.actionResult);
        }

        public static void Read(Message msg, out List<DestroyCheatInfo> list)
        {
            list = new List<DestroyCheatInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyCheatInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyClearRequest ty)
        {
            ty = new DestroyClearRequest();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.missionRequest);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.isAutoPlay);
            Marshaler.Read(msg, out ty.turnCount);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.phase);
        }

        public static void Read(Message msg, out List<DestroyClearRequest> list)
        {
            list = new List<DestroyClearRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyClearRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyClearResult ty)
        {
            ty = new DestroyClearResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.stageId);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.battleSkinResultInfoList);
            Marshaler.Read(msg, out ty.npcResultList);
            Marshaler.Read(msg, out ty.goldItemResultInfo);
            Marshaler.Read(msg, out ty.ownerRewardInfo);
            Marshaler.Read(msg, out ty.firstClearItemResultInfo);
            Marshaler.Read(msg, out ty.questRewardInfoList);
            Marshaler.Read(msg, out ty.defaultRewardInfoList);
            Marshaler.Read(msg, out ty.globalDropItemResultInfoList);
            Marshaler.Read(msg, out ty.repulseItemResultInfo);
            Marshaler.Read(msg, out ty.passiveItemResultInfoList);
            Marshaler.Read(msg, out ty.foodBuffItemReslutInfo);
            Marshaler.Read(msg, out ty.attackPointRewardResultInfo);
            Marshaler.Read(msg, out ty.demonPointItemResultInfo);
            Marshaler.Read(msg, out ty.repeatItemResultInfo);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.playCountEventInfoList);
            Marshaler.Read(msg, out ty.normalGroupIndex);
            Marshaler.Read(msg, out ty.ownerGroupIndex);
            Marshaler.Read(msg, out ty.teamMateUSN);
            Marshaler.Read(msg, out ty.teamMateNickname);
            Marshaler.Read(msg, out ty.isFriend);
            Marshaler.Read(msg, out ty.ingameGoldBuffAddValue);
            Marshaler.Read(msg, out ty.getBasepointExp);
            Marshaler.Read(msg, out ty.usedFoodID);
            Marshaler.Read(msg, out ty.basepointInfo);
            Marshaler.Read(msg, out ty.userBuffInfo);
            Marshaler.Read(msg, out ty.stageInfo);
            Marshaler.Read(msg, out ty.updateUserGlobalDropEventInfoList);
            Marshaler.Read(msg, out ty.teamMatePlayTitleID);
            Marshaler.Read(msg, out ty.adViewRouletteInfo);
            Marshaler.Read(msg, out ty.heroPassiveGroupInfoList);
            Marshaler.Read(msg, out ty.liveJoinCount);
            Marshaler.Read(msg, out ty.usedEventLobbyBuffIdList);
            Marshaler.Read(msg, out ty.destroyDiscoverInfo);
        }

        public static void Read(Message msg, out List<DestroyClearResult> list)
        {
            list = new List<DestroyClearResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyClearResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyClearVerificationRequest ty)
        {
            ty = new DestroyClearVerificationRequest();
            Marshaler.Read(msg, out ty.isClear);
            Marshaler.Read(msg, out ty.unitStatusList);
            Marshaler.Read(msg, out ty.stageInfoString);
            Marshaler.Read(msg, out ty.clearDateTime);
            Marshaler.Read(msg, out ty.battleEncounter);
        }

        public static void Read(Message msg, out List<DestroyClearVerificationRequest> list)
        {
            list = new List<DestroyClearVerificationRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyClearVerificationRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyClientSendRoomInfo ty)
        {
            ty = new DestroyClientSendRoomInfo();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.userCount);
            Marshaler.Read(msg, out ty.ownerUSN);
            Marshaler.Read(msg, out ty.ownerNickname);
            Marshaler.Read(msg, out ty.ownerUserExp);
            Marshaler.Read(msg, out ty.ownerSkinID);
            Marshaler.Read(msg, out ty.remainSecToClose);
        }

        public static void Read(Message msg, out List<DestroyClientSendRoomInfo> list)
        {
            list = new List<DestroyClientSendRoomInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyClientSendRoomInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyCreateResult ty)
        {
            ty = new DestroyCreateResult();
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.stageMonsterInfoList);
            Marshaler.Read(msg, out ty.battleEncounter);
        }

        public static void Read(Message msg, out List<DestroyCreateResult> list)
        {
            list = new List<DestroyCreateResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyCreateResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyDisasterDicoverInfo ty)
        {
            ty = new DestroyDisasterDicoverInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.bossStageClearFlag);
            Marshaler.Read(msg, out ty.pickGroupID);
            Marshaler.Read(msg, out ty.isClear);
            Marshaler.Read(msg, out ty.disasterGaugeInfoList);
            Marshaler.Read(msg, out ty.remainSecToClose);
        }

        public static void Read(Message msg, out List<DestroyDisasterDicoverInfo> list)
        {
            list = new List<DestroyDisasterDicoverInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyDisasterDicoverInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyDisasterGaugeInfo ty)
        {
            ty = new DestroyDisasterGaugeInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.disasterArea);
            Marshaler.Read(msg, out ty.discoverCount);
            Marshaler.Read(msg, out ty.gaugePoint);
        }

        public static void Read(Message msg, out List<DestroyDisasterGaugeInfo> list)
        {
            list = new List<DestroyDisasterGaugeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyDisasterGaugeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyDiscoverInfo ty)
        {
            ty = new DestroyDiscoverInfo();
            Marshaler.Read(msg, out ty.region);
            Marshaler.Read(msg, out ty.pickGroupID);
            Marshaler.Read(msg, out ty.discoverCount);
            Marshaler.Read(msg, out ty.gaugePoint);
            Marshaler.Read(msg, out ty.isClear);
            Marshaler.Read(msg, out ty.closeDate);
            Marshaler.Read(msg, out ty.remainSecToClose);
            Marshaler.Read(msg, out ty.highRankDiscoverCount);
            Marshaler.Read(msg, out ty.highRankGaugePoint);
            Marshaler.Read(msg, out ty.isHighRankClear);
            Marshaler.Read(msg, out ty.highRankCloseDate);
            Marshaler.Read(msg, out ty.highRankRemainSecToClose);
        }

        public static void Read(Message msg, out List<DestroyDiscoverInfo> list)
        {
            list = new List<DestroyDiscoverInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyDiscoverInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyExitRequest ty)
        {
            ty = new DestroyExitRequest();
            Marshaler.Read(msg, out ty.exitStatus);
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.isAutoPlay);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.phase);
        }

        public static void Read(Message msg, out List<DestroyExitRequest> list)
        {
            list = new List<DestroyExitRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyExitRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyExitStatus en)
        {
            byte num;
            msg.Read(out num);
            en = (DestroyExitStatus)num;
        }

        public static void Read(Message msg, out List<DestroyExitStatus> list)
        {
            list = new List<DestroyExitStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyExitStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyInviteOption en)
        {
            byte num;
            msg.Read(out num);
            en = (DestroyInviteOption)num;
        }

        public static void Read(Message msg, out List<DestroyInviteOption> list)
        {
            list = new List<DestroyInviteOption>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyInviteOption item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyJoinResult ty)
        {
            ty = new DestroyJoinResult();
            Marshaler.Read(msg, out ty.destroyRoomInfo);
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.stageMonsterInfoList);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.battleEncounter);
        }

        public static void Read(Message msg, out List<DestroyJoinResult> list)
        {
            list = new List<DestroyJoinResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyJoinResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyLiveJoinInvitation ty)
        {
            ty = new DestroyLiveJoinInvitation();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.bossID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.ownerUserInfo);
            Marshaler.Read(msg, out ty.remainSecToClose);
        }

        public static void Read(Message msg, out List<DestroyLiveJoinInvitation> list)
        {
            list = new List<DestroyLiveJoinInvitation>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyLiveJoinInvitation item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyLiveJoinUserInfo ty)
        {
            ty = new DestroyLiveJoinUserInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
        }

        public static void Read(Message msg, out List<DestroyLiveJoinUserInfo> list)
        {
            list = new List<DestroyLiveJoinUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyLiveJoinUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyLobbySyncInfo ty)
        {
            ty = new DestroyLobbySyncInfo();
            Marshaler.Read(msg, out ty.notifyType);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.simpleTeamInfo);
        }

        public static void Read(Message msg, out List<DestroyLobbySyncInfo> list)
        {
            list = new List<DestroyLobbySyncInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyLobbySyncInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyNotifyType en)
        {
            byte num;
            msg.Read(out num);
            en = (DestroyNotifyType)num;
        }

        public static void Read(Message msg, out List<DestroyNotifyType> list)
        {
            list = new List<DestroyNotifyType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyNotifyType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyOtherPlayerTeamInfo ty)
        {
            ty = new DestroyOtherPlayerTeamInfo();
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
        }

        public static void Read(Message msg, out List<DestroyOtherPlayerTeamInfo> list)
        {
            list = new List<DestroyOtherPlayerTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyOtherPlayerTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyReJoinResult ty)
        {
            ty = new DestroyReJoinResult();
            Marshaler.Read(msg, out ty.destroyRoomInfo);
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.stageMonsterInfoList);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.battleEncounter);
        }

        public static void Read(Message msg, out List<DestroyReJoinResult> list)
        {
            list = new List<DestroyReJoinResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyReJoinResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyStartResult ty)
        {
            ty = new DestroyStartResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.ingameSeed);
        }

        public static void Read(Message msg, out List<DestroyStartResult> list)
        {
            list = new List<DestroyStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroySyncInfo ty)
        {
            ty = new DestroySyncInfo();
            Marshaler.Read(msg, out ty.ingameSyncStr);
        }

        public static void Read(Message msg, out List<DestroySyncInfo> list)
        {
            list = new List<DestroySyncInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroySyncInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyUnitStatus ty)
        {
            ty = new DestroyUnitStatus();
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.isAlive);
        }

        public static void Read(Message msg, out List<DestroyUnitStatus> list)
        {
            list = new List<DestroyUnitStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyUnitStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyUserProfileInfo ty)
        {
            ty = new DestroyUserProfileInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.skinChangeIDList);
            Marshaler.Read(msg, out ty.weaponChangeIDList);
            Marshaler.Read(msg, out ty.headChangeIDList);
            Marshaler.Read(msg, out ty.skinHeadStyleChangedList);
            Marshaler.Read(msg, out ty.bossStageTopClearRegion);
            Marshaler.Read(msg, out ty.topClearStoryQuestID);
            Marshaler.Read(msg, out ty.userState);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.isAIEnable);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<DestroyUserProfileInfo> list)
        {
            list = new List<DestroyUserProfileInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyUserProfileInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DestroyUserState en)
        {
            byte num;
            msg.Read(out num);
            en = (DestroyUserState)num;
        }

        public static void Read(Message msg, out List<DestroyUserState> list)
        {
            list = new List<DestroyUserState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DestroyUserState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DiaBuyInfo ty)
        {
            ty = new DiaBuyInfo();
            Marshaler.Read(msg, out ty.shopMoneyID);
            Marshaler.Read(msg, out ty.buyCount);
        }

        public static void Read(Message msg, out List<DiaBuyInfo> list)
        {
            list = new List<DiaBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DiaBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DiaEventSubType en)
        {
            int num;
            msg.Read(out num);
            en = (DiaEventSubType)num;
        }

        public static void Read(Message msg, out List<DiaEventSubType> list)
        {
            list = new List<DiaEventSubType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DiaEventSubType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DisasterQuestClearResultInfo ty)
        {
            ty = new DisasterQuestClearResultInfo();
            Marshaler.Read(msg, out ty.questID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.removeItemResultInfoList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.apRewardInfoList);
        }

        public static void Read(Message msg, out List<DisasterQuestClearResultInfo> list)
        {
            list = new List<DisasterQuestClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DisasterQuestClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DropBoxGrade en)
        {
            byte num;
            msg.Read(out num);
            en = (DropBoxGrade)num;
        }

        public static void Read(Message msg, out List<DropBoxGrade> list)
        {
            list = new List<DropBoxGrade>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DropBoxGrade item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out DropItemInfo ty)
        {
            ty = new DropItemInfo();
            Marshaler.Read(msg, out ty.dropItemID);
            Marshaler.Read(msg, out ty.dropItemCount);
            Marshaler.Read(msg, out ty.dropBoxGrade);
            Marshaler.Read(msg, out ty.dropItemEvolutionCount);
            Marshaler.Read(msg, out ty.dropItemBuffAddCount);
            //Marshaler.Read(msg, out ty.dropItemOptionValue);
            //Marshaler.Read(msg, out ty.addPassiveIDList);
            //Marshaler.Read(msg, out ty.addPassiveValueList);
            //Marshaler.Read(msg, out ty.ownerHeroID);
            //Marshaler.Read(msg, out ty.heroCoinID);
            //Marshaler.Read(msg, out ty.heroCoinCount);
            //Marshaler.Read(msg, out ty.skinLevel);
            //Marshaler.Read(msg, out ty.skinExp);
            //Marshaler.Read(msg, out ty.skinAwaken);
            //Marshaler.Read(msg, out ty.skinMaxLevelCount);
            //Marshaler.Read(msg, out ty.heroGroupID);
            //Marshaler.Read(msg, out ty.costumeGroupID);
            //Marshaler.Read(msg, out ty.costumeReplaceItemID);
            //Marshaler.Read(msg, out ty.costumeReplaceItemCount);
            //Marshaler.Read(msg, out ty.upgradeCount);
            //Marshaler.Read(msg, out ty.ownerCostumeItemID);
            //Marshaler.Read(msg, out ty.expireDate);
            //Marshaler.Read(msg, out ty.weaponOptionMax);
            //Marshaler.Read(msg, out ty.selectedWeaponBaseOptionMax);
            //Marshaler.Read(msg, out ty.selectedWeaponRandomOptionFlag);
            //Marshaler.Read(msg, out ty.selectedWeaponRandomOptionValue);
            //Marshaler.Read(msg, out ty.selectedRandomPassiveIDList);
        }

        public static void Read(Message msg, out List<DropItemInfo> list)
        {
            list = new List<DropItemInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                DropItemInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EmergencyNoticeInfo ty)
        {
            ty = new EmergencyNoticeInfo();
            //Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.fromDate);
            Marshaler.Read(msg, out ty.toDate);
            Marshaler.Read(msg, out ty.maintenanceStartTime);
            Marshaler.Read(msg, out ty.maintenanceEndTime);
            Marshaler.Read(msg, out ty.targetOSType);
            Marshaler.Read(msg, out ty.isDisplayTime);
            Marshaler.Read(msg, out ty.displayTermSec);
            Marshaler.Read(msg, out ty.message);
        }

        public static void Read(Message msg, out List<EmergencyNoticeInfo> list)
        {
            list = new List<EmergencyNoticeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EmergencyNoticeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventAttendanceResult ty)
        {
            ty = new EventAttendanceResult();
            Marshaler.Read(msg, out ty.eventAttendanceInfoList);
            Marshaler.Read(msg, out ty.rewardItemInfoList);
            Marshaler.Read(msg, out ty.apRewardInfoList);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<EventAttendanceResult> list)
        {
            list = new List<EventAttendanceResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventAttendanceResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventAttendanceType en)
        {
            byte num;
            msg.Read(out num);
            en = (EventAttendanceType)num;
        }

        public static void Read(Message msg, out List<EventAttendanceType> list)
        {
            list = new List<EventAttendanceType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventAttendanceType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventAutoInfo ty)
        {
            ty = new EventAutoInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.userStageID);
            Marshaler.Read(msg, out ty.attackValueLv);
            Marshaler.Read(msg, out ty.criticalValueLv);
            Marshaler.Read(msg, out ty.criticalRateLv);
            Marshaler.Read(msg, out ty.monsterHP);
            Marshaler.Read(msg, out ty.rewardItemCount);
            Marshaler.Read(msg, out ty.boxState);
            Marshaler.Read(msg, out ty.boxSlotUpgrade);
            Marshaler.Read(msg, out ty.specialRewardIndex);
            Marshaler.Read(msg, out ty.checkUserTime);
            Marshaler.Read(msg, out ty.getExtraBoxCount);
        }

        public static void Read(Message msg, out List<EventAutoInfo> list)
        {
            list = new List<EventAutoInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventAutoInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventBasepointInfo ty)
        {
            ty = new EventBasepointInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.basepointID);
            Marshaler.Read(msg, out ty.lastClearLoopQuestID);
        }

        public static void Read(Message msg, out List<EventBasepointInfo> list)
        {
            list = new List<EventBasepointInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventBasepointInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventBingoExchangeInfo ty)
        {
            ty = new EventBingoExchangeInfo();
            Marshaler.Read(msg, out ty.exchangeId);
            Marshaler.Read(msg, out ty.count);
        }

        public static void Read(Message msg, out List<EventBingoExchangeInfo> list)
        {
            list = new List<EventBingoExchangeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventBingoExchangeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventBingoExchangeResult ty)
        {
            ty = new EventBingoExchangeResult();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.userEventBingoInfo);
            Marshaler.Read(msg, out ty.getNumberItemInfoList);
            Marshaler.Read(msg, out ty.getRewardItemInfoList);
            Marshaler.Read(msg, out ty.getAllClearRewardItemInfo);
            Marshaler.Read(msg, out ty.itemResultInfoList);
        }

        public static void Read(Message msg, out List<EventBingoExchangeResult> list)
        {
            list = new List<EventBingoExchangeResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventBingoExchangeResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventBingoRandomNumberResult ty)
        {
            ty = new EventBingoRandomNumberResult();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.userEventBingoInfo);
            Marshaler.Read(msg, out ty.getNumberItemInfoList);
            Marshaler.Read(msg, out ty.getRewardItemInfoList);
            Marshaler.Read(msg, out ty.getAllClearRewardItemInfo);
            Marshaler.Read(msg, out ty.itemResultInfoList);
        }

        public static void Read(Message msg, out List<EventBingoRandomNumberResult> list)
        {
            list = new List<EventBingoRandomNumberResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventBingoRandomNumberResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventConfirmGameRecordScoreInfo ty)
        {
            ty = new EventConfirmGameRecordScoreInfo();
            Marshaler.Read(msg, out ty.boxID);
            Marshaler.Read(msg, out ty.boxScore);
            Marshaler.Read(msg, out ty.boxRewardFlag);
        }

        public static void Read(Message msg, out List<EventConfirmGameRecordScoreInfo> list)
        {
            list = new List<EventConfirmGameRecordScoreInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventConfirmGameRecordScoreInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventConquestAreaClientSendInfo ty)
        {
            ty = new EventConquestAreaClientSendInfo();
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isRewarded);
        }

        public static void Read(Message msg, out List<EventConquestAreaClientSendInfo> list)
        {
            list = new List<EventConquestAreaClientSendInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventConquestAreaClientSendInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventConquestProductionDepotClientSendInfo ty)
        {
            ty = new EventConquestProductionDepotClientSendInfo();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.level);
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.upgradeRewardFlag);
            Marshaler.Read(msg, out ty.getRewardTime);
            Marshaler.Read(msg, out ty.updateDateTimeList);
        }

        public static void Read(Message msg, out List<EventConquestProductionDepotClientSendInfo> list)
        {
            list = new List<EventConquestProductionDepotClientSendInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventConquestProductionDepotClientSendInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventConquestUnitClientSendInfo ty)
        {
            ty = new EventConquestUnitClientSendInfo();
            Marshaler.Read(msg, out ty.unitID);
            Marshaler.Read(msg, out ty.areaID);
        }

        public static void Read(Message msg, out List<EventConquestUnitClientSendInfo> list)
        {
            list = new List<EventConquestUnitClientSendInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventConquestUnitClientSendInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventCookingResult ty)
        {
            ty = new EventCookingResult();
            Marshaler.Read(msg, out ty.successType);
            Marshaler.Read(msg, out ty.dailyMeliodasCookingCount);
            Marshaler.Read(msg, out ty.useMaterialItemInfoList);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.userRecipeInfo);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.cookingCount);
            Marshaler.Read(msg, out ty.npcResult);
            Marshaler.Read(msg, out ty.isImmediately);
        }

        public static void Read(Message msg, out List<EventCookingResult> list)
        {
            list = new List<EventCookingResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventCookingResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventDescentBossEventStageClearResultInfo ty)
        {
            ty = new EventDescentBossEventStageClearResultInfo();
            Marshaler.Read(msg, out ty.userDescentBossEventInfoForClient);
            Marshaler.Read(msg, out ty.clearMissionIDList);
            Marshaler.Read(msg, out ty.addPoint);
            Marshaler.Read(msg, out ty.addBonusPoint);
        }

        public static void Read(Message msg, out List<EventDescentBossEventStageClearResultInfo> list)
        {
            list = new List<EventDescentBossEventStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventDescentBossEventStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventDiceBaseType en)
        {
            byte num;
            msg.Read(out num);
            en = (EventDiceBaseType)num;
        }

        public static void Read(Message msg, out List<EventDiceBaseType> list)
        {
            list = new List<EventDiceBaseType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventDiceBaseType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventDiceQuestionRewardType en)
        {
            int num;
            msg.Read(out num);
            en = (EventDiceQuestionRewardType)num;
        }

        public static void Read(Message msg, out List<EventDiceQuestionRewardType> list)
        {
            list = new List<EventDiceQuestionRewardType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventDiceQuestionRewardType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventDisasterDestroyClearInfo ty)
        {
            ty = new EventDisasterDestroyClearInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.firstClearInfo);
        }

        public static void Read(Message msg, out List<EventDisasterDestroyClearInfo> list)
        {
            list = new List<EventDisasterDestroyClearInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventDisasterDestroyClearInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventExchangeCardDetailInfo ty)
        {
            ty = new EventExchangeCardDetailInfo();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.status);
        }

        public static void Read(Message msg, out List<EventExchangeCardDetailInfo> list)
        {
            list = new List<EventExchangeCardDetailInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventExchangeCardDetailInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventExchangeCardInfo ty)
        {
            ty = new EventExchangeCardInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.resetCount);
            Marshaler.Read(msg, out ty.selectCount);
            Marshaler.Read(msg, out ty.isCompleteChance);
            Marshaler.Read(msg, out ty.remainChanceSelectCount);
            Marshaler.Read(msg, out ty.selectedRewardIDList);
            Marshaler.Read(msg, out ty.selectedRewardInfoList);
            Marshaler.Read(msg, out ty.detailInfoList);
        }

        public static void Read(Message msg, out List<EventExchangeCardInfo> list)
        {
            list = new List<EventExchangeCardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventExchangeCardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventLadderResult ty)
        {
            ty = new EventLadderResult();
            Marshaler.Read(msg, out ty.midRewardIDList);
            Marshaler.Read(msg, out ty.topRewardIDList);
            Marshaler.Read(msg, out ty.character1RewardIDList);
            Marshaler.Read(msg, out ty.character2RewardIDList);
        }

        public static void Read(Message msg, out List<EventLadderResult> list)
        {
            list = new List<EventLadderResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventLadderResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventLobbyBuffInfo ty)
        {
            ty = new EventLobbyBuffInfo();
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.remainCount);
            Marshaler.Read(msg, out ty.remainSecToRemove);
            //Marshaler.Read(msg, out ty.endDateTime);
        }

        public static void Read(Message msg, out List<EventLobbyBuffInfo> list)
        {
            list = new List<EventLobbyBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventLobbyBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventLobbyBuffPointInfo ty)
        {
            ty = new EventLobbyBuffPointInfo();
            Marshaler.Read(msg, out ty.count);
            Marshaler.Read(msg, out ty.updateTime);
            Marshaler.Read(msg, out ty.remainSecondToRecharge);
            Marshaler.Read(msg, out ty.mileage);
        }

        public static void Read(Message msg, out List<EventLobbyBuffPointInfo> list)
        {
            list = new List<EventLobbyBuffPointInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventLobbyBuffPointInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventLobbyGiftResult ty)
        {
            ty = new EventLobbyGiftResult();
            Marshaler.Read(msg, out ty.rewardItemID);
            Marshaler.Read(msg, out ty.rewardItemCount);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.eventLobbyGiftInfo);
            Marshaler.Read(msg, out ty.ItemResultInfo);
        }

        public static void Read(Message msg, out List<EventLobbyGiftResult> list)
        {
            list = new List<EventLobbyGiftResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventLobbyGiftResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventLuckyBoxReward ty)
        {
            ty = new EventLuckyBoxReward();
            Marshaler.Read(msg, out ty.rewardID);
            Marshaler.Read(msg, out ty.rewardedCount);
        }

        public static void Read(Message msg, out List<EventLuckyBoxReward> list)
        {
            list = new List<EventLuckyBoxReward>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventLuckyBoxReward item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventMazeBuffInfo ty)
        {
            ty = new EventMazeBuffInfo();
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.level);
        }

        public static void Read(Message msg, out List<EventMazeBuffInfo> list)
        {
            list = new List<EventMazeBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventMazeBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventMazeSeasonShopBuyInfo ty)
        {
            ty = new EventMazeSeasonShopBuyInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.productID);
            Marshaler.Read(msg, out ty.dailyBuyCount);
            Marshaler.Read(msg, out ty.seasonBuyCount);
        }

        public static void Read(Message msg, out List<EventMazeSeasonShopBuyInfo> list)
        {
            list = new List<EventMazeSeasonShopBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventMazeSeasonShopBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventMazeSeasonShopInfo ty)
        {
            ty = new EventMazeSeasonShopInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.buyPoint);
            Marshaler.Read(msg, out ty.remainSeasonShopStartSec);
            Marshaler.Read(msg, out ty.remainSeasonShopEndSec);
            Marshaler.Read(msg, out ty.currentSeasonShopNeedItemList);
        }

        public static void Read(Message msg, out List<EventMazeSeasonShopInfo> list)
        {
            list = new List<EventMazeSeasonShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventMazeSeasonShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventMissionClearRequestInfo ty)
        {
            ty = new EventMissionClearRequestInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.chainID);
            Marshaler.Read(msg, out ty.chainIndex);
        }

        public static void Read(Message msg, out List<EventMissionClearRequestInfo> list)
        {
            list = new List<EventMissionClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventMissionClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventMoleGameRankInfo ty)
        {
            ty = new EventMoleGameRankInfo();
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.redisEventMoleGameRankInfo);
        }

        public static void Read(Message msg, out List<EventMoleGameRankInfo> list)
        {
            list = new List<EventMoleGameRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventMoleGameRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventMoleGameRecordScoreInfo ty)
        {
            ty = new EventMoleGameRecordScoreInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.recordType);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.rewardFlag);
        }

        public static void Read(Message msg, out List<EventMoleGameRecordScoreInfo> list)
        {
            list = new List<EventMoleGameRecordScoreInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventMoleGameRecordScoreInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventOpenType en)
        {
            byte num;
            msg.Read(out num);
            en = (EventOpenType)num;
        }

        public static void Read(Message msg, out List<EventOpenType> list)
        {
            list = new List<EventOpenType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventOpenType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventPacketInfo ty)
        {
            ty = new EventPacketInfo();
            Marshaler.Read(msg, out ty.serverEventInfoList);
            Marshaler.Read(msg, out ty.userExchangeInfoList);
            Marshaler.Read(msg, out ty.userWorldAreaStageEventInfoList);
            Marshaler.Read(msg, out ty.userFreeStageEventInfoList);
            Marshaler.Read(msg, out ty.userPlayCountEventInfoList);
            Marshaler.Read(msg, out ty.userGachaEventInfoList);
            Marshaler.Read(msg, out ty.userStepupGachaEventInfoList);
            Marshaler.Read(msg, out ty.userAttendanceEventInfoList);
            Marshaler.Read(msg, out ty.userMissionEventInfoList);
            Marshaler.Read(msg, out ty.userListStageEventInfoList);
            Marshaler.Read(msg, out ty.userFinalBossStageEventInfoList);
            Marshaler.Read(msg, out ty.userDonationEventInfoList);
            Marshaler.Read(msg, out ty.userDiaBuyEventInfoList);
            Marshaler.Read(msg, out ty.userSeasonPassRankRewardInfoList);
            Marshaler.Read(msg, out ty.userPaybackInfoList);
            Marshaler.Read(msg, out ty.userGamblePaybackInfoList);
            Marshaler.Read(msg, out ty.userGagueEventInfoList);
            Marshaler.Read(msg, out ty.userChallengeBossEventInfoClientSendList);
            Marshaler.Read(msg, out ty.userBingGachaEventInfoList);
            Marshaler.Read(msg, out ty.userGlobalDropEventInfoList);
            Marshaler.Read(msg, out ty.userChallengeDestroyEventInfoList);
            Marshaler.Read(msg, out ty.userTimeMissionEventInfoList);
            Marshaler.Read(msg, out ty.userLobbyGiftEventInfoList);
            Marshaler.Read(msg, out ty.userSnsShareEventInfoList);
            Marshaler.Read(msg, out ty.userLobbyDecorationEventInfoList);
            Marshaler.Read(msg, out ty.userWeeklyStageEventInfoList);
            Marshaler.Read(msg, out ty.userBlitzStageEventInfoList);
            Marshaler.Read(msg, out ty.userTreasureHuntEventInfoList);
            Marshaler.Read(msg, out ty.userKOFBritanniaEventInfoList);
            Marshaler.Read(msg, out ty.userExchangeCardEventInfoList);
            Marshaler.Read(msg, out ty.userProvisionEventInfoList);
            Marshaler.Read(msg, out ty.userPvpWinCountEventInfoList);
            Marshaler.Read(msg, out ty.userRandomBoxEventInfoList);
            Marshaler.Read(msg, out ty.userRecipeEventInfoList);
            Marshaler.Read(msg, out ty.userChapterClearEventInfoList);
            Marshaler.Read(msg, out ty.userPredictEventInfoList);
            Marshaler.Read(msg, out ty.userDescentBossEventInfoList);
            Marshaler.Read(msg, out ty.userAutoEventInfoList);
            Marshaler.Read(msg, out ty.userPatrolEventInfoList);
            Marshaler.Read(msg, out ty.userCheerEventInfoList);
            Marshaler.Read(msg, out ty.userEventDiceInfoList);
            Marshaler.Read(msg, out ty.userSkinOneStepEvolutionEventInfoList);
            Marshaler.Read(msg, out ty.userEventPuzzleInfoList);
            Marshaler.Read(msg, out ty.userStepupMissionEventInfoList);
            Marshaler.Read(msg, out ty.userAncientWarInfoList);
            Marshaler.Read(msg, out ty.userArtifactWishEventInfoList);
            Marshaler.Read(msg, out ty.userGachaWishEventInfoList);
            Marshaler.Read(msg, out ty.userMazeEventInfoList);
            Marshaler.Read(msg, out ty.userGachaEventOnceInfo);
            Marshaler.Read(msg, out ty.useEventMoleGameInfoList);
            Marshaler.Read(msg, out ty.userEventLobbyBuffInfoList);
            Marshaler.Read(msg, out ty.userEventConquestInfoList);
            Marshaler.Read(msg, out ty.userEventLuckybagInfoList);
            Marshaler.Read(msg, out ty.userEventGambleBoxInfoList);
            Marshaler.Read(msg, out ty.userEventLuckyBoxInfoList);
            Marshaler.Read(msg, out ty.userEventRoadInfoList);
            Marshaler.Read(msg, out ty.userEventConfirmGameInfoList);
            Marshaler.Read(msg, out ty.userEventBalloonDartInfoList);
        }

        public static void Read(Message msg, out List<EventPacketInfo> list)
        {
            list = new List<EventPacketInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventPacketInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventPatrolInfo ty)
        {
            ty = new EventPatrolInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            //Marshaler.Read(msg, out ty.daySeq);
        }

        public static void Read(Message msg, out List<EventPatrolInfo> list)
        {
            list = new List<EventPatrolInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventPatrolInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventPredictInfo ty)
        {
            ty = new EventPredictInfo();
            //Marshaler.Read(msg, out ty.needSave);
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.rewardItemList);
            Marshaler.Read(msg, out ty.userTotalScore);
            Marshaler.Read(msg, out ty.userDailyCount);
            Marshaler.Read(msg, out ty.specialRewardIndex);
        }

        public static void Read(Message msg, out List<EventPredictInfo> list)
        {
            list = new List<EventPredictInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventPredictInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventPuzzleBlockScoreInfo ty)
        {
            ty = new EventPuzzleBlockScoreInfo();
            Marshaler.Read(msg, out ty.blockID);
            Marshaler.Read(msg, out ty.blockScore);
            Marshaler.Read(msg, out ty.blockMatchCount);
        }

        public static void Read(Message msg, out List<EventPuzzleBlockScoreInfo> list)
        {
            list = new List<EventPuzzleBlockScoreInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventPuzzleBlockScoreInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventQuestClearResultInfo ty)
        {
            ty = new EventQuestClearResultInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.questID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.removeItemResultInfoList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.basepointInfo);
            Marshaler.Read(msg, out ty.apRewardInfoList);
            Marshaler.Read(msg, out ty.resetQuestIDList);
        }

        public static void Read(Message msg, out List<EventQuestClearResultInfo> list)
        {
            list = new List<EventQuestClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventQuestClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventRandomBoxChangeType en)
        {
            byte num;
            msg.Read(out num);
            en = (EventRandomBoxChangeType)num;
        }

        public static void Read(Message msg, out List<EventRandomBoxChangeType> list)
        {
            list = new List<EventRandomBoxChangeType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventRandomBoxChangeType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventRandomBoxInfo ty)
        {
            ty = new EventRandomBoxInfo();
            Marshaler.Read(msg, out ty.boxType);
            Marshaler.Read(msg, out ty.rewardId);
        }

        public static void Read(Message msg, out List<EventRandomBoxInfo> list)
        {
            list = new List<EventRandomBoxInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventRandomBoxInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventRandomBoxType en)
        {
            byte num;
            msg.Read(out num);
            en = (EventRandomBoxType)num;
        }

        public static void Read(Message msg, out List<EventRandomBoxType> list)
        {
            list = new List<EventRandomBoxType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventRandomBoxType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventShopProductInfo ty)
        {
            ty = new EventShopProductInfo();
            Marshaler.Read(msg, out ty.slotIndex);
            Marshaler.Read(msg, out ty.productItemID);
            Marshaler.Read(msg, out ty.productItemCount);
            Marshaler.Read(msg, out ty.productBuyCount);
            Marshaler.Read(msg, out ty.productMaxCount);
            Marshaler.Read(msg, out ty.priceItemID);
            Marshaler.Read(msg, out ty.priceItemCount);
        }

        public static void Read(Message msg, out List<EventShopProductInfo> list)
        {
            list = new List<EventShopProductInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventShopProductInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventTreasureHuntMissionType en)
        {
            byte num;
            msg.Read(out num);
            en = (EventTreasureHuntMissionType)num;
        }

        public static void Read(Message msg, out List<EventTreasureHuntMissionType> list)
        {
            list = new List<EventTreasureHuntMissionType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventTreasureHuntMissionType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out EventTreasureHuntPointType en)
        {
            byte num;
            msg.Read(out num);
            en = (EventTreasureHuntPointType)num;
        }

        public static void Read(Message msg, out List<EventTreasureHuntPointType> list)
        {
            list = new List<EventTreasureHuntPointType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                EventTreasureHuntPointType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ExtensionStageInfo ty)
        {
            ty = new ExtensionStageInfo();
            Marshaler.Read(msg, out ty.openType);
            Marshaler.Read(msg, out ty.remainPlayTimeSec);
            Marshaler.Read(msg, out ty.nextOpenTimeSec);
            Marshaler.Read(msg, out ty.remainKeyOpenTimeSec);
            Marshaler.Read(msg, out ty.dayOfWeek);
            Marshaler.Read(msg, out ty.openStageTypeList);
        }

        public static void Read(Message msg, out List<ExtensionStageInfo> list)
        {
            list = new List<ExtensionStageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ExtensionStageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FameResultInfo ty)
        {
            ty = new FameResultInfo();
            Marshaler.Read(msg, out ty.fameId);
            Marshaler.Read(msg, out ty.userFameScoreList);
        }

        public static void Read(Message msg, out List<FameResultInfo> list)
        {
            list = new List<FameResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FameResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FameScoreInfo ty)
        {
            ty = new FameScoreInfo();
            //Marshaler.Read(msg, out ty.rewardYN);
            Marshaler.Read(msg, out ty.checkListType);
            Marshaler.Read(msg, out ty.score);
        }

        public static void Read(Message msg, out List<FameScoreInfo> list)
        {
            list = new List<FameScoreInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FameScoreInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossBattleScoreInfo ty)
        {
            ty = new FinalBossBattleScoreInfo();
            Marshaler.Read(msg, out ty.finalBossScoreGroupID);
            Marshaler.Read(msg, out ty.missionGroupID);
            Marshaler.Read(msg, out ty.battleScoreGroupID);
            Marshaler.Read(msg, out ty.vowGroupID);
            Marshaler.Read(msg, out ty.vowSelectMax);
            Marshaler.Read(msg, out ty.remainSec);
        }

        public static void Read(Message msg, out List<FinalBossBattleScoreInfo> list)
        {
            list = new List<FinalBossBattleScoreInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossBattleScoreInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossDifficulty en)
        {
            byte num;
            msg.Read(out num);
            en = (FinalBossDifficulty)num;
        }

        public static void Read(Message msg, out List<FinalBossDifficulty> list)
        {
            list = new List<FinalBossDifficulty>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossDifficulty item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossFameRankingInfo ty)
        {
            ty = new FinalBossFameRankingInfo();
            //Marshaler.Read(msg, out ty.recordTime);
            //Marshaler.Read(msg, out ty.scoreReload);
            Marshaler.Read(msg, out ty.fameID);
            Marshaler.Read(msg, out ty.keywordID);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.ranking);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userRankExp);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.sortType);
        }

        public static void Read(Message msg, out List<FinalBossFameRankingInfo> list)
        {
            list = new List<FinalBossFameRankingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossFameRankingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossGroupInfo ty)
        {
            ty = new FinalBossGroupInfo();
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.remainActiveStartSec);
            Marshaler.Read(msg, out ty.remainActiveEndSec);
            Marshaler.Read(msg, out ty.currentPlayCount);
        }

        public static void Read(Message msg, out List<FinalBossGroupInfo> list)
        {
            list = new List<FinalBossGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossSeasonInfo ty)
        {
            ty = new FinalBossSeasonInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.remainSeasonStartSec);
            Marshaler.Read(msg, out ty.remainSeasonEndSec);
        }

        public static void Read(Message msg, out List<FinalBossSeasonInfo> list)
        {
            list = new List<FinalBossSeasonInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossSeasonInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossSeasonShopBuyInfo ty)
        {
            ty = new FinalBossSeasonShopBuyInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.productID);
            Marshaler.Read(msg, out ty.dailyBuyCount);
            Marshaler.Read(msg, out ty.seasonBuyCount);
        }

        public static void Read(Message msg, out List<FinalBossSeasonShopBuyInfo> list)
        {
            list = new List<FinalBossSeasonShopBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossSeasonShopBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossSeasonShopInfo ty)
        {
            ty = new FinalBossSeasonShopInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.remainSeasonShopStartSec);
            Marshaler.Read(msg, out ty.remainSeasonShopEndSec);
            Marshaler.Read(msg, out ty.currentSeasonShopNeedItemList);
        }

        public static void Read(Message msg, out List<FinalBossSeasonShopInfo> list)
        {
            list = new List<FinalBossSeasonShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossSeasonShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossStageResult ty)
        {
            ty = new FinalBossStageResult();
            Marshaler.Read(msg, out ty.missionPoint);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.vowPoint);
        }

        public static void Read(Message msg, out List<FinalBossStageResult> list)
        {
            list = new List<FinalBossStageResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossStageResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossUserRankInfo ty)
        {
            ty = new FinalBossUserRankInfo();
            Marshaler.Read(msg, out ty.upperRewardRemainRankPoint);
            Marshaler.Read(msg, out ty.upperRankRewardRemainRankPoint);
            Marshaler.Read(msg, out ty.redisFinalBossRankInfo);
        }

        public static void Read(Message msg, out List<FinalBossUserRankInfo> list)
        {
            list = new List<FinalBossUserRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossUserRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FinalBossVowInfo ty)
        {
            ty = new FinalBossVowInfo();
            Marshaler.Read(msg, out ty.stageId);
            Marshaler.Read(msg, out ty.vowIdList);
            //Marshaler.Read(msg, out ty.expireTime);
        }

        public static void Read(Message msg, out List<FinalBossVowInfo> list)
        {
            list = new List<FinalBossVowInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FinalBossVowInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FirstBuyShopType en)
        {
            byte num;
            msg.Read(out num);
            en = (FirstBuyShopType)num;
        }

        public static void Read(Message msg, out List<FirstBuyShopType> list)
        {
            list = new List<FirstBuyShopType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FirstBuyShopType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FoodBuffInfo ty)
        {
            ty = new FoodBuffInfo();
            Marshaler.Read(msg, out ty.foodItemID);
            Marshaler.Read(msg, out ty.useCount);
            Marshaler.Read(msg, out ty.isAutoFoodUse);
        }

        public static void Read(Message msg, out List<FoodBuffInfo> list)
        {
            list = new List<FoodBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FoodBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendBattleSkinInfo ty)
        {
            ty = new FriendBattleSkinInfo();
            Marshaler.Read(msg, out ty.battleSkinInfo);
            Marshaler.Read(msg, out ty.skinAwaken);
        }

        public static void Read(Message msg, out List<FriendBattleSkinInfo> list)
        {
            list = new List<FriendBattleSkinInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendBattleSkinInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendCookingEatResult ty)
        {
            ty = new FriendCookingEatResult();
            Marshaler.Read(msg, out ty.isFriend);
            Marshaler.Read(msg, out ty.friendCookingEatAlready);
            Marshaler.Read(msg, out ty.friendCookingEatTotalCount);
            Marshaler.Read(msg, out ty.buffInfo);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<FriendCookingEatResult> list)
        {
            list = new List<FriendCookingEatResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendCookingEatResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendGuildInfo ty)
        {
            ty = new FriendGuildInfo();
            Marshaler.Read(msg, out ty.friendUSN);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildLevel);
            Marshaler.Read(msg, out ty.guildEmblemIconID);
            Marshaler.Read(msg, out ty.guildEmblemSubIconID);
            Marshaler.Read(msg, out ty.guildEmblemBgID);
        }

        public static void Read(Message msg, out List<FriendGuildInfo> list)
        {
            list = new List<FriendGuildInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendGuildInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendInfo ty)
        {
            ty = new FriendInfo();
            Marshaler.Read(msg, out ty.friendUSN);
            Marshaler.Read(msg, out ty.friendNickname);
            Marshaler.Read(msg, out ty.friendWantToSay);
            Marshaler.Read(msg, out ty.friendExp);
            Marshaler.Read(msg, out ty.friendHeroID);
            Marshaler.Read(msg, out ty.friendSkinID);
            Marshaler.Read(msg, out ty.friendAfterLoginMin);
            Marshaler.Read(msg, out ty.friendState);
            Marshaler.Read(msg, out ty.loginState);
            Marshaler.Read(msg, out ty.isFriendPointSend);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.friendCookingEatAlready);
            Marshaler.Read(msg, out ty.friendRecipeOrderCount);
            Marshaler.Read(msg, out ty.playTitleID);
            //Marshaler.Read(msg, out ty.cookingEatDailySeq);
            //Marshaler.Read(msg, out ty.friendCookingEatDailySeq);
        }

        public static void Read(Message msg, out List<FriendInfo> list)
        {
            list = new List<FriendInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendLobbyFurnitureInfo ty)
        {
            ty = new FriendLobbyFurnitureInfo();
            Marshaler.Read(msg, out ty.furnitureGroup);
            Marshaler.Read(msg, out ty.furnitureID);
            Marshaler.Read(msg, out ty.buffFurnitureID);
        }

        public static void Read(Message msg, out List<FriendLobbyFurnitureInfo> list)
        {
            list = new List<FriendLobbyFurnitureInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendLobbyFurnitureInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendLobbyInfo ty)
        {
            ty = new FriendLobbyInfo();
            Marshaler.Read(msg, out ty.friendUSN);
            Marshaler.Read(msg, out ty.friendNickName);
            Marshaler.Read(msg, out ty.friendExp);
            Marshaler.Read(msg, out ty.friendCookingEatAlready);
            Marshaler.Read(msg, out ty.friendCookingEatTotalCount);
            Marshaler.Read(msg, out ty.friendLobbyNpcInfoList);
            Marshaler.Read(msg, out ty.friendLobbyVisualType);
            Marshaler.Read(msg, out ty.friendLobbyFurnitureInfoList);
            Marshaler.Read(msg, out ty.topClearMainStageID);
            Marshaler.Read(msg, out ty.storyQuestProgressInfo);
            Marshaler.Read(msg, out ty.userTutorialInfoLIst);
            Marshaler.Read(msg, out ty.friendMusicInfo);
        }

        public static void Read(Message msg, out List<FriendLobbyInfo> list)
        {
            list = new List<FriendLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendLobbyMusicInfo ty)
        {
            ty = new FriendLobbyMusicInfo();
            Marshaler.Read(msg, out ty.playMusicIndex);
            Marshaler.Read(msg, out ty.musicInstrumentID);
            Marshaler.Read(msg, out ty.editMusicInfoList);
        }

        public static void Read(Message msg, out List<FriendLobbyMusicInfo> list)
        {
            list = new List<FriendLobbyMusicInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendLobbyMusicInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendLobbyNpcInfo ty)
        {
            ty = new FriendLobbyNpcInfo();
            Marshaler.Read(msg, out ty.guestID);
            Marshaler.Read(msg, out ty.costumeID);
            Marshaler.Read(msg, out ty.subCostumeID);
        }

        public static void Read(Message msg, out List<FriendLobbyNpcInfo> list)
        {
            list = new List<FriendLobbyNpcInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendLobbyNpcInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchBattleStartResult ty)
        {
            ty = new FriendlyMatchBattleStartResult();
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.isBuffUsed);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.useItemResultInfo);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
        }

        public static void Read(Message msg, out List<FriendlyMatchBattleStartResult> list)
        {
            list = new List<FriendlyMatchBattleStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchBattleStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchChatMessage ty)
        {
            ty = new FriendlyMatchChatMessage();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.chatType);
            Marshaler.Read(msg, out ty.stampID);
            Marshaler.Read(msg, out ty.message);
            Marshaler.Read(msg, out ty.chatDate);
        }

        public static void Read(Message msg, out List<FriendlyMatchChatMessage> list)
        {
            list = new List<FriendlyMatchChatMessage>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchChatMessage item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchChatType en)
        {
            byte num;
            msg.Read(out num);
            en = (FriendlyMatchChatType)num;
        }

        public static void Read(Message msg, out List<FriendlyMatchChatType> list)
        {
            list = new List<FriendlyMatchChatType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchChatType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchClearRequest ty)
        {
            ty = new FriendlyMatchClearRequest();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.missionRequest);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.isAutoPlay);
            Marshaler.Read(msg, out ty.turnCount);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.teamInfo);
        }

        public static void Read(Message msg, out List<FriendlyMatchClearRequest> list)
        {
            list = new List<FriendlyMatchClearRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchClearRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchClearResult ty)
        {
            ty = new FriendlyMatchClearResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.playCountEventInfoList);
            Marshaler.Read(msg, out ty.usedFoodID);
        }

        public static void Read(Message msg, out List<FriendlyMatchClearResult> list)
        {
            list = new List<FriendlyMatchClearResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchClearResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchClientSendRoomInfo ty)
        {
            ty = new FriendlyMatchClientSendRoomInfo();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.matchMode);
            Marshaler.Read(msg, out ty.userCount);
            Marshaler.Read(msg, out ty.ownerUSN);
            Marshaler.Read(msg, out ty.ownerNickname);
            Marshaler.Read(msg, out ty.ownerUserExp);
            Marshaler.Read(msg, out ty.ownerSkinID);
            Marshaler.Read(msg, out ty.modeID);
        }

        public static void Read(Message msg, out List<FriendlyMatchClientSendRoomInfo> list)
        {
            list = new List<FriendlyMatchClientSendRoomInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchClientSendRoomInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchCreateResult ty)
        {
            ty = new FriendlyMatchCreateResult();
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.matchMode);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.modeID);
            Marshaler.Read(msg, out ty.passiveID);
        }

        public static void Read(Message msg, out List<FriendlyMatchCreateResult> list)
        {
            list = new List<FriendlyMatchCreateResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchCreateResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchInviteOption en)
        {
            byte num;
            msg.Read(out num);
            en = (FriendlyMatchInviteOption)num;
        }

        public static void Read(Message msg, out List<FriendlyMatchInviteOption> list)
        {
            list = new List<FriendlyMatchInviteOption>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchInviteOption item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchJoinResult ty)
        {
            ty = new FriendlyMatchJoinResult();
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
        }

        public static void Read(Message msg, out List<FriendlyMatchJoinResult> list)
        {
            list = new List<FriendlyMatchJoinResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchJoinResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchObserveStartResult ty)
        {
            ty = new FriendlyMatchObserveStartResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.ingameSeed);
            Marshaler.Read(msg, out ty.otherUSN);
            Marshaler.Read(msg, out ty.otherTeamIndex);
            Marshaler.Read(msg, out ty.simpleTeamInfo);
        }

        public static void Read(Message msg, out List<FriendlyMatchObserveStartResult> list)
        {
            list = new List<FriendlyMatchObserveStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchObserveStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchStartResult ty)
        {
            ty = new FriendlyMatchStartResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.ingameSeed);
            Marshaler.Read(msg, out ty.otherUSN);
            Marshaler.Read(msg, out ty.otherTeamIndex);
        }

        public static void Read(Message msg, out List<FriendlyMatchStartResult> list)
        {
            list = new List<FriendlyMatchStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchSyncInfo ty)
        {
            ty = new FriendlyMatchSyncInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.foodBuffInfo);
        }

        public static void Read(Message msg, out List<FriendlyMatchSyncInfo> list)
        {
            list = new List<FriendlyMatchSyncInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchSyncInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchUserProfileInfo ty)
        {
            ty = new FriendlyMatchUserProfileInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.skinChangeIDList);
            Marshaler.Read(msg, out ty.weaponChangeIDList);
            Marshaler.Read(msg, out ty.headChangeIDList);
            Marshaler.Read(msg, out ty.skinHeadStyleChangedList);
            Marshaler.Read(msg, out ty.bossStageTopClearRegion);
            Marshaler.Read(msg, out ty.topClearStoryQuestID);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<FriendlyMatchUserProfileInfo> list)
        {
            list = new List<FriendlyMatchUserProfileInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchUserProfileInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchUserState en)
        {
            byte num;
            msg.Read(out num);
            en = (FriendlyMatchUserState)num;
        }

        public static void Read(Message msg, out List<FriendlyMatchUserState> list)
        {
            list = new List<FriendlyMatchUserState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchUserState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendlyMatchUserStatusInfo ty)
        {
            ty = new FriendlyMatchUserStatusInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.status);
        }

        public static void Read(Message msg, out List<FriendlyMatchUserStatusInfo> list)
        {
            list = new List<FriendlyMatchUserStatusInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendlyMatchUserStatusInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendRecipeOrderInfo ty)
        {
            ty = new FriendRecipeOrderInfo();
            Marshaler.Read(msg, out ty.slotNumber);
            Marshaler.Read(msg, out ty.recipeID);
        }

        public static void Read(Message msg, out List<FriendRecipeOrderInfo> list)
        {
            list = new List<FriendRecipeOrderInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendRecipeOrderInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out FriendState en)
        {
            byte num;
            msg.Read(out num);
            en = (FriendState)num;
        }

        public static void Read(Message msg, out List<FriendState> list)
        {
            list = new List<FriendState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                FriendState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GambleAmountType en)
        {
            byte num;
            msg.Read(out num);
            en = (GambleAmountType)num;
        }

        public static void Read(Message msg, out List<GambleAmountType> list)
        {
            list = new List<GambleAmountType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GambleAmountType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GambleCheckSumInfo ty)
        {
            ty = new GambleCheckSumInfo();
            Marshaler.Read(msg, out ty.gambleGroup);
            Marshaler.Read(msg, out ty.hashValue);
        }

        public static void Read(Message msg, out List<GambleCheckSumInfo> list)
        {
            list = new List<GambleCheckSumInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GambleCheckSumInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GambleGaugeType en)
        {
            byte num;
            msg.Read(out num);
            en = (GambleGaugeType)num;
        }

        public static void Read(Message msg, out List<GambleGaugeType> list)
        {
            list = new List<GambleGaugeType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GambleGaugeType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GamblePriceType en)
        {
            byte num;
            msg.Read(out num);
            en = (GamblePriceType)num;
        }

        public static void Read(Message msg, out List<GamblePriceType> list)
        {
            list = new List<GamblePriceType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GamblePriceType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GambleShopBuyRequest ty)
        {
            ty = new GambleShopBuyRequest();
            Marshaler.Read(msg, out ty.gambleGroup);
            Marshaler.Read(msg, out ty.amountType);
            Marshaler.Read(msg, out ty.priceType);
            Marshaler.Read(msg, out ty.adViewContentType);
        }

        public static void Read(Message msg, out List<GambleShopBuyRequest> list)
        {
            list = new List<GambleShopBuyRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GambleShopBuyRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GambleShopInfo ty)
        {
            ty = new GambleShopInfo();
            Marshaler.Read(msg, out ty.gambleGroup);
            Marshaler.Read(msg, out ty.currentRotationGroup);
            Marshaler.Read(msg, out ty.currentRotationGroupRemainSec);
        }

        public static void Read(Message msg, out List<GambleShopInfo> list)
        {
            list = new List<GambleShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GambleShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GambleTimeSwitchLobbyInfo ty)
        {
            ty = new GambleTimeSwitchLobbyInfo();
            Marshaler.Read(msg, out ty.currentGambleTimeSwitchID);
            Marshaler.Read(msg, out ty.remainSec);
        }

        public static void Read(Message msg, out List<GambleTimeSwitchLobbyInfo> list)
        {
            list = new List<GambleTimeSwitchLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GambleTimeSwitchLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GlobalItemDropInfo ty)
        {
            ty = new GlobalItemDropInfo();
            Marshaler.Read(msg, out ty.itemID);
            Marshaler.Read(msg, out ty.itemCount);
            //Marshaler.Read(msg, out ty.index);
        }

        public static void Read(Message msg, out List<GlobalItemDropInfo> list)
        {
            list = new List<GlobalItemDropInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GlobalItemDropInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildAttendanceResult ty)
        {
            ty = new GuildAttendanceResult();
            Marshaler.Read(msg, out ty.bAttendnaceRewardEnable);
            Marshaler.Read(msg, out ty.attendanceCount);
            Marshaler.Read(msg, out ty.remainSecToAttendanceEnd);
            Marshaler.Read(msg, out ty.prevAttendCount);
            Marshaler.Read(msg, out ty.bAttendOccur);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.guildRewardResult);
        }

        public static void Read(Message msg, out List<GuildAttendanceResult> list)
        {
            list = new List<GuildAttendanceResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildAttendanceResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildAttendanceRewardResult ty)
        {
            ty = new GuildAttendanceRewardResult();
            Marshaler.Read(msg, out ty.addRankPoint);
            Marshaler.Read(msg, out ty.addGuildSkillPoint);
            Marshaler.Read(msg, out ty.rankPointResult);
            Marshaler.Read(msg, out ty.guildSkillPointResult);
            Marshaler.Read(msg, out ty.guildExpResult);
            Marshaler.Read(msg, out ty.accumdContribution);
            Marshaler.Read(msg, out ty.weeklyContribution);
        }

        public static void Read(Message msg, out List<GuildAttendanceRewardResult> list)
        {
            list = new List<GuildAttendanceRewardResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildAttendanceRewardResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildAttendanceStatus ty)
        {
            ty = new GuildAttendanceStatus();
            Marshaler.Read(msg, out ty.isAttendEnable);
            Marshaler.Read(msg, out ty.isRewardEnable);
            Marshaler.Read(msg, out ty.remainSecToAttendEnd);
        }

        public static void Read(Message msg, out List<GuildAttendanceStatus> list)
        {
            list = new List<GuildAttendanceStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildAttendanceStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBattlePointRegisteredResult ty)
        {
            ty = new GuildBattlePointRegisteredResult();
            Marshaler.Read(msg, out ty.isRegisteredFlag);
            Marshaler.Read(msg, out ty.battlePoint);
        }

        public static void Read(Message msg, out List<GuildBattlePointRegisteredResult> list)
        {
            list = new List<GuildBattlePointRegisteredResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBattlePointRegisteredResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBattlePointType en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildBattlePointType)num;
        }

        public static void Read(Message msg, out List<GuildBattlePointType> list)
        {
            list = new List<GuildBattlePointType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBattlePointType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBossDifficulty en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildBossDifficulty)num;
        }

        public static void Read(Message msg, out List<GuildBossDifficulty> list)
        {
            list = new List<GuildBossDifficulty>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBossDifficulty item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBossOffSeasonInfo ty)
        {
            ty = new GuildBossOffSeasonInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.missionGroupID);
        }

        public static void Read(Message msg, out List<GuildBossOffSeasonInfo> list)
        {
            list = new List<GuildBossOffSeasonInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBossOffSeasonInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBossOffSeasonRankPoint ty)
        {
            ty = new GuildBossOffSeasonRankPoint();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.topRankPoint);
        }

        public static void Read(Message msg, out List<GuildBossOffSeasonRankPoint> list)
        {
            list = new List<GuildBossOffSeasonRankPoint>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBossOffSeasonRankPoint item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBossRankPoint ty)
        {
            ty = new GuildBossRankPoint();
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.topRankPoint);
            Marshaler.Read(msg, out ty.accumRankPoint);
        }

        public static void Read(Message msg, out List<GuildBossRankPoint> list)
        {
            list = new List<GuildBossRankPoint>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBossRankPoint item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBossRankPointReward ty)
        {
            ty = new GuildBossRankPointReward();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.rewardOrder);
            Marshaler.Read(msg, out ty.rewardOrderHell);
        }

        public static void Read(Message msg, out List<GuildBossRankPointReward> list)
        {
            list = new List<GuildBossRankPointReward>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBossRankPointReward item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBPGuildRankInfo ty)
        {
            ty = new GuildBPGuildRankInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildExp);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.masterName);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.prevRank);
            Marshaler.Read(msg, out ty.battlePoint);
        }

        public static void Read(Message msg, out List<GuildBPGuildRankInfo> list)
        {
            list = new List<GuildBPGuildRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBPGuildRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBPMemberRankInfo ty)
        {
            ty = new GuildBPMemberRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.prevRank);
            Marshaler.Read(msg, out ty.battlePoint);
        }

        public static void Read(Message msg, out List<GuildBPMemberRankInfo> list)
        {
            list = new List<GuildBPMemberRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBPMemberRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildBPUserRankInfo ty)
        {
            ty = new GuildBPUserRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.prevRank);
            Marshaler.Read(msg, out ty.battlePoint);
        }

        public static void Read(Message msg, out List<GuildBPUserRankInfo> list)
        {
            list = new List<GuildBPUserRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildBPUserRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildChatMessage ty)
        {
            ty = new GuildChatMessage();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.chatType);
            Marshaler.Read(msg, out ty.message);
            Marshaler.Read(msg, out ty.chatTime);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.skinID);
        }

        public static void Read(Message msg, out List<GuildChatMessage> list)
        {
            list = new List<GuildChatMessage>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildChatMessage item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildChatType en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildChatType)num;
        }

        public static void Read(Message msg, out List<GuildChatType> list)
        {
            list = new List<GuildChatType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildChatType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildDonation ty)
        {
            ty = new GuildDonation();
            Marshaler.Read(msg, out ty.donationID);
            Marshaler.Read(msg, out ty.donationCount);
            Marshaler.Read(msg, out ty.needItemIDList);
        }

        public static void Read(Message msg, out List<GuildDonation> list)
        {
            list = new List<GuildDonation>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildDonation item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildDonationInitializeResult ty)
        {
            ty = new GuildDonationInitializeResult();
            Marshaler.Read(msg, out ty.useItemResultInfoList);
            Marshaler.Read(msg, out ty.guildDonationID);
            Marshaler.Read(msg, out ty.guildDonationCount);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<GuildDonationInitializeResult> list)
        {
            list = new List<GuildDonationInitializeResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildDonationInitializeResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildDonationResult ty)
        {
            ty = new GuildDonationResult();
            Marshaler.Read(msg, out ty.useItemResultInfoList);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.currentGuildExp);
            Marshaler.Read(msg, out ty.currentAccumGuildContribution);
            Marshaler.Read(msg, out ty.currentWeeklyContribution);
            Marshaler.Read(msg, out ty.guildDonationID);
            Marshaler.Read(msg, out ty.guildDonationCount);
            Marshaler.Read(msg, out ty.guildDonationContribution);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<GuildDonationResult> list)
        {
            list = new List<GuildDonationResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildDonationResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildGroupMissionInfo ty)
        {
            ty = new GuildGroupMissionInfo();
            Marshaler.Read(msg, out ty.missionId);
            Marshaler.Read(msg, out ty.progressValue);
        }

        public static void Read(Message msg, out List<GuildGroupMissionInfo> list)
        {
            list = new List<GuildGroupMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildGroupMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildInfo ty)
        {
            ty = new GuildInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildExp);
            Marshaler.Read(msg, out ty.masterUSN);
            Marshaler.Read(msg, out ty.description);
            Marshaler.Read(msg, out ty.noticeTitle);
            Marshaler.Read(msg, out ty.notice);
            Marshaler.Read(msg, out ty.showNotice);
            Marshaler.Read(msg, out ty.emblemIconID);
            Marshaler.Read(msg, out ty.emblemSubIconID);
            Marshaler.Read(msg, out ty.emblemBgID);
            Marshaler.Read(msg, out ty.guildPoint);
            Marshaler.Read(msg, out ty.skillPoint);
            Marshaler.Read(msg, out ty.joiningApprovalType);
            Marshaler.Read(msg, out ty.joiningLevelCondition);
            Marshaler.Read(msg, out ty.memberCount);
            Marshaler.Read(msg, out ty.applicantCount);
            Marshaler.Read(msg, out ty.masterName);
            Marshaler.Read(msg, out ty.attendSeq);
            Marshaler.Read(msg, out ty.attendCount);
            Marshaler.Read(msg, out ty.prevAttendCount);
            Marshaler.Read(msg, out ty.skillUseList);
            Marshaler.Read(msg, out ty.invitationGrade);
            Marshaler.Read(msg, out ty.guildWarSeedSeason);
            Marshaler.Read(msg, out ty.expBoostStack);
            Marshaler.Read(msg, out ty.joiningBattlePoint);
            Marshaler.Read(msg, out ty.joiningCurrentConstellationGroup);
            Marshaler.Read(msg, out ty.recruitNotice);
            Marshaler.Read(msg, out ty.recruitEndRemainSec);
            //Marshaler.Read(msg, out ty.level);
            //Marshaler.Read(msg, out ty.lastGuildMissionResetSeq);
            //Marshaler.Read(msg, out ty.lastGuildMissionResetExp);
            //Marshaler.Read(msg, out ty.languageType);
            //Marshaler.Read(msg, out ty.expBoostStackUpdateSeq);
            //Marshaler.Read(msg, out ty.recruitExpireTime);
            //Marshaler.Read(msg, out ty.currentAPWeekResetSEQ);
        }

        public static void Read(Message msg, out List<GuildInfo> list)
        {
            list = new List<GuildInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildInvitationState en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildInvitationState)num;
        }

        public static void Read(Message msg, out List<GuildInvitationState> list)
        {
            list = new List<GuildInvitationState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildInvitationState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildJoiningApprovalType en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildJoiningApprovalType)num;
        }

        public static void Read(Message msg, out List<GuildJoiningApprovalType> list)
        {
            list = new List<GuildJoiningApprovalType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildJoiningApprovalType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildMemberGrade en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildMemberGrade)num;
        }

        public static void Read(Message msg, out List<GuildMemberGrade> list)
        {
            list = new List<GuildMemberGrade>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildMemberGrade item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildMemberInfo ty)
        {
            ty = new GuildMemberInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.remainSecToJoinEnable);
            Marshaler.Read(msg, out ty.joinEnableTime);
            Marshaler.Read(msg, out ty.joinTime);
            Marshaler.Read(msg, out ty.afterLoginMin);
            Marshaler.Read(msg, out ty.accumdContribution);
            Marshaler.Read(msg, out ty.weeklyContribution);
            Marshaler.Read(msg, out ty.prevWeeklyContirbution);
            Marshaler.Read(msg, out ty.weeklySeq);
            Marshaler.Read(msg, out ty.loginState);
            Marshaler.Read(msg, out ty.lastAttendTime);
            Marshaler.Read(msg, out ty.bTodayAttend);
            Marshaler.Read(msg, out ty.stageClearCount);
            Marshaler.Read(msg, out ty.joinTimeWeeklySeq);
            Marshaler.Read(msg, out ty.playTitleID);
            Marshaler.Read(msg, out ty.joinBattlePoint);
            Marshaler.Read(msg, out ty.joinConstellationGroup);
            Marshaler.Read(msg, out ty.guildOrderMissionMileageRewardIndex);
            //Marshaler.Read(msg, out ty.attendRewardTime);
            //Marshaler.Read(msg, out ty.netmarblePID);
        }

        public static void Read(Message msg, out List<GuildMemberInfo> list)
        {
            list = new List<GuildMemberInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildMemberInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildMemberRankInfo ty)
        {
            ty = new GuildMemberRankInfo();
            Marshaler.Read(msg, out ty.USN);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinCostumeGroupID);
            Marshaler.Read(msg, out ty.weaponCostumeGroupID);
            Marshaler.Read(msg, out ty.headCostumeGroupID);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
        }

        public static void Read(Message msg, out List<GuildMemberRankInfo> list)
        {
            list = new List<GuildMemberRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildMemberRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildMissionInfo ty)
        {
            ty = new GuildMissionInfo();
            Marshaler.Read(msg, out ty.guildMissionID);
            Marshaler.Read(msg, out ty.progressValue);
            Marshaler.Read(msg, out ty.isReward);
        }

        public static void Read(Message msg, out List<GuildMissionInfo> list)
        {
            list = new List<GuildMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildMissionRewardResult ty)
        {
            ty = new GuildMissionRewardResult();
            Marshaler.Read(msg, out ty.rewardGuildMissionIDList);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.currentGuildExp);
        }

        public static void Read(Message msg, out List<GuildMissionRewardResult> list)
        {
            list = new List<GuildMissionRewardResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildMissionRewardResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildNoticeInfo ty)
        {
            ty = new GuildNoticeInfo();
            Marshaler.Read(msg, out ty.showNotice);
            Marshaler.Read(msg, out ty.noticeTitle);
            Marshaler.Read(msg, out ty.noticeMessage);
        }

        public static void Read(Message msg, out List<GuildNoticeInfo> list)
        {
            list = new List<GuildNoticeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildNoticeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildOrderMissionInfo ty)
        {
            ty = new GuildOrderMissionInfo();
            Marshaler.Read(msg, out ty.missionID);
            Marshaler.Read(msg, out ty.progress);
        }

        public static void Read(Message msg, out List<GuildOrderMissionInfo> list)
        {
            list = new List<GuildOrderMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildOrderMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildOrderMissionInfoClientSend ty)
        {
            ty = new GuildOrderMissionInfoClientSend();
            Marshaler.Read(msg, out ty.guildOrderMissionInfoList);
            Marshaler.Read(msg, out ty.clearGuildOrderMissionCount);
        }

        public static void Read(Message msg, out List<GuildOrderMissionInfoClientSend> list)
        {
            list = new List<GuildOrderMissionInfoClientSend>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildOrderMissionInfoClientSend item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildOrderMissionStatus en)
        {
            int num;
            msg.Read(out num);
            en = (GuildOrderMissionStatus)num;
        }

        public static void Read(Message msg, out List<GuildOrderMissionStatus> list)
        {
            list = new List<GuildOrderMissionStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildOrderMissionStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRankRedisInfo ty)
        {
            ty = new GuildRankRedisInfo();
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.totolRankUpCount);
        }

        public static void Read(Message msg, out List<GuildRankRedisInfo> list)
        {
            list = new List<GuildRankRedisInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRankRedisInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRankRewardInfo ty)
        {
            ty = new GuildRankRewardInfo();
            Marshaler.Read(msg, out ty.guildRankInfo);
            Marshaler.Read(msg, out ty.rewardItemInfoList);
        }

        public static void Read(Message msg, out List<GuildRankRewardInfo> list)
        {
            list = new List<GuildRankRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRankRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRecruitSearchType en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildRecruitSearchType)num;
        }

        public static void Read(Message msg, out List<GuildRecruitSearchType> list)
        {
            list = new List<GuildRecruitSearchType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRecruitSearchType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRewardResult ty)
        {
            ty = new GuildRewardResult();
            Marshaler.Read(msg, out ty.addRankPoint);
            Marshaler.Read(msg, out ty.addRankBonusPoint);
            Marshaler.Read(msg, out ty.guildBossBonusPoint);
            Marshaler.Read(msg, out ty.addGuildSkillPoint);
            Marshaler.Read(msg, out ty.addGuildExp);
            Marshaler.Read(msg, out ty.guildSkillPointResult);
            Marshaler.Read(msg, out ty.rankPointResult);
            Marshaler.Read(msg, out ty.stageClearCountResult);
            Marshaler.Read(msg, out ty.guildExpResult);
            Marshaler.Read(msg, out ty.accumdContribution);
            Marshaler.Read(msg, out ty.weeklyContribution);
            Marshaler.Read(msg, out ty.addGuildBoostExp);
        }

        public static void Read(Message msg, out List<GuildRewardResult> list)
        {
            list = new List<GuildRewardResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRewardResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRoomInfo ty)
        {
            ty = new GuildRoomInfo();
            Marshaler.Read(msg, out ty.resultCode);
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.guildRoomMenberInfoList);
            Marshaler.Read(msg, out ty.guildMemberInfo);
            Marshaler.Read(msg, out ty.guildRankStartRemainSec);
            Marshaler.Read(msg, out ty.guildRankEndRemainSec);
            Marshaler.Read(msg, out ty.guildRankRewardInfo);
            Marshaler.Read(msg, out ty.guildBossWeekRewardList);
            Marshaler.Read(msg, out ty.guildMemberRanker);
            Marshaler.Read(msg, out ty.registerTeamBattlePoint);
            Marshaler.Read(msg, out ty.registerAccountBattlePoint);
            Marshaler.Read(msg, out ty.guildWarRankRewardInfo);
            Marshaler.Read(msg, out ty.prevSeasonGuildWarLeagueRankInfoList);
            Marshaler.Read(msg, out ty.guildWarLowRewardInfo);
        }

        public static void Read(Message msg, out List<GuildRoomInfo> list)
        {
            list = new List<GuildRoomInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRoomInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRoomMemberEmojiState en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildRoomMemberEmojiState)num;
        }

        public static void Read(Message msg, out List<GuildRoomMemberEmojiState> list)
        {
            list = new List<GuildRoomMemberEmojiState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRoomMemberEmojiState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRoomMemberInfo ty)
        {
            ty = new GuildRoomMemberInfo();
            Marshaler.Read(msg, out ty.userUSN);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinCostumeGroupID);
            Marshaler.Read(msg, out ty.weaponCostumeGroupID);
            Marshaler.Read(msg, out ty.headCostumeGroupID);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
            Marshaler.Read(msg, out ty.point);
            Marshaler.Read(msg, out ty.emojiState);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<GuildRoomMemberInfo> list)
        {
            list = new List<GuildRoomMemberInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRoomMemberInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRoomMemberPointInfo ty)
        {
            ty = new GuildRoomMemberPointInfo();
            Marshaler.Read(msg, out ty.userUSN);
            Marshaler.Read(msg, out ty.point);
        }

        public static void Read(Message msg, out List<GuildRoomMemberPointInfo> list)
        {
            list = new List<GuildRoomMemberPointInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRoomMemberPointInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRoomMemberState en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildRoomMemberState)num;
        }

        public static void Read(Message msg, out List<GuildRoomMemberState> list)
        {
            list = new List<GuildRoomMemberState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRoomMemberState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRoomMoveInfo ty)
        {
            ty = new GuildRoomMoveInfo();
            Marshaler.Read(msg, out ty.targetUSN);
            Marshaler.Read(msg, out ty.x);
            Marshaler.Read(msg, out ty.z);
            Marshaler.Read(msg, out ty.prevState);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.motion);
        }

        public static void Read(Message msg, out List<GuildRoomMoveInfo> list)
        {
            list = new List<GuildRoomMoveInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRoomMoveInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildRoomPoint ty)
        {
            ty = new GuildRoomPoint();
            Marshaler.Read(msg, out ty.x);
            Marshaler.Read(msg, out ty.z);
            Marshaler.Read(msg, out ty.prevState);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.motion);
        }

        public static void Read(Message msg, out List<GuildRoomPoint> list)
        {
            list = new List<GuildRoomPoint>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildRoomPoint item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildSetupInfo ty)
        {
            ty = new GuildSetupInfo();
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.description);
            Marshaler.Read(msg, out ty.noticeTitle);
            Marshaler.Read(msg, out ty.notice);
            Marshaler.Read(msg, out ty.showNotice);
            Marshaler.Read(msg, out ty.emblemIconID);
            Marshaler.Read(msg, out ty.emblemBgID);
            Marshaler.Read(msg, out ty.emblemSubIconID);
            Marshaler.Read(msg, out ty.joiningApprovalType);
            Marshaler.Read(msg, out ty.joiningLevelCondition);
            Marshaler.Read(msg, out ty.invitationGrade);
            Marshaler.Read(msg, out ty.joiningBattlePoint);
            Marshaler.Read(msg, out ty.joiningCurrentConstellationGroup);
            Marshaler.Read(msg, out ty.recruitNotice);
        }

        public static void Read(Message msg, out List<GuildSetupInfo> list)
        {
            list = new List<GuildSetupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildSetupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildSkillInfo ty)
        {
            ty = new GuildSkillInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.skillID);
            Marshaler.Read(msg, out ty.slotNo);
        }

        public static void Read(Message msg, out List<GuildSkillInfo> list)
        {
            list = new List<GuildSkillInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildSkillInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildSkillUseInfo ty)
        {
            ty = new GuildSkillUseInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.guildExp);
            Marshaler.Read(msg, out ty.skillPoint);
            Marshaler.Read(msg, out ty.skillUseList);
        }

        public static void Read(Message msg, out List<GuildSkillUseInfo> list)
        {
            list = new List<GuildSkillUseInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildSkillUseInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarAreaInfo ty)
        {
            ty = new GuildWarAreaInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.areaID);
            Marshaler.Read(msg, out ty.deployUSN);
            Marshaler.Read(msg, out ty.deployTeamCount);
            Marshaler.Read(msg, out ty.isInBattle);
            Marshaler.Read(msg, out ty.loseTeamCount);
            //Marshaler.Read(msg, out ty.regionID);
            //Marshaler.Read(msg, out ty.lastOffenceGuildSN);
            //Marshaler.Read(msg, out ty.lastOffenceUSN);
            //Marshaler.Read(msg, out ty.lastBattleStartTime);
        }

        public static void Read(Message msg, out List<GuildWarAreaInfo> list)
        {
            list = new List<GuildWarAreaInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarAreaInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarAreaPassiveType en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildWarAreaPassiveType)num;
        }

        public static void Read(Message msg, out List<GuildWarAreaPassiveType> list)
        {
            list = new List<GuildWarAreaPassiveType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarAreaPassiveType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarBattlePrepareInfo ty)
        {
            ty = new GuildWarBattlePrepareInfo();
            Marshaler.Read(msg, out ty.defenceBMSlotCount);
            Marshaler.Read(msg, out ty.squadBMSlotCount);
            Marshaler.Read(msg, out ty.defenceUserTeamList);
            Marshaler.Read(msg, out ty.guildWarSquadSlotList);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamInfoList);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamBuffList);
        }

        public static void Read(Message msg, out List<GuildWarBattlePrepareInfo> list)
        {
            list = new List<GuildWarBattlePrepareInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarBattlePrepareInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarBattleRecord ty)
        {
            ty = new GuildWarBattleRecord();
            Marshaler.Read(msg, out ty.recordID);
            Marshaler.Read(msg, out ty.defenceTeamIndex);
            Marshaler.Read(msg, out ty.winGuildSerial);
            Marshaler.Read(msg, out ty.battleEnd);
            Marshaler.Read(msg, out ty.attackerGuildSerial);
            Marshaler.Read(msg, out ty.attackerNickame);
            Marshaler.Read(msg, out ty.attackSkinIDList);
            Marshaler.Read(msg, out ty.deadHeroIDList);
            //Marshaler.Read(msg, out ty.guildSerial);
            //Marshaler.Read(msg, out ty.areaID);
            //Marshaler.Read(msg, out ty.battleNumber);
            //Marshaler.Read(msg, out ty.attackerUSN);
        }

        public static void Read(Message msg, out List<GuildWarBattleRecord> list)
        {
            list = new List<GuildWarBattleRecord>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarBattleRecord item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarBattleSettingChangeInfo ty)
        {
            ty = new GuildWarBattleSettingChangeInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.nickName);
        }

        public static void Read(Message msg, out List<GuildWarBattleSettingChangeInfo> list)
        {
            list = new List<GuildWarBattleSettingChangeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarBattleSettingChangeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarDefenceTeamInfo ty)
        {
            ty = new GuildWarDefenceTeamInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
        }

        public static void Read(Message msg, out List<GuildWarDefenceTeamInfo> list)
        {
            list = new List<GuildWarDefenceTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarDefenceTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarHero ty)
        {
            ty = new GuildWarHero();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
            Marshaler.Read(msg, out ty.isUsed);
        }

        public static void Read(Message msg, out List<GuildWarHero> list)
        {
            list = new List<GuildWarHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLeagueRankInfo ty)
        {
            ty = new GuildWarLeagueRankInfo();
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.guildWarRankInfoList);
        }

        public static void Read(Message msg, out List<GuildWarLeagueRankInfo> list)
        {
            list = new List<GuildWarLeagueRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLeagueRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLobbyInfo ty)
        {
            ty = new GuildWarLobbyInfo();
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.currentGuildWarScheduleInfo);
            Marshaler.Read(msg, out ty.nextGuildWarScheduleInfo);
            Marshaler.Read(msg, out ty.guildInfoList);
            Marshaler.Read(msg, out ty.guildWarLeagueRankInfoList);
            Marshaler.Read(msg, out ty.guildWarVersusRecordList);
            Marshaler.Read(msg, out ty.guildWarVersusScheduleInfoList);
            Marshaler.Read(msg, out ty.nextSeasonRemainSec);
            Marshaler.Read(msg, out ty.guildWarUserSquadInfo);
            Marshaler.Read(msg, out ty.isGuildWarPlayable);
            //Marshaler.Read(msg, out ty.currentSeasonGuildWarLeagueRankInfo);
            //Marshaler.Read(msg, out ty.prevSeasonGuildWarLeagueRankInfo);
        }

        public static void Read(Message msg, out List<GuildWarLobbyInfo> list)
        {
            list = new List<GuildWarLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowAreaInfo ty)
        {
            ty = new GuildWarLowAreaInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.areaID);
            Marshaler.Read(msg, out ty.deployCount);
            Marshaler.Read(msg, out ty.loseCount);
        }

        public static void Read(Message msg, out List<GuildWarLowAreaInfo> list)
        {
            list = new List<GuildWarLowAreaInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowAreaInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowBattleRecord ty)
        {
            ty = new GuildWarLowBattleRecord();
            Marshaler.Read(msg, out ty.recordID);
            Marshaler.Read(msg, out ty.defenceTeamIndex);
            Marshaler.Read(msg, out ty.winGuildSerial);
            Marshaler.Read(msg, out ty.battleEnd);
            Marshaler.Read(msg, out ty.attackerGuildSerial);
            Marshaler.Read(msg, out ty.attackerNickame);
            Marshaler.Read(msg, out ty.attackSkinIDList);
            //Marshaler.Read(msg, out ty.guildSerial);
            //Marshaler.Read(msg, out ty.defenceUSN);
            //Marshaler.Read(msg, out ty.attackerUSN);
        }

        public static void Read(Message msg, out List<GuildWarLowBattleRecord> list)
        {
            list = new List<GuildWarLowBattleRecord>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowBattleRecord item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowDefenceTeamInfo ty)
        {
            ty = new GuildWarLowDefenceTeamInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
        }

        public static void Read(Message msg, out List<GuildWarLowDefenceTeamInfo> list)
        {
            list = new List<GuildWarLowDefenceTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowDefenceTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowHero ty)
        {
            ty = new GuildWarLowHero();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
            Marshaler.Read(msg, out ty.isUsed);
        }

        public static void Read(Message msg, out List<GuildWarLowHero> list)
        {
            list = new List<GuildWarLowHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowInfo ty)
        {
            ty = new GuildWarLowInfo();
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.tier);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.opponentGuildSN);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildExp);
            Marshaler.Read(msg, out ty.emblemIconID);
            Marshaler.Read(msg, out ty.emblemSubIconID);
            Marshaler.Read(msg, out ty.emblemBgID);
            Marshaler.Read(msg, out ty.guildAccountBattlePoint);
            Marshaler.Read(msg, out ty.applyDate);
        }

        public static void Read(Message msg, out List<GuildWarLowInfo> list)
        {
            list = new List<GuildWarLowInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowLobbyInfo ty)
        {
            ty = new GuildWarLowLobbyInfo();
            Marshaler.Read(msg, out ty.currentScheduleInfo);
            Marshaler.Read(msg, out ty.nextScheduleInfo);
            Marshaler.Read(msg, out ty.guildInfo);
            Marshaler.Read(msg, out ty.opponentGuildInfo);
            Marshaler.Read(msg, out ty.nextSeasonRemainSec);
            Marshaler.Read(msg, out ty.lastSeason);
            Marshaler.Read(msg, out ty.tier);
            Marshaler.Read(msg, out ty.attackCount);
            Marshaler.Read(msg, out ty.receivedPlayRewardID);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.opponentBattlePoint);
            Marshaler.Read(msg, out ty.isLate);
            Marshaler.Read(msg, out ty.registAccountBPGuildMemberCount);
            Marshaler.Read(msg, out ty.saveDefenceTeamGuildMemberCount);
            Marshaler.Read(msg, out ty.useHeroIDList);
            Marshaler.Read(msg, out ty.areaInfoList);
            Marshaler.Read(msg, out ty.areaID);
        }

        public static void Read(Message msg, out List<GuildWarLowLobbyInfo> list)
        {
            list = new List<GuildWarLowLobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowLobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowMemberInfo ty)
        {
            ty = new GuildWarLowMemberInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.areaID);
            Marshaler.Read(msg, out ty.defenceTeamCount);
            Marshaler.Read(msg, out ty.loseDefenceTeamCount);
            Marshaler.Read(msg, out ty.isInBattle);
            Marshaler.Read(msg, out ty.defenceTeamPower);
            Marshaler.Read(msg, out ty.userRank);
            Marshaler.Read(msg, out ty.userNickName);
            Marshaler.Read(msg, out ty.accountBattlePoint);
            //Marshaler.Read(msg, out ty.attackCount);
            //Marshaler.Read(msg, out ty.receivedPlayRewardID);
            //Marshaler.Read(msg, out ty.lastAttackGuildSerial);
            //Marshaler.Read(msg, out ty.lastAttackDefenceUSN);
            //Marshaler.Read(msg, out ty.lastOffenceGuildSN);
            //Marshaler.Read(msg, out ty.lastOffenceUSN);
            //Marshaler.Read(msg, out ty.lastBattleStartTime);
        }

        public static void Read(Message msg, out List<GuildWarLowMemberInfo> list)
        {
            list = new List<GuildWarLowMemberInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowMemberInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowRewardInfo ty)
        {
            ty = new GuildWarLowRewardInfo();
            Marshaler.Read(msg, out ty.winRewardItemInfoList);
            Marshaler.Read(msg, out ty.pointRewardItemInfoList);
            Marshaler.Read(msg, out ty.tier);
            Marshaler.Read(msg, out ty.guildInfo);
            Marshaler.Read(msg, out ty.opponentGuildInfo);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.opponentBattlePoint);
            Marshaler.Read(msg, out ty.isRewardExist);
        }

        public static void Read(Message msg, out List<GuildWarLowRewardInfo> list)
        {
            list = new List<GuildWarLowRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowScheduleInfo ty)
        {
            ty = new GuildWarLowScheduleInfo();
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.guildWarLowScheduleType);
            Marshaler.Read(msg, out ty.remainSec);
        }

        public static void Read(Message msg, out List<GuildWarLowScheduleInfo> list)
        {
            list = new List<GuildWarLowScheduleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowScheduleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowScheduleType en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildWarLowScheduleType)num;
        }

        public static void Read(Message msg, out List<GuildWarLowScheduleType> list)
        {
            list = new List<GuildWarLowScheduleType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowScheduleType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowStageClearRequestInfo ty)
        {
            ty = new GuildWarLowStageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageClearRequestInfo);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.attackGuildSN);
            Marshaler.Read(msg, out ty.attackAreaID);
            Marshaler.Read(msg, out ty.attackUSN);
            Marshaler.Read(msg, out ty.clientSyncGuildWarLowHeroList);
        }

        public static void Read(Message msg, out List<GuildWarLowStageClearRequestInfo> list)
        {
            list = new List<GuildWarLowStageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowStageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowStageClearResultInfo ty)
        {
            ty = new GuildWarLowStageClearResultInfo();
            Marshaler.Read(msg, out ty.stageClearResultInfo);
            Marshaler.Read(msg, out ty.addAreaScore);
            Marshaler.Read(msg, out ty.addDeployScore);
            Marshaler.Read(msg, out ty.occupationApply);
            Marshaler.Read(msg, out ty.nextDefenceTeamIndex);
            Marshaler.Read(msg, out ty.attackCount);
            Marshaler.Read(msg, out ty.isContinue);
        }

        public static void Read(Message msg, out List<GuildWarLowStageClearResultInfo> list)
        {
            list = new List<GuildWarLowStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowStageRejoinResultInfo ty)
        {
            ty = new GuildWarLowStageRejoinResultInfo();
            Marshaler.Read(msg, out ty.guildWarLowDefenceTeamInfo);
            Marshaler.Read(msg, out ty.defenceGuildWarLowHeroList);
            Marshaler.Read(msg, out ty.attackGuildWarLowHeroList);
            Marshaler.Read(msg, out ty.useHeroIDList);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.defenceGuildInfo);
            Marshaler.Read(msg, out ty.defencePlayTitleID);
            Marshaler.Read(msg, out ty.defenceUserNickName);
            Marshaler.Read(msg, out ty.nextDefenceTeamIndex);
            Marshaler.Read(msg, out ty.guildWarLowPassiveSkillIDList);
            Marshaler.Read(msg, out ty.attackCount);
            Marshaler.Read(msg, out ty.isContinue);
        }

        public static void Read(Message msg, out List<GuildWarLowStageRejoinResultInfo> list)
        {
            list = new List<GuildWarLowStageRejoinResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowStageRejoinResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowStageStartRequestInfo ty)
        {
            ty = new GuildWarLowStageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageStartRequestInfo);
            Marshaler.Read(msg, out ty.attackGuildSN);
            Marshaler.Read(msg, out ty.attackAreaID);
            Marshaler.Read(msg, out ty.attackUSN);
            Marshaler.Read(msg, out ty.attackTeamIndex);
            Marshaler.Read(msg, out ty.useSkinIDList);
            Marshaler.Read(msg, out ty.isContinue);
        }

        public static void Read(Message msg, out List<GuildWarLowStageStartRequestInfo> list)
        {
            list = new List<GuildWarLowStageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowStageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarLowStageStartResultInfo ty)
        {
            ty = new GuildWarLowStageStartResultInfo();
            Marshaler.Read(msg, out ty.stageStartResultInfo);
            Marshaler.Read(msg, out ty.guildWarLowDefenceTeamInfo);
            Marshaler.Read(msg, out ty.defenceGuildWarLowHeroList);
            Marshaler.Read(msg, out ty.defencePlayTitleID);
            Marshaler.Read(msg, out ty.defenceUserNickName);
            Marshaler.Read(msg, out ty.attackGuildWarLowHeroList);
            Marshaler.Read(msg, out ty.guildWarLowPassiveSkillIDList);
            Marshaler.Read(msg, out ty.playRewardItemResultInfo);
            Marshaler.Read(msg, out ty.attackAreaID);
        }

        public static void Read(Message msg, out List<GuildWarLowStageStartResultInfo> list)
        {
            list = new List<GuildWarLowStageStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarLowStageStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarMagicBuffInfo ty)
        {
            ty = new GuildWarMagicBuffInfo();
            Marshaler.Read(msg, out ty.passiveType);
            Marshaler.Read(msg, out ty.passiveID);
        }

        public static void Read(Message msg, out List<GuildWarMagicBuffInfo> list)
        {
            list = new List<GuildWarMagicBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarMagicBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarMemberInfo ty)
        {
            ty = new GuildWarMemberInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.guildWarSeasonKillCount);
            Marshaler.Read(msg, out ty.guildWarAccumKillCount);
            Marshaler.Read(msg, out ty.squadUseHeroCount);
            Marshaler.Read(msg, out ty.squadHeroCount);
            //Marshaler.Read(msg, out ty.lastSeason);
            //Marshaler.Read(msg, out ty.lastAttackGuildSerial);
            //Marshaler.Read(msg, out ty.lastAttackAreaID);
            //Marshaler.Read(msg, out ty.defenceBMSlotCount);
            //Marshaler.Read(msg, out ty.squadBMSlotCount);
        }

        public static void Read(Message msg, out List<GuildWarMemberInfo> list)
        {
            list = new List<GuildWarMemberInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarMemberInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarRankInfo ty)
        {
            ty = new GuildWarRankInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.winCount);
            Marshaler.Read(msg, out ty.drawCount);
            Marshaler.Read(msg, out ty.loseCount);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildExp);
            Marshaler.Read(msg, out ty.emblemIconID);
            Marshaler.Read(msg, out ty.emblemSubIconID);
            Marshaler.Read(msg, out ty.emblemBgID);
            Marshaler.Read(msg, out ty.totalScore);
            Marshaler.Read(msg, out ty.totalGuildAccountBattlePoint);
        }

        public static void Read(Message msg, out List<GuildWarRankInfo> list)
        {
            list = new List<GuildWarRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarRankRewardInfo ty)
        {
            ty = new GuildWarRankRewardInfo();
            Marshaler.Read(msg, out ty.guildWarRankInfo);
            Marshaler.Read(msg, out ty.rewardItemInfoList);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.costumeRewardItemInfoList);
            Marshaler.Read(msg, out ty.isCostumeReceived);
            Marshaler.Read(msg, out ty.costumeReceiveExpireDate);
            Marshaler.Read(msg, out ty.winRewardItemInfoList);
        }

        public static void Read(Message msg, out List<GuildWarRankRewardInfo> list)
        {
            list = new List<GuildWarRankRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarRankRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarRecommandDefenceTeamInfo ty)
        {
            ty = new GuildWarRecommandDefenceTeamInfo();
            Marshaler.Read(msg, out ty.teamNumber);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.fateSkinIDList);
        }

        public static void Read(Message msg, out List<GuildWarRecommandDefenceTeamInfo> list)
        {
            list = new List<GuildWarRecommandDefenceTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarRecommandDefenceTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarRegionInfo ty)
        {
            ty = new GuildWarRegionInfo();
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.regionID);
            Marshaler.Read(msg, out ty.bonusScore);
            Marshaler.Read(msg, out ty.deployAreaCount);
            Marshaler.Read(msg, out ty.loseAreaCount);
            Marshaler.Read(msg, out ty.magicAreaID);
            Marshaler.Read(msg, out ty.magicBuffID);
            Marshaler.Read(msg, out ty.attackPriority);
        }

        public static void Read(Message msg, out List<GuildWarRegionInfo> list)
        {
            list = new List<GuildWarRegionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarRegionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarScheduleInfo ty)
        {
            ty = new GuildWarScheduleInfo();
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.guildWarScheduleType);
            Marshaler.Read(msg, out ty.battleNumber);
            Marshaler.Read(msg, out ty.remainSec);
        }

        public static void Read(Message msg, out List<GuildWarScheduleInfo> list)
        {
            list = new List<GuildWarScheduleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarScheduleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarScheduleType en)
        {
            byte num;
            msg.Read(out num);
            en = (GuildWarScheduleType)num;
        }

        public static void Read(Message msg, out List<GuildWarScheduleType> list)
        {
            list = new List<GuildWarScheduleType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarScheduleType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarSelectionInfo ty)
        {
            ty = new GuildWarSelectionInfo();
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.guildSNList);
        }

        public static void Read(Message msg, out List<GuildWarSelectionInfo> list)
        {
            list = new List<GuildWarSelectionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarSelectionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarSquadSlot ty)
        {
            ty = new GuildWarSquadSlot();
            Marshaler.Read(msg, out ty.slot);
            Marshaler.Read(msg, out ty.heroID);
            //Marshaler.Read(msg, out ty.usn);
        }

        public static void Read(Message msg, out List<GuildWarSquadSlot> list)
        {
            list = new List<GuildWarSquadSlot>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarSquadSlot item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarStageClearRequestInfo ty)
        {
            ty = new GuildWarStageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageClearRequestInfo);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.battleNumber);
            Marshaler.Read(msg, out ty.AttackGuildSN);
            Marshaler.Read(msg, out ty.AttackAreaID);
            Marshaler.Read(msg, out ty.clientSyncGuildWarHeroList);
            Marshaler.Read(msg, out ty.killCount);
        }

        public static void Read(Message msg, out List<GuildWarStageClearRequestInfo> list)
        {
            list = new List<GuildWarStageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarStageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarStageClearResultInfo ty)
        {
            ty = new GuildWarStageClearResultInfo();
            Marshaler.Read(msg, out ty.stageClearResultInfo);
            Marshaler.Read(msg, out ty.addAreaScore);
            Marshaler.Read(msg, out ty.addRegionScore);
            Marshaler.Read(msg, out ty.addRegionBonusScore);
            Marshaler.Read(msg, out ty.occupationApply);
            Marshaler.Read(msg, out ty.updatedGuildWarVersusRecord);
            Marshaler.Read(msg, out ty.offenceGuildWarVersusRecord);
            Marshaler.Read(msg, out ty.nextDefenceTeamIndex);
        }

        public static void Read(Message msg, out List<GuildWarStageClearResultInfo> list)
        {
            list = new List<GuildWarStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarStageRejoinResultInfo ty)
        {
            ty = new GuildWarStageRejoinResultInfo();
            Marshaler.Read(msg, out ty.guildWarDefenceTeamInfo);
            Marshaler.Read(msg, out ty.defenceGuildWarHeroList);
            Marshaler.Read(msg, out ty.attackGuildWarHeroList);
            Marshaler.Read(msg, out ty.useHeroIDList);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.battleNumber);
            Marshaler.Read(msg, out ty.defenceGuildInfo);
            Marshaler.Read(msg, out ty.defencePlayTitleID);
            Marshaler.Read(msg, out ty.defenceUserNickName);
            Marshaler.Read(msg, out ty.nextDefenceTeamIndex);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamBuffList);
            Marshaler.Read(msg, out ty.guildWarAttackTeamBuffList);
            Marshaler.Read(msg, out ty.guildWarMagicBuffInfo);
            //Marshaler.Read(msg, out ty.guildWarRegionInfo);
        }

        public static void Read(Message msg, out List<GuildWarStageRejoinResultInfo> list)
        {
            list = new List<GuildWarStageRejoinResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarStageRejoinResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarStageStartRequestInfo ty)
        {
            ty = new GuildWarStageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageStartRequestInfo);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.battleNumber);
            Marshaler.Read(msg, out ty.AttackGuildSN);
            Marshaler.Read(msg, out ty.AttackAreaID);
            Marshaler.Read(msg, out ty.AttackUSN);
            Marshaler.Read(msg, out ty.AttackTeamIndex);
            Marshaler.Read(msg, out ty.useSkinIDList);
            Marshaler.Read(msg, out ty.isContinue);
        }

        public static void Read(Message msg, out List<GuildWarStageStartRequestInfo> list)
        {
            list = new List<GuildWarStageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarStageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarStageStartResultInfo ty)
        {
            ty = new GuildWarStageStartResultInfo();
            Marshaler.Read(msg, out ty.stageStartResultInfo);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamInfo);
            Marshaler.Read(msg, out ty.defenceGuildWarHeroList);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamBuffList);
            Marshaler.Read(msg, out ty.guildWarAttackTeamBuffList);
            Marshaler.Read(msg, out ty.useGuildWarBuffItemResultInfoList);
            Marshaler.Read(msg, out ty.attackGuildWarHeroList);
            Marshaler.Read(msg, out ty.guildWarMagicBuffInfo);
        }

        public static void Read(Message msg, out List<GuildWarStageStartResultInfo> list)
        {
            list = new List<GuildWarStageStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarStageStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarTeamBuff ty)
        {
            ty = new GuildWarTeamBuff();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.slot);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.buffItemID);
            Marshaler.Read(msg, out ty.buffItemCount);
            Marshaler.Read(msg, out ty.activeYN);
        }

        public static void Read(Message msg, out List<GuildWarTeamBuff> list)
        {
            list = new List<GuildWarTeamBuff>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarTeamBuff item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarTeamBuffRegist ty)
        {
            ty = new GuildWarTeamBuffRegist();
            Marshaler.Read(msg, out ty.slot);
            Marshaler.Read(msg, out ty.buffItemID);
            Marshaler.Read(msg, out ty.buffItemCount);
        }

        public static void Read(Message msg, out List<GuildWarTeamBuffRegist> list)
        {
            list = new List<GuildWarTeamBuffRegist>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarTeamBuffRegist item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarUserSquadInfo ty)
        {
            ty = new GuildWarUserSquadInfo();
            Marshaler.Read(msg, out ty.guildWarSquadSlotList);
        }

        public static void Read(Message msg, out List<GuildWarUserSquadInfo> list)
        {
            list = new List<GuildWarUserSquadInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarUserSquadInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarVersusInfo ty)
        {
            ty = new GuildWarVersusInfo();
            Marshaler.Read(msg, out ty.leftGuildSN);
            Marshaler.Read(msg, out ty.rightGuildSN);
        }

        public static void Read(Message msg, out List<GuildWarVersusInfo> list)
        {
            list = new List<GuildWarVersusInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarVersusInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarVersusRecord ty)
        {
            ty = new GuildWarVersusRecord();
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.versusGuildSN);
            Marshaler.Read(msg, out ty.battleNumber);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildExp);
            Marshaler.Read(msg, out ty.emblemIconID);
            Marshaler.Read(msg, out ty.emblemSubIconID);
            Marshaler.Read(msg, out ty.emblemBgID);
            Marshaler.Read(msg, out ty.guildAccountBattlePoint);
        }

        public static void Read(Message msg, out List<GuildWarVersusRecord> list)
        {
            list = new List<GuildWarVersusRecord>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarVersusRecord item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarVersusScheduleInfo ty)
        {
            ty = new GuildWarVersusScheduleInfo();
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.matchNumber);
            Marshaler.Read(msg, out ty.guildWarVersusInfoList);
        }

        public static void Read(Message msg, out List<GuildWarVersusScheduleInfo> list)
        {
            list = new List<GuildWarVersusScheduleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarVersusScheduleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out GuildWarWorldMapInfo ty)
        {
            ty = new GuildWarWorldMapInfo();
            Marshaler.Read(msg, out ty.guildMemberInfoList);
            Marshaler.Read(msg, out ty.guildWarMemberInfoList);
            Marshaler.Read(msg, out ty.guildWarRegionBonusScoreList);
            Marshaler.Read(msg, out ty.guildWarAreaInfoList);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamInfoList);
            Marshaler.Read(msg, out ty.guildWarHeroList);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamBuffList);
        }

        public static void Read(Message msg, out List<GuildWarWorldMapInfo> list)
        {
            list = new List<GuildWarWorldMapInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                GuildWarWorldMapInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HawkStepInfo ty)
        {
            ty = new HawkStepInfo();
            Marshaler.Read(msg, out ty.Index);
            Marshaler.Read(msg, out ty.fakeStep);
        }

        public static void Read(Message msg, out List<HawkStepInfo> list)
        {
            list = new List<HawkStepInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HawkStepInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroAliveStatus en)
        {
            byte num;
            msg.Read(out num);
            en = (HeroAliveStatus)num;
        }

        public static void Read(Message msg, out List<HeroAliveStatus> list)
        {
            list = new List<HeroAliveStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroAliveStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroKindType en)
        {
            byte num;
            msg.Read(out num);
            en = (HeroKindType)num;
        }

        public static void Read(Message msg, out List<HeroKindType> list)
        {
            list = new List<HeroKindType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroKindType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueBuffInfo ty)
        {
            ty = new HeroLeagueBuffInfo();
            Marshaler.Read(msg, out ty.passiveID);
            Marshaler.Read(msg, out ty.remainEndSec);
        }

        public static void Read(Message msg, out List<HeroLeagueBuffInfo> list)
        {
            list = new List<HeroLeagueBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueHero ty)
        {
            ty = new HeroLeagueHero();
            Marshaler.Read(msg, out ty.userGroup);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
            Marshaler.Read(msg, out ty.attackUserGroup);
        }

        public static void Read(Message msg, out List<HeroLeagueHero> list)
        {
            list = new List<HeroLeagueHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueRewardInfo ty)
        {
            ty = new HeroLeagueRewardInfo();
            Marshaler.Read(msg, out ty.isRewarded);
            Marshaler.Read(msg, out ty.rewardID);
            Marshaler.Read(msg, out ty.useTeamCount);
        }

        public static void Read(Message msg, out List<HeroLeagueRewardInfo> list)
        {
            list = new List<HeroLeagueRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueScoreRewardInfo ty)
        {
            ty = new HeroLeagueScoreRewardInfo();
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.rewardIndex);
        }

        public static void Read(Message msg, out List<HeroLeagueScoreRewardInfo> list)
        {
            list = new List<HeroLeagueScoreRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueScoreRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueSeasonInfo ty)
        {
            ty = new HeroLeagueSeasonInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.remainSeasonStartSec);
            Marshaler.Read(msg, out ty.remainSeasonEndSec);
        }

        public static void Read(Message msg, out List<HeroLeagueSeasonInfo> list)
        {
            list = new List<HeroLeagueSeasonInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueSeasonInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueSeasonShopBuyInfo ty)
        {
            ty = new HeroLeagueSeasonShopBuyInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.productID);
            Marshaler.Read(msg, out ty.seasonBuyCount);
        }

        public static void Read(Message msg, out List<HeroLeagueSeasonShopBuyInfo> list)
        {
            list = new List<HeroLeagueSeasonShopBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueSeasonShopBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueSeasonShopInfo ty)
        {
            ty = new HeroLeagueSeasonShopInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.remainSeasonShopStartSec);
            Marshaler.Read(msg, out ty.remainSeasonShopEndSec);
            Marshaler.Read(msg, out ty.currentSeasonShopNeedItemList);
        }

        public static void Read(Message msg, out List<HeroLeagueSeasonShopInfo> list)
        {
            list = new List<HeroLeagueSeasonShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueSeasonShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueStageClearRequestInfo ty)
        {
            ty = new HeroLeagueStageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageClearRequestInfo);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.isGiveUp);
            Marshaler.Read(msg, out ty.ClientSyncHeroLeagueHeroList);
        }

        public static void Read(Message msg, out List<HeroLeagueStageClearRequestInfo> list)
        {
            list = new List<HeroLeagueStageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueStageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueStageStartRequestInfo ty)
        {
            ty = new HeroLeagueStageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageStartRequestInfo);
            Marshaler.Read(msg, out ty.season);
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.targetUserGroup);
            Marshaler.Read(msg, out ty.teamNumber);
            Marshaler.Read(msg, out ty.useSkinIDList);
            Marshaler.Read(msg, out ty.isContinue);
        }

        public static void Read(Message msg, out List<HeroLeagueStageStartRequestInfo> list)
        {
            list = new List<HeroLeagueStageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueStageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out HeroLeagueUserGroup ty)
        {
            ty = new HeroLeagueUserGroup();
            Marshaler.Read(msg, out ty.userGroup);
            Marshaler.Read(msg, out ty.teamNumber);
            Marshaler.Read(msg, out ty.useTeamCount);
        }

        public static void Read(Message msg, out List<HeroLeagueUserGroup> list)
        {
            list = new List<HeroLeagueUserGroup>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                HeroLeagueUserGroup item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out IngameBattlePointRequest ty)
        {
            ty = new IngameBattlePointRequest();
            Marshaler.Read(msg, out ty.skillMoveCount);
            Marshaler.Read(msg, out ty.skillUnusedCount);
            Marshaler.Read(msg, out ty.skillCombineCount);
            Marshaler.Read(msg, out ty.debuffApplyCount);
            Marshaler.Read(msg, out ty.buffApplyCount);
            Marshaler.Read(msg, out ty.aliveHeroCount);
            Marshaler.Read(msg, out ty.remainHP);
            Marshaler.Read(msg, out ty.criticalOccurCount);
            Marshaler.Read(msg, out ty.heroGroupSkillUse01);
            Marshaler.Read(msg, out ty.heroGroupSkillUse02);
            Marshaler.Read(msg, out ty.heroGroupSkillUse03);
            Marshaler.Read(msg, out ty.heroGroupSkillUse04);
            Marshaler.Read(msg, out ty.heroSkillUse01);
            Marshaler.Read(msg, out ty.skillIDUse01);
            Marshaler.Read(msg, out ty.skillIDUse02);
            Marshaler.Read(msg, out ty.skillIDUse03);
            Marshaler.Read(msg, out ty.skillIDUse04);
            Marshaler.Read(msg, out ty.skillIDUse05);
            Marshaler.Read(msg, out ty.skillIDUse06);
            Marshaler.Read(msg, out ty.skillIDUse07);
            Marshaler.Read(msg, out ty.skillIDUse08);
            Marshaler.Read(msg, out ty.skillBreakKillCount);
            Marshaler.Read(msg, out ty.skillRankDownCount);
            Marshaler.Read(msg, out ty.skillDamageRangeCount01);
            Marshaler.Read(msg, out ty.skillDamageRangeCount02);
            Marshaler.Read(msg, out ty.skillDamageRangeCount03);
            Marshaler.Read(msg, out ty.skillDamageRangeCount04);
            Marshaler.Read(msg, out ty.skillDamageRangeCount05);
            Marshaler.Read(msg, out ty.skillCardOptionIdUse01);
            Marshaler.Read(msg, out ty.skillCardOptionIdUse02);
            Marshaler.Read(msg, out ty.skillCardOptionIdUse03);
            Marshaler.Read(msg, out ty.skillCardOptionIdUse04);
            Marshaler.Read(msg, out ty.skillCardOptionIdUse05);
            Marshaler.Read(msg, out ty.skillCardOptionIdUse06);
            Marshaler.Read(msg, out ty.enemyDebuffForbidAttack);
            Marshaler.Read(msg, out ty.enemyDebuffForbidBuff);
            Marshaler.Read(msg, out ty.skillDetonateKill);
            Marshaler.Read(msg, out ty.enemyDebuffIgnite);
            Marshaler.Read(msg, out ty.oneTurnDamage);
            Marshaler.Read(msg, out ty.oneSkillRecoveryHP);
            Marshaler.Read(msg, out ty.partyOneTurnRecoveryHP);
            Marshaler.Read(msg, out ty.clearStageEnemyTotalDamage);
            Marshaler.Read(msg, out ty.enemyDisUseHeal);
            Marshaler.Read(msg, out ty.enemySkillSpikeKill);
            Marshaler.Read(msg, out ty.enemyExplosionDamage);
            Marshaler.Read(msg, out ty.totalDamage);
            Marshaler.Read(msg, out ty.skillIgnoreFixedDefCount);
        }

        public static void Read(Message msg, out List<IngameBattlePointRequest> list)
        {
            list = new List<IngameBattlePointRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                IngameBattlePointRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out IngameDropItemInfo ty)
        {
            ty = new IngameDropItemInfo();
            Marshaler.Read(msg, out ty.groupIndex);
            Marshaler.Read(msg, out ty.isBossDrop);
        }

        public static void Read(Message msg, out List<IngameDropItemInfo> list)
        {
            list = new List<IngameDropItemInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                IngameDropItemInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out IngameMissionProgressRequest ty)
        {
            ty = new IngameMissionProgressRequest();
            Marshaler.Read(msg, out ty.isSupporterBest);
            Marshaler.Read(msg, out ty.cardUseCount_lv2);
            Marshaler.Read(msg, out ty.cardUseCount_lv3);
            Marshaler.Read(msg, out ty.cardUseCount_specical);
            Marshaler.Read(msg, out ty.cardUseCount_heal);
            Marshaler.Read(msg, out ty.cardUseCount_debuff);
            Marshaler.Read(msg, out ty.allyTurnCount);
            Marshaler.Read(msg, out ty.cardUseCount_lv1);
            Marshaler.Read(msg, out ty.cardUseCount_counterPose);
            Marshaler.Read(msg, out ty.cardUseCount_Shild);
            Marshaler.Read(msg, out ty.cardUseCount_AtkStaDown);
            Marshaler.Read(msg, out ty.cardUseCount_Stun);
            Marshaler.Read(msg, out ty.cardUseCount_Stone);
            Marshaler.Read(msg, out ty.cardUseCount_Ice);
            Marshaler.Read(msg, out ty.cardUseCount_specialCoop);
            Marshaler.Read(msg, out ty.debuffBleedDeadCount);
            Marshaler.Read(msg, out ty.staminaDecreaseCount);
            Marshaler.Read(msg, out ty.staminaIncreaseCount);
            Marshaler.Read(msg, out ty.cardLevelDownCount);
            Marshaler.Read(msg, out ty.weakAttributeAttackCount);
            Marshaler.Read(msg, out ty.winTeamPower);
            Marshaler.Read(msg, out ty.isAllHeroAlive);
            Marshaler.Read(msg, out ty.isAllSSR);
            Marshaler.Read(msg, out ty.isAllUR);
            Marshaler.Read(msg, out ty.isAllWoman);
            Marshaler.Read(msg, out ty.isAllMan);
            Marshaler.Read(msg, out ty.isNoneWeaponWin);
            Marshaler.Read(msg, out ty.buffIceDeadCount);
            Marshaler.Read(msg, out ty.lastAttackerSkinID);
            Marshaler.Read(msg, out ty.debuffShockKillCount);
            Marshaler.Read(msg, out ty.debuffPoisonKillCount);
            Marshaler.Read(msg, out ty.maxDamage);
            Marshaler.Read(msg, out ty.handicapSkillCount);
            Marshaler.Read(msg, out ty.minHPRatio);
            Marshaler.Read(msg, out ty.skillCombineByUserInputCount);
            Marshaler.Read(msg, out ty.counterPoseKillCount);
            Marshaler.Read(msg, out ty.skillLockCount);
            Marshaler.Read(msg, out ty.isUsedTargeting);
            Marshaler.Read(msg, out ty.isUsedCardReset);
            Marshaler.Read(msg, out ty.isUsedBalorEye);
            Marshaler.Read(msg, out ty.debuffPetrifactionCount);
            Marshaler.Read(msg, out ty.debuffFreezingCount);
            Marshaler.Read(msg, out ty.debuffPreventposeCount);
            Marshaler.Read(msg, out ty.debuffInfectionCount);
            Marshaler.Read(msg, out ty.buffImmuneCount);
            Marshaler.Read(msg, out ty.decreaseGaugeCount);
            Marshaler.Read(msg, out ty.skillDissipationCount);
            Marshaler.Read(msg, out ty.skillOptionDissipationCount);
            Marshaler.Read(msg, out ty.skillBustCount);
            Marshaler.Read(msg, out ty.skillWeaknessCount);
            Marshaler.Read(msg, out ty.eraseBuffCount);
            Marshaler.Read(msg, out ty.erasePoseCount);
            Marshaler.Read(msg, out ty.recoveryDebuffCount);
            Marshaler.Read(msg, out ty.cardDisuseCount);
            Marshaler.Read(msg, out ty.beAttackedCountBySpecialCard);
            Marshaler.Read(msg, out ty.useCountDropMamaSkill);
            Marshaler.Read(msg, out ty.isFinishedByDropMamaSkill);
            Marshaler.Read(msg, out ty.buffSkillUseCount);
            Marshaler.Read(msg, out ty.skillStaminaAttackCount);
            Marshaler.Read(msg, out ty.skillStaminaAddCount);
            Marshaler.Read(msg, out ty.skillIgnoreFixedDefCount);
            Marshaler.Read(msg, out ty.skillDefIgnoreCount);
            Marshaler.Read(msg, out ty.enemyPhoenixCount);
            Marshaler.Read(msg, out ty.cardUseHeroChange);
            Marshaler.Read(msg, out ty.monsterKillCount);
            Marshaler.Read(msg, out ty.skillDetonateCount);
            Marshaler.Read(msg, out ty.cardUseCount_Atk);
            Marshaler.Read(msg, out ty.cardUseCount_Atk_WithOut_Special);
            Marshaler.Read(msg, out ty.poseUseCount);
            Marshaler.Read(msg, out ty.stageBattleHeroSameKind);
            Marshaler.Read(msg, out ty.stageBattleCardUseSpecialKill);
        }

        public static void Read(Message msg, out List<IngameMissionProgressRequest> list)
        {
            list = new List<IngameMissionProgressRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                IngameMissionProgressRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out List<int> list)
        {
            list = new List<int>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                int item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out InteractiveChoice en)
        {
            byte num;
            msg.Read(out num);
            en = (InteractiveChoice)num;
        }

        public static void Read(Message msg, out List<InteractiveChoice> list)
        {
            list = new List<InteractiveChoice>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                InteractiveChoice item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out InvalidRequestType en)
        {
            uint num;
            msg.Read(out num);
            en = (InvalidRequestType)num;
        }

        public static void Read(Message msg, out List<InvalidRequestType> list)
        {
            list = new List<InvalidRequestType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                InvalidRequestType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ItemGambleShopBuyInfo ty)
        {
            ty = new ItemGambleShopBuyInfo();
            Marshaler.Read(msg, out ty.shopProductID);
            Marshaler.Read(msg, out ty.buyCount);
            Marshaler.Read(msg, out ty.buyCountByDia);
            Marshaler.Read(msg, out ty.buyCountByTicket);
            Marshaler.Read(msg, out ty.buyCountByKey);
            Marshaler.Read(msg, out ty.freeBuyCount);
        }

        public static void Read(Message msg, out List<ItemGambleShopBuyInfo> list)
        {
            list = new List<ItemGambleShopBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ItemGambleShopBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ItemOfferInfo ty)
        {
            ty = new ItemOfferInfo();
            Marshaler.Read(msg, out ty.itemOfferSEQ);
            Marshaler.Read(msg, out ty.startDate);
            Marshaler.Read(msg, out ty.endDate);
            Marshaler.Read(msg, out ty.itemID);
            Marshaler.Read(msg, out ty.itemCount);
        }

        public static void Read(Message msg, out List<ItemOfferInfo> list)
        {
            list = new List<ItemOfferInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ItemOfferInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ItemResultInfo ty)
        {
            ty = new ItemResultInfo();
            Marshaler.Read(msg, out ty.itemType);
            ItemType itemType = ty.itemType;
            if (itemType != ItemType.None)
            {
                switch (itemType)
                {
                    case ItemType.Hero:
                        Marshaler.Read(msg, out ty.userHeroInfo);
                        break;
                    case ItemType.Skin:
                        Marshaler.Read(msg, out ty.userSkinInfo);
                        break;
                    case ItemType.Weapon:
                        Marshaler.Read(msg, out ty.userWeaponInfo);
                        break;
                    case ItemType.Costume_Skin:
                        Marshaler.Read(msg, out ty.userCostumeSkin);
                        break;
                    case ItemType.Costume_Weapon:
                        Marshaler.Read(msg, out ty.userCostumeWeapon);
                        break;
                    case ItemType.Costume_Head:
                        Marshaler.Read(msg, out ty.userCostumeHead);
                        break;
                    case ItemType.Artifact_Card:
                        Marshaler.Read(msg, out ty.userArtifact);
                        break;
                    default:
                        Marshaler.Read(msg, out ty.userItemInfo);
                        break;
                }
            }
            Marshaler.Read(msg, out ty.getItemCount);
            Marshaler.Read(msg, out ty.ingameResultDropBoxGrade);
            Marshaler.Read(msg, out ty.ownerSkinID);
            Marshaler.Read(msg, out ty.ownerCostumeID);
            Marshaler.Read(msg, out ty.skinExp);
            Marshaler.Read(msg, out ty.buffAddCount);
            Marshaler.Read(msg, out ty.ownerArtifactCardID);
            Marshaler.Read(msg, out ty.isGrowthPointUpdate);
            Marshaler.Read(msg, out ty.growthPoint);
            //Marshaler.Read(msg, out ty.upgradeSkin);
            //Marshaler.Read(msg, out ty.prevSkinID);
        }

        public static void Read(Message msg, out List<ItemResultInfo> list)
        {
            list = new List<ItemResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ItemResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ItemSellType en)
        {
            int num;
            msg.Read(out num);
            en = (ItemSellType)num;
        }

        public static void Read(Message msg, out List<ItemSellType> list)
        {
            list = new List<ItemSellType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ItemSellType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ItemType en)
        {
            byte num;
            msg.Read(out num);
            en = (ItemType)num;
        }

        public static void Read(Message msg, out List<ItemType> list)
        {
            list = new List<ItemType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ItemType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ItemUseResult ty)
        {
            ty = new ItemUseResult();
            Marshaler.Read(msg, out ty.useItemInfo);
            Marshaler.Read(msg, out ty.itemResultInfoList);
            Marshaler.Read(msg, out ty.updateSkinList);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<ItemUseResult> list)
        {
            list = new List<ItemUseResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ItemUseResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out KOFBritanniaStageClearResultInfo ty)
        {
            ty = new KOFBritanniaStageClearResultInfo();
            Marshaler.Read(msg, out ty.stageClearResultInfo);
            Marshaler.Read(msg, out ty.firstTeamClearItemResultInfo);
            Marshaler.Read(msg, out ty.firstGroupClearItemResultInfoList);
        }

        public static void Read(Message msg, out List<KOFBritanniaStageClearResultInfo> list)
        {
            list = new List<KOFBritanniaStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                KOFBritanniaStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LanguageType en)
        {
            byte num;
            msg.Read(out num);
            en = (LanguageType)num;
        }

        public static void Read(Message msg, out List<LanguageType> list)
        {
            list = new List<LanguageType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LanguageType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LimitedCostumeInfo ty)
        {
            ty = new LimitedCostumeInfo();
            Marshaler.Read(msg, out ty.removeSkinCostumeGroupIDList);
            Marshaler.Read(msg, out ty.removeHeadCostumeGroupIDList);
            Marshaler.Read(msg, out ty.removeWeaponCostumeGroupIDList);
            Marshaler.Read(msg, out ty.updateUserSkinList);
        }

        public static void Read(Message msg, out List<LimitedCostumeInfo> list)
        {
            list = new List<LimitedCostumeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LimitedCostumeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyBuffInfo ty)
        {
            ty = new LobbyBuffInfo();
            Marshaler.Read(msg, out ty.buffID);
            Marshaler.Read(msg, out ty.buffLevel);
            Marshaler.Read(msg, out ty.buffValue);
            Marshaler.Read(msg, out ty.buffRemainSec);
        }

        public static void Read(Message msg, out List<LobbyBuffInfo> list)
        {
            list = new List<LobbyBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyCollectResult ty)
        {
            ty = new LobbyCollectResult();
            Marshaler.Read(msg, out ty.recipeCollectInfoList);
            Marshaler.Read(msg, out ty.buffNpcID);
            Marshaler.Read(msg, out ty.buffNpcValue);
            Marshaler.Read(msg, out ty.friendCookingEatCount);
            Marshaler.Read(msg, out ty.collectPassiveUseCount);
            Marshaler.Read(msg, out ty.goldRewardResultInfo);
            Marshaler.Read(msg, out ty.passiveItemResultInfoList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<LobbyCollectResult> list)
        {
            list = new List<LobbyCollectResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyCollectResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyCookingInfo ty)
        {
            ty = new LobbyCookingInfo();
            Marshaler.Read(msg, out ty.nextAppearRemainSec);
            Marshaler.Read(msg, out ty.appearHeroList);
            Marshaler.Read(msg, out ty.disappearRemainSec);
        }

        public static void Read(Message msg, out List<LobbyCookingInfo> list)
        {
            list = new List<LobbyCookingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyCookingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyGuestInfo ty)
        {
            ty = new LobbyGuestInfo();
            Marshaler.Read(msg, out ty.heroGuestIDList);
            Marshaler.Read(msg, out ty.currentVisitGuestID);
            Marshaler.Read(msg, out ty.newHeroVisit);
            Marshaler.Read(msg, out ty.remainHeroVisitTimeSec);
            Marshaler.Read(msg, out ty.currentVisitGuestIndex);
        }

        public static void Read(Message msg, out List<LobbyGuestInfo> list)
        {
            list = new List<LobbyGuestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyGuestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyInfo ty)
        {
            ty = new LobbyInfo();
            Marshaler.Read(msg, out ty.lobbyVRSearchList);
            Marshaler.Read(msg, out ty.lobbyReddotInfo);
            Marshaler.Read(msg, out ty.userNpcInfoList);
            Marshaler.Read(msg, out ty.guestNPCList);
            Marshaler.Read(msg, out ty.currentVisitGuestID);
            Marshaler.Read(msg, out ty.currentVisitGuestIndex);
            Marshaler.Read(msg, out ty.newHeroVisit);
            Marshaler.Read(msg, out ty.remainHeroVisitTimeSec);
            Marshaler.Read(msg, out ty.hawkCollectAble);
            Marshaler.Read(msg, out ty.eventPacketInfo);
            Marshaler.Read(msg, out ty.noticeList);
            Marshaler.Read(msg, out ty.packageBannerInfoList);
            Marshaler.Read(msg, out ty.disableDropInteractiveList);
            Marshaler.Read(msg, out ty.isGuildKickOut);
            Marshaler.Read(msg, out ty.guildMemberInfo);
            Marshaler.Read(msg, out ty.remainDailyResetTimeSEC);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.didDailyResetToday);
            Marshaler.Read(msg, out ty.randomShopInfo);
            Marshaler.Read(msg, out ty.clientSendFinalBossSeasonInfo);
            Marshaler.Read(msg, out ty.clientSendFinalBossSeasonShopInfo);
            Marshaler.Read(msg, out ty.userHeroGachaGaugeInfoList);
            Marshaler.Read(msg, out ty.userAgeLevel);
            Marshaler.Read(msg, out ty.monthlyInfo);
            Marshaler.Read(msg, out ty.gaugeEventFreeChargeAble);
            Marshaler.Read(msg, out ty.currentSeasonGroup);
            Marshaler.Read(msg, out ty.tournamentDiplayInfoList);
            Marshaler.Read(msg, out ty.userAdViewInfoList);
            Marshaler.Read(msg, out ty.clientSendBossWarInfo);
            Marshaler.Read(msg, out ty.arenaRealTimePvpLowGrade);
            Marshaler.Read(msg, out ty.arenaRealTimePvpLowGradeNumber);
            Marshaler.Read(msg, out ty.updateUserFurnitureList);
            Marshaler.Read(msg, out ty.firstDiaBuy);
            Marshaler.Read(msg, out ty.isGuildWarRejoinInfoExists);
            Marshaler.Read(msg, out ty.currentGuildWarScheduleInfo);
            Marshaler.Read(msg, out ty.isGuildWarSelected);
            Marshaler.Read(msg, out ty.guildWarRejoinInfoReaminTTLSec);
            Marshaler.Read(msg, out ty.guildWarSelectionInfoList);
            Marshaler.Read(msg, out ty.isGuildWarRankRewardable);
            Marshaler.Read(msg, out ty.activeSpecialGuestBuff);
            Marshaler.Read(msg, out ty.popupSpecialGuestBuff);
            Marshaler.Read(msg, out ty.popupPatrolMissionOpen);
            Marshaler.Read(msg, out ty.towerStageInfo);
            Marshaler.Read(msg, out ty.towerStageHeroInfo);
            Marshaler.Read(msg, out ty.disasterTowerStageInfo);
            Marshaler.Read(msg, out ty.disasterTowerStageHeroInfo);
            Marshaler.Read(msg, out ty.lowerLeagueTableID);
            Marshaler.Read(msg, out ty.guildBossSeasonID);
            Marshaler.Read(msg, out ty.guildBossGroupID);
            Marshaler.Read(msg, out ty.currentGuildWarLowScheduleInfo);
            Marshaler.Read(msg, out ty.isGuildWarLowRejoinInfoExists);
            Marshaler.Read(msg, out ty.guildWarLowRejoinInfoReaminTTLSec);
            Marshaler.Read(msg, out ty.isGuildWarLowPointRewardable);
            Marshaler.Read(msg, out ty.guildWarLowLastSeason);
            Marshaler.Read(msg, out ty.guildWarLowOpponentGuildSN);
            Marshaler.Read(msg, out ty.isGuildWarPrevSeasonSelected);
            Marshaler.Read(msg, out ty.guildAttendanceStatus);
            Marshaler.Read(msg, out ty.guildNoticeInfo);
            Marshaler.Read(msg, out ty.guildMarkList);
            Marshaler.Read(msg, out ty.gambleTimeSwitchLobbyInfo);
            Marshaler.Read(msg, out ty.growthPoint);
            Marshaler.Read(msg, out ty.stackConstellationStoneInfoList);
            Marshaler.Read(msg, out ty.isCreatureNestChallengeRewardable);
            Marshaler.Read(msg, out ty.isCreatureNestBlueDotOn);
            Marshaler.Read(msg, out ty.removeLimitedCostumeInfo);
            Marshaler.Read(msg, out ty.remainConstellationChaosChargeSec);
            Marshaler.Read(msg, out ty.arenaRealTimePvpSimpleInfo);
            Marshaler.Read(msg, out ty.clientSendEventMazeSeasonShopInfo);
            Marshaler.Read(msg, out ty.clientSendHeroLeagueInfo);
            Marshaler.Read(msg, out ty.clientSendHeroLeagueSeasonShopInfo);
            Marshaler.Read(msg, out ty.guildOrderMissionInfoClientSend);
            Marshaler.Read(msg, out ty.userGuildOrderMissionInfoClientSend);
            Marshaler.Read(msg, out ty.creatureColosseumSeasonInfo);
            Marshaler.Read(msg, out ty.demonLordInfo);
            Marshaler.Read(msg, out ty.diaShopBuyRemainTimeSec);
        }

        public static void Read(Message msg, out List<LobbyInfo> list)
        {
            list = new List<LobbyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyQuestGroupInfo ty)
        {
            ty = new LobbyQuestGroupInfo();
            Marshaler.Read(msg, out ty.questRoute);
            Marshaler.Read(msg, out ty.questGroup);
        }

        public static void Read(Message msg, out List<LobbyQuestGroupInfo> list)
        {
            list = new List<LobbyQuestGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyQuestGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyRandomShopInfo ty)
        {
            ty = new LobbyRandomShopInfo();
            Marshaler.Read(msg, out ty.dailySeq);
            Marshaler.Read(msg, out ty.visitRewardYN);
            Marshaler.Read(msg, out ty.remainRandomShopScheduleList);
        }

        public static void Read(Message msg, out List<LobbyRandomShopInfo> list)
        {
            list = new List<LobbyRandomShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyRandomShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyReddotInfo ty)
        {
            ty = new LobbyReddotInfo();
            Marshaler.Read(msg, out ty.mailListCount);
            Marshaler.Read(msg, out ty.friendMailListCount);
            Marshaler.Read(msg, out ty.destroyInviteCount);
            Marshaler.Read(msg, out ty.friendReddot);
            Marshaler.Read(msg, out ty.friendApplyReddot);
            Marshaler.Read(msg, out ty.guildReddot);
            Marshaler.Read(msg, out ty.noticeMailCount);
            Marshaler.Read(msg, out ty.packageMailCount);
            Marshaler.Read(msg, out ty.itemGambleShopFreeReddot);
            Marshaler.Read(msg, out ty.coinDailyShopFreeReddot);
            Marshaler.Read(msg, out ty.friendlyMatchInviteCount);
            Marshaler.Read(msg, out ty.realTimePvpRewardAble);
            Marshaler.Read(msg, out ty.guildReddot1);
            Marshaler.Read(msg, out ty.guildReddot2);
            Marshaler.Read(msg, out ty.guildReddot3);
            Marshaler.Read(msg, out ty.guildAttendableReddot);
            Marshaler.Read(msg, out ty.guildRankRewardReddot);
            Marshaler.Read(msg, out ty.guildInvitationCount);
            Marshaler.Read(msg, out ty.eventPuzzleRewardReddot);
            Marshaler.Read(msg, out ty.eventMoleGameRewardReddot);
            Marshaler.Read(msg, out ty.arenaSmashRewardAble);
        }

        public static void Read(Message msg, out List<LobbyReddotInfo> list)
        {
            list = new List<LobbyReddotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyReddotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LobbyVisualType en)
        {
            byte num;
            msg.Read(out num);
            en = (LobbyVisualType)num;
        }

        public static void Read(Message msg, out List<LobbyVisualType> list)
        {
            list = new List<LobbyVisualType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LobbyVisualType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LoginServiceInfo ty)
        {
            ty = new LoginServiceInfo();
            Marshaler.Read(msg, out ty.currentServerTime);
            Marshaler.Read(msg, out ty.maintenanceInfo);
            Marshaler.Read(msg, out ty.emergencyNoticeInfo);
            Marshaler.Read(msg, out ty.remainResetTimeSEC);
        }

        public static void Read(Message msg, out List<LoginServiceInfo> list)
        {
            list = new List<LoginServiceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LoginServiceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out LoginUserResultInfo ty)
        {
            ty = new LoginUserResultInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.sessionKey);
            Marshaler.Read(msg, out ty.name);
            Marshaler.Read(msg, out ty.nicknameChangeCount);
            Marshaler.Read(msg, out ty.exp);
            Marshaler.Read(msg, out ty.vipExp);
            Marshaler.Read(msg, out ty.noticeList);
            Marshaler.Read(msg, out ty.userHeroList);
            Marshaler.Read(msg, out ty.userSkinList);
            Marshaler.Read(msg, out ty.userWeaponList);
            Marshaler.Read(msg, out ty.userCommonItemList);
            Marshaler.Read(msg, out ty.extensionData);
            Marshaler.Read(msg, out ty.userTeamList);
            Marshaler.Read(msg, out ty.arenaRankingDefenceTeamInfo);
            Marshaler.Read(msg, out ty.arenaSmashDefenceTeamInfoList);
            Marshaler.Read(msg, out ty.tournamentTeamInfoList);
            Marshaler.Read(msg, out ty.userAPInfoList);
            Marshaler.Read(msg, out ty.userStageInfo);
            Marshaler.Read(msg, out ty.userWantToSay);
            Marshaler.Read(msg, out ty.userMaxFriendCount);
            Marshaler.Read(msg, out ty.userDailyReset);
            Marshaler.Read(msg, out ty.userRecipeInfoList);
            Marshaler.Read(msg, out ty.userBasePointContentsInfo);
            Marshaler.Read(msg, out ty.autoStartQuestIDList);
            Marshaler.Read(msg, out ty.userQuestProgressInfoList);
            Marshaler.Read(msg, out ty.missionAchieveRewardIndex);
            Marshaler.Read(msg, out ty.userGuildMemberInfo);
            Marshaler.Read(msg, out ty.userGuildName);
            Marshaler.Read(msg, out ty.frinedCode);
            Marshaler.Read(msg, out ty.playingDestroyRoomSN);
            Marshaler.Read(msg, out ty.userDestroyDiscoverInfoList);
            Marshaler.Read(msg, out ty.userAgeLevel);
            Marshaler.Read(msg, out ty.userTutorialInfoList);
            Marshaler.Read(msg, out ty.userQuickMessageInfoList);
            Marshaler.Read(msg, out ty.userStampBookmarkInfoList);
            Marshaler.Read(msg, out ty.rePayFlag);
            Marshaler.Read(msg, out ty.userNpcList);
            Marshaler.Read(msg, out ty.platformMissionInfoList);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.destroyInviteOption);
            Marshaler.Read(msg, out ty.isGuildInvitationOn);
            Marshaler.Read(msg, out ty.userNicknameChangeAvailableRemainSec);
            Marshaler.Read(msg, out ty.userCostumeSkin);
            Marshaler.Read(msg, out ty.userCostumeWeapon);
            Marshaler.Read(msg, out ty.userCostumeHead);
            Marshaler.Read(msg, out ty.userCostumeCraftUpgradeInfoList);
            Marshaler.Read(msg, out ty.userPackageInfoList);
            Marshaler.Read(msg, out ty.userDiaShopPackageInfoList);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.lobbyUniqueInteractiveFlag);
            Marshaler.Read(msg, out ty.questChapterClearInfo);
            Marshaler.Read(msg, out ty.loveRewardSeq);
            Marshaler.Read(msg, out ty.userGuildInfo);
            Marshaler.Read(msg, out ty.guildMemberInfoList);
            Marshaler.Read(msg, out ty.isCheatEnable);
            Marshaler.Read(msg, out ty.realTimePvpRewardAble);
            Marshaler.Read(msg, out ty.userBuffInfoList);
            Marshaler.Read(msg, out ty.userHeroGachaGaugeInfoList);
            Marshaler.Read(msg, out ty.eventMissionAchieveRewardIndex);
            Marshaler.Read(msg, out ty.restDayCount);
            Marshaler.Read(msg, out ty.isPvpLowerClear);
            Marshaler.Read(msg, out ty.accountCreateTime);
            Marshaler.Read(msg, out ty.userFurnitureList);
            Marshaler.Read(msg, out ty.friendInfoList);
            Marshaler.Read(msg, out ty.userFrozenAssetList);
            Marshaler.Read(msg, out ty.arenaRealTimePvpGrade);
            Marshaler.Read(msg, out ty.userWeaponUpgradeFailGaugeList);
            Marshaler.Read(msg, out ty.monthlyInfo);
            Marshaler.Read(msg, out ty.eventMissionCompleteRewardInfoList);
            Marshaler.Read(msg, out ty.guildBossRankPointList);
            Marshaler.Read(msg, out ty.guildBossRankPointReward);
            Marshaler.Read(msg, out ty.isDecisionPlayAble);
            Marshaler.Read(msg, out ty.userMusicList);
            Marshaler.Read(msg, out ty.isGuideListRewarded);
            Marshaler.Read(msg, out ty.guideListStep);
            Marshaler.Read(msg, out ty.playTitleID);
            Marshaler.Read(msg, out ty.playMusicID);
            Marshaler.Read(msg, out ty.musicInstrumentID);
            Marshaler.Read(msg, out ty.freePackageReward);
            Marshaler.Read(msg, out ty.seasonPassAccumulationCount);
            Marshaler.Read(msg, out ty.userPackageMissionInfoList);
            Marshaler.Read(msg, out ty.userFinalBossRankPointList);
            Marshaler.Read(msg, out ty.getPlayTitleList);
            Marshaler.Read(msg, out ty.reverseSeasonInfoList);
            Marshaler.Read(msg, out ty.guildWarUserSquadInfo);
            Marshaler.Read(msg, out ty.destroyDisasterInfo);
            Marshaler.Read(msg, out ty.userEventBingoInfo);
            Marshaler.Read(msg, out ty.userStageTicketClearInfoList);
            Marshaler.Read(msg, out ty.arenaSmashLobbyInfo);
            Marshaler.Read(msg, out ty.heroPassiveGroupInfoList);
            Marshaler.Read(msg, out ty.guildWarDefenceTeamInfoList);
            Marshaler.Read(msg, out ty.guildWarLowDefenceTeamInfoList);
            Marshaler.Read(msg, out ty.artifactCardIdList);
            Marshaler.Read(msg, out ty.artifactTeamInfoList);
            Marshaler.Read(msg, out ty.artifactUnionInfoList);
            Marshaler.Read(msg, out ty.northGrimBookCategoryInfoList);
            Marshaler.Read(msg, out ty.constellationInfo);
            Marshaler.Read(msg, out ty.lobbyVisualType);
            Marshaler.Read(msg, out ty.materialFusionPoint);
            Marshaler.Read(msg, out ty.battleEncounter);
            Marshaler.Read(msg, out ty.attendanceHeroID);
            Marshaler.Read(msg, out ty.activeAttendanceHeroID);
            Marshaler.Read(msg, out ty.dailyFreeGambleInfoClientSend);
            Marshaler.Read(msg, out ty.guildOrderMissionInfoClientSend);
            Marshaler.Read(msg, out ty.userGuildOrderMissionInfoClientSend);
        }

        public static void Read(Message msg, out List<LoginUserResultInfo> list)
        {
            list = new List<LoginUserResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                LoginUserResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out List<long> list)
        {
            list = new List<long>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                long item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MailHistoryInfo ty)
        {
            ty = new MailHistoryInfo();
            Marshaler.Read(msg, out ty.mailSN);
            Marshaler.Read(msg, out ty.itemID);
            Marshaler.Read(msg, out ty.itemCount);
            Marshaler.Read(msg, out ty.mailContentsType);
            Marshaler.Read(msg, out ty.openDate);
        }

        public static void Read(Message msg, out List<MailHistoryInfo> list)
        {
            list = new List<MailHistoryInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MailHistoryInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MailInfo ty)
        {
            ty = new MailInfo();
            Marshaler.Read(msg, out ty.mailSN);
            Marshaler.Read(msg, out ty.mailContentsType);
            Marshaler.Read(msg, out ty.itemType);
            Marshaler.Read(msg, out ty.itemID);
            Marshaler.Read(msg, out ty.itemCount);
            Marshaler.Read(msg, out ty.eventSN);
            Marshaler.Read(msg, out ty.expireDate);
        }

        public static void Read(Message msg, out List<MailInfo> list)
        {
            list = new List<MailInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MailInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MaintenanceInfo ty)
        {
            ty = new MaintenanceInfo();
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.message);
        }

        public static void Read(Message msg, out List<MaintenanceInfo> list)
        {
            list = new List<MaintenanceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MaintenanceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MakingCountInfo ty)
        {
            ty = new MakingCountInfo();
            Marshaler.Read(msg, out ty.makingID);
            Marshaler.Read(msg, out ty.makingCount);
        }

        public static void Read(Message msg, out List<MakingCountInfo> list)
        {
            list = new List<MakingCountInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MakingCountInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MakingProgressInfo ty)
        {
            ty = new MakingProgressInfo();
            Marshaler.Read(msg, out ty.makingSN);
            Marshaler.Read(msg, out ty.makingID);
            Marshaler.Read(msg, out ty.remainSecToComplete);
            Marshaler.Read(msg, out ty.makingEndDate);
        }

        public static void Read(Message msg, out List<MakingProgressInfo> list)
        {
            list = new List<MakingProgressInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MakingProgressInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MakingStartResultInfo ty)
        {
            ty = new MakingStartResultInfo();
            Marshaler.Read(msg, out ty.makingInfo);
            Marshaler.Read(msg, out ty.progressInfo);
            Marshaler.Read(msg, out ty.costItemInfo);
            Marshaler.Read(msg, out ty.materialItemInfoList);
        }

        public static void Read(Message msg, out List<MakingStartResultInfo> list)
        {
            list = new List<MakingStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MakingStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MakingUserInfo ty)
        {
            ty = new MakingUserInfo();
            Marshaler.Read(msg, out ty.makingID);
            Marshaler.Read(msg, out ty.remainSec);
            Marshaler.Read(msg, out ty.rewardStatus);
        }

        public static void Read(Message msg, out List<MakingUserInfo> list)
        {
            list = new List<MakingUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MakingUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MarketMissionInfo ty)
        {
            ty = new MarketMissionInfo();
            Marshaler.Read(msg, out ty.missionType);
            Marshaler.Read(msg, out ty.missionValue);
        }

        public static void Read(Message msg, out List<MarketMissionInfo> list)
        {
            list = new List<MarketMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MarketMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MasterRedisSkip en)
        {
            byte num;
            msg.Read(out num);
            en = (MasterRedisSkip)num;
        }

        public static void Read(Message msg, out List<MasterRedisSkip> list)
        {
            list = new List<MasterRedisSkip>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MasterRedisSkip item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MasterToGameMatchingResultInfo ty)
        {
            ty = new MasterToGameMatchingResultInfo();
            Marshaler.Read(msg, out ty.isSingleMatching);
            Marshaler.Read(msg, out ty.userUSN);
            Marshaler.Read(msg, out ty.targetUSN);
            Marshaler.Read(msg, out ty.firstAttackUSN);
            Marshaler.Read(msg, out ty.targetTeamIndex);
            Marshaler.Read(msg, out ty.targetFoodBuffItemID);
            Marshaler.Read(msg, out ty.targetNetmarblePID);
            Marshaler.Read(msg, out ty.targetUserLevel);
            Marshaler.Read(msg, out ty.targetBattlePowerPoint);
            Marshaler.Read(msg, out ty.targetBinStreak);
            Marshaler.Read(msg, out ty.targetRankPoint);
            Marshaler.Read(msg, out ty.relayServerConnect);
            Marshaler.Read(msg, out ty.gameserverID);
        }

        public static void Read(Message msg, out List<MasterToGameMatchingResultInfo> list)
        {
            list = new List<MasterToGameMatchingResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MasterToGameMatchingResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MatchingBossWarUserProfileInfo ty)
        {
            ty = new MatchingBossWarUserProfileInfo();
            Marshaler.Read(msg, out ty.bossWarUserProfileInfo);
            Marshaler.Read(msg, out ty.isReady);
            Marshaler.Read(msg, out ty.isLoadingEnd);
            Marshaler.Read(msg, out ty.isLeave);
            Marshaler.Read(msg, out ty.isDefeat);
            Marshaler.Read(msg, out ty.isDestroy);
            Marshaler.Read(msg, out ty.isBattleEnd);
            Marshaler.Read(msg, out ty.randomSeed);
            Marshaler.Read(msg, out ty.gameserverID);
        }

        public static void Read(Message msg, out List<MatchingBossWarUserProfileInfo> list)
        {
            list = new List<MatchingBossWarUserProfileInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MatchingBossWarUserProfileInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MatchResult en)
        {
            byte num;
            msg.Read(out num);
            en = (MatchResult)num;
        }

        public static void Read(Message msg, out List<MatchResult> list)
        {
            list = new List<MatchResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MatchResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MaterialItemInfo ty)
        {
            ty = new MaterialItemInfo();
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.itemSerial);
            Marshaler.Read(msg, out ty.itemCount);
        }

        public static void Read(Message msg, out List<MaterialItemInfo> list)
        {
            list = new List<MaterialItemInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MaterialItemInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MazeBuffType en)
        {
            byte num;
            msg.Read(out num);
            en = (MazeBuffType)num;
        }

        public static void Read(Message msg, out List<MazeBuffType> list)
        {
            list = new List<MazeBuffType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MazeBuffType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MazeClearBonusProgressType en)
        {
            byte num;
            msg.Read(out num);
            en = (MazeClearBonusProgressType)num;
        }

        public static void Read(Message msg, out List<MazeClearBonusProgressType> list)
        {
            list = new List<MazeClearBonusProgressType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MazeClearBonusProgressType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MazeHeroInfo ty)
        {
            ty = new MazeHeroInfo();
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinExp);
            Marshaler.Read(msg, out ty.awaken);
            Marshaler.Read(msg, out ty.trensend);
            Marshaler.Read(msg, out ty.skillLevelUpCount);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.slotIndex);
            Marshaler.Read(msg, out ty.isDead);
            //Marshaler.Read(msg, out ty.lastDecreaseHP);
            //Marshaler.Read(msg, out ty.lastIsDead);
            //Marshaler.Read(msg, out ty.teamType);
        }

        public static void Read(Message msg, out List<MazeHeroInfo> list)
        {
            list = new List<MazeHeroInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MazeHeroInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MazeSpotType en)
        {
            byte num;
            msg.Read(out num);
            en = (MazeSpotType)num;
        }

        public static void Read(Message msg, out List<MazeSpotType> list)
        {
            list = new List<MazeSpotType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MazeSpotType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MazeTeamType en)
        {
            byte num;
            msg.Read(out num);
            en = (MazeTeamType)num;
        }

        public static void Read(Message msg, out List<MazeTeamType> list)
        {
            list = new List<MazeTeamType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MazeTeamType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MercenaryDetailInfo ty)
        {
            ty = new MercenaryDetailInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.mercenaryHero);
            Marshaler.Read(msg, out ty.mercenarySkin);
            Marshaler.Read(msg, out ty.mercenaryWeaponList);
            Marshaler.Read(msg, out ty.skinCostumeList);
            Marshaler.Read(msg, out ty.weaponCostumeList);
            Marshaler.Read(msg, out ty.headCostumeList);
            Marshaler.Read(msg, out ty.costumeCraftUpgradeInfoList);
        }

        public static void Read(Message msg, out List<MercenaryDetailInfo> list)
        {
            list = new List<MercenaryDetailInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MercenaryDetailInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MercenaryInfo ty)
        {
            ty = new MercenaryInfo();
            //Marshaler.Read(msg, out ty.mercenaryLastUseTime);
            Marshaler.Read(msg, out ty.mercenaryUsn);
            Marshaler.Read(msg, out ty.mercenaryNickname);
            Marshaler.Read(msg, out ty.mercenaryUserExp);
            Marshaler.Read(msg, out ty.mercenaryRemainUsingSec);
            Marshaler.Read(msg, out ty.mercenaryState);
            Marshaler.Read(msg, out ty.mercenarySlotInfoList);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
        }

        public static void Read(Message msg, out List<MercenaryInfo> list)
        {
            list = new List<MercenaryInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MercenaryInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MercenarySlotInfo ty)
        {
            ty = new MercenarySlotInfo();
            Marshaler.Read(msg, out ty.mercenaryHeroID);
            Marshaler.Read(msg, out ty.mercenarySkinID);
            Marshaler.Read(msg, out ty.mercenarySkinExp);
            Marshaler.Read(msg, out ty.mercenarySkinAwaken);
            Marshaler.Read(msg, out ty.mercenarySkinResearchList);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
            Marshaler.Read(msg, out ty.skinCostumeGroupID);
            Marshaler.Read(msg, out ty.weaponCostumeGroupID);
            Marshaler.Read(msg, out ty.headCostumeGroupID);
            Marshaler.Read(msg, out ty.mercenarySkinTranscend);
            Marshaler.Read(msg, out ty.mercenarySkinExceed);
        }

        public static void Read(Message msg, out List<MercenarySlotInfo> list)
        {
            list = new List<MercenarySlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MercenarySlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MissionClearRequestInfo ty)
        {
            ty = new MissionClearRequestInfo();
            Marshaler.Read(msg, out ty.chainID);
            Marshaler.Read(msg, out ty.chainIndex);
        }

        public static void Read(Message msg, out List<MissionClearRequestInfo> list)
        {
            list = new List<MissionClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MissionClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MissionClearResultInfo ty)
        {
            ty = new MissionClearResultInfo();
            Marshaler.Read(msg, out ty.successChainIDList);
            Marshaler.Read(msg, out ty.getUserExp);
            Marshaler.Read(msg, out ty.itemResultInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.apRewardInfoList);
            Marshaler.Read(msg, out ty.errorType);
            Marshaler.Read(msg, out ty.invalidRequestType);
        }

        public static void Read(Message msg, out List<MissionClearResultInfo> list)
        {
            list = new List<MissionClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MissionClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MissionResult ty)
        {
            ty = new MissionResult();
            Marshaler.Read(msg, out ty.userMissionInfoList);
            Marshaler.Read(msg, out ty.marketMissionInfoList);
            Marshaler.Read(msg, out ty.eventMissionInfoList);
            Marshaler.Read(msg, out ty.guildMissionInfoList);
            Marshaler.Read(msg, out ty.titleMissionInfoList);
            Marshaler.Read(msg, out ty.guildGroupMissionInfoList);
            Marshaler.Read(msg, out ty.guildOrderMissionInfoList);
        }

        public static void Read(Message msg, out List<MissionResult> list)
        {
            list = new List<MissionResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MissionResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out MissionType en)
        {
            short num;
            msg.Read(out num);
            en = (MissionType)num;
        }

        public static void Read(Message msg, out List<MissionType> list)
        {
            list = new List<MissionType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                MissionType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NeedItemInfo ty)
        {
            ty = new NeedItemInfo();
            Marshaler.Read(msg, out ty.itemID);
            Marshaler.Read(msg, out ty.itemCount);
        }

        public static void Read(Message msg, out List<NeedItemInfo> list)
        {
            list = new List<NeedItemInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NeedItemInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NetmarbleAccountInfo ty)
        {
            ty = new NetmarbleAccountInfo();
            Marshaler.Read(msg, out ty.netmarblePlayerID);
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.banStatus);
            Marshaler.Read(msg, out ty.banReason);
            Marshaler.Read(msg, out ty.banCode);
            Marshaler.Read(msg, out ty.banLimitSec);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.languageChangeAble);
            Marshaler.Read(msg, out ty.needMobileConnect);
            Marshaler.Read(msg, out ty.recommandHeroID);
            Marshaler.Read(msg, out ty.recommandSkinID);
        }

        public static void Read(Message msg, out List<NetmarbleAccountInfo> list)
        {
            list = new List<NetmarbleAccountInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NetmarbleAccountInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NetmarbleSDKInfo ty)
        {
            ty = new NetmarbleSDKInfo();
            Marshaler.Read(msg, out ty.sdkJson);
            Marshaler.Read(msg, out ty.storeType);
            Marshaler.Read(msg, out ty.countryCode);
            Marshaler.Read(msg, out ty.joinedCountryCode);
            Marshaler.Read(msg, out ty.languageCode);
            Marshaler.Read(msg, out ty.platformADID);
            Marshaler.Read(msg, out ty.UDID);
            Marshaler.Read(msg, out ty.OS);
            Marshaler.Read(msg, out ty.timeZone);
            Marshaler.Read(msg, out ty.sdkADID);
        }

        public static void Read(Message msg, out List<NetmarbleSDKInfo> list)
        {
            list = new List<NetmarbleSDKInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NetmarbleSDKInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NetmarbleUserInfo ty)
        {
            ty = new NetmarbleUserInfo();
            Marshaler.Read(msg, out ty.netmarblePlayerID);
            Marshaler.Read(msg, out ty.userNickname);
            Marshaler.Read(msg, out ty.userLevel);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.banStatus);
            Marshaler.Read(msg, out ty.banReason);
            Marshaler.Read(msg, out ty.banCode);
            Marshaler.Read(msg, out ty.banLimitSec);
        }

        public static void Read(Message msg, out List<NetmarbleUserInfo> list)
        {
            list = new List<NetmarbleUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NetmarbleUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NorthGrimBookCategoryInfo ty)
        {
            ty = new NorthGrimBookCategoryInfo();
            Marshaler.Read(msg, out ty.categoryID);
            Marshaler.Read(msg, out ty.rewardFlag);
        }

        public static void Read(Message msg, out List<NorthGrimBookCategoryInfo> list)
        {
            list = new List<NorthGrimBookCategoryInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NorthGrimBookCategoryInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NorthQuestClearResultInfo ty)
        {
            ty = new NorthQuestClearResultInfo();
            Marshaler.Read(msg, out ty.questID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.removeItemResultInfoList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.apRewardInfoList);
        }

        public static void Read(Message msg, out List<NorthQuestClearResultInfo> list)
        {
            list = new List<NorthQuestClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NorthQuestClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NoticeInfo ty)
        {
            ty = new NoticeInfo();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.fromDate);
            Marshaler.Read(msg, out ty.toDate);
            Marshaler.Read(msg, out ty.noticeTimeColor);
            Marshaler.Read(msg, out ty.descriptionColor);
            Marshaler.Read(msg, out ty.priority);
            Marshaler.Read(msg, out ty.targetOSType);
            Marshaler.Read(msg, out ty.noticeStartTime);
            Marshaler.Read(msg, out ty.noticeEndTime);
            Marshaler.Read(msg, out ty.noticeType);
            Marshaler.Read(msg, out ty.languageSet);
            Marshaler.Read(msg, out ty.noticeLanguageDataList);
            Marshaler.Read(msg, out ty.specificData);
        }

        public static void Read(Message msg, out List<NoticeInfo> list)
        {
            list = new List<NoticeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NoticeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NoticeLanguageData ty)
        {
            ty = new NoticeLanguageData();
            Marshaler.Read(msg, out ty.languageType);
            Marshaler.Read(msg, out ty.imageURL);
            Marshaler.Read(msg, out ty.linkURL);
            Marshaler.Read(msg, out ty.description);
        }

        public static void Read(Message msg, out List<NoticeLanguageData> list)
        {
            list = new List<NoticeLanguageData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NoticeLanguageData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NoticeMailInfo ty)
        {
            ty = new NoticeMailInfo();
            Marshaler.Read(msg, out ty.noticeMailSEQ);
            Marshaler.Read(msg, out ty.expireRemainSEC);
            Marshaler.Read(msg, out ty.noticeTitle);
            Marshaler.Read(msg, out ty.noticeContents);
            Marshaler.Read(msg, out ty.getItemList);
            Marshaler.Read(msg, out ty.rewardGetStatus);
            Marshaler.Read(msg, out ty.linkURL);
            Marshaler.Read(msg, out ty.isRefundMail);
            Marshaler.Read(msg, out ty.noticeMailType);
        }

        public static void Read(Message msg, out List<NoticeMailInfo> list)
        {
            list = new List<NoticeMailInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NoticeMailInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NoticeMailLanguageData ty)
        {
            ty = new NoticeMailLanguageData();
            Marshaler.Read(msg, out ty.languageType);
            Marshaler.Read(msg, out ty.szTitle);
            Marshaler.Read(msg, out ty.szContents);
            Marshaler.Read(msg, out ty.szLinkURL);
        }

        public static void Read(Message msg, out List<NoticeMailLanguageData> list)
        {
            list = new List<NoticeMailLanguageData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NoticeMailLanguageData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NoticeMailType en)
        {
            byte num;
            msg.Read(out num);
            en = (NoticeMailType)num;
        }

        public static void Read(Message msg, out List<NoticeMailType> list)
        {
            list = new List<NoticeMailType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NoticeMailType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NoticeSpecificData ty)
        {
            ty = new NoticeSpecificData();
            Marshaler.Read(msg, out ty.title);
            Marshaler.Read(msg, out ty.imageURL);
            Marshaler.Read(msg, out ty.linkURL);
            Marshaler.Read(msg, out ty.description);
        }

        public static void Read(Message msg, out List<NoticeSpecificData> list)
        {
            list = new List<NoticeSpecificData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NoticeSpecificData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NoticeType en)
        {
            byte num;
            msg.Read(out num);
            en = (NoticeType)num;
        }

        public static void Read(Message msg, out List<NoticeType> list)
        {
            list = new List<NoticeType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NoticeType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NpcGiftResult ty)
        {
            ty = new NpcGiftResult();
            Marshaler.Read(msg, out ty.userNpc);
            Marshaler.Read(msg, out ty.useItemResultInfo);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.userBuffInfo);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<NpcGiftResult> list)
        {
            list = new List<NpcGiftResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NpcGiftResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NpcGiftState en)
        {
            byte num;
            msg.Read(out num);
            en = (NpcGiftState)num;
        }

        public static void Read(Message msg, out List<NpcGiftState> list)
        {
            list = new List<NpcGiftState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NpcGiftState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out NpcTalkResult ty)
        {
            ty = new NpcTalkResult();
            Marshaler.Read(msg, out ty.userNpc);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.interactiveQuestionID);
            Marshaler.Read(msg, out ty.choice);
            Marshaler.Read(msg, out ty.guestID);
            Marshaler.Read(msg, out ty.interactiveTalkID);
        }

        public static void Read(Message msg, out List<NpcTalkResult> list)
        {
            list = new List<NpcTalkResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                NpcTalkResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OpenCondition en)
        {
            byte num;
            msg.Read(out num);
            en = (OpenCondition)num;
        }

        public static void Read(Message msg, out List<OpenCondition> list)
        {
            list = new List<OpenCondition>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OpenCondition item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OSType en)
        {
            byte num;
            msg.Read(out num);
            en = (OSType)num;
        }

        public static void Read(Message msg, out List<OSType> list)
        {
            list = new List<OSType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OSType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OtherArtifactInfo ty)
        {
            ty = new OtherArtifactInfo();
            Marshaler.Read(msg, out ty.unionId);
            Marshaler.Read(msg, out ty.unionExp);
            Marshaler.Read(msg, out ty.artifactCardIdList);
        }

        public static void Read(Message msg, out List<OtherArtifactInfo> list)
        {
            list = new List<OtherArtifactInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OtherArtifactInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OtherConstellationStatusInfo ty)
        {
            ty = new OtherConstellationStatusInfo();
            Marshaler.Read(msg, out ty.type);
            Marshaler.Read(msg, out ty.value);
        }

        public static void Read(Message msg, out List<OtherConstellationStatusInfo> list)
        {
            list = new List<OtherConstellationStatusInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OtherConstellationStatusInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OtherPlayerSimpleTeamInfo ty)
        {
            ty = new OtherPlayerSimpleTeamInfo();
            Marshaler.Read(msg, out ty.teamBattlePoint);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.unitInfoList);
            Marshaler.Read(msg, out ty.lobbyBuffItemIDList);
            Marshaler.Read(msg, out ty.playTitleIDList);
            Marshaler.Read(msg, out ty.artifactInfo);
            Marshaler.Read(msg, out ty.constellationStatusInfoList);
        }

        public static void Read(Message msg, out List<OtherPlayerSimpleTeamInfo> list)
        {
            list = new List<OtherPlayerSimpleTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OtherPlayerSimpleTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OtherPlayerSimpleUnitInfo ty)
        {
            ty = new OtherPlayerSimpleUnitInfo();
            Marshaler.Read(msg, out ty.slotIndex);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinExp);
            Marshaler.Read(msg, out ty.attack);
            Marshaler.Read(msg, out ty.defense);
            Marshaler.Read(msg, out ty.hpMax);
            Marshaler.Read(msg, out ty.fateSkinID);
            Marshaler.Read(msg, out ty.fateAddAttack);
            Marshaler.Read(msg, out ty.fateAddDefense);
            Marshaler.Read(msg, out ty.fateAddHPMax);
            Marshaler.Read(msg, out ty.fateSkillLevelUpCount);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
            Marshaler.Read(msg, out ty.skinChangeID);
            Marshaler.Read(msg, out ty.skinWeaponChangeID);
            Marshaler.Read(msg, out ty.skinHeadChangeID);
            Marshaler.Read(msg, out ty.memorialClearIDList);
            Marshaler.Read(msg, out ty.exclusiveLevel);
            Marshaler.Read(msg, out ty.awaken);
            Marshaler.Read(msg, out ty.fateAwaken);
            Marshaler.Read(msg, out ty.skinTranscend);
            Marshaler.Read(msg, out ty.fateSkinTranscend);
            Marshaler.Read(msg, out ty.skinExceed);
            Marshaler.Read(msg, out ty.fateSkinExceed);
        }

        public static void Read(Message msg, out List<OtherPlayerSimpleUnitInfo> list)
        {
            list = new List<OtherPlayerSimpleUnitInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OtherPlayerSimpleUnitInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OtherPlayerSlotInfo ty)
        {
            ty = new OtherPlayerSlotInfo();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinExp);
            Marshaler.Read(msg, out ty.skinAwaken);
            Marshaler.Read(msg, out ty.researchList);
            Marshaler.Read(msg, out ty.equipWeaponList);
            Marshaler.Read(msg, out ty.skinCostumeGroupID);
            Marshaler.Read(msg, out ty.weaponCostumeGroupID);
            Marshaler.Read(msg, out ty.headCostumeGroupID);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
            Marshaler.Read(msg, out ty.skillLevelUpCount);
            Marshaler.Read(msg, out ty.maxLevelCount);
            Marshaler.Read(msg, out ty.passiveSkillLevel);
            Marshaler.Read(msg, out ty.registeredCostumeGroupList);
            Marshaler.Read(msg, out ty.transcend);
            Marshaler.Read(msg, out ty.skinExceed);
            Marshaler.Read(msg, out ty.registeredMadeCostumeGroup);
        }

        public static void Read(Message msg, out List<OtherPlayerSlotInfo> list)
        {
            list = new List<OtherPlayerSlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OtherPlayerSlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OtherPlayerTeamInfo ty)
        {
            ty = new OtherPlayerTeamInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.foodBuffItemID);
            Marshaler.Read(msg, out ty.teamSlotList);
            Marshaler.Read(msg, out ty.fateSlotList);
            Marshaler.Read(msg, out ty.skinCostumeList);
            Marshaler.Read(msg, out ty.weaponCostumeList);
            Marshaler.Read(msg, out ty.headCostumeList);
            Marshaler.Read(msg, out ty.lobbyBuffItemIDList);
            Marshaler.Read(msg, out ty.guildSkillUseList);
            Marshaler.Read(msg, out ty.aiLevel);
            Marshaler.Read(msg, out ty.playTitleIDList);
            Marshaler.Read(msg, out ty.aiCustomizingInfo);
            Marshaler.Read(msg, out ty.artifactInfo);
            Marshaler.Read(msg, out ty.constellationStatusInfoList);
            Marshaler.Read(msg, out ty.costumeCraftUpgradeInfoList);
        }

        public static void Read(Message msg, out List<OtherPlayerTeamInfo> list)
        {
            list = new List<OtherPlayerTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OtherPlayerTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out OtherPlayerWeapon ty)
        {
            ty = new OtherPlayerWeapon();
            Marshaler.Read(msg, out ty.weaponSerial);
            Marshaler.Read(msg, out ty.weaponBaseID);
            Marshaler.Read(msg, out ty.upgrade);
            Marshaler.Read(msg, out ty.evolution);
            Marshaler.Read(msg, out ty.addPassiveSkillList);
            Marshaler.Read(msg, out ty.addMagicSkill);
            Marshaler.Read(msg, out ty.defaultOptionValue);
            Marshaler.Read(msg, out ty.carveHeroGroup);
        }

        public static void Read(Message msg, out List<OtherPlayerWeapon> list)
        {
            list = new List<OtherPlayerWeapon>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                OtherPlayerWeapon item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PackageBannerInfo ty)
        {
            ty = new PackageBannerInfo();
            Marshaler.Read(msg, out ty.packageID);
            Marshaler.Read(msg, out ty.priority);
            Marshaler.Read(msg, out ty.packageImageUrl);
        }

        public static void Read(Message msg, out List<PackageBannerInfo> list)
        {
            list = new List<PackageBannerInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PackageBannerInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PackageMailHistoryInfo ty)
        {
            ty = new PackageMailHistoryInfo();
            //Marshaler.Read(msg, out ty.tID);
            Marshaler.Read(msg, out ty.mailSerial);
            Marshaler.Read(msg, out ty.packageID);
            Marshaler.Read(msg, out ty.openTime);
            Marshaler.Read(msg, out ty.choiceItemList);
        }

        public static void Read(Message msg, out List<PackageMailHistoryInfo> list)
        {
            list = new List<PackageMailHistoryInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PackageMailHistoryInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PackageMailInfo ty)
        {
            ty = new PackageMailInfo();
            //Marshaler.Read(msg, out ty.tID);
            Marshaler.Read(msg, out ty.mailSerial);
            Marshaler.Read(msg, out ty.packageID);
            Marshaler.Read(msg, out ty.mailContentsType);
            Marshaler.Read(msg, out ty.choiceItemList);
        }

        public static void Read(Message msg, out List<PackageMailInfo> list)
        {
            list = new List<PackageMailInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PackageMailInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PackageMissionStatus en)
        {
            byte num;
            msg.Read(out num);
            en = (PackageMissionStatus)num;
        }

        public static void Read(Message msg, out List<PackageMissionStatus> list)
        {
            list = new List<PackageMissionStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PackageMissionStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PacketError en)
        {
            uint num;
            msg.Read(out num);
            en = (PacketError)num;
        }

        public static void Read(Message msg, out List<PacketError> list)
        {
            list = new List<PacketError>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PacketError item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PatrolInfo ty)
        {
            ty = new PatrolInfo();
            Marshaler.Read(msg, out ty.rotationId);
            Marshaler.Read(msg, out ty.lastRewardElpasedTimeSEC);
            Marshaler.Read(msg, out ty.patrolMissionInfoList);
            Marshaler.Read(msg, out ty.eventEndDate);
        }

        public static void Read(Message msg, out List<PatrolInfo> list)
        {
            list = new List<PatrolInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PatrolInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PatrolMissionInfo ty)
        {
            ty = new PatrolMissionInfo();
            Marshaler.Read(msg, out ty.patrolId);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.heroIdList);
            Marshaler.Read(msg, out ty.remainCompleteTimeSec);
        }

        public static void Read(Message msg, out List<PatrolMissionInfo> list)
        {
            list = new List<PatrolMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PatrolMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PaybackEventResultInfo ty)
        {
            ty = new PaybackEventResultInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.paybackGroupID);
            Marshaler.Read(msg, out ty.addValue);
        }

        public static void Read(Message msg, out List<PaybackEventResultInfo> list)
        {
            list = new List<PaybackEventResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PaybackEventResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PickInfo ty)
        {
            ty = new PickInfo();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.count);
        }

        public static void Read(Message msg, out List<PickInfo> list)
        {
            list = new List<PickInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PickInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PlayTitleGroupActiveInfo ty)
        {
            ty = new PlayTitleGroupActiveInfo();
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.activeStartRemainSec);
            Marshaler.Read(msg, out ty.activeEndRemainSec);
        }

        public static void Read(Message msg, out List<PlayTitleGroupActiveInfo> list)
        {
            list = new List<PlayTitleGroupActiveInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PlayTitleGroupActiveInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PlayTitleMissionClearRequestInfo ty)
        {
            ty = new PlayTitleMissionClearRequestInfo();
            Marshaler.Read(msg, out ty.missionID);
        }

        public static void Read(Message msg, out List<PlayTitleMissionClearRequestInfo> list)
        {
            list = new List<PlayTitleMissionClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PlayTitleMissionClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PlayTitleMissionClearResultInfo ty)
        {
            ty = new PlayTitleMissionClearResultInfo();
            Marshaler.Read(msg, out ty.successMissionIDList);
            Marshaler.Read(msg, out ty.getUserExp);
            Marshaler.Read(msg, out ty.itemResultInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.apRewardInfoList);
            Marshaler.Read(msg, out ty.errorType);
            Marshaler.Read(msg, out ty.invalidRequestType);
        }

        public static void Read(Message msg, out List<PlayTitleMissionClearResultInfo> list)
        {
            list = new List<PlayTitleMissionClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PlayTitleMissionClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PointCommonItemID en)
        {
            int num;
            msg.Read(out num);
            en = (PointCommonItemID)num;
        }

        public static void Read(Message msg, out List<PointCommonItemID> list)
        {
            list = new List<PointCommonItemID>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PointCommonItemID item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PVPRankingInfo ty)
        {
            ty = new PVPRankingInfo();
            Marshaler.Read(msg, out ty.currentSeasionID);
            Marshaler.Read(msg, out ty.seasonRankInfo);
            Marshaler.Read(msg, out ty.mySeasonInfo);
            Marshaler.Read(msg, out ty.pvpRankingInfo);
            Marshaler.Read(msg, out ty.myRankingInfo);
            Marshaler.Read(msg, out ty.pvpLowerInfo);
            Marshaler.Read(msg, out ty.myLowerInfo);
            Marshaler.Read(msg, out ty.pvpLimitInfo);
            Marshaler.Read(msg, out ty.myLimitInfo);
        }

        public static void Read(Message msg, out List<PVPRankingInfo> list)
        {
            list = new List<PVPRankingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PVPRankingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PVPRankingMyInfo ty)
        {
            ty = new PVPRankingMyInfo();
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.point);
            Marshaler.Read(msg, out ty.rank);
        }

        public static void Read(Message msg, out List<PVPRankingMyInfo> list)
        {
            list = new List<PVPRankingMyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PVPRankingMyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PVPRankingTopUserInfo ty)
        {
            ty = new PVPRankingTopUserInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.point);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.userRankExp);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBackgroundID);
        }

        public static void Read(Message msg, out List<PVPRankingTopUserInfo> list)
        {
            list = new List<PVPRankingTopUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PVPRankingTopUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PvpSeasonHistoryInfo ty)
        {
            ty = new PvpSeasonHistoryInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.seasonPoint);
            Marshaler.Read(msg, out ty.seasonRank);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userRankExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.costumeSkinGroupID);
            Marshaler.Read(msg, out ty.costumeWeaponGroupID);
            Marshaler.Read(msg, out ty.costumeHeadGroupID);
            Marshaler.Read(msg, out ty.isHelmetOpen);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBackgroundID);
        }

        public static void Read(Message msg, out List<PvpSeasonHistoryInfo> list)
        {
            list = new List<PvpSeasonHistoryInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PvpSeasonHistoryInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PvpSeasonLastWeekInfo ty)
        {
            ty = new PvpSeasonLastWeekInfo();
            Marshaler.Read(msg, out ty.isView);
            Marshaler.Read(msg, out ty.seasonPoint);
            Marshaler.Read(msg, out ty.currentRank);
            Marshaler.Read(msg, out ty.lastWeekRank);
            Marshaler.Read(msg, out ty.lastWeekPoint);
            Marshaler.Read(msg, out ty.rewardPoint);
            Marshaler.Read(msg, out ty.rewardRank);
        }

        public static void Read(Message msg, out List<PvpSeasonLastWeekInfo> list)
        {
            list = new List<PvpSeasonLastWeekInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PvpSeasonLastWeekInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PvpSeasonLastWeeklyUserInfo ty)
        {
            ty = new PvpSeasonLastWeeklyUserInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.seasonPoint);
            Marshaler.Read(msg, out ty.currentRank);
            Marshaler.Read(msg, out ty.oldRank);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.userRankExp);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBackgroundID);
        }

        public static void Read(Message msg, out List<PvpSeasonLastWeeklyUserInfo> list)
        {
            list = new List<PvpSeasonLastWeeklyUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PvpSeasonLastWeeklyUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PvpSeasonRewardInfo ty)
        {
            ty = new PvpSeasonRewardInfo();
            Marshaler.Read(msg, out ty.isReward);
            Marshaler.Read(msg, out ty.rewardSeasonID);
            Marshaler.Read(msg, out ty.seasonPoint);
            Marshaler.Read(msg, out ty.seasonRank);
            Marshaler.Read(msg, out ty.rewardItemInfoList);
        }

        public static void Read(Message msg, out List<PvpSeasonRewardInfo> list)
        {
            list = new List<PvpSeasonRewardInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PvpSeasonRewardInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out PvpSkillDataInfo ty)
        {
            ty = new PvpSkillDataInfo();
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.skillTarget);
            Marshaler.Read(msg, out ty.currentCost);
        }

        public static void Read(Message msg, out List<PvpSkillDataInfo> list)
        {
            list = new List<PvpSkillDataInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                PvpSkillDataInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out QuestChapterClearInfo ty)
        {
            ty = new QuestChapterClearInfo();
            Marshaler.Read(msg, out ty.storyChapterRewardFlag);
            Marshaler.Read(msg, out ty.anotherChapterRewardFlag);
            Marshaler.Read(msg, out ty.northChapterRewardFlag);
            Marshaler.Read(msg, out ty.disasterChapterRewardFlag);
        }

        public static void Read(Message msg, out List<QuestChapterClearInfo> list)
        {
            list = new List<QuestChapterClearInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                QuestChapterClearInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out QuestClass en)
        {
            byte num;
            msg.Read(out num);
            en = (QuestClass)num;
        }

        public static void Read(Message msg, out List<QuestClass> list)
        {
            list = new List<QuestClass>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                QuestClass item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out QuestClearResultInfo ty)
        {
            ty = new QuestClearResultInfo();
            Marshaler.Read(msg, out ty.questID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.getItemResultInfoList);
            Marshaler.Read(msg, out ty.removeItemResultInfoList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.basepointGetExp);
            Marshaler.Read(msg, out ty.basepointInfo);
            Marshaler.Read(msg, out ty.apRewardInfoList);
            Marshaler.Read(msg, out ty.lobbyVisualType);
        }

        public static void Read(Message msg, out List<QuestClearResultInfo> list)
        {
            list = new List<QuestClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                QuestClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out QuestGroupInfo ty)
        {
            ty = new QuestGroupInfo();
            Marshaler.Read(msg, out ty.questGroup);
            Marshaler.Read(msg, out ty.questID);
        }

        public static void Read(Message msg, out List<QuestGroupInfo> list)
        {
            list = new List<QuestGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                QuestGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out QuestProgressInfo ty)
        {
            ty = new QuestProgressInfo();
            Marshaler.Read(msg, out ty.questID);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.progressCountList);
            Marshaler.Read(msg, out ty.interactionFlag);
        }

        public static void Read(Message msg, out List<QuestProgressInfo> list)
        {
            list = new List<QuestProgressInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                QuestProgressInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out QuestState en)
        {
            byte num;
            msg.Read(out num);
            en = (QuestState)num;
        }

        public static void Read(Message msg, out List<QuestState> list)
        {
            list = new List<QuestState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                QuestState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out QuestType en)
        {
            byte num;
            msg.Read(out num);
            en = (QuestType)num;
        }

        public static void Read(Message msg, out List<QuestType> list)
        {
            list = new List<QuestType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                QuestType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RandomShopSchedule ty)
        {
            ty = new RandomShopSchedule();
            Marshaler.Read(msg, out ty.basepointID);
            Marshaler.Read(msg, out ty.openRemainSec);
            Marshaler.Read(msg, out ty.closeRemainSec);
            //Marshaler.Read(msg, out ty.openDateTime);
            //Marshaler.Read(msg, out ty.closeDateTime);
        }

        public static void Read(Message msg, out List<RandomShopSchedule> list)
        {
            list = new List<RandomShopSchedule>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RandomShopSchedule item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RandomshopSlotInfo ty)
        {
            ty = new RandomshopSlotInfo();
            Marshaler.Read(msg, out ty.shopID);
            Marshaler.Read(msg, out ty.slotIndex);
            Marshaler.Read(msg, out ty.buyCount);
            Marshaler.Read(msg, out ty.PriceID);
        }

        public static void Read(Message msg, out List<RandomshopSlotInfo> list)
        {
            list = new List<RandomshopSlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RandomshopSlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RandomShopSlotState en)
        {
            byte num;
            msg.Read(out num);
            en = (RandomShopSlotState)num;
        }

        public static void Read(Message msg, out List<RandomShopSlotState> list)
        {
            list = new List<RandomShopSlotState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RandomShopSlotState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RandomShopSlotType en)
        {
            byte num;
            msg.Read(out num);
            en = (RandomShopSlotType)num;
        }

        public static void Read(Message msg, out List<RandomShopSlotType> list)
        {
            list = new List<RandomShopSlotType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RandomShopSlotType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RatingType en)
        {
            byte num;
            msg.Read(out num);
            en = (RatingType)num;
        }

        public static void Read(Message msg, out List<RatingType> list)
        {
            list = new List<RatingType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RatingType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecipeCollectInfo ty)
        {
            ty = new RecipeCollectInfo();
            Marshaler.Read(msg, out ty.recipeID);
            Marshaler.Read(msg, out ty.sellCount);
        }

        public static void Read(Message msg, out List<RecipeCollectInfo> list)
        {
            list = new List<RecipeCollectInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecipeCollectInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecipeOrderInfo ty)
        {
            ty = new RecipeOrderInfo();
            Marshaler.Read(msg, out ty.slotNumber);
            Marshaler.Read(msg, out ty.recipeID);
            Marshaler.Read(msg, out ty.sellCount);
            Marshaler.Read(msg, out ty.collectCount);
            Marshaler.Read(msg, out ty.remainSEC);
        }

        public static void Read(Message msg, out List<RecipeOrderInfo> list)
        {
            list = new List<RecipeOrderInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecipeOrderInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecommandHeroData ty)
        {
            ty = new RecommandHeroData();
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.cnt);
            Marshaler.Read(msg, out ty.battleCNT);
        }

        public static void Read(Message msg, out List<RecommandHeroData> list)
        {
            list = new List<RecommandHeroData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecommandHeroData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecommandHeroInfo ty)
        {
            ty = new RecommandHeroInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.m_mainRecommandHeroDataList);
            Marshaler.Read(msg, out ty.m_subRecommandHeroDataList);
        }

        public static void Read(Message msg, out List<RecommandHeroInfo> list)
        {
            list = new List<RecommandHeroInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecommandHeroInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecommandHeroRequestInfo ty)
        {
            ty = new RecommandHeroRequestInfo();
            Marshaler.Read(msg, out ty.stageMode);
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.destroyGroupID);
            Marshaler.Read(msg, out ty.diffculty);
        }

        public static void Read(Message msg, out List<RecommandHeroRequestInfo> list)
        {
            list = new List<RecommandHeroRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecommandHeroRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecommendHeroGrowthInfo ty)
        {
            ty = new RecommendHeroGrowthInfo();
            Marshaler.Read(msg, out ty.recommendWeaponSetTypeList);
            Marshaler.Read(msg, out ty.recommendWeaponOptionInfoList);
            Marshaler.Read(msg, out ty.recommendTeamInfoList);
        }

        public static void Read(Message msg, out List<RecommendHeroGrowthInfo> list)
        {
            list = new List<RecommendHeroGrowthInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecommendHeroGrowthInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecommendHeroGrowthTeamInfo ty)
        {
            ty = new RecommendHeroGrowthTeamInfo();
            Marshaler.Read(msg, out ty.stageType);
            Marshaler.Read(msg, out ty.stageSubType);
            Marshaler.Read(msg, out ty.stageId);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.heroIdList);
        }

        public static void Read(Message msg, out List<RecommendHeroGrowthTeamInfo> list)
        {
            list = new List<RecommendHeroGrowthTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecommendHeroGrowthTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecommendHeroGrowthWeaponOptionInfo ty)
        {
            ty = new RecommendHeroGrowthWeaponOptionInfo();
            Marshaler.Read(msg, out ty.group);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.optionId);
        }

        public static void Read(Message msg, out List<RecommendHeroGrowthWeaponOptionInfo> list)
        {
            list = new List<RecommendHeroGrowthWeaponOptionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecommendHeroGrowthWeaponOptionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RecommendHeroGrowthWeaponSetInfo ty)
        {
            ty = new RecommendHeroGrowthWeaponSetInfo();
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.weaponSetTypeList);
        }

        public static void Read(Message msg, out List<RecommendHeroGrowthWeaponSetInfo> list)
        {
            list = new List<RecommendHeroGrowthWeaponSetInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RecommendHeroGrowthWeaponSetInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RedisAncientWarUserRankInfo ty)
        {
            ty = new RedisAncientWarUserRankInfo();
            Marshaler.Read(msg, out ty.USN);
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.teamType);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.totolRankUpCount);
            Marshaler.Read(msg, out ty.rankUnixTime);
            //Marshaler.Read(msg, out ty.areaId);
        }

        public static void Read(Message msg, out List<RedisAncientWarUserRankInfo> list)
        {
            list = new List<RedisAncientWarUserRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RedisAncientWarUserRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RedisEventMoleGameRankInfo ty)
        {
            ty = new RedisEventMoleGameRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.highScore);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.totolRankUpCount);
        }

        public static void Read(Message msg, out List<RedisEventMoleGameRankInfo> list)
        {
            list = new List<RedisEventMoleGameRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RedisEventMoleGameRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RedisFinalBossDifficultyRankInfo ty)
        {
            ty = new RedisFinalBossDifficultyRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.topRankUnxs);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.totalRankUpCount);
            Marshaler.Read(msg, out ty.difficulty);
        }

        public static void Read(Message msg, out List<RedisFinalBossDifficultyRankInfo> list)
        {
            list = new List<RedisFinalBossDifficultyRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RedisFinalBossDifficultyRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RedisFinalBossRankInfo ty)
        {
            ty = new RedisFinalBossRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.totolRankUpCount);
            Marshaler.Read(msg, out ty.score);
            //Marshaler.Read(msg, out ty.topRankUnxs);
            //Marshaler.Read(msg, out ty.difficultyRankSkinIDList);
            //Marshaler.Read(msg, out ty.difficultyRankPoint);
            //Marshaler.Read(msg, out ty.difficultyTopRankUnxs);
        }

        public static void Read(Message msg, out List<RedisFinalBossRankInfo> list)
        {
            list = new List<RedisFinalBossRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RedisFinalBossRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RedisGuildBossRankInfo ty)
        {
            ty = new RedisGuildBossRankInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.totolRankUpCount);
            Marshaler.Read(msg, out ty.difficulty);
            //Marshaler.Read(msg, out ty.weekSEQ);
            //Marshaler.Read(msg, out ty.redisPoint);
        }

        public static void Read(Message msg, out List<RedisGuildBossRankInfo> list)
        {
            list = new List<RedisGuildBossRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RedisGuildBossRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RegisterInfo ty)
        {
            ty = new RegisterInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.friendID);
        }

        public static void Read(Message msg, out List<RegisterInfo> list)
        {
            list = new List<RegisterInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RegisterInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RelayConnRequest ty)
        {
            ty = new RelayConnRequest();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.sessionKey);
            Marshaler.Read(msg, out ty.contentType);
            Marshaler.Read(msg, out ty.roomSN);
        }

        public static void Read(Message msg, out List<RelayConnRequest> list)
        {
            list = new List<RelayConnRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RelayConnRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RelayContentType en)
        {
            int num;
            msg.Read(out num);
            en = (RelayContentType)num;
        }

        public static void Read(Message msg, out List<RelayContentType> list)
        {
            list = new List<RelayContentType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RelayContentType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RelayRoomState en)
        {
            byte num;
            msg.Read(out num);
            en = (RelayRoomState)num;
        }

        public static void Read(Message msg, out List<RelayRoomState> list)
        {
            list = new List<RelayRoomState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RelayRoomState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RelayServerInfo ty)
        {
            ty = new RelayServerInfo();
            Marshaler.Read(msg, out ty.serverIP);
            Marshaler.Read(msg, out ty.serverPort);
            Marshaler.Read(msg, out ty.sessionKey);
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.ingameSeed);
            Marshaler.Read(msg, out ty.playKey);
        }

        public static void Read(Message msg, out List<RelayServerInfo> list)
        {
            list = new List<RelayServerInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RelayServerInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RelayServerNodeInfo ty)
        {
            ty = new RelayServerNodeInfo();
            Marshaler.Read(msg, out ty.serverID);
            Marshaler.Read(msg, out ty.sessionKey);
            Marshaler.Read(msg, out ty.serverPort);
        }

        public static void Read(Message msg, out List<RelayServerNodeInfo> list)
        {
            list = new List<RelayServerNodeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RelayServerNodeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RelayUserType en)
        {
            int num;
            msg.Read(out num);
            en = (RelayUserType)num;
        }

        public static void Read(Message msg, out List<RelayUserType> list)
        {
            list = new List<RelayUserType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RelayUserType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ReplayBytesInfo ty)
        {
            ty = new ReplayBytesInfo();
            Marshaler.Read(msg, out ty.data);
        }

        public static void Read(Message msg, out List<ReplayBytesInfo> list)
        {
            list = new List<ReplayBytesInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ReplayBytesInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ReplayInfo ty)
        {
            ty = new ReplayInfo();
            Marshaler.Read(msg, out ty.body);
            Marshaler.Read(msg, out ty.syncList);
        }

        public static void Read(Message msg, out List<ReplayInfo> list)
        {
            list = new List<ReplayInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ReplayInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ReverseGroupInfo ty)
        {
            ty = new ReverseGroupInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.firstClearFlag);
            Marshaler.Read(msg, out ty.missionFlag);
        }

        public static void Read(Message msg, out List<ReverseGroupInfo> list)
        {
            list = new List<ReverseGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ReverseGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ReverseSeasonInfo ty)
        {
            ty = new ReverseSeasonInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.starRewardIndex);
            Marshaler.Read(msg, out ty.groupRewardFlag);
            Marshaler.Read(msg, out ty.reverseGroupInfoList);
        }

        public static void Read(Message msg, out List<ReverseSeasonInfo> list)
        {
            list = new List<ReverseSeasonInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ReverseSeasonInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out RewardStatusType en)
        {
            byte num;
            msg.Read(out num);
            en = (RewardStatusType)num;
        }

        public static void Read(Message msg, out List<RewardStatusType> list)
        {
            list = new List<RewardStatusType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                RewardStatusType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SeasonPassRankRewardSlotInfo ty)
        {
            ty = new SeasonPassRankRewardSlotInfo();
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.rewardFlag);
        }

        public static void Read(Message msg, out List<SeasonPassRankRewardSlotInfo> list)
        {
            list = new List<SeasonPassRankRewardSlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SeasonPassRankRewardSlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SeasonPassShopBuyInfo ty)
        {
            ty = new SeasonPassShopBuyInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.buyInfo);
        }

        public static void Read(Message msg, out List<SeasonPassShopBuyInfo> list)
        {
            list = new List<SeasonPassShopBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SeasonPassShopBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SendCookingInfo ty)
        {
            ty = new SendCookingInfo();
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.orderCount);
            Marshaler.Read(msg, out ty.remainOrderCount);
        }

        public static void Read(Message msg, out List<SendCookingInfo> list)
        {
            list = new List<SendCookingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SendCookingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerAncientWarControlInfo ty)
        {
            ty = new ServerAncientWarControlInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.startDate);
            Marshaler.Read(msg, out ty.endDate);
            Marshaler.Read(msg, out ty.calculateDate);
            Marshaler.Read(msg, out ty.rewardDate);
        }

        public static void Read(Message msg, out List<ServerAncientWarControlInfo> list)
        {
            list = new List<ServerAncientWarControlInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerAncientWarControlInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerArenaRealTimePVPLimitHeroCostInfo ty)
        {
            ty = new ServerArenaRealTimePVPLimitHeroCostInfo();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.heroId);
            Marshaler.Read(msg, out ty.cost);
            Marshaler.Read(msg, out ty.grade);
            //Marshaler.Read(msg, out ty.rank);
        }

        public static void Read(Message msg, out List<ServerArenaRealTimePVPLimitHeroCostInfo> list)
        {
            list = new List<ServerArenaRealTimePVPLimitHeroCostInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerArenaRealTimePVPLimitHeroCostInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerArenaRealTimePVPMatchingInfo ty)
        {
            ty = new ServerArenaRealTimePVPMatchingInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.grade);
            Marshaler.Read(msg, out ty.gradeNumber);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.foodBuffID);
            Marshaler.Read(msg, out ty.userLevel);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.netmarblePID);
            Marshaler.Read(msg, out ty.rankPoint);
            Marshaler.Read(msg, out ty.isPlacementMatching);
            Marshaler.Read(msg, out ty.isSerialLose);
            Marshaler.Read(msg, out ty.isRealTimeMatch);
            Marshaler.Read(msg, out ty.joinTick);
            Marshaler.Read(msg, out ty.matchingAbleMinPoint);
            Marshaler.Read(msg, out ty.matchingAbleMaxPoint);
            Marshaler.Read(msg, out ty.arenaRankingMatchingSuccess);
            Marshaler.Read(msg, out ty.matchingTargetUSN);
            Marshaler.Read(msg, out ty.matchingAIUSN);
            Marshaler.Read(msg, out ty.checkAIRandomTick);
            Marshaler.Read(msg, out ty.sessionKey);
            Marshaler.Read(msg, out ty.relayServerConnect);
            Marshaler.Read(msg, out ty.gameServerID);
        }

        public static void Read(Message msg, out List<ServerArenaRealTimePVPMatchingInfo> list)
        {
            list = new List<ServerArenaRealTimePVPMatchingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerArenaRealTimePVPMatchingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerEventDBInfo ty)
        {
            ty = new ServerEventDBInfo();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.eventJson);
            Marshaler.Read(msg, out ty.eventTitle);
            Marshaler.Read(msg, out ty.eventSubTitle);
            Marshaler.Read(msg, out ty.imageURL);
            Marshaler.Read(msg, out ty.linkURL);
            Marshaler.Read(msg, out ty.priority);
            Marshaler.Read(msg, out ty.description);
            Marshaler.Read(msg, out ty.tabNumber);
            Marshaler.Read(msg, out ty.tabName);
            Marshaler.Read(msg, out ty.tabPriority);
            Marshaler.Read(msg, out ty.toDate);
            Marshaler.Read(msg, out ty.fromDate);
            Marshaler.Read(msg, out ty.maintenance);
            Marshaler.Read(msg, out ty.emphasis);
            Marshaler.Read(msg, out ty.subIndexList);
        }

        public static void Read(Message msg, out List<ServerEventDBInfo> list)
        {
            list = new List<ServerEventDBInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerEventDBInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerEventInfo ty)
        {
            ty = new ServerEventInfo();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.eventJson);
            Marshaler.Read(msg, out ty.eventTitle);
            Marshaler.Read(msg, out ty.eventSubTitle);
            Marshaler.Read(msg, out ty.imgURL);
            Marshaler.Read(msg, out ty.linkURL);
            Marshaler.Read(msg, out ty.priority);
            Marshaler.Read(msg, out ty.description);
            Marshaler.Read(msg, out ty.tabNumber);
            Marshaler.Read(msg, out ty.tabName);
            Marshaler.Read(msg, out ty.tabPriority);
            Marshaler.Read(msg, out ty.startRemainSec);
            Marshaler.Read(msg, out ty.endRemainSec);
            Marshaler.Read(msg, out ty.toDate);
            Marshaler.Read(msg, out ty.fromDate);
            Marshaler.Read(msg, out ty.eventOpenType);
            Marshaler.Read(msg, out ty.nextOpenReaminSec);
            Marshaler.Read(msg, out ty.playAbleRemainSec);
            Marshaler.Read(msg, out ty.timeIndex);
            Marshaler.Read(msg, out ty.maintenance);
            Marshaler.Read(msg, out ty.emphasis);
        }

        public static void Read(Message msg, out List<ServerEventInfo> list)
        {
            list = new List<ServerEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerEventType en)
        {
            int num;
            msg.Read(out num);
            en = (ServerEventType)num;
        }

        public static void Read(Message msg, out List<ServerEventType> list)
        {
            list = new List<ServerEventType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerEventType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerIniInfo ty)
        {
            ty = new ServerIniInfo();
            Marshaler.Read(msg, out ty.clientAccessVersion);
            Marshaler.Read(msg, out ty.cdnAccessVersion);
            Marshaler.Read(msg, out ty.securityList);
            Marshaler.Read(msg, out ty.finalBossRankPointMax);
            Marshaler.Read(msg, out ty.guildBossRankPointMax);
            Marshaler.Read(msg, out ty.logLevel);
            Marshaler.Read(msg, out ty.targetHost);
            Marshaler.Read(msg, out ty.redisSkip);
            Marshaler.Read(msg, out ty.localSkip);
        }

        public static void Read(Message msg, out List<ServerIniInfo> list)
        {
            list = new List<ServerIniInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerIniInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerMaintenanceInfo ty)
        {
            ty = new ServerMaintenanceInfo();
            //Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.startDate);
            Marshaler.Read(msg, out ty.endDate);
            Marshaler.Read(msg, out ty.message);
        }

        public static void Read(Message msg, out List<ServerMaintenanceInfo> list)
        {
            list = new List<ServerMaintenanceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerMaintenanceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerNoticeMailInfo ty)
        {
            ty = new ServerNoticeMailInfo();
            Marshaler.Read(msg, out ty.noticeMailSEQ);
            Marshaler.Read(msg, out ty.sendDate);
            Marshaler.Read(msg, out ty.expireDate);
            Marshaler.Read(msg, out ty.getItemList);
            Marshaler.Read(msg, out ty.checkAccountCreateTime);
            Marshaler.Read(msg, out ty.languageSet);
            Marshaler.Read(msg, out ty.noticeMailLanguageDataList);
            Marshaler.Read(msg, out ty.specificData);
        }

        public static void Read(Message msg, out List<ServerNoticeMailInfo> list)
        {
            list = new List<ServerNoticeMailInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerNoticeMailInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerSystemMailData ty)
        {
            ty = new ServerSystemMailData();
            Marshaler.Read(msg, out ty.systemMailIndex);
            Marshaler.Read(msg, out ty.szTitle);
            Marshaler.Read(msg, out ty.szContents);
        }

        public static void Read(Message msg, out List<ServerSystemMailData> list)
        {
            list = new List<ServerSystemMailData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerSystemMailData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ServerVersionInfo ty)
        {
            ty = new ServerVersionInfo();
            Marshaler.Read(msg, out ty.buildTime);
            Marshaler.Read(msg, out ty.assemblyInfoDescription);
        }

        public static void Read(Message msg, out List<ServerVersionInfo> list)
        {
            list = new List<ServerVersionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ServerVersionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ShopBuyInfo ty)
        {
            ty = new ShopBuyInfo();
            //Marshaler.Read(msg, out ty.serverNoDailyReset);
            Marshaler.Read(msg, out ty.shopProductID);
            Marshaler.Read(msg, out ty.basepointID);
            Marshaler.Read(msg, out ty.buyCount);
            Marshaler.Read(msg, out ty.freeBuyCount);
            Marshaler.Read(msg, out ty.startRemainSec);
            Marshaler.Read(msg, out ty.endRemainSec);
            Marshaler.Read(msg, out ty.bonusGetCount);
            Marshaler.Read(msg, out ty.periodBuyCount);
        }

        public static void Read(Message msg, out List<ShopBuyInfo> list)
        {
            list = new List<ShopBuyInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ShopBuyInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ShopBuyRequestInfo ty)
        {
            ty = new ShopBuyRequestInfo();
            Marshaler.Read(msg, out ty.shopProductID);
            Marshaler.Read(msg, out ty.buyCount);
        }

        public static void Read(Message msg, out List<ShopBuyRequestInfo> list)
        {
            list = new List<ShopBuyRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ShopBuyRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ShopInfo ty)
        {
            ty = new ShopInfo();
            Marshaler.Read(msg, out ty.unlockCount);
            Marshaler.Read(msg, out ty.productList);
            Marshaler.Read(msg, out ty.expireDate);
        }

        public static void Read(Message msg, out List<ShopInfo> list)
        {
            list = new List<ShopInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ShopInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ShopProduct ty)
        {
            ty = new ShopProduct();
            Marshaler.Read(msg, out ty.slotIndex);
            Marshaler.Read(msg, out ty.productID);
            Marshaler.Read(msg, out ty.isSoldOut);
        }

        public static void Read(Message msg, out List<ShopProduct> list)
        {
            list = new List<ShopProduct>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ShopProduct item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out ShopTimeItemInfo ty)
        {
            ty = new ShopTimeItemInfo();
            Marshaler.Read(msg, out ty.shopProductID);
            Marshaler.Read(msg, out ty.endDate);
            Marshaler.Read(msg, out ty.remainSecEndDate);
            Marshaler.Read(msg, out ty.startDate);
            Marshaler.Read(msg, out ty.remainSecStartDate);
            Marshaler.Read(msg, out ty.productType);
        }

        public static void Read(Message msg, out List<ShopTimeItemInfo> list)
        {
            list = new List<ShopTimeItemInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                ShopTimeItemInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out List<short> list)
        {
            list = new List<short>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                short item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SideStageClearInfo ty)
        {
            ty = new SideStageClearInfo();
            Marshaler.Read(msg, out ty.region);
            Marshaler.Read(msg, out ty.sideStageID1);
            Marshaler.Read(msg, out ty.sideStageID2);
            Marshaler.Read(msg, out ty.sideStageID3);
            Marshaler.Read(msg, out ty.sideStageID4);
            Marshaler.Read(msg, out ty.sideStageID5);
            Marshaler.Read(msg, out ty.freeStage);
            Marshaler.Read(msg, out ty.bossStage);
            Marshaler.Read(msg, out ty.limitedStage);
            Marshaler.Read(msg, out ty.areaFirstClearInfo);
            Marshaler.Read(msg, out ty.hawkRunStage);
            Marshaler.Read(msg, out ty.finalBossStage);
        }

        public static void Read(Message msg, out List<SideStageClearInfo> list)
        {
            list = new List<SideStageClearInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SideStageClearInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SimpleInfoSlotInfo ty)
        {
            ty = new SimpleInfoSlotInfo();
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinExp);
            Marshaler.Read(msg, out ty.skinAwaken);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
            Marshaler.Read(msg, out ty.skinCostumeGroupID);
            Marshaler.Read(msg, out ty.weaponCostumeGroupID);
            Marshaler.Read(msg, out ty.headCostumeGroupID);
            Marshaler.Read(msg, out ty.skinResearchList);
            Marshaler.Read(msg, out ty.maxLevelCount);
            Marshaler.Read(msg, out ty.skinTranscend);
            Marshaler.Read(msg, out ty.skinExceed);
            Marshaler.Read(msg, out ty.skinCostumeExpireDate);
            Marshaler.Read(msg, out ty.weaponCostumeExpireDate);
            Marshaler.Read(msg, out ty.headCostumeExpireDate);
        }

        public static void Read(Message msg, out List<SimpleInfoSlotInfo> list)
        {
            list = new List<SimpleInfoSlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SimpleInfoSlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkillTarget en)
        {
            byte num;
            msg.Read(out num);
            en = (SkillTarget)num;
        }

        public static void Read(Message msg, out List<SkillTarget> list)
        {
            list = new List<SkillTarget>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkillTarget item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkinAwakenValue en)
        {
            int num;
            msg.Read(out num);
            en = (SkinAwakenValue)num;
        }

        public static void Read(Message msg, out List<SkinAwakenValue> list)
        {
            list = new List<SkinAwakenValue>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkinAwakenValue item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkinEvolutionBreakResult ty)
        {
            ty = new SkinEvolutionBreakResult();
            Marshaler.Read(msg, out ty.userSkin);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.priceItemResultInfoList);
        }

        public static void Read(Message msg, out List<SkinEvolutionBreakResult> list)
        {
            list = new List<SkinEvolutionBreakResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkinEvolutionBreakResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkinEvolutionResult ty)
        {
            ty = new SkinEvolutionResult();
            Marshaler.Read(msg, out ty.prevSkinID);
            Marshaler.Read(msg, out ty.userSkin);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.priceItemResultInfoList);
        }

        public static void Read(Message msg, out List<SkinEvolutionResult> list)
        {
            list = new List<SkinEvolutionResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkinEvolutionResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkinGiveFellowResult ty)
        {
            ty = new SkinGiveFellowResult();
            Marshaler.Read(msg, out ty.userSkin);
            Marshaler.Read(msg, out ty.fellowshipItemInfoList);
            Marshaler.Read(msg, out ty.userNpcResult);
        }

        public static void Read(Message msg, out List<SkinGiveFellowResult> list)
        {
            list = new List<SkinGiveFellowResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkinGiveFellowResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkinOneStepEvolutionResult ty)
        {
            ty = new SkinOneStepEvolutionResult();
            Marshaler.Read(msg, out ty.prevSkinID);
            Marshaler.Read(msg, out ty.growthPoint);
            Marshaler.Read(msg, out ty.userSkin);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.userPackageMissionInfoList);
        }

        public static void Read(Message msg, out List<SkinOneStepEvolutionResult> list)
        {
            list = new List<SkinOneStepEvolutionResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkinOneStepEvolutionResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkinSkillLevelUpResult ty)
        {
            ty = new SkinSkillLevelUpResult();
            Marshaler.Read(msg, out ty.userSkin);
            Marshaler.Read(msg, out ty.priceItemInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.questProgressInfoList);
        }

        public static void Read(Message msg, out List<SkinSkillLevelUpResult> list)
        {
            list = new List<SkinSkillLevelUpResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkinSkillLevelUpResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SkinStatInfo ty)
        {
            ty = new SkinStatInfo();
            Marshaler.Read(msg, out ty.slotIndex);
            Marshaler.Read(msg, out ty.attack);
            Marshaler.Read(msg, out ty.defence);
            Marshaler.Read(msg, out ty.life);
            Marshaler.Read(msg, out ty.currentLife);
            Marshaler.Read(msg, out ty.teamIndex);
        }

        public static void Read(Message msg, out List<SkinStatInfo> list)
        {
            list = new List<SkinStatInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SkinStatInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageClearRequestInfo ty)
        {
            ty = new StageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.battleSkinInfoList);
            Marshaler.Read(msg, out ty.friendBattleSkinInfo);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.mercenaryUSN);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.missionRequest);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.isAutoPlay);
            Marshaler.Read(msg, out ty.turnCount);
            Marshaler.Read(msg, out ty.clientTimeSec);
            Marshaler.Read(msg, out ty.deltaTime);
            Marshaler.Read(msg, out ty.packetSendTick);
            Marshaler.Read(msg, out ty.tickCount);
            Marshaler.Read(msg, out ty.stopwatch);
            Marshaler.Read(msg, out ty.dateTime);
            Marshaler.Read(msg, out ty.stageIndex);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.phase);
            Marshaler.Read(msg, out ty.clearDateTime);
            Marshaler.Read(msg, out ty.stageString);
            Marshaler.Read(msg, out ty.battleAbuseLog);
            Marshaler.Read(msg, out ty.battleSimulationLog);
            Marshaler.Read(msg, out ty.battleEncounter);
        }

        public static void Read(Message msg, out List<StageClearRequestInfo> list)
        {
            list = new List<StageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageClearResultInfo ty)
        {
            ty = new StageClearResultInfo();
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.battleSkinResultInfoList);
            Marshaler.Read(msg, out ty.npcResultList);
            Marshaler.Read(msg, out ty.goldItemResultInfo);
            Marshaler.Read(msg, out ty.ingameItemResultInfoList);
            Marshaler.Read(msg, out ty.questItemResultInfoList);
            Marshaler.Read(msg, out ty.firstItemResultInfo);
            Marshaler.Read(msg, out ty.clearItemResultInfo);
            Marshaler.Read(msg, out ty.globalDropItemResultInfoList);
            Marshaler.Read(msg, out ty.gaugeRewardItemResultInfo);
            Marshaler.Read(msg, out ty.passiveDropItemInfo);
            Marshaler.Read(msg, out ty.additionalItemResultInfo);
            Marshaler.Read(msg, out ty.fixedItemResultInfoList);
            Marshaler.Read(msg, out ty.firstClearItemResultInfoList);
            Marshaler.Read(msg, out ty.inGameMissionRewardItemResultInfoList);
            Marshaler.Read(msg, out ty.demonPointItemResultInfo);
            Marshaler.Read(msg, out ty.isFirstClear);
            Marshaler.Read(msg, out ty.playStageID);
            Marshaler.Read(msg, out ty.stageInfo);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.playCountEventInfoList);
            Marshaler.Read(msg, out ty.ingameGoldBuffAddValue);
            Marshaler.Read(msg, out ty.usedFoodID);
            Marshaler.Read(msg, out ty.updateUserGlobalDropEventInfoList);
            Marshaler.Read(msg, out ty.adViewRouletteInfo);
            Marshaler.Read(msg, out ty.heroPassiveGroupInfoList);
            Marshaler.Read(msg, out ty.usedEventLobbyBuffIdList);
            Marshaler.Read(msg, out ty.isAbuseDetect);
        }

        public static void Read(Message msg, out List<StageClearResultInfo> list)
        {
            list = new List<StageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageClearTicketRequest ty)
        {
            ty = new StageClearTicketRequest();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.clearCount);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.battleSkinInfoList);
            Marshaler.Read(msg, out ty.eventSEQ);
            //Marshaler.Read(msg, out ty.freeTicketEventSEQ);
        }

        public static void Read(Message msg, out List<StageClearTicketRequest> list)
        {
            list = new List<StageClearTicketRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageClearTicketRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageClearTicketResult ty)
        {
            ty = new StageClearTicketResult();
            Marshaler.Read(msg, out ty.serverClearCount);
            Marshaler.Read(msg, out ty.ticketClearCountInfo);
            Marshaler.Read(msg, out ty.ticketItemResultInfo);
            Marshaler.Read(msg, out ty.useItemResultInfo);
            Marshaler.Read(msg, out ty.playStageID);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.staminaInfo);
            Marshaler.Read(msg, out ty.stageInfo);
            Marshaler.Read(msg, out ty.goldItemResultInfo);
            Marshaler.Read(msg, out ty.ingameItemResultInfoList);
            Marshaler.Read(msg, out ty.questItemResultInfoList);
            Marshaler.Read(msg, out ty.clearItemResultInfoList);
            Marshaler.Read(msg, out ty.globalDropItemResultInfoList);
            Marshaler.Read(msg, out ty.gaugeRewardItemResultInfoList);
            Marshaler.Read(msg, out ty.additionalItemResultInfoList);
            Marshaler.Read(msg, out ty.weekEventFixedItemResultInfoList);
            Marshaler.Read(msg, out ty.passiveItemResultInfoList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.playCountEventInfoList);
            Marshaler.Read(msg, out ty.ingameGoldBuffAddValue);
            Marshaler.Read(msg, out ty.updateUserGlobalDropEventInfoList);
            Marshaler.Read(msg, out ty.battleSkinResultInfoList);
            Marshaler.Read(msg, out ty.npcResultList);
            Marshaler.Read(msg, out ty.heroPassiveGroupInfoList);
            Marshaler.Read(msg, out ty.freeClearTicketUseCount);
            Marshaler.Read(msg, out ty.usedEventLobbyBuffIdList);
        }

        public static void Read(Message msg, out List<StageClearTicketResult> list)
        {
            list = new List<StageClearTicketResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageClearTicketResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageControlType en)
        {
            byte num;
            msg.Read(out num);
            en = (StageControlType)num;
        }

        public static void Read(Message msg, out List<StageControlType> list)
        {
            list = new List<StageControlType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageControlType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageInfo ty)
        {
            ty = new StageInfo();
            Marshaler.Read(msg, out ty.mainStageTopClearID);
            Marshaler.Read(msg, out ty.anotherMainStageTopClearID);
            Marshaler.Read(msg, out ty.anotherFreeStageFlag);
            Marshaler.Read(msg, out ty.northMainStageTopClearID);
            Marshaler.Read(msg, out ty.northFreeStageFlag);
            Marshaler.Read(msg, out ty.disasterMainStageTopClearID);
            Marshaler.Read(msg, out ty.disasterFreeStageFlag);
            Marshaler.Read(msg, out ty.sideStageClearInfoList);
            Marshaler.Read(msg, out ty.weeklyStageFirstClearInfoList);
            Marshaler.Read(msg, out ty.questStageFirstClearInfo);
            Marshaler.Read(msg, out ty.descentStageFirstClearInfo);
            Marshaler.Read(msg, out ty.stagePlayCountInfoList);
            Marshaler.Read(msg, out ty.dayofWeek);
            Marshaler.Read(msg, out ty.extraStageInfoList);
            Marshaler.Read(msg, out ty.eventGauge);
            Marshaler.Read(msg, out ty.goldGauge);
            Marshaler.Read(msg, out ty.upgradeGauge1);
            Marshaler.Read(msg, out ty.upgradeGauge2);
            Marshaler.Read(msg, out ty.upgradeGauge3);
            Marshaler.Read(msg, out ty.evolutionGauge1);
            Marshaler.Read(msg, out ty.evolutionGauge2);
            Marshaler.Read(msg, out ty.evolutionGauge3);
            Marshaler.Read(msg, out ty.timelimitGauge);
            Marshaler.Read(msg, out ty.timelimitGauge2);
            Marshaler.Read(msg, out ty.timelimitGauge3);
            Marshaler.Read(msg, out ty.timelimitStageRemainSec);
            Marshaler.Read(msg, out ty.timelimitStageRemainSec2);
            Marshaler.Read(msg, out ty.timelimitStageRemainSec3);
            Marshaler.Read(msg, out ty.trainingStageInfo);
            Marshaler.Read(msg, out ty.eventWeeklyStageID);
            Marshaler.Read(msg, out ty.eventDisasterDestroyClearInfoList);
            Marshaler.Read(msg, out ty.coinDungeonGauge);
            Marshaler.Read(msg, out ty.coinDungeonStageRemainSec);
            Marshaler.Read(msg, out ty.coinDungeonWeekResetRemainSec);
            Marshaler.Read(msg, out ty.coinDungeonWeekOpenCount);
            Marshaler.Read(msg, out ty.coinDungeonGauge2);
            Marshaler.Read(msg, out ty.coinDungeonStageRemainSec2);
            Marshaler.Read(msg, out ty.coinDungeonWeekOpenCount2);
            Marshaler.Read(msg, out ty.coinDungeonGauge3);
            Marshaler.Read(msg, out ty.coinDungeonStageRemainSec3);
            Marshaler.Read(msg, out ty.coinDungeonWeekOpenCount3);
            Marshaler.Read(msg, out ty.yggdrasilTowerStageFirstClearInfoList);
            Marshaler.Read(msg, out ty.creatureNestStageInfoList);
            Marshaler.Read(msg, out ty.weeklyResetRemainSec);
            Marshaler.Read(msg, out ty.weeklyBuffUseHour);
            Marshaler.Read(msg, out ty.finalBossFirstClearInfoList);
            Marshaler.Read(msg, out ty.creatureColosseumSeasonInfo);
            Marshaler.Read(msg, out ty.creatureColosseumStageInfoList);
        }

        public static void Read(Message msg, out List<StageInfo> list)
        {
            list = new List<StageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageMonsterGrade en)
        {
            byte num;
            msg.Read(out num);
            en = (StageMonsterGrade)num;
        }

        public static void Read(Message msg, out List<StageMonsterGrade> list)
        {
            list = new List<StageMonsterGrade>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageMonsterGrade item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageMonsterInfo ty)
        {
            ty = new StageMonsterInfo();
            //Marshaler.Read(msg, out ty.privateDropBoxGrade);
            Marshaler.Read(msg, out ty.monsterID);
            Marshaler.Read(msg, out ty.bossColumnNumber);
            Marshaler.Read(msg, out ty.dropBoxGrade);
            Marshaler.Read(msg, out ty.stageMonsterGrade);
        }

        public static void Read(Message msg, out List<StageMonsterInfo> list)
        {
            list = new List<StageMonsterInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageMonsterInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StagePlayCountInfo ty)
        {
            ty = new StagePlayCountInfo();
            //Marshaler.Read(msg, out ty.isDailyReset);
            Marshaler.Read(msg, out ty.stageLimitIndex);
            Marshaler.Read(msg, out ty.stagePlayCount);
        }

        public static void Read(Message msg, out List<StagePlayCountInfo> list)
        {
            list = new List<StagePlayCountInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StagePlayCountInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageStartRequestInfo ty)
        {
            ty = new StageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.mercenaryUSN);
            Marshaler.Read(msg, out ty.mercenarySkinID);
            Marshaler.Read(msg, out ty.mercenaryState);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.stageNpcIDList);
            Marshaler.Read(msg, out ty.stageIndex);
        }

        public static void Read(Message msg, out List<StageStartRequestInfo> list)
        {
            list = new List<StageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageStartResultInfo ty)
        {
            ty = new StageStartResultInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.ingameGold);
            Marshaler.Read(msg, out ty.isGoldManta);
            Marshaler.Read(msg, out ty.stageMonsterList);
            Marshaler.Read(msg, out ty.apInfo);
            Marshaler.Read(msg, out ty.missionResult);
            Marshaler.Read(msg, out ty.isBuffUsed);
            Marshaler.Read(msg, out ty.foodBuffInfo);
            Marshaler.Read(msg, out ty.useItemResultInfo);
            Marshaler.Read(msg, out ty.isRejoinEnable);
            Marshaler.Read(msg, out ty.rejoinData);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.questProgressInfoList);
            Marshaler.Read(msg, out ty.stageIndex);
            Marshaler.Read(msg, out ty.guildSkillUseList);
            Marshaler.Read(msg, out ty.usedEventLobbyBuffIdList);
            Marshaler.Read(msg, out ty.battleEncounter);
        }

        public static void Read(Message msg, out List<StageStartResultInfo> list)
        {
            list = new List<StageStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageTicketClearInfo ty)
        {
            ty = new StageTicketClearInfo();
            Marshaler.Read(msg, out ty.controlType);
            Marshaler.Read(msg, out ty.clearCount);
        }

        public static void Read(Message msg, out List<StageTicketClearInfo> list)
        {
            list = new List<StageTicketClearInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageTicketClearInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageType en)
        {
            byte num;
            msg.Read(out num);
            en = (StageType)num;
        }

        public static void Read(Message msg, out List<StageType> list)
        {
            list = new List<StageType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageVerifyRequest ty)
        {
            ty = new StageVerifyRequest();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.data);
        }

        public static void Read(Message msg, out List<StageVerifyRequest> list)
        {
            list = new List<StageVerifyRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageVerifyRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StageVerifyResult ty)
        {
            ty = new StageVerifyResult();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.ingameGold);
            Marshaler.Read(msg, out ty.isGoldManta);
        }

        public static void Read(Message msg, out List<StageVerifyResult> list)
        {
            list = new List<StageVerifyResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StageVerifyResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StatUserSkin ty)
        {
            ty = new StatUserSkin();
            Marshaler.Read(msg, out ty.skinId);
            Marshaler.Read(msg, out ty.level);
            Marshaler.Read(msg, out ty.exp);
            Marshaler.Read(msg, out ty.battlePoint);
            Marshaler.Read(msg, out ty.weaponIdList);
            Marshaler.Read(msg, out ty.costumeId);
            Marshaler.Read(msg, out ty.weaponCostumeId);
            Marshaler.Read(msg, out ty.headCostumeId);
            Marshaler.Read(msg, out ty.skinStatusInfo);
            Marshaler.Read(msg, out ty.exclusivePassiveLevel);
            Marshaler.Read(msg, out ty.awakenCnt);
            Marshaler.Read(msg, out ty.transcendValue);
            Marshaler.Read(msg, out ty.exceedCnt);
            Marshaler.Read(msg, out ty.specialSkillLevel);
            Marshaler.Read(msg, out ty.fateSkinId);
            Marshaler.Read(msg, out ty.fateSkinLevel);
            Marshaler.Read(msg, out ty.fateSkinExp);
            Marshaler.Read(msg, out ty.fateExclusivePassiveLevel);
            Marshaler.Read(msg, out ty.fateAwakenCnt);
            Marshaler.Read(msg, out ty.fateTranscendValue);
            Marshaler.Read(msg, out ty.fateExceedCnt);
            Marshaler.Read(msg, out ty.fateSpecialSkillLevel);
            Marshaler.Read(msg, out ty.fateAddAtk);
            Marshaler.Read(msg, out ty.fateAddDef);
            Marshaler.Read(msg, out ty.fateAddHp);
            Marshaler.Read(msg, out ty.artifactAtk);
            Marshaler.Read(msg, out ty.artifactDef);
            Marshaler.Read(msg, out ty.artifactHp);
            Marshaler.Read(msg, out ty.constellationStatusInfo);
        }

        public static void Read(Message msg, out List<StatUserSkin> list)
        {
            list = new List<StatUserSkin>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StatUserSkin item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StatusInfo ty)
        {
            ty = new StatusInfo();
            Marshaler.Read(msg, out ty.atk);
            Marshaler.Read(msg, out ty.def);
            Marshaler.Read(msg, out ty.maxHp);
            Marshaler.Read(msg, out ty.fixedAtkPer);
            Marshaler.Read(msg, out ty.fixedDefPer);
            Marshaler.Read(msg, out ty.critAtkPer);
            Marshaler.Read(msg, out ty.critDefPer);
            Marshaler.Read(msg, out ty.critPer);
            Marshaler.Read(msg, out ty.critResPer);
            Marshaler.Read(msg, out ty.hpRecoveryPer);
            Marshaler.Read(msg, out ty.hpStealPer);
            Marshaler.Read(msg, out ty.hpRegenPer);
            Marshaler.Read(msg, out ty.attrEnhancePer);
            Marshaler.Read(msg, out ty.dmgRes);
        }

        public static void Read(Message msg, out List<StatusInfo> list)
        {
            list = new List<StatusInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StatusInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out StepupPriceType en)
        {
            byte num;
            msg.Read(out num);
            en = (StepupPriceType)num;
        }

        public static void Read(Message msg, out List<StepupPriceType> list)
        {
            list = new List<StepupPriceType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                StepupPriceType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out List<string> list)
        {
            list = new List<string>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                string item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SubdubClearRequestInfo ty)
        {
            ty = new SubdubClearRequestInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.turnCount);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.battleSkinInfoList);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.missionRequest);
        }

        public static void Read(Message msg, out List<SubdubClearRequestInfo> list)
        {
            list = new List<SubdubClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SubdubClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SubdueBossBattleSyncInfo ty)
        {
            ty = new SubdueBossBattleSyncInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.leave);
            Marshaler.Read(msg, out ty.defeat);
            Marshaler.Read(msg, out ty.currDamage);
            Marshaler.Read(msg, out ty.userTotalDamage);
        }

        public static void Read(Message msg, out List<SubdueBossBattleSyncInfo> list)
        {
            list = new List<SubdueBossBattleSyncInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SubdueBossBattleSyncInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SubdueBossBattleSyncResult ty)
        {
            ty = new SubdueBossBattleSyncResult();
            Marshaler.Read(msg, out ty.gameSN);
            Marshaler.Read(msg, out ty.totalDamage);
            Marshaler.Read(msg, out ty.bossDestroy);
            Marshaler.Read(msg, out ty.remainBattleEndSec);
            Marshaler.Read(msg, out ty.battleSyncList);
            Marshaler.Read(msg, out ty.battleRanking);
        }

        public static void Read(Message msg, out List<SubdueBossBattleSyncResult> list)
        {
            list = new List<SubdueBossBattleSyncResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SubdueBossBattleSyncResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SubdueBossPlayInfo ty)
        {
            ty = new SubdueBossPlayInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.playCount);
            Marshaler.Read(msg, out ty.initRemainSec);
            //Marshaler.Read(msg, out ty.playSeq);
        }

        public static void Read(Message msg, out List<SubdueBossPlayInfo> list)
        {
            list = new List<SubdueBossPlayInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SubdueBossPlayInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SubdueBossRewardRank ty)
        {
            ty = new SubdueBossRewardRank();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.damageCount);
            Marshaler.Read(msg, out ty.leave);
            Marshaler.Read(msg, out ty.defeat);
            //Marshaler.Read(msg, out ty.lastAttackTimeCount);
            //Marshaler.Read(msg, out ty.randomSeed);
        }

        public static void Read(Message msg, out List<SubdueBossRewardRank> list)
        {
            list = new List<SubdueBossRewardRank>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SubdueBossRewardRank item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SubdueBossRewardResult ty)
        {
            ty = new SubdueBossRewardResult();
            Marshaler.Read(msg, out ty.isVictory);
            Marshaler.Read(msg, out ty.rankList);
            Marshaler.Read(msg, out ty.defeatMemberUSNs);
            Marshaler.Read(msg, out ty.goldItemResultInfo);
            Marshaler.Read(msg, out ty.rewardHostResultInfoList);
            Marshaler.Read(msg, out ty.rewardRankResultInfoList);
            Marshaler.Read(msg, out ty.rewardLostResultInfoList);
            Marshaler.Read(msg, out ty.rewardDamageRangeResultInfoList);
            Marshaler.Read(msg, out ty.adViewRouletteInfo);
            Marshaler.Read(msg, out ty.updateUserGlobalDropEventInfoList);
            Marshaler.Read(msg, out ty.rewardGlobalDropResultInfoList);
            Marshaler.Read(msg, out ty.rewardSoloResultInfoList);
            Marshaler.Read(msg, out ty.usedEventLobbyBuffIdList);
            Marshaler.Read(msg, out ty.questProgressInfoList);
        }

        public static void Read(Message msg, out List<SubdueBossRewardResult> list)
        {
            list = new List<SubdueBossRewardResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SubdueBossRewardResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SuccessInfo ty)
        {
            ty = new SuccessInfo();
            Marshaler.Read(msg, out ty.values);
            Marshaler.Read(msg, out ty.successType);
        }

        public static void Read(Message msg, out List<SuccessInfo> list)
        {
            list = new List<SuccessInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SuccessInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SuccessType en)
        {
            byte num;
            msg.Read(out num);
            en = (SuccessType)num;
        }

        public static void Read(Message msg, out List<SuccessType> list)
        {
            list = new List<SuccessType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SuccessType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SyncCreatureNestHero ty)
        {
            ty = new SyncCreatureNestHero();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
        }

        public static void Read(Message msg, out List<SyncCreatureNestHero> list)
        {
            list = new List<SyncCreatureNestHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SyncCreatureNestHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out SyncMazeHero ty)
        {
            ty = new SyncMazeHero();
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.decreaseHP);
            Marshaler.Read(msg, out ty.isDead);
        }

        public static void Read(Message msg, out List<SyncMazeHero> list)
        {
            list = new List<SyncMazeHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                SyncMazeHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TalkExtraDataType en)
        {
            int num;
            msg.Read(out num);
            en = (TalkExtraDataType)num;
        }

        public static void Read(Message msg, out List<TalkExtraDataType> list)
        {
            list = new List<TalkExtraDataType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TalkExtraDataType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TalkKitType en)
        {
            byte num;
            msg.Read(out num);
            en = (TalkKitType)num;
        }

        public static void Read(Message msg, out List<TalkKitType> list)
        {
            list = new List<TalkKitType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TalkKitType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TeamIndexType en)
        {
            byte num;
            msg.Read(out num);
            en = (TeamIndexType)num;
        }

        public static void Read(Message msg, out List<TeamIndexType> list)
        {
            list = new List<TeamIndexType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TeamIndexType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentBattleEndRequest ty)
        {
            ty = new TournamentBattleEndRequest();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.resultState);
            Marshaler.Read(msg, out ty.missionRequest);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.isAutoPlay);
            Marshaler.Read(msg, out ty.turnCount);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.teamInfo);
        }

        public static void Read(Message msg, out List<TournamentBattleEndRequest> list)
        {
            list = new List<TournamentBattleEndRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentBattleEndRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentBattleEndResult ty)
        {
            ty = new TournamentBattleEndResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.isWin);
            Marshaler.Read(msg, out ty.isMatchPlay);
            Marshaler.Read(msg, out ty.tournamentSEQ);
            Marshaler.Read(msg, out ty.matchInfo);
            Marshaler.Read(msg, out ty.tournamentRank);
            Marshaler.Read(msg, out ty.missionResult);
        }

        public static void Read(Message msg, out List<TournamentBattleEndResult> list)
        {
            list = new List<TournamentBattleEndResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentBattleEndResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentBattleStartRequest ty)
        {
            ty = new TournamentBattleStartRequest();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.teamInfo);
            Marshaler.Read(msg, out ty.skinStatInfoList);
            Marshaler.Read(msg, out ty.otherUSN);
            Marshaler.Read(msg, out ty.otherTeamIndex);
        }

        public static void Read(Message msg, out List<TournamentBattleStartRequest> list)
        {
            list = new List<TournamentBattleStartRequest>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentBattleStartRequest item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentBattleStartResult ty)
        {
            ty = new TournamentBattleStartResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
            Marshaler.Read(msg, out ty.otherPlayerTeamInfo);
        }

        public static void Read(Message msg, out List<TournamentBattleStartResult> list)
        {
            list = new List<TournamentBattleStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentBattleStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentControlInfo ty)
        {
            ty = new TournamentControlInfo();
            Marshaler.Read(msg, out ty.SEQ);
            Marshaler.Read(msg, out ty.prepareFromTime);
            Marshaler.Read(msg, out ty.openFromTime);
            Marshaler.Read(msg, out ty.postToTime);
            Marshaler.Read(msg, out ty.replayToTime);
            Marshaler.Read(msg, out ty.title);
            Marshaler.Read(msg, out ty.bannerURL);
            Marshaler.Read(msg, out ty.contents);
            Marshaler.Read(msg, out ty.playerUSNList);
            Marshaler.Read(msg, out ty.rewardGroupID);
            Marshaler.Read(msg, out ty.isWeaponUse);
            Marshaler.Read(msg, out ty.damageRate);
            Marshaler.Read(msg, out ty.damageIncRate);
        }

        public static void Read(Message msg, out List<TournamentControlInfo> list)
        {
            list = new List<TournamentControlInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentControlInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentDisplayInfo ty)
        {
            ty = new TournamentDisplayInfo();
            Marshaler.Read(msg, out ty.SEQ);
            Marshaler.Read(msg, out ty.title);
            Marshaler.Read(msg, out ty.bannerURL);
            Marshaler.Read(msg, out ty.contents);
            Marshaler.Read(msg, out ty.rewardGroupID);
            Marshaler.Read(msg, out ty.isWeaponUse);
            Marshaler.Read(msg, out ty.damageRate);
            Marshaler.Read(msg, out ty.damageIncRate);
            Marshaler.Read(msg, out ty.startTime);
            Marshaler.Read(msg, out ty.endTime);
            Marshaler.Read(msg, out ty.startRemainSec);
            Marshaler.Read(msg, out ty.endRemainSec);
            Marshaler.Read(msg, out ty.isPlayer);
            Marshaler.Read(msg, out ty.tournamentState);
            Marshaler.Read(msg, out ty.stateRemainSec);
        }

        public static void Read(Message msg, out List<TournamentDisplayInfo> list)
        {
            list = new List<TournamentDisplayInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentDisplayInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchInfo ty)
        {
            ty = new TournamentMatchInfo();
            Marshaler.Read(msg, out ty.roundIndex);
            Marshaler.Read(msg, out ty.matchIndex);
            Marshaler.Read(msg, out ty.matchState);
            Marshaler.Read(msg, out ty.matchStateRemainSec);
            Marshaler.Read(msg, out ty.playerUSN1);
            Marshaler.Read(msg, out ty.playerUSN2);
            Marshaler.Read(msg, out ty.winnerUSN);
            Marshaler.Read(msg, out ty.resultState);
            Marshaler.Read(msg, out ty.playerWin1);
            Marshaler.Read(msg, out ty.playerWin2);
        }

        public static void Read(Message msg, out List<TournamentMatchInfo> list)
        {
            list = new List<TournamentMatchInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchJoinResult ty)
        {
            ty = new TournamentMatchJoinResult();
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
        }

        public static void Read(Message msg, out List<TournamentMatchJoinResult> list)
        {
            list = new List<TournamentMatchJoinResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchJoinResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchPlayFinishInfo ty)
        {
            ty = new TournamentMatchPlayFinishInfo();
            Marshaler.Read(msg, out ty.SEQ);
            Marshaler.Read(msg, out ty.matchIndex);
            Marshaler.Read(msg, out ty.matchState);
            Marshaler.Read(msg, out ty.matchRoomSN);
            Marshaler.Read(msg, out ty.matchWinnerUSN);
            Marshaler.Read(msg, out ty.matchResultState);
            Marshaler.Read(msg, out ty.playIndex);
            Marshaler.Read(msg, out ty.playWinnerUSN);
            Marshaler.Read(msg, out ty.playResultState);
            Marshaler.Read(msg, out ty.replaySEQ);
            Marshaler.Read(msg, out ty.relaySessionKey);
        }

        public static void Read(Message msg, out List<TournamentMatchPlayFinishInfo> list)
        {
            list = new List<TournamentMatchPlayFinishInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchPlayFinishInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchPlayInfo ty)
        {
            ty = new TournamentMatchPlayInfo();
            Marshaler.Read(msg, out ty.playIndex);
            Marshaler.Read(msg, out ty.winnerUSN);
            Marshaler.Read(msg, out ty.resultState);
            Marshaler.Read(msg, out ty.replaySEQ);
        }

        public static void Read(Message msg, out List<TournamentMatchPlayInfo> list)
        {
            list = new List<TournamentMatchPlayInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchPlayInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchResultState en)
        {
            byte num;
            msg.Read(out num);
            en = (TournamentMatchResultState)num;
        }

        public static void Read(Message msg, out List<TournamentMatchResultState> list)
        {
            list = new List<TournamentMatchResultState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchResultState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchStartResult ty)
        {
            ty = new TournamentMatchStartResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.ingameSeed);
            Marshaler.Read(msg, out ty.playerUSN1);
            Marshaler.Read(msg, out ty.playerUSN2);
            Marshaler.Read(msg, out ty.playerTeamIndex1);
            Marshaler.Read(msg, out ty.playerTeamIndex2);
        }

        public static void Read(Message msg, out List<TournamentMatchStartResult> list)
        {
            list = new List<TournamentMatchStartResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchStartResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchState en)
        {
            byte num;
            msg.Read(out num);
            en = (TournamentMatchState)num;
        }

        public static void Read(Message msg, out List<TournamentMatchState> list)
        {
            list = new List<TournamentMatchState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchSuspendResult ty)
        {
            ty = new TournamentMatchSuspendResult();
            Marshaler.Read(msg, out ty.SEQ);
            Marshaler.Read(msg, out ty.matchInfo);
            Marshaler.Read(msg, out ty.playerRank1);
            Marshaler.Read(msg, out ty.playerRank2);
        }

        public static void Read(Message msg, out List<TournamentMatchSuspendResult> list)
        {
            list = new List<TournamentMatchSuspendResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchSuspendResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchUserProfileInfo ty)
        {
            ty = new TournamentMatchUserProfileInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.skinChangeIDList);
            Marshaler.Read(msg, out ty.weaponChangeIDList);
            Marshaler.Read(msg, out ty.headChangeIDList);
            Marshaler.Read(msg, out ty.skinHeadStyleChangedList);
            Marshaler.Read(msg, out ty.bossStageTopClearRegion);
            Marshaler.Read(msg, out ty.topClearStoryQuestID);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<TournamentMatchUserProfileInfo> list)
        {
            list = new List<TournamentMatchUserProfileInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchUserProfileInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentMatchWatcherJoinResult ty)
        {
            ty = new TournamentMatchWatcherJoinResult();
            Marshaler.Read(msg, out ty.relayServerInfo);
            Marshaler.Read(msg, out ty.playKey);
            Marshaler.Read(msg, out ty.playMode);
        }

        public static void Read(Message msg, out List<TournamentMatchWatcherJoinResult> list)
        {
            list = new List<TournamentMatchWatcherJoinResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentMatchWatcherJoinResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentPlayerCheerInfo ty)
        {
            ty = new TournamentPlayerCheerInfo();
            Marshaler.Read(msg, out ty.USN);
            Marshaler.Read(msg, out ty.cheerCount);
        }

        public static void Read(Message msg, out List<TournamentPlayerCheerInfo> list)
        {
            list = new List<TournamentPlayerCheerInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentPlayerCheerInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentPlayerInfo ty)
        {
            ty = new TournamentPlayerInfo();
            Marshaler.Read(msg, out ty.USN);
            Marshaler.Read(msg, out ty.tournamentRank);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<TournamentPlayerInfo> list)
        {
            list = new List<TournamentPlayerInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentPlayerInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentProgressInfo ty)
        {
            ty = new TournamentProgressInfo();
            Marshaler.Read(msg, out ty.SEQ);
            Marshaler.Read(msg, out ty.tournamentState);
            Marshaler.Read(msg, out ty.stateRemainSec);
            Marshaler.Read(msg, out ty.roundIndex);
            Marshaler.Read(msg, out ty.roundState);
            Marshaler.Read(msg, out ty.roundStateRemainSec);
        }

        public static void Read(Message msg, out List<TournamentProgressInfo> list)
        {
            list = new List<TournamentProgressInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentProgressInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentRoundState en)
        {
            byte num;
            msg.Read(out num);
            en = (TournamentRoundState)num;
        }

        public static void Read(Message msg, out List<TournamentRoundState> list)
        {
            list = new List<TournamentRoundState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentRoundState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentState en)
        {
            byte num;
            msg.Read(out num);
            en = (TournamentState)num;
        }

        public static void Read(Message msg, out List<TournamentState> list)
        {
            list = new List<TournamentState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TournamentWatcherLoginResult ty)
        {
            ty = new TournamentWatcherLoginResult();
            Marshaler.Read(msg, out ty.roomSN);
            Marshaler.Read(msg, out ty.currentPlayIndex);
            Marshaler.Read(msg, out ty.matchInfo);
            Marshaler.Read(msg, out ty.replayBytesInfo);
        }

        public static void Read(Message msg, out List<TournamentWatcherLoginResult> list)
        {
            list = new List<TournamentWatcherLoginResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TournamentWatcherLoginResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TowerStageHeroInfo ty)
        {
            ty = new TowerStageHeroInfo();
            Marshaler.Read(msg, out ty.updateFlag);
            Marshaler.Read(msg, out ty.heroIDList);
        }

        public static void Read(Message msg, out List<TowerStageHeroInfo> list)
        {
            list = new List<TowerStageHeroInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TowerStageHeroInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TowerStageInfo ty)
        {
            ty = new TowerStageInfo();
            Marshaler.Read(msg, out ty.clearStageID);
            Marshaler.Read(msg, out ty.recvRewardStageID);
            Marshaler.Read(msg, out ty.seasonId);
            Marshaler.Read(msg, out ty.remainEndTimeSec);
            Marshaler.Read(msg, out ty.topClearStageID);
        }

        public static void Read(Message msg, out List<TowerStageInfo> list)
        {
            list = new List<TowerStageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TowerStageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingInfo ty)
        {
            ty = new TrainingInfo();
            Marshaler.Read(msg, out ty.heroKindType);
            Marshaler.Read(msg, out ty.attackPowerCount);
            Marshaler.Read(msg, out ty.magicPowerCount);
            Marshaler.Read(msg, out ty.attackDefenceCount);
            Marshaler.Read(msg, out ty.magicDefenceCount);
            Marshaler.Read(msg, out ty.lifeCount);
            Marshaler.Read(msg, out ty.attackPowerRating);
            Marshaler.Read(msg, out ty.magicPowerRating);
            Marshaler.Read(msg, out ty.attackDefenceRating);
            Marshaler.Read(msg, out ty.magicDefenceRating);
            Marshaler.Read(msg, out ty.lifeRating);
        }

        public static void Read(Message msg, out List<TrainingInfo> list)
        {
            list = new List<TrainingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingStageClearStarInfo ty)
        {
            ty = new TrainingStageClearStarInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.star);
        }

        public static void Read(Message msg, out List<TrainingStageClearStarInfo> list)
        {
            list = new List<TrainingStageClearStarInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingStageClearStarInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingStageInfo ty)
        {
            ty = new TrainingStageInfo();
            Marshaler.Read(msg, out ty.remainSecToReset);
            Marshaler.Read(msg, out ty.remainSecToClose);
            Marshaler.Read(msg, out ty.stageList);
            Marshaler.Read(msg, out ty.rewardGauge);
            Marshaler.Read(msg, out ty.point);
            Marshaler.Read(msg, out ty.mirrorTeamInfo);
            Marshaler.Read(msg, out ty.trainingTaskID);
            Marshaler.Read(msg, out ty.trainingTaskCount);
            Marshaler.Read(msg, out ty.clearStarInfoList);
        }

        public static void Read(Message msg, out List<TrainingStageInfo> list)
        {
            list = new List<TrainingStageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingStageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingStageInGameMissionClearInfo ty)
        {
            ty = new TrainingStageInGameMissionClearInfo();
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.star);
            Marshaler.Read(msg, out ty.clearMissionIDList);
        }

        public static void Read(Message msg, out List<TrainingStageInGameMissionClearInfo> list)
        {
            list = new List<TrainingStageInGameMissionClearInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingStageInGameMissionClearInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingStageListInfo ty)
        {
            ty = new TrainingStageListInfo();
            Marshaler.Read(msg, out ty.remainCloseSec);
            Marshaler.Read(msg, out ty.trainingStageList);
        }

        public static void Read(Message msg, out List<TrainingStageListInfo> list)
        {
            list = new List<TrainingStageListInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingStageListInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingStageSlotInfo ty)
        {
            ty = new TrainingStageSlotInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.state);
        }

        public static void Read(Message msg, out List<TrainingStageSlotInfo> list)
        {
            list = new List<TrainingStageSlotInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingStageSlotInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingStageState en)
        {
            byte num;
            msg.Read(out num);
            en = (TrainingStageState)num;
        }

        public static void Read(Message msg, out List<TrainingStageState> list)
        {
            list = new List<TrainingStageState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingStageState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TrainingStageType en)
        {
            byte num;
            msg.Read(out num);
            en = (TrainingStageType)num;
        }

        public static void Read(Message msg, out List<TrainingStageType> list)
        {
            list = new List<TrainingStageType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TrainingStageType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TutorialStatus en)
        {
            byte num;
            msg.Read(out num);
            en = (TutorialStatus)num;
        }

        public static void Read(Message msg, out List<TutorialStatus> list)
        {
            list = new List<TutorialStatus>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TutorialStatus item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out TutorialType en)
        {
            byte num;
            msg.Read(out num);
            en = (TutorialType)num;
        }

        public static void Read(Message msg, out List<TutorialType> list)
        {
            list = new List<TutorialType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                TutorialType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UpgradeUserSkin ty)
        {
            ty = new UpgradeUserSkin();
            Marshaler.Read(msg, out ty.prevSkinID);
            Marshaler.Read(msg, out ty.userSkin);
        }

        public static void Read(Message msg, out List<UpgradeUserSkin> list)
        {
            list = new List<UpgradeUserSkin>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UpgradeUserSkin item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserADViewInfo ty)
        {
            ty = new UserADViewInfo();
            Marshaler.Read(msg, out ty.adViewContentType);
            Marshaler.Read(msg, out ty.viewCount);
            Marshaler.Read(msg, out ty.coolRemainSec);
            Marshaler.Read(msg, out ty.roulettePoint);
            //Marshaler.Read(msg, out ty.lastViewUnxs);
        }

        public static void Read(Message msg, out List<UserADViewInfo> list)
        {
            list = new List<UserADViewInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserADViewInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserAncientWarInfo ty)
        {
            ty = new UserAncientWarInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.teamType);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.rewardIndex);
            Marshaler.Read(msg, out ty.remainBattleStartSec);
            Marshaler.Read(msg, out ty.isAutoTeamType);
            Marshaler.Read(msg, out ty.donationCount);
            //Marshaler.Read(msg, out ty.sendRewardMailYN);
            //Marshaler.Read(msg, out ty.rankUnixTime);
        }

        public static void Read(Message msg, out List<UserAncientWarInfo> list)
        {
            list = new List<UserAncientWarInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserAncientWarInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserArtifact ty)
        {
            ty = new UserArtifact();
            Marshaler.Read(msg, out ty.artifactCardID);
        }

        public static void Read(Message msg, out List<UserArtifact> list)
        {
            list = new List<UserArtifact>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserArtifact item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserArtifactTeamInfo ty)
        {
            ty = new UserArtifactTeamInfo();
            Marshaler.Read(msg, out ty.teamIndex);
            Marshaler.Read(msg, out ty.unionId);
            Marshaler.Read(msg, out ty.artifactCardIdList);
        }

        public static void Read(Message msg, out List<UserArtifactTeamInfo> list)
        {
            list = new List<UserArtifactTeamInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserArtifactTeamInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserArtifactUnionInfo ty)
        {
            ty = new UserArtifactUnionInfo();
            Marshaler.Read(msg, out ty.unionId);
            Marshaler.Read(msg, out ty.exp);
        }

        public static void Read(Message msg, out List<UserArtifactUnionInfo> list)
        {
            list = new List<UserArtifactUnionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserArtifactUnionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserArtifactWishEventInfo ty)
        {
            ty = new UserArtifactWishEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.artifactCardIdList);
        }

        public static void Read(Message msg, out List<UserArtifactWishEventInfo> list)
        {
            list = new List<UserArtifactWishEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserArtifactWishEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserBasePointContentsInfo ty)
        {
            ty = new UserBasePointContentsInfo();
            Marshaler.Read(msg, out ty.basePointInfoList);
            Marshaler.Read(msg, out ty.eventBasepointInfoList);
        }

        public static void Read(Message msg, out List<UserBasePointContentsInfo> list)
        {
            list = new List<UserBasePointContentsInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserBasePointContentsInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserBingoGachaEventInfo ty)
        {
            ty = new UserBingoGachaEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.reward);
            Marshaler.Read(msg, out ty.progress);
            Marshaler.Read(msg, out ty.slotList);
        }

        public static void Read(Message msg, out List<UserBingoGachaEventInfo> list)
        {
            list = new List<UserBingoGachaEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserBingoGachaEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserBlitzStageEventInfo ty)
        {
            ty = new UserBlitzStageEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.regionID);
            Marshaler.Read(msg, out ty.mainStageID);
            Marshaler.Read(msg, out ty.sideStageIDList);
            Marshaler.Read(msg, out ty.freeStageValue);
            Marshaler.Read(msg, out ty.lastClearStageID);
            Marshaler.Read(msg, out ty.limitedStageValue);
            Marshaler.Read(msg, out ty.bossStageValue);
        }

        public static void Read(Message msg, out List<UserBlitzStageEventInfo> list)
        {
            list = new List<UserBlitzStageEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserBlitzStageEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserBuffInfo ty)
        {
            ty = new UserBuffInfo();
            Marshaler.Read(msg, out ty.buffType);
            Marshaler.Read(msg, out ty.targetID);
            Marshaler.Read(msg, out ty.passiveID);
            Marshaler.Read(msg, out ty.remainSecToRemove);
        }

        public static void Read(Message msg, out List<UserBuffInfo> list)
        {
            list = new List<UserBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserBuffType en)
        {
            byte num;
            msg.Read(out num);
            en = (UserBuffType)num;
        }

        public static void Read(Message msg, out List<UserBuffType> list)
        {
            list = new List<UserBuffType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserBuffType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserChallengeDestroyEventInfo ty)
        {
            ty = new UserChallengeDestroyEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.point);
            Marshaler.Read(msg, out ty.maxWorldPoint);
            Marshaler.Read(msg, out ty.rewardIndex);
            Marshaler.Read(msg, out ty.isWorldReward);
        }

        public static void Read(Message msg, out List<UserChallengeDestroyEventInfo> list)
        {
            list = new List<UserChallengeDestroyEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserChallengeDestroyEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserChapterClearEventInfo ty)
        {
            ty = new UserChapterClearEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.rewardedMissionChapterID);
        }

        public static void Read(Message msg, out List<UserChapterClearEventInfo> list)
        {
            list = new List<UserChapterClearEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserChapterClearEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserCheerEventInfo ty)
        {
            ty = new UserCheerEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.totalCheerCount);
            Marshaler.Read(msg, out ty.gaugeRewardedID);
            Marshaler.Read(msg, out ty.isFinishRewarded);
            Marshaler.Read(msg, out ty.cheerGroupList);
        }

        public static void Read(Message msg, out List<UserCheerEventInfo> list)
        {
            list = new List<UserCheerEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserCheerEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserComebackType en)
        {
            byte num;
            msg.Read(out num);
            en = (UserComebackType)num;
        }

        public static void Read(Message msg, out List<UserComebackType> list)
        {
            list = new List<UserComebackType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserComebackType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserCommonItem ty)
        {
            ty = new UserCommonItem();
            Marshaler.Read(msg, out ty.ItemID);
            Marshaler.Read(msg, out ty.ItemCount);
        }

        public static void Read(Message msg, out List<UserCommonItem> list)
        {
            list = new List<UserCommonItem>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserCommonItem item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserCostumeCraftUpgradeInfo ty)
        {
            ty = new UserCostumeCraftUpgradeInfo();
            Marshaler.Read(msg, out ty.costumeGroup);
            Marshaler.Read(msg, out ty.heroGroup);
            Marshaler.Read(msg, out ty.upgradeAtk);
            Marshaler.Read(msg, out ty.upgradeDef);
            Marshaler.Read(msg, out ty.upgradeMaxHp);
        }

        public static void Read(Message msg, out List<UserCostumeCraftUpgradeInfo> list)
        {
            list = new List<UserCostumeCraftUpgradeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserCostumeCraftUpgradeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserCostumeHead ty)
        {
            ty = new UserCostumeHead();
            Marshaler.Read(msg, out ty.costumeID);
            Marshaler.Read(msg, out ty.exp);
            Marshaler.Read(msg, out ty.upgrade);
            Marshaler.Read(msg, out ty.heroGroupID);
            Marshaler.Read(msg, out ty.costumeGroupID);
            Marshaler.Read(msg, out ty.expireDate);
        }

        public static void Read(Message msg, out List<UserCostumeHead> list)
        {
            list = new List<UserCostumeHead>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserCostumeHead item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserCostumeSkin ty)
        {
            ty = new UserCostumeSkin();
            Marshaler.Read(msg, out ty.costumeID);
            Marshaler.Read(msg, out ty.exp);
            Marshaler.Read(msg, out ty.upgrade);
            Marshaler.Read(msg, out ty.heroGroupID);
            Marshaler.Read(msg, out ty.costumeGroupID);
            Marshaler.Read(msg, out ty.expireDate);
        }

        public static void Read(Message msg, out List<UserCostumeSkin> list)
        {
            list = new List<UserCostumeSkin>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserCostumeSkin item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserCostumeWeapon ty)
        {
            ty = new UserCostumeWeapon();
            Marshaler.Read(msg, out ty.costumeID);
            Marshaler.Read(msg, out ty.exp);
            Marshaler.Read(msg, out ty.upgrade);
            Marshaler.Read(msg, out ty.heroGroupID);
            Marshaler.Read(msg, out ty.costumeGroupID);
            Marshaler.Read(msg, out ty.expireDate);
        }

        public static void Read(Message msg, out List<UserCostumeWeapon> list)
        {
            list = new List<UserCostumeWeapon>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserCostumeWeapon item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserCreatureNestStageInfo ty)
        {
            ty = new UserCreatureNestStageInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.isTeamSetting);
            Marshaler.Read(msg, out ty.startStageID);
            Marshaler.Read(msg, out ty.clearStageID);
            Marshaler.Read(msg, out ty.rewardReceiveStage);
            Marshaler.Read(msg, out ty.challengeRewardStatus);
            Marshaler.Read(msg, out ty.passiveIDList);
        }

        public static void Read(Message msg, out List<UserCreatureNestStageInfo> list)
        {
            list = new List<UserCreatureNestStageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserCreatureNestStageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserDailyReset ty)
        {
            ty = new UserDailyReset();
            Marshaler.Read(msg, out ty.barrelCount);
            Marshaler.Read(msg, out ty.friendDeleteCount);
            Marshaler.Read(msg, out ty.floorSearchValue1);
            Marshaler.Read(msg, out ty.floorSearchValue2);
            Marshaler.Read(msg, out ty.floorSearchValue3);
            Marshaler.Read(msg, out ty.floorSearchValue4);
            Marshaler.Read(msg, out ty.lobbyQuestProgressInfoList);
            Marshaler.Read(msg, out ty.attendanceInfo);
            Marshaler.Read(msg, out ty.birthdayGuestIDList);
            Marshaler.Read(msg, out ty.basepointDailyReward);
            Marshaler.Read(msg, out ty.cleanTableCount);
            Marshaler.Read(msg, out ty.serveBeerCount);
            Marshaler.Read(msg, out ty.playJukeboxCount);
            Marshaler.Read(msg, out ty.elizabethTouchCount);
            Marshaler.Read(msg, out ty.hawkAngerCount);
            Marshaler.Read(msg, out ty.meliodasCookingCount);
            Marshaler.Read(msg, out ty.barrelFellowCount);
            Marshaler.Read(msg, out ty.friendPointGainCount);
            Marshaler.Read(msg, out ty.heroGachaOneDiaCount);
            Marshaler.Read(msg, out ty.helbramCount);
            Marshaler.Read(msg, out ty.friendCookingEatCount);
            Marshaler.Read(msg, out ty.guildDonationCount1);
            Marshaler.Read(msg, out ty.guildDonationCount2);
            Marshaler.Read(msg, out ty.guildShopResetCount);
            Marshaler.Read(msg, out ty.eventExchangeBoxGachaResetCount);
            Marshaler.Read(msg, out ty.eventGagueChargeFreeCount);
            Marshaler.Read(msg, out ty.eventGagueChargetPoint);
            Marshaler.Read(msg, out ty.guildDonationContribution);
            Marshaler.Read(msg, out ty.stageInfo);
            Marshaler.Read(msg, out ty.userPackageInfoList);
            Marshaler.Read(msg, out ty.userDiaShopPackageInfoList);
            Marshaler.Read(msg, out ty.guildMissionInfoList);
            Marshaler.Read(msg, out ty.eventPacketInfo);
            Marshaler.Read(msg, out ty.inviteSpecialGuestCount);
            Marshaler.Read(msg, out ty.trainingStageRefreshCount);
            Marshaler.Read(msg, out ty.lobbyGuestInfo);
            Marshaler.Read(msg, out ty.userAdViewInfoList);
            Marshaler.Read(msg, out ty.subdueBossPlayInfoList);
            Marshaler.Read(msg, out ty.patrolInfo);
            Marshaler.Read(msg, out ty.eventLadderPlayCount);
            Marshaler.Read(msg, out ty.arenaSmashTeamUpdateCount);
            Marshaler.Read(msg, out ty.arenaSmashWinRewardedCount);
            Marshaler.Read(msg, out ty.eventTreasureHuntDiceCount);
            Marshaler.Read(msg, out ty.guildExpBoostStack);
            Marshaler.Read(msg, out ty.destroyLiveJoinCount);
            Marshaler.Read(msg, out ty.lobbyCollectPassiveUseCount);
            Marshaler.Read(msg, out ty.freeClearTicketUseCount);
            Marshaler.Read(msg, out ty.gambleFreeCount);
            Marshaler.Read(msg, out ty.dailyFreeGambleInfoClientSend);
            Marshaler.Read(msg, out ty.itemResultInfoList);
            Marshaler.Read(msg, out ty.constellationChaosInfo);
            Marshaler.Read(msg, out ty.guildOrderMissionInfoClientSend);
            Marshaler.Read(msg, out ty.userGuildOrderMissionInfoClientSend);
        }

        public static void Read(Message msg, out List<UserDailyReset> list)
        {
            list = new List<UserDailyReset>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserDailyReset item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserDemonLordInfo ty)
        {
            ty = new UserDemonLordInfo();
            //Marshaler.Read(msg, out ty.isDemonLordStageOpen);
            //Marshaler.Read(msg, out ty.isDemonLordFreeOpen);
            //Marshaler.Read(msg, out ty.demonLordStageAlreadyClearIndex);
            Marshaler.Read(msg, out ty.demonLordOpenTime);
        }

        public static void Read(Message msg, out List<UserDemonLordInfo> list)
        {
            list = new List<UserDemonLordInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserDemonLordInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserDemonLordInfoToClientSend ty)
        {
            ty = new UserDemonLordInfoToClientSend();
            Marshaler.Read(msg, out ty.isDemonLordStageOpen);
            Marshaler.Read(msg, out ty.isDemonLordFreeOpen);
            Marshaler.Read(msg, out ty.demonLordStageAlreadyClearIndex);
            Marshaler.Read(msg, out ty.demonLordOpenTime);
            Marshaler.Read(msg, out ty.remainWeekResetSec);
        }

        public static void Read(Message msg, out List<UserDemonLordInfoToClientSend> list)
        {
            list = new List<UserDemonLordInfoToClientSend>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserDemonLordInfoToClientSend item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserDiaBuyEventInfo ty)
        {
            ty = new UserDiaBuyEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.diaBuyInfoList);
            Marshaler.Read(msg, out ty.totalBuyCount);
            //Marshaler.Read(msg, out ty.monthSEQ);
        }

        public static void Read(Message msg, out List<UserDiaBuyEventInfo> list)
        {
            list = new List<UserDiaBuyEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserDiaBuyEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserDonationEventInfo ty)
        {
            ty = new UserDonationEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.basepointID);
            Marshaler.Read(msg, out ty.donationValue);
            Marshaler.Read(msg, out ty.rewardFlag);
        }

        public static void Read(Message msg, out List<UserDonationEventInfo> list)
        {
            list = new List<UserDonationEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserDonationEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventBalloonDartInfo ty)
        {
            ty = new UserEventBalloonDartInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.step);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.totalScore);
            Marshaler.Read(msg, out ty.dartType);
            Marshaler.Read(msg, out ty.balloonList);
            Marshaler.Read(msg, out ty.chanceType);
            Marshaler.Read(msg, out ty.chanceBalloonList);
            Marshaler.Read(msg, out ty.stepRewardedList);
            Marshaler.Read(msg, out ty.totalRewardedList);
        }

        public static void Read(Message msg, out List<UserEventBalloonDartInfo> list)
        {
            list = new List<UserEventBalloonDartInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventBalloonDartInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventBingoInfo ty)
        {
            ty = new UserEventBingoInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.reward);
            Marshaler.Read(msg, out ty.progress);
            Marshaler.Read(msg, out ty.numberSlotList);
            Marshaler.Read(msg, out ty.rewardSlotList);
            Marshaler.Read(msg, out ty.resetCount);
        }

        public static void Read(Message msg, out List<UserEventBingoInfo> list)
        {
            list = new List<UserEventBingoInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventBingoInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventBoxWishInfo ty)
        {
            ty = new UserEventBoxWishInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.wishId);
        }

        public static void Read(Message msg, out List<UserEventBoxWishInfo> list)
        {
            list = new List<UserEventBoxWishInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventBoxWishInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventConquesClientSendInfo ty)
        {
            ty = new UserEventConquesClientSendInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.conquestProductionDepotInfoList);
            Marshaler.Read(msg, out ty.conquestAreaInfoList);
            Marshaler.Read(msg, out ty.lastedAttackAreaID);
            Marshaler.Read(msg, out ty.sceneIndex);
            Marshaler.Read(msg, out ty.units);
            Marshaler.Read(msg, out ty.stageClaerAreaList);
        }

        public static void Read(Message msg, out List<UserEventConquesClientSendInfo> list)
        {
            list = new List<UserEventConquesClientSendInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventConquesClientSendInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventDiceInfo ty)
        {
            ty = new UserEventDiceInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.rollCount);
            Marshaler.Read(msg, out ty.position);
            Marshaler.Read(msg, out ty.activeQuestionID);
            Marshaler.Read(msg, out ty.raceCount);
            Marshaler.Read(msg, out ty.raceRewardFlag);
            Marshaler.Read(msg, out ty.isBonusDice);
            Marshaler.Read(msg, out ty.currentRollList);
            Marshaler.Read(msg, out ty.isNeedEvent);
        }

        public static void Read(Message msg, out List<UserEventDiceInfo> list)
        {
            list = new List<UserEventDiceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventDiceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventGachaWishInfo ty)
        {
            ty = new UserEventGachaWishInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.remainCount);
            Marshaler.Read(msg, out ty.skinId);
        }

        public static void Read(Message msg, out List<UserEventGachaWishInfo> list)
        {
            list = new List<UserEventGachaWishInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventGachaWishInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventGambleBoxInfoToClientSend ty)
        {
            ty = new UserEventGambleBoxInfoToClientSend();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.step);
            Marshaler.Read(msg, out ty.pickList);
        }

        public static void Read(Message msg, out List<UserEventGambleBoxInfoToClientSend> list)
        {
            list = new List<UserEventGambleBoxInfoToClientSend>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventGambleBoxInfoToClientSend item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventInfo ty)
        {
            ty = new UserEventInfo();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.step);
            Marshaler.Read(msg, out ty.progress);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.status);
        }

        public static void Read(Message msg, out List<UserEventInfo> list)
        {
            list = new List<UserEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventLobbyBuffInfo ty)
        {
            ty = new UserEventLobbyBuffInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.pointInfo);
            Marshaler.Read(msg, out ty.buffList);
        }

        public static void Read(Message msg, out List<UserEventLobbyBuffInfo> list)
        {
            list = new List<UserEventLobbyBuffInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventLobbyBuffInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventLobbyDecorationInfo ty)
        {
            ty = new UserEventLobbyDecorationInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.rewardFlag);
        }

        public static void Read(Message msg, out List<UserEventLobbyDecorationInfo> list)
        {
            list = new List<UserEventLobbyDecorationInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventLobbyDecorationInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventLuckyBoxInfo ty)
        {
            ty = new UserEventLuckyBoxInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.userRewardedList);
            Marshaler.Read(msg, out ty.rewardedAllList);
        }

        public static void Read(Message msg, out List<UserEventLuckyBoxInfo> list)
        {
            list = new List<UserEventLuckyBoxInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventLuckyBoxInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventMoleGameInfo ty)
        {
            ty = new UserEventMoleGameInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.totalScore);
            Marshaler.Read(msg, out ty.totalScoreRewardFlag);
            Marshaler.Read(msg, out ty.highScore);
            Marshaler.Read(msg, out ty.playCount);
        }

        public static void Read(Message msg, out List<UserEventMoleGameInfo> list)
        {
            list = new List<UserEventMoleGameInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventMoleGameInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventPuzzleBlockInfo ty)
        {
            ty = new UserEventPuzzleBlockInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.blockID);
            Marshaler.Read(msg, out ty.blockScore);
            Marshaler.Read(msg, out ty.blockMatchCount);
            Marshaler.Read(msg, out ty.blockRewardFlag);
        }

        public static void Read(Message msg, out List<UserEventPuzzleBlockInfo> list)
        {
            list = new List<UserEventPuzzleBlockInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventPuzzleBlockInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventPuzzleBlockSet ty)
        {
            ty = new UserEventPuzzleBlockSet();
            Marshaler.Read(msg, out ty.blockID);
            Marshaler.Read(msg, out ty.scoreRate);
        }

        public static void Read(Message msg, out List<UserEventPuzzleBlockSet> list)
        {
            list = new List<UserEventPuzzleBlockSet>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventPuzzleBlockSet item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventPuzzleInfo ty)
        {
            ty = new UserEventPuzzleInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.setBlockIDList);
            Marshaler.Read(msg, out ty.totalScore);
            Marshaler.Read(msg, out ty.totalScoreRewardFlag);
            Marshaler.Read(msg, out ty.highScore);
        }

        public static void Read(Message msg, out List<UserEventPuzzleInfo> list)
        {
            list = new List<UserEventPuzzleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventPuzzleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventRecipeInfo ty)
        {
            ty = new UserEventRecipeInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.recipeID);
            Marshaler.Read(msg, out ty.recipeActive);
        }

        public static void Read(Message msg, out List<UserEventRecipeInfo> list)
        {
            list = new List<UserEventRecipeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventRecipeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserEventRoadInfo ty)
        {
            ty = new UserEventRoadInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventType);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.floor);
            Marshaler.Read(msg, out ty.scoreList);
            Marshaler.Read(msg, out ty.scoreRewardList);
            Marshaler.Read(msg, out ty.passIndex);
            Marshaler.Read(msg, out ty.passCount);
            Marshaler.Read(msg, out ty.collection);
        }

        public static void Read(Message msg, out List<UserEventRoadInfo> list)
        {
            list = new List<UserEventRoadInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserEventRoadInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserExchangeEventInfo ty)
        {
            ty = new UserExchangeEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.exchangeID);
            Marshaler.Read(msg, out ty.dailyExchangeCount);
            Marshaler.Read(msg, out ty.totalExchangeCount);
            Marshaler.Read(msg, out ty.eventType);
        }

        public static void Read(Message msg, out List<UserExchangeEventInfo> list)
        {
            list = new List<UserExchangeEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserExchangeEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserExtensionData ty)
        {
            ty = new UserExtensionData();
            Marshaler.Read(msg, out ty.itemInventoryMax);
            Marshaler.Read(msg, out ty.weaponInventoryMax);
        }

        public static void Read(Message msg, out List<UserExtensionData> list)
        {
            list = new List<UserExtensionData>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserExtensionData item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserExtraStageInfo ty)
        {
            ty = new UserExtraStageInfo();
            Marshaler.Read(msg, out ty.extraGroupID);
            Marshaler.Read(msg, out ty.clearID);
        }

        public static void Read(Message msg, out List<UserExtraStageInfo> list)
        {
            list = new List<UserExtraStageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserExtraStageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserFinalBossDifficultyRankInfo ty)
        {
            ty = new UserFinalBossDifficultyRankInfo();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.difficulty);
            Marshaler.Read(msg, out ty.firstRewardYN);
            //Marshaler.Read(msg, out ty.usn);
            //Marshaler.Read(msg, out ty.topRankPoint);
            //Marshaler.Read(msg, out ty.topRankUnxs);
            //Marshaler.Read(msg, out ty.skinIDList);
            //Marshaler.Read(msg, out ty.isTopRankRefresh);
            //Marshaler.Read(msg, out ty.rank);
            //Marshaler.Read(msg, out ty.totalRankUpCount);
        }

        public static void Read(Message msg, out List<UserFinalBossDifficultyRankInfo> list)
        {
            list = new List<UserFinalBossDifficultyRankInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserFinalBossDifficultyRankInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserFinalBossRankPoint ty)
        {
            ty = new UserFinalBossRankPoint();
            Marshaler.Read(msg, out ty.seasonID);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.topRankPoint);
            Marshaler.Read(msg, out ty.skinIDList);
            Marshaler.Read(msg, out ty.rank);
            Marshaler.Read(msg, out ty.totolRankUpCount);
            Marshaler.Read(msg, out ty.score);
            Marshaler.Read(msg, out ty.lastScoreRewardOrder);
            //Marshaler.Read(msg, out ty.usn);
            //Marshaler.Read(msg, out ty.rewardYN);
            //Marshaler.Read(msg, out ty.topRankUnxs);
            //Marshaler.Read(msg, out ty.isTopRankRefresh);
            //Marshaler.Read(msg, out ty.isFinalBossDifficultyHeroRankRefresh);
            //Marshaler.Read(msg, out ty.difficulty);
            //Marshaler.Read(msg, out ty.difficultyRankSkinIDList);
            //Marshaler.Read(msg, out ty.difficultyTopRankPoint);
            //Marshaler.Read(msg, out ty.difficultyTopRankUnxs);
        }

        public static void Read(Message msg, out List<UserFinalBossRankPoint> list)
        {
            list = new List<UserFinalBossRankPoint>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserFinalBossRankPoint item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserFinalBossStageEventInfo ty)
        {
            ty = new UserFinalBossStageEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.bossStageValue);
            Marshaler.Read(msg, out ty.mainBossStageTopClearID);
            Marshaler.Read(msg, out ty.lastClearStageID);
        }

        public static void Read(Message msg, out List<UserFinalBossStageEventInfo> list)
        {
            list = new List<UserFinalBossStageEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserFinalBossStageEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserFreeStageEventInfo ty)
        {
            ty = new UserFreeStageEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.freeStageValue);
            Marshaler.Read(msg, out ty.lastClearStageID);
        }

        public static void Read(Message msg, out List<UserFreeStageEventInfo> list)
        {
            list = new List<UserFreeStageEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserFreeStageEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserFrozenAsset ty)
        {
            ty = new UserFrozenAsset();
            Marshaler.Read(msg, out ty.seq);
            Marshaler.Read(msg, out ty.contentTypeID);
            Marshaler.Read(msg, out ty.needItemInfoList);
        }

        public static void Read(Message msg, out List<UserFrozenAsset> list)
        {
            list = new List<UserFrozenAsset>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserFrozenAsset item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserFurniture ty)
        {
            ty = new UserFurniture();
            Marshaler.Read(msg, out ty.furnitureGroup);
            Marshaler.Read(msg, out ty.furnitureID);
            Marshaler.Read(msg, out ty.buffFurnitureID);
        }

        public static void Read(Message msg, out List<UserFurniture> list)
        {
            list = new List<UserFurniture>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserFurniture item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserFurnitureEventInfo ty)
        {
            ty = new UserFurnitureEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.isRegist);
            //Marshaler.Read(msg, out ty.int>);
        }

        public static void Read(Message msg, out List<UserFurnitureEventInfo> list)
        {
            list = new List<UserFurnitureEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserFurnitureEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserGachaEventInfo ty)
        {
            ty = new UserGachaEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.buyCount);
        }

        public static void Read(Message msg, out List<UserGachaEventInfo> list)
        {
            list = new List<UserGachaEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserGachaEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserGachaEventOnceInfo ty)
        {
            ty = new UserGachaEventOnceInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.id);
            Marshaler.Read(msg, out ty.freeCount);
        }

        public static void Read(Message msg, out List<UserGachaEventOnceInfo> list)
        {
            list = new List<UserGachaEventOnceInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserGachaEventOnceInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserGagueEventInfo ty)
        {
            ty = new UserGagueEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.gagueGroupID);
            Marshaler.Read(msg, out ty.progress);
            Marshaler.Read(msg, out ty.rewardIndex);
        }

        public static void Read(Message msg, out List<UserGagueEventInfo> list)
        {
            list = new List<UserGagueEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserGagueEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserGlobalDropEventInfo ty)
        {
            ty = new UserGlobalDropEventInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.globalDropSlotItemCountList);
        }

        public static void Read(Message msg, out List<UserGlobalDropEventInfo> list)
        {
            list = new List<UserGlobalDropEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserGlobalDropEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserGuildOrderMissionInfo ty)
        {
            ty = new UserGuildOrderMissionInfo();
            Marshaler.Read(msg, out ty.missionID);
            Marshaler.Read(msg, out ty.progress);
            Marshaler.Read(msg, out ty.rewardYN);
            Marshaler.Read(msg, out ty.entryMemberInfoList);
        }

        public static void Read(Message msg, out List<UserGuildOrderMissionInfo> list)
        {
            list = new List<UserGuildOrderMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserGuildOrderMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserHero ty)
        {
            ty = new UserHero();
            Marshaler.Read(msg, out ty.heroID);
        }

        public static void Read(Message msg, out List<UserHero> list)
        {
            list = new List<UserHero>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserHero item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserHeroGachaGaugeInfo ty)
        {
            ty = new UserHeroGachaGaugeInfo();
            Marshaler.Read(msg, out ty.gambleGroup);
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.gauge);
            Marshaler.Read(msg, out ty.rewardStep);
            Marshaler.Read(msg, out ty.rewardCount);
        }

        public static void Read(Message msg, out List<UserHeroGachaGaugeInfo> list)
        {
            list = new List<UserHeroGachaGaugeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserHeroGachaGaugeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserHeroLeagueInfo ty)
        {
            ty = new UserHeroLeagueInfo();
            Marshaler.Read(msg, out ty.league);
            Marshaler.Read(msg, out ty.useTeamCount);
            Marshaler.Read(msg, out ty.winCount);
            Marshaler.Read(msg, out ty.currentUserGroup);
            Marshaler.Read(msg, out ty.rewardInfo);
            Marshaler.Read(msg, out ty.scoreRewardInfo);
            //Marshaler.Read(msg, out ty.season);
            //Marshaler.Read(msg, out ty.week);
        }

        public static void Read(Message msg, out List<UserHeroLeagueInfo> list)
        {
            list = new List<UserHeroLeagueInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserHeroLeagueInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserHeroPassiveGroupInfo ty)
        {
            ty = new UserHeroPassiveGroupInfo();
            Marshaler.Read(msg, out ty.heroPassiveGroup);
            Marshaler.Read(msg, out ty.dailyUseCount);
        }

        public static void Read(Message msg, out List<UserHeroPassiveGroupInfo> list)
        {
            list = new List<UserHeroPassiveGroupInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserHeroPassiveGroupInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserKOFBritanniaEventInfo ty)
        {
            ty = new UserKOFBritanniaEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.isStarted);
            Marshaler.Read(msg, out ty.challengeStageGauge);
            Marshaler.Read(msg, out ty.challengeStageID);
            Marshaler.Read(msg, out ty.teamID);
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.mercenaryHeroIDList);
            Marshaler.Read(msg, out ty.completedTeamIDList);
        }

        public static void Read(Message msg, out List<UserKOFBritanniaEventInfo> list)
        {
            list = new List<UserKOFBritanniaEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserKOFBritanniaEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserLevelUpResult ty)
        {
            ty = new UserLevelUpResult();
            Marshaler.Read(msg, out ty.apInfoList);
        }

        public static void Read(Message msg, out List<UserLevelUpResult> list)
        {
            list = new List<UserLevelUpResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserLevelUpResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserListStageEventInfo ty)
        {
            ty = new UserListStageEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.freeStageValue);
            Marshaler.Read(msg, out ty.mainStageTopClearID);
            Marshaler.Read(msg, out ty.lastClearStageID);
        }

        public static void Read(Message msg, out List<UserListStageEventInfo> list)
        {
            list = new List<UserListStageEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserListStageEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserLoginState en)
        {
            byte num;
            msg.Read(out num);
            en = (UserLoginState)num;
        }

        public static void Read(Message msg, out List<UserLoginState> list)
        {
            list = new List<UserLoginState>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserLoginState item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserMarketingInfo ty)
        {
            ty = new UserMarketingInfo();
            Marshaler.Read(msg, out ty.firstBuy);
            Marshaler.Read(msg, out ty.firstEvolution);
            Marshaler.Read(msg, out ty.firstPVP);
            Marshaler.Read(msg, out ty.firstBoss);
            Marshaler.Read(msg, out ty.firstWeeklyStage);
            Marshaler.Read(msg, out ty.firstMainStageClear);
            Marshaler.Read(msg, out ty.gambleCount);
            Marshaler.Read(msg, out ty.urGet);
            Marshaler.Read(msg, out ty.vipUser);
            Marshaler.Read(msg, out ty.firstDiaBuy);
        }

        public static void Read(Message msg, out List<UserMarketingInfo> list)
        {
            list = new List<UserMarketingInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserMarketingInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserMazeEventInfo ty)
        {
            ty = new UserMazeEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.stageID);
            Marshaler.Read(msg, out ty.rewardedIndex);
            Marshaler.Read(msg, out ty.randomBattleStageID);
            Marshaler.Read(msg, out ty.randomStageID1);
            Marshaler.Read(msg, out ty.randomStageID2);
            Marshaler.Read(msg, out ty.randomValue1);
            Marshaler.Read(msg, out ty.randomValue2);
            Marshaler.Read(msg, out ty.startedStageID);
            Marshaler.Read(msg, out ty.heroRefreshCount);
            Marshaler.Read(msg, out ty.passiveRefreshCount);
            Marshaler.Read(msg, out ty.topSpotID);
            Marshaler.Read(msg, out ty.clearBonusProgressType);
            Marshaler.Read(msg, out ty.seasonShopBuyPoint);
            Marshaler.Read(msg, out ty.selectablePassiveIDList);
            Marshaler.Read(msg, out ty.selectableHeroIDList);
            Marshaler.Read(msg, out ty.passiveIDList);
            Marshaler.Read(msg, out ty.lastPassiveIDList);
            Marshaler.Read(msg, out ty.savedPassiveIDList);
            Marshaler.Read(msg, out ty.mazeHeroInfoList);
            Marshaler.Read(msg, out ty.savedHeroInfoList);
            Marshaler.Read(msg, out ty.shopPassiveIDList);
            Marshaler.Read(msg, out ty.shopIDList);
            Marshaler.Read(msg, out ty.shopBuyProductIDList);
            Marshaler.Read(msg, out ty.shopBuffIDList);
            Marshaler.Read(msg, out ty.shopBuyBuffIDList);
            Marshaler.Read(msg, out ty.buffInfoList);
            //Marshaler.Read(msg, out ty.lastHeroInfoList);
            //Marshaler.Read(msg, out ty.seasonShopBuyInfoList);
            //Marshaler.Read(msg, out ty.isSeasonShopInitialized);
        }

        public static void Read(Message msg, out List<UserMazeEventInfo> list)
        {
            list = new List<UserMazeEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserMazeEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserMissionEventInfo ty)
        {
            ty = new UserMissionEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.chainID);
            Marshaler.Read(msg, out ty.rewardIndex);
            Marshaler.Read(msg, out ty.progressValue);
        }

        public static void Read(Message msg, out List<UserMissionEventInfo> list)
        {
            list = new List<UserMissionEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserMissionEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserMonthlyStageInfo ty)
        {
            ty = new UserMonthlyStageInfo();
            Marshaler.Read(msg, out ty.monthlyID);
            Marshaler.Read(msg, out ty.lastCountRewardIndex);
            Marshaler.Read(msg, out ty.lastClearStageIDList);
            Marshaler.Read(msg, out ty.monthlyRemainSec);
        }

        public static void Read(Message msg, out List<UserMonthlyStageInfo> list)
        {
            list = new List<UserMonthlyStageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserMonthlyStageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserMusic ty)
        {
            ty = new UserMusic();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.name);
            Marshaler.Read(msg, out ty.tempo);
            Marshaler.Read(msg, out ty.beat);
            Marshaler.Read(msg, out ty.code);
        }

        public static void Read(Message msg, out List<UserMusic> list)
        {
            list = new List<UserMusic>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserMusic item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserNpc ty)
        {
            ty = new UserNpc();
            //Marshaler.Read(msg, out ty.serverTalkAnswered);
            Marshaler.Read(msg, out ty.guestID);
            Marshaler.Read(msg, out ty.giftIndex);
            Marshaler.Read(msg, out ty.costumeID);
            Marshaler.Read(msg, out ty.subCostumeID);
            Marshaler.Read(msg, out ty.talkCount);
            Marshaler.Read(msg, out ty.questionID);
            Marshaler.Read(msg, out ty.goodTalkCount);
            Marshaler.Read(msg, out ty.lovePoint);
            Marshaler.Read(msg, out ty.giftState);
        }

        public static void Read(Message msg, out List<UserNpc> list)
        {
            list = new List<UserNpc>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserNpc item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserNpcResult ty)
        {
            ty = new UserNpcResult();
            Marshaler.Read(msg, out ty.guestID);
            Marshaler.Read(msg, out ty.lovePoint);
        }

        public static void Read(Message msg, out List<UserNpcResult> list)
        {
            list = new List<UserNpcResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserNpcResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPackageInfo ty)
        {
            ty = new UserPackageInfo();
            Marshaler.Read(msg, out ty.packageID);
            Marshaler.Read(msg, out ty.buyCount);
            Marshaler.Read(msg, out ty.buyTime);
            Marshaler.Read(msg, out ty.expireTIme);
            Marshaler.Read(msg, out ty.remainResetTimeSEC);
            Marshaler.Read(msg, out ty.rewardValue);
            Marshaler.Read(msg, out ty.dayCount);
            Marshaler.Read(msg, out ty.rewardAble);
            Marshaler.Read(msg, out ty.isExpire);
        }

        public static void Read(Message msg, out List<UserPackageInfo> list)
        {
            list = new List<UserPackageInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPackageInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPackageMissionInfo ty)
        {
            ty = new UserPackageMissionInfo();
            //Marshaler.Read(msg, out ty.packageBuyExpireDate);
            //Marshaler.Read(msg, out ty.packageId);
            Marshaler.Read(msg, out ty.packageMissionID);
            Marshaler.Read(msg, out ty.packageMissionStatus);
            Marshaler.Read(msg, out ty.packageBuyExpireRemainSEC);
            Marshaler.Read(msg, out ty.progress);
        }

        public static void Read(Message msg, out List<UserPackageMissionInfo> list)
        {
            list = new List<UserPackageMissionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPackageMissionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPaybackEventInfo ty)
        {
            ty = new UserPaybackEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.paybackGroupID);
            Marshaler.Read(msg, out ty.progress);
            Marshaler.Read(msg, out ty.rewardID);
            Marshaler.Read(msg, out ty.resetCount);
        }

        public static void Read(Message msg, out List<UserPaybackEventInfo> list)
        {
            list = new List<UserPaybackEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPaybackEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPlayCountEventInfo ty)
        {
            ty = new UserPlayCountEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.playCount);
            Marshaler.Read(msg, out ty.getReward);
        }

        public static void Read(Message msg, out List<UserPlayCountEventInfo> list)
        {
            list = new List<UserPlayCountEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPlayCountEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPredictInfo ty)
        {
            ty = new UserPredictInfo();
            Marshaler.Read(msg, out ty.Index);
            Marshaler.Read(msg, out ty.upgradeCount);
        }

        public static void Read(Message msg, out List<UserPredictInfo> list)
        {
            list = new List<UserPredictInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPredictInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserProfileInfo ty)
        {
            ty = new UserProfileInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.nickname);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<UserProfileInfo> list)
        {
            list = new List<UserProfileInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserProfileInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserProvisionEventInfo ty)
        {
            ty = new UserProvisionEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.isFinalRewardReceived);
            Marshaler.Read(msg, out ty.sectionInfoList);
        }

        public static void Read(Message msg, out List<UserProvisionEventInfo> list)
        {
            list = new List<UserProvisionEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserProvisionEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserProvisionEventSectionInfo ty)
        {
            ty = new UserProvisionEventSectionInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.sectionID);
            Marshaler.Read(msg, out ty.provideCountList);
            Marshaler.Read(msg, out ty.isSectionRewardReceived);
        }

        public static void Read(Message msg, out List<UserProvisionEventSectionInfo> list)
        {
            list = new List<UserProvisionEventSectionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserProvisionEventSectionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPvpShopGradeInfo ty)
        {
            ty = new UserPvpShopGradeInfo();
            Marshaler.Read(msg, out ty.arenaRealTimePvpLowerGrade);
            Marshaler.Read(msg, out ty.arenaRealTimePvpLowerGradeNumber);
            Marshaler.Read(msg, out ty.arenaRealTimePvpGrade);
            Marshaler.Read(msg, out ty.arenaRealTimePvpGradeNumber);
        }

        public static void Read(Message msg, out List<UserPvpShopGradeInfo> list)
        {
            list = new List<UserPvpShopGradeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPvpShopGradeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPVPWinCountEventInfo ty)
        {
            ty = new UserPVPWinCountEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.weekInfoList);
        }

        public static void Read(Message msg, out List<UserPVPWinCountEventInfo> list)
        {
            list = new List<UserPVPWinCountEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPVPWinCountEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserPVPWinCountEventWeekInfo ty)
        {
            ty = new UserPVPWinCountEventWeekInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.week);
            Marshaler.Read(msg, out ty.winCount);
            Marshaler.Read(msg, out ty.rewardIndex);
        }

        public static void Read(Message msg, out List<UserPVPWinCountEventWeekInfo> list)
        {
            list = new List<UserPVPWinCountEventWeekInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserPVPWinCountEventWeekInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserRandomBoxEventInfo ty)
        {
            ty = new UserRandomBoxEventInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.freeCount);
            Marshaler.Read(msg, out ty.mileage);
            Marshaler.Read(msg, out ty.boxInfoList);
        }

        public static void Read(Message msg, out List<UserRandomBoxEventInfo> list)
        {
            list = new List<UserRandomBoxEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserRandomBoxEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserRandomLuckybagInfo ty)
        {
            ty = new UserRandomLuckybagInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.openValue);
            Marshaler.Read(msg, out ty.lastReward);
            Marshaler.Read(msg, out ty.rewardValue);
        }

        public static void Read(Message msg, out List<UserRandomLuckybagInfo> list)
        {
            list = new List<UserRandomLuckybagInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserRandomLuckybagInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserRecipeInfo ty)
        {
            ty = new UserRecipeInfo();
            Marshaler.Read(msg, out ty.recipeID);
            Marshaler.Read(msg, out ty.recipeExp);
            Marshaler.Read(msg, out ty.recipeActive);
        }

        public static void Read(Message msg, out List<UserRecipeInfo> list)
        {
            list = new List<UserRecipeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserRecipeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserSimpleInfo ty)
        {
            ty = new UserSimpleInfo();
            //Marshaler.Read(msg, out ty.skinCostumeExpireDate);
            //Marshaler.Read(msg, out ty.weaponCostumeExpireDate);
            //Marshaler.Read(msg, out ty.headCostumeExpireDate);
            //Marshaler.Read(msg, out ty.stageStartTimeTicks);
            Marshaler.Read(msg, out ty.USN);
            Marshaler.Read(msg, out ty.NickName);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.mainSkinExp);
            Marshaler.Read(msg, out ty.mainCostumeGroupID);
            Marshaler.Read(msg, out ty.mainWeaponCostumeGroupID);
            Marshaler.Read(msg, out ty.mainHeadCostumeGroupID);
            Marshaler.Read(msg, out ty.mainIsHeadStyleChanged);
            Marshaler.Read(msg, out ty.simpleInfoSlotInfoList);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.friendReddot);
            Marshaler.Read(msg, out ty.friendApplyReddot);
            Marshaler.Read(msg, out ty.guildReddot);
            Marshaler.Read(msg, out ty.bossTopClearRegion);
            Marshaler.Read(msg, out ty.topClearStoryQuestID);
            Marshaler.Read(msg, out ty.destroyInviteOption);
            Marshaler.Read(msg, out ty.isGuildInvitationOn);
            Marshaler.Read(msg, out ty.guildRoomPoint);
            Marshaler.Read(msg, out ty.guildInfoRefresh);
            Marshaler.Read(msg, out ty.topVisitBasepointID);
            Marshaler.Read(msg, out ty.topClearMainStageID);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.friendlytMatchInviteOption);
            Marshaler.Read(msg, out ty.friendCookingEatTotalCount);
            Marshaler.Read(msg, out ty.guildReddot1);
            Marshaler.Read(msg, out ty.guildReddot2);
            Marshaler.Read(msg, out ty.guildReddot3);
            Marshaler.Read(msg, out ty.recipeOrderCount);
            Marshaler.Read(msg, out ty.topClearEventQuestID);
            Marshaler.Read(msg, out ty.playTitleID);
            Marshaler.Read(msg, out ty.arenaSmashBattlePoint);
            Marshaler.Read(msg, out ty.arenaSmashRecordSN);
        }

        public static void Read(Message msg, out List<UserSimpleInfo> list)
        {
            list = new List<UserSimpleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserSimpleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserSkin ty)
        {
            ty = new UserSkin();
            //Marshaler.Read(msg, out ty.getSkinID);
            //Marshaler.Read(msg, out ty.goldBuffValue);
            //Marshaler.Read(msg, out ty.dropBuffValue);
            //Marshaler.Read(msg, out ty.expBuffValue);
            //Marshaler.Read(msg, out ty.skinMaterialCount);
            //Marshaler.Read(msg, out ty.isFellowshipMax);
            //Marshaler.Read(msg, out ty.heroContentsPassiveID);
            Marshaler.Read(msg, out ty.skinOwnerHeroID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinExp);
            Marshaler.Read(msg, out ty.skinFellowshipExp);
            Marshaler.Read(msg, out ty.lastFellowRewardIndex);
            Marshaler.Read(msg, out ty.awaken);
            Marshaler.Read(msg, out ty.skillLevelUpCount);
            Marshaler.Read(msg, out ty.maxLevelCount);
            Marshaler.Read(msg, out ty.passiveSkillLevel);
            Marshaler.Read(msg, out ty.equipWeaponList);
            Marshaler.Read(msg, out ty.researchList);
            Marshaler.Read(msg, out ty.skinCostumeGroupID);
            Marshaler.Read(msg, out ty.weaponCostumeGroupID);
            Marshaler.Read(msg, out ty.headCostumeGroupID);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
            Marshaler.Read(msg, out ty.firstResearchType);
            Marshaler.Read(msg, out ty.firstResearchSlot);
            Marshaler.Read(msg, out ty.registeredCostumeGroupList);
            Marshaler.Read(msg, out ty.trainingStagePlayCount);
            Marshaler.Read(msg, out ty.usedGuildBossSeq);
            Marshaler.Read(msg, out ty.usedEventChallengeBossSeq);
            Marshaler.Read(msg, out ty.transcend);
            Marshaler.Read(msg, out ty.registeredMadeCostumeGroup);
            Marshaler.Read(msg, out ty.heroLeagueUserGroup);
            Marshaler.Read(msg, out ty.exceed);
            Marshaler.Read(msg, out ty.levelUpBonusRewardIndex);
        }

        public static void Read(Message msg, out List<UserSkin> list)
        {
            list = new List<UserSkin>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserSkin item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserSkinOneStepEvolutionEventInfo ty)
        {
            ty = new UserSkinOneStepEvolutionEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.skinOneStepEvolutionCount);
        }

        public static void Read(Message msg, out List<UserSkinOneStepEvolutionEventInfo> list)
        {
            list = new List<UserSkinOneStepEvolutionEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserSkinOneStepEvolutionEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserSnsShareEventInfo ty)
        {
            ty = new UserSnsShareEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.shareCount);
            Marshaler.Read(msg, out ty.rewardYN);
        }

        public static void Read(Message msg, out List<UserSnsShareEventInfo> list)
        {
            list = new List<UserSnsShareEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserSnsShareEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserStepupGachaEventInfo ty)
        {
            ty = new UserStepupGachaEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.stepNo);
            Marshaler.Read(msg, out ty.stepCount);
            Marshaler.Read(msg, out ty.mileage);
            Marshaler.Read(msg, out ty.mileageReward);
            Marshaler.Read(msg, out ty.stepRotationCount);
            //Marshaler.Read(msg, out ty.stepRotationOccur);
            //Marshaler.Read(msg, out ty.stepRotationIndex);
        }

        public static void Read(Message msg, out List<UserStepupGachaEventInfo> list)
        {
            list = new List<UserStepupGachaEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserStepupGachaEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserStepupMissionEventInfo ty)
        {
            ty = new UserStepupMissionEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.stepupMissionGroupID);
            Marshaler.Read(msg, out ty.isAllStepCompleted);
        }

        public static void Read(Message msg, out List<UserStepupMissionEventInfo> list)
        {
            list = new List<UserStepupMissionEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserStepupMissionEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserSubdueBossPlayInfo ty)
        {
            ty = new UserSubdueBossPlayInfo();
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.playSeq);
            Marshaler.Read(msg, out ty.playCount);
        }

        public static void Read(Message msg, out List<UserSubdueBossPlayInfo> list)
        {
            list = new List<UserSubdueBossPlayInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserSubdueBossPlayInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserTeam ty)
        {
            ty = new UserTeam();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.name);
            Marshaler.Read(msg, out ty.teamSlotList);
            Marshaler.Read(msg, out ty.defenceBuffID);
        }

        public static void Read(Message msg, out List<UserTeam> list)
        {
            list = new List<UserTeam>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserTeam item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserTeamChangeInfo ty)
        {
            ty = new UserTeamChangeInfo();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.teamSlotList);
            Marshaler.Read(msg, out ty.battlePowerPoint);
            Marshaler.Read(msg, out ty.defenceBuffID);
        }

        public static void Read(Message msg, out List<UserTeamChangeInfo> list)
        {
            list = new List<UserTeamChangeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserTeamChangeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserTeamSlot ty)
        {
            ty = new UserTeamSlot();
            Marshaler.Read(msg, out ty.index);
            Marshaler.Read(msg, out ty.heroID);
            Marshaler.Read(msg, out ty.heroGroupID);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.fateHeroID);
            Marshaler.Read(msg, out ty.fateHeroGroupID);
            Marshaler.Read(msg, out ty.fateSkinID);
        }

        public static void Read(Message msg, out List<UserTeamSlot> list)
        {
            list = new List<UserTeamSlot>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserTeamSlot item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserTimeMissionEventInfo ty)
        {
            ty = new UserTimeMissionEventInfo();
            Marshaler.Read(msg, out ty.eventSeq);
            Marshaler.Read(msg, out ty.timeMissionStartUnixSec);
        }

        public static void Read(Message msg, out List<UserTimeMissionEventInfo> list)
        {
            list = new List<UserTimeMissionEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserTimeMissionEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserTreasureHuntEventInfo ty)
        {
            ty = new UserTreasureHuntEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.isStarted);
            Marshaler.Read(msg, out ty.pointID);
            Marshaler.Read(msg, out ty.groupID);
            Marshaler.Read(msg, out ty.groupRestartCount);
            Marshaler.Read(msg, out ty.completeCount);
            Marshaler.Read(msg, out ty.completeRewardIndex);
            Marshaler.Read(msg, out ty.pointCompleteBits);
            Marshaler.Read(msg, out ty.pointMissionSuccessBits);
            Marshaler.Read(msg, out ty.pointRewardBits);
        }

        public static void Read(Message msg, out List<UserTreasureHuntEventInfo> list)
        {
            list = new List<UserTreasureHuntEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserTreasureHuntEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserTutorialInfo ty)
        {
            ty = new UserTutorialInfo();
            Marshaler.Read(msg, out ty.tutorialType);
            Marshaler.Read(msg, out ty.tutorialStatus);
            Marshaler.Read(msg, out ty.tutorialStep);
        }

        public static void Read(Message msg, out List<UserTutorialInfo> list)
        {
            list = new List<UserTutorialInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserTutorialInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserWeapon ty)
        {
            ty = new UserWeapon();
            //Marshaler.Read(msg, out ty.isEvolutionRewarded);
            Marshaler.Read(msg, out ty.weaponSerial);
            Marshaler.Read(msg, out ty.weaponBaseID);
            Marshaler.Read(msg, out ty.upgrade);
            Marshaler.Read(msg, out ty.evolution);
            Marshaler.Read(msg, out ty.addPassiveSkillList);
            Marshaler.Read(msg, out ty.addMagicSkill);
            Marshaler.Read(msg, out ty.getWeaponTime);
            Marshaler.Read(msg, out ty.isEquip);
            Marshaler.Read(msg, out ty.defaultOptionValue);
            Marshaler.Read(msg, out ty.isLock);
            Marshaler.Read(msg, out ty.carveHeroGroup);
        }

        public static void Read(Message msg, out List<UserWeapon> list)
        {
            list = new List<UserWeapon>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserWeapon item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserWeaponPassiveSkill ty)
        {
            ty = new UserWeaponPassiveSkill();
            Marshaler.Read(msg, out ty.passiveID);
            Marshaler.Read(msg, out ty.passiveValue);
        }

        public static void Read(Message msg, out List<UserWeaponPassiveSkill> list)
        {
            list = new List<UserWeaponPassiveSkill>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserWeaponPassiveSkill item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserWeeklyStageEventInfo ty)
        {
            ty = new UserWeeklyStageEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.eventSubIndex);
            Marshaler.Read(msg, out ty.firstWeeklyValue);
            Marshaler.Read(msg, out ty.lastClearStageID);
        }

        public static void Read(Message msg, out List<UserWeeklyStageEventInfo> list)
        {
            list = new List<UserWeeklyStageEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserWeeklyStageEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out UserWorldAreaStageEventInfo ty)
        {
            ty = new UserWorldAreaStageEventInfo();
            Marshaler.Read(msg, out ty.eventSEQ);
            Marshaler.Read(msg, out ty.regionID);
            Marshaler.Read(msg, out ty.mainStageID);
            Marshaler.Read(msg, out ty.sideStageIDList);
            Marshaler.Read(msg, out ty.freeStageValue);
            Marshaler.Read(msg, out ty.lastClearStageID);
            Marshaler.Read(msg, out ty.limitedStageValue);
            Marshaler.Read(msg, out ty.bossStageValue);
        }

        public static void Read(Message msg, out List<UserWorldAreaStageEventInfo> list)
        {
            list = new List<UserWorldAreaStageEventInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                UserWorldAreaStageEventInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out VersionInfo ty)
        {
            ty = new VersionInfo();
            Marshaler.Read(msg, out ty.clientVersion);
            Marshaler.Read(msg, out ty.cdnVersion);
        }

        public static void Read(Message msg, out List<VersionInfo> list)
        {
            list = new List<VersionInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                VersionInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeaponAutoGrindOption ty)
        {
            ty = new WeaponAutoGrindOption();
            Marshaler.Read(msg, out ty.isAutoOn);
            Marshaler.Read(msg, out ty.ratingFlag);
            Marshaler.Read(msg, out ty.setFlag);
            Marshaler.Read(msg, out ty.partFlag);
            Marshaler.Read(msg, out ty.optionValueRate);
            Marshaler.Read(msg, out ty.isOptionValueOff);
        }

        public static void Read(Message msg, out List<WeaponAutoGrindOption> list)
        {
            list = new List<WeaponAutoGrindOption>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeaponAutoGrindOption item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeaponAutoGrindResult ty)
        {
            ty = new WeaponAutoGrindResult();
            Marshaler.Read(msg, out ty.grindWeaponIDList);
            Marshaler.Read(msg, out ty.grindGetItemResultInfoList);
        }

        public static void Read(Message msg, out List<WeaponAutoGrindResult> list)
        {
            list = new List<WeaponAutoGrindResult>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeaponAutoGrindResult item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeaponExchangeMode en)
        {
            int num;
            msg.Read(out num);
            en = (WeaponExchangeMode)num;
        }

        public static void Read(Message msg, out List<WeaponExchangeMode> list)
        {
            list = new List<WeaponExchangeMode>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeaponExchangeMode item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeaponOptionSuccessType en)
        {
            byte num;
            msg.Read(out num);
            en = (WeaponOptionSuccessType)num;
        }

        public static void Read(Message msg, out List<WeaponOptionSuccessType> list)
        {
            list = new List<WeaponOptionSuccessType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeaponOptionSuccessType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeaponPartsType en)
        {
            byte num;
            msg.Read(out num);
            en = (WeaponPartsType)num;
        }

        public static void Read(Message msg, out List<WeaponPartsType> list)
        {
            list = new List<WeaponPartsType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeaponPartsType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeaponSetType en)
        {
            byte num;
            msg.Read(out num);
            en = (WeaponSetType)num;
        }

        public static void Read(Message msg, out List<WeaponSetType> list)
        {
            list = new List<WeaponSetType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeaponSetType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeaponUpgradeFailGaugeInfo ty)
        {
            ty = new WeaponUpgradeFailGaugeInfo();
            Marshaler.Read(msg, out ty.rating);
            Marshaler.Read(msg, out ty.gauge);
        }

        public static void Read(Message msg, out List<WeaponUpgradeFailGaugeInfo> list)
        {
            list = new List<WeaponUpgradeFailGaugeInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeaponUpgradeFailGaugeInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeekStageCoinOpenType en)
        {
            byte num;
            msg.Read(out num);
            en = (WeekStageCoinOpenType)num;
        }

        public static void Read(Message msg, out List<WeekStageCoinOpenType> list)
        {
            list = new List<WeekStageCoinOpenType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeekStageCoinOpenType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeekStageGroupType en)
        {
            byte num;
            msg.Read(out num);
            en = (WeekStageGroupType)num;
        }

        public static void Read(Message msg, out List<WeekStageGroupType> list)
        {
            list = new List<WeekStageGroupType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeekStageGroupType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WeekStageType en)
        {
            byte num;
            msg.Read(out num);
            en = (WeekStageType)num;
        }

        public static void Read(Message msg, out List<WeekStageType> list)
        {
            list = new List<WeekStageType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WeekStageType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestRoomInfo ty)
        {
            ty = new WestRoomInfo();
            //Marshaler.Read(msg, out ty.isActive);
            Marshaler.Read(msg, out ty.westRoomID);
            Marshaler.Read(msg, out ty.roomType);
            Marshaler.Read(msg, out ty.channelID);
            Marshaler.Read(msg, out ty.userCount);
            Marshaler.Read(msg, out ty.serverID);
            Marshaler.Read(msg, out ty.serverPort);
        }

        public static void Read(Message msg, out List<WestRoomInfo> list)
        {
            list = new List<WestRoomInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestRoomInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestRoomType en)
        {
            byte num;
            msg.Read(out num);
            en = (WestRoomType)num;
        }

        public static void Read(Message msg, out List<WestRoomType> list)
        {
            list = new List<WestRoomType>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestRoomType item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestServerInfo ty)
        {
            ty = new WestServerInfo();
            Marshaler.Read(msg, out ty.serverID);
            Marshaler.Read(msg, out ty.serverPort);
        }

        public static void Read(Message msg, out List<WestServerInfo> list)
        {
            list = new List<WestServerInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestServerInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestServerLoginInfo ty)
        {
            ty = new WestServerLoginInfo();
            Marshaler.Read(msg, out ty.usn);
            Marshaler.Read(msg, out ty.sessionKey);
            Marshaler.Read(msg, out ty.joinChannelID);
            Marshaler.Read(msg, out ty.roomType);
        }

        public static void Read(Message msg, out List<WestServerLoginInfo> list)
        {
            list = new List<WestServerLoginInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestServerLoginInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestSideMoveInfo ty)
        {
            ty = new WestSideMoveInfo();
            Marshaler.Read(msg, out ty.targetUSN);
            Marshaler.Read(msg, out ty.x);
            Marshaler.Read(msg, out ty.z);
            Marshaler.Read(msg, out ty.prevState);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.motion);
        }

        public static void Read(Message msg, out List<WestSideMoveInfo> list)
        {
            list = new List<WestSideMoveInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestSideMoveInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestSidePoint ty)
        {
            ty = new WestSidePoint();
            Marshaler.Read(msg, out ty.x);
            Marshaler.Read(msg, out ty.z);
            Marshaler.Read(msg, out ty.prevState);
            Marshaler.Read(msg, out ty.state);
            Marshaler.Read(msg, out ty.motion);
        }

        public static void Read(Message msg, out List<WestSidePoint> list)
        {
            list = new List<WestSidePoint>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestSidePoint item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestSideServerInfo ty)
        {
            ty = new WestSideServerInfo();
            Marshaler.Read(msg, out ty.serverIP);
            Marshaler.Read(msg, out ty.serverPort);
            Marshaler.Read(msg, out ty.channelID);
            Marshaler.Read(msg, out ty.roomType);
        }

        public static void Read(Message msg, out List<WestSideServerInfo> list)
        {
            list = new List<WestSideServerInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestSideServerInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestSideUserInfo ty)
        {
            ty = new WestSideUserInfo();
            Marshaler.Read(msg, out ty.userUSN);
            Marshaler.Read(msg, out ty.nickName);
            Marshaler.Read(msg, out ty.userRankExp);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.point);
            Marshaler.Read(msg, out ty.skinID);
            Marshaler.Read(msg, out ty.skinCostumeGroupID);
            Marshaler.Read(msg, out ty.weaponCostumeGroupID);
            Marshaler.Read(msg, out ty.headCostumeGroupID);
            Marshaler.Read(msg, out ty.isHeadStyleChanged);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBackgroundID);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<WestSideUserInfo> list)
        {
            list = new List<WestSideUserInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestSideUserInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out WestSideUserSimpleInfo ty)
        {
            ty = new WestSideUserSimpleInfo();
            Marshaler.Read(msg, out ty.USN);
            Marshaler.Read(msg, out ty.userExp);
            Marshaler.Read(msg, out ty.NickName);
            Marshaler.Read(msg, out ty.mainSkinID);
            Marshaler.Read(msg, out ty.mainSkinExp);
            Marshaler.Read(msg, out ty.userWantToSay);
            Marshaler.Read(msg, out ty.guildSN);
            Marshaler.Read(msg, out ty.guildName);
            Marshaler.Read(msg, out ty.guildIconID);
            Marshaler.Read(msg, out ty.guildSubIconID);
            Marshaler.Read(msg, out ty.guildBGIconID);
            Marshaler.Read(msg, out ty.playTitleID);
        }

        public static void Read(Message msg, out List<WestSideUserSimpleInfo> list)
        {
            list = new List<WestSideUserSimpleInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                WestSideUserSimpleInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out YggdrasilTowerStageClearRequestInfo ty)
        {
            ty = new YggdrasilTowerStageClearRequestInfo();
            Marshaler.Read(msg, out ty.stageClearRequestInfo);
        }

        public static void Read(Message msg, out List<YggdrasilTowerStageClearRequestInfo> list)
        {
            list = new List<YggdrasilTowerStageClearRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                YggdrasilTowerStageClearRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out YggdrasilTowerStageClearResultInfo ty)
        {
            ty = new YggdrasilTowerStageClearResultInfo();
            Marshaler.Read(msg, out ty.stageClearResultInfo);
        }

        public static void Read(Message msg, out List<YggdrasilTowerStageClearResultInfo> list)
        {
            list = new List<YggdrasilTowerStageClearResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                YggdrasilTowerStageClearResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out YggdrasilTowerStageStartRequestInfo ty)
        {
            ty = new YggdrasilTowerStageStartRequestInfo();
            Marshaler.Read(msg, out ty.stageStartRequestInfo);
        }

        public static void Read(Message msg, out List<YggdrasilTowerStageStartRequestInfo> list)
        {
            list = new List<YggdrasilTowerStageStartRequestInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                YggdrasilTowerStageStartRequestInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }

        public static void Read(Message msg, out YggdrasilTowerStageStartResultInfo ty)
        {
            ty = new YggdrasilTowerStageStartResultInfo();
            Marshaler.Read(msg, out ty.stageStartResultInfo);
        }

        public static void Read(Message msg, out List<YggdrasilTowerStageStartResultInfo> list)
        {
            list = new List<YggdrasilTowerStageStartResultInfo>();
            int num = 0;
            msg.ReadScalar(ref num);
            for (int i = 0; i < num; i++)
            {
                YggdrasilTowerStageStartResultInfo item;
                Marshaler.Read(msg, out item);
                list.Add(item);
            }
        }
    }
}