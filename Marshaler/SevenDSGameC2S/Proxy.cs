using Nettention.Proud;

namespace SevenDSGameC2S
{
    public class Proxy : RmiProxy
    {
        public bool CG_RequestChannelUserInfo(HostID remote, RmiContext rmiContext, string netamrblePlayerID, NetmarbleSDKInfo sdkInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestChannelUserInfo);
            CommonPacket.Marshaler.Write(message, netamrblePlayerID);
            CommonPacket.Marshaler.Write(message, sdkInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestChannelUserInfo, Common.CG_RequestChannelUserInfo);
        }

        public bool CG_RequestHeartBeat(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeartBeat);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeartBeat, Common.CG_RequestHeartBeat);
        }

        public bool CG_RequestChangeNickname(HostID remote, RmiContext rmiContext, string nickname)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestChangeNickname);
            CommonPacket.Marshaler.Write(message, nickname);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestChangeNickname, Common.CG_RequestChangeNickname);
        }

        public bool CG_RequestChangeWantToSay(HostID remote, RmiContext rmiContext, string wantToSay)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestChangeWantToSay);
            CommonPacket.Marshaler.Write(message, wantToSay);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestChangeWantToSay, Common.CG_RequestChangeWantToSay);
        }

        public bool CG_RequestTeamInfo(HostID remote, RmiContext rmiContext, byte teamIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTeamInfo);
            CommonPacket.Marshaler.Write(message, teamIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTeamInfo, Common.CG_RequestTeamInfo);
        }

        public bool CG_RequestTeamSlotChange(HostID remote, RmiContext rmiContext, byte teamIndex, List<UserTeamSlot> mainSlotList, int battlePowerPoint, int buffID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTeamSlotChange);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, mainSlotList);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            CommonPacket.Marshaler.Write(message, buffID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTeamSlotChange, Common.CG_RequestTeamSlotChange);
        }

        public bool CG_RequestTeamNameChange(HostID remote, RmiContext rmiContext, byte teamIndex, string name)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTeamNameChange);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, name);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTeamNameChange, Common.CG_RequestTeamNameChange);
        }

        public bool CG_RequestLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyInfo, Common.CG_RequestLobbyInfo);
        }

        public bool CG_RequestBasePointInfo(HostID remote, RmiContext rmiContext, int basePointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointInfo);
            CommonPacket.Marshaler.Write(message, basePointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointInfo, Common.CG_RequestBasePointInfo);
        }

        public bool CG_RequestMercenaryList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMercenaryList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMercenaryList, Common.CG_RequestMercenaryList);
        }

        public bool CG_RequestMercenaryInfo(HostID remote, RmiContext rmiContext, long targetUSN, int skinID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMercenaryInfo);
            CommonPacket.Marshaler.Write(message, targetUSN);
            CommonPacket.Marshaler.Write(message, skinID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMercenaryInfo, Common.CG_RequestMercenaryInfo);
        }

        public bool CG_RequestGuildInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildInfo, Common.CG_RequestGuildInfo);
        }

        public bool CG_RequestChatStampUpdateBookmark(HostID remote, RmiContext rmiContext, byte stampSlot, List<int> stampIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestChatStampUpdateBookmark);
            CommonPacket.Marshaler.Write(message, stampSlot);
            CommonPacket.Marshaler.Write(message, stampIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestChatStampUpdateBookmark, Common.CG_RequestChatStampUpdateBookmark);
        }

        public bool CG_RequestChatStampUpdateQuickMessage(HostID remote, RmiContext rmiContext, byte slotNumber, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestChatStampUpdateQuickMessage);
            CommonPacket.Marshaler.Write(message, slotNumber);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestChatStampUpdateQuickMessage, Common.CG_RequestChatStampUpdateQuickMessage);
        }

        public bool CG_RequestMainSkinChange(HostID remote, RmiContext rmiContext, int targetSkinID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMainSkinChange);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMainSkinChange, Common.CG_RequestMainSkinChange);
        }

        public bool CG_RequestEventList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventList, Common.CG_RequestEventList);
        }

        public bool CG_RequestCheatEnter(HostID remote, RmiContext rmiContext, string messageStr)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCheatEnter);
            CommonPacket.Marshaler.Write(message, messageStr);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCheatEnter, Common.CG_RequestCheatEnter);
        }

        public bool CG_RequestCheatStageClear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCheatStageClear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCheatStageClear, Common.CG_RequestCheatStageClear);
        }

        public bool CG_RequestDllGetItem(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDllGetItem);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDllGetItem, Common.CG_RequestDllGetItem);
        }

        public bool CG_RequestRecommendFriendUSNList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRecommendFriendUSNList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRecommendFriendUSNList, Common.CG_RequestRecommendFriendUSNList);
        }

        public bool CG_RequestDailyReset(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDailyReset);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDailyReset, Common.CG_RequestDailyReset);
        }

        public bool CG_RequestFrozenAssetRedeem(HostID remote, RmiContext rmiContext, int frozenSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFrozenAssetRedeem);
            CommonPacket.Marshaler.Write(message, frozenSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFrozenAssetRedeem, Common.CG_RequestFrozenAssetRedeem);
        }

        public bool CG_RequestDataTableReload(HostID remote, RmiContext rmiContext, ByteArrayInfo dataZipFileInfo, int totalFileSize, bool isFirst, bool isLast)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDataTableReload);
            CommonPacket.Marshaler.Write(message, dataZipFileInfo);
            CommonPacket.Marshaler.Write(message, totalFileSize);
            CommonPacket.Marshaler.Write(message, isFirst);
            CommonPacket.Marshaler.Write(message, isLast);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDataTableReload, Common.CG_RequestDataTableReload);
        }

        public bool CG_RequestRecommendHeroGrowthInfo(HostID remote, RmiContext rmiContext, int heroId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRecommendHeroGrowthInfo);
            CommonPacket.Marshaler.Write(message, heroId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRecommendHeroGrowthInfo, Common.CG_RequestRecommendHeroGrowthInfo);
        }

        public bool CG_RequestServerVersion(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestServerVersion);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestServerVersion, Common.CG_RequestServerVersion);
        }

        public bool CG_RequestSecurityToken(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSecurityToken);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSecurityToken, Common.CG_RequestSecurityToken);
        }

        public bool CG_RequestNetmarbleAuth(HostID remote, RmiContext rmiContext, string netmarblePlayerID, string gametoken, string securityCertValue, int versionNumber, ClientDeviceType deviceType, int signType, NetmarbleSDKInfo sdkInfo, int buildCountry)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestNetmarbleAuth);
            CommonPacket.Marshaler.Write(message, netmarblePlayerID);
            CommonPacket.Marshaler.Write(message, gametoken);
            CommonPacket.Marshaler.Write(message, securityCertValue);
            CommonPacket.Marshaler.Write(message, versionNumber);
            CommonPacket.Marshaler.Write(message, deviceType);
            CommonPacket.Marshaler.Write(message, signType);
            CommonPacket.Marshaler.Write(message, sdkInfo);
            CommonPacket.Marshaler.Write(message, buildCountry);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestNetmarbleAuth, Common.CG_RequestNetmarbleAuth);
        }

        public bool CG_RequestAuthenticateCreate(HostID remote, RmiContext rmiContext, string netmarblePlayerID, NetmarbleSDKInfo sdkInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAuthenticateCreate);
            CommonPacket.Marshaler.Write(message, netmarblePlayerID);
            CommonPacket.Marshaler.Write(message, sdkInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAuthenticateCreate, Common.CG_RequestAuthenticateCreate);
        }

        public bool CG_RequestEditorUserInfoByNickName(HostID remote, RmiContext rmiContext, string nickName)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEditorUserInfoByNickName);
            CommonPacket.Marshaler.Write(message, nickName);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEditorUserInfoByNickName, Common.CG_RequestEditorUserInfoByNickName);
        }

        public bool CG_RequestLogin(HostID remote, RmiContext rmiContext, long usn, NetmarbleSDKInfo sdkInfo, VersionInfo versionInfo, string rejoinData, long clientTimeTick, string patchName, string patchData, LanguageType languageType, int buildCountry)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLogin);
            CommonPacket.Marshaler.Write(message, usn);
            CommonPacket.Marshaler.Write(message, sdkInfo);
            CommonPacket.Marshaler.Write(message, versionInfo);
            CommonPacket.Marshaler.Write(message, rejoinData);
            CommonPacket.Marshaler.Write(message, clientTimeTick);
            CommonPacket.Marshaler.Write(message, patchName);
            CommonPacket.Marshaler.Write(message, patchData);
            CommonPacket.Marshaler.Write(message, languageType);
            CommonPacket.Marshaler.Write(message, buildCountry);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLogin, Common.CG_RequestLogin);
        }

        public bool CG_RequestLoginInstantly(HostID remote, RmiContext rmiContext, long usn, NetmarbleSDKInfo sdkInfo, int sessionKey, VersionInfo versionInfo, string rejoinData, long clientTimeTick, RmiID reconnectRequestRmiID, LanguageType languageType, int talkChannelID, int buildCountry)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLoginInstantly);
            CommonPacket.Marshaler.Write(message, usn);
            CommonPacket.Marshaler.Write(message, sdkInfo);
            CommonPacket.Marshaler.Write(message, sessionKey);
            CommonPacket.Marshaler.Write(message, versionInfo);
            CommonPacket.Marshaler.Write(message, rejoinData);
            CommonPacket.Marshaler.Write(message, clientTimeTick);
            CommonPacket.Marshaler.Write(message, reconnectRequestRmiID);
            CommonPacket.Marshaler.Write(message, languageType);
            CommonPacket.Marshaler.Write(message, talkChannelID);
            CommonPacket.Marshaler.Write(message, buildCountry);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLoginInstantly, Common.CG_RequestLoginInstantly);
        }

        public bool CG_RetryRequest(HostID remote, RmiContext rmiContext, RmiID rmiID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RetryRequest);
            CommonPacket.Marshaler.Write(message, rmiID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RetryRequest, Common.CG_RetryRequest);
        }

        public bool CG_RequestAccountWithdraw(HostID remote, RmiContext rmiContext, string gameToken, string code, string idToken)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAccountWithdraw);
            CommonPacket.Marshaler.Write(message, gameToken);
            CommonPacket.Marshaler.Write(message, code);
            CommonPacket.Marshaler.Write(message, idToken);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAccountWithdraw, Common.CG_RequestAccountWithdraw);
        }

        public bool CG_RequestAccountWithdrawCancel(HostID remote, RmiContext rmiContext, string netmarblePlayerID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAccountWithdrawCancel);
            CommonPacket.Marshaler.Write(message, netmarblePlayerID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAccountWithdrawCancel, Common.CG_RequestAccountWithdrawCancel);
        }

        public bool CG_RequestCookie(HostID remote, RmiContext rmiContext, ByteArrayInfo cookie)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookie);
            CommonPacket.Marshaler.Write(message, cookie);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookie, Common.CG_RequestCookie);
        }

        public bool CG_RequestVerifySecurityCertValue(HostID remote, RmiContext rmiContext, string securityCertValue, ClientDeviceType deviceType, int signType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestVerifySecurityCertValue);
            CommonPacket.Marshaler.Write(message, securityCertValue);
            CommonPacket.Marshaler.Write(message, deviceType);
            CommonPacket.Marshaler.Write(message, signType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestVerifySecurityCertValue, Common.CG_RequestVerifySecurityCertValue);
        }

        public bool CG_RequestBillingInitialize(HostID remote, RmiContext rmiContext, string itemID, string purchaseType, List<int> choicePackageItemList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBillingInitialize);
            CommonPacket.Marshaler.Write(message, itemID);
            CommonPacket.Marshaler.Write(message, purchaseType);
            CommonPacket.Marshaler.Write(message, choicePackageItemList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBillingInitialize, Common.CG_RequestBillingInitialize);
        }

        public bool CG_RequestBillingVerifyPU(HostID remote, RmiContext rmiContext, BillingVerifyRequestInfo verifyRequestInfo, List<int> choicePackageItemList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBillingVerifyPU);
            CommonPacket.Marshaler.Write(message, verifyRequestInfo);
            CommonPacket.Marshaler.Write(message, choicePackageItemList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBillingVerifyPU, Common.CG_RequestBillingVerifyPU);
        }

        public bool CG_RequestBillingRemainTR(HostID remote, RmiContext rmiContext, bool isPurchase, List<string> purchasesJSONString)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBillingRemainTR);
            CommonPacket.Marshaler.Write(message, isPurchase);
            CommonPacket.Marshaler.Write(message, purchasesJSONString);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBillingRemainTR, Common.CG_RequestBillingRemainTR);
        }

        public bool CG_RequestBillingCouponVerify(HostID remote, RmiContext rmiContext, BillingVerifyType verifyType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBillingCouponVerify);
            CommonPacket.Marshaler.Write(message, verifyType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBillingCouponVerify, Common.CG_RequestBillingCouponVerify);
        }

        public bool CG_RequestBillingCrossPromotion(HostID remote, RmiContext rmiContext, BillingVerifyType verifyType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBillingCrossPromotion);
            CommonPacket.Marshaler.Write(message, verifyType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBillingCrossPromotion, Common.CG_RequestBillingCrossPromotion);
        }

        public bool CG_RequestBillingPackageShop(HostID remote, RmiContext rmiContext, int productID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBillingPackageShop);
            CommonPacket.Marshaler.Write(message, productID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBillingPackageShop, Common.CG_RequestBillingPackageShop);
        }

        public bool CG_RequestAgeInput(HostID remote, RmiContext rmiContext, byte ageLevel)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAgeInput);
            CommonPacket.Marshaler.Write(message, ageLevel);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAgeInput, Common.CG_RequestAgeInput);
        }

        public bool CG_RequestSDKInfoChange(HostID remote, RmiContext rmiContext, NetmarbleSDKInfo sdkInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSDKInfoChange);
            CommonPacket.Marshaler.Write(message, sdkInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSDKInfoChange, Common.CG_RequestSDKInfoChange);
        }

        public bool CG_RequestPCBillingInitialize(HostID remote, RmiContext rmiContext, string sku, List<int> choicePackageItemList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPCBillingInitialize);
            CommonPacket.Marshaler.Write(message, sku);
            CommonPacket.Marshaler.Write(message, choicePackageItemList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPCBillingInitialize, Common.CG_RequestPCBillingInitialize);
        }

        public bool CG_RequestPCBillingRemainItems(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPCBillingRemainItems);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPCBillingRemainItems, Common.CG_RequestPCBillingRemainItems);
        }

        public bool CG_RequestSkinLevelUpBySkinMaterial(HostID remote, RmiContext rmiContext, int targetSkinID, List<NeedItemInfo> materialItemList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinLevelUpBySkinMaterial);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, materialItemList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinLevelUpBySkinMaterial, Common.CG_RequestSkinLevelUpBySkinMaterial);
        }

        public bool CG_RequestSkinResearch(HostID remote, RmiContext rmiContext, int targetSkinID, int researchID, byte researchSlot)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinResearch);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, researchID);
            CommonPacket.Marshaler.Write(message, researchSlot);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinResearch, Common.CG_RequestSkinResearch);
        }

        public bool CG_RequestSkinResearchInit(HostID remote, RmiContext rmiContext, int targetSkinID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinResearchInit);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinResearchInit, Common.CG_RequestSkinResearchInit);
        }

        public bool CG_RequestSkinMaterialGrind(HostID remote, RmiContext rmiContext, List<int> skinMaterialIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinMaterialGrind);
            CommonPacket.Marshaler.Write(message, skinMaterialIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinMaterialGrind, Common.CG_RequestSkinMaterialGrind);
        }

        public bool CG_RequestSkinAwaken(HostID remote, RmiContext rmiContext, int targetHeroID, byte awakenIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinAwaken);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            CommonPacket.Marshaler.Write(message, awakenIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinAwaken, Common.CG_RequestSkinAwaken);
        }

        public bool CG_RequestSkinHeadStyleChange(HostID remote, RmiContext rmiContext, int targetSkinID, bool isChanged)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinHeadStyleChange);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, isChanged);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinHeadStyleChange, Common.CG_RequestSkinHeadStyleChange);
        }

        public bool CG_RequestSkinEvolution(HostID remote, RmiContext rmiContext, int targetHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinEvolution);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinEvolution, Common.CG_RequestSkinEvolution);
        }

        public bool CG_RequestSkinSkillLevelUp(HostID remote, RmiContext rmiContext, int targetHeroID, byte skillLevelUpCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinSkillLevelUp);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            CommonPacket.Marshaler.Write(message, skillLevelUpCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinSkillLevelUp, Common.CG_RequestSkinSkillLevelUp);
        }

        public bool CG_RequestSkinGiveFellowshipExp(HostID remote, RmiContext rmiContext, int targetHeroID, List<NeedItemInfo> useItemInfoList, bool IsADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinGiveFellowshipExp);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            CommonPacket.Marshaler.Write(message, useItemInfoList);
            CommonPacket.Marshaler.Write(message, IsADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinGiveFellowshipExp, Common.CG_RequestSkinGiveFellowshipExp);
        }

        public bool CG_RequestSkinFellowshipLevelUpReward(HostID remote, RmiContext rmiContext, int heroID, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinFellowshipLevelUpReward);
            CommonPacket.Marshaler.Write(message, heroID);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinFellowshipLevelUpReward, Common.CG_RequestSkinFellowshipLevelUpReward);
        }

        public bool CG_RequestCostumeEquip(HostID remote, RmiContext rmiContext, int costumeID, int targetHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeEquip);
            CommonPacket.Marshaler.Write(message, costumeID);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeEquip, Common.CG_RequestCostumeEquip);
        }

        public bool CG_RequestCostumeUnEquip(HostID remote, RmiContext rmiContext, int costumeID, int targetHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeUnEquip);
            CommonPacket.Marshaler.Write(message, costumeID);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeUnEquip, Common.CG_RequestCostumeUnEquip);
        }

        public bool CG_RequestCostumeUnLock(HostID remote, RmiContext rmiContext, List<int> targetHeroIDList, List<int> costumeGroupIDList, List<int> targetHeroGroupIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeUnLock);
            CommonPacket.Marshaler.Write(message, targetHeroIDList);
            CommonPacket.Marshaler.Write(message, costumeGroupIDList);
            CommonPacket.Marshaler.Write(message, targetHeroGroupIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeUnLock, Common.CG_RequestCostumeUnLock);
        }

        public bool CG_RequestSkinOverEvolution(HostID remote, RmiContext rmiContext, int targetHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinOverEvolution);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinOverEvolution, Common.CG_RequestSkinOverEvolution);
        }

        public bool CG_RequestSkinMaxAwakenReward(HostID remote, RmiContext rmiContext, int targetHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinMaxAwakenReward);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinMaxAwakenReward, Common.CG_RequestSkinMaxAwakenReward);
        }

        public bool CG_RequestCostumeRegister(HostID remote, RmiContext rmiContext, int targetSkinID, int targetCostumeID, byte slotIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeRegister);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, targetCostumeID);
            CommonPacket.Marshaler.Write(message, slotIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeRegister, Common.CG_RequestCostumeRegister);
        }

        public bool CG_RequestSkinLoveReward(HostID remote, RmiContext rmiContext, byte rewardSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinLoveReward);
            CommonPacket.Marshaler.Write(message, rewardSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinLoveReward, Common.CG_RequestSkinLoveReward);
        }

        public bool CG_RequestCostumeAutoRegister(HostID remote, RmiContext rmiContext, List<CostumeAutoRegisterInfo> registerInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeAutoRegister);
            CommonPacket.Marshaler.Write(message, registerInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeAutoRegister, Common.CG_RequestCostumeAutoRegister);
        }

        public bool CG_RequestStoryCostume(HostID remote, RmiContext rmiContext, List<int> idList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestStoryCostume);
            CommonPacket.Marshaler.Write(message, idList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestStoryCostume, Common.CG_RequestStoryCostume);
        }

        public bool CG_RequestCostumeLevelUp(HostID remote, RmiContext rmiContext, int costumeID, int levelUpCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeLevelUp);
            CommonPacket.Marshaler.Write(message, costumeID);
            CommonPacket.Marshaler.Write(message, levelUpCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeLevelUp, Common.CG_RequestCostumeLevelUp);
        }

        public bool CG_RequestSkinMaxAwaken(HostID remote, RmiContext rmiContext, int targetHeroID, int useItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinMaxAwaken);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            CommonPacket.Marshaler.Write(message, useItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinMaxAwaken, Common.CG_RequestSkinMaxAwaken);
        }

        public bool CG_RequestBattlePointRegister(HostID remote, RmiContext rmiContext, int battlePoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBattlePointRegister);
            CommonPacket.Marshaler.Write(message, battlePoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBattlePointRegister, Common.CG_RequestBattlePointRegister);
        }

        public bool CG_RequestSkinTranscend(HostID remote, RmiContext rmiContext, int targetHeroId, byte transcendIndex, List<NeedItemInfo> useItemInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinTranscend);
            CommonPacket.Marshaler.Write(message, targetHeroId);
            CommonPacket.Marshaler.Write(message, transcendIndex);
            CommonPacket.Marshaler.Write(message, useItemInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinTranscend, Common.CG_RequestSkinTranscend);
        }

        public bool CG_RequestSkinTranscendReset(HostID remote, RmiContext rmiContext, int targetHeroId, byte useItemIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinTranscendReset);
            CommonPacket.Marshaler.Write(message, targetHeroId);
            CommonPacket.Marshaler.Write(message, useItemIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinTranscendReset, Common.CG_RequestSkinTranscendReset);
        }

        public bool CG_RequestCostumeCraft(HostID remote, RmiContext rmiContext, int costumeId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeCraft);
            CommonPacket.Marshaler.Write(message, costumeId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeCraft, Common.CG_RequestCostumeCraft);
        }

        public bool CG_RequestLimitedCostumeCheck(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLimitedCostumeCheck);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLimitedCostumeCheck, Common.CG_RequestLimitedCostumeCheck);
        }

        public bool CG_RequestGetExclusiveSkill(HostID remote, RmiContext rmiContext, int heroId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGetExclusiveSkill);
            CommonPacket.Marshaler.Write(message, heroId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGetExclusiveSkill, Common.CG_RequestGetExclusiveSkill);
        }

        public bool CG_RequestSkinOneStepEvolution(HostID remote, RmiContext rmiContext, int heroId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinOneStepEvolution);
            CommonPacket.Marshaler.Write(message, heroId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinOneStepEvolution, Common.CG_RequestSkinOneStepEvolution);
        }

        public bool CG_RequestSkinOverEvolutionStraight(HostID remote, RmiContext rmiContext, int targetHeroID, byte targetMaxLevelCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinOverEvolutionStraight);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            CommonPacket.Marshaler.Write(message, targetMaxLevelCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinOverEvolutionStraight, Common.CG_RequestSkinOverEvolutionStraight);
        }

        public bool CG_RequestSkinLegendEvolution(HostID remote, RmiContext rmiContext, int heroId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinLegendEvolution);
            CommonPacket.Marshaler.Write(message, heroId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinLegendEvolution, Common.CG_RequestSkinLegendEvolution);
        }

        public bool CG_RequestCostumeCraftUpgrade(HostID remote, RmiContext rmiContext, int costumeId, List<CostumeCraftUpgradeInfo> upgradeInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeCraftUpgrade);
            CommonPacket.Marshaler.Write(message, costumeId);
            CommonPacket.Marshaler.Write(message, upgradeInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeCraftUpgrade, Common.CG_RequestCostumeCraftUpgrade);
        }

        public bool CG_RequestSkinLevelupBonus(HostID remote, RmiContext rmiContext, int heroId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinLevelupBonus);
            CommonPacket.Marshaler.Write(message, heroId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinLevelupBonus, Common.CG_RequestSkinLevelupBonus);
        }

        public bool CG_RequestSkinExceed(HostID remote, RmiContext rmiContext, int heroId, byte exceedIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSkinExceed);
            CommonPacket.Marshaler.Write(message, heroId);
            CommonPacket.Marshaler.Write(message, exceedIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSkinExceed, Common.CG_RequestSkinExceed);
        }

        public bool CG_RequestWeaponEquip(HostID remote, RmiContext rmiContext, int targetSkinID, int weaponSerial, int slotNumber, bool isDelete)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponEquip);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, weaponSerial);
            CommonPacket.Marshaler.Write(message, slotNumber);
            CommonPacket.Marshaler.Write(message, isDelete);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponEquip, Common.CG_RequestWeaponEquip);
        }

        public bool CG_RequestWeaponUnEquip(HostID remote, RmiContext rmiContext, int targetSkinID, int slotNumber)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponUnEquip);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, slotNumber);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponUnEquip, Common.CG_RequestWeaponUnEquip);
        }

        public bool CG_RequestWeaponSell(HostID remote, RmiContext rmiContext, List<int> selectWeaponSerialList, ItemSellType itemSellType, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponSell);
            CommonPacket.Marshaler.Write(message, selectWeaponSerialList);
            CommonPacket.Marshaler.Write(message, itemSellType);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponSell, Common.CG_RequestWeaponSell);
        }

        public bool CG_RequestWeaponGrind(HostID remote, RmiContext rmiContext, List<int> selectWeaponSerialList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponGrind);
            CommonPacket.Marshaler.Write(message, selectWeaponSerialList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponGrind, Common.CG_RequestWeaponGrind);
        }

        public bool CG_RequestWeaponUpgrade(HostID remote, RmiContext rmiContext, int targetWeaponSerial, short useFailGauge)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponUpgrade);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, useFailGauge);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponUpgrade, Common.CG_RequestWeaponUpgrade);
        }

        public bool CG_RequestWeaponUpgradeRetry(HostID remote, RmiContext rmiContext, int targetWeaponSerial, int useItemId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponUpgradeRetry);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, useItemId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponUpgradeRetry, Common.CG_RequestWeaponUpgradeRetry);
        }

        public bool CG_RequestWeaponEvolution(HostID remote, RmiContext rmiContext, int targetWeaponSerial)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponEvolution);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponEvolution, Common.CG_RequestWeaponEvolution);
        }

        public bool CG_RequestWeaponEvolutionRetry(HostID remote, RmiContext rmiContext, int targetWeaponSerial, int optionSlotIndex, int needItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponEvolutionRetry);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, optionSlotIndex);
            CommonPacket.Marshaler.Write(message, needItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponEvolutionRetry, Common.CG_RequestWeaponEvolutionRetry);
        }

        public bool CG_RequestWeaponOptionEnhance(HostID remote, RmiContext rmiContext, int targetWeaponSerial, int optionSlotIndex, byte enhanceType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponOptionEnhance);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, optionSlotIndex);
            CommonPacket.Marshaler.Write(message, enhanceType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponOptionEnhance, Common.CG_RequestWeaponOptionEnhance);
        }

        public bool CG_RequestWeaponLock(HostID remote, RmiContext rmiContext, int targetWeaponSerial)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponLock);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponLock, Common.CG_RequestWeaponLock);
        }

        public bool CG_RequestWeaponUnLock(HostID remote, RmiContext rmiContext, int targetWeaponSerial)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponUnLock);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponUnLock, Common.CG_RequestWeaponUnLock);
        }

        public bool CG_RequestWeaponEquipExchange(HostID remote, RmiContext rmiContext, int pickedWeaponSerial, int pickedSkinID, int targetWeaponSerial, int targetSkinID, int slotNumber, bool isDelete)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponEquipExchange);
            CommonPacket.Marshaler.Write(message, pickedWeaponSerial);
            CommonPacket.Marshaler.Write(message, pickedSkinID);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, slotNumber);
            CommonPacket.Marshaler.Write(message, isDelete);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponEquipExchange, Common.CG_RequestWeaponEquipExchange);
        }

        public bool CG_RequestWeaponEquipExchangeAll(HostID remote, RmiContext rmiContext, int targetSkinID, int srcSkinID, WeaponExchangeMode exchangeMode)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponEquipExchangeAll);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, srcSkinID);
            CommonPacket.Marshaler.Write(message, exchangeMode);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponEquipExchangeAll, Common.CG_RequestWeaponEquipExchangeAll);
        }

        public bool CG_RequestWeaponEquipRecommand(HostID remote, RmiContext rmiContext, int targetSkinID, List<int> weaponSerialList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponEquipRecommand);
            CommonPacket.Marshaler.Write(message, targetSkinID);
            CommonPacket.Marshaler.Write(message, weaponSerialList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponEquipRecommand, Common.CG_RequestWeaponEquipRecommand);
        }

        public bool CG_RequestWeaponCarve(HostID remote, RmiContext rmiContext, int eventSeq, int targetWeaponSerial, byte heroGroup)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponCarve);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, heroGroup);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponCarve, Common.CG_RequestWeaponCarve);
        }

        public bool CG_RequestWeaponCarveRemove(HostID remote, RmiContext rmiContext, int eventSeq, int targetWeaponSerial)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponCarveRemove);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponCarveRemove, Common.CG_RequestWeaponCarveRemove);
        }

        public bool CG_RequestWeaponUpgradeAndEvolution(HostID remote, RmiContext rmiContext, int targetWeaponSerial, short upgradeCount, short evolutionCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponUpgradeAndEvolution);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, upgradeCount);
            CommonPacket.Marshaler.Write(message, evolutionCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponUpgradeAndEvolution, Common.CG_RequestWeaponUpgradeAndEvolution);
        }

        public bool CG_RequestWeaponAutoOptionChange(HostID remote, RmiContext rmiContext, int targetWeaponSerial, List<UserWeaponPassiveSkill> targetOptionList, List<int> slotNumberList, int costItemID, int costItemID2)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponAutoOptionChange);
            CommonPacket.Marshaler.Write(message, targetWeaponSerial);
            CommonPacket.Marshaler.Write(message, targetOptionList);
            CommonPacket.Marshaler.Write(message, slotNumberList);
            CommonPacket.Marshaler.Write(message, costItemID);
            CommonPacket.Marshaler.Write(message, costItemID2);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponAutoOptionChange, Common.CG_RequestWeaponAutoOptionChange);
        }

        public bool CG_RequestStageInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestStageInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestStageInfo, Common.CG_RequestStageInfo);
        }

        public bool CG_RequestStageRejoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestStageRejoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestStageRejoin, Common.CG_RequestStageRejoin);
        }

        public bool CG_Request_Week_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo weekStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_Stage_Start);
            CommonPacket.Marshaler.Write(message, weekStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_Stage_Start, Common.CG_Request_Week_Stage_Start);
        }

        public bool CG_Request_Week_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo weekStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_Stage_Clear);
            CommonPacket.Marshaler.Write(message, weekStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_Stage_Clear, Common.CG_Request_Week_Stage_Clear);
        }

        public bool CG_Request_Week_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_Stage_Continue, Common.CG_Request_Week_Stage_Continue);
        }

        public bool CG_Request_Main_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_Stage_Start, Common.CG_Request_Main_Stage_Start);
        }

        public bool CG_Request_Main_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_Stage_Clear, Common.CG_Request_Main_Stage_Clear);
        }

        public bool CG_Request_Main_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_Stage_Continue, Common.CG_Request_Main_Stage_Continue);
        }

        public bool CG_Request_Free_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo freeStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_Stage_Start);
            CommonPacket.Marshaler.Write(message, freeStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_Stage_Start, Common.CG_Request_Free_Stage_Start);
        }

        public bool CG_Request_Free_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo freeStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_Stage_Clear);
            CommonPacket.Marshaler.Write(message, freeStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_Stage_Clear, Common.CG_Request_Free_Stage_Clear);
        }

        public bool CG_Request_Free_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_Stage_Continue, Common.CG_Request_Free_Stage_Continue);
        }

        public bool CG_RequestHawkRunStageStart(HostID remote, RmiContext rmiContext, int stageID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHawkRunStageStart);
            CommonPacket.Marshaler.Write(message, stageID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHawkRunStageStart, Common.CG_RequestHawkRunStageStart);
        }

        public bool CG_RequestHawkRunStageClear(HostID remote, RmiContext rmiContext, int stageID, bool isClear, int getGold)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHawkRunStageClear);
            CommonPacket.Marshaler.Write(message, stageID);
            CommonPacket.Marshaler.Write(message, isClear);
            CommonPacket.Marshaler.Write(message, getGold);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHawkRunStageClear, Common.CG_RequestHawkRunStageClear);
        }

        public bool CG_RequestEventStageClear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventStageClear);
            CommonPacket.Marshaler.Write(message, eventStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventStageClear, Common.CG_RequestEventStageClear);
        }

        public bool CG_Request_Quest_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo questStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Quest_Stage_Start);
            CommonPacket.Marshaler.Write(message, questStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Quest_Stage_Start, Common.CG_Request_Quest_Stage_Start);
        }

        public bool CG_Request_Quest_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo questStageClearRequestInfo, byte propIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Quest_Stage_Clear);
            CommonPacket.Marshaler.Write(message, questStageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, propIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Quest_Stage_Clear, Common.CG_Request_Quest_Stage_Clear);
        }

        public bool CG_Request_Quest_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Quest_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Quest_Stage_Continue, Common.CG_Request_Quest_Stage_Continue);
        }

        public bool CG_Request_Boss_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo bossStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_Stage_Start);
            CommonPacket.Marshaler.Write(message, bossStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_Stage_Start, Common.CG_Request_Boss_Stage_Start);
        }

        public bool CG_Request_Boss_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo bossClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_Stage_Clear);
            CommonPacket.Marshaler.Write(message, bossClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_Stage_Clear, Common.CG_Request_Boss_Stage_Clear);
        }

        public bool CG_Request_Boss_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_Stage_Continue, Common.CG_Request_Boss_Stage_Continue);
        }

        public bool CG_Request_Memorial_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo memorialStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Memorial_Stage_Start);
            CommonPacket.Marshaler.Write(message, memorialStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Memorial_Stage_Start, Common.CG_Request_Memorial_Stage_Start);
        }

        public bool CG_Request_Memorial_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo memorialStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Memorial_Stage_Clear);
            CommonPacket.Marshaler.Write(message, memorialStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Memorial_Stage_Clear, Common.CG_Request_Memorial_Stage_Clear);
        }

        public bool CG_Request_Memorial_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Memorial_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Memorial_Stage_Continue, Common.CG_Request_Memorial_Stage_Continue);
        }

        public bool CG_Request_Limited_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo limitedStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Limited_Stage_Start);
            CommonPacket.Marshaler.Write(message, limitedStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Limited_Stage_Start, Common.CG_Request_Limited_Stage_Start);
        }

        public bool CG_Request_Limited_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo limitedStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Limited_Stage_Clear);
            CommonPacket.Marshaler.Write(message, limitedStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Limited_Stage_Clear, Common.CG_Request_Limited_Stage_Clear);
        }

        public bool CG_Request_Limited_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Limited_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Limited_Stage_Continue, Common.CG_Request_Limited_Stage_Continue);
        }

        public bool CG_Request_Main_ExtraStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo extraMainStageStartInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_ExtraStage_Start);
            CommonPacket.Marshaler.Write(message, extraMainStageStartInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_ExtraStage_Start, Common.CG_Request_Main_ExtraStage_Start);
        }

        public bool CG_Request_Main_ExtraStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo extraMainStageClearInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_ExtraStage_Clear);
            CommonPacket.Marshaler.Write(message, extraMainStageClearInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_ExtraStage_Clear, Common.CG_Request_Main_ExtraStage_Clear);
        }

        public bool CG_Request_Main_ExtraStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_ExtraStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_ExtraStage_Continue, Common.CG_Request_Main_ExtraStage_Continue);
        }

        public bool CG_Request_Boss_ExtraStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo extraBossStageStartInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_ExtraStage_Start);
            CommonPacket.Marshaler.Write(message, extraBossStageStartInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_ExtraStage_Start, Common.CG_Request_Boss_ExtraStage_Start);
        }

        public bool CG_Request_Boss_ExtraStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo extraBossStageClearInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_ExtraStage_Clear);
            CommonPacket.Marshaler.Write(message, extraBossStageClearInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_ExtraStage_Clear, Common.CG_Request_Boss_ExtraStage_Clear);
        }

        public bool CG_Request_Boss_ExtraStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_ExtraStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_ExtraStage_Continue, Common.CG_Request_Boss_ExtraStage_Continue);
        }

        public bool CG_RequestRewardStageClear(HostID remote, RmiContext rmiContext, int stageID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRewardStageClear);
            CommonPacket.Marshaler.Write(message, stageID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRewardStageClear, Common.CG_RequestRewardStageClear);
        }

        public bool CG_Request_SingleSiege_ExtraStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo extraSingleSiegeStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_SingleSiege_ExtraStage_Start);
            CommonPacket.Marshaler.Write(message, extraSingleSiegeStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_SingleSiege_ExtraStage_Start, Common.CG_Request_SingleSiege_ExtraStage_Start);
        }

        public bool CG_Request_SingleSiege_ExtraStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo extraSingleSiegeStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_SingleSiege_ExtraStage_Clear);
            CommonPacket.Marshaler.Write(message, extraSingleSiegeStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_SingleSiege_ExtraStage_Clear, Common.CG_Request_SingleSiege_ExtraStage_Clear);
        }

        public bool CG_Request_SingleSiege_ExtraStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_SingleSiege_ExtraStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_SingleSiege_ExtraStage_Continue, Common.CG_Request_SingleSiege_ExtraStage_Continue);
        }

        public bool CG_Request_FinalBoss_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Stage_Start, Common.CG_Request_FinalBoss_Stage_Start);
        }

        public bool CG_Request_FinalBoss_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest, List<StatUserSkin> statUserSkinList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, ingameBattlePointRequest);
            CommonPacket.Marshaler.Write(message, statUserSkinList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Stage_Clear, Common.CG_Request_FinalBoss_Stage_Clear);
        }

        public bool CG_Request_FinalBoss_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Stage_Continue, Common.CG_Request_FinalBoss_Stage_Continue);
        }

        public bool CG_Request_FinalBoss_Season_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Season_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Season_Info, Common.CG_Request_FinalBoss_Season_Info);
        }

        public bool CG_Request_Training_Stage_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Training_Stage_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Training_Stage_Info, Common.CG_Request_Training_Stage_Info);
        }

        public bool CG_Request_Training_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Training_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Training_Stage_Start, Common.CG_Request_Training_Stage_Start);
        }

        public bool CG_Request_Training_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Training_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Training_Stage_Clear, Common.CG_Request_Training_Stage_Clear);
        }

        public bool CG_Request_Training_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Training_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Training_Stage_Continue, Common.CG_Request_Training_Stage_Continue);
        }

        public bool CG_Request_Training_Stage_Open(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Training_Stage_Open);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Training_Stage_Open, Common.CG_Request_Training_Stage_Open);
        }

        public bool CG_Request_Training_Stage_Refresh(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Training_Stage_Refresh);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Training_Stage_Refresh, Common.CG_Request_Training_Stage_Refresh);
        }

        public bool CG_Request_GuildBoss_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo, List<int> useSkinIDList, short guildBossSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            CommonPacket.Marshaler.Write(message, useSkinIDList);
            CommonPacket.Marshaler.Write(message, guildBossSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_Stage_Start, Common.CG_Request_GuildBoss_Stage_Start);
        }

        public bool CG_Request_GuildBoss_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest, List<StatUserSkin> statUserSkinList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, ingameBattlePointRequest);
            CommonPacket.Marshaler.Write(message, statUserSkinList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_Stage_Clear, Common.CG_Request_GuildBoss_Stage_Clear);
        }

        public bool CG_Request_GuildBoss_Lobby_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_Lobby_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_Lobby_Info, Common.CG_Request_GuildBoss_Lobby_Info);
        }

        public bool CG_Request_GuildBoss_Rank_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_Rank_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_Rank_Info, Common.CG_Request_GuildBoss_Rank_Info);
        }

        public bool CG_Request_GuildBoss_LastWeek_Rank_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_LastWeek_Rank_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_LastWeek_Rank_Info, Common.CG_Request_GuildBoss_LastWeek_Rank_Info);
        }

        public bool CG_Request_GuildBoss_Time_Refresh(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_Time_Refresh);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_Time_Refresh, Common.CG_Request_GuildBoss_Time_Refresh);
        }

        public bool CG_Request_AnotherMain_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_AnotherMain_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_AnotherMain_Stage_Start, Common.CG_Request_AnotherMain_Stage_Start);
        }

        public bool CG_Request_AnotherMain_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_AnotherMain_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_AnotherMain_Stage_Clear, Common.CG_Request_AnotherMain_Stage_Clear);
        }

        public bool CG_Request_AnotherMain_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_AnotherMain_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_AnotherMain_Stage_Continue, Common.CG_Request_AnotherMain_Stage_Continue);
        }

        public bool CG_Request_FinalBoss_Season_Rank_Info(HostID remote, RmiContext rmiContext, int seasonID, int bossGroupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Season_Rank_Info);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, bossGroupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Season_Rank_Info, Common.CG_Request_FinalBoss_Season_Rank_Info);
        }

        public bool CG_Request_Reverse_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Reverse_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Reverse_Stage_Start, Common.CG_Request_Reverse_Stage_Start);
        }

        public bool CG_Request_Reverse_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Reverse_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Reverse_Stage_Clear, Common.CG_Request_Reverse_Stage_Clear);
        }

        public bool CG_Request_Reverse_Star_Reward(HostID remote, RmiContext rmiContext, short seasonID, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Reverse_Star_Reward);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Reverse_Star_Reward, Common.CG_Request_Reverse_Star_Reward);
        }

        public bool CG_Request_Reverse_Group_Reward(HostID remote, RmiContext rmiContext, short rewardID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Reverse_Group_Reward);
            CommonPacket.Marshaler.Write(message, rewardID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Reverse_Group_Reward, Common.CG_Request_Reverse_Group_Reward);
        }

        public bool CG_Request_Tower_Stage_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Tower_Stage_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Tower_Stage_Info, Common.CG_Request_Tower_Stage_Info);
        }

        public bool CG_Request_Tower_Stage_Set_Play_Deck(HostID remote, RmiContext rmiContext, List<int> heroIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Tower_Stage_Set_Play_Deck);
            CommonPacket.Marshaler.Write(message, heroIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Tower_Stage_Set_Play_Deck, Common.CG_Request_Tower_Stage_Set_Play_Deck);
        }

        public bool CG_Request_Tower_Stage_Reset(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Tower_Stage_Reset);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Tower_Stage_Reset, Common.CG_Request_Tower_Stage_Reset);
        }

        public bool CG_Request_Tower_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Tower_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Tower_Stage_Start, Common.CG_Request_Tower_Stage_Start);
        }

        public bool CG_Request_Tower_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo, bool isGiveUp)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Tower_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, isGiveUp);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Tower_Stage_Clear, Common.CG_Request_Tower_Stage_Clear);
        }

        public bool CG_Request_FinalBoss_Score_Reward(HostID remote, RmiContext rmiContext, int seasonID, int bossGroupID, int rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Score_Reward);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, bossGroupID);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Score_Reward, Common.CG_Request_FinalBoss_Score_Reward);
        }

        public bool CG_Request_GuildBoss_Off_Season_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo, short guildBossSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_Off_Season_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            CommonPacket.Marshaler.Write(message, guildBossSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_Off_Season_Stage_Start, Common.CG_Request_GuildBoss_Off_Season_Stage_Start);
        }

        public bool CG_Request_GuildBoss_Off_Season_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_Off_Season_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, ingameBattlePointRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_Off_Season_Stage_Clear, Common.CG_Request_GuildBoss_Off_Season_Stage_Clear);
        }

        public bool CG_Request_Disaster_Tower_Stage_Info(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Tower_Stage_Info);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Tower_Stage_Info, Common.CG_Request_Disaster_Tower_Stage_Info);
        }

        public bool CG_Request_Disaster_Tower_Stage_Set_Play_Deck(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> heroIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Tower_Stage_Set_Play_Deck);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, heroIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Tower_Stage_Set_Play_Deck, Common.CG_Request_Disaster_Tower_Stage_Set_Play_Deck);
        }

        public bool CG_Request_Disaster_Tower_Stage_Reset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Tower_Stage_Reset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Tower_Stage_Reset, Common.CG_Request_Disaster_Tower_Stage_Reset);
        }

        public bool CG_Request_Disaster_Tower_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Tower_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Tower_Stage_Start, Common.CG_Request_Disaster_Tower_Stage_Start);
        }

        public bool CG_Request_Disaster_Tower_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo, bool isGiveUp)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Tower_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, isGiveUp);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Tower_Stage_Clear, Common.CG_Request_Disaster_Tower_Stage_Clear);
        }

        public bool CG_Request_FinalBoss_Stage_Fame_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Stage_Fame_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Stage_Fame_Start, Common.CG_Request_FinalBoss_Stage_Fame_Start);
        }

        public bool CG_Request_FinalBoss_Stage_Fame_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest, int fameID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Stage_Fame_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, ingameBattlePointRequest);
            CommonPacket.Marshaler.Write(message, fameID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Stage_Fame_Clear, Common.CG_Request_FinalBoss_Stage_Fame_Clear);
        }

        public bool CG_Request_FinalBoss_Stage_Fame_Season_Rank_Info(HostID remote, RmiContext rmiContext, int fameId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Stage_Fame_Season_Rank_Info);
            CommonPacket.Marshaler.Write(message, fameId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Stage_Fame_Season_Rank_Info, Common.CG_Request_FinalBoss_Stage_Fame_Season_Rank_Info);
        }

        public bool CG_Request_FinalBoss_Stage_Fame_MyScoreInfo(HostID remote, RmiContext rmiContext, int fameID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_Stage_Fame_MyScoreInfo);
            CommonPacket.Marshaler.Write(message, fameID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_Stage_Fame_MyScoreInfo, Common.CG_Request_FinalBoss_Stage_Fame_MyScoreInfo);
        }

        public bool CG_Request_Main_EventAreaStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventAreaMainStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_EventAreaStage_Start);
            CommonPacket.Marshaler.Write(message, eventAreaMainStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_EventAreaStage_Start, Common.CG_Request_Main_EventAreaStage_Start);
        }

        public bool CG_Request_Main_EventAreaStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventAreaMainStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_EventAreaStage_Clear);
            CommonPacket.Marshaler.Write(message, eventAreaMainStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_EventAreaStage_Clear, Common.CG_Request_Main_EventAreaStage_Clear);
        }

        public bool CG_Request_Main_EventAreaStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_EventAreaStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_EventAreaStage_Continue, Common.CG_Request_Main_EventAreaStage_Continue);
        }

        public bool CG_Request_Free_EventAreaStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventAreaFreeStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_EventAreaStage_Start);
            CommonPacket.Marshaler.Write(message, eventAreaFreeStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_EventAreaStage_Start, Common.CG_Request_Free_EventAreaStage_Start);
        }

        public bool CG_Request_Free_EventAreaStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventAreaFreeStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_EventAreaStage_Clear);
            CommonPacket.Marshaler.Write(message, eventAreaFreeStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_EventAreaStage_Clear, Common.CG_Request_Free_EventAreaStage_Clear);
        }

        public bool CG_Request_Free_EventAreaStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_EventAreaStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_EventAreaStage_Continue, Common.CG_Request_Free_EventAreaStage_Continue);
        }

        public bool CG_RequestEventAreaRewardStageClear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventAreaRewardStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventAreaRewardStageClear);
            CommonPacket.Marshaler.Write(message, eventAreaRewardStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventAreaRewardStageClear, Common.CG_RequestEventAreaRewardStageClear);
        }

        public bool CG_Request_Free_EventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventFreeStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_EventStage_Start);
            CommonPacket.Marshaler.Write(message, eventFreeStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_EventStage_Start, Common.CG_Request_Free_EventStage_Start);
        }

        public bool CG_Request_Free_EventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventFreeStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, eventFreeStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_EventStage_Clear, Common.CG_Request_Free_EventStage_Clear);
        }

        public bool CG_Request_Free_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_EventStage_Continue, Common.CG_Request_Free_EventStage_Continue);
        }

        public bool CG_RequestEventExchange(HostID remote, RmiContext rmiContext, int eventSEQ, int exchangeID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchange);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, exchangeID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchange, Common.CG_RequestEventExchange);
        }

        public bool CG_RequestEventPlayCountReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPlayCountReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPlayCountReward, Common.CG_RequestEventPlayCountReward);
        }

        public bool CG_Request_Main_ListEventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventListMainStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_ListEventStage_Start);
            CommonPacket.Marshaler.Write(message, eventListMainStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_ListEventStage_Start, Common.CG_Request_Main_ListEventStage_Start);
        }

        public bool CG_Request_Main_ListEventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventListMainStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_ListEventStage_Clear);
            CommonPacket.Marshaler.Write(message, eventListMainStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_ListEventStage_Clear, Common.CG_Request_Main_ListEventStage_Clear);
        }

        public bool CG_Request_Main_ListEventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Main_ListEventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Main_ListEventStage_Continue, Common.CG_Request_Main_ListEventStage_Continue);
        }

        public bool CG_Request_Free_ListEventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventListFreeStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_ListEventStage_Start);
            CommonPacket.Marshaler.Write(message, eventListFreeStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_ListEventStage_Start, Common.CG_Request_Free_ListEventStage_Start);
        }

        public bool CG_Request_Free_ListEventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventListFreeStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_ListEventStage_Clear);
            CommonPacket.Marshaler.Write(message, eventListFreeStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_ListEventStage_Clear, Common.CG_Request_Free_ListEventStage_Clear);
        }

        public bool CG_Request_Free_ListEventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_ListEventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_ListEventStage_Continue, Common.CG_Request_Free_ListEventStage_Continue);
        }

        public bool CG_Request_FinalBoss_EventMainStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventFinalBossMainStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_EventMainStage_Start);
            CommonPacket.Marshaler.Write(message, eventFinalBossMainStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_EventMainStage_Start, Common.CG_Request_FinalBoss_EventMainStage_Start);
        }

        public bool CG_Request_FinalBoss_EventMainStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventFinalBossMainStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_EventMainStage_Clear);
            CommonPacket.Marshaler.Write(message, eventFinalBossMainStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_EventMainStage_Clear, Common.CG_Request_FinalBoss_EventMainStage_Clear);
        }

        public bool CG_Request_FinalBoss_EventMainStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_EventMainStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_EventMainStage_Continue, Common.CG_Request_FinalBoss_EventMainStage_Continue);
        }

        public bool CG_Request_FinalBoss_EventFreeStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventFinalBossFreeStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_EventFreeStage_Start);
            CommonPacket.Marshaler.Write(message, eventFinalBossFreeStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_EventFreeStage_Start, Common.CG_Request_FinalBoss_EventFreeStage_Start);
        }

        public bool CG_Request_FinalBoss_EventFreeStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventFinalBossFreeStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_EventFreeStage_Clear);
            CommonPacket.Marshaler.Write(message, eventFinalBossFreeStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_EventFreeStage_Clear, Common.CG_Request_FinalBoss_EventFreeStage_Clear);
        }

        public bool CG_Request_FinalBoss_EventFreeStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_FinalBoss_EventFreeStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_FinalBoss_EventFreeStage_Continue, Common.CG_Request_FinalBoss_EventFreeStage_Continue);
        }

        public bool CG_Request_Limited_EventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventLimitedStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Limited_EventStage_Start);
            CommonPacket.Marshaler.Write(message, eventLimitedStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Limited_EventStage_Start, Common.CG_Request_Limited_EventStage_Start);
        }

        public bool CG_Request_Limited_EventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventLimitedStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Limited_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, eventLimitedStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Limited_EventStage_Clear, Common.CG_Request_Limited_EventStage_Clear);
        }

        public bool CG_Request_Limited_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Limited_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Limited_EventStage_Continue, Common.CG_Request_Limited_EventStage_Continue);
        }

        public bool CG_Request_Boss_EventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventBossStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_EventStage_Start);
            CommonPacket.Marshaler.Write(message, eventBossStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_EventStage_Start, Common.CG_Request_Boss_EventStage_Start);
        }

        public bool CG_Request_Boss_EventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventBossStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, eventBossStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_EventStage_Clear, Common.CG_Request_Boss_EventStage_Clear);
        }

        public bool CG_Request_Boss_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_EventStage_Continue, Common.CG_Request_Boss_EventStage_Continue);
        }

        public bool CG_Request_Monthly_EventStage_Start(HostID remote, RmiContext rmiContext, int monthlyID, int storyID, StageStartRequestInfo monthlyStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Monthly_EventStage_Start);
            CommonPacket.Marshaler.Write(message, monthlyID);
            CommonPacket.Marshaler.Write(message, storyID);
            CommonPacket.Marshaler.Write(message, monthlyStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Monthly_EventStage_Start, Common.CG_Request_Monthly_EventStage_Start);
        }

        public bool CG_Request_Monthly_EventStage_Clear(HostID remote, RmiContext rmiContext, int monthlyID, int storyID, StageClearRequestInfo monthlyStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Monthly_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, monthlyID);
            CommonPacket.Marshaler.Write(message, storyID);
            CommonPacket.Marshaler.Write(message, monthlyStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Monthly_EventStage_Clear, Common.CG_Request_Monthly_EventStage_Clear);
        }

        public bool CG_Request_Monthly_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Monthly_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Monthly_EventStage_Continue, Common.CG_Request_Monthly_EventStage_Continue);
        }

        public bool CG_RequestMonthlyStagePointReward(HostID remote, RmiContext rmiContext, int monthlyID, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMonthlyStagePointReward);
            CommonPacket.Marshaler.Write(message, monthlyID);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMonthlyStagePointReward, Common.CG_RequestMonthlyStagePointReward);
        }

        public bool CG_RequestWeekStageGaugeReward(HostID remote, RmiContext rmiContext, WeekStageGroupType weekStageGroupType, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeekStageGaugeReward);
            CommonPacket.Marshaler.Write(message, weekStageGroupType);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeekStageGaugeReward, Common.CG_RequestWeekStageGaugeReward);
        }

        public bool CG_RequestIngameBattleStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestIngameBattleStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestIngameBattleStart, Common.CG_RequestIngameBattleStart);
        }

        public bool CG_RequestStageEndLog(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestStageEndLog);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestStageEndLog, Common.CG_RequestStageEndLog);
        }

        public bool CG_Request_ChallengeBoss_EventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo startRequestInfo, List<int> useSkinIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_ChallengeBoss_EventStage_Start);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            CommonPacket.Marshaler.Write(message, useSkinIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_ChallengeBoss_EventStage_Start, Common.CG_Request_ChallengeBoss_EventStage_Start);
        }

        public bool CG_Request_ChallengeBoss_EventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_ChallengeBoss_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_ChallengeBoss_EventStage_Clear, Common.CG_Request_ChallengeBoss_EventStage_Clear);
        }

        public bool CG_Request_ChallengeBoss_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_ChallengeBoss_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_ChallengeBoss_EventStage_Continue, Common.CG_Request_ChallengeBoss_EventStage_Continue);
        }

        public bool CG_Request_ChallengeBoss_EventStage_Info(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_ChallengeBoss_EventStage_Info);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_ChallengeBoss_EventStage_Info, Common.CG_Request_ChallengeBoss_EventStage_Info);
        }

        public bool CG_Request_ChallengeBoss_Event_Point_Reward(HostID remote, RmiContext rmiContext, int eventSEQ, int step)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_ChallengeBoss_Event_Point_Reward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, step);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_ChallengeBoss_Event_Point_Reward, Common.CG_Request_ChallengeBoss_Event_Point_Reward);
        }

        public bool CG_Request_DisasterBoss_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DisasterBoss_Stage_Start);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DisasterBoss_Stage_Start, Common.CG_Request_DisasterBoss_Stage_Start);
        }

        public bool CG_Request_DisasterBoss_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DisasterBoss_Stage_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DisasterBoss_Stage_Clear, Common.CG_Request_DisasterBoss_Stage_Clear);
        }

        public bool CG_Request_DisasterBoss_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DisasterBoss_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DisasterBoss_Stage_Continue, Common.CG_Request_DisasterBoss_Stage_Continue);
        }

        public bool CG_Request_Week_EventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventWeekStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_EventStage_Start);
            CommonPacket.Marshaler.Write(message, eventWeekStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_EventStage_Start, Common.CG_Request_Week_EventStage_Start);
        }

        public bool CG_Request_Week_EventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventWeekStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, eventWeekStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_EventStage_Clear, Common.CG_Request_Week_EventStage_Clear);
        }

        public bool CG_Request_Week_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_EventStage_Continue, Common.CG_Request_Week_EventStage_Continue);
        }

        public bool CG_Request_Blitz_EventStage_Lobby_Info(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Lobby_Info);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Lobby_Info, Common.CG_Request_Blitz_EventStage_Lobby_Info);
        }

        public bool CG_Request_Blitz_EventStage_Squad_Change(HostID remote, RmiContext rmiContext, int eventSEQ, List<BlitzHeroInfo> blitzHeroInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Squad_Change);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, blitzHeroInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Squad_Change, Common.CG_Request_Blitz_EventStage_Squad_Change);
        }

        public bool CG_Request_Blitz_EventStage_Squad_Init(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Squad_Init);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Squad_Init, Common.CG_Request_Blitz_EventStage_Squad_Init);
        }

        public bool CG_Request_Blitz_EventStage_Team_Change(HostID remote, RmiContext rmiContext, int eventSEQ, List<BlitzTeamSlotInfo> blitzTeamSlotInfoList, int buffID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Team_Change);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, blitzTeamSlotInfoList);
            CommonPacket.Marshaler.Write(message, buffID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Team_Change, Common.CG_Request_Blitz_EventStage_Team_Change);
        }

        public bool CG_Request_Blitz_EventStage_Main_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Main_Start);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Main_Start, Common.CG_Request_Blitz_EventStage_Main_Start);
        }

        public bool CG_Request_Blitz_EventStage_Main_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo clearRequestInfo, List<BlitzMonsterInfo> mosterInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Main_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            CommonPacket.Marshaler.Write(message, mosterInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Main_Clear, Common.CG_Request_Blitz_EventStage_Main_Clear);
        }

        public bool CG_Request_Blitz_EventStage_Free_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Free_Start);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Free_Start, Common.CG_Request_Blitz_EventStage_Free_Start);
        }

        public bool CG_Request_Blitz_EventStage_Free_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo clearRequestInfo, List<BlitzMonsterInfo> mosterInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Free_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            CommonPacket.Marshaler.Write(message, mosterInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Free_Clear, Common.CG_Request_Blitz_EventStage_Free_Clear);
        }

        public bool CG_Request_Blitz_EventStage_Reward_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Reward_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Reward_Clear, Common.CG_Request_Blitz_EventStage_Reward_Clear);
        }

        public bool CG_Request_Blitz_EventStage_Rejoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Rejoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Rejoin, Common.CG_Request_Blitz_EventStage_Rejoin);
        }

        public bool CG_Request_Blitz_EventStage_Rejoin_Cancel(HostID remote, RmiContext rmiContext, List<BlitzMonsterInfo> blitzMonsterInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Blitz_EventStage_Rejoin_Cancel);
            CommonPacket.Marshaler.Write(message, blitzMonsterInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Blitz_EventStage_Rejoin_Cancel, Common.CG_Request_Blitz_EventStage_Rejoin_Cancel);
        }

        public bool CG_RequestRecommandHero(HostID remote, RmiContext rmiContext, RecommandHeroRequestInfo requestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRecommandHero);
            CommonPacket.Marshaler.Write(message, requestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRecommandHero, Common.CG_RequestRecommandHero);
        }

        public bool CG_Request_Free_Once_EventAreaStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo eventAreaFreeOnceStageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_Once_EventAreaStage_Start);
            CommonPacket.Marshaler.Write(message, eventAreaFreeOnceStageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_Once_EventAreaStage_Start, Common.CG_Request_Free_Once_EventAreaStage_Start);
        }

        public bool CG_Request_Free_Once_EventAreaStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo eventAreaFreeOnceStageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_Once_EventAreaStage_Clear);
            CommonPacket.Marshaler.Write(message, eventAreaFreeOnceStageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_Once_EventAreaStage_Clear, Common.CG_Request_Free_Once_EventAreaStage_Clear);
        }

        public bool CG_Request_Free_Once_EventAreaStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_Once_EventAreaStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_Once_EventAreaStage_Continue, Common.CG_Request_Free_Once_EventAreaStage_Continue);
        }

        public bool CG_Request_DescentBoss_EventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DescentBoss_EventStage_Start);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DescentBoss_EventStage_Start, Common.CG_Request_DescentBoss_EventStage_Start);
        }

        public bool CG_Request_DescentBoss_EventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DescentBoss_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DescentBoss_EventStage_Clear, Common.CG_Request_DescentBoss_EventStage_Clear);
        }

        public bool CG_Request_DescentBoss_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DescentBoss_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DescentBoss_EventStage_Continue, Common.CG_Request_DescentBoss_EventStage_Continue);
        }

        public bool CG_Request_DescentBoss_Event_Point_Reward(HostID remote, RmiContext rmiContext, int eventSEQ, int step)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DescentBoss_Event_Point_Reward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, step);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DescentBoss_Event_Point_Reward, Common.CG_Request_DescentBoss_Event_Point_Reward);
        }

        public bool CG_Request_NorthMain_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_NorthMain_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_NorthMain_Stage_Start, Common.CG_Request_NorthMain_Stage_Start);
        }

        public bool CG_Request_NorthMain_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_NorthMain_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_NorthMain_Stage_Clear, Common.CG_Request_NorthMain_Stage_Clear);
        }

        public bool CG_Request_NorthMain_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_NorthMain_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_NorthMain_Stage_Continue, Common.CG_Request_NorthMain_Stage_Continue);
        }

        public bool CG_Request_North_Free_Once_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_North_Free_Once_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_North_Free_Once_Stage_Start, Common.CG_Request_North_Free_Once_Stage_Start);
        }

        public bool CG_Request_North_Free_Once_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageCleatRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_North_Free_Once_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageCleatRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_North_Free_Once_Stage_Clear, Common.CG_Request_North_Free_Once_Stage_Clear);
        }

        public bool CG_Request_North_Free_Once_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_North_Free_Once_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_North_Free_Once_Stage_Continue, Common.CG_Request_North_Free_Once_Stage_Continue);
        }

        public bool CG_Request_Another_Free_Once_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Another_Free_Once_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Another_Free_Once_Stage_Start, Common.CG_Request_Another_Free_Once_Stage_Start);
        }

        public bool CG_Request_Another_Free_Once_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageCleatRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Another_Free_Once_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageCleatRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Another_Free_Once_Stage_Clear, Common.CG_Request_Another_Free_Once_Stage_Clear);
        }

        public bool CG_Request_Another_Free_Once_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Another_Free_Once_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Another_Free_Once_Stage_Continue, Common.CG_Request_Another_Free_Once_Stage_Continue);
        }

        public bool CG_RequestEventMazeStageStart(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStageStart);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStageStart, Common.CG_RequestEventMazeStageStart);
        }

        public bool CG_RequestEventMazeStageClear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo, List<SyncMazeHero> heroSyncInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStageClear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            CommonPacket.Marshaler.Write(message, heroSyncInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStageClear, Common.CG_RequestEventMazeStageClear);
        }

        public bool CG_RequestEventMazeStageRejoin(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStageRejoin);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStageRejoin, Common.CG_RequestEventMazeStageRejoin);
        }

        public bool CG_RequestEventMazeStageRejoinCancel(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStageRejoinCancel);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStageRejoinCancel, Common.CG_RequestEventMazeStageRejoinCancel);
        }

        public bool CG_RequestEventMazeStageReChallenge(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStageReChallenge);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStageReChallenge, Common.CG_RequestEventMazeStageReChallenge);
        }

        public bool CG_RequestEventMazeStageReChallengeCancel(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStageReChallengeCancel);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStageReChallengeCancel, Common.CG_RequestEventMazeStageReChallengeCancel);
        }

        public bool CG_Request_Conquest_EventStage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Conquest_EventStage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Conquest_EventStage_Start, Common.CG_Request_Conquest_EventStage_Start);
        }

        public bool CG_Request_Conquest_EventStage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Conquest_EventStage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Conquest_EventStage_Clear, Common.CG_Request_Conquest_EventStage_Clear);
        }

        public bool CG_Request_Conquest_EventStage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Conquest_EventStage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Conquest_EventStage_Continue, Common.CG_Request_Conquest_EventStage_Continue);
        }

        public bool CG_Request_Disaster_Main_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Main_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Main_Stage_Start, Common.CG_Request_Disaster_Main_Stage_Start);
        }

        public bool CG_Request_Disaster_Main_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Main_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Main_Stage_Clear, Common.CG_Request_Disaster_Main_Stage_Clear);
        }

        public bool CG_Request_Disaster_Main_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Main_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Main_Stage_Continue, Common.CG_Request_Disaster_Main_Stage_Continue);
        }

        public bool CG_Request_Disaster_Free_Once_Stage_Start(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Free_Once_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Free_Once_Stage_Start, Common.CG_Request_Disaster_Free_Once_Stage_Start);
        }

        public bool CG_Request_Disaster_Free_Once_Stage_Clear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageCleatRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Free_Once_Stage_Clear);
            CommonPacket.Marshaler.Write(message, stageCleatRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Free_Once_Stage_Clear, Common.CG_Request_Disaster_Free_Once_Stage_Clear);
        }

        public bool CG_Request_Disaster_Free_Once_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Disaster_Free_Once_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Disaster_Free_Once_Stage_Continue, Common.CG_Request_Disaster_Free_Once_Stage_Continue);
        }

        public bool CG_RequestMailList(HostID remote, RmiContext rmiContext, LanguageType languageType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMailList);
            CommonPacket.Marshaler.Write(message, languageType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMailList, Common.CG_RequestMailList);
        }

        public bool CG_RequestMailConfirm(HostID remote, RmiContext rmiContext, int mailSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMailConfirm);
            CommonPacket.Marshaler.Write(message, mailSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMailConfirm, Common.CG_RequestMailConfirm);
        }

        public bool CG_RequestMailConfirmAll(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMailConfirmAll);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMailConfirmAll, Common.CG_RequestMailConfirmAll);
        }

        public bool CG_RequestMailHistoryList(HostID remote, RmiContext rmiContext, int lastMailHistorySN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMailHistoryList);
            CommonPacket.Marshaler.Write(message, lastMailHistorySN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMailHistoryList, Common.CG_RequestMailHistoryList);
        }

        public bool CG_RequestMailRecentlyHistoryList(HostID remote, RmiContext rmiContext, int firstMailHistorySN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMailRecentlyHistoryList);
            CommonPacket.Marshaler.Write(message, firstMailHistorySN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMailRecentlyHistoryList, Common.CG_RequestMailRecentlyHistoryList);
        }

        public bool CG_RequestFriendMailList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendMailList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendMailList, Common.CG_RequestFriendMailList);
        }

        public bool CG_RequestFriendMailConfirm(HostID remote, RmiContext rmiContext, int mailSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendMailConfirm);
            CommonPacket.Marshaler.Write(message, mailSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendMailConfirm, Common.CG_RequestFriendMailConfirm);
        }

        public bool CG_RequestFriendMailConfirmAll(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendMailConfirmAll);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendMailConfirmAll, Common.CG_RequestFriendMailConfirmAll);
        }

        public bool CG_RequestNoticeMailReward(HostID remote, RmiContext rmiContext, int noticeMailSEQ, NoticeMailType noticeMailType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestNoticeMailReward);
            CommonPacket.Marshaler.Write(message, noticeMailSEQ);
            CommonPacket.Marshaler.Write(message, noticeMailType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestNoticeMailReward, Common.CG_RequestNoticeMailReward);
        }

        public bool CG_RequestPackageMailList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPackageMailList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPackageMailList, Common.CG_RequestPackageMailList);
        }

        public bool CG_RequestPackageMailGet(HostID remote, RmiContext rmiContext, int mailSerial, int packageID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPackageMailGet);
            CommonPacket.Marshaler.Write(message, mailSerial);
            CommonPacket.Marshaler.Write(message, packageID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPackageMailGet, Common.CG_RequestPackageMailGet);
        }

        public bool CG_RequestPackageMailHistoryList(HostID remote, RmiContext rmiContext, int nextMailSEQ, bool isNext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPackageMailHistoryList);
            CommonPacket.Marshaler.Write(message, nextMailSEQ);
            CommonPacket.Marshaler.Write(message, isNext);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPackageMailHistoryList, Common.CG_RequestPackageMailHistoryList);
        }

        public bool CG_RequestLevelUpPackageReward(HostID remote, RmiContext rmiContext, int productID, int rewardID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLevelUpPackageReward);
            CommonPacket.Marshaler.Write(message, productID);
            CommonPacket.Marshaler.Write(message, rewardID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLevelUpPackageReward, Common.CG_RequestLevelUpPackageReward);
        }

        public bool CG_RequestLevelUpPackageRewardAll(HostID remote, RmiContext rmiContext, int productID, int rewardID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLevelUpPackageRewardAll);
            CommonPacket.Marshaler.Write(message, productID);
            CommonPacket.Marshaler.Write(message, rewardID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLevelUpPackageRewardAll, Common.CG_RequestLevelUpPackageRewardAll);
        }

        public bool CG_RequestAttendancePackageReward(HostID remote, RmiContext rmiContext, int productID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAttendancePackageReward);
            CommonPacket.Marshaler.Write(message, productID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAttendancePackageReward, Common.CG_RequestAttendancePackageReward);
        }

        public bool CG_RequestAttendancePackageRewardAll(HostID remote, RmiContext rmiContext, int productID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAttendancePackageRewardAll);
            CommonPacket.Marshaler.Write(message, productID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAttendancePackageRewardAll, Common.CG_RequestAttendancePackageRewardAll);
        }

        public bool CG_RequestMailADReward(HostID remote, RmiContext rmiContext, ADViewContentType contentType, int viewCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMailADReward);
            CommonPacket.Marshaler.Write(message, contentType);
            CommonPacket.Marshaler.Write(message, viewCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMailADReward, Common.CG_RequestMailADReward);
        }

        public bool CG_RequestGambleShopBuy(HostID remote, RmiContext rmiContext, GambleShopBuyRequest gambleRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGambleShopBuy);
            CommonPacket.Marshaler.Write(message, gambleRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGambleShopBuy, Common.CG_RequestGambleShopBuy);
        }

        public bool CG_RequestStepupGambleShopBuy(HostID remote, RmiContext rmiContext, int stepupGroupID, StepupPriceType priceType, int choiceItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestStepupGambleShopBuy);
            CommonPacket.Marshaler.Write(message, stepupGroupID);
            CommonPacket.Marshaler.Write(message, priceType);
            CommonPacket.Marshaler.Write(message, choiceItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestStepupGambleShopBuy, Common.CG_RequestStepupGambleShopBuy);
        }

        public bool CG_RequestStepupGambleMileageReward(HostID remote, RmiContext rmiContext, int stepupGroupID, int mileageIndex, int choiceItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestStepupGambleMileageReward);
            CommonPacket.Marshaler.Write(message, stepupGroupID);
            CommonPacket.Marshaler.Write(message, mileageIndex);
            CommonPacket.Marshaler.Write(message, choiceItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestStepupGambleMileageReward, Common.CG_RequestStepupGambleMileageReward);
        }

        public bool CG_RequestItemGambleShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemGambleShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemGambleShopInfo, Common.CG_RequestItemGambleShopInfo);
        }

        public bool CG_RequestItemGambleShopBuy(HostID remote, RmiContext rmiContext, int itemGambleDisplayID, int usePriceItemID, bool isADView, WeaponAutoGrindOption grindOption)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemGambleShopBuy);
            CommonPacket.Marshaler.Write(message, itemGambleDisplayID);
            CommonPacket.Marshaler.Write(message, usePriceItemID);
            CommonPacket.Marshaler.Write(message, isADView);
            CommonPacket.Marshaler.Write(message, grindOption);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemGambleShopBuy, Common.CG_RequestItemGambleShopBuy);
        }

        public bool CG_RequestRandomShopBuy(HostID remote, RmiContext rmiContext, int basepointID, byte slotIndex, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomShopBuy);
            CommonPacket.Marshaler.Write(message, basepointID);
            CommonPacket.Marshaler.Write(message, slotIndex);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomShopBuy, Common.CG_RequestRandomShopBuy);
        }

        public bool CG_RequestRandomShopRefresh(HostID remote, RmiContext rmiContext, int basepointID, bool isADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomShopRefresh);
            CommonPacket.Marshaler.Write(message, basepointID);
            CommonPacket.Marshaler.Write(message, isADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomShopRefresh, Common.CG_RequestRandomShopRefresh);
        }

        public bool CG_RequestRandomShopInfo(HostID remote, RmiContext rmiContext, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomShopInfo);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomShopInfo, Common.CG_RequestRandomShopInfo);
        }

        public bool CG_RequestBasePointShopInfo(HostID remote, RmiContext rmiContext, int basepointID, bool isCommonShop)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointShopInfo);
            CommonPacket.Marshaler.Write(message, basepointID);
            CommonPacket.Marshaler.Write(message, isCommonShop);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointShopInfo, Common.CG_RequestBasePointShopInfo);
        }

        public bool CG_RequestBasePointShopBuy(HostID remote, RmiContext rmiContext, List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointShopBuy);
            CommonPacket.Marshaler.Write(message, shopBuyRequestInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointShopBuy, Common.CG_RequestBasePointShopBuy);
        }

        public bool CG_RequestBasePointShopReset(HostID remote, RmiContext rmiContext, int basepointID, bool isCommonShop, bool isADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointShopReset);
            CommonPacket.Marshaler.Write(message, basepointID);
            CommonPacket.Marshaler.Write(message, isCommonShop);
            CommonPacket.Marshaler.Write(message, isADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointShopReset, Common.CG_RequestBasePointShopReset);
        }

        public bool CG_RequestArenaRealTimePvpShopInfo(HostID remote, RmiContext rmiContext, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpShopInfo);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpShopInfo, Common.CG_RequestArenaRealTimePvpShopInfo);
        }

        public bool CG_RequestArenaRealTimePvpShopBuy(HostID remote, RmiContext rmiContext, List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpShopBuy);
            CommonPacket.Marshaler.Write(message, shopBuyRequestInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpShopBuy, Common.CG_RequestArenaRealTimePvpShopBuy);
        }

        public bool CG_RequestArenaRealTimePvpShopReset(HostID remote, RmiContext rmiContext, int basepointID, bool isADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpShopReset);
            CommonPacket.Marshaler.Write(message, basepointID);
            CommonPacket.Marshaler.Write(message, isADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpShopReset, Common.CG_RequestArenaRealTimePvpShopReset);
        }

        public bool CG_RequestCoinShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCoinShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCoinShopInfo, Common.CG_RequestCoinShopInfo);
        }

        public bool CG_RequestCoinShopBuy(HostID remote, RmiContext rmiContext, int shopID, byte buyCount, List<UserCommonItem> useItemInfoList, bool isADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCoinShopBuy);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            CommonPacket.Marshaler.Write(message, useItemInfoList);
            CommonPacket.Marshaler.Write(message, isADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCoinShopBuy, Common.CG_RequestCoinShopBuy);
        }

        public bool CG_RequestEventCoinShopBuy(HostID remote, RmiContext rmiContext, int shopID, byte buyCount, List<UserCommonItem> useItemInfoList, bool isADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventCoinShopBuy);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            CommonPacket.Marshaler.Write(message, useItemInfoList);
            CommonPacket.Marshaler.Write(message, isADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventCoinShopBuy, Common.CG_RequestEventCoinShopBuy);
        }

        public bool CG_RequestCostumeShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeShopInfo, Common.CG_RequestCostumeShopInfo);
        }

        public bool CG_RequestCostumeShopBuy(HostID remote, RmiContext rmiContext, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeShopBuy);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeShopBuy, Common.CG_RequestCostumeShopBuy);
        }

        public bool CG_RequestCostumeShopPackageBuy(HostID remote, RmiContext rmiContext, List<CostumePackageBuyInfo> costumePackageBuyInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCostumeShopPackageBuy);
            CommonPacket.Marshaler.Write(message, costumePackageBuyInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCostumeShopPackageBuy, Common.CG_RequestCostumeShopPackageBuy);
        }

        public bool CG_RequestDiaShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDiaShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDiaShopInfo, Common.CG_RequestDiaShopInfo);
        }

        public bool CG_RequestDiaShopBuy(HostID remote, RmiContext rmiContext, int productItemID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDiaShopBuy);
            CommonPacket.Marshaler.Write(message, productItemID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDiaShopBuy, Common.CG_RequestDiaShopBuy);
        }

        public bool CG_RequestItemInventoryBuy(HostID remote, RmiContext rmiContext, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemInventoryBuy);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemInventoryBuy, Common.CG_RequestItemInventoryBuy);
        }

        public bool CG_RequestWeaponInventoryBuy(HostID remote, RmiContext rmiContext, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeaponInventoryBuy);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeaponInventoryBuy, Common.CG_RequestWeaponInventoryBuy);
        }

        public bool CG_RequestWeekStageKeyBuy(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeekStageKeyBuy);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeekStageKeyBuy, Common.CG_RequestWeekStageKeyBuy);
        }

        public bool CG_RequestCommonItemSell(HostID remote, RmiContext rmiContext, List<UserCommonItem> sellCommonItemList, ItemSellType itemSellType, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCommonItemSell);
            CommonPacket.Marshaler.Write(message, sellCommonItemList);
            CommonPacket.Marshaler.Write(message, itemSellType);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCommonItemSell, Common.CG_RequestCommonItemSell);
        }

        public bool CG_RequestCommonItemRemove(HostID remote, RmiContext rmiContext, int itemID, int itemMinusCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCommonItemRemove);
            CommonPacket.Marshaler.Write(message, itemID);
            CommonPacket.Marshaler.Write(message, itemMinusCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCommonItemRemove, Common.CG_RequestCommonItemRemove);
        }

        public bool CG_RequestPackageBuy(HostID remote, RmiContext rmiContext, int shopMoneyID, List<int> choiceItemIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPackageBuy);
            CommonPacket.Marshaler.Write(message, shopMoneyID);
            CommonPacket.Marshaler.Write(message, choiceItemIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPackageBuy, Common.CG_RequestPackageBuy);
        }

        public bool CG_RequestBuyDia(HostID remote, RmiContext rmiContext, int shopMoneyID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBuyDia);
            CommonPacket.Marshaler.Write(message, shopMoneyID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBuyDia, Common.CG_RequestBuyDia);
        }

        public bool CG_RequestBuyGold(HostID remote, RmiContext rmiContext, int shopMoneyID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBuyGold);
            CommonPacket.Marshaler.Write(message, shopMoneyID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBuyGold, Common.CG_RequestBuyGold);
        }

        public bool CG_RequestBuyStamina(HostID remote, RmiContext rmiContext, int shopMoneyID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBuyStamina);
            CommonPacket.Marshaler.Write(message, shopMoneyID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBuyStamina, Common.CG_RequestBuyStamina);
        }

        public bool CG_RequestGuildShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildShopInfo, Common.CG_RequestGuildShopInfo);
        }

        public bool CG_RequestGuildShopBuy(HostID remote, RmiContext rmiContext, List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildShopBuy);
            CommonPacket.Marshaler.Write(message, shopBuyRequestInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildShopBuy, Common.CG_RequestGuildShopBuy);
        }

        public bool CG_RequestGuildShopReset(HostID remote, RmiContext rmiContext, bool isADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildShopReset);
            CommonPacket.Marshaler.Write(message, isADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildShopReset, Common.CG_RequestGuildShopReset);
        }

        public bool CG_RequestFinalBossShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFinalBossShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFinalBossShopInfo, Common.CG_RequestFinalBossShopInfo);
        }

        public bool CG_RequestFinalBossShopBuy(HostID remote, RmiContext rmiContext, int seasonID, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFinalBossShopBuy);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFinalBossShopBuy, Common.CG_RequestFinalBossShopBuy);
        }

        public bool CG_RequestBingoGambleShopInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBingoGambleShopInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBingoGambleShopInfo, Common.CG_RequestBingoGambleShopInfo);
        }

        public bool CG_RequestBingoGambleShopReset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBingoGambleShopReset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBingoGambleShopReset, Common.CG_RequestBingoGambleShopReset);
        }

        public bool CG_RequestBingoGambleShopReward(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> rewardIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBingoGambleShopReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBingoGambleShopReward, Common.CG_RequestBingoGambleShopReward);
        }

        public bool CG_RequestDiaShopPackageBuy(HostID remote, RmiContext rmiContext, int productItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDiaShopPackageBuy);
            CommonPacket.Marshaler.Write(message, productItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDiaShopPackageBuy, Common.CG_RequestDiaShopPackageBuy);
        }

        public bool CG_RequestRandomShopVisitReward(HostID remote, RmiContext rmiContext, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomShopVisitReward);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomShopVisitReward, Common.CG_RequestRandomShopVisitReward);
        }

        public bool CG_RequestGambleChoiceShopBuy(HostID remote, RmiContext rmiContext, int gambleType, int choiceSkinID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGambleChoiceShopBuy);
            CommonPacket.Marshaler.Write(message, gambleType);
            CommonPacket.Marshaler.Write(message, choiceSkinID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGambleChoiceShopBuy, Common.CG_RequestGambleChoiceShopBuy);
        }

        public bool CG_RequestRandomShopScheduleInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomShopScheduleInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomShopScheduleInfo, Common.CG_RequestRandomShopScheduleInfo);
        }

        public bool CG_RequestPackageShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPackageShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPackageShopInfo, Common.CG_RequestPackageShopInfo);
        }

        public bool CG_RequestFreePackageReward(HostID remote, RmiContext rmiContext, int rewardID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFreePackageReward);
            CommonPacket.Marshaler.Write(message, rewardID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFreePackageReward, Common.CG_RequestFreePackageReward);
        }

        public bool CG_RequestPackageMissionClose(HostID remote, RmiContext rmiContext, List<byte> packageMissionIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPackageMissionClose);
            CommonPacket.Marshaler.Write(message, packageMissionIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPackageMissionClose, Common.CG_RequestPackageMissionClose);
        }

        public bool CG_RequestGambleShopInfo(HostID remote, RmiContext rmiContext, int gambleType, List<GambleCheckSumInfo> gambleCheckSumInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGambleShopInfo);
            CommonPacket.Marshaler.Write(message, gambleType);
            CommonPacket.Marshaler.Write(message, gambleCheckSumInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGambleShopInfo, Common.CG_RequestGambleShopInfo);
        }

        public bool CG_RequestADRouletteReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestADRouletteReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestADRouletteReward, Common.CG_RequestADRouletteReward);
        }

        public bool CG_RequestGambleGaugeReward(HostID remote, RmiContext rmiContext, int gambleType, byte rewardStep, int choiceIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGambleGaugeReward);
            CommonPacket.Marshaler.Write(message, gambleType);
            CommonPacket.Marshaler.Write(message, rewardStep);
            CommonPacket.Marshaler.Write(message, choiceIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGambleGaugeReward, Common.CG_RequestGambleGaugeReward);
        }

        public bool CG_RequestArenaSmashShopInfo(HostID remote, RmiContext rmiContext, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashShopInfo);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashShopInfo, Common.CG_RequestArenaSmashShopInfo);
        }

        public bool CG_RequestArenaSmashShopBuy(HostID remote, RmiContext rmiContext, List<ShopBuyRequestInfo> shopBuyRequestInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashShopBuy);
            CommonPacket.Marshaler.Write(message, shopBuyRequestInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashShopBuy, Common.CG_RequestArenaSmashShopBuy);
        }

        public bool CG_RequestArenaSmashShopReward(HostID remote, RmiContext rmiContext, byte shopRewardID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashShopReward);
            CommonPacket.Marshaler.Write(message, shopRewardID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashShopReward, Common.CG_RequestArenaSmashShopReward);
        }

        public bool CG_RequestArenaSmashShopReset(HostID remote, RmiContext rmiContext, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashShopReset);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashShopReset, Common.CG_RequestArenaSmashShopReset);
        }

        public bool CG_RequestEvolutionExchange(HostID remote, RmiContext rmiContext, int evolutionExchangeID, byte buyCount, List<NeedItemInfo> priceItemList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEvolutionExchange);
            CommonPacket.Marshaler.Write(message, evolutionExchangeID);
            CommonPacket.Marshaler.Write(message, buyCount);
            CommonPacket.Marshaler.Write(message, priceItemList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEvolutionExchange, Common.CG_RequestEvolutionExchange);
        }

        public bool CG_RequestQuestStart(HostID remote, RmiContext rmiContext, int questID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestStart);
            CommonPacket.Marshaler.Write(message, questID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestStart, Common.CG_RequestQuestStart);
        }

        public bool CG_RequestQuestProgress(HostID remote, RmiContext rmiContext, int questID, int needID, byte propIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestProgress);
            CommonPacket.Marshaler.Write(message, questID);
            CommonPacket.Marshaler.Write(message, needID);
            CommonPacket.Marshaler.Write(message, propIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestProgress, Common.CG_RequestQuestProgress);
        }

        public bool CG_RequestQuestClear(HostID remote, RmiContext rmiContext, int questID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestClear);
            CommonPacket.Marshaler.Write(message, questID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestClear, Common.CG_RequestQuestClear);
        }

        public bool CG_RequestQuestRemove(HostID remote, RmiContext rmiContext, int questID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestRemove);
            CommonPacket.Marshaler.Write(message, questID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestRemove, Common.CG_RequestQuestRemove);
        }

        public bool CG_RequestDirectSelectorReward(HostID remote, RmiContext rmiContext, int selectorID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDirectSelectorReward);
            CommonPacket.Marshaler.Write(message, selectorID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDirectSelectorReward, Common.CG_RequestDirectSelectorReward);
        }

        public bool CG_RequestMissionProgress(HostID remote, RmiContext rmiContext, MissionType missionType, int missionTypeValue, int addValue)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMissionProgress);
            CommonPacket.Marshaler.Write(message, missionType);
            CommonPacket.Marshaler.Write(message, missionTypeValue);
            CommonPacket.Marshaler.Write(message, addValue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMissionProgress, Common.CG_RequestMissionProgress);
        }

        public bool CG_RequestMissionClear(HostID remote, RmiContext rmiContext, List<MissionClearRequestInfo> missionClearList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMissionClear);
            CommonPacket.Marshaler.Write(message, missionClearList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMissionClear, Common.CG_RequestMissionClear);
        }

        public bool CG_RequestMissionEventClear(HostID remote, RmiContext rmiContext, List<EventMissionClearRequestInfo> missionClearList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMissionEventClear);
            CommonPacket.Marshaler.Write(message, missionClearList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMissionEventClear, Common.CG_RequestMissionEventClear);
        }

        public bool CG_RequestMissionGetAchievePointReward(HostID remote, RmiContext rmiContext, short rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMissionGetAchievePointReward);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMissionGetAchievePointReward, Common.CG_RequestMissionGetAchievePointReward);
        }

        public bool CG_RequestQuestChapterClear(HostID remote, RmiContext rmiContext, int region)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestChapterClear);
            CommonPacket.Marshaler.Write(message, region);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestChapterClear, Common.CG_RequestQuestChapterClear);
        }

        public bool CG_RequestEventMissionGetAchievePointReward(HostID remote, RmiContext rmiContext, short rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMissionGetAchievePointReward);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMissionGetAchievePointReward, Common.CG_RequestEventMissionGetAchievePointReward);
        }

        public bool CG_RequestEventMissionCompleteReward(HostID remote, RmiContext rmiContext, int eventSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMissionCompleteReward);
            CommonPacket.Marshaler.Write(message, eventSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMissionCompleteReward, Common.CG_RequestEventMissionCompleteReward);
        }

        public bool CG_RequestEventMissionInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMissionInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMissionInfo, Common.CG_RequestEventMissionInfo);
        }

        public bool CG_RequestEventQuestClear(HostID remote, RmiContext rmiContext, int eventSeq, int questID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventQuestClear);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, questID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventQuestClear, Common.CG_RequestEventQuestClear);
        }

        public bool CG_RequestAnotherQuestClear(HostID remote, RmiContext rmiContext, int questID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAnotherQuestClear);
            CommonPacket.Marshaler.Write(message, questID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAnotherQuestClear, Common.CG_RequestAnotherQuestClear);
        }

        public bool CG_RequestNorthQuestClear(HostID remote, RmiContext rmiContext, int questID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestNorthQuestClear);
            CommonPacket.Marshaler.Write(message, questID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestNorthQuestClear, Common.CG_RequestNorthQuestClear);
        }

        public bool CG_RequestQuestGuideListAllClearReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestGuideListAllClearReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestGuideListAllClearReward, Common.CG_RequestQuestGuideListAllClearReward);
        }

        public bool CG_RequestQuestGuideListStepStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestGuideListStepStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestGuideListStepStart, Common.CG_RequestQuestGuideListStepStart);
        }

        public bool CG_RequestQuestGuideListStepClear(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestQuestGuideListStepClear);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestQuestGuideListStepClear, Common.CG_RequestQuestGuideListStepClear);
        }

        public bool CG_RequestDisasterQuestClear(HostID remote, RmiContext rmiContext, int questID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDisasterQuestClear);
            CommonPacket.Marshaler.Write(message, questID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDisasterQuestClear, Common.CG_RequestDisasterQuestClear);
        }

        public bool CG_RequestLobbyVRSearch(HostID remote, RmiContext rmiContext, int interactiveVRID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyVRSearch);
            CommonPacket.Marshaler.Write(message, interactiveVRID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyVRSearch, Common.CG_RequestLobbyVRSearch);
        }

        public bool CG_RequestLobbyVRHelbram(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyVRHelbram);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyVRHelbram, Common.CG_RequestLobbyVRHelbram);
        }

        public bool CG_RequestLobbyNpcSkin(HostID remote, RmiContext rmiContext, int npcID, int storyCostumeID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyNpcSkin);
            CommonPacket.Marshaler.Write(message, npcID);
            CommonPacket.Marshaler.Write(message, storyCostumeID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyNpcSkin, Common.CG_RequestLobbyNpcSkin);
        }

        public bool CG_RequestLobbyNpcGift(HostID remote, RmiContext rmiContext, int npcID, int giftItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyNpcGift);
            CommonPacket.Marshaler.Write(message, npcID);
            CommonPacket.Marshaler.Write(message, giftItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyNpcGift, Common.CG_RequestLobbyNpcGift);
        }

        public bool CG_RequestLobbyKingAmber(HostID remote, RmiContext rmiContext, int amberID, int rewardItemID, int amberCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyKingAmber);
            CommonPacket.Marshaler.Write(message, amberID);
            CommonPacket.Marshaler.Write(message, rewardItemID);
            CommonPacket.Marshaler.Write(message, amberCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyKingAmber, Common.CG_RequestLobbyKingAmber);
        }

        public bool CG_RequestLobbyDropInteractiveOpen(HostID remote, RmiContext rmiContext, int npcID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyDropInteractiveOpen);
            CommonPacket.Marshaler.Write(message, npcID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyDropInteractiveOpen, Common.CG_RequestLobbyDropInteractiveOpen);
        }

        public bool CG_RequestLobbyUniqueInteractiveOpen(HostID remote, RmiContext rmiContext, int npcID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyUniqueInteractiveOpen);
            CommonPacket.Marshaler.Write(message, npcID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyUniqueInteractiveOpen, Common.CG_RequestLobbyUniqueInteractiveOpen);
        }

        public bool CG_RequestLobbyNpcTalkInfo(HostID remote, RmiContext rmiContext, int npcID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyNpcTalkInfo);
            CommonPacket.Marshaler.Write(message, npcID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyNpcTalkInfo, Common.CG_RequestLobbyNpcTalkInfo);
        }

        public bool CG_RequestLobbyNpcTalkChoice(HostID remote, RmiContext rmiContext, int npcID, InteractiveChoice choice)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyNpcTalkChoice);
            CommonPacket.Marshaler.Write(message, npcID);
            CommonPacket.Marshaler.Write(message, choice);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyNpcTalkChoice, Common.CG_RequestLobbyNpcTalkChoice);
        }

        public bool CG_RequestLobbyBarrel(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyBarrel);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyBarrel, Common.CG_RequestLobbyBarrel);
        }

        public bool CG_RequestLobbyBarrelRefill(HostID remote, RmiContext rmiContext, int itemIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyBarrelRefill);
            CommonPacket.Marshaler.Write(message, itemIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyBarrelRefill, Common.CG_RequestLobbyBarrelRefill);
        }

        public bool CG_RequestLobbyCleanTable(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyCleanTable);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyCleanTable, Common.CG_RequestLobbyCleanTable);
        }

        public bool CG_RequestLobbyServeBeer(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyServeBeer);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyServeBeer, Common.CG_RequestLobbyServeBeer);
        }

        public bool CG_RequestLobbyPlayJukebox(HostID remote, RmiContext rmiContext, int playMusicID, byte musicInstrument)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyPlayJukebox);
            CommonPacket.Marshaler.Write(message, playMusicID);
            CommonPacket.Marshaler.Write(message, musicInstrument);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyPlayJukebox, Common.CG_RequestLobbyPlayJukebox);
        }

        public bool CG_RequestLobbyElizabethTouch(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyElizabethTouch);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyElizabethTouch, Common.CG_RequestLobbyElizabethTouch);
        }

        public bool CG_RequestLobbyHawkAnger(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyHawkAnger);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyHawkAnger, Common.CG_RequestLobbyHawkAnger);
        }

        public bool CG_RequestAttendanceReward(HostID remote, RmiContext rmiContext, ClientDeviceType deviceType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAttendanceReward);
            CommonPacket.Marshaler.Write(message, deviceType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAttendanceReward, Common.CG_RequestAttendanceReward);
        }

        public bool CG_RequestAttendanceEventReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAttendanceEventReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAttendanceEventReward, Common.CG_RequestAttendanceEventReward);
        }

        public bool CG_RequestCookingStart(HostID remote, RmiContext rmiContext, CookingRequest cookingRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookingStart);
            CommonPacket.Marshaler.Write(message, cookingRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookingStart, Common.CG_RequestCookingStart);
        }

        public bool CG_RequestRecipeActive(HostID remote, RmiContext rmiContext, int recipeID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRecipeActive);
            CommonPacket.Marshaler.Write(message, recipeID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRecipeActive, Common.CG_RequestRecipeActive);
        }

        public bool CG_RequestCookingRecipeOrderInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookingRecipeOrderInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookingRecipeOrderInfo, Common.CG_RequestCookingRecipeOrderInfo);
        }

        public bool CG_RequestCookingRecipeOrder(HostID remote, RmiContext rmiContext, byte slotIndex, int recipeID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookingRecipeOrder);
            CommonPacket.Marshaler.Write(message, slotIndex);
            CommonPacket.Marshaler.Write(message, recipeID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookingRecipeOrder, Common.CG_RequestCookingRecipeOrder);
        }

        public bool CG_RequestCookingRecipeDisorder(HostID remote, RmiContext rmiContext, byte slotIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookingRecipeDisorder);
            CommonPacket.Marshaler.Write(message, slotIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookingRecipeDisorder, Common.CG_RequestCookingRecipeDisorder);
        }

        public bool CG_RequestCookingRecipeCollect(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookingRecipeCollect);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookingRecipeCollect, Common.CG_RequestCookingRecipeCollect);
        }

        public bool CG_RequestCookingRecipeCollectOneSlot(HostID remote, RmiContext rmiContext, byte slotIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookingRecipeCollectOneSlot);
            CommonPacket.Marshaler.Write(message, slotIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookingRecipeCollectOneSlot, Common.CG_RequestCookingRecipeCollectOneSlot);
        }

        public bool CG_RequestCookingUseCookingBuff(HostID remote, RmiContext rmiContext, int foodItemID, bool isAutoUse)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCookingUseCookingBuff);
            CommonPacket.Marshaler.Write(message, foodItemID);
            CommonPacket.Marshaler.Write(message, isAutoUse);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCookingUseCookingBuff, Common.CG_RequestCookingUseCookingBuff);
        }

        public bool CG_RequestGuestInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuestInfo, Common.CG_RequestGuestInfo);
        }

        public bool CG_RequestGuestChange(HostID remote, RmiContext rmiContext, int guestSlotIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuestChange);
            CommonPacket.Marshaler.Write(message, guestSlotIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuestChange, Common.CG_RequestGuestChange);
        }

        public bool CG_RequestGuestChangeTarget(HostID remote, RmiContext rmiContext, int guestSlotIndex, int npcID, bool isFree)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuestChangeTarget);
            CommonPacket.Marshaler.Write(message, guestSlotIndex);
            CommonPacket.Marshaler.Write(message, npcID);
            CommonPacket.Marshaler.Write(message, isFree);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuestChangeTarget, Common.CG_RequestGuestChangeTarget);
        }

        public bool CG_RequestGuestTalk(HostID remote, RmiContext rmiContext, int npcID, int talkID, InteractiveChoice choice)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuestTalk);
            CommonPacket.Marshaler.Write(message, npcID);
            CommonPacket.Marshaler.Write(message, talkID);
            CommonPacket.Marshaler.Write(message, choice);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuestTalk, Common.CG_RequestGuestTalk);
        }

        public bool CG_RequestGuestGift(HostID remote, RmiContext rmiContext, int npcID, int giftItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuestGift);
            CommonPacket.Marshaler.Write(message, npcID);
            CommonPacket.Marshaler.Write(message, giftItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuestGift, Common.CG_RequestGuestGift);
        }

        public bool CG_RequestBirthdayNpcInfo(HostID remote, RmiContext rmiContext, int npcID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBirthdayNpcInfo);
            CommonPacket.Marshaler.Write(message, npcID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBirthdayNpcInfo, Common.CG_RequestBirthdayNpcInfo);
        }

        public bool CG_RequestRestReward(HostID remote, RmiContext rmiContext, int breakID, int rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRestReward);
            CommonPacket.Marshaler.Write(message, breakID);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRestReward, Common.CG_RequestRestReward);
        }

        public bool CG_RequestLobbyHousingShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyHousingShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyHousingShopInfo, Common.CG_RequestLobbyHousingShopInfo);
        }

        public bool CG_RequestLobbyHousingShopBuy(HostID remote, RmiContext rmiContext, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyHousingShopBuy);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyHousingShopBuy, Common.CG_RequestLobbyHousingShopBuy);
        }

        public bool CG_RequestLobbyFurnitureRegist(HostID remote, RmiContext rmiContext, List<UserFurniture> registUserFurnitureList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbyFurnitureRegist);
            CommonPacket.Marshaler.Write(message, registUserFurnitureList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbyFurnitureRegist, Common.CG_RequestLobbyFurnitureRegist);
        }

        public bool CG_RequestUserMusicEdit(HostID remote, RmiContext rmiContext, UserMusic editUserMusic)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestUserMusicEdit);
            CommonPacket.Marshaler.Write(message, editUserMusic);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestUserMusicEdit, Common.CG_RequestUserMusicEdit);
        }

        public bool CG_RequestAttendanceFortuneEventReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAttendanceFortuneEventReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAttendanceFortuneEventReward, Common.CG_RequestAttendanceFortuneEventReward);
        }

        public bool CG_RequestEventCookingStart(HostID remote, RmiContext rmiContext, int eventSeq, CookingRequest cookingRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventCookingStart);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, cookingRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventCookingStart, Common.CG_RequestEventCookingStart);
        }

        public bool CG_RequestEventRecipeActive(HostID remote, RmiContext rmiContext, int eventSeq, int recipeID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRecipeActive);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, recipeID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRecipeActive, Common.CG_RequestEventRecipeActive);
        }

        public bool CG_RequestLobbySetVisualType(HostID remote, RmiContext rmiContext, LobbyVisualType lobbyVisualType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbySetVisualType);
            CommonPacket.Marshaler.Write(message, lobbyVisualType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbySetVisualType, Common.CG_RequestLobbySetVisualType);
        }

        public bool CG_RequestLobbySetAttendanceHero(HostID remote, RmiContext rmiContext, int attendanceHeroID, int activeAttendanceHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLobbySetAttendanceHero);
            CommonPacket.Marshaler.Write(message, attendanceHeroID);
            CommonPacket.Marshaler.Write(message, activeAttendanceHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLobbySetAttendanceHero, Common.CG_RequestLobbySetAttendanceHero);
        }

        public bool CG_RequestBasePointGoldDonation(HostID remote, RmiContext rmiContext, int basePointID, int useItemID, int useItemCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointGoldDonation);
            CommonPacket.Marshaler.Write(message, basePointID);
            CommonPacket.Marshaler.Write(message, useItemID);
            CommonPacket.Marshaler.Write(message, useItemCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointGoldDonation, Common.CG_RequestBasePointGoldDonation);
        }

        public bool CG_RequestBasePointSetTrigger(HostID remote, RmiContext rmiContext, int triggerID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointSetTrigger);
            CommonPacket.Marshaler.Write(message, triggerID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointSetTrigger, Common.CG_RequestBasePointSetTrigger);
        }

        public bool CG_RequestBasePointDropInteractiveOpen(HostID remote, RmiContext rmiContext, int npcID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointDropInteractiveOpen);
            CommonPacket.Marshaler.Write(message, npcID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointDropInteractiveOpen, Common.CG_RequestBasePointDropInteractiveOpen);
        }

        public bool CG_RequestBasePointUniqueInteractiveOpen(HostID remote, RmiContext rmiContext, int npcID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointUniqueInteractiveOpen);
            CommonPacket.Marshaler.Write(message, npcID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointUniqueInteractiveOpen, Common.CG_RequestBasePointUniqueInteractiveOpen);
        }

        public bool CG_RequestBasePointDailyReward(HostID remote, RmiContext rmiContext, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointDailyReward);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointDailyReward, Common.CG_RequestBasePointDailyReward);
        }

        public bool CG_RequestBasePointDonationEventReward(HostID remote, RmiContext rmiContext, int basepointID, int eventSeq, List<byte> rewardIndexList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointDonationEventReward);
            CommonPacket.Marshaler.Write(message, basepointID);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, rewardIndexList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointDonationEventReward, Common.CG_RequestBasePointDonationEventReward);
        }

        public bool CG_RequestBasePointDonationInfo(HostID remote, RmiContext rmiContext, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointDonationInfo);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointDonationInfo, Common.CG_RequestBasePointDonationInfo);
        }

        public bool CG_RequestBasePointEventGoldDonation(HostID remote, RmiContext rmiContext, int eventSeq, int basepointID, int useItemID, int useItemCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBasePointEventGoldDonation);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, basepointID);
            CommonPacket.Marshaler.Write(message, useItemID);
            CommonPacket.Marshaler.Write(message, useItemCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBasePointEventGoldDonation, Common.CG_RequestBasePointEventGoldDonation);
        }

        public bool CG_RequestEventBasepointInfo(HostID remote, RmiContext rmiContext, int eventSeq, int basepointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBasepointInfo);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, basepointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBasepointInfo, Common.CG_RequestEventBasepointInfo);
        }

        public bool CG_RequestDestroySetInviteOption(HostID remote, RmiContext rmiContext, DestroyInviteOption option)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroySetInviteOption);
            CommonPacket.Marshaler.Write(message, option);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroySetInviteOption, Common.CG_RequestDestroySetInviteOption);
        }

        public bool CG_RequestDestroyGetUserLoginList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyGetUserLoginList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyGetUserLoginList, Common.CG_RequestDestroyGetUserLoginList);
        }

        public bool CG_RequestDestroyGetFriendLoginList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyGetFriendLoginList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyGetFriendLoginList, Common.CG_RequestDestroyGetFriendLoginList);
        }

        public bool CG_RequestDestroyGetGuildLoginList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyGetGuildLoginList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyGetGuildLoginList, Common.CG_RequestDestroyGetGuildLoginList);
        }

        public bool CG_RequestDestroyGetReceivedInvitationList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyGetReceivedInvitationList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyGetReceivedInvitationList, Common.CG_RequestDestroyGetReceivedInvitationList);
        }

        public bool CG_RequestDestroyInvite(HostID remote, RmiContext rmiContext, List<long> invitedUSNList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyInvite);
            CommonPacket.Marshaler.Write(message, invitedUSNList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyInvite, Common.CG_RequestDestroyInvite);
        }

        public bool CG_RequestDestroyRemoveInvitation(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyRemoveInvitation);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyRemoveInvitation, Common.CG_RequestDestroyRemoveInvitation);
        }

        public bool CG_RequestDestroyRemoveJoinInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyRemoveJoinInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyRemoveJoinInfo, Common.CG_RequestDestroyRemoveJoinInfo);
        }

        public bool CG_RequestDestroyCreate(HostID remote, RmiContext rmiContext, int destroyGroupID, byte difficulty, bool isMultiClear)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyCreate);
            CommonPacket.Marshaler.Write(message, destroyGroupID);
            CommonPacket.Marshaler.Write(message, difficulty);
            CommonPacket.Marshaler.Write(message, isMultiClear);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyCreate, Common.CG_RequestDestroyCreate);
        }

        public bool CG_RequestDestroyJoin(HostID remote, RmiContext rmiContext, int roomSN, bool isLiveJoin)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyJoin);
            CommonPacket.Marshaler.Write(message, roomSN);
            CommonPacket.Marshaler.Write(message, isLiveJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyJoin, Common.CG_RequestDestroyJoin);
        }

        public bool CG_RequestDestroyStart(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyStart);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyStart, Common.CG_RequestDestroyStart);
        }

        public bool CG_RequestDestroyBattleStart(HostID remote, RmiContext rmiContext, int roomSN, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyBattleStart);
            CommonPacket.Marshaler.Write(message, roomSN);
            CommonPacket.Marshaler.Write(message, skinStatInfoList);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyBattleStart, Common.CG_RequestDestroyBattleStart);
        }

        public bool CG_RequestDestroyClear(HostID remote, RmiContext rmiContext, DestroyClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyClear);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyClear, Common.CG_RequestDestroyClear);
        }

        public bool CG_RequestDestroyReJoin(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyReJoin);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyReJoin, Common.CG_RequestDestroyReJoin);
        }

        public bool CG_RequestDestroyRemove(HostID remote, RmiContext rmiContext, byte region)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyRemove);
            CommonPacket.Marshaler.Write(message, region);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyRemove, Common.CG_RequestDestroyRemove);
        }

        public bool CG_RequestDestroyBattleEnd(HostID remote, RmiContext rmiContext, DestroyExitRequest exitRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyBattleEnd);
            CommonPacket.Marshaler.Write(message, exitRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyBattleEnd, Common.CG_RequestDestroyBattleEnd);
        }

        public bool CG_RequestDestroyInviteAI(HostID remote, RmiContext rmiContext, int roomSN, long invitedAIUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyInviteAI);
            CommonPacket.Marshaler.Write(message, roomSN);
            CommonPacket.Marshaler.Write(message, invitedAIUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyInviteAI, Common.CG_RequestDestroyInviteAI);
        }

        public bool CG_RequestDestroyKickOutAI(HostID remote, RmiContext rmiContext, int roomSN, long kickoutUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyKickOutAI);
            CommonPacket.Marshaler.Write(message, roomSN);
            CommonPacket.Marshaler.Write(message, kickoutUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyKickOutAI, Common.CG_RequestDestroyKickOutAI);
        }

        public bool CG_RequestEventDestroyCreate(HostID remote, RmiContext rmiContext, int eventSeq, int destroyGroupID, byte difficulty)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDestroyCreate);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, destroyGroupID);
            CommonPacket.Marshaler.Write(message, difficulty);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDestroyCreate, Common.CG_RequestEventDestroyCreate);
        }

        public bool CG_RequestEventDestroyStart(HostID remote, RmiContext rmiContext, int eventSeq, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDestroyStart);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDestroyStart, Common.CG_RequestEventDestroyStart);
        }

        public bool CG_RequestEventDestroyClear(HostID remote, RmiContext rmiContext, int eventSeq, DestroyClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDestroyClear);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDestroyClear, Common.CG_RequestEventDestroyClear);
        }

        public bool CG_RequestEventDestroyRemove(HostID remote, RmiContext rmiContext, int eventSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDestroyRemove);
            CommonPacket.Marshaler.Write(message, eventSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDestroyRemove, Common.CG_RequestEventDestroyRemove);
        }

        public bool CG_RequestEventChallengeDestroyCreate(HostID remote, RmiContext rmiContext, int eventSeq, int destroyGroupID, byte difficulty)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventChallengeDestroyCreate);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, destroyGroupID);
            CommonPacket.Marshaler.Write(message, difficulty);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventChallengeDestroyCreate, Common.CG_RequestEventChallengeDestroyCreate);
        }

        public bool CG_RequestEventChallengeDestroyStart(HostID remote, RmiContext rmiContext, int eventSeq, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventChallengeDestroyStart);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventChallengeDestroyStart, Common.CG_RequestEventChallengeDestroyStart);
        }

        public bool CG_RequestEventChallengeDestroyClear(HostID remote, RmiContext rmiContext, int eventSeq, DestroyClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventChallengeDestroyClear);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventChallengeDestroyClear, Common.CG_RequestEventChallengeDestroyClear);
        }

        public bool CG_RequestEventChallengeDestroyPointRefresh(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventChallengeDestroyPointRefresh);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventChallengeDestroyPointRefresh, Common.CG_RequestEventChallengeDestroyPointRefresh);
        }

        public bool CG_RequestEventChallengeDestroyUserReward(HostID remote, RmiContext rmiContext, int eventSEQ, int step)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventChallengeDestroyUserReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, step);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventChallengeDestroyUserReward, Common.CG_RequestEventChallengeDestroyUserReward);
        }

        public bool CG_RequestEventChallengeDestroyWorldReward(HostID remote, RmiContext rmiContext, int eventSEQ, int step)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventChallengeDestroyWorldReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, step);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventChallengeDestroyWorldReward, Common.CG_RequestEventChallengeDestroyWorldReward);
        }

        public bool CG_RequestDisasterDestroyCreate(HostID remote, RmiContext rmiContext, int seasonID, int destroyGroupID, byte difficulty)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDisasterDestroyCreate);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, destroyGroupID);
            CommonPacket.Marshaler.Write(message, difficulty);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDisasterDestroyCreate, Common.CG_RequestDisasterDestroyCreate);
        }

        public bool CG_RequestDisasterDestroyStart(HostID remote, RmiContext rmiContext, int seasonID, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDisasterDestroyStart);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDisasterDestroyStart, Common.CG_RequestDisasterDestroyStart);
        }

        public bool CG_RequestDisasterDestroyClear(HostID remote, RmiContext rmiContext, int seasonID, DestroyClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDisasterDestroyClear);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDisasterDestroyClear, Common.CG_RequestDisasterDestroyClear);
        }

        public bool CG_RequestEventDisasterDestroyCreate(HostID remote, RmiContext rmiContext, int destroyGroupID, byte difficulty)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDisasterDestroyCreate);
            CommonPacket.Marshaler.Write(message, destroyGroupID);
            CommonPacket.Marshaler.Write(message, difficulty);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDisasterDestroyCreate, Common.CG_RequestEventDisasterDestroyCreate);
        }

        public bool CG_RequestEventDisasterDestroyStart(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDisasterDestroyStart);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDisasterDestroyStart, Common.CG_RequestEventDisasterDestroyStart);
        }

        public bool CG_RequestEventDisasterDestroyClear(HostID remote, RmiContext rmiContext, DestroyClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDisasterDestroyClear);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDisasterDestroyClear, Common.CG_RequestEventDisasterDestroyClear);
        }

        public bool CG_RequestEventDisasterDestroyLeave(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDisasterDestroyLeave);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDisasterDestroyLeave, Common.CG_RequestEventDisasterDestroyLeave);
        }

        public bool CG_RequestDestroyOtherPlayerTeamInfo(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyOtherPlayerTeamInfo);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyOtherPlayerTeamInfo, Common.CG_RequestDestroyOtherPlayerTeamInfo);
        }

        public bool CG_RequestDestroyLiveJoinRegister(HostID remote, RmiContext rmiContext, int groupID, byte difficulty, int battlePoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyLiveJoinRegister);
            CommonPacket.Marshaler.Write(message, groupID);
            CommonPacket.Marshaler.Write(message, difficulty);
            CommonPacket.Marshaler.Write(message, battlePoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyLiveJoinRegister, Common.CG_RequestDestroyLiveJoinRegister);
        }

        public bool CG_RequestDestroyLiveJoinUnregister(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyLiveJoinUnregister);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyLiveJoinUnregister, Common.CG_RequestDestroyLiveJoinUnregister);
        }

        public bool CG_RequestDestroyLiveJoinList(HostID remote, RmiContext rmiContext, int battlePoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyLiveJoinList);
            CommonPacket.Marshaler.Write(message, battlePoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyLiveJoinList, Common.CG_RequestDestroyLiveJoinList);
        }

        public bool CG_RequestDestroyLiveJoinInvite(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyLiveJoinInvite);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyLiveJoinInvite, Common.CG_RequestDestroyLiveJoinInvite);
        }

        public bool CG_RequestDestroyLiveJoinAbortInvitation(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyLiveJoinAbortInvitation);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyLiveJoinAbortInvitation, Common.CG_RequestDestroyLiveJoinAbortInvitation);
        }

        public bool CG_RequestDestroyLiveJoinRejectInvitation(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyLiveJoinRejectInvitation);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyLiveJoinRejectInvitation, Common.CG_RequestDestroyLiveJoinRejectInvitation);
        }

        public bool CG_RequestDestroyRoomInfo(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDestroyRoomInfo);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDestroyRoomInfo, Common.CG_RequestDestroyRoomInfo);
        }

        public bool CG_RequestFriendList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendList, Common.CG_RequestFriendList);
        }

        public bool CG_RequestFriendGuildInfo(HostID remote, RmiContext rmiContext, long friendUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendGuildInfo);
            CommonPacket.Marshaler.Write(message, friendUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendGuildInfo, Common.CG_RequestFriendGuildInfo);
        }

        public bool CG_RequestFriendApplySendList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplySendList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplySendList, Common.CG_RequestFriendApplySendList);
        }

        public bool CG_RequestFriendApplyReceiveList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplyReceiveList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplyReceiveList, Common.CG_RequestFriendApplyReceiveList);
        }

        public bool CG_RequestFriendApplySend(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplySend);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplySend, Common.CG_RequestFriendApplySend);
        }

        public bool CG_RequestFriendApplyReject(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplyReject);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplyReject, Common.CG_RequestFriendApplyReject);
        }

        public bool CG_RequestFriendApplyReceiveAccept(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplyReceiveAccept);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplyReceiveAccept, Common.CG_RequestFriendApplyReceiveAccept);
        }

        public bool CG_RequestFriendApplyReceiveAcceptList(HostID remote, RmiContext rmiContext, List<long> targetUSNList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplyReceiveAcceptList);
            CommonPacket.Marshaler.Write(message, targetUSNList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplyReceiveAcceptList, Common.CG_RequestFriendApplyReceiveAcceptList);
        }

        public bool CG_RequestFriendApplyReceiveRefuse(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplyReceiveRefuse);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplyReceiveRefuse, Common.CG_RequestFriendApplyReceiveRefuse);
        }

        public bool CG_RequestFriendApplyReceiveRefuseList(HostID remote, RmiContext rmiContext, List<long> targetUSNList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendApplyReceiveRefuseList);
            CommonPacket.Marshaler.Write(message, targetUSNList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendApplyReceiveRefuseList, Common.CG_RequestFriendApplyReceiveRefuseList);
        }

        public bool CG_RequestFriendRemove(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendRemove);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendRemove, Common.CG_RequestFriendRemove);
        }

        public bool CG_RequestFriendSearch(HostID remote, RmiContext rmiContext, int friendID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendSearch);
            CommonPacket.Marshaler.Write(message, friendID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendSearch, Common.CG_RequestFriendSearch);
        }

        public bool CG_RequestFriendVisit(HostID remote, RmiContext rmiContext, long friendUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendVisit);
            CommonPacket.Marshaler.Write(message, friendUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendVisit, Common.CG_RequestFriendVisit);
        }

        public bool CG_RequestFriendPointSend(HostID remote, RmiContext rmiContext, long friendUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendPointSend);
            CommonPacket.Marshaler.Write(message, friendUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendPointSend, Common.CG_RequestFriendPointSend);
        }

        public bool CG_RequestFriendPointSendAll(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendPointSendAll);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendPointSendAll, Common.CG_RequestFriendPointSendAll);
        }

        public bool CG_RequestFriendLobbyInfo(HostID remote, RmiContext rmiContext, long friendUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendLobbyInfo);
            CommonPacket.Marshaler.Write(message, friendUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendLobbyInfo, Common.CG_RequestFriendLobbyInfo);
        }

        public bool CG_RequestFriendCookingRecipeInfo(HostID remote, RmiContext rmiContext, long friendUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendCookingRecipeInfo);
            CommonPacket.Marshaler.Write(message, friendUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendCookingRecipeInfo, Common.CG_RequestFriendCookingRecipeInfo);
        }

        public bool CG_RequestFriendCookingEat(HostID remote, RmiContext rmiContext, long friendUSN, int recipeI)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendCookingEat);
            CommonPacket.Marshaler.Write(message, friendUSN);
            CommonPacket.Marshaler.Write(message, recipeI);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendCookingEat, Common.CG_RequestFriendCookingEat);
        }

        public bool CG_RequestFriendCookingEatFriendList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendCookingEatFriendList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendCookingEatFriendList, Common.CG_RequestFriendCookingEatFriendList);
        }

        public bool CG_RequestRefreshRecommendFriendList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRefreshRecommendFriendList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRefreshRecommendFriendList, Common.CG_RequestRefreshRecommendFriendList);
        }

        public bool CG_RequestGuildRecommendList(HostID remote, RmiContext rmiContext, bool isRefresh, bool defaultLanguage)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildRecommendList);
            CommonPacket.Marshaler.Write(message, isRefresh);
            CommonPacket.Marshaler.Write(message, defaultLanguage);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildRecommendList, Common.CG_RequestGuildRecommendList);
        }

        public bool CG_RequestGuildInfoWithMemberList(HostID remote, RmiContext rmiContext, int guildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildInfoWithMemberList);
            CommonPacket.Marshaler.Write(message, guildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildInfoWithMemberList, Common.CG_RequestGuildInfoWithMemberList);
        }

        public bool CG_RequestGuildSearchByName(HostID remote, RmiContext rmiContext, string guildName, bool defaultLanguage)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildSearchByName);
            CommonPacket.Marshaler.Write(message, guildName);
            CommonPacket.Marshaler.Write(message, defaultLanguage);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildSearchByName, Common.CG_RequestGuildSearchByName);
        }

        public bool CG_RequestGuildCreate(HostID remote, RmiContext rmiContext, GuildSetupInfo setupInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildCreate);
            CommonPacket.Marshaler.Write(message, setupInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildCreate, Common.CG_RequestGuildCreate);
        }

        public bool CG_RequestGuildDisband(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildDisband);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildDisband, Common.CG_RequestGuildDisband);
        }

        public bool CG_RequestGuildApplicantList(HostID remote, RmiContext rmiContext, int guildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildApplicantList);
            CommonPacket.Marshaler.Write(message, guildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildApplicantList, Common.CG_RequestGuildApplicantList);
        }

        public bool CG_RequestGuildApply(HostID remote, RmiContext rmiContext, int guildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildApply);
            CommonPacket.Marshaler.Write(message, guildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildApply, Common.CG_RequestGuildApply);
        }

        public bool CG_RequestGuildReturnApplication(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildReturnApplication);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildReturnApplication, Common.CG_RequestGuildReturnApplication);
        }

        public bool CG_RequestGuildAcceptApplicant(HostID remote, RmiContext rmiContext, long applicantUsn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildAcceptApplicant);
            CommonPacket.Marshaler.Write(message, applicantUsn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildAcceptApplicant, Common.CG_RequestGuildAcceptApplicant);
        }

        public bool CG_RequestGuildRejectApplicant(HostID remote, RmiContext rmiContext, long applicantUsn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildRejectApplicant);
            CommonPacket.Marshaler.Write(message, applicantUsn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildRejectApplicant, Common.CG_RequestGuildRejectApplicant);
        }

        public bool CG_RequestGuildLevelUp(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildLevelUp);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildLevelUp, Common.CG_RequestGuildLevelUp);
        }

        public bool CG_RequestGuildChangeName(HostID remote, RmiContext rmiContext, string newGuildName)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildChangeName);
            CommonPacket.Marshaler.Write(message, newGuildName);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildChangeName, Common.CG_RequestGuildChangeName);
        }

        public bool CG_RequestGuildChangeBoard(HostID remote, RmiContext rmiContext, GuildSetupInfo setupInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildChangeBoard);
            CommonPacket.Marshaler.Write(message, setupInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildChangeBoard, Common.CG_RequestGuildChangeBoard);
        }

        public bool CG_RequestGuildChangeMaster(HostID remote, RmiContext rmiContext, long newMasterUsn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildChangeMaster);
            CommonPacket.Marshaler.Write(message, newMasterUsn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildChangeMaster, Common.CG_RequestGuildChangeMaster);
        }

        public bool CG_RequestGuildChangeMemberGrade(HostID remote, RmiContext rmiContext, long targetUsn, GuildMemberGrade targetGrade)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildChangeMemberGrade);
            CommonPacket.Marshaler.Write(message, targetUsn);
            CommonPacket.Marshaler.Write(message, targetGrade);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildChangeMemberGrade, Common.CG_RequestGuildChangeMemberGrade);
        }

        public bool CG_RequestGuildKickOutMember(HostID remote, RmiContext rmiContext, long targetUsn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildKickOutMember);
            CommonPacket.Marshaler.Write(message, targetUsn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildKickOutMember, Common.CG_RequestGuildKickOutMember);
        }

        public bool CG_RequestGuildLeave(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildLeave);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildLeave, Common.CG_RequestGuildLeave);
        }

        public bool CG_RequestGuildRoomInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildRoomInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildRoomInfo, Common.CG_RequestGuildRoomInfo);
        }

        public bool CG_RequestGuildAttendance(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildAttendance);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildAttendance, Common.CG_RequestGuildAttendance);
        }

        public bool CG_RequestGuildAttendanceReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildAttendanceReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildAttendanceReward, Common.CG_RequestGuildAttendanceReward);
        }

        public bool CG_RequestGuildUserInfo(HostID remote, RmiContext rmiContext, long usn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildUserInfo);
            CommonPacket.Marshaler.Write(message, usn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildUserInfo, Common.CG_RequestGuildUserInfo);
        }

        public bool CG_RequestGuildAttendanceStatus(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildAttendanceStatus);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildAttendanceStatus, Common.CG_RequestGuildAttendanceStatus);
        }

        public bool CG_RequestGuildDonation(HostID remote, RmiContext rmiContext, GuildDonation guildDonation)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildDonation);
            CommonPacket.Marshaler.Write(message, guildDonation);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildDonation, Common.CG_RequestGuildDonation);
        }

        public bool CG_RequestGuildDonationInitialize(HostID remote, RmiContext rmiContext, byte donationID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildDonationInitialize);
            CommonPacket.Marshaler.Write(message, donationID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildDonationInitialize, Common.CG_RequestGuildDonationInitialize);
        }

        public bool CG_RequestGuildMissionInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildMissionInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildMissionInfo, Common.CG_RequestGuildMissionInfo);
        }

        public bool CG_RequestGuildMissionReward(HostID remote, RmiContext rmiContext, List<int> guildMissionIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildMissionReward);
            CommonPacket.Marshaler.Write(message, guildMissionIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildMissionReward, Common.CG_RequestGuildMissionReward);
        }

        public bool CG_RequestGuildDonationInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildDonationInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildDonationInfo, Common.CG_RequestGuildDonationInfo);
        }

        public bool CG_RequestGuildSkillInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildSkillInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildSkillInfo, Common.CG_RequestGuildSkillInfo);
        }

        public bool CG_RequestGuildSkillLevelUp(HostID remote, RmiContext rmiContext, int currentSkillID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildSkillLevelUp);
            CommonPacket.Marshaler.Write(message, currentSkillID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildSkillLevelUp, Common.CG_RequestGuildSkillLevelUp);
        }

        public bool CG_RequestGuildSkillUse(HostID remote, RmiContext rmiContext, byte slotNo, int skillID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildSkillUse);
            CommonPacket.Marshaler.Write(message, slotNo);
            CommonPacket.Marshaler.Write(message, skillID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildSkillUse, Common.CG_RequestGuildSkillUse);
        }

        public bool CG_RequestGuildSkillDisuse(HostID remote, RmiContext rmiContext, byte slotNo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildSkillDisuse);
            CommonPacket.Marshaler.Write(message, slotNo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildSkillDisuse, Common.CG_RequestGuildSkillDisuse);
        }

        public bool CG_RequestGuildSkillUseInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildSkillUseInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildSkillUseInfo, Common.CG_RequestGuildSkillUseInfo);
        }

        public bool CG_RequestGuildBossRankPointReward(HostID remote, RmiContext rmiContext, short rewardOrder, bool isNormal)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildBossRankPointReward);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            CommonPacket.Marshaler.Write(message, isNormal);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildBossRankPointReward, Common.CG_RequestGuildBossRankPointReward);
        }

        public bool CG_RequestGuildBattlePointRegister(HostID remote, RmiContext rmiContext, GuildBattlePointType type, List<UserTeamSlot> mainSlotList, int battlePoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildBattlePointRegister);
            CommonPacket.Marshaler.Write(message, type);
            CommonPacket.Marshaler.Write(message, mainSlotList);
            CommonPacket.Marshaler.Write(message, battlePoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildBattlePointRegister, Common.CG_RequestGuildBattlePointRegister);
        }

        public bool CG_RequestGuildBattlePointMemeberRankList(HostID remote, RmiContext rmiContext, GuildBattlePointType type)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildBattlePointMemeberRankList);
            CommonPacket.Marshaler.Write(message, type);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildBattlePointMemeberRankList, Common.CG_RequestGuildBattlePointMemeberRankList);
        }

        public bool CG_RequestGuildBattlePointGuildRankList(HostID remote, RmiContext rmiContext, GuildBattlePointType type)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildBattlePointGuildRankList);
            CommonPacket.Marshaler.Write(message, type);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildBattlePointGuildRankList, Common.CG_RequestGuildBattlePointGuildRankList);
        }

        public bool CG_RequestGuildBattlePointUserRankList(HostID remote, RmiContext rmiContext, GuildBattlePointType type)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildBattlePointUserRankList);
            CommonPacket.Marshaler.Write(message, type);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildBattlePointUserRankList, Common.CG_RequestGuildBattlePointUserRankList);
        }

        public bool CG_RequestGuildInvitationReceivedList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildInvitationReceivedList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildInvitationReceivedList, Common.CG_RequestGuildInvitationReceivedList);
        }

        public bool CG_RequestGuildInvitationSend(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildInvitationSend);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildInvitationSend, Common.CG_RequestGuildInvitationSend);
        }

        public bool CG_RequestGuildInvitationRemove(HostID remote, RmiContext rmiContext, int guildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildInvitationRemove);
            CommonPacket.Marshaler.Write(message, guildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildInvitationRemove, Common.CG_RequestGuildInvitationRemove);
        }

        public bool CG_RequestGuildInvitationSetOption(HostID remote, RmiContext rmiContext, bool isGuildInvitationOn)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildInvitationSetOption);
            CommonPacket.Marshaler.Write(message, isGuildInvitationOn);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildInvitationSetOption, Common.CG_RequestGuildInvitationSetOption);
        }

        public bool CG_RequestGuildMarkInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildMarkInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildMarkInfo, Common.CG_RequestGuildMarkInfo);
        }

        public bool CG_RequestGuildRecruitList(HostID remote, RmiContext rmiContext, bool isRefresh, bool defaultLanguage, GuildRecruitSearchType searchType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildRecruitList);
            CommonPacket.Marshaler.Write(message, isRefresh);
            CommonPacket.Marshaler.Write(message, defaultLanguage);
            CommonPacket.Marshaler.Write(message, searchType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildRecruitList, Common.CG_RequestGuildRecruitList);
        }

        public bool CG_RequestGuildRecruitApply(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildRecruitApply);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildRecruitApply, Common.CG_RequestGuildRecruitApply);
        }

        public bool CG_RequestGuildRecruitCancel(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildRecruitCancel);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildRecruitCancel, Common.CG_RequestGuildRecruitCancel);
        }

        public bool CG_RequestAPRechargeByUseItem(HostID remote, RmiContext rmiContext, int useItemID, int useCount, bool isADView)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAPRechargeByUseItem);
            CommonPacket.Marshaler.Write(message, useItemID);
            CommonPacket.Marshaler.Write(message, useCount);
            CommonPacket.Marshaler.Write(message, isADView);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAPRechargeByUseItem, Common.CG_RequestAPRechargeByUseItem);
        }

        public bool CG_RequestWeekStageKeyOpen(HostID remote, RmiContext rmiContext, int areaID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeekStageKeyOpen);
            CommonPacket.Marshaler.Write(message, areaID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeekStageKeyOpen, Common.CG_RequestWeekStageKeyOpen);
        }

        public bool CG_RequestFoodBuffAutoUseOnOff(HostID remote, RmiContext rmiContext, bool isAutoUse)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFoodBuffAutoUseOnOff);
            CommonPacket.Marshaler.Write(message, isAutoUse);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFoodBuffAutoUseOnOff, Common.CG_RequestFoodBuffAutoUseOnOff);
        }

        public bool CG_RequestItemUseRankExp(HostID remote, RmiContext rmiContext, int itemID, int itemUseCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemUseRankExp);
            CommonPacket.Marshaler.Write(message, itemID);
            CommonPacket.Marshaler.Write(message, itemUseCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemUseRankExp, Common.CG_RequestItemUseRankExp);
        }

        public bool CG_RequestItemUseBoxOpen(HostID remote, RmiContext rmiContext, int itemID, int itemUseCount, string codeAnswer)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemUseBoxOpen);
            CommonPacket.Marshaler.Write(message, itemID);
            CommonPacket.Marshaler.Write(message, itemUseCount);
            CommonPacket.Marshaler.Write(message, codeAnswer);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemUseBoxOpen, Common.CG_RequestItemUseBoxOpen);
        }

        public bool CG_RequestItemUseRecipeExp(HostID remote, RmiContext rmiContext, int itemID, int itemUseCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemUseRecipeExp);
            CommonPacket.Marshaler.Write(message, itemID);
            CommonPacket.Marshaler.Write(message, itemUseCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemUseRecipeExp, Common.CG_RequestItemUseRecipeExp);
        }

        public bool CG_RequestItemUseWeeklyKeyBox(HostID remote, RmiContext rmiContext, int useItemID, int useCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemUseWeeklyKeyBox);
            CommonPacket.Marshaler.Write(message, useItemID);
            CommonPacket.Marshaler.Write(message, useCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemUseWeeklyKeyBox, Common.CG_RequestItemUseWeeklyKeyBox);
        }

        public bool CG_RequestItemUseWeaponTicket(HostID remote, RmiContext rmiContext, int useItemID, int selectedDBID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemUseWeaponTicket);
            CommonPacket.Marshaler.Write(message, useItemID);
            CommonPacket.Marshaler.Write(message, selectedDBID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemUseWeaponTicket, Common.CG_RequestItemUseWeaponTicket);
        }

        public bool CG_RequestItemUseMusic(HostID remote, RmiContext rmiContext, int useItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemUseMusic);
            CommonPacket.Marshaler.Write(message, useItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemUseMusic, Common.CG_RequestItemUseMusic);
        }

        public bool CG_RequestItemUseBuff(HostID remote, RmiContext rmiContext, int useItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestItemUseBuff);
            CommonPacket.Marshaler.Write(message, useItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestItemUseBuff, Common.CG_RequestItemUseBuff);
        }

        public bool CG_RequestWeekStageCoinOpen(HostID remote, RmiContext rmiContext, int areaID, List<UserCommonItem> useItemInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWeekStageCoinOpen);
            CommonPacket.Marshaler.Write(message, areaID);
            CommonPacket.Marshaler.Write(message, useItemInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWeekStageCoinOpen, Common.CG_RequestWeekStageCoinOpen);
        }

        public bool CG_RequestTutorialAddStep(HostID remote, RmiContext rmiContext, int tutorialStep)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTutorialAddStep);
            CommonPacket.Marshaler.Write(message, tutorialStep);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTutorialAddStep, Common.CG_RequestTutorialAddStep);
        }

        public bool CG_RequestTutorialSetFlag(HostID remote, RmiContext rmiContext, TutorialType tutorialType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTutorialSetFlag);
            CommonPacket.Marshaler.Write(message, tutorialType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTutorialSetFlag, Common.CG_RequestTutorialSetFlag);
        }

        public bool CG_RequestTutorialHeroFlag(HostID remote, RmiContext rmiContext, TutorialType tutorialType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTutorialHeroFlag);
            CommonPacket.Marshaler.Write(message, tutorialType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTutorialHeroFlag, Common.CG_RequestTutorialHeroFlag);
        }

        public bool CG_RequestTutorialGambleShopBuy(HostID remote, RmiContext rmiContext, int tutorialStep)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTutorialGambleShopBuy);
            CommonPacket.Marshaler.Write(message, tutorialStep);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTutorialGambleShopBuy, Common.CG_RequestTutorialGambleShopBuy);
        }

        public bool CG_RequestBattleTutorialInfo(HostID remote, RmiContext rmiContext, string netmarblePlayerID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBattleTutorialInfo);
            CommonPacket.Marshaler.Write(message, netmarblePlayerID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBattleTutorialInfo, Common.CG_RequestBattleTutorialInfo);
        }

        public bool CG_RequestBattleTutorialSet(HostID remote, RmiContext rmiContext, string netmarblePlayerID, byte battleTutorialSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestBattleTutorialSet);
            CommonPacket.Marshaler.Write(message, netmarblePlayerID);
            CommonPacket.Marshaler.Write(message, battleTutorialSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestBattleTutorialSet, Common.CG_RequestBattleTutorialSet);
        }

        public bool CG_RequestFriendlyMatchCreate(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchCreate);
            CommonPacket.Marshaler.Write(message, matchMode);
            CommonPacket.Marshaler.Write(message, modeID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchCreate, Common.CG_RequestFriendlyMatchCreate);
        }

        public bool CG_RequestFriendlyMatchFriendList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchFriendList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchFriendList, Common.CG_RequestFriendlyMatchFriendList);
        }

        public bool CG_RequestFriendlyMatchInvite(HostID remote, RmiContext rmiContext, List<long> friendUSNList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchInvite);
            CommonPacket.Marshaler.Write(message, friendUSNList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchInvite, Common.CG_RequestFriendlyMatchInvite);
        }

        public bool CG_RequestFriendlyMatchReceivedInviteList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchReceivedInviteList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchReceivedInviteList, Common.CG_RequestFriendlyMatchReceivedInviteList);
        }

        public bool CG_RequestFriendlyMatchInviteAccept(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchInviteAccept);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchInviteAccept, Common.CG_RequestFriendlyMatchInviteAccept);
        }

        public bool CG_RequestFriendlyMatchInviteReject(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchInviteReject);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchInviteReject, Common.CG_RequestFriendlyMatchInviteReject);
        }

        public bool CG_RequestFriendlyMatchStart(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchStart);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchStart, Common.CG_RequestFriendlyMatchStart);
        }

        public bool CG_RequestFriendlyMatchBattleStart(HostID remote, RmiContext rmiContext, int roomSN, int battlePowerPoint, OtherPlayerTeamInfo teamInfo, List<SkinStatInfo> skinStatInfoList, long otherUSN, byte otherTeamIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchBattleStart);
            CommonPacket.Marshaler.Write(message, roomSN);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            CommonPacket.Marshaler.Write(message, teamInfo);
            CommonPacket.Marshaler.Write(message, skinStatInfoList);
            CommonPacket.Marshaler.Write(message, otherUSN);
            CommonPacket.Marshaler.Write(message, otherTeamIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchBattleStart, Common.CG_RequestFriendlyMatchBattleStart);
        }

        public bool CG_RequestFriendlyMatchClear(HostID remote, RmiContext rmiContext, FriendlyMatchClearRequest clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchClear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchClear, Common.CG_RequestFriendlyMatchClear);
        }

        public bool CG_RequestFriendlyMatchExit(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchExit);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchExit, Common.CG_RequestFriendlyMatchExit);
        }

        public bool CG_RequestFriendlyMatchSetInviteOption(HostID remote, RmiContext rmiContext, FriendlyMatchInviteOption option)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchSetInviteOption);
            CommonPacket.Marshaler.Write(message, option);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchSetInviteOption, Common.CG_RequestFriendlyMatchSetInviteOption);
        }

        public bool CG_RequestFriendlyMatchObserveCreate(HostID remote, RmiContext rmiContext, byte matchMode, byte modeID, byte passiveID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveCreate);
            CommonPacket.Marshaler.Write(message, matchMode);
            CommonPacket.Marshaler.Write(message, modeID);
            CommonPacket.Marshaler.Write(message, passiveID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveCreate, Common.CG_RequestFriendlyMatchObserveCreate);
        }

        public bool CG_RequestFriendlyMatchObserveFriendList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveFriendList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveFriendList, Common.CG_RequestFriendlyMatchObserveFriendList);
        }

        public bool CG_RequestFriendlyMatchObserveInvite(HostID remote, RmiContext rmiContext, List<long> friendUSNList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveInvite);
            CommonPacket.Marshaler.Write(message, friendUSNList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveInvite, Common.CG_RequestFriendlyMatchObserveInvite);
        }

        public bool CG_RequestFriendlyMatchObserveReceivedInviteList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveReceivedInviteList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveReceivedInviteList, Common.CG_RequestFriendlyMatchObserveReceivedInviteList);
        }

        public bool CG_RequestFriendlyMatchObserveInviteAccept(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveInviteAccept);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveInviteAccept, Common.CG_RequestFriendlyMatchObserveInviteAccept);
        }

        public bool CG_RequestFriendlyMatchObserveInviteReject(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveInviteReject);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveInviteReject, Common.CG_RequestFriendlyMatchObserveInviteReject);
        }

        public bool CG_RequestFriendlyMatchObserveStart(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveStart);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveStart, Common.CG_RequestFriendlyMatchObserveStart);
        }

        public bool CG_RequestFriendlyMatchObserveBattleStart(HostID remote, RmiContext rmiContext, int roomSN, int battlePowerPoint, OtherPlayerTeamInfo teamInfo, List<SkinStatInfo> skinStatInfoList, long otherUSN, byte otherTeamIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveBattleStart);
            CommonPacket.Marshaler.Write(message, roomSN);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            CommonPacket.Marshaler.Write(message, teamInfo);
            CommonPacket.Marshaler.Write(message, skinStatInfoList);
            CommonPacket.Marshaler.Write(message, otherUSN);
            CommonPacket.Marshaler.Write(message, otherTeamIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveBattleStart, Common.CG_RequestFriendlyMatchObserveBattleStart);
        }

        public bool CG_RequestFriendlyMatchObserveClear(HostID remote, RmiContext rmiContext, FriendlyMatchClearRequest clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveClear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveClear, Common.CG_RequestFriendlyMatchObserveClear);
        }

        public bool CG_RequestFriendlyMatchObserveExit(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveExit);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveExit, Common.CG_RequestFriendlyMatchObserveExit);
        }

        public bool CG_RequestFriendlyMatchObserveSetInviteOption(HostID remote, RmiContext rmiContext, FriendlyMatchInviteOption option)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFriendlyMatchObserveSetInviteOption);
            CommonPacket.Marshaler.Write(message, option);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFriendlyMatchObserveSetInviteOption, Common.CG_RequestFriendlyMatchObserveSetInviteOption);
        }

        public bool CG_RequestEventSeasonPassInfo(HostID remote, RmiContext rmiContext, byte currentClientSeasonPassWeek)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventSeasonPassInfo);
            CommonPacket.Marshaler.Write(message, currentClientSeasonPassWeek);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventSeasonPassInfo, Common.CG_RequestEventSeasonPassInfo);
        }

        public bool CG_RequestEventSeasonPassRankUpReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardRank, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventSeasonPassRankUpReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardRank);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventSeasonPassRankUpReward, Common.CG_RequestEventSeasonPassRankUpReward);
        }

        public bool CG_RequestEventSeasonPassRankUpRewardAll(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventSeasonPassRankUpRewardAll);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventSeasonPassRankUpRewardAll, Common.CG_RequestEventSeasonPassRankUpRewardAll);
        }

        public bool CG_RequestEventSeasonPassRankBuy(HostID remote, RmiContext rmiContext, int eventSEQ, int buyRankCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventSeasonPassRankBuy);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, buyRankCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventSeasonPassRankBuy, Common.CG_RequestEventSeasonPassRankBuy);
        }

        public bool CG_RequestWestSideServerInfo_Random(HostID remote, RmiContext rmiContext, WestRoomType roomType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWestSideServerInfo_Random);
            CommonPacket.Marshaler.Write(message, roomType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWestSideServerInfo_Random, Common.CG_RequestWestSideServerInfo_Random);
        }

        public bool CG_RequestWestSideServerInfo_Fixed(HostID remote, RmiContext rmiContext, WestRoomType roomType, int channelID, int roomID, bool isChannelChange)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWestSideServerInfo_Fixed);
            CommonPacket.Marshaler.Write(message, roomType);
            CommonPacket.Marshaler.Write(message, channelID);
            CommonPacket.Marshaler.Write(message, roomID);
            CommonPacket.Marshaler.Write(message, isChannelChange);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWestSideServerInfo_Fixed, Common.CG_RequestWestSideServerInfo_Fixed);
        }

        public bool CG_RequestWestSideServerInfo_Recommand(HostID remote, RmiContext rmiContext, WestRoomType roomType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWestSideServerInfo_Recommand);
            CommonPacket.Marshaler.Write(message, roomType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWestSideServerInfo_Recommand, Common.CG_RequestWestSideServerInfo_Recommand);
        }

        public bool CG_RequestWestSide_PlayerInfo(HostID remote, RmiContext rmiContext, long targetUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWestSide_PlayerInfo);
            CommonPacket.Marshaler.Write(message, targetUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWestSide_PlayerInfo, Common.CG_RequestWestSide_PlayerInfo);
        }

        public bool CG_RequestWestSide_PlayerteamInfo(HostID remote, RmiContext rmiContext, long targetUSN, TeamIndexType teamIndexType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWestSide_PlayerteamInfo);
            CommonPacket.Marshaler.Write(message, targetUSN);
            CommonPacket.Marshaler.Write(message, teamIndexType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWestSide_PlayerteamInfo, Common.CG_RequestWestSide_PlayerteamInfo);
        }

        public bool CG_RequestWestSide_PlayerGuildInfo(HostID remote, RmiContext rmiContext, int targetGuildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWestSide_PlayerGuildInfo);
            CommonPacket.Marshaler.Write(message, targetGuildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWestSide_PlayerGuildInfo, Common.CG_RequestWestSide_PlayerGuildInfo);
        }

        public bool CG_RequestWorldChattingChannel(HostID remote, RmiContext rmiContext, int targetChannelId, bool neverFail)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestWorldChattingChannel);
            CommonPacket.Marshaler.Write(message, targetChannelId);
            CommonPacket.Marshaler.Write(message, neverFail);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestWorldChattingChannel, Common.CG_RequestWorldChattingChannel);
        }

        public bool CG_RequestArenaRealTimePvpLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLobbyInfo, Common.CG_RequestArenaRealTimePvpLobbyInfo);
        }

        public bool CG_RequestArenaRealTimePvpJoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpJoin, Common.CG_RequestArenaRealTimePvpJoin);
        }

        public bool CG_RequestArenaRealTimePvpTopRankerList(HostID remote, RmiContext rmiContext, ArenaLeagueGrade grade, byte gradeNum)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpTopRankerList);
            CommonPacket.Marshaler.Write(message, grade);
            CommonPacket.Marshaler.Write(message, gradeNum);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpTopRankerList, Common.CG_RequestArenaRealTimePvpTopRankerList);
        }

        public bool CG_RequestArenaRealTimePvpLastRankerList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLastRankerList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLastRankerList, Common.CG_RequestArenaRealTimePvpLastRankerList);
        }

        public bool CG_RequestArenaRealTimePvpMatching(HostID remote, RmiContext rmiContext, byte teamIndex, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpMatching);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, skinStatInfoList);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpMatching, Common.CG_RequestArenaRealTimePvpMatching);
        }

        public bool CG_RequestArenaRealTimePvpBattleStart(HostID remote, RmiContext rmiContext, long opponentUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpBattleStart);
            CommonPacket.Marshaler.Write(message, opponentUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpBattleStart, Common.CG_RequestArenaRealTimePvpBattleStart);
        }

        public bool CG_RequestArenaRealTimePvpBattleEnd(HostID remote, RmiContext rmiContext, ArenaRealTimePVPClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpBattleEnd);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpBattleEnd, Common.CG_RequestArenaRealTimePvpBattleEnd);
        }

        public bool CG_RequestArenaRealTimePvpRollback(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpRollback);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpRollback, Common.CG_RequestArenaRealTimePvpRollback);
        }

        public bool CG_RequestArenaRealTimePvpIngameBattleStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpIngameBattleStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpIngameBattleStart, Common.CG_RequestArenaRealTimePvpIngameBattleStart);
        }

        public bool CG_RequestArenaRealTimePvpLowerLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLowerLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLowerLobbyInfo, Common.CG_RequestArenaRealTimePvpLowerLobbyInfo);
        }

        public bool CG_RequestArenaRealTimePvpLowerJoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLowerJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLowerJoin, Common.CG_RequestArenaRealTimePvpLowerJoin);
        }

        public bool CG_RequestArenaRealTimePvpLowerTopRankerList(HostID remote, RmiContext rmiContext, ArenaLeagueGrade grade, byte gradeNum)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLowerTopRankerList);
            CommonPacket.Marshaler.Write(message, grade);
            CommonPacket.Marshaler.Write(message, gradeNum);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLowerTopRankerList, Common.CG_RequestArenaRealTimePvpLowerTopRankerList);
        }

        public bool CG_RequestArenaRealTimePvpLowerMatching(HostID remote, RmiContext rmiContext, byte teamIndex, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLowerMatching);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, skinStatInfoList);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLowerMatching, Common.CG_RequestArenaRealTimePvpLowerMatching);
        }

        public bool CG_RequestArenaRealTimePvpLowerBattleEnd(HostID remote, RmiContext rmiContext, ArenaRealTimePVPClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLowerBattleEnd);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLowerBattleEnd, Common.CG_RequestArenaRealTimePvpLowerBattleEnd);
        }

        public bool CG_RequestArenaRealTimePvpAllInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpAllInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpAllInfo, Common.CG_RequestArenaRealTimePvpAllInfo);
        }

        public bool CG_RequestArenaRealTimePvpLastRankerBattleInfo(HostID remote, RmiContext rmiContext, byte rank)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLastRankerBattleInfo);
            CommonPacket.Marshaler.Write(message, rank);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLastRankerBattleInfo, Common.CG_RequestArenaRealTimePvpLastRankerBattleInfo);
        }

        public bool CG_RequestArenaRealTimePvpLastRankerBattleStart(HostID remote, RmiContext rmiContext, byte rank)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLastRankerBattleStart);
            CommonPacket.Marshaler.Write(message, rank);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLastRankerBattleStart, Common.CG_RequestArenaRealTimePvpLastRankerBattleStart);
        }

        public bool CG_RequestArenaRealTimePvpLowerRollback(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLowerRollback);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLowerRollback, Common.CG_RequestArenaRealTimePvpLowerRollback);
        }

        public bool CG_RequestArenaRealTimePvpLowerIngameBattleStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLowerIngameBattleStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLowerIngameBattleStart, Common.CG_RequestArenaRealTimePvpLowerIngameBattleStart);
        }

        public bool CG_RequestArenaRankingLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRankingLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRankingLobbyInfo, Common.CG_RequestArenaRankingLobbyInfo);
        }

        public bool CG_RequestArenaRankingJoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRankingJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRankingJoin, Common.CG_RequestArenaRankingJoin);
        }

        public bool CG_RequestArenaRankingTopRankerList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRankingTopRankerList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRankingTopRankerList, Common.CG_RequestArenaRankingTopRankerList);
        }

        public bool CG_RequestArenaRankingMatching(HostID remote, RmiContext rmiContext, byte teamIndex, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRankingMatching);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, skinStatInfoList);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRankingMatching, Common.CG_RequestArenaRankingMatching);
        }

        public bool CG_RequestArenaRankingBattleEnd(HostID remote, RmiContext rmiContext, ArenaRealTimePVPClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRankingBattleEnd);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRankingBattleEnd, Common.CG_RequestArenaRankingBattleEnd);
        }

        public bool CG_RequestArenaRankingIngameBattleStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRankingIngameBattleStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRankingIngameBattleStart, Common.CG_RequestArenaRankingIngameBattleStart);
        }

        public bool CG_RequestArenaRankingDefenceTeamUpdate(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRankingDefenceTeamUpdate);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRankingDefenceTeamUpdate, Common.CG_RequestArenaRankingDefenceTeamUpdate);
        }

        public bool CG_RequestPvpSeasonInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPvpSeasonInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPvpSeasonInfo, Common.CG_RequestPvpSeasonInfo);
        }

        public bool CG_RequestPvpSeasonHistory(HostID remote, RmiContext rmiContext, int seasonID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPvpSeasonHistory);
            CommonPacket.Marshaler.Write(message, seasonID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPvpSeasonHistory, Common.CG_RequestPvpSeasonHistory);
        }

        public bool CG_RequestCurrentTopRanking(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCurrentTopRanking);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCurrentTopRanking, Common.CG_RequestCurrentTopRanking);
        }

        public bool CG_RequestLastTopRanking(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestLastTopRanking);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestLastTopRanking, Common.CG_RequestLastTopRanking);
        }

        public bool CG_RequestPvpAbuseReport(HostID remote, RmiContext rmiContext, byte reportType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPvpAbuseReport);
            CommonPacket.Marshaler.Write(message, reportType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPvpAbuseReport, Common.CG_RequestPvpAbuseReport);
        }

        public bool CG_RequestPvpAllReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPvpAllReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPvpAllReward, Common.CG_RequestPvpAllReward);
        }

        public bool CG_RequestPvpAllJoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPvpAllJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPvpAllJoin, Common.CG_RequestPvpAllJoin);
        }

        public bool CG_RequestArenaSmashTeamSlotChange(HostID remote, RmiContext rmiContext, List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashTeamSlotChange);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfoList);
            CommonPacket.Marshaler.Write(message, userArtifactTeamInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashTeamSlotChange, Common.CG_RequestArenaSmashTeamSlotChange);
        }

        public bool CG_RequestArenaSmashDefenceTeamUpdate(HostID remote, RmiContext rmiContext, int battlePowerPoint, List<AICustomizingInfo> aiCustomizingInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashDefenceTeamUpdate);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            CommonPacket.Marshaler.Write(message, aiCustomizingInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashDefenceTeamUpdate, Common.CG_RequestArenaSmashDefenceTeamUpdate);
        }

        public bool CG_RequestArenaSmashDefenceTeamFoodBuffUpdate(HostID remote, RmiContext rmiContext, byte teamIndex, int foodBuffItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashDefenceTeamFoodBuffUpdate);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, foodBuffItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashDefenceTeamFoodBuffUpdate, Common.CG_RequestArenaSmashDefenceTeamFoodBuffUpdate);
        }

        public bool CG_RequestArenaSmashLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashLobbyInfo, Common.CG_RequestArenaSmashLobbyInfo);
        }

        public bool CG_RequestArenaSmashJoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashJoin, Common.CG_RequestArenaSmashJoin);
        }

        public bool CG_RequestArenaSmashOpponentList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashOpponentList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashOpponentList, Common.CG_RequestArenaSmashOpponentList);
        }

        public bool CG_RequestArenaSmashOpponentListReload(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashOpponentListReload);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashOpponentListReload, Common.CG_RequestArenaSmashOpponentListReload);
        }

        public bool CG_RequestArenaSmashOpponentTeamInfo(HostID remote, RmiContext rmiContext, long opponentUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashOpponentTeamInfo);
            CommonPacket.Marshaler.Write(message, opponentUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashOpponentTeamInfo, Common.CG_RequestArenaSmashOpponentTeamInfo);
        }

        public bool CG_RequestArenaSmashMatchJoin(HostID remote, RmiContext rmiContext, long opponentUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashMatchJoin);
            CommonPacket.Marshaler.Write(message, opponentUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashMatchJoin, Common.CG_RequestArenaSmashMatchJoin);
        }

        public bool CG_RequestArenaSmashMatchBattleStart(HostID remote, RmiContext rmiContext, ArenaSmashBattleStartRequest battleStartRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashMatchBattleStart);
            CommonPacket.Marshaler.Write(message, battleStartRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashMatchBattleStart, Common.CG_RequestArenaSmashMatchBattleStart);
        }

        public bool CG_RequestArenaSmashMatchBattleEnd(HostID remote, RmiContext rmiContext, ArenaSmashBattleEndRequest battleEndRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashMatchBattleEnd);
            CommonPacket.Marshaler.Write(message, battleEndRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashMatchBattleEnd, Common.CG_RequestArenaSmashMatchBattleEnd);
        }

        public bool CG_RequestArenaSmashWinReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashWinReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashWinReward, Common.CG_RequestArenaSmashWinReward);
        }

        public bool CG_RequestArenaSmashBestRefresh(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashBestRefresh);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashBestRefresh, Common.CG_RequestArenaSmashBestRefresh);
        }

        public bool CG_RequestArenaSmashBestReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashBestReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashBestReward, Common.CG_RequestArenaSmashBestReward);
        }

        public bool CG_RequestArenaSmashRecordList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashRecordList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashRecordList, Common.CG_RequestArenaSmashRecordList);
        }

        public bool CG_RequestArenaSmashOffenseTeamFoodBuffUpdate(HostID remote, RmiContext rmiContext, byte teamIndex, int foodBuffItemID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashOffenseTeamFoodBuffUpdate);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, foodBuffItemID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashOffenseTeamFoodBuffUpdate, Common.CG_RequestArenaSmashOffenseTeamFoodBuffUpdate);
        }

        public bool CG_RequestArenaSmashRankReward(HostID remote, RmiContext rmiContext, int rank)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashRankReward);
            CommonPacket.Marshaler.Write(message, rank);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashRankReward, Common.CG_RequestArenaSmashRankReward);
        }

        public bool CG_RequestArenaSmashRankInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashRankInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashRankInfo, Common.CG_RequestArenaSmashRankInfo);
        }

        public bool CG_RequestArenaSmashMatchInfo(HostID remote, RmiContext rmiContext, int rank, long opponentUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaSmashMatchInfo);
            CommonPacket.Marshaler.Write(message, rank);
            CommonPacket.Marshaler.Write(message, opponentUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaSmashMatchInfo, Common.CG_RequestArenaSmashMatchInfo);
        }

        public bool CG_RequestArenaRealTimePvpLimitLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitLobbyInfo, Common.CG_RequestArenaRealTimePvpLimitLobbyInfo);
        }

        public bool CG_RequestArenaRealTimePvpLimitJoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitJoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitJoin, Common.CG_RequestArenaRealTimePvpLimitJoin);
        }

        public bool CG_RequestArenaRealTimePvpLimitMatching(HostID remote, RmiContext rmiContext, List<SkinStatInfo> skinStatInfoList, int battlePowerPoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitMatching);
            CommonPacket.Marshaler.Write(message, skinStatInfoList);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitMatching, Common.CG_RequestArenaRealTimePvpLimitMatching);
        }

        public bool CG_RequestArenaRealTimePvpLimitBattleEnd(HostID remote, RmiContext rmiContext, ArenaRealTimePVPClearRequest clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitBattleEnd);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitBattleEnd, Common.CG_RequestArenaRealTimePvpLimitBattleEnd);
        }

        public bool CG_RequestArenaRealTimePvpLimitIngameBattleStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitIngameBattleStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitIngameBattleStart, Common.CG_RequestArenaRealTimePvpLimitIngameBattleStart);
        }

        public bool CG_RequestArenaRealTimePvpLimitTeamChange(HostID remote, RmiContext rmiContext, List<UserTeamSlot> mainSlotList, int battlePowerPoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitTeamChange);
            CommonPacket.Marshaler.Write(message, mainSlotList);
            CommonPacket.Marshaler.Write(message, battlePowerPoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitTeamChange, Common.CG_RequestArenaRealTimePvpLimitTeamChange);
        }

        public bool CG_RequestArenaRealTimePvpLimitTopRankerList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitTopRankerList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitTopRankerList, Common.CG_RequestArenaRealTimePvpLimitTopRankerList);
        }

        public bool CG_RequestArenaRealTimePvpLimitRankReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArenaRealTimePvpLimitRankReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArenaRealTimePvpLimitRankReward, Common.CG_RequestArenaRealTimePvpLimitRankReward);
        }

        public bool CG_RequestEventExchangeInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeInfo, Common.CG_RequestEventExchangeInfo);
        }

        public bool CG_RequestEventExchangeBoxGachaInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeBoxGachaInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeBoxGachaInfo, Common.CG_RequestEventExchangeBoxGachaInfo);
        }

        public bool CG_RequestEventExchangeBoxGachaPickup(HostID remote, RmiContext rmiContext, int eventSEQ, GambleAmountType amountType, bool useDia)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeBoxGachaPickup);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, amountType);
            CommonPacket.Marshaler.Write(message, useDia);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeBoxGachaPickup, Common.CG_RequestEventExchangeBoxGachaPickup);
        }

        public bool CG_RequestEventExchangeBoxGachaReset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeBoxGachaReset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeBoxGachaReset, Common.CG_RequestEventExchangeBoxGachaReset);
        }

        public bool CG_RequestEventPaybackReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPaybackReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPaybackReward, Common.CG_RequestEventPaybackReward);
        }

        public bool CG_RequestEventSnsShareProgress(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventSnsShareProgress);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventSnsShareProgress, Common.CG_RequestEventSnsShareProgress);
        }

        public bool CG_RequestEventSnsShareReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventSnsShareReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventSnsShareReward, Common.CG_RequestEventSnsShareReward);
        }

        public bool CG_RequestGagueEventInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGagueEventInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGagueEventInfo, Common.CG_RequestGagueEventInfo);
        }

        public bool CG_RequestGagueEventCharge(HostID remote, RmiContext rmiContext, int eventSEQ, int chargePoint, bool isFreeCharge)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGagueEventCharge);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, chargePoint);
            CommonPacket.Marshaler.Write(message, isFreeCharge);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGagueEventCharge, Common.CG_RequestGagueEventCharge);
        }

        public bool CG_RequestGagueEventReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGagueEventReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGagueEventReward, Common.CG_RequestGagueEventReward);
        }

        public bool CG_RequestGagueEventReset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGagueEventReset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGagueEventReset, Common.CG_RequestGagueEventReset);
        }

        public bool CG_RequestEventLadderReward(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> midRewardIDList, List<int> topRewardIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventLadderReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, midRewardIDList);
            CommonPacket.Marshaler.Write(message, topRewardIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventLadderReward, Common.CG_RequestEventLadderReward);
        }

        public bool CG_RequestEventLobbyGiftReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventLobbyGiftReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventLobbyGiftReward, Common.CG_RequestEventLobbyGiftReward);
        }

        public bool CG_RequestEventTimeMissionInfo(HostID remote, RmiContext rmiContext, int eventSeq, int currentClientTimeMissionDays)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTimeMissionInfo);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, currentClientTimeMissionDays);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTimeMissionInfo, Common.CG_RequestEventTimeMissionInfo);
        }

        public bool CG_RequestEventTimeMissionStart(HostID remote, RmiContext rmiContext, int eventSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTimeMissionStart);
            CommonPacket.Marshaler.Write(message, eventSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTimeMissionStart, Common.CG_RequestEventTimeMissionStart);
        }

        public bool CG_RequestEventLobbyDecorationReward(HostID remote, RmiContext rmiContext, int eventSEQ, int id)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventLobbyDecorationReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, id);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventLobbyDecorationReward, Common.CG_RequestEventLobbyDecorationReward);
        }

        public bool CG_RequestEventPvpWinCountReward(HostID remote, RmiContext rmiContext, int eventSEQ, byte week, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPvpWinCountReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, week);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPvpWinCountReward, Common.CG_RequestEventPvpWinCountReward);
        }

        public bool CG_RequestEventChapterClearReward(HostID remote, RmiContext rmiContext, int eventSEQ, int id)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventChapterClearReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, id);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventChapterClearReward, Common.CG_RequestEventChapterClearReward);
        }

        public bool CG_RequestEventBingoInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBingoInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBingoInfo, Common.CG_RequestEventBingoInfo);
        }

        public bool CG_RequestEventBingoReset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBingoReset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBingoReset, Common.CG_RequestEventBingoReset);
        }

        public bool CG_RequestEventBingoRandomNumber(HostID remote, RmiContext rmiContext, int eventSEQ, byte count)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBingoRandomNumber);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, count);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBingoRandomNumber, Common.CG_RequestEventBingoRandomNumber);
        }

        public bool CG_RequestEventBingoExchangeNumber(HostID remote, RmiContext rmiContext, int eventSEQ, List<EventBingoExchangeInfo> exchangeInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBingoExchangeNumber);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, exchangeInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBingoExchangeNumber, Common.CG_RequestEventBingoExchangeNumber);
        }

        public bool CG_RequestEventSkinOneStepEvolution(HostID remote, RmiContext rmiContext, int eventSEQ, int targetHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventSkinOneStepEvolution);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, targetHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventSkinOneStepEvolution, Common.CG_RequestEventSkinOneStepEvolution);
        }

        public bool CG_RequestEventLuckyBoxInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventLuckyBoxInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventLuckyBoxInfo, Common.CG_RequestEventLuckyBoxInfo);
        }

        public bool CG_RequestEventLuckyBoxReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventLuckyBoxReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventLuckyBoxReward, Common.CG_RequestEventLuckyBoxReward);
        }

        public bool CG_RequestRegistPlayTitle(HostID remote, RmiContext rmiContext, int playTitleID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRegistPlayTitle);
            CommonPacket.Marshaler.Write(message, playTitleID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRegistPlayTitle, Common.CG_RequestRegistPlayTitle);
        }

        public bool CG_RequestPlayTitleMissionReward(HostID remote, RmiContext rmiContext, int category)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPlayTitleMissionReward);
            CommonPacket.Marshaler.Write(message, category);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPlayTitleMissionReward, Common.CG_RequestPlayTitleMissionReward);
        }

        public bool CG_RequestPlayTitleInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPlayTitleInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPlayTitleInfo, Common.CG_RequestPlayTitleInfo);
        }

        public bool CG_RequestTournamentList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentList, Common.CG_RequestTournamentList);
        }

        public bool CG_RequestTournamentProgressInfo(HostID remote, RmiContext rmiContext, int tournamentSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentProgressInfo);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentProgressInfo, Common.CG_RequestTournamentProgressInfo);
        }

        public bool CG_RequestTournamentResultInfo(HostID remote, RmiContext rmiContext, int tournamentSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentResultInfo);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentResultInfo, Common.CG_RequestTournamentResultInfo);
        }

        public bool CG_RequestTournamentMatchJoin(HostID remote, RmiContext rmiContext, int tournamentSEQ, short matchIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentMatchJoin);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            CommonPacket.Marshaler.Write(message, matchIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentMatchJoin, Common.CG_RequestTournamentMatchJoin);
        }

        public bool CG_RequestTournamentMatchBattleStart(HostID remote, RmiContext rmiContext, TournamentBattleStartRequest battleStartRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentMatchBattleStart);
            CommonPacket.Marshaler.Write(message, battleStartRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentMatchBattleStart, Common.CG_RequestTournamentMatchBattleStart);
        }

        public bool CG_RequestTournamentMatchBattleEnd(HostID remote, RmiContext rmiContext, TournamentBattleEndRequest battleEndRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentMatchBattleEnd);
            CommonPacket.Marshaler.Write(message, battleEndRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentMatchBattleEnd, Common.CG_RequestTournamentMatchBattleEnd);
        }

        public bool CG_RequestTournamentMatchExit(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentMatchExit);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentMatchExit, Common.CG_RequestTournamentMatchExit);
        }

        public bool CG_RequestTournamentReward(HostID remote, RmiContext rmiContext, int tournamentSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentReward);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentReward, Common.CG_RequestTournamentReward);
        }

        public bool CG_RequestTournamentPlayerTeamSlotChange(HostID remote, RmiContext rmiContext, List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentPlayerTeamSlotChange);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfoList);
            CommonPacket.Marshaler.Write(message, userArtifactTeamInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentPlayerTeamSlotChange, Common.CG_RequestTournamentPlayerTeamSlotChange);
        }

        public bool CG_RequestTournamentPlayerTeamInfo(HostID remote, RmiContext rmiContext, int tournamentSEQ, long playerUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentPlayerTeamInfo);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            CommonPacket.Marshaler.Write(message, playerUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentPlayerTeamInfo, Common.CG_RequestTournamentPlayerTeamInfo);
        }

        public bool CG_RequestTournamentCheer(HostID remote, RmiContext rmiContext, int tournamentSEQ, long playerUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentCheer);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            CommonPacket.Marshaler.Write(message, playerUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentCheer, Common.CG_RequestTournamentCheer);
        }

        public bool CG_RequestTournamentCheerList(HostID remote, RmiContext rmiContext, int tournamentSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentCheerList);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentCheerList, Common.CG_RequestTournamentCheerList);
        }

        public bool CG_RequestTournamentWatcherJoin(HostID remote, RmiContext rmiContext, int tournamentSEQ, short matchIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentWatcherJoin);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            CommonPacket.Marshaler.Write(message, matchIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentWatcherJoin, Common.CG_RequestTournamentWatcherJoin);
        }

        public bool CG_RequestTournamentWatcherExit(HostID remote, RmiContext rmiContext, int roomSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentWatcherExit);
            CommonPacket.Marshaler.Write(message, roomSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentWatcherExit, Common.CG_RequestTournamentWatcherExit);
        }

        public bool CG_RequestTournamentMatchPlayInfo(HostID remote, RmiContext rmiContext, int tournamentSEQ, short matchIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentMatchPlayInfo);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            CommonPacket.Marshaler.Write(message, matchIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentMatchPlayInfo, Common.CG_RequestTournamentMatchPlayInfo);
        }

        public bool CG_RequestTournamentReplayInfo(HostID remote, RmiContext rmiContext, int tournamentSEQ, long replaySEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestTournamentReplayInfo);
            CommonPacket.Marshaler.Write(message, tournamentSEQ);
            CommonPacket.Marshaler.Write(message, replaySEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestTournamentReplayInfo, Common.CG_RequestTournamentReplayInfo);
        }

        public bool CG_RequestGuildWarLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLobbyInfo, Common.CG_RequestGuildWarLobbyInfo);
        }

        public bool CG_RequestGuildWarRankInfo(HostID remote, RmiContext rmiContext, int season, int league)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarRankInfo);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, league);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarRankInfo, Common.CG_RequestGuildWarRankInfo);
        }

        public bool CG_RequestGuildWarVersusRecordInfo(HostID remote, RmiContext rmiContext, int season, int league)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarVersusRecordInfo);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, league);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarVersusRecordInfo, Common.CG_RequestGuildWarVersusRecordInfo);
        }

        public bool CG_RequestGuildWarGuildMemberList(HostID remote, RmiContext rmiContext, int guildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarGuildMemberList);
            CommonPacket.Marshaler.Write(message, guildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarGuildMemberList, Common.CG_RequestGuildWarGuildMemberList);
        }

        public bool CG_RequestGuildWarWorldMapInfo(HostID remote, RmiContext rmiContext, int season, int guildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarWorldMapInfo);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, guildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarWorldMapInfo, Common.CG_RequestGuildWarWorldMapInfo);
        }

        public bool CG_RequestGuildWarAttackSquadChange(HostID remote, RmiContext rmiContext, int season, List<GuildWarSquadSlot> updateGuildWarSquadSlotList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarAttackSquadChange);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, updateGuildWarSquadSlotList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarAttackSquadChange, Common.CG_RequestGuildWarAttackSquadChange);
        }

        public bool CG_RequestGuildWarDefenceTeamChange(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarDefenceTeamChange);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarDefenceTeamChange, Common.CG_RequestGuildWarDefenceTeamChange);
        }

        public bool CG_RequestGuildWarRegionBonusScoreChange(HostID remote, RmiContext rmiContext, int season, int regionID, int bonusScore)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarRegionBonusScoreChange);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, regionID);
            CommonPacket.Marshaler.Write(message, bonusScore);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarRegionBonusScoreChange, Common.CG_RequestGuildWarRegionBonusScoreChange);
        }

        public bool CG_RequestGuildWarAreaGuildMemberChange(HostID remote, RmiContext rmiContext, int season, List<int> swapAreaIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarAreaGuildMemberChange);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, swapAreaIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarAreaGuildMemberChange, Common.CG_RequestGuildWarAreaGuildMemberChange);
        }

        public bool CG_RequestGuildWarBattleRecordInfo(HostID remote, RmiContext rmiContext, int season, int guildSN, int areaID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarBattleRecordInfo);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, guildSN);
            CommonPacket.Marshaler.Write(message, areaID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarBattleRecordInfo, Common.CG_RequestGuildWarBattleRecordInfo);
        }

        public bool CG_Request_GuildWar_Stage_Start(HostID remote, RmiContext rmiContext, GuildWarStageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildWar_Stage_Start);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildWar_Stage_Start, Common.CG_Request_GuildWar_Stage_Start);
        }

        public bool CG_Request_GuildWar_Stage_Clear(HostID remote, RmiContext rmiContext, GuildWarStageClearRequestInfo clearRequestInfo, IngameBattlePointRequest ingameBattlePointRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildWar_Stage_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            CommonPacket.Marshaler.Write(message, ingameBattlePointRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildWar_Stage_Clear, Common.CG_Request_GuildWar_Stage_Clear);
        }

        public bool CG_Request_GuildWar_Stage_Rejoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildWar_Stage_Rejoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildWar_Stage_Rejoin, Common.CG_Request_GuildWar_Stage_Rejoin);
        }

        public bool CG_Request_GuildWar_Stage_HeroStatus_Sync(HostID remote, RmiContext rmiContext, List<ClientSyncGuildWarHero> clientSyncGuildWarHeroList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildWar_Stage_HeroStatus_Sync);
            CommonPacket.Marshaler.Write(message, clientSyncGuildWarHeroList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildWar_Stage_HeroStatus_Sync, Common.CG_Request_GuildWar_Stage_HeroStatus_Sync);
        }

        public bool CG_RequestGuildWarBattlePrepareInfo(HostID remote, RmiContext rmiContext, int season)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarBattlePrepareInfo);
            CommonPacket.Marshaler.Write(message, season);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarBattlePrepareInfo, Common.CG_RequestGuildWarBattlePrepareInfo);
        }

        public bool CG_RequestGuildWarAttackTeamChange(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarAttackTeamChange);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarAttackTeamChange, Common.CG_RequestGuildWarAttackTeamChange);
        }

        public bool CG_RequestGuildWarDefenceSlotExpand(HostID remote, RmiContext rmiContext, int season, byte expandSlotCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarDefenceSlotExpand);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, expandSlotCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarDefenceSlotExpand, Common.CG_RequestGuildWarDefenceSlotExpand);
        }

        public bool CG_RequestGuildWarSquadSlotExpand(HostID remote, RmiContext rmiContext, int season, byte expandSlotCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarSquadSlotExpand);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, expandSlotCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarSquadSlotExpand, Common.CG_RequestGuildWarSquadSlotExpand);
        }

        public bool CG_RequestGuildWarAttackTeamInfo(HostID remote, RmiContext rmiContext, int season)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarAttackTeamInfo);
            CommonPacket.Marshaler.Write(message, season);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarAttackTeamInfo, Common.CG_RequestGuildWarAttackTeamInfo);
        }

        public bool CG_RequestGuildWarDefenceTeamInfo(HostID remote, RmiContext rmiContext, int season, int guildSN, long deployUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarDefenceTeamInfo);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, guildSN);
            CommonPacket.Marshaler.Write(message, deployUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarDefenceTeamInfo, Common.CG_RequestGuildWarDefenceTeamInfo);
        }

        public bool CG_RequestGuildWarAttackTeamBuffRegist(HostID remote, RmiContext rmiContext, int season, List<GuildWarTeamBuffRegist> guildWarTeamBuffRegistList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarAttackTeamBuffRegist);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, guildWarTeamBuffRegistList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarAttackTeamBuffRegist, Common.CG_RequestGuildWarAttackTeamBuffRegist);
        }

        public bool CG_RequestGuildWarDefenceTeamBuffRegist(HostID remote, RmiContext rmiContext, int season, byte teamIndex, List<GuildWarTeamBuffRegist> guildWarTeamBuffRegistList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarDefenceTeamBuffRegist);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, guildWarTeamBuffRegistList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarDefenceTeamBuffRegist, Common.CG_RequestGuildWarDefenceTeamBuffRegist);
        }

        public bool CG_Request_GuildWar_Stage_Rejoin_Cancel(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildWar_Stage_Rejoin_Cancel);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildWar_Stage_Rejoin_Cancel, Common.CG_Request_GuildWar_Stage_Rejoin_Cancel);
        }

        public bool CG_RequestGuildWarDefenceTeamInfoAll(HostID remote, RmiContext rmiContext, int season, int guildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarDefenceTeamInfoAll);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, guildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarDefenceTeamInfoAll, Common.CG_RequestGuildWarDefenceTeamInfoAll);
        }

        public bool CG_RequestGuildWarRankInfoAll(HostID remote, RmiContext rmiContext, int season)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarRankInfoAll);
            CommonPacket.Marshaler.Write(message, season);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarRankInfoAll, Common.CG_RequestGuildWarRankInfoAll);
        }

        public bool CG_RequestGuildWarDefenceTeamSave(HostID remote, RmiContext rmiContext, int season, byte teamIndex, byte isOnlyHeroSave)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarDefenceTeamSave);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, teamIndex);
            CommonPacket.Marshaler.Write(message, isOnlyHeroSave);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarDefenceTeamSave, Common.CG_RequestGuildWarDefenceTeamSave);
        }

        public bool CG_RequestGuildWarMagicAreaRegist(HostID remote, RmiContext rmiContext, int season, int magicAreaID, int magicBuffID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarMagicAreaRegist);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, magicAreaID);
            CommonPacket.Marshaler.Write(message, magicBuffID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarMagicAreaRegist, Common.CG_RequestGuildWarMagicAreaRegist);
        }

        public bool CG_RequestGuildWarDefenceTeamSaveAll(HostID remote, RmiContext rmiContext, int season, byte isOnlyHeroSave, List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarDefenceTeamSaveAll);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, isOnlyHeroSave);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfoList);
            CommonPacket.Marshaler.Write(message, userArtifactTeamInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarDefenceTeamSaveAll, Common.CG_RequestGuildWarDefenceTeamSaveAll);
        }

        public bool CG_RequestGuildWarLowerLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowerLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowerLobbyInfo, Common.CG_RequestGuildWarLowerLobbyInfo);
        }

        public bool CG_RequestGuildWarCostumeReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarCostumeReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarCostumeReward, Common.CG_RequestGuildWarCostumeReward);
        }

        public bool CG_RequestGuildWarRegionAttackPriorityChange(HostID remote, RmiContext rmiContext, int guildSN, List<int> guildWarRegionIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarRegionAttackPriorityChange);
            CommonPacket.Marshaler.Write(message, guildSN);
            CommonPacket.Marshaler.Write(message, guildWarRegionIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarRegionAttackPriorityChange, Common.CG_RequestGuildWarRegionAttackPriorityChange);
        }

        public bool CG_RequestGuildWarBattleSettingChange(HostID remote, RmiContext rmiContext, bool isComplete)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarBattleSettingChange);
            CommonPacket.Marshaler.Write(message, isComplete);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarBattleSettingChange, Common.CG_RequestGuildWarBattleSettingChange);
        }

        public bool CG_RequestGuildWarBattleSettingChangeInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarBattleSettingChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarBattleSettingChangeInfo, Common.CG_RequestGuildWarBattleSettingChangeInfo);
        }

        public bool CG_RequestGuildWarNonSeasonBattlePrepareInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarNonSeasonBattlePrepareInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarNonSeasonBattlePrepareInfo, Common.CG_RequestGuildWarNonSeasonBattlePrepareInfo);
        }

        public bool CG_RequestGuildWarNonSeasonDefenceTeamChange(HostID remote, RmiContext rmiContext, UserTeamChangeInfo userTeamChangeInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarNonSeasonDefenceTeamChange);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarNonSeasonDefenceTeamChange, Common.CG_RequestGuildWarNonSeasonDefenceTeamChange);
        }

        public bool CG_RequestGuildWarNonSeasonDefenceTeamSaveAll(HostID remote, RmiContext rmiContext, byte isOnlyHeroSave, List<UserTeamChangeInfo> userTeamChangeInfoList, List<UserArtifactTeamInfo> userArtifactTeamInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarNonSeasonDefenceTeamSaveAll);
            CommonPacket.Marshaler.Write(message, isOnlyHeroSave);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfoList);
            CommonPacket.Marshaler.Write(message, userArtifactTeamInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarNonSeasonDefenceTeamSaveAll, Common.CG_RequestGuildWarNonSeasonDefenceTeamSaveAll);
        }

        public bool CG_RequestGuildWarNonSeasonAttackSquadChange(HostID remote, RmiContext rmiContext, List<GuildWarSquadSlot> updateGuildWarSquadSlotList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarNonSeasonAttackSquadChange);
            CommonPacket.Marshaler.Write(message, updateGuildWarSquadSlotList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarNonSeasonAttackSquadChange, Common.CG_RequestGuildWarNonSeasonAttackSquadChange);
        }

        public bool CG_RequestGuildWarUserInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarUserInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarUserInfo, Common.CG_RequestGuildWarUserInfo);
        }

        public bool CG_RequestGuildWarRecommandDefenceTeamInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarRecommandDefenceTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarRecommandDefenceTeamInfo, Common.CG_RequestGuildWarRecommandDefenceTeamInfo);
        }

        public bool CG_RequestGuildWarRecommandDefenceTeamRegist(HostID remote, RmiContext rmiContext, GuildWarRecommandDefenceTeamInfo guildWarRecommandDefenceTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarRecommandDefenceTeamRegist);
            CommonPacket.Marshaler.Write(message, guildWarRecommandDefenceTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarRecommandDefenceTeamRegist, Common.CG_RequestGuildWarRecommandDefenceTeamRegist);
        }

        public bool CG_RequestSubdueCreate(HostID remote, RmiContext rmiContext, int groupID, byte difficulty)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueCreate);
            CommonPacket.Marshaler.Write(message, groupID);
            CommonPacket.Marshaler.Write(message, difficulty);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueCreate, Common.CG_RequestSubdueCreate);
        }

        public bool CG_RequestSubdueJoin(HostID remote, RmiContext rmiContext, int gameSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueJoin);
            CommonPacket.Marshaler.Write(message, gameSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueJoin, Common.CG_RequestSubdueJoin);
        }

        public bool CG_RequestSubdueOwnerGameStart(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueOwnerGameStart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueOwnerGameStart, Common.CG_RequestSubdueOwnerGameStart);
        }

        public bool CG_RequestSubdueLoadingComplete(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueLoadingComplete);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueLoadingComplete, Common.CG_RequestSubdueLoadingComplete);
        }

        public bool CG_RequestSubdueOnlineFriendList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueOnlineFriendList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueOnlineFriendList, Common.CG_RequestSubdueOnlineFriendList);
        }

        public bool CG_RequestSubdueOnlineGuildMemberList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueOnlineGuildMemberList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueOnlineGuildMemberList, Common.CG_RequestSubdueOnlineGuildMemberList);
        }

        public bool CG_RequestSubdueOnlineUserRankRangeList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueOnlineUserRankRangeList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueOnlineUserRankRangeList, Common.CG_RequestSubdueOnlineUserRankRangeList);
        }

        public bool CG_RequestSubdueInvitationReceiveList(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueInvitationReceiveList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueInvitationReceiveList, Common.CG_RequestSubdueInvitationReceiveList);
        }

        public bool CG_RequestSubdueRemoveInvitation(HostID remote, RmiContext rmiContext, int gameSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueRemoveInvitation);
            CommonPacket.Marshaler.Write(message, gameSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueRemoveInvitation, Common.CG_RequestSubdueRemoveInvitation);
        }

        public bool CG_RequestSubdueInvite(HostID remote, RmiContext rmiContext, List<long> invitedUSNList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueInvite);
            CommonPacket.Marshaler.Write(message, invitedUSNList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueInvite, Common.CG_RequestSubdueInvite);
        }

        public bool CG_RequestSubdueReward(HostID remote, RmiContext rmiContext, int gameSN, SubdubClearRequestInfo clearRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSubdueReward);
            CommonPacket.Marshaler.Write(message, gameSN);
            CommonPacket.Marshaler.Write(message, clearRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSubdueReward, Common.CG_RequestSubdueReward);
        }

        public bool CG_RequestPatrolMissionInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPatrolMissionInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPatrolMissionInfo, Common.CG_RequestPatrolMissionInfo);
        }

        public bool CG_RequestPatrolMissionStart(HostID remote, RmiContext rmiContext, int patrolId, List<int> heroIdList, int battlePoint)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPatrolMissionStart);
            CommonPacket.Marshaler.Write(message, patrolId);
            CommonPacket.Marshaler.Write(message, heroIdList);
            CommonPacket.Marshaler.Write(message, battlePoint);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPatrolMissionStart, Common.CG_RequestPatrolMissionStart);
        }

        public bool CG_RequestPatrolMissionCancel(HostID remote, RmiContext rmiContext, int patrolId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPatrolMissionCancel);
            CommonPacket.Marshaler.Write(message, patrolId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPatrolMissionCancel, Common.CG_RequestPatrolMissionCancel);
        }

        public bool CG_RequestPatrolMissionReward(HostID remote, RmiContext rmiContext, int patrolId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPatrolMissionReward);
            CommonPacket.Marshaler.Write(message, patrolId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPatrolMissionReward, Common.CG_RequestPatrolMissionReward);
        }

        public bool CG_RequestPatrolMissionTimeReward(HostID remote, RmiContext rmiContext, int id, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestPatrolMissionTimeReward);
            CommonPacket.Marshaler.Write(message, id);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestPatrolMissionTimeReward, Common.CG_RequestPatrolMissionTimeReward);
        }

        public bool CG_Request_Free_Stage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_Stage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_Stage_ClearTicket, Common.CG_Request_Free_Stage_ClearTicket);
        }

        public bool CG_Request_Week_Stage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_Stage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_Stage_ClearTicket, Common.CG_Request_Week_Stage_ClearTicket);
        }

        public bool CG_Request_Boss_Stage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest, bool isBatchPlay)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Boss_Stage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            CommonPacket.Marshaler.Write(message, isBatchPlay);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Boss_Stage_ClearTicket, Common.CG_Request_Boss_Stage_ClearTicket);
        }

        public bool CG_Request_Week_EventStage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Week_EventStage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Week_EventStage_ClearTicket, Common.CG_Request_Week_EventStage_ClearTicket);
        }

        public bool CG_Request_DisasterBoss_Stage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_DisasterBoss_Stage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_DisasterBoss_Stage_ClearTicket, Common.CG_Request_DisasterBoss_Stage_ClearTicket);
        }

        public bool CG_Request_Free_EventAreaStage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Free_EventAreaStage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Free_EventAreaStage_ClearTicket, Common.CG_Request_Free_EventAreaStage_ClearTicket);
        }

        public bool CG_Request_Yggdrasil_Tower_Stage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Yggdrasil_Tower_Stage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Yggdrasil_Tower_Stage_ClearTicket, Common.CG_Request_Yggdrasil_Tower_Stage_ClearTicket);
        }

        public bool CG_Request_Training_Stage_ClearTicket(HostID remote, RmiContext rmiContext, StageClearTicketRequest clearTicketRequest)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Training_Stage_ClearTicket);
            CommonPacket.Marshaler.Write(message, clearTicketRequest);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Training_Stage_ClearTicket, Common.CG_Request_Training_Stage_ClearTicket);
        }

        public bool CG_RequestEventExchangeCardInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeCardInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeCardInfo, Common.CG_RequestEventExchangeCardInfo);
        }

        public bool CG_RequestEventExchangeCardSetup(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> specialIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeCardSetup);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, specialIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeCardSetup, Common.CG_RequestEventExchangeCardSetup);
        }

        public bool CG_RequestEventExchangeCardChoiceManual(HostID remote, RmiContext rmiContext, int eventSEQ, int boardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeCardChoiceManual);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, boardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeCardChoiceManual, Common.CG_RequestEventExchangeCardChoiceManual);
        }

        public bool CG_RequestEventExchangeCardChoiceAuto(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeCardChoiceAuto);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeCardChoiceAuto, Common.CG_RequestEventExchangeCardChoiceAuto);
        }

        public bool CG_RequestEventExchangeCardReset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeCardReset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeCardReset, Common.CG_RequestEventExchangeCardReset);
        }

        public bool CG_RequestEventCraftExchange(HostID remote, RmiContext rmiContext, int eventSeq, int craftID, int craftCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventCraftExchange);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, craftID);
            CommonPacket.Marshaler.Write(message, craftCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventCraftExchange, Common.CG_RequestEventCraftExchange);
        }

        public bool CG_RequestEventProvisionProvide(HostID remote, RmiContext rmiContext, int eventSEQ, int section, List<NeedItemInfo> provideItemInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventProvisionProvide);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, section);
            CommonPacket.Marshaler.Write(message, provideItemInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventProvisionProvide, Common.CG_RequestEventProvisionProvide);
        }

        public bool CG_RequestEventProvisionGetFinalReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventProvisionGetFinalReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventProvisionGetFinalReward, Common.CG_RequestEventProvisionGetFinalReward);
        }

        public bool CG_RequestEventExchangeKingAmber(HostID remote, RmiContext rmiContext, int eventSEQ, int amberID, int rewardItemID, int amberCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventExchangeKingAmber);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, amberID);
            CommonPacket.Marshaler.Write(message, rewardItemID);
            CommonPacket.Marshaler.Write(message, amberCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventExchangeKingAmber, Common.CG_RequestEventExchangeKingAmber);
        }

        public bool CG_RequestEventTreasureHuntInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntInfo, Common.CG_RequestEventTreasureHuntInfo);
        }

        public bool CG_RequestEventTreasureHuntStart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntStart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntStart, Common.CG_RequestEventTreasureHuntStart);
        }

        public bool CG_RequestEventTreasureHuntMoveDice(HostID remote, RmiContext rmiContext, int eventSEQ, byte diceNumber, byte diceSpeed)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntMoveDice);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, diceNumber);
            CommonPacket.Marshaler.Write(message, diceSpeed);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntMoveDice, Common.CG_RequestEventTreasureHuntMoveDice);
        }

        public bool CG_RequestEventTreasureHuntMoveChoosePoint(HostID remote, RmiContext rmiContext, int eventSEQ, byte pointID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntMoveChoosePoint);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, pointID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntMoveChoosePoint, Common.CG_RequestEventTreasureHuntMoveChoosePoint);
        }

        public bool CG_RequestEventTreasureHuntChooseReward(HostID remote, RmiContext rmiContext, int eventSEQ, byte rewardIndex, bool isMissionSucceed)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntChooseReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            CommonPacket.Marshaler.Write(message, isMissionSucceed);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntChooseReward, Common.CG_RequestEventTreasureHuntChooseReward);
        }

        public bool CG_RequestEventTreasureHuntComplete(HostID remote, RmiContext rmiContext, int eventSEQ, bool isRestart)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntComplete);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, isRestart);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntComplete, Common.CG_RequestEventTreasureHuntComplete);
        }

        public bool CG_RequestEventTreasureHuntCompleteReward(HostID remote, RmiContext rmiContext, int eventSEQ, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntCompleteReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntCompleteReward, Common.CG_RequestEventTreasureHuntCompleteReward);
        }

        public bool CG_RequestEventTreasureHuntMission(HostID remote, RmiContext rmiContext, int eventSEQ, bool isSucceed, byte diceSpeed)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventTreasureHuntMission);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, isSucceed);
            CommonPacket.Marshaler.Write(message, diceSpeed);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventTreasureHuntMission, Common.CG_RequestEventTreasureHuntMission);
        }

        public bool CG_RequestEventKOFBritanniaInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaInfo, Common.CG_RequestEventKOFBritanniaInfo);
        }

        public bool CG_RequestEventKOFBritanniaStart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaStart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaStart, Common.CG_RequestEventKOFBritanniaStart);
        }

        public bool CG_RequestEventKOFBritanniaTeamSelect(HostID remote, RmiContext rmiContext, int eventSEQ, int teamID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaTeamSelect);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, teamID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaTeamSelect, Common.CG_RequestEventKOFBritanniaTeamSelect);
        }

        public bool CG_RequestEventKOFBritanniaTeamChange(HostID remote, RmiContext rmiContext, int eventSEQ, UserTeamChangeInfo userTeamChangeInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaTeamChange);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaTeamChange, Common.CG_RequestEventKOFBritanniaTeamChange);
        }

        public bool CG_RequestEventKOFBritanniaStageStart(HostID remote, RmiContext rmiContext, StageStartRequestInfo stageStartRequestInfo, List<int> mercenaryHeroIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaStageStart);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            CommonPacket.Marshaler.Write(message, mercenaryHeroIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaStageStart, Common.CG_RequestEventKOFBritanniaStageStart);
        }

        public bool CG_RequestEventKOFBritanniaStageClear(HostID remote, RmiContext rmiContext, StageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaStageClear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaStageClear, Common.CG_RequestEventKOFBritanniaStageClear);
        }

        public bool CG_RequestEventKOFBritanniaStageContinue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaStageContinue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaStageContinue, Common.CG_RequestEventKOFBritanniaStageContinue);
        }

        public bool CG_RequestEventKOFBritanniaRestart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaRestart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaRestart, Common.CG_RequestEventKOFBritanniaRestart);
        }

        public bool CG_RequestEventKOFBritanniaStageRejoinCancel(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventKOFBritanniaStageRejoinCancel);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventKOFBritanniaStageRejoinCancel, Common.CG_RequestEventKOFBritanniaStageRejoinCancel);
        }

        public bool CG_RequestEventGamblePaybackReward(HostID remote, RmiContext rmiContext, int eventSEQ, short rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventGamblePaybackReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventGamblePaybackReward, Common.CG_RequestEventGamblePaybackReward);
        }

        public bool CG_RequestNMFunTalkKitLogin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestNMFunTalkKitLogin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestNMFunTalkKitLogin, Common.CG_RequestNMFunTalkKitLogin);
        }

        public bool CG_RequestNMFunTalkKitCreateRoom(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestNMFunTalkKitCreateRoom);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestNMFunTalkKitCreateRoom, Common.CG_RequestNMFunTalkKitCreateRoom);
        }

        public bool CG_Request_GuildBoss_User_Rank_Info(HostID remote, RmiContext rmiContext, GuildBossDifficulty difficulty)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_User_Rank_Info);
            CommonPacket.Marshaler.Write(message, difficulty);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_User_Rank_Info, Common.CG_Request_GuildBoss_User_Rank_Info);
        }

        public bool CG_Request_GuildBoss_User_Rank_Info_Range(HostID remote, RmiContext rmiContext, GuildBossDifficulty difficulty, int startRank, short count)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_GuildBoss_User_Rank_Info_Range);
            CommonPacket.Marshaler.Write(message, difficulty);
            CommonPacket.Marshaler.Write(message, startRank);
            CommonPacket.Marshaler.Write(message, count);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_GuildBoss_User_Rank_Info_Range, Common.CG_Request_GuildBoss_User_Rank_Info_Range);
        }

        public bool CG_RequestEventRandomBoxInfo(HostID remote, RmiContext rmiContext, int eventSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRandomBoxInfo);
            CommonPacket.Marshaler.Write(message, eventSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRandomBoxInfo, Common.CG_RequestEventRandomBoxInfo);
        }

        public bool CG_RequestEventRandomBoxCreate(HostID remote, RmiContext rmiContext, int eventSeq)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRandomBoxCreate);
            CommonPacket.Marshaler.Write(message, eventSeq);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRandomBoxCreate, Common.CG_RequestEventRandomBoxCreate);
        }

        public bool CG_RequestEventRandomBoxReward(HostID remote, RmiContext rmiContext, int eventSeq, byte slot)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRandomBoxReward);
            CommonPacket.Marshaler.Write(message, eventSeq);
            CommonPacket.Marshaler.Write(message, slot);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRandomBoxReward, Common.CG_RequestEventRandomBoxReward);
        }

        public bool CG_RequestFinalBossVowUpdate(HostID remote, RmiContext rmiContext, int stageId, List<int> vowIdList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestFinalBossVowUpdate);
            CommonPacket.Marshaler.Write(message, stageId);
            CommonPacket.Marshaler.Write(message, vowIdList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestFinalBossVowUpdate, Common.CG_RequestFinalBossVowUpdate);
        }

        public bool CG_RequestSeasonpassShopInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSeasonpassShopInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSeasonpassShopInfo, Common.CG_RequestSeasonpassShopInfo);
        }

        public bool CG_RequestSeasonpassShopBuy(HostID remote, RmiContext rmiContext, int eventSEQ, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestSeasonpassShopBuy);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestSeasonpassShopBuy, Common.CG_RequestSeasonpassShopBuy);
        }

        public bool CG_Request_EventPredict_User_Info(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventPredict_User_Info);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventPredict_User_Info, Common.CG_Request_EventPredict_User_Info);
        }

        public bool CG_Request_EventPredict_Start(HostID remote, RmiContext rmiContext, int eventSEQ, List<UserPredictInfo> predictList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventPredict_Start);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, predictList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventPredict_Start, Common.CG_Request_EventPredict_Start);
        }

        public bool CG_Request_EventPredict_Special_Reward(HostID remote, RmiContext rmiContext, int eventSEQ, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventPredict_Special_Reward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventPredict_Special_Reward, Common.CG_Request_EventPredict_Special_Reward);
        }

        public bool CG_RequestGuildWarLowLobbyInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowLobbyInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowLobbyInfo, Common.CG_RequestGuildWarLowLobbyInfo);
        }

        public bool CG_RequestGuildWarLowApply(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowApply);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowApply, Common.CG_RequestGuildWarLowApply);
        }

        public bool CG_RequestGuildWarLowAttackTeamChange(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowAttackTeamChange);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowAttackTeamChange, Common.CG_RequestGuildWarLowAttackTeamChange);
        }

        public bool CG_RequestGuildWarLowDefenceTeamChange(HostID remote, RmiContext rmiContext, int season, UserTeamChangeInfo userTeamChangeInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowDefenceTeamChange);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowDefenceTeamChange, Common.CG_RequestGuildWarLowDefenceTeamChange);
        }

        public bool CG_RequestGuildWarLowAreaDeployGuildMember(HostID remote, RmiContext rmiContext, int season, int areaID, long deployUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowAreaDeployGuildMember);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, areaID);
            CommonPacket.Marshaler.Write(message, deployUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowAreaDeployGuildMember, Common.CG_RequestGuildWarLowAreaDeployGuildMember);
        }

        public bool CG_RequestGuildWarLowAreaInfo(HostID remote, RmiContext rmiContext, int season, int targetGuildSN, int areaID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowAreaInfo);
            CommonPacket.Marshaler.Write(message, season);
            CommonPacket.Marshaler.Write(message, targetGuildSN);
            CommonPacket.Marshaler.Write(message, areaID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowAreaInfo, Common.CG_RequestGuildWarLowAreaInfo);
        }

        public bool CG_RequestGuildWarLowStageStart(HostID remote, RmiContext rmiContext, GuildWarLowStageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowStageStart);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowStageStart, Common.CG_RequestGuildWarLowStageStart);
        }

        public bool CG_RequestGuildWarLowStageClear(HostID remote, RmiContext rmiContext, GuildWarLowStageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowStageClear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowStageClear, Common.CG_RequestGuildWarLowStageClear);
        }

        public bool CG_RequestGuildWarLowStageRejoin(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowStageRejoin);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowStageRejoin, Common.CG_RequestGuildWarLowStageRejoin);
        }

        public bool CG_RequestGuildWarLowStageRejoinCancel(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowStageRejoinCancel);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowStageRejoinCancel, Common.CG_RequestGuildWarLowStageRejoinCancel);
        }

        public bool CG_RequestGuildWarLowStageSync(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowStageSync);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowStageSync, Common.CG_RequestGuildWarLowStageSync);
        }

        public bool CG_RequestGuildWarLowDefenceTeamSaveAll(HostID remote, RmiContext rmiContext, int totalDefenceTeamPower, List<UserTeamChangeInfo> userTeamChangeInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowDefenceTeamSaveAll);
            CommonPacket.Marshaler.Write(message, totalDefenceTeamPower);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowDefenceTeamSaveAll, Common.CG_RequestGuildWarLowDefenceTeamSaveAll);
        }

        public bool CG_RequestGuildWarLowBattleRecordInfo(HostID remote, RmiContext rmiContext, int guildSN, long deployUSN, bool isNeedDefenceTeam)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowBattleRecordInfo);
            CommonPacket.Marshaler.Write(message, guildSN);
            CommonPacket.Marshaler.Write(message, deployUSN);
            CommonPacket.Marshaler.Write(message, isNeedDefenceTeam);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowBattleRecordInfo, Common.CG_RequestGuildWarLowBattleRecordInfo);
        }

        public bool CG_RequestGuildWarLowMemberList(HostID remote, RmiContext rmiContext, int guildSN, bool isCheck)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowMemberList);
            CommonPacket.Marshaler.Write(message, guildSN);
            CommonPacket.Marshaler.Write(message, isCheck);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowMemberList, Common.CG_RequestGuildWarLowMemberList);
        }

        public bool CG_RequestGuildWarLowDefenceTeamInfo(HostID remote, RmiContext rmiContext, int guildSN, long deployUSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowDefenceTeamInfo);
            CommonPacket.Marshaler.Write(message, guildSN);
            CommonPacket.Marshaler.Write(message, deployUSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowDefenceTeamInfo, Common.CG_RequestGuildWarLowDefenceTeamInfo);
        }

        public bool CG_RequestGuildWarLowAreaInfoList(HostID remote, RmiContext rmiContext, int targetGuildSN)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowAreaInfoList);
            CommonPacket.Marshaler.Write(message, targetGuildSN);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowAreaInfoList, Common.CG_RequestGuildWarLowAreaInfoList);
        }

        public bool CG_RequestGuildWarLowRecordInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildWarLowRecordInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildWarLowRecordInfo, Common.CG_RequestGuildWarLowRecordInfo);
        }

        public bool CG_Request_EventAuto_On(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventAuto_On);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventAuto_On, Common.CG_Request_EventAuto_On);
        }

        public bool CG_Request_EventAuto_Result(HostID remote, RmiContext rmiContext, EventAutoInfo userEventAutoInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventAuto_Result);
            CommonPacket.Marshaler.Write(message, userEventAutoInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventAuto_Result, Common.CG_Request_EventAuto_Result);
        }

        public bool CG_Request_EventAuto_Battle_End(HostID remote, RmiContext rmiContext, EventAutoInfo userEventAutoInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventAuto_Battle_End);
            CommonPacket.Marshaler.Write(message, userEventAutoInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventAuto_Battle_End, Common.CG_Request_EventAuto_Battle_End);
        }

        public bool CG_Request_EventAuto_HawkUpgrade(HostID remote, RmiContext rmiContext, EventAutoInfo userEventAutoInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventAuto_HawkUpgrade);
            CommonPacket.Marshaler.Write(message, userEventAutoInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventAuto_HawkUpgrade, Common.CG_Request_EventAuto_HawkUpgrade);
        }

        public bool CG_Request_EventAuto_Reward(HostID remote, RmiContext rmiContext, EventAutoInfo userEventAutoInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventAuto_Reward);
            CommonPacket.Marshaler.Write(message, userEventAutoInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventAuto_Reward, Common.CG_Request_EventAuto_Reward);
        }

        public bool CG_Request_EventAuto_Box_Slot_Upgrade(HostID remote, RmiContext rmiContext, EventAutoInfo userEventAutoInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventAuto_Box_Slot_Upgrade);
            CommonPacket.Marshaler.Write(message, userEventAutoInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventAuto_Box_Slot_Upgrade, Common.CG_Request_EventAuto_Box_Slot_Upgrade);
        }

        public bool CG_Request_EventAuto_SpecialReward(HostID remote, RmiContext rmiContext, EventAutoInfo userEventAutoInfo, int rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_EventAuto_SpecialReward);
            CommonPacket.Marshaler.Write(message, userEventAutoInfo);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_EventAuto_SpecialReward, Common.CG_Request_EventAuto_SpecialReward);
        }

        public bool CG_RequestYggdrasilTowerStageStart(HostID remote, RmiContext rmiContext, YggdrasilTowerStageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestYggdrasilTowerStageStart);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestYggdrasilTowerStageStart, Common.CG_RequestYggdrasilTowerStageStart);
        }

        public bool CG_RequestYggdrasilTowerStageClear(HostID remote, RmiContext rmiContext, YggdrasilTowerStageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestYggdrasilTowerStageClear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestYggdrasilTowerStageClear, Common.CG_RequestYggdrasilTowerStageClear);
        }

        public bool CG_RequestYggdrasilTowerShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestYggdrasilTowerShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestYggdrasilTowerShopInfo, Common.CG_RequestYggdrasilTowerShopInfo);
        }

        public bool CG_RequestYggdrasilTowerShopBuy(HostID remote, RmiContext rmiContext, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestYggdrasilTowerShopBuy);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestYggdrasilTowerShopBuy, Common.CG_RequestYggdrasilTowerShopBuy);
        }

        public bool CG_Request_Yggdrasil_Tower_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_Yggdrasil_Tower_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_Yggdrasil_Tower_Stage_Continue, Common.CG_Request_Yggdrasil_Tower_Stage_Continue);
        }

        public bool CG_RequestArtifactCardPackOpen(HostID remote, RmiContext rmiContext, int itemId, int count)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArtifactCardPackOpen);
            CommonPacket.Marshaler.Write(message, itemId);
            CommonPacket.Marshaler.Write(message, count);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArtifactCardPackOpen, Common.CG_RequestArtifactCardPackOpen);
        }

        public bool CG_RequestArtifactUnionUpgrade(HostID remote, RmiContext rmiContext, int unionId, List<NeedItemInfo> useItemInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArtifactUnionUpgrade);
            CommonPacket.Marshaler.Write(message, unionId);
            CommonPacket.Marshaler.Write(message, useItemInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArtifactUnionUpgrade, Common.CG_RequestArtifactUnionUpgrade);
        }

        public bool CG_RequestArtifactTeamChange(HostID remote, RmiContext rmiContext, UserArtifactTeamInfo artifactTeamInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArtifactTeamChange);
            CommonPacket.Marshaler.Write(message, artifactTeamInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArtifactTeamChange, Common.CG_RequestArtifactTeamChange);
        }

        public bool CG_RequestArtifactDescentBossTeamChange(HostID remote, RmiContext rmiContext, List<UserArtifactTeamInfo> artifactTeamInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArtifactDescentBossTeamChange);
            CommonPacket.Marshaler.Write(message, artifactTeamInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArtifactDescentBossTeamChange, Common.CG_RequestArtifactDescentBossTeamChange);
        }

        public bool CG_RequestArtifactTeamInfoAll(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArtifactTeamInfoAll);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArtifactTeamInfoAll, Common.CG_RequestArtifactTeamInfoAll);
        }

        public bool CG_RequestArtifactDemonLordTeamChange(HostID remote, RmiContext rmiContext, List<UserArtifactTeamInfo> artifactTeamInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestArtifactDemonLordTeamChange);
            CommonPacket.Marshaler.Write(message, artifactTeamInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestArtifactDemonLordTeamChange, Common.CG_RequestArtifactDemonLordTeamChange);
        }

        public bool CG_RequestEventArtifactWishSave(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> artifactCardIdList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventArtifactWishSave);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, artifactCardIdList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventArtifactWishSave, Common.CG_RequestEventArtifactWishSave);
        }

        public bool CG_RequestEventArtifactWishCardPackOpen(HostID remote, RmiContext rmiContext, int eventSEQ, int count)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventArtifactWishCardPackOpen);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, count);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventArtifactWishCardPackOpen, Common.CG_RequestEventArtifactWishCardPackOpen);
        }

        public bool CG_RequestNorthGrimBookReward(HostID remote, RmiContext rmiContext, int grimContentID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestNorthGrimBookReward);
            CommonPacket.Marshaler.Write(message, grimContentID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestNorthGrimBookReward, Common.CG_RequestNorthGrimBookReward);
        }

        public bool CG_Request_CreatureNest_Season_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Season_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Season_Info, Common.CG_Request_CreatureNest_Season_Info);
        }

        public bool CG_Request_CreatureNest_Stage_Start(HostID remote, RmiContext rmiContext, CreatureNestStageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Stage_Start);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Stage_Start, Common.CG_Request_CreatureNest_Stage_Start);
        }

        public bool CG_Request_CreatureNest_Stage_Clear(HostID remote, RmiContext rmiContext, CreatureNestStageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Stage_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Stage_Clear, Common.CG_Request_CreatureNest_Stage_Clear);
        }

        public bool CG_Request_CreatureNest_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Stage_Continue, Common.CG_Request_CreatureNest_Stage_Continue);
        }

        public bool CG_Request_CreatureNest_Init(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Init);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Init, Common.CG_Request_CreatureNest_Init);
        }

        public bool CG_Request_CreatureNest_Team_Save(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Team_Save);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Team_Save, Common.CG_Request_CreatureNest_Team_Save);
        }

        public bool CG_Request_CreatureNest_Stage_Rejoin(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Stage_Rejoin);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Stage_Rejoin, Common.CG_Request_CreatureNest_Stage_Rejoin);
        }

        public bool CG_Request_CreatureNest_Stage_Rejoin_Cancel(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Stage_Rejoin_Cancel);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Stage_Rejoin_Cancel, Common.CG_Request_CreatureNest_Stage_Rejoin_Cancel);
        }

        public bool CG_Request_CreatureNest_Use_Reset_Item(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Use_Reset_Item);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Use_Reset_Item, Common.CG_Request_CreatureNest_Use_Reset_Item);
        }

        public bool CG_Request_CreatureNest_Challenge_Reward(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Challenge_Reward);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Challenge_Reward, Common.CG_Request_CreatureNest_Challenge_Reward);
        }

        public bool CG_Request_CreatureNest_Select_Group(HostID remote, RmiContext rmiContext, int groupId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureNest_Select_Group);
            CommonPacket.Marshaler.Write(message, groupId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureNest_Select_Group, Common.CG_Request_CreatureNest_Select_Group);
        }

        public bool CG_RequestEventCheerGroup(HostID remote, RmiContext rmiContext, int eventSEQ, int groupID, byte cheerCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventCheerGroup);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, groupID);
            CommonPacket.Marshaler.Write(message, cheerCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventCheerGroup, Common.CG_RequestEventCheerGroup);
        }

        public bool CG_RequestEventCheerGaugeReward(HostID remote, RmiContext rmiContext, int eventSEQ, int gaugeID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventCheerGaugeReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, gaugeID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventCheerGaugeReward, Common.CG_RequestEventCheerGaugeReward);
        }

        public bool CG_RequestEventCheerFinishReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventCheerFinishReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventCheerFinishReward, Common.CG_RequestEventCheerFinishReward);
        }

        public bool CG_RequestEventDiceInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDiceInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDiceInfo, Common.CG_RequestEventDiceInfo);
        }

        public bool CG_RequestEventDiceRoll(HostID remote, RmiContext rmiContext, int eventSEQ, bool isBonusRoll)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDiceRoll);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, isBonusRoll);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDiceRoll, Common.CG_RequestEventDiceRoll);
        }

        public bool CG_RequestEventDiceRollEventHandle(HostID remote, RmiContext rmiContext, int eventSEQ, int answerIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDiceRollEventHandle);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, answerIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDiceRollEventHandle, Common.CG_RequestEventDiceRollEventHandle);
        }

        public bool CG_RequestEventDiceRaceReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventDiceRaceReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventDiceRaceReward, Common.CG_RequestEventDiceRaceReward);
        }

        public bool CG_RequestConstellationStoneOpen(HostID remote, RmiContext rmiContext, byte group, List<int> stoneIdList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestConstellationStoneOpen);
            CommonPacket.Marshaler.Write(message, group);
            CommonPacket.Marshaler.Write(message, stoneIdList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestConstellationStoneOpen, Common.CG_RequestConstellationStoneOpen);
        }

        public bool CG_RequestConstellationStoneOptionValueChange(HostID remote, RmiContext rmiContext, byte group, ConstellationManaStoneColorType color)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestConstellationStoneOptionValueChange);
            CommonPacket.Marshaler.Write(message, group);
            CommonPacket.Marshaler.Write(message, color);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestConstellationStoneOptionValueChange, Common.CG_RequestConstellationStoneOptionValueChange);
        }

        public bool CG_RequestConstellationStoneOptionValueChangeApply(HostID remote, RmiContext rmiContext, byte gruop, bool isApply)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestConstellationStoneOptionValueChangeApply);
            CommonPacket.Marshaler.Write(message, gruop);
            CommonPacket.Marshaler.Write(message, isApply);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestConstellationStoneOptionValueChangeApply, Common.CG_RequestConstellationStoneOptionValueChangeApply);
        }

        public bool CG_RequestConstellationStoneLock(HostID remote, RmiContext rmiContext, int stoneId, bool isLock)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestConstellationStoneLock);
            CommonPacket.Marshaler.Write(message, stoneId);
            CommonPacket.Marshaler.Write(message, isLock);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestConstellationStoneLock, Common.CG_RequestConstellationStoneLock);
        }

        public bool CG_RequestMaterialFusion(HostID remote, RmiContext rmiContext, List<NeedItemInfo> matarialItemInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestMaterialFusion);
            CommonPacket.Marshaler.Write(message, matarialItemInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestMaterialFusion, Common.CG_RequestMaterialFusion);
        }

        public bool CG_RequestEventPuzzleInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPuzzleInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPuzzleInfo, Common.CG_RequestEventPuzzleInfo);
        }

        public bool CG_RequestEventPuzzleInfoStart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPuzzleInfoStart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPuzzleInfoStart, Common.CG_RequestEventPuzzleInfoStart);
        }

        public bool CG_RequestEventPuzzleInfoEnd(HostID remote, RmiContext rmiContext, int eventSEQ, List<EventPuzzleBlockScoreInfo> blockScoreInfoList, int score)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPuzzleInfoEnd);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, blockScoreInfoList);
            CommonPacket.Marshaler.Write(message, score);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPuzzleInfoEnd, Common.CG_RequestEventPuzzleInfoEnd);
        }

        public bool CG_RequestEventPuzzleInfoBlockReward(HostID remote, RmiContext rmiContext, int eventSEQ, int blockID, int rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPuzzleInfoBlockReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, blockID);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPuzzleInfoBlockReward, Common.CG_RequestEventPuzzleInfoBlockReward);
        }

        public bool CG_RequestEventPuzzleInfoTotalReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventPuzzleInfoTotalReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventPuzzleInfoTotalReward, Common.CG_RequestEventPuzzleInfoTotalReward);
        }

        public bool CG_RequestRandomLuckybagInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomLuckybagInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomLuckybagInfo, Common.CG_RequestRandomLuckybagInfo);
        }

        public bool CG_RequestRandomLuckybagOpen(HostID remote, RmiContext rmiContext, int eventSEQ, int openOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomLuckybagOpen);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, openOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomLuckybagOpen, Common.CG_RequestRandomLuckybagOpen);
        }

        public bool CG_RequestRandomLuckybagLastReward(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestRandomLuckybagLastReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestRandomLuckybagLastReward, Common.CG_RequestRandomLuckybagLastReward);
        }

        public bool CG_RequestAncientWarInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarInfo, Common.CG_RequestAncientWarInfo);
        }

        public bool CG_RequestAncientWarRefresh(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarRefresh);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarRefresh, Common.CG_RequestAncientWarRefresh);
        }

        public bool CG_RequestAncientWarTeamSelect(HostID remote, RmiContext rmiContext, int eventSEQ, AncientWarTeamType teamType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarTeamSelect);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, teamType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarTeamSelect, Common.CG_RequestAncientWarTeamSelect);
        }

        public bool CG_RequestAncientWarStageStart(HostID remote, RmiContext rmiContext, AncientWarStageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarStageStart);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarStageStart, Common.CG_RequestAncientWarStageStart);
        }

        public bool CG_RequestAncientWarStageClear(HostID remote, RmiContext rmiContext, AncientWarStageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarStageClear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarStageClear, Common.CG_RequestAncientWarStageClear);
        }

        public bool CG_RequestAncientWarExtraStageStart(HostID remote, RmiContext rmiContext, AncientWarExtraStageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarExtraStageStart);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarExtraStageStart, Common.CG_RequestAncientWarExtraStageStart);
        }

        public bool CG_RequestAncientWarExtraStageClear(HostID remote, RmiContext rmiContext, AncientWarExtraStageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarExtraStageClear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarExtraStageClear, Common.CG_RequestAncientWarExtraStageClear);
        }

        public bool CG_RequestAncientWarReward(HostID remote, RmiContext rmiContext, int eventSEQ, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarReward, Common.CG_RequestAncientWarReward);
        }

        public bool CG_RequestAncientWarDonation(HostID remote, RmiContext rmiContext, int eventSEQ, int areaId, int useCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarDonation);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, areaId);
            CommonPacket.Marshaler.Write(message, useCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarDonation, Common.CG_RequestAncientWarDonation);
        }

        public bool CG_RequestAncientWarRankInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestAncientWarRankInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestAncientWarRankInfo, Common.CG_RequestAncientWarRankInfo);
        }

        public bool CG_RequestEventStepupMissionStart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventStepupMissionStart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventStepupMissionStart, Common.CG_RequestEventStepupMissionStart);
        }

        public bool CG_RequestEventStepupMissionGroupClear(HostID remote, RmiContext rmiContext, int eventSEQ, int groupRewardID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventStepupMissionGroupClear);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, groupRewardID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventStepupMissionGroupClear, Common.CG_RequestEventStepupMissionGroupClear);
        }

        public bool CG_RequestEventGambleWishSave(HostID remote, RmiContext rmiContext, int eventSEQ, int gambleGroup, int skinId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventGambleWishSave);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, gambleGroup);
            CommonPacket.Marshaler.Write(message, skinId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventGambleWishSave, Common.CG_RequestEventGambleWishSave);
        }

        public bool CG_RequestEventMazeInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeInfo, Common.CG_RequestEventMazeInfo);
        }

        public bool CG_RequestEventMazeStart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStart, Common.CG_RequestEventMazeStart);
        }

        public bool CG_RequestEventMazeSelectStartHeroes(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> heroIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeSelectStartHeroes);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, heroIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeSelectStartHeroes, Common.CG_RequestEventMazeSelectStartHeroes);
        }

        public bool CG_RequestEventMazeInitialize(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeInitialize);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeInitialize, Common.CG_RequestEventMazeInitialize);
        }

        public bool CG_RequestEventMazeMove(HostID remote, RmiContext rmiContext, int eventSEQ, int stageID, int heroID, int mazeHeroID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeMove);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, stageID);
            CommonPacket.Marshaler.Write(message, heroID);
            CommonPacket.Marshaler.Write(message, mazeHeroID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeMove, Common.CG_RequestEventMazeMove);
        }

        public bool CG_RequestEventMazePassiveSelect(HostID remote, RmiContext rmiContext, int eventSEQ, int passiveID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazePassiveSelect);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, passiveID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazePassiveSelect, Common.CG_RequestEventMazePassiveSelect);
        }

        public bool CG_RequestEventMazeSeasonReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeSeasonReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeSeasonReward, Common.CG_RequestEventMazeSeasonReward);
        }

        public bool CG_RequestEventMazeChangeSlot(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> heroIDList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeChangeSlot);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, heroIDList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeChangeSlot, Common.CG_RequestEventMazeChangeSlot);
        }

        public bool CG_RequestEventMazeRefreshSelectableHeroes(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeRefreshSelectableHeroes);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeRefreshSelectableHeroes, Common.CG_RequestEventMazeRefreshSelectableHeroes);
        }

        public bool CG_RequestEventMazeShopBuy(HostID remote, RmiContext rmiContext, int eventSEQ, int stageID, int shopID, int heroID, int mazeHeroID, int passiveID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeShopBuy);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, stageID);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, heroID);
            CommonPacket.Marshaler.Write(message, mazeHeroID);
            CommonPacket.Marshaler.Write(message, passiveID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeShopBuy, Common.CG_RequestEventMazeShopBuy);
        }

        public bool CG_RequestEventMazeRefreshSelectablePassives(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeRefreshSelectablePassives);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeRefreshSelectablePassives, Common.CG_RequestEventMazeRefreshSelectablePassives);
        }

        public bool CG_RequestEventMazeSaveTeam(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeSaveTeam);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeSaveTeam, Common.CG_RequestEventMazeSaveTeam);
        }

        public bool CG_RequestEventMazeSelectClearBonus(HostID remote, RmiContext rmiContext, int eventSEQ, bool isClearBonus, int replayBonusID, int passiveID, int heroID, MazeSpotType mazeSpotType)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeSelectClearBonus);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, isClearBonus);
            CommonPacket.Marshaler.Write(message, replayBonusID);
            CommonPacket.Marshaler.Write(message, passiveID);
            CommonPacket.Marshaler.Write(message, heroID);
            CommonPacket.Marshaler.Write(message, mazeSpotType);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeSelectClearBonus, Common.CG_RequestEventMazeSelectClearBonus);
        }

        public bool CG_RequestEventMazeSeasonShopInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeSeasonShopInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeSeasonShopInfo, Common.CG_RequestEventMazeSeasonShopInfo);
        }

        public bool CG_RequestEventMazeSeasonShopBuy(HostID remote, RmiContext rmiContext, int seasonID, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeSeasonShopBuy);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeSeasonShopBuy, Common.CG_RequestEventMazeSeasonShopBuy);
        }

        public bool CG_RequestEventMazeStartSavedTeam(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeStartSavedTeam);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeStartSavedTeam, Common.CG_RequestEventMazeStartSavedTeam);
        }

        public bool CG_RequestEventMazeShopBuffBuy(HostID remote, RmiContext rmiContext, int eventSEQ, int stageID, int shopBuffID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMazeShopBuffBuy);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, stageID);
            CommonPacket.Marshaler.Write(message, shopBuffID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMazeShopBuffBuy, Common.CG_RequestEventMazeShopBuffBuy);
        }

        public bool CG_RequestEventMoleGameInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMoleGameInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMoleGameInfo, Common.CG_RequestEventMoleGameInfo);
        }

        public bool CG_RequestEventMoleGameStart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMoleGameStart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMoleGameStart, Common.CG_RequestEventMoleGameStart);
        }

        public bool CG_RequestEventMoleGameEnd(HostID remote, RmiContext rmiContext, int eventSEQ, int getScore, List<EventMoleGameRecordScoreInfo> recordScoreInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMoleGameEnd);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, getScore);
            CommonPacket.Marshaler.Write(message, recordScoreInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMoleGameEnd, Common.CG_RequestEventMoleGameEnd);
        }

        public bool CG_RequestEventMoleGameRecordReward(HostID remote, RmiContext rmiContext, int eventSEQ, int recordType, int rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMoleGameRecordReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, recordType);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMoleGameRecordReward, Common.CG_RequestEventMoleGameRecordReward);
        }

        public bool CG_RequestEventMoleGameTotalReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMoleGameTotalReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMoleGameTotalReward, Common.CG_RequestEventMoleGameTotalReward);
        }

        public bool CG_RequestEventMoleGameRankInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventMoleGameRankInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventMoleGameRankInfo, Common.CG_RequestEventMoleGameRankInfo);
        }

        public bool CG_RequestEventConfirmGameInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConfirmGameInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConfirmGameInfo, Common.CG_RequestEventConfirmGameInfo);
        }

        public bool CG_RequestEventConfirmGameStart(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConfirmGameStart);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConfirmGameStart, Common.CG_RequestEventConfirmGameStart);
        }

        public bool CG_RequestEventConfirmGameEnd(HostID remote, RmiContext rmiContext, int eventSEQ, int getScore, List<EventConfirmGameRecordScoreInfo> recordScoreInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConfirmGameEnd);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, getScore);
            CommonPacket.Marshaler.Write(message, recordScoreInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConfirmGameEnd, Common.CG_RequestEventConfirmGameEnd);
        }

        public bool CG_RequestEventConfirmGameRecordReward(HostID remote, RmiContext rmiContext, int eventSEQ, int recordType, int rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConfirmGameRecordReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, recordType);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConfirmGameRecordReward, Common.CG_RequestEventConfirmGameRecordReward);
        }

        public bool CG_RequestEventConfirmGameTotalReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardOrder)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConfirmGameTotalReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardOrder);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConfirmGameTotalReward, Common.CG_RequestEventConfirmGameTotalReward);
        }

        public bool CG_RequestEventLobbyBuffInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventLobbyBuffInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventLobbyBuffInfo, Common.CG_RequestEventLobbyBuffInfo);
        }

        public bool CG_RequestEventLobbyBuffBuy(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> buffIdList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventLobbyBuffBuy);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, buffIdList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventLobbyBuffBuy, Common.CG_RequestEventLobbyBuffBuy);
        }

        public bool CG_RequestEventBoxWishInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBoxWishInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBoxWishInfo, Common.CG_RequestEventBoxWishInfo);
        }

        public bool CG_RequestEventBoxWishSet(HostID remote, RmiContext rmiContext, int eventSEQ, int wishId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBoxWishSet);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, wishId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBoxWishSet, Common.CG_RequestEventBoxWishSet);
        }

        public bool CG_RequestEventBoxWishPickUp(HostID remote, RmiContext rmiContext, int eventSEQ, byte pickCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBoxWishPickUp);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, pickCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBoxWishPickUp, Common.CG_RequestEventBoxWishPickUp);
        }

        public bool CG_RequestEventBoxWishReset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBoxWishReset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBoxWishReset, Common.CG_RequestEventBoxWishReset);
        }

        public bool CG_RequestEventRoadInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRoadInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRoadInfo, Common.CG_RequestEventRoadInfo);
        }

        public bool CG_RequestEventRoadWalk(HostID remote, RmiContext rmiContext, int eventSEQ, List<short> idList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRoadWalk);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, idList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRoadWalk, Common.CG_RequestEventRoadWalk);
        }

        public bool CG_RequestEventRoadReward(HostID remote, RmiContext rmiContext, int eventSEQ, List<short> rewardIdList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRoadReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardIdList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRoadReward, Common.CG_RequestEventRoadReward);
        }

        public bool CG_RequestEventRoadSelect(HostID remote, RmiContext rmiContext, int eventSEQ, byte type)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventRoadSelect);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, type);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventRoadSelect, Common.CG_RequestEventRoadSelect);
        }

        public bool CG_RequestEventGambleBoxInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventGambleBoxInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventGambleBoxInfo, Common.CG_RequestEventGambleBoxInfo);
        }

        public bool CG_RequestEventGambleBoxPickup(HostID remote, RmiContext rmiContext, int eventSEQ, int count)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventGambleBoxPickup);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, count);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventGambleBoxPickup, Common.CG_RequestEventGambleBoxPickup);
        }

        public bool CG_RequestEventGambleBoxReset(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventGambleBoxReset);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventGambleBoxReset, Common.CG_RequestEventGambleBoxReset);
        }

        public bool CG_RequestEventConquestInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestInfo, Common.CG_RequestEventConquestInfo);
        }

        public bool CG_RequestEventConquestProductionDepotCompleteReward(HostID remote, RmiContext rmiContext, int eventSEQ, int depotIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestProductionDepotCompleteReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, depotIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestProductionDepotCompleteReward, Common.CG_RequestEventConquestProductionDepotCompleteReward);
        }

        public bool CG_RequestEventConquestProductionDepotUpgrade(HostID remote, RmiContext rmiContext, int eventSEQ, int depotIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestProductionDepotUpgrade);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, depotIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestProductionDepotUpgrade, Common.CG_RequestEventConquestProductionDepotUpgrade);
        }

        public bool CG_RequestEventConquestProductionDepotUpgradeReward(HostID remote, RmiContext rmiContext, int eventSEQ, int depotIndex, int rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestProductionDepotUpgradeReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, depotIndex);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestProductionDepotUpgradeReward, Common.CG_RequestEventConquestProductionDepotUpgradeReward);
        }

        public bool CG_RequestEventConquestAreaAttack(HostID remote, RmiContext rmiContext, int eventSEQ, int areaID, int attackCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestAreaAttack);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, areaID);
            CommonPacket.Marshaler.Write(message, attackCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestAreaAttack, Common.CG_RequestEventConquestAreaAttack);
        }

        public bool CG_RequestEventConquestAreaFeverAttack(HostID remote, RmiContext rmiContext, int eventSEQ, int areaID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestAreaFeverAttack);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, areaID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestAreaFeverAttack, Common.CG_RequestEventConquestAreaFeverAttack);
        }

        public bool CG_RequestEventConquestAreaAttackReward(HostID remote, RmiContext rmiContext, int eventSEQ, int areaID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestAreaAttackReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, areaID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestAreaAttackReward, Common.CG_RequestEventConquestAreaAttackReward);
        }

        public bool CG_RequestEventConquestMakeFeverItem(HostID remote, RmiContext rmiContext, int eventSEQ, int count)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestMakeFeverItem);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, count);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestMakeFeverItem, Common.CG_RequestEventConquestMakeFeverItem);
        }

        public bool CG_RequestEventConquestUpdateSceneIndex(HostID remote, RmiContext rmiContext, int eventSEQ, int sceneIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestUpdateSceneIndex);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, sceneIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestUpdateSceneIndex, Common.CG_RequestEventConquestUpdateSceneIndex);
        }

        public bool CG_RequestEventConquestUpdateUnitPos(HostID remote, RmiContext rmiContext, int eventSEQ, int unitID, int areaID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventConquestUpdateUnitPos);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, unitID);
            CommonPacket.Marshaler.Write(message, areaID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventConquestUpdateUnitPos, Common.CG_RequestEventConquestUpdateUnitPos);
        }

        public bool CG_RequestGuildOrderMissioInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildOrderMissioInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildOrderMissioInfo, Common.CG_RequestGuildOrderMissioInfo);
        }

        public bool CG_RequestGuildOrderMissionClear(HostID remote, RmiContext rmiContext, int missionID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildOrderMissionClear);
            CommonPacket.Marshaler.Write(message, missionID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildOrderMissionClear, Common.CG_RequestGuildOrderMissionClear);
        }

        public bool CG_RequestGuildOrderAPRewardBox(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildOrderAPRewardBox);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildOrderAPRewardBox, Common.CG_RequestGuildOrderAPRewardBox);
        }

        public bool CG_RequestGuildOrderMissionMileageBonusReward(HostID remote, RmiContext rmiContext, int mileageStep)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestGuildOrderMissionMileageBonusReward);
            CommonPacket.Marshaler.Write(message, mileageStep);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestGuildOrderMissionMileageBonusReward, Common.CG_RequestGuildOrderMissionMileageBonusReward);
        }

        public bool CG_RequestHeroLeagueInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueInfo, Common.CG_RequestHeroLeagueInfo);
        }

        public bool CG_RequestHeroLeagueSelectLeague(HostID remote, RmiContext rmiContext, byte league)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueSelectLeague);
            CommonPacket.Marshaler.Write(message, league);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueSelectLeague, Common.CG_RequestHeroLeagueSelectLeague);
        }

        public bool CG_RequestHeroLeagueInitialize(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueInitialize);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueInitialize, Common.CG_RequestHeroLeagueInitialize);
        }

        public bool CG_RequestHeroLeagueInitUserGroup(HostID remote, RmiContext rmiContext, int userGroup)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueInitUserGroup);
            CommonPacket.Marshaler.Write(message, userGroup);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueInitUserGroup, Common.CG_RequestHeroLeagueInitUserGroup);
        }

        public bool CG_RequestHeroLeagueGagueReward(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueGagueReward);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueGagueReward, Common.CG_RequestHeroLeagueGagueReward);
        }

        public bool CG_RequestHeroLeagueAttackTeamChange(HostID remote, RmiContext rmiContext, UserTeamChangeInfo userTeamChangeInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueAttackTeamChange);
            CommonPacket.Marshaler.Write(message, userTeamChangeInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueAttackTeamChange, Common.CG_RequestHeroLeagueAttackTeamChange);
        }

        public bool CG_RequestHeroLeagueStageStart(HostID remote, RmiContext rmiContext, HeroLeagueStageStartRequestInfo stageStartRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueStageStart);
            CommonPacket.Marshaler.Write(message, stageStartRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueStageStart, Common.CG_RequestHeroLeagueStageStart);
        }

        public bool CG_RequestHeroLeagueStageClear(HostID remote, RmiContext rmiContext, HeroLeagueStageClearRequestInfo stageClearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueStageClear);
            CommonPacket.Marshaler.Write(message, stageClearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueStageClear, Common.CG_RequestHeroLeagueStageClear);
        }

        public bool CG_RequestHeroLeagueSeasonShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueSeasonShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueSeasonShopInfo, Common.CG_RequestHeroLeagueSeasonShopInfo);
        }

        public bool CG_RequestHeroLeagueSeasonShopBuy(HostID remote, RmiContext rmiContext, int seasonID, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueSeasonShopBuy);
            CommonPacket.Marshaler.Write(message, seasonID);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueSeasonShopBuy, Common.CG_RequestHeroLeagueSeasonShopBuy);
        }

        public bool CG_RequestHeroLeagueStageRejoin(HostID remote, RmiContext rmiContext, int userGroup, byte teamNumber)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueStageRejoin);
            CommonPacket.Marshaler.Write(message, userGroup);
            CommonPacket.Marshaler.Write(message, teamNumber);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueStageRejoin, Common.CG_RequestHeroLeagueStageRejoin);
        }

        public bool CG_RequestHeroLeagueStageRejoinCancel(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueStageRejoinCancel);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueStageRejoinCancel, Common.CG_RequestHeroLeagueStageRejoinCancel);
        }

        public bool CG_RequestHeroLeagueScoreReward(HostID remote, RmiContext rmiContext, byte rewardIndex)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestHeroLeagueScoreReward);
            CommonPacket.Marshaler.Write(message, rewardIndex);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestHeroLeagueScoreReward, Common.CG_RequestHeroLeagueScoreReward);
        }

        public bool CG_Request_CreatureColosseum_Season_Info(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Season_Info);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Season_Info, Common.CG_Request_CreatureColosseum_Season_Info);
        }

        public bool CG_Request_CreatureColosseum_Stage_Start(HostID remote, RmiContext rmiContext, CreatureNestStageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Stage_Start);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Stage_Start, Common.CG_Request_CreatureColosseum_Stage_Start);
        }

        public bool CG_Request_CreatureColosseum_Stage_Clear(HostID remote, RmiContext rmiContext, CreatureNestStageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Stage_Clear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Stage_Clear, Common.CG_Request_CreatureColosseum_Stage_Clear);
        }

        public bool CG_Request_CreatureColosseum_Stage_Continue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Stage_Continue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Stage_Continue, Common.CG_Request_CreatureColosseum_Stage_Continue);
        }

        public bool CG_Request_CreatureColosseum_Init(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Init);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Init, Common.CG_Request_CreatureColosseum_Init);
        }

        public bool CG_Request_CreatureColosseum_Team_Save(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Team_Save);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Team_Save, Common.CG_Request_CreatureColosseum_Team_Save);
        }

        public bool CG_Request_CreatureColosseum_Stage_Rejoin(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Stage_Rejoin);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Stage_Rejoin, Common.CG_Request_CreatureColosseum_Stage_Rejoin);
        }

        public bool CG_Request_CreatureColosseum_Stage_Rejoin_Cancel(HostID remote, RmiContext rmiContext, int groupID)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_Request_CreatureColosseum_Stage_Rejoin_Cancel);
            CommonPacket.Marshaler.Write(message, groupID);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_Request_CreatureColosseum_Stage_Rejoin_Cancel, Common.CG_Request_CreatureColosseum_Stage_Rejoin_Cancel);
        }

        public bool CG_RequestCreatureColosseumShopInfo(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCreatureColosseumShopInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCreatureColosseumShopInfo, Common.CG_RequestCreatureColosseumShopInfo);
        }

        public bool CG_RequestCreatureColosseumShopBuy(HostID remote, RmiContext rmiContext, int shopID, byte buyCount)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestCreatureColosseumShopBuy);
            CommonPacket.Marshaler.Write(message, shopID);
            CommonPacket.Marshaler.Write(message, buyCount);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestCreatureColosseumShopBuy, Common.CG_RequestCreatureColosseumShopBuy);
        }

        public bool CG_RequestEventBalloonDartInfo(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBalloonDartInfo);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBalloonDartInfo, Common.CG_RequestEventBalloonDartInfo);
        }

        public bool CG_RequestEventBalloonDartThrow(HostID remote, RmiContext rmiContext, int eventSEQ, List<int> throwIndexList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBalloonDartThrow);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, throwIndexList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBalloonDartThrow, Common.CG_RequestEventBalloonDartThrow);
        }

        public bool CG_RequestEventBalloonDartChance(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBalloonDartChance);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBalloonDartChance, Common.CG_RequestEventBalloonDartChance);
        }

        public bool CG_RequestEventBalloonDartStepUp(HostID remote, RmiContext rmiContext, int eventSEQ)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBalloonDartStepUp);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBalloonDartStepUp, Common.CG_RequestEventBalloonDartStepUp);
        }

        public bool CG_RequestEventBalloonDartStepReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBalloonDartStepReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBalloonDartStepReward, Common.CG_RequestEventBalloonDartStepReward);
        }

        public bool CG_RequestEventBalloonDartTotalReward(HostID remote, RmiContext rmiContext, int eventSEQ, int rewardId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestEventBalloonDartTotalReward);
            CommonPacket.Marshaler.Write(message, eventSEQ);
            CommonPacket.Marshaler.Write(message, rewardId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestEventBalloonDartTotalReward, Common.CG_RequestEventBalloonDartTotalReward);
        }

        public bool CG_RequestDemonLordStageOpen(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDemonLordStageOpen);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDemonLordStageOpen, Common.CG_RequestDemonLordStageOpen);
        }

        public bool CG_RequestDemonLordStageStart(HostID remote, RmiContext rmiContext, StageStartRequestInfo startRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDemonLordStageStart);
            CommonPacket.Marshaler.Write(message, startRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDemonLordStageStart, Common.CG_RequestDemonLordStageStart);
        }

        public bool CG_RequestDemonLordStageClear(HostID remote, RmiContext rmiContext, StageClearRequestInfo clearRequestInfo)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDemonLordStageClear);
            CommonPacket.Marshaler.Write(message, clearRequestInfo);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDemonLordStageClear, Common.CG_RequestDemonLordStageClear);
        }

        public bool CG_RequestDemonLordStageContinue(HostID remote, RmiContext rmiContext)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDemonLordStageContinue);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDemonLordStageContinue, Common.CG_RequestDemonLordStageContinue);
        }

        public bool CG_RequestDemonLordStageCoinOpen(HostID remote, RmiContext rmiContext, List<NeedItemInfo> useItemInfoList)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestDemonLordStageCoinOpen);
            CommonPacket.Marshaler.Write(message, useItemInfoList);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestDemonLordStageCoinOpen, Common.CG_RequestDemonLordStageCoinOpen);
        }

        public bool CG_RequestChat(HostID remote, RmiContext rmiContext, ChatMsgType type, string msg, int stampId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestChat);
            CommonPacket.Marshaler.Write(message, type);
            CommonPacket.Marshaler.Write(message, msg);
            CommonPacket.Marshaler.Write(message, stampId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestChat, Common.CG_RequestChat);
        }

        public bool CG_RequestChatChannelEnter(HostID remote, RmiContext rmiContext, int channelId)
        {
            Message message = new Message() { SimplePacketMode = base.core.IsSimplePacketMode() };
            message.Write(Common.CG_RequestChatChannelEnter);
            CommonPacket.Marshaler.Write(message, channelId);
            return this.RmiSend(new HostID[] { remote }, rmiContext, message, RmiName_CG_RequestChatChannelEnter, Common.CG_RequestChatChannelEnter);
        }

        public override RmiID[] GetRmiIDList()
        {
            return Common.RmiIDList;
        }

        public const string RmiName_CG_RequestChannelUserInfo = "CG_RequestChannelUserInfo";

        public const string RmiName_CG_RequestHeartBeat = "CG_RequestHeartBeat";

        public const string RmiName_CG_RequestChangeNickname = "CG_RequestChangeNickname";

        public const string RmiName_CG_RequestChangeWantToSay = "CG_RequestChangeWantToSay";

        public const string RmiName_CG_RequestTeamInfo = "CG_RequestTeamInfo";

        public const string RmiName_CG_RequestTeamSlotChange = "CG_RequestTeamSlotChange";

        public const string RmiName_CG_RequestTeamNameChange = "CG_RequestTeamNameChange";

        public const string RmiName_CG_RequestLobbyInfo = "CG_RequestLobbyInfo";

        public const string RmiName_CG_RequestBasePointInfo = "CG_RequestBasePointInfo";

        public const string RmiName_CG_RequestMercenaryList = "CG_RequestMercenaryList";

        public const string RmiName_CG_RequestMercenaryInfo = "CG_RequestMercenaryInfo";

        public const string RmiName_CG_RequestGuildInfo = "CG_RequestGuildInfo";

        public const string RmiName_CG_RequestChatStampUpdateBookmark = "CG_RequestChatStampUpdateBookmark";

        public const string RmiName_CG_RequestChatStampUpdateQuickMessage = "CG_RequestChatStampUpdateQuickMessage";

        public const string RmiName_CG_RequestMainSkinChange = "CG_RequestMainSkinChange";

        public const string RmiName_CG_RequestEventList = "CG_RequestEventList";

        public const string RmiName_CG_RequestCheatEnter = "CG_RequestCheatEnter";

        public const string RmiName_CG_RequestCheatStageClear = "CG_RequestCheatStageClear";

        public const string RmiName_CG_RequestDllGetItem = "CG_RequestDllGetItem";

        public const string RmiName_CG_RequestRecommendFriendUSNList = "CG_RequestRecommendFriendUSNList";

        public const string RmiName_CG_RequestDailyReset = "CG_RequestDailyReset";

        public const string RmiName_CG_RequestFrozenAssetRedeem = "CG_RequestFrozenAssetRedeem";

        public const string RmiName_CG_RequestDataTableReload = "CG_RequestDataTableReload";

        public const string RmiName_CG_RequestRecommendHeroGrowthInfo = "CG_RequestRecommendHeroGrowthInfo";

        public const string RmiName_CG_RequestServerVersion = "CG_RequestServerVersion";

        public const string RmiName_CG_RequestSecurityToken = "CG_RequestSecurityToken";

        public const string RmiName_CG_RequestNetmarbleAuth = "CG_RequestNetmarbleAuth";

        public const string RmiName_CG_RequestAuthenticateCreate = "CG_RequestAuthenticateCreate";

        public const string RmiName_CG_RequestEditorUserInfoByNickName = "CG_RequestEditorUserInfoByNickName";

        public const string RmiName_CG_RequestLogin = "CG_RequestLogin";

        public const string RmiName_CG_RequestLoginInstantly = "CG_RequestLoginInstantly";

        public const string RmiName_CG_RetryRequest = "CG_RetryRequest";

        public const string RmiName_CG_RequestAccountWithdraw = "CG_RequestAccountWithdraw";

        public const string RmiName_CG_RequestAccountWithdrawCancel = "CG_RequestAccountWithdrawCancel";

        public const string RmiName_CG_RequestCookie = "CG_RequestCookie";

        public const string RmiName_CG_RequestVerifySecurityCertValue = "CG_RequestVerifySecurityCertValue";

        public const string RmiName_CG_RequestBillingInitialize = "CG_RequestBillingInitialize";

        public const string RmiName_CG_RequestBillingVerifyPU = "CG_RequestBillingVerifyPU";

        public const string RmiName_CG_RequestBillingRemainTR = "CG_RequestBillingRemainTR";

        public const string RmiName_CG_RequestBillingCouponVerify = "CG_RequestBillingCouponVerify";

        public const string RmiName_CG_RequestBillingCrossPromotion = "CG_RequestBillingCrossPromotion";

        public const string RmiName_CG_RequestBillingPackageShop = "CG_RequestBillingPackageShop";

        public const string RmiName_CG_RequestAgeInput = "CG_RequestAgeInput";

        public const string RmiName_CG_RequestSDKInfoChange = "CG_RequestSDKInfoChange";

        public const string RmiName_CG_RequestPCBillingInitialize = "CG_RequestPCBillingInitialize";

        public const string RmiName_CG_RequestPCBillingRemainItems = "CG_RequestPCBillingRemainItems";

        public const string RmiName_CG_RequestSkinLevelUpBySkinMaterial = "CG_RequestSkinLevelUpBySkinMaterial";

        public const string RmiName_CG_RequestSkinResearch = "CG_RequestSkinResearch";

        public const string RmiName_CG_RequestSkinResearchInit = "CG_RequestSkinResearchInit";

        public const string RmiName_CG_RequestSkinMaterialGrind = "CG_RequestSkinMaterialGrind";

        public const string RmiName_CG_RequestSkinAwaken = "CG_RequestSkinAwaken";

        public const string RmiName_CG_RequestSkinHeadStyleChange = "CG_RequestSkinHeadStyleChange";

        public const string RmiName_CG_RequestSkinEvolution = "CG_RequestSkinEvolution";

        public const string RmiName_CG_RequestSkinSkillLevelUp = "CG_RequestSkinSkillLevelUp";

        public const string RmiName_CG_RequestSkinGiveFellowshipExp = "CG_RequestSkinGiveFellowshipExp";

        public const string RmiName_CG_RequestSkinFellowshipLevelUpReward = "CG_RequestSkinFellowshipLevelUpReward";

        public const string RmiName_CG_RequestCostumeEquip = "CG_RequestCostumeEquip";

        public const string RmiName_CG_RequestCostumeUnEquip = "CG_RequestCostumeUnEquip";

        public const string RmiName_CG_RequestCostumeUnLock = "CG_RequestCostumeUnLock";

        public const string RmiName_CG_RequestSkinOverEvolution = "CG_RequestSkinOverEvolution";

        public const string RmiName_CG_RequestSkinMaxAwakenReward = "CG_RequestSkinMaxAwakenReward";

        public const string RmiName_CG_RequestCostumeRegister = "CG_RequestCostumeRegister";

        public const string RmiName_CG_RequestSkinLoveReward = "CG_RequestSkinLoveReward";

        public const string RmiName_CG_RequestCostumeAutoRegister = "CG_RequestCostumeAutoRegister";

        public const string RmiName_CG_RequestStoryCostume = "CG_RequestStoryCostume";

        public const string RmiName_CG_RequestCostumeLevelUp = "CG_RequestCostumeLevelUp";

        public const string RmiName_CG_RequestSkinMaxAwaken = "CG_RequestSkinMaxAwaken";

        public const string RmiName_CG_RequestBattlePointRegister = "CG_RequestBattlePointRegister";

        public const string RmiName_CG_RequestSkinTranscend = "CG_RequestSkinTranscend";

        public const string RmiName_CG_RequestSkinTranscendReset = "CG_RequestSkinTranscendReset";

        public const string RmiName_CG_RequestCostumeCraft = "CG_RequestCostumeCraft";

        public const string RmiName_CG_RequestLimitedCostumeCheck = "CG_RequestLimitedCostumeCheck";

        public const string RmiName_CG_RequestGetExclusiveSkill = "CG_RequestGetExclusiveSkill";

        public const string RmiName_CG_RequestSkinOneStepEvolution = "CG_RequestSkinOneStepEvolution";

        public const string RmiName_CG_RequestSkinOverEvolutionStraight = "CG_RequestSkinOverEvolutionStraight";

        public const string RmiName_CG_RequestSkinLegendEvolution = "CG_RequestSkinLegendEvolution";

        public const string RmiName_CG_RequestCostumeCraftUpgrade = "CG_RequestCostumeCraftUpgrade";

        public const string RmiName_CG_RequestSkinLevelupBonus = "CG_RequestSkinLevelupBonus";

        public const string RmiName_CG_RequestSkinExceed = "CG_RequestSkinExceed";

        public const string RmiName_CG_RequestWeaponEquip = "CG_RequestWeaponEquip";

        public const string RmiName_CG_RequestWeaponUnEquip = "CG_RequestWeaponUnEquip";

        public const string RmiName_CG_RequestWeaponSell = "CG_RequestWeaponSell";

        public const string RmiName_CG_RequestWeaponGrind = "CG_RequestWeaponGrind";

        public const string RmiName_CG_RequestWeaponUpgrade = "CG_RequestWeaponUpgrade";

        public const string RmiName_CG_RequestWeaponUpgradeRetry = "CG_RequestWeaponUpgradeRetry";

        public const string RmiName_CG_RequestWeaponEvolution = "CG_RequestWeaponEvolution";

        public const string RmiName_CG_RequestWeaponEvolutionRetry = "CG_RequestWeaponEvolutionRetry";

        public const string RmiName_CG_RequestWeaponOptionEnhance = "CG_RequestWeaponOptionEnhance";

        public const string RmiName_CG_RequestWeaponLock = "CG_RequestWeaponLock";

        public const string RmiName_CG_RequestWeaponUnLock = "CG_RequestWeaponUnLock";

        public const string RmiName_CG_RequestWeaponEquipExchange = "CG_RequestWeaponEquipExchange";

        public const string RmiName_CG_RequestWeaponEquipExchangeAll = "CG_RequestWeaponEquipExchangeAll";

        public const string RmiName_CG_RequestWeaponEquipRecommand = "CG_RequestWeaponEquipRecommand";

        public const string RmiName_CG_RequestWeaponCarve = "CG_RequestWeaponCarve";

        public const string RmiName_CG_RequestWeaponCarveRemove = "CG_RequestWeaponCarveRemove";

        public const string RmiName_CG_RequestWeaponUpgradeAndEvolution = "CG_RequestWeaponUpgradeAndEvolution";

        public const string RmiName_CG_RequestWeaponAutoOptionChange = "CG_RequestWeaponAutoOptionChange";

        public const string RmiName_CG_RequestStageInfo = "CG_RequestStageInfo";

        public const string RmiName_CG_RequestStageRejoin = "CG_RequestStageRejoin";

        public const string RmiName_CG_Request_Week_Stage_Start = "CG_Request_Week_Stage_Start";

        public const string RmiName_CG_Request_Week_Stage_Clear = "CG_Request_Week_Stage_Clear";

        public const string RmiName_CG_Request_Week_Stage_Continue = "CG_Request_Week_Stage_Continue";

        public const string RmiName_CG_Request_Main_Stage_Start = "CG_Request_Main_Stage_Start";

        public const string RmiName_CG_Request_Main_Stage_Clear = "CG_Request_Main_Stage_Clear";

        public const string RmiName_CG_Request_Main_Stage_Continue = "CG_Request_Main_Stage_Continue";

        public const string RmiName_CG_Request_Free_Stage_Start = "CG_Request_Free_Stage_Start";

        public const string RmiName_CG_Request_Free_Stage_Clear = "CG_Request_Free_Stage_Clear";

        public const string RmiName_CG_Request_Free_Stage_Continue = "CG_Request_Free_Stage_Continue";

        public const string RmiName_CG_RequestHawkRunStageStart = "CG_RequestHawkRunStageStart";

        public const string RmiName_CG_RequestHawkRunStageClear = "CG_RequestHawkRunStageClear";

        public const string RmiName_CG_RequestEventStageClear = "CG_RequestEventStageClear";

        public const string RmiName_CG_Request_Quest_Stage_Start = "CG_Request_Quest_Stage_Start";

        public const string RmiName_CG_Request_Quest_Stage_Clear = "CG_Request_Quest_Stage_Clear";

        public const string RmiName_CG_Request_Quest_Stage_Continue = "CG_Request_Quest_Stage_Continue";

        public const string RmiName_CG_Request_Boss_Stage_Start = "CG_Request_Boss_Stage_Start";

        public const string RmiName_CG_Request_Boss_Stage_Clear = "CG_Request_Boss_Stage_Clear";

        public const string RmiName_CG_Request_Boss_Stage_Continue = "CG_Request_Boss_Stage_Continue";

        public const string RmiName_CG_Request_Memorial_Stage_Start = "CG_Request_Memorial_Stage_Start";

        public const string RmiName_CG_Request_Memorial_Stage_Clear = "CG_Request_Memorial_Stage_Clear";

        public const string RmiName_CG_Request_Memorial_Stage_Continue = "CG_Request_Memorial_Stage_Continue";

        public const string RmiName_CG_Request_Limited_Stage_Start = "CG_Request_Limited_Stage_Start";

        public const string RmiName_CG_Request_Limited_Stage_Clear = "CG_Request_Limited_Stage_Clear";

        public const string RmiName_CG_Request_Limited_Stage_Continue = "CG_Request_Limited_Stage_Continue";

        public const string RmiName_CG_Request_Main_ExtraStage_Start = "CG_Request_Main_ExtraStage_Start";

        public const string RmiName_CG_Request_Main_ExtraStage_Clear = "CG_Request_Main_ExtraStage_Clear";

        public const string RmiName_CG_Request_Main_ExtraStage_Continue = "CG_Request_Main_ExtraStage_Continue";

        public const string RmiName_CG_Request_Boss_ExtraStage_Start = "CG_Request_Boss_ExtraStage_Start";

        public const string RmiName_CG_Request_Boss_ExtraStage_Clear = "CG_Request_Boss_ExtraStage_Clear";

        public const string RmiName_CG_Request_Boss_ExtraStage_Continue = "CG_Request_Boss_ExtraStage_Continue";

        public const string RmiName_CG_RequestRewardStageClear = "CG_RequestRewardStageClear";

        public const string RmiName_CG_Request_SingleSiege_ExtraStage_Start = "CG_Request_SingleSiege_ExtraStage_Start";

        public const string RmiName_CG_Request_SingleSiege_ExtraStage_Clear = "CG_Request_SingleSiege_ExtraStage_Clear";

        public const string RmiName_CG_Request_SingleSiege_ExtraStage_Continue = "CG_Request_SingleSiege_ExtraStage_Continue";

        public const string RmiName_CG_Request_FinalBoss_Stage_Start = "CG_Request_FinalBoss_Stage_Start";

        public const string RmiName_CG_Request_FinalBoss_Stage_Clear = "CG_Request_FinalBoss_Stage_Clear";

        public const string RmiName_CG_Request_FinalBoss_Stage_Continue = "CG_Request_FinalBoss_Stage_Continue";

        public const string RmiName_CG_Request_FinalBoss_Season_Info = "CG_Request_FinalBoss_Season_Info";

        public const string RmiName_CG_Request_Training_Stage_Info = "CG_Request_Training_Stage_Info";

        public const string RmiName_CG_Request_Training_Stage_Start = "CG_Request_Training_Stage_Start";

        public const string RmiName_CG_Request_Training_Stage_Clear = "CG_Request_Training_Stage_Clear";

        public const string RmiName_CG_Request_Training_Stage_Continue = "CG_Request_Training_Stage_Continue";

        public const string RmiName_CG_Request_Training_Stage_Open = "CG_Request_Training_Stage_Open";

        public const string RmiName_CG_Request_Training_Stage_Refresh = "CG_Request_Training_Stage_Refresh";

        public const string RmiName_CG_Request_GuildBoss_Stage_Start = "CG_Request_GuildBoss_Stage_Start";

        public const string RmiName_CG_Request_GuildBoss_Stage_Clear = "CG_Request_GuildBoss_Stage_Clear";

        public const string RmiName_CG_Request_GuildBoss_Lobby_Info = "CG_Request_GuildBoss_Lobby_Info";

        public const string RmiName_CG_Request_GuildBoss_Rank_Info = "CG_Request_GuildBoss_Rank_Info";

        public const string RmiName_CG_Request_GuildBoss_LastWeek_Rank_Info = "CG_Request_GuildBoss_LastWeek_Rank_Info";

        public const string RmiName_CG_Request_GuildBoss_Time_Refresh = "CG_Request_GuildBoss_Time_Refresh";

        public const string RmiName_CG_Request_AnotherMain_Stage_Start = "CG_Request_AnotherMain_Stage_Start";

        public const string RmiName_CG_Request_AnotherMain_Stage_Clear = "CG_Request_AnotherMain_Stage_Clear";

        public const string RmiName_CG_Request_AnotherMain_Stage_Continue = "CG_Request_AnotherMain_Stage_Continue";

        public const string RmiName_CG_Request_FinalBoss_Season_Rank_Info = "CG_Request_FinalBoss_Season_Rank_Info";

        public const string RmiName_CG_Request_Reverse_Stage_Start = "CG_Request_Reverse_Stage_Start";

        public const string RmiName_CG_Request_Reverse_Stage_Clear = "CG_Request_Reverse_Stage_Clear";

        public const string RmiName_CG_Request_Reverse_Star_Reward = "CG_Request_Reverse_Star_Reward";

        public const string RmiName_CG_Request_Reverse_Group_Reward = "CG_Request_Reverse_Group_Reward";

        public const string RmiName_CG_Request_Tower_Stage_Info = "CG_Request_Tower_Stage_Info";

        public const string RmiName_CG_Request_Tower_Stage_Set_Play_Deck = "CG_Request_Tower_Stage_Set_Play_Deck";

        public const string RmiName_CG_Request_Tower_Stage_Reset = "CG_Request_Tower_Stage_Reset";

        public const string RmiName_CG_Request_Tower_Stage_Start = "CG_Request_Tower_Stage_Start";

        public const string RmiName_CG_Request_Tower_Stage_Clear = "CG_Request_Tower_Stage_Clear";

        public const string RmiName_CG_Request_FinalBoss_Score_Reward = "CG_Request_FinalBoss_Score_Reward";

        public const string RmiName_CG_Request_GuildBoss_Off_Season_Stage_Start = "CG_Request_GuildBoss_Off_Season_Stage_Start";

        public const string RmiName_CG_Request_GuildBoss_Off_Season_Stage_Clear = "CG_Request_GuildBoss_Off_Season_Stage_Clear";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_Info = "CG_Request_Disaster_Tower_Stage_Info";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_Set_Play_Deck = "CG_Request_Disaster_Tower_Stage_Set_Play_Deck";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_Reset = "CG_Request_Disaster_Tower_Stage_Reset";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_Start = "CG_Request_Disaster_Tower_Stage_Start";

        public const string RmiName_CG_Request_Disaster_Tower_Stage_Clear = "CG_Request_Disaster_Tower_Stage_Clear";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_Start = "CG_Request_FinalBoss_Stage_Fame_Start";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_Clear = "CG_Request_FinalBoss_Stage_Fame_Clear";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_Season_Rank_Info = "CG_Request_FinalBoss_Stage_Fame_Season_Rank_Info";

        public const string RmiName_CG_Request_FinalBoss_Stage_Fame_MyScoreInfo = "CG_Request_FinalBoss_Stage_Fame_MyScoreInfo";

        public const string RmiName_CG_Request_Main_EventAreaStage_Start = "CG_Request_Main_EventAreaStage_Start";

        public const string RmiName_CG_Request_Main_EventAreaStage_Clear = "CG_Request_Main_EventAreaStage_Clear";

        public const string RmiName_CG_Request_Main_EventAreaStage_Continue = "CG_Request_Main_EventAreaStage_Continue";

        public const string RmiName_CG_Request_Free_EventAreaStage_Start = "CG_Request_Free_EventAreaStage_Start";

        public const string RmiName_CG_Request_Free_EventAreaStage_Clear = "CG_Request_Free_EventAreaStage_Clear";

        public const string RmiName_CG_Request_Free_EventAreaStage_Continue = "CG_Request_Free_EventAreaStage_Continue";

        public const string RmiName_CG_RequestEventAreaRewardStageClear = "CG_RequestEventAreaRewardStageClear";

        public const string RmiName_CG_Request_Free_EventStage_Start = "CG_Request_Free_EventStage_Start";

        public const string RmiName_CG_Request_Free_EventStage_Clear = "CG_Request_Free_EventStage_Clear";

        public const string RmiName_CG_Request_Free_EventStage_Continue = "CG_Request_Free_EventStage_Continue";

        public const string RmiName_CG_RequestEventExchange = "CG_RequestEventExchange";

        public const string RmiName_CG_RequestEventPlayCountReward = "CG_RequestEventPlayCountReward";

        public const string RmiName_CG_Request_Main_ListEventStage_Start = "CG_Request_Main_ListEventStage_Start";

        public const string RmiName_CG_Request_Main_ListEventStage_Clear = "CG_Request_Main_ListEventStage_Clear";

        public const string RmiName_CG_Request_Main_ListEventStage_Continue = "CG_Request_Main_ListEventStage_Continue";

        public const string RmiName_CG_Request_Free_ListEventStage_Start = "CG_Request_Free_ListEventStage_Start";

        public const string RmiName_CG_Request_Free_ListEventStage_Clear = "CG_Request_Free_ListEventStage_Clear";

        public const string RmiName_CG_Request_Free_ListEventStage_Continue = "CG_Request_Free_ListEventStage_Continue";

        public const string RmiName_CG_Request_FinalBoss_EventMainStage_Start = "CG_Request_FinalBoss_EventMainStage_Start";

        public const string RmiName_CG_Request_FinalBoss_EventMainStage_Clear = "CG_Request_FinalBoss_EventMainStage_Clear";

        public const string RmiName_CG_Request_FinalBoss_EventMainStage_Continue = "CG_Request_FinalBoss_EventMainStage_Continue";

        public const string RmiName_CG_Request_FinalBoss_EventFreeStage_Start = "CG_Request_FinalBoss_EventFreeStage_Start";

        public const string RmiName_CG_Request_FinalBoss_EventFreeStage_Clear = "CG_Request_FinalBoss_EventFreeStage_Clear";

        public const string RmiName_CG_Request_FinalBoss_EventFreeStage_Continue = "CG_Request_FinalBoss_EventFreeStage_Continue";

        public const string RmiName_CG_Request_Limited_EventStage_Start = "CG_Request_Limited_EventStage_Start";

        public const string RmiName_CG_Request_Limited_EventStage_Clear = "CG_Request_Limited_EventStage_Clear";

        public const string RmiName_CG_Request_Limited_EventStage_Continue = "CG_Request_Limited_EventStage_Continue";

        public const string RmiName_CG_Request_Boss_EventStage_Start = "CG_Request_Boss_EventStage_Start";

        public const string RmiName_CG_Request_Boss_EventStage_Clear = "CG_Request_Boss_EventStage_Clear";

        public const string RmiName_CG_Request_Boss_EventStage_Continue = "CG_Request_Boss_EventStage_Continue";

        public const string RmiName_CG_Request_Monthly_EventStage_Start = "CG_Request_Monthly_EventStage_Start";

        public const string RmiName_CG_Request_Monthly_EventStage_Clear = "CG_Request_Monthly_EventStage_Clear";

        public const string RmiName_CG_Request_Monthly_EventStage_Continue = "CG_Request_Monthly_EventStage_Continue";

        public const string RmiName_CG_RequestMonthlyStagePointReward = "CG_RequestMonthlyStagePointReward";

        public const string RmiName_CG_RequestWeekStageGaugeReward = "CG_RequestWeekStageGaugeReward";

        public const string RmiName_CG_RequestIngameBattleStart = "CG_RequestIngameBattleStart";

        public const string RmiName_CG_RequestStageEndLog = "CG_RequestStageEndLog";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_Start = "CG_Request_ChallengeBoss_EventStage_Start";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_Clear = "CG_Request_ChallengeBoss_EventStage_Clear";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_Continue = "CG_Request_ChallengeBoss_EventStage_Continue";

        public const string RmiName_CG_Request_ChallengeBoss_EventStage_Info = "CG_Request_ChallengeBoss_EventStage_Info";

        public const string RmiName_CG_Request_ChallengeBoss_Event_Point_Reward = "CG_Request_ChallengeBoss_Event_Point_Reward";

        public const string RmiName_CG_Request_DisasterBoss_Stage_Start = "CG_Request_DisasterBoss_Stage_Start";

        public const string RmiName_CG_Request_DisasterBoss_Stage_Clear = "CG_Request_DisasterBoss_Stage_Clear";

        public const string RmiName_CG_Request_DisasterBoss_Stage_Continue = "CG_Request_DisasterBoss_Stage_Continue";

        public const string RmiName_CG_Request_Week_EventStage_Start = "CG_Request_Week_EventStage_Start";

        public const string RmiName_CG_Request_Week_EventStage_Clear = "CG_Request_Week_EventStage_Clear";

        public const string RmiName_CG_Request_Week_EventStage_Continue = "CG_Request_Week_EventStage_Continue";

        public const string RmiName_CG_Request_Blitz_EventStage_Lobby_Info = "CG_Request_Blitz_EventStage_Lobby_Info";

        public const string RmiName_CG_Request_Blitz_EventStage_Squad_Change = "CG_Request_Blitz_EventStage_Squad_Change";

        public const string RmiName_CG_Request_Blitz_EventStage_Squad_Init = "CG_Request_Blitz_EventStage_Squad_Init";

        public const string RmiName_CG_Request_Blitz_EventStage_Team_Change = "CG_Request_Blitz_EventStage_Team_Change";

        public const string RmiName_CG_Request_Blitz_EventStage_Main_Start = "CG_Request_Blitz_EventStage_Main_Start";

        public const string RmiName_CG_Request_Blitz_EventStage_Main_Clear = "CG_Request_Blitz_EventStage_Main_Clear";

        public const string RmiName_CG_Request_Blitz_EventStage_Free_Start = "CG_Request_Blitz_EventStage_Free_Start";

        public const string RmiName_CG_Request_Blitz_EventStage_Free_Clear = "CG_Request_Blitz_EventStage_Free_Clear";

        public const string RmiName_CG_Request_Blitz_EventStage_Reward_Clear = "CG_Request_Blitz_EventStage_Reward_Clear";

        public const string RmiName_CG_Request_Blitz_EventStage_Rejoin = "CG_Request_Blitz_EventStage_Rejoin";

        public const string RmiName_CG_Request_Blitz_EventStage_Rejoin_Cancel = "CG_Request_Blitz_EventStage_Rejoin_Cancel";

        public const string RmiName_CG_RequestRecommandHero = "CG_RequestRecommandHero";

        public const string RmiName_CG_Request_Free_Once_EventAreaStage_Start = "CG_Request_Free_Once_EventAreaStage_Start";

        public const string RmiName_CG_Request_Free_Once_EventAreaStage_Clear = "CG_Request_Free_Once_EventAreaStage_Clear";

        public const string RmiName_CG_Request_Free_Once_EventAreaStage_Continue = "CG_Request_Free_Once_EventAreaStage_Continue";

        public const string RmiName_CG_Request_DescentBoss_EventStage_Start = "CG_Request_DescentBoss_EventStage_Start";

        public const string RmiName_CG_Request_DescentBoss_EventStage_Clear = "CG_Request_DescentBoss_EventStage_Clear";

        public const string RmiName_CG_Request_DescentBoss_EventStage_Continue = "CG_Request_DescentBoss_EventStage_Continue";

        public const string RmiName_CG_Request_DescentBoss_Event_Point_Reward = "CG_Request_DescentBoss_Event_Point_Reward";

        public const string RmiName_CG_Request_NorthMain_Stage_Start = "CG_Request_NorthMain_Stage_Start";

        public const string RmiName_CG_Request_NorthMain_Stage_Clear = "CG_Request_NorthMain_Stage_Clear";

        public const string RmiName_CG_Request_NorthMain_Stage_Continue = "CG_Request_NorthMain_Stage_Continue";

        public const string RmiName_CG_Request_North_Free_Once_Stage_Start = "CG_Request_North_Free_Once_Stage_Start";

        public const string RmiName_CG_Request_North_Free_Once_Stage_Clear = "CG_Request_North_Free_Once_Stage_Clear";

        public const string RmiName_CG_Request_North_Free_Once_Stage_Continue = "CG_Request_North_Free_Once_Stage_Continue";

        public const string RmiName_CG_Request_Another_Free_Once_Stage_Start = "CG_Request_Another_Free_Once_Stage_Start";

        public const string RmiName_CG_Request_Another_Free_Once_Stage_Clear = "CG_Request_Another_Free_Once_Stage_Clear";

        public const string RmiName_CG_Request_Another_Free_Once_Stage_Continue = "CG_Request_Another_Free_Once_Stage_Continue";

        public const string RmiName_CG_RequestEventMazeStageStart = "CG_RequestEventMazeStageStart";

        public const string RmiName_CG_RequestEventMazeStageClear = "CG_RequestEventMazeStageClear";

        public const string RmiName_CG_RequestEventMazeStageRejoin = "CG_RequestEventMazeStageRejoin";

        public const string RmiName_CG_RequestEventMazeStageRejoinCancel = "CG_RequestEventMazeStageRejoinCancel";

        public const string RmiName_CG_RequestEventMazeStageReChallenge = "CG_RequestEventMazeStageReChallenge";

        public const string RmiName_CG_RequestEventMazeStageReChallengeCancel = "CG_RequestEventMazeStageReChallengeCancel";

        public const string RmiName_CG_Request_Conquest_EventStage_Start = "CG_Request_Conquest_EventStage_Start";

        public const string RmiName_CG_Request_Conquest_EventStage_Clear = "CG_Request_Conquest_EventStage_Clear";

        public const string RmiName_CG_Request_Conquest_EventStage_Continue = "CG_Request_Conquest_EventStage_Continue";

        public const string RmiName_CG_Request_Disaster_Main_Stage_Start = "CG_Request_Disaster_Main_Stage_Start";

        public const string RmiName_CG_Request_Disaster_Main_Stage_Clear = "CG_Request_Disaster_Main_Stage_Clear";

        public const string RmiName_CG_Request_Disaster_Main_Stage_Continue = "CG_Request_Disaster_Main_Stage_Continue";

        public const string RmiName_CG_Request_Disaster_Free_Once_Stage_Start = "CG_Request_Disaster_Free_Once_Stage_Start";

        public const string RmiName_CG_Request_Disaster_Free_Once_Stage_Clear = "CG_Request_Disaster_Free_Once_Stage_Clear";

        public const string RmiName_CG_Request_Disaster_Free_Once_Stage_Continue = "CG_Request_Disaster_Free_Once_Stage_Continue";

        public const string RmiName_CG_RequestMailList = "CG_RequestMailList";

        public const string RmiName_CG_RequestMailConfirm = "CG_RequestMailConfirm";

        public const string RmiName_CG_RequestMailConfirmAll = "CG_RequestMailConfirmAll";

        public const string RmiName_CG_RequestMailHistoryList = "CG_RequestMailHistoryList";

        public const string RmiName_CG_RequestMailRecentlyHistoryList = "CG_RequestMailRecentlyHistoryList";

        public const string RmiName_CG_RequestFriendMailList = "CG_RequestFriendMailList";

        public const string RmiName_CG_RequestFriendMailConfirm = "CG_RequestFriendMailConfirm";

        public const string RmiName_CG_RequestFriendMailConfirmAll = "CG_RequestFriendMailConfirmAll";

        public const string RmiName_CG_RequestNoticeMailReward = "CG_RequestNoticeMailReward";

        public const string RmiName_CG_RequestPackageMailList = "CG_RequestPackageMailList";

        public const string RmiName_CG_RequestPackageMailGet = "CG_RequestPackageMailGet";

        public const string RmiName_CG_RequestPackageMailHistoryList = "CG_RequestPackageMailHistoryList";

        public const string RmiName_CG_RequestLevelUpPackageReward = "CG_RequestLevelUpPackageReward";

        public const string RmiName_CG_RequestLevelUpPackageRewardAll = "CG_RequestLevelUpPackageRewardAll";

        public const string RmiName_CG_RequestAttendancePackageReward = "CG_RequestAttendancePackageReward";

        public const string RmiName_CG_RequestAttendancePackageRewardAll = "CG_RequestAttendancePackageRewardAll";

        public const string RmiName_CG_RequestMailADReward = "CG_RequestMailADReward";

        public const string RmiName_CG_RequestGambleShopBuy = "CG_RequestGambleShopBuy";

        public const string RmiName_CG_RequestStepupGambleShopBuy = "CG_RequestStepupGambleShopBuy";

        public const string RmiName_CG_RequestStepupGambleMileageReward = "CG_RequestStepupGambleMileageReward";

        public const string RmiName_CG_RequestItemGambleShopInfo = "CG_RequestItemGambleShopInfo";

        public const string RmiName_CG_RequestItemGambleShopBuy = "CG_RequestItemGambleShopBuy";

        public const string RmiName_CG_RequestRandomShopBuy = "CG_RequestRandomShopBuy";

        public const string RmiName_CG_RequestRandomShopRefresh = "CG_RequestRandomShopRefresh";

        public const string RmiName_CG_RequestRandomShopInfo = "CG_RequestRandomShopInfo";

        public const string RmiName_CG_RequestBasePointShopInfo = "CG_RequestBasePointShopInfo";

        public const string RmiName_CG_RequestBasePointShopBuy = "CG_RequestBasePointShopBuy";

        public const string RmiName_CG_RequestBasePointShopReset = "CG_RequestBasePointShopReset";

        public const string RmiName_CG_RequestArenaRealTimePvpShopInfo = "CG_RequestArenaRealTimePvpShopInfo";

        public const string RmiName_CG_RequestArenaRealTimePvpShopBuy = "CG_RequestArenaRealTimePvpShopBuy";

        public const string RmiName_CG_RequestArenaRealTimePvpShopReset = "CG_RequestArenaRealTimePvpShopReset";

        public const string RmiName_CG_RequestCoinShopInfo = "CG_RequestCoinShopInfo";

        public const string RmiName_CG_RequestCoinShopBuy = "CG_RequestCoinShopBuy";

        public const string RmiName_CG_RequestEventCoinShopBuy = "CG_RequestEventCoinShopBuy";

        public const string RmiName_CG_RequestCostumeShopInfo = "CG_RequestCostumeShopInfo";

        public const string RmiName_CG_RequestCostumeShopBuy = "CG_RequestCostumeShopBuy";

        public const string RmiName_CG_RequestCostumeShopPackageBuy = "CG_RequestCostumeShopPackageBuy";

        public const string RmiName_CG_RequestDiaShopInfo = "CG_RequestDiaShopInfo";

        public const string RmiName_CG_RequestDiaShopBuy = "CG_RequestDiaShopBuy";

        public const string RmiName_CG_RequestItemInventoryBuy = "CG_RequestItemInventoryBuy";

        public const string RmiName_CG_RequestWeaponInventoryBuy = "CG_RequestWeaponInventoryBuy";

        public const string RmiName_CG_RequestWeekStageKeyBuy = "CG_RequestWeekStageKeyBuy";

        public const string RmiName_CG_RequestCommonItemSell = "CG_RequestCommonItemSell";

        public const string RmiName_CG_RequestCommonItemRemove = "CG_RequestCommonItemRemove";

        public const string RmiName_CG_RequestPackageBuy = "CG_RequestPackageBuy";

        public const string RmiName_CG_RequestBuyDia = "CG_RequestBuyDia";

        public const string RmiName_CG_RequestBuyGold = "CG_RequestBuyGold";

        public const string RmiName_CG_RequestBuyStamina = "CG_RequestBuyStamina";

        public const string RmiName_CG_RequestGuildShopInfo = "CG_RequestGuildShopInfo";

        public const string RmiName_CG_RequestGuildShopBuy = "CG_RequestGuildShopBuy";

        public const string RmiName_CG_RequestGuildShopReset = "CG_RequestGuildShopReset";

        public const string RmiName_CG_RequestFinalBossShopInfo = "CG_RequestFinalBossShopInfo";

        public const string RmiName_CG_RequestFinalBossShopBuy = "CG_RequestFinalBossShopBuy";

        public const string RmiName_CG_RequestBingoGambleShopInfo = "CG_RequestBingoGambleShopInfo";

        public const string RmiName_CG_RequestBingoGambleShopReset = "CG_RequestBingoGambleShopReset";

        public const string RmiName_CG_RequestBingoGambleShopReward = "CG_RequestBingoGambleShopReward";

        public const string RmiName_CG_RequestDiaShopPackageBuy = "CG_RequestDiaShopPackageBuy";

        public const string RmiName_CG_RequestRandomShopVisitReward = "CG_RequestRandomShopVisitReward";

        public const string RmiName_CG_RequestGambleChoiceShopBuy = "CG_RequestGambleChoiceShopBuy";

        public const string RmiName_CG_RequestRandomShopScheduleInfo = "CG_RequestRandomShopScheduleInfo";

        public const string RmiName_CG_RequestPackageShopInfo = "CG_RequestPackageShopInfo";

        public const string RmiName_CG_RequestFreePackageReward = "CG_RequestFreePackageReward";

        public const string RmiName_CG_RequestPackageMissionClose = "CG_RequestPackageMissionClose";

        public const string RmiName_CG_RequestGambleShopInfo = "CG_RequestGambleShopInfo";

        public const string RmiName_CG_RequestADRouletteReward = "CG_RequestADRouletteReward";

        public const string RmiName_CG_RequestGambleGaugeReward = "CG_RequestGambleGaugeReward";

        public const string RmiName_CG_RequestArenaSmashShopInfo = "CG_RequestArenaSmashShopInfo";

        public const string RmiName_CG_RequestArenaSmashShopBuy = "CG_RequestArenaSmashShopBuy";

        public const string RmiName_CG_RequestArenaSmashShopReward = "CG_RequestArenaSmashShopReward";

        public const string RmiName_CG_RequestArenaSmashShopReset = "CG_RequestArenaSmashShopReset";

        public const string RmiName_CG_RequestEvolutionExchange = "CG_RequestEvolutionExchange";

        public const string RmiName_CG_RequestQuestStart = "CG_RequestQuestStart";

        public const string RmiName_CG_RequestQuestProgress = "CG_RequestQuestProgress";

        public const string RmiName_CG_RequestQuestClear = "CG_RequestQuestClear";

        public const string RmiName_CG_RequestQuestRemove = "CG_RequestQuestRemove";

        public const string RmiName_CG_RequestDirectSelectorReward = "CG_RequestDirectSelectorReward";

        public const string RmiName_CG_RequestMissionProgress = "CG_RequestMissionProgress";

        public const string RmiName_CG_RequestMissionClear = "CG_RequestMissionClear";

        public const string RmiName_CG_RequestMissionEventClear = "CG_RequestMissionEventClear";

        public const string RmiName_CG_RequestMissionGetAchievePointReward = "CG_RequestMissionGetAchievePointReward";

        public const string RmiName_CG_RequestQuestChapterClear = "CG_RequestQuestChapterClear";

        public const string RmiName_CG_RequestEventMissionGetAchievePointReward = "CG_RequestEventMissionGetAchievePointReward";

        public const string RmiName_CG_RequestEventMissionCompleteReward = "CG_RequestEventMissionCompleteReward";

        public const string RmiName_CG_RequestEventMissionInfo = "CG_RequestEventMissionInfo";

        public const string RmiName_CG_RequestEventQuestClear = "CG_RequestEventQuestClear";

        public const string RmiName_CG_RequestAnotherQuestClear = "CG_RequestAnotherQuestClear";

        public const string RmiName_CG_RequestNorthQuestClear = "CG_RequestNorthQuestClear";

        public const string RmiName_CG_RequestQuestGuideListAllClearReward = "CG_RequestQuestGuideListAllClearReward";

        public const string RmiName_CG_RequestQuestGuideListStepStart = "CG_RequestQuestGuideListStepStart";

        public const string RmiName_CG_RequestQuestGuideListStepClear = "CG_RequestQuestGuideListStepClear";

        public const string RmiName_CG_RequestDisasterQuestClear = "CG_RequestDisasterQuestClear";

        public const string RmiName_CG_RequestLobbyVRSearch = "CG_RequestLobbyVRSearch";

        public const string RmiName_CG_RequestLobbyVRHelbram = "CG_RequestLobbyVRHelbram";

        public const string RmiName_CG_RequestLobbyNpcSkin = "CG_RequestLobbyNpcSkin";

        public const string RmiName_CG_RequestLobbyNpcGift = "CG_RequestLobbyNpcGift";

        public const string RmiName_CG_RequestLobbyKingAmber = "CG_RequestLobbyKingAmber";

        public const string RmiName_CG_RequestLobbyDropInteractiveOpen = "CG_RequestLobbyDropInteractiveOpen";

        public const string RmiName_CG_RequestLobbyUniqueInteractiveOpen = "CG_RequestLobbyUniqueInteractiveOpen";

        public const string RmiName_CG_RequestLobbyNpcTalkInfo = "CG_RequestLobbyNpcTalkInfo";

        public const string RmiName_CG_RequestLobbyNpcTalkChoice = "CG_RequestLobbyNpcTalkChoice";

        public const string RmiName_CG_RequestLobbyBarrel = "CG_RequestLobbyBarrel";

        public const string RmiName_CG_RequestLobbyBarrelRefill = "CG_RequestLobbyBarrelRefill";

        public const string RmiName_CG_RequestLobbyCleanTable = "CG_RequestLobbyCleanTable";

        public const string RmiName_CG_RequestLobbyServeBeer = "CG_RequestLobbyServeBeer";

        public const string RmiName_CG_RequestLobbyPlayJukebox = "CG_RequestLobbyPlayJukebox";

        public const string RmiName_CG_RequestLobbyElizabethTouch = "CG_RequestLobbyElizabethTouch";

        public const string RmiName_CG_RequestLobbyHawkAnger = "CG_RequestLobbyHawkAnger";

        public const string RmiName_CG_RequestAttendanceReward = "CG_RequestAttendanceReward";

        public const string RmiName_CG_RequestAttendanceEventReward = "CG_RequestAttendanceEventReward";

        public const string RmiName_CG_RequestCookingStart = "CG_RequestCookingStart";

        public const string RmiName_CG_RequestRecipeActive = "CG_RequestRecipeActive";

        public const string RmiName_CG_RequestCookingRecipeOrderInfo = "CG_RequestCookingRecipeOrderInfo";

        public const string RmiName_CG_RequestCookingRecipeOrder = "CG_RequestCookingRecipeOrder";

        public const string RmiName_CG_RequestCookingRecipeDisorder = "CG_RequestCookingRecipeDisorder";

        public const string RmiName_CG_RequestCookingRecipeCollect = "CG_RequestCookingRecipeCollect";

        public const string RmiName_CG_RequestCookingRecipeCollectOneSlot = "CG_RequestCookingRecipeCollectOneSlot";

        public const string RmiName_CG_RequestCookingUseCookingBuff = "CG_RequestCookingUseCookingBuff";

        public const string RmiName_CG_RequestGuestInfo = "CG_RequestGuestInfo";

        public const string RmiName_CG_RequestGuestChange = "CG_RequestGuestChange";

        public const string RmiName_CG_RequestGuestChangeTarget = "CG_RequestGuestChangeTarget";

        public const string RmiName_CG_RequestGuestTalk = "CG_RequestGuestTalk";

        public const string RmiName_CG_RequestGuestGift = "CG_RequestGuestGift";

        public const string RmiName_CG_RequestBirthdayNpcInfo = "CG_RequestBirthdayNpcInfo";

        public const string RmiName_CG_RequestRestReward = "CG_RequestRestReward";

        public const string RmiName_CG_RequestLobbyHousingShopInfo = "CG_RequestLobbyHousingShopInfo";

        public const string RmiName_CG_RequestLobbyHousingShopBuy = "CG_RequestLobbyHousingShopBuy";

        public const string RmiName_CG_RequestLobbyFurnitureRegist = "CG_RequestLobbyFurnitureRegist";

        public const string RmiName_CG_RequestUserMusicEdit = "CG_RequestUserMusicEdit";

        public const string RmiName_CG_RequestAttendanceFortuneEventReward = "CG_RequestAttendanceFortuneEventReward";

        public const string RmiName_CG_RequestEventCookingStart = "CG_RequestEventCookingStart";

        public const string RmiName_CG_RequestEventRecipeActive = "CG_RequestEventRecipeActive";

        public const string RmiName_CG_RequestLobbySetVisualType = "CG_RequestLobbySetVisualType";

        public const string RmiName_CG_RequestLobbySetAttendanceHero = "CG_RequestLobbySetAttendanceHero";

        public const string RmiName_CG_RequestBasePointGoldDonation = "CG_RequestBasePointGoldDonation";

        public const string RmiName_CG_RequestBasePointSetTrigger = "CG_RequestBasePointSetTrigger";

        public const string RmiName_CG_RequestBasePointDropInteractiveOpen = "CG_RequestBasePointDropInteractiveOpen";

        public const string RmiName_CG_RequestBasePointUniqueInteractiveOpen = "CG_RequestBasePointUniqueInteractiveOpen";

        public const string RmiName_CG_RequestBasePointDailyReward = "CG_RequestBasePointDailyReward";

        public const string RmiName_CG_RequestBasePointDonationEventReward = "CG_RequestBasePointDonationEventReward";

        public const string RmiName_CG_RequestBasePointDonationInfo = "CG_RequestBasePointDonationInfo";

        public const string RmiName_CG_RequestBasePointEventGoldDonation = "CG_RequestBasePointEventGoldDonation";

        public const string RmiName_CG_RequestEventBasepointInfo = "CG_RequestEventBasepointInfo";

        public const string RmiName_CG_RequestDestroySetInviteOption = "CG_RequestDestroySetInviteOption";

        public const string RmiName_CG_RequestDestroyGetUserLoginList = "CG_RequestDestroyGetUserLoginList";

        public const string RmiName_CG_RequestDestroyGetFriendLoginList = "CG_RequestDestroyGetFriendLoginList";

        public const string RmiName_CG_RequestDestroyGetGuildLoginList = "CG_RequestDestroyGetGuildLoginList";

        public const string RmiName_CG_RequestDestroyGetReceivedInvitationList = "CG_RequestDestroyGetReceivedInvitationList";

        public const string RmiName_CG_RequestDestroyInvite = "CG_RequestDestroyInvite";

        public const string RmiName_CG_RequestDestroyRemoveInvitation = "CG_RequestDestroyRemoveInvitation";

        public const string RmiName_CG_RequestDestroyRemoveJoinInfo = "CG_RequestDestroyRemoveJoinInfo";

        public const string RmiName_CG_RequestDestroyCreate = "CG_RequestDestroyCreate";

        public const string RmiName_CG_RequestDestroyJoin = "CG_RequestDestroyJoin";

        public const string RmiName_CG_RequestDestroyStart = "CG_RequestDestroyStart";

        public const string RmiName_CG_RequestDestroyBattleStart = "CG_RequestDestroyBattleStart";

        public const string RmiName_CG_RequestDestroyClear = "CG_RequestDestroyClear";

        public const string RmiName_CG_RequestDestroyReJoin = "CG_RequestDestroyReJoin";

        public const string RmiName_CG_RequestDestroyRemove = "CG_RequestDestroyRemove";

        public const string RmiName_CG_RequestDestroyBattleEnd = "CG_RequestDestroyBattleEnd";

        public const string RmiName_CG_RequestDestroyInviteAI = "CG_RequestDestroyInviteAI";

        public const string RmiName_CG_RequestDestroyKickOutAI = "CG_RequestDestroyKickOutAI";

        public const string RmiName_CG_RequestEventDestroyCreate = "CG_RequestEventDestroyCreate";

        public const string RmiName_CG_RequestEventDestroyStart = "CG_RequestEventDestroyStart";

        public const string RmiName_CG_RequestEventDestroyClear = "CG_RequestEventDestroyClear";

        public const string RmiName_CG_RequestEventDestroyRemove = "CG_RequestEventDestroyRemove";

        public const string RmiName_CG_RequestEventChallengeDestroyCreate = "CG_RequestEventChallengeDestroyCreate";

        public const string RmiName_CG_RequestEventChallengeDestroyStart = "CG_RequestEventChallengeDestroyStart";

        public const string RmiName_CG_RequestEventChallengeDestroyClear = "CG_RequestEventChallengeDestroyClear";

        public const string RmiName_CG_RequestEventChallengeDestroyPointRefresh = "CG_RequestEventChallengeDestroyPointRefresh";

        public const string RmiName_CG_RequestEventChallengeDestroyUserReward = "CG_RequestEventChallengeDestroyUserReward";

        public const string RmiName_CG_RequestEventChallengeDestroyWorldReward = "CG_RequestEventChallengeDestroyWorldReward";

        public const string RmiName_CG_RequestDisasterDestroyCreate = "CG_RequestDisasterDestroyCreate";

        public const string RmiName_CG_RequestDisasterDestroyStart = "CG_RequestDisasterDestroyStart";

        public const string RmiName_CG_RequestDisasterDestroyClear = "CG_RequestDisasterDestroyClear";

        public const string RmiName_CG_RequestEventDisasterDestroyCreate = "CG_RequestEventDisasterDestroyCreate";

        public const string RmiName_CG_RequestEventDisasterDestroyStart = "CG_RequestEventDisasterDestroyStart";

        public const string RmiName_CG_RequestEventDisasterDestroyClear = "CG_RequestEventDisasterDestroyClear";

        public const string RmiName_CG_RequestEventDisasterDestroyLeave = "CG_RequestEventDisasterDestroyLeave";

        public const string RmiName_CG_RequestDestroyOtherPlayerTeamInfo = "CG_RequestDestroyOtherPlayerTeamInfo";

        public const string RmiName_CG_RequestDestroyLiveJoinRegister = "CG_RequestDestroyLiveJoinRegister";

        public const string RmiName_CG_RequestDestroyLiveJoinUnregister = "CG_RequestDestroyLiveJoinUnregister";

        public const string RmiName_CG_RequestDestroyLiveJoinList = "CG_RequestDestroyLiveJoinList";

        public const string RmiName_CG_RequestDestroyLiveJoinInvite = "CG_RequestDestroyLiveJoinInvite";

        public const string RmiName_CG_RequestDestroyLiveJoinAbortInvitation = "CG_RequestDestroyLiveJoinAbortInvitation";

        public const string RmiName_CG_RequestDestroyLiveJoinRejectInvitation = "CG_RequestDestroyLiveJoinRejectInvitation";

        public const string RmiName_CG_RequestDestroyRoomInfo = "CG_RequestDestroyRoomInfo";

        public const string RmiName_CG_RequestFriendList = "CG_RequestFriendList";

        public const string RmiName_CG_RequestFriendGuildInfo = "CG_RequestFriendGuildInfo";

        public const string RmiName_CG_RequestFriendApplySendList = "CG_RequestFriendApplySendList";

        public const string RmiName_CG_RequestFriendApplyReceiveList = "CG_RequestFriendApplyReceiveList";

        public const string RmiName_CG_RequestFriendApplySend = "CG_RequestFriendApplySend";

        public const string RmiName_CG_RequestFriendApplyReject = "CG_RequestFriendApplyReject";

        public const string RmiName_CG_RequestFriendApplyReceiveAccept = "CG_RequestFriendApplyReceiveAccept";

        public const string RmiName_CG_RequestFriendApplyReceiveAcceptList = "CG_RequestFriendApplyReceiveAcceptList";

        public const string RmiName_CG_RequestFriendApplyReceiveRefuse = "CG_RequestFriendApplyReceiveRefuse";

        public const string RmiName_CG_RequestFriendApplyReceiveRefuseList = "CG_RequestFriendApplyReceiveRefuseList";

        public const string RmiName_CG_RequestFriendRemove = "CG_RequestFriendRemove";

        public const string RmiName_CG_RequestFriendSearch = "CG_RequestFriendSearch";

        public const string RmiName_CG_RequestFriendVisit = "CG_RequestFriendVisit";

        public const string RmiName_CG_RequestFriendPointSend = "CG_RequestFriendPointSend";

        public const string RmiName_CG_RequestFriendPointSendAll = "CG_RequestFriendPointSendAll";

        public const string RmiName_CG_RequestFriendLobbyInfo = "CG_RequestFriendLobbyInfo";

        public const string RmiName_CG_RequestFriendCookingRecipeInfo = "CG_RequestFriendCookingRecipeInfo";

        public const string RmiName_CG_RequestFriendCookingEat = "CG_RequestFriendCookingEat";

        public const string RmiName_CG_RequestFriendCookingEatFriendList = "CG_RequestFriendCookingEatFriendList";

        public const string RmiName_CG_RequestRefreshRecommendFriendList = "CG_RequestRefreshRecommendFriendList";

        public const string RmiName_CG_RequestGuildRecommendList = "CG_RequestGuildRecommendList";

        public const string RmiName_CG_RequestGuildInfoWithMemberList = "CG_RequestGuildInfoWithMemberList";

        public const string RmiName_CG_RequestGuildSearchByName = "CG_RequestGuildSearchByName";

        public const string RmiName_CG_RequestGuildCreate = "CG_RequestGuildCreate";

        public const string RmiName_CG_RequestGuildDisband = "CG_RequestGuildDisband";

        public const string RmiName_CG_RequestGuildApplicantList = "CG_RequestGuildApplicantList";

        public const string RmiName_CG_RequestGuildApply = "CG_RequestGuildApply";

        public const string RmiName_CG_RequestGuildReturnApplication = "CG_RequestGuildReturnApplication";

        public const string RmiName_CG_RequestGuildAcceptApplicant = "CG_RequestGuildAcceptApplicant";

        public const string RmiName_CG_RequestGuildRejectApplicant = "CG_RequestGuildRejectApplicant";

        public const string RmiName_CG_RequestGuildLevelUp = "CG_RequestGuildLevelUp";

        public const string RmiName_CG_RequestGuildChangeName = "CG_RequestGuildChangeName";

        public const string RmiName_CG_RequestGuildChangeBoard = "CG_RequestGuildChangeBoard";

        public const string RmiName_CG_RequestGuildChangeMaster = "CG_RequestGuildChangeMaster";

        public const string RmiName_CG_RequestGuildChangeMemberGrade = "CG_RequestGuildChangeMemberGrade";

        public const string RmiName_CG_RequestGuildKickOutMember = "CG_RequestGuildKickOutMember";

        public const string RmiName_CG_RequestGuildLeave = "CG_RequestGuildLeave";

        public const string RmiName_CG_RequestGuildRoomInfo = "CG_RequestGuildRoomInfo";

        public const string RmiName_CG_RequestGuildAttendance = "CG_RequestGuildAttendance";

        public const string RmiName_CG_RequestGuildAttendanceReward = "CG_RequestGuildAttendanceReward";

        public const string RmiName_CG_RequestGuildUserInfo = "CG_RequestGuildUserInfo";

        public const string RmiName_CG_RequestGuildAttendanceStatus = "CG_RequestGuildAttendanceStatus";

        public const string RmiName_CG_RequestGuildDonation = "CG_RequestGuildDonation";

        public const string RmiName_CG_RequestGuildDonationInitialize = "CG_RequestGuildDonationInitialize";

        public const string RmiName_CG_RequestGuildMissionInfo = "CG_RequestGuildMissionInfo";

        public const string RmiName_CG_RequestGuildMissionReward = "CG_RequestGuildMissionReward";

        public const string RmiName_CG_RequestGuildDonationInfo = "CG_RequestGuildDonationInfo";

        public const string RmiName_CG_RequestGuildSkillInfo = "CG_RequestGuildSkillInfo";

        public const string RmiName_CG_RequestGuildSkillLevelUp = "CG_RequestGuildSkillLevelUp";

        public const string RmiName_CG_RequestGuildSkillUse = "CG_RequestGuildSkillUse";

        public const string RmiName_CG_RequestGuildSkillDisuse = "CG_RequestGuildSkillDisuse";

        public const string RmiName_CG_RequestGuildSkillUseInfo = "CG_RequestGuildSkillUseInfo";

        public const string RmiName_CG_RequestGuildBossRankPointReward = "CG_RequestGuildBossRankPointReward";

        public const string RmiName_CG_RequestGuildBattlePointRegister = "CG_RequestGuildBattlePointRegister";

        public const string RmiName_CG_RequestGuildBattlePointMemeberRankList = "CG_RequestGuildBattlePointMemeberRankList";

        public const string RmiName_CG_RequestGuildBattlePointGuildRankList = "CG_RequestGuildBattlePointGuildRankList";

        public const string RmiName_CG_RequestGuildBattlePointUserRankList = "CG_RequestGuildBattlePointUserRankList";

        public const string RmiName_CG_RequestGuildInvitationReceivedList = "CG_RequestGuildInvitationReceivedList";

        public const string RmiName_CG_RequestGuildInvitationSend = "CG_RequestGuildInvitationSend";

        public const string RmiName_CG_RequestGuildInvitationRemove = "CG_RequestGuildInvitationRemove";

        public const string RmiName_CG_RequestGuildInvitationSetOption = "CG_RequestGuildInvitationSetOption";

        public const string RmiName_CG_RequestGuildMarkInfo = "CG_RequestGuildMarkInfo";

        public const string RmiName_CG_RequestGuildRecruitList = "CG_RequestGuildRecruitList";

        public const string RmiName_CG_RequestGuildRecruitApply = "CG_RequestGuildRecruitApply";

        public const string RmiName_CG_RequestGuildRecruitCancel = "CG_RequestGuildRecruitCancel";

        public const string RmiName_CG_RequestAPRechargeByUseItem = "CG_RequestAPRechargeByUseItem";

        public const string RmiName_CG_RequestWeekStageKeyOpen = "CG_RequestWeekStageKeyOpen";

        public const string RmiName_CG_RequestFoodBuffAutoUseOnOff = "CG_RequestFoodBuffAutoUseOnOff";

        public const string RmiName_CG_RequestItemUseRankExp = "CG_RequestItemUseRankExp";

        public const string RmiName_CG_RequestItemUseBoxOpen = "CG_RequestItemUseBoxOpen";

        public const string RmiName_CG_RequestItemUseRecipeExp = "CG_RequestItemUseRecipeExp";

        public const string RmiName_CG_RequestItemUseWeeklyKeyBox = "CG_RequestItemUseWeeklyKeyBox";

        public const string RmiName_CG_RequestItemUseWeaponTicket = "CG_RequestItemUseWeaponTicket";

        public const string RmiName_CG_RequestItemUseMusic = "CG_RequestItemUseMusic";

        public const string RmiName_CG_RequestItemUseBuff = "CG_RequestItemUseBuff";

        public const string RmiName_CG_RequestWeekStageCoinOpen = "CG_RequestWeekStageCoinOpen";

        public const string RmiName_CG_RequestTutorialAddStep = "CG_RequestTutorialAddStep";

        public const string RmiName_CG_RequestTutorialSetFlag = "CG_RequestTutorialSetFlag";

        public const string RmiName_CG_RequestTutorialHeroFlag = "CG_RequestTutorialHeroFlag";

        public const string RmiName_CG_RequestTutorialGambleShopBuy = "CG_RequestTutorialGambleShopBuy";

        public const string RmiName_CG_RequestBattleTutorialInfo = "CG_RequestBattleTutorialInfo";

        public const string RmiName_CG_RequestBattleTutorialSet = "CG_RequestBattleTutorialSet";

        public const string RmiName_CG_RequestFriendlyMatchCreate = "CG_RequestFriendlyMatchCreate";

        public const string RmiName_CG_RequestFriendlyMatchFriendList = "CG_RequestFriendlyMatchFriendList";

        public const string RmiName_CG_RequestFriendlyMatchInvite = "CG_RequestFriendlyMatchInvite";

        public const string RmiName_CG_RequestFriendlyMatchReceivedInviteList = "CG_RequestFriendlyMatchReceivedInviteList";

        public const string RmiName_CG_RequestFriendlyMatchInviteAccept = "CG_RequestFriendlyMatchInviteAccept";

        public const string RmiName_CG_RequestFriendlyMatchInviteReject = "CG_RequestFriendlyMatchInviteReject";

        public const string RmiName_CG_RequestFriendlyMatchStart = "CG_RequestFriendlyMatchStart";

        public const string RmiName_CG_RequestFriendlyMatchBattleStart = "CG_RequestFriendlyMatchBattleStart";

        public const string RmiName_CG_RequestFriendlyMatchClear = "CG_RequestFriendlyMatchClear";

        public const string RmiName_CG_RequestFriendlyMatchExit = "CG_RequestFriendlyMatchExit";

        public const string RmiName_CG_RequestFriendlyMatchSetInviteOption = "CG_RequestFriendlyMatchSetInviteOption";

        public const string RmiName_CG_RequestFriendlyMatchObserveCreate = "CG_RequestFriendlyMatchObserveCreate";

        public const string RmiName_CG_RequestFriendlyMatchObserveFriendList = "CG_RequestFriendlyMatchObserveFriendList";

        public const string RmiName_CG_RequestFriendlyMatchObserveInvite = "CG_RequestFriendlyMatchObserveInvite";

        public const string RmiName_CG_RequestFriendlyMatchObserveReceivedInviteList = "CG_RequestFriendlyMatchObserveReceivedInviteList";

        public const string RmiName_CG_RequestFriendlyMatchObserveInviteAccept = "CG_RequestFriendlyMatchObserveInviteAccept";

        public const string RmiName_CG_RequestFriendlyMatchObserveInviteReject = "CG_RequestFriendlyMatchObserveInviteReject";

        public const string RmiName_CG_RequestFriendlyMatchObserveStart = "CG_RequestFriendlyMatchObserveStart";

        public const string RmiName_CG_RequestFriendlyMatchObserveBattleStart = "CG_RequestFriendlyMatchObserveBattleStart";

        public const string RmiName_CG_RequestFriendlyMatchObserveClear = "CG_RequestFriendlyMatchObserveClear";

        public const string RmiName_CG_RequestFriendlyMatchObserveExit = "CG_RequestFriendlyMatchObserveExit";

        public const string RmiName_CG_RequestFriendlyMatchObserveSetInviteOption = "CG_RequestFriendlyMatchObserveSetInviteOption";

        public const string RmiName_CG_RequestEventSeasonPassInfo = "CG_RequestEventSeasonPassInfo";

        public const string RmiName_CG_RequestEventSeasonPassRankUpReward = "CG_RequestEventSeasonPassRankUpReward";

        public const string RmiName_CG_RequestEventSeasonPassRankUpRewardAll = "CG_RequestEventSeasonPassRankUpRewardAll";

        public const string RmiName_CG_RequestEventSeasonPassRankBuy = "CG_RequestEventSeasonPassRankBuy";

        public const string RmiName_CG_RequestWestSideServerInfo_Random = "CG_RequestWestSideServerInfo_Random";

        public const string RmiName_CG_RequestWestSideServerInfo_Fixed = "CG_RequestWestSideServerInfo_Fixed";

        public const string RmiName_CG_RequestWestSideServerInfo_Recommand = "CG_RequestWestSideServerInfo_Recommand";

        public const string RmiName_CG_RequestWestSide_PlayerInfo = "CG_RequestWestSide_PlayerInfo";

        public const string RmiName_CG_RequestWestSide_PlayerteamInfo = "CG_RequestWestSide_PlayerteamInfo";

        public const string RmiName_CG_RequestWestSide_PlayerGuildInfo = "CG_RequestWestSide_PlayerGuildInfo";

        public const string RmiName_CG_RequestWorldChattingChannel = "CG_RequestWorldChattingChannel";

        public const string RmiName_CG_RequestArenaRealTimePvpLobbyInfo = "CG_RequestArenaRealTimePvpLobbyInfo";

        public const string RmiName_CG_RequestArenaRealTimePvpJoin = "CG_RequestArenaRealTimePvpJoin";

        public const string RmiName_CG_RequestArenaRealTimePvpTopRankerList = "CG_RequestArenaRealTimePvpTopRankerList";

        public const string RmiName_CG_RequestArenaRealTimePvpLastRankerList = "CG_RequestArenaRealTimePvpLastRankerList";

        public const string RmiName_CG_RequestArenaRealTimePvpMatching = "CG_RequestArenaRealTimePvpMatching";

        public const string RmiName_CG_RequestArenaRealTimePvpBattleStart = "CG_RequestArenaRealTimePvpBattleStart";

        public const string RmiName_CG_RequestArenaRealTimePvpBattleEnd = "CG_RequestArenaRealTimePvpBattleEnd";

        public const string RmiName_CG_RequestArenaRealTimePvpRollback = "CG_RequestArenaRealTimePvpRollback";

        public const string RmiName_CG_RequestArenaRealTimePvpIngameBattleStart = "CG_RequestArenaRealTimePvpIngameBattleStart";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerLobbyInfo = "CG_RequestArenaRealTimePvpLowerLobbyInfo";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerJoin = "CG_RequestArenaRealTimePvpLowerJoin";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerTopRankerList = "CG_RequestArenaRealTimePvpLowerTopRankerList";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerMatching = "CG_RequestArenaRealTimePvpLowerMatching";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerBattleEnd = "CG_RequestArenaRealTimePvpLowerBattleEnd";

        public const string RmiName_CG_RequestArenaRealTimePvpAllInfo = "CG_RequestArenaRealTimePvpAllInfo";

        public const string RmiName_CG_RequestArenaRealTimePvpLastRankerBattleInfo = "CG_RequestArenaRealTimePvpLastRankerBattleInfo";

        public const string RmiName_CG_RequestArenaRealTimePvpLastRankerBattleStart = "CG_RequestArenaRealTimePvpLastRankerBattleStart";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerRollback = "CG_RequestArenaRealTimePvpLowerRollback";

        public const string RmiName_CG_RequestArenaRealTimePvpLowerIngameBattleStart = "CG_RequestArenaRealTimePvpLowerIngameBattleStart";

        public const string RmiName_CG_RequestArenaRankingLobbyInfo = "CG_RequestArenaRankingLobbyInfo";

        public const string RmiName_CG_RequestArenaRankingJoin = "CG_RequestArenaRankingJoin";

        public const string RmiName_CG_RequestArenaRankingTopRankerList = "CG_RequestArenaRankingTopRankerList";

        public const string RmiName_CG_RequestArenaRankingMatching = "CG_RequestArenaRankingMatching";

        public const string RmiName_CG_RequestArenaRankingBattleEnd = "CG_RequestArenaRankingBattleEnd";

        public const string RmiName_CG_RequestArenaRankingIngameBattleStart = "CG_RequestArenaRankingIngameBattleStart";

        public const string RmiName_CG_RequestArenaRankingDefenceTeamUpdate = "CG_RequestArenaRankingDefenceTeamUpdate";

        public const string RmiName_CG_RequestPvpSeasonInfo = "CG_RequestPvpSeasonInfo";

        public const string RmiName_CG_RequestPvpSeasonHistory = "CG_RequestPvpSeasonHistory";

        public const string RmiName_CG_RequestCurrentTopRanking = "CG_RequestCurrentTopRanking";

        public const string RmiName_CG_RequestLastTopRanking = "CG_RequestLastTopRanking";

        public const string RmiName_CG_RequestPvpAbuseReport = "CG_RequestPvpAbuseReport";

        public const string RmiName_CG_RequestPvpAllReward = "CG_RequestPvpAllReward";

        public const string RmiName_CG_RequestPvpAllJoin = "CG_RequestPvpAllJoin";

        public const string RmiName_CG_RequestArenaSmashTeamSlotChange = "CG_RequestArenaSmashTeamSlotChange";

        public const string RmiName_CG_RequestArenaSmashDefenceTeamUpdate = "CG_RequestArenaSmashDefenceTeamUpdate";

        public const string RmiName_CG_RequestArenaSmashDefenceTeamFoodBuffUpdate = "CG_RequestArenaSmashDefenceTeamFoodBuffUpdate";

        public const string RmiName_CG_RequestArenaSmashLobbyInfo = "CG_RequestArenaSmashLobbyInfo";

        public const string RmiName_CG_RequestArenaSmashJoin = "CG_RequestArenaSmashJoin";

        public const string RmiName_CG_RequestArenaSmashOpponentList = "CG_RequestArenaSmashOpponentList";

        public const string RmiName_CG_RequestArenaSmashOpponentListReload = "CG_RequestArenaSmashOpponentListReload";

        public const string RmiName_CG_RequestArenaSmashOpponentTeamInfo = "CG_RequestArenaSmashOpponentTeamInfo";

        public const string RmiName_CG_RequestArenaSmashMatchJoin = "CG_RequestArenaSmashMatchJoin";

        public const string RmiName_CG_RequestArenaSmashMatchBattleStart = "CG_RequestArenaSmashMatchBattleStart";

        public const string RmiName_CG_RequestArenaSmashMatchBattleEnd = "CG_RequestArenaSmashMatchBattleEnd";

        public const string RmiName_CG_RequestArenaSmashWinReward = "CG_RequestArenaSmashWinReward";

        public const string RmiName_CG_RequestArenaSmashBestRefresh = "CG_RequestArenaSmashBestRefresh";

        public const string RmiName_CG_RequestArenaSmashBestReward = "CG_RequestArenaSmashBestReward";

        public const string RmiName_CG_RequestArenaSmashRecordList = "CG_RequestArenaSmashRecordList";

        public const string RmiName_CG_RequestArenaSmashOffenseTeamFoodBuffUpdate = "CG_RequestArenaSmashOffenseTeamFoodBuffUpdate";

        public const string RmiName_CG_RequestArenaSmashRankReward = "CG_RequestArenaSmashRankReward";

        public const string RmiName_CG_RequestArenaSmashRankInfo = "CG_RequestArenaSmashRankInfo";

        public const string RmiName_CG_RequestArenaSmashMatchInfo = "CG_RequestArenaSmashMatchInfo";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitLobbyInfo = "CG_RequestArenaRealTimePvpLimitLobbyInfo";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitJoin = "CG_RequestArenaRealTimePvpLimitJoin";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitMatching = "CG_RequestArenaRealTimePvpLimitMatching";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitBattleEnd = "CG_RequestArenaRealTimePvpLimitBattleEnd";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitIngameBattleStart = "CG_RequestArenaRealTimePvpLimitIngameBattleStart";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitTeamChange = "CG_RequestArenaRealTimePvpLimitTeamChange";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitTopRankerList = "CG_RequestArenaRealTimePvpLimitTopRankerList";

        public const string RmiName_CG_RequestArenaRealTimePvpLimitRankReward = "CG_RequestArenaRealTimePvpLimitRankReward";

        public const string RmiName_CG_RequestEventExchangeInfo = "CG_RequestEventExchangeInfo";

        public const string RmiName_CG_RequestEventExchangeBoxGachaInfo = "CG_RequestEventExchangeBoxGachaInfo";

        public const string RmiName_CG_RequestEventExchangeBoxGachaPickup = "CG_RequestEventExchangeBoxGachaPickup";

        public const string RmiName_CG_RequestEventExchangeBoxGachaReset = "CG_RequestEventExchangeBoxGachaReset";

        public const string RmiName_CG_RequestEventPaybackReward = "CG_RequestEventPaybackReward";

        public const string RmiName_CG_RequestEventSnsShareProgress = "CG_RequestEventSnsShareProgress";

        public const string RmiName_CG_RequestEventSnsShareReward = "CG_RequestEventSnsShareReward";

        public const string RmiName_CG_RequestGagueEventInfo = "CG_RequestGagueEventInfo";

        public const string RmiName_CG_RequestGagueEventCharge = "CG_RequestGagueEventCharge";

        public const string RmiName_CG_RequestGagueEventReward = "CG_RequestGagueEventReward";

        public const string RmiName_CG_RequestGagueEventReset = "CG_RequestGagueEventReset";

        public const string RmiName_CG_RequestEventLadderReward = "CG_RequestEventLadderReward";

        public const string RmiName_CG_RequestEventLobbyGiftReward = "CG_RequestEventLobbyGiftReward";

        public const string RmiName_CG_RequestEventTimeMissionInfo = "CG_RequestEventTimeMissionInfo";

        public const string RmiName_CG_RequestEventTimeMissionStart = "CG_RequestEventTimeMissionStart";

        public const string RmiName_CG_RequestEventLobbyDecorationReward = "CG_RequestEventLobbyDecorationReward";

        public const string RmiName_CG_RequestEventPvpWinCountReward = "CG_RequestEventPvpWinCountReward";

        public const string RmiName_CG_RequestEventChapterClearReward = "CG_RequestEventChapterClearReward";

        public const string RmiName_CG_RequestEventBingoInfo = "CG_RequestEventBingoInfo";

        public const string RmiName_CG_RequestEventBingoReset = "CG_RequestEventBingoReset";

        public const string RmiName_CG_RequestEventBingoRandomNumber = "CG_RequestEventBingoRandomNumber";

        public const string RmiName_CG_RequestEventBingoExchangeNumber = "CG_RequestEventBingoExchangeNumber";

        public const string RmiName_CG_RequestEventSkinOneStepEvolution = "CG_RequestEventSkinOneStepEvolution";

        public const string RmiName_CG_RequestEventLuckyBoxInfo = "CG_RequestEventLuckyBoxInfo";

        public const string RmiName_CG_RequestEventLuckyBoxReward = "CG_RequestEventLuckyBoxReward";

        public const string RmiName_CG_RequestRegistPlayTitle = "CG_RequestRegistPlayTitle";

        public const string RmiName_CG_RequestPlayTitleMissionReward = "CG_RequestPlayTitleMissionReward";

        public const string RmiName_CG_RequestPlayTitleInfo = "CG_RequestPlayTitleInfo";

        public const string RmiName_CG_RequestTournamentList = "CG_RequestTournamentList";

        public const string RmiName_CG_RequestTournamentProgressInfo = "CG_RequestTournamentProgressInfo";

        public const string RmiName_CG_RequestTournamentResultInfo = "CG_RequestTournamentResultInfo";

        public const string RmiName_CG_RequestTournamentMatchJoin = "CG_RequestTournamentMatchJoin";

        public const string RmiName_CG_RequestTournamentMatchBattleStart = "CG_RequestTournamentMatchBattleStart";

        public const string RmiName_CG_RequestTournamentMatchBattleEnd = "CG_RequestTournamentMatchBattleEnd";

        public const string RmiName_CG_RequestTournamentMatchExit = "CG_RequestTournamentMatchExit";

        public const string RmiName_CG_RequestTournamentReward = "CG_RequestTournamentReward";

        public const string RmiName_CG_RequestTournamentPlayerTeamSlotChange = "CG_RequestTournamentPlayerTeamSlotChange";

        public const string RmiName_CG_RequestTournamentPlayerTeamInfo = "CG_RequestTournamentPlayerTeamInfo";

        public const string RmiName_CG_RequestTournamentCheer = "CG_RequestTournamentCheer";

        public const string RmiName_CG_RequestTournamentCheerList = "CG_RequestTournamentCheerList";

        public const string RmiName_CG_RequestTournamentWatcherJoin = "CG_RequestTournamentWatcherJoin";

        public const string RmiName_CG_RequestTournamentWatcherExit = "CG_RequestTournamentWatcherExit";

        public const string RmiName_CG_RequestTournamentMatchPlayInfo = "CG_RequestTournamentMatchPlayInfo";

        public const string RmiName_CG_RequestTournamentReplayInfo = "CG_RequestTournamentReplayInfo";

        public const string RmiName_CG_RequestGuildWarLobbyInfo = "CG_RequestGuildWarLobbyInfo";

        public const string RmiName_CG_RequestGuildWarRankInfo = "CG_RequestGuildWarRankInfo";

        public const string RmiName_CG_RequestGuildWarVersusRecordInfo = "CG_RequestGuildWarVersusRecordInfo";

        public const string RmiName_CG_RequestGuildWarGuildMemberList = "CG_RequestGuildWarGuildMemberList";

        public const string RmiName_CG_RequestGuildWarWorldMapInfo = "CG_RequestGuildWarWorldMapInfo";

        public const string RmiName_CG_RequestGuildWarAttackSquadChange = "CG_RequestGuildWarAttackSquadChange";

        public const string RmiName_CG_RequestGuildWarDefenceTeamChange = "CG_RequestGuildWarDefenceTeamChange";

        public const string RmiName_CG_RequestGuildWarRegionBonusScoreChange = "CG_RequestGuildWarRegionBonusScoreChange";

        public const string RmiName_CG_RequestGuildWarAreaGuildMemberChange = "CG_RequestGuildWarAreaGuildMemberChange";

        public const string RmiName_CG_RequestGuildWarBattleRecordInfo = "CG_RequestGuildWarBattleRecordInfo";

        public const string RmiName_CG_Request_GuildWar_Stage_Start = "CG_Request_GuildWar_Stage_Start";

        public const string RmiName_CG_Request_GuildWar_Stage_Clear = "CG_Request_GuildWar_Stage_Clear";

        public const string RmiName_CG_Request_GuildWar_Stage_Rejoin = "CG_Request_GuildWar_Stage_Rejoin";

        public const string RmiName_CG_Request_GuildWar_Stage_HeroStatus_Sync = "CG_Request_GuildWar_Stage_HeroStatus_Sync";

        public const string RmiName_CG_RequestGuildWarBattlePrepareInfo = "CG_RequestGuildWarBattlePrepareInfo";

        public const string RmiName_CG_RequestGuildWarAttackTeamChange = "CG_RequestGuildWarAttackTeamChange";

        public const string RmiName_CG_RequestGuildWarDefenceSlotExpand = "CG_RequestGuildWarDefenceSlotExpand";

        public const string RmiName_CG_RequestGuildWarSquadSlotExpand = "CG_RequestGuildWarSquadSlotExpand";

        public const string RmiName_CG_RequestGuildWarAttackTeamInfo = "CG_RequestGuildWarAttackTeamInfo";

        public const string RmiName_CG_RequestGuildWarDefenceTeamInfo = "CG_RequestGuildWarDefenceTeamInfo";

        public const string RmiName_CG_RequestGuildWarAttackTeamBuffRegist = "CG_RequestGuildWarAttackTeamBuffRegist";

        public const string RmiName_CG_RequestGuildWarDefenceTeamBuffRegist = "CG_RequestGuildWarDefenceTeamBuffRegist";

        public const string RmiName_CG_Request_GuildWar_Stage_Rejoin_Cancel = "CG_Request_GuildWar_Stage_Rejoin_Cancel";

        public const string RmiName_CG_RequestGuildWarDefenceTeamInfoAll = "CG_RequestGuildWarDefenceTeamInfoAll";

        public const string RmiName_CG_RequestGuildWarRankInfoAll = "CG_RequestGuildWarRankInfoAll";

        public const string RmiName_CG_RequestGuildWarDefenceTeamSave = "CG_RequestGuildWarDefenceTeamSave";

        public const string RmiName_CG_RequestGuildWarMagicAreaRegist = "CG_RequestGuildWarMagicAreaRegist";

        public const string RmiName_CG_RequestGuildWarDefenceTeamSaveAll = "CG_RequestGuildWarDefenceTeamSaveAll";

        public const string RmiName_CG_RequestGuildWarLowerLobbyInfo = "CG_RequestGuildWarLowerLobbyInfo";

        public const string RmiName_CG_RequestGuildWarCostumeReward = "CG_RequestGuildWarCostumeReward";

        public const string RmiName_CG_RequestGuildWarRegionAttackPriorityChange = "CG_RequestGuildWarRegionAttackPriorityChange";

        public const string RmiName_CG_RequestGuildWarBattleSettingChange = "CG_RequestGuildWarBattleSettingChange";

        public const string RmiName_CG_RequestGuildWarBattleSettingChangeInfo = "CG_RequestGuildWarBattleSettingChangeInfo";

        public const string RmiName_CG_RequestGuildWarNonSeasonBattlePrepareInfo = "CG_RequestGuildWarNonSeasonBattlePrepareInfo";

        public const string RmiName_CG_RequestGuildWarNonSeasonDefenceTeamChange = "CG_RequestGuildWarNonSeasonDefenceTeamChange";

        public const string RmiName_CG_RequestGuildWarNonSeasonDefenceTeamSaveAll = "CG_RequestGuildWarNonSeasonDefenceTeamSaveAll";

        public const string RmiName_CG_RequestGuildWarNonSeasonAttackSquadChange = "CG_RequestGuildWarNonSeasonAttackSquadChange";

        public const string RmiName_CG_RequestGuildWarUserInfo = "CG_RequestGuildWarUserInfo";

        public const string RmiName_CG_RequestGuildWarRecommandDefenceTeamInfo = "CG_RequestGuildWarRecommandDefenceTeamInfo";

        public const string RmiName_CG_RequestGuildWarRecommandDefenceTeamRegist = "CG_RequestGuildWarRecommandDefenceTeamRegist";

        public const string RmiName_CG_RequestSubdueCreate = "CG_RequestSubdueCreate";

        public const string RmiName_CG_RequestSubdueJoin = "CG_RequestSubdueJoin";

        public const string RmiName_CG_RequestSubdueOwnerGameStart = "CG_RequestSubdueOwnerGameStart";

        public const string RmiName_CG_RequestSubdueLoadingComplete = "CG_RequestSubdueLoadingComplete";

        public const string RmiName_CG_RequestSubdueOnlineFriendList = "CG_RequestSubdueOnlineFriendList";

        public const string RmiName_CG_RequestSubdueOnlineGuildMemberList = "CG_RequestSubdueOnlineGuildMemberList";

        public const string RmiName_CG_RequestSubdueOnlineUserRankRangeList = "CG_RequestSubdueOnlineUserRankRangeList";

        public const string RmiName_CG_RequestSubdueInvitationReceiveList = "CG_RequestSubdueInvitationReceiveList";

        public const string RmiName_CG_RequestSubdueRemoveInvitation = "CG_RequestSubdueRemoveInvitation";

        public const string RmiName_CG_RequestSubdueInvite = "CG_RequestSubdueInvite";

        public const string RmiName_CG_RequestSubdueReward = "CG_RequestSubdueReward";

        public const string RmiName_CG_RequestPatrolMissionInfo = "CG_RequestPatrolMissionInfo";

        public const string RmiName_CG_RequestPatrolMissionStart = "CG_RequestPatrolMissionStart";

        public const string RmiName_CG_RequestPatrolMissionCancel = "CG_RequestPatrolMissionCancel";

        public const string RmiName_CG_RequestPatrolMissionReward = "CG_RequestPatrolMissionReward";

        public const string RmiName_CG_RequestPatrolMissionTimeReward = "CG_RequestPatrolMissionTimeReward";

        public const string RmiName_CG_Request_Free_Stage_ClearTicket = "CG_Request_Free_Stage_ClearTicket";

        public const string RmiName_CG_Request_Week_Stage_ClearTicket = "CG_Request_Week_Stage_ClearTicket";

        public const string RmiName_CG_Request_Boss_Stage_ClearTicket = "CG_Request_Boss_Stage_ClearTicket";

        public const string RmiName_CG_Request_Week_EventStage_ClearTicket = "CG_Request_Week_EventStage_ClearTicket";

        public const string RmiName_CG_Request_DisasterBoss_Stage_ClearTicket = "CG_Request_DisasterBoss_Stage_ClearTicket";

        public const string RmiName_CG_Request_Free_EventAreaStage_ClearTicket = "CG_Request_Free_EventAreaStage_ClearTicket";

        public const string RmiName_CG_Request_Yggdrasil_Tower_Stage_ClearTicket = "CG_Request_Yggdrasil_Tower_Stage_ClearTicket";

        public const string RmiName_CG_Request_Training_Stage_ClearTicket = "CG_Request_Training_Stage_ClearTicket";

        public const string RmiName_CG_RequestEventExchangeCardInfo = "CG_RequestEventExchangeCardInfo";

        public const string RmiName_CG_RequestEventExchangeCardSetup = "CG_RequestEventExchangeCardSetup";

        public const string RmiName_CG_RequestEventExchangeCardChoiceManual = "CG_RequestEventExchangeCardChoiceManual";

        public const string RmiName_CG_RequestEventExchangeCardChoiceAuto = "CG_RequestEventExchangeCardChoiceAuto";

        public const string RmiName_CG_RequestEventExchangeCardReset = "CG_RequestEventExchangeCardReset";

        public const string RmiName_CG_RequestEventCraftExchange = "CG_RequestEventCraftExchange";

        public const string RmiName_CG_RequestEventProvisionProvide = "CG_RequestEventProvisionProvide";

        public const string RmiName_CG_RequestEventProvisionGetFinalReward = "CG_RequestEventProvisionGetFinalReward";

        public const string RmiName_CG_RequestEventExchangeKingAmber = "CG_RequestEventExchangeKingAmber";

        public const string RmiName_CG_RequestEventTreasureHuntInfo = "CG_RequestEventTreasureHuntInfo";

        public const string RmiName_CG_RequestEventTreasureHuntStart = "CG_RequestEventTreasureHuntStart";

        public const string RmiName_CG_RequestEventTreasureHuntMoveDice = "CG_RequestEventTreasureHuntMoveDice";

        public const string RmiName_CG_RequestEventTreasureHuntMoveChoosePoint = "CG_RequestEventTreasureHuntMoveChoosePoint";

        public const string RmiName_CG_RequestEventTreasureHuntChooseReward = "CG_RequestEventTreasureHuntChooseReward";

        public const string RmiName_CG_RequestEventTreasureHuntComplete = "CG_RequestEventTreasureHuntComplete";

        public const string RmiName_CG_RequestEventTreasureHuntCompleteReward = "CG_RequestEventTreasureHuntCompleteReward";

        public const string RmiName_CG_RequestEventTreasureHuntMission = "CG_RequestEventTreasureHuntMission";

        public const string RmiName_CG_RequestEventKOFBritanniaInfo = "CG_RequestEventKOFBritanniaInfo";

        public const string RmiName_CG_RequestEventKOFBritanniaStart = "CG_RequestEventKOFBritanniaStart";

        public const string RmiName_CG_RequestEventKOFBritanniaTeamSelect = "CG_RequestEventKOFBritanniaTeamSelect";

        public const string RmiName_CG_RequestEventKOFBritanniaTeamChange = "CG_RequestEventKOFBritanniaTeamChange";

        public const string RmiName_CG_RequestEventKOFBritanniaStageStart = "CG_RequestEventKOFBritanniaStageStart";

        public const string RmiName_CG_RequestEventKOFBritanniaStageClear = "CG_RequestEventKOFBritanniaStageClear";

        public const string RmiName_CG_RequestEventKOFBritanniaStageContinue = "CG_RequestEventKOFBritanniaStageContinue";

        public const string RmiName_CG_RequestEventKOFBritanniaRestart = "CG_RequestEventKOFBritanniaRestart";

        public const string RmiName_CG_RequestEventKOFBritanniaStageRejoinCancel = "CG_RequestEventKOFBritanniaStageRejoinCancel";

        public const string RmiName_CG_RequestEventGamblePaybackReward = "CG_RequestEventGamblePaybackReward";

        public const string RmiName_CG_RequestNMFunTalkKitLogin = "CG_RequestNMFunTalkKitLogin";

        public const string RmiName_CG_RequestNMFunTalkKitCreateRoom = "CG_RequestNMFunTalkKitCreateRoom";

        public const string RmiName_CG_Request_GuildBoss_User_Rank_Info = "CG_Request_GuildBoss_User_Rank_Info";

        public const string RmiName_CG_Request_GuildBoss_User_Rank_Info_Range = "CG_Request_GuildBoss_User_Rank_Info_Range";

        public const string RmiName_CG_RequestEventRandomBoxInfo = "CG_RequestEventRandomBoxInfo";

        public const string RmiName_CG_RequestEventRandomBoxCreate = "CG_RequestEventRandomBoxCreate";

        public const string RmiName_CG_RequestEventRandomBoxReward = "CG_RequestEventRandomBoxReward";

        public const string RmiName_CG_RequestFinalBossVowUpdate = "CG_RequestFinalBossVowUpdate";

        public const string RmiName_CG_RequestSeasonpassShopInfo = "CG_RequestSeasonpassShopInfo";

        public const string RmiName_CG_RequestSeasonpassShopBuy = "CG_RequestSeasonpassShopBuy";

        public const string RmiName_CG_Request_EventPredict_User_Info = "CG_Request_EventPredict_User_Info";

        public const string RmiName_CG_Request_EventPredict_Start = "CG_Request_EventPredict_Start";

        public const string RmiName_CG_Request_EventPredict_Special_Reward = "CG_Request_EventPredict_Special_Reward";

        public const string RmiName_CG_RequestGuildWarLowLobbyInfo = "CG_RequestGuildWarLowLobbyInfo";

        public const string RmiName_CG_RequestGuildWarLowApply = "CG_RequestGuildWarLowApply";

        public const string RmiName_CG_RequestGuildWarLowAttackTeamChange = "CG_RequestGuildWarLowAttackTeamChange";

        public const string RmiName_CG_RequestGuildWarLowDefenceTeamChange = "CG_RequestGuildWarLowDefenceTeamChange";

        public const string RmiName_CG_RequestGuildWarLowAreaDeployGuildMember = "CG_RequestGuildWarLowAreaDeployGuildMember";

        public const string RmiName_CG_RequestGuildWarLowAreaInfo = "CG_RequestGuildWarLowAreaInfo";

        public const string RmiName_CG_RequestGuildWarLowStageStart = "CG_RequestGuildWarLowStageStart";

        public const string RmiName_CG_RequestGuildWarLowStageClear = "CG_RequestGuildWarLowStageClear";

        public const string RmiName_CG_RequestGuildWarLowStageRejoin = "CG_RequestGuildWarLowStageRejoin";

        public const string RmiName_CG_RequestGuildWarLowStageRejoinCancel = "CG_RequestGuildWarLowStageRejoinCancel";

        public const string RmiName_CG_RequestGuildWarLowStageSync = "CG_RequestGuildWarLowStageSync";

        public const string RmiName_CG_RequestGuildWarLowDefenceTeamSaveAll = "CG_RequestGuildWarLowDefenceTeamSaveAll";

        public const string RmiName_CG_RequestGuildWarLowBattleRecordInfo = "CG_RequestGuildWarLowBattleRecordInfo";

        public const string RmiName_CG_RequestGuildWarLowMemberList = "CG_RequestGuildWarLowMemberList";

        public const string RmiName_CG_RequestGuildWarLowDefenceTeamInfo = "CG_RequestGuildWarLowDefenceTeamInfo";

        public const string RmiName_CG_RequestGuildWarLowAreaInfoList = "CG_RequestGuildWarLowAreaInfoList";

        public const string RmiName_CG_RequestGuildWarLowRecordInfo = "CG_RequestGuildWarLowRecordInfo";

        public const string RmiName_CG_Request_EventAuto_On = "CG_Request_EventAuto_On";

        public const string RmiName_CG_Request_EventAuto_Result = "CG_Request_EventAuto_Result";

        public const string RmiName_CG_Request_EventAuto_Battle_End = "CG_Request_EventAuto_Battle_End";

        public const string RmiName_CG_Request_EventAuto_HawkUpgrade = "CG_Request_EventAuto_HawkUpgrade";

        public const string RmiName_CG_Request_EventAuto_Reward = "CG_Request_EventAuto_Reward";

        public const string RmiName_CG_Request_EventAuto_Box_Slot_Upgrade = "CG_Request_EventAuto_Box_Slot_Upgrade";

        public const string RmiName_CG_Request_EventAuto_SpecialReward = "CG_Request_EventAuto_SpecialReward";

        public const string RmiName_CG_RequestYggdrasilTowerStageStart = "CG_RequestYggdrasilTowerStageStart";

        public const string RmiName_CG_RequestYggdrasilTowerStageClear = "CG_RequestYggdrasilTowerStageClear";

        public const string RmiName_CG_RequestYggdrasilTowerShopInfo = "CG_RequestYggdrasilTowerShopInfo";

        public const string RmiName_CG_RequestYggdrasilTowerShopBuy = "CG_RequestYggdrasilTowerShopBuy";

        public const string RmiName_CG_Request_Yggdrasil_Tower_Stage_Continue = "CG_Request_Yggdrasil_Tower_Stage_Continue";

        public const string RmiName_CG_RequestArtifactCardPackOpen = "CG_RequestArtifactCardPackOpen";

        public const string RmiName_CG_RequestArtifactUnionUpgrade = "CG_RequestArtifactUnionUpgrade";

        public const string RmiName_CG_RequestArtifactTeamChange = "CG_RequestArtifactTeamChange";

        public const string RmiName_CG_RequestArtifactDescentBossTeamChange = "CG_RequestArtifactDescentBossTeamChange";

        public const string RmiName_CG_RequestArtifactTeamInfoAll = "CG_RequestArtifactTeamInfoAll";

        public const string RmiName_CG_RequestArtifactDemonLordTeamChange = "CG_RequestArtifactDemonLordTeamChange";

        public const string RmiName_CG_RequestEventArtifactWishSave = "CG_RequestEventArtifactWishSave";

        public const string RmiName_CG_RequestEventArtifactWishCardPackOpen = "CG_RequestEventArtifactWishCardPackOpen";

        public const string RmiName_CG_RequestNorthGrimBookReward = "CG_RequestNorthGrimBookReward";

        public const string RmiName_CG_Request_CreatureNest_Season_Info = "CG_Request_CreatureNest_Season_Info";

        public const string RmiName_CG_Request_CreatureNest_Stage_Start = "CG_Request_CreatureNest_Stage_Start";

        public const string RmiName_CG_Request_CreatureNest_Stage_Clear = "CG_Request_CreatureNest_Stage_Clear";

        public const string RmiName_CG_Request_CreatureNest_Stage_Continue = "CG_Request_CreatureNest_Stage_Continue";

        public const string RmiName_CG_Request_CreatureNest_Init = "CG_Request_CreatureNest_Init";

        public const string RmiName_CG_Request_CreatureNest_Team_Save = "CG_Request_CreatureNest_Team_Save";

        public const string RmiName_CG_Request_CreatureNest_Stage_Rejoin = "CG_Request_CreatureNest_Stage_Rejoin";

        public const string RmiName_CG_Request_CreatureNest_Stage_Rejoin_Cancel = "CG_Request_CreatureNest_Stage_Rejoin_Cancel";

        public const string RmiName_CG_Request_CreatureNest_Use_Reset_Item = "CG_Request_CreatureNest_Use_Reset_Item";

        public const string RmiName_CG_Request_CreatureNest_Challenge_Reward = "CG_Request_CreatureNest_Challenge_Reward";

        public const string RmiName_CG_Request_CreatureNest_Select_Group = "CG_Request_CreatureNest_Select_Group";

        public const string RmiName_CG_RequestEventCheerGroup = "CG_RequestEventCheerGroup";

        public const string RmiName_CG_RequestEventCheerGaugeReward = "CG_RequestEventCheerGaugeReward";

        public const string RmiName_CG_RequestEventCheerFinishReward = "CG_RequestEventCheerFinishReward";

        public const string RmiName_CG_RequestEventDiceInfo = "CG_RequestEventDiceInfo";

        public const string RmiName_CG_RequestEventDiceRoll = "CG_RequestEventDiceRoll";

        public const string RmiName_CG_RequestEventDiceRollEventHandle = "CG_RequestEventDiceRollEventHandle";

        public const string RmiName_CG_RequestEventDiceRaceReward = "CG_RequestEventDiceRaceReward";

        public const string RmiName_CG_RequestConstellationStoneOpen = "CG_RequestConstellationStoneOpen";

        public const string RmiName_CG_RequestConstellationStoneOptionValueChange = "CG_RequestConstellationStoneOptionValueChange";

        public const string RmiName_CG_RequestConstellationStoneOptionValueChangeApply = "CG_RequestConstellationStoneOptionValueChangeApply";

        public const string RmiName_CG_RequestConstellationStoneLock = "CG_RequestConstellationStoneLock";

        public const string RmiName_CG_RequestMaterialFusion = "CG_RequestMaterialFusion";

        public const string RmiName_CG_RequestEventPuzzleInfo = "CG_RequestEventPuzzleInfo";

        public const string RmiName_CG_RequestEventPuzzleInfoStart = "CG_RequestEventPuzzleInfoStart";

        public const string RmiName_CG_RequestEventPuzzleInfoEnd = "CG_RequestEventPuzzleInfoEnd";

        public const string RmiName_CG_RequestEventPuzzleInfoBlockReward = "CG_RequestEventPuzzleInfoBlockReward";

        public const string RmiName_CG_RequestEventPuzzleInfoTotalReward = "CG_RequestEventPuzzleInfoTotalReward";

        public const string RmiName_CG_RequestRandomLuckybagInfo = "CG_RequestRandomLuckybagInfo";

        public const string RmiName_CG_RequestRandomLuckybagOpen = "CG_RequestRandomLuckybagOpen";

        public const string RmiName_CG_RequestRandomLuckybagLastReward = "CG_RequestRandomLuckybagLastReward";

        public const string RmiName_CG_RequestAncientWarInfo = "CG_RequestAncientWarInfo";

        public const string RmiName_CG_RequestAncientWarRefresh = "CG_RequestAncientWarRefresh";

        public const string RmiName_CG_RequestAncientWarTeamSelect = "CG_RequestAncientWarTeamSelect";

        public const string RmiName_CG_RequestAncientWarStageStart = "CG_RequestAncientWarStageStart";

        public const string RmiName_CG_RequestAncientWarStageClear = "CG_RequestAncientWarStageClear";

        public const string RmiName_CG_RequestAncientWarExtraStageStart = "CG_RequestAncientWarExtraStageStart";

        public const string RmiName_CG_RequestAncientWarExtraStageClear = "CG_RequestAncientWarExtraStageClear";

        public const string RmiName_CG_RequestAncientWarReward = "CG_RequestAncientWarReward";

        public const string RmiName_CG_RequestAncientWarDonation = "CG_RequestAncientWarDonation";

        public const string RmiName_CG_RequestAncientWarRankInfo = "CG_RequestAncientWarRankInfo";

        public const string RmiName_CG_RequestEventStepupMissionStart = "CG_RequestEventStepupMissionStart";

        public const string RmiName_CG_RequestEventStepupMissionGroupClear = "CG_RequestEventStepupMissionGroupClear";

        public const string RmiName_CG_RequestEventGambleWishSave = "CG_RequestEventGambleWishSave";

        public const string RmiName_CG_RequestEventMazeInfo = "CG_RequestEventMazeInfo";

        public const string RmiName_CG_RequestEventMazeStart = "CG_RequestEventMazeStart";

        public const string RmiName_CG_RequestEventMazeSelectStartHeroes = "CG_RequestEventMazeSelectStartHeroes";

        public const string RmiName_CG_RequestEventMazeInitialize = "CG_RequestEventMazeInitialize";

        public const string RmiName_CG_RequestEventMazeMove = "CG_RequestEventMazeMove";

        public const string RmiName_CG_RequestEventMazePassiveSelect = "CG_RequestEventMazePassiveSelect";

        public const string RmiName_CG_RequestEventMazeSeasonReward = "CG_RequestEventMazeSeasonReward";

        public const string RmiName_CG_RequestEventMazeChangeSlot = "CG_RequestEventMazeChangeSlot";

        public const string RmiName_CG_RequestEventMazeRefreshSelectableHeroes = "CG_RequestEventMazeRefreshSelectableHeroes";

        public const string RmiName_CG_RequestEventMazeShopBuy = "CG_RequestEventMazeShopBuy";

        public const string RmiName_CG_RequestEventMazeRefreshSelectablePassives = "CG_RequestEventMazeRefreshSelectablePassives";

        public const string RmiName_CG_RequestEventMazeSaveTeam = "CG_RequestEventMazeSaveTeam";

        public const string RmiName_CG_RequestEventMazeSelectClearBonus = "CG_RequestEventMazeSelectClearBonus";

        public const string RmiName_CG_RequestEventMazeSeasonShopInfo = "CG_RequestEventMazeSeasonShopInfo";

        public const string RmiName_CG_RequestEventMazeSeasonShopBuy = "CG_RequestEventMazeSeasonShopBuy";

        public const string RmiName_CG_RequestEventMazeStartSavedTeam = "CG_RequestEventMazeStartSavedTeam";

        public const string RmiName_CG_RequestEventMazeShopBuffBuy = "CG_RequestEventMazeShopBuffBuy";

        public const string RmiName_CG_RequestEventMoleGameInfo = "CG_RequestEventMoleGameInfo";

        public const string RmiName_CG_RequestEventMoleGameStart = "CG_RequestEventMoleGameStart";

        public const string RmiName_CG_RequestEventMoleGameEnd = "CG_RequestEventMoleGameEnd";

        public const string RmiName_CG_RequestEventMoleGameRecordReward = "CG_RequestEventMoleGameRecordReward";

        public const string RmiName_CG_RequestEventMoleGameTotalReward = "CG_RequestEventMoleGameTotalReward";

        public const string RmiName_CG_RequestEventMoleGameRankInfo = "CG_RequestEventMoleGameRankInfo";

        public const string RmiName_CG_RequestEventConfirmGameInfo = "CG_RequestEventConfirmGameInfo";

        public const string RmiName_CG_RequestEventConfirmGameStart = "CG_RequestEventConfirmGameStart";

        public const string RmiName_CG_RequestEventConfirmGameEnd = "CG_RequestEventConfirmGameEnd";

        public const string RmiName_CG_RequestEventConfirmGameRecordReward = "CG_RequestEventConfirmGameRecordReward";

        public const string RmiName_CG_RequestEventConfirmGameTotalReward = "CG_RequestEventConfirmGameTotalReward";

        public const string RmiName_CG_RequestEventLobbyBuffInfo = "CG_RequestEventLobbyBuffInfo";

        public const string RmiName_CG_RequestEventLobbyBuffBuy = "CG_RequestEventLobbyBuffBuy";

        public const string RmiName_CG_RequestEventBoxWishInfo = "CG_RequestEventBoxWishInfo";

        public const string RmiName_CG_RequestEventBoxWishSet = "CG_RequestEventBoxWishSet";

        public const string RmiName_CG_RequestEventBoxWishPickUp = "CG_RequestEventBoxWishPickUp";

        public const string RmiName_CG_RequestEventBoxWishReset = "CG_RequestEventBoxWishReset";

        public const string RmiName_CG_RequestEventRoadInfo = "CG_RequestEventRoadInfo";

        public const string RmiName_CG_RequestEventRoadWalk = "CG_RequestEventRoadWalk";

        public const string RmiName_CG_RequestEventRoadReward = "CG_RequestEventRoadReward";

        public const string RmiName_CG_RequestEventRoadSelect = "CG_RequestEventRoadSelect";

        public const string RmiName_CG_RequestEventGambleBoxInfo = "CG_RequestEventGambleBoxInfo";

        public const string RmiName_CG_RequestEventGambleBoxPickup = "CG_RequestEventGambleBoxPickup";

        public const string RmiName_CG_RequestEventGambleBoxReset = "CG_RequestEventGambleBoxReset";

        public const string RmiName_CG_RequestEventConquestInfo = "CG_RequestEventConquestInfo";

        public const string RmiName_CG_RequestEventConquestProductionDepotCompleteReward = "CG_RequestEventConquestProductionDepotCompleteReward";

        public const string RmiName_CG_RequestEventConquestProductionDepotUpgrade = "CG_RequestEventConquestProductionDepotUpgrade";

        public const string RmiName_CG_RequestEventConquestProductionDepotUpgradeReward = "CG_RequestEventConquestProductionDepotUpgradeReward";

        public const string RmiName_CG_RequestEventConquestAreaAttack = "CG_RequestEventConquestAreaAttack";

        public const string RmiName_CG_RequestEventConquestAreaFeverAttack = "CG_RequestEventConquestAreaFeverAttack";

        public const string RmiName_CG_RequestEventConquestAreaAttackReward = "CG_RequestEventConquestAreaAttackReward";

        public const string RmiName_CG_RequestEventConquestMakeFeverItem = "CG_RequestEventConquestMakeFeverItem";

        public const string RmiName_CG_RequestEventConquestUpdateSceneIndex = "CG_RequestEventConquestUpdateSceneIndex";

        public const string RmiName_CG_RequestEventConquestUpdateUnitPos = "CG_RequestEventConquestUpdateUnitPos";

        public const string RmiName_CG_RequestGuildOrderMissioInfo = "CG_RequestGuildOrderMissioInfo";

        public const string RmiName_CG_RequestGuildOrderMissionClear = "CG_RequestGuildOrderMissionClear";

        public const string RmiName_CG_RequestGuildOrderAPRewardBox = "CG_RequestGuildOrderAPRewardBox";

        public const string RmiName_CG_RequestGuildOrderMissionMileageBonusReward = "CG_RequestGuildOrderMissionMileageBonusReward";

        public const string RmiName_CG_RequestHeroLeagueInfo = "CG_RequestHeroLeagueInfo";

        public const string RmiName_CG_RequestHeroLeagueSelectLeague = "CG_RequestHeroLeagueSelectLeague";

        public const string RmiName_CG_RequestHeroLeagueInitialize = "CG_RequestHeroLeagueInitialize";

        public const string RmiName_CG_RequestHeroLeagueInitUserGroup = "CG_RequestHeroLeagueInitUserGroup";

        public const string RmiName_CG_RequestHeroLeagueGagueReward = "CG_RequestHeroLeagueGagueReward";

        public const string RmiName_CG_RequestHeroLeagueAttackTeamChange = "CG_RequestHeroLeagueAttackTeamChange";

        public const string RmiName_CG_RequestHeroLeagueStageStart = "CG_RequestHeroLeagueStageStart";

        public const string RmiName_CG_RequestHeroLeagueStageClear = "CG_RequestHeroLeagueStageClear";

        public const string RmiName_CG_RequestHeroLeagueSeasonShopInfo = "CG_RequestHeroLeagueSeasonShopInfo";

        public const string RmiName_CG_RequestHeroLeagueSeasonShopBuy = "CG_RequestHeroLeagueSeasonShopBuy";

        public const string RmiName_CG_RequestHeroLeagueStageRejoin = "CG_RequestHeroLeagueStageRejoin";

        public const string RmiName_CG_RequestHeroLeagueStageRejoinCancel = "CG_RequestHeroLeagueStageRejoinCancel";

        public const string RmiName_CG_RequestHeroLeagueScoreReward = "CG_RequestHeroLeagueScoreReward";

        public const string RmiName_CG_Request_CreatureColosseum_Season_Info = "CG_Request_CreatureColosseum_Season_Info";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_Start = "CG_Request_CreatureColosseum_Stage_Start";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_Clear = "CG_Request_CreatureColosseum_Stage_Clear";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_Continue = "CG_Request_CreatureColosseum_Stage_Continue";

        public const string RmiName_CG_Request_CreatureColosseum_Init = "CG_Request_CreatureColosseum_Init";

        public const string RmiName_CG_Request_CreatureColosseum_Team_Save = "CG_Request_CreatureColosseum_Team_Save";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_Rejoin = "CG_Request_CreatureColosseum_Stage_Rejoin";

        public const string RmiName_CG_Request_CreatureColosseum_Stage_Rejoin_Cancel = "CG_Request_CreatureColosseum_Stage_Rejoin_Cancel";

        public const string RmiName_CG_RequestCreatureColosseumShopInfo = "CG_RequestCreatureColosseumShopInfo";

        public const string RmiName_CG_RequestCreatureColosseumShopBuy = "CG_RequestCreatureColosseumShopBuy";

        public const string RmiName_CG_RequestEventBalloonDartInfo = "CG_RequestEventBalloonDartInfo";

        public const string RmiName_CG_RequestEventBalloonDartThrow = "CG_RequestEventBalloonDartThrow";

        public const string RmiName_CG_RequestEventBalloonDartChance = "CG_RequestEventBalloonDartChance";

        public const string RmiName_CG_RequestEventBalloonDartStepUp = "CG_RequestEventBalloonDartStepUp";

        public const string RmiName_CG_RequestEventBalloonDartStepReward = "CG_RequestEventBalloonDartStepReward";

        public const string RmiName_CG_RequestEventBalloonDartTotalReward = "CG_RequestEventBalloonDartTotalReward";

        public const string RmiName_CG_RequestDemonLordStageOpen = "CG_RequestDemonLordStageOpen";

        public const string RmiName_CG_RequestDemonLordStageStart = "CG_RequestDemonLordStageStart";

        public const string RmiName_CG_RequestDemonLordStageClear = "CG_RequestDemonLordStageClear";

        public const string RmiName_CG_RequestDemonLordStageContinue = "CG_RequestDemonLordStageContinue";

        public const string RmiName_CG_RequestDemonLordStageCoinOpen = "CG_RequestDemonLordStageCoinOpen";

        public const string RmiName_CG_RequestChat = "CG_RequestChat";

        public const string RmiName_CG_RequestChatChannelEnter = "CG_RequestChatChannelEnter";

        public const string RmiName_First = "CG_RequestChannelUserInfo";
    }
}
