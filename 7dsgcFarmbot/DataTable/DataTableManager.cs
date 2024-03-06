using System.IO.Compression;

// A table is a collection of one class from /DataTable/Class/
// Each table is serialized in a binary file, the firsts 4 bytes represent the size of the collection and the other bytes the content
// There are over 500 tables, the binary files are stored in /DataTable/Tables.zip
// The tables are stored in the values of _tableDictionary as BaseTable<ROWTYPE> where ROWTYPE is a table (1 table = 1 BaseTable)
public sealed class DataTableManager
{
    private static volatile DataTableManager? _instance;

    private static readonly object _syncLock = new object();

    private DataTableManager()
    {
    }

    public static DataTableManager Instance
    {
        get
        {
            if (_instance != null) return _instance;
            lock (_syncLock)
            {
                if (_instance == null)
                {
                    _instance = new DataTableManager();
                }
            }
            return _instance;
        }
    }

    public bool IsInitialized { get; private set; } = false;

    public void Initialize()  // Unzips the tables and builds _tableDictionary from their content
    {
        if (IsInitialized)
            return;
        Logger.Log("[DataTableManager-InitializeDatabase] Initialize");
        byte[] fileContent = _7dsgcFarmbot.Properties.Resources.Tables;
        using (MemoryStream stream = new MemoryStream(fileContent))
        {
            using (ZipArchive archive = new ZipArchive(stream))  // Reading the whole thing takes several seconds so I recommend commenting all the unused ones
            {
                //AddTable<DBAiCustomizingBasicPresetRow>(archive, TableType.AiCustomizingBasicPreset);
                //AddTable<DBAiCustomizingConditionRow>(archive, TableType.AiCustomizingCondition);
                //AddTable<DBAiCustomizingCostRow>(archive, TableType.AiCustomizingCost);
                //AddTable<DBAiCustomizingEtcRow>(archive, TableType.AiCustomizingEtc);
                //AddTable<DBAiCustomizingGroupRow>(archive, TableType.AiCustomizingGroup);
                //AddTable<DBAiCustomizingIconRow>(archive, TableType.AiCustomizingIcon);
                //AddTable<DBAiCustomizingMoveRow>(archive, TableType.AiCustomizingMove);
                //AddTable<DBAiCustomizingMoveTypeRow>(archive, TableType.AiCustomizingMoveType);
                //AddTable<DBAiCustomizingSkillTypeRow>(archive, TableType.AiCustomizingSkillType);
                //AddTable<DBAiCustomizingTargetRow>(archive, TableType.AiCustomizingTarget);
                //AddTable<DBArCharactersRow>(archive, TableType.ArCharacters);
                //AddTable<DBArDevicesRow>(archive, TableType.ArDevices);
                //AddTable<DBAreaRow>(archive, TableType.Area);
                //AddTable<DBArSystemsRow>(archive, TableType.ArSystems);
                //AddTable<DBArtifactCardRow>(archive, TableType.ArtifactCard);
                //AddTable<DBArtifactCardUnionRow>(archive, TableType.ArtifactCardUnion);
                //AddTable<DBArtifactCategoryRow>(archive, TableType.ArtifactCategory);
                //AddTable<DBArtifactEventGroupRow>(archive, TableType.ArtifactEventGroup);
                //AddTable<DBArtifactGroupRow>(archive, TableType.ArtifactGroup);
                //AddTable<DBArtifactUnionFilterGroupRow>(archive, TableType.ArtifactUnionFilterGroup);
                //AddTable<DBAttendanceHeroRow>(archive, TableType.AttendanceHero);
                //AddTable<DBAttendancePackageRow>(archive, TableType.AttendancePackage);
                //AddTable<DBBasepointCollisionNpcRow>(archive, TableType.BasepointCollisionNpc);
                //AddTable<DBBasepointFellowRewardRow>(archive, TableType.BasepointFellowReward);
                //AddTable<DBBasepointInteractiveAniRow>(archive, TableType.BasepointInteractiveAni);
                //AddTable<DBBasepointNpcMoveRow>(archive, TableType.BasepointNpcMove);
                //AddTable<DBBasepointNpcRow>(archive, TableType.BasepointNpc);
                //AddTable<DBBasepointNpcTalkRow>(archive, TableType.BasepointNpcTalk);
                //AddTable<DBBasepointRandomShopRow>(archive, TableType.BasepointRandomShop);
                //AddTable<DBBasepointShopRow>(archive, TableType.BasepointShop);
                //AddTable<DBBirthdayRow>(archive, TableType.Birthday);
                //AddTable<DBBlindContentRow>(archive, TableType.BlindContent);
                //AddTable<DBBoxItemInfoRow>(archive, TableType.BoxItemInfo);
                //AddTable<DBBundleDiscountPackageRow>(archive, TableType.BundleDiscountPackage);
                //AddTable<DBCardpackArtifactEventRow>(archive, TableType.CardpackArtifactEvent);
                //AddTable<DBCardpackArtifactInfoRow>(archive, TableType.CardpackArtifactInfo);
                //AddTable<DBCardpackPackageInfoRow>(archive, TableType.CardpackPackageInfo);
                //AddTable<DBChapterChangeRow>(archive, TableType.ChapterChange);
                //AddTable<DBChapterGroupRow>(archive, TableType.ChapterGroup);
                //AddTable<DBChapterRow>(archive, TableType.Chapter);
                //AddTable<DBCharacterLocalizeInfoRow>(archive, TableType.CharacterLocalizeInfo);
                //AddTable<DBCoinDemonpointRow>(archive, TableType.CoinDemonpoint);
                //AddTable<DBCoinShopEventRow>(archive, TableType.CoinShopEvent);
                //AddTable<DBCoinShopRow>(archive, TableType.CoinShop);
                //AddTable<DBCoinShopSettingRow>(archive, TableType.CoinShopSetting);
                //AddTable<DBConfigGameRow>(archive, TableType.ConfigGame);
                //AddTable<DBConstellationBaseRow>(archive, TableType.ConstellationBase);
                //AddTable<DBConstellationIgnoreTeamRow>(archive, TableType.ConstellationIgnoreTeam);
                //AddTable<DBConstellationStoneRow>(archive, TableType.ConstellationStone);
                //AddTable<DBConstManastoneRandomRow>(archive, TableType.ConstManastoneRandom);
                //AddTable<DBContentAdRouletteRow>(archive, TableType.ContentAdRoulette);
                //AddTable<DBContentAdRow>(archive, TableType.ContentAd);
                //AddTable<DBContentControlRow>(archive, TableType.ContentControl);
                //AddTable<DBContentLinkRow>(archive, TableType.ContentLink);
                //AddTable<DBContentsPassiveRow>(archive, TableType.ContentsPassive);
                //AddTable<DBControlAnotherRow>(archive, TableType.ControlAnother);
                //AddTable<DBCookingListRow>(archive, TableType.CookingList);
                //AddTable<DBCookingMaterialRow>(archive, TableType.CookingMaterial);
                //AddTable<DBCookingRecipeRow>(archive, TableType.CookingRecipe);
                //AddTable<DBCostumeBaseRow>(archive, TableType.CostumeBase);
                //AddTable<DBCostumeChangeSfxRow>(archive, TableType.CostumeChangeSfx);
                //AddTable<DBCostumeCraftRow>(archive, TableType.CostumeCraft);
                //AddTable<DBCostumeShopGroupRow>(archive, TableType.CostumeShopGroup);
                //AddTable<DBCostumeShopPackageRow>(archive, TableType.CostumeShopPackage);
                //AddTable<DBCostumeShopRow>(archive, TableType.CostumeShop);
                //AddTable<DBCostumeShopSettingRow>(archive, TableType.CostumeShopSetting);
                //AddTable<DBCostumeStatRow>(archive, TableType.CostumeStat);
                //AddTable<DBCraftCostumeUpgradeFinishRow>(archive, TableType.CraftCostumeUpgradeFinish);
                //AddTable<DBCraftCostumeUpgradeRow>(archive, TableType.CraftCostumeUpgrade);
                //AddTable<DBCreaturecolosseumSeasonRow>(archive, TableType.CreaturecolosseumSeason);
                //AddTable<DBCreaturePassiveRow>(archive, TableType.CreaturePassive);
                //AddTable<DBDailyAttendanceRow>(archive, TableType.DailyAttendance);
                //AddTable<DBDemonlordPassiveRow>(archive, TableType.DemonlordPassive);
                //AddTable<DBDemonlordRuleinfoRow>(archive, TableType.DemonlordRuleinfo);
                //AddTable<DBDemonlordRuleRow>(archive, TableType.DemonlordRule);
                //AddTable<DBDirectSelectorRow>(archive, TableType.DirectSelector);
                //AddTable<DBEventAdditionalPaymentRow>(archive, TableType.EventAdditionalPayment);
                //AddTable<DBEventAltarRewardRow>(archive, TableType.EventAltarReward);
                //AddTable<DBEventAttendanceRow>(archive, TableType.EventAttendance);
                //AddTable<DBEventAutoBoxrewardRow>(archive, TableType.EventAutoBoxreward);
                //AddTable<DBEventAutoBoxslotRow>(archive, TableType.EventAutoBoxslot);
                //AddTable<DBEventAutoBuffRow>(archive, TableType.EventAutoBuff);
                //AddTable<DBEventAutoGroupRow>(archive, TableType.EventAutoGroup);
                //AddTable<DBEventAutoHeroRow>(archive, TableType.EventAutoHero);
                //AddTable<DBEventAutoLevelupRow>(archive, TableType.EventAutoLevelup);
                //AddTable<DBEventAutoMonsterRow>(archive, TableType.EventAutoMonster);
                //AddTable<DBEventAutoSettingRow>(archive, TableType.EventAutoSetting);
                //AddTable<DBEventAutoStageRow>(archive, TableType.EventAutoStage);
                //AddTable<DBEventBalloondartBalloonRow>(archive, TableType.EventBalloondartBalloon);
                //AddTable<DBEventBalloondartChanceRow>(archive, TableType.EventBalloondartChance);
                //AddTable<DBEventBalloondartPinRow>(archive, TableType.EventBalloondartPin);
                //AddTable<DBEventBalloondartRewardRow>(archive, TableType.EventBalloondartReward);
                //AddTable<DBEventBalloondartScoreRow>(archive, TableType.EventBalloondartScore);
                //AddTable<DBEventBalloondartSpecialRow>(archive, TableType.EventBalloondartSpecial);
                //AddTable<DBEventBalloondartStageRow>(archive, TableType.EventBalloondartStage);
                //AddTable<DBEventBingoExchangeRow>(archive, TableType.EventBingoExchange);
                //AddTable<DBEventBingoRandomRow>(archive, TableType.EventBingoRandom);
                //AddTable<DBEventBingoRewardRow>(archive, TableType.EventBingoReward);
                //AddTable<DBEventBingoRow>(archive, TableType.EventBingo);
                //AddTable<DBEventBossMissionRow>(archive, TableType.EventBossMission);
                //AddTable<DBEventBuffLobbyRow>(archive, TableType.EventBuffLobby);
                //AddTable<DBEventBuffRow>(archive, TableType.EventBuff);
                //AddTable<DBEventChallengeDestroyRow>(archive, TableType.EventChallengeDestroy);
                //AddTable<DBEventChallengeDestroyscoreRow>(archive, TableType.EventChallengeDestroyscore);
                //AddTable<DBEventCheerFinishRow>(archive, TableType.EventCheerFinish);
                //AddTable<DBEventCheerGaugeRow>(archive, TableType.EventCheerGauge);
                //AddTable<DBEventCheerGroupRow>(archive, TableType.EventCheerGroup);
                //AddTable<DBEventCheerRewardRow>(archive, TableType.EventCheerReward);
                //AddTable<DBEventConfirmBoxRow>(archive, TableType.EventConfirmBox);
                //AddTable<DBEventConfirmConfigRow>(archive, TableType.EventConfirmConfig);
                //AddTable<DBEventConfirmImageRow>(archive, TableType.EventConfirmImage);
                //AddTable<DBEventConfirmNoteRow>(archive, TableType.EventConfirmNote);
                //AddTable<DBEventConfirmRewardRow>(archive, TableType.EventConfirmReward);
                //AddTable<DBEventConfirmScoreRow>(archive, TableType.EventConfirmScore);
                //AddTable<DBEventConquestCharacterRow>(archive, TableType.EventConquestCharacter);
                //AddTable<DBEventConquestCutInRow>(archive, TableType.EventConquestCutIn);
                //AddTable<DBEventConquestCutsceneRow>(archive, TableType.EventConquestCutscene);
                //AddTable<DBEventConquestEnemyRow>(archive, TableType.EventConquestEnemy);
                //AddTable<DBEventConquestFeverRow>(archive, TableType.EventConquestFever);
                //AddTable<DBEventConquestLocalizationRow>(archive, TableType.EventConquestLocalization);
                //AddTable<DBEventConquestProductionRow>(archive, TableType.EventConquestProduction);
                //AddTable<DBEventConquestRewardRow>(archive, TableType.EventConquestReward);
                //AddTable<DBEventConquestRow>(archive, TableType.EventConquest);
                //AddTable<DBEventConquestTileRow>(archive, TableType.EventConquestTile);
                //AddTable<DBEventCraftsLocalizationRow>(archive, TableType.EventCraftsLocalization);
                //AddTable<DBEventCraftsMaterialRow>(archive, TableType.EventCraftsMaterial);
                //AddTable<DBEventCraftsRow>(archive, TableType.EventCrafts);
                //AddTable<DBEventDiceMissionRow>(archive, TableType.EventDiceMission);
                //AddTable<DBEventDiceQuestionRow>(archive, TableType.EventDiceQuestion);
                //AddTable<DBEventDiceRewardRow>(archive, TableType.EventDiceReward);
                //AddTable<DBEventDiceRow>(archive, TableType.EventDice);
                //AddTable<DBEventDisasterTripleRow>(archive, TableType.EventDisasterTriple);
                //AddTable<DBEventDonationRow>(archive, TableType.EventDonation);
                //AddTable<DBEventExchangeBoxRow>(archive, TableType.EventExchangeBox);
                //AddTable<DBEventExchangeBoxSettingRow>(archive, TableType.EventExchangeBoxSetting);
                //AddTable<DBEventExchangeCardGroupRow>(archive, TableType.EventExchangeCardGroup);
                //AddTable<DBEventExchangeCardRewardRow>(archive, TableType.EventExchangeCardReward);
                //AddTable<DBEventExchangeCardSettingRow>(archive, TableType.EventExchangeCardSetting);
                //AddTable<DBEventExchangeRow>(archive, TableType.EventExchange);
                //AddTable<DBEventFortuneAttendanceRow>(archive, TableType.EventFortuneAttendance);
                //AddTable<DBEventFurnitureRow>(archive, TableType.EventFurniture);
                //AddTable<DBEventGambleboxDisplayRow>(archive, TableType.EventGambleboxDisplay);
                //AddTable<DBEventGambleboxGroupRow>(archive, TableType.EventGambleboxGroup);
                //AddTable<DBEventGrowthRow>(archive, TableType.EventGrowth);
                //AddTable<DBEventKingAmberRow>(archive, TableType.EventKingAmber);
                //AddTable<DBEventLadderRewardRow>(archive, TableType.EventLadderReward);
                //AddTable<DBEventLobbyGiftRow>(archive, TableType.EventLobbyGift);
                //AddTable<DBEventLobbyRow>(archive, TableType.EventLobby);
                //AddTable<DBEventLuckybagRewardRow>(archive, TableType.EventLuckybagReward);
                //AddTable<DBEventLuckybagSetRow>(archive, TableType.EventLuckybagSet);
                //AddTable<DBEventLuckyboxRow>(archive, TableType.EventLuckybox);
                //AddTable<DBEventMatchBlockRow>(archive, TableType.EventMatchBlock);
                //AddTable<DBEventMatchBuffRow>(archive, TableType.EventMatchBuff);
                //AddTable<DBEventMatchConfigRow>(archive, TableType.EventMatchConfig);
                //AddTable<DBEventMatchHawkRow>(archive, TableType.EventMatchHawk);
                //AddTable<DBEventMatchMatchrewardRow>(archive, TableType.EventMatchMatchreward);
                //AddTable<DBEventMatchScorerewardRow>(archive, TableType.EventMatchScorereward);
                //AddTable<DBEventMissionAchievepointRow>(archive, TableType.EventMissionAchievepoint);
                //AddTable<DBEventMissionChapterRow>(archive, TableType.EventMissionChapter);
                //AddTable<DBEventMissionRewardRow>(archive, TableType.EventMissionReward);
                //AddTable<DBEventMissionRow>(archive, TableType.EventMission);
                //AddTable<DBEventMissionScoreRow>(archive, TableType.EventMissionScore);
                //AddTable<DBEventMissionScoreSetRow>(archive, TableType.EventMissionScoreSet);
                //AddTable<DBEventMoleGameHawkRow>(archive, TableType.EventMoleGameHawk);
                //AddTable<DBEventMoleGameNoteRow>(archive, TableType.EventMoleGameNote);
                //AddTable<DBEventMoleRecordRewardRow>(archive, TableType.EventMoleRecordReward);
                //AddTable<DBEventMoleScoreRewardRow>(archive, TableType.EventMoleScoreReward);
                //AddTable<DBEventMonthlySettingRow>(archive, TableType.EventMonthlySetting);
                //AddTable<DBEventMonthlyStoryRow>(archive, TableType.EventMonthlyStory);
                //AddTable<DBEventPaybackRow>(archive, TableType.EventPayback);
                //AddTable<DBEventPlaycountRow>(archive, TableType.EventPlaycount);
                //AddTable<DBEventPredictNpcActRow>(archive, TableType.EventPredictNpcAct);
                //AddTable<DBEventPredictRewardRow>(archive, TableType.EventPredictReward);
                //AddTable<DBEventPredictSettingRow>(archive, TableType.EventPredictSetting);
                //AddTable<DBEventPredictSpecialRewardRow>(archive, TableType.EventPredictSpecialReward);
                //AddTable<DBEventPredictUpgradeRow>(archive, TableType.EventPredictUpgrade);
                //AddTable<DBEventProvisionCutsceneRow>(archive, TableType.EventProvisionCutscene);
                //AddTable<DBEventProvisionLocalizationRow>(archive, TableType.EventProvisionLocalization);
                //AddTable<DBEventProvisionRewardRow>(archive, TableType.EventProvisionReward);
                //AddTable<DBEventProvisionSectionRow>(archive, TableType.EventProvisionSection);
                //AddTable<DBEventPvpWincountRow>(archive, TableType.EventPvpWincount);
                //AddTable<DBEventPvpWincountWeekRow>(archive, TableType.EventPvpWincountWeek);
                //AddTable<DBEventRandomBoxDrawRateRow>(archive, TableType.EventRandomBoxDrawRate);
                //AddTable<DBEventRandomBoxRewardRow>(archive, TableType.EventRandomBoxReward);
                //AddTable<DBEventRandomBoxStageRow>(archive, TableType.EventRandomBoxStage);
                //AddTable<DBEventRhittaRewardRow>(archive, TableType.EventRhittaReward);
                //AddTable<DBEventRoadHawkRow>(archive, TableType.EventRoadHawk);
                //AddTable<DBEventRoadReactionRow>(archive, TableType.EventRoadReaction);
                //AddTable<DBEventRoadScorerewardRow>(archive, TableType.EventRoadScorereward);
                //AddTable<DBEventRoadStageRow>(archive, TableType.EventRoadStage);
                //AddTable<DBEventRoadTileRow>(archive, TableType.EventRoadTile);
                //AddTable<DBEventRow>(archive, TableType.Event);
                //AddTable<DBEventSetupRow>(archive, TableType.EventSetup);
                //AddTable<DBEventTimeMissionRow>(archive, TableType.EventTimeMission);
                //AddTable<DBEventTimeMissionSettingRow>(archive, TableType.EventTimeMissionSetting);
                //AddTable<DBEventTreasureHuntFinishRow>(archive, TableType.EventTreasureHuntFinish);
                //AddTable<DBEventTreasureHuntGroupRow>(archive, TableType.EventTreasureHuntGroup);
                //AddTable<DBEventTreasureHuntPointRow>(archive, TableType.EventTreasureHuntPoint);
                //AddTable<DBEventTreasureHuntSettingRow>(archive, TableType.EventTreasureHuntSetting);
                //AddTable<DBEventWishboxRow>(archive, TableType.EventWishbox);
                //AddTable<DBEvolutionBreakBaseRow>(archive, TableType.EvolutionBreakBase);
                //AddTable<DBEvolutionBreakMaxRow>(archive, TableType.EvolutionBreakMax);
                //AddTable<DBEvolutionExchangeRow>(archive, TableType.EvolutionExchange);
                //AddTable<DBExpRow>(archive, TableType.Exp);
                //AddTable<DBFadeInoutRow>(archive, TableType.FadeInout);
                //AddTable<DBFateMonsterRow>(archive, TableType.FateMonster);
                //AddTable<DBFateRow>(archive, TableType.Fate);
                //AddTable<DBFinalBossHallOfFameListRow>(archive, TableType.FinalBossHallOfFameList);
                //AddTable<DBFinalBossHallOfFameRow>(archive, TableType.FinalBossHallOfFame);
                //AddTable<DBFinalBossSeasonRow>(archive, TableType.FinalBossSeason);
                //AddTable<DBFinalBossSettingRow>(archive, TableType.FinalBossSetting);
                //AddTable<DBFinalBossShopRow>(archive, TableType.FinalBossShop);
                //AddTable<DBFirstBuyBonusRow>(archive, TableType.FirstBuyBonus);
                //AddTable<DBFoodBuffRow>(archive, TableType.FoodBuff);
                //AddTable<DBFoodHeroEatCategoryInfoRow>(archive, TableType.FoodHeroEatCategoryInfo);
                //AddTable<DBForumControlRow>(archive, TableType.ForumControl);
                //AddTable<DBFreePackageRewardRow>(archive, TableType.FreePackageReward);
                //AddTable<DBFriendVisitHeroRow>(archive, TableType.FriendVisitHero);
                //AddTable<DBFrozenContentRow>(archive, TableType.FrozenContent);
                //AddTable<DBGambleBonusRewardRow>(archive, TableType.GambleBonusReward);
                //AddTable<DBGambleChoiceRow>(archive, TableType.GambleChoice);
                //AddTable<DBGambleDisplayRow>(archive, TableType.GambleDisplay);
                //AddTable<DBGambleGroupRow>(archive, TableType.GambleGroup);
                //AddTable<DBGamblePaybackRewardRow>(archive, TableType.GamblePaybackReward);
                //AddTable<DBGamblePaybackRow>(archive, TableType.GamblePayback);
                //AddTable<DBGambleRatingPerRow>(archive, TableType.GambleRatingPer);
                //AddTable<DBGambleRotationSetRow>(archive, TableType.GambleRotationSet);
                //AddTable<DBGambleSignRow>(archive, TableType.GambleSign);
                //AddTable<DBGambleSoundRow>(archive, TableType.GambleSound);
                //AddTable<DBGambleTimeSwitchRow>(archive, TableType.GambleTimeSwitch);
                //AddTable<DBGameCenterAchievementRow>(archive, TableType.GameCenterAchievement);
                //AddTable<DBGameCenterLeaderboardRow>(archive, TableType.GameCenterLeaderboard);
                //AddTable<DBGlobalChannelSettingRow>(archive, TableType.GlobalChannelSetting);
                //AddTable<DBGrimBookCategoryRow>(archive, TableType.GrimBookCategory);
                //AddTable<DBGrimBookContentRow>(archive, TableType.GrimBookContent);
                //AddTable<DBGrimBookTalkRow>(archive, TableType.GrimBookTalk);
                //AddTable<DBGuestGiftRow>(archive, TableType.GuestGift);
                //AddTable<DBGuestInteractiveTalkRow>(archive, TableType.GuestInteractiveTalk);
                //AddTable<DBGuidelistRewardRow>(archive, TableType.GuidelistReward);
                //AddTable<DBGuideRecommendListRow>(archive, TableType.GuideRecommendList);
                //AddTable<DBGuildAttendanceRow>(archive, TableType.GuildAttendance);
                //AddTable<DBGuildBaseRow>(archive, TableType.GuildBase);
                //AddTable<DBGuildBossBattlescoreInfoRow>(archive, TableType.GuildBossBattlescoreInfo);
                //AddTable<DBGuildBossGuildRewardRow>(archive, TableType.GuildBossGuildReward);
                //AddTable<DBGuildBossHellMissionRow>(archive, TableType.GuildBossHellMission);
                //AddTable<DBGuildBossHellRewardRow>(archive, TableType.GuildBossHellReward);
                //AddTable<DBGuildBossMissionRow>(archive, TableType.GuildBossMission);
                //AddTable<DBGuildBossPersonalRewardRow>(archive, TableType.GuildBossPersonalReward);
                //AddTable<DBGuildBossSeasonRow>(archive, TableType.GuildBossSeason);
                //AddTable<DBGuildDonationRow>(archive, TableType.GuildDonation);
                //AddTable<DBGuildExpBoostRow>(archive, TableType.GuildExpBoost);
                //AddTable<DBGuildGroupMissionRow>(archive, TableType.GuildGroupMission);
                //AddTable<DBGuildMarkRow>(archive, TableType.GuildMark);
                //AddTable<DBGuildMissionRow>(archive, TableType.GuildMission);
                //AddTable<DBGuildorderBonusrewardGroupRow>(archive, TableType.GuildorderBonusrewardGroup);
                //AddTable<DBGuildorderMileagebonusRow>(archive, TableType.GuildorderMileagebonus);
                //AddTable<DBGuildorderMissionRow>(archive, TableType.GuildorderMission);
                //AddTable<DBGuildorderRewardboxRow>(archive, TableType.GuildorderRewardbox);
                //AddTable<DBGuildRankRewardRow>(archive, TableType.GuildRankReward);
                //AddTable<DBGuildShopRow>(archive, TableType.GuildShop);
                //AddTable<DBGuildSkillRow>(archive, TableType.GuildSkill);
                //AddTable<DBGuildWarAreaBuffRow>(archive, TableType.GuildWarAreaBuff);
                //AddTable<DBGuildWarAreaRow>(archive, TableType.GuildWarArea);
                //AddTable<DBGuildWarBuffRow>(archive, TableType.GuildWarBuff);
                //AddTable<DBGuildWarConfigRow>(archive, TableType.GuildWarConfig);
                //AddTable<DBGuildWarLeagueSignRow>(archive, TableType.GuildWarLeagueSign);
                //AddTable<DBGuildWarLowAreaRow>(archive, TableType.GuildWarLowArea);
                //AddTable<DBGuildWarLowPlayRewardRow>(archive, TableType.GuildWarLowPlayReward);
                //AddTable<DBGuildWarLowPointRewardRow>(archive, TableType.GuildWarLowPointReward);
                //AddTable<DBGuildWarLowSeasonRow>(archive, TableType.GuildWarLowSeason);
                //AddTable<DBGuildWarLowTierRow>(archive, TableType.GuildWarLowTier);
                //AddTable<DBGuildWarLowWinRewardRow>(archive, TableType.GuildWarLowWinReward);
                //AddTable<DBGuildWarRankRewardRow>(archive, TableType.GuildWarRankReward);
                //AddTable<DBGuildWarRegionRow>(archive, TableType.GuildWarRegion);
                //AddTable<DBGuildWarSeasonRow>(archive, TableType.GuildWarSeason);
                //AddTable<DBHawkSlotRow>(archive, TableType.HawkSlot);
                //AddTable<DBHeadCostumeResourceRow>(archive, TableType.HeadCostumeResource);
                //AddTable<DBHeroBaseRow>(archive, TableType.HeroBase);
                //AddTable<DBHeroCapacityMentRow>(archive, TableType.HeroCapacityMent);
                //AddTable<DBHeroContentsPassiveRow>(archive, TableType.HeroContentsPassive);
                //AddTable<DBHeroDetailRow>(archive, TableType.HeroDetail);
                //AddTable<DBHeroFilterGroupRow>(archive, TableType.HeroFilterGroup);
                //AddTable<DBHeroGroupNameRow>(archive, TableType.HeroGroupName);
                //AddTable<DBHeroGrowthPointInfoRow>(archive, TableType.HeroGrowthPointInfo);
                //AddTable<DBHeroJobGroupRow>(archive, TableType.HeroJobGroup);
                //AddTable<DBHeroLeagueBuffRow>(archive, TableType.HeroLeagueBuff);
                //AddTable<DBHeroLeagueDefenceRow>(archive, TableType.HeroLeagueDefence);
                //AddTable<DBHeroLeagueInfoRow>(archive, TableType.HeroLeagueInfo);
                //AddTable<DBHeroLeagueNpcNameRow>(archive, TableType.HeroLeagueNpcName);
                //AddTable<DBHeroLeagueRankRow>(archive, TableType.HeroLeagueRank);
                //AddTable<DBHeroLeagueRewardRow>(archive, TableType.HeroLeagueReward);
                //AddTable<DBHeroLeagueScoreRow>(archive, TableType.HeroLeagueScore);
                //AddTable<DBHeroLeagueSeasonRow>(archive, TableType.HeroLeagueSeason);
                //AddTable<DBHeroLeagueSeasonShopRow>(archive, TableType.HeroLeagueSeasonShop);
                //AddTable<DBHeroLeagueStageRow>(archive, TableType.HeroLeagueStage);
                //AddTable<DBHeroLovepointRewardRow>(archive, TableType.HeroLovepointReward);
                //AddTable<DBHeroLovepointShareRow>(archive, TableType.HeroLovepointShare);
                //AddTable<DBInteractiveItemRow>(archive, TableType.InteractiveItem);
                //AddTable<DBInteractiveRow>(archive, TableType.Interactive);
                //AddTable<DBInteractiveTalkRow>(archive, TableType.InteractiveTalk);
                //AddTable<DBInteractiveVrRow>(archive, TableType.InteractiveVr);
                //AddTable<DBItemGotchaDisplayRow>(archive, TableType.ItemGotchaDisplay);
                //AddTable<DBItemGotchaGroupRow>(archive, TableType.ItemGotchaGroup);
                //AddTable<DBItemGotchaRatingPerRow>(archive, TableType.ItemGotchaRatingPer);
                //AddTable<DBItemGotchaSignRow>(archive, TableType.ItemGotchaSign);
                //AddTable<DBItemInfoRow>(archive, TableType.ItemInfo);
                //AddTable<DBItemTypeDescIrregularRow>(archive, TableType.ItemTypeDescIrregular);
                //AddTable<DBItemTypeDescRow>(archive, TableType.ItemTypeDesc);
                //AddTable<DBJournalRow>(archive, TableType.Journal);
                //AddTable<DBJukeboxListRow>(archive, TableType.JukeboxList);
                //AddTable<DBKingAmberRow>(archive, TableType.KingAmber);
                //AddTable<DBLevelupPackageRow>(archive, TableType.LevelupPackage);
                //AddTable<DBLoadingDefaultRow>(archive, TableType.LoadingDefault);
                //AddTable<DBLoadingSceneRow>(archive, TableType.LoadingScene);
                //AddTable<DBLoadingSettingRow>(archive, TableType.LoadingSetting);
                //AddTable<DBLoadingTipRow>(archive, TableType.LoadingTip);
                //AddTable<DBLobbyHousingBuffRow>(archive, TableType.LobbyHousingBuff);
                //AddTable<DBLobbyHousingFurnitureBaseRow>(archive, TableType.LobbyHousingFurnitureBase);
                //AddTable<DBLobbyHousingShopRow>(archive, TableType.LobbyHousingShop);
                //AddTable<DBLobbyNpcRewardRow>(archive, TableType.LobbyNpcReward);
                //AddTable<DBLoseGuideRow>(archive, TableType.LoseGuide);
                //AddTable<DBMailboxRow>(archive, TableType.Mailbox);
                //AddTable<DBMaterialChangeRow>(archive, TableType.MaterialChange);
                //AddTable<DBMaterialFusionConfigRow>(archive, TableType.MaterialFusionConfig);
                //AddTable<DBMaterialInfoRow>(archive, TableType.MaterialInfo);
                //AddTable<DBMazeNeedHeroRow>(archive, TableType.MazeNeedHero);
                //AddTable<DBMazeReplayBonusRow>(archive, TableType.MazeReplayBonus);
                //AddTable<DBMazeSeasonRow>(archive, TableType.MazeSeason);
                //AddTable<DBMazeSeasonShopGradeRow>(archive, TableType.MazeSeasonShopGrade);
                //AddTable<DBMazeSeasonShopRow>(archive, TableType.MazeSeasonShop);
                //AddTable<DBMazeShopBuffRow>(archive, TableType.MazeShopBuff);
                //AddTable<DBMazeShopRow>(archive, TableType.MazeShop);
                //AddTable<DBMercenaryNpcSettingRow>(archive, TableType.MercenaryNpcSetting);
                //AddTable<DBMissionAchievepointRow>(archive, TableType.MissionAchievepoint);
                //AddTable<DBMissionPlayTitleGroupRow>(archive, TableType.MissionPlayTitleGroup);
                //AddTable<DBMissionPlayTitleRow>(archive, TableType.MissionPlayTitle);
                //AddTable<DBMissionRow>(archive, TableType.Mission);
                //AddTable<DBMonsterAiRow>(archive, TableType.MonsterAi);
                //AddTable<DBMonsterBaseRow>(archive, TableType.MonsterBase);
                //AddTable<DBMonsterResourceRow>(archive, TableType.MonsterResource);
                //AddTable<DBMonsterSkillRow>(archive, TableType.MonsterSkill);
                //AddTable<DBMusicalBaseRow>(archive, TableType.MusicalBase);
                //AddTable<DBNormalPackageRow>(archive, TableType.NormalPackage);
                //AddTable<DBNoticeRow>(archive, TableType.Notice);
                //AddTable<DBNpcInfoRow>(archive, TableType.NpcInfo);
                //AddTable<DBNpcPropRow>(archive, TableType.NpcProp);
                //AddTable<DBPackageWeaponGrowthRow>(archive, TableType.PackageWeaponGrowth);
                //AddTable<DBPackageWeekSetupRow>(archive, TableType.PackageWeekSetup);
                //AddTable<DBPassDesignSettingRow>(archive, TableType.PassDesignSetting);
                //AddTable<DBPassMissionRankRewardRow>(archive, TableType.PassMissionRankReward);
                //AddTable<DBPassMissionRankRow>(archive, TableType.PassMissionRank);
                //AddTable<DBPassMissionRewardRow>(archive, TableType.PassMissionReward);
                //AddTable<DBPatrolRow>(archive, TableType.Patrol);
                //AddTable<DBPatrolTimeRewardRow>(archive, TableType.PatrolTimeReward);
                //AddTable<DBPopupPackageRow>(archive, TableType.PopupPackage);
                //AddTable<DBPvpChaosBaseRow>(archive, TableType.PvpChaosBase);
                //AddTable<DBPvpChaosGradeChangeRow>(archive, TableType.PvpChaosGradeChange);
                //AddTable<DBPvpChaosHeroCostRow>(archive, TableType.PvpChaosHeroCost);
                //AddTable<DBPvpChaosRankRewardRow>(archive, TableType.PvpChaosRankReward);
                //AddTable<DBPvpLowLeagueRewardGroupRow>(archive, TableType.PvpLowLeagueRewardGroup);
                //AddTable<DBPvpLowLeagueRuleSettingRow>(archive, TableType.PvpLowLeagueRuleSetting);
                //AddTable<DBPvpModeBaseRow>(archive, TableType.PvpModeBase);
                //AddTable<DBPvpNpcNameRow>(archive, TableType.PvpNpcName);
                //AddTable<DBPvpPointRow>(archive, TableType.PvpPoint);
                //AddTable<DBPvpRewardRow>(archive, TableType.PvpReward);
                //AddTable<DBPvpRuleSettingRow>(archive, TableType.PvpRuleSetting);
                //AddTable<DBPvpSeasonBaseRow>(archive, TableType.PvpSeasonBase);
                //AddTable<DBPvpSeasonRewardGroupRow>(archive, TableType.PvpSeasonRewardGroup);
                //AddTable<DBPvpShopRow>(archive, TableType.PvpShop);
                //AddTable<DBPvpShowRow>(archive, TableType.PvpShow);
                //AddTable<DBPvpSmashRewardRow>(archive, TableType.PvpSmashReward);
                //AddTable<DBPvpSmashShopGradeRow>(archive, TableType.PvpSmashShopGrade);
                //AddTable<DBPvpSmashShopRewardRow>(archive, TableType.PvpSmashShopReward);
                //AddTable<DBPvpSmashShopRow>(archive, TableType.PvpSmashShop);
                //AddTable<DBPvpTopRankRow>(archive, TableType.PvpTopRank);
                //AddTable<DBPvpTournamentRewardRow>(archive, TableType.PvpTournamentReward);
                //AddTable<DBPvpUserReportRow>(archive, TableType.PvpUserReport);
                //AddTable<DBQuestCharacterCostumeRow>(archive, TableType.QuestCharacterCostume);
                //AddTable<DBQuestCharacterRow>(archive, TableType.QuestCharacter);
                //AddTable<DBQuestEventStepupGroupRow>(archive, TableType.QuestEventStepupGroup);
                //AddTable<DBQuestEventUtilityRow>(archive, TableType.QuestEventUtility);
                //AddTable<DBQuestExtraRow>(archive, TableType.QuestExtra);
                //AddTable<DBQuestRow>(archive, TableType.Quest);
                //AddTable<DBQuestSoundRow>(archive, TableType.QuestSound);
                //AddTable<DBQuestTalkRow>(archive, TableType.QuestTalk);
                //AddTable<DBRatingRow>(archive, TableType.Rating);
                //AddTable<DBRecommendTeamRow>(archive, TableType.RecommendTeam);
                //AddTable<DBRegionChangeRow>(archive, TableType.RegionChange);
                //AddTable<DBRegionRow>(archive, TableType.Region);
                //AddTable<DBRegionSubMatchingRow>(archive, TableType.RegionSubMatching);
                //AddTable<DBSelectedExchangeInfoRow>(archive, TableType.SelectedExchangeInfo);
                //AddTable<DBSellItemInfoRow>(archive, TableType.SellItemInfo);
                //AddTable<DBSequenceRow>(archive, TableType.Sequence);
                //AddTable<DBSetCostumeRow>(archive, TableType.SetCostume);
                //AddTable<DBSfxRow>(archive, TableType.Sfx);
                //AddTable<DBShopChoicePackageRow>(archive, TableType.ShopChoicePackage);
                //AddTable<DBShopConsumeRow>(archive, TableType.ShopConsume);
                //AddTable<DBShopCreaturecolosseumRow>(archive, TableType.ShopCreaturecolosseum);
                //AddTable<DBShopHawkMileageRow>(archive, TableType.ShopHawkMileage);
                //AddTable<DBShopHubRow>(archive, TableType.ShopHub);
                //AddTable<DBShopMenuRow>(archive, TableType.ShopMenu);
                //AddTable<DBShopMoneyRow>(archive, TableType.ShopMoney);
                //AddTable<DBShopPackageRow>(archive, TableType.ShopPackage);
                //AddTable<DBShopYggdrasilMileageRow>(archive, TableType.ShopYggdrasilMileage);
                //AddTable<DBSituationPackageRow>(archive, TableType.SituationPackage);
                //AddTable<DBSkillCardBaseRow>(archive, TableType.SkillCardBase);
                //AddTable<DBSkillCardBuffRow>(archive, TableType.SkillCardBuff);
                //AddTable<DBSkillCardBulletRow>(archive, TableType.SkillCardBullet);
                //AddTable<DBSkillCardOptionRow>(archive, TableType.SkillCardOption);
                //AddTable<DBSkillCardResourceRow>(archive, TableType.SkillCardResource);
                //AddTable<DBSkillPassiveConditionIconRow>(archive, TableType.SkillPassiveConditionIcon);
                //AddTable<DBSkillPassiveRow>(archive, TableType.SkillPassive);
                //AddTable<DBSkillSearchGroupRow>(archive, TableType.SkillSearchGroup);
                //AddTable<DBSkillSearchInfoRow>(archive, TableType.SkillSearchInfo);
                //AddTable<DBSkinAniRow>(archive, TableType.SkinAni);
                //AddTable<DBSkinAwakenResourceRow>(archive, TableType.SkinAwakenResource);
                //AddTable<DBSkinAwakenRow>(archive, TableType.SkinAwaken);
                //AddTable<DBSkinAwakenStatRow>(archive, TableType.SkinAwakenStat);
                AddTable<DBSkinBaseRow>(archive, TableType.SkinBase);
                //AddTable<DBSkinCostumeResourceRow>(archive, TableType.SkinCostumeResource);
                //AddTable<DBSkinEvolutionRow>(archive, TableType.SkinEvolution);
                //AddTable<DBSkinExceedRow>(archive, TableType.SkinExceed);
                //AddTable<DBSkinExclusivePassiveRow>(archive, TableType.SkinExclusivePassive);
                //AddTable<DBSkinLevelupBonusRow>(archive, TableType.SkinLevelupBonus);
                //AddTable<DBSkinSkillLevelupRow>(archive, TableType.SkinSkillLevelup);
                //AddTable<DBSkinSkillRow>(archive, TableType.SkinSkill);
                //AddTable<DBSkinTranscendRow>(archive, TableType.SkinTranscend);
                //AddTable<DBSnsRewardRow>(archive, TableType.SnsReward);
                //AddTable<DBSoundRow>(archive, TableType.Sound);
                //AddTable<DBStageAncientBossDescRow>(archive, TableType.StageAncientBossDesc);
                //AddTable<DBStageAncientMissionBuffRow>(archive, TableType.StageAncientMissionBuff);
                //AddTable<DBStageAncientMissionRow>(archive, TableType.StageAncientMission);
                //AddTable<DBStageAncientRankRewardRow>(archive, TableType.StageAncientRankReward);
                //AddTable<DBStageAncientRewardRow>(archive, TableType.StageAncientReward);
                //AddTable<DBStageAncientRow>(archive, TableType.StageAncient);
                //AddTable<DBStageBossDestroyRow>(archive, TableType.StageBossDestroy);
                //AddTable<DBStageBossRow>(archive, TableType.StageBoss);
                //AddTable<DBStageBossSeasonRow>(archive, TableType.StageBossSeason);
                //AddTable<DBStageChallengeBossDescRow>(archive, TableType.StageChallengeBossDesc);
                //AddTable<DBStageChallengeBossEventRow>(archive, TableType.StageChallengeBossEvent);
                //AddTable<DBStageChallengeBossGroupRow>(archive, TableType.StageChallengeBossGroup);
                //AddTable<DBStageChallengeBossRow>(archive, TableType.StageChallengeBoss);
                //AddTable<DBStageConquestRow>(archive, TableType.StageConquest);
                //AddTable<DBStageCreaturenestGaugeRow>(archive, TableType.StageCreaturenestGauge);
                //AddTable<DBStageCreaturenestInfoRow>(archive, TableType.StageCreaturenestInfo);
                //AddTable<DBStageCreaturenestRow>(archive, TableType.StageCreaturenest);
                //AddTable<DBStageDemonlordDescRow>(archive, TableType.StageDemonlordDesc);
                //AddTable<DBStageDemonlordRow>(archive, TableType.StageDemonlord);
                //AddTable<DBStageDescentBossGroupRow>(archive, TableType.StageDescentBossGroup);
                //AddTable<DBStageDescentBossRow>(archive, TableType.StageDescentBoss);
                //AddTable<DBStageDestroyCommonRow>(archive, TableType.StageDestroyCommon);
                //AddTable<DBStageDestroyDescRow>(archive, TableType.StageDestroyDesc);
                //AddTable<DBStageDestroyRow>(archive, TableType.StageDestroy);
                //AddTable<DBStageEventMonthlyRow>(archive, TableType.StageEventMonthly);
                //AddTable<DBStageEventTowerRow>(archive, TableType.StageEventTower);
                //AddTable<DBStageEventTowerSeasonRow>(archive, TableType.StageEventTowerSeason);
                //AddTable<DBStageExtraRow>(archive, TableType.StageExtra);
                //AddTable<DBStageFinalBossBattlescoreRow>(archive, TableType.StageFinalBossBattlescore);
                //AddTable<DBStageFinalBossEventRow>(archive, TableType.StageFinalBossEvent);
                //AddTable<DBStageFinalBossGroupRow>(archive, TableType.StageFinalBossGroup);
                //AddTable<DBStageFinalBossMissionRow>(archive, TableType.StageFinalBossMission);
                //AddTable<DBStageFinalBossRankRewardRow>(archive, TableType.StageFinalBossRankReward);
                //AddTable<DBStageFinalBossRow>(archive, TableType.StageFinalBoss);
                //AddTable<DBStageFinalBossScoreGroupRow>(archive, TableType.StageFinalBossScoreGroup);
                //AddTable<DBStageFinalBossScorerewardRow>(archive, TableType.StageFinalBossScorereward);
                //AddTable<DBStageFinalBossVowRow>(archive, TableType.StageFinalBossVow);
                //AddTable<DBStageFreeRow>(archive, TableType.StageFree);
                //AddTable<DBStageGlobalDropRow>(archive, TableType.StageGlobalDrop);
                //AddTable<DBStageGlobalTypeRow>(archive, TableType.StageGlobalType);
                //AddTable<DBStageGuildWarLowRow>(archive, TableType.StageGuildWarLow);
                //AddTable<DBStageGuildWarRow>(archive, TableType.StageGuildWar);
                //AddTable<DBStageLimitedRow>(archive, TableType.StageLimited);
                //AddTable<DBStageMazePassiveRow>(archive, TableType.StageMazePassive);
                //AddTable<DBStageMazeRow>(archive, TableType.StageMaze);
                //AddTable<DBStageMazeSeasonRewardRow>(archive, TableType.StageMazeSeasonReward);
                //AddTable<DBStageMazeSpotRow>(archive, TableType.StageMazeSpot);
                //AddTable<DBStageMemorialRow>(archive, TableType.StageMemorial);
                //AddTable<DBStageNpcBaseRow>(archive, TableType.StageNpcBase);
                //AddTable<DBStageNpcSettingRow>(archive, TableType.StageNpcSetting);
                //AddTable<DBStagePlayCountRow>(archive, TableType.StagePlayCount);
                //AddTable<DBStageQuestRow>(archive, TableType.StageQuest);
                //AddTable<DBStageReverseGroupRewardRow>(archive, TableType.StageReverseGroupReward);
                //AddTable<DBStageReverseGroupRow>(archive, TableType.StageReverseGroup);
                //AddTable<DBStageReverseMissionRow>(archive, TableType.StageReverseMission);
                //AddTable<DBStageReverseRow>(archive, TableType.StageReverse);
                //AddTable<DBStageReverseSeasonRewardRow>(archive, TableType.StageReverseSeasonReward);
                //AddTable<DBStageRow>(archive, TableType.Stage);
                //AddTable<DBStageRunRow>(archive, TableType.StageRun);
                //AddTable<DBStageSingleSiegeDescRow>(archive, TableType.StageSingleSiegeDesc);
                //AddTable<DBStageSingleSiegeRow>(archive, TableType.StageSingleSiege);
                //AddTable<DBStageSubdueBossGroupRow>(archive, TableType.StageSubdueBossGroup);
                //AddTable<DBStageSubdueBossRewardRow>(archive, TableType.StageSubdueBossReward);
                //AddTable<DBStageSubdueBossRow>(archive, TableType.StageSubdueBoss);
                //AddTable<DBStageSubdueTagRow>(archive, TableType.StageSubdueTag);
                //AddTable<DBStageTournamentRow>(archive, TableType.StageTournament);
                //AddTable<DBStageTournamentTeamInfoRow>(archive, TableType.StageTournamentTeamInfo);
                //AddTable<DBStageTowerModePassiveRow>(archive, TableType.StageTowerModePassive);
                //AddTable<DBStageTowerRow>(archive, TableType.StageTower);
                //AddTable<DBStageTowerSeasonRow>(archive, TableType.StageTowerSeason);
                //AddTable<DBStageTrainingGroupRow>(archive, TableType.StageTrainingGroup);
                //AddTable<DBStageTrainingPlayCountRow>(archive, TableType.StageTrainingPlayCount);
                //AddTable<DBStageTrainingRow>(archive, TableType.StageTraining);
                //AddTable<DBStageTrainingTaskOpenRow>(archive, TableType.StageTrainingTaskOpen);
                //AddTable<DBStageTrainingTaskRow>(archive, TableType.StageTrainingTask);
                //AddTable<DBStageTypeRow>(archive, TableType.StageType);
                //AddTable<DBStageWeekBuffRow>(archive, TableType.StageWeekBuff);
                //AddTable<DBStageWeekRandomStageRow>(archive, TableType.StageWeekRandomStage);
                //AddTable<DBStageWeekRewardRow>(archive, TableType.StageWeekReward);
                //AddTable<DBStageWeekRow>(archive, TableType.StageWeek);
                //AddTable<DBStageWeekSetupRow>(archive, TableType.StageWeekSetup);
                //AddTable<DBStageYggdrasilTowerRow>(archive, TableType.StageYggdrasilTower);
                //AddTable<DBStampChatRow>(archive, TableType.StampChat);
                //AddTable<DBStepupGambleBonusRewardRow>(archive, TableType.StepupGambleBonusReward);
                //AddTable<DBStepupGambleInfoRow>(archive, TableType.StepupGambleInfo);
                //AddTable<DBStepupMileageBonusRewardRow>(archive, TableType.StepupMileageBonusReward);
                //AddTable<DBStepupMileageRow>(archive, TableType.StepupMileage);
                //AddTable<DBStepupSetRow>(archive, TableType.StepupSet);
                //AddTable<DBStoryreviewAreaRow>(archive, TableType.StoryreviewArea);
                //AddTable<DBStoryreviewListRow>(archive, TableType.StoryreviewList);
                //AddTable<DBStoryreviewRootRow>(archive, TableType.StoryreviewRoot);
                //AddTable<DBStoryreviewStageRow>(archive, TableType.StoryreviewStage);
                //AddTable<DBTimeStepupPackageRow>(archive, TableType.TimeStepupPackage);
                //AddTable<DBTownChangeRow>(archive, TableType.TownChange);
                //AddTable<DBTownDonationValueConfigRow>(archive, TableType.TownDonationValueConfig);
                //AddTable<DBTrainingMissionRewardRow>(archive, TableType.TrainingMissionReward);
                //AddTable<DBTrainingStageMissionRow>(archive, TableType.TrainingStageMission);
                //AddTable<DBTutorialRewardRow>(archive, TableType.TutorialReward);
                //AddTable<DBUpgradeRatingRow>(archive, TableType.UpgradeRating);
                //AddTable<DBVideoRow>(archive, TableType.Video);
                //AddTable<DBWeaponAutoSettingRow>(archive, TableType.WeaponAutoSetting);
                //AddTable<DBWeaponBaseChangeRow>(archive, TableType.WeaponBaseChange);
                //AddTable<DBWeaponBaseRow>(archive, TableType.WeaponBase);
                //AddTable<DBWeaponCarveBaseRow>(archive, TableType.WeaponCarveBase);
                //AddTable<DBWeaponCostumeResourceRow>(archive, TableType.WeaponCostumeResource);
                //AddTable<DBWeaponEventSetRow>(archive, TableType.WeaponEventSet);
                //AddTable<DBWeaponEvolutionRow>(archive, TableType.WeaponEvolution);
                //AddTable<DBWeaponGrindRow>(archive, TableType.WeaponGrind);
                //AddTable<DBWeaponGrowthRow>(archive, TableType.WeaponGrowth);
                //AddTable<DBWeaponMagicRow>(archive, TableType.WeaponMagic);
                //AddTable<DBWeaponOptionChangeRow>(archive, TableType.WeaponOptionChange);
                //AddTable<DBWeaponOptionRow>(archive, TableType.WeaponOption);
                //AddTable<DBWeaponSetRow>(archive, TableType.WeaponSet);
                //AddTable<DBWeaponUpgradeRow>(archive, TableType.WeaponUpgrade);
                //AddTable<DBWelcomeAttendanceRow>(archive, TableType.WelcomeAttendance);
            }
        }
        IsInitialized = true;
    }

    public void Clear()
    {
        if (!IsInitialized)
            return;
        _tableDictionary.Clear();
        IsInitialized = false;
    }

    // Reads table from zip then builds and adds the BaseTable in _tableDictionary
    private void AddTable<ROWTYPE>(ZipArchive zip, TableType table) where ROWTYPE : class, ITableRowIndexer, new()
    {
        string entryName = _tableFileNameArray[(int)table];
        ZipArchiveEntry? entry = zip.GetEntry(entryName);
        if (entry == null)
            throw new Exception($"Table {entryName} does not exist");
        List<ROWTYPE> list = new List<ROWTYPE>();
        using (BinaryReader reader = new BinaryReader(entry.Open()))
        {
            int rowCount = reader.ReadInt32();  // The firsts 4 bytes represent the size of the collection
            for (int i = 0; i < rowCount; i++)
            {
                ROWTYPE row = new ROWTYPE();
                row.ReadToStream(reader);
                list.Add(row);
            }
        }
        _tableDictionary.Add(table, new BaseTable<ROWTYPE>(list.GetEnumerator(), table));
    }

    private BaseTable<ROWTYPE>? GetTable<ROWTYPE>() where ROWTYPE : class, ITableRowIndexer
    {
        TableType table = BaseTable<ROWTYPE>.TableType;
        if (_tableDictionary.ContainsKey(table))
        {
            return _tableDictionary[table] as BaseTable<ROWTYPE>;
        }
        Console.WriteLine($"[DataTableManager-GetTable] Not found table {typeof(ROWTYPE)}");
        return null;
    }

    // Usage example: DataTableManager.Instance.GetTableToList<DBSkinBaseRow>(); -> returns all the elements of the table DBSkinBaseRow
    public List<ROWTYPE> GetTableToList<ROWTYPE>() where ROWTYPE : class, ITableRowIndexer
    {
        BaseTable<ROWTYPE>? table = GetTable<ROWTYPE>();
        if (table != null)
        {
            return table.ListDBRows;
        }
        return new List<ROWTYPE>();
    }

    // Usage example: DataTableManager.Instance.GetData<DBSkinBaseRow>(323901); -> returns chaos arthur info
    public ROWTYPE? GetData<ROWTYPE>(int id) where ROWTYPE : class, ITableRowIndexer
    {
        BaseTable<ROWTYPE>? table = GetTable<ROWTYPE>();
        if (table != null)
        {
            return table.GetData(id);
        }
        return default(ROWTYPE);
    }

    // Usage example: DataTableManager.Instance.GetDatas<DBSkinBaseRow>(s => s.StartRating == (int)RatingType.UR); -> returns the info of all the UR base units
    public List<ROWTYPE> GetDatas<ROWTYPE>(Predicate<ROWTYPE> condtion) where ROWTYPE : class, ITableRowIndexer
    {
        BaseTable<ROWTYPE>? table = GetTable<ROWTYPE>();
        if (table != null)
        {
            return table.GetDatas(condtion);
        }
        return new List<ROWTYPE>();
    }

    // Equivalent to the method above except that it returns the first element of the list only
    public ROWTYPE? GetData<ROWTYPE>(Predicate<ROWTYPE> condtion) where ROWTYPE : class, ITableRowIndexer
    {
        BaseTable<ROWTYPE>? table = GetTable<ROWTYPE>();
        if (table != null)
        {
            return table.GetData(condtion);
        }
        return null;
    }

    public bool IsExistData<ROWTYPE>(int id) where ROWTYPE : class, ITableRowIndexer
    {
        BaseTable<ROWTYPE>? table = GetTable<ROWTYPE>();
        return table != null && table.Contains(id);
    }

    private readonly Dictionary<TableType, object> _tableDictionary = new Dictionary<TableType, object>();  // object is of type BaseTable<ROWTYPE>

    private readonly string[] _tableFileNameArray = new string[]
    {
            "DB_ai_customizing_Basic_Preset.csv",
            "DB_ai_customizing_condition.csv",
            "DB_ai_customizing_cost.csv",
            "DB_ai_customizing_etc.csv",
            "DB_ai_customizing_group.csv",
            "DB_ai_customizing_icon.csv",
            "DB_ai_customizing_move.csv",
            "DB_ai_customizing_move_type.csv",
            "DB_ai_customizing_skill_type.csv",
            "DB_ai_customizing_target.csv",
            "DB_ar_characters.csv",
            "DB_ar_devices.csv",
            "DB_ar_systems.csv",
            "DB_area.csv",
            "DB_artifact_card.csv",
            "DB_artifact_card_union.csv",
            "DB_artifact_category.csv",
            "DB_artifact_event_group.csv",
            "DB_artifact_group.csv",
            "DB_artifact_union_filter_group.csv",
            "DB_attendance_hero.csv",
            "DB_attendance_package.csv",
            "DB_basepoint_collision_npc.csv",
            "DB_basepoint_fellow_reward.csv",
            "DB_basepoint_interactive_ani.csv",
            "DB_basepoint_npc.csv",
            "DB_basepoint_npc_move.csv",
            "DB_basepoint_npc_talk.csv",
            "DB_basepoint_random_shop.csv",
            "DB_basepoint_shop.csv",
            "DB_birthday.csv",
            "DB_blind_content.csv",
            "DB_box_item_info.csv",
            "DB_bundle_discount_package.csv",
            "DB_cardpack_artifact_event.csv",
            "DB_cardpack_artifact_info.csv",
            "DB_cardpack_package_info.csv",
            "DB_chapter.csv",
            "DB_chapter_change.csv",
            "DB_chapter_group.csv",
            "DB_character_localize_info.csv",
            "DB_coin_demonpoint.csv",
            "DB_coin_shop.csv",
            "DB_coin_shop_event.csv",
            "DB_coin_shop_setting.csv",
            "DB_config_game.csv",
            "DB_const_manastone_random.csv",
            "DB_constellation_base.csv",
            "DB_constellation_ignore_team.csv",
            "DB_constellation_stone.csv",
            "DB_content_ad.csv",
            "DB_content_ad_roulette.csv",
            "DB_content_control.csv",
            "DB_content_link.csv",
            "DB_contents_passive.csv",
            "DB_control_another.csv",
            "DB_cooking_list.csv",
            "DB_cooking_material.csv",
            "DB_cooking_recipe.csv",
            "DB_costume_base.csv",
            "DB_costume_change_sfx.csv",
            "DB_costume_craft.csv",
            "DB_costume_shop.csv",
            "DB_costume_shop_group.csv",
            "DB_costume_shop_package.csv",
            "DB_costume_shop_setting.csv",
            "DB_costume_stat.csv",
            "DB_craft_costume_upgrade.csv",
            "DB_craft_costume_upgrade_finish.csv",
            "DB_creature_passive.csv",
            "DB_creaturecolosseum_season.csv",
            "DB_daily_attendance.csv",
            "DB_demonlord_passive.csv",
            "DB_demonlord_rule.csv",
            "DB_demonlord_ruleinfo.csv",
            "DB_direct_selector.csv",
            "DB_event.csv",
            "DB_event_additional_payment.csv",
            "DB_event_altar_reward.csv",
            "DB_event_attendance.csv",
            "DB_event_auto_boxReward.csv",
            "DB_event_auto_boxSlot.csv",
            "DB_event_auto_buff.csv",
            "DB_event_auto_group.csv",
            "DB_event_auto_hero.csv",
            "DB_event_auto_levelup.csv",
            "DB_event_auto_monster.csv",
            "DB_event_auto_setting.csv",
            "DB_event_auto_stage.csv",
            "DB_event_balloondart_balloon.csv",
            "DB_event_balloondart_chance.csv",
            "DB_event_balloondart_pin.csv",
            "DB_event_balloondart_reward.csv",
            "DB_event_balloondart_score.csv",
            "DB_event_balloondart_special.csv",
            "DB_event_balloondart_stage.csv",
            "DB_event_bingo.csv",
            "DB_event_bingo_exchange.csv",
            "DB_event_bingo_random.csv",
            "DB_event_bingo_reward.csv",
            "DB_event_boss_mission.csv",
            "DB_event_buff.csv",
            "DB_event_buff_lobby.csv",
            "DB_event_challenge_destroy.csv",
            "DB_event_challenge_destroyscore.csv",
            "DB_event_cheer_finish.csv",
            "DB_event_cheer_gauge.csv",
            "DB_event_cheer_group.csv",
            "DB_event_cheer_reward.csv",
            "DB_event_confirm_box.csv",
            "DB_event_confirm_config.csv",
            "DB_event_confirm_image.csv",
            "DB_event_confirm_note.csv",
            "DB_event_confirm_reward.csv",
            "DB_event_confirm_score.csv",
            "DB_event_conquest.csv",
            "DB_event_conquest_character.csv",
            "DB_event_conquest_cut_in.csv",
            "DB_event_conquest_cutscene.csv",
            "DB_event_conquest_enemy.csv",
            "DB_event_conquest_fever.csv",
            "DB_event_conquest_localization.csv",
            "DB_event_conquest_production.csv",
            "DB_event_conquest_reward.csv",
            "DB_event_conquest_tile.csv",
            "DB_event_crafts.csv",
            "DB_event_crafts_localization.csv",
            "DB_event_crafts_material.csv",
            "DB_event_dice.csv",
            "DB_event_dice_mission.csv",
            "DB_event_dice_question.csv",
            "DB_event_dice_reward.csv",
            "DB_event_disaster_triple.csv",
            "DB_event_donation.csv",
            "DB_event_exchange.csv",
            "DB_event_exchange_box.csv",
            "DB_event_exchange_box_setting.csv",
            "DB_event_exchange_card_group.csv",
            "DB_event_exchange_card_reward.csv",
            "DB_event_exchange_card_setting.csv",
            "DB_event_fortune_attendance.csv",
            "DB_event_furniture.csv",
            "DB_event_gamblebox_display.csv",
            "DB_event_gamblebox_group.csv",
            "DB_event_growth.csv",
            "DB_event_king_amber.csv",
            "DB_event_ladder_reward.csv",
            "DB_event_lobby.csv",
            "DB_event_lobby_gift.csv",
            "DB_event_luckybag_reward.csv",
            "DB_event_luckybag_set.csv",
            "DB_event_luckybox.csv",
            "DB_event_match_block.csv",
            "DB_event_match_buff.csv",
            "DB_event_match_config.csv",
            "DB_event_match_hawk.csv",
            "DB_event_match_matchreward.csv",
            "DB_event_match_scorereward.csv",
            "DB_event_mission.csv",
            "DB_event_mission_achievepoint.csv",
            "DB_event_mission_chapter.csv",
            "DB_event_mission_reward.csv",
            "DB_event_mission_score.csv",
            "DB_event_mission_score_set.csv",
            "DB_event_mole_game_hawk.csv",
            "DB_event_mole_game_note.csv",
            "DB_event_mole_record_reward.csv",
            "DB_event_mole_score_reward.csv",
            "DB_event_monthly_setting.csv",
            "DB_event_monthly_story.csv",
            "DB_event_payback.csv",
            "DB_event_playcount.csv",
            "DB_event_predict_npc_act.csv",
            "DB_event_predict_reward.csv",
            "DB_event_predict_setting.csv",
            "DB_event_predict_special_reward.csv",
            "DB_event_predict_upgrade.csv",
            "DB_event_provision_cutscene.csv",
            "DB_event_provision_localization.csv",
            "DB_event_provision_reward.csv",
            "DB_event_provision_section.csv",
            "DB_event_pvp_wincount.csv",
            "DB_event_pvp_wincount_week.csv",
            "DB_event_random_box_draw_rate.csv",
            "DB_event_random_box_reward.csv",
            "DB_event_random_box_stage.csv",
            "DB_event_rhitta_reward.csv",
            "DB_event_road_hawk.csv",
            "DB_event_road_reaction.csv",
            "DB_event_road_scorereward.csv",
            "DB_event_road_stage.csv",
            "DB_event_road_tile.csv",
            "DB_event_setup.csv",
            "DB_event_time_mission.csv",
            "DB_event_time_mission_setting.csv",
            "DB_event_treasure_hunt_finish.csv",
            "DB_event_treasure_hunt_group.csv",
            "DB_event_treasure_hunt_point.csv",
            "DB_event_treasure_hunt_setting.csv",
            "DB_event_wishbox.csv",
            "DB_evolution_break_base.csv",
            "DB_evolution_break_max.csv",
            "DB_evolution_exchange.csv",
            "DB_exp.csv",
            "DB_fade_inout.csv",
            "DB_fate.csv",
            "DB_fate_monster.csv",
            "DB_final_boss_hall_of_fame.csv",
            "DB_final_boss_hall_of_fame_list.csv",
            "DB_final_boss_season.csv",
            "DB_final_boss_setting.csv",
            "DB_final_boss_shop.csv",
            "DB_first_buy_bonus.csv",
            "DB_food_buff.csv",
            "DB_food_hero_eat_category_info.csv",
            "DB_forum_control.csv",
            "DB_free_package_reward.csv",
            "DB_friend_visit_hero.csv",
            "DB_frozen_content.csv",
            "DB_gamble_bonus_reward.csv",
            "DB_gamble_choice.csv",
            "DB_gamble_display.csv",
            "DB_gamble_group.csv",
            "DB_gamble_payback.csv",
            "DB_gamble_payback_reward.csv",
            "DB_gamble_rating_per.csv",
            "DB_gamble_rotation_set.csv",
            "DB_gamble_sign.csv",
            "DB_gamble_sound.csv",
            "DB_gamble_time_switch.csv",
            "DB_game_center_achievement.csv",
            "DB_game_center_leaderboard.csv",
            "DB_global_channel_setting.csv",
            "DB_grim_book_category.csv",
            "DB_grim_book_content.csv",
            "DB_grim_book_talk.csv",
            "DB_guest_gift.csv",
            "DB_guest_interactive_talk.csv",
            "DB_guide_recommend_list.csv",
            "DB_guidelist_reward.csv",
            "DB_guild_attendance.csv",
            "DB_guild_base.csv",
            "DB_guild_boss_battlescore_info.csv",
            "DB_guild_boss_guild_reward.csv",
            "DB_guild_boss_hell_mission.csv",
            "DB_guild_boss_hell_reward.csv",
            "DB_guild_boss_mission.csv",
            "DB_guild_boss_personal_reward.csv",
            "DB_guild_boss_season.csv",
            "DB_guild_donation.csv",
            "DB_guild_exp_boost.csv",
            "DB_guild_group_mission.csv",
            "DB_guild_mark.csv",
            "DB_guild_mission.csv",
            "DB_guild_rank_reward.csv",
            "DB_guild_shop.csv",
            "DB_guild_skill.csv",
            "DB_guild_war_area.csv",
            "DB_guild_war_area_buff.csv",
            "DB_guild_war_buff.csv",
            "DB_guild_war_config.csv",
            "DB_guild_war_league_sign.csv",
            "DB_guild_war_low_area.csv",
            "DB_guild_war_low_play_reward.csv",
            "DB_guild_war_low_point_reward.csv",
            "DB_guild_war_low_season.csv",
            "DB_guild_war_low_tier.csv",
            "DB_guild_war_low_win_reward.csv",
            "DB_guild_war_rank_reward.csv",
            "DB_guild_war_region.csv",
            "DB_guild_war_season.csv",
            "DB_guildorder_bonusreward_group.csv",
            "DB_guildorder_mileagebonus.csv",
            "DB_guildorder_mission.csv",
            "DB_guildorder_rewardbox.csv",
            "DB_hawk_slot.csv",
            "DB_head_costume_resource.csv",
            "DB_hero_base.csv",
            "DB_hero_capacity_ment.csv",
            "DB_hero_contents_passive.csv",
            "DB_hero_detail.csv",
            "DB_hero_filter_group.csv",
            "DB_hero_group_name.csv",
            "DB_hero_growth_point_info.csv",
            "DB_hero_job_group.csv",
            "DB_hero_league_buff.csv",
            "DB_hero_league_defence.csv",
            "DB_hero_league_info.csv",
            "DB_hero_league_npc_name.csv",
            "DB_hero_league_rank.csv",
            "DB_hero_league_reward.csv",
            "DB_hero_league_score.csv",
            "DB_hero_league_season.csv",
            "DB_hero_league_season_shop.csv",
            "DB_hero_league_stage.csv",
            "DB_hero_lovepoint_reward.csv",
            "DB_hero_lovepoint_share.csv",
            "DB_interactive.csv",
            "DB_interactive_item.csv",
            "DB_interactive_talk.csv",
            "DB_interactive_vr.csv",
            "DB_item_gotcha_display.csv",
            "DB_item_gotcha_group.csv",
            "DB_item_gotcha_rating_per.csv",
            "DB_item_gotcha_sign.csv",
            "DB_item_info.csv",
            "DB_item_type_desc.csv",
            "DB_item_type_desc_irregular.csv",
            "DB_journal.csv",
            "DB_jukebox_list.csv",
            "DB_king_amber.csv",
            "DB_levelup_package.csv",
            "DB_loading_default.csv",
            "DB_loading_scene.csv",
            "DB_loading_setting.csv",
            "DB_loading_tip.csv",
            "DB_lobby_housing_buff.csv",
            "DB_lobby_housing_furniture_base.csv",
            "DB_lobby_housing_shop.csv",
            "DB_lobby_npc_reward.csv",
            "DB_lose_guide.csv",
            "DB_mailbox.csv",
            "DB_material_change.csv",
            "DB_material_fusion_config.csv",
            "DB_material_info.csv",
            "DB_maze_need_hero.csv",
            "DB_maze_replay_bonus.csv",
            "DB_maze_season.csv",
            "DB_maze_season_shop.csv",
            "DB_maze_season_shop_grade.csv",
            "DB_maze_shop.csv",
            "DB_maze_shop_buff.csv",
            "DB_mercenary_npc_setting.csv",
            "DB_mission.csv",
            "DB_mission_achievepoint.csv",
            "DB_mission_play_title.csv",
            "DB_mission_play_title_group.csv",
            "DB_monster_ai.csv",
            "DB_monster_base.csv",
            "DB_monster_resource.csv",
            "DB_monster_skill.csv",
            "DB_musical_base.csv",
            "DB_normal_package.csv",
            "DB_notice.csv",
            "DB_npc_info.csv",
            "DB_npc_prop.csv",
            "DB_package_weapon_growth.csv",
            "DB_package_week_setup.csv",
            "DB_pass_design_setting.csv",
            "DB_pass_mission_rank.csv",
            "DB_pass_mission_rank_reward.csv",
            "DB_pass_mission_reward.csv",
            "DB_patrol.csv",
            "DB_patrol_time_reward.csv",
            "DB_popup_package.csv",
            "DB_pvp_chaos_base.csv",
            "DB_pvp_chaos_grade_change.csv",
            "DB_pvp_chaos_hero_cost.csv",
            "DB_pvp_chaos_rank_reward.csv",
            "DB_pvp_low_league_reward_group.csv",
            "DB_pvp_low_league_rule_setting.csv",
            "DB_pvp_mode_base.csv",
            "DB_pvp_npc_name.csv",
            "DB_pvp_point.csv",
            "DB_pvp_reward.csv",
            "DB_pvp_rule_setting.csv",
            "DB_pvp_season_base.csv",
            "DB_pvp_season_reward_group.csv",
            "DB_pvp_shop.csv",
            "DB_pvp_show.csv",
            "DB_pvp_smash_reward.csv",
            "DB_pvp_smash_shop.csv",
            "DB_pvp_smash_shop_grade.csv",
            "DB_pvp_smash_shop_reward.csv",
            "DB_pvp_top_rank.csv",
            "DB_pvp_tournament_reward.csv",
            "DB_pvp_user_report.csv",
            "DB_quest.csv",
            "DB_quest_character.csv",
            "DB_quest_character_costume.csv",
            "DB_quest_event_stepup_group.csv",
            "DB_quest_event_utility.csv",
            "DB_quest_extra.csv",
            "DB_quest_sound.csv",
            "DB_quest_talk.csv",
            "DB_rating.csv",
            "DB_recommend_team.csv",
            "DB_region.csv",
            "DB_region_change.csv",
            "DB_region_sub_matching.csv",
            "DB_selected_exchange_info.csv",
            "DB_sell_item_info.csv",
            "DB_sequence.csv",
            "DB_set_costume.csv",
            "DB_sfx.csv",
            "DB_shop_choice_package.csv",
            "DB_shop_consume.csv",
            "DB_shop_creaturecolosseum.csv",
            "DB_shop_hawk_mileage.csv",
            "DB_shop_hub.csv",
            "DB_shop_menu.csv",
            "DB_shop_money.csv",
            "DB_shop_package.csv",
            "DB_shop_yggdrasil_mileage.csv",
            "DB_situation_package.csv",
            "DB_skill_card_base.csv",
            "DB_skill_card_buff.csv",
            "DB_skill_card_bullet.csv",
            "DB_skill_card_option.csv",
            "DB_skill_card_resource.csv",
            "DB_skill_passive.csv",
            "DB_skill_passive_condition_icon.csv",
            "DB_skill_search_group.csv",
            "DB_skill_search_info.csv",
            "DB_skin_ani.csv",
            "DB_skin_awaken.csv",
            "DB_skin_awaken_resource.csv",
            "DB_skin_awaken_stat.csv",
            "DB_skin_base.csv",
            "DB_skin_costume_resource.csv",
            "DB_skin_evolution.csv",
            "DB_skin_exceed.csv",
            "DB_skin_exclusive_passive.csv",
            "DB_skin_levelup_bonus.csv",
            "DB_skin_skill.csv",
            "DB_skin_skill_levelup.csv",
            "DB_skin_transcend.csv",
            "DB_sns_reward.csv",
            "DB_sound.csv",
            "DB_stage.csv",
            "DB_stage_ancient.csv",
            "DB_stage_ancient_boss_desc.csv",
            "DB_stage_ancient_mission.csv",
            "DB_stage_ancient_mission_buff.csv",
            "DB_stage_ancient_rank_reward.csv",
            "DB_stage_ancient_reward.csv",
            "DB_stage_boss.csv",
            "DB_stage_boss_destroy.csv",
            "DB_stage_boss_season.csv",
            "DB_stage_challenge_boss.csv",
            "DB_stage_challenge_boss_desc.csv",
            "DB_stage_challenge_boss_event.csv",
            "DB_stage_challenge_boss_group.csv",
            "DB_stage_conquest.csv",
            "DB_stage_creaturenest.csv",
            "DB_stage_creaturenest_gauge.csv",
            "DB_stage_creaturenest_info.csv",
            "DB_stage_demonlord.csv",
            "DB_stage_demonlord_desc.csv",
            "DB_stage_descent_boss.csv",
            "DB_stage_descent_boss_group.csv",
            "DB_stage_destroy.csv",
            "DB_stage_destroy_common.csv",
            "DB_stage_destroy_desc.csv",
            "DB_stage_event_monthly.csv",
            "DB_stage_event_tower.csv",
            "DB_stage_event_tower_season.csv",
            "DB_stage_extra.csv",
            "DB_stage_final_boss.csv",
            "DB_stage_final_boss_battlescore.csv",
            "DB_stage_final_boss_event.csv",
            "DB_stage_final_boss_group.csv",
            "DB_stage_final_boss_mission.csv",
            "DB_stage_final_boss_rank_reward.csv",
            "DB_stage_final_boss_score_group.csv",
            "DB_stage_final_boss_scorereward.csv",
            "DB_stage_final_boss_vow.csv",
            "DB_stage_free.csv",
            "DB_stage_global_drop.csv",
            "DB_stage_global_type.csv",
            "DB_stage_guild_war.csv",
            "DB_stage_guild_war_low.csv",
            "DB_stage_limited.csv",
            "DB_stage_maze.csv",
            "DB_stage_maze_passive.csv",
            "DB_stage_maze_season_reward.csv",
            "DB_stage_maze_spot.csv",
            "DB_stage_memorial.csv",
            "DB_stage_npc_base.csv",
            "DB_stage_npc_setting.csv",
            "DB_stage_play_count.csv",
            "DB_stage_quest.csv",
            "DB_stage_reverse.csv",
            "DB_stage_reverse_group.csv",
            "DB_stage_reverse_group_reward.csv",
            "DB_stage_reverse_mission.csv",
            "DB_stage_reverse_season_reward.csv",
            "DB_stage_run.csv",
            "DB_stage_single_siege.csv",
            "DB_stage_single_siege_desc.csv",
            "DB_stage_subdue_boss.csv",
            "DB_stage_subdue_boss_group.csv",
            "DB_stage_subdue_boss_reward.csv",
            "DB_stage_subdue_tag.csv",
            "DB_stage_tournament.csv",
            "DB_stage_tournament_team_info.csv",
            "DB_stage_tower.csv",
            "DB_stage_tower_mode_passive.csv",
            "DB_stage_tower_season.csv",
            "DB_stage_training.csv",
            "DB_stage_training_group.csv",
            "DB_stage_training_play_count.csv",
            "DB_stage_training_task.csv",
            "DB_stage_training_task_open.csv",
            "DB_stage_type.csv",
            "DB_stage_week.csv",
            "DB_stage_week_buff.csv",
            "DB_stage_week_random_stage.csv",
            "DB_stage_week_reward.csv",
            "DB_stage_week_setup.csv",
            "DB_stage_yggdrasil_tower.csv",
            "DB_stamp_chat.csv",
            "DB_stepup_gamble_bonus_reward.csv",
            "DB_stepup_gamble_info.csv",
            "DB_stepup_mileage.csv",
            "DB_stepup_mileage_bonus_reward.csv",
            "DB_stepup_set.csv",
            "DB_storyreview_area.csv",
            "DB_storyreview_list.csv",
            "DB_storyreview_root.csv",
            "DB_storyreview_stage.csv",
            "DB_time_stepup_package.csv",
            "DB_town_change.csv",
            "DB_town_donation_value_config.csv",
            "DB_training_mission_reward.csv",
            "DB_training_stage_mission.csv",
            "DB_tutorial_reward.csv",
            "DB_upgrade_rating.csv",
            "DB_video.csv",
            "DB_weapon_auto_setting.csv",
            "DB_weapon_base.csv",
            "DB_weapon_base_change.csv",
            "DB_weapon_carve_base.csv",
            "DB_weapon_costume_resource.csv",
            "DB_weapon_event_set.csv",
            "DB_weapon_evolution.csv",
            "DB_weapon_grind.csv",
            "DB_weapon_growth.csv",
            "DB_weapon_magic.csv",
            "DB_weapon_option.csv",
            "DB_weapon_option_change.csv",
            "DB_weapon_set.csv",
            "DB_weapon_upgrade.csv",
            "DB_welcome_attendance.csv"
    };  // The index of each element must correspond to its corresponding table in TableType

    public enum TableType
    {
        AiCustomizingBasicPreset,
        AiCustomizingCondition,
        AiCustomizingCost,
        AiCustomizingEtc,
        AiCustomizingGroup,
        AiCustomizingIcon,
        AiCustomizingMove,
        AiCustomizingMoveType,
        AiCustomizingSkillType,
        AiCustomizingTarget,
        ArCharacters,
        ArDevices,
        ArSystems,
        Area,
        ArtifactCard,
        ArtifactCardUnion,
        ArtifactCategory,
        ArtifactEventGroup,
        ArtifactGroup,
        ArtifactUnionFilterGroup,
        AttendanceHero,
        AttendancePackage,
        BasepointCollisionNpc,
        BasepointFellowReward,
        BasepointInteractiveAni,
        BasepointNpc,
        BasepointNpcMove,
        BasepointNpcTalk,
        BasepointRandomShop,
        BasepointShop,
        Birthday,
        BlindContent,
        BoxItemInfo,
        BundleDiscountPackage,
        CardpackArtifactEvent,
        CardpackArtifactInfo,
        CardpackPackageInfo,
        Chapter,
        ChapterChange,
        ChapterGroup,
        CharacterLocalizeInfo,
        CoinDemonpoint,
        CoinShop,
        CoinShopEvent,
        CoinShopSetting,
        ConfigGame,
        ConstManastoneRandom,
        ConstellationBase,
        ConstellationIgnoreTeam,
        ConstellationStone,
        ContentAd,
        ContentAdRoulette,
        ContentControl,
        ContentLink,
        ContentsPassive,
        ControlAnother,
        CookingList,
        CookingMaterial,
        CookingRecipe,
        CostumeBase,
        CostumeChangeSfx,
        CostumeCraft,
        CostumeShop,
        CostumeShopGroup,
        CostumeShopPackage,
        CostumeShopSetting,
        CostumeStat,
        CraftCostumeUpgrade,
        CraftCostumeUpgradeFinish,
        CreaturePassive,
        CreaturecolosseumSeason,
        DailyAttendance,
        DemonlordPassive,
        DemonlordRule,
        DemonlordRuleinfo,
        DirectSelector,
        Event,
        EventAdditionalPayment,
        EventAltarReward,
        EventAttendance,
        EventAutoBoxreward,
        EventAutoBoxslot,
        EventAutoBuff,
        EventAutoGroup,
        EventAutoHero,
        EventAutoLevelup,
        EventAutoMonster,
        EventAutoSetting,
        EventAutoStage,
        EventBalloondartBalloon,
        EventBalloondartChance,
        EventBalloondartPin,
        EventBalloondartReward,
        EventBalloondartScore,
        EventBalloondartSpecial,
        EventBalloondartStage,
        EventBingo,
        EventBingoExchange,
        EventBingoRandom,
        EventBingoReward,
        EventBossMission,
        EventBuff,
        EventBuffLobby,
        EventChallengeDestroy,
        EventChallengeDestroyscore,
        EventCheerFinish,
        EventCheerGauge,
        EventCheerGroup,
        EventCheerReward,
        EventConfirmBox,
        EventConfirmConfig,
        EventConfirmImage,
        EventConfirmNote,
        EventConfirmReward,
        EventConfirmScore,
        EventConquest,
        EventConquestCharacter,
        EventConquestCutIn,
        EventConquestCutscene,
        EventConquestEnemy,
        EventConquestFever,
        EventConquestLocalization,
        EventConquestProduction,
        EventConquestReward,
        EventConquestTile,
        EventCrafts,
        EventCraftsLocalization,
        EventCraftsMaterial,
        EventDice,
        EventDiceMission,
        EventDiceQuestion,
        EventDiceReward,
        EventDisasterTriple,
        EventDonation,
        EventExchange,
        EventExchangeBox,
        EventExchangeBoxSetting,
        EventExchangeCardGroup,
        EventExchangeCardReward,
        EventExchangeCardSetting,
        EventFortuneAttendance,
        EventFurniture,
        EventGambleboxDisplay,
        EventGambleboxGroup,
        EventGrowth,
        EventKingAmber,
        EventLadderReward,
        EventLobby,
        EventLobbyGift,
        EventLuckybagReward,
        EventLuckybagSet,
        EventLuckybox,
        EventMatchBlock,
        EventMatchBuff,
        EventMatchConfig,
        EventMatchHawk,
        EventMatchMatchreward,
        EventMatchScorereward,
        EventMission,
        EventMissionAchievepoint,
        EventMissionChapter,
        EventMissionReward,
        EventMissionScore,
        EventMissionScoreSet,
        EventMoleGameHawk,
        EventMoleGameNote,
        EventMoleRecordReward,
        EventMoleScoreReward,
        EventMonthlySetting,
        EventMonthlyStory,
        EventPayback,
        EventPlaycount,
        EventPredictNpcAct,
        EventPredictReward,
        EventPredictSetting,
        EventPredictSpecialReward,
        EventPredictUpgrade,
        EventProvisionCutscene,
        EventProvisionLocalization,
        EventProvisionReward,
        EventProvisionSection,
        EventPvpWincount,
        EventPvpWincountWeek,
        EventRandomBoxDrawRate,
        EventRandomBoxReward,
        EventRandomBoxStage,
        EventRhittaReward,
        EventRoadHawk,
        EventRoadReaction,
        EventRoadScorereward,
        EventRoadStage,
        EventRoadTile,
        EventSetup,
        EventTimeMission,
        EventTimeMissionSetting,
        EventTreasureHuntFinish,
        EventTreasureHuntGroup,
        EventTreasureHuntPoint,
        EventTreasureHuntSetting,
        EventWishbox,
        EvolutionBreakBase,
        EvolutionBreakMax,
        EvolutionExchange,
        Exp,
        FadeInout,
        Fate,
        FateMonster,
        FinalBossHallOfFame,
        FinalBossHallOfFameList,
        FinalBossSeason,
        FinalBossSetting,
        FinalBossShop,
        FirstBuyBonus,
        FoodBuff,
        FoodHeroEatCategoryInfo,
        ForumControl,
        FreePackageReward,
        FriendVisitHero,
        FrozenContent,
        GambleBonusReward,
        GambleChoice,
        GambleDisplay,
        GambleGroup,
        GamblePayback,
        GamblePaybackReward,
        GambleRatingPer,
        GambleRotationSet,
        GambleSign,
        GambleSound,
        GambleTimeSwitch,
        GameCenterAchievement,
        GameCenterLeaderboard,
        GlobalChannelSetting,
        GrimBookCategory,
        GrimBookContent,
        GrimBookTalk,
        GuestGift,
        GuestInteractiveTalk,
        GuideRecommendList,
        GuidelistReward,
        GuildAttendance,
        GuildBase,
        GuildBossBattlescoreInfo,
        GuildBossGuildReward,
        GuildBossHellMission,
        GuildBossHellReward,
        GuildBossMission,
        GuildBossPersonalReward,
        GuildBossSeason,
        GuildDonation,
        GuildExpBoost,
        GuildGroupMission,
        GuildMark,
        GuildMission,
        GuildRankReward,
        GuildShop,
        GuildSkill,
        GuildWarArea,
        GuildWarAreaBuff,
        GuildWarBuff,
        GuildWarConfig,
        GuildWarLeagueSign,
        GuildWarLowArea,
        GuildWarLowPlayReward,
        GuildWarLowPointReward,
        GuildWarLowSeason,
        GuildWarLowTier,
        GuildWarLowWinReward,
        GuildWarRankReward,
        GuildWarRegion,
        GuildWarSeason,
        GuildorderBonusrewardGroup,
        GuildorderMileagebonus,
        GuildorderMission,
        GuildorderRewardbox,
        HawkSlot,
        HeadCostumeResource,
        HeroBase,
        HeroCapacityMent,
        HeroContentsPassive,
        HeroDetail,
        HeroFilterGroup,
        HeroGroupName,
        HeroGrowthPointInfo,
        HeroJobGroup,
        HeroLeagueBuff,
        HeroLeagueDefence,
        HeroLeagueInfo,
        HeroLeagueNpcName,
        HeroLeagueRank,
        HeroLeagueReward,
        HeroLeagueScore,
        HeroLeagueSeason,
        HeroLeagueSeasonShop,
        HeroLeagueStage,
        HeroLovepointReward,
        HeroLovepointShare,
        Interactive,
        InteractiveItem,
        InteractiveTalk,
        InteractiveVr,
        ItemGotchaDisplay,
        ItemGotchaGroup,
        ItemGotchaRatingPer,
        ItemGotchaSign,
        ItemInfo,
        ItemTypeDesc,
        ItemTypeDescIrregular,
        Journal,
        JukeboxList,
        KingAmber,
        LevelupPackage,
        LoadingDefault,
        LoadingScene,
        LoadingSetting,
        LoadingTip,
        LobbyHousingBuff,
        LobbyHousingFurnitureBase,
        LobbyHousingShop,
        LobbyNpcReward,
        LoseGuide,
        Mailbox,
        MaterialChange,
        MaterialFusionConfig,
        MaterialInfo,
        MazeNeedHero,
        MazeReplayBonus,
        MazeSeason,
        MazeSeasonShop,
        MazeSeasonShopGrade,
        MazeShop,
        MazeShopBuff,
        MercenaryNpcSetting,
        Mission,
        MissionAchievepoint,
        MissionPlayTitle,
        MissionPlayTitleGroup,
        MonsterAi,
        MonsterBase,
        MonsterResource,
        MonsterSkill,
        MusicalBase,
        NormalPackage,
        Notice,
        NpcInfo,
        NpcProp,
        PackageWeaponGrowth,
        PackageWeekSetup,
        PassDesignSetting,
        PassMissionRank,
        PassMissionRankReward,
        PassMissionReward,
        Patrol,
        PatrolTimeReward,
        PopupPackage,
        PvpChaosBase,
        PvpChaosGradeChange,
        PvpChaosHeroCost,
        PvpChaosRankReward,
        PvpLowLeagueRewardGroup,
        PvpLowLeagueRuleSetting,
        PvpModeBase,
        PvpNpcName,
        PvpPoint,
        PvpReward,
        PvpRuleSetting,
        PvpSeasonBase,
        PvpSeasonRewardGroup,
        PvpShop,
        PvpShow,
        PvpSmashReward,
        PvpSmashShop,
        PvpSmashShopGrade,
        PvpSmashShopReward,
        PvpTopRank,
        PvpTournamentReward,
        PvpUserReport,
        Quest,
        QuestCharacter,
        QuestCharacterCostume,
        QuestEventStepupGroup,
        QuestEventUtility,
        QuestExtra,
        QuestSound,
        QuestTalk,
        Rating,
        RecommendTeam,
        Region,
        RegionChange,
        RegionSubMatching,
        SelectedExchangeInfo,
        SellItemInfo,
        Sequence,
        SetCostume,
        Sfx,
        ShopChoicePackage,
        ShopConsume,
        ShopCreaturecolosseum,
        ShopHawkMileage,
        ShopHub,
        ShopMenu,
        ShopMoney,
        ShopPackage,
        ShopYggdrasilMileage,
        SituationPackage,
        SkillCardBase,
        SkillCardBuff,
        SkillCardBullet,
        SkillCardOption,
        SkillCardResource,
        SkillPassive,
        SkillPassiveConditionIcon,
        SkillSearchGroup,
        SkillSearchInfo,
        SkinAni,
        SkinAwaken,
        SkinAwakenResource,
        SkinAwakenStat,
        SkinBase,
        SkinCostumeResource,
        SkinEvolution,
        SkinExceed,
        SkinExclusivePassive,
        SkinLevelupBonus,
        SkinSkill,
        SkinSkillLevelup,
        SkinTranscend,
        SnsReward,
        Sound,
        Stage,
        StageAncient,
        StageAncientBossDesc,
        StageAncientMission,
        StageAncientMissionBuff,
        StageAncientRankReward,
        StageAncientReward,
        StageBoss,
        StageBossDestroy,
        StageBossSeason,
        StageChallengeBoss,
        StageChallengeBossDesc,
        StageChallengeBossEvent,
        StageChallengeBossGroup,
        StageConquest,
        StageCreaturenest,
        StageCreaturenestGauge,
        StageCreaturenestInfo,
        StageDemonlord,
        StageDemonlordDesc,
        StageDescentBoss,
        StageDescentBossGroup,
        StageDestroy,
        StageDestroyCommon,
        StageDestroyDesc,
        StageEventMonthly,
        StageEventTower,
        StageEventTowerSeason,
        StageExtra,
        StageFinalBoss,
        StageFinalBossBattlescore,
        StageFinalBossEvent,
        StageFinalBossGroup,
        StageFinalBossMission,
        StageFinalBossRankReward,
        StageFinalBossScoreGroup,
        StageFinalBossScorereward,
        StageFinalBossVow,
        StageFree,
        StageGlobalDrop,
        StageGlobalType,
        StageGuildWar,
        StageGuildWarLow,
        StageLimited,
        StageMaze,
        StageMazePassive,
        StageMazeSeasonReward,
        StageMazeSpot,
        StageMemorial,
        StageNpcBase,
        StageNpcSetting,
        StagePlayCount,
        StageQuest,
        StageReverse,
        StageReverseGroup,
        StageReverseGroupReward,
        StageReverseMission,
        StageReverseSeasonReward,
        StageRun,
        StageSingleSiege,
        StageSingleSiegeDesc,
        StageSubdueBoss,
        StageSubdueBossGroup,
        StageSubdueBossReward,
        StageSubdueTag,
        StageTournament,
        StageTournamentTeamInfo,
        StageTower,
        StageTowerModePassive,
        StageTowerSeason,
        StageTraining,
        StageTrainingGroup,
        StageTrainingPlayCount,
        StageTrainingTask,
        StageTrainingTaskOpen,
        StageType,
        StageWeek,
        StageWeekBuff,
        StageWeekRandomStage,
        StageWeekReward,
        StageWeekSetup,
        StageYggdrasilTower,
        StampChat,
        StepupGambleBonusReward,
        StepupGambleInfo,
        StepupMileage,
        StepupMileageBonusReward,
        StepupSet,
        StoryreviewArea,
        StoryreviewList,
        StoryreviewRoot,
        StoryreviewStage,
        TimeStepupPackage,
        TownChange,
        TownDonationValueConfig,
        TrainingMissionReward,
        TrainingStageMission,
        TutorialReward,
        UpgradeRating,
        Video,
        WeaponAutoSetting,
        WeaponBase,
        WeaponBaseChange,
        WeaponCarveBase,
        WeaponCostumeResource,
        WeaponEventSet,
        WeaponEvolution,
        WeaponGrind,
        WeaponGrowth,
        WeaponMagic,
        WeaponOption,
        WeaponOptionChange,
        WeaponSet,
        WeaponUpgrade,
        WelcomeAttendance
    }
}
