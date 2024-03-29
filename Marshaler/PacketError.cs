﻿public enum PacketError : uint
{
    None,
    DB_System_Error,
    System_Error,
    Security_Verify_Failed,
    User_Max,
    Duplication,
    Invalid_User,
    Invalid_Connection,
    Invalid_USN,
    Invalid_Session,
    Invalid_TableInfo,
    Need_QA_Auth,
    Invalid_Auth,
    Already_AuthCreate,
    Need_Client_Update,
    Need_Cdn_Update,
    Under_Maintenance,
    Stage_Time_Error,
    Invalid_ReconnectRequest,
    Invalid_UserType,
    Invalid_Cookie,
    Invalid_Already_Packet,
    Invalid_Request = 100U,
    NotEnough_Item,
    NotEnough_AP,
    WeekStage_NotOpen,
    WeekStage_NewOpen,
    ArenaLeague_NotOpen,
    ArenaLeague_NotJoinCurrentLeague,
    Stage_NotComplete_Quest,
    Guild_Cannot_JoinOrCreateTime,
    Cannot_Connect_Redis,
    Need_DailyReset,
    ReconnectRequest_Wating,
    Relay_NotExist_Room,
    Relay_Cannot_ListMember,
    Relay_Invalid_RoomState,
    Relay_Invalid_RoomSerial,
    Relay_Invalid_UserSerial,
    Relay_Not_Owner,
    Relay_Not_Member,
    Relay_Max_Member,
    Relay_Cannot_Connect,
    Relay_Not_JoinAnyRoom,
    Relay_Already_JoinOrCreate,
    Relay_Invalid_BattleExit,
    Relay_Already_Changed_Mode,
    Relay_Already_Join,
    Friend_Delete_Daily_Max,
    Event_Already_Closed,
    Event_Exchange_Max_Count,
    Event_Already_Reward,
    Event_Gacha_Max_Count,
    Event_Time_Over,
    Event_SeasonPass_Not_Buy_Package,
    Event_SeasonPass_Already_Buy_Package,
    Event_SeasonPass_Invalid_Rank_Reward,
    Event_SeasonPass_Buy_Package_Invalid_Time,
    Event_SeasonPass_Max_Rank,
    Recipe_Collect_Empty,
    Inventory_Full,
    Item_Count_Full,
    WeaponInventory_Full,
    Stamina_Full,
    PvpStamina_Full,
    TrainingStamina_Full,
    Gold_Full,
    Free_Dia_Full,
    Buy_Dia_Full,
    FriendPoint_Full,
    PvpCoin_Full,
    AchievePoint_Full,
    FellowshipPoint_Full,
    FinalBossCoin_Full,
    FinalBossPoint_Bronze_Full,
    FinalBossPoint_Silver_Full,
    FinalBossPoint_Gold_Full,
    GuildDonationMoney_Full,
    GuildGold_Full,
    Weekkey_Full,
    PvpSmashCoin_Full,
    ClearTicket_Full,
    Timelimit_Key_Full,
    Mission_Max_Count,
    TrainingStage_NotOpen,
    Redis_Master_Change,
    Get_Item,
    Contents_Maintenance,
    FriendPoint_Daily_Full,
    WeaponLocked,
    Shop_Refresh_Reset_Count_Daily_Max,
    ItemBoxCodeIncorrect,
    BoxGacha_Empty,
    BoxGacha_Reset_UnAble,
    BoxGacha_Reset_Count_Over,
    ReTry_Send,
    NotEnough_AP_Event,
    NotEnough_AP_Evolution,
    NotEnough_AP_Gold,
    Weekly_Event_Item_Full,
    Weekly_Gold_Item_Full,
    TimeMission_End,
    TimeMission_Already_Started,
    RandomShop_Already_Closed,
    Shop_Invalid_Avilable_Time,
    Free_Package_Already_Reward,
    Free_Package_Need_Condition,
    PackageMission_Check_Condition,
    PackageMission_TimeOver,
    Contents_OFF_InApp_AD,
    Stage_Reset,
    Event_Newroulette_Data_Error,
    notice_battle_reconect_blitz_reset_01,
    Destroy_Not_EventDisasterDestroy,
    EVENT_CARVE_DISCOUNT_INVALID,
    Event_Predict_InvalidInfo,
    Event_Predict_Wrong_Special_Index,
    Event_Predict_Not_ValidSpecialInfo,
    Event_Predict_Need_More_Score,
    Gamble_Mileage_Over,
    Gacha_Payback_Point_Excess,
    Yggdrasil_Tower_Stamina_Full,
    NotEnough_Yggdrasil_Stamina,
    Event_Cheer_Invalid_Finish_RewardInfo,
    CreatureNest_Key_Full,
    Event_Puzzle_Stamina_Full,
    NotEnough_Event_Puzzle_Stamina,
    Account_Withdraw_Failed_Join_Guild,
    Account_Withdraw_Failed_SIWA_Revoke,
    Const_Chaos_Item_Full,
    Event_Confirm_Game_Stamina_Full,
    NotEnough_Event_Confirm_Game_Stamina,
    evolution_lr_key_max_01,
    evolution_lr_key_max_02,
    Destroy_NotExist_Room = 500U,
    Destroy_Not_Owner,
    Destroy_Not_Member,
    Destroy_Not_Found,
    Destroy_Not_JoinAnyRoom,
    Destroy_Already_TimeOver,
    Destroy_Already_Started,
    Destroy_Already_Finished,
    Destroy_Max_Member,
    Destroy_Invalid_RoomSerial,
    Destroy_Invalid_RoomState,
    Destroy_Invalid_UserSerial,
    Destroy_Invalid_Difficulty,
    Destroy_Cannot_CreateRoom,
    Destroy_Cannot_KickUserReady,
    Destroy_Cannot_ChangeTeamReady,
    Destroy_Not_ReadyAllMember,
    Destroy_Already_Created,
    Destroy_Already_Cleared,
    Destroy_Cannot_CreateUserBattle,
    Destroy_Invalid_AITeam,
    Destroy_Invalid_RoundID,
    Destroy_Already_RoundFinished,
    Destroy_Not_DisasterSeason,
    Destroy_Not_SeasonActiveDay,
    Destroy_Cannot_InviteProcessingLiveJoin,
    Destroy_Cannot_InviteUnregisterLiveJoin,
    Destroy_Cannot_JoinProcessingLiveJoin,
    Destroy_Cannot_JoinInvitationAborted,
    Destroy_Cannot_InviteNotConnected,
    Destroy_Already_LiveJoin,
    Destroy_One_Step_Clear_Insufficient_Food,
    Guild_Already_JoinOrCreate = 600U,
    Guild_Not_JoinOrCreate,
    Guild_Not_Applicant,
    Guild_Invalid_Serial,
    Guild_Invalid_GuildName,
    Guild_Invalid_ApprovalType,
    Guild_NotEnough_Grade,
    Guild_Cannot_Leave,
    Guild_Cannot_Apply,
    Guild_Room_NotOpen,
    Guild_Attend_First,
    Guild_NotExists_PrevAttendCount,
    Guild_NotExists_AttendanceTableInfo,
    Guild_Already_Attend_Reward,
    Guild_Cannot_Apply_LevelLimit,
    Guild_Shop_Seq_Changed,
    Guild_Shop_Buy_Count_Max,
    Guild_Not_Applicant_Member,
    Guild_NotEnough_GuildLevel,
    Guild_NotEnough_SkillPoint,
    Guild_Already_SkillUse,
    Guild_NotExists_OwnSkill,
    Guild_Working_OtherMember,
    Guild_Cannot_InviteMemberMax,
    Guild_Cannot_InviteAlreadyJoin,
    Guild_Cannot_InviteOptionOff,
    Guild_Already_Invited,
    Guild_Cannot_InviteQuestCondition,
    GuildBoss_Seq_Change,
    GuildBoss_IsLocked,
    Guild_Already_Recruit,
    Guild_Not_Recruit,
    Guild_Cannot_Apply_BattlePoint,
    Guild_Cannot_Apply_ConstellationGroup,
    Guild_NotEnough_PersonalRewardPoint,
    GuildWar_AllowSeasonEnd = 650U,
    GuildWar_DenyApplyGuild,
    GuildWar_NotJoinedGuildMember,
    GuildWar_NotInSeason,
    GuildWar_SeasonChange,
    GuildWar_NotInBattleSetting,
    GuildWar_RegionBonusScoreAlreadyMax,
    GuildWar_RegionBonusScoreLimit,
    GuildWar_InTranRegionBonusScore,
    GuildWar_NotSelectionGuild,
    GuildWar_NotInBattleAndInBattleSetting,
    GuildWar_NotInBattle,
    GuildWar_InBattleAnotherUser,
    GuildWar_InvalidGuildSelectionInfo,
    GuildWar_InvalidGuildSquadInfo,
    GuildWar_NotInSquadUseHeroID,
    GuildWar_NotAliveUseHeroID,
    GuildWar_ExistUsedHeroID,
    GuildWar_RejoinTimeOut,
    GuildWar_NotClearNeedStage,
    GuildWar_AlreadyCleardTeam,
    GuildWar_InBattleRejoinTimeOut,
    GuildWar_NotCurrentVersusGuild,
    GuildWar_DefenceBMSlotAlreadyMax,
    GuildWar_SquadBMSlotAlreadyMax,
    GuildWar_InBattlePrepare,
    GuildWar_InvalidHero,
    GuildWar_MemberNotPlayable,
    GuildWar_CostumeRewardTimeOut,
    GuildWar_AlreadyReceivedCostumeReward,
    GuildWar_InvalidCostumeRewardInfo,
    GuildWar_Cannnot_SquadBMSlot,
    GuildWar_NotInNonSeason,
    GuildWar_NotPrevSeasonSelectionGuild,
    FriendlyMatch_Cannot_CreateRoom = 700U,
    FriendlyMatch_Invalid_Invite,
    FriendlyMatch_Invalid_Room,
    FriendlyMatch_Already_Start,
    FriendlyMatch_Room_Max,
    FriendlyMatch_Not_Enough_Member_Count,
    FriendlyMatch_Invalid_Ready,
    FriendlyMatch_Invalid_Team_Info,
    ArenaRealTimePvp_NotOpen,
    ArenaRealTimePvp_Need_Reload,
    ArenaRealTimePvp_AlreayMatching,
    ArenaRealTimePvp_MatchingServerError,
    ArenaRealTimePvp_OpponentUserError,
    ArenaRealTimePvp_NotEnough_UserLevel,
    ArenaRealTimePvp_PvpServerMaintenance,
    ArenaRealTimeDecision_NeedGrade,
    ArenaRealTimeDecision_NotOpen,
    ArenaRealTimeLower_NeedBattlePoint,
    ArenaDecision_MatchingList_Error,
    ArenaDecision_Check_Target_Status,
    ArenaDecision_Already_MatchingList,
    ArenaDecision_AttackCount_Overt,
    ArenaRanking_NeedUpperJoin,
    ArenaRanking_NeedChallenger,
    ArenaRanking_NeedTeamSetting,
    ArenaRanking_AttackOver,
    ArenaRanking_NeedJoin,
    ArenaSmash_NotOpenContents,
    ArenaSmash_NeedTeamSetting,
    ArenaSmash_NotEnough_RecipeLevel,
    ArenaSmash_NotInitialized,
    ArenaSmash_NotOpen,
    ArenaSmash_AlreadyJoin,
    ArenaSmash_NeedJoin,
    ArenaSmash_Invalid_OpponentTime,
    ArenaSmash_Invalid_OpponentUSN,
    ArenaSmash_Invalid_MatchCount,
    ArenaSmash_NotState_BestRefresh,
    ArenaSmash_NotEnough_WinRewardPoint,
    ArenaSmash_AlreadyBestReward,
    ArenaSmash_Stamina_Full,
    ArenaSmash_CannotUpdateTeam,
    ArenaSmash_AlreadyRankReward,
    ArenaSmash_VictoryCountReward,
    FriendlyMatchObserve_InviteNotConnected,
    FriendlyMatchObserve_InvalidUserStatus,
    FinalBoss_Limit_PlayCount = 800U,
    FinalBoss_Not_In_Season,
    FinalBoss_Inactive,
    FinalBoss_Season_Change,
    FinalBoss_Mission_Rotation_Cool,
    FinalBoss_Mission_Rotation_Change,
    FinalBoss_Already_Score_Reward,
    FinalBoss_NotEnough_Score,
    FinalBoss_Invalid_Score_Reward_Order,
    FinalBoss_Invalid_Vow_Id,
    ADView_DailyLimited = 850U,
    ADView_NotCool,
    Guild_Mission_Already_Reward = 900U,
    Guild_Mission_Not_Achieve,
    TrainingStage_PlayCount_Over = 950U,
    TrainingStage_OpenCount_Over,
    TrainingStage_Already_Opend,
    TrainingStage_Need_Reset,
    Billing_Invalid_ItemID = 1000U,
    Billing_Invalid_TransactionID,
    Billing_Already_Buy,
    Billing_Fail_InitScript,
    Billing_Fail_Parsing,
    Billing_Fail_Coupon,
    Billing_Fail_CrossPromotion,
    Billing_Fail_MarbleRequest,
    Billing_Fail_Invalied_Itemid,
    Billing_Need_Condition_Item,
    Billing_System_Error,
    Billing_Check_Age,
    Billing_Time_Over,
    Billing_Invalid_ChoicePackage,
    Billing_Choice_Item_Select,
    SubdueBoss_NotExist_Game = 1050U,
    SubdueBoss_NotCreate_Game,
    SubdueBoss_Not_Owner,
    SubdueBoss_Not_Member,
    SubdueBoss_Not_Found,
    SubdueBoss_Invalid_GameSerial,
    SubdueBoss_Invalid_NotInvite,
    SubdueBoss_Invalid_NotLobbyWait,
    SubdueBoss_Invalid_UserSerial,
    SubdueBoss_Not_ReadyAllMember,
    SubdueBoss_NotEnough_Member,
    SubdueBoss_NotEnough_Ticket,
    SubdueBoss_NotEnough_PlayCount,
    SubdueBoss_Close,
    SubdueBoss_Join_Fail,
    SubdueBoss_Invalid_QuestRequireLv,
    SubdueBoss_NotRewardEnableState,
    SubdueBoss_AlreayRewarded,
    SubdueBoss_NotInBattleState,
    SubdueBoss_Now_Allow_KickOut,
    SubdueBoss_Disconnect,
    SubdueBoss_Create_Fail_Invalid_SN,
    SubdueBoss_Join_Fail_UserFull,
    SubdueBoss_Join_Fail_HostLeave,
    SubdueBoss_Join_Fail_AlreadyJoin,
    SubdueBoss_Change_Time_Wait,
    SubdueBoss_ReJoin_Fail,
    SubdueBoss_AlreadyGameStart,
    SubdueBoss_LoadingTimeOver,
    NetmarbleQuest_Invalid_Request = 1100U,
    NetmarbleQuest_Invalid_Result,
    NetmarbleQuest_Invalid_QuestSeq,
    NetmarbleQuest_Already_Achieved,
    NetmarbleQuest_NotEnough_Reward,
    NetmarbleQuest_Failed_Enqueue,
    NetmarbleSDK_Security_Fail = 1200U,
    WestSide_Channel_Invalid_ID = 1300U,
    WestSide_Channel_MaxUser,
    WestSide_UserDataLoadFail,
    WestSide_Server_Maintenance,
    WorldChatting_Channel_MaxUser,
    channel_change_01,
    channel_change_02,
    channel_change_03,
    Tournament_Invalid_SEQ = 1400U,
    Tournament_Invalid_Player,
    Tournament_Invalid_MatchIndex,
    Tournament_Not_Progress,
    Tournament_Not_Prepare,
    Tournament_Not_Open,
    Tournament_Not_Post,
    Tournament_Not_Replay,
    Tournament_Not_OpenRound,
    Tournament_Not_MatchWait,
    Tournament_Not_ExistRoom,
    Tournament_Not_ExistOpponent,
    Tournament_Invalid_MatchMemberCount,
    Tournament_Invalid_MatcState,
    Tournament_Already_Reward,
    Tournament_Invalid_Reward,
    Tournament_Already_Cheer,
    Tournament_Not_ExistPlayerTeam,
    Tournament_Not_ExistReplayInfo,
    Bingo_NotExistUserBingoInfo = 1500U,
    Bingo_FailedCreate,
    Bingo_FailedReset,
    Bingo_NotExistItemInfo,
    Bingo_NotExistExchageInfo,
    Bingo_NotExistRewardInfo,
    Lobby_Invalid_Npc = 1600U,
    Lobby_Barrel_Not_Empty,
    TowerStage_Closed_Contents = 1700U,
    TowerStage_Not_Clear_Open_Quest,
    TowerStage_Not_In_Season,
    TowerStage_Season_Change,
    TowerStage_Season_Reset,
    GuildWarLow_AllowSeasonEnd = 1800U,
    GuildWarLow_NotInSeason,
    GuildWarLow_InvalidHero,
    GuildWarLow_InBattlePrepare,
    GuildWarLow_NotInApplication,
    GuildWarLow_NotInBattle,
    GuildWarLow_NotInBattleSetting,
    GuildWarLow_NotEnoughGuildMember,
    GuildWarLow_InvalidAreaID,
    GuildWarLow_ExistUsedHeroID,
    GuildWarLow_NotApply,
    GuildWarLow_InBattleAnotherUser,
    GuildWarLow_NotMatchedGuild,
    GuildWarLow_AlreadyClearedArea,
    GuildWarLow_BattleCountMax,
    GuildWarLow_AnotherAreaDeployed,
    GuildWarLow_RejoinTimeOut,
    GuildWarLow_DefenceTeamSaveEnd,
    GuildWarLow_AreaDeployMax,
    GuildWarLow_InBattleRejoinTimeOut,
    GuildWarLow_AlreadyApplied,
    GuildWarLow_InvalidGuildSerial,
    GuildWarLow_AlreadyCleardTeam,
    GuildWarLow_NotGuildWarLowMember,
    HOTFIX_MESSAGE_01,
    HOTFIX_MESSAGE_02,
    HOTFIX_MESSAGE_03,
    HOTFIX_MESSAGE_04,
    HOTFIX_MESSAGE_05,
    HOTFIX_MESSAGE_06,
    HOTFIX_MESSAGE_07,
    HOTFIX_MESSAGE_08,
    HOTFIX_MESSAGE_09,
    HOTFIX_MESSAGE_10,
    AuthDB_Error = 10100U,
    AuthDB_Nickname_Duplication,
    Auth_NicknameLength,
    UserDB_Error = 10200U,
    UserDB_Already_Open,
    UserDB_Not_Enough_Item,
    UserDB_Nothing_Target,
    UserDB_Nothing_Material,
    UserDB_Skill_Level_Max,
    UserDB_Expired_Mail,
    UserDB_Too_Many_Get_Request,
    UserDB_No_Attached_Item,
    UserDB_Hero_Info_Not_Exist,
    UserDB_Skin_Info_Not_Exist,
    ArenaDB_Error = 10300U,
    FriendDB_Error = 10400U,
    FriendDB_Apply_Send_Max,
    FriendDB_Apply_Receive_Max,
    FriendDB_My_Friend_Max,
    FriendDB_Target_Friend_Max,
    FriendDB_Apply_Send_Already,
    FriendDB_Apply_Receive_Already,
    FriendDB_Already_Friend,
    FriendDB_State_Error,
    FriendDB_Target_Info_Invalid,
    FriendDB_Apply_Send_Invalid,
    FriendDB_Not_My_Friend,
    FriendDB_Already_Send_Point,
    FriendDB_Not_Found_User,
    GuildDB_Error = 10500U,
    GuildDB_Cannot_Create_AlreadyJoin,
    GuildDB_Cannot_Create_NameDuplication,
    GuildDB_Guild_Not_Found,
    GuildDB_Cannot_Disband_RemainApplicant,
    GuildDB_Cannot_Disband_RemainMember,
    GuildDB_Cannot_Join_MemberMax,
    GuildDB_Cannot_Join_ApplicantMax,
    GuildDB_Cannot_Join_InvalidGuildSN,
    GuildDB_Cannot_Join_NotApplicant,
    GuildDB_Outside_Auth,
    GuildDB_Cannot_Change_RemainApplicant,
    GuildDB_Not_Guild_Member,
    GuildDB_Cannot_Change_NotMember,
    GuildDB_Cannot_Leave_Master,
    GuildDB_Cannot_Change_InvalidGrade,
    GuildDB_Cannot_Change_SameGrade,
    GuildDB_Cannot_Change_NotSubMaster,
    GuildDB_Cannot_Reward_Mission,
    GuildDB_NotEnough_SkillPoint,
    GuildDB_GuildWar_Area_Deploy_Change = 10600U,
    GuildDB_GuildWarLow_Not_Found = 10650U,
    GuildDB_GuildWarLow_Deployee_Not_Member,
    GuildDB_GuildWarLow_Apply_Not_Regist_Account_BP,
    GuildDB_GuildWarLow_Apply_Not_Save_Defence_Team,
    MGTDB_Error = 10900U,
    CreatureNest_Already_Clear = 1900U,
    CreatureNest_Cannot_Rejoin_By_Week_Reset,
    Creature_Colosseum_Not_Season,
    Puzzle_Event_Disconnect = 1910U,
    Guild_AP_Already_Reset,
    Guild_Order_Mission_Invalid_ClearTime,
    Hero_League_Already_Initialized,
    Demon_Lord_Already_Closed,
    Skin_Exceed_Not_Open,
    Chat_Channel_Invalid,
    Chat_Channel_Max,
    Chat_Message_Invalid,
    Chat_Message_Max,
    Chat_Message_Invalid_Guild
}
