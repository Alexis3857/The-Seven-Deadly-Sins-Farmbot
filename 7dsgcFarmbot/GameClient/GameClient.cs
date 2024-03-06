using Nettention.Proud;

namespace GameClient
{
    public class GameClient : ClientBase  // Contains all the methods to send a message to the game server, we always use this class when we want to send one
    {
        private const HostID SERVER = HostID.HostID_Server;

        private readonly RmiContext RELIABLESEND = RmiContext.FastEncryptedReliableSend;

        private readonly RmiContext SECURE_RELIABLE_SEND = RmiContext.SecureReliableSend;

        public GameProxy SendProxy { get; } = new GameProxy();

        private GamePacketHandler PacketHandler { get; } = new GamePacketHandler();

        public void Initialize()
        {
            Logger.Log("[GameClient-Initialize]");
            InitializeNetClient();
            // Attach RMI proxy and stub to NetClient object
            AttachProxy(SendProxy);  // From client to server
            // From server to client
            AttachStub(PacketHandler.S2CStub);
            AttachStub(PacketHandler.S2CGuildStub);
            AttachStub(PacketHandler.S2CShopStub);
            AttachStub(PacketHandler.S2CStageStub);
            AttachStub(PacketHandler.S2CWeaponStub);
        }

        // Event that occurs after the connection attempt
        // It doesn't mean that the connection was accepted
        protected override void OnJoinServerComplete(ErrorInfo errorInfo, ByteArray replyFromServer)
        {
            PacketManager.Instance.OnJoinServerComplete(errorInfo);
        }

        // Event that occurs when the connection is terminated
        // Not called when the users diconnect themselves
        protected override void OnLeaveServer(ErrorInfo errorInfo)
        {
            PacketManager.Instance.OnLeaveServer(errorInfo);
        }

        // Event that occurs when an internal error has occured
        protected override void OnError(ErrorInfo errorInfo)
        {
            Console.WriteLine("[GameClient-OnError] " + errorInfo.errorType);
        }

        // Event that occurs when an internal error has occured, with a priority lower than Error
        protected override void OnWarning(ErrorInfo errorInfo)
        {
            Console.WriteLine("[GameClient-OnWarning] " + errorInfo.errorType);
        }

        // Event that occurs when an internal notification has occured. It does not indicate a problem.
        protected override void OnInformation(ErrorInfo errorInfo)
        {
            Console.WriteLine("[GameClient-OnInformation] " + errorInfo.errorType);
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

        public void RequestChannelUserInfo(string netamrblePlayerID, NetmarbleSDKInfo sdkInfo)
        {
            SendProxy.CG_RequestChannelUserInfo(SERVER, RELIABLESEND, netamrblePlayerID, sdkInfo);
        }

        public void RequestHeartBeat()
        {
            SendProxy.CG_RequestHeartBeat(SERVER, RELIABLESEND);
        }

        public void RequestChangeNickname(string nickname)
        {
            SendProxy.CG_RequestChangeNickname(SERVER, RELIABLESEND, nickname);
        }

        public void RequestChangeWantToSay(string wantToSay)
        {
            SendProxy.CG_RequestChangeWantToSay(SERVER, RELIABLESEND, wantToSay);
        }

        public void RequestTeamInfo(byte teamIndex)
        {
            SendProxy.CG_RequestTeamInfo(SERVER, RELIABLESEND, teamIndex);
        }

        public void RequestTeamSlotChange(byte teamIndex, List<UserTeamSlot> mainSlotList, int battlePowerPoint, int buffID)
        {
            SendProxy.CG_RequestTeamSlotChange(SERVER, RELIABLESEND, teamIndex, mainSlotList, battlePowerPoint, buffID);
        }

        public void RequestTeamNameChange(byte teamIndex, string name)
        {
            SendProxy.CG_RequestTeamNameChange(SERVER, RELIABLESEND, teamIndex, name);
        }

        public void RequestLobbyInfo()
        {
            SendProxy.CG_RequestLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestBasePointInfo(int basePointID)
        {
            SendProxy.CG_RequestBasePointInfo(SERVER, RELIABLESEND, basePointID);
        }

        public void RequestMercenaryList()
        {
            SendProxy.CG_RequestMercenaryList(SERVER, RELIABLESEND);
        }

        public void RequestMercenaryInfo(long targetUSN, int skinID)
        {
            SendProxy.CG_RequestMercenaryInfo(SERVER, RELIABLESEND, targetUSN, skinID);
        }

        public void RequestGuildInfo()
        {
            SendProxy.CG_RequestGuildInfo(SERVER, RELIABLESEND);
        }

        public void RequestChatStampUpdateBookmark(byte stampSlot, List<int> stampIDList)
        {
            SendProxy.CG_RequestChatStampUpdateBookmark(SERVER, RELIABLESEND, stampSlot, stampIDList);
        }

        public void RequestChatStampUpdateQuickMessage(byte slotNumber, string message)
        {
            SendProxy.CG_RequestChatStampUpdateQuickMessage(SERVER, RELIABLESEND, slotNumber, message);
        }

        public void RequestMainSkinChange(int targetSkinID)
        {
            SendProxy.CG_RequestMainSkinChange(SERVER, RELIABLESEND, targetSkinID);
        }

        public void RequestEventList()
        {
            SendProxy.CG_RequestEventList(SERVER, RELIABLESEND);
        }

        public void RequestCheatEnter(string message)
        {
            SendProxy.CG_RequestCheatEnter(SERVER, RELIABLESEND, message);
        }

        public void RequestCheatStageClear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_RequestCheatStageClear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void RequestDllGetItem()
        {
            SendProxy.CG_RequestDllGetItem(SERVER, RELIABLESEND);
        }

        public void RequestRecommendFriendUSNList()
        {
            SendProxy.CG_RequestRecommendFriendUSNList(SERVER, RELIABLESEND);
        }

        public void RequestDailyReset()
        {
            SendProxy.CG_RequestDailyReset(SERVER, RELIABLESEND);
        }

        public void RequestFrozenAssetRedeem(int frozenSEQ)
        {
            SendProxy.CG_RequestFrozenAssetRedeem(SERVER, RELIABLESEND, frozenSEQ);
        }

        public void RequestDataTableReload(ByteArrayInfo dataZipFileInfo, int totalFileSize, bool isFirst, bool isLast)
        {
            SendProxy.CG_RequestDataTableReload(SERVER, RELIABLESEND, dataZipFileInfo, totalFileSize, isFirst, isLast);
        }

        public void RequestRecommendHeroGrowthInfo(int heroId)
        {
            SendProxy.CG_RequestRecommendHeroGrowthInfo(SERVER, RELIABLESEND, heroId);
        }

        public void RequestServerVersion()
        {
            SendProxy.CG_RequestServerVersion(SERVER, RELIABLESEND);
        }

        public void RequestSecurityToken()
        {
            SendProxy.CG_RequestSecurityToken(SERVER, RELIABLESEND);
        }

        public void RequestNetmarbleAuth(string netmarblePlayerID, string gametoken, string securityCertValue, int versionNumber, ClientDeviceType deviceType, int signType, NetmarbleSDKInfo sdkInfo, int buildCountry)
        {
            SendProxy.CG_RequestNetmarbleAuth(SERVER, RELIABLESEND, netmarblePlayerID, gametoken, securityCertValue, versionNumber, deviceType, signType, sdkInfo, buildCountry);
        }

        public void RequestAuthenticateCreate(string netmarblePlayerID, NetmarbleSDKInfo sdkInfo)
        {
            SendProxy.CG_RequestAuthenticateCreate(SERVER, RELIABLESEND, netmarblePlayerID, sdkInfo);
        }

        public void RequestEditorUserInfoByNickName(string nickName)
        {
            SendProxy.CG_RequestEditorUserInfoByNickName(SERVER, RELIABLESEND, nickName);
        }

        public void RequestLogin(long usn, NetmarbleSDKInfo sdkInfo, VersionInfo versionInfo, string rejoinData, long clientTimeTick, string patchName, string patchData, LanguageType languageType, int buildCountry)
        {
            SendProxy.CG_RequestLogin(SERVER, RELIABLESEND, usn, sdkInfo, versionInfo, rejoinData, clientTimeTick, patchName, patchData, languageType, buildCountry);
        }

        public void RequestLoginInstantly(long usn, NetmarbleSDKInfo sdkInfo, int sessionKey, VersionInfo versionInfo, string rejoinData, long clientTimeTick, RmiID reconnectRequestRmiID, LanguageType languageType, int talkChannelID, int buildCountry)
        {
            SendProxy.CG_RequestLoginInstantly(SERVER, RELIABLESEND, usn, sdkInfo, sessionKey, versionInfo, rejoinData, clientTimeTick, reconnectRequestRmiID, languageType, talkChannelID, buildCountry);
        }

        public void RetryRequest(RmiID rmiID)
        {
            SendProxy.CG_RetryRequest(SERVER, RELIABLESEND, rmiID);
        }

        public void RequestAccountWithdraw(string gameToken, string code, string idToken)
        {
            SendProxy.CG_RequestAccountWithdraw(SERVER, RELIABLESEND, gameToken, code, idToken);
        }

        public void RequestAccountWithdrawCancel(string netmarblePlayerID)
        {
            SendProxy.CG_RequestAccountWithdrawCancel(SERVER, RELIABLESEND, netmarblePlayerID);
        }

        public void RequestCookie(ByteArrayInfo cookie)
        {
            SendProxy.CG_RequestCookie(SERVER, RELIABLESEND, cookie);
        }

        public void RequestVerifySecurityCertValue(string securityCertValue, ClientDeviceType deviceType, int signType)
        {
            SendProxy.CG_RequestVerifySecurityCertValue(SERVER, RELIABLESEND, securityCertValue, deviceType, signType);
        }

        public void RequestBillingInitialize(string itemID, string purchaseType, List<int> choicePackageItemList)
        {
            SendProxy.CG_RequestBillingInitialize(SERVER, RELIABLESEND, itemID, purchaseType, choicePackageItemList);
        }

        public void RequestBillingVerifyPU(BillingVerifyRequestInfo verifyRequestInfo, List<int> choicePackageItemList)
        {
            SendProxy.CG_RequestBillingVerifyPU(SERVER, RELIABLESEND, verifyRequestInfo, choicePackageItemList);
        }

        public void RequestBillingRemainTR(bool isPurchase, List<string> purchasesJSONString)
        {
            SendProxy.CG_RequestBillingRemainTR(SERVER, RELIABLESEND, isPurchase, purchasesJSONString);
        }

        public void RequestBillingCouponVerify(BillingVerifyType verifyType)
        {
            SendProxy.CG_RequestBillingCouponVerify(SERVER, RELIABLESEND, verifyType);
        }

        public void RequestBillingCrossPromotion(BillingVerifyType verifyType)
        {
            SendProxy.CG_RequestBillingCrossPromotion(SERVER, RELIABLESEND, verifyType);
        }

        public void RequestBillingPackageShop(int productID)
        {
            SendProxy.CG_RequestBillingPackageShop(SERVER, RELIABLESEND, productID);
        }

        public void RequestAgeInput(byte ageLevel)
        {
            SendProxy.CG_RequestAgeInput(SERVER, RELIABLESEND, ageLevel);
        }

        public void RequestSDKInfoChange(NetmarbleSDKInfo sdkInfo)
        {
            SendProxy.CG_RequestSDKInfoChange(SERVER, RELIABLESEND, sdkInfo);
        }

        public void RequestPCBillingInitialize(string sku, List<int> choicePackageItemList)
        {
            SendProxy.CG_RequestPCBillingInitialize(SERVER, RELIABLESEND, sku, choicePackageItemList);
        }

        public void RequestPCBillingRemainItems()
        {
            SendProxy.CG_RequestPCBillingRemainItems(SERVER, RELIABLESEND);
        }

        public void RequestSkinLevelUpBySkinMaterial(int targetSkinID, List<NeedItemInfo> materialItemList)
        {
            SendProxy.CG_RequestSkinLevelUpBySkinMaterial(SERVER, RELIABLESEND, targetSkinID, materialItemList);
        }

        public void RequestSkinResearch(int targetSkinID, int researchID, byte researchSlot)
        {
            SendProxy.CG_RequestSkinResearch(SERVER, RELIABLESEND, targetSkinID, researchID, researchSlot);
        }

        public void RequestSkinResearchInit(int targetSkinID)
        {
            SendProxy.CG_RequestSkinResearchInit(SERVER, RELIABLESEND, targetSkinID);
        }

        public void RequestSkinMaterialGrind(List<int> skinMaterialIDList)
        {
            SendProxy.CG_RequestSkinMaterialGrind(SERVER, RELIABLESEND, skinMaterialIDList);
        }

        public void RequestSkinAwaken(int targetHeroID, byte awakenIndex)
        {
            SendProxy.CG_RequestSkinAwaken(SERVER, RELIABLESEND, targetHeroID, awakenIndex);
        }

        public void RequestSkinHeadStyleChange(int targetSkinID, bool isChanged)
        {
            SendProxy.CG_RequestSkinHeadStyleChange(SERVER, RELIABLESEND, targetSkinID, isChanged);
        }

        public void RequestSkinEvolution(int targetHeroID)
        {
            SendProxy.CG_RequestSkinEvolution(SERVER, RELIABLESEND, targetHeroID);
        }

        public void RequestSkinSkillLevelUp(int targetHeroID, byte skillLevelUpCount)
        {
            SendProxy.CG_RequestSkinSkillLevelUp(SERVER, RELIABLESEND, targetHeroID, skillLevelUpCount);
        }

        public void RequestSkinGiveFellowshipExp(int targetHeroID, List<NeedItemInfo> useItemInfoList, bool IsADView)
        {
            SendProxy.CG_RequestSkinGiveFellowshipExp(SERVER, RELIABLESEND, targetHeroID, useItemInfoList, IsADView);
        }

        public void RequestSkinFellowshipLevelUpReward(int heroID, byte rewardIndex)
        {
            SendProxy.CG_RequestSkinFellowshipLevelUpReward(SERVER, RELIABLESEND, heroID, rewardIndex);
        }

        public void RequestCostumeEquip(int costumeID, int targetHeroID)
        {
            SendProxy.CG_RequestCostumeEquip(SERVER, RELIABLESEND, costumeID, targetHeroID);
        }

        public void RequestCostumeUnEquip(int costumeID, int targetHeroID)
        {
            SendProxy.CG_RequestCostumeUnEquip(SERVER, RELIABLESEND, costumeID, targetHeroID);
        }

        public void RequestCostumeUnLock(List<int> targetHeroIDList, List<int> costumeGroupIDList, List<int> targetHeroGroupIDList)
        {
            SendProxy.CG_RequestCostumeUnLock(SERVER, RELIABLESEND, targetHeroIDList, costumeGroupIDList, targetHeroGroupIDList);
        }

        public void RequestSkinOverEvolution(int targetHeroID)
        {
            SendProxy.CG_RequestSkinOverEvolution(SERVER, RELIABLESEND, targetHeroID);
        }

        public void RequestSkinMaxAwakenReward(int targetHeroID)
        {
            SendProxy.CG_RequestSkinMaxAwakenReward(SERVER, RELIABLESEND, targetHeroID);
        }

        public void RequestCostumeRegister(int targetSkinID, int targetCostumeID, byte slotIndex)
        {
            SendProxy.CG_RequestCostumeRegister(SERVER, RELIABLESEND, targetSkinID, targetCostumeID, slotIndex);
        }

        public void RequestSkinLoveReward(byte rewardSeq)
        {
            SendProxy.CG_RequestSkinLoveReward(SERVER, RELIABLESEND, rewardSeq);
        }

        public void RequestCostumeAutoRegister(List<CostumeAutoRegisterInfo> registerInfoList)
        {
            SendProxy.CG_RequestCostumeAutoRegister(SERVER, RELIABLESEND, registerInfoList);
        }

        public void RequestStoryCostume(List<int> idList)
        {
            SendProxy.CG_RequestStoryCostume(SERVER, RELIABLESEND, idList);
        }

        public void RequestCostumeLevelUp(int costumeID, int levelUpCount)
        {
            SendProxy.CG_RequestCostumeLevelUp(SERVER, RELIABLESEND, costumeID, levelUpCount);
        }

        public void RequestSkinMaxAwaken(int targetHeroID, int useItemID)
        {
            SendProxy.CG_RequestSkinMaxAwaken(SERVER, RELIABLESEND, targetHeroID, useItemID);
        }

        public void RequestBattlePointRegister(int battlePoint)
        {
            SendProxy.CG_RequestBattlePointRegister(SERVER, RELIABLESEND, battlePoint);
        }

        public void RequestSkinTranscend(int targetHeroId, byte transcendIndex, List<NeedItemInfo> useItemInfoList)
        {
            SendProxy.CG_RequestSkinTranscend(SERVER, RELIABLESEND, targetHeroId, transcendIndex, useItemInfoList);
        }

        public void RequestSkinTranscendReset(int targetHeroId, byte useItemIndex)
        {
            SendProxy.CG_RequestSkinTranscendReset(SERVER, RELIABLESEND, targetHeroId, useItemIndex);
        }

        public void RequestCostumeCraft(int costumeId)
        {
            SendProxy.CG_RequestCostumeCraft(SERVER, RELIABLESEND, costumeId);
        }

        public void RequestLimitedCostumeCheck()
        {
            SendProxy.CG_RequestLimitedCostumeCheck(SERVER, RELIABLESEND);
        }

        public void RequestGetExclusiveSkill(int heroId)
        {
            SendProxy.CG_RequestGetExclusiveSkill(SERVER, RELIABLESEND, heroId);
        }

        public void RequestSkinOneStepEvolution(int heroId)
        {
            SendProxy.CG_RequestSkinOneStepEvolution(SERVER, RELIABLESEND, heroId);
        }

        public void RequestSkinOverEvolutionStraight(int targetHeroID, byte targetMaxLevelCount)
        {
            SendProxy.CG_RequestSkinOverEvolutionStraight(SERVER, RELIABLESEND, targetHeroID, targetMaxLevelCount);
        }

        public void RequestSkinLegendEvolution(int heroId)
        {
            SendProxy.CG_RequestSkinLegendEvolution(SERVER, RELIABLESEND, heroId);
        }

        public void RequestCostumeCraftUpgrade(int costumeId, List<CostumeCraftUpgradeInfo> upgradeInfoList)
        {
            SendProxy.CG_RequestCostumeCraftUpgrade(SERVER, RELIABLESEND, costumeId, upgradeInfoList);
        }

        public void RequestSkinLevelupBonus(int heroId)
        {
            SendProxy.CG_RequestSkinLevelupBonus(SERVER, RELIABLESEND, heroId);
        }

        public void RequestSkinExceed(int heroId, byte exceedIndex)
        {
            SendProxy.CG_RequestSkinExceed(SERVER, RELIABLESEND, heroId, exceedIndex);
        }

        public void RequestWeaponEquip(int targetSkinID, int weaponSerial, int slotNumber, bool isDelete)
        {
            SendProxy.CG_RequestWeaponEquip(SERVER, RELIABLESEND, targetSkinID, weaponSerial, slotNumber, isDelete);
        }

        public void RequestWeaponUnEquip(int targetSkinID, int slotNumber)
        {
            SendProxy.CG_RequestWeaponUnEquip(SERVER, RELIABLESEND, targetSkinID, slotNumber);
        }

        public void RequestWeaponSell(List<int> selectWeaponSerialList, ItemSellType itemSellType, int basepointID)
        {
            SendProxy.CG_RequestWeaponSell(SERVER, RELIABLESEND, selectWeaponSerialList, itemSellType, basepointID);
        }

        public void RequestWeaponGrind(List<int> selectWeaponSerialList)
        {
            SendProxy.CG_RequestWeaponGrind(SERVER, RELIABLESEND, selectWeaponSerialList);
        }

        public void RequestWeaponUpgrade(int targetWeaponSerial, short useFailGauge)
        {
            SendProxy.CG_RequestWeaponUpgrade(SERVER, RELIABLESEND, targetWeaponSerial, useFailGauge);
        }

        public void RequestWeaponUpgradeRetry(int targetWeaponSerial, int useItemId)
        {
            SendProxy.CG_RequestWeaponUpgradeRetry(SERVER, RELIABLESEND, targetWeaponSerial, useItemId);
        }

        public void RequestWeaponEvolution(int targetWeaponSerial)
        {
            SendProxy.CG_RequestWeaponEvolution(SERVER, RELIABLESEND, targetWeaponSerial);
        }

        public void RequestWeaponEvolutionRetry(int targetWeaponSerial, int optionSlotIndex, int needItemID)
        {
            SendProxy.CG_RequestWeaponEvolutionRetry(SERVER, RELIABLESEND, targetWeaponSerial, optionSlotIndex, needItemID);
        }

        public void RequestWeaponOptionEnhance(int targetWeaponSerial, int optionSlotIndex, byte enhanceType)
        {
            SendProxy.CG_RequestWeaponOptionEnhance(SERVER, RELIABLESEND, targetWeaponSerial, optionSlotIndex, enhanceType);
        }

        public void RequestWeaponLock(int targetWeaponSerial)
        {
            SendProxy.CG_RequestWeaponLock(SERVER, RELIABLESEND, targetWeaponSerial);
        }

        public void RequestWeaponUnLock(int targetWeaponSerial)
        {
            SendProxy.CG_RequestWeaponUnLock(SERVER, RELIABLESEND, targetWeaponSerial);
        }

        public void RequestWeaponEquipExchange(int pickedWeaponSerial, int pickedSkinID, int targetWeaponSerial, int targetSkinID, int slotNumber, bool isDelete)
        {
            SendProxy.CG_RequestWeaponEquipExchange(SERVER, RELIABLESEND, pickedWeaponSerial, pickedSkinID, targetWeaponSerial, targetSkinID, slotNumber, isDelete);
        }

        public void RequestWeaponEquipExchangeAll(int targetSkinID, int srcSkinID, WeaponExchangeMode exchangeMode)
        {
            SendProxy.CG_RequestWeaponEquipExchangeAll(SERVER, RELIABLESEND, targetSkinID, srcSkinID, exchangeMode);
        }

        public void RequestWeaponEquipRecommand(int targetSkinID, List<int> weaponSerialList)
        {
            SendProxy.CG_RequestWeaponEquipRecommand(SERVER, RELIABLESEND, targetSkinID, weaponSerialList);
        }

        public void RequestWeaponCarve(int eventSeq, int targetWeaponSerial, byte heroGroup)
        {
            SendProxy.CG_RequestWeaponCarve(SERVER, RELIABLESEND, eventSeq, targetWeaponSerial, heroGroup);
        }

        public void RequestWeaponCarveRemove(int eventSeq, int targetWeaponSerial)
        {
            SendProxy.CG_RequestWeaponCarveRemove(SERVER, RELIABLESEND, eventSeq, targetWeaponSerial);
        }

        public void RequestWeaponUpgradeAndEvolution(int targetWeaponSerial, short upgradeCount, short evolutionCount)
        {
            SendProxy.CG_RequestWeaponUpgradeAndEvolution(SERVER, RELIABLESEND, targetWeaponSerial, upgradeCount, evolutionCount);
        }

        public void RequestWeaponAutoOptionChange(int targetWeaponSerial, List<UserWeaponPassiveSkill> targetOptionList, List<int> slotNumberList, int costItemID, int costItemID2)
        {
            SendProxy.CG_RequestWeaponAutoOptionChange(SERVER, RELIABLESEND, targetWeaponSerial, targetOptionList, slotNumberList, costItemID, costItemID2);
        }

        public void RequestStageInfo()
        {
            SendProxy.CG_RequestStageInfo(SERVER, RELIABLESEND);
        }

        public void RequestStageRejoin()
        {
            SendProxy.CG_RequestStageRejoin(SERVER, RELIABLESEND);
        }

        public void Request_Week_Stage_Start(StageStartRequestInfo weekStageStartRequestInfo)
        {
            SendProxy.CG_Request_Week_Stage_Start(SERVER, RELIABLESEND, weekStageStartRequestInfo);
        }

        public void Request_Week_Stage_Clear(StageClearRequestInfo weekStageClearRequestInfo)
        {
            SendProxy.CG_Request_Week_Stage_Clear(SERVER, RELIABLESEND, weekStageClearRequestInfo);
        }

        public void Request_Week_Stage_Continue()
        {
            SendProxy.CG_Request_Week_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Main_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Main_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Main_Stage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_Request_Main_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void Request_Main_Stage_Continue()
        {
            SendProxy.CG_Request_Main_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Free_Stage_Start(StageStartRequestInfo freeStageStartRequestInfo)
        {
            SendProxy.CG_Request_Free_Stage_Start(SERVER, RELIABLESEND, freeStageStartRequestInfo);
        }

        public void Request_Free_Stage_Clear(StageClearRequestInfo freeStageClearRequestInfo)
        {
            SendProxy.CG_Request_Free_Stage_Clear(SERVER, RELIABLESEND, freeStageClearRequestInfo);
        }

        public void Request_Free_Stage_Continue()
        {
            SendProxy.CG_Request_Free_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestHawkRunStageStart(int stageID)
        {
            SendProxy.CG_RequestHawkRunStageStart(SERVER, RELIABLESEND, stageID);
        }

        public void RequestHawkRunStageClear(int stageID, bool isClear, int getGold)
        {
            SendProxy.CG_RequestHawkRunStageClear(SERVER, RELIABLESEND, stageID, isClear, getGold);
        }

        public void RequestEventStageClear(StageClearRequestInfo eventStageClearRequestInfo)
        {
            SendProxy.CG_RequestEventStageClear(SERVER, RELIABLESEND, eventStageClearRequestInfo);
        }

        public void Request_Quest_Stage_Start(StageStartRequestInfo questStageStartRequestInfo)
        {
            SendProxy.CG_Request_Quest_Stage_Start(SERVER, RELIABLESEND, questStageStartRequestInfo);
        }

        public void Request_Quest_Stage_Clear(StageClearRequestInfo questStageClearRequestInfo, byte propIndex)
        {
            SendProxy.CG_Request_Quest_Stage_Clear(SERVER, RELIABLESEND, questStageClearRequestInfo, propIndex);
        }

        public void Request_Quest_Stage_Continue()
        {
            SendProxy.CG_Request_Quest_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Boss_Stage_Start(StageStartRequestInfo bossStartRequestInfo)
        {
            SendProxy.CG_Request_Boss_Stage_Start(SERVER, RELIABLESEND, bossStartRequestInfo);
        }

        public void Request_Boss_Stage_Clear(StageClearRequestInfo bossClearRequestInfo)
        {
            SendProxy.CG_Request_Boss_Stage_Clear(SERVER, RELIABLESEND, bossClearRequestInfo);
        }

        public void Request_Boss_Stage_Continue()
        {
            SendProxy.CG_Request_Boss_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Memorial_Stage_Start(StageStartRequestInfo memorialStageStartRequestInfo)
        {
            SendProxy.CG_Request_Memorial_Stage_Start(SERVER, RELIABLESEND, memorialStageStartRequestInfo);
        }

        public void Request_Memorial_Stage_Clear(StageClearRequestInfo memorialStageClearRequestInfo)
        {
            SendProxy.CG_Request_Memorial_Stage_Clear(SERVER, RELIABLESEND, memorialStageClearRequestInfo);
        }

        public void Request_Memorial_Stage_Continue()
        {
            SendProxy.CG_Request_Memorial_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Limited_Stage_Start(StageStartRequestInfo limitedStageStartRequestInfo)
        {
            SendProxy.CG_Request_Limited_Stage_Start(SERVER, RELIABLESEND, limitedStageStartRequestInfo);
        }

        public void Request_Limited_Stage_Clear(StageClearRequestInfo limitedStageClearRequestInfo)
        {
            SendProxy.CG_Request_Limited_Stage_Clear(SERVER, RELIABLESEND, limitedStageClearRequestInfo);
        }

        public void Request_Limited_Stage_Continue()
        {
            SendProxy.CG_Request_Limited_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Main_ExtraStage_Start(StageStartRequestInfo extraMainStageStartInfo)
        {
            SendProxy.CG_Request_Main_ExtraStage_Start(SERVER, RELIABLESEND, extraMainStageStartInfo);
        }

        public void Request_Main_ExtraStage_Clear(StageClearRequestInfo extraMainStageClearInfo)
        {
            SendProxy.CG_Request_Main_ExtraStage_Clear(SERVER, RELIABLESEND, extraMainStageClearInfo);
        }

        public void Request_Main_ExtraStage_Continue()
        {
            SendProxy.CG_Request_Main_ExtraStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Boss_ExtraStage_Start(StageStartRequestInfo extraBossStageStartInfo)
        {
            SendProxy.CG_Request_Boss_ExtraStage_Start(SERVER, RELIABLESEND, extraBossStageStartInfo);
        }

        public void Request_Boss_ExtraStage_Clear(StageClearRequestInfo extraBossStageClearInfo)
        {
            SendProxy.CG_Request_Boss_ExtraStage_Clear(SERVER, RELIABLESEND, extraBossStageClearInfo);
        }

        public void Request_Boss_ExtraStage_Continue()
        {
            SendProxy.CG_Request_Boss_ExtraStage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestRewardStageClear(int stageID)
        {
            SendProxy.CG_RequestRewardStageClear(SERVER, RELIABLESEND, stageID);
        }

        public void Request_SingleSiege_ExtraStage_Start(StageStartRequestInfo extraSingleSiegeStageStartRequestInfo)
        {
            SendProxy.CG_Request_SingleSiege_ExtraStage_Start(SERVER, RELIABLESEND, extraSingleSiegeStageStartRequestInfo);
        }

        public void Request_SingleSiege_ExtraStage_Clear(StageClearRequestInfo extraSingleSiegeStageClearRequestInfo)
        {
            SendProxy.CG_Request_SingleSiege_ExtraStage_Clear(SERVER, RELIABLESEND, extraSingleSiegeStageClearRequestInfo);
        }

        public void Request_SingleSiege_ExtraStage_Continue()
        {
            SendProxy.CG_Request_SingleSiege_ExtraStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_FinalBoss_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_FinalBoss_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_FinalBoss_Stage_Clear(StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest, List<StatUserSkin> statUserSkinList)
        {
            SendProxy.CG_Request_FinalBoss_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo, ingameBattlePointRequest, statUserSkinList);
        }

        public void Request_FinalBoss_Stage_Continue()
        {
            SendProxy.CG_Request_FinalBoss_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_FinalBoss_Season_Info()
        {
            SendProxy.CG_Request_FinalBoss_Season_Info(SERVER, RELIABLESEND);
        }

        public void Request_Training_Stage_Info()
        {
            SendProxy.CG_Request_Training_Stage_Info(SERVER, RELIABLESEND);
        }

        public void Request_Training_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Training_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Training_Stage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_Request_Training_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void Request_Training_Stage_Continue()
        {
            SendProxy.CG_Request_Training_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Training_Stage_Open()
        {
            SendProxy.CG_Request_Training_Stage_Open(SERVER, RELIABLESEND);
        }

        public void Request_Training_Stage_Refresh()
        {
            SendProxy.CG_Request_Training_Stage_Refresh(SERVER, RELIABLESEND);
        }

        public void Request_GuildBoss_Stage_Start(StageStartRequestInfo stageStartRequestInfo, List<int> useSkinIDList, short guildBossSeq)
        {
            SendProxy.CG_Request_GuildBoss_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo, useSkinIDList, guildBossSeq);
        }

        public void Request_GuildBoss_Stage_Clear(StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest, List<StatUserSkin> statUserSkinList)
        {
            SendProxy.CG_Request_GuildBoss_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo, ingameBattlePointRequest, statUserSkinList);
        }

        public void Request_GuildBoss_Lobby_Info()
        {
            SendProxy.CG_Request_GuildBoss_Lobby_Info(SERVER, RELIABLESEND);
        }

        public void Request_GuildBoss_Rank_Info()
        {
            SendProxy.CG_Request_GuildBoss_Rank_Info(SERVER, RELIABLESEND);
        }

        public void Request_GuildBoss_LastWeek_Rank_Info()
        {
            SendProxy.CG_Request_GuildBoss_LastWeek_Rank_Info(SERVER, RELIABLESEND);
        }

        public void Request_GuildBoss_Time_Refresh()
        {
            SendProxy.CG_Request_GuildBoss_Time_Refresh(SERVER, RELIABLESEND);
        }

        public void Request_AnotherMain_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_AnotherMain_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_AnotherMain_Stage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_Request_AnotherMain_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void Request_AnotherMain_Stage_Continue()
        {
            SendProxy.CG_Request_AnotherMain_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_FinalBoss_Season_Rank_Info(int seasonID, int bossGroupID)
        {
            SendProxy.CG_Request_FinalBoss_Season_Rank_Info(SERVER, RELIABLESEND, seasonID, bossGroupID);
        }

        public void Request_Reverse_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Reverse_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Reverse_Stage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_Request_Reverse_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void Request_Reverse_Star_Reward(short seasonID, byte rewardIndex)
        {
            SendProxy.CG_Request_Reverse_Star_Reward(SERVER, RELIABLESEND, seasonID, rewardIndex);
        }

        public void Request_Reverse_Group_Reward(short rewardID)
        {
            SendProxy.CG_Request_Reverse_Group_Reward(SERVER, RELIABLESEND, rewardID);
        }

        public void Request_Tower_Stage_Info()
        {
            SendProxy.CG_Request_Tower_Stage_Info(SERVER, RELIABLESEND);
        }

        public void Request_Tower_Stage_Set_Play_Deck(List<int> heroIDList)
        {
            SendProxy.CG_Request_Tower_Stage_Set_Play_Deck(SERVER, RELIABLESEND, heroIDList);
        }

        public void Request_Tower_Stage_Reset()
        {
            SendProxy.CG_Request_Tower_Stage_Reset(SERVER, RELIABLESEND);
        }

        public void Request_Tower_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Tower_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Tower_Stage_Clear(StageClearRequestInfo stageClearRequestInfo, bool isGiveUp)
        {
            SendProxy.CG_Request_Tower_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo, isGiveUp);
        }

        public void Request_FinalBoss_Score_Reward(int seasonID, int bossGroupID, int rewardOrder)
        {
            SendProxy.CG_Request_FinalBoss_Score_Reward(SERVER, RELIABLESEND, seasonID, bossGroupID, rewardOrder);
        }

        public void Request_GuildBoss_Off_Season_Stage_Start(StageStartRequestInfo stageStartRequestInfo, short guildBossSeq)
        {
            SendProxy.CG_Request_GuildBoss_Off_Season_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo, guildBossSeq);
        }

        public void Request_GuildBoss_Off_Season_Stage_Clear(StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest)
        {
            SendProxy.CG_Request_GuildBoss_Off_Season_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo, ingameBattlePointRequest);
        }

        public void Request_Disaster_Tower_Stage_Info(int eventSEQ)
        {
            SendProxy.CG_Request_Disaster_Tower_Stage_Info(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_Disaster_Tower_Stage_Set_Play_Deck(int eventSEQ, List<int> heroIDList)
        {
            SendProxy.CG_Request_Disaster_Tower_Stage_Set_Play_Deck(SERVER, RELIABLESEND, eventSEQ, heroIDList);
        }

        public void Request_Disaster_Tower_Stage_Reset(int eventSEQ)
        {
            SendProxy.CG_Request_Disaster_Tower_Stage_Reset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_Disaster_Tower_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Disaster_Tower_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Disaster_Tower_Stage_Clear(StageClearRequestInfo stageClearRequestInfo, bool isGiveUp)
        {
            SendProxy.CG_Request_Disaster_Tower_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo, isGiveUp);
        }

        public void Request_FinalBoss_Stage_Fame_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_FinalBoss_Stage_Fame_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_FinalBoss_Stage_Fame_Clear(StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest, int fameID)
        {
            SendProxy.CG_Request_FinalBoss_Stage_Fame_Clear(SERVER, RELIABLESEND, stageClearRequestInfo, ingameBattlePointRequest, fameID);
        }

        public void Request_FinalBoss_Stage_Fame_Season_Rank_Info(int fameId)
        {
            SendProxy.CG_Request_FinalBoss_Stage_Fame_Season_Rank_Info(SERVER, RELIABLESEND, fameId);
        }

        public void Request_FinalBoss_Stage_Fame_MyScoreInfo(int fameID)
        {
            SendProxy.CG_Request_FinalBoss_Stage_Fame_MyScoreInfo(SERVER, RELIABLESEND, fameID);
        }

        public void Request_Main_EventAreaStage_Start(StageStartRequestInfo eventAreaMainStageStartRequestInfo)
        {
            SendProxy.CG_Request_Main_EventAreaStage_Start(SERVER, RELIABLESEND, eventAreaMainStageStartRequestInfo);
        }

        public void Request_Main_EventAreaStage_Clear(StageClearRequestInfo eventAreaMainStageClearRequestInfo)
        {
            SendProxy.CG_Request_Main_EventAreaStage_Clear(SERVER, RELIABLESEND, eventAreaMainStageClearRequestInfo);
        }

        public void Request_Main_EventAreaStage_Continue()
        {
            SendProxy.CG_Request_Main_EventAreaStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Free_EventAreaStage_Start(StageStartRequestInfo eventAreaFreeStageStartRequestInfo)
        {
            SendProxy.CG_Request_Free_EventAreaStage_Start(SERVER, RELIABLESEND, eventAreaFreeStageStartRequestInfo);
        }

        public void Request_Free_EventAreaStage_Clear(StageClearRequestInfo eventAreaFreeStageClearRequestInfo)
        {
            SendProxy.CG_Request_Free_EventAreaStage_Clear(SERVER, RELIABLESEND, eventAreaFreeStageClearRequestInfo);
        }

        public void Request_Free_EventAreaStage_Continue()
        {
            SendProxy.CG_Request_Free_EventAreaStage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestEventAreaRewardStageClear(StageClearRequestInfo eventAreaRewardStageClearRequestInfo)
        {
            SendProxy.CG_RequestEventAreaRewardStageClear(SERVER, RELIABLESEND, eventAreaRewardStageClearRequestInfo);
        }

        public void Request_Free_EventStage_Start(StageStartRequestInfo eventFreeStageStartRequestInfo)
        {
            SendProxy.CG_Request_Free_EventStage_Start(SERVER, RELIABLESEND, eventFreeStageStartRequestInfo);
        }

        public void Request_Free_EventStage_Clear(StageClearRequestInfo eventFreeStageClearRequestInfo)
        {
            SendProxy.CG_Request_Free_EventStage_Clear(SERVER, RELIABLESEND, eventFreeStageClearRequestInfo);
        }

        public void Request_Free_EventStage_Continue()
        {
            SendProxy.CG_Request_Free_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestEventExchange(int eventSEQ, int exchangeID, byte buyCount)
        {
            SendProxy.CG_RequestEventExchange(SERVER, RELIABLESEND, eventSEQ, exchangeID, buyCount);
        }

        public void RequestEventPlayCountReward(int eventSEQ)
        {
            SendProxy.CG_RequestEventPlayCountReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_Main_ListEventStage_Start(StageStartRequestInfo eventListMainStageStartRequestInfo)
        {
            SendProxy.CG_Request_Main_ListEventStage_Start(SERVER, RELIABLESEND, eventListMainStageStartRequestInfo);
        }

        public void Request_Main_ListEventStage_Clear(StageClearRequestInfo eventListMainStageClearRequestInfo)
        {
            SendProxy.CG_Request_Main_ListEventStage_Clear(SERVER, RELIABLESEND, eventListMainStageClearRequestInfo);
        }

        public void Request_Main_ListEventStage_Continue()
        {
            SendProxy.CG_Request_Main_ListEventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Free_ListEventStage_Start(StageStartRequestInfo eventListFreeStageStartRequestInfo)
        {
            SendProxy.CG_Request_Free_ListEventStage_Start(SERVER, RELIABLESEND, eventListFreeStageStartRequestInfo);
        }

        public void Request_Free_ListEventStage_Clear(StageClearRequestInfo eventListFreeStageClearRequestInfo)
        {
            SendProxy.CG_Request_Free_ListEventStage_Clear(SERVER, RELIABLESEND, eventListFreeStageClearRequestInfo);
        }

        public void Request_Free_ListEventStage_Continue()
        {
            SendProxy.CG_Request_Free_ListEventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_FinalBoss_EventMainStage_Start(StageStartRequestInfo eventFinalBossMainStageStartRequestInfo)
        {
            SendProxy.CG_Request_FinalBoss_EventMainStage_Start(SERVER, RELIABLESEND, eventFinalBossMainStageStartRequestInfo);
        }

        public void Request_FinalBoss_EventMainStage_Clear(StageClearRequestInfo eventFinalBossMainStageClearRequestInfo)
        {
            SendProxy.CG_Request_FinalBoss_EventMainStage_Clear(SERVER, RELIABLESEND, eventFinalBossMainStageClearRequestInfo);
        }

        public void Request_FinalBoss_EventMainStage_Continue()
        {
            SendProxy.CG_Request_FinalBoss_EventMainStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_FinalBoss_EventFreeStage_Start(StageStartRequestInfo eventFinalBossFreeStageStartRequestInfo)
        {
            SendProxy.CG_Request_FinalBoss_EventFreeStage_Start(SERVER, RELIABLESEND, eventFinalBossFreeStageStartRequestInfo);
        }

        public void Request_FinalBoss_EventFreeStage_Clear(StageClearRequestInfo eventFinalBossFreeStageClearRequestInfo)
        {
            SendProxy.CG_Request_FinalBoss_EventFreeStage_Clear(SERVER, RELIABLESEND, eventFinalBossFreeStageClearRequestInfo);
        }

        public void Request_FinalBoss_EventFreeStage_Continue()
        {
            SendProxy.CG_Request_FinalBoss_EventFreeStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Limited_EventStage_Start(StageStartRequestInfo eventLimitedStageStartRequestInfo)
        {
            SendProxy.CG_Request_Limited_EventStage_Start(SERVER, RELIABLESEND, eventLimitedStageStartRequestInfo);
        }

        public void Request_Limited_EventStage_Clear(StageClearRequestInfo eventLimitedStageClearRequestInfo)
        {
            SendProxy.CG_Request_Limited_EventStage_Clear(SERVER, RELIABLESEND, eventLimitedStageClearRequestInfo);
        }

        public void Request_Limited_EventStage_Continue()
        {
            SendProxy.CG_Request_Limited_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Boss_EventStage_Start(StageStartRequestInfo eventBossStageStartRequestInfo)
        {
            SendProxy.CG_Request_Boss_EventStage_Start(SERVER, RELIABLESEND, eventBossStageStartRequestInfo);
        }

        public void Request_Boss_EventStage_Clear(StageClearRequestInfo eventBossStageClearRequestInfo)
        {
            SendProxy.CG_Request_Boss_EventStage_Clear(SERVER, RELIABLESEND, eventBossStageClearRequestInfo);
        }

        public void Request_Boss_EventStage_Continue()
        {
            SendProxy.CG_Request_Boss_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Monthly_EventStage_Start(int monthlyID, int storyID, StageStartRequestInfo monthlyStageStartRequestInfo)
        {
            SendProxy.CG_Request_Monthly_EventStage_Start(SERVER, RELIABLESEND, monthlyID, storyID, monthlyStageStartRequestInfo);
        }

        public void Request_Monthly_EventStage_Clear(int monthlyID, int storyID, StageClearRequestInfo monthlyStageClearRequestInfo)
        {
            SendProxy.CG_Request_Monthly_EventStage_Clear(SERVER, RELIABLESEND, monthlyID, storyID, monthlyStageClearRequestInfo);
        }

        public void Request_Monthly_EventStage_Continue()
        {
            SendProxy.CG_Request_Monthly_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestMonthlyStagePointReward(int monthlyID, byte rewardIndex)
        {
            SendProxy.CG_RequestMonthlyStagePointReward(SERVER, RELIABLESEND, monthlyID, rewardIndex);
        }

        public void RequestWeekStageGaugeReward(WeekStageGroupType weekStageGroupType, int groupID)
        {
            SendProxy.CG_RequestWeekStageGaugeReward(SERVER, RELIABLESEND, weekStageGroupType, groupID);
        }

        public void RequestIngameBattleStart()
        {
            SendProxy.CG_RequestIngameBattleStart(SERVER, RELIABLESEND);
        }

        public void RequestStageEndLog()
        {
            SendProxy.CG_RequestStageEndLog(SERVER, RELIABLESEND);
        }

        public void Request_ChallengeBoss_EventStage_Start(StageStartRequestInfo startRequestInfo, List<int> useSkinIDList)
        {
            SendProxy.CG_Request_ChallengeBoss_EventStage_Start(SERVER, RELIABLESEND, startRequestInfo, useSkinIDList);
        }

        public void Request_ChallengeBoss_EventStage_Clear(StageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_Request_ChallengeBoss_EventStage_Clear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void Request_ChallengeBoss_EventStage_Continue()
        {
            SendProxy.CG_Request_ChallengeBoss_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_ChallengeBoss_EventStage_Info(int eventSEQ)
        {
            SendProxy.CG_Request_ChallengeBoss_EventStage_Info(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_ChallengeBoss_Event_Point_Reward(int eventSEQ, int step)
        {
            SendProxy.CG_Request_ChallengeBoss_Event_Point_Reward(SERVER, RELIABLESEND, eventSEQ, step);
        }

        public void Request_DisasterBoss_Stage_Start(StageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_Request_DisasterBoss_Stage_Start(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void Request_DisasterBoss_Stage_Clear(StageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_Request_DisasterBoss_Stage_Clear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void Request_DisasterBoss_Stage_Continue()
        {
            SendProxy.CG_Request_DisasterBoss_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Week_EventStage_Start(StageStartRequestInfo eventWeekStageStartRequestInfo)
        {
            SendProxy.CG_Request_Week_EventStage_Start(SERVER, RELIABLESEND, eventWeekStageStartRequestInfo);
        }

        public void Request_Week_EventStage_Clear(StageClearRequestInfo eventWeekStageClearRequestInfo)
        {
            SendProxy.CG_Request_Week_EventStage_Clear(SERVER, RELIABLESEND, eventWeekStageClearRequestInfo);
        }

        public void Request_Week_EventStage_Continue()
        {
            SendProxy.CG_Request_Week_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Blitz_EventStage_Lobby_Info(int eventSEQ)
        {
            SendProxy.CG_Request_Blitz_EventStage_Lobby_Info(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_Blitz_EventStage_Squad_Change(int eventSEQ, List<BlitzHeroInfo> blitzHeroInfoList)
        {
            SendProxy.CG_Request_Blitz_EventStage_Squad_Change(SERVER, RELIABLESEND, eventSEQ, blitzHeroInfoList);
        }

        public void Request_Blitz_EventStage_Squad_Init(int eventSEQ)
        {
            SendProxy.CG_Request_Blitz_EventStage_Squad_Init(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_Blitz_EventStage_Team_Change(int eventSEQ, List<BlitzTeamSlotInfo> blitzTeamSlotInfoList, int buffID)
        {
            SendProxy.CG_Request_Blitz_EventStage_Team_Change(SERVER, RELIABLESEND, eventSEQ, blitzTeamSlotInfoList, buffID);
        }

        public void Request_Blitz_EventStage_Main_Start(StageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_Request_Blitz_EventStage_Main_Start(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void Request_Blitz_EventStage_Main_Clear(StageClearRequestInfo clearRequestInfo, List<BlitzMonsterInfo> mosterInfoList)
        {
            SendProxy.CG_Request_Blitz_EventStage_Main_Clear(SERVER, RELIABLESEND, clearRequestInfo, mosterInfoList);
        }

        public void Request_Blitz_EventStage_Free_Start(StageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_Request_Blitz_EventStage_Free_Start(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void Request_Blitz_EventStage_Free_Clear(StageClearRequestInfo clearRequestInfo, List<BlitzMonsterInfo> mosterInfoList)
        {
            SendProxy.CG_Request_Blitz_EventStage_Free_Clear(SERVER, RELIABLESEND, clearRequestInfo, mosterInfoList);
        }

        public void Request_Blitz_EventStage_Reward_Clear(StageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_Request_Blitz_EventStage_Reward_Clear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void Request_Blitz_EventStage_Rejoin()
        {
            SendProxy.CG_Request_Blitz_EventStage_Rejoin(SERVER, RELIABLESEND);
        }

        public void Request_Blitz_EventStage_Rejoin_Cancel(List<BlitzMonsterInfo> blitzMonsterInfoList)
        {
            SendProxy.CG_Request_Blitz_EventStage_Rejoin_Cancel(SERVER, RELIABLESEND, blitzMonsterInfoList);
        }

        public void RequestRecommandHero(RecommandHeroRequestInfo requestInfo)
        {
            SendProxy.CG_RequestRecommandHero(SERVER, RELIABLESEND, requestInfo);
        }

        public void Request_Free_Once_EventAreaStage_Start(StageStartRequestInfo eventAreaFreeOnceStageStartRequestInfo)
        {
            SendProxy.CG_Request_Free_Once_EventAreaStage_Start(SERVER, RELIABLESEND, eventAreaFreeOnceStageStartRequestInfo);
        }

        public void Request_Free_Once_EventAreaStage_Clear(StageClearRequestInfo eventAreaFreeOnceStageClearRequestInfo)
        {
            SendProxy.CG_Request_Free_Once_EventAreaStage_Clear(SERVER, RELIABLESEND, eventAreaFreeOnceStageClearRequestInfo);
        }

        public void Request_Free_Once_EventAreaStage_Continue()
        {
            SendProxy.CG_Request_Free_Once_EventAreaStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_DescentBoss_EventStage_Start(StageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_Request_DescentBoss_EventStage_Start(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void Request_DescentBoss_EventStage_Clear(StageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_Request_DescentBoss_EventStage_Clear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void Request_DescentBoss_EventStage_Continue()
        {
            SendProxy.CG_Request_DescentBoss_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_DescentBoss_Event_Point_Reward(int eventSEQ, int step)
        {
            SendProxy.CG_Request_DescentBoss_Event_Point_Reward(SERVER, RELIABLESEND, eventSEQ, step);
        }

        public void Request_NorthMain_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_NorthMain_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_NorthMain_Stage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_Request_NorthMain_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void Request_NorthMain_Stage_Continue()
        {
            SendProxy.CG_Request_NorthMain_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_North_Free_Once_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_North_Free_Once_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_North_Free_Once_Stage_Clear(StageClearRequestInfo stageCleatRequestInfo)
        {
            SendProxy.CG_Request_North_Free_Once_Stage_Clear(SERVER, RELIABLESEND, stageCleatRequestInfo);
        }

        public void Request_North_Free_Once_Stage_Continue()
        {
            SendProxy.CG_Request_North_Free_Once_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Another_Free_Once_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Another_Free_Once_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Another_Free_Once_Stage_Clear(StageClearRequestInfo stageCleatRequestInfo)
        {
            SendProxy.CG_Request_Another_Free_Once_Stage_Clear(SERVER, RELIABLESEND, stageCleatRequestInfo);
        }

        public void Request_Another_Free_Once_Stage_Continue()
        {
            SendProxy.CG_Request_Another_Free_Once_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestEventMazeStageStart(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_RequestEventMazeStageStart(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void RequestEventMazeStageClear(StageClearRequestInfo stageClearRequestInfo, List<SyncMazeHero> heroSyncInfoList)
        {
            SendProxy.CG_RequestEventMazeStageClear(SERVER, RELIABLESEND, stageClearRequestInfo, heroSyncInfoList);
        }

        public void RequestEventMazeStageRejoin(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeStageRejoin(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeStageRejoinCancel(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeStageRejoinCancel(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeStageReChallenge(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_RequestEventMazeStageReChallenge(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void RequestEventMazeStageReChallengeCancel(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeStageReChallengeCancel(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_Conquest_EventStage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Conquest_EventStage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Conquest_EventStage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_Request_Conquest_EventStage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void Request_Conquest_EventStage_Continue()
        {
            SendProxy.CG_Request_Conquest_EventStage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Disaster_Main_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Disaster_Main_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Disaster_Main_Stage_Clear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_Request_Disaster_Main_Stage_Clear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void Request_Disaster_Main_Stage_Continue()
        {
            SendProxy.CG_Request_Disaster_Main_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_Disaster_Free_Once_Stage_Start(StageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_Disaster_Free_Once_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_Disaster_Free_Once_Stage_Clear(StageClearRequestInfo stageCleatRequestInfo)
        {
            SendProxy.CG_Request_Disaster_Free_Once_Stage_Clear(SERVER, RELIABLESEND, stageCleatRequestInfo);
        }

        public void Request_Disaster_Free_Once_Stage_Continue()
        {
            SendProxy.CG_Request_Disaster_Free_Once_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestMailList(LanguageType languageType)
        {
            SendProxy.CG_RequestMailList(SERVER, RELIABLESEND, languageType);
        }

        public void RequestMailConfirm(int mailSN)
        {
            SendProxy.CG_RequestMailConfirm(SERVER, RELIABLESEND, mailSN);
        }

        public void RequestMailConfirmAll()
        {
            SendProxy.CG_RequestMailConfirmAll(SERVER, RELIABLESEND);
        }

        public void RequestMailHistoryList(int lastMailHistorySN)
        {
            SendProxy.CG_RequestMailHistoryList(SERVER, RELIABLESEND, lastMailHistorySN);
        }

        public void RequestMailRecentlyHistoryList(int firstMailHistorySN)
        {
            SendProxy.CG_RequestMailRecentlyHistoryList(SERVER, RELIABLESEND, firstMailHistorySN);
        }

        public void RequestFriendMailList()
        {
            SendProxy.CG_RequestFriendMailList(SERVER, RELIABLESEND);
        }

        public void RequestFriendMailConfirm(int mailSN)
        {
            SendProxy.CG_RequestFriendMailConfirm(SERVER, RELIABLESEND, mailSN);
        }

        public void RequestFriendMailConfirmAll()
        {
            SendProxy.CG_RequestFriendMailConfirmAll(SERVER, RELIABLESEND);
        }

        public void RequestNoticeMailReward(int noticeMailSEQ, NoticeMailType noticeMailType)
        {
            SendProxy.CG_RequestNoticeMailReward(SERVER, RELIABLESEND, noticeMailSEQ, noticeMailType);
        }

        public void RequestPackageMailList()
        {
            SendProxy.CG_RequestPackageMailList(SERVER, RELIABLESEND);
        }

        public void RequestPackageMailGet(int mailSerial, int packageID)
        {
            SendProxy.CG_RequestPackageMailGet(SERVER, RELIABLESEND, mailSerial, packageID);
        }

        public void RequestPackageMailHistoryList(int nextMailSEQ, bool isNext)
        {
            SendProxy.CG_RequestPackageMailHistoryList(SERVER, RELIABLESEND, nextMailSEQ, isNext);
        }

        public void RequestLevelUpPackageReward(int productID, int rewardID)
        {
            SendProxy.CG_RequestLevelUpPackageReward(SERVER, RELIABLESEND, productID, rewardID);
        }

        public void RequestLevelUpPackageRewardAll(int productID, int rewardID)
        {
            SendProxy.CG_RequestLevelUpPackageRewardAll(SERVER, RELIABLESEND, productID, rewardID);
        }

        public void RequestAttendancePackageReward(int productID)
        {
            SendProxy.CG_RequestAttendancePackageReward(SERVER, RELIABLESEND, productID);
        }

        public void RequestAttendancePackageRewardAll(int productID)
        {
            SendProxy.CG_RequestAttendancePackageRewardAll(SERVER, RELIABLESEND, productID);
        }

        public void RequestMailADReward(ADViewContentType contentType, int viewCount)
        {
            SendProxy.CG_RequestMailADReward(SERVER, RELIABLESEND, contentType, viewCount);
        }

        public void RequestGambleShopBuy(GambleShopBuyRequest gambleRequest)
        {
            SendProxy.CG_RequestGambleShopBuy(SERVER, RELIABLESEND, gambleRequest);
        }

        public void RequestStepupGambleShopBuy(int stepupGroupID, StepupPriceType priceType, int choiceItemID)
        {
            SendProxy.CG_RequestStepupGambleShopBuy(SERVER, RELIABLESEND, stepupGroupID, priceType, choiceItemID);
        }

        public void RequestStepupGambleMileageReward(int stepupGroupID, int mileageIndex, int choiceItemID)
        {
            SendProxy.CG_RequestStepupGambleMileageReward(SERVER, RELIABLESEND, stepupGroupID, mileageIndex, choiceItemID);
        }

        public void RequestItemGambleShopInfo()
        {
            SendProxy.CG_RequestItemGambleShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestItemGambleShopBuy(int itemGambleDisplayID, int usePriceItemID, bool isADView, WeaponAutoGrindOption grindOption)
        {
            SendProxy.CG_RequestItemGambleShopBuy(SERVER, RELIABLESEND, itemGambleDisplayID, usePriceItemID, isADView, grindOption);
        }

        public void RequestRandomShopBuy(int basepointID, byte slotIndex, byte buyCount)
        {
            SendProxy.CG_RequestRandomShopBuy(SERVER, RELIABLESEND, basepointID, slotIndex, buyCount);
        }

        public void RequestRandomShopRefresh(int basepointID, bool isADView)
        {
            SendProxy.CG_RequestRandomShopRefresh(SERVER, RELIABLESEND, basepointID, isADView);
        }

        public void RequestRandomShopInfo(int basepointID)
        {
            SendProxy.CG_RequestRandomShopInfo(SERVER, RELIABLESEND, basepointID);
        }

        public void RequestBasePointShopInfo(int basepointID, bool isCommonShop)
        {
            SendProxy.CG_RequestBasePointShopInfo(SERVER, RELIABLESEND, basepointID, isCommonShop);
        }

        public void RequestBasePointShopBuy(List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            SendProxy.CG_RequestBasePointShopBuy(SERVER, RELIABLESEND, shopBuyRequestInfoList);
        }

        public void RequestBasePointShopReset(int basepointID, bool isCommonShop, bool isADView)
        {
            SendProxy.CG_RequestBasePointShopReset(SERVER, RELIABLESEND, basepointID, isCommonShop, isADView);
        }

        public void RequestArenaRealTimePvpShopInfo(int basepointID)
        {
            SendProxy.CG_RequestArenaRealTimePvpShopInfo(SERVER, RELIABLESEND, basepointID);
        }

        public void RequestArenaRealTimePvpShopBuy(List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            SendProxy.CG_RequestArenaRealTimePvpShopBuy(SERVER, RELIABLESEND, shopBuyRequestInfoList);
        }

        public void RequestArenaRealTimePvpShopReset(int basepointID, bool isADView)
        {
            SendProxy.CG_RequestArenaRealTimePvpShopReset(SERVER, RELIABLESEND, basepointID, isADView);
        }

        public void RequestCoinShopInfo()
        {
            SendProxy.CG_RequestCoinShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestCoinShopBuy(int shopID, byte buyCount, List<UserCommonItem> useItemInfoList, bool isADView)
        {
            SendProxy.CG_RequestCoinShopBuy(SERVER, RELIABLESEND, shopID, buyCount, useItemInfoList, isADView);
        }

        public void RequestEventCoinShopBuy(int shopID, byte buyCount, List<UserCommonItem> useItemInfoList, bool isADView)
        {
            SendProxy.CG_RequestEventCoinShopBuy(SERVER, RELIABLESEND, shopID, buyCount, useItemInfoList, isADView);
        }

        public void RequestCostumeShopInfo()
        {
            SendProxy.CG_RequestCostumeShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestCostumeShopBuy(int shopID, byte buyCount)
        {
            SendProxy.CG_RequestCostumeShopBuy(SERVER, RELIABLESEND, shopID, buyCount);
        }

        public void RequestCostumeShopPackageBuy(List<CostumePackageBuyInfo> costumePackageBuyInfoList)
        {
            SendProxy.CG_RequestCostumeShopPackageBuy(SERVER, RELIABLESEND, costumePackageBuyInfoList);
        }

        public void RequestDiaShopInfo()
        {
            SendProxy.CG_RequestDiaShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestDiaShopBuy(int productItemID, byte buyCount)
        {
            SendProxy.CG_RequestDiaShopBuy(SERVER, RELIABLESEND, productItemID, buyCount);
        }

        public void RequestItemInventoryBuy(byte buyCount)
        {
            SendProxy.CG_RequestItemInventoryBuy(SERVER, RELIABLESEND, buyCount);
        }

        public void RequestWeaponInventoryBuy(byte buyCount)
        {
            SendProxy.CG_RequestWeaponInventoryBuy(SERVER, RELIABLESEND, buyCount);
        }

        public void RequestWeekStageKeyBuy()
        {
            SendProxy.CG_RequestWeekStageKeyBuy(SERVER, RELIABLESEND);
        }

        public void RequestCommonItemSell(List<UserCommonItem> sellCommonItemList, ItemSellType itemSellType, int basepointID)
        {
            SendProxy.CG_RequestCommonItemSell(SERVER, RELIABLESEND, sellCommonItemList, itemSellType, basepointID);
        }

        public void RequestCommonItemRemove(int itemID, int itemMinusCount)
        {
            SendProxy.CG_RequestCommonItemRemove(SERVER, RELIABLESEND, itemID, itemMinusCount);
        }

        public void RequestPackageBuy(int shopMoneyID, List<int> choiceItemIDList)
        {
            SendProxy.CG_RequestPackageBuy(SERVER, RELIABLESEND, shopMoneyID, choiceItemIDList);
        }

        public void RequestBuyDia(int shopMoneyID)
        {
            SendProxy.CG_RequestBuyDia(SERVER, RELIABLESEND, shopMoneyID);
        }

        public void RequestBuyGold(int shopMoneyID)
        {
            SendProxy.CG_RequestBuyGold(SERVER, RELIABLESEND, shopMoneyID);
        }

        public void RequestBuyStamina(int shopMoneyID)
        {
            SendProxy.CG_RequestBuyStamina(SERVER, RELIABLESEND, shopMoneyID);
        }

        public void RequestGuildShopInfo()
        {
            SendProxy.CG_RequestGuildShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildShopBuy(List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            SendProxy.CG_RequestGuildShopBuy(SERVER, RELIABLESEND, shopBuyRequestInfoList);
        }

        public void RequestGuildShopReset(bool isADView)
        {
            SendProxy.CG_RequestGuildShopReset(SERVER, RELIABLESEND, isADView);
        }

        public void RequestFinalBossShopInfo()
        {
            SendProxy.CG_RequestFinalBossShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestFinalBossShopBuy(int seasonID, int shopID, byte buyCount)
        {
            SendProxy.CG_RequestFinalBossShopBuy(SERVER, RELIABLESEND, seasonID, shopID, buyCount);
        }

        public void RequestBingoGambleShopInfo(int eventSEQ)
        {
            SendProxy.CG_RequestBingoGambleShopInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestBingoGambleShopReset(int eventSEQ)
        {
            SendProxy.CG_RequestBingoGambleShopReset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestBingoGambleShopReward(int eventSEQ, List<int> rewardIDList)
        {
            SendProxy.CG_RequestBingoGambleShopReward(SERVER, RELIABLESEND, eventSEQ, rewardIDList);
        }

        public void RequestDiaShopPackageBuy(int productItemID)
        {
            SendProxy.CG_RequestDiaShopPackageBuy(SERVER, RELIABLESEND, productItemID);
        }

        public void RequestRandomShopVisitReward(int basepointID)
        {
            SendProxy.CG_RequestRandomShopVisitReward(SERVER, RELIABLESEND, basepointID);
        }

        public void RequestGambleChoiceShopBuy(int gambleType, int choiceSkinID)
        {
            SendProxy.CG_RequestGambleChoiceShopBuy(SERVER, RELIABLESEND, gambleType, choiceSkinID);
        }

        public void RequestRandomShopScheduleInfo()
        {
            SendProxy.CG_RequestRandomShopScheduleInfo(SERVER, RELIABLESEND);
        }

        public void RequestPackageShopInfo()
        {
            SendProxy.CG_RequestPackageShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestFreePackageReward(int rewardID)
        {
            SendProxy.CG_RequestFreePackageReward(SERVER, RELIABLESEND, rewardID);
        }

        public void RequestPackageMissionClose(List<byte> packageMissionIDList)
        {
            SendProxy.CG_RequestPackageMissionClose(SERVER, RELIABLESEND, packageMissionIDList);
        }

        public void RequestGambleShopInfo(int gambleType, List<GambleCheckSumInfo> gambleCheckSumInfoList)
        {
            SendProxy.CG_RequestGambleShopInfo(SERVER, RELIABLESEND, gambleType, gambleCheckSumInfoList);
        }

        public void RequestADRouletteReward()
        {
            SendProxy.CG_RequestADRouletteReward(SERVER, RELIABLESEND);
        }

        public void RequestGambleGaugeReward(int gambleType, byte rewardStep, int choiceIndex)
        {
            SendProxy.CG_RequestGambleGaugeReward(SERVER, RELIABLESEND, gambleType, rewardStep, choiceIndex);
        }

        public void RequestArenaSmashShopInfo(int basepointID)
        {
            SendProxy.CG_RequestArenaSmashShopInfo(SERVER, RELIABLESEND, basepointID);
        }

        public void RequestArenaSmashShopBuy(List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            SendProxy.CG_RequestArenaSmashShopBuy(SERVER, RELIABLESEND, shopBuyRequestInfoList);
        }

        public void RequestArenaSmashShopReward(byte shopRewardID)
        {
            SendProxy.CG_RequestArenaSmashShopReward(SERVER, RELIABLESEND, shopRewardID);
        }

        public void RequestArenaSmashShopReset(int basepointID)
        {
            SendProxy.CG_RequestArenaSmashShopReset(SERVER, RELIABLESEND, basepointID);
        }

        public void RequestEvolutionExchange(int evolutionExchangeID, byte buyCount, List<NeedItemInfo> priceItemList)
        {
            SendProxy.CG_RequestEvolutionExchange(SERVER, RELIABLESEND, evolutionExchangeID, buyCount, priceItemList);
        }

        public void RequestQuestStart(int questID)
        {
            SendProxy.CG_RequestQuestStart(SERVER, RELIABLESEND, questID);
        }

        public void RequestQuestProgress(int questID, int needID, byte propIndex)
        {
            SendProxy.CG_RequestQuestProgress(SERVER, RELIABLESEND, questID, needID, propIndex);
        }

        public void RequestQuestClear(int questID)
        {
            SendProxy.CG_RequestQuestClear(SERVER, RELIABLESEND, questID);
        }

        public void RequestQuestRemove(int questID)
        {
            SendProxy.CG_RequestQuestRemove(SERVER, RELIABLESEND, questID);
        }

        public void RequestDirectSelectorReward(int selectorID)
        {
            SendProxy.CG_RequestDirectSelectorReward(SERVER, RELIABLESEND, selectorID);
        }

        public void RequestMissionProgress(MissionType missionType, int missionTypeValue, int addValue)
        {
            SendProxy.CG_RequestMissionProgress(SERVER, RELIABLESEND, missionType, missionTypeValue, addValue);
        }

        public void RequestMissionClear(List<MissionClearRequestInfo> missionClearList)
        {
            SendProxy.CG_RequestMissionClear(SERVER, RELIABLESEND, missionClearList);
        }

        public void RequestMissionEventClear(List<EventMissionClearRequestInfo> missionClearList)
        {
            SendProxy.CG_RequestMissionEventClear(SERVER, RELIABLESEND, missionClearList);
        }

        public void RequestMissionGetAchievePointReward(short rewardOrder)
        {
            SendProxy.CG_RequestMissionGetAchievePointReward(SERVER, RELIABLESEND, rewardOrder);
        }

        public void RequestQuestChapterClear(int region)
        {
            SendProxy.CG_RequestQuestChapterClear(SERVER, RELIABLESEND, region);
        }

        public void RequestEventMissionGetAchievePointReward(short rewardOrder)
        {
            SendProxy.CG_RequestEventMissionGetAchievePointReward(SERVER, RELIABLESEND, rewardOrder);
        }

        public void RequestEventMissionCompleteReward(int eventSeq)
        {
            SendProxy.CG_RequestEventMissionCompleteReward(SERVER, RELIABLESEND, eventSeq);
        }

        public void RequestEventMissionInfo()
        {
            SendProxy.CG_RequestEventMissionInfo(SERVER, RELIABLESEND);
        }

        public void RequestEventQuestClear(int eventSeq, int questID)
        {
            SendProxy.CG_RequestEventQuestClear(SERVER, RELIABLESEND, eventSeq, questID);
        }

        public void RequestAnotherQuestClear(int questID)
        {
            SendProxy.CG_RequestAnotherQuestClear(SERVER, RELIABLESEND, questID);
        }

        public void RequestNorthQuestClear(int questID)
        {
            SendProxy.CG_RequestNorthQuestClear(SERVER, RELIABLESEND, questID);
        }

        public void RequestQuestGuideListAllClearReward()
        {
            SendProxy.CG_RequestQuestGuideListAllClearReward(SERVER, RELIABLESEND);
        }

        public void RequestQuestGuideListStepStart()
        {
            SendProxy.CG_RequestQuestGuideListStepStart(SERVER, RELIABLESEND);
        }

        public void RequestQuestGuideListStepClear()
        {
            SendProxy.CG_RequestQuestGuideListStepClear(SERVER, RELIABLESEND);
        }

        public void RequestDisasterQuestClear(int questID)
        {
            SendProxy.CG_RequestDisasterQuestClear(SERVER, RELIABLESEND, questID);
        }

        public void RequestLobbyVRSearch(int interactiveVRID)
        {
            SendProxy.CG_RequestLobbyVRSearch(SERVER, RELIABLESEND, interactiveVRID);
        }

        public void RequestLobbyVRHelbram()
        {
            SendProxy.CG_RequestLobbyVRHelbram(SERVER, RELIABLESEND);
        }

        public void RequestLobbyNpcSkin(int npcID, int storyCostumeID)
        {
            SendProxy.CG_RequestLobbyNpcSkin(SERVER, RELIABLESEND, npcID, storyCostumeID);
        }

        public void RequestLobbyNpcGift(int npcID, int giftItemID)
        {
            SendProxy.CG_RequestLobbyNpcGift(SERVER, RELIABLESEND, npcID, giftItemID);
        }

        public void RequestLobbyKingAmber(int amberID, int rewardItemID, int amberCount)
        {
            SendProxy.CG_RequestLobbyKingAmber(SERVER, RELIABLESEND, amberID, rewardItemID, amberCount);
        }

        public void RequestLobbyDropInteractiveOpen(int npcID)
        {
            SendProxy.CG_RequestLobbyDropInteractiveOpen(SERVER, RELIABLESEND, npcID);
        }

        public void RequestLobbyUniqueInteractiveOpen(int npcID)
        {
            SendProxy.CG_RequestLobbyUniqueInteractiveOpen(SERVER, RELIABLESEND, npcID);
        }

        public void RequestLobbyNpcTalkInfo(int npcID)
        {
            SendProxy.CG_RequestLobbyNpcTalkInfo(SERVER, RELIABLESEND, npcID);
        }

        public void RequestLobbyNpcTalkChoice(int npcID, InteractiveChoice choice)
        {
            SendProxy.CG_RequestLobbyNpcTalkChoice(SERVER, RELIABLESEND, npcID, choice);
        }

        public void RequestLobbyBarrel()
        {
            SendProxy.CG_RequestLobbyBarrel(SERVER, RELIABLESEND);
        }

        public void RequestLobbyBarrelRefill(int itemIndex)
        {
            SendProxy.CG_RequestLobbyBarrelRefill(SERVER, RELIABLESEND, itemIndex);
        }

        public void RequestLobbyCleanTable()
        {
            SendProxy.CG_RequestLobbyCleanTable(SERVER, RELIABLESEND);
        }

        public void RequestLobbyServeBeer()
        {
            SendProxy.CG_RequestLobbyServeBeer(SERVER, RELIABLESEND);
        }

        public void RequestLobbyPlayJukebox(int playMusicID, byte musicInstrument)
        {
            SendProxy.CG_RequestLobbyPlayJukebox(SERVER, RELIABLESEND, playMusicID, musicInstrument);
        }

        public void RequestLobbyElizabethTouch()
        {
            SendProxy.CG_RequestLobbyElizabethTouch(SERVER, RELIABLESEND);
        }

        public void RequestLobbyHawkAnger()
        {
            SendProxy.CG_RequestLobbyHawkAnger(SERVER, RELIABLESEND);
        }

        public void RequestAttendanceReward(ClientDeviceType deviceType)
        {
            SendProxy.CG_RequestAttendanceReward(SERVER, RELIABLESEND, deviceType);
        }

        public void RequestAttendanceEventReward()
        {
            SendProxy.CG_RequestAttendanceEventReward(SERVER, RELIABLESEND);
        }

        public void RequestCookingStart(CookingRequest cookingRequest)
        {
            SendProxy.CG_RequestCookingStart(SERVER, RELIABLESEND, cookingRequest);
        }

        public void RequestRecipeActive(int recipeID)
        {
            SendProxy.CG_RequestRecipeActive(SERVER, RELIABLESEND, recipeID);
        }

        public void RequestCookingRecipeOrderInfo()
        {
            SendProxy.CG_RequestCookingRecipeOrderInfo(SERVER, RELIABLESEND);
        }

        public void RequestCookingRecipeOrder(byte slotIndex, int recipeID)
        {
            SendProxy.CG_RequestCookingRecipeOrder(SERVER, RELIABLESEND, slotIndex, recipeID);
        }

        public void RequestCookingRecipeDisorder(byte slotIndex)
        {
            SendProxy.CG_RequestCookingRecipeDisorder(SERVER, RELIABLESEND, slotIndex);
        }

        public void RequestCookingRecipeCollect()
        {
            SendProxy.CG_RequestCookingRecipeCollect(SERVER, RELIABLESEND);
        }

        public void RequestCookingRecipeCollectOneSlot(byte slotIndex)
        {
            SendProxy.CG_RequestCookingRecipeCollectOneSlot(SERVER, RELIABLESEND, slotIndex);
        }

        public void RequestCookingUseCookingBuff(int foodItemID, bool isAutoUse)
        {
            SendProxy.CG_RequestCookingUseCookingBuff(SERVER, RELIABLESEND, foodItemID, isAutoUse);
        }

        public void RequestGuestInfo()
        {
            SendProxy.CG_RequestGuestInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuestChange(int guestSlotIndex)
        {
            SendProxy.CG_RequestGuestChange(SERVER, RELIABLESEND, guestSlotIndex);
        }

        public void RequestGuestChangeTarget(int guestSlotIndex, int npcID, bool isFree)
        {
            SendProxy.CG_RequestGuestChangeTarget(SERVER, RELIABLESEND, guestSlotIndex, npcID, isFree);
        }

        public void RequestGuestTalk(int npcID, int talkID, InteractiveChoice choice)
        {
            SendProxy.CG_RequestGuestTalk(SERVER, RELIABLESEND, npcID, talkID, choice);
        }

        public void RequestGuestGift(int npcID, int giftItemID)
        {
            SendProxy.CG_RequestGuestGift(SERVER, RELIABLESEND, npcID, giftItemID);
        }

        public void RequestBirthdayNpcInfo(int npcID)
        {
            SendProxy.CG_RequestBirthdayNpcInfo(SERVER, RELIABLESEND, npcID);
        }

        public void RequestRestReward(int breakID, int rewardIndex)
        {
            SendProxy.CG_RequestRestReward(SERVER, RELIABLESEND, breakID, rewardIndex);
        }

        public void RequestLobbyHousingShopInfo()
        {
            SendProxy.CG_RequestLobbyHousingShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestLobbyHousingShopBuy(int shopID, byte buyCount)
        {
            SendProxy.CG_RequestLobbyHousingShopBuy(SERVER, RELIABLESEND, shopID, buyCount);
        }

        public void RequestLobbyFurnitureRegist(List<UserFurniture> registUserFurnitureList)
        {
            SendProxy.CG_RequestLobbyFurnitureRegist(SERVER, RELIABLESEND, registUserFurnitureList);
        }

        public void RequestUserMusicEdit(UserMusic editUserMusic)
        {
            SendProxy.CG_RequestUserMusicEdit(SERVER, RELIABLESEND, editUserMusic);
        }

        public void RequestAttendanceFortuneEventReward()
        {
            SendProxy.CG_RequestAttendanceFortuneEventReward(SERVER, RELIABLESEND);
        }

        public void RequestEventCookingStart(int eventSeq, CookingRequest cookingRequest)
        {
            SendProxy.CG_RequestEventCookingStart(SERVER, RELIABLESEND, eventSeq, cookingRequest);
        }

        public void RequestEventRecipeActive(int eventSeq, int recipeID)
        {
            SendProxy.CG_RequestEventRecipeActive(SERVER, RELIABLESEND, eventSeq, recipeID);
        }

        public void RequestLobbySetVisualType(LobbyVisualType lobbyVisualType)
        {
            SendProxy.CG_RequestLobbySetVisualType(SERVER, RELIABLESEND, lobbyVisualType);
        }

        public void RequestLobbySetAttendanceHero(int attendanceHeroID, int activeAttendanceHeroID)
        {
            SendProxy.CG_RequestLobbySetAttendanceHero(SERVER, RELIABLESEND, attendanceHeroID, activeAttendanceHeroID);
        }

        public void RequestBasePointGoldDonation(int basePointID, int useItemID, int useItemCount)
        {
            SendProxy.CG_RequestBasePointGoldDonation(SERVER, RELIABLESEND, basePointID, useItemID, useItemCount);
        }

        public void RequestBasePointSetTrigger(int triggerID)
        {
            SendProxy.CG_RequestBasePointSetTrigger(SERVER, RELIABLESEND, triggerID);
        }

        public void RequestBasePointDropInteractiveOpen(int npcID)
        {
            SendProxy.CG_RequestBasePointDropInteractiveOpen(SERVER, RELIABLESEND, npcID);
        }

        public void RequestBasePointUniqueInteractiveOpen(int npcID)
        {
            SendProxy.CG_RequestBasePointUniqueInteractiveOpen(SERVER, RELIABLESEND, npcID);
        }

        public void RequestBasePointDailyReward(int basepointID)
        {
            SendProxy.CG_RequestBasePointDailyReward(SERVER, RELIABLESEND, basepointID);
        }

        public void RequestBasePointDonationEventReward(int basepointID, int eventSeq, List<byte> rewardIndexList)
        {
            SendProxy.CG_RequestBasePointDonationEventReward(SERVER, RELIABLESEND, basepointID, eventSeq, rewardIndexList);
        }

        public void RequestBasePointDonationInfo(int basepointID)
        {
            SendProxy.CG_RequestBasePointDonationInfo(SERVER, RELIABLESEND, basepointID);
        }

        public void RequestBasePointEventGoldDonation(int eventSeq, int basepointID, int useItemID, int useItemCount)
        {
            SendProxy.CG_RequestBasePointEventGoldDonation(SERVER, RELIABLESEND, eventSeq, basepointID, useItemID, useItemCount);
        }

        public void RequestEventBasepointInfo(int eventSeq, int basepointID)
        {
            SendProxy.CG_RequestEventBasepointInfo(SERVER, RELIABLESEND, eventSeq, basepointID);
        }

        public void RequestDestroySetInviteOption(DestroyInviteOption option)
        {
            SendProxy.CG_RequestDestroySetInviteOption(SERVER, RELIABLESEND, option);
        }

        public void RequestDestroyGetUserLoginList()
        {
            SendProxy.CG_RequestDestroyGetUserLoginList(SERVER, RELIABLESEND);
        }

        public void RequestDestroyGetFriendLoginList()
        {
            SendProxy.CG_RequestDestroyGetFriendLoginList(SERVER, RELIABLESEND);
        }

        public void RequestDestroyGetGuildLoginList()
        {
            SendProxy.CG_RequestDestroyGetGuildLoginList(SERVER, RELIABLESEND);
        }

        public void RequestDestroyGetReceivedInvitationList()
        {
            SendProxy.CG_RequestDestroyGetReceivedInvitationList(SERVER, RELIABLESEND);
        }

        public void RequestDestroyInvite(List<long> invitedUSNList)
        {
            SendProxy.CG_RequestDestroyInvite(SERVER, RELIABLESEND, invitedUSNList);
        }

        public void RequestDestroyRemoveInvitation(int roomSN)
        {
            SendProxy.CG_RequestDestroyRemoveInvitation(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestDestroyRemoveJoinInfo()
        {
            SendProxy.CG_RequestDestroyRemoveJoinInfo(SERVER, RELIABLESEND);
        }

        public void RequestDestroyCreate(int destroyGroupID, byte difficulty, bool isMultiClear)
        {
            SendProxy.CG_RequestDestroyCreate(SERVER, RELIABLESEND, destroyGroupID, difficulty, isMultiClear);
        }

        public void RequestDestroyJoin(int roomSN, bool isLiveJoin)
        {
            SendProxy.CG_RequestDestroyJoin(SERVER, RELIABLESEND, roomSN, isLiveJoin);
        }

        public void RequestDestroyStart(int roomSN)
        {
            SendProxy.CG_RequestDestroyStart(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestDestroyBattleStart(int roomSN, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            SendProxy.CG_RequestDestroyBattleStart(SERVER, RELIABLESEND, roomSN, skinStatInfoList, battlePowerPoint);
        }

        public void RequestDestroyClear(DestroyClearRequest clearRequest)
        {
            SendProxy.CG_RequestDestroyClear(SERVER, RELIABLESEND, clearRequest);
        }

        public void RequestDestroyReJoin(int roomSN)
        {
            SendProxy.CG_RequestDestroyReJoin(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestDestroyRemove(byte region)
        {
            SendProxy.CG_RequestDestroyRemove(SERVER, RELIABLESEND, region);
        }

        public void RequestDestroyBattleEnd(DestroyExitRequest exitRequest)
        {
            SendProxy.CG_RequestDestroyBattleEnd(SERVER, RELIABLESEND, exitRequest);
        }

        public void RequestDestroyInviteAI(int roomSN, long invitedAIUSN)
        {
            SendProxy.CG_RequestDestroyInviteAI(SERVER, RELIABLESEND, roomSN, invitedAIUSN);
        }

        public void RequestDestroyKickOutAI(int roomSN, long kickoutUSN)
        {
            SendProxy.CG_RequestDestroyKickOutAI(SERVER, RELIABLESEND, roomSN, kickoutUSN);
        }

        public void RequestEventDestroyCreate(int eventSeq, int destroyGroupID, byte difficulty)
        {
            SendProxy.CG_RequestEventDestroyCreate(SERVER, RELIABLESEND, eventSeq, destroyGroupID, difficulty);
        }

        public void RequestEventDestroyStart(int eventSeq, int roomSN)
        {
            SendProxy.CG_RequestEventDestroyStart(SERVER, RELIABLESEND, eventSeq, roomSN);
        }

        public void RequestEventDestroyClear(int eventSeq, DestroyClearRequest clearRequest)
        {
            SendProxy.CG_RequestEventDestroyClear(SERVER, RELIABLESEND, eventSeq, clearRequest);
        }

        public void RequestEventDestroyRemove(int eventSeq)
        {
            SendProxy.CG_RequestEventDestroyRemove(SERVER, RELIABLESEND, eventSeq);
        }

        public void RequestEventChallengeDestroyCreate(int eventSeq, int destroyGroupID, byte difficulty)
        {
            SendProxy.CG_RequestEventChallengeDestroyCreate(SERVER, RELIABLESEND, eventSeq, destroyGroupID, difficulty);
        }

        public void RequestEventChallengeDestroyStart(int eventSeq, int roomSN)
        {
            SendProxy.CG_RequestEventChallengeDestroyStart(SERVER, RELIABLESEND, eventSeq, roomSN);
        }

        public void RequestEventChallengeDestroyClear(int eventSeq, DestroyClearRequest clearRequest)
        {
            SendProxy.CG_RequestEventChallengeDestroyClear(SERVER, RELIABLESEND, eventSeq, clearRequest);
        }

        public void RequestEventChallengeDestroyPointRefresh(int eventSEQ)
        {
            SendProxy.CG_RequestEventChallengeDestroyPointRefresh(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventChallengeDestroyUserReward(int eventSEQ, int step)
        {
            SendProxy.CG_RequestEventChallengeDestroyUserReward(SERVER, RELIABLESEND, eventSEQ, step);
        }

        public void RequestEventChallengeDestroyWorldReward(int eventSEQ, int step)
        {
            SendProxy.CG_RequestEventChallengeDestroyWorldReward(SERVER, RELIABLESEND, eventSEQ, step);
        }

        public void RequestDisasterDestroyCreate(int seasonID, int destroyGroupID, byte difficulty)
        {
            SendProxy.CG_RequestDisasterDestroyCreate(SERVER, RELIABLESEND, seasonID, destroyGroupID, difficulty);
        }

        public void RequestDisasterDestroyStart(int seasonID, int roomSN)
        {
            SendProxy.CG_RequestDisasterDestroyStart(SERVER, RELIABLESEND, seasonID, roomSN);
        }

        public void RequestDisasterDestroyClear(int seasonID, DestroyClearRequest clearRequest)
        {
            SendProxy.CG_RequestDisasterDestroyClear(SERVER, RELIABLESEND, seasonID, clearRequest);
        }

        public void RequestEventDisasterDestroyCreate(int destroyGroupID, byte difficulty)
        {
            SendProxy.CG_RequestEventDisasterDestroyCreate(SERVER, RELIABLESEND, destroyGroupID, difficulty);
        }

        public void RequestEventDisasterDestroyStart(int roomSN)
        {
            SendProxy.CG_RequestEventDisasterDestroyStart(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestEventDisasterDestroyClear(DestroyClearRequest clearRequest)
        {
            SendProxy.CG_RequestEventDisasterDestroyClear(SERVER, RELIABLESEND, clearRequest);
        }

        public void RequestEventDisasterDestroyLeave()
        {
            SendProxy.CG_RequestEventDisasterDestroyLeave(SERVER, RELIABLESEND);
        }

        public void RequestDestroyOtherPlayerTeamInfo(long targetUSN)
        {
            SendProxy.CG_RequestDestroyOtherPlayerTeamInfo(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestDestroyLiveJoinRegister(int groupID, byte difficulty, int battlePoint)
        {
            SendProxy.CG_RequestDestroyLiveJoinRegister(SERVER, RELIABLESEND, groupID, difficulty, battlePoint);
        }

        public void RequestDestroyLiveJoinUnregister()
        {
            SendProxy.CG_RequestDestroyLiveJoinUnregister(SERVER, RELIABLESEND);
        }

        public void RequestDestroyLiveJoinList(int battlePoint)
        {
            SendProxy.CG_RequestDestroyLiveJoinList(SERVER, RELIABLESEND, battlePoint);
        }

        public void RequestDestroyLiveJoinInvite(long targetUSN)
        {
            SendProxy.CG_RequestDestroyLiveJoinInvite(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestDestroyLiveJoinAbortInvitation(long targetUSN)
        {
            SendProxy.CG_RequestDestroyLiveJoinAbortInvitation(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestDestroyLiveJoinRejectInvitation(int roomSN)
        {
            SendProxy.CG_RequestDestroyLiveJoinRejectInvitation(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestDestroyRoomInfo(int roomSN)
        {
            SendProxy.CG_RequestDestroyRoomInfo(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendList()
        {
            SendProxy.CG_RequestFriendList(SERVER, RELIABLESEND);
        }

        public void RequestFriendGuildInfo(long friendUSN)
        {
            SendProxy.CG_RequestFriendGuildInfo(SERVER, RELIABLESEND, friendUSN);
        }

        public void RequestFriendApplySendList()
        {
            SendProxy.CG_RequestFriendApplySendList(SERVER, RELIABLESEND);
        }

        public void RequestFriendApplyReceiveList()
        {
            SendProxy.CG_RequestFriendApplyReceiveList(SERVER, RELIABLESEND);
        }

        public void RequestFriendApplySend(long targetUSN)
        {
            SendProxy.CG_RequestFriendApplySend(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestFriendApplyReject(long targetUSN)
        {
            SendProxy.CG_RequestFriendApplyReject(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestFriendApplyReceiveAccept(long targetUSN)
        {
            SendProxy.CG_RequestFriendApplyReceiveAccept(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestFriendApplyReceiveAcceptList(List<long> targetUSNList)
        {
            SendProxy.CG_RequestFriendApplyReceiveAcceptList(SERVER, RELIABLESEND, targetUSNList);
        }

        public void RequestFriendApplyReceiveRefuse(long targetUSN)
        {
            SendProxy.CG_RequestFriendApplyReceiveRefuse(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestFriendApplyReceiveRefuseList(List<long> targetUSNList)
        {
            SendProxy.CG_RequestFriendApplyReceiveRefuseList(SERVER, RELIABLESEND, targetUSNList);
        }

        public void RequestFriendRemove(long targetUSN)
        {
            SendProxy.CG_RequestFriendRemove(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestFriendSearch(int friendID)
        {
            SendProxy.CG_RequestFriendSearch(SERVER, RELIABLESEND, friendID);
        }

        public void RequestFriendVisit(long friendUSN)
        {
            SendProxy.CG_RequestFriendVisit(SERVER, RELIABLESEND, friendUSN);
        }

        public void RequestFriendPointSend(long friendUSN)
        {
            SendProxy.CG_RequestFriendPointSend(SERVER, RELIABLESEND, friendUSN);
        }

        public void RequestFriendPointSendAll()
        {
            SendProxy.CG_RequestFriendPointSendAll(SERVER, RELIABLESEND);
        }

        public void RequestFriendLobbyInfo(long friendUSN)
        {
            SendProxy.CG_RequestFriendLobbyInfo(SERVER, RELIABLESEND, friendUSN);
        }

        public void RequestFriendCookingRecipeInfo(long friendUSN)
        {
            SendProxy.CG_RequestFriendCookingRecipeInfo(SERVER, RELIABLESEND, friendUSN);
        }

        public void RequestFriendCookingEat(long friendUSN, int recipeI)
        {
            SendProxy.CG_RequestFriendCookingEat(SERVER, RELIABLESEND, friendUSN, recipeI);
        }

        public void RequestFriendCookingEatFriendList()
        {
            SendProxy.CG_RequestFriendCookingEatFriendList(SERVER, RELIABLESEND);
        }

        public void RequestRefreshRecommendFriendList()
        {
            SendProxy.CG_RequestRefreshRecommendFriendList(SERVER, RELIABLESEND);
        }

        public void RequestGuildRecommendList(bool isRefresh, bool defaultLanguage)
        {
            SendProxy.CG_RequestGuildRecommendList(SERVER, RELIABLESEND, isRefresh, defaultLanguage);
        }

        public void RequestGuildInfoWithMemberList(int guildSN)
        {
            SendProxy.CG_RequestGuildInfoWithMemberList(SERVER, RELIABLESEND, guildSN);
        }

        public void RequestGuildSearchByName(string guildName, bool defaultLanguage)
        {
            SendProxy.CG_RequestGuildSearchByName(SERVER, RELIABLESEND, guildName, defaultLanguage);
        }

        public void RequestGuildCreate(GuildSetupInfo setupInfo)
        {
            SendProxy.CG_RequestGuildCreate(SERVER, RELIABLESEND, setupInfo);
        }

        public void RequestGuildDisband()
        {
            SendProxy.CG_RequestGuildDisband(SERVER, RELIABLESEND);
        }

        public void RequestGuildApplicantList(int guildSN)
        {
            SendProxy.CG_RequestGuildApplicantList(SERVER, RELIABLESEND, guildSN);
        }

        public void RequestGuildApply(int guildSN)
        {
            SendProxy.CG_RequestGuildApply(SERVER, RELIABLESEND, guildSN);
        }

        public void RequestGuildReturnApplication()
        {
            SendProxy.CG_RequestGuildReturnApplication(SERVER, RELIABLESEND);
        }

        public void RequestGuildAcceptApplicant(long applicantUsn)
        {
            SendProxy.CG_RequestGuildAcceptApplicant(SERVER, RELIABLESEND, applicantUsn);
        }

        public void RequestGuildRejectApplicant(long applicantUsn)
        {
            SendProxy.CG_RequestGuildRejectApplicant(SERVER, RELIABLESEND, applicantUsn);
        }

        public void RequestGuildLevelUp()
        {
            SendProxy.CG_RequestGuildLevelUp(SERVER, RELIABLESEND);
        }

        public void RequestGuildChangeName(string newGuildName)
        {
            SendProxy.CG_RequestGuildChangeName(SERVER, RELIABLESEND, newGuildName);
        }

        public void RequestGuildChangeBoard(GuildSetupInfo setupInfo)
        {
            SendProxy.CG_RequestGuildChangeBoard(SERVER, RELIABLESEND, setupInfo);
        }

        public void RequestGuildChangeMaster(long newMasterUsn)
        {
            SendProxy.CG_RequestGuildChangeMaster(SERVER, RELIABLESEND, newMasterUsn);
        }

        public void RequestGuildChangeMemberGrade(long targetUsn, GuildMemberGrade targetGrade)
        {
            SendProxy.CG_RequestGuildChangeMemberGrade(SERVER, RELIABLESEND, targetUsn, targetGrade);
        }

        public void RequestGuildKickOutMember(long targetUsn)
        {
            SendProxy.CG_RequestGuildKickOutMember(SERVER, RELIABLESEND, targetUsn);
        }

        public void RequestGuildLeave()
        {
            SendProxy.CG_RequestGuildLeave(SERVER, RELIABLESEND);
        }

        public void RequestGuildRoomInfo()
        {
            SendProxy.CG_RequestGuildRoomInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildAttendance()
        {
            SendProxy.CG_RequestGuildAttendance(SERVER, RELIABLESEND);
        }

        public void RequestGuildAttendanceReward()
        {
            SendProxy.CG_RequestGuildAttendanceReward(SERVER, RELIABLESEND);
        }

        public void RequestGuildUserInfo(long usn)
        {
            SendProxy.CG_RequestGuildUserInfo(SERVER, RELIABLESEND, usn);
        }

        public void RequestGuildAttendanceStatus()
        {
            SendProxy.CG_RequestGuildAttendanceStatus(SERVER, RELIABLESEND);
        }

        public void RequestGuildDonation(GuildDonation guildDonation)
        {
            SendProxy.CG_RequestGuildDonation(SERVER, RELIABLESEND, guildDonation);
        }

        public void RequestGuildDonationInitialize(byte donationID)
        {
            SendProxy.CG_RequestGuildDonationInitialize(SERVER, RELIABLESEND, donationID);
        }

        public void RequestGuildMissionInfo()
        {
            SendProxy.CG_RequestGuildMissionInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildMissionReward(List<int> guildMissionIDList)
        {
            SendProxy.CG_RequestGuildMissionReward(SERVER, RELIABLESEND, guildMissionIDList);
        }

        public void RequestGuildDonationInfo()
        {
            SendProxy.CG_RequestGuildDonationInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildSkillInfo()
        {
            SendProxy.CG_RequestGuildSkillInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildSkillLevelUp(int currentSkillID)
        {
            SendProxy.CG_RequestGuildSkillLevelUp(SERVER, RELIABLESEND, currentSkillID);
        }

        public void RequestGuildSkillUse(byte slotNo, int skillID)
        {
            SendProxy.CG_RequestGuildSkillUse(SERVER, RELIABLESEND, slotNo, skillID);
        }

        public void RequestGuildSkillDisuse(byte slotNo)
        {
            SendProxy.CG_RequestGuildSkillDisuse(SERVER, RELIABLESEND, slotNo);
        }

        public void RequestGuildSkillUseInfo()
        {
            SendProxy.CG_RequestGuildSkillUseInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildBossRankPointReward(short rewardOrder, bool isNormal)
        {
            SendProxy.CG_RequestGuildBossRankPointReward(SERVER, RELIABLESEND, rewardOrder, isNormal);
        }

        public void RequestGuildBattlePointRegister(GuildBattlePointType type, List<UserTeamSlot> mainSlotList, int battlePoint)
        {
            SendProxy.CG_RequestGuildBattlePointRegister(SERVER, RELIABLESEND, type, mainSlotList, battlePoint);
        }

        public void RequestGuildBattlePointMemeberRankList(GuildBattlePointType type)
        {
            SendProxy.CG_RequestGuildBattlePointMemeberRankList(SERVER, RELIABLESEND, type);
        }

        public void RequestGuildBattlePointGuildRankList(GuildBattlePointType type)
        {
            SendProxy.CG_RequestGuildBattlePointGuildRankList(SERVER, RELIABLESEND, type);
        }

        public void RequestGuildBattlePointUserRankList(GuildBattlePointType type)
        {
            SendProxy.CG_RequestGuildBattlePointUserRankList(SERVER, RELIABLESEND, type);
        }

        public void RequestGuildInvitationReceivedList()
        {
            SendProxy.CG_RequestGuildInvitationReceivedList(SERVER, RELIABLESEND);
        }

        public void RequestGuildInvitationSend(long targetUSN)
        {
            SendProxy.CG_RequestGuildInvitationSend(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestGuildInvitationRemove(int guildSN)
        {
            SendProxy.CG_RequestGuildInvitationRemove(SERVER, RELIABLESEND, guildSN);
        }

        public void RequestGuildInvitationSetOption(bool isGuildInvitationOn)
        {
            SendProxy.CG_RequestGuildInvitationSetOption(SERVER, RELIABLESEND, isGuildInvitationOn);
        }

        public void RequestGuildMarkInfo()
        {
            SendProxy.CG_RequestGuildMarkInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildRecruitList(bool isRefresh, bool defaultLanguage, GuildRecruitSearchType searchType)
        {
            SendProxy.CG_RequestGuildRecruitList(SERVER, RELIABLESEND, isRefresh, defaultLanguage, searchType);
        }

        public void RequestGuildRecruitApply()
        {
            SendProxy.CG_RequestGuildRecruitApply(SERVER, RELIABLESEND);
        }

        public void RequestGuildRecruitCancel()
        {
            SendProxy.CG_RequestGuildRecruitCancel(SERVER, RELIABLESEND);
        }

        public void RequestAPRechargeByUseItem(int useItemID, int useCount, bool isADView)
        {
            SendProxy.CG_RequestAPRechargeByUseItem(SERVER, RELIABLESEND, useItemID, useCount, isADView);
        }

        public void RequestWeekStageKeyOpen(int areaID)
        {
            SendProxy.CG_RequestWeekStageKeyOpen(SERVER, RELIABLESEND, areaID);
        }

        public void RequestFoodBuffAutoUseOnOff(bool isAutoUse)
        {
            SendProxy.CG_RequestFoodBuffAutoUseOnOff(SERVER, RELIABLESEND, isAutoUse);
        }

        public void RequestItemUseRankExp(int itemID, int itemUseCount)
        {
            SendProxy.CG_RequestItemUseRankExp(SERVER, RELIABLESEND, itemID, itemUseCount);
        }

        public void RequestItemUseBoxOpen(int itemID, int itemUseCount, string codeAnswer)
        {
            SendProxy.CG_RequestItemUseBoxOpen(SERVER, RELIABLESEND, itemID, itemUseCount, codeAnswer);
        }

        public void RequestItemUseRecipeExp(int itemID, int itemUseCount)
        {
            SendProxy.CG_RequestItemUseRecipeExp(SERVER, RELIABLESEND, itemID, itemUseCount);
        }

        public void RequestItemUseWeeklyKeyBox(int useItemID, int useCount)
        {
            SendProxy.CG_RequestItemUseWeeklyKeyBox(SERVER, RELIABLESEND, useItemID, useCount);
        }

        public void RequestItemUseWeaponTicket(int useItemID, int selectedDBID)
        {
            SendProxy.CG_RequestItemUseWeaponTicket(SERVER, RELIABLESEND, useItemID, selectedDBID);
        }

        public void RequestItemUseMusic(int useItemID)
        {
            SendProxy.CG_RequestItemUseMusic(SERVER, RELIABLESEND, useItemID);
        }

        public void RequestItemUseBuff(int useItemID)
        {
            SendProxy.CG_RequestItemUseBuff(SERVER, RELIABLESEND, useItemID);
        }

        public void RequestWeekStageCoinOpen(int areaID, List<UserCommonItem> useItemInfoList)
        {
            SendProxy.CG_RequestWeekStageCoinOpen(SERVER, RELIABLESEND, areaID, useItemInfoList);
        }

        public void RequestTutorialAddStep(int tutorialStep)
        {
            SendProxy.CG_RequestTutorialAddStep(SERVER, RELIABLESEND, tutorialStep);
        }

        public void RequestTutorialSetFlag(TutorialType tutorialType)
        {
            SendProxy.CG_RequestTutorialSetFlag(SERVER, RELIABLESEND, tutorialType);
        }

        public void RequestTutorialHeroFlag(TutorialType tutorialType)
        {
            SendProxy.CG_RequestTutorialHeroFlag(SERVER, RELIABLESEND, tutorialType);
        }

        public void RequestTutorialGambleShopBuy(int tutorialStep)
        {
            SendProxy.CG_RequestTutorialGambleShopBuy(SERVER, RELIABLESEND, tutorialStep);
        }

        public void RequestBattleTutorialInfo(string netmarblePlayerID)
        {
            SendProxy.CG_RequestBattleTutorialInfo(SERVER, RELIABLESEND, netmarblePlayerID);
        }

        public void RequestBattleTutorialSet(string netmarblePlayerID, byte battleTutorialSeq)
        {
            SendProxy.CG_RequestBattleTutorialSet(SERVER, RELIABLESEND, netmarblePlayerID, battleTutorialSeq);
        }

        public void RequestFriendlyMatchCreate(byte matchMode, byte modeID)
        {
            SendProxy.CG_RequestFriendlyMatchCreate(SERVER, RELIABLESEND, matchMode, modeID);
        }

        public void RequestFriendlyMatchFriendList()
        {
            SendProxy.CG_RequestFriendlyMatchFriendList(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchInvite(List<long> friendUSNList)
        {
            SendProxy.CG_RequestFriendlyMatchInvite(SERVER, RELIABLESEND, friendUSNList);
        }

        public void RequestFriendlyMatchReceivedInviteList()
        {
            SendProxy.CG_RequestFriendlyMatchReceivedInviteList(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchInviteAccept(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchInviteAccept(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchInviteReject(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchInviteReject(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchStart(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchStart(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchBattleStart(int roomSN, int battlePowerPoint, OtherPlayerTeamInfo teamInfo, List<SkinStatInfo> skinStatInfoList, long otherUSN, byte otherTeamIndex)
        {
            SendProxy.CG_RequestFriendlyMatchBattleStart(SERVER, RELIABLESEND, roomSN, battlePowerPoint, teamInfo, skinStatInfoList, otherUSN, otherTeamIndex);
        }

        public void RequestFriendlyMatchClear(FriendlyMatchClearRequest clearRequestInfo)
        {
            SendProxy.CG_RequestFriendlyMatchClear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void RequestFriendlyMatchExit(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchExit(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchSetInviteOption(FriendlyMatchInviteOption option)
        {
            SendProxy.CG_RequestFriendlyMatchSetInviteOption(SERVER, RELIABLESEND, option);
        }

        public void RequestFriendlyMatchObserveCreate(byte matchMode, byte modeID, byte passiveID)
        {
            SendProxy.CG_RequestFriendlyMatchObserveCreate(SERVER, RELIABLESEND, matchMode, modeID, passiveID);
        }

        public void RequestFriendlyMatchObserveFriendList()
        {
            SendProxy.CG_RequestFriendlyMatchObserveFriendList(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveInvite(List<long> friendUSNList)
        {
            SendProxy.CG_RequestFriendlyMatchObserveInvite(SERVER, RELIABLESEND, friendUSNList);
        }

        public void RequestFriendlyMatchObserveReceivedInviteList()
        {
            SendProxy.CG_RequestFriendlyMatchObserveReceivedInviteList(SERVER, RELIABLESEND);
        }

        public void RequestFriendlyMatchObserveInviteAccept(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchObserveInviteAccept(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchObserveInviteReject(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchObserveInviteReject(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchObserveStart(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchObserveStart(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchObserveBattleStart(int roomSN, int battlePowerPoint, OtherPlayerTeamInfo teamInfo, List<SkinStatInfo> skinStatInfoList, long otherUSN, byte otherTeamIndex)
        {
            SendProxy.CG_RequestFriendlyMatchObserveBattleStart(SERVER, RELIABLESEND, roomSN, battlePowerPoint, teamInfo, skinStatInfoList, otherUSN, otherTeamIndex);
        }

        public void RequestFriendlyMatchObserveClear(FriendlyMatchClearRequest clearRequestInfo)
        {
            SendProxy.CG_RequestFriendlyMatchObserveClear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void RequestFriendlyMatchObserveExit(int roomSN)
        {
            SendProxy.CG_RequestFriendlyMatchObserveExit(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestFriendlyMatchObserveSetInviteOption(FriendlyMatchInviteOption option)
        {
            SendProxy.CG_RequestFriendlyMatchObserveSetInviteOption(SERVER, RELIABLESEND, option);
        }

        public void RequestEventSeasonPassInfo(byte currentClientSeasonPassWeek)
        {
            SendProxy.CG_RequestEventSeasonPassInfo(SERVER, RELIABLESEND, currentClientSeasonPassWeek);
        }

        public void RequestEventSeasonPassRankUpReward(int eventSEQ, int rewardRank, byte rewardIndex)
        {
            SendProxy.CG_RequestEventSeasonPassRankUpReward(SERVER, RELIABLESEND, eventSEQ, rewardRank, rewardIndex);
        }

        public void RequestEventSeasonPassRankUpRewardAll(int eventSEQ)
        {
            SendProxy.CG_RequestEventSeasonPassRankUpRewardAll(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventSeasonPassRankBuy(int eventSEQ, int buyRankCount)
        {
            SendProxy.CG_RequestEventSeasonPassRankBuy(SERVER, RELIABLESEND, eventSEQ, buyRankCount);
        }

        public void RequestWestSideServerInfo_Random(WestRoomType roomType)
        {
            SendProxy.CG_RequestWestSideServerInfo_Random(SERVER, RELIABLESEND, roomType);
        }

        public void RequestWestSideServerInfo_Fixed(WestRoomType roomType, int channelID, int roomID, bool isChannelChange)
        {
            SendProxy.CG_RequestWestSideServerInfo_Fixed(SERVER, RELIABLESEND, roomType, channelID, roomID, isChannelChange);
        }

        public void RequestWestSideServerInfo_Recommand(WestRoomType roomType)
        {
            SendProxy.CG_RequestWestSideServerInfo_Recommand(SERVER, RELIABLESEND, roomType);
        }

        public void RequestWestSide_PlayerInfo(long targetUSN)
        {
            SendProxy.CG_RequestWestSide_PlayerInfo(SERVER, RELIABLESEND, targetUSN);
        }

        public void RequestWestSide_PlayerteamInfo(long targetUSN, TeamIndexType teamIndexType)
        {
            SendProxy.CG_RequestWestSide_PlayerteamInfo(SERVER, RELIABLESEND, targetUSN, teamIndexType);
        }

        public void RequestWestSide_PlayerGuildInfo(int targetGuildSN)
        {
            SendProxy.CG_RequestWestSide_PlayerGuildInfo(SERVER, RELIABLESEND, targetGuildSN);
        }

        public void RequestWorldChattingChannel(int targetChannelId, bool neverFail)
        {
            SendProxy.CG_RequestWorldChattingChannel(SERVER, RELIABLESEND, targetChannelId, neverFail);
        }

        public void RequestArenaRealTimePvpLobbyInfo()
        {
            SendProxy.CG_RequestArenaRealTimePvpLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpJoin()
        {
            SendProxy.CG_RequestArenaRealTimePvpJoin(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpTopRankerList(ArenaLeagueGrade grade, byte gradeNum)
        {
            SendProxy.CG_RequestArenaRealTimePvpTopRankerList(SERVER, RELIABLESEND, grade, gradeNum);
        }

        public void RequestArenaRealTimePvpLastRankerList()
        {
            SendProxy.CG_RequestArenaRealTimePvpLastRankerList(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpMatching(byte teamIndex, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            SendProxy.CG_RequestArenaRealTimePvpMatching(SERVER, RELIABLESEND, teamIndex, skinStatInfoList, battlePowerPoint);
        }

        public void RequestArenaRealTimePvpBattleStart(long opponentUSN)
        {
            SendProxy.CG_RequestArenaRealTimePvpBattleStart(SERVER, RELIABLESEND, opponentUSN);
        }

        public void RequestArenaRealTimePvpBattleEnd(ArenaRealTimePVPClearRequest clearRequest)
        {
            SendProxy.CG_RequestArenaRealTimePvpBattleEnd(SERVER, SECURE_RELIABLE_SEND, clearRequest);
        }

        public void RequestArenaRealTimePvpRollback()
        {
            SendProxy.CG_RequestArenaRealTimePvpRollback(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpIngameBattleStart()
        {
            SendProxy.CG_RequestArenaRealTimePvpIngameBattleStart(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLowerLobbyInfo()
        {
            SendProxy.CG_RequestArenaRealTimePvpLowerLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLowerJoin()
        {
            SendProxy.CG_RequestArenaRealTimePvpLowerJoin(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLowerTopRankerList(ArenaLeagueGrade grade, byte gradeNum)
        {
            SendProxy.CG_RequestArenaRealTimePvpLowerTopRankerList(SERVER, RELIABLESEND, grade, gradeNum);
        }

        public void RequestArenaRealTimePvpLowerMatching(byte teamIndex, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            SendProxy.CG_RequestArenaRealTimePvpLowerMatching(SERVER, RELIABLESEND, teamIndex, skinStatInfoList, battlePowerPoint);
        }

        public void RequestArenaRealTimePvpLowerBattleEnd(ArenaRealTimePVPClearRequest clearRequest)
        {
            SendProxy.CG_RequestArenaRealTimePvpLowerBattleEnd(SERVER, SECURE_RELIABLE_SEND, clearRequest);
        }

        public void RequestArenaRealTimePvpAllInfo()
        {
            SendProxy.CG_RequestArenaRealTimePvpAllInfo(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLastRankerBattleInfo(byte rank)
        {
            SendProxy.CG_RequestArenaRealTimePvpLastRankerBattleInfo(SERVER, RELIABLESEND, rank);
        }

        public void RequestArenaRealTimePvpLastRankerBattleStart(byte rank)
        {
            SendProxy.CG_RequestArenaRealTimePvpLastRankerBattleStart(SERVER, RELIABLESEND, rank);
        }

        public void RequestArenaRealTimePvpLowerRollback()
        {
            SendProxy.CG_RequestArenaRealTimePvpLowerRollback(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLowerIngameBattleStart()
        {
            SendProxy.CG_RequestArenaRealTimePvpLowerIngameBattleStart(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingLobbyInfo()
        {
            SendProxy.CG_RequestArenaRankingLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingJoin()
        {
            SendProxy.CG_RequestArenaRankingJoin(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingTopRankerList()
        {
            SendProxy.CG_RequestArenaRankingTopRankerList(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingMatching(byte teamIndex, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            SendProxy.CG_RequestArenaRankingMatching(SERVER, RELIABLESEND, teamIndex, skinStatInfoList, battlePowerPoint);
        }

        public void RequestArenaRankingBattleEnd(ArenaRealTimePVPClearRequest clearRequest)
        {
            SendProxy.CG_RequestArenaRankingBattleEnd(SERVER, RELIABLESEND, clearRequest);
        }

        public void RequestArenaRankingIngameBattleStart()
        {
            SendProxy.CG_RequestArenaRankingIngameBattleStart(SERVER, RELIABLESEND);
        }

        public void RequestArenaRankingDefenceTeamUpdate()
        {
            SendProxy.CG_RequestArenaRankingDefenceTeamUpdate(SERVER, RELIABLESEND);
        }

        public void RequestPvpSeasonInfo()
        {
            SendProxy.CG_RequestPvpSeasonInfo(SERVER, RELIABLESEND);
        }

        public void RequestPvpSeasonHistory(int seasonID)
        {
            SendProxy.CG_RequestPvpSeasonHistory(SERVER, RELIABLESEND, seasonID);
        }

        public void RequestCurrentTopRanking()
        {
            SendProxy.CG_RequestCurrentTopRanking(SERVER, RELIABLESEND);
        }

        public void RequestLastTopRanking()
        {
            SendProxy.CG_RequestLastTopRanking(SERVER, RELIABLESEND);
        }

        public void RequestPvpAbuseReport(byte reportType)
        {
            SendProxy.CG_RequestPvpAbuseReport(SERVER, RELIABLESEND, reportType);
        }

        public void RequestPvpAllReward()
        {
            SendProxy.CG_RequestPvpAllReward(SERVER, RELIABLESEND);
        }

        public void RequestPvpAllJoin()
        {
            SendProxy.CG_RequestPvpAllJoin(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashTeamSlotChange(List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            SendProxy.CG_RequestArenaSmashTeamSlotChange(SERVER, RELIABLESEND, userTeamChangeInfoList, userArtifactTeamInfoList);
        }

        public void RequestArenaSmashDefenceTeamUpdate(int battlePowerPoint, List<AICustomizingInfo> aiCustomizingInfoList)
        {
            SendProxy.CG_RequestArenaSmashDefenceTeamUpdate(SERVER, RELIABLESEND, battlePowerPoint, aiCustomizingInfoList);
        }

        public void RequestArenaSmashDefenceTeamFoodBuffUpdate(byte teamIndex, int foodBuffItemID)
        {
            SendProxy.CG_RequestArenaSmashDefenceTeamFoodBuffUpdate(SERVER, RELIABLESEND, teamIndex, foodBuffItemID);
        }

        public void RequestArenaSmashLobbyInfo()
        {
            SendProxy.CG_RequestArenaSmashLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashJoin()
        {
            SendProxy.CG_RequestArenaSmashJoin(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashOpponentList()
        {
            SendProxy.CG_RequestArenaSmashOpponentList(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashOpponentListReload()
        {
            SendProxy.CG_RequestArenaSmashOpponentListReload(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashOpponentTeamInfo(long opponentUSN)
        {
            SendProxy.CG_RequestArenaSmashOpponentTeamInfo(SERVER, RELIABLESEND, opponentUSN);
        }

        public void RequestArenaSmashMatchJoin(long opponentUSN)
        {
            SendProxy.CG_RequestArenaSmashMatchJoin(SERVER, RELIABLESEND, opponentUSN);
        }

        public void RequestArenaSmashMatchBattleStart(ArenaSmashBattleStartRequest battleStartRequest)
        {
            SendProxy.CG_RequestArenaSmashMatchBattleStart(SERVER, RELIABLESEND, battleStartRequest);
        }

        public void RequestArenaSmashMatchBattleEnd(ArenaSmashBattleEndRequest battleEndRequest)
        {
            SendProxy.CG_RequestArenaSmashMatchBattleEnd(SERVER, RELIABLESEND, battleEndRequest);
        }

        public void RequestArenaSmashWinReward()
        {
            SendProxy.CG_RequestArenaSmashWinReward(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashBestRefresh()
        {
            SendProxy.CG_RequestArenaSmashBestRefresh(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashBestReward()
        {
            SendProxy.CG_RequestArenaSmashBestReward(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashRecordList()
        {
            SendProxy.CG_RequestArenaSmashRecordList(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashOffenseTeamFoodBuffUpdate(byte teamIndex, int foodBuffItemID)
        {
            SendProxy.CG_RequestArenaSmashOffenseTeamFoodBuffUpdate(SERVER, RELIABLESEND, teamIndex, foodBuffItemID);
        }

        public void RequestArenaSmashRankReward(int rank)
        {
            SendProxy.CG_RequestArenaSmashRankReward(SERVER, RELIABLESEND, rank);
        }

        public void RequestArenaSmashRankInfo()
        {
            SendProxy.CG_RequestArenaSmashRankInfo(SERVER, RELIABLESEND);
        }

        public void RequestArenaSmashMatchInfo(int rank, long opponentUSN)
        {
            SendProxy.CG_RequestArenaSmashMatchInfo(SERVER, RELIABLESEND, rank, opponentUSN);
        }

        public void RequestArenaRealTimePvpLimitLobbyInfo()
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLimitJoin()
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitJoin(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLimitMatching(List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitMatching(SERVER, RELIABLESEND, skinStatInfoList, battlePowerPoint);
        }

        public void RequestArenaRealTimePvpLimitBattleEnd(ArenaRealTimePVPClearRequest clearRequest)
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitBattleEnd(SERVER, RELIABLESEND, clearRequest);
        }

        public void RequestArenaRealTimePvpLimitIngameBattleStart()
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitIngameBattleStart(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLimitTeamChange(List<UserTeamSlot> mainSlotList, int battlePowerPoint)
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitTeamChange(SERVER, RELIABLESEND, mainSlotList, battlePowerPoint);
        }

        public void RequestArenaRealTimePvpLimitTopRankerList()
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitTopRankerList(SERVER, RELIABLESEND);
        }

        public void RequestArenaRealTimePvpLimitRankReward()
        {
            SendProxy.CG_RequestArenaRealTimePvpLimitRankReward(SERVER, RELIABLESEND);
        }

        public void RequestEventExchangeInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventExchangeInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventExchangeBoxGachaInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventExchangeBoxGachaInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventExchangeBoxGachaPickup(int eventSEQ, GambleAmountType amountType, bool useDia)
        {
            SendProxy.CG_RequestEventExchangeBoxGachaPickup(SERVER, RELIABLESEND, eventSEQ, amountType, useDia);
        }

        public void RequestEventExchangeBoxGachaReset(int eventSEQ)
        {
            SendProxy.CG_RequestEventExchangeBoxGachaReset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventPaybackReward(int eventSEQ)
        {
            SendProxy.CG_RequestEventPaybackReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventSnsShareProgress(int eventSEQ)
        {
            SendProxy.CG_RequestEventSnsShareProgress(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventSnsShareReward(int eventSEQ)
        {
            SendProxy.CG_RequestEventSnsShareReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestGagueEventInfo(int eventSEQ)
        {
            SendProxy.CG_RequestGagueEventInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestGagueEventCharge(int eventSEQ, int chargePoint, bool isFreeCharge)
        {
            SendProxy.CG_RequestGagueEventCharge(SERVER, RELIABLESEND, eventSEQ, chargePoint, isFreeCharge);
        }

        public void RequestGagueEventReward(int eventSEQ)
        {
            SendProxy.CG_RequestGagueEventReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestGagueEventReset(int eventSEQ)
        {
            SendProxy.CG_RequestGagueEventReset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventLadderReward(int eventSEQ, List<int> midRewardIDList, List<int> topRewardIDList)
        {
            SendProxy.CG_RequestEventLadderReward(SERVER, RELIABLESEND, eventSEQ, midRewardIDList, topRewardIDList);
        }

        public void RequestEventLobbyGiftReward(int eventSEQ)
        {
            SendProxy.CG_RequestEventLobbyGiftReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventTimeMissionInfo(int eventSeq, int currentClientTimeMissionDays)
        {
            SendProxy.CG_RequestEventTimeMissionInfo(SERVER, RELIABLESEND, eventSeq, currentClientTimeMissionDays);
        }

        public void RequestEventTimeMissionStart(int eventSeq)
        {
            SendProxy.CG_RequestEventTimeMissionStart(SERVER, RELIABLESEND, eventSeq);
        }

        public void RequestEventLobbyDecorationReward(int eventSEQ, int id)
        {
            SendProxy.CG_RequestEventLobbyDecorationReward(SERVER, RELIABLESEND, eventSEQ, id);
        }

        public void RequestEventPvpWinCountReward(int eventSEQ, byte week, byte rewardIndex)
        {
            SendProxy.CG_RequestEventPvpWinCountReward(SERVER, RELIABLESEND, eventSEQ, week, rewardIndex);
        }

        public void RequestEventChapterClearReward(int eventSEQ, int id)
        {
            SendProxy.CG_RequestEventChapterClearReward(SERVER, RELIABLESEND, eventSEQ, id);
        }

        public void RequestEventBingoInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventBingoInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventBingoReset(int eventSEQ)
        {
            SendProxy.CG_RequestEventBingoReset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventBingoRandomNumber(int eventSEQ, byte count)
        {
            SendProxy.CG_RequestEventBingoRandomNumber(SERVER, RELIABLESEND, eventSEQ, count);
        }

        public void RequestEventBingoExchangeNumber(int eventSEQ, List<EventBingoExchangeInfo> exchangeInfoList)
        {
            SendProxy.CG_RequestEventBingoExchangeNumber(SERVER, RELIABLESEND, eventSEQ, exchangeInfoList);
        }

        public void RequestEventSkinOneStepEvolution(int eventSEQ, int targetHeroID)
        {
            SendProxy.CG_RequestEventSkinOneStepEvolution(SERVER, RELIABLESEND, eventSEQ, targetHeroID);
        }

        public void RequestEventLuckyBoxInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventLuckyBoxInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventLuckyBoxReward(int eventSEQ)
        {
            SendProxy.CG_RequestEventLuckyBoxReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestRegistPlayTitle(int playTitleID)
        {
            SendProxy.CG_RequestRegistPlayTitle(SERVER, RELIABLESEND, playTitleID);
        }

        public void RequestPlayTitleMissionReward(int category)
        {
            SendProxy.CG_RequestPlayTitleMissionReward(SERVER, RELIABLESEND, category);
        }

        public void RequestPlayTitleInfo()
        {
            SendProxy.CG_RequestPlayTitleInfo(SERVER, RELIABLESEND);
        }

        public void RequestTournamentList()
        {
            SendProxy.CG_RequestTournamentList(SERVER, RELIABLESEND);
        }

        public void RequestTournamentProgressInfo(int tournamentSEQ)
        {
            SendProxy.CG_RequestTournamentProgressInfo(SERVER, RELIABLESEND, tournamentSEQ);
        }

        public void RequestTournamentResultInfo(int tournamentSEQ)
        {
            SendProxy.CG_RequestTournamentResultInfo(SERVER, RELIABLESEND, tournamentSEQ);
        }

        public void RequestTournamentMatchJoin(int tournamentSEQ, short matchIndex)
        {
            SendProxy.CG_RequestTournamentMatchJoin(SERVER, RELIABLESEND, tournamentSEQ, matchIndex);
        }

        public void RequestTournamentMatchBattleStart(TournamentBattleStartRequest battleStartRequest)
        {
            SendProxy.CG_RequestTournamentMatchBattleStart(SERVER, RELIABLESEND, battleStartRequest);
        }

        public void RequestTournamentMatchBattleEnd(TournamentBattleEndRequest battleEndRequest)
        {
            SendProxy.CG_RequestTournamentMatchBattleEnd(SERVER, RELIABLESEND, battleEndRequest);
        }

        public void RequestTournamentMatchExit(int roomSN)
        {
            SendProxy.CG_RequestTournamentMatchExit(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestTournamentReward(int tournamentSEQ)
        {
            SendProxy.CG_RequestTournamentReward(SERVER, RELIABLESEND, tournamentSEQ);
        }

        public void RequestTournamentPlayerTeamSlotChange(List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            SendProxy.CG_RequestTournamentPlayerTeamSlotChange(SERVER, RELIABLESEND, userTeamChangeInfoList, userArtifactTeamInfoList);
        }

        public void RequestTournamentPlayerTeamInfo(int tournamentSEQ, long playerUSN)
        {
            SendProxy.CG_RequestTournamentPlayerTeamInfo(SERVER, RELIABLESEND, tournamentSEQ, playerUSN);
        }

        public void RequestTournamentCheer(int tournamentSEQ, long playerUSN)
        {
            SendProxy.CG_RequestTournamentCheer(SERVER, RELIABLESEND, tournamentSEQ, playerUSN);
        }

        public void RequestTournamentCheerList(int tournamentSEQ)
        {
            SendProxy.CG_RequestTournamentCheerList(SERVER, RELIABLESEND, tournamentSEQ);
        }

        public void RequestTournamentWatcherJoin(int tournamentSEQ, short matchIndex)
        {
            SendProxy.CG_RequestTournamentWatcherJoin(SERVER, RELIABLESEND, tournamentSEQ, matchIndex);
        }

        public void RequestTournamentWatcherExit(int roomSN)
        {
            SendProxy.CG_RequestTournamentWatcherExit(SERVER, RELIABLESEND, roomSN);
        }

        public void RequestTournamentMatchPlayInfo(int tournamentSEQ, short matchIndex)
        {
            SendProxy.CG_RequestTournamentMatchPlayInfo(SERVER, RELIABLESEND, tournamentSEQ, matchIndex);
        }

        public void RequestTournamentReplayInfo(int tournamentSEQ, long replaySEQ)
        {
            SendProxy.CG_RequestTournamentReplayInfo(SERVER, RELIABLESEND, tournamentSEQ, replaySEQ);
        }

        public void RequestGuildWarLobbyInfo()
        {
            SendProxy.CG_RequestGuildWarLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarRankInfo(int season, int league)
        {
            SendProxy.CG_RequestGuildWarRankInfo(SERVER, RELIABLESEND, season, league);
        }

        public void RequestGuildWarVersusRecordInfo(int season, int league)
        {
            SendProxy.CG_RequestGuildWarVersusRecordInfo(SERVER, RELIABLESEND, season, league);
        }

        public void RequestGuildWarGuildMemberList(int guildSN)
        {
            SendProxy.CG_RequestGuildWarGuildMemberList(SERVER, RELIABLESEND, guildSN);
        }

        public void RequestGuildWarWorldMapInfo(int season, int guildSN)
        {
            SendProxy.CG_RequestGuildWarWorldMapInfo(SERVER, RELIABLESEND, season, guildSN);
        }

        public void RequestGuildWarAttackSquadChange(int season, List<GuildWarSquadSlot> updateGuildWarSquadSlotList)
        {
            SendProxy.CG_RequestGuildWarAttackSquadChange(SERVER, RELIABLESEND, season, updateGuildWarSquadSlotList);
        }

        public void RequestGuildWarDefenceTeamChange(int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            SendProxy.CG_RequestGuildWarDefenceTeamChange(SERVER, RELIABLESEND, season, userTeamChangeInfo);
        }

        public void RequestGuildWarRegionBonusScoreChange(int season, int regionID, int bonusScore)
        {
            SendProxy.CG_RequestGuildWarRegionBonusScoreChange(SERVER, RELIABLESEND, season, regionID, bonusScore);
        }

        public void RequestGuildWarAreaGuildMemberChange(int season, List<int> swapAreaIDList)
        {
            SendProxy.CG_RequestGuildWarAreaGuildMemberChange(SERVER, RELIABLESEND, season, swapAreaIDList);
        }

        public void RequestGuildWarBattleRecordInfo(int season, int guildSN, int areaID)
        {
            SendProxy.CG_RequestGuildWarBattleRecordInfo(SERVER, RELIABLESEND, season, guildSN, areaID);
        }

        public void Request_GuildWar_Stage_Start(GuildWarStageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_Request_GuildWar_Stage_Start(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void Request_GuildWar_Stage_Clear(GuildWarStageClearRequestInfo clearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest)
        {
            SendProxy.CG_Request_GuildWar_Stage_Clear(SERVER, RELIABLESEND, clearRequestInfo, ingameBattlePointRequest);
        }

        public void Request_GuildWar_Stage_Rejoin()
        {
            SendProxy.CG_Request_GuildWar_Stage_Rejoin(SERVER, RELIABLESEND);
        }

        public void Request_GuildWar_Stage_HeroStatus_Sync(List<ClientSyncGuildWarHero> clientSyncGuildWarHeroList)
        {
            SendProxy.CG_Request_GuildWar_Stage_HeroStatus_Sync(SERVER, RELIABLESEND, clientSyncGuildWarHeroList);
        }

        public void RequestGuildWarBattlePrepareInfo(int season)
        {
            SendProxy.CG_RequestGuildWarBattlePrepareInfo(SERVER, RELIABLESEND, season);
        }

        public void RequestGuildWarAttackTeamChange(int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            SendProxy.CG_RequestGuildWarAttackTeamChange(SERVER, RELIABLESEND, season, userTeamChangeInfo);
        }

        public void RequestGuildWarDefenceSlotExpand(int season, byte expandSlotCount)
        {
            SendProxy.CG_RequestGuildWarDefenceSlotExpand(SERVER, RELIABLESEND, season, expandSlotCount);
        }

        public void RequestGuildWarSquadSlotExpand(int season, byte expandSlotCount)
        {
            SendProxy.CG_RequestGuildWarSquadSlotExpand(SERVER, RELIABLESEND, season, expandSlotCount);
        }

        public void RequestGuildWarAttackTeamInfo(int season)
        {
            SendProxy.CG_RequestGuildWarAttackTeamInfo(SERVER, RELIABLESEND, season);
        }

        public void RequestGuildWarDefenceTeamInfo(int season, int guildSN, long deployUSN)
        {
            SendProxy.CG_RequestGuildWarDefenceTeamInfo(SERVER, RELIABLESEND, season, guildSN, deployUSN);
        }

        public void RequestGuildWarAttackTeamBuffRegist(int season, List<GuildWarTeamBuffRegist> guildWarTeamBuffRegistList)
        {
            SendProxy.CG_RequestGuildWarAttackTeamBuffRegist(SERVER, RELIABLESEND, season, guildWarTeamBuffRegistList);
        }

        public void RequestGuildWarDefenceTeamBuffRegist(int season, byte teamIndex, List<GuildWarTeamBuffRegist> guildWarTeamBuffRegistList)
        {
            SendProxy.CG_RequestGuildWarDefenceTeamBuffRegist(SERVER, RELIABLESEND, season, teamIndex, guildWarTeamBuffRegistList);
        }

        public void Request_GuildWar_Stage_Rejoin_Cancel()
        {
            SendProxy.CG_Request_GuildWar_Stage_Rejoin_Cancel(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarDefenceTeamInfoAll(int season, int guildSN)
        {
            SendProxy.CG_RequestGuildWarDefenceTeamInfoAll(SERVER, RELIABLESEND, season, guildSN);
        }

        public void RequestGuildWarRankInfoAll(int season)
        {
            SendProxy.CG_RequestGuildWarRankInfoAll(SERVER, RELIABLESEND, season);
        }

        public void RequestGuildWarDefenceTeamSave(int season, byte teamIndex, byte isOnlyHeroSave)
        {
            SendProxy.CG_RequestGuildWarDefenceTeamSave(SERVER, RELIABLESEND, season, teamIndex, isOnlyHeroSave);
        }

        public void RequestGuildWarMagicAreaRegist(int season, int magicAreaID, int magicBuffID)
        {
            SendProxy.CG_RequestGuildWarMagicAreaRegist(SERVER, RELIABLESEND, season, magicAreaID, magicBuffID);
        }

        public void RequestGuildWarDefenceTeamSaveAll(int season, byte isOnlyHeroSave, List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            SendProxy.CG_RequestGuildWarDefenceTeamSaveAll(SERVER, RELIABLESEND, season, isOnlyHeroSave, userTeamChangeInfoList, userArtifactTeamInfoList);
        }

        public void RequestGuildWarLowerLobbyInfo()
        {
            SendProxy.CG_RequestGuildWarLowerLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarCostumeReward()
        {
            SendProxy.CG_RequestGuildWarCostumeReward(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarRegionAttackPriorityChange(int guildSN, List<int> guildWarRegionIDList)
        {
            SendProxy.CG_RequestGuildWarRegionAttackPriorityChange(SERVER, RELIABLESEND, guildSN, guildWarRegionIDList);
        }

        public void RequestGuildWarBattleSettingChange(bool isComplete)
        {
            SendProxy.CG_RequestGuildWarBattleSettingChange(SERVER, RELIABLESEND, isComplete);
        }

        public void RequestGuildWarBattleSettingChangeInfo()
        {
            SendProxy.CG_RequestGuildWarBattleSettingChangeInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarNonSeasonBattlePrepareInfo()
        {
            SendProxy.CG_RequestGuildWarNonSeasonBattlePrepareInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarNonSeasonDefenceTeamChange(UserTeamChangeInfo userTeamChangeInfo)
        {
            SendProxy.CG_RequestGuildWarNonSeasonDefenceTeamChange(SERVER, RELIABLESEND, userTeamChangeInfo);
        }

        public void RequestGuildWarNonSeasonDefenceTeamSaveAll(byte isOnlyHeroSave, List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            SendProxy.CG_RequestGuildWarNonSeasonDefenceTeamSaveAll(SERVER, RELIABLESEND, isOnlyHeroSave, userTeamChangeInfoList, userArtifactTeamInfoList);
        }

        public void RequestGuildWarNonSeasonAttackSquadChange(List<GuildWarSquadSlot> updateGuildWarSquadSlotList)
        {
            SendProxy.CG_RequestGuildWarNonSeasonAttackSquadChange(SERVER, RELIABLESEND, updateGuildWarSquadSlotList);
        }

        public void RequestGuildWarUserInfo()
        {
            SendProxy.CG_RequestGuildWarUserInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarRecommandDefenceTeamInfo()
        {
            SendProxy.CG_RequestGuildWarRecommandDefenceTeamInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarRecommandDefenceTeamRegist(GuildWarRecommandDefenceTeamInfo guildWarRecommandDefenceTeamInfo)
        {
            SendProxy.CG_RequestGuildWarRecommandDefenceTeamRegist(SERVER, RELIABLESEND, guildWarRecommandDefenceTeamInfo);
        }

        public void RequestSubdueCreate(int groupID, byte difficulty)
        {
            SendProxy.CG_RequestSubdueCreate(SERVER, RELIABLESEND, groupID, difficulty);
        }

        public void RequestSubdueJoin(int gameSN)
        {
            SendProxy.CG_RequestSubdueJoin(SERVER, RELIABLESEND, gameSN);
        }

        public void RequestSubdueOwnerGameStart()
        {
            SendProxy.CG_RequestSubdueOwnerGameStart(SERVER, RELIABLESEND);
        }

        public void RequestSubdueLoadingComplete()
        {
            SendProxy.CG_RequestSubdueLoadingComplete(SERVER, RELIABLESEND);
        }

        public void RequestSubdueOnlineFriendList()
        {
            SendProxy.CG_RequestSubdueOnlineFriendList(SERVER, RELIABLESEND);
        }

        public void RequestSubdueOnlineGuildMemberList()
        {
            SendProxy.CG_RequestSubdueOnlineGuildMemberList(SERVER, RELIABLESEND);
        }

        public void RequestSubdueOnlineUserRankRangeList()
        {
            SendProxy.CG_RequestSubdueOnlineUserRankRangeList(SERVER, RELIABLESEND);
        }

        public void RequestSubdueInvitationReceiveList()
        {
            SendProxy.CG_RequestSubdueInvitationReceiveList(SERVER, RELIABLESEND);
        }

        public void RequestSubdueRemoveInvitation(int gameSN)
        {
            SendProxy.CG_RequestSubdueRemoveInvitation(SERVER, RELIABLESEND, gameSN);
        }

        public void RequestSubdueInvite(List<long> invitedUSNList)
        {
            SendProxy.CG_RequestSubdueInvite(SERVER, RELIABLESEND, invitedUSNList);
        }

        public void RequestSubdueReward(int gameSN, SubdubClearRequestInfo clearRequest)
        {
            SendProxy.CG_RequestSubdueReward(SERVER, RELIABLESEND, gameSN, clearRequest);
        }

        public void RequestPatrolMissionInfo()
        {
            SendProxy.CG_RequestPatrolMissionInfo(SERVER, RELIABLESEND);
        }

        public void RequestPatrolMissionStart(int patrolId, List<int> heroIdList, int battlePoint)
        {
            SendProxy.CG_RequestPatrolMissionStart(SERVER, RELIABLESEND, patrolId, heroIdList, battlePoint);
        }

        public void RequestPatrolMissionCancel(int patrolId)
        {
            SendProxy.CG_RequestPatrolMissionCancel(SERVER, RELIABLESEND, patrolId);
        }

        public void RequestPatrolMissionReward(int patrolId)
        {
            SendProxy.CG_RequestPatrolMissionReward(SERVER, RELIABLESEND, patrolId);
        }

        public void RequestPatrolMissionTimeReward(int id, byte rewardIndex)
        {
            SendProxy.CG_RequestPatrolMissionTimeReward(SERVER, RELIABLESEND, id, rewardIndex);
        }

        public void Request_Free_Stage_ClearTicket(StageClearTicketRequest clearTicketRequest)
        {
            SendProxy.CG_Request_Free_Stage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest);
        }

        public void Request_Week_Stage_ClearTicket(StageClearTicketRequest clearTicketRequest)
        {
            SendProxy.CG_Request_Week_Stage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest);
        }

        public void Request_Boss_Stage_ClearTicket(StageClearTicketRequest clearTicketRequest, bool isBatchPlay)
        {
            SendProxy.CG_Request_Boss_Stage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest, isBatchPlay);
        }

        public void Request_Week_EventStage_ClearTicket(StageClearTicketRequest clearTicketRequest)
        {
            SendProxy.CG_Request_Week_EventStage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest);
        }

        public void Request_DisasterBoss_Stage_ClearTicket(StageClearTicketRequest clearTicketRequest)
        {
            SendProxy.CG_Request_DisasterBoss_Stage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest);
        }

        public void Request_Free_EventAreaStage_ClearTicket(StageClearTicketRequest clearTicketRequest)
        {
            SendProxy.CG_Request_Free_EventAreaStage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest);
        }

        public void Request_Yggdrasil_Tower_Stage_ClearTicket(StageClearTicketRequest clearTicketRequest)
        {
            SendProxy.CG_Request_Yggdrasil_Tower_Stage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest);
        }

        public void Request_Training_Stage_ClearTicket(StageClearTicketRequest clearTicketRequest)
        {
            SendProxy.CG_Request_Training_Stage_ClearTicket(SERVER, RELIABLESEND, clearTicketRequest);
        }

        public void RequestEventExchangeCardInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventExchangeCardInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventExchangeCardSetup(int eventSEQ, List<int> specialIDList)
        {
            SendProxy.CG_RequestEventExchangeCardSetup(SERVER, RELIABLESEND, eventSEQ, specialIDList);
        }

        public void RequestEventExchangeCardChoiceManual(int eventSEQ, int boardIndex)
        {
            SendProxy.CG_RequestEventExchangeCardChoiceManual(SERVER, RELIABLESEND, eventSEQ, boardIndex);
        }

        public void RequestEventExchangeCardChoiceAuto(int eventSEQ)
        {
            SendProxy.CG_RequestEventExchangeCardChoiceAuto(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventExchangeCardReset(int eventSEQ)
        {
            SendProxy.CG_RequestEventExchangeCardReset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventCraftExchange(int eventSeq, int craftID, int craftCount)
        {
            SendProxy.CG_RequestEventCraftExchange(SERVER, RELIABLESEND, eventSeq, craftID, craftCount);
        }

        public void RequestEventProvisionProvide(int eventSEQ, int section, List<NeedItemInfo> provideItemInfoList)
        {
            SendProxy.CG_RequestEventProvisionProvide(SERVER, RELIABLESEND, eventSEQ, section, provideItemInfoList);
        }

        public void RequestEventProvisionGetFinalReward(int eventSEQ)
        {
            SendProxy.CG_RequestEventProvisionGetFinalReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventExchangeKingAmber(int eventSEQ, int amberID, int rewardItemID, int amberCount)
        {
            SendProxy.CG_RequestEventExchangeKingAmber(SERVER, RELIABLESEND, eventSEQ, amberID, rewardItemID, amberCount);
        }

        public void RequestEventTreasureHuntInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventTreasureHuntInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventTreasureHuntStart(int eventSEQ)
        {
            SendProxy.CG_RequestEventTreasureHuntStart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventTreasureHuntMoveDice(int eventSEQ, byte diceNumber, byte diceSpeed)
        {
            SendProxy.CG_RequestEventTreasureHuntMoveDice(SERVER, RELIABLESEND, eventSEQ, diceNumber, diceSpeed);
        }

        public void RequestEventTreasureHuntMoveChoosePoint(int eventSEQ, byte pointID)
        {
            SendProxy.CG_RequestEventTreasureHuntMoveChoosePoint(SERVER, RELIABLESEND, eventSEQ, pointID);
        }

        public void RequestEventTreasureHuntChooseReward(int eventSEQ, byte rewardIndex, bool isMissionSucceed)
        {
            SendProxy.CG_RequestEventTreasureHuntChooseReward(SERVER, RELIABLESEND, eventSEQ, rewardIndex, isMissionSucceed);
        }

        public void RequestEventTreasureHuntComplete(int eventSEQ, bool isRestart)
        {
            SendProxy.CG_RequestEventTreasureHuntComplete(SERVER, RELIABLESEND, eventSEQ, isRestart);
        }

        public void RequestEventTreasureHuntCompleteReward(int eventSEQ, byte rewardIndex)
        {
            SendProxy.CG_RequestEventTreasureHuntCompleteReward(SERVER, RELIABLESEND, eventSEQ, rewardIndex);
        }

        public void RequestEventTreasureHuntMission(int eventSEQ, bool isSucceed, byte diceSpeed)
        {
            SendProxy.CG_RequestEventTreasureHuntMission(SERVER, RELIABLESEND, eventSEQ, isSucceed, diceSpeed);
        }

        public void RequestEventKOFBritanniaInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventKOFBritanniaInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventKOFBritanniaStart(int eventSEQ)
        {
            SendProxy.CG_RequestEventKOFBritanniaStart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventKOFBritanniaTeamSelect(int eventSEQ, int teamID)
        {
            SendProxy.CG_RequestEventKOFBritanniaTeamSelect(SERVER, RELIABLESEND, eventSEQ, teamID);
        }

        public void RequestEventKOFBritanniaTeamChange(int eventSEQ, UserTeamChangeInfo userTeamChangeInfo)
        {
            SendProxy.CG_RequestEventKOFBritanniaTeamChange(SERVER, RELIABLESEND, eventSEQ, userTeamChangeInfo);
        }

        public void RequestEventKOFBritanniaStageStart(StageStartRequestInfo stageStartRequestInfo, List<int> mercenaryHeroIDList)
        {
            SendProxy.CG_RequestEventKOFBritanniaStageStart(SERVER, RELIABLESEND, stageStartRequestInfo, mercenaryHeroIDList);
        }

        public void RequestEventKOFBritanniaStageClear(StageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_RequestEventKOFBritanniaStageClear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void RequestEventKOFBritanniaStageContinue()
        {
            SendProxy.CG_RequestEventKOFBritanniaStageContinue(SERVER, RELIABLESEND);
        }

        public void RequestEventKOFBritanniaRestart(int eventSEQ)
        {
            SendProxy.CG_RequestEventKOFBritanniaRestart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventKOFBritanniaStageRejoinCancel(int eventSEQ)
        {
            SendProxy.CG_RequestEventKOFBritanniaStageRejoinCancel(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventGamblePaybackReward(int eventSEQ, short rewardOrder)
        {
            SendProxy.CG_RequestEventGamblePaybackReward(SERVER, RELIABLESEND, eventSEQ, rewardOrder);
        }

        public void RequestNMFunTalkKitLogin()
        {
            SendProxy.CG_RequestNMFunTalkKitLogin(SERVER, RELIABLESEND);
        }

        public void RequestNMFunTalkKitCreateRoom()
        {
            SendProxy.CG_RequestNMFunTalkKitCreateRoom(SERVER, RELIABLESEND);
        }

        public void Request_GuildBoss_User_Rank_Info(GuildBossDifficulty difficulty)
        {
            SendProxy.CG_Request_GuildBoss_User_Rank_Info(SERVER, RELIABLESEND, difficulty);
        }

        public void Request_GuildBoss_User_Rank_Info_Range(GuildBossDifficulty difficulty, int startRank, short count)
        {
            SendProxy.CG_Request_GuildBoss_User_Rank_Info_Range(SERVER, RELIABLESEND, difficulty, startRank, count);
        }

        public void RequestEventRandomBoxInfo(int eventSeq)
        {
            SendProxy.CG_RequestEventRandomBoxInfo(SERVER, RELIABLESEND, eventSeq);
        }

        public void RequestEventRandomBoxCreate(int eventSeq)
        {
            SendProxy.CG_RequestEventRandomBoxCreate(SERVER, RELIABLESEND, eventSeq);
        }

        public void RequestEventRandomBoxReward(int eventSeq, byte slot)
        {
            SendProxy.CG_RequestEventRandomBoxReward(SERVER, RELIABLESEND, eventSeq, slot);
        }

        public void RequestFinalBossVowUpdate(int stageId, List<int> vowIdList)
        {
            SendProxy.CG_RequestFinalBossVowUpdate(SERVER, RELIABLESEND, stageId, vowIdList);
        }

        public void RequestSeasonpassShopInfo(int eventSEQ)
        {
            SendProxy.CG_RequestSeasonpassShopInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestSeasonpassShopBuy(int eventSEQ, int shopID, byte buyCount)
        {
            SendProxy.CG_RequestSeasonpassShopBuy(SERVER, RELIABLESEND, eventSEQ, shopID, buyCount);
        }

        public void Request_EventPredict_User_Info(int eventSEQ)
        {
            SendProxy.CG_Request_EventPredict_User_Info(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_EventPredict_Start(int eventSEQ, List<UserPredictInfo> predictList)
        {
            SendProxy.CG_Request_EventPredict_Start(SERVER, RELIABLESEND, eventSEQ, predictList);
        }

        public void Request_EventPredict_Special_Reward(int eventSEQ, byte rewardIndex)
        {
            SendProxy.CG_Request_EventPredict_Special_Reward(SERVER, RELIABLESEND, eventSEQ, rewardIndex);
        }

        public void RequestGuildWarLowLobbyInfo()
        {
            SendProxy.CG_RequestGuildWarLowLobbyInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarLowApply()
        {
            SendProxy.CG_RequestGuildWarLowApply(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarLowAttackTeamChange(int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            SendProxy.CG_RequestGuildWarLowAttackTeamChange(SERVER, RELIABLESEND, season, userTeamChangeInfo);
        }

        public void RequestGuildWarLowDefenceTeamChange(int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            SendProxy.CG_RequestGuildWarLowDefenceTeamChange(SERVER, RELIABLESEND, season, userTeamChangeInfo);
        }

        public void RequestGuildWarLowAreaDeployGuildMember(int season, int areaID, long deployUSN)
        {
            SendProxy.CG_RequestGuildWarLowAreaDeployGuildMember(SERVER, RELIABLESEND, season, areaID, deployUSN);
        }

        public void RequestGuildWarLowAreaInfo(int season, int targetGuildSN, int areaID)
        {
            SendProxy.CG_RequestGuildWarLowAreaInfo(SERVER, RELIABLESEND, season, targetGuildSN, areaID);
        }

        public void RequestGuildWarLowStageStart(GuildWarLowStageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_RequestGuildWarLowStageStart(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void RequestGuildWarLowStageClear(GuildWarLowStageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_RequestGuildWarLowStageClear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void RequestGuildWarLowStageRejoin()
        {
            SendProxy.CG_RequestGuildWarLowStageRejoin(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarLowStageRejoinCancel()
        {
            SendProxy.CG_RequestGuildWarLowStageRejoinCancel(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarLowStageSync()
        {
            SendProxy.CG_RequestGuildWarLowStageSync(SERVER, RELIABLESEND);
        }

        public void RequestGuildWarLowDefenceTeamSaveAll(int totalDefenceTeamPower, List<UserTeamChangeInfo> userTeamChangeInfoList)
        {
            SendProxy.CG_RequestGuildWarLowDefenceTeamSaveAll(SERVER, RELIABLESEND, totalDefenceTeamPower, userTeamChangeInfoList);
        }

        public void RequestGuildWarLowBattleRecordInfo(int guildSN, long deployUSN, bool isNeedDefenceTeam)
        {
            SendProxy.CG_RequestGuildWarLowBattleRecordInfo(SERVER, RELIABLESEND, guildSN, deployUSN, isNeedDefenceTeam);
        }

        public void RequestGuildWarLowMemberList(int guildSN, bool isCheck)
        {
            SendProxy.CG_RequestGuildWarLowMemberList(SERVER, RELIABLESEND, guildSN, isCheck);
        }

        public void RequestGuildWarLowDefenceTeamInfo(int guildSN, long deployUSN)
        {
            SendProxy.CG_RequestGuildWarLowDefenceTeamInfo(SERVER, RELIABLESEND, guildSN, deployUSN);
        }

        public void RequestGuildWarLowAreaInfoList(int targetGuildSN)
        {
            SendProxy.CG_RequestGuildWarLowAreaInfoList(SERVER, RELIABLESEND, targetGuildSN);
        }

        public void RequestGuildWarLowRecordInfo()
        {
            SendProxy.CG_RequestGuildWarLowRecordInfo(SERVER, RELIABLESEND);
        }

        public void Request_EventAuto_On(int eventSEQ)
        {
            SendProxy.CG_Request_EventAuto_On(SERVER, RELIABLESEND, eventSEQ);
        }

        public void Request_EventAuto_Result(EventAutoInfo userEventAutoInfo)
        {
            SendProxy.CG_Request_EventAuto_Result(SERVER, RELIABLESEND, userEventAutoInfo);
        }

        public void Request_EventAuto_Battle_End(EventAutoInfo userEventAutoInfo)
        {
            SendProxy.CG_Request_EventAuto_Battle_End(SERVER, RELIABLESEND, userEventAutoInfo);
        }

        public void Request_EventAuto_HawkUpgrade(EventAutoInfo userEventAutoInfo)
        {
            SendProxy.CG_Request_EventAuto_HawkUpgrade(SERVER, RELIABLESEND, userEventAutoInfo);
        }

        public void Request_EventAuto_Reward(EventAutoInfo userEventAutoInfo)
        {
            SendProxy.CG_Request_EventAuto_Reward(SERVER, RELIABLESEND, userEventAutoInfo);
        }

        public void Request_EventAuto_Box_Slot_Upgrade(EventAutoInfo userEventAutoInfo)
        {
            SendProxy.CG_Request_EventAuto_Box_Slot_Upgrade(SERVER, RELIABLESEND, userEventAutoInfo);
        }

        public void Request_EventAuto_SpecialReward(EventAutoInfo userEventAutoInfo, int rewardIndex)
        {
            SendProxy.CG_Request_EventAuto_SpecialReward(SERVER, RELIABLESEND, userEventAutoInfo, rewardIndex);
        }

        public void RequestYggdrasilTowerStageStart(YggdrasilTowerStageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_RequestYggdrasilTowerStageStart(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void RequestYggdrasilTowerStageClear(YggdrasilTowerStageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_RequestYggdrasilTowerStageClear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void RequestYggdrasilTowerShopInfo()
        {
            SendProxy.CG_RequestYggdrasilTowerShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestYggdrasilTowerShopBuy(int shopID, byte buyCount)
        {
            SendProxy.CG_RequestYggdrasilTowerShopBuy(SERVER, RELIABLESEND, shopID, buyCount);
        }

        public void Request_Yggdrasil_Tower_Stage_Continue()
        {
            SendProxy.CG_Request_Yggdrasil_Tower_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void RequestArtifactCardPackOpen(int itemId, int count)
        {
            SendProxy.CG_RequestArtifactCardPackOpen(SERVER, RELIABLESEND, itemId, count);
        }

        public void RequestArtifactUnionUpgrade(int unionId, List<NeedItemInfo> useItemInfoList)
        {
            SendProxy.CG_RequestArtifactUnionUpgrade(SERVER, RELIABLESEND, unionId, useItemInfoList);
        }

        public void RequestArtifactTeamChange(UserArtifactTeamInfo artifactTeamInfo)
        {
            SendProxy.CG_RequestArtifactTeamChange(SERVER, RELIABLESEND, artifactTeamInfo);
        }

        public void RequestArtifactDescentBossTeamChange(List<UserArtifactTeamInfo> artifactTeamInfoList)
        {
            SendProxy.CG_RequestArtifactDescentBossTeamChange(SERVER, RELIABLESEND, artifactTeamInfoList);
        }

        public void RequestArtifactTeamInfoAll()
        {
            SendProxy.CG_RequestArtifactTeamInfoAll(SERVER, RELIABLESEND);
        }

        public void RequestArtifactDemonLordTeamChange(List<UserArtifactTeamInfo> artifactTeamInfoList)
        {
            SendProxy.CG_RequestArtifactDemonLordTeamChange(SERVER, RELIABLESEND, artifactTeamInfoList);
        }

        public void RequestEventArtifactWishSave(int eventSEQ, List<int> artifactCardIdList)
        {
            SendProxy.CG_RequestEventArtifactWishSave(SERVER, RELIABLESEND, eventSEQ, artifactCardIdList);
        }

        public void RequestEventArtifactWishCardPackOpen(int eventSEQ, int count)
        {
            SendProxy.CG_RequestEventArtifactWishCardPackOpen(SERVER, RELIABLESEND, eventSEQ, count);
        }

        public void RequestNorthGrimBookReward(int grimContentID)
        {
            SendProxy.CG_RequestNorthGrimBookReward(SERVER, RELIABLESEND, grimContentID);
        }

        public void Request_CreatureNest_Season_Info()
        {
            SendProxy.CG_Request_CreatureNest_Season_Info(SERVER, RELIABLESEND);
        }

        public void Request_CreatureNest_Stage_Start(CreatureNestStageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_Request_CreatureNest_Stage_Start(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void Request_CreatureNest_Stage_Clear(CreatureNestStageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_Request_CreatureNest_Stage_Clear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void Request_CreatureNest_Stage_Continue()
        {
            SendProxy.CG_Request_CreatureNest_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_CreatureNest_Init(int groupID)
        {
            SendProxy.CG_Request_CreatureNest_Init(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureNest_Team_Save(int groupID)
        {
            SendProxy.CG_Request_CreatureNest_Team_Save(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureNest_Stage_Rejoin(int groupID)
        {
            SendProxy.CG_Request_CreatureNest_Stage_Rejoin(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureNest_Stage_Rejoin_Cancel(int groupID)
        {
            SendProxy.CG_Request_CreatureNest_Stage_Rejoin_Cancel(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureNest_Use_Reset_Item(int groupID)
        {
            SendProxy.CG_Request_CreatureNest_Use_Reset_Item(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureNest_Challenge_Reward(int groupID)
        {
            SendProxy.CG_Request_CreatureNest_Challenge_Reward(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureNest_Select_Group(int groupId)
        {
            SendProxy.CG_Request_CreatureNest_Select_Group(SERVER, RELIABLESEND, groupId);
        }

        public void RequestEventCheerGroup(int eventSEQ, int groupID, byte cheerCount)
        {
            SendProxy.CG_RequestEventCheerGroup(SERVER, RELIABLESEND, eventSEQ, groupID, cheerCount);
        }

        public void RequestEventCheerGaugeReward(int eventSEQ, int gaugeID)
        {
            SendProxy.CG_RequestEventCheerGaugeReward(SERVER, RELIABLESEND, eventSEQ, gaugeID);
        }

        public void RequestEventCheerFinishReward(int eventSEQ)
        {
            SendProxy.CG_RequestEventCheerFinishReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventDiceInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventDiceInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventDiceRoll(int eventSEQ, bool isBonusRoll)
        {
            SendProxy.CG_RequestEventDiceRoll(SERVER, RELIABLESEND, eventSEQ, isBonusRoll);
        }

        public void RequestEventDiceRollEventHandle(int eventSEQ, int answerIndex)
        {
            SendProxy.CG_RequestEventDiceRollEventHandle(SERVER, RELIABLESEND, eventSEQ, answerIndex);
        }

        public void RequestEventDiceRaceReward(int eventSEQ, int rewardIndex)
        {
            SendProxy.CG_RequestEventDiceRaceReward(SERVER, RELIABLESEND, eventSEQ, rewardIndex);
        }

        public void RequestConstellationStoneOpen(byte group, List<int> stoneIdList)
        {
            SendProxy.CG_RequestConstellationStoneOpen(SERVER, RELIABLESEND, group, stoneIdList);
        }

        public void RequestConstellationStoneOptionValueChange(byte group, ConstellationManaStoneColorType color)
        {
            SendProxy.CG_RequestConstellationStoneOptionValueChange(SERVER, RELIABLESEND, group, color);
        }

        public void RequestConstellationStoneOptionValueChangeApply(byte gruop, bool isApply)
        {
            SendProxy.CG_RequestConstellationStoneOptionValueChangeApply(SERVER, RELIABLESEND, gruop, isApply);
        }

        public void RequestConstellationStoneLock(int stoneId, bool isLock)
        {
            SendProxy.CG_RequestConstellationStoneLock(SERVER, RELIABLESEND, stoneId, isLock);
        }

        public void RequestMaterialFusion(List<NeedItemInfo> matarialItemInfoList)
        {
            SendProxy.CG_RequestMaterialFusion(SERVER, RELIABLESEND, matarialItemInfoList);
        }

        public void RequestEventPuzzleInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventPuzzleInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventPuzzleInfoStart(int eventSEQ)
        {
            SendProxy.CG_RequestEventPuzzleInfoStart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventPuzzleInfoEnd(int eventSEQ, List<EventPuzzleBlockScoreInfo> blockScoreInfoList, int score)
        {
            SendProxy.CG_RequestEventPuzzleInfoEnd(SERVER, RELIABLESEND, eventSEQ, blockScoreInfoList, score);
        }

        public void RequestEventPuzzleInfoBlockReward(int eventSEQ, int blockID, int rewardOrder)
        {
            SendProxy.CG_RequestEventPuzzleInfoBlockReward(SERVER, RELIABLESEND, eventSEQ, blockID, rewardOrder);
        }

        public void RequestEventPuzzleInfoTotalReward(int eventSEQ, int rewardOrder)
        {
            SendProxy.CG_RequestEventPuzzleInfoTotalReward(SERVER, RELIABLESEND, eventSEQ, rewardOrder);
        }

        public void RequestRandomLuckybagInfo(int eventSEQ)
        {
            SendProxy.CG_RequestRandomLuckybagInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestRandomLuckybagOpen(int eventSEQ, int openOrder)
        {
            SendProxy.CG_RequestRandomLuckybagOpen(SERVER, RELIABLESEND, eventSEQ, openOrder);
        }

        public void RequestRandomLuckybagLastReward(int eventSEQ)
        {
            SendProxy.CG_RequestRandomLuckybagLastReward(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestAncientWarInfo(int eventSEQ)
        {
            SendProxy.CG_RequestAncientWarInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestAncientWarRefresh(int eventSEQ)
        {
            SendProxy.CG_RequestAncientWarRefresh(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestAncientWarTeamSelect(int eventSEQ, AncientWarTeamType teamType)
        {
            SendProxy.CG_RequestAncientWarTeamSelect(SERVER, RELIABLESEND, eventSEQ, teamType);
        }

        public void RequestAncientWarStageStart(AncientWarStageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_RequestAncientWarStageStart(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void RequestAncientWarStageClear(AncientWarStageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_RequestAncientWarStageClear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void RequestAncientWarExtraStageStart(AncientWarExtraStageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_RequestAncientWarExtraStageStart(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void RequestAncientWarExtraStageClear(AncientWarExtraStageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_RequestAncientWarExtraStageClear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void RequestAncientWarReward(int eventSEQ, byte rewardIndex)
        {
            SendProxy.CG_RequestAncientWarReward(SERVER, RELIABLESEND, eventSEQ, rewardIndex);
        }

        public void RequestAncientWarDonation(int eventSEQ, int areaId, int useCount)
        {
            SendProxy.CG_RequestAncientWarDonation(SERVER, RELIABLESEND, eventSEQ, areaId, useCount);
        }

        public void RequestAncientWarRankInfo(int eventSEQ)
        {
            SendProxy.CG_RequestAncientWarRankInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventStepupMissionStart(int eventSEQ)
        {
            SendProxy.CG_RequestEventStepupMissionStart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventStepupMissionGroupClear(int eventSEQ, int groupRewardID)
        {
            SendProxy.CG_RequestEventStepupMissionGroupClear(SERVER, RELIABLESEND, eventSEQ, groupRewardID);
        }

        public void RequestEventGambleWishSave(int eventSEQ, int gambleGroup, int skinId)
        {
            SendProxy.CG_RequestEventGambleWishSave(SERVER, RELIABLESEND, eventSEQ, gambleGroup, skinId);
        }

        public void RequestEventMazeInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeStart(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeStart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeSelectStartHeroes(int eventSEQ, List<int> heroIDList)
        {
            SendProxy.CG_RequestEventMazeSelectStartHeroes(SERVER, RELIABLESEND, eventSEQ, heroIDList);
        }

        public void RequestEventMazeInitialize(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeInitialize(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeMove(int eventSEQ, int stageID, int heroID, int mazeHeroID)
        {
            SendProxy.CG_RequestEventMazeMove(SERVER, RELIABLESEND, eventSEQ, stageID, heroID, mazeHeroID);
        }

        public void RequestEventMazePassiveSelect(int eventSEQ, int passiveID)
        {
            SendProxy.CG_RequestEventMazePassiveSelect(SERVER, RELIABLESEND, eventSEQ, passiveID);
        }

        public void RequestEventMazeSeasonReward(int eventSEQ, int rewardIndex)
        {
            SendProxy.CG_RequestEventMazeSeasonReward(SERVER, RELIABLESEND, eventSEQ, rewardIndex);
        }

        public void RequestEventMazeChangeSlot(int eventSEQ, List<int> heroIDList)
        {
            SendProxy.CG_RequestEventMazeChangeSlot(SERVER, RELIABLESEND, eventSEQ, heroIDList);
        }

        public void RequestEventMazeRefreshSelectableHeroes(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeRefreshSelectableHeroes(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeShopBuy(int eventSEQ, int stageID, int shopID, int heroID, int mazeHeroID, int passiveID)
        {
            SendProxy.CG_RequestEventMazeShopBuy(SERVER, RELIABLESEND, eventSEQ, stageID, shopID, heroID, mazeHeroID, passiveID);
        }

        public void RequestEventMazeRefreshSelectablePassives(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeRefreshSelectablePassives(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeSaveTeam(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeSaveTeam(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeSelectClearBonus(int eventSEQ, bool isClearBonus, int replayBonusID, int passiveID, int heroID, MazeSpotType mazeSpotType)
        {
            SendProxy.CG_RequestEventMazeSelectClearBonus(SERVER, RELIABLESEND, eventSEQ, isClearBonus, replayBonusID, passiveID, heroID, mazeSpotType);
        }

        public void RequestEventMazeSeasonShopInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeSeasonShopInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeSeasonShopBuy(int seasonID, int shopID, byte buyCount)
        {
            SendProxy.CG_RequestEventMazeSeasonShopBuy(SERVER, RELIABLESEND, seasonID, shopID, buyCount);
        }

        public void RequestEventMazeStartSavedTeam(int eventSEQ)
        {
            SendProxy.CG_RequestEventMazeStartSavedTeam(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMazeShopBuffBuy(int eventSEQ, int stageID, int shopBuffID)
        {
            SendProxy.CG_RequestEventMazeShopBuffBuy(SERVER, RELIABLESEND, eventSEQ, stageID, shopBuffID);
        }

        public void RequestEventMoleGameInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventMoleGameInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMoleGameStart(int eventSEQ)
        {
            SendProxy.CG_RequestEventMoleGameStart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventMoleGameEnd(int eventSEQ, int getScore, List<EventMoleGameRecordScoreInfo> recordScoreInfoList)
        {
            SendProxy.CG_RequestEventMoleGameEnd(SERVER, RELIABLESEND, eventSEQ, getScore, recordScoreInfoList);
        }

        public void RequestEventMoleGameRecordReward(int eventSEQ, int recordType, int rewardOrder)
        {
            SendProxy.CG_RequestEventMoleGameRecordReward(SERVER, RELIABLESEND, eventSEQ, recordType, rewardOrder);
        }

        public void RequestEventMoleGameTotalReward(int eventSEQ, int rewardOrder)
        {
            SendProxy.CG_RequestEventMoleGameTotalReward(SERVER, RELIABLESEND, eventSEQ, rewardOrder);
        }

        public void RequestEventMoleGameRankInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventMoleGameRankInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventConfirmGameInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventConfirmGameInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventConfirmGameStart(int eventSEQ)
        {
            SendProxy.CG_RequestEventConfirmGameStart(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventConfirmGameEnd(int eventSEQ, int getScore, List<EventConfirmGameRecordScoreInfo> recordScoreInfoList)
        {
            SendProxy.CG_RequestEventConfirmGameEnd(SERVER, RELIABLESEND, eventSEQ, getScore, recordScoreInfoList);
        }

        public void RequestEventConfirmGameRecordReward(int eventSEQ, int recordType, int rewardOrder)
        {
            SendProxy.CG_RequestEventConfirmGameRecordReward(SERVER, RELIABLESEND, eventSEQ, recordType, rewardOrder);
        }

        public void RequestEventConfirmGameTotalReward(int eventSEQ, int rewardOrder)
        {
            SendProxy.CG_RequestEventConfirmGameTotalReward(SERVER, RELIABLESEND, eventSEQ, rewardOrder);
        }

        public void RequestEventLobbyBuffInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventLobbyBuffInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventLobbyBuffBuy(int eventSEQ, List<int> buffIdList)
        {
            SendProxy.CG_RequestEventLobbyBuffBuy(SERVER, RELIABLESEND, eventSEQ, buffIdList);
        }

        public void RequestEventBoxWishInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventBoxWishInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventBoxWishSet(int eventSEQ, int wishId)
        {
            SendProxy.CG_RequestEventBoxWishSet(SERVER, RELIABLESEND, eventSEQ, wishId);
        }

        public void RequestEventBoxWishPickUp(int eventSEQ, byte pickCount)
        {
            SendProxy.CG_RequestEventBoxWishPickUp(SERVER, RELIABLESEND, eventSEQ, pickCount);
        }

        public void RequestEventBoxWishReset(int eventSEQ)
        {
            SendProxy.CG_RequestEventBoxWishReset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventRoadInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventRoadInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventRoadWalk(int eventSEQ, List<short> idList)
        {
            SendProxy.CG_RequestEventRoadWalk(SERVER, RELIABLESEND, eventSEQ, idList);
        }

        public void RequestEventRoadReward(int eventSEQ, List<short> rewardIdList)
        {
            SendProxy.CG_RequestEventRoadReward(SERVER, RELIABLESEND, eventSEQ, rewardIdList);
        }

        public void RequestEventRoadSelect(int eventSEQ, byte type)
        {
            SendProxy.CG_RequestEventRoadSelect(SERVER, RELIABLESEND, eventSEQ, type);
        }

        public void RequestEventGambleBoxInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventGambleBoxInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventGambleBoxPickup(int eventSEQ, int count)
        {
            SendProxy.CG_RequestEventGambleBoxPickup(SERVER, RELIABLESEND, eventSEQ, count);
        }

        public void RequestEventGambleBoxReset(int eventSEQ)
        {
            SendProxy.CG_RequestEventGambleBoxReset(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventConquestInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventConquestInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventConquestProductionDepotCompleteReward(int eventSEQ, int depotIndex)
        {
            SendProxy.CG_RequestEventConquestProductionDepotCompleteReward(SERVER, RELIABLESEND, eventSEQ, depotIndex);
        }

        public void RequestEventConquestProductionDepotUpgrade(int eventSEQ, int depotIndex)
        {
            SendProxy.CG_RequestEventConquestProductionDepotUpgrade(SERVER, RELIABLESEND, eventSEQ, depotIndex);
        }

        public void RequestEventConquestProductionDepotUpgradeReward(int eventSEQ, int depotIndex, int rewardIndex)
        {
            SendProxy.CG_RequestEventConquestProductionDepotUpgradeReward(SERVER, RELIABLESEND, eventSEQ, depotIndex, rewardIndex);
        }

        public void RequestEventConquestAreaAttack(int eventSEQ, int areaID, int attackCount)
        {
            SendProxy.CG_RequestEventConquestAreaAttack(SERVER, RELIABLESEND, eventSEQ, areaID, attackCount);
        }

        public void RequestEventConquestAreaFeverAttack(int eventSEQ, int areaID)
        {
            SendProxy.CG_RequestEventConquestAreaFeverAttack(SERVER, RELIABLESEND, eventSEQ, areaID);
        }

        public void RequestEventConquestAreaAttackReward(int eventSEQ, int areaID)
        {
            SendProxy.CG_RequestEventConquestAreaAttackReward(SERVER, RELIABLESEND, eventSEQ, areaID);
        }

        public void RequestEventConquestMakeFeverItem(int eventSEQ, int count)
        {
            SendProxy.CG_RequestEventConquestMakeFeverItem(SERVER, RELIABLESEND, eventSEQ, count);
        }

        public void RequestEventConquestUpdateSceneIndex(int eventSEQ, int sceneIndex)
        {
            SendProxy.CG_RequestEventConquestUpdateSceneIndex(SERVER, RELIABLESEND, eventSEQ, sceneIndex);
        }

        public void RequestEventConquestUpdateUnitPos(int eventSEQ, int unitID, int areaID)
        {
            SendProxy.CG_RequestEventConquestUpdateUnitPos(SERVER, RELIABLESEND, eventSEQ, unitID, areaID);
        }

        public void RequestGuildOrderMissioInfo()
        {
            SendProxy.CG_RequestGuildOrderMissioInfo(SERVER, RELIABLESEND);
        }

        public void RequestGuildOrderMissionClear(int missionID)
        {
            SendProxy.CG_RequestGuildOrderMissionClear(SERVER, RELIABLESEND, missionID);
        }

        public void RequestGuildOrderAPRewardBox(int groupID)
        {
            SendProxy.CG_RequestGuildOrderAPRewardBox(SERVER, RELIABLESEND, groupID);
        }

        public void RequestGuildOrderMissionMileageBonusReward(int mileageStep)
        {
            SendProxy.CG_RequestGuildOrderMissionMileageBonusReward(SERVER, RELIABLESEND, mileageStep);
        }

        public void RequestHeroLeagueInfo()
        {
            SendProxy.CG_RequestHeroLeagueInfo(SERVER, RELIABLESEND);
        }

        public void RequestHeroLeagueSelectLeague(byte league)
        {
            SendProxy.CG_RequestHeroLeagueSelectLeague(SERVER, RELIABLESEND, league);
        }

        public void RequestHeroLeagueInitialize()
        {
            SendProxy.CG_RequestHeroLeagueInitialize(SERVER, RELIABLESEND);
        }

        public void RequestHeroLeagueInitUserGroup(int userGroup)
        {
            SendProxy.CG_RequestHeroLeagueInitUserGroup(SERVER, RELIABLESEND, userGroup);
        }

        public void RequestHeroLeagueGagueReward()
        {
            SendProxy.CG_RequestHeroLeagueGagueReward(SERVER, RELIABLESEND);
        }

        public void RequestHeroLeagueAttackTeamChange(UserTeamChangeInfo userTeamChangeInfo)
        {
            SendProxy.CG_RequestHeroLeagueAttackTeamChange(SERVER, RELIABLESEND, userTeamChangeInfo);
        }

        public void RequestHeroLeagueStageStart(HeroLeagueStageStartRequestInfo stageStartRequestInfo)
        {
            SendProxy.CG_RequestHeroLeagueStageStart(SERVER, RELIABLESEND, stageStartRequestInfo);
        }

        public void RequestHeroLeagueStageClear(HeroLeagueStageClearRequestInfo stageClearRequestInfo)
        {
            SendProxy.CG_RequestHeroLeagueStageClear(SERVER, RELIABLESEND, stageClearRequestInfo);
        }

        public void RequestHeroLeagueSeasonShopInfo()
        {
            SendProxy.CG_RequestHeroLeagueSeasonShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestHeroLeagueSeasonShopBuy(int seasonID, int shopID, byte buyCount)
        {
            SendProxy.CG_RequestHeroLeagueSeasonShopBuy(SERVER, RELIABLESEND, seasonID, shopID, buyCount);
        }

        public void RequestHeroLeagueStageRejoin(int userGroup, byte teamNumber)
        {
            SendProxy.CG_RequestHeroLeagueStageRejoin(SERVER, RELIABLESEND, userGroup, teamNumber);
        }

        public void RequestHeroLeagueStageRejoinCancel()
        {
            SendProxy.CG_RequestHeroLeagueStageRejoinCancel(SERVER, RELIABLESEND);
        }

        public void RequestHeroLeagueScoreReward(byte rewardIndex)
        {
            SendProxy.CG_RequestHeroLeagueScoreReward(SERVER, RELIABLESEND, rewardIndex);
        }

        public void Request_CreatureColosseum_Season_Info()
        {
            SendProxy.CG_Request_CreatureColosseum_Season_Info(SERVER, RELIABLESEND);
        }

        public void Request_CreatureColosseum_Stage_Start(CreatureNestStageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_Request_CreatureColosseum_Stage_Start(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void Request_CreatureColosseum_Stage_Clear(CreatureNestStageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_Request_CreatureColosseum_Stage_Clear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void Request_CreatureColosseum_Stage_Continue()
        {
            SendProxy.CG_Request_CreatureColosseum_Stage_Continue(SERVER, RELIABLESEND);
        }

        public void Request_CreatureColosseum_Init(int groupID)
        {
            SendProxy.CG_Request_CreatureColosseum_Init(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureColosseum_Team_Save(int groupID)
        {
            SendProxy.CG_Request_CreatureColosseum_Team_Save(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureColosseum_Stage_Rejoin(int groupID)
        {
            SendProxy.CG_Request_CreatureColosseum_Stage_Rejoin(SERVER, RELIABLESEND, groupID);
        }

        public void Request_CreatureColosseum_Stage_Rejoin_Cancel(int groupID)
        {
            SendProxy.CG_Request_CreatureColosseum_Stage_Rejoin_Cancel(SERVER, RELIABLESEND, groupID);
        }

        public void RequestCreatureColosseumShopInfo()
        {
            SendProxy.CG_RequestCreatureColosseumShopInfo(SERVER, RELIABLESEND);
        }

        public void RequestCreatureColosseumShopBuy(int shopID, byte buyCount)
        {
            SendProxy.CG_RequestCreatureColosseumShopBuy(SERVER, RELIABLESEND, shopID, buyCount);
        }

        public void RequestEventBalloonDartInfo(int eventSEQ)
        {
            SendProxy.CG_RequestEventBalloonDartInfo(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventBalloonDartThrow(int eventSEQ, List<int> throwIndexList)
        {
            SendProxy.CG_RequestEventBalloonDartThrow(SERVER, RELIABLESEND, eventSEQ, throwIndexList);
        }

        public void RequestEventBalloonDartChance(int eventSEQ)
        {
            SendProxy.CG_RequestEventBalloonDartChance(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventBalloonDartStepUp(int eventSEQ)
        {
            SendProxy.CG_RequestEventBalloonDartStepUp(SERVER, RELIABLESEND, eventSEQ);
        }

        public void RequestEventBalloonDartStepReward(int eventSEQ, int rewardId)
        {
            SendProxy.CG_RequestEventBalloonDartStepReward(SERVER, RELIABLESEND, eventSEQ, rewardId);
        }

        public void RequestEventBalloonDartTotalReward(int eventSEQ, int rewardId)
        {
            SendProxy.CG_RequestEventBalloonDartTotalReward(SERVER, RELIABLESEND, eventSEQ, rewardId);
        }

        public void RequestDemonLordStageOpen()
        {
            SendProxy.CG_RequestDemonLordStageOpen(SERVER, RELIABLESEND);
        }

        public void RequestDemonLordStageStart(StageStartRequestInfo startRequestInfo)
        {
            SendProxy.CG_RequestDemonLordStageStart(SERVER, RELIABLESEND, startRequestInfo);
        }

        public void RequestDemonLordStageClear(StageClearRequestInfo clearRequestInfo)
        {
            SendProxy.CG_RequestDemonLordStageClear(SERVER, RELIABLESEND, clearRequestInfo);
        }

        public void RequestDemonLordStageContinue()
        {
            SendProxy.CG_RequestDemonLordStageContinue(SERVER, RELIABLESEND);
        }

        public void RequestDemonLordStageCoinOpen(List<NeedItemInfo> useItemInfoList)
        {
            SendProxy.CG_RequestDemonLordStageCoinOpen(SERVER, RELIABLESEND, useItemInfoList);
        }

        public void RequestChat(ChatMsgType type, string msg, int stampId)
        {
            SendProxy.CG_RequestChat(SERVER, RELIABLESEND, type, msg, stampId);
        }

        public void RequestChatChannelEnter(int channelId)
        {
            SendProxy.CG_RequestChatChannelEnter(SERVER, RELIABLESEND, channelId);
        }
    }
}
