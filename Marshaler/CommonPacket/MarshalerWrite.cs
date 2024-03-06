using Nettention.Proud;

namespace CommonPacket
{
    public partial class Marshaler : Nettention.Proud.Marshaler
    {
        public static void Write(Message msg, RmiID en)
        {
            msg.Write(en);
        }

        public static void Write(Message msg, ADViewContentType en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<ADViewContentType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AICustomizingActionInfo ty)
        {
            Marshaler.Write(msg, ty.priority);
            Marshaler.Write(msg, ty.detailInfo);
        }

        public static void Write(Message msg, List<AICustomizingActionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AICustomizingDetailInfo ty)
        {
            Marshaler.Write(msg, ty.costID);
            Marshaler.Write(msg, ty.skillID);
            Marshaler.Write(msg, ty.targetID);
            Marshaler.Write(msg, ty.allowDuplicationID);
            Marshaler.Write(msg, ty.conditionIDList);
            Marshaler.Write(msg, ty.moveID);
            Marshaler.Write(msg, ty.moveConditionID);
        }

        public static void Write(Message msg, List<AICustomizingDetailInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AICustomizingGroupInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.priority);
            Marshaler.Write(msg, ty.actionInfoList);
        }

        public static void Write(Message msg, List<AICustomizingGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AICustomizingInfo ty)
        {
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.iconID);
            Marshaler.Write(msg, ty.isDefault);
            Marshaler.Write(msg, ty.groupInfoList);
        }

        public static void Write(Message msg, List<AICustomizingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarAreaInfo ty)
        {
            Marshaler.Write(msg, ty.areaId);
            Marshaler.Write(msg, ty.goddessScore);
            Marshaler.Write(msg, ty.demonScore);
        }

        public static void Write(Message msg, List<AncientWarAreaInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarExtraStageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearRequestInfo);
            Marshaler.Write(msg, ty.ingameBattlePointRequest);
        }

        public static void Write(Message msg, List<AncientWarExtraStageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarExtraStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearResultInfo);
            Marshaler.Write(msg, ty.stageScoreInfo);
            Marshaler.Write(msg, ty.clearMissionIdList);
            Marshaler.Write(msg, ty.userAncientWarInfo);
        }

        public static void Write(Message msg, List<AncientWarExtraStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarExtraStageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartRequestInfo);
        }

        public static void Write(Message msg, List<AncientWarExtraStageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarExtraStageStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartResultInfo);
            Marshaler.Write(msg, ty.useKeyItemResultInfo);
        }

        public static void Write(Message msg, List<AncientWarExtraStageStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.goddessScore);
            Marshaler.Write(msg, ty.demonScore);
            Marshaler.Write(msg, ty.areaInfoList);
        }

        public static void Write(Message msg, List<AncientWarInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarStageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearRequestInfo);
            Marshaler.Write(msg, ty.ingameBattlePointRequest);
        }

        public static void Write(Message msg, List<AncientWarStageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearResultInfo);
            Marshaler.Write(msg, ty.stageScoreInfo);
            Marshaler.Write(msg, ty.clearMissionIdList);
            Marshaler.Write(msg, ty.userAncientWarInfo);
        }

        public static void Write(Message msg, List<AncientWarStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarStageScoreInfo ty)
        {
            Marshaler.Write(msg, ty.boostValue);
            Marshaler.Write(msg, ty.clearScore);
            Marshaler.Write(msg, ty.damageScore);
            Marshaler.Write(msg, ty.missionScore);
            Marshaler.Write(msg, ty.lifeScore);
            Marshaler.Write(msg, ty.totalScore);
        }

        public static void Write(Message msg, List<AncientWarStageScoreInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarStageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartRequestInfo);
        }

        public static void Write(Message msg, List<AncientWarStageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarStageStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartResultInfo);
        }

        public static void Write(Message msg, List<AncientWarStageStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarStageType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<AncientWarStageType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<AncientWarState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarTeamType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<AncientWarTeamType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AncientWarUserRankInfo ty)
        {
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.redisAncientWarUserRankInfo);
        }

        public static void Write(Message msg, List<AncientWarUserRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AnotherQuestClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.questID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.removeItemResultInfoList);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.apRewardInfoList);
        }

        public static void Write(Message msg, List<AnotherQuestClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, APInfo ty)
        {
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.count);
            Marshaler.Write(msg, ty.updateTime);
            Marshaler.Write(msg, ty.remainSecondToRecharge);
        }

        public static void Write(Message msg, List<APInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ApRewardInfo ty)
        {
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.getApCount);
        }

        public static void Write(Message msg, List<ApRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, APType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<APType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AreaType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<AreaType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaAllRewardResultInfo ty)
        {
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumber);
            Marshaler.Write(msg, ty.rankingPoint);
            Marshaler.Write(msg, ty.rewardRank);
            Marshaler.Write(msg, ty.totalPlayCount);
            Marshaler.Write(msg, ty.totalWinCount);
            Marshaler.Write(msg, ty.attackPlayCount);
            Marshaler.Write(msg, ty.attackWinCount);
            Marshaler.Write(msg, ty.defencePlayCount);
            Marshaler.Write(msg, ty.defenceWinCount);
            Marshaler.Write(msg, ty.rewardItemList);
            Marshaler.Write(msg, ty.rewardSeasonPoint);
            Marshaler.Write(msg, ty.totalRankCount);
            Marshaler.Write(msg, ty.rewardPvpLimitSeasonId);
        }

        public static void Write(Message msg, List<ArenaAllRewardResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaDecisionHistoryData ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.battleType);
            Marshaler.Write(msg, ty.battleResult);
            Marshaler.Write(msg, ty.changePoint);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.targetUSN);
            Marshaler.Write(msg, ty.targetNickname);
            Marshaler.Write(msg, ty.targetRankLevel);
            Marshaler.Write(msg, ty.targetMainHeroID);
            Marshaler.Write(msg, ty.targetGuildName);
            Marshaler.Write(msg, ty.targetGuildIconID);
            Marshaler.Write(msg, ty.targetGuildSubIconID);
            Marshaler.Write(msg, ty.targetGuildBackgroundID);
        }

        public static void Write(Message msg, List<ArenaDecisionHistoryData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaDecisionMatchingData ty)
        {
            Marshaler.Write(msg, ty.targetUSN);
            Marshaler.Write(msg, ty.targetNickname);
            Marshaler.Write(msg, ty.targetRankExp);
            Marshaler.Write(msg, ty.targetMainHeroID);
            Marshaler.Write(msg, ty.targetGuildName);
            Marshaler.Write(msg, ty.targetGuildIconID);
            Marshaler.Write(msg, ty.targetGuildSubIconID);
            Marshaler.Write(msg, ty.targetGuildBackgroundID);
            Marshaler.Write(msg, ty.matchingType);
        }

        public static void Write(Message msg, List<ArenaDecisionMatchingData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaDecisionMatchingSimpleInfo ty)
        {
            Marshaler.Write(msg, ty.arenaRealTimePvpOppUserInfo);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
        }

        public static void Write(Message msg, List<ArenaDecisionMatchingSimpleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaDecisionMatchingType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<ArenaDecisionMatchingType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueEventType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<ArenaLeagueEventType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueGrade en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<ArenaLeagueGrade> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueInfo ty)
        {
            Marshaler.Write(msg, ty.leagueID);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumer);
            Marshaler.Write(msg, ty.userCount);
            Marshaler.Write(msg, ty.namePrefixID);
            Marshaler.Write(msg, ty.namePostfixID);
        }

        public static void Write(Message msg, List<ArenaLeagueInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.leagueUserInfo);
            Marshaler.Write(msg, ty.matchInfoList);
            Marshaler.Write(msg, ty.missionInfo);
            Marshaler.Write(msg, ty.shopBuyInfoList);
            Marshaler.Write(msg, ty.rewardItemList);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.prevGrade);
            Marshaler.Write(msg, ty.prevGradeNumber);
        }

        public static void Write(Message msg, List<ArenaLeagueLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueMatchInfo ty)
        {
            Marshaler.Write(msg, ty.oppUserInfo);
            Marshaler.Write(msg, ty.matchResult);
        }

        public static void Write(Message msg, List<ArenaLeagueMatchInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueMatchRecord ty)
        {
            Marshaler.Write(msg, ty.oppUSN);
            Marshaler.Write(msg, ty.oppNickName);
            Marshaler.Write(msg, ty.oppExp);
            Marshaler.Write(msg, ty.oppHeroID);
            Marshaler.Write(msg, ty.matchResult);
            Marshaler.Write(msg, ty.attack);
            Marshaler.Write(msg, ty.myRankPointChangeValue);
            Marshaler.Write(msg, ty.recordTime);
        }

        public static void Write(Message msg, List<ArenaLeagueMatchRecord> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueMissionInfo ty)
        {
            Marshaler.Write(msg, ty.missionClearCount);
            Marshaler.Write(msg, ty.matchCount);
            Marshaler.Write(msg, ty.winCount);
            Marshaler.Write(msg, ty.winningStreakCount);
            Marshaler.Write(msg, ty.getRewardMissionIDList);
        }

        public static void Write(Message msg, List<ArenaLeagueMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueNotifyResult ty)
        {
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.leagueInfo);
            Marshaler.Write(msg, ty.matchInfoList);
        }

        public static void Write(Message msg, List<ArenaLeagueNotifyResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueOpponentInfo ty)
        {
            Marshaler.Write(msg, ty.userInfo);
            Marshaler.Write(msg, ty.teamInfo);
        }

        public static void Write(Message msg, List<ArenaLeagueOpponentInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueOpponentUserInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.leagueSeq);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumber);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.winCount);
            Marshaler.Write(msg, ty.playCount);
            Marshaler.Write(msg, ty.totalWinCount);
            Marshaler.Write(msg, ty.totalPlayCount);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<ArenaLeagueOpponentUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaLeagueUserInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.leagueSeq);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumber);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.leagueID);
            Marshaler.Write(msg, ty.namePrefixID);
            Marshaler.Write(msg, ty.namePostfixID);
            Marshaler.Write(msg, ty.winningStreak);
            Marshaler.Write(msg, ty.winCount);
            Marshaler.Write(msg, ty.playCount);
            Marshaler.Write(msg, ty.totalWinCount);
            Marshaler.Write(msg, ty.totalPlayCount);
            Marshaler.Write(msg, ty.remainSecToBuffEnd);
            Marshaler.Write(msg, ty.remainSecToFreeRefresh);
            Marshaler.Write(msg, ty.remainSecToLeagueEnd);
            Marshaler.Write(msg, ty.remainSecToShopRefresh);
            Marshaler.Write(msg, ty.isPromotion);
            Marshaler.Write(msg, ty.promotionWinCount);
            Marshaler.Write(msg, ty.promotionPlayCount);
            Marshaler.Write(msg, ty.isRewardReceived);
        }

        public static void Write(Message msg, List<ArenaLeagueUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRankingBattleEndResult ty)
        {
            Marshaler.Write(msg, ty.arenaRankingLobbyInfo);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.getRankPoint);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.getCoinItemResultInfo);
            Marshaler.Write(msg, ty.getCoinCount);
            Marshaler.Write(msg, ty.increaseCoinCountByBuff);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.isFirstPVP);
            Marshaler.Write(msg, ty.usedFoodID);
            Marshaler.Write(msg, ty.adViewRouletteInfo);
            Marshaler.Write(msg, ty.pvpWinCountEventInfoList);
            Marshaler.Write(msg, ty.isAbuseDetect);
        }

        public static void Write(Message msg, List<ArenaRankingBattleEndResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRankingJoinStatus en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<ArenaRankingJoinStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRankingLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.attackPlayCount);
            Marshaler.Write(msg, ty.attackWinCount);
            Marshaler.Write(msg, ty.defencePlayCount);
            Marshaler.Write(msg, ty.defenceWinCount);
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.joinStatus);
            Marshaler.Write(msg, ty.arenaRankingRewardInfo);
            Marshaler.Write(msg, ty.seasonPvpPassiveID);
            Marshaler.Write(msg, ty.seasonPvpModeID);
        }

        public static void Write(Message msg, List<ArenaRankingLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpBattleEndResult ty)
        {
            Marshaler.Write(msg, ty.arenaRealTimePvpLobbyInfo);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.getRankPoint);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.getCoinItemResultInfo);
            Marshaler.Write(msg, ty.getCoinCount);
            Marshaler.Write(msg, ty.increaseCoinCountByBuff);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.isFirstPVP);
            Marshaler.Write(msg, ty.usedFoodID);
            Marshaler.Write(msg, ty.adViewRouletteInfo);
            Marshaler.Write(msg, ty.pvpWinCountEventInfoList);
            Marshaler.Write(msg, ty.isAbuseDetect);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpBattleEndResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpBattleStartResult ty)
        {
            Marshaler.Write(msg, ty.arenaRealTimePvpOppUserInfo);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.isCPU);
            Marshaler.Write(msg, ty.firstAttackUSN);
            Marshaler.Write(msg, ty.changeRankPoint);
            Marshaler.Write(msg, ty.getCoinItemResultInfo);
            Marshaler.Write(msg, ty.isBuffUsed);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.useItemResultInfo);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.userPlayCountEventInfoList);
            Marshaler.Write(msg, ty.isPlacementMatching);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpBattleStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePVPClearRequest ty)
        {
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.targetSkinStatInfoList);
            Marshaler.Write(msg, ty.missionRequest);
        }

        public static void Write(Message msg, List<ArenaRealTimePVPClearRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpGameStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.getCoinItemResultInfo);
            Marshaler.Write(msg, ty.useItemResultInfo);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.userPlayCountEventInfoList);
            Marshaler.Write(msg, ty.foodBuffInfo);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpGameStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpInfo ty)
        {
            Marshaler.Write(msg, ty.needJoin);
            Marshaler.Write(msg, ty.arenaRealTimePvpRemainSec);
            Marshaler.Write(msg, ty.arenaRealTimeDecisionRemainSec);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.prevGrade);
            Marshaler.Write(msg, ty.prevGradeNumber);
            Marshaler.Write(msg, ty.placementMatchList);
            Marshaler.Write(msg, ty.arenaRealTimePvpLimitHeroCostRemainTimeSec);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpLastRankerStatueInfo ty)
        {
            Marshaler.Write(msg, ty.lastRank);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.skinCostumeGroup);
            Marshaler.Write(msg, ty.weaponCostumeGroup);
            Marshaler.Write(msg, ty.headCostumeGroup);
            Marshaler.Write(msg, ty.isHelmetOpen);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBackgroundID);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumber);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpLastRankerStatueInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpLeagueInfo ty)
        {
            Marshaler.Write(msg, ty.leagueID);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumber);
            Marshaler.Write(msg, ty.userCount);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpLeagueInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePVPLimitHeroCost ty)
        {
            Marshaler.Write(msg, ty.heroId);
            Marshaler.Write(msg, ty.cost);
        }

        public static void Write(Message msg, List<ArenaRealTimePVPLimitHeroCost> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpLimitMyRankInfo ty)
        {
            Marshaler.Write(msg, ty.myRank);
            Marshaler.Write(msg, ty.totalRankCount);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpLimitMyRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.arenaRealTimeUserInfo);
            Marshaler.Write(msg, ty.arenaRealTimePvpInfo);
            Marshaler.Write(msg, ty.arenaRealTimePvpRewardInfo);
            Marshaler.Write(msg, ty.decisionFirstFlag);
            Marshaler.Write(msg, ty.seasonPvpPassiveID);
            Marshaler.Write(msg, ty.seasonPvpModeID);
            Marshaler.Write(msg, ty.lowerLeagueTableID);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpOpponentUserInfo ty)
        {
            //Marshaler.Write(msg, ty.beforeOppUSN);
            //Marshaler.Write(msg, ty.leagueID);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.leagueSeq);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumber);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.totalWinCount);
            Marshaler.Write(msg, ty.totalPlayCount);
            Marshaler.Write(msg, ty.totalDefencePlayCount);
            Marshaler.Write(msg, ty.lastRank);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.isNpcData);
            Marshaler.Write(msg, ty.playTitleID);
            Marshaler.Write(msg, ty.attackPlayCount);
            Marshaler.Write(msg, ty.attackWinCount);
            Marshaler.Write(msg, ty.defencePlayCount);
            Marshaler.Write(msg, ty.defenceWinCount);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpOpponentUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpRankerBattleStartResult ty)
        {
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.oppUserInfo);
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.isBuffUsed);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpRankerBattleStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpRewardInfo ty)
        {
            Marshaler.Write(msg, ty.rewardReceived);
            Marshaler.Write(msg, ty.rewardRank);
            Marshaler.Write(msg, ty.rewardItemList);
            Marshaler.Write(msg, ty.rewardSeasonPoint);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvpShopBuyInfo ty)
        {
            Marshaler.Write(msg, ty.shopID);
            Marshaler.Write(msg, ty.buyCount);
        }

        public static void Write(Message msg, List<ArenaRealTimePvpShopBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimePvp_LoginInfo ty)
        {
            Marshaler.Write(msg, ty.upperGrade);
            Marshaler.Write(msg, ty.upperGradeNumber);
            Marshaler.Write(msg, ty.upperRankPoint);
            Marshaler.Write(msg, ty.upperTotalWinCount);
            Marshaler.Write(msg, ty.upperTotalPlayCount);
            Marshaler.Write(msg, ty.upperJoinAble);
            Marshaler.Write(msg, ty.upperRewardAble);
            Marshaler.Write(msg, ty.lowerGrade);
            Marshaler.Write(msg, ty.lowerGradeNumber);
            Marshaler.Write(msg, ty.lowerRankPoint);
            Marshaler.Write(msg, ty.lowerTotalWinCount);
            Marshaler.Write(msg, ty.lowerTotalPlayCount);
            Marshaler.Write(msg, ty.lowerJoinAble);
            Marshaler.Write(msg, ty.lowerRewardAble);
            Marshaler.Write(msg, ty.arenaRealTimePvpLowerRemainSEC);
            Marshaler.Write(msg, ty.arenaRealTimePvpRemainSEC);
            Marshaler.Write(msg, ty.arenaRealTimedecisionRemainSEC);
            Marshaler.Write(msg, ty.pvpSeasonRewardAble);
            Marshaler.Write(msg, ty.pvpSeasonID);
            Marshaler.Write(msg, ty.rankingRewardAble);
            Marshaler.Write(msg, ty.rankingJoinAble);
            Marshaler.Write(msg, ty.limitRankPoint);
            Marshaler.Write(msg, ty.limitTotalWinCount);
            Marshaler.Write(msg, ty.limitTotalPlayCount);
            Marshaler.Write(msg, ty.limitJoinAble);
            Marshaler.Write(msg, ty.limitRewardAble);
            Marshaler.Write(msg, ty.arenaRealTimePvpLimitRemainSec);
        }

        public static void Write(Message msg, List<ArenaRealTimePvp_LoginInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaRealTimeUserInfo ty)
        {
            Marshaler.Write(msg, ty.arenaRealTimePvpRankPoint);
            Marshaler.Write(msg, ty.arenaRealTimePvpGrade);
            Marshaler.Write(msg, ty.arenaRealTimePvpGradeNumber);
            Marshaler.Write(msg, ty.arenaRealTimePvpLeagueID);
            Marshaler.Write(msg, ty.totalWinCount);
            Marshaler.Write(msg, ty.totalPlayCount);
            Marshaler.Write(msg, ty.realTimePvpPromotion);
            Marshaler.Write(msg, ty.realTimePvpPromotionPlayCount);
            Marshaler.Write(msg, ty.realTimePvpPromotionWinCount);
            Marshaler.Write(msg, ty.lastRank);
            Marshaler.Write(msg, ty.lastDecisionRankPoint);
            Marshaler.Write(msg, ty.attackWinCount);
            Marshaler.Write(msg, ty.attackTotalPlayCount);
            Marshaler.Write(msg, ty.defenceWinCount);
            Marshaler.Write(msg, ty.defenceTotalPlayCount);
            Marshaler.Write(msg, ty.winStreak);
        }

        public static void Write(Message msg, List<ArenaRealTimeUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashBattleEndRequest ty)
        {
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.opponentUSN);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.opponentSkinStatInfoList);
            Marshaler.Write(msg, ty.missionRequest);
            Marshaler.Write(msg, ty.isAutoPlay);
            Marshaler.Write(msg, ty.turnCount);
        }

        public static void Write(Message msg, List<ArenaSmashBattleEndRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashBattleEndResult ty)
        {
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.userWin);
            Marshaler.Write(msg, ty.opponentWin);
            Marshaler.Write(msg, ty.isMatchPlay);
            Marshaler.Write(msg, ty.arenaSmashUserInfo);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.adViewRouletteInfo);
        }

        public static void Write(Message msg, List<ArenaSmashBattleEndResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashBattleStartRequest ty)
        {
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.opponentUSN);
        }

        public static void Write(Message msg, List<ArenaSmashBattleStartRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashBattleStartResult ty)
        {
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.foodBuffItemID);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.userPlayCountEventInfoList);
        }

        public static void Write(Message msg, List<ArenaSmashBattleStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.arenaSmashUserInfo);
            Marshaler.Write(msg, ty.needJoin);
            Marshaler.Write(msg, ty.needTeamSetting);
            Marshaler.Write(msg, ty.weeklyResetStartRaminSec);
            Marshaler.Write(msg, ty.weeklyResetEndRemainSec);
            Marshaler.Write(msg, ty.pvpModeList);
        }

        public static void Write(Message msg, List<ArenaSmashLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashOpponentInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.matchResult);
        }

        public static void Write(Message msg, List<ArenaSmashOpponentInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashRankInfo ty)
        {
            Marshaler.Write(msg, ty.rankInfo);
            Marshaler.Write(msg, ty.teamInfoList);
        }

        public static void Write(Message msg, List<ArenaSmashRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashRecordInfo ty)
        {
            Marshaler.Write(msg, ty.recordSN);
            Marshaler.Write(msg, ty.isPlayer);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.prevRank);
            Marshaler.Write(msg, ty.opponentUSN);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
        }

        public static void Write(Message msg, List<ArenaSmashRecordInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashShopInfo ty)
        {
            Marshaler.Write(msg, ty.shopGrade);
            Marshaler.Write(msg, ty.shopRewardID);
            Marshaler.Write(msg, ty.shopRewardPoint);
        }

        public static void Write(Message msg, List<ArenaSmashShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ArenaSmashUserInfo ty)
        {
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.winRewardPoint);
            Marshaler.Write(msg, ty.bestRank);
            Marshaler.Write(msg, ty.bestReward);
            Marshaler.Write(msg, ty.bestResetRaminSec);
            Marshaler.Write(msg, ty.opponentListRemainSec);
            Marshaler.Write(msg, ty.opponentListExpireRemainSec);
        }

        public static void Write(Message msg, List<ArenaSmashUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AttendanceResult ty)
        {
            Marshaler.Write(msg, ty.attendanceInfo);
            Marshaler.Write(msg, ty.rewardItemInfoList);
            Marshaler.Write(msg, ty.apRewardInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.preRegistationRewardList);
        }

        public static void Write(Message msg, List<AttendanceResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, AttendanceType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<AttendanceType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BalloonInfo ty)
        {
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.rewardId);
            Marshaler.Write(msg, ty.isPop);
        }

        public static void Write(Message msg, List<BalloonInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BasePointInfo ty)
        {
            Marshaler.Write(msg, ty.basePointID);
            Marshaler.Write(msg, ty.fellowshipExp);
            Marshaler.Write(msg, ty.trigger);
            Marshaler.Write(msg, ty.uniqueInteractiveFlag);
            Marshaler.Write(msg, ty.lastClearLoopQuestID);
            Marshaler.Write(msg, ty.loopRandomQuestID);
            Marshaler.Write(msg, ty.overDonationValue);
            Marshaler.Write(msg, ty.disableDropInteractiveList);
        }

        public static void Write(Message msg, List<BasePointInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BasePointRefreshInfo ty)
        {
            Marshaler.Write(msg, ty.isGuildKickOut);
            Marshaler.Write(msg, ty.guildMemberInfo);
            Marshaler.Write(msg, ty.lobbyReddotInfo);
            Marshaler.Write(msg, ty.prevTopGuildRankInfoList);
            Marshaler.Write(msg, ty.lobbyRandomShopInfo);
        }

        public static void Write(Message msg, List<BasePointRefreshInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BattleSkinInfo ty)
        {
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.heroAliveStatus);
            Marshaler.Write(msg, ty.isBestPlayer);
            Marshaler.Write(msg, ty.power);
            Marshaler.Write(msg, ty.teamIndex);
        }

        public static void Write(Message msg, List<BattleSkinInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BattleSkinResultInfo ty)
        {
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinExp);
            Marshaler.Write(msg, ty.skinGetExp);
            Marshaler.Write(msg, ty.skinBuffExp);
            Marshaler.Write(msg, ty.isBestPlayer);
        }

        public static void Write(Message msg, List<BattleSkinResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BillingInitializeResultInfo ty)
        {
            Marshaler.Write(msg, ty.resCode);
            Marshaler.Write(msg, ty.transactionID);
            Marshaler.Write(msg, ty.resultString);
            Marshaler.Write(msg, ty.pcTransactionID);
        }

        public static void Write(Message msg, List<BillingInitializeResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BillingRemainTRResultInfo ty)
        {
            Marshaler.Write(msg, ty.resCode);
            Marshaler.Write(msg, ty.isPurchase);
            Marshaler.Write(msg, ty.resultString);
        }

        public static void Write(Message msg, List<BillingRemainTRResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BillingResCode en)
        {
            msg.Write((short)en);
        }
        public static void Write(Message msg, List<BillingResCode> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BillingResultCode en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<BillingResultCode> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BillingVerifyRequestInfo ty)
        {
            Marshaler.Write(msg, ty.verifyType);
            Marshaler.Write(msg, ty.purchases);
            Marshaler.Write(msg, ty.packageID);
            Marshaler.Write(msg, ty.isPurchase);
            Marshaler.Write(msg, ty.tid);
            Marshaler.Write(msg, ty.market);
            Marshaler.Write(msg, ty.currencyType);
            Marshaler.Write(msg, ty.iapItemType);
        }

        public static void Write(Message msg, List<BillingVerifyRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BillingVerifyResultInfo ty)
        {
            Marshaler.Write(msg, ty.resCode);
            Marshaler.Write(msg, ty.resultCode);
            Marshaler.Write(msg, ty.transactionID);
            Marshaler.Write(msg, ty.resultString);
            Marshaler.Write(msg, ty.isPurchase);
            Marshaler.Write(msg, ty.promoFlag);
            Marshaler.Write(msg, ty.gppFlag);
            Marshaler.Write(msg, ty.pcTransactionID);
        }

        public static void Write(Message msg, List<BillingVerifyResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BillingVerifyType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<BillingVerifyType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BlitzHeroInfo ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.status);
            Marshaler.Write(msg, ty.type);
        }

        public static void Write(Message msg, List<BlitzHeroInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BlitzHeroType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<BlitzHeroType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BlitzMonsterInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.monsterID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDie);
        }

        public static void Write(Message msg, List<BlitzMonsterInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BlitzSquadInfo ty)
        {
            Marshaler.Write(msg, ty.remainSquadChageCount);
            Marshaler.Write(msg, ty.remainSquadInitCount);
            Marshaler.Write(msg, ty.heroInfoList);
        }

        public static void Write(Message msg, List<BlitzSquadInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BlitzTeamSlotInfo ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.heroGroupID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.fateHeroID);
            Marshaler.Write(msg, ty.fateHeroGroupID);
            Marshaler.Write(msg, ty.fateSkinID);
        }

        public static void Write(Message msg, List<BlitzTeamSlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BoassWarLoadingSendInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.roomSN);
        }

        public static void Write(Message msg, List<BoassWarLoadingSendInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, List<bool> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarBattleStartResult ty)
        {
            Marshaler.Write(msg, ty.useItemResultInfoList);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<BossWarBattleStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarBattleSyncType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<BossWarBattleSyncType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarClientSendGameInfo ty)
        {
            Marshaler.Write(msg, ty.gameSN);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.hostUSN);
            Marshaler.Write(msg, ty.hostNickname);
            Marshaler.Write(msg, ty.hostUserExp);
            Marshaler.Write(msg, ty.hostSkinID);
        }

        public static void Write(Message msg, List<BossWarClientSendGameInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarGameState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<BossWarGameState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarGroupInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.remainEndSec);
        }

        public static void Write(Message msg, List<BossWarGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarJoinMemberInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.isHost);
            Marshaler.Write(msg, ty.position);
            Marshaler.Write(msg, ty.userState);
            Marshaler.Write(msg, ty.teamPower);
            Marshaler.Write(msg, ty.useFoodId);
        }

        public static void Write(Message msg, List<BossWarJoinMemberInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarJoinResult ty)
        {
            Marshaler.Write(msg, ty.gameSN);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.stageMonsterInfoList);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
        }

        public static void Write(Message msg, List<BossWarJoinResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarLobbySyncInfo ty)
        {
            Marshaler.Write(msg, ty.notifyType);
            Marshaler.Write(msg, ty.usn);
        }

        public static void Write(Message msg, List<BossWarLobbySyncInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarNotifyType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<BossWarNotifyType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarStartResult ty)
        {
            Marshaler.Write(msg, ty.gameSN);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.ingameSeed);
        }

        public static void Write(Message msg, List<BossWarStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarSubState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<BossWarSubState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarSync ty)
        {
            Marshaler.Write(msg, ty.syncType);
            Marshaler.Write(msg, ty.syncValue);
        }

        public static void Write(Message msg, List<BossWarSync> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarUserProfileInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.position);
            Marshaler.Write(msg, ty.isHost);
            Marshaler.Write(msg, ty.userState);
            Marshaler.Write(msg, ty.teamPower);
            Marshaler.Write(msg, ty.useFoodId);
        }

        public static void Write(Message msg, List<BossWarUserProfileInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, BossWarUserState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<BossWarUserState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, byte[] array)
        {
            int num = (array == null) ? 0 : array.Length;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, array[i]);
            }
        }

        public static void Write(Message msg, List<byte> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ByteArrayInfo ty)
        {
            Marshaler.Write(msg, ty.data);
        }

        public static void Write(Message msg, List<ByteArrayInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ChallengeBossEventInfoToClientSend ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.expireDate);
            Marshaler.Write(msg, ty.bossStage);
            Marshaler.Write(msg, ty.rewardIndex);
            Marshaler.Write(msg, ty.currentEventChallengeBossSeq);
            Marshaler.Write(msg, ty.remainSkinUsedSEQResetSec);
            Marshaler.Write(msg, ty.currentMissionGroupID);
        }

        public static void Write(Message msg, List<ChallengeBossEventInfoToClientSend> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ChallengeBossEventStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.userChallengeBossEventInfoForClient);
            Marshaler.Write(msg, ty.clearMissionIDList);
            Marshaler.Write(msg, ty.addPoint);
            Marshaler.Write(msg, ty.addBonusPoint);
        }

        public static void Write(Message msg, List<ChallengeBossEventStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ChannelUserInfo ty)
        {
            Marshaler.Write(msg, ty.netmarblePlayerID);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.userNickName);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.lastLoginTime);
            Marshaler.Write(msg, ty.isAdditionalDownloadNeeded);
        }

        public static void Write(Message msg, List<ChannelUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ChatInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.msg);
            Marshaler.Write(msg, ty.extraData);
            Marshaler.Write(msg, ty.stamp);
            Marshaler.Write(msg, ty.guildMemberGrade);
            Marshaler.Write(msg, ty.date);
        }

        public static void Write(Message msg, List<ChatInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ChatMsgType en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<ChatMsgType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ChatQuickMessageInfo ty)
        {
            Marshaler.Write(msg, ty.slotNumber);
            Marshaler.Write(msg, ty.message);
        }

        public static void Write(Message msg, List<ChatQuickMessageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ChatStampBookmarkInfo ty)
        {
            Marshaler.Write(msg, ty.stampSlot);
            Marshaler.Write(msg, ty.stampIDList);
        }

        public static void Write(Message msg, List<ChatStampBookmarkInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CheatResult ty)
        {
            Marshaler.Write(msg, ty.itemResultInfoList);
            Marshaler.Write(msg, ty.sideStageClearInfoList);
            Marshaler.Write(msg, ty.dailyReset);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainStageTopClearID);
            Marshaler.Write(msg, ty.guildPoint);
            Marshaler.Write(msg, ty.userTeamList);
            Marshaler.Write(msg, ty.clearQuestID);
            Marshaler.Write(msg, ty.removeQuestID);
            Marshaler.Write(msg, ty.destroyDiscoverInfo);
            Marshaler.Write(msg, ty.userTutorialInfoList);
            Marshaler.Write(msg, ty.userNpcList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.destroyCheatInfo);
            Marshaler.Write(msg, ty.apRewardInfo);
            Marshaler.Write(msg, ty.userQuestProgressInfoList);
            Marshaler.Write(msg, ty.userRecipeInfo);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.stageInfo);
            Marshaler.Write(msg, ty.cheatType);
            Marshaler.Write(msg, ty.cheatMessage);
            Marshaler.Write(msg, ty.currentTimeAttackMissionDays);
            Marshaler.Write(msg, ty.gachaGaugeInfo);
        }

        public static void Write(Message msg, List<CheatResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CheerGroupInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.cheerCount);
        }

        public static void Write(Message msg, List<CheerGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientDeviceType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<ClientDeviceType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSeasonPassRankRewardInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.buySeasonPassPackageID);
            Marshaler.Write(msg, ty.rankRewardInfoList);
        }

        public static void Write(Message msg, List<ClientSeasonPassRankRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendArenaSmashRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
        }

        public static void Write(Message msg, List<ClientSendArenaSmashRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendArenaSmashRankTeamInfo ty)
        {
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.skinIDList);
        }

        public static void Write(Message msg, List<ClientSendArenaSmashRankTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendBlitzStageEventInfo ty)
        {
            Marshaler.Write(msg, ty.blitzStageEventInfo);
            Marshaler.Write(msg, ty.blitzStageSquadInfo);
            Marshaler.Write(msg, ty.blitzStageMonsterInfoList);
            Marshaler.Write(msg, ty.blitzStageTeamSlotInfoList);
        }

        public static void Write(Message msg, List<ClientSendBlitzStageEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendBossWarInfo ty)
        {
            Marshaler.Write(msg, ty.bossWarInfoList);
            Marshaler.Write(msg, ty.subdueBossPlayInfoList);
        }

        public static void Write(Message msg, List<ClientSendBossWarInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendCreatureNestStageInfo ty)
        {
            Marshaler.Write(msg, ty.userCreatureNestStageInfo);
            Marshaler.Write(msg, ty.savedTeamInfo);
            Marshaler.Write(msg, ty.heroSyncInfoList);
        }

        public static void Write(Message msg, List<ClientSendCreatureNestStageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventAttendanceInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.lastRewardIndex);
            Marshaler.Write(msg, ty.dayFixRewardDay);
            Marshaler.Write(msg, ty.isRewardedToday);
            Marshaler.Write(msg, ty.endRemainSec);
        }

        public static void Write(Message msg, List<ClientSendEventAttendanceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventChallengeBossLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.sendInfo);
        }

        public static void Write(Message msg, List<ClientSendEventChallengeBossLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventConfirmGameInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.totalScore);
            Marshaler.Write(msg, ty.totalScoreRewardFlag);
            Marshaler.Write(msg, ty.highScore);
            Marshaler.Write(msg, ty.userEventConfirmGameRecordInfoList);
        }

        public static void Write(Message msg, List<ClientSendEventConfirmGameInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventDiceInfo ty)
        {
            Marshaler.Write(msg, ty.userEventDiceInfo);
        }

        public static void Write(Message msg, List<ClientSendEventDiceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventLobbyGiftInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.lastRewardIndex);
            Marshaler.Write(msg, ty.isRewardedToday);
        }

        public static void Write(Message msg, List<ClientSendEventLobbyGiftInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventMazeSeasonShopInfo ty)
        {
            Marshaler.Write(msg, ty.eventMazeSeasonShopInfoList);
            Marshaler.Write(msg, ty.eventMazeSeasonShopBuyInfoList);
        }

        public static void Write(Message msg, List<ClientSendEventMazeSeasonShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventMissionInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.chainID);
            Marshaler.Write(msg, ty.rewardChainIndex);
            Marshaler.Write(msg, ty.progressValue);
        }

        public static void Write(Message msg, List<ClientSendEventMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventMoleGameInfo ty)
        {
            Marshaler.Write(msg, ty.userEventMoleGameInfo);
            Marshaler.Write(msg, ty.userEventMoleGameRecordInfoList);
        }

        public static void Write(Message msg, List<ClientSendEventMoleGameInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendEventPuzzleInfo ty)
        {
            Marshaler.Write(msg, ty.userPuzzleInfo);
            Marshaler.Write(msg, ty.userPuzzleBlockInfoList);
            Marshaler.Write(msg, ty.eventPuzzleAPInfo);
        }

        public static void Write(Message msg, List<ClientSendEventPuzzleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendFinalBossDifficultyRankInfo ty)
        {
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.redisFinalBossDifficultyRankInfo);
        }

        public static void Write(Message msg, List<ClientSendFinalBossDifficultyRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendFinalBossRankHeroInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.skinIDList);
        }

        public static void Write(Message msg, List<ClientSendFinalBossRankHeroInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendFinalBossRankInfo ty)
        {
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.redisFinalBossRankInfo);
        }

        public static void Write(Message msg, List<ClientSendFinalBossRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendFinalBossSeasonInfo ty)
        {
            Marshaler.Write(msg, ty.currentSeasonID);
            Marshaler.Write(msg, ty.currentFinalBossStageFlag);
            Marshaler.Write(msg, ty.finalBossGroupInfoList);
            Marshaler.Write(msg, ty.remainFinalBossInitSec);
            Marshaler.Write(msg, ty.currentFinalBossPointItemCount);
            Marshaler.Write(msg, ty.finalBossSeasonInfoList);
            Marshaler.Write(msg, ty.finalBossBattleScoreInfoList);
            Marshaler.Write(msg, ty.prevSeasonID);
            Marshaler.Write(msg, ty.finalBossRankRewardOccured);
            Marshaler.Write(msg, ty.finalBossVowInfoList);
        }

        public static void Write(Message msg, List<ClientSendFinalBossSeasonInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendFinalBossSeasonShopInfo ty)
        {
            Marshaler.Write(msg, ty.finalBossSeasonShopInfoList);
            Marshaler.Write(msg, ty.finalBossSeasonShopBuyInfoList);
        }

        public static void Write(Message msg, List<ClientSendFinalBossSeasonShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendGuildBossLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.startRemainSec);
            Marshaler.Write(msg, ty.endRamainSec);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.totalRankUpCount);
            Marshaler.Write(msg, ty.currentRankPoint);
            Marshaler.Write(msg, ty.userWeeklyContribution);
            Marshaler.Write(msg, ty.currentMissionGroupID);
            Marshaler.Write(msg, ty.stageLocked);
            Marshaler.Write(msg, ty.currentGuildBossSeq);
            Marshaler.Write(msg, ty.isJoinFirstWeek);
            Marshaler.Write(msg, ty.currentSeasonGroup);
            Marshaler.Write(msg, ty.guildBossRankPointList);
            Marshaler.Write(msg, ty.guildBossRankPointReward);
            Marshaler.Write(msg, ty.guildBossOffSeasonRankPointList);
            Marshaler.Write(msg, ty.currentSeasonID);
            Marshaler.Write(msg, ty.guildBossRankInfoList);
            Marshaler.Write(msg, ty.joinFirstWeekRemainSec);
            Marshaler.Write(msg, ty.guildBossOffSeasonInfoList);
            Marshaler.Write(msg, ty.isGuildBossHellOpened);
        }

        public static void Write(Message msg, List<ClientSendGuildBossLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendGuildBossRankInfo ty)
        {
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.redisGuildBossRankInfo);
            Marshaler.Write(msg, ty.guildInvitationState);
        }

        public static void Write(Message msg, List<ClientSendGuildBossRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendGuildRankInfo ty)
        {
            Marshaler.Write(msg, ty.guildRankInfo);
            Marshaler.Write(msg, ty.guildInfo);
        }

        public static void Write(Message msg, List<ClientSendGuildRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendGuildWarInfo ty)
        {
            Marshaler.Write(msg, ty.guildWarScheduleInfo);
            Marshaler.Write(msg, ty.nextGuildWarScheduleInfo);
            Marshaler.Write(msg, ty.isGuildWarSelected);
            Marshaler.Write(msg, ty.isGuildWarPrevSeasonSelected);
            Marshaler.Write(msg, ty.isGuildWarPlayable);
            Marshaler.Write(msg, ty.guildWarType);
        }

        public static void Write(Message msg, List<ClientSendGuildWarInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendGuildWarLowMemberRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.score);
        }

        public static void Write(Message msg, List<ClientSendGuildWarLowMemberRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendHeroLeagueInfo ty)
        {
            Marshaler.Write(msg, ty.remainSeasonInitSec);
            Marshaler.Write(msg, ty.remainWeekInitSec);
            Marshaler.Write(msg, ty.week);
            Marshaler.Write(msg, ty.heroLeagueInfo);
            Marshaler.Write(msg, ty.heroLeagueSeasonInfo);
            Marshaler.Write(msg, ty.heroLeagueHeroList);
            Marshaler.Write(msg, ty.heroLeagueSeasonBuffInfo);
            Marshaler.Write(msg, ty.heroLeagueSpecialBuffInfoList);
        }

        public static void Write(Message msg, List<ClientSendHeroLeagueInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendHeroLeagueSeasonShopInfo ty)
        {
            Marshaler.Write(msg, ty.heroLeagueSeasonShopInfoList);
            Marshaler.Write(msg, ty.heroLeagueSeasonShopBuyInfoList);
        }

        public static void Write(Message msg, List<ClientSendHeroLeagueSeasonShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendMissionInfo ty)
        {
            Marshaler.Write(msg, ty.chainID);
            Marshaler.Write(msg, ty.rewardChainIndex);
            Marshaler.Write(msg, ty.progressValue);
        }

        public static void Write(Message msg, List<ClientSendMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendPlayTitleMissionInfo ty)
        {
            Marshaler.Write(msg, ty.missionID);
            Marshaler.Write(msg, ty.progressValue);
        }

        public static void Write(Message msg, List<ClientSendPlayTitleMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendTimeMissionEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.remainSec);
        }

        public static void Write(Message msg, List<ClientSendTimeMissionEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSendUserAttendanceInfo ty)
        {
            Marshaler.Write(msg, ty.isRewardedToday);
            Marshaler.Write(msg, ty.attendanceType);
            Marshaler.Write(msg, ty.attendanceGroup);
            Marshaler.Write(msg, ty.rewardIndex);
            Marshaler.Write(msg, ty.welcomeRewardIndex);
            Marshaler.Write(msg, ty.comebackMissionEnable);
            Marshaler.Write(msg, ty.combackEndRemainSec);
            Marshaler.Write(msg, ty.pvpComebackMissionEnable);
            Marshaler.Write(msg, ty.pvpCombackEndRemainSec);
            Marshaler.Write(msg, ty.lastRewardedType);
            Marshaler.Write(msg, ty.lastRewardedGroup);
            Marshaler.Write(msg, ty.lastRewardedIndex);
        }

        public static void Write(Message msg, List<ClientSendUserAttendanceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSyncGuildWarHero ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
            //Marshaler.Write(msg, ty.guildSN);
        }

        public static void Write(Message msg, List<ClientSyncGuildWarHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSyncGuildWarLowHero ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
            //Marshaler.Write(msg, ty.guildSN);
        }

        public static void Write(Message msg, List<ClientSyncGuildWarLowHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ClientSyncHeroLeagueHero ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
        }

        public static void Write(Message msg, List<ClientSyncHeroLeagueHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CoinshopDailySlotInfo ty)
        {
            Marshaler.Write(msg, ty.shopID);
            Marshaler.Write(msg, ty.slotIndex);
            Marshaler.Write(msg, ty.buyCount);
        }

        public static void Write(Message msg, List<CoinshopDailySlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CoinShopPeriodBuyLimitType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<CoinShopPeriodBuyLimitType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CoinShopRotationInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.coinShopBuyInfoList);
        }

        public static void Write(Message msg, List<CoinShopRotationInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CoinShopRotationTabInfo ty)
        {
            Marshaler.Write(msg, ty.platinumCoinTab);
            Marshaler.Write(msg, ty.goldCoinTab);
            Marshaler.Write(msg, ty.silverCoinTab);
            Marshaler.Write(msg, ty.friendCoinTab);
        }

        public static void Write(Message msg, List<CoinShopRotationTabInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ConstellationChaosInfo ty)
        {
            Marshaler.Write(msg, ty.itemResultInfo);
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.isRecharge);
        }

        public static void Write(Message msg, List<ConstellationChaosInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ConstellationInfo ty)
        {
            Marshaler.Write(msg, ty.groupId);
            Marshaler.Write(msg, ty.stoneInfoList);
        }

        public static void Write(Message msg, List<ConstellationInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ConstellationManaStoneColorType en)
        {
            msg.Write((sbyte)en);
        }
        public static void Write(Message msg, List<ConstellationManaStoneColorType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ConstellationStoneInfo ty)
        {
            Marshaler.Write(msg, ty.stoneId);
            Marshaler.Write(msg, ty.status);
            Marshaler.Write(msg, ty.isLock);
        }

        public static void Write(Message msg, List<ConstellationStoneInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ConstellationStoneStatus ty)
        {
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.value);
        }

        public static void Write(Message msg, List<ConstellationStoneStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ConstellationSystemInfo ty)
        {
            Marshaler.Write(msg, ty.growthPoint);
            Marshaler.Write(msg, ty.constellationInfoList);
        }

        public static void Write(Message msg, List<ConstellationSystemInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CookingHeroInfo ty)
        {
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.cookingHeroID);
            Marshaler.Write(msg, ty.fellowshipPoint);
            Marshaler.Write(msg, ty.getCount);
            Marshaler.Write(msg, ty.visitType);
        }

        public static void Write(Message msg, List<CookingHeroInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CookingHeroVisit en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<CookingHeroVisit> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CookingInfo ty)
        {
            Marshaler.Write(msg, ty.cookingID);
            Marshaler.Write(msg, ty.cookingPoint);
            Marshaler.Write(msg, ty.remainSec);
        }

        public static void Write(Message msg, List<CookingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CookingRequest ty)
        {
            Marshaler.Write(msg, ty.npcID);
            Marshaler.Write(msg, ty.materialItemIDList);
            Marshaler.Write(msg, ty.cookingCount);
            Marshaler.Write(msg, ty.isImmediately);
        }

        public static void Write(Message msg, List<CookingRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CookingResult ty)
        {
            Marshaler.Write(msg, ty.successType);
            Marshaler.Write(msg, ty.dailyMeliodasCookingCount);
            Marshaler.Write(msg, ty.useMaterialItemInfoList);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.userRecipeInfo);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.cookingCount);
            Marshaler.Write(msg, ty.npcResult);
            Marshaler.Write(msg, ty.isImmediately);
        }

        public static void Write(Message msg, List<CookingResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumeAutoRegisterInfo ty)
        {
            Marshaler.Write(msg, ty.targetSkinID);
            Marshaler.Write(msg, ty.targetCostumeIDList);
            Marshaler.Write(msg, ty.slotIndexList);
        }

        public static void Write(Message msg, List<CostumeAutoRegisterInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumeCraftUpgradeInfo ty)
        {
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.upgrade);
        }

        public static void Write(Message msg, List<CostumeCraftUpgradeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumeCraftUpgradeType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<CostumeCraftUpgradeType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumePackageBuyInfo ty)
        {
            Marshaler.Write(msg, ty.shopID);
            Marshaler.Write(msg, ty.costumePackagePriceType);
        }

        public static void Write(Message msg, List<CostumePackageBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumePackagePriceType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<CostumePackagePriceType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumeResultInfo ty)
        {
            Marshaler.Write(msg, ty.resultCotumeType);
            Marshaler.Write(msg, ty.skinCostumeResultInfo);
            Marshaler.Write(msg, ty.weaponCostumeResultInfo);
            Marshaler.Write(msg, ty.headCostumeResultInfo);
        }

        public static void Write(Message msg, List<CostumeResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumeShopProductType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<CostumeShopProductType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CostumeType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<CostumeType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CreatureNestChallengeRewardStatus en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<CreatureNestChallengeRewardStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CreatureNestColosseumSeasonInfo ty)
        {
            Marshaler.Write(msg, ty.currentSeasonID);
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.initializedItemResultInfoList);
        }

        public static void Write(Message msg, List<CreatureNestColosseumSeasonInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CreatureNestStageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearRequestInfo);
            Marshaler.Write(msg, ty.ingameBattlePointRequest);
            Marshaler.Write(msg, ty.statUserSkinList);
            Marshaler.Write(msg, ty.heroSyncInfoList);
        }

        public static void Write(Message msg, List<CreatureNestStageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CreatureNestStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearResultInfo);
            Marshaler.Write(msg, ty.clientSendCreatureNestStageInfo);
        }

        public static void Write(Message msg, List<CreatureNestStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CreatureNestStagePassiveInfo ty)
        {
            Marshaler.Write(msg, ty.phase);
            Marshaler.Write(msg, ty.passiveID);
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.isNewPassive);
        }

        public static void Write(Message msg, List<CreatureNestStagePassiveInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CreatureNestStageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartRequestInfo);
        }

        public static void Write(Message msg, List<CreatureNestStageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, CreatureNestStageStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartResultInfo);
            Marshaler.Write(msg, ty.userPlayCountEventInfoList);
            Marshaler.Write(msg, ty.paybackEventresultInfo);
            Marshaler.Write(msg, ty.activePassiveSkillInfoList);
            Marshaler.Write(msg, ty.clientSendCreatureNestStageInfo);
        }

        public static void Write(Message msg, List<CreatureNestStageStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DailyFreeGambleInfoClientSend ty)
        {
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.freeCount);
            Marshaler.Write(msg, ty.remainSec);
        }

        public static void Write(Message msg, List<DailyFreeGambleInfoClientSend> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DateTimeKind en)
        {
            msg.Write((int)en);
        }

        public static void Write(Message msg, List<DateTimeKind> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DateTime ty)
        {
            Marshaler.Write(msg, ty.Ticks);
            Marshaler.Write(msg, ty.Kind);
        }

        public static void Write(Message msg, List<DateTime> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DayOfWeek en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<DayOfWeek> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DescentBossEventInfoToClientSend ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.expireDate);
            Marshaler.Write(msg, ty.bossStage);
            Marshaler.Write(msg, ty.rewardIndex);
            Marshaler.Write(msg, ty.currentMissionGroupID);
        }

        public static void Write(Message msg, List<DescentBossEventInfoToClientSend> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyBattleStartResult ty)
        {
            Marshaler.Write(msg, ty.isBuffUsed);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.useItemResultInfo);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.otherTeamInfo);
            Marshaler.Write(msg, ty.usedEventLobbyBuffIdList);
        }

        public static void Write(Message msg, List<DestroyBattleStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyCardOrderInfo ty)
        {
            Marshaler.Write(msg, ty.roundID);
            Marshaler.Write(msg, ty.cardInfoList);
        }

        public static void Write(Message msg, List<DestroyCardOrderInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyCardSelectionInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.roundID);
            Marshaler.Write(msg, ty.selectedCardIndex);
            Marshaler.Write(msg, ty.autoInput);
            Marshaler.Write(msg, ty.targetCampList);
            Marshaler.Write(msg, ty.targetIndexList);
            Marshaler.Write(msg, ty.isMove);
            Marshaler.Write(msg, ty.targetCardIndex);
        }

        public static void Write(Message msg, List<DestroyCardSelectionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyChatMessage ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.chatType);
            Marshaler.Write(msg, ty.stampID);
            Marshaler.Write(msg, ty.message);
            Marshaler.Write(msg, ty.chatDate);
        }

        public static void Write(Message msg, List<DestroyChatMessage> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyChatType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<DestroyChatType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyCheatInfo ty)
        {
            Marshaler.Write(msg, ty.readyUserUSN);
            Marshaler.Write(msg, ty.actionResult);
        }

        public static void Write(Message msg, List<DestroyCheatInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyClearRequest ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.missionRequest);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.isAutoPlay);
            Marshaler.Write(msg, ty.turnCount);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.phase);
        }

        public static void Write(Message msg, List<DestroyClearRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyClearResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.stageId);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.battleSkinResultInfoList);
            Marshaler.Write(msg, ty.npcResultList);
            Marshaler.Write(msg, ty.goldItemResultInfo);
            Marshaler.Write(msg, ty.ownerRewardInfo);
            Marshaler.Write(msg, ty.firstClearItemResultInfo);
            Marshaler.Write(msg, ty.questRewardInfoList);
            Marshaler.Write(msg, ty.defaultRewardInfoList);
            Marshaler.Write(msg, ty.globalDropItemResultInfoList);
            Marshaler.Write(msg, ty.repulseItemResultInfo);
            Marshaler.Write(msg, ty.passiveItemResultInfoList);
            Marshaler.Write(msg, ty.foodBuffItemReslutInfo);
            Marshaler.Write(msg, ty.attackPointRewardResultInfo);
            Marshaler.Write(msg, ty.demonPointItemResultInfo);
            Marshaler.Write(msg, ty.repeatItemResultInfo);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.playCountEventInfoList);
            Marshaler.Write(msg, ty.normalGroupIndex);
            Marshaler.Write(msg, ty.ownerGroupIndex);
            Marshaler.Write(msg, ty.teamMateUSN);
            Marshaler.Write(msg, ty.teamMateNickname);
            Marshaler.Write(msg, ty.isFriend);
            Marshaler.Write(msg, ty.ingameGoldBuffAddValue);
            Marshaler.Write(msg, ty.getBasepointExp);
            Marshaler.Write(msg, ty.usedFoodID);
            Marshaler.Write(msg, ty.basepointInfo);
            Marshaler.Write(msg, ty.userBuffInfo);
            Marshaler.Write(msg, ty.stageInfo);
            Marshaler.Write(msg, ty.updateUserGlobalDropEventInfoList);
            Marshaler.Write(msg, ty.teamMatePlayTitleID);
            Marshaler.Write(msg, ty.adViewRouletteInfo);
            Marshaler.Write(msg, ty.heroPassiveGroupInfoList);
            Marshaler.Write(msg, ty.liveJoinCount);
            Marshaler.Write(msg, ty.usedEventLobbyBuffIdList);
            Marshaler.Write(msg, ty.destroyDiscoverInfo);
        }

        public static void Write(Message msg, List<DestroyClearResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyClearVerificationRequest ty)
        {
            Marshaler.Write(msg, ty.isClear);
            Marshaler.Write(msg, ty.unitStatusList);
            Marshaler.Write(msg, ty.stageInfoString);
            Marshaler.Write(msg, ty.clearDateTime);
            Marshaler.Write(msg, ty.battleEncounter);
        }

        public static void Write(Message msg, List<DestroyClearVerificationRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyClientSendRoomInfo ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.userCount);
            Marshaler.Write(msg, ty.ownerUSN);
            Marshaler.Write(msg, ty.ownerNickname);
            Marshaler.Write(msg, ty.ownerUserExp);
            Marshaler.Write(msg, ty.ownerSkinID);
            Marshaler.Write(msg, ty.remainSecToClose);
        }

        public static void Write(Message msg, List<DestroyClientSendRoomInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyCreateResult ty)
        {
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.stageMonsterInfoList);
            Marshaler.Write(msg, ty.battleEncounter);
        }

        public static void Write(Message msg, List<DestroyCreateResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyDisasterDicoverInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.bossStageClearFlag);
            Marshaler.Write(msg, ty.pickGroupID);
            Marshaler.Write(msg, ty.isClear);
            Marshaler.Write(msg, ty.disasterGaugeInfoList);
            Marshaler.Write(msg, ty.remainSecToClose);
        }

        public static void Write(Message msg, List<DestroyDisasterDicoverInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyDisasterGaugeInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.disasterArea);
            Marshaler.Write(msg, ty.discoverCount);
            Marshaler.Write(msg, ty.gaugePoint);
        }

        public static void Write(Message msg, List<DestroyDisasterGaugeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyDiscoverInfo ty)
        {
            Marshaler.Write(msg, ty.region);
            Marshaler.Write(msg, ty.pickGroupID);
            Marshaler.Write(msg, ty.discoverCount);
            Marshaler.Write(msg, ty.gaugePoint);
            Marshaler.Write(msg, ty.isClear);
            Marshaler.Write(msg, ty.closeDate);
            Marshaler.Write(msg, ty.remainSecToClose);
            Marshaler.Write(msg, ty.highRankDiscoverCount);
            Marshaler.Write(msg, ty.highRankGaugePoint);
            Marshaler.Write(msg, ty.isHighRankClear);
            Marshaler.Write(msg, ty.highRankCloseDate);
            Marshaler.Write(msg, ty.highRankRemainSecToClose);
        }

        public static void Write(Message msg, List<DestroyDiscoverInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyExitRequest ty)
        {
            Marshaler.Write(msg, ty.exitStatus);
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.isAutoPlay);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.phase);
        }

        public static void Write(Message msg, List<DestroyExitRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyExitStatus en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<DestroyExitStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyInviteOption en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<DestroyInviteOption> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyJoinResult ty)
        {
            Marshaler.Write(msg, ty.destroyRoomInfo);
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.stageMonsterInfoList);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.battleEncounter);
        }

        public static void Write(Message msg, List<DestroyJoinResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyLiveJoinInvitation ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.bossID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.ownerUserInfo);
            Marshaler.Write(msg, ty.remainSecToClose);
        }

        public static void Write(Message msg, List<DestroyLiveJoinInvitation> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyLiveJoinUserInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
        }

        public static void Write(Message msg, List<DestroyLiveJoinUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyLobbySyncInfo ty)
        {
            Marshaler.Write(msg, ty.notifyType);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.simpleTeamInfo);
        }

        public static void Write(Message msg, List<DestroyLobbySyncInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyNotifyType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<DestroyNotifyType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyOtherPlayerTeamInfo ty)
        {
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
        }

        public static void Write(Message msg, List<DestroyOtherPlayerTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyReJoinResult ty)
        {
            Marshaler.Write(msg, ty.destroyRoomInfo);
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.stageMonsterInfoList);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.battleEncounter);
        }

        public static void Write(Message msg, List<DestroyReJoinResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyStartResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.ingameSeed);
        }

        public static void Write(Message msg, List<DestroyStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroySyncInfo ty)
        {
            Marshaler.Write(msg, ty.ingameSyncStr);
        }

        public static void Write(Message msg, List<DestroySyncInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyUnitStatus ty)
        {
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.isAlive);
        }

        public static void Write(Message msg, List<DestroyUnitStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyUserProfileInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.skinChangeIDList);
            Marshaler.Write(msg, ty.weaponChangeIDList);
            Marshaler.Write(msg, ty.headChangeIDList);
            Marshaler.Write(msg, ty.skinHeadStyleChangedList);
            Marshaler.Write(msg, ty.bossStageTopClearRegion);
            Marshaler.Write(msg, ty.topClearStoryQuestID);
            Marshaler.Write(msg, ty.userState);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.isAIEnable);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<DestroyUserProfileInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DestroyUserState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<DestroyUserState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DiaBuyInfo ty)
        {
            Marshaler.Write(msg, ty.shopMoneyID);
            Marshaler.Write(msg, ty.buyCount);
        }

        public static void Write(Message msg, List<DiaBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DiaEventSubType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<DiaEventSubType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DisasterQuestClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.questID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.removeItemResultInfoList);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.apRewardInfoList);
        }

        public static void Write(Message msg, List<DisasterQuestClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DropBoxGrade en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<DropBoxGrade> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, DropItemInfo ty)
        {
            Marshaler.Write(msg, ty.dropItemID);
            Marshaler.Write(msg, ty.dropItemCount);
            Marshaler.Write(msg, ty.dropBoxGrade);
            Marshaler.Write(msg, ty.dropItemEvolutionCount);
            Marshaler.Write(msg, ty.dropItemBuffAddCount);
            //Marshaler.Write(msg, ty.dropItemOptionValue);
            //Marshaler.Write(msg, ty.addPassiveIDList);
            //Marshaler.Write(msg, ty.addPassiveValueList);
            //Marshaler.Write(msg, ty.ownerHeroID);
            //Marshaler.Write(msg, ty.heroCoinID);
            //Marshaler.Write(msg, ty.heroCoinCount);
            //Marshaler.Write(msg, ty.skinLevel);
            //Marshaler.Write(msg, ty.skinExp);
            //Marshaler.Write(msg, ty.skinAwaken);
            //Marshaler.Write(msg, ty.skinMaxLevelCount);
            //Marshaler.Write(msg, ty.heroGroupID);
            //Marshaler.Write(msg, ty.costumeGroupID);
            //Marshaler.Write(msg, ty.costumeReplaceItemID);
            //Marshaler.Write(msg, ty.costumeReplaceItemCount);
            //Marshaler.Write(msg, ty.upgradeCount);
            //Marshaler.Write(msg, ty.ownerCostumeItemID);
            //Marshaler.Write(msg, ty.expireDate);
            //Marshaler.Write(msg, ty.weaponOptionMax);
            //Marshaler.Write(msg, ty.selectedWeaponBaseOptionMax);
            //Marshaler.Write(msg, ty.selectedWeaponRandomOptionFlag);
            //Marshaler.Write(msg, ty.selectedWeaponRandomOptionValue);
            //Marshaler.Write(msg, ty.selectedRandomPassiveIDList);
        }

        public static void Write(Message msg, List<DropItemInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EmergencyNoticeInfo ty)
        {
            //Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.fromDate);
            Marshaler.Write(msg, ty.toDate);
            Marshaler.Write(msg, ty.maintenanceStartTime);
            Marshaler.Write(msg, ty.maintenanceEndTime);
            Marshaler.Write(msg, ty.targetOSType);
            Marshaler.Write(msg, ty.isDisplayTime);
            Marshaler.Write(msg, ty.displayTermSec);
            Marshaler.Write(msg, ty.message);
        }

        public static void Write(Message msg, List<EmergencyNoticeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventAttendanceResult ty)
        {
            Marshaler.Write(msg, ty.eventAttendanceInfoList);
            Marshaler.Write(msg, ty.rewardItemInfoList);
            Marshaler.Write(msg, ty.apRewardInfoList);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<EventAttendanceResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventAttendanceType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<EventAttendanceType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventAutoInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.userStageID);
            Marshaler.Write(msg, ty.attackValueLv);
            Marshaler.Write(msg, ty.criticalValueLv);
            Marshaler.Write(msg, ty.criticalRateLv);
            Marshaler.Write(msg, ty.monsterHP);
            Marshaler.Write(msg, ty.rewardItemCount);
            Marshaler.Write(msg, ty.boxState);
            Marshaler.Write(msg, ty.boxSlotUpgrade);
            Marshaler.Write(msg, ty.specialRewardIndex);
            Marshaler.Write(msg, ty.checkUserTime);
            Marshaler.Write(msg, ty.getExtraBoxCount);
        }

        public static void Write(Message msg, List<EventAutoInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventBasepointInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.basepointID);
            Marshaler.Write(msg, ty.lastClearLoopQuestID);
        }

        public static void Write(Message msg, List<EventBasepointInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventBingoExchangeInfo ty)
        {
            Marshaler.Write(msg, ty.exchangeId);
            Marshaler.Write(msg, ty.count);
        }

        public static void Write(Message msg, List<EventBingoExchangeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventBingoExchangeResult ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.userEventBingoInfo);
            Marshaler.Write(msg, ty.getNumberItemInfoList);
            Marshaler.Write(msg, ty.getRewardItemInfoList);
            Marshaler.Write(msg, ty.getAllClearRewardItemInfo);
            Marshaler.Write(msg, ty.itemResultInfoList);
        }

        public static void Write(Message msg, List<EventBingoExchangeResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventBingoRandomNumberResult ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.userEventBingoInfo);
            Marshaler.Write(msg, ty.getNumberItemInfoList);
            Marshaler.Write(msg, ty.getRewardItemInfoList);
            Marshaler.Write(msg, ty.getAllClearRewardItemInfo);
            Marshaler.Write(msg, ty.itemResultInfoList);
        }

        public static void Write(Message msg, List<EventBingoRandomNumberResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventConfirmGameRecordScoreInfo ty)
        {
            Marshaler.Write(msg, ty.boxID);
            Marshaler.Write(msg, ty.boxScore);
            Marshaler.Write(msg, ty.boxRewardFlag);
        }

        public static void Write(Message msg, List<EventConfirmGameRecordScoreInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventConquestAreaClientSendInfo ty)
        {
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isRewarded);
        }

        public static void Write(Message msg, List<EventConquestAreaClientSendInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventConquestProductionDepotClientSendInfo ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.level);
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.upgradeRewardFlag);
            Marshaler.Write(msg, ty.getRewardTime);
            Marshaler.Write(msg, ty.updateDateTimeList);
        }

        public static void Write(Message msg, List<EventConquestProductionDepotClientSendInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventConquestUnitClientSendInfo ty)
        {
            Marshaler.Write(msg, ty.unitID);
            Marshaler.Write(msg, ty.areaID);
        }

        public static void Write(Message msg, List<EventConquestUnitClientSendInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventCookingResult ty)
        {
            Marshaler.Write(msg, ty.successType);
            Marshaler.Write(msg, ty.dailyMeliodasCookingCount);
            Marshaler.Write(msg, ty.useMaterialItemInfoList);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.userRecipeInfo);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.cookingCount);
            Marshaler.Write(msg, ty.npcResult);
            Marshaler.Write(msg, ty.isImmediately);
        }

        public static void Write(Message msg, List<EventCookingResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventDescentBossEventStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.userDescentBossEventInfoForClient);
            Marshaler.Write(msg, ty.clearMissionIDList);
            Marshaler.Write(msg, ty.addPoint);
            Marshaler.Write(msg, ty.addBonusPoint);
        }

        public static void Write(Message msg, List<EventDescentBossEventStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventDiceBaseType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<EventDiceBaseType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventDiceQuestionRewardType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<EventDiceQuestionRewardType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventDisasterDestroyClearInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.firstClearInfo);
        }

        public static void Write(Message msg, List<EventDisasterDestroyClearInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventExchangeCardDetailInfo ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.status);
        }

        public static void Write(Message msg, List<EventExchangeCardDetailInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventExchangeCardInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.resetCount);
            Marshaler.Write(msg, ty.selectCount);
            Marshaler.Write(msg, ty.isCompleteChance);
            Marshaler.Write(msg, ty.remainChanceSelectCount);
            Marshaler.Write(msg, ty.selectedRewardIDList);
            Marshaler.Write(msg, ty.selectedRewardInfoList);
            Marshaler.Write(msg, ty.detailInfoList);
        }

        public static void Write(Message msg, List<EventExchangeCardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventLadderResult ty)
        {
            Marshaler.Write(msg, ty.midRewardIDList);
            Marshaler.Write(msg, ty.topRewardIDList);
            Marshaler.Write(msg, ty.character1RewardIDList);
            Marshaler.Write(msg, ty.character2RewardIDList);
        }

        public static void Write(Message msg, List<EventLadderResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventLobbyBuffInfo ty)
        {
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.remainCount);
            Marshaler.Write(msg, ty.remainSecToRemove);
            //Marshaler.Write(msg, ty.endDateTime);
        }

        public static void Write(Message msg, List<EventLobbyBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventLobbyBuffPointInfo ty)
        {
            Marshaler.Write(msg, ty.count);
            Marshaler.Write(msg, ty.updateTime);
            Marshaler.Write(msg, ty.remainSecondToRecharge);
            Marshaler.Write(msg, ty.mileage);
        }

        public static void Write(Message msg, List<EventLobbyBuffPointInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventLobbyGiftResult ty)
        {
            Marshaler.Write(msg, ty.rewardItemID);
            Marshaler.Write(msg, ty.rewardItemCount);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.eventLobbyGiftInfo);
            Marshaler.Write(msg, ty.ItemResultInfo);
        }

        public static void Write(Message msg, List<EventLobbyGiftResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventLuckyBoxReward ty)
        {
            Marshaler.Write(msg, ty.rewardID);
            Marshaler.Write(msg, ty.rewardedCount);
        }

        public static void Write(Message msg, List<EventLuckyBoxReward> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventMazeBuffInfo ty)
        {
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.level);
        }

        public static void Write(Message msg, List<EventMazeBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventMazeSeasonShopBuyInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.productID);
            Marshaler.Write(msg, ty.dailyBuyCount);
            Marshaler.Write(msg, ty.seasonBuyCount);
        }

        public static void Write(Message msg, List<EventMazeSeasonShopBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventMazeSeasonShopInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.buyPoint);
            Marshaler.Write(msg, ty.remainSeasonShopStartSec);
            Marshaler.Write(msg, ty.remainSeasonShopEndSec);
            Marshaler.Write(msg, ty.currentSeasonShopNeedItemList);
        }

        public static void Write(Message msg, List<EventMazeSeasonShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventMissionClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.chainID);
            Marshaler.Write(msg, ty.chainIndex);
        }

        public static void Write(Message msg, List<EventMissionClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventMoleGameRankInfo ty)
        {
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.redisEventMoleGameRankInfo);
        }

        public static void Write(Message msg, List<EventMoleGameRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventMoleGameRecordScoreInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.recordType);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.rewardFlag);
        }

        public static void Write(Message msg, List<EventMoleGameRecordScoreInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventOpenType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<EventOpenType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventPacketInfo ty)
        {
            Marshaler.Write(msg, ty.serverEventInfoList);
            Marshaler.Write(msg, ty.userExchangeInfoList);
            Marshaler.Write(msg, ty.userWorldAreaStageEventInfoList);
            Marshaler.Write(msg, ty.userFreeStageEventInfoList);
            Marshaler.Write(msg, ty.userPlayCountEventInfoList);
            Marshaler.Write(msg, ty.userGachaEventInfoList);
            Marshaler.Write(msg, ty.userStepupGachaEventInfoList);
            Marshaler.Write(msg, ty.userAttendanceEventInfoList);
            Marshaler.Write(msg, ty.userMissionEventInfoList);
            Marshaler.Write(msg, ty.userListStageEventInfoList);
            Marshaler.Write(msg, ty.userFinalBossStageEventInfoList);
            Marshaler.Write(msg, ty.userDonationEventInfoList);
            Marshaler.Write(msg, ty.userDiaBuyEventInfoList);
            Marshaler.Write(msg, ty.userSeasonPassRankRewardInfoList);
            Marshaler.Write(msg, ty.userPaybackInfoList);
            Marshaler.Write(msg, ty.userGamblePaybackInfoList);
            Marshaler.Write(msg, ty.userGagueEventInfoList);
            Marshaler.Write(msg, ty.userChallengeBossEventInfoClientSendList);
            Marshaler.Write(msg, ty.userBingGachaEventInfoList);
            Marshaler.Write(msg, ty.userGlobalDropEventInfoList);
            Marshaler.Write(msg, ty.userChallengeDestroyEventInfoList);
            Marshaler.Write(msg, ty.userTimeMissionEventInfoList);
            Marshaler.Write(msg, ty.userLobbyGiftEventInfoList);
            Marshaler.Write(msg, ty.userSnsShareEventInfoList);
            Marshaler.Write(msg, ty.userLobbyDecorationEventInfoList);
            Marshaler.Write(msg, ty.userWeeklyStageEventInfoList);
            Marshaler.Write(msg, ty.userBlitzStageEventInfoList);
            Marshaler.Write(msg, ty.userTreasureHuntEventInfoList);
            Marshaler.Write(msg, ty.userKOFBritanniaEventInfoList);
            Marshaler.Write(msg, ty.userExchangeCardEventInfoList);
            Marshaler.Write(msg, ty.userProvisionEventInfoList);
            Marshaler.Write(msg, ty.userPvpWinCountEventInfoList);
            Marshaler.Write(msg, ty.userRandomBoxEventInfoList);
            Marshaler.Write(msg, ty.userRecipeEventInfoList);
            Marshaler.Write(msg, ty.userChapterClearEventInfoList);
            Marshaler.Write(msg, ty.userPredictEventInfoList);
            Marshaler.Write(msg, ty.userDescentBossEventInfoList);
            Marshaler.Write(msg, ty.userAutoEventInfoList);
            Marshaler.Write(msg, ty.userPatrolEventInfoList);
            Marshaler.Write(msg, ty.userCheerEventInfoList);
            Marshaler.Write(msg, ty.userEventDiceInfoList);
            Marshaler.Write(msg, ty.userSkinOneStepEvolutionEventInfoList);
            Marshaler.Write(msg, ty.userEventPuzzleInfoList);
            Marshaler.Write(msg, ty.userStepupMissionEventInfoList);
            Marshaler.Write(msg, ty.userAncientWarInfoList);
            Marshaler.Write(msg, ty.userArtifactWishEventInfoList);
            Marshaler.Write(msg, ty.userGachaWishEventInfoList);
            Marshaler.Write(msg, ty.userMazeEventInfoList);
            Marshaler.Write(msg, ty.userGachaEventOnceInfo);
            Marshaler.Write(msg, ty.useEventMoleGameInfoList);
            Marshaler.Write(msg, ty.userEventLobbyBuffInfoList);
            Marshaler.Write(msg, ty.userEventConquestInfoList);
            Marshaler.Write(msg, ty.userEventLuckybagInfoList);
            Marshaler.Write(msg, ty.userEventGambleBoxInfoList);
            Marshaler.Write(msg, ty.userEventLuckyBoxInfoList);
            Marshaler.Write(msg, ty.userEventRoadInfoList);
            Marshaler.Write(msg, ty.userEventConfirmGameInfoList);
            Marshaler.Write(msg, ty.userEventBalloonDartInfoList);
        }

        public static void Write(Message msg, List<EventPacketInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventPatrolInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            //Marshaler.Write(msg, ty.daySeq);
        }

        public static void Write(Message msg, List<EventPatrolInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventPredictInfo ty)
        {
            //Marshaler.Write(msg, ty.needSave);
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.rewardItemList);
            Marshaler.Write(msg, ty.userTotalScore);
            Marshaler.Write(msg, ty.userDailyCount);
            Marshaler.Write(msg, ty.specialRewardIndex);
        }

        public static void Write(Message msg, List<EventPredictInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventPuzzleBlockScoreInfo ty)
        {
            Marshaler.Write(msg, ty.blockID);
            Marshaler.Write(msg, ty.blockScore);
            Marshaler.Write(msg, ty.blockMatchCount);
        }

        public static void Write(Message msg, List<EventPuzzleBlockScoreInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventQuestClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.questID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.removeItemResultInfoList);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.basepointInfo);
            Marshaler.Write(msg, ty.apRewardInfoList);
            Marshaler.Write(msg, ty.resetQuestIDList);
        }

        public static void Write(Message msg, List<EventQuestClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventRandomBoxChangeType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<EventRandomBoxChangeType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventRandomBoxInfo ty)
        {
            Marshaler.Write(msg, ty.boxType);
            Marshaler.Write(msg, ty.rewardId);
        }

        public static void Write(Message msg, List<EventRandomBoxInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventRandomBoxType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<EventRandomBoxType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventShopProductInfo ty)
        {
            Marshaler.Write(msg, ty.slotIndex);
            Marshaler.Write(msg, ty.productItemID);
            Marshaler.Write(msg, ty.productItemCount);
            Marshaler.Write(msg, ty.productBuyCount);
            Marshaler.Write(msg, ty.productMaxCount);
            Marshaler.Write(msg, ty.priceItemID);
            Marshaler.Write(msg, ty.priceItemCount);
        }

        public static void Write(Message msg, List<EventShopProductInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventTreasureHuntMissionType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<EventTreasureHuntMissionType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, EventTreasureHuntPointType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<EventTreasureHuntPointType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ExtensionStageInfo ty)
        {
            Marshaler.Write(msg, ty.openType);
            Marshaler.Write(msg, ty.remainPlayTimeSec);
            Marshaler.Write(msg, ty.nextOpenTimeSec);
            Marshaler.Write(msg, ty.remainKeyOpenTimeSec);
            Marshaler.Write(msg, ty.dayOfWeek);
            Marshaler.Write(msg, ty.openStageTypeList);
        }

        public static void Write(Message msg, List<ExtensionStageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FameResultInfo ty)
        {
            Marshaler.Write(msg, ty.fameId);
            Marshaler.Write(msg, ty.userFameScoreList);
        }

        public static void Write(Message msg, List<FameResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FameScoreInfo ty)
        {
            //Marshaler.Write(msg, ty.rewardYN);
            Marshaler.Write(msg, ty.checkListType);
            Marshaler.Write(msg, ty.score);
        }

        public static void Write(Message msg, List<FameScoreInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossBattleScoreInfo ty)
        {
            Marshaler.Write(msg, ty.finalBossScoreGroupID);
            Marshaler.Write(msg, ty.missionGroupID);
            Marshaler.Write(msg, ty.battleScoreGroupID);
            Marshaler.Write(msg, ty.vowGroupID);
            Marshaler.Write(msg, ty.vowSelectMax);
            Marshaler.Write(msg, ty.remainSec);
        }

        public static void Write(Message msg, List<FinalBossBattleScoreInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossDifficulty en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<FinalBossDifficulty> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossFameRankingInfo ty)
        {
            //Marshaler.Write(msg, ty.recordTime);
            //Marshaler.Write(msg, ty.scoreReload);
            Marshaler.Write(msg, ty.fameID);
            Marshaler.Write(msg, ty.keywordID);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.ranking);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userRankExp);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.sortType);
        }

        public static void Write(Message msg, List<FinalBossFameRankingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossGroupInfo ty)
        {
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.remainActiveStartSec);
            Marshaler.Write(msg, ty.remainActiveEndSec);
            Marshaler.Write(msg, ty.currentPlayCount);
        }

        public static void Write(Message msg, List<FinalBossGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossSeasonInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.remainSeasonStartSec);
            Marshaler.Write(msg, ty.remainSeasonEndSec);
        }

        public static void Write(Message msg, List<FinalBossSeasonInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossSeasonShopBuyInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.productID);
            Marshaler.Write(msg, ty.dailyBuyCount);
            Marshaler.Write(msg, ty.seasonBuyCount);
        }

        public static void Write(Message msg, List<FinalBossSeasonShopBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossSeasonShopInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.remainSeasonShopStartSec);
            Marshaler.Write(msg, ty.remainSeasonShopEndSec);
            Marshaler.Write(msg, ty.currentSeasonShopNeedItemList);
        }

        public static void Write(Message msg, List<FinalBossSeasonShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossStageResult ty)
        {
            Marshaler.Write(msg, ty.missionPoint);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.vowPoint);
        }

        public static void Write(Message msg, List<FinalBossStageResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossUserRankInfo ty)
        {
            Marshaler.Write(msg, ty.upperRewardRemainRankPoint);
            Marshaler.Write(msg, ty.upperRankRewardRemainRankPoint);
            Marshaler.Write(msg, ty.redisFinalBossRankInfo);
        }

        public static void Write(Message msg, List<FinalBossUserRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FinalBossVowInfo ty)
        {
            Marshaler.Write(msg, ty.stageId);
            Marshaler.Write(msg, ty.vowIdList);
            //Marshaler.Write(msg, ty.expireTime);
        }

        public static void Write(Message msg, List<FinalBossVowInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FirstBuyShopType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<FirstBuyShopType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FoodBuffInfo ty)
        {
            Marshaler.Write(msg, ty.foodItemID);
            Marshaler.Write(msg, ty.useCount);
            Marshaler.Write(msg, ty.isAutoFoodUse);
        }

        public static void Write(Message msg, List<FoodBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendBattleSkinInfo ty)
        {
            Marshaler.Write(msg, ty.battleSkinInfo);
            Marshaler.Write(msg, ty.skinAwaken);
        }

        public static void Write(Message msg, List<FriendBattleSkinInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendCookingEatResult ty)
        {
            Marshaler.Write(msg, ty.isFriend);
            Marshaler.Write(msg, ty.friendCookingEatAlready);
            Marshaler.Write(msg, ty.friendCookingEatTotalCount);
            Marshaler.Write(msg, ty.buffInfo);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<FriendCookingEatResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendGuildInfo ty)
        {
            Marshaler.Write(msg, ty.friendUSN);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildLevel);
            Marshaler.Write(msg, ty.guildEmblemIconID);
            Marshaler.Write(msg, ty.guildEmblemSubIconID);
            Marshaler.Write(msg, ty.guildEmblemBgID);
        }

        public static void Write(Message msg, List<FriendGuildInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendInfo ty)
        {
            Marshaler.Write(msg, ty.friendUSN);
            Marshaler.Write(msg, ty.friendNickname);
            Marshaler.Write(msg, ty.friendWantToSay);
            Marshaler.Write(msg, ty.friendExp);
            Marshaler.Write(msg, ty.friendHeroID);
            Marshaler.Write(msg, ty.friendSkinID);
            Marshaler.Write(msg, ty.friendAfterLoginMin);
            Marshaler.Write(msg, ty.friendState);
            Marshaler.Write(msg, ty.loginState);
            Marshaler.Write(msg, ty.isFriendPointSend);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.friendCookingEatAlready);
            Marshaler.Write(msg, ty.friendRecipeOrderCount);
            Marshaler.Write(msg, ty.playTitleID);
            //Marshaler.Write(msg, ty.cookingEatDailySeq);
            //Marshaler.Write(msg, ty.friendCookingEatDailySeq);
        }

        public static void Write(Message msg, List<FriendInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendLobbyFurnitureInfo ty)
        {
            Marshaler.Write(msg, ty.furnitureGroup);
            Marshaler.Write(msg, ty.furnitureID);
            Marshaler.Write(msg, ty.buffFurnitureID);
        }

        public static void Write(Message msg, List<FriendLobbyFurnitureInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.friendUSN);
            Marshaler.Write(msg, ty.friendNickName);
            Marshaler.Write(msg, ty.friendExp);
            Marshaler.Write(msg, ty.friendCookingEatAlready);
            Marshaler.Write(msg, ty.friendCookingEatTotalCount);
            Marshaler.Write(msg, ty.friendLobbyNpcInfoList);
            Marshaler.Write(msg, ty.friendLobbyVisualType);
            Marshaler.Write(msg, ty.friendLobbyFurnitureInfoList);
            Marshaler.Write(msg, ty.topClearMainStageID);
            Marshaler.Write(msg, ty.storyQuestProgressInfo);
            Marshaler.Write(msg, ty.userTutorialInfoLIst);
            Marshaler.Write(msg, ty.friendMusicInfo);
        }

        public static void Write(Message msg, List<FriendLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendLobbyMusicInfo ty)
        {
            Marshaler.Write(msg, ty.playMusicIndex);
            Marshaler.Write(msg, ty.musicInstrumentID);
            Marshaler.Write(msg, ty.editMusicInfoList);
        }

        public static void Write(Message msg, List<FriendLobbyMusicInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendLobbyNpcInfo ty)
        {
            Marshaler.Write(msg, ty.guestID);
            Marshaler.Write(msg, ty.costumeID);
            Marshaler.Write(msg, ty.subCostumeID);
        }

        public static void Write(Message msg, List<FriendLobbyNpcInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchBattleStartResult ty)
        {
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.isBuffUsed);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.useItemResultInfo);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
        }

        public static void Write(Message msg, List<FriendlyMatchBattleStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchChatMessage ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.chatType);
            Marshaler.Write(msg, ty.stampID);
            Marshaler.Write(msg, ty.message);
            Marshaler.Write(msg, ty.chatDate);
        }

        public static void Write(Message msg, List<FriendlyMatchChatMessage> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchChatType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<FriendlyMatchChatType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchClearRequest ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.missionRequest);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.isAutoPlay);
            Marshaler.Write(msg, ty.turnCount);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.teamInfo);
        }

        public static void Write(Message msg, List<FriendlyMatchClearRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchClearResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.playCountEventInfoList);
            Marshaler.Write(msg, ty.usedFoodID);
        }

        public static void Write(Message msg, List<FriendlyMatchClearResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchClientSendRoomInfo ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.matchMode);
            Marshaler.Write(msg, ty.userCount);
            Marshaler.Write(msg, ty.ownerUSN);
            Marshaler.Write(msg, ty.ownerNickname);
            Marshaler.Write(msg, ty.ownerUserExp);
            Marshaler.Write(msg, ty.ownerSkinID);
            Marshaler.Write(msg, ty.modeID);
        }

        public static void Write(Message msg, List<FriendlyMatchClientSendRoomInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchCreateResult ty)
        {
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.matchMode);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.modeID);
            Marshaler.Write(msg, ty.passiveID);
        }

        public static void Write(Message msg, List<FriendlyMatchCreateResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchInviteOption en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<FriendlyMatchInviteOption> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchJoinResult ty)
        {
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
        }

        public static void Write(Message msg, List<FriendlyMatchJoinResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchObserveStartResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.ingameSeed);
            Marshaler.Write(msg, ty.otherUSN);
            Marshaler.Write(msg, ty.otherTeamIndex);
            Marshaler.Write(msg, ty.simpleTeamInfo);
        }

        public static void Write(Message msg, List<FriendlyMatchObserveStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchStartResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.ingameSeed);
            Marshaler.Write(msg, ty.otherUSN);
            Marshaler.Write(msg, ty.otherTeamIndex);
        }

        public static void Write(Message msg, List<FriendlyMatchStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchSyncInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.foodBuffInfo);
        }

        public static void Write(Message msg, List<FriendlyMatchSyncInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchUserProfileInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.skinChangeIDList);
            Marshaler.Write(msg, ty.weaponChangeIDList);
            Marshaler.Write(msg, ty.headChangeIDList);
            Marshaler.Write(msg, ty.skinHeadStyleChangedList);
            Marshaler.Write(msg, ty.bossStageTopClearRegion);
            Marshaler.Write(msg, ty.topClearStoryQuestID);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<FriendlyMatchUserProfileInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchUserState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<FriendlyMatchUserState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendlyMatchUserStatusInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.status);
        }

        public static void Write(Message msg, List<FriendlyMatchUserStatusInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendRecipeOrderInfo ty)
        {
            Marshaler.Write(msg, ty.slotNumber);
            Marshaler.Write(msg, ty.recipeID);
        }

        public static void Write(Message msg, List<FriendRecipeOrderInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, FriendState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<FriendState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GambleAmountType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GambleAmountType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GambleCheckSumInfo ty)
        {
            Marshaler.Write(msg, ty.gambleGroup);
            Marshaler.Write(msg, ty.hashValue);
        }

        public static void Write(Message msg, List<GambleCheckSumInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GambleGaugeType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GambleGaugeType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GamblePriceType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GamblePriceType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GambleShopBuyRequest ty)
        {
            Marshaler.Write(msg, ty.gambleGroup);
            Marshaler.Write(msg, ty.amountType);
            Marshaler.Write(msg, ty.priceType);
            Marshaler.Write(msg, ty.adViewContentType);
        }

        public static void Write(Message msg, List<GambleShopBuyRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GambleShopInfo ty)
        {
            Marshaler.Write(msg, ty.gambleGroup);
            Marshaler.Write(msg, ty.currentRotationGroup);
            Marshaler.Write(msg, ty.currentRotationGroupRemainSec);
        }

        public static void Write(Message msg, List<GambleShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GambleTimeSwitchLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.currentGambleTimeSwitchID);
            Marshaler.Write(msg, ty.remainSec);
        }

        public static void Write(Message msg, List<GambleTimeSwitchLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GlobalItemDropInfo ty)
        {
            Marshaler.Write(msg, ty.itemID);
            Marshaler.Write(msg, ty.itemCount);
            //Marshaler.Write(msg, ty.index);
        }

        public static void Write(Message msg, List<GlobalItemDropInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildAttendanceResult ty)
        {
            Marshaler.Write(msg, ty.bAttendnaceRewardEnable);
            Marshaler.Write(msg, ty.attendanceCount);
            Marshaler.Write(msg, ty.remainSecToAttendanceEnd);
            Marshaler.Write(msg, ty.prevAttendCount);
            Marshaler.Write(msg, ty.bAttendOccur);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.guildRewardResult);
        }

        public static void Write(Message msg, List<GuildAttendanceResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildAttendanceRewardResult ty)
        {
            Marshaler.Write(msg, ty.addRankPoint);
            Marshaler.Write(msg, ty.addGuildSkillPoint);
            Marshaler.Write(msg, ty.rankPointResult);
            Marshaler.Write(msg, ty.guildSkillPointResult);
            Marshaler.Write(msg, ty.guildExpResult);
            Marshaler.Write(msg, ty.accumdContribution);
            Marshaler.Write(msg, ty.weeklyContribution);
        }

        public static void Write(Message msg, List<GuildAttendanceRewardResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildAttendanceStatus ty)
        {
            Marshaler.Write(msg, ty.isAttendEnable);
            Marshaler.Write(msg, ty.isRewardEnable);
            Marshaler.Write(msg, ty.remainSecToAttendEnd);
        }

        public static void Write(Message msg, List<GuildAttendanceStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBattlePointRegisteredResult ty)
        {
            Marshaler.Write(msg, ty.isRegisteredFlag);
            Marshaler.Write(msg, ty.battlePoint);
        }

        public static void Write(Message msg, List<GuildBattlePointRegisteredResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBattlePointType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildBattlePointType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBossDifficulty en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildBossDifficulty> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBossOffSeasonInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.missionGroupID);
        }

        public static void Write(Message msg, List<GuildBossOffSeasonInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBossOffSeasonRankPoint ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.topRankPoint);
        }

        public static void Write(Message msg, List<GuildBossOffSeasonRankPoint> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBossRankPoint ty)
        {
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.topRankPoint);
            Marshaler.Write(msg, ty.accumRankPoint);
        }

        public static void Write(Message msg, List<GuildBossRankPoint> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBossRankPointReward ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.rewardOrder);
            Marshaler.Write(msg, ty.rewardOrderHell);
        }

        public static void Write(Message msg, List<GuildBossRankPointReward> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBPGuildRankInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildExp);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.masterName);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.prevRank);
            Marshaler.Write(msg, ty.battlePoint);
        }

        public static void Write(Message msg, List<GuildBPGuildRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBPMemberRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.prevRank);
            Marshaler.Write(msg, ty.battlePoint);
        }

        public static void Write(Message msg, List<GuildBPMemberRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildBPUserRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.prevRank);
            Marshaler.Write(msg, ty.battlePoint);
        }

        public static void Write(Message msg, List<GuildBPUserRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildChatMessage ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.chatType);
            Marshaler.Write(msg, ty.message);
            Marshaler.Write(msg, ty.chatTime);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.skinID);
        }

        public static void Write(Message msg, List<GuildChatMessage> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildChatType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildChatType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildDonation ty)
        {
            Marshaler.Write(msg, ty.donationID);
            Marshaler.Write(msg, ty.donationCount);
            Marshaler.Write(msg, ty.needItemIDList);
        }

        public static void Write(Message msg, List<GuildDonation> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildDonationInitializeResult ty)
        {
            Marshaler.Write(msg, ty.useItemResultInfoList);
            Marshaler.Write(msg, ty.guildDonationID);
            Marshaler.Write(msg, ty.guildDonationCount);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<GuildDonationInitializeResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildDonationResult ty)
        {
            Marshaler.Write(msg, ty.useItemResultInfoList);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.currentGuildExp);
            Marshaler.Write(msg, ty.currentAccumGuildContribution);
            Marshaler.Write(msg, ty.currentWeeklyContribution);
            Marshaler.Write(msg, ty.guildDonationID);
            Marshaler.Write(msg, ty.guildDonationCount);
            Marshaler.Write(msg, ty.guildDonationContribution);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<GuildDonationResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildGroupMissionInfo ty)
        {
            Marshaler.Write(msg, ty.missionId);
            Marshaler.Write(msg, ty.progressValue);
        }

        public static void Write(Message msg, List<GuildGroupMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildExp);
            Marshaler.Write(msg, ty.masterUSN);
            Marshaler.Write(msg, ty.description);
            Marshaler.Write(msg, ty.noticeTitle);
            Marshaler.Write(msg, ty.notice);
            Marshaler.Write(msg, ty.showNotice);
            Marshaler.Write(msg, ty.emblemIconID);
            Marshaler.Write(msg, ty.emblemSubIconID);
            Marshaler.Write(msg, ty.emblemBgID);
            Marshaler.Write(msg, ty.guildPoint);
            Marshaler.Write(msg, ty.skillPoint);
            Marshaler.Write(msg, ty.joiningApprovalType);
            Marshaler.Write(msg, ty.joiningLevelCondition);
            Marshaler.Write(msg, ty.memberCount);
            Marshaler.Write(msg, ty.applicantCount);
            Marshaler.Write(msg, ty.masterName);
            Marshaler.Write(msg, ty.attendSeq);
            Marshaler.Write(msg, ty.attendCount);
            Marshaler.Write(msg, ty.prevAttendCount);
            Marshaler.Write(msg, ty.skillUseList);
            Marshaler.Write(msg, ty.invitationGrade);
            Marshaler.Write(msg, ty.guildWarSeedSeason);
            Marshaler.Write(msg, ty.expBoostStack);
            Marshaler.Write(msg, ty.joiningBattlePoint);
            Marshaler.Write(msg, ty.joiningCurrentConstellationGroup);
            Marshaler.Write(msg, ty.recruitNotice);
            Marshaler.Write(msg, ty.recruitEndRemainSec);
            //Marshaler.Write(msg, ty.level);
            //Marshaler.Write(msg, ty.lastGuildMissionResetSeq);
            //Marshaler.Write(msg, ty.lastGuildMissionResetExp);
            //Marshaler.Write(msg, ty.languageType);
            //Marshaler.Write(msg, ty.expBoostStackUpdateSeq);
            //Marshaler.Write(msg, ty.recruitExpireTime);
            //Marshaler.Write(msg, ty.currentAPWeekResetSEQ);
        }

        public static void Write(Message msg, List<GuildInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildInvitationState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildInvitationState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildJoiningApprovalType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildJoiningApprovalType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildMemberGrade en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildMemberGrade> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildMemberInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.remainSecToJoinEnable);
            Marshaler.Write(msg, ty.joinEnableTime);
            Marshaler.Write(msg, ty.joinTime);
            Marshaler.Write(msg, ty.afterLoginMin);
            Marshaler.Write(msg, ty.accumdContribution);
            Marshaler.Write(msg, ty.weeklyContribution);
            Marshaler.Write(msg, ty.prevWeeklyContirbution);
            Marshaler.Write(msg, ty.weeklySeq);
            Marshaler.Write(msg, ty.loginState);
            Marshaler.Write(msg, ty.lastAttendTime);
            Marshaler.Write(msg, ty.bTodayAttend);
            Marshaler.Write(msg, ty.stageClearCount);
            Marshaler.Write(msg, ty.joinTimeWeeklySeq);
            Marshaler.Write(msg, ty.playTitleID);
            Marshaler.Write(msg, ty.joinBattlePoint);
            Marshaler.Write(msg, ty.joinConstellationGroup);
            Marshaler.Write(msg, ty.guildOrderMissionMileageRewardIndex);
            //Marshaler.Write(msg, ty.attendRewardTime);
            //Marshaler.Write(msg, ty.netmarblePID);
        }

        public static void Write(Message msg, List<GuildMemberInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildMemberRankInfo ty)
        {
            Marshaler.Write(msg, ty.USN);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinCostumeGroupID);
            Marshaler.Write(msg, ty.weaponCostumeGroupID);
            Marshaler.Write(msg, ty.headCostumeGroupID);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
        }

        public static void Write(Message msg, List<GuildMemberRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildMissionInfo ty)
        {
            Marshaler.Write(msg, ty.guildMissionID);
            Marshaler.Write(msg, ty.progressValue);
            Marshaler.Write(msg, ty.isReward);
        }

        public static void Write(Message msg, List<GuildMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildMissionRewardResult ty)
        {
            Marshaler.Write(msg, ty.rewardGuildMissionIDList);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.currentGuildExp);
        }

        public static void Write(Message msg, List<GuildMissionRewardResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildNoticeInfo ty)
        {
            Marshaler.Write(msg, ty.showNotice);
            Marshaler.Write(msg, ty.noticeTitle);
            Marshaler.Write(msg, ty.noticeMessage);
        }

        public static void Write(Message msg, List<GuildNoticeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildOrderMissionInfo ty)
        {
            Marshaler.Write(msg, ty.missionID);
            Marshaler.Write(msg, ty.progress);
        }

        public static void Write(Message msg, List<GuildOrderMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildOrderMissionInfoClientSend ty)
        {
            Marshaler.Write(msg, ty.guildOrderMissionInfoList);
            Marshaler.Write(msg, ty.clearGuildOrderMissionCount);
        }

        public static void Write(Message msg, List<GuildOrderMissionInfoClientSend> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildOrderMissionStatus en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<GuildOrderMissionStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRankRedisInfo ty)
        {
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.totolRankUpCount);
        }

        public static void Write(Message msg, List<GuildRankRedisInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRankRewardInfo ty)
        {
            Marshaler.Write(msg, ty.guildRankInfo);
            Marshaler.Write(msg, ty.rewardItemInfoList);
        }

        public static void Write(Message msg, List<GuildRankRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRecruitSearchType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildRecruitSearchType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRewardResult ty)
        {
            Marshaler.Write(msg, ty.addRankPoint);
            Marshaler.Write(msg, ty.addRankBonusPoint);
            Marshaler.Write(msg, ty.guildBossBonusPoint);
            Marshaler.Write(msg, ty.addGuildSkillPoint);
            Marshaler.Write(msg, ty.addGuildExp);
            Marshaler.Write(msg, ty.guildSkillPointResult);
            Marshaler.Write(msg, ty.rankPointResult);
            Marshaler.Write(msg, ty.stageClearCountResult);
            Marshaler.Write(msg, ty.guildExpResult);
            Marshaler.Write(msg, ty.accumdContribution);
            Marshaler.Write(msg, ty.weeklyContribution);
            Marshaler.Write(msg, ty.addGuildBoostExp);
        }

        public static void Write(Message msg, List<GuildRewardResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRoomInfo ty)
        {
            Marshaler.Write(msg, ty.resultCode);
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.guildRoomMenberInfoList);
            Marshaler.Write(msg, ty.guildMemberInfo);
            Marshaler.Write(msg, ty.guildRankStartRemainSec);
            Marshaler.Write(msg, ty.guildRankEndRemainSec);
            Marshaler.Write(msg, ty.guildRankRewardInfo);
            Marshaler.Write(msg, ty.guildBossWeekRewardList);
            Marshaler.Write(msg, ty.guildMemberRanker);
            Marshaler.Write(msg, ty.registerTeamBattlePoint);
            Marshaler.Write(msg, ty.registerAccountBattlePoint);
            Marshaler.Write(msg, ty.guildWarRankRewardInfo);
            Marshaler.Write(msg, ty.prevSeasonGuildWarLeagueRankInfoList);
            Marshaler.Write(msg, ty.guildWarLowRewardInfo);
        }

        public static void Write(Message msg, List<GuildRoomInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRoomMemberEmojiState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildRoomMemberEmojiState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRoomMemberInfo ty)
        {
            Marshaler.Write(msg, ty.userUSN);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinCostumeGroupID);
            Marshaler.Write(msg, ty.weaponCostumeGroupID);
            Marshaler.Write(msg, ty.headCostumeGroupID);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
            Marshaler.Write(msg, ty.point);
            Marshaler.Write(msg, ty.emojiState);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<GuildRoomMemberInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRoomMemberPointInfo ty)
        {
            Marshaler.Write(msg, ty.userUSN);
            Marshaler.Write(msg, ty.point);
        }

        public static void Write(Message msg, List<GuildRoomMemberPointInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRoomMemberState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildRoomMemberState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRoomMoveInfo ty)
        {
            Marshaler.Write(msg, ty.targetUSN);
            Marshaler.Write(msg, ty.x);
            Marshaler.Write(msg, ty.z);
            Marshaler.Write(msg, ty.prevState);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.motion);
        }

        public static void Write(Message msg, List<GuildRoomMoveInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildRoomPoint ty)
        {
            Marshaler.Write(msg, ty.x);
            Marshaler.Write(msg, ty.z);
            Marshaler.Write(msg, ty.prevState);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.motion);
        }

        public static void Write(Message msg, List<GuildRoomPoint> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildSetupInfo ty)
        {
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.description);
            Marshaler.Write(msg, ty.noticeTitle);
            Marshaler.Write(msg, ty.notice);
            Marshaler.Write(msg, ty.showNotice);
            Marshaler.Write(msg, ty.emblemIconID);
            Marshaler.Write(msg, ty.emblemBgID);
            Marshaler.Write(msg, ty.emblemSubIconID);
            Marshaler.Write(msg, ty.joiningApprovalType);
            Marshaler.Write(msg, ty.joiningLevelCondition);
            Marshaler.Write(msg, ty.invitationGrade);
            Marshaler.Write(msg, ty.joiningBattlePoint);
            Marshaler.Write(msg, ty.joiningCurrentConstellationGroup);
            Marshaler.Write(msg, ty.recruitNotice);
        }

        public static void Write(Message msg, List<GuildSetupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildSkillInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.skillID);
            Marshaler.Write(msg, ty.slotNo);
        }

        public static void Write(Message msg, List<GuildSkillInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildSkillUseInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.guildExp);
            Marshaler.Write(msg, ty.skillPoint);
            Marshaler.Write(msg, ty.skillUseList);
        }

        public static void Write(Message msg, List<GuildSkillUseInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarAreaInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.areaID);
            Marshaler.Write(msg, ty.deployUSN);
            Marshaler.Write(msg, ty.deployTeamCount);
            Marshaler.Write(msg, ty.isInBattle);
            Marshaler.Write(msg, ty.loseTeamCount);
            //Marshaler.Write(msg, ty.regionID);
            //Marshaler.Write(msg, ty.lastOffenceGuildSN);
            //Marshaler.Write(msg, ty.lastOffenceUSN);
            //Marshaler.Write(msg, ty.lastBattleStartTime);
        }

        public static void Write(Message msg, List<GuildWarAreaInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarAreaPassiveType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildWarAreaPassiveType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarBattlePrepareInfo ty)
        {
            Marshaler.Write(msg, ty.defenceBMSlotCount);
            Marshaler.Write(msg, ty.squadBMSlotCount);
            Marshaler.Write(msg, ty.defenceUserTeamList);
            Marshaler.Write(msg, ty.guildWarSquadSlotList);
            Marshaler.Write(msg, ty.guildWarDefenceTeamInfoList);
            Marshaler.Write(msg, ty.guildWarDefenceTeamBuffList);
        }

        public static void Write(Message msg, List<GuildWarBattlePrepareInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarBattleRecord ty)
        {
            Marshaler.Write(msg, ty.recordID);
            Marshaler.Write(msg, ty.defenceTeamIndex);
            Marshaler.Write(msg, ty.winGuildSerial);
            Marshaler.Write(msg, ty.battleEnd);
            Marshaler.Write(msg, ty.attackerGuildSerial);
            Marshaler.Write(msg, ty.attackerNickame);
            Marshaler.Write(msg, ty.attackSkinIDList);
            Marshaler.Write(msg, ty.deadHeroIDList);
            //Marshaler.Write(msg, ty.guildSerial);
            //Marshaler.Write(msg, ty.areaID);
            //Marshaler.Write(msg, ty.battleNumber);
            //Marshaler.Write(msg, ty.attackerUSN);
        }

        public static void Write(Message msg, List<GuildWarBattleRecord> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarBattleSettingChangeInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.nickName);
        }

        public static void Write(Message msg, List<GuildWarBattleSettingChangeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarDefenceTeamInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
        }

        public static void Write(Message msg, List<GuildWarDefenceTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarHero ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
            Marshaler.Write(msg, ty.isUsed);
        }

        public static void Write(Message msg, List<GuildWarHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLeagueRankInfo ty)
        {
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.guildWarRankInfoList);
        }

        public static void Write(Message msg, List<GuildWarLeagueRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.currentGuildWarScheduleInfo);
            Marshaler.Write(msg, ty.nextGuildWarScheduleInfo);
            Marshaler.Write(msg, ty.guildInfoList);
            Marshaler.Write(msg, ty.guildWarLeagueRankInfoList);
            Marshaler.Write(msg, ty.guildWarVersusRecordList);
            Marshaler.Write(msg, ty.guildWarVersusScheduleInfoList);
            Marshaler.Write(msg, ty.nextSeasonRemainSec);
            Marshaler.Write(msg, ty.guildWarUserSquadInfo);
            Marshaler.Write(msg, ty.isGuildWarPlayable);
            //Marshaler.Write(msg, ty.currentSeasonGuildWarLeagueRankInfo);
            //Marshaler.Write(msg, ty.prevSeasonGuildWarLeagueRankInfo);
        }

        public static void Write(Message msg, List<GuildWarLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowAreaInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.areaID);
            Marshaler.Write(msg, ty.deployCount);
            Marshaler.Write(msg, ty.loseCount);
        }

        public static void Write(Message msg, List<GuildWarLowAreaInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowBattleRecord ty)
        {
            Marshaler.Write(msg, ty.recordID);
            Marshaler.Write(msg, ty.defenceTeamIndex);
            Marshaler.Write(msg, ty.winGuildSerial);
            Marshaler.Write(msg, ty.battleEnd);
            Marshaler.Write(msg, ty.attackerGuildSerial);
            Marshaler.Write(msg, ty.attackerNickame);
            Marshaler.Write(msg, ty.attackSkinIDList);
            //Marshaler.Write(msg, ty.guildSerial);
            //Marshaler.Write(msg, ty.defenceUSN);
            //Marshaler.Write(msg, ty.attackerUSN);
        }

        public static void Write(Message msg, List<GuildWarLowBattleRecord> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowDefenceTeamInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
        }

        public static void Write(Message msg, List<GuildWarLowDefenceTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowHero ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
            Marshaler.Write(msg, ty.isUsed);
        }

        public static void Write(Message msg, List<GuildWarLowHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowInfo ty)
        {
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.tier);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.opponentGuildSN);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildExp);
            Marshaler.Write(msg, ty.emblemIconID);
            Marshaler.Write(msg, ty.emblemSubIconID);
            Marshaler.Write(msg, ty.emblemBgID);
            Marshaler.Write(msg, ty.guildAccountBattlePoint);
            Marshaler.Write(msg, ty.applyDate);
        }

        public static void Write(Message msg, List<GuildWarLowInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowLobbyInfo ty)
        {
            Marshaler.Write(msg, ty.currentScheduleInfo);
            Marshaler.Write(msg, ty.nextScheduleInfo);
            Marshaler.Write(msg, ty.guildInfo);
            Marshaler.Write(msg, ty.opponentGuildInfo);
            Marshaler.Write(msg, ty.nextSeasonRemainSec);
            Marshaler.Write(msg, ty.lastSeason);
            Marshaler.Write(msg, ty.tier);
            Marshaler.Write(msg, ty.attackCount);
            Marshaler.Write(msg, ty.receivedPlayRewardID);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.opponentBattlePoint);
            Marshaler.Write(msg, ty.isLate);
            Marshaler.Write(msg, ty.registAccountBPGuildMemberCount);
            Marshaler.Write(msg, ty.saveDefenceTeamGuildMemberCount);
            Marshaler.Write(msg, ty.useHeroIDList);
            Marshaler.Write(msg, ty.areaInfoList);
            Marshaler.Write(msg, ty.areaID);
        }

        public static void Write(Message msg, List<GuildWarLowLobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowMemberInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.areaID);
            Marshaler.Write(msg, ty.defenceTeamCount);
            Marshaler.Write(msg, ty.loseDefenceTeamCount);
            Marshaler.Write(msg, ty.isInBattle);
            Marshaler.Write(msg, ty.defenceTeamPower);
            Marshaler.Write(msg, ty.userRank);
            Marshaler.Write(msg, ty.userNickName);
            Marshaler.Write(msg, ty.accountBattlePoint);
            //Marshaler.Write(msg, ty.attackCount);
            //Marshaler.Write(msg, ty.receivedPlayRewardID);
            //Marshaler.Write(msg, ty.lastAttackGuildSerial);
            //Marshaler.Write(msg, ty.lastAttackDefenceUSN);
            //Marshaler.Write(msg, ty.lastOffenceGuildSN);
            //Marshaler.Write(msg, ty.lastOffenceUSN);
            //Marshaler.Write(msg, ty.lastBattleStartTime);
        }

        public static void Write(Message msg, List<GuildWarLowMemberInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowRewardInfo ty)
        {
            Marshaler.Write(msg, ty.winRewardItemInfoList);
            Marshaler.Write(msg, ty.pointRewardItemInfoList);
            Marshaler.Write(msg, ty.tier);
            Marshaler.Write(msg, ty.guildInfo);
            Marshaler.Write(msg, ty.opponentGuildInfo);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.opponentBattlePoint);
            Marshaler.Write(msg, ty.isRewardExist);
        }

        public static void Write(Message msg, List<GuildWarLowRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowScheduleInfo ty)
        {
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.guildWarLowScheduleType);
            Marshaler.Write(msg, ty.remainSec);
        }

        public static void Write(Message msg, List<GuildWarLowScheduleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowScheduleType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildWarLowScheduleType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowStageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearRequestInfo);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.attackGuildSN);
            Marshaler.Write(msg, ty.attackAreaID);
            Marshaler.Write(msg, ty.attackUSN);
            Marshaler.Write(msg, ty.clientSyncGuildWarLowHeroList);
        }

        public static void Write(Message msg, List<GuildWarLowStageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearResultInfo);
            Marshaler.Write(msg, ty.addAreaScore);
            Marshaler.Write(msg, ty.addDeployScore);
            Marshaler.Write(msg, ty.occupationApply);
            Marshaler.Write(msg, ty.nextDefenceTeamIndex);
            Marshaler.Write(msg, ty.attackCount);
            Marshaler.Write(msg, ty.isContinue);
        }

        public static void Write(Message msg, List<GuildWarLowStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowStageRejoinResultInfo ty)
        {
            Marshaler.Write(msg, ty.guildWarLowDefenceTeamInfo);
            Marshaler.Write(msg, ty.defenceGuildWarLowHeroList);
            Marshaler.Write(msg, ty.attackGuildWarLowHeroList);
            Marshaler.Write(msg, ty.useHeroIDList);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.defenceGuildInfo);
            Marshaler.Write(msg, ty.defencePlayTitleID);
            Marshaler.Write(msg, ty.defenceUserNickName);
            Marshaler.Write(msg, ty.nextDefenceTeamIndex);
            Marshaler.Write(msg, ty.guildWarLowPassiveSkillIDList);
            Marshaler.Write(msg, ty.attackCount);
            Marshaler.Write(msg, ty.isContinue);
        }

        public static void Write(Message msg, List<GuildWarLowStageRejoinResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowStageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartRequestInfo);
            Marshaler.Write(msg, ty.attackGuildSN);
            Marshaler.Write(msg, ty.attackAreaID);
            Marshaler.Write(msg, ty.attackUSN);
            Marshaler.Write(msg, ty.attackTeamIndex);
            Marshaler.Write(msg, ty.useSkinIDList);
            Marshaler.Write(msg, ty.isContinue);
        }

        public static void Write(Message msg, List<GuildWarLowStageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarLowStageStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartResultInfo);
            Marshaler.Write(msg, ty.guildWarLowDefenceTeamInfo);
            Marshaler.Write(msg, ty.defenceGuildWarLowHeroList);
            Marshaler.Write(msg, ty.defencePlayTitleID);
            Marshaler.Write(msg, ty.defenceUserNickName);
            Marshaler.Write(msg, ty.attackGuildWarLowHeroList);
            Marshaler.Write(msg, ty.guildWarLowPassiveSkillIDList);
            Marshaler.Write(msg, ty.playRewardItemResultInfo);
            Marshaler.Write(msg, ty.attackAreaID);
        }

        public static void Write(Message msg, List<GuildWarLowStageStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarMagicBuffInfo ty)
        {
            Marshaler.Write(msg, ty.passiveType);
            Marshaler.Write(msg, ty.passiveID);
        }

        public static void Write(Message msg, List<GuildWarMagicBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarMemberInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.guildWarSeasonKillCount);
            Marshaler.Write(msg, ty.guildWarAccumKillCount);
            Marshaler.Write(msg, ty.squadUseHeroCount);
            Marshaler.Write(msg, ty.squadHeroCount);
            //Marshaler.Write(msg, ty.lastSeason);
            //Marshaler.Write(msg, ty.lastAttackGuildSerial);
            //Marshaler.Write(msg, ty.lastAttackAreaID);
            //Marshaler.Write(msg, ty.defenceBMSlotCount);
            //Marshaler.Write(msg, ty.squadBMSlotCount);
        }

        public static void Write(Message msg, List<GuildWarMemberInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarRankInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.winCount);
            Marshaler.Write(msg, ty.drawCount);
            Marshaler.Write(msg, ty.loseCount);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildExp);
            Marshaler.Write(msg, ty.emblemIconID);
            Marshaler.Write(msg, ty.emblemSubIconID);
            Marshaler.Write(msg, ty.emblemBgID);
            Marshaler.Write(msg, ty.totalScore);
            Marshaler.Write(msg, ty.totalGuildAccountBattlePoint);
        }

        public static void Write(Message msg, List<GuildWarRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarRankRewardInfo ty)
        {
            Marshaler.Write(msg, ty.guildWarRankInfo);
            Marshaler.Write(msg, ty.rewardItemInfoList);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.costumeRewardItemInfoList);
            Marshaler.Write(msg, ty.isCostumeReceived);
            Marshaler.Write(msg, ty.costumeReceiveExpireDate);
            Marshaler.Write(msg, ty.winRewardItemInfoList);
        }

        public static void Write(Message msg, List<GuildWarRankRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarRecommandDefenceTeamInfo ty)
        {
            Marshaler.Write(msg, ty.teamNumber);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.fateSkinIDList);
        }

        public static void Write(Message msg, List<GuildWarRecommandDefenceTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarRegionInfo ty)
        {
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.regionID);
            Marshaler.Write(msg, ty.bonusScore);
            Marshaler.Write(msg, ty.deployAreaCount);
            Marshaler.Write(msg, ty.loseAreaCount);
            Marshaler.Write(msg, ty.magicAreaID);
            Marshaler.Write(msg, ty.magicBuffID);
            Marshaler.Write(msg, ty.attackPriority);
        }

        public static void Write(Message msg, List<GuildWarRegionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarScheduleInfo ty)
        {
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.guildWarScheduleType);
            Marshaler.Write(msg, ty.battleNumber);
            Marshaler.Write(msg, ty.remainSec);
        }

        public static void Write(Message msg, List<GuildWarScheduleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarScheduleType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<GuildWarScheduleType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarSelectionInfo ty)
        {
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.guildSNList);
        }

        public static void Write(Message msg, List<GuildWarSelectionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarSquadSlot ty)
        {
            Marshaler.Write(msg, ty.slot);
            Marshaler.Write(msg, ty.heroID);
            //Marshaler.Write(msg, ty.usn);
        }

        public static void Write(Message msg, List<GuildWarSquadSlot> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarStageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearRequestInfo);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.battleNumber);
            Marshaler.Write(msg, ty.AttackGuildSN);
            Marshaler.Write(msg, ty.AttackAreaID);
            Marshaler.Write(msg, ty.clientSyncGuildWarHeroList);
            Marshaler.Write(msg, ty.killCount);
        }

        public static void Write(Message msg, List<GuildWarStageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearResultInfo);
            Marshaler.Write(msg, ty.addAreaScore);
            Marshaler.Write(msg, ty.addRegionScore);
            Marshaler.Write(msg, ty.addRegionBonusScore);
            Marshaler.Write(msg, ty.occupationApply);
            Marshaler.Write(msg, ty.updatedGuildWarVersusRecord);
            Marshaler.Write(msg, ty.offenceGuildWarVersusRecord);
            Marshaler.Write(msg, ty.nextDefenceTeamIndex);
        }

        public static void Write(Message msg, List<GuildWarStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarStageRejoinResultInfo ty)
        {
            Marshaler.Write(msg, ty.guildWarDefenceTeamInfo);
            Marshaler.Write(msg, ty.defenceGuildWarHeroList);
            Marshaler.Write(msg, ty.attackGuildWarHeroList);
            Marshaler.Write(msg, ty.useHeroIDList);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.battleNumber);
            Marshaler.Write(msg, ty.defenceGuildInfo);
            Marshaler.Write(msg, ty.defencePlayTitleID);
            Marshaler.Write(msg, ty.defenceUserNickName);
            Marshaler.Write(msg, ty.nextDefenceTeamIndex);
            Marshaler.Write(msg, ty.guildWarDefenceTeamBuffList);
            Marshaler.Write(msg, ty.guildWarAttackTeamBuffList);
            Marshaler.Write(msg, ty.guildWarMagicBuffInfo);
            //Marshaler.Write(msg, ty.guildWarRegionInfo);
        }

        public static void Write(Message msg, List<GuildWarStageRejoinResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarStageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartRequestInfo);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.battleNumber);
            Marshaler.Write(msg, ty.AttackGuildSN);
            Marshaler.Write(msg, ty.AttackAreaID);
            Marshaler.Write(msg, ty.AttackUSN);
            Marshaler.Write(msg, ty.AttackTeamIndex);
            Marshaler.Write(msg, ty.useSkinIDList);
            Marshaler.Write(msg, ty.isContinue);
        }

        public static void Write(Message msg, List<GuildWarStageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarStageStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartResultInfo);
            Marshaler.Write(msg, ty.guildWarDefenceTeamInfo);
            Marshaler.Write(msg, ty.defenceGuildWarHeroList);
            Marshaler.Write(msg, ty.guildWarDefenceTeamBuffList);
            Marshaler.Write(msg, ty.guildWarAttackTeamBuffList);
            Marshaler.Write(msg, ty.useGuildWarBuffItemResultInfoList);
            Marshaler.Write(msg, ty.attackGuildWarHeroList);
            Marshaler.Write(msg, ty.guildWarMagicBuffInfo);
        }

        public static void Write(Message msg, List<GuildWarStageStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarTeamBuff ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.slot);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.buffItemID);
            Marshaler.Write(msg, ty.buffItemCount);
            Marshaler.Write(msg, ty.activeYN);
        }

        public static void Write(Message msg, List<GuildWarTeamBuff> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarTeamBuffRegist ty)
        {
            Marshaler.Write(msg, ty.slot);
            Marshaler.Write(msg, ty.buffItemID);
            Marshaler.Write(msg, ty.buffItemCount);
        }

        public static void Write(Message msg, List<GuildWarTeamBuffRegist> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarUserSquadInfo ty)
        {
            Marshaler.Write(msg, ty.guildWarSquadSlotList);
        }

        public static void Write(Message msg, List<GuildWarUserSquadInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarVersusInfo ty)
        {
            Marshaler.Write(msg, ty.leftGuildSN);
            Marshaler.Write(msg, ty.rightGuildSN);
        }

        public static void Write(Message msg, List<GuildWarVersusInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarVersusRecord ty)
        {
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.versusGuildSN);
            Marshaler.Write(msg, ty.battleNumber);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildExp);
            Marshaler.Write(msg, ty.emblemIconID);
            Marshaler.Write(msg, ty.emblemSubIconID);
            Marshaler.Write(msg, ty.emblemBgID);
            Marshaler.Write(msg, ty.guildAccountBattlePoint);
        }

        public static void Write(Message msg, List<GuildWarVersusRecord> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarVersusScheduleInfo ty)
        {
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.matchNumber);
            Marshaler.Write(msg, ty.guildWarVersusInfoList);
        }

        public static void Write(Message msg, List<GuildWarVersusScheduleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, GuildWarWorldMapInfo ty)
        {
            Marshaler.Write(msg, ty.guildMemberInfoList);
            Marshaler.Write(msg, ty.guildWarMemberInfoList);
            Marshaler.Write(msg, ty.guildWarRegionBonusScoreList);
            Marshaler.Write(msg, ty.guildWarAreaInfoList);
            Marshaler.Write(msg, ty.guildWarDefenceTeamInfoList);
            Marshaler.Write(msg, ty.guildWarHeroList);
            Marshaler.Write(msg, ty.guildWarDefenceTeamBuffList);
        }

        public static void Write(Message msg, List<GuildWarWorldMapInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HawkStepInfo ty)
        {
            Marshaler.Write(msg, ty.Index);
            Marshaler.Write(msg, ty.fakeStep);
        }

        public static void Write(Message msg, List<HawkStepInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroAliveStatus en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<HeroAliveStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroKindType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<HeroKindType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueBuffInfo ty)
        {
            Marshaler.Write(msg, ty.passiveID);
            Marshaler.Write(msg, ty.remainEndSec);
        }

        public static void Write(Message msg, List<HeroLeagueBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueHero ty)
        {
            Marshaler.Write(msg, ty.userGroup);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
            Marshaler.Write(msg, ty.attackUserGroup);
        }

        public static void Write(Message msg, List<HeroLeagueHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueRewardInfo ty)
        {
            Marshaler.Write(msg, ty.isRewarded);
            Marshaler.Write(msg, ty.rewardID);
            Marshaler.Write(msg, ty.useTeamCount);
        }

        public static void Write(Message msg, List<HeroLeagueRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueScoreRewardInfo ty)
        {
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.rewardIndex);
        }

        public static void Write(Message msg, List<HeroLeagueScoreRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueSeasonInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.remainSeasonStartSec);
            Marshaler.Write(msg, ty.remainSeasonEndSec);
        }

        public static void Write(Message msg, List<HeroLeagueSeasonInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueSeasonShopBuyInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.productID);
            Marshaler.Write(msg, ty.seasonBuyCount);
        }

        public static void Write(Message msg, List<HeroLeagueSeasonShopBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueSeasonShopInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.remainSeasonShopStartSec);
            Marshaler.Write(msg, ty.remainSeasonShopEndSec);
            Marshaler.Write(msg, ty.currentSeasonShopNeedItemList);
        }

        public static void Write(Message msg, List<HeroLeagueSeasonShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueStageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearRequestInfo);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.isGiveUp);
            Marshaler.Write(msg, ty.ClientSyncHeroLeagueHeroList);
        }

        public static void Write(Message msg, List<HeroLeagueStageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueStageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartRequestInfo);
            Marshaler.Write(msg, ty.season);
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.targetUserGroup);
            Marshaler.Write(msg, ty.teamNumber);
            Marshaler.Write(msg, ty.useSkinIDList);
            Marshaler.Write(msg, ty.isContinue);
        }

        public static void Write(Message msg, List<HeroLeagueStageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, HeroLeagueUserGroup ty)
        {
            Marshaler.Write(msg, ty.userGroup);
            Marshaler.Write(msg, ty.teamNumber);
            Marshaler.Write(msg, ty.useTeamCount);
        }

        public static void Write(Message msg, List<HeroLeagueUserGroup> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, IngameBattlePointRequest ty)
        {
            Marshaler.Write(msg, ty.skillMoveCount);
            Marshaler.Write(msg, ty.skillUnusedCount);
            Marshaler.Write(msg, ty.skillCombineCount);
            Marshaler.Write(msg, ty.debuffApplyCount);
            Marshaler.Write(msg, ty.buffApplyCount);
            Marshaler.Write(msg, ty.aliveHeroCount);
            Marshaler.Write(msg, ty.remainHP);
            Marshaler.Write(msg, ty.criticalOccurCount);
            Marshaler.Write(msg, ty.heroGroupSkillUse01);
            Marshaler.Write(msg, ty.heroGroupSkillUse02);
            Marshaler.Write(msg, ty.heroGroupSkillUse03);
            Marshaler.Write(msg, ty.heroGroupSkillUse04);
            Marshaler.Write(msg, ty.heroSkillUse01);
            Marshaler.Write(msg, ty.skillIDUse01);
            Marshaler.Write(msg, ty.skillIDUse02);
            Marshaler.Write(msg, ty.skillIDUse03);
            Marshaler.Write(msg, ty.skillIDUse04);
            Marshaler.Write(msg, ty.skillIDUse05);
            Marshaler.Write(msg, ty.skillIDUse06);
            Marshaler.Write(msg, ty.skillIDUse07);
            Marshaler.Write(msg, ty.skillIDUse08);
            Marshaler.Write(msg, ty.skillBreakKillCount);
            Marshaler.Write(msg, ty.skillRankDownCount);
            Marshaler.Write(msg, ty.skillDamageRangeCount01);
            Marshaler.Write(msg, ty.skillDamageRangeCount02);
            Marshaler.Write(msg, ty.skillDamageRangeCount03);
            Marshaler.Write(msg, ty.skillDamageRangeCount04);
            Marshaler.Write(msg, ty.skillDamageRangeCount05);
            Marshaler.Write(msg, ty.skillCardOptionIdUse01);
            Marshaler.Write(msg, ty.skillCardOptionIdUse02);
            Marshaler.Write(msg, ty.skillCardOptionIdUse03);
            Marshaler.Write(msg, ty.skillCardOptionIdUse04);
            Marshaler.Write(msg, ty.skillCardOptionIdUse05);
            Marshaler.Write(msg, ty.skillCardOptionIdUse06);
            Marshaler.Write(msg, ty.enemyDebuffForbidAttack);
            Marshaler.Write(msg, ty.enemyDebuffForbidBuff);
            Marshaler.Write(msg, ty.skillDetonateKill);
            Marshaler.Write(msg, ty.enemyDebuffIgnite);
            Marshaler.Write(msg, ty.oneTurnDamage);
            Marshaler.Write(msg, ty.oneSkillRecoveryHP);
            Marshaler.Write(msg, ty.partyOneTurnRecoveryHP);
            Marshaler.Write(msg, ty.clearStageEnemyTotalDamage);
            Marshaler.Write(msg, ty.enemyDisUseHeal);
            Marshaler.Write(msg, ty.enemySkillSpikeKill);
            Marshaler.Write(msg, ty.enemyExplosionDamage);
            Marshaler.Write(msg, ty.totalDamage);
            Marshaler.Write(msg, ty.skillIgnoreFixedDefCount);
        }

        public static void Write(Message msg, List<IngameBattlePointRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, IngameDropItemInfo ty)
        {
            Marshaler.Write(msg, ty.groupIndex);
            Marshaler.Write(msg, ty.isBossDrop);
        }

        public static void Write(Message msg, List<IngameDropItemInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, IngameMissionProgressRequest ty)
        {
            Marshaler.Write(msg, ty.isSupporterBest);
            Marshaler.Write(msg, ty.cardUseCount_lv2);
            Marshaler.Write(msg, ty.cardUseCount_lv3);
            Marshaler.Write(msg, ty.cardUseCount_specical);
            Marshaler.Write(msg, ty.cardUseCount_heal);
            Marshaler.Write(msg, ty.cardUseCount_debuff);
            Marshaler.Write(msg, ty.allyTurnCount);
            Marshaler.Write(msg, ty.cardUseCount_lv1);
            Marshaler.Write(msg, ty.cardUseCount_counterPose);
            Marshaler.Write(msg, ty.cardUseCount_Shild);
            Marshaler.Write(msg, ty.cardUseCount_AtkStaDown);
            Marshaler.Write(msg, ty.cardUseCount_Stun);
            Marshaler.Write(msg, ty.cardUseCount_Stone);
            Marshaler.Write(msg, ty.cardUseCount_Ice);
            Marshaler.Write(msg, ty.cardUseCount_specialCoop);
            Marshaler.Write(msg, ty.debuffBleedDeadCount);
            Marshaler.Write(msg, ty.staminaDecreaseCount);
            Marshaler.Write(msg, ty.staminaIncreaseCount);
            Marshaler.Write(msg, ty.cardLevelDownCount);
            Marshaler.Write(msg, ty.weakAttributeAttackCount);
            Marshaler.Write(msg, ty.winTeamPower);
            Marshaler.Write(msg, ty.isAllHeroAlive);
            Marshaler.Write(msg, ty.isAllSSR);
            Marshaler.Write(msg, ty.isAllUR);
            Marshaler.Write(msg, ty.isAllWoman);
            Marshaler.Write(msg, ty.isAllMan);
            Marshaler.Write(msg, ty.isNoneWeaponWin);
            Marshaler.Write(msg, ty.buffIceDeadCount);
            Marshaler.Write(msg, ty.lastAttackerSkinID);
            Marshaler.Write(msg, ty.debuffShockKillCount);
            Marshaler.Write(msg, ty.debuffPoisonKillCount);
            Marshaler.Write(msg, ty.maxDamage);
            Marshaler.Write(msg, ty.handicapSkillCount);
            Marshaler.Write(msg, ty.minHPRatio);
            Marshaler.Write(msg, ty.skillCombineByUserInputCount);
            Marshaler.Write(msg, ty.counterPoseKillCount);
            Marshaler.Write(msg, ty.skillLockCount);
            Marshaler.Write(msg, ty.isUsedTargeting);
            Marshaler.Write(msg, ty.isUsedCardReset);
            Marshaler.Write(msg, ty.isUsedBalorEye);
            Marshaler.Write(msg, ty.debuffPetrifactionCount);
            Marshaler.Write(msg, ty.debuffFreezingCount);
            Marshaler.Write(msg, ty.debuffPreventposeCount);
            Marshaler.Write(msg, ty.debuffInfectionCount);
            Marshaler.Write(msg, ty.buffImmuneCount);
            Marshaler.Write(msg, ty.decreaseGaugeCount);
            Marshaler.Write(msg, ty.skillDissipationCount);
            Marshaler.Write(msg, ty.skillOptionDissipationCount);
            Marshaler.Write(msg, ty.skillBustCount);
            Marshaler.Write(msg, ty.skillWeaknessCount);
            Marshaler.Write(msg, ty.eraseBuffCount);
            Marshaler.Write(msg, ty.erasePoseCount);
            Marshaler.Write(msg, ty.recoveryDebuffCount);
            Marshaler.Write(msg, ty.cardDisuseCount);
            Marshaler.Write(msg, ty.beAttackedCountBySpecialCard);
            Marshaler.Write(msg, ty.useCountDropMamaSkill);
            Marshaler.Write(msg, ty.isFinishedByDropMamaSkill);
            Marshaler.Write(msg, ty.buffSkillUseCount);
            Marshaler.Write(msg, ty.skillStaminaAttackCount);
            Marshaler.Write(msg, ty.skillStaminaAddCount);
            Marshaler.Write(msg, ty.skillIgnoreFixedDefCount);
            Marshaler.Write(msg, ty.skillDefIgnoreCount);
            Marshaler.Write(msg, ty.enemyPhoenixCount);
            Marshaler.Write(msg, ty.cardUseHeroChange);
            Marshaler.Write(msg, ty.monsterKillCount);
            Marshaler.Write(msg, ty.skillDetonateCount);
            Marshaler.Write(msg, ty.cardUseCount_Atk);
            Marshaler.Write(msg, ty.cardUseCount_Atk_WithOut_Special);
            Marshaler.Write(msg, ty.poseUseCount);
            Marshaler.Write(msg, ty.stageBattleHeroSameKind);
            Marshaler.Write(msg, ty.stageBattleCardUseSpecialKill);
        }

        public static void Write(Message msg, List<IngameMissionProgressRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, List<int> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, List<short> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, InteractiveChoice en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<InteractiveChoice> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, InvalidRequestType en)
        {
            msg.Write((uint)en);
        }

        public static void Write(Message msg, List<InvalidRequestType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ItemGambleShopBuyInfo ty)
        {
            Marshaler.Write(msg, ty.shopProductID);
            Marshaler.Write(msg, ty.buyCount);
            Marshaler.Write(msg, ty.buyCountByDia);
            Marshaler.Write(msg, ty.buyCountByTicket);
            Marshaler.Write(msg, ty.buyCountByKey);
            Marshaler.Write(msg, ty.freeBuyCount);
        }

        public static void Write(Message msg, List<ItemGambleShopBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ItemOfferInfo ty)
        {
            Marshaler.Write(msg, ty.itemOfferSEQ);
            Marshaler.Write(msg, ty.startDate);
            Marshaler.Write(msg, ty.endDate);
            Marshaler.Write(msg, ty.itemID);
            Marshaler.Write(msg, ty.itemCount);
        }

        public static void Write(Message msg, List<ItemOfferInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ItemResultInfo ty)
        {
            Marshaler.Write(msg, ty.itemType);
            if (ty.itemType != ItemType.None)
            {
                switch (ty.itemType)
                {
                    case ItemType.Hero:
                        Marshaler.Write(msg, ty.userHeroInfo);
                        break;
                    case ItemType.Skin:
                        Marshaler.Write(msg, ty.userSkinInfo);
                        break;
                    case ItemType.Weapon:
                        Marshaler.Write(msg, ty.userWeaponInfo);
                        break;
                    case ItemType.Costume_Skin:
                        Marshaler.Write(msg, ty.userCostumeSkin);
                        break;
                    case ItemType.Costume_Weapon:
                        Marshaler.Write(msg, ty.userCostumeWeapon);
                        break;
                    case ItemType.Costume_Head:
                        Marshaler.Write(msg, ty.userCostumeHead);
                        break;
                    case ItemType.Artifact_Card:
                        Marshaler.Write(msg, ty.userArtifact);
                        break;
                    default:
                        Marshaler.Write(msg, ty.userItemInfo);
                        break;
                }
            }
            Marshaler.Write(msg, ty.getItemCount);
            Marshaler.Write(msg, ty.ingameResultDropBoxGrade);
            Marshaler.Write(msg, ty.ownerSkinID);
            Marshaler.Write(msg, ty.ownerCostumeID);
            Marshaler.Write(msg, ty.skinExp);
            Marshaler.Write(msg, ty.buffAddCount);
            Marshaler.Write(msg, ty.ownerArtifactCardID);
            Marshaler.Write(msg, ty.isGrowthPointUpdate);
            Marshaler.Write(msg, ty.growthPoint);
            //Marshaler.Write(msg, ty.upgradeSkin);
            //Marshaler.Write(msg, ty.prevSkinID);
        }

        public static void Write(Message msg, List<ItemResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ItemSellType en)
        {
            msg.Write((int)en);
        }

        public static void Write(Message msg, List<ItemSellType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ItemType en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<ItemType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ItemUseResult ty)
        {
            Marshaler.Write(msg, ty.useItemInfo);
            Marshaler.Write(msg, ty.itemResultInfoList);
            Marshaler.Write(msg, ty.updateSkinList);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<ItemUseResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, KOFBritanniaStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearResultInfo);
            Marshaler.Write(msg, ty.firstTeamClearItemResultInfo);
            Marshaler.Write(msg, ty.firstGroupClearItemResultInfoList);
        }

        public static void Write(Message msg, List<KOFBritanniaStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LanguageType en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<LanguageType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LimitedCostumeInfo ty)
        {
            Marshaler.Write(msg, ty.removeSkinCostumeGroupIDList);
            Marshaler.Write(msg, ty.removeHeadCostumeGroupIDList);
            Marshaler.Write(msg, ty.removeWeaponCostumeGroupIDList);
            Marshaler.Write(msg, ty.updateUserSkinList);
        }

        public static void Write(Message msg, List<LimitedCostumeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyBuffInfo ty)
        {
            Marshaler.Write(msg, ty.buffID);
            Marshaler.Write(msg, ty.buffLevel);
            Marshaler.Write(msg, ty.buffValue);
            Marshaler.Write(msg, ty.buffRemainSec);
        }

        public static void Write(Message msg, List<LobbyBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyCollectResult ty)
        {
            Marshaler.Write(msg, ty.recipeCollectInfoList);
            Marshaler.Write(msg, ty.buffNpcID);
            Marshaler.Write(msg, ty.buffNpcValue);
            Marshaler.Write(msg, ty.friendCookingEatCount);
            Marshaler.Write(msg, ty.collectPassiveUseCount);
            Marshaler.Write(msg, ty.goldRewardResultInfo);
            Marshaler.Write(msg, ty.passiveItemResultInfoList);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<LobbyCollectResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyCookingInfo ty)
        {
            Marshaler.Write(msg, ty.nextAppearRemainSec);
            Marshaler.Write(msg, ty.appearHeroList);
            Marshaler.Write(msg, ty.disappearRemainSec);
        }

        public static void Write(Message msg, List<LobbyCookingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyGuestInfo ty)
        {
            Marshaler.Write(msg, ty.heroGuestIDList);
            Marshaler.Write(msg, ty.currentVisitGuestID);
            Marshaler.Write(msg, ty.newHeroVisit);
            Marshaler.Write(msg, ty.remainHeroVisitTimeSec);
            Marshaler.Write(msg, ty.currentVisitGuestIndex);
        }

        public static void Write(Message msg, List<LobbyGuestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyInfo ty)
        {
            Marshaler.Write(msg, ty.lobbyVRSearchList);
            Marshaler.Write(msg, ty.lobbyReddotInfo);
            Marshaler.Write(msg, ty.userNpcInfoList);
            Marshaler.Write(msg, ty.guestNPCList);
            Marshaler.Write(msg, ty.currentVisitGuestID);
            Marshaler.Write(msg, ty.currentVisitGuestIndex);
            Marshaler.Write(msg, ty.newHeroVisit);
            Marshaler.Write(msg, ty.remainHeroVisitTimeSec);
            Marshaler.Write(msg, ty.hawkCollectAble);
            Marshaler.Write(msg, ty.eventPacketInfo);
            Marshaler.Write(msg, ty.noticeList);
            Marshaler.Write(msg, ty.packageBannerInfoList);
            Marshaler.Write(msg, ty.disableDropInteractiveList);
            Marshaler.Write(msg, ty.isGuildKickOut);
            Marshaler.Write(msg, ty.guildMemberInfo);
            Marshaler.Write(msg, ty.remainDailyResetTimeSEC);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.didDailyResetToday);
            Marshaler.Write(msg, ty.randomShopInfo);
            Marshaler.Write(msg, ty.clientSendFinalBossSeasonInfo);
            Marshaler.Write(msg, ty.clientSendFinalBossSeasonShopInfo);
            Marshaler.Write(msg, ty.userHeroGachaGaugeInfoList);
            Marshaler.Write(msg, ty.userAgeLevel);
            Marshaler.Write(msg, ty.monthlyInfo);
            Marshaler.Write(msg, ty.gaugeEventFreeChargeAble);
            Marshaler.Write(msg, ty.currentSeasonGroup);
            Marshaler.Write(msg, ty.tournamentDiplayInfoList);
            Marshaler.Write(msg, ty.userAdViewInfoList);
            Marshaler.Write(msg, ty.clientSendBossWarInfo);
            Marshaler.Write(msg, ty.arenaRealTimePvpLowGrade);
            Marshaler.Write(msg, ty.arenaRealTimePvpLowGradeNumber);
            Marshaler.Write(msg, ty.updateUserFurnitureList);
            Marshaler.Write(msg, ty.firstDiaBuy);
            Marshaler.Write(msg, ty.isGuildWarRejoinInfoExists);
            Marshaler.Write(msg, ty.currentGuildWarScheduleInfo);
            Marshaler.Write(msg, ty.isGuildWarSelected);
            Marshaler.Write(msg, ty.guildWarRejoinInfoReaminTTLSec);
            Marshaler.Write(msg, ty.guildWarSelectionInfoList);
            Marshaler.Write(msg, ty.isGuildWarRankRewardable);
            Marshaler.Write(msg, ty.activeSpecialGuestBuff);
            Marshaler.Write(msg, ty.popupSpecialGuestBuff);
            Marshaler.Write(msg, ty.popupPatrolMissionOpen);
            Marshaler.Write(msg, ty.towerStageInfo);
            Marshaler.Write(msg, ty.towerStageHeroInfo);
            Marshaler.Write(msg, ty.disasterTowerStageInfo);
            Marshaler.Write(msg, ty.disasterTowerStageHeroInfo);
            Marshaler.Write(msg, ty.lowerLeagueTableID);
            Marshaler.Write(msg, ty.guildBossSeasonID);
            Marshaler.Write(msg, ty.guildBossGroupID);
            Marshaler.Write(msg, ty.currentGuildWarLowScheduleInfo);
            Marshaler.Write(msg, ty.isGuildWarLowRejoinInfoExists);
            Marshaler.Write(msg, ty.guildWarLowRejoinInfoReaminTTLSec);
            Marshaler.Write(msg, ty.isGuildWarLowPointRewardable);
            Marshaler.Write(msg, ty.guildWarLowLastSeason);
            Marshaler.Write(msg, ty.guildWarLowOpponentGuildSN);
            Marshaler.Write(msg, ty.isGuildWarPrevSeasonSelected);
            Marshaler.Write(msg, ty.guildAttendanceStatus);
            Marshaler.Write(msg, ty.guildNoticeInfo);
            Marshaler.Write(msg, ty.guildMarkList);
            Marshaler.Write(msg, ty.gambleTimeSwitchLobbyInfo);
            Marshaler.Write(msg, ty.growthPoint);
            Marshaler.Write(msg, ty.stackConstellationStoneInfoList);
            Marshaler.Write(msg, ty.isCreatureNestChallengeRewardable);
            Marshaler.Write(msg, ty.isCreatureNestBlueDotOn);
            Marshaler.Write(msg, ty.removeLimitedCostumeInfo);
            Marshaler.Write(msg, ty.remainConstellationChaosChargeSec);
            Marshaler.Write(msg, ty.arenaRealTimePvpSimpleInfo);
            Marshaler.Write(msg, ty.clientSendEventMazeSeasonShopInfo);
            Marshaler.Write(msg, ty.clientSendHeroLeagueInfo);
            Marshaler.Write(msg, ty.clientSendHeroLeagueSeasonShopInfo);
            Marshaler.Write(msg, ty.guildOrderMissionInfoClientSend);
            Marshaler.Write(msg, ty.userGuildOrderMissionInfoClientSend);
            Marshaler.Write(msg, ty.creatureColosseumSeasonInfo);
            Marshaler.Write(msg, ty.demonLordInfo);
            Marshaler.Write(msg, ty.diaShopBuyRemainTimeSec);
        }

        public static void Write(Message msg, List<LobbyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyQuestGroupInfo ty)
        {
            Marshaler.Write(msg, ty.questRoute);
            Marshaler.Write(msg, ty.questGroup);
        }

        public static void Write(Message msg, List<LobbyQuestGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyRandomShopInfo ty)
        {
            Marshaler.Write(msg, ty.dailySeq);
            Marshaler.Write(msg, ty.visitRewardYN);
            Marshaler.Write(msg, ty.remainRandomShopScheduleList);
        }

        public static void Write(Message msg, List<LobbyRandomShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyReddotInfo ty)
        {
            Marshaler.Write(msg, ty.mailListCount);
            Marshaler.Write(msg, ty.friendMailListCount);
            Marshaler.Write(msg, ty.destroyInviteCount);
            Marshaler.Write(msg, ty.friendReddot);
            Marshaler.Write(msg, ty.friendApplyReddot);
            Marshaler.Write(msg, ty.guildReddot);
            Marshaler.Write(msg, ty.noticeMailCount);
            Marshaler.Write(msg, ty.packageMailCount);
            Marshaler.Write(msg, ty.itemGambleShopFreeReddot);
            Marshaler.Write(msg, ty.coinDailyShopFreeReddot);
            Marshaler.Write(msg, ty.friendlyMatchInviteCount);
            Marshaler.Write(msg, ty.realTimePvpRewardAble);
            Marshaler.Write(msg, ty.guildReddot1);
            Marshaler.Write(msg, ty.guildReddot2);
            Marshaler.Write(msg, ty.guildReddot3);
            Marshaler.Write(msg, ty.guildAttendableReddot);
            Marshaler.Write(msg, ty.guildRankRewardReddot);
            Marshaler.Write(msg, ty.guildInvitationCount);
            Marshaler.Write(msg, ty.eventPuzzleRewardReddot);
            Marshaler.Write(msg, ty.eventMoleGameRewardReddot);
            Marshaler.Write(msg, ty.arenaSmashRewardAble);
        }

        public static void Write(Message msg, List<LobbyReddotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LobbyVisualType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<LobbyVisualType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LoginServiceInfo ty)
        {
            Marshaler.Write(msg, ty.currentServerTime);
            Marshaler.Write(msg, ty.maintenanceInfo);
            Marshaler.Write(msg, ty.emergencyNoticeInfo);
            Marshaler.Write(msg, ty.remainResetTimeSEC);
        }

        public static void Write(Message msg, List<LoginServiceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, LoginUserResultInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.sessionKey);
            Marshaler.Write(msg, ty.name);
            Marshaler.Write(msg, ty.nicknameChangeCount);
            Marshaler.Write(msg, ty.exp);
            Marshaler.Write(msg, ty.vipExp);
            Marshaler.Write(msg, ty.noticeList);
            Marshaler.Write(msg, ty.userHeroList);
            Marshaler.Write(msg, ty.userSkinList);
            Marshaler.Write(msg, ty.userWeaponList);
            Marshaler.Write(msg, ty.userCommonItemList);
            Marshaler.Write(msg, ty.extensionData);
            Marshaler.Write(msg, ty.userTeamList);
            Marshaler.Write(msg, ty.arenaRankingDefenceTeamInfo);
            Marshaler.Write(msg, ty.arenaSmashDefenceTeamInfoList);
            Marshaler.Write(msg, ty.tournamentTeamInfoList);
            Marshaler.Write(msg, ty.userAPInfoList);
            Marshaler.Write(msg, ty.userStageInfo);
            Marshaler.Write(msg, ty.userWantToSay);
            Marshaler.Write(msg, ty.userMaxFriendCount);
            Marshaler.Write(msg, ty.userDailyReset);
            Marshaler.Write(msg, ty.userRecipeInfoList);
            Marshaler.Write(msg, ty.userBasePointContentsInfo);
            Marshaler.Write(msg, ty.autoStartQuestIDList);
            Marshaler.Write(msg, ty.userQuestProgressInfoList);
            Marshaler.Write(msg, ty.missionAchieveRewardIndex);
            Marshaler.Write(msg, ty.userGuildMemberInfo);
            Marshaler.Write(msg, ty.userGuildName);
            Marshaler.Write(msg, ty.frinedCode);
            Marshaler.Write(msg, ty.playingDestroyRoomSN);
            Marshaler.Write(msg, ty.userDestroyDiscoverInfoList);
            Marshaler.Write(msg, ty.userAgeLevel);
            Marshaler.Write(msg, ty.userTutorialInfoList);
            Marshaler.Write(msg, ty.userQuickMessageInfoList);
            Marshaler.Write(msg, ty.userStampBookmarkInfoList);
            Marshaler.Write(msg, ty.rePayFlag);
            Marshaler.Write(msg, ty.userNpcList);
            Marshaler.Write(msg, ty.platformMissionInfoList);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.destroyInviteOption);
            Marshaler.Write(msg, ty.isGuildInvitationOn);
            Marshaler.Write(msg, ty.userNicknameChangeAvailableRemainSec);
            Marshaler.Write(msg, ty.userCostumeSkin);
            Marshaler.Write(msg, ty.userCostumeWeapon);
            Marshaler.Write(msg, ty.userCostumeHead);
            Marshaler.Write(msg, ty.userCostumeCraftUpgradeInfoList);
            Marshaler.Write(msg, ty.userPackageInfoList);
            Marshaler.Write(msg, ty.userDiaShopPackageInfoList);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.lobbyUniqueInteractiveFlag);
            Marshaler.Write(msg, ty.questChapterClearInfo);
            Marshaler.Write(msg, ty.loveRewardSeq);
            Marshaler.Write(msg, ty.userGuildInfo);
            Marshaler.Write(msg, ty.guildMemberInfoList);
            Marshaler.Write(msg, ty.isCheatEnable);
            Marshaler.Write(msg, ty.realTimePvpRewardAble);
            Marshaler.Write(msg, ty.userBuffInfoList);
            Marshaler.Write(msg, ty.userHeroGachaGaugeInfoList);
            Marshaler.Write(msg, ty.eventMissionAchieveRewardIndex);
            Marshaler.Write(msg, ty.restDayCount);
            Marshaler.Write(msg, ty.isPvpLowerClear);
            Marshaler.Write(msg, ty.accountCreateTime);
            Marshaler.Write(msg, ty.userFurnitureList);
            Marshaler.Write(msg, ty.friendInfoList);
            Marshaler.Write(msg, ty.userFrozenAssetList);
            Marshaler.Write(msg, ty.arenaRealTimePvpGrade);
            Marshaler.Write(msg, ty.userWeaponUpgradeFailGaugeList);
            Marshaler.Write(msg, ty.monthlyInfo);
            Marshaler.Write(msg, ty.eventMissionCompleteRewardInfoList);
            Marshaler.Write(msg, ty.guildBossRankPointList);
            Marshaler.Write(msg, ty.guildBossRankPointReward);
            Marshaler.Write(msg, ty.isDecisionPlayAble);
            Marshaler.Write(msg, ty.userMusicList);
            Marshaler.Write(msg, ty.isGuideListRewarded);
            Marshaler.Write(msg, ty.guideListStep);
            Marshaler.Write(msg, ty.playTitleID);
            Marshaler.Write(msg, ty.playMusicID);
            Marshaler.Write(msg, ty.musicInstrumentID);
            Marshaler.Write(msg, ty.freePackageReward);
            Marshaler.Write(msg, ty.seasonPassAccumulationCount);
            Marshaler.Write(msg, ty.userPackageMissionInfoList);
            Marshaler.Write(msg, ty.userFinalBossRankPointList);
            Marshaler.Write(msg, ty.getPlayTitleList);
            Marshaler.Write(msg, ty.reverseSeasonInfoList);
            Marshaler.Write(msg, ty.guildWarUserSquadInfo);
            Marshaler.Write(msg, ty.destroyDisasterInfo);
            Marshaler.Write(msg, ty.userEventBingoInfo);
            Marshaler.Write(msg, ty.userStageTicketClearInfoList);
            Marshaler.Write(msg, ty.arenaSmashLobbyInfo);
            Marshaler.Write(msg, ty.heroPassiveGroupInfoList);
            Marshaler.Write(msg, ty.guildWarDefenceTeamInfoList);
            Marshaler.Write(msg, ty.guildWarLowDefenceTeamInfoList);
            Marshaler.Write(msg, ty.artifactCardIdList);
            Marshaler.Write(msg, ty.artifactTeamInfoList);
            Marshaler.Write(msg, ty.artifactUnionInfoList);
            Marshaler.Write(msg, ty.northGrimBookCategoryInfoList);
            Marshaler.Write(msg, ty.constellationInfo);
            Marshaler.Write(msg, ty.lobbyVisualType);
            Marshaler.Write(msg, ty.materialFusionPoint);
            Marshaler.Write(msg, ty.battleEncounter);
            Marshaler.Write(msg, ty.attendanceHeroID);
            Marshaler.Write(msg, ty.activeAttendanceHeroID);
            Marshaler.Write(msg, ty.dailyFreeGambleInfoClientSend);
            Marshaler.Write(msg, ty.guildOrderMissionInfoClientSend);
            Marshaler.Write(msg, ty.userGuildOrderMissionInfoClientSend);
        }

        public static void Write(Message msg, List<LoginUserResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, List<long> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MailHistoryInfo ty)
        {
            Marshaler.Write(msg, ty.mailSN);
            Marshaler.Write(msg, ty.itemID);
            Marshaler.Write(msg, ty.itemCount);
            Marshaler.Write(msg, ty.mailContentsType);
            Marshaler.Write(msg, ty.openDate);
        }

        public static void Write(Message msg, List<MailHistoryInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MailInfo ty)
        {
            Marshaler.Write(msg, ty.mailSN);
            Marshaler.Write(msg, ty.mailContentsType);
            Marshaler.Write(msg, ty.itemType);
            Marshaler.Write(msg, ty.itemID);
            Marshaler.Write(msg, ty.itemCount);
            Marshaler.Write(msg, ty.eventSN);
            Marshaler.Write(msg, ty.expireDate);
        }

        public static void Write(Message msg, List<MailInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MaintenanceInfo ty)
        {
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.message);
        }

        public static void Write(Message msg, List<MaintenanceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MakingCountInfo ty)
        {
            Marshaler.Write(msg, ty.makingID);
            Marshaler.Write(msg, ty.makingCount);
        }

        public static void Write(Message msg, List<MakingCountInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MakingProgressInfo ty)
        {
            Marshaler.Write(msg, ty.makingSN);
            Marshaler.Write(msg, ty.makingID);
            Marshaler.Write(msg, ty.remainSecToComplete);
            Marshaler.Write(msg, ty.makingEndDate);
        }

        public static void Write(Message msg, List<MakingProgressInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MakingStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.makingInfo);
            Marshaler.Write(msg, ty.progressInfo);
            Marshaler.Write(msg, ty.costItemInfo);
            Marshaler.Write(msg, ty.materialItemInfoList);
        }

        public static void Write(Message msg, List<MakingStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MakingUserInfo ty)
        {
            Marshaler.Write(msg, ty.makingID);
            Marshaler.Write(msg, ty.remainSec);
            Marshaler.Write(msg, ty.rewardStatus);
        }

        public static void Write(Message msg, List<MakingUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MarketMissionInfo ty)
        {
            Marshaler.Write(msg, ty.missionType);
            Marshaler.Write(msg, ty.missionValue);
        }

        public static void Write(Message msg, List<MarketMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MasterRedisSkip en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<MasterRedisSkip> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MasterToGameMatchingResultInfo ty)
        {
            Marshaler.Write(msg, ty.isSingleMatching);
            Marshaler.Write(msg, ty.userUSN);
            Marshaler.Write(msg, ty.targetUSN);
            Marshaler.Write(msg, ty.firstAttackUSN);
            Marshaler.Write(msg, ty.targetTeamIndex);
            Marshaler.Write(msg, ty.targetFoodBuffItemID);
            Marshaler.Write(msg, ty.targetNetmarblePID);
            Marshaler.Write(msg, ty.targetUserLevel);
            Marshaler.Write(msg, ty.targetBattlePowerPoint);
            Marshaler.Write(msg, ty.targetBinStreak);
            Marshaler.Write(msg, ty.targetRankPoint);
            Marshaler.Write(msg, ty.relayServerConnect);
            Marshaler.Write(msg, ty.gameserverID);
        }

        public static void Write(Message msg, List<MasterToGameMatchingResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MatchingBossWarUserProfileInfo ty)
        {
            Marshaler.Write(msg, ty.bossWarUserProfileInfo);
            Marshaler.Write(msg, ty.isReady);
            Marshaler.Write(msg, ty.isLoadingEnd);
            Marshaler.Write(msg, ty.isLeave);
            Marshaler.Write(msg, ty.isDefeat);
            Marshaler.Write(msg, ty.isDestroy);
            Marshaler.Write(msg, ty.isBattleEnd);
            Marshaler.Write(msg, ty.randomSeed);
            Marshaler.Write(msg, ty.gameserverID);
        }

        public static void Write(Message msg, List<MatchingBossWarUserProfileInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MatchResult en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<MatchResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MaterialItemInfo ty)
        {
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.itemSerial);
            Marshaler.Write(msg, ty.itemCount);
        }

        public static void Write(Message msg, List<MaterialItemInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MazeBuffType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<MazeBuffType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MazeClearBonusProgressType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<MazeClearBonusProgressType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MazeHeroInfo ty)
        {
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinExp);
            Marshaler.Write(msg, ty.awaken);
            Marshaler.Write(msg, ty.trensend);
            Marshaler.Write(msg, ty.skillLevelUpCount);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.slotIndex);
            Marshaler.Write(msg, ty.isDead);
            //Marshaler.Write(msg, ty.lastDecreaseHP);
            //Marshaler.Write(msg, ty.lastIsDead);
            //Marshaler.Write(msg, ty.teamType);
        }

        public static void Write(Message msg, List<MazeHeroInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MazeSpotType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<MazeSpotType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MazeTeamType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<MazeTeamType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MercenaryDetailInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.mercenaryHero);
            Marshaler.Write(msg, ty.mercenarySkin);
            Marshaler.Write(msg, ty.mercenaryWeaponList);
            Marshaler.Write(msg, ty.skinCostumeList);
            Marshaler.Write(msg, ty.weaponCostumeList);
            Marshaler.Write(msg, ty.headCostumeList);
            Marshaler.Write(msg, ty.costumeCraftUpgradeInfoList);
        }

        public static void Write(Message msg, List<MercenaryDetailInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MercenaryInfo ty)
        {
            //Marshaler.Write(msg, ty.mercenaryLastUseTime);
            Marshaler.Write(msg, ty.mercenaryUsn);
            Marshaler.Write(msg, ty.mercenaryNickname);
            Marshaler.Write(msg, ty.mercenaryUserExp);
            Marshaler.Write(msg, ty.mercenaryRemainUsingSec);
            Marshaler.Write(msg, ty.mercenaryState);
            Marshaler.Write(msg, ty.mercenarySlotInfoList);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
        }

        public static void Write(Message msg, List<MercenaryInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MercenarySlotInfo ty)
        {
            Marshaler.Write(msg, ty.mercenaryHeroID);
            Marshaler.Write(msg, ty.mercenarySkinID);
            Marshaler.Write(msg, ty.mercenarySkinExp);
            Marshaler.Write(msg, ty.mercenarySkinAwaken);
            Marshaler.Write(msg, ty.mercenarySkinResearchList);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
            Marshaler.Write(msg, ty.skinCostumeGroupID);
            Marshaler.Write(msg, ty.weaponCostumeGroupID);
            Marshaler.Write(msg, ty.headCostumeGroupID);
            Marshaler.Write(msg, ty.mercenarySkinTranscend);
            Marshaler.Write(msg, ty.mercenarySkinExceed);
        }

        public static void Write(Message msg, List<MercenarySlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MissionClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.chainID);
            Marshaler.Write(msg, ty.chainIndex);
        }

        public static void Write(Message msg, List<MissionClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MissionClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.successChainIDList);
            Marshaler.Write(msg, ty.getUserExp);
            Marshaler.Write(msg, ty.itemResultInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.apRewardInfoList);
            Marshaler.Write(msg, ty.errorType);
            Marshaler.Write(msg, ty.invalidRequestType);
        }

        public static void Write(Message msg, List<MissionClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MissionResult ty)
        {
            Marshaler.Write(msg, ty.userMissionInfoList);
            Marshaler.Write(msg, ty.marketMissionInfoList);
            Marshaler.Write(msg, ty.eventMissionInfoList);
            Marshaler.Write(msg, ty.guildMissionInfoList);
            Marshaler.Write(msg, ty.titleMissionInfoList);
            Marshaler.Write(msg, ty.guildGroupMissionInfoList);
            Marshaler.Write(msg, ty.guildOrderMissionInfoList);
        }

        public static void Write(Message msg, List<MissionResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, MissionType en)
        {
            msg.Write((short)en);
        }
        public static void Write(Message msg, List<MissionType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NeedItemInfo ty)
        {
            Marshaler.Write(msg, ty.itemID);
            Marshaler.Write(msg, ty.itemCount);
        }

        public static void Write(Message msg, List<NeedItemInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NetmarbleAccountInfo ty)
        {
            Marshaler.Write(msg, ty.netmarblePlayerID);
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.banStatus);
            Marshaler.Write(msg, ty.banReason);
            Marshaler.Write(msg, ty.banCode);
            Marshaler.Write(msg, ty.banLimitSec);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.languageChangeAble);
            Marshaler.Write(msg, ty.needMobileConnect);
            Marshaler.Write(msg, ty.recommandHeroID);
            Marshaler.Write(msg, ty.recommandSkinID);
        }

        public static void Write(Message msg, List<NetmarbleAccountInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NetmarbleSDKInfo ty)
        {
            Marshaler.Write(msg, ty.sdkJson);
            Marshaler.Write(msg, ty.storeType);
            Marshaler.Write(msg, ty.countryCode);
            Marshaler.Write(msg, ty.joinedCountryCode);
            Marshaler.Write(msg, ty.languageCode);
            Marshaler.Write(msg, ty.platformADID);
            Marshaler.Write(msg, ty.UDID);
            Marshaler.Write(msg, ty.OS);
            Marshaler.Write(msg, ty.timeZone);
            Marshaler.Write(msg, ty.sdkADID);
        }

        public static void Write(Message msg, List<NetmarbleSDKInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NetmarbleUserInfo ty)
        {
            Marshaler.Write(msg, ty.netmarblePlayerID);
            Marshaler.Write(msg, ty.userNickname);
            Marshaler.Write(msg, ty.userLevel);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.banStatus);
            Marshaler.Write(msg, ty.banReason);
            Marshaler.Write(msg, ty.banCode);
            Marshaler.Write(msg, ty.banLimitSec);
        }

        public static void Write(Message msg, List<NetmarbleUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NorthGrimBookCategoryInfo ty)
        {
            Marshaler.Write(msg, ty.categoryID);
            Marshaler.Write(msg, ty.rewardFlag);
        }

        public static void Write(Message msg, List<NorthGrimBookCategoryInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NorthQuestClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.questID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.removeItemResultInfoList);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.apRewardInfoList);
        }

        public static void Write(Message msg, List<NorthQuestClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NoticeInfo ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.fromDate);
            Marshaler.Write(msg, ty.toDate);
            Marshaler.Write(msg, ty.noticeTimeColor);
            Marshaler.Write(msg, ty.descriptionColor);
            Marshaler.Write(msg, ty.priority);
            Marshaler.Write(msg, ty.targetOSType);
            Marshaler.Write(msg, ty.noticeStartTime);
            Marshaler.Write(msg, ty.noticeEndTime);
            Marshaler.Write(msg, ty.noticeType);
            Marshaler.Write(msg, ty.languageSet);
            Marshaler.Write(msg, ty.noticeLanguageDataList);
            Marshaler.Write(msg, ty.specificData);
        }

        public static void Write(Message msg, List<NoticeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NoticeLanguageData ty)
        {
            Marshaler.Write(msg, ty.languageType);
            Marshaler.Write(msg, ty.imageURL);
            Marshaler.Write(msg, ty.linkURL);
            Marshaler.Write(msg, ty.description);
        }

        public static void Write(Message msg, List<NoticeLanguageData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NoticeMailInfo ty)
        {
            Marshaler.Write(msg, ty.noticeMailSEQ);
            Marshaler.Write(msg, ty.expireRemainSEC);
            Marshaler.Write(msg, ty.noticeTitle);
            Marshaler.Write(msg, ty.noticeContents);
            Marshaler.Write(msg, ty.getItemList);
            Marshaler.Write(msg, ty.rewardGetStatus);
            Marshaler.Write(msg, ty.linkURL);
            Marshaler.Write(msg, ty.isRefundMail);
            Marshaler.Write(msg, ty.noticeMailType);
        }

        public static void Write(Message msg, List<NoticeMailInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NoticeMailLanguageData ty)
        {
            Marshaler.Write(msg, ty.languageType);
            Marshaler.Write(msg, ty.szTitle);
            Marshaler.Write(msg, ty.szContents);
            Marshaler.Write(msg, ty.szLinkURL);
        }

        public static void Write(Message msg, List<NoticeMailLanguageData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NoticeMailType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<NoticeMailType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NoticeSpecificData ty)
        {
            Marshaler.Write(msg, ty.title);
            Marshaler.Write(msg, ty.imageURL);
            Marshaler.Write(msg, ty.linkURL);
            Marshaler.Write(msg, ty.description);
        }

        public static void Write(Message msg, List<NoticeSpecificData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NoticeType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<NoticeType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NpcGiftResult ty)
        {
            Marshaler.Write(msg, ty.userNpc);
            Marshaler.Write(msg, ty.useItemResultInfo);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.userBuffInfo);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<NpcGiftResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NpcGiftState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<NpcGiftState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, NpcTalkResult ty)
        {
            Marshaler.Write(msg, ty.userNpc);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.interactiveQuestionID);
            Marshaler.Write(msg, ty.choice);
            Marshaler.Write(msg, ty.guestID);
            Marshaler.Write(msg, ty.interactiveTalkID);
        }

        public static void Write(Message msg, List<NpcTalkResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OpenCondition en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<OpenCondition> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OSType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<OSType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OtherArtifactInfo ty)
        {
            Marshaler.Write(msg, ty.unionId);
            Marshaler.Write(msg, ty.unionExp);
            Marshaler.Write(msg, ty.artifactCardIdList);
        }

        public static void Write(Message msg, List<OtherArtifactInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OtherConstellationStatusInfo ty)
        {
            Marshaler.Write(msg, ty.type);
            Marshaler.Write(msg, ty.value);
        }

        public static void Write(Message msg, List<OtherConstellationStatusInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OtherPlayerSimpleTeamInfo ty)
        {
            Marshaler.Write(msg, ty.teamBattlePoint);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.unitInfoList);
            Marshaler.Write(msg, ty.lobbyBuffItemIDList);
            Marshaler.Write(msg, ty.playTitleIDList);
            Marshaler.Write(msg, ty.artifactInfo);
            Marshaler.Write(msg, ty.constellationStatusInfoList);
        }

        public static void Write(Message msg, List<OtherPlayerSimpleTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OtherPlayerSimpleUnitInfo ty)
        {
            Marshaler.Write(msg, ty.slotIndex);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinExp);
            Marshaler.Write(msg, ty.attack);
            Marshaler.Write(msg, ty.defense);
            Marshaler.Write(msg, ty.hpMax);
            Marshaler.Write(msg, ty.fateSkinID);
            Marshaler.Write(msg, ty.fateAddAttack);
            Marshaler.Write(msg, ty.fateAddDefense);
            Marshaler.Write(msg, ty.fateAddHPMax);
            Marshaler.Write(msg, ty.fateSkillLevelUpCount);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
            Marshaler.Write(msg, ty.skinChangeID);
            Marshaler.Write(msg, ty.skinWeaponChangeID);
            Marshaler.Write(msg, ty.skinHeadChangeID);
            Marshaler.Write(msg, ty.memorialClearIDList);
            Marshaler.Write(msg, ty.exclusiveLevel);
            Marshaler.Write(msg, ty.awaken);
            Marshaler.Write(msg, ty.fateAwaken);
            Marshaler.Write(msg, ty.skinTranscend);
            Marshaler.Write(msg, ty.fateSkinTranscend);
            Marshaler.Write(msg, ty.skinExceed);
            Marshaler.Write(msg, ty.fateSkinExceed);
        }

        public static void Write(Message msg, List<OtherPlayerSimpleUnitInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OtherPlayerSlotInfo ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinExp);
            Marshaler.Write(msg, ty.skinAwaken);
            Marshaler.Write(msg, ty.researchList);
            Marshaler.Write(msg, ty.equipWeaponList);
            Marshaler.Write(msg, ty.skinCostumeGroupID);
            Marshaler.Write(msg, ty.weaponCostumeGroupID);
            Marshaler.Write(msg, ty.headCostumeGroupID);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
            Marshaler.Write(msg, ty.skillLevelUpCount);
            Marshaler.Write(msg, ty.maxLevelCount);
            Marshaler.Write(msg, ty.passiveSkillLevel);
            Marshaler.Write(msg, ty.registeredCostumeGroupList);
            Marshaler.Write(msg, ty.transcend);
            Marshaler.Write(msg, ty.skinExceed);
            Marshaler.Write(msg, ty.registeredMadeCostumeGroup);
        }

        public static void Write(Message msg, List<OtherPlayerSlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OtherPlayerTeamInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.foodBuffItemID);
            Marshaler.Write(msg, ty.teamSlotList);
            Marshaler.Write(msg, ty.fateSlotList);
            Marshaler.Write(msg, ty.skinCostumeList);
            Marshaler.Write(msg, ty.weaponCostumeList);
            Marshaler.Write(msg, ty.headCostumeList);
            Marshaler.Write(msg, ty.lobbyBuffItemIDList);
            Marshaler.Write(msg, ty.guildSkillUseList);
            Marshaler.Write(msg, ty.aiLevel);
            Marshaler.Write(msg, ty.playTitleIDList);
            Marshaler.Write(msg, ty.aiCustomizingInfo);
            Marshaler.Write(msg, ty.artifactInfo);
            Marshaler.Write(msg, ty.constellationStatusInfoList);
            Marshaler.Write(msg, ty.costumeCraftUpgradeInfoList);
        }

        public static void Write(Message msg, List<OtherPlayerTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, OtherPlayerWeapon ty)
        {
            Marshaler.Write(msg, ty.weaponSerial);
            Marshaler.Write(msg, ty.weaponBaseID);
            Marshaler.Write(msg, ty.upgrade);
            Marshaler.Write(msg, ty.evolution);
            Marshaler.Write(msg, ty.addPassiveSkillList);
            Marshaler.Write(msg, ty.addMagicSkill);
            Marshaler.Write(msg, ty.defaultOptionValue);
            Marshaler.Write(msg, ty.carveHeroGroup);
        }

        public static void Write(Message msg, List<OtherPlayerWeapon> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PackageBannerInfo ty)
        {
            Marshaler.Write(msg, ty.packageID);
            Marshaler.Write(msg, ty.priority);
            Marshaler.Write(msg, ty.packageImageUrl);
        }

        public static void Write(Message msg, List<PackageBannerInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PackageMailHistoryInfo ty)
        {
            //Marshaler.Write(msg, ty.tID);
            Marshaler.Write(msg, ty.mailSerial);
            Marshaler.Write(msg, ty.packageID);
            Marshaler.Write(msg, ty.openTime);
            Marshaler.Write(msg, ty.choiceItemList);
        }

        public static void Write(Message msg, List<PackageMailHistoryInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PackageMailInfo ty)
        {
            //Marshaler.Write(msg, ty.tID);
            Marshaler.Write(msg, ty.mailSerial);
            Marshaler.Write(msg, ty.packageID);
            Marshaler.Write(msg, ty.mailContentsType);
            Marshaler.Write(msg, ty.choiceItemList);
        }

        public static void Write(Message msg, List<PackageMailInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PackageMissionStatus en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<PackageMissionStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PacketError en)
        {
            msg.Write((uint)en);
        }
        public static void Write(Message msg, List<PacketError> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PatrolInfo ty)
        {
            Marshaler.Write(msg, ty.rotationId);
            Marshaler.Write(msg, ty.lastRewardElpasedTimeSEC);
            Marshaler.Write(msg, ty.patrolMissionInfoList);
            Marshaler.Write(msg, ty.eventEndDate);
        }

        public static void Write(Message msg, List<PatrolInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PatrolMissionInfo ty)
        {
            Marshaler.Write(msg, ty.patrolId);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.heroIdList);
            Marshaler.Write(msg, ty.remainCompleteTimeSec);
        }

        public static void Write(Message msg, List<PatrolMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PaybackEventResultInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.paybackGroupID);
            Marshaler.Write(msg, ty.addValue);
        }

        public static void Write(Message msg, List<PaybackEventResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PickInfo ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.count);
        }

        public static void Write(Message msg, List<PickInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PlayTitleGroupActiveInfo ty)
        {
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.activeStartRemainSec);
            Marshaler.Write(msg, ty.activeEndRemainSec);
        }

        public static void Write(Message msg, List<PlayTitleGroupActiveInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PlayTitleMissionClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.missionID);
        }

        public static void Write(Message msg, List<PlayTitleMissionClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PlayTitleMissionClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.successMissionIDList);
            Marshaler.Write(msg, ty.getUserExp);
            Marshaler.Write(msg, ty.itemResultInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.apRewardInfoList);
            Marshaler.Write(msg, ty.errorType);
            Marshaler.Write(msg, ty.invalidRequestType);
        }

        public static void Write(Message msg, List<PlayTitleMissionClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PointCommonItemID en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<PointCommonItemID> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PVPRankingInfo ty)
        {
            Marshaler.Write(msg, ty.currentSeasionID);
            Marshaler.Write(msg, ty.seasonRankInfo);
            Marshaler.Write(msg, ty.mySeasonInfo);
            Marshaler.Write(msg, ty.pvpRankingInfo);
            Marshaler.Write(msg, ty.myRankingInfo);
            Marshaler.Write(msg, ty.pvpLowerInfo);
            Marshaler.Write(msg, ty.myLowerInfo);
            Marshaler.Write(msg, ty.pvpLimitInfo);
            Marshaler.Write(msg, ty.myLimitInfo);
        }

        public static void Write(Message msg, List<PVPRankingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PVPRankingMyInfo ty)
        {
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.point);
            Marshaler.Write(msg, ty.rank);
        }

        public static void Write(Message msg, List<PVPRankingMyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PVPRankingTopUserInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.point);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.userRankExp);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBackgroundID);
        }

        public static void Write(Message msg, List<PVPRankingTopUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PvpSeasonHistoryInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.seasonPoint);
            Marshaler.Write(msg, ty.seasonRank);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userRankExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.costumeSkinGroupID);
            Marshaler.Write(msg, ty.costumeWeaponGroupID);
            Marshaler.Write(msg, ty.costumeHeadGroupID);
            Marshaler.Write(msg, ty.isHelmetOpen);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBackgroundID);
        }

        public static void Write(Message msg, List<PvpSeasonHistoryInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PvpSeasonLastWeekInfo ty)
        {
            Marshaler.Write(msg, ty.isView);
            Marshaler.Write(msg, ty.seasonPoint);
            Marshaler.Write(msg, ty.currentRank);
            Marshaler.Write(msg, ty.lastWeekRank);
            Marshaler.Write(msg, ty.lastWeekPoint);
            Marshaler.Write(msg, ty.rewardPoint);
            Marshaler.Write(msg, ty.rewardRank);
        }

        public static void Write(Message msg, List<PvpSeasonLastWeekInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PvpSeasonLastWeeklyUserInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.seasonPoint);
            Marshaler.Write(msg, ty.currentRank);
            Marshaler.Write(msg, ty.oldRank);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.userRankExp);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBackgroundID);
        }

        public static void Write(Message msg, List<PvpSeasonLastWeeklyUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PvpSeasonRewardInfo ty)
        {
            Marshaler.Write(msg, ty.isReward);
            Marshaler.Write(msg, ty.rewardSeasonID);
            Marshaler.Write(msg, ty.seasonPoint);
            Marshaler.Write(msg, ty.seasonRank);
            Marshaler.Write(msg, ty.rewardItemInfoList);
        }

        public static void Write(Message msg, List<PvpSeasonRewardInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, PvpSkillDataInfo ty)
        {
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.skillTarget);
            Marshaler.Write(msg, ty.currentCost);
        }

        public static void Write(Message msg, List<PvpSkillDataInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, QuestChapterClearInfo ty)
        {
            Marshaler.Write(msg, ty.storyChapterRewardFlag);
            Marshaler.Write(msg, ty.anotherChapterRewardFlag);
            Marshaler.Write(msg, ty.northChapterRewardFlag);
            Marshaler.Write(msg, ty.disasterChapterRewardFlag);
        }

        public static void Write(Message msg, List<QuestChapterClearInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, QuestClass en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<QuestClass> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, QuestClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.questID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.getItemResultInfoList);
            Marshaler.Write(msg, ty.removeItemResultInfoList);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.basepointGetExp);
            Marshaler.Write(msg, ty.basepointInfo);
            Marshaler.Write(msg, ty.apRewardInfoList);
            Marshaler.Write(msg, ty.lobbyVisualType);
        }

        public static void Write(Message msg, List<QuestClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, QuestGroupInfo ty)
        {
            Marshaler.Write(msg, ty.questGroup);
            Marshaler.Write(msg, ty.questID);
        }

        public static void Write(Message msg, List<QuestGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, QuestProgressInfo ty)
        {
            Marshaler.Write(msg, ty.questID);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.progressCountList);
            Marshaler.Write(msg, ty.interactionFlag);
        }

        public static void Write(Message msg, List<QuestProgressInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, QuestState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<QuestState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, QuestType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<QuestType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RandomShopSchedule ty)
        {
            Marshaler.Write(msg, ty.basepointID);
            Marshaler.Write(msg, ty.openRemainSec);
            Marshaler.Write(msg, ty.closeRemainSec);
            //Marshaler.Write(msg, ty.openDateTime);
            //Marshaler.Write(msg, ty.closeDateTime);
        }

        public static void Write(Message msg, List<RandomShopSchedule> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RandomshopSlotInfo ty)
        {
            Marshaler.Write(msg, ty.shopID);
            Marshaler.Write(msg, ty.slotIndex);
            Marshaler.Write(msg, ty.buyCount);
            Marshaler.Write(msg, ty.PriceID);
        }

        public static void Write(Message msg, List<RandomshopSlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RandomShopSlotState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<RandomShopSlotState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RandomShopSlotType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<RandomShopSlotType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RatingType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<RatingType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecipeCollectInfo ty)
        {
            Marshaler.Write(msg, ty.recipeID);
            Marshaler.Write(msg, ty.sellCount);
        }

        public static void Write(Message msg, List<RecipeCollectInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecipeOrderInfo ty)
        {
            Marshaler.Write(msg, ty.slotNumber);
            Marshaler.Write(msg, ty.recipeID);
            Marshaler.Write(msg, ty.sellCount);
            Marshaler.Write(msg, ty.collectCount);
            Marshaler.Write(msg, ty.remainSEC);
        }

        public static void Write(Message msg, List<RecipeOrderInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecommandHeroData ty)
        {
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.cnt);
            Marshaler.Write(msg, ty.battleCNT);
        }

        public static void Write(Message msg, List<RecommandHeroData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecommandHeroInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.m_mainRecommandHeroDataList);
            Marshaler.Write(msg, ty.m_subRecommandHeroDataList);
        }

        public static void Write(Message msg, List<RecommandHeroInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecommandHeroRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageMode);
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.destroyGroupID);
            Marshaler.Write(msg, ty.diffculty);
        }

        public static void Write(Message msg, List<RecommandHeroRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecommendHeroGrowthInfo ty)
        {
            Marshaler.Write(msg, ty.recommendWeaponSetTypeList);
            Marshaler.Write(msg, ty.recommendWeaponOptionInfoList);
            Marshaler.Write(msg, ty.recommendTeamInfoList);
        }

        public static void Write(Message msg, List<RecommendHeroGrowthInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecommendHeroGrowthTeamInfo ty)
        {
            Marshaler.Write(msg, ty.stageType);
            Marshaler.Write(msg, ty.stageSubType);
            Marshaler.Write(msg, ty.stageId);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.heroIdList);
        }

        public static void Write(Message msg, List<RecommendHeroGrowthTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecommendHeroGrowthWeaponOptionInfo ty)
        {
            Marshaler.Write(msg, ty.group);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.optionId);
        }

        public static void Write(Message msg, List<RecommendHeroGrowthWeaponOptionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RecommendHeroGrowthWeaponSetInfo ty)
        {
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.weaponSetTypeList);
        }

        public static void Write(Message msg, List<RecommendHeroGrowthWeaponSetInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RedisAncientWarUserRankInfo ty)
        {
            Marshaler.Write(msg, ty.USN);
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.teamType);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.totolRankUpCount);
            Marshaler.Write(msg, ty.rankUnixTime);
            //Marshaler.Write(msg, ty.areaId);
        }

        public static void Write(Message msg, List<RedisAncientWarUserRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RedisEventMoleGameRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.highScore);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.totolRankUpCount);
        }

        public static void Write(Message msg, List<RedisEventMoleGameRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RedisFinalBossDifficultyRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.topRankUnxs);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.totalRankUpCount);
            Marshaler.Write(msg, ty.difficulty);
        }

        public static void Write(Message msg, List<RedisFinalBossDifficultyRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RedisFinalBossRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.totolRankUpCount);
            Marshaler.Write(msg, ty.score);
            //Marshaler.Write(msg, ty.topRankUnxs);
            //Marshaler.Write(msg, ty.difficultyRankSkinIDList);
            //Marshaler.Write(msg, ty.difficultyRankPoint);
            //Marshaler.Write(msg, ty.difficultyTopRankUnxs);
        }

        public static void Write(Message msg, List<RedisFinalBossRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RedisGuildBossRankInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.totolRankUpCount);
            Marshaler.Write(msg, ty.difficulty);
            //Marshaler.Write(msg, ty.weekSEQ);
            //Marshaler.Write(msg, ty.redisPoint);
        }

        public static void Write(Message msg, List<RedisGuildBossRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RegisterInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.friendID);
        }

        public static void Write(Message msg, List<RegisterInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RelayConnRequest ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.sessionKey);
            Marshaler.Write(msg, ty.contentType);
            Marshaler.Write(msg, ty.roomSN);
        }

        public static void Write(Message msg, List<RelayConnRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RelayContentType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<RelayContentType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RelayRoomState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<RelayRoomState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RelayServerInfo ty)
        {
            Marshaler.Write(msg, ty.serverIP);
            Marshaler.Write(msg, ty.serverPort);
            Marshaler.Write(msg, ty.sessionKey);
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.ingameSeed);
            Marshaler.Write(msg, ty.playKey);
        }

        public static void Write(Message msg, List<RelayServerInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RelayServerNodeInfo ty)
        {
            Marshaler.Write(msg, ty.serverID);
            Marshaler.Write(msg, ty.sessionKey);
            Marshaler.Write(msg, ty.serverPort);
        }

        public static void Write(Message msg, List<RelayServerNodeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RelayUserType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<RelayUserType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ReplayBytesInfo ty)
        {
            Marshaler.Write(msg, ty.data);
        }

        public static void Write(Message msg, List<ReplayBytesInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ReplayInfo ty)
        {
            Marshaler.Write(msg, ty.body);
            Marshaler.Write(msg, ty.syncList);
        }

        public static void Write(Message msg, List<ReplayInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ReverseGroupInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.firstClearFlag);
            Marshaler.Write(msg, ty.missionFlag);
        }

        public static void Write(Message msg, List<ReverseGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ReverseSeasonInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.starRewardIndex);
            Marshaler.Write(msg, ty.groupRewardFlag);
            Marshaler.Write(msg, ty.reverseGroupInfoList);
        }

        public static void Write(Message msg, List<ReverseSeasonInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, RewardStatusType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<RewardStatusType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SeasonPassRankRewardSlotInfo ty)
        {
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.rewardFlag);
        }

        public static void Write(Message msg, List<SeasonPassRankRewardSlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SeasonPassShopBuyInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.buyInfo);
        }

        public static void Write(Message msg, List<SeasonPassShopBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SendCookingInfo ty)
        {
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.orderCount);
            Marshaler.Write(msg, ty.remainOrderCount);
        }

        public static void Write(Message msg, List<SendCookingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerAncientWarControlInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.startDate);
            Marshaler.Write(msg, ty.endDate);
            Marshaler.Write(msg, ty.calculateDate);
            Marshaler.Write(msg, ty.rewardDate);
        }

        public static void Write(Message msg, List<ServerAncientWarControlInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerArenaRealTimePVPLimitHeroCostInfo ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.heroId);
            Marshaler.Write(msg, ty.cost);
            Marshaler.Write(msg, ty.grade);
            //Marshaler.Write(msg, ty.rank);
        }

        public static void Write(Message msg, List<ServerArenaRealTimePVPLimitHeroCostInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerArenaRealTimePVPMatchingInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.grade);
            Marshaler.Write(msg, ty.gradeNumber);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.foodBuffID);
            Marshaler.Write(msg, ty.userLevel);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.netmarblePID);
            Marshaler.Write(msg, ty.rankPoint);
            Marshaler.Write(msg, ty.isPlacementMatching);
            Marshaler.Write(msg, ty.isSerialLose);
            Marshaler.Write(msg, ty.isRealTimeMatch);
            Marshaler.Write(msg, ty.joinTick);
            Marshaler.Write(msg, ty.matchingAbleMinPoint);
            Marshaler.Write(msg, ty.matchingAbleMaxPoint);
            Marshaler.Write(msg, ty.arenaRankingMatchingSuccess);
            Marshaler.Write(msg, ty.matchingTargetUSN);
            Marshaler.Write(msg, ty.matchingAIUSN);
            Marshaler.Write(msg, ty.checkAIRandomTick);
            Marshaler.Write(msg, ty.sessionKey);
            Marshaler.Write(msg, ty.relayServerConnect);
            Marshaler.Write(msg, ty.gameServerID);
        }

        public static void Write(Message msg, List<ServerArenaRealTimePVPMatchingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerEventDBInfo ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.eventJson);
            Marshaler.Write(msg, ty.eventTitle);
            Marshaler.Write(msg, ty.eventSubTitle);
            Marshaler.Write(msg, ty.imageURL);
            Marshaler.Write(msg, ty.linkURL);
            Marshaler.Write(msg, ty.priority);
            Marshaler.Write(msg, ty.description);
            Marshaler.Write(msg, ty.tabNumber);
            Marshaler.Write(msg, ty.tabName);
            Marshaler.Write(msg, ty.tabPriority);
            Marshaler.Write(msg, ty.toDate);
            Marshaler.Write(msg, ty.fromDate);
            Marshaler.Write(msg, ty.maintenance);
            Marshaler.Write(msg, ty.emphasis);
            Marshaler.Write(msg, ty.subIndexList);
        }

        public static void Write(Message msg, List<ServerEventDBInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerEventInfo ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.eventJson);
            Marshaler.Write(msg, ty.eventTitle);
            Marshaler.Write(msg, ty.eventSubTitle);
            Marshaler.Write(msg, ty.imgURL);
            Marshaler.Write(msg, ty.linkURL);
            Marshaler.Write(msg, ty.priority);
            Marshaler.Write(msg, ty.description);
            Marshaler.Write(msg, ty.tabNumber);
            Marshaler.Write(msg, ty.tabName);
            Marshaler.Write(msg, ty.tabPriority);
            Marshaler.Write(msg, ty.startRemainSec);
            Marshaler.Write(msg, ty.endRemainSec);
            Marshaler.Write(msg, ty.toDate);
            Marshaler.Write(msg, ty.fromDate);
            Marshaler.Write(msg, ty.eventOpenType);
            Marshaler.Write(msg, ty.nextOpenReaminSec);
            Marshaler.Write(msg, ty.playAbleRemainSec);
            Marshaler.Write(msg, ty.timeIndex);
            Marshaler.Write(msg, ty.maintenance);
            Marshaler.Write(msg, ty.emphasis);
        }

        public static void Write(Message msg, List<ServerEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerEventType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<ServerEventType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerIniInfo ty)
        {
            Marshaler.Write(msg, ty.clientAccessVersion);
            Marshaler.Write(msg, ty.cdnAccessVersion);
            Marshaler.Write(msg, ty.securityList);
            Marshaler.Write(msg, ty.finalBossRankPointMax);
            Marshaler.Write(msg, ty.guildBossRankPointMax);
            Marshaler.Write(msg, ty.logLevel);
            Marshaler.Write(msg, ty.targetHost);
            Marshaler.Write(msg, ty.redisSkip);
            Marshaler.Write(msg, ty.localSkip);
        }

        public static void Write(Message msg, List<ServerIniInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerMaintenanceInfo ty)
        {
            //Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.startDate);
            Marshaler.Write(msg, ty.endDate);
            Marshaler.Write(msg, ty.message);
        }

        public static void Write(Message msg, List<ServerMaintenanceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerNoticeMailInfo ty)
        {
            Marshaler.Write(msg, ty.noticeMailSEQ);
            Marshaler.Write(msg, ty.sendDate);
            Marshaler.Write(msg, ty.expireDate);
            Marshaler.Write(msg, ty.getItemList);
            Marshaler.Write(msg, ty.checkAccountCreateTime);
            Marshaler.Write(msg, ty.languageSet);
            Marshaler.Write(msg, ty.noticeMailLanguageDataList);
            Marshaler.Write(msg, ty.specificData);
        }

        public static void Write(Message msg, List<ServerNoticeMailInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerSystemMailData ty)
        {
            Marshaler.Write(msg, ty.systemMailIndex);
            Marshaler.Write(msg, ty.szTitle);
            Marshaler.Write(msg, ty.szContents);
        }

        public static void Write(Message msg, List<ServerSystemMailData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ServerVersionInfo ty)
        {
            Marshaler.Write(msg, ty.buildTime);
            Marshaler.Write(msg, ty.assemblyInfoDescription);
        }

        public static void Write(Message msg, List<ServerVersionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ShopBuyInfo ty)
        {
            //Marshaler.Write(msg, ty.serverNoDailyReset);
            Marshaler.Write(msg, ty.shopProductID);
            Marshaler.Write(msg, ty.basepointID);
            Marshaler.Write(msg, ty.buyCount);
            Marshaler.Write(msg, ty.freeBuyCount);
            Marshaler.Write(msg, ty.startRemainSec);
            Marshaler.Write(msg, ty.endRemainSec);
            Marshaler.Write(msg, ty.bonusGetCount);
            Marshaler.Write(msg, ty.periodBuyCount);
        }

        public static void Write(Message msg, List<ShopBuyInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ShopBuyRequestInfo ty)
        {
            Marshaler.Write(msg, ty.shopProductID);
            Marshaler.Write(msg, ty.buyCount);
        }

        public static void Write(Message msg, List<ShopBuyRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ShopInfo ty)
        {
            Marshaler.Write(msg, ty.unlockCount);
            Marshaler.Write(msg, ty.productList);
            Marshaler.Write(msg, ty.expireDate);
        }

        public static void Write(Message msg, List<ShopInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ShopProduct ty)
        {
            Marshaler.Write(msg, ty.slotIndex);
            Marshaler.Write(msg, ty.productID);
            Marshaler.Write(msg, ty.isSoldOut);
        }

        public static void Write(Message msg, List<ShopProduct> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, ShopTimeItemInfo ty)
        {
            Marshaler.Write(msg, ty.shopProductID);
            Marshaler.Write(msg, ty.endDate);
            Marshaler.Write(msg, ty.remainSecEndDate);
            Marshaler.Write(msg, ty.startDate);
            Marshaler.Write(msg, ty.remainSecStartDate);
            Marshaler.Write(msg, ty.productType);
        }

        public static void Write(Message msg, List<ShopTimeItemInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SideStageClearInfo ty)
        {
            Marshaler.Write(msg, ty.region);
            Marshaler.Write(msg, ty.sideStageID1);
            Marshaler.Write(msg, ty.sideStageID2);
            Marshaler.Write(msg, ty.sideStageID3);
            Marshaler.Write(msg, ty.sideStageID4);
            Marshaler.Write(msg, ty.sideStageID5);
            Marshaler.Write(msg, ty.freeStage);
            Marshaler.Write(msg, ty.bossStage);
            Marshaler.Write(msg, ty.limitedStage);
            Marshaler.Write(msg, ty.areaFirstClearInfo);
            Marshaler.Write(msg, ty.hawkRunStage);
            Marshaler.Write(msg, ty.finalBossStage);
        }

        public static void Write(Message msg, List<SideStageClearInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SimpleInfoSlotInfo ty)
        {
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinExp);
            Marshaler.Write(msg, ty.skinAwaken);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
            Marshaler.Write(msg, ty.skinCostumeGroupID);
            Marshaler.Write(msg, ty.weaponCostumeGroupID);
            Marshaler.Write(msg, ty.headCostumeGroupID);
            Marshaler.Write(msg, ty.skinResearchList);
            Marshaler.Write(msg, ty.maxLevelCount);
            Marshaler.Write(msg, ty.skinTranscend);
            Marshaler.Write(msg, ty.skinExceed);
            Marshaler.Write(msg, ty.skinCostumeExpireDate);
            Marshaler.Write(msg, ty.weaponCostumeExpireDate);
            Marshaler.Write(msg, ty.headCostumeExpireDate);
        }

        public static void Write(Message msg, List<SimpleInfoSlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkillTarget en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<SkillTarget> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkinAwakenValue en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<SkinAwakenValue> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkinEvolutionBreakResult ty)
        {
            Marshaler.Write(msg, ty.userSkin);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.priceItemResultInfoList);
        }

        public static void Write(Message msg, List<SkinEvolutionBreakResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkinEvolutionResult ty)
        {
            Marshaler.Write(msg, ty.prevSkinID);
            Marshaler.Write(msg, ty.userSkin);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.priceItemResultInfoList);
        }

        public static void Write(Message msg, List<SkinEvolutionResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkinGiveFellowResult ty)
        {
            Marshaler.Write(msg, ty.userSkin);
            Marshaler.Write(msg, ty.fellowshipItemInfoList);
            Marshaler.Write(msg, ty.userNpcResult);
        }

        public static void Write(Message msg, List<SkinGiveFellowResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkinOneStepEvolutionResult ty)
        {
            Marshaler.Write(msg, ty.prevSkinID);
            Marshaler.Write(msg, ty.growthPoint);
            Marshaler.Write(msg, ty.userSkin);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.userPackageMissionInfoList);
        }

        public static void Write(Message msg, List<SkinOneStepEvolutionResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkinSkillLevelUpResult ty)
        {
            Marshaler.Write(msg, ty.userSkin);
            Marshaler.Write(msg, ty.priceItemInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.questProgressInfoList);
        }

        public static void Write(Message msg, List<SkinSkillLevelUpResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SkinStatInfo ty)
        {
            Marshaler.Write(msg, ty.slotIndex);
            Marshaler.Write(msg, ty.attack);
            Marshaler.Write(msg, ty.defence);
            Marshaler.Write(msg, ty.life);
            Marshaler.Write(msg, ty.currentLife);
            Marshaler.Write(msg, ty.teamIndex);
        }

        public static void Write(Message msg, List<SkinStatInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.battleSkinInfoList);
            Marshaler.Write(msg, ty.friendBattleSkinInfo);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.mercenaryUSN);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.missionRequest);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.isAutoPlay);
            Marshaler.Write(msg, ty.turnCount);
            Marshaler.Write(msg, ty.clientTimeSec);
            Marshaler.Write(msg, ty.deltaTime);
            Marshaler.Write(msg, ty.packetSendTick);
            Marshaler.Write(msg, ty.tickCount);
            Marshaler.Write(msg, ty.stopwatch);
            Marshaler.Write(msg, ty.dateTime);
            Marshaler.Write(msg, ty.stageIndex);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.phase);
            Marshaler.Write(msg, ty.clearDateTime);
            Marshaler.Write(msg, ty.stageString);
            Marshaler.Write(msg, ty.battleAbuseLog);
            Marshaler.Write(msg, ty.battleSimulationLog);
            Marshaler.Write(msg, ty.battleEncounter);
        }

        public static void Write(Message msg, List<StageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.battleSkinResultInfoList);
            Marshaler.Write(msg, ty.npcResultList);
            Marshaler.Write(msg, ty.goldItemResultInfo);
            Marshaler.Write(msg, ty.ingameItemResultInfoList);
            Marshaler.Write(msg, ty.questItemResultInfoList);
            Marshaler.Write(msg, ty.firstItemResultInfo);
            Marshaler.Write(msg, ty.clearItemResultInfo);
            Marshaler.Write(msg, ty.globalDropItemResultInfoList);
            Marshaler.Write(msg, ty.gaugeRewardItemResultInfo);
            Marshaler.Write(msg, ty.passiveDropItemInfo);
            Marshaler.Write(msg, ty.additionalItemResultInfo);
            Marshaler.Write(msg, ty.fixedItemResultInfoList);
            Marshaler.Write(msg, ty.firstClearItemResultInfoList);
            Marshaler.Write(msg, ty.inGameMissionRewardItemResultInfoList);
            Marshaler.Write(msg, ty.demonPointItemResultInfo);
            Marshaler.Write(msg, ty.isFirstClear);
            Marshaler.Write(msg, ty.playStageID);
            Marshaler.Write(msg, ty.stageInfo);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.playCountEventInfoList);
            Marshaler.Write(msg, ty.ingameGoldBuffAddValue);
            Marshaler.Write(msg, ty.usedFoodID);
            Marshaler.Write(msg, ty.updateUserGlobalDropEventInfoList);
            Marshaler.Write(msg, ty.adViewRouletteInfo);
            Marshaler.Write(msg, ty.heroPassiveGroupInfoList);
            Marshaler.Write(msg, ty.usedEventLobbyBuffIdList);
            Marshaler.Write(msg, ty.isAbuseDetect);
        }

        public static void Write(Message msg, List<StageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageClearTicketRequest ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.clearCount);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.battleSkinInfoList);
            Marshaler.Write(msg, ty.eventSEQ);
            //Marshaler.Write(msg, ty.freeTicketEventSEQ);
        }

        public static void Write(Message msg, List<StageClearTicketRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageClearTicketResult ty)
        {
            Marshaler.Write(msg, ty.serverClearCount);
            Marshaler.Write(msg, ty.ticketClearCountInfo);
            Marshaler.Write(msg, ty.ticketItemResultInfo);
            Marshaler.Write(msg, ty.useItemResultInfo);
            Marshaler.Write(msg, ty.playStageID);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.staminaInfo);
            Marshaler.Write(msg, ty.stageInfo);
            Marshaler.Write(msg, ty.goldItemResultInfo);
            Marshaler.Write(msg, ty.ingameItemResultInfoList);
            Marshaler.Write(msg, ty.questItemResultInfoList);
            Marshaler.Write(msg, ty.clearItemResultInfoList);
            Marshaler.Write(msg, ty.globalDropItemResultInfoList);
            Marshaler.Write(msg, ty.gaugeRewardItemResultInfoList);
            Marshaler.Write(msg, ty.additionalItemResultInfoList);
            Marshaler.Write(msg, ty.weekEventFixedItemResultInfoList);
            Marshaler.Write(msg, ty.passiveItemResultInfoList);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.playCountEventInfoList);
            Marshaler.Write(msg, ty.ingameGoldBuffAddValue);
            Marshaler.Write(msg, ty.updateUserGlobalDropEventInfoList);
            Marshaler.Write(msg, ty.battleSkinResultInfoList);
            Marshaler.Write(msg, ty.npcResultList);
            Marshaler.Write(msg, ty.heroPassiveGroupInfoList);
            Marshaler.Write(msg, ty.freeClearTicketUseCount);
            Marshaler.Write(msg, ty.usedEventLobbyBuffIdList);
        }

        public static void Write(Message msg, List<StageClearTicketResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageControlType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<StageControlType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageInfo ty)
        {
            Marshaler.Write(msg, ty.mainStageTopClearID);
            Marshaler.Write(msg, ty.anotherMainStageTopClearID);
            Marshaler.Write(msg, ty.anotherFreeStageFlag);
            Marshaler.Write(msg, ty.northMainStageTopClearID);
            Marshaler.Write(msg, ty.northFreeStageFlag);
            Marshaler.Write(msg, ty.disasterMainStageTopClearID);
            Marshaler.Write(msg, ty.disasterFreeStageFlag);
            Marshaler.Write(msg, ty.sideStageClearInfoList);
            Marshaler.Write(msg, ty.weeklyStageFirstClearInfoList);
            Marshaler.Write(msg, ty.questStageFirstClearInfo);
            Marshaler.Write(msg, ty.descentStageFirstClearInfo);
            Marshaler.Write(msg, ty.stagePlayCountInfoList);
            Marshaler.Write(msg, ty.dayofWeek);
            Marshaler.Write(msg, ty.extraStageInfoList);
            Marshaler.Write(msg, ty.eventGauge);
            Marshaler.Write(msg, ty.goldGauge);
            Marshaler.Write(msg, ty.upgradeGauge1);
            Marshaler.Write(msg, ty.upgradeGauge2);
            Marshaler.Write(msg, ty.upgradeGauge3);
            Marshaler.Write(msg, ty.evolutionGauge1);
            Marshaler.Write(msg, ty.evolutionGauge2);
            Marshaler.Write(msg, ty.evolutionGauge3);
            Marshaler.Write(msg, ty.timelimitGauge);
            Marshaler.Write(msg, ty.timelimitGauge2);
            Marshaler.Write(msg, ty.timelimitGauge3);
            Marshaler.Write(msg, ty.timelimitStageRemainSec);
            Marshaler.Write(msg, ty.timelimitStageRemainSec2);
            Marshaler.Write(msg, ty.timelimitStageRemainSec3);
            Marshaler.Write(msg, ty.trainingStageInfo);
            Marshaler.Write(msg, ty.eventWeeklyStageID);
            Marshaler.Write(msg, ty.eventDisasterDestroyClearInfoList);
            Marshaler.Write(msg, ty.coinDungeonGauge);
            Marshaler.Write(msg, ty.coinDungeonStageRemainSec);
            Marshaler.Write(msg, ty.coinDungeonWeekResetRemainSec);
            Marshaler.Write(msg, ty.coinDungeonWeekOpenCount);
            Marshaler.Write(msg, ty.coinDungeonGauge2);
            Marshaler.Write(msg, ty.coinDungeonStageRemainSec2);
            Marshaler.Write(msg, ty.coinDungeonWeekOpenCount2);
            Marshaler.Write(msg, ty.coinDungeonGauge3);
            Marshaler.Write(msg, ty.coinDungeonStageRemainSec3);
            Marshaler.Write(msg, ty.coinDungeonWeekOpenCount3);
            Marshaler.Write(msg, ty.yggdrasilTowerStageFirstClearInfoList);
            Marshaler.Write(msg, ty.creatureNestStageInfoList);
            Marshaler.Write(msg, ty.weeklyResetRemainSec);
            Marshaler.Write(msg, ty.weeklyBuffUseHour);
            Marshaler.Write(msg, ty.finalBossFirstClearInfoList);
            Marshaler.Write(msg, ty.creatureColosseumSeasonInfo);
            Marshaler.Write(msg, ty.creatureColosseumStageInfoList);
        }

        public static void Write(Message msg, List<StageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageMonsterGrade en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<StageMonsterGrade> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageMonsterInfo ty)
        {
            //Marshaler.Write(msg, ty.privateDropBoxGrade);
            Marshaler.Write(msg, ty.monsterID);
            Marshaler.Write(msg, ty.bossColumnNumber);
            Marshaler.Write(msg, ty.dropBoxGrade);
            Marshaler.Write(msg, ty.stageMonsterGrade);
        }

        public static void Write(Message msg, List<StageMonsterInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StagePlayCountInfo ty)
        {
            //Marshaler.Write(msg, ty.isDailyReset);
            Marshaler.Write(msg, ty.stageLimitIndex);
            Marshaler.Write(msg, ty.stagePlayCount);
        }

        public static void Write(Message msg, List<StagePlayCountInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.mercenaryUSN);
            Marshaler.Write(msg, ty.mercenarySkinID);
            Marshaler.Write(msg, ty.mercenaryState);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.stageNpcIDList);
            Marshaler.Write(msg, ty.stageIndex);
        }

        public static void Write(Message msg, List<StageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.ingameGold);
            Marshaler.Write(msg, ty.isGoldManta);
            Marshaler.Write(msg, ty.stageMonsterList);
            Marshaler.Write(msg, ty.apInfo);
            Marshaler.Write(msg, ty.missionResult);
            Marshaler.Write(msg, ty.isBuffUsed);
            Marshaler.Write(msg, ty.foodBuffInfo);
            Marshaler.Write(msg, ty.useItemResultInfo);
            Marshaler.Write(msg, ty.isRejoinEnable);
            Marshaler.Write(msg, ty.rejoinData);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.questProgressInfoList);
            Marshaler.Write(msg, ty.stageIndex);
            Marshaler.Write(msg, ty.guildSkillUseList);
            Marshaler.Write(msg, ty.usedEventLobbyBuffIdList);
            Marshaler.Write(msg, ty.battleEncounter);
        }

        public static void Write(Message msg, List<StageStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageTicketClearInfo ty)
        {
            Marshaler.Write(msg, ty.controlType);
            Marshaler.Write(msg, ty.clearCount);
        }

        public static void Write(Message msg, List<StageTicketClearInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<StageType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageVerifyRequest ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.data);
        }

        public static void Write(Message msg, List<StageVerifyRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StageVerifyResult ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.ingameGold);
            Marshaler.Write(msg, ty.isGoldManta);
        }

        public static void Write(Message msg, List<StageVerifyResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StatUserSkin ty)
        {
            Marshaler.Write(msg, ty.skinId);
            Marshaler.Write(msg, ty.level);
            Marshaler.Write(msg, ty.exp);
            Marshaler.Write(msg, ty.battlePoint);
            Marshaler.Write(msg, ty.weaponIdList);
            Marshaler.Write(msg, ty.costumeId);
            Marshaler.Write(msg, ty.weaponCostumeId);
            Marshaler.Write(msg, ty.headCostumeId);
            Marshaler.Write(msg, ty.skinStatusInfo);
            Marshaler.Write(msg, ty.exclusivePassiveLevel);
            Marshaler.Write(msg, ty.awakenCnt);
            Marshaler.Write(msg, ty.transcendValue);
            Marshaler.Write(msg, ty.exceedCnt);
            Marshaler.Write(msg, ty.specialSkillLevel);
            Marshaler.Write(msg, ty.fateSkinId);
            Marshaler.Write(msg, ty.fateSkinLevel);
            Marshaler.Write(msg, ty.fateSkinExp);
            Marshaler.Write(msg, ty.fateExclusivePassiveLevel);
            Marshaler.Write(msg, ty.fateAwakenCnt);
            Marshaler.Write(msg, ty.fateTranscendValue);
            Marshaler.Write(msg, ty.fateExceedCnt);
            Marshaler.Write(msg, ty.fateSpecialSkillLevel);
            Marshaler.Write(msg, ty.fateAddAtk);
            Marshaler.Write(msg, ty.fateAddDef);
            Marshaler.Write(msg, ty.fateAddHp);
            Marshaler.Write(msg, ty.artifactAtk);
            Marshaler.Write(msg, ty.artifactDef);
            Marshaler.Write(msg, ty.artifactHp);
            Marshaler.Write(msg, ty.constellationStatusInfo);
        }

        public static void Write(Message msg, List<StatUserSkin> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StatusInfo ty)
        {
            Marshaler.Write(msg, ty.atk);
            Marshaler.Write(msg, ty.def);
            Marshaler.Write(msg, ty.maxHp);
            Marshaler.Write(msg, ty.fixedAtkPer);
            Marshaler.Write(msg, ty.fixedDefPer);
            Marshaler.Write(msg, ty.critAtkPer);
            Marshaler.Write(msg, ty.critDefPer);
            Marshaler.Write(msg, ty.critPer);
            Marshaler.Write(msg, ty.critResPer);
            Marshaler.Write(msg, ty.hpRecoveryPer);
            Marshaler.Write(msg, ty.hpStealPer);
            Marshaler.Write(msg, ty.hpRegenPer);
            Marshaler.Write(msg, ty.attrEnhancePer);
            Marshaler.Write(msg, ty.dmgRes);
        }

        public static void Write(Message msg, List<StatusInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, StepupPriceType en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<StepupPriceType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, List<string> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SubdubClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.turnCount);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.battleSkinInfoList);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.missionRequest);
        }

        public static void Write(Message msg, List<SubdubClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SubdueBossBattleSyncInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.leave);
            Marshaler.Write(msg, ty.defeat);
            Marshaler.Write(msg, ty.currDamage);
            Marshaler.Write(msg, ty.userTotalDamage);
        }

        public static void Write(Message msg, List<SubdueBossBattleSyncInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SubdueBossBattleSyncResult ty)
        {
            Marshaler.Write(msg, ty.gameSN);
            Marshaler.Write(msg, ty.totalDamage);
            Marshaler.Write(msg, ty.bossDestroy);
            Marshaler.Write(msg, ty.remainBattleEndSec);
            Marshaler.Write(msg, ty.battleSyncList);
            Marshaler.Write(msg, ty.battleRanking);
        }

        public static void Write(Message msg, List<SubdueBossBattleSyncResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SubdueBossPlayInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.playCount);
            Marshaler.Write(msg, ty.initRemainSec);
            //Marshaler.Write(msg, ty.playSeq);
        }

        public static void Write(Message msg, List<SubdueBossPlayInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SubdueBossRewardRank ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.damageCount);
            Marshaler.Write(msg, ty.leave);
            Marshaler.Write(msg, ty.defeat);
            //Marshaler.Write(msg, ty.lastAttackTimeCount);
            //Marshaler.Write(msg, ty.randomSeed);
        }

        public static void Write(Message msg, List<SubdueBossRewardRank> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SubdueBossRewardResult ty)
        {
            Marshaler.Write(msg, ty.isVictory);
            Marshaler.Write(msg, ty.rankList);
            Marshaler.Write(msg, ty.defeatMemberUSNs);
            Marshaler.Write(msg, ty.goldItemResultInfo);
            Marshaler.Write(msg, ty.rewardHostResultInfoList);
            Marshaler.Write(msg, ty.rewardRankResultInfoList);
            Marshaler.Write(msg, ty.rewardLostResultInfoList);
            Marshaler.Write(msg, ty.rewardDamageRangeResultInfoList);
            Marshaler.Write(msg, ty.adViewRouletteInfo);
            Marshaler.Write(msg, ty.updateUserGlobalDropEventInfoList);
            Marshaler.Write(msg, ty.rewardGlobalDropResultInfoList);
            Marshaler.Write(msg, ty.rewardSoloResultInfoList);
            Marshaler.Write(msg, ty.usedEventLobbyBuffIdList);
            Marshaler.Write(msg, ty.questProgressInfoList);
        }

        public static void Write(Message msg, List<SubdueBossRewardResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SuccessInfo ty)
        {
            Marshaler.Write(msg, ty.values);
            Marshaler.Write(msg, ty.successType);
        }

        public static void Write(Message msg, List<SuccessInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SuccessType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<SuccessType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SyncCreatureNestHero ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
        }

        public static void Write(Message msg, List<SyncCreatureNestHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, SyncMazeHero ty)
        {
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.decreaseHP);
            Marshaler.Write(msg, ty.isDead);
        }

        public static void Write(Message msg, List<SyncMazeHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TalkExtraDataType en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<TalkExtraDataType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TalkKitType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TalkKitType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TeamIndexType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TeamIndexType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentBattleEndRequest ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.resultState);
            Marshaler.Write(msg, ty.missionRequest);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.isAutoPlay);
            Marshaler.Write(msg, ty.turnCount);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.teamInfo);
        }

        public static void Write(Message msg, List<TournamentBattleEndRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentBattleEndResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.isWin);
            Marshaler.Write(msg, ty.isMatchPlay);
            Marshaler.Write(msg, ty.tournamentSEQ);
            Marshaler.Write(msg, ty.matchInfo);
            Marshaler.Write(msg, ty.tournamentRank);
            Marshaler.Write(msg, ty.missionResult);
        }

        public static void Write(Message msg, List<TournamentBattleEndResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentBattleStartRequest ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.teamInfo);
            Marshaler.Write(msg, ty.skinStatInfoList);
            Marshaler.Write(msg, ty.otherUSN);
            Marshaler.Write(msg, ty.otherTeamIndex);
        }

        public static void Write(Message msg, List<TournamentBattleStartRequest> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentBattleStartResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
            Marshaler.Write(msg, ty.otherPlayerTeamInfo);
        }

        public static void Write(Message msg, List<TournamentBattleStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentControlInfo ty)
        {
            Marshaler.Write(msg, ty.SEQ);
            Marshaler.Write(msg, ty.prepareFromTime);
            Marshaler.Write(msg, ty.openFromTime);
            Marshaler.Write(msg, ty.postToTime);
            Marshaler.Write(msg, ty.replayToTime);
            Marshaler.Write(msg, ty.title);
            Marshaler.Write(msg, ty.bannerURL);
            Marshaler.Write(msg, ty.contents);
            Marshaler.Write(msg, ty.playerUSNList);
            Marshaler.Write(msg, ty.rewardGroupID);
            Marshaler.Write(msg, ty.isWeaponUse);
            Marshaler.Write(msg, ty.damageRate);
            Marshaler.Write(msg, ty.damageIncRate);
        }

        public static void Write(Message msg, List<TournamentControlInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentDisplayInfo ty)
        {
            Marshaler.Write(msg, ty.SEQ);
            Marshaler.Write(msg, ty.title);
            Marshaler.Write(msg, ty.bannerURL);
            Marshaler.Write(msg, ty.contents);
            Marshaler.Write(msg, ty.rewardGroupID);
            Marshaler.Write(msg, ty.isWeaponUse);
            Marshaler.Write(msg, ty.damageRate);
            Marshaler.Write(msg, ty.damageIncRate);
            Marshaler.Write(msg, ty.startTime);
            Marshaler.Write(msg, ty.endTime);
            Marshaler.Write(msg, ty.startRemainSec);
            Marshaler.Write(msg, ty.endRemainSec);
            Marshaler.Write(msg, ty.isPlayer);
            Marshaler.Write(msg, ty.tournamentState);
            Marshaler.Write(msg, ty.stateRemainSec);
        }

        public static void Write(Message msg, List<TournamentDisplayInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchInfo ty)
        {
            Marshaler.Write(msg, ty.roundIndex);
            Marshaler.Write(msg, ty.matchIndex);
            Marshaler.Write(msg, ty.matchState);
            Marshaler.Write(msg, ty.matchStateRemainSec);
            Marshaler.Write(msg, ty.playerUSN1);
            Marshaler.Write(msg, ty.playerUSN2);
            Marshaler.Write(msg, ty.winnerUSN);
            Marshaler.Write(msg, ty.resultState);
            Marshaler.Write(msg, ty.playerWin1);
            Marshaler.Write(msg, ty.playerWin2);
        }

        public static void Write(Message msg, List<TournamentMatchInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchJoinResult ty)
        {
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
        }

        public static void Write(Message msg, List<TournamentMatchJoinResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchPlayFinishInfo ty)
        {
            Marshaler.Write(msg, ty.SEQ);
            Marshaler.Write(msg, ty.matchIndex);
            Marshaler.Write(msg, ty.matchState);
            Marshaler.Write(msg, ty.matchRoomSN);
            Marshaler.Write(msg, ty.matchWinnerUSN);
            Marshaler.Write(msg, ty.matchResultState);
            Marshaler.Write(msg, ty.playIndex);
            Marshaler.Write(msg, ty.playWinnerUSN);
            Marshaler.Write(msg, ty.playResultState);
            Marshaler.Write(msg, ty.replaySEQ);
            Marshaler.Write(msg, ty.relaySessionKey);
        }

        public static void Write(Message msg, List<TournamentMatchPlayFinishInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchPlayInfo ty)
        {
            Marshaler.Write(msg, ty.playIndex);
            Marshaler.Write(msg, ty.winnerUSN);
            Marshaler.Write(msg, ty.resultState);
            Marshaler.Write(msg, ty.replaySEQ);
        }

        public static void Write(Message msg, List<TournamentMatchPlayInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchResultState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TournamentMatchResultState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchStartResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.ingameSeed);
            Marshaler.Write(msg, ty.playerUSN1);
            Marshaler.Write(msg, ty.playerUSN2);
            Marshaler.Write(msg, ty.playerTeamIndex1);
            Marshaler.Write(msg, ty.playerTeamIndex2);
        }

        public static void Write(Message msg, List<TournamentMatchStartResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TournamentMatchState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchSuspendResult ty)
        {
            Marshaler.Write(msg, ty.SEQ);
            Marshaler.Write(msg, ty.matchInfo);
            Marshaler.Write(msg, ty.playerRank1);
            Marshaler.Write(msg, ty.playerRank2);
        }

        public static void Write(Message msg, List<TournamentMatchSuspendResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchUserProfileInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.skinChangeIDList);
            Marshaler.Write(msg, ty.weaponChangeIDList);
            Marshaler.Write(msg, ty.headChangeIDList);
            Marshaler.Write(msg, ty.skinHeadStyleChangedList);
            Marshaler.Write(msg, ty.bossStageTopClearRegion);
            Marshaler.Write(msg, ty.topClearStoryQuestID);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<TournamentMatchUserProfileInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentMatchWatcherJoinResult ty)
        {
            Marshaler.Write(msg, ty.relayServerInfo);
            Marshaler.Write(msg, ty.playKey);
            Marshaler.Write(msg, ty.playMode);
        }

        public static void Write(Message msg, List<TournamentMatchWatcherJoinResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentPlayerCheerInfo ty)
        {
            Marshaler.Write(msg, ty.USN);
            Marshaler.Write(msg, ty.cheerCount);
        }

        public static void Write(Message msg, List<TournamentPlayerCheerInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentPlayerInfo ty)
        {
            Marshaler.Write(msg, ty.USN);
            Marshaler.Write(msg, ty.tournamentRank);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<TournamentPlayerInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentProgressInfo ty)
        {
            Marshaler.Write(msg, ty.SEQ);
            Marshaler.Write(msg, ty.tournamentState);
            Marshaler.Write(msg, ty.stateRemainSec);
            Marshaler.Write(msg, ty.roundIndex);
            Marshaler.Write(msg, ty.roundState);
            Marshaler.Write(msg, ty.roundStateRemainSec);
        }

        public static void Write(Message msg, List<TournamentProgressInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentRoundState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TournamentRoundState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TournamentState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TournamentWatcherLoginResult ty)
        {
            Marshaler.Write(msg, ty.roomSN);
            Marshaler.Write(msg, ty.currentPlayIndex);
            Marshaler.Write(msg, ty.matchInfo);
            Marshaler.Write(msg, ty.replayBytesInfo);
        }

        public static void Write(Message msg, List<TournamentWatcherLoginResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TowerStageHeroInfo ty)
        {
            Marshaler.Write(msg, ty.updateFlag);
            Marshaler.Write(msg, ty.heroIDList);
        }

        public static void Write(Message msg, List<TowerStageHeroInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TowerStageInfo ty)
        {
            Marshaler.Write(msg, ty.clearStageID);
            Marshaler.Write(msg, ty.recvRewardStageID);
            Marshaler.Write(msg, ty.seasonId);
            Marshaler.Write(msg, ty.remainEndTimeSec);
            Marshaler.Write(msg, ty.topClearStageID);
        }

        public static void Write(Message msg, List<TowerStageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingInfo ty)
        {
            Marshaler.Write(msg, ty.heroKindType);
            Marshaler.Write(msg, ty.attackPowerCount);
            Marshaler.Write(msg, ty.magicPowerCount);
            Marshaler.Write(msg, ty.attackDefenceCount);
            Marshaler.Write(msg, ty.magicDefenceCount);
            Marshaler.Write(msg, ty.lifeCount);
            Marshaler.Write(msg, ty.attackPowerRating);
            Marshaler.Write(msg, ty.magicPowerRating);
            Marshaler.Write(msg, ty.attackDefenceRating);
            Marshaler.Write(msg, ty.magicDefenceRating);
            Marshaler.Write(msg, ty.lifeRating);
        }

        public static void Write(Message msg, List<TrainingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingStageClearStarInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.star);
        }

        public static void Write(Message msg, List<TrainingStageClearStarInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingStageInfo ty)
        {
            Marshaler.Write(msg, ty.remainSecToReset);
            Marshaler.Write(msg, ty.remainSecToClose);
            Marshaler.Write(msg, ty.stageList);
            Marshaler.Write(msg, ty.rewardGauge);
            Marshaler.Write(msg, ty.point);
            Marshaler.Write(msg, ty.mirrorTeamInfo);
            Marshaler.Write(msg, ty.trainingTaskID);
            Marshaler.Write(msg, ty.trainingTaskCount);
            Marshaler.Write(msg, ty.clearStarInfoList);
        }

        public static void Write(Message msg, List<TrainingStageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingStageInGameMissionClearInfo ty)
        {
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.star);
            Marshaler.Write(msg, ty.clearMissionIDList);
        }

        public static void Write(Message msg, List<TrainingStageInGameMissionClearInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingStageListInfo ty)
        {
            Marshaler.Write(msg, ty.remainCloseSec);
            Marshaler.Write(msg, ty.trainingStageList);
        }

        public static void Write(Message msg, List<TrainingStageListInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingStageSlotInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.state);
        }

        public static void Write(Message msg, List<TrainingStageSlotInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingStageState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TrainingStageState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TrainingStageType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TrainingStageType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TutorialStatus en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TutorialStatus> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, TutorialType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<TutorialType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UpgradeUserSkin ty)
        {
            Marshaler.Write(msg, ty.prevSkinID);
            Marshaler.Write(msg, ty.userSkin);
        }

        public static void Write(Message msg, List<UpgradeUserSkin> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserADViewInfo ty)
        {
            Marshaler.Write(msg, ty.adViewContentType);
            Marshaler.Write(msg, ty.viewCount);
            Marshaler.Write(msg, ty.coolRemainSec);
            Marshaler.Write(msg, ty.roulettePoint);
            //Marshaler.Write(msg, ty.lastViewUnxs);
        }

        public static void Write(Message msg, List<UserADViewInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserAncientWarInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.teamType);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.rewardIndex);
            Marshaler.Write(msg, ty.remainBattleStartSec);
            Marshaler.Write(msg, ty.isAutoTeamType);
            Marshaler.Write(msg, ty.donationCount);
            //Marshaler.Write(msg, ty.sendRewardMailYN);
            //Marshaler.Write(msg, ty.rankUnixTime);
        }

        public static void Write(Message msg, List<UserAncientWarInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserArtifact ty)
        {
            Marshaler.Write(msg, ty.artifactCardID);
        }

        public static void Write(Message msg, List<UserArtifact> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserArtifactTeamInfo ty)
        {
            Marshaler.Write(msg, ty.teamIndex);
            Marshaler.Write(msg, ty.unionId);
            Marshaler.Write(msg, ty.artifactCardIdList);
        }

        public static void Write(Message msg, List<UserArtifactTeamInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserArtifactUnionInfo ty)
        {
            Marshaler.Write(msg, ty.unionId);
            Marshaler.Write(msg, ty.exp);
        }

        public static void Write(Message msg, List<UserArtifactUnionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserArtifactWishEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.artifactCardIdList);
        }

        public static void Write(Message msg, List<UserArtifactWishEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserBasePointContentsInfo ty)
        {
            Marshaler.Write(msg, ty.basePointInfoList);
            Marshaler.Write(msg, ty.eventBasepointInfoList);
        }

        public static void Write(Message msg, List<UserBasePointContentsInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserBingoGachaEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.reward);
            Marshaler.Write(msg, ty.progress);
            Marshaler.Write(msg, ty.slotList);
        }

        public static void Write(Message msg, List<UserBingoGachaEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserBlitzStageEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.regionID);
            Marshaler.Write(msg, ty.mainStageID);
            Marshaler.Write(msg, ty.sideStageIDList);
            Marshaler.Write(msg, ty.freeStageValue);
            Marshaler.Write(msg, ty.lastClearStageID);
            Marshaler.Write(msg, ty.limitedStageValue);
            Marshaler.Write(msg, ty.bossStageValue);
        }

        public static void Write(Message msg, List<UserBlitzStageEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserBuffInfo ty)
        {
            Marshaler.Write(msg, ty.buffType);
            Marshaler.Write(msg, ty.targetID);
            Marshaler.Write(msg, ty.passiveID);
            Marshaler.Write(msg, ty.remainSecToRemove);
        }

        public static void Write(Message msg, List<UserBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserBuffType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<UserBuffType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserChallengeDestroyEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.point);
            Marshaler.Write(msg, ty.maxWorldPoint);
            Marshaler.Write(msg, ty.rewardIndex);
            Marshaler.Write(msg, ty.isWorldReward);
        }

        public static void Write(Message msg, List<UserChallengeDestroyEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserChapterClearEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.rewardedMissionChapterID);
        }

        public static void Write(Message msg, List<UserChapterClearEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserCheerEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.totalCheerCount);
            Marshaler.Write(msg, ty.gaugeRewardedID);
            Marshaler.Write(msg, ty.isFinishRewarded);
            Marshaler.Write(msg, ty.cheerGroupList);
        }

        public static void Write(Message msg, List<UserCheerEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserComebackType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<UserComebackType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserCommonItem ty)
        {
            Marshaler.Write(msg, ty.ItemID);
            Marshaler.Write(msg, ty.ItemCount);
        }

        public static void Write(Message msg, List<UserCommonItem> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserCostumeCraftUpgradeInfo ty)
        {
            Marshaler.Write(msg, ty.costumeGroup);
            Marshaler.Write(msg, ty.heroGroup);
            Marshaler.Write(msg, ty.upgradeAtk);
            Marshaler.Write(msg, ty.upgradeDef);
            Marshaler.Write(msg, ty.upgradeMaxHp);
        }

        public static void Write(Message msg, List<UserCostumeCraftUpgradeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserCostumeHead ty)
        {
            Marshaler.Write(msg, ty.costumeID);
            Marshaler.Write(msg, ty.exp);
            Marshaler.Write(msg, ty.upgrade);
            Marshaler.Write(msg, ty.heroGroupID);
            Marshaler.Write(msg, ty.costumeGroupID);
            Marshaler.Write(msg, ty.expireDate);
        }

        public static void Write(Message msg, List<UserCostumeHead> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserCostumeSkin ty)
        {
            Marshaler.Write(msg, ty.costumeID);
            Marshaler.Write(msg, ty.exp);
            Marshaler.Write(msg, ty.upgrade);
            Marshaler.Write(msg, ty.heroGroupID);
            Marshaler.Write(msg, ty.costumeGroupID);
            Marshaler.Write(msg, ty.expireDate);
        }

        public static void Write(Message msg, List<UserCostumeSkin> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserCostumeWeapon ty)
        {
            Marshaler.Write(msg, ty.costumeID);
            Marshaler.Write(msg, ty.exp);
            Marshaler.Write(msg, ty.upgrade);
            Marshaler.Write(msg, ty.heroGroupID);
            Marshaler.Write(msg, ty.costumeGroupID);
            Marshaler.Write(msg, ty.expireDate);
        }

        public static void Write(Message msg, List<UserCostumeWeapon> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserCreatureNestStageInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.isTeamSetting);
            Marshaler.Write(msg, ty.startStageID);
            Marshaler.Write(msg, ty.clearStageID);
            Marshaler.Write(msg, ty.rewardReceiveStage);
            Marshaler.Write(msg, ty.challengeRewardStatus);
            Marshaler.Write(msg, ty.passiveIDList);
        }

        public static void Write(Message msg, List<UserCreatureNestStageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserDailyReset ty)
        {
            Marshaler.Write(msg, ty.barrelCount);
            Marshaler.Write(msg, ty.friendDeleteCount);
            Marshaler.Write(msg, ty.floorSearchValue1);
            Marshaler.Write(msg, ty.floorSearchValue2);
            Marshaler.Write(msg, ty.floorSearchValue3);
            Marshaler.Write(msg, ty.floorSearchValue4);
            Marshaler.Write(msg, ty.lobbyQuestProgressInfoList);
            Marshaler.Write(msg, ty.attendanceInfo);
            Marshaler.Write(msg, ty.birthdayGuestIDList);
            Marshaler.Write(msg, ty.basepointDailyReward);
            Marshaler.Write(msg, ty.cleanTableCount);
            Marshaler.Write(msg, ty.serveBeerCount);
            Marshaler.Write(msg, ty.playJukeboxCount);
            Marshaler.Write(msg, ty.elizabethTouchCount);
            Marshaler.Write(msg, ty.hawkAngerCount);
            Marshaler.Write(msg, ty.meliodasCookingCount);
            Marshaler.Write(msg, ty.barrelFellowCount);
            Marshaler.Write(msg, ty.friendPointGainCount);
            Marshaler.Write(msg, ty.heroGachaOneDiaCount);
            Marshaler.Write(msg, ty.helbramCount);
            Marshaler.Write(msg, ty.friendCookingEatCount);
            Marshaler.Write(msg, ty.guildDonationCount1);
            Marshaler.Write(msg, ty.guildDonationCount2);
            Marshaler.Write(msg, ty.guildShopResetCount);
            Marshaler.Write(msg, ty.eventExchangeBoxGachaResetCount);
            Marshaler.Write(msg, ty.eventGagueChargeFreeCount);
            Marshaler.Write(msg, ty.eventGagueChargetPoint);
            Marshaler.Write(msg, ty.guildDonationContribution);
            Marshaler.Write(msg, ty.stageInfo);
            Marshaler.Write(msg, ty.userPackageInfoList);
            Marshaler.Write(msg, ty.userDiaShopPackageInfoList);
            Marshaler.Write(msg, ty.guildMissionInfoList);
            Marshaler.Write(msg, ty.eventPacketInfo);
            Marshaler.Write(msg, ty.inviteSpecialGuestCount);
            Marshaler.Write(msg, ty.trainingStageRefreshCount);
            Marshaler.Write(msg, ty.lobbyGuestInfo);
            Marshaler.Write(msg, ty.userAdViewInfoList);
            Marshaler.Write(msg, ty.subdueBossPlayInfoList);
            Marshaler.Write(msg, ty.patrolInfo);
            Marshaler.Write(msg, ty.eventLadderPlayCount);
            Marshaler.Write(msg, ty.arenaSmashTeamUpdateCount);
            Marshaler.Write(msg, ty.arenaSmashWinRewardedCount);
            Marshaler.Write(msg, ty.eventTreasureHuntDiceCount);
            Marshaler.Write(msg, ty.guildExpBoostStack);
            Marshaler.Write(msg, ty.destroyLiveJoinCount);
            Marshaler.Write(msg, ty.lobbyCollectPassiveUseCount);
            Marshaler.Write(msg, ty.freeClearTicketUseCount);
            Marshaler.Write(msg, ty.gambleFreeCount);
            Marshaler.Write(msg, ty.dailyFreeGambleInfoClientSend);
            Marshaler.Write(msg, ty.itemResultInfoList);
            Marshaler.Write(msg, ty.constellationChaosInfo);
            Marshaler.Write(msg, ty.guildOrderMissionInfoClientSend);
            Marshaler.Write(msg, ty.userGuildOrderMissionInfoClientSend);
        }

        public static void Write(Message msg, List<UserDailyReset> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserDemonLordInfo ty)
        {
            //Marshaler.Write(msg, ty.isDemonLordStageOpen);
            //Marshaler.Write(msg, ty.isDemonLordFreeOpen);
            //Marshaler.Write(msg, ty.demonLordStageAlreadyClearIndex);
            Marshaler.Write(msg, ty.demonLordOpenTime);
        }

        public static void Write(Message msg, List<UserDemonLordInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserDemonLordInfoToClientSend ty)
        {
            Marshaler.Write(msg, ty.isDemonLordStageOpen);
            Marshaler.Write(msg, ty.isDemonLordFreeOpen);
            Marshaler.Write(msg, ty.demonLordStageAlreadyClearIndex);
            Marshaler.Write(msg, ty.demonLordOpenTime);
            Marshaler.Write(msg, ty.remainWeekResetSec);
        }

        public static void Write(Message msg, List<UserDemonLordInfoToClientSend> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserDiaBuyEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.diaBuyInfoList);
            Marshaler.Write(msg, ty.totalBuyCount);
            //Marshaler.Write(msg, ty.monthSEQ);
        }

        public static void Write(Message msg, List<UserDiaBuyEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserDonationEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.basepointID);
            Marshaler.Write(msg, ty.donationValue);
            Marshaler.Write(msg, ty.rewardFlag);
        }

        public static void Write(Message msg, List<UserDonationEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventBalloonDartInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.step);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.totalScore);
            Marshaler.Write(msg, ty.dartType);
            Marshaler.Write(msg, ty.balloonList);
            Marshaler.Write(msg, ty.chanceType);
            Marshaler.Write(msg, ty.chanceBalloonList);
            Marshaler.Write(msg, ty.stepRewardedList);
            Marshaler.Write(msg, ty.totalRewardedList);
        }

        public static void Write(Message msg, List<UserEventBalloonDartInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventBingoInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.reward);
            Marshaler.Write(msg, ty.progress);
            Marshaler.Write(msg, ty.numberSlotList);
            Marshaler.Write(msg, ty.rewardSlotList);
            Marshaler.Write(msg, ty.resetCount);
        }

        public static void Write(Message msg, List<UserEventBingoInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventBoxWishInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.wishId);
        }

        public static void Write(Message msg, List<UserEventBoxWishInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventConquesClientSendInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.conquestProductionDepotInfoList);
            Marshaler.Write(msg, ty.conquestAreaInfoList);
            Marshaler.Write(msg, ty.lastedAttackAreaID);
            Marshaler.Write(msg, ty.sceneIndex);
            Marshaler.Write(msg, ty.units);
            Marshaler.Write(msg, ty.stageClaerAreaList);
        }

        public static void Write(Message msg, List<UserEventConquesClientSendInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventDiceInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.rollCount);
            Marshaler.Write(msg, ty.position);
            Marshaler.Write(msg, ty.activeQuestionID);
            Marshaler.Write(msg, ty.raceCount);
            Marshaler.Write(msg, ty.raceRewardFlag);
            Marshaler.Write(msg, ty.isBonusDice);
            Marshaler.Write(msg, ty.currentRollList);
            Marshaler.Write(msg, ty.isNeedEvent);
        }

        public static void Write(Message msg, List<UserEventDiceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventGachaWishInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.remainCount);
            Marshaler.Write(msg, ty.skinId);
        }

        public static void Write(Message msg, List<UserEventGachaWishInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventGambleBoxInfoToClientSend ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.step);
            Marshaler.Write(msg, ty.pickList);
        }

        public static void Write(Message msg, List<UserEventGambleBoxInfoToClientSend> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventInfo ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.step);
            Marshaler.Write(msg, ty.progress);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.status);
        }

        public static void Write(Message msg, List<UserEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventLobbyBuffInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.pointInfo);
            Marshaler.Write(msg, ty.buffList);
        }

        public static void Write(Message msg, List<UserEventLobbyBuffInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventLobbyDecorationInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.rewardFlag);
        }

        public static void Write(Message msg, List<UserEventLobbyDecorationInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventLuckyBoxInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.userRewardedList);
            Marshaler.Write(msg, ty.rewardedAllList);
        }

        public static void Write(Message msg, List<UserEventLuckyBoxInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventMoleGameInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.totalScore);
            Marshaler.Write(msg, ty.totalScoreRewardFlag);
            Marshaler.Write(msg, ty.highScore);
            Marshaler.Write(msg, ty.playCount);
        }

        public static void Write(Message msg, List<UserEventMoleGameInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventPuzzleBlockInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.blockID);
            Marshaler.Write(msg, ty.blockScore);
            Marshaler.Write(msg, ty.blockMatchCount);
            Marshaler.Write(msg, ty.blockRewardFlag);
        }

        public static void Write(Message msg, List<UserEventPuzzleBlockInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventPuzzleBlockSet ty)
        {
            Marshaler.Write(msg, ty.blockID);
            Marshaler.Write(msg, ty.scoreRate);
        }

        public static void Write(Message msg, List<UserEventPuzzleBlockSet> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventPuzzleInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.setBlockIDList);
            Marshaler.Write(msg, ty.totalScore);
            Marshaler.Write(msg, ty.totalScoreRewardFlag);
            Marshaler.Write(msg, ty.highScore);
        }

        public static void Write(Message msg, List<UserEventPuzzleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventRecipeInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.recipeID);
            Marshaler.Write(msg, ty.recipeActive);
        }

        public static void Write(Message msg, List<UserEventRecipeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserEventRoadInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventType);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.floor);
            Marshaler.Write(msg, ty.scoreList);
            Marshaler.Write(msg, ty.scoreRewardList);
            Marshaler.Write(msg, ty.passIndex);
            Marshaler.Write(msg, ty.passCount);
            Marshaler.Write(msg, ty.collection);
        }

        public static void Write(Message msg, List<UserEventRoadInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserExchangeEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.exchangeID);
            Marshaler.Write(msg, ty.dailyExchangeCount);
            Marshaler.Write(msg, ty.totalExchangeCount);
            Marshaler.Write(msg, ty.eventType);
        }

        public static void Write(Message msg, List<UserExchangeEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserExtensionData ty)
        {
            Marshaler.Write(msg, ty.itemInventoryMax);
            Marshaler.Write(msg, ty.weaponInventoryMax);
        }

        public static void Write(Message msg, List<UserExtensionData> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserExtraStageInfo ty)
        {
            Marshaler.Write(msg, ty.extraGroupID);
            Marshaler.Write(msg, ty.clearID);
        }

        public static void Write(Message msg, List<UserExtraStageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserFinalBossDifficultyRankInfo ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.difficulty);
            Marshaler.Write(msg, ty.firstRewardYN);
            //Marshaler.Write(msg, ty.usn);
            //Marshaler.Write(msg, ty.topRankPoint);
            //Marshaler.Write(msg, ty.topRankUnxs);
            //Marshaler.Write(msg, ty.skinIDList);
            //Marshaler.Write(msg, ty.isTopRankRefresh);
            //Marshaler.Write(msg, ty.rank);
            //Marshaler.Write(msg, ty.totalRankUpCount);
        }

        public static void Write(Message msg, List<UserFinalBossDifficultyRankInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserFinalBossRankPoint ty)
        {
            Marshaler.Write(msg, ty.seasonID);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.topRankPoint);
            Marshaler.Write(msg, ty.skinIDList);
            Marshaler.Write(msg, ty.rank);
            Marshaler.Write(msg, ty.totolRankUpCount);
            Marshaler.Write(msg, ty.score);
            Marshaler.Write(msg, ty.lastScoreRewardOrder);
            //Marshaler.Write(msg, ty.usn);
            //Marshaler.Write(msg, ty.rewardYN);
            //Marshaler.Write(msg, ty.topRankUnxs);
            //Marshaler.Write(msg, ty.isTopRankRefresh);
            //Marshaler.Write(msg, ty.isFinalBossDifficultyHeroRankRefresh);
            //Marshaler.Write(msg, ty.difficulty);
            //Marshaler.Write(msg, ty.difficultyRankSkinIDList);
            //Marshaler.Write(msg, ty.difficultyTopRankPoint);
            //Marshaler.Write(msg, ty.difficultyTopRankUnxs);
        }

        public static void Write(Message msg, List<UserFinalBossRankPoint> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserFinalBossStageEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.bossStageValue);
            Marshaler.Write(msg, ty.mainBossStageTopClearID);
            Marshaler.Write(msg, ty.lastClearStageID);
        }

        public static void Write(Message msg, List<UserFinalBossStageEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserFreeStageEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.freeStageValue);
            Marshaler.Write(msg, ty.lastClearStageID);
        }

        public static void Write(Message msg, List<UserFreeStageEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserFrozenAsset ty)
        {
            Marshaler.Write(msg, ty.seq);
            Marshaler.Write(msg, ty.contentTypeID);
            Marshaler.Write(msg, ty.needItemInfoList);
        }

        public static void Write(Message msg, List<UserFrozenAsset> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserFurniture ty)
        {
            Marshaler.Write(msg, ty.furnitureGroup);
            Marshaler.Write(msg, ty.furnitureID);
            Marshaler.Write(msg, ty.buffFurnitureID);
        }

        public static void Write(Message msg, List<UserFurniture> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserFurnitureEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.isRegist);
            //Marshaler.Write(msg, ty.int>);
        }

        public static void Write(Message msg, List<UserFurnitureEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserGachaEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.buyCount);
        }

        public static void Write(Message msg, List<UserGachaEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserGachaEventOnceInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.id);
            Marshaler.Write(msg, ty.freeCount);
        }

        public static void Write(Message msg, List<UserGachaEventOnceInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserGagueEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.gagueGroupID);
            Marshaler.Write(msg, ty.progress);
            Marshaler.Write(msg, ty.rewardIndex);
        }

        public static void Write(Message msg, List<UserGagueEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserGlobalDropEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.globalDropSlotItemCountList);
        }

        public static void Write(Message msg, List<UserGlobalDropEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserGuildOrderMissionInfo ty)
        {
            Marshaler.Write(msg, ty.missionID);
            Marshaler.Write(msg, ty.progress);
            Marshaler.Write(msg, ty.rewardYN);
            Marshaler.Write(msg, ty.entryMemberInfoList);
        }

        public static void Write(Message msg, List<UserGuildOrderMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserHero ty)
        {
            Marshaler.Write(msg, ty.heroID);
        }

        public static void Write(Message msg, List<UserHero> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserHeroGachaGaugeInfo ty)
        {
            Marshaler.Write(msg, ty.gambleGroup);
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.gauge);
            Marshaler.Write(msg, ty.rewardStep);
            Marshaler.Write(msg, ty.rewardCount);
        }

        public static void Write(Message msg, List<UserHeroGachaGaugeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserHeroLeagueInfo ty)
        {
            Marshaler.Write(msg, ty.league);
            Marshaler.Write(msg, ty.useTeamCount);
            Marshaler.Write(msg, ty.winCount);
            Marshaler.Write(msg, ty.currentUserGroup);
            Marshaler.Write(msg, ty.rewardInfo);
            Marshaler.Write(msg, ty.scoreRewardInfo);
            //Marshaler.Write(msg, ty.season);
            //Marshaler.Write(msg, ty.week);
        }

        public static void Write(Message msg, List<UserHeroLeagueInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserHeroPassiveGroupInfo ty)
        {
            Marshaler.Write(msg, ty.heroPassiveGroup);
            Marshaler.Write(msg, ty.dailyUseCount);
        }

        public static void Write(Message msg, List<UserHeroPassiveGroupInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserKOFBritanniaEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.isStarted);
            Marshaler.Write(msg, ty.challengeStageGauge);
            Marshaler.Write(msg, ty.challengeStageID);
            Marshaler.Write(msg, ty.teamID);
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.mercenaryHeroIDList);
            Marshaler.Write(msg, ty.completedTeamIDList);
        }

        public static void Write(Message msg, List<UserKOFBritanniaEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserLevelUpResult ty)
        {
            Marshaler.Write(msg, ty.apInfoList);
        }

        public static void Write(Message msg, List<UserLevelUpResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserListStageEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.freeStageValue);
            Marshaler.Write(msg, ty.mainStageTopClearID);
            Marshaler.Write(msg, ty.lastClearStageID);
        }

        public static void Write(Message msg, List<UserListStageEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserLoginState en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<UserLoginState> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserMarketingInfo ty)
        {
            Marshaler.Write(msg, ty.firstBuy);
            Marshaler.Write(msg, ty.firstEvolution);
            Marshaler.Write(msg, ty.firstPVP);
            Marshaler.Write(msg, ty.firstBoss);
            Marshaler.Write(msg, ty.firstWeeklyStage);
            Marshaler.Write(msg, ty.firstMainStageClear);
            Marshaler.Write(msg, ty.gambleCount);
            Marshaler.Write(msg, ty.urGet);
            Marshaler.Write(msg, ty.vipUser);
            Marshaler.Write(msg, ty.firstDiaBuy);
        }

        public static void Write(Message msg, List<UserMarketingInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserMazeEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.stageID);
            Marshaler.Write(msg, ty.rewardedIndex);
            Marshaler.Write(msg, ty.randomBattleStageID);
            Marshaler.Write(msg, ty.randomStageID1);
            Marshaler.Write(msg, ty.randomStageID2);
            Marshaler.Write(msg, ty.randomValue1);
            Marshaler.Write(msg, ty.randomValue2);
            Marshaler.Write(msg, ty.startedStageID);
            Marshaler.Write(msg, ty.heroRefreshCount);
            Marshaler.Write(msg, ty.passiveRefreshCount);
            Marshaler.Write(msg, ty.topSpotID);
            Marshaler.Write(msg, ty.clearBonusProgressType);
            Marshaler.Write(msg, ty.seasonShopBuyPoint);
            Marshaler.Write(msg, ty.selectablePassiveIDList);
            Marshaler.Write(msg, ty.selectableHeroIDList);
            Marshaler.Write(msg, ty.passiveIDList);
            Marshaler.Write(msg, ty.lastPassiveIDList);
            Marshaler.Write(msg, ty.savedPassiveIDList);
            Marshaler.Write(msg, ty.mazeHeroInfoList);
            Marshaler.Write(msg, ty.savedHeroInfoList);
            Marshaler.Write(msg, ty.shopPassiveIDList);
            Marshaler.Write(msg, ty.shopIDList);
            Marshaler.Write(msg, ty.shopBuyProductIDList);
            Marshaler.Write(msg, ty.shopBuffIDList);
            Marshaler.Write(msg, ty.shopBuyBuffIDList);
            Marshaler.Write(msg, ty.buffInfoList);
            //Marshaler.Write(msg, ty.lastHeroInfoList);
            //Marshaler.Write(msg, ty.seasonShopBuyInfoList);
            //Marshaler.Write(msg, ty.isSeasonShopInitialized);
        }

        public static void Write(Message msg, List<UserMazeEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserMissionEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.chainID);
            Marshaler.Write(msg, ty.rewardIndex);
            Marshaler.Write(msg, ty.progressValue);
        }

        public static void Write(Message msg, List<UserMissionEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserMonthlyStageInfo ty)
        {
            Marshaler.Write(msg, ty.monthlyID);
            Marshaler.Write(msg, ty.lastCountRewardIndex);
            Marshaler.Write(msg, ty.lastClearStageIDList);
            Marshaler.Write(msg, ty.monthlyRemainSec);
        }

        public static void Write(Message msg, List<UserMonthlyStageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserMusic ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.name);
            Marshaler.Write(msg, ty.tempo);
            Marshaler.Write(msg, ty.beat);
            Marshaler.Write(msg, ty.code);
        }

        public static void Write(Message msg, List<UserMusic> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserNpc ty)
        {
            //Marshaler.Write(msg, ty.serverTalkAnswered);
            Marshaler.Write(msg, ty.guestID);
            Marshaler.Write(msg, ty.giftIndex);
            Marshaler.Write(msg, ty.costumeID);
            Marshaler.Write(msg, ty.subCostumeID);
            Marshaler.Write(msg, ty.talkCount);
            Marshaler.Write(msg, ty.questionID);
            Marshaler.Write(msg, ty.goodTalkCount);
            Marshaler.Write(msg, ty.lovePoint);
            Marshaler.Write(msg, ty.giftState);
        }

        public static void Write(Message msg, List<UserNpc> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserNpcResult ty)
        {
            Marshaler.Write(msg, ty.guestID);
            Marshaler.Write(msg, ty.lovePoint);
        }

        public static void Write(Message msg, List<UserNpcResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPackageInfo ty)
        {
            Marshaler.Write(msg, ty.packageID);
            Marshaler.Write(msg, ty.buyCount);
            Marshaler.Write(msg, ty.buyTime);
            Marshaler.Write(msg, ty.expireTIme);
            Marshaler.Write(msg, ty.remainResetTimeSEC);
            Marshaler.Write(msg, ty.rewardValue);
            Marshaler.Write(msg, ty.dayCount);
            Marshaler.Write(msg, ty.rewardAble);
            Marshaler.Write(msg, ty.isExpire);
        }

        public static void Write(Message msg, List<UserPackageInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPackageMissionInfo ty)
        {
            //Marshaler.Write(msg, ty.packageBuyExpireDate);
            //Marshaler.Write(msg, ty.packageId);
            Marshaler.Write(msg, ty.packageMissionID);
            Marshaler.Write(msg, ty.packageMissionStatus);
            Marshaler.Write(msg, ty.packageBuyExpireRemainSEC);
            Marshaler.Write(msg, ty.progress);
        }

        public static void Write(Message msg, List<UserPackageMissionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPaybackEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.paybackGroupID);
            Marshaler.Write(msg, ty.progress);
            Marshaler.Write(msg, ty.rewardID);
            Marshaler.Write(msg, ty.resetCount);
        }

        public static void Write(Message msg, List<UserPaybackEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPlayCountEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.playCount);
            Marshaler.Write(msg, ty.getReward);
        }

        public static void Write(Message msg, List<UserPlayCountEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPredictInfo ty)
        {
            Marshaler.Write(msg, ty.Index);
            Marshaler.Write(msg, ty.upgradeCount);
        }

        public static void Write(Message msg, List<UserPredictInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserProfileInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.nickname);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<UserProfileInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserProvisionEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.isFinalRewardReceived);
            Marshaler.Write(msg, ty.sectionInfoList);
        }

        public static void Write(Message msg, List<UserProvisionEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserProvisionEventSectionInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.sectionID);
            Marshaler.Write(msg, ty.provideCountList);
            Marshaler.Write(msg, ty.isSectionRewardReceived);
        }

        public static void Write(Message msg, List<UserProvisionEventSectionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPvpShopGradeInfo ty)
        {
            Marshaler.Write(msg, ty.arenaRealTimePvpLowerGrade);
            Marshaler.Write(msg, ty.arenaRealTimePvpLowerGradeNumber);
            Marshaler.Write(msg, ty.arenaRealTimePvpGrade);
            Marshaler.Write(msg, ty.arenaRealTimePvpGradeNumber);
        }

        public static void Write(Message msg, List<UserPvpShopGradeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPVPWinCountEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.weekInfoList);
        }

        public static void Write(Message msg, List<UserPVPWinCountEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserPVPWinCountEventWeekInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.week);
            Marshaler.Write(msg, ty.winCount);
            Marshaler.Write(msg, ty.rewardIndex);
        }

        public static void Write(Message msg, List<UserPVPWinCountEventWeekInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserRandomBoxEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.freeCount);
            Marshaler.Write(msg, ty.mileage);
            Marshaler.Write(msg, ty.boxInfoList);
        }

        public static void Write(Message msg, List<UserRandomBoxEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserRandomLuckybagInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.openValue);
            Marshaler.Write(msg, ty.lastReward);
            Marshaler.Write(msg, ty.rewardValue);
        }

        public static void Write(Message msg, List<UserRandomLuckybagInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserRecipeInfo ty)
        {
            Marshaler.Write(msg, ty.recipeID);
            Marshaler.Write(msg, ty.recipeExp);
            Marshaler.Write(msg, ty.recipeActive);
        }

        public static void Write(Message msg, List<UserRecipeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserSimpleInfo ty)
        {
            //Marshaler.Write(msg, ty.skinCostumeExpireDate);
            //Marshaler.Write(msg, ty.weaponCostumeExpireDate);
            //Marshaler.Write(msg, ty.headCostumeExpireDate);
            //Marshaler.Write(msg, ty.stageStartTimeTicks);
            Marshaler.Write(msg, ty.USN);
            Marshaler.Write(msg, ty.NickName);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.mainSkinExp);
            Marshaler.Write(msg, ty.mainCostumeGroupID);
            Marshaler.Write(msg, ty.mainWeaponCostumeGroupID);
            Marshaler.Write(msg, ty.mainHeadCostumeGroupID);
            Marshaler.Write(msg, ty.mainIsHeadStyleChanged);
            Marshaler.Write(msg, ty.simpleInfoSlotInfoList);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.friendReddot);
            Marshaler.Write(msg, ty.friendApplyReddot);
            Marshaler.Write(msg, ty.guildReddot);
            Marshaler.Write(msg, ty.bossTopClearRegion);
            Marshaler.Write(msg, ty.topClearStoryQuestID);
            Marshaler.Write(msg, ty.destroyInviteOption);
            Marshaler.Write(msg, ty.isGuildInvitationOn);
            Marshaler.Write(msg, ty.guildRoomPoint);
            Marshaler.Write(msg, ty.guildInfoRefresh);
            Marshaler.Write(msg, ty.topVisitBasepointID);
            Marshaler.Write(msg, ty.topClearMainStageID);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.friendlytMatchInviteOption);
            Marshaler.Write(msg, ty.friendCookingEatTotalCount);
            Marshaler.Write(msg, ty.guildReddot1);
            Marshaler.Write(msg, ty.guildReddot2);
            Marshaler.Write(msg, ty.guildReddot3);
            Marshaler.Write(msg, ty.recipeOrderCount);
            Marshaler.Write(msg, ty.topClearEventQuestID);
            Marshaler.Write(msg, ty.playTitleID);
            Marshaler.Write(msg, ty.arenaSmashBattlePoint);
            Marshaler.Write(msg, ty.arenaSmashRecordSN);
        }

        public static void Write(Message msg, List<UserSimpleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserSkin ty)
        {
            //Marshaler.Write(msg, ty.getSkinID);
            //Marshaler.Write(msg, ty.goldBuffValue);
            //Marshaler.Write(msg, ty.dropBuffValue);
            //Marshaler.Write(msg, ty.expBuffValue);
            //Marshaler.Write(msg, ty.skinMaterialCount);
            //Marshaler.Write(msg, ty.isFellowshipMax);
            //Marshaler.Write(msg, ty.heroContentsPassiveID);
            Marshaler.Write(msg, ty.skinOwnerHeroID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinExp);
            Marshaler.Write(msg, ty.skinFellowshipExp);
            Marshaler.Write(msg, ty.lastFellowRewardIndex);
            Marshaler.Write(msg, ty.awaken);
            Marshaler.Write(msg, ty.skillLevelUpCount);
            Marshaler.Write(msg, ty.maxLevelCount);
            Marshaler.Write(msg, ty.passiveSkillLevel);
            Marshaler.Write(msg, ty.equipWeaponList);
            Marshaler.Write(msg, ty.researchList);
            Marshaler.Write(msg, ty.skinCostumeGroupID);
            Marshaler.Write(msg, ty.weaponCostumeGroupID);
            Marshaler.Write(msg, ty.headCostumeGroupID);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
            Marshaler.Write(msg, ty.firstResearchType);
            Marshaler.Write(msg, ty.firstResearchSlot);
            Marshaler.Write(msg, ty.registeredCostumeGroupList);
            Marshaler.Write(msg, ty.trainingStagePlayCount);
            Marshaler.Write(msg, ty.usedGuildBossSeq);
            Marshaler.Write(msg, ty.usedEventChallengeBossSeq);
            Marshaler.Write(msg, ty.transcend);
            Marshaler.Write(msg, ty.registeredMadeCostumeGroup);
            Marshaler.Write(msg, ty.heroLeagueUserGroup);
            Marshaler.Write(msg, ty.exceed);
            Marshaler.Write(msg, ty.levelUpBonusRewardIndex);
        }

        public static void Write(Message msg, List<UserSkin> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserSkinOneStepEvolutionEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.skinOneStepEvolutionCount);
        }

        public static void Write(Message msg, List<UserSkinOneStepEvolutionEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserSnsShareEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.shareCount);
            Marshaler.Write(msg, ty.rewardYN);
        }

        public static void Write(Message msg, List<UserSnsShareEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserStepupGachaEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.stepNo);
            Marshaler.Write(msg, ty.stepCount);
            Marshaler.Write(msg, ty.mileage);
            Marshaler.Write(msg, ty.mileageReward);
            Marshaler.Write(msg, ty.stepRotationCount);
            //Marshaler.Write(msg, ty.stepRotationOccur);
            //Marshaler.Write(msg, ty.stepRotationIndex);
        }

        public static void Write(Message msg, List<UserStepupGachaEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserStepupMissionEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.stepupMissionGroupID);
            Marshaler.Write(msg, ty.isAllStepCompleted);
        }

        public static void Write(Message msg, List<UserStepupMissionEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserSubdueBossPlayInfo ty)
        {
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.playSeq);
            Marshaler.Write(msg, ty.playCount);
        }

        public static void Write(Message msg, List<UserSubdueBossPlayInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserTeam ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.name);
            Marshaler.Write(msg, ty.teamSlotList);
            Marshaler.Write(msg, ty.defenceBuffID);
        }

        public static void Write(Message msg, List<UserTeam> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserTeamChangeInfo ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.teamSlotList);
            Marshaler.Write(msg, ty.battlePowerPoint);
            Marshaler.Write(msg, ty.defenceBuffID);
        }

        public static void Write(Message msg, List<UserTeamChangeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserTeamSlot ty)
        {
            Marshaler.Write(msg, ty.index);
            Marshaler.Write(msg, ty.heroID);
            Marshaler.Write(msg, ty.heroGroupID);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.fateHeroID);
            Marshaler.Write(msg, ty.fateHeroGroupID);
            Marshaler.Write(msg, ty.fateSkinID);
        }

        public static void Write(Message msg, List<UserTeamSlot> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserTimeMissionEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSeq);
            Marshaler.Write(msg, ty.timeMissionStartUnixSec);
        }

        public static void Write(Message msg, List<UserTimeMissionEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserTreasureHuntEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.isStarted);
            Marshaler.Write(msg, ty.pointID);
            Marshaler.Write(msg, ty.groupID);
            Marshaler.Write(msg, ty.groupRestartCount);
            Marshaler.Write(msg, ty.completeCount);
            Marshaler.Write(msg, ty.completeRewardIndex);
            Marshaler.Write(msg, ty.pointCompleteBits);
            Marshaler.Write(msg, ty.pointMissionSuccessBits);
            Marshaler.Write(msg, ty.pointRewardBits);
        }

        public static void Write(Message msg, List<UserTreasureHuntEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserTutorialInfo ty)
        {
            Marshaler.Write(msg, ty.tutorialType);
            Marshaler.Write(msg, ty.tutorialStatus);
            Marshaler.Write(msg, ty.tutorialStep);
        }

        public static void Write(Message msg, List<UserTutorialInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserWeapon ty)
        {
            //Marshaler.Write(msg, ty.isEvolutionRewarded);
            Marshaler.Write(msg, ty.weaponSerial);
            Marshaler.Write(msg, ty.weaponBaseID);
            Marshaler.Write(msg, ty.upgrade);
            Marshaler.Write(msg, ty.evolution);
            Marshaler.Write(msg, ty.addPassiveSkillList);
            Marshaler.Write(msg, ty.addMagicSkill);
            Marshaler.Write(msg, ty.getWeaponTime);
            Marshaler.Write(msg, ty.isEquip);
            Marshaler.Write(msg, ty.defaultOptionValue);
            Marshaler.Write(msg, ty.isLock);
            Marshaler.Write(msg, ty.carveHeroGroup);
        }

        public static void Write(Message msg, List<UserWeapon> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserWeaponPassiveSkill ty)
        {
            Marshaler.Write(msg, ty.passiveID);
            Marshaler.Write(msg, ty.passiveValue);
        }

        public static void Write(Message msg, List<UserWeaponPassiveSkill> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserWeeklyStageEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.eventSubIndex);
            Marshaler.Write(msg, ty.firstWeeklyValue);
            Marshaler.Write(msg, ty.lastClearStageID);
        }

        public static void Write(Message msg, List<UserWeeklyStageEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, UserWorldAreaStageEventInfo ty)
        {
            Marshaler.Write(msg, ty.eventSEQ);
            Marshaler.Write(msg, ty.regionID);
            Marshaler.Write(msg, ty.mainStageID);
            Marshaler.Write(msg, ty.sideStageIDList);
            Marshaler.Write(msg, ty.freeStageValue);
            Marshaler.Write(msg, ty.lastClearStageID);
            Marshaler.Write(msg, ty.limitedStageValue);
            Marshaler.Write(msg, ty.bossStageValue);
        }

        public static void Write(Message msg, List<UserWorldAreaStageEventInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, VersionInfo ty)
        {
            Marshaler.Write(msg, ty.clientVersion);
            Marshaler.Write(msg, ty.cdnVersion);
        }

        public static void Write(Message msg, List<VersionInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeaponAutoGrindOption ty)
        {
            Marshaler.Write(msg, ty.isAutoOn);
            Marshaler.Write(msg, ty.ratingFlag);
            Marshaler.Write(msg, ty.setFlag);
            Marshaler.Write(msg, ty.partFlag);
            Marshaler.Write(msg, ty.optionValueRate);
            Marshaler.Write(msg, ty.isOptionValueOff);
        }

        public static void Write(Message msg, List<WeaponAutoGrindOption> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeaponAutoGrindResult ty)
        {
            Marshaler.Write(msg, ty.grindWeaponIDList);
            Marshaler.Write(msg, ty.grindGetItemResultInfoList);
        }

        public static void Write(Message msg, List<WeaponAutoGrindResult> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeaponExchangeMode en)
        {
            msg.Write((int)en);
        }
        public static void Write(Message msg, List<WeaponExchangeMode> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeaponOptionSuccessType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<WeaponOptionSuccessType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeaponPartsType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<WeaponPartsType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeaponSetType en)
        {
            msg.Write((byte)en);
        }

        public static void Write(Message msg, List<WeaponSetType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeaponUpgradeFailGaugeInfo ty)
        {
            Marshaler.Write(msg, ty.rating);
            Marshaler.Write(msg, ty.gauge);
        }

        public static void Write(Message msg, List<WeaponUpgradeFailGaugeInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeekStageCoinOpenType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<WeekStageCoinOpenType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeekStageGroupType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<WeekStageGroupType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WeekStageType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<WeekStageType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestRoomInfo ty)
        {
            //Marshaler.Write(msg, ty.isActive);
            Marshaler.Write(msg, ty.westRoomID);
            Marshaler.Write(msg, ty.roomType);
            Marshaler.Write(msg, ty.channelID);
            Marshaler.Write(msg, ty.userCount);
            Marshaler.Write(msg, ty.serverID);
            Marshaler.Write(msg, ty.serverPort);
        }

        public static void Write(Message msg, List<WestRoomInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestRoomType en)
        {
            msg.Write((byte)en);
        }
        public static void Write(Message msg, List<WestRoomType> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestServerInfo ty)
        {
            Marshaler.Write(msg, ty.serverID);
            Marshaler.Write(msg, ty.serverPort);
        }

        public static void Write(Message msg, List<WestServerInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestServerLoginInfo ty)
        {
            Marshaler.Write(msg, ty.usn);
            Marshaler.Write(msg, ty.sessionKey);
            Marshaler.Write(msg, ty.joinChannelID);
            Marshaler.Write(msg, ty.roomType);
        }

        public static void Write(Message msg, List<WestServerLoginInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestSideMoveInfo ty)
        {
            Marshaler.Write(msg, ty.targetUSN);
            Marshaler.Write(msg, ty.x);
            Marshaler.Write(msg, ty.z);
            Marshaler.Write(msg, ty.prevState);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.motion);
        }

        public static void Write(Message msg, List<WestSideMoveInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestSidePoint ty)
        {
            Marshaler.Write(msg, ty.x);
            Marshaler.Write(msg, ty.z);
            Marshaler.Write(msg, ty.prevState);
            Marshaler.Write(msg, ty.state);
            Marshaler.Write(msg, ty.motion);
        }

        public static void Write(Message msg, List<WestSidePoint> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestSideServerInfo ty)
        {
            Marshaler.Write(msg, ty.serverIP);
            Marshaler.Write(msg, ty.serverPort);
            Marshaler.Write(msg, ty.channelID);
            Marshaler.Write(msg, ty.roomType);
        }

        public static void Write(Message msg, List<WestSideServerInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestSideUserInfo ty)
        {
            Marshaler.Write(msg, ty.userUSN);
            Marshaler.Write(msg, ty.nickName);
            Marshaler.Write(msg, ty.userRankExp);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.point);
            Marshaler.Write(msg, ty.skinID);
            Marshaler.Write(msg, ty.skinCostumeGroupID);
            Marshaler.Write(msg, ty.weaponCostumeGroupID);
            Marshaler.Write(msg, ty.headCostumeGroupID);
            Marshaler.Write(msg, ty.isHeadStyleChanged);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBackgroundID);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<WestSideUserInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, WestSideUserSimpleInfo ty)
        {
            Marshaler.Write(msg, ty.USN);
            Marshaler.Write(msg, ty.userExp);
            Marshaler.Write(msg, ty.NickName);
            Marshaler.Write(msg, ty.mainSkinID);
            Marshaler.Write(msg, ty.mainSkinExp);
            Marshaler.Write(msg, ty.userWantToSay);
            Marshaler.Write(msg, ty.guildSN);
            Marshaler.Write(msg, ty.guildName);
            Marshaler.Write(msg, ty.guildIconID);
            Marshaler.Write(msg, ty.guildSubIconID);
            Marshaler.Write(msg, ty.guildBGIconID);
            Marshaler.Write(msg, ty.playTitleID);
        }

        public static void Write(Message msg, List<WestSideUserSimpleInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, YggdrasilTowerStageClearRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearRequestInfo);
        }

        public static void Write(Message msg, List<YggdrasilTowerStageClearRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, YggdrasilTowerStageClearResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageClearResultInfo);
        }

        public static void Write(Message msg, List<YggdrasilTowerStageClearResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, YggdrasilTowerStageStartRequestInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartRequestInfo);
        }

        public static void Write(Message msg, List<YggdrasilTowerStageStartRequestInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }

        public static void Write(Message msg, YggdrasilTowerStageStartResultInfo ty)
        {
            Marshaler.Write(msg, ty.stageStartResultInfo);
        }

        public static void Write(Message msg, List<YggdrasilTowerStageStartResultInfo> list)
        {
            int num = (list == null) ? 0 : list.Count;
            msg.WriteScalar(num);
            for (int i = 0; i < num; i++)
            {
                Marshaler.Write(msg, list[i]);
            }
        }
    }
}