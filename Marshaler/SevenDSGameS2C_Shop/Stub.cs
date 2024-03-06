using Nettention.Proud;

namespace SevenDSGameS2C_Shop
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
                    case Common.CG_RequestItemInventoryBuyOK:
                        this.ProcessReceivedMessage_CG_RequestItemInventoryBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponInventoryBuyOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponInventoryBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeekStageKeyBuyOK:
                        this.ProcessReceivedMessage_CG_RequestWeekStageKeyBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDiaShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestDiaShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDiaShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestDiaShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGambleShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestGambleShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestItemGambleShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestItemGambleShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestItemGambleShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestItemGambleShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestRandomShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestRandomShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestRandomShopRefreshOK:
                        this.ProcessReceivedMessage_CG_RequestRandomShopRefreshOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestRandomShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestRandomShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBasePointShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestBasePointShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBasePointShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestBasePointShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBasePointShopResetOK:
                        this.ProcessReceivedMessage_CG_RequestBasePointShopResetOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaRealTimePvpShopResetOK:
                        this.ProcessReceivedMessage_CG_RequestArenaRealTimePvpShopResetOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCoinShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestCoinShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCoinShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestCoinShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCostumeShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestCostumeShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCostumeShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestCostumeShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCommonItemSellOK:
                        this.ProcessReceivedMessage_CG_RequestCommonItemSellOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCommonItemRemoveOK:
                        this.ProcessReceivedMessage_CG_RequestCommonItemRemoveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPackageShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestPackageShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGambleShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestGambleShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestADRouletteRewardOK:
                        this.ProcessReceivedMessage_CG_RequestADRouletteRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGambleGaugeRewardOK:
                        this.ProcessReceivedMessage_CG_RequestGambleGaugeRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashShopRewardOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashShopRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestArenaSmashShopResetOK:
                        this.ProcessReceivedMessage_CG_RequestArenaSmashShopResetOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEvolutionExchangeOK:
                        this.ProcessReceivedMessage_CG_RequestEvolutionExchangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestRandomShopVisitRewardOK:
                        this.ProcessReceivedMessage_CG_RequestRandomShopVisitRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestRandomShopScheduleInfoOK:
                        this.ProcessReceivedMessage_CG_RequestRandomShopScheduleInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPackageBuyOK:
                        this.ProcessReceivedMessage_CG_RequestPackageBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBuyDiaOK:
                        this.ProcessReceivedMessage_CG_RequestBuyDiaOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBuyGoldOK:
                        this.ProcessReceivedMessage_CG_RequestBuyGoldOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBuyStaminaOK:
                        this.ProcessReceivedMessage_CG_RequestBuyStaminaOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCostumeShopPackageBuyOK:
                        this.ProcessReceivedMessage_CG_RequestCostumeShopPackageBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestFinalBossShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestFinalBossShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestFinalBossShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestFinalBossShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBingoGambleShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestBingoGambleShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBingoGambleShopResetOK:
                        this.ProcessReceivedMessage_CG_RequestBingoGambleShopResetOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestBingoGambleShopRewardOK:
                        this.ProcessReceivedMessage_CG_RequestBingoGambleShopRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestDiaShopPackageBuyOK:
                        this.ProcessReceivedMessage_CG_RequestDiaShopPackageBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestGambleChoiceShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestGambleChoiceShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestFreePackageRewardOK:
                        this.ProcessReceivedMessage_CG_RequestFreePackageRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestPackageMissionCloseOK:
                        this.ProcessReceivedMessage_CG_RequestPackageMissionCloseOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestStepupGambleShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestStepupGambleShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestStepupGambleMileageRewardOK:
                        this.ProcessReceivedMessage_CG_RequestStepupGambleMileageRewardOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestLobbyHousingShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestLobbyHousingShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestLobbyHousingShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestLobbyHousingShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestYggdrasilTowerShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestYggdrasilTowerShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestYggdrasilTowerShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestYggdrasilTowerShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventCoinShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestEventCoinShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeSeasonShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeSeasonShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestEventMazeSeasonShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestEventMazeSeasonShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestHeroLeagueSeasonShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestHeroLeagueSeasonShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestHeroLeagueSeasonShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestHeroLeagueSeasonShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCreatureColosseumShopInfoOK:
                        this.ProcessReceivedMessage_CG_RequestCreatureColosseumShopInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestCreatureColosseumShopBuyOK:
                        this.ProcessReceivedMessage_CG_RequestCreatureColosseumShopBuyOK(readOnlyMessage, pa, hostTag, remoteHostID);
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

        private void ProcessReceivedMessage_CG_RequestItemInventoryBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            short maxItemInventoryCount;
            CommonPacket.Marshaler.Read(__msg, out maxItemInventoryCount);
            List<ItemResultInfo> useItemResultinfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultinfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestItemInventoryBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestItemInventoryBuyOK,
                    rmiName = RmiName_CG_RequestItemInventoryBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestItemInventoryBuyOK(remote, rmiContext, maxItemInventoryCount, useItemResultinfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestItemInventoryBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestItemInventoryBuyOK,
                    rmiName = RmiName_CG_RequestItemInventoryBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponInventoryBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            short maxWeaponInventoryCount;
            CommonPacket.Marshaler.Read(__msg, out maxWeaponInventoryCount);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponInventoryBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponInventoryBuyOK,
                    rmiName = RmiName_CG_RequestWeaponInventoryBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponInventoryBuyOK(remote, rmiContext, maxWeaponInventoryCount, useItemResultInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponInventoryBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponInventoryBuyOK,
                    rmiName = RmiName_CG_RequestWeaponInventoryBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeekStageKeyBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> useDiaItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useDiaItemResultInfoList);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeekStageKeyBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageKeyBuyOK,
                    rmiName = RmiName_CG_RequestWeekStageKeyBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeekStageKeyBuyOK(remote, rmiContext, useDiaItemResultInfoList, getItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeekStageKeyBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeekStageKeyBuyOK,
                    rmiName = RmiName_CG_RequestWeekStageKeyBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDiaShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<UserPackageInfo> userPackageInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDiaShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDiaShopInfoOK,
                    rmiName = RmiName_CG_RequestDiaShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDiaShopInfoOK(remote, rmiContext, shopBuyInfoList, userPackageInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDiaShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDiaShopInfoOK,
                    rmiName = RmiName_CG_RequestDiaShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDiaShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int productID;
            CommonPacket.Marshaler.Read(__msg, out productID);
            ApRewardInfo apUpdateInfo;
            CommonPacket.Marshaler.Read(__msg, out apUpdateInfo);
            ApRewardInfo apBonusInfo;
            CommonPacket.Marshaler.Read(__msg, out apBonusInfo);
            int addUserExp;
            CommonPacket.Marshaler.Read(__msg, out addUserExp);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            byte buyCount;
            CommonPacket.Marshaler.Read(__msg, out buyCount);
            byte getBonusCount;
            CommonPacket.Marshaler.Read(__msg, out getBonusCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDiaShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDiaShopBuyOK,
                    rmiName = RmiName_CG_RequestDiaShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDiaShopBuyOK(remote, rmiContext, productID, apUpdateInfo, apBonusInfo, addUserExp, missionResult, useItemResultInfoList, getItemResultInfoList, buyCount, getBonusCount, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDiaShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDiaShopBuyOK,
                    rmiName = RmiName_CG_RequestDiaShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGambleShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> priceItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceItemResultInfoList);
            List<ItemResultInfo> gambleResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out gambleResultInfoList);
            ItemResultInfo gambleRewardItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out gambleRewardItemResultInfo);
            UserDailyReset userDailyResetInfo;
            CommonPacket.Marshaler.Read(__msg, out userDailyResetInfo);
            int gambleType;
            CommonPacket.Marshaler.Read(__msg, out gambleType);
            GambleAmountType amountType;
            CommonPacket.Marshaler.Read(__msg, out amountType);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            int eventSEQ;
            CommonPacket.Marshaler.Read(__msg, out eventSEQ);
            bool firstSSR;
            CommonPacket.Marshaler.Read(__msg, out firstSSR);
            UserHeroGachaGaugeInfo userHeroGachaGaugeInfo;
            CommonPacket.Marshaler.Read(__msg, out userHeroGachaGaugeInfo);
            bool isThirdGamble;
            CommonPacket.Marshaler.Read(__msg, out isThirdGamble);
            UserBingoGachaEventInfo userBingoGachaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBingoGachaEventInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            UserADViewInfo updateUserADViewInfo;
            CommonPacket.Marshaler.Read(__msg, out updateUserADViewInfo);
            PaybackEventResultInfo gamblePaybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out gamblePaybackEventResultInfo);
            List<UpgradeUserSkin> upgradeSkinList;
            CommonPacket.Marshaler.Read(__msg, out upgradeSkinList);
            UserEventGachaWishInfo userEventGachaWishInfo;
            CommonPacket.Marshaler.Read(__msg, out userEventGachaWishInfo);
            UserGachaEventOnceInfo resultUserEventGachaOnceInfo;
            CommonPacket.Marshaler.Read(__msg, out resultUserEventGachaOnceInfo);
            DailyFreeGambleInfoClientSend resultUserDailyFreeGachaInfo;
            CommonPacket.Marshaler.Read(__msg, out resultUserDailyFreeGachaInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGambleShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleShopBuyOK,
                    rmiName = RmiName_CG_RequestGambleShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGambleShopBuyOK(remote, rmiContext, priceItemResultInfoList, gambleResultInfoList, gambleRewardItemResultInfo, userDailyResetInfo, gambleType, amountType, missionResult, eventSEQ, firstSSR, userHeroGachaGaugeInfo, isThirdGamble, userBingoGachaEventInfo, paybackEventresultInfo, userPackageMissionInfoList, updateUserADViewInfo, gamblePaybackEventResultInfo, upgradeSkinList, userEventGachaWishInfo, resultUserEventGachaOnceInfo, resultUserDailyFreeGachaInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGambleShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleShopBuyOK,
                    rmiName = RmiName_CG_RequestGambleShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestItemGambleShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemGambleShopBuyInfo> buyInfoList;
            CommonPacket.Marshaler.Read(__msg, out buyInfoList);
            int remainResetSec;
            CommonPacket.Marshaler.Read(__msg, out remainResetSec);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestItemGambleShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestItemGambleShopInfoOK,
                    rmiName = RmiName_CG_RequestItemGambleShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestItemGambleShopInfoOK(remote, rmiContext, buyInfoList, remainResetSec))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestItemGambleShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestItemGambleShopInfoOK,
                    rmiName = RmiName_CG_RequestItemGambleShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestItemGambleShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ItemGambleShopBuyInfo buyInfo;
            CommonPacket.Marshaler.Read(__msg, out buyInfo);
            List<ItemResultInfo> priceItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceItemResultInfoList);
            List<ItemResultInfo> itemGambleResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out itemGambleResultInfoList);
            int itemGambleDisplayID;
            CommonPacket.Marshaler.Read(__msg, out itemGambleDisplayID);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            UserADViewInfo updateUserADViewInfo;
            CommonPacket.Marshaler.Read(__msg, out updateUserADViewInfo);
            WeaponAutoGrindResult autoGrindResult;
            CommonPacket.Marshaler.Read(__msg, out autoGrindResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestItemGambleShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestItemGambleShopBuyOK,
                    rmiName = RmiName_CG_RequestItemGambleShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestItemGambleShopBuyOK(remote, rmiContext, buyInfo, priceItemResultInfoList, itemGambleResultInfoList, itemGambleDisplayID, missionResult, paybackEventresultInfo, updateUserADViewInfo, autoGrindResult, questProgressInfoList, userPlayCountEventInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestItemGambleShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestItemGambleShopBuyOK,
                    rmiName = RmiName_CG_RequestItemGambleShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestRandomShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> priceResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceResultInfoList);
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            RandomshopSlotInfo buySlotInfo;
            CommonPacket.Marshaler.Read(__msg, out buySlotInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestRandomShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopBuyOK,
                    rmiName = RmiName_CG_RequestRandomShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestRandomShopBuyOK(remote, rmiContext, priceResultInfoList, getItemResultInfo, buySlotInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestRandomShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopBuyOK,
                    rmiName = RmiName_CG_RequestRandomShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestRandomShopRefreshOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> priceResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceResultInfoList);
            List<RandomshopSlotInfo> RandomShopSlotInfoList;
            CommonPacket.Marshaler.Read(__msg, out RandomShopSlotInfoList);
            byte resetCount;
            CommonPacket.Marshaler.Read(__msg, out resetCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            UserADViewInfo updateUserADViewInfo;
            CommonPacket.Marshaler.Read(__msg, out updateUserADViewInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestRandomShopRefreshOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopRefreshOK,
                    rmiName = RmiName_CG_RequestRandomShopRefreshOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestRandomShopRefreshOK(remote, rmiContext, priceResultInfoList, RandomShopSlotInfoList, resetCount, paybackEventresultInfo, updateUserADViewInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestRandomShopRefreshOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopRefreshOK,
                    rmiName = RmiName_CG_RequestRandomShopRefreshOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestRandomShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int basepointID;
            CommonPacket.Marshaler.Read(__msg, out basepointID);
            List<RandomshopSlotInfo> RandomShopSlotInfoList;
            CommonPacket.Marshaler.Read(__msg, out RandomShopSlotInfoList);
            byte resetCount;
            CommonPacket.Marshaler.Read(__msg, out resetCount);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestRandomShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopInfoOK,
                    rmiName = RmiName_CG_RequestRandomShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestRandomShopInfoOK(remote, rmiContext, basepointID, RandomShopSlotInfoList, resetCount))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestRandomShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopInfoOK,
                    rmiName = RmiName_CG_RequestRandomShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBasePointShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            byte resetCount;
            CommonPacket.Marshaler.Read(__msg, out resetCount);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBasePointShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBasePointShopInfoOK,
                    rmiName = RmiName_CG_RequestBasePointShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBasePointShopInfoOK(remote, rmiContext, shopBuyInfoList, resetCount))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBasePointShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBasePointShopInfoOK,
                    rmiName = RmiName_CG_RequestBasePointShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBasePointShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> priceResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceResultInfoList);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            List<ShopBuyInfo> shopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfoList);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBasePointShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBasePointShopBuyOK,
                    rmiName = RmiName_CG_RequestBasePointShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBasePointShopBuyOK(remote, rmiContext, priceResultInfoList, getItemResultInfoList, shopBuyInfoList, questProgressInfoList, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBasePointShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBasePointShopBuyOK,
                    rmiName = RmiName_CG_RequestBasePointShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBasePointShopResetOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            byte resetCount;
            CommonPacket.Marshaler.Read(__msg, out resetCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            UserADViewInfo updateUserADViewInfo;
            CommonPacket.Marshaler.Read(__msg, out updateUserADViewInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBasePointShopResetOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBasePointShopResetOK,
                    rmiName = RmiName_CG_RequestBasePointShopResetOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBasePointShopResetOK(remote, rmiContext, itemResultInfoList, resetCount, paybackEventresultInfo, updateUserADViewInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBasePointShopResetOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBasePointShopResetOK,
                    rmiName = RmiName_CG_RequestBasePointShopResetOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ShopBuyInfo> arenaRealTimePvpShopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpShopBuyInfoList);
            UserPvpShopGradeInfo userPvpShopGradeInfo;
            CommonPacket.Marshaler.Read(__msg, out userPvpShopGradeInfo);
            byte resetCount;
            CommonPacket.Marshaler.Read(__msg, out resetCount);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpShopInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpShopInfoOK(remote, rmiContext, remainSec, arenaRealTimePvpShopBuyInfoList, userPvpShopGradeInfo, resetCount))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpShopInfoOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ItemResultInfo priceResultItemInfo;
            CommonPacket.Marshaler.Read(__msg, out priceResultItemInfo);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            List<ShopBuyInfo> arenaRealTimePvpShopBuyInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaRealTimePvpShopBuyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpShopBuyOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpShopBuyOK(remote, rmiContext, priceResultItemInfo, getItemResultInfoList, arenaRealTimePvpShopBuyInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpShopBuyOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaRealTimePvpShopResetOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            byte resetCount;
            CommonPacket.Marshaler.Read(__msg, out resetCount);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            UserADViewInfo updateUserADViewInfo;
            CommonPacket.Marshaler.Read(__msg, out updateUserADViewInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaRealTimePvpShopResetOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpShopResetOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpShopResetOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaRealTimePvpShopResetOK(remote, rmiContext, itemResultInfoList, resetCount, paybackEventresultInfo, updateUserADViewInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaRealTimePvpShopResetOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaRealTimePvpShopResetOK,
                    rmiName = RmiName_CG_RequestArenaRealTimePvpShopResetOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCoinShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ShopBuyInfo> coinShopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out coinShopBuyInfoList);
            List<ShopBuyInfo> coinShopEventBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out coinShopEventBuyInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCoinShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCoinShopInfoOK,
                    rmiName = RmiName_CG_RequestCoinShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCoinShopInfoOK(remote, rmiContext, coinShopBuyInfoList, coinShopEventBuyInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCoinShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCoinShopInfoOK,
                    rmiName = RmiName_CG_RequestCoinShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCoinShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int shopID;
            CommonPacket.Marshaler.Read(__msg, out shopID);
            ShopBuyInfo buyInfo;
            CommonPacket.Marshaler.Read(__msg, out buyInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            ApRewardInfo apRewardInfo;
            CommonPacket.Marshaler.Read(__msg, out apRewardInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCoinShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCoinShopBuyOK,
                    rmiName = RmiName_CG_RequestCoinShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCoinShopBuyOK(remote, rmiContext, shopID, buyInfo, useItemResultInfoList, getItemResultInfo, apRewardInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCoinShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCoinShopBuyOK,
                    rmiName = RmiName_CG_RequestCoinShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCostumeShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ShopTimeItemInfo> shopTimeItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out shopTimeItemInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCostumeShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCostumeShopInfoOK,
                    rmiName = RmiName_CG_RequestCostumeShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCostumeShopInfoOK(remote, rmiContext, shopBuyInfoList, shopTimeItemInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCostumeShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCostumeShopInfoOK,
                    rmiName = RmiName_CG_RequestCostumeShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCostumeShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            ShopBuyInfo shopBuyInfo;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCostumeShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCostumeShopBuyOK,
                    rmiName = RmiName_CG_RequestCostumeShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCostumeShopBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, shopBuyInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCostumeShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCostumeShopBuyOK,
                    rmiName = RmiName_CG_RequestCostumeShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCommonItemSellOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            List<ItemResultInfo> itemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCommonItemSellOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCommonItemSellOK,
                    rmiName = RmiName_CG_RequestCommonItemSellOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCommonItemSellOK(remote, rmiContext, getItemResultInfo, itemResultInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCommonItemSellOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCommonItemSellOK,
                    rmiName = RmiName_CG_RequestCommonItemSellOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCommonItemRemoveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ItemResultInfo itemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCommonItemRemoveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCommonItemRemoveOK,
                    rmiName = RmiName_CG_RequestCommonItemRemoveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCommonItemRemoveOK(remote, rmiContext, itemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCommonItemRemoveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCommonItemRemoveOK,
                    rmiName = RmiName_CG_RequestCommonItemRemoveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPackageShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<UserPackageInfo> userPackageInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageInfoList);
            DateTime nowServerTime;
            CommonPacket.Marshaler.Read(__msg, out nowServerTime);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPackageShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPackageShopInfoOK,
                    rmiName = RmiName_CG_RequestPackageShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPackageShopInfoOK(remote, rmiContext, userPackageInfoList, nowServerTime))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPackageShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPackageShopInfoOK,
                    rmiName = RmiName_CG_RequestPackageShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGambleShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            GambleShopInfo gambleShopInfo;
            CommonPacket.Marshaler.Read(__msg, out gambleShopInfo);
            GambleTimeSwitchLobbyInfo gambleTimeSwitchLobbyInfo;
            CommonPacket.Marshaler.Read(__msg, out gambleTimeSwitchLobbyInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGambleShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleShopInfoOK,
                    rmiName = RmiName_CG_RequestGambleShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGambleShopInfoOK(remote, rmiContext, gambleShopInfo, gambleTimeSwitchLobbyInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGambleShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleShopInfoOK,
                    rmiName = RmiName_CG_RequestGambleShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestADRouletteRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            UserADViewInfo updateUserADViewInfo;
            CommonPacket.Marshaler.Read(__msg, out updateUserADViewInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestADRouletteRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestADRouletteRewardOK,
                    rmiName = RmiName_CG_RequestADRouletteRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestADRouletteRewardOK(remote, rmiContext, getItemResultInfo, missionResult, updateUserADViewInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestADRouletteRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestADRouletteRewardOK,
                    rmiName = RmiName_CG_RequestADRouletteRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGambleGaugeRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserHeroGachaGaugeInfo userHeroGachaGaugeInfo;
            CommonPacket.Marshaler.Read(__msg, out userHeroGachaGaugeInfo);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<UpgradeUserSkin> upgradeSkinList;
            CommonPacket.Marshaler.Read(__msg, out upgradeSkinList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGambleGaugeRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleGaugeRewardOK,
                    rmiName = RmiName_CG_RequestGambleGaugeRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGambleGaugeRewardOK(remote, rmiContext, userHeroGachaGaugeInfo, rewardItemInfoList, missionResult, upgradeSkinList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGambleGaugeRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleGaugeRewardOK,
                    rmiName = RmiName_CG_RequestGambleGaugeRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashShopInfo arenaSmashShopInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashShopInfo);
            List<ShopBuyInfo> shopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashShopInfoOK(remote, rmiContext, arenaSmashShopInfo, shopBuyInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopInfoOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashShopInfo arenaSmashShopInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashShopInfo);
            List<ItemResultInfo> priceResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceResultInfoList);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            List<ShopBuyInfo> shopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfoList);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopBuyOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashShopBuyOK(remote, rmiContext, arenaSmashShopInfo, priceResultInfoList, getItemResultInfoList, shopBuyInfoList, questProgressInfoList, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopBuyOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashShopRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            byte shopRewardID;
            CommonPacket.Marshaler.Read(__msg, out shopRewardID);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashShopRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashShopRewardOK(remote, rmiContext, shopRewardID, rewardItemInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashShopRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopRewardOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestArenaSmashShopResetOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ArenaSmashShopInfo arenaSmashShopInfo;
            CommonPacket.Marshaler.Read(__msg, out arenaSmashShopInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestArenaSmashShopResetOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopResetOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopResetOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestArenaSmashShopResetOK(remote, rmiContext, arenaSmashShopInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestArenaSmashShopResetOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestArenaSmashShopResetOK,
                    rmiName = RmiName_CG_RequestArenaSmashShopResetOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEvolutionExchangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> buyItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out buyItemResultInfo);
            List<ItemResultInfo> priceReslutInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceReslutInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEvolutionExchangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEvolutionExchangeOK,
                    rmiName = RmiName_CG_RequestEvolutionExchangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEvolutionExchangeOK(remote, rmiContext, buyItemResultInfo, priceReslutInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEvolutionExchangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEvolutionExchangeOK,
                    rmiName = RmiName_CG_RequestEvolutionExchangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestRandomShopVisitRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int basepointID;
            CommonPacket.Marshaler.Read(__msg, out basepointID);
            ItemResultInfo useItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestRandomShopVisitRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopVisitRewardOK,
                    rmiName = RmiName_CG_RequestRandomShopVisitRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestRandomShopVisitRewardOK(remote, rmiContext, basepointID, useItemResultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestRandomShopVisitRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopVisitRewardOK,
                    rmiName = RmiName_CG_RequestRandomShopVisitRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestRandomShopScheduleInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            LobbyRandomShopInfo lobbyRandomShopInfo;
            CommonPacket.Marshaler.Read(__msg, out lobbyRandomShopInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestRandomShopScheduleInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopScheduleInfoOK,
                    rmiName = RmiName_CG_RequestRandomShopScheduleInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestRandomShopScheduleInfoOK(remote, rmiContext, lobbyRandomShopInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestRandomShopScheduleInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestRandomShopScheduleInfoOK,
                    rmiName = RmiName_CG_RequestRandomShopScheduleInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPackageBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int shopMoneyID;
            CommonPacket.Marshaler.Read(__msg, out shopMoneyID);
            List<UserPackageInfo> userPackageInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageInfoList);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            List<UserDiaBuyEventInfo> userDiaBuyEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userDiaBuyEventInfoList);
            List<ClientSeasonPassRankRewardInfo> seasonPassClientSendList;
            CommonPacket.Marshaler.Read(__msg, out seasonPassClientSendList);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            int firstDiaBuyItemID;
            CommonPacket.Marshaler.Read(__msg, out firstDiaBuyItemID);
            UserBuffInfo userBuffInfo;
            CommonPacket.Marshaler.Read(__msg, out userBuffInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPackageBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPackageBuyOK,
                    rmiName = RmiName_CG_RequestPackageBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPackageBuyOK(remote, rmiContext, shopMoneyID, userPackageInfoList, getItemResultInfoList, userDiaBuyEventInfoList, seasonPassClientSendList, userPackageMissionInfoList, firstDiaBuyItemID, userBuffInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPackageBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPackageBuyOK,
                    rmiName = RmiName_CG_RequestPackageBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBuyDiaOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBuyDiaOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBuyDiaOK,
                    rmiName = RmiName_CG_RequestBuyDiaOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBuyDiaOK(remote, rmiContext, getItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBuyDiaOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBuyDiaOK,
                    rmiName = RmiName_CG_RequestBuyDiaOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBuyGoldOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBuyGoldOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBuyGoldOK,
                    rmiName = RmiName_CG_RequestBuyGoldOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBuyGoldOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBuyGoldOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBuyGoldOK,
                    rmiName = RmiName_CG_RequestBuyGoldOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBuyStaminaOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            APInfo apInfo;
            CommonPacket.Marshaler.Read(__msg, out apInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBuyStaminaOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBuyStaminaOK,
                    rmiName = RmiName_CG_RequestBuyStaminaOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBuyStaminaOK(remote, rmiContext, useItemResultInfoList, apInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBuyStaminaOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBuyStaminaOK,
                    rmiName = RmiName_CG_RequestBuyStaminaOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCostumeShopPackageBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            List<ShopBuyInfo> shopBuyInfoList;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCostumeShopPackageBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCostumeShopPackageBuyOK,
                    rmiName = RmiName_CG_RequestCostumeShopPackageBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCostumeShopPackageBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, shopBuyInfoList, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCostumeShopPackageBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCostumeShopPackageBuyOK,
                    rmiName = RmiName_CG_RequestCostumeShopPackageBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestFinalBossShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendFinalBossSeasonShopInfo clientSendFinalBossSeasonShopInfo;
            CommonPacket.Marshaler.Read(__msg, out clientSendFinalBossSeasonShopInfo);
            List<ItemResultInfo> remoteItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out remoteItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestFinalBossShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestFinalBossShopInfoOK,
                    rmiName = RmiName_CG_RequestFinalBossShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestFinalBossShopInfoOK(remote, rmiContext, clientSendFinalBossSeasonShopInfo, remoteItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestFinalBossShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestFinalBossShopInfoOK,
                    rmiName = RmiName_CG_RequestFinalBossShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestFinalBossShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            FinalBossSeasonShopBuyInfo shopBuyInfo;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestFinalBossShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestFinalBossShopBuyOK,
                    rmiName = RmiName_CG_RequestFinalBossShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestFinalBossShopBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, shopBuyInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestFinalBossShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestFinalBossShopBuyOK,
                    rmiName = RmiName_CG_RequestFinalBossShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBingoGambleShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserBingoGachaEventInfo userBingoGachaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBingoGachaEventInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBingoGambleShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBingoGambleShopInfoOK,
                    rmiName = RmiName_CG_RequestBingoGambleShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBingoGambleShopInfoOK(remote, rmiContext, userBingoGachaEventInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBingoGambleShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBingoGambleShopInfoOK,
                    rmiName = RmiName_CG_RequestBingoGambleShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBingoGambleShopResetOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserBingoGachaEventInfo userBingoGachaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBingoGachaEventInfo);
            List<ItemResultInfo> useItemResultinfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultinfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBingoGambleShopResetOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBingoGambleShopResetOK,
                    rmiName = RmiName_CG_RequestBingoGambleShopResetOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBingoGambleShopResetOK(remote, rmiContext, userBingoGachaEventInfo, useItemResultinfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBingoGambleShopResetOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBingoGambleShopResetOK,
                    rmiName = RmiName_CG_RequestBingoGambleShopResetOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestBingoGambleShopRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserBingoGachaEventInfo userBingoGachaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBingoGachaEventInfo);
            List<ItemResultInfo> itemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestBingoGambleShopRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestBingoGambleShopRewardOK,
                    rmiName = RmiName_CG_RequestBingoGambleShopRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestBingoGambleShopRewardOK(remote, rmiContext, userBingoGachaEventInfo, itemResultInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestBingoGambleShopRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestBingoGambleShopRewardOK,
                    rmiName = RmiName_CG_RequestBingoGambleShopRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestDiaShopPackageBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int productItemID;
            CommonPacket.Marshaler.Read(__msg, out productItemID);
            List<UserPackageInfo> userPackageInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageInfoList);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestDiaShopPackageBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestDiaShopPackageBuyOK,
                    rmiName = RmiName_CG_RequestDiaShopPackageBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestDiaShopPackageBuyOK(remote, rmiContext, productItemID, userPackageInfoList, useItemResultInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestDiaShopPackageBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestDiaShopPackageBuyOK,
                    rmiName = RmiName_CG_RequestDiaShopPackageBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestGambleChoiceShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<ItemResultInfo> priceItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceItemResultInfoList);
            List<ItemResultInfo> itemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfoList);
            int gambleType;
            CommonPacket.Marshaler.Read(__msg, out gambleType);
            int gambleEventSEQ;
            CommonPacket.Marshaler.Read(__msg, out gambleEventSEQ);
            UserBingoGachaEventInfo userBingoGachaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBingoGachaEventInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<UpgradeUserSkin> upgradeSkinResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out upgradeSkinResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestGambleChoiceShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleChoiceShopBuyOK,
                    rmiName = RmiName_CG_RequestGambleChoiceShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestGambleChoiceShopBuyOK(remote, rmiContext, priceItemResultInfoList, itemResultInfoList, gambleType, gambleEventSEQ, userBingoGachaEventInfo, missionResult, paybackEventresultInfo, upgradeSkinResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestGambleChoiceShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestGambleChoiceShopBuyOK,
                    rmiName = RmiName_CG_RequestGambleChoiceShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestFreePackageRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long freePackageReward;
            CommonPacket.Marshaler.Read(__msg, out freePackageReward);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestFreePackageRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestFreePackageRewardOK,
                    rmiName = RmiName_CG_RequestFreePackageRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestFreePackageRewardOK(remote, rmiContext, freePackageReward, getItemResultInfoList, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestFreePackageRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestFreePackageRewardOK,
                    rmiName = RmiName_CG_RequestFreePackageRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestPackageMissionCloseOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestPackageMissionCloseOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestPackageMissionCloseOK,
                    rmiName = RmiName_CG_RequestPackageMissionCloseOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestPackageMissionCloseOK(remote, rmiContext, userPackageMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestPackageMissionCloseOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestPackageMissionCloseOK,
                    rmiName = RmiName_CG_RequestPackageMissionCloseOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestStepupGambleShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserStepupGachaEventInfo stepupInfo;
            CommonPacket.Marshaler.Read(__msg, out stepupInfo);
            List<ItemResultInfo> priceItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out priceItemResultInfoList);
            List<ItemResultInfo> gambleResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out gambleResultInfoList);
            ItemResultInfo gambleRewardResultInfo;
            CommonPacket.Marshaler.Read(__msg, out gambleRewardResultInfo);
            List<ItemResultInfo> bonusResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out bonusResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            UserBingoGachaEventInfo userBingoGachaEventInfo;
            CommonPacket.Marshaler.Read(__msg, out userBingoGachaEventInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            PaybackEventResultInfo gamblePaybackEventResultInfo;
            CommonPacket.Marshaler.Read(__msg, out gamblePaybackEventResultInfo);
            List<UpgradeUserSkin> upgradeSkinList;
            CommonPacket.Marshaler.Read(__msg, out upgradeSkinList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestStepupGambleShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestStepupGambleShopBuyOK,
                    rmiName = RmiName_CG_RequestStepupGambleShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestStepupGambleShopBuyOK(remote, rmiContext, stepupInfo, priceItemResultInfoList, gambleResultInfoList, gambleRewardResultInfo, bonusResultInfoList, missionResult, userBingoGachaEventInfo, paybackEventresultInfo, gamblePaybackEventResultInfo, upgradeSkinList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestStepupGambleShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestStepupGambleShopBuyOK,
                    rmiName = RmiName_CG_RequestStepupGambleShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestStepupGambleMileageRewardOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserStepupGachaEventInfo stepupInfo;
            CommonPacket.Marshaler.Read(__msg, out stepupInfo);
            List<ItemResultInfo> rewardItemInfoList;
            CommonPacket.Marshaler.Read(__msg, out rewardItemInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<UpgradeUserSkin> upgradeSkinList;
            CommonPacket.Marshaler.Read(__msg, out upgradeSkinList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestStepupGambleMileageRewardOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestStepupGambleMileageRewardOK,
                    rmiName = RmiName_CG_RequestStepupGambleMileageRewardOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestStepupGambleMileageRewardOK(remote, rmiContext, stepupInfo, rewardItemInfoList, missionResult, upgradeSkinList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestStepupGambleMileageRewardOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestStepupGambleMileageRewardOK,
                    rmiName = RmiName_CG_RequestStepupGambleMileageRewardOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestLobbyHousingShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestLobbyHousingShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestLobbyHousingShopInfoOK,
                    rmiName = RmiName_CG_RequestLobbyHousingShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestLobbyHousingShopInfoOK(remote, rmiContext, shopBuyInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestLobbyHousingShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestLobbyHousingShopInfoOK,
                    rmiName = RmiName_CG_RequestLobbyHousingShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestLobbyHousingShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            ShopBuyInfo shopBuyInfo;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestLobbyHousingShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestLobbyHousingShopBuyOK,
                    rmiName = RmiName_CG_RequestLobbyHousingShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestLobbyHousingShopBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, shopBuyInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestLobbyHousingShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestLobbyHousingShopBuyOK,
                    rmiName = RmiName_CG_RequestLobbyHousingShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestYggdrasilTowerShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            int remainResetTimeSec;
            CommonPacket.Marshaler.Read(__msg, out remainResetTimeSec);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestYggdrasilTowerShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerShopInfoOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestYggdrasilTowerShopInfoOK(remote, rmiContext, shopBuyInfoList, remainResetTimeSec))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestYggdrasilTowerShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerShopInfoOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestYggdrasilTowerShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            ShopBuyInfo shopBuyInfo;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestYggdrasilTowerShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerShopBuyOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestYggdrasilTowerShopBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, shopBuyInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestYggdrasilTowerShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestYggdrasilTowerShopBuyOK,
                    rmiName = RmiName_CG_RequestYggdrasilTowerShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventCoinShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int shopID;
            CommonPacket.Marshaler.Read(__msg, out shopID);
            ShopBuyInfo buyInfo;
            CommonPacket.Marshaler.Read(__msg, out buyInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            ApRewardInfo apRewardInfo;
            CommonPacket.Marshaler.Read(__msg, out apRewardInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventCoinShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventCoinShopBuyOK,
                    rmiName = RmiName_CG_RequestEventCoinShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventCoinShopBuyOK(remote, rmiContext, shopID, buyInfo, useItemResultInfoList, getItemResultInfo, apRewardInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventCoinShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventCoinShopBuyOK,
                    rmiName = RmiName_CG_RequestEventCoinShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeSeasonShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendEventMazeSeasonShopInfo clientSendEventMazeSeasonShopInfo;
            CommonPacket.Marshaler.Read(__msg, out clientSendEventMazeSeasonShopInfo);
            List<ItemResultInfo> itemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeSeasonShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeSeasonShopInfoOK,
                    rmiName = RmiName_CG_RequestEventMazeSeasonShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeSeasonShopInfoOK(remote, rmiContext, clientSendEventMazeSeasonShopInfo, itemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeSeasonShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeSeasonShopInfoOK,
                    rmiName = RmiName_CG_RequestEventMazeSeasonShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestEventMazeSeasonShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            EventMazeSeasonShopBuyInfo shopBuyInfo;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfo);
            int seasonShopBuyPoint;
            CommonPacket.Marshaler.Read(__msg, out seasonShopBuyPoint);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestEventMazeSeasonShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeSeasonShopBuyOK,
                    rmiName = RmiName_CG_RequestEventMazeSeasonShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestEventMazeSeasonShopBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, shopBuyInfo, seasonShopBuyPoint, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestEventMazeSeasonShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestEventMazeSeasonShopBuyOK,
                    rmiName = RmiName_CG_RequestEventMazeSeasonShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestHeroLeagueSeasonShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            ClientSendHeroLeagueSeasonShopInfo clientSendHeroLeagueSeasonShopInfo;
            CommonPacket.Marshaler.Read(__msg, out clientSendHeroLeagueSeasonShopInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestHeroLeagueSeasonShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestHeroLeagueSeasonShopInfoOK,
                    rmiName = RmiName_CG_RequestHeroLeagueSeasonShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestHeroLeagueSeasonShopInfoOK(remote, rmiContext, clientSendHeroLeagueSeasonShopInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestHeroLeagueSeasonShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestHeroLeagueSeasonShopInfoOK,
                    rmiName = RmiName_CG_RequestHeroLeagueSeasonShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestHeroLeagueSeasonShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            HeroLeagueSeasonShopBuyInfo shopBuyInfo;
            CommonPacket.Marshaler.Read(__msg, out shopBuyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestHeroLeagueSeasonShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestHeroLeagueSeasonShopBuyOK,
                    rmiName = RmiName_CG_RequestHeroLeagueSeasonShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestHeroLeagueSeasonShopBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, shopBuyInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestHeroLeagueSeasonShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestHeroLeagueSeasonShopBuyOK,
                    rmiName = RmiName_CG_RequestHeroLeagueSeasonShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCreatureColosseumShopInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            CreatureNestColosseumSeasonInfo seasonInfo;
            CommonPacket.Marshaler.Read(__msg, out seasonInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCreatureColosseumShopInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCreatureColosseumShopInfoOK,
                    rmiName = RmiName_CG_RequestCreatureColosseumShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCreatureColosseumShopInfoOK(remote, rmiContext, shopBuyInfoList, seasonInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCreatureColosseumShopInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCreatureColosseumShopInfoOK,
                    rmiName = RmiName_CG_RequestCreatureColosseumShopInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestCreatureColosseumShopBuyOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
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
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            ShopBuyInfo buyInfo;
            CommonPacket.Marshaler.Read(__msg, out buyInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestCreatureColosseumShopBuyOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestCreatureColosseumShopBuyOK,
                    rmiName = RmiName_CG_RequestCreatureColosseumShopBuyOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestCreatureColosseumShopBuyOK(remote, rmiContext, useItemResultInfoList, getItemResultInfoList, buyInfo, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestCreatureColosseumShopBuyOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestCreatureColosseumShopBuyOK,
                    rmiName = RmiName_CG_RequestCreatureColosseumShopBuyOK,
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

        public Stub.CG_RequestItemInventoryBuyOKDelegate CG_RequestItemInventoryBuyOK = (HostID remote, RmiContext rmiContext, short maxItemInventoryCount, List<ItemResultInfo> useItemResultinfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeaponInventoryBuyOKDelegate CG_RequestWeaponInventoryBuyOK = (HostID remote, RmiContext rmiContext, short maxWeaponInventoryCount, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeekStageKeyBuyOKDelegate CG_RequestWeekStageKeyBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useDiaItemResultInfoList, List<ItemResultInfo> getItemResultInfoList) => false;

        public Stub.CG_RequestDiaShopInfoOKDelegate CG_RequestDiaShopInfoOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, List<UserPackageInfo> userPackageInfoList) => false;

        public Stub.CG_RequestDiaShopBuyOKDelegate CG_RequestDiaShopBuyOK = (HostID remote, RmiContext rmiContext, int productID, ApRewardInfo apUpdateInfo, ApRewardInfo apBonusInfo, int addUserExp, MissionResult missionResult, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, byte buyCount, byte getBonusCount, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestGambleShopBuyOKDelegate CG_RequestGambleShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> gambleResultInfoList, ItemResultInfo gambleRewardItemResultInfo, UserDailyReset userDailyResetInfo, int gambleType, GambleAmountType amountType, MissionResult missionResult, int eventSEQ, bool firstSSR, UserHeroGachaGaugeInfo userHeroGachaGaugeInfo, bool isThirdGamble, UserBingoGachaEventInfo userBingoGachaEventInfo, PaybackEventResultInfo paybackEventresultInfo, List<UserPackageMissionInfo> userPackageMissionInfoList, UserADViewInfo updateUserADViewInfo, PaybackEventResultInfo gamblePaybackEventResultInfo, List<UpgradeUserSkin> upgradeSkinList, UserEventGachaWishInfo userEventGachaWishInfo, UserGachaEventOnceInfo resultUserEventGachaOnceInfo, DailyFreeGambleInfoClientSend resultUserDailyFreeGachaInfo) => false;

        public Stub.CG_RequestItemGambleShopInfoOKDelegate CG_RequestItemGambleShopInfoOK = (HostID remote, RmiContext rmiContext, List<ItemGambleShopBuyInfo> buyInfoList, int remainResetSec) => false;

        public Stub.CG_RequestItemGambleShopBuyOKDelegate CG_RequestItemGambleShopBuyOK = (HostID remote, RmiContext rmiContext, ItemGambleShopBuyInfo buyInfo, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> itemGambleResultInfoList, int itemGambleDisplayID, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo, WeaponAutoGrindResult autoGrindResult, List<QuestProgressInfo> questProgressInfoList, List<UserPlayCountEventInfo> userPlayCountEventInfoList) => false;

        public Stub.CG_RequestRandomShopBuyOKDelegate CG_RequestRandomShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceResultInfoList, ItemResultInfo getItemResultInfo, RandomshopSlotInfo buySlotInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestRandomShopRefreshOKDelegate CG_RequestRandomShopRefreshOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceResultInfoList, List<RandomshopSlotInfo> RandomShopSlotInfoList, byte resetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo) => false;

        public Stub.CG_RequestRandomShopInfoOKDelegate CG_RequestRandomShopInfoOK = (HostID remote, RmiContext rmiContext, int basepointID, List<RandomshopSlotInfo> RandomShopSlotInfoList, byte resetCount) => false;

        public Stub.CG_RequestBasePointShopInfoOKDelegate CG_RequestBasePointShopInfoOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, byte resetCount) => false;

        public Stub.CG_RequestBasePointShopBuyOKDelegate CG_RequestBasePointShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceResultInfoList, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> shopBuyInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestBasePointShopResetOKDelegate CG_RequestBasePointShopResetOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> itemResultInfoList, byte resetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpShopInfoOKDelegate CG_RequestArenaRealTimePvpShopInfoOK = (HostID remote, RmiContext rmiContext, int remainSec, List<ShopBuyInfo> arenaRealTimePvpShopBuyInfoList, UserPvpShopGradeInfo userPvpShopGradeInfo, byte resetCount) => false;

        public Stub.CG_RequestArenaRealTimePvpShopBuyOKDelegate CG_RequestArenaRealTimePvpShopBuyOK = (HostID remote, RmiContext rmiContext, ItemResultInfo priceResultItemInfo, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> arenaRealTimePvpShopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestArenaRealTimePvpShopResetOKDelegate CG_RequestArenaRealTimePvpShopResetOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> itemResultInfoList, byte resetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo) => false;

        public Stub.CG_RequestCoinShopInfoOKDelegate CG_RequestCoinShopInfoOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> coinShopBuyInfoList, List<ShopBuyInfo> coinShopEventBuyInfoList) => false;

        public Stub.CG_RequestCoinShopBuyOKDelegate CG_RequestCoinShopBuyOK = (HostID remote, RmiContext rmiContext, int shopID, ShopBuyInfo buyInfo, List<ItemResultInfo> useItemResultInfoList, ItemResultInfo getItemResultInfo, ApRewardInfo apRewardInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestCostumeShopInfoOKDelegate CG_RequestCostumeShopInfoOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, List<ShopTimeItemInfo> shopTimeItemInfoList) => false;

        public Stub.CG_RequestCostumeShopBuyOKDelegate CG_RequestCostumeShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestCommonItemSellOKDelegate CG_RequestCommonItemSellOK = (HostID remote, RmiContext rmiContext, ItemResultInfo getItemResultInfo, List<ItemResultInfo> itemResultInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestCommonItemRemoveOKDelegate CG_RequestCommonItemRemoveOK = (HostID remote, RmiContext rmiContext, ItemResultInfo itemResultInfo) => false;

        public Stub.CG_RequestPackageShopInfoOKDelegate CG_RequestPackageShopInfoOK = (HostID remote, RmiContext rmiContext, List<UserPackageInfo> userPackageInfoList, DateTime nowServerTime) => false;

        public Stub.CG_RequestGambleShopInfoOKDelegate CG_RequestGambleShopInfoOK = (HostID remote, RmiContext rmiContext, GambleShopInfo gambleShopInfo, GambleTimeSwitchLobbyInfo gambleTimeSwitchLobbyInfo) => false;

        public Stub.CG_RequestADRouletteRewardOKDelegate CG_RequestADRouletteRewardOK = (HostID remote, RmiContext rmiContext, ItemResultInfo getItemResultInfo, MissionResult missionResult, UserADViewInfo updateUserADViewInfo) => false;

        public Stub.CG_RequestGambleGaugeRewardOKDelegate CG_RequestGambleGaugeRewardOK = (HostID remote, RmiContext rmiContext, UserHeroGachaGaugeInfo userHeroGachaGaugeInfo, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, List<UpgradeUserSkin> upgradeSkinList) => false;

        public Stub.CG_RequestArenaSmashShopInfoOKDelegate CG_RequestArenaSmashShopInfoOK = (HostID remote, RmiContext rmiContext, ArenaSmashShopInfo arenaSmashShopInfo, List<ShopBuyInfo> shopBuyInfoList) => false;

        public Stub.CG_RequestArenaSmashShopBuyOKDelegate CG_RequestArenaSmashShopBuyOK = (HostID remote, RmiContext rmiContext, ArenaSmashShopInfo arenaSmashShopInfo, List<ItemResultInfo> priceResultInfoList, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> shopBuyInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestArenaSmashShopRewardOKDelegate CG_RequestArenaSmashShopRewardOK = (HostID remote, RmiContext rmiContext, byte shopRewardID, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestArenaSmashShopResetOKDelegate CG_RequestArenaSmashShopResetOK = (HostID remote, RmiContext rmiContext, ArenaSmashShopInfo arenaSmashShopInfo) => false;

        public Stub.CG_RequestEvolutionExchangeOKDelegate CG_RequestEvolutionExchangeOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> buyItemResultInfo, List<ItemResultInfo> priceReslutInfoList) => false;

        public Stub.CG_RequestRandomShopVisitRewardOKDelegate CG_RequestRandomShopVisitRewardOK = (HostID remote, RmiContext rmiContext, int basepointID, ItemResultInfo useItemResultInfo) => false;

        public Stub.CG_RequestRandomShopScheduleInfoOKDelegate CG_RequestRandomShopScheduleInfoOK = (HostID remote, RmiContext rmiContext, LobbyRandomShopInfo lobbyRandomShopInfo) => false;

        public Stub.CG_RequestPackageBuyOKDelegate CG_RequestPackageBuyOK = (HostID remote, RmiContext rmiContext, int shopMoneyID, List<UserPackageInfo> userPackageInfoList, List<ItemResultInfo> getItemResultInfoList, List<UserDiaBuyEventInfo> userDiaBuyEventInfoList, List<ClientSeasonPassRankRewardInfo> seasonPassClientSendList, List<UserPackageMissionInfo> userPackageMissionInfoList, int firstDiaBuyItemID, UserBuffInfo userBuffInfo) => false;

        public Stub.CG_RequestBuyDiaOKDelegate CG_RequestBuyDiaOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> getItemResultInfoList) => false;

        public Stub.CG_RequestBuyGoldOKDelegate CG_RequestBuyGoldOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestBuyStaminaOKDelegate CG_RequestBuyStaminaOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, APInfo apInfo, MissionResult missionResult) => false;

        public Stub.CG_RequestCostumeShopPackageBuyOKDelegate CG_RequestCostumeShopPackageBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> shopBuyInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestFinalBossShopInfoOKDelegate CG_RequestFinalBossShopInfoOK = (HostID remote, RmiContext rmiContext, ClientSendFinalBossSeasonShopInfo clientSendFinalBossSeasonShopInfo, List<ItemResultInfo> remoteItemResultInfoList) => false;

        public Stub.CG_RequestFinalBossShopBuyOKDelegate CG_RequestFinalBossShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, FinalBossSeasonShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestBingoGambleShopInfoOKDelegate CG_RequestBingoGambleShopInfoOK = (HostID remote, RmiContext rmiContext, UserBingoGachaEventInfo userBingoGachaEventInfo) => false;

        public Stub.CG_RequestBingoGambleShopResetOKDelegate CG_RequestBingoGambleShopResetOK = (HostID remote, RmiContext rmiContext, UserBingoGachaEventInfo userBingoGachaEventInfo, List<ItemResultInfo> useItemResultinfoList) => false;

        public Stub.CG_RequestBingoGambleShopRewardOKDelegate CG_RequestBingoGambleShopRewardOK = (HostID remote, RmiContext rmiContext, UserBingoGachaEventInfo userBingoGachaEventInfo, List<ItemResultInfo> itemResultInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestDiaShopPackageBuyOKDelegate CG_RequestDiaShopPackageBuyOK = (HostID remote, RmiContext rmiContext, int productItemID, List<UserPackageInfo> userPackageInfoList, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestGambleChoiceShopBuyOKDelegate CG_RequestGambleChoiceShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> itemResultInfoList, int gambleType, int gambleEventSEQ, UserBingoGachaEventInfo userBingoGachaEventInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<UpgradeUserSkin> upgradeSkinResultInfoList) => false;

        public Stub.CG_RequestFreePackageRewardOKDelegate CG_RequestFreePackageRewardOK = (HostID remote, RmiContext rmiContext, long freePackageReward, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult) => false;

        public Stub.CG_RequestPackageMissionCloseOKDelegate CG_RequestPackageMissionCloseOK = (HostID remote, RmiContext rmiContext, List<UserPackageMissionInfo> userPackageMissionInfoList) => false;

        public Stub.CG_RequestStepupGambleShopBuyOKDelegate CG_RequestStepupGambleShopBuyOK = (HostID remote, RmiContext rmiContext, UserStepupGachaEventInfo stepupInfo, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> gambleResultInfoList, ItemResultInfo gambleRewardResultInfo, List<ItemResultInfo> bonusResultInfoList, MissionResult missionResult, UserBingoGachaEventInfo userBingoGachaEventInfo, PaybackEventResultInfo paybackEventresultInfo, PaybackEventResultInfo gamblePaybackEventResultInfo, List<UpgradeUserSkin> upgradeSkinList) => false;

        public Stub.CG_RequestStepupGambleMileageRewardOKDelegate CG_RequestStepupGambleMileageRewardOK = (HostID remote, RmiContext rmiContext, UserStepupGachaEventInfo stepupInfo, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, List<UpgradeUserSkin> upgradeSkinList) => false;

        public Stub.CG_RequestLobbyHousingShopInfoOKDelegate CG_RequestLobbyHousingShopInfoOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList) => false;

        public Stub.CG_RequestLobbyHousingShopBuyOKDelegate CG_RequestLobbyHousingShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestYggdrasilTowerShopInfoOKDelegate CG_RequestYggdrasilTowerShopInfoOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, int remainResetTimeSec) => false;

        public Stub.CG_RequestYggdrasilTowerShopBuyOKDelegate CG_RequestYggdrasilTowerShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestEventCoinShopBuyOKDelegate CG_RequestEventCoinShopBuyOK = (HostID remote, RmiContext rmiContext, int shopID, ShopBuyInfo buyInfo, List<ItemResultInfo> useItemResultInfoList, ItemResultInfo getItemResultInfo, ApRewardInfo apRewardInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestEventMazeSeasonShopInfoOKDelegate CG_RequestEventMazeSeasonShopInfoOK = (HostID remote, RmiContext rmiContext, ClientSendEventMazeSeasonShopInfo clientSendEventMazeSeasonShopInfo, List<ItemResultInfo> itemResultInfoList) => false;

        public Stub.CG_RequestEventMazeSeasonShopBuyOKDelegate CG_RequestEventMazeSeasonShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, EventMazeSeasonShopBuyInfo shopBuyInfo, int seasonShopBuyPoint, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestHeroLeagueSeasonShopInfoOKDelegate CG_RequestHeroLeagueSeasonShopInfoOK = (HostID remote, RmiContext rmiContext, ClientSendHeroLeagueSeasonShopInfo clientSendHeroLeagueSeasonShopInfo) => false;

        public Stub.CG_RequestHeroLeagueSeasonShopBuyOKDelegate CG_RequestHeroLeagueSeasonShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, HeroLeagueSeasonShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestCreatureColosseumShopInfoOKDelegate CG_RequestCreatureColosseumShopInfoOK = (HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, CreatureNestColosseumSeasonInfo seasonInfo) => false;

        public Stub.CG_RequestCreatureColosseumShopBuyOKDelegate CG_RequestCreatureColosseumShopBuyOK = (HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo buyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public const string RmiName_CG_RequestItemInventoryBuyOK = "CG_RequestItemInventoryBuyOK";

        public const string RmiName_CG_RequestWeaponInventoryBuyOK = "CG_RequestWeaponInventoryBuyOK";

        public const string RmiName_CG_RequestWeekStageKeyBuyOK = "CG_RequestWeekStageKeyBuyOK";

        public const string RmiName_CG_RequestDiaShopInfoOK = "CG_RequestDiaShopInfoOK";

        public const string RmiName_CG_RequestDiaShopBuyOK = "CG_RequestDiaShopBuyOK";

        public const string RmiName_CG_RequestGambleShopBuyOK = "CG_RequestGambleShopBuyOK";

        public const string RmiName_CG_RequestItemGambleShopInfoOK = "CG_RequestItemGambleShopInfoOK";

        public const string RmiName_CG_RequestItemGambleShopBuyOK = "CG_RequestItemGambleShopBuyOK";

        public const string RmiName_CG_RequestRandomShopBuyOK = "CG_RequestRandomShopBuyOK";

        public const string RmiName_CG_RequestRandomShopRefreshOK = "CG_RequestRandomShopRefreshOK";

        public const string RmiName_CG_RequestRandomShopInfoOK = "CG_RequestRandomShopInfoOK";

        public const string RmiName_CG_RequestBasePointShopInfoOK = "CG_RequestBasePointShopInfoOK";

        public const string RmiName_CG_RequestBasePointShopBuyOK = "CG_RequestBasePointShopBuyOK";

        public const string RmiName_CG_RequestBasePointShopResetOK = "CG_RequestBasePointShopResetOK";

        public const string RmiName_CG_RequestArenaRealTimePvpShopInfoOK = "CG_RequestArenaRealTimePvpShopInfoOK";

        public const string RmiName_CG_RequestArenaRealTimePvpShopBuyOK = "CG_RequestArenaRealTimePvpShopBuyOK";

        public const string RmiName_CG_RequestArenaRealTimePvpShopResetOK = "CG_RequestArenaRealTimePvpShopResetOK";

        public const string RmiName_CG_RequestCoinShopInfoOK = "CG_RequestCoinShopInfoOK";

        public const string RmiName_CG_RequestCoinShopBuyOK = "CG_RequestCoinShopBuyOK";

        public const string RmiName_CG_RequestCostumeShopInfoOK = "CG_RequestCostumeShopInfoOK";

        public const string RmiName_CG_RequestCostumeShopBuyOK = "CG_RequestCostumeShopBuyOK";

        public const string RmiName_CG_RequestCommonItemSellOK = "CG_RequestCommonItemSellOK";

        public const string RmiName_CG_RequestCommonItemRemoveOK = "CG_RequestCommonItemRemoveOK";

        public const string RmiName_CG_RequestPackageShopInfoOK = "CG_RequestPackageShopInfoOK";

        public const string RmiName_CG_RequestGambleShopInfoOK = "CG_RequestGambleShopInfoOK";

        public const string RmiName_CG_RequestADRouletteRewardOK = "CG_RequestADRouletteRewardOK";

        public const string RmiName_CG_RequestGambleGaugeRewardOK = "CG_RequestGambleGaugeRewardOK";

        public const string RmiName_CG_RequestArenaSmashShopInfoOK = "CG_RequestArenaSmashShopInfoOK";

        public const string RmiName_CG_RequestArenaSmashShopBuyOK = "CG_RequestArenaSmashShopBuyOK";

        public const string RmiName_CG_RequestArenaSmashShopRewardOK = "CG_RequestArenaSmashShopRewardOK";

        public const string RmiName_CG_RequestArenaSmashShopResetOK = "CG_RequestArenaSmashShopResetOK";

        public const string RmiName_CG_RequestEvolutionExchangeOK = "CG_RequestEvolutionExchangeOK";

        public const string RmiName_CG_RequestRandomShopVisitRewardOK = "CG_RequestRandomShopVisitRewardOK";

        public const string RmiName_CG_RequestRandomShopScheduleInfoOK = "CG_RequestRandomShopScheduleInfoOK";

        public const string RmiName_CG_RequestPackageBuyOK = "CG_RequestPackageBuyOK";

        public const string RmiName_CG_RequestBuyDiaOK = "CG_RequestBuyDiaOK";

        public const string RmiName_CG_RequestBuyGoldOK = "CG_RequestBuyGoldOK";

        public const string RmiName_CG_RequestBuyStaminaOK = "CG_RequestBuyStaminaOK";

        public const string RmiName_CG_RequestCostumeShopPackageBuyOK = "CG_RequestCostumeShopPackageBuyOK";

        public const string RmiName_CG_RequestFinalBossShopInfoOK = "CG_RequestFinalBossShopInfoOK";

        public const string RmiName_CG_RequestFinalBossShopBuyOK = "CG_RequestFinalBossShopBuyOK";

        public const string RmiName_CG_RequestBingoGambleShopInfoOK = "CG_RequestBingoGambleShopInfoOK";

        public const string RmiName_CG_RequestBingoGambleShopResetOK = "CG_RequestBingoGambleShopResetOK";

        public const string RmiName_CG_RequestBingoGambleShopRewardOK = "CG_RequestBingoGambleShopRewardOK";

        public const string RmiName_CG_RequestDiaShopPackageBuyOK = "CG_RequestDiaShopPackageBuyOK";

        public const string RmiName_CG_RequestGambleChoiceShopBuyOK = "CG_RequestGambleChoiceShopBuyOK";

        public const string RmiName_CG_RequestFreePackageRewardOK = "CG_RequestFreePackageRewardOK";

        public const string RmiName_CG_RequestPackageMissionCloseOK = "CG_RequestPackageMissionCloseOK";

        public const string RmiName_CG_RequestStepupGambleShopBuyOK = "CG_RequestStepupGambleShopBuyOK";

        public const string RmiName_CG_RequestStepupGambleMileageRewardOK = "CG_RequestStepupGambleMileageRewardOK";

        public const string RmiName_CG_RequestLobbyHousingShopInfoOK = "CG_RequestLobbyHousingShopInfoOK";

        public const string RmiName_CG_RequestLobbyHousingShopBuyOK = "CG_RequestLobbyHousingShopBuyOK";

        public const string RmiName_CG_RequestYggdrasilTowerShopInfoOK = "CG_RequestYggdrasilTowerShopInfoOK";

        public const string RmiName_CG_RequestYggdrasilTowerShopBuyOK = "CG_RequestYggdrasilTowerShopBuyOK";

        public const string RmiName_CG_RequestEventCoinShopBuyOK = "CG_RequestEventCoinShopBuyOK";

        public const string RmiName_CG_RequestEventMazeSeasonShopInfoOK = "CG_RequestEventMazeSeasonShopInfoOK";

        public const string RmiName_CG_RequestEventMazeSeasonShopBuyOK = "CG_RequestEventMazeSeasonShopBuyOK";

        public const string RmiName_CG_RequestHeroLeagueSeasonShopInfoOK = "CG_RequestHeroLeagueSeasonShopInfoOK";

        public const string RmiName_CG_RequestHeroLeagueSeasonShopBuyOK = "CG_RequestHeroLeagueSeasonShopBuyOK";

        public const string RmiName_CG_RequestCreatureColosseumShopInfoOK = "CG_RequestCreatureColosseumShopInfoOK";

        public const string RmiName_CG_RequestCreatureColosseumShopBuyOK = "CG_RequestCreatureColosseumShopBuyOK";

        public const string RmiName_First = "CG_RequestItemInventoryBuyOK";

        public delegate bool CG_RequestItemInventoryBuyOKDelegate(HostID remote, RmiContext rmiContext, short maxItemInventoryCount, List<ItemResultInfo> useItemResultinfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeaponInventoryBuyOKDelegate(HostID remote, RmiContext rmiContext, short maxWeaponInventoryCount, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeekStageKeyBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useDiaItemResultInfoList, List<ItemResultInfo> getItemResultInfoList);

        public delegate bool CG_RequestDiaShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, List<UserPackageInfo> userPackageInfoList);

        public delegate bool CG_RequestDiaShopBuyOKDelegate(HostID remote, RmiContext rmiContext, int productID, ApRewardInfo apUpdateInfo, ApRewardInfo apBonusInfo, int addUserExp, MissionResult missionResult, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, byte buyCount, byte getBonusCount, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestGambleShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> gambleResultInfoList, ItemResultInfo gambleRewardItemResultInfo, UserDailyReset userDailyResetInfo, int gambleType, GambleAmountType amountType, MissionResult missionResult, int eventSEQ, bool firstSSR, UserHeroGachaGaugeInfo userHeroGachaGaugeInfo, bool isThirdGamble, UserBingoGachaEventInfo userBingoGachaEventInfo, PaybackEventResultInfo paybackEventresultInfo, List<UserPackageMissionInfo> userPackageMissionInfoList, UserADViewInfo updateUserADViewInfo, PaybackEventResultInfo gamblePaybackEventResultInfo, List<UpgradeUserSkin> upgradeSkinList, UserEventGachaWishInfo userEventGachaWishInfo, UserGachaEventOnceInfo resultUserEventGachaOnceInfo, DailyFreeGambleInfoClientSend resultUserDailyFreeGachaInfo);

        public delegate bool CG_RequestItemGambleShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ItemGambleShopBuyInfo> buyInfoList, int remainResetSec);

        public delegate bool CG_RequestItemGambleShopBuyOKDelegate(HostID remote, RmiContext rmiContext, ItemGambleShopBuyInfo buyInfo, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> itemGambleResultInfoList, int itemGambleDisplayID, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo, WeaponAutoGrindResult autoGrindResult, List<QuestProgressInfo> questProgressInfoList, List<UserPlayCountEventInfo> userPlayCountEventInfoList);

        public delegate bool CG_RequestRandomShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceResultInfoList, ItemResultInfo getItemResultInfo, RandomshopSlotInfo buySlotInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestRandomShopRefreshOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceResultInfoList, List<RandomshopSlotInfo> RandomShopSlotInfoList, byte resetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo);

        public delegate bool CG_RequestRandomShopInfoOKDelegate(HostID remote, RmiContext rmiContext, int basepointID, List<RandomshopSlotInfo> RandomShopSlotInfoList, byte resetCount);

        public delegate bool CG_RequestBasePointShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, byte resetCount);

        public delegate bool CG_RequestBasePointShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceResultInfoList, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> shopBuyInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestBasePointShopResetOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> itemResultInfoList, byte resetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo);

        public delegate bool CG_RequestArenaRealTimePvpShopInfoOKDelegate(HostID remote, RmiContext rmiContext, int remainSec, List<ShopBuyInfo> arenaRealTimePvpShopBuyInfoList, UserPvpShopGradeInfo userPvpShopGradeInfo, byte resetCount);

        public delegate bool CG_RequestArenaRealTimePvpShopBuyOKDelegate(HostID remote, RmiContext rmiContext, ItemResultInfo priceResultItemInfo, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> arenaRealTimePvpShopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestArenaRealTimePvpShopResetOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> itemResultInfoList, byte resetCount, PaybackEventResultInfo paybackEventresultInfo, UserADViewInfo updateUserADViewInfo);

        public delegate bool CG_RequestCoinShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> coinShopBuyInfoList, List<ShopBuyInfo> coinShopEventBuyInfoList);

        public delegate bool CG_RequestCoinShopBuyOKDelegate(HostID remote, RmiContext rmiContext, int shopID, ShopBuyInfo buyInfo, List<ItemResultInfo> useItemResultInfoList, ItemResultInfo getItemResultInfo, ApRewardInfo apRewardInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestCostumeShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, List<ShopTimeItemInfo> shopTimeItemInfoList);

        public delegate bool CG_RequestCostumeShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestCommonItemSellOKDelegate(HostID remote, RmiContext rmiContext, ItemResultInfo getItemResultInfo, List<ItemResultInfo> itemResultInfoList, MissionResult missionResult);

        public delegate bool CG_RequestCommonItemRemoveOKDelegate(HostID remote, RmiContext rmiContext, ItemResultInfo itemResultInfo);

        public delegate bool CG_RequestPackageShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<UserPackageInfo> userPackageInfoList, DateTime nowServerTime);

        public delegate bool CG_RequestGambleShopInfoOKDelegate(HostID remote, RmiContext rmiContext, GambleShopInfo gambleShopInfo, GambleTimeSwitchLobbyInfo gambleTimeSwitchLobbyInfo);

        public delegate bool CG_RequestADRouletteRewardOKDelegate(HostID remote, RmiContext rmiContext, ItemResultInfo getItemResultInfo, MissionResult missionResult, UserADViewInfo updateUserADViewInfo);

        public delegate bool CG_RequestGambleGaugeRewardOKDelegate(HostID remote, RmiContext rmiContext, UserHeroGachaGaugeInfo userHeroGachaGaugeInfo, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, List<UpgradeUserSkin> upgradeSkinList);

        public delegate bool CG_RequestArenaSmashShopInfoOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashShopInfo arenaSmashShopInfo, List<ShopBuyInfo> shopBuyInfoList);

        public delegate bool CG_RequestArenaSmashShopBuyOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashShopInfo arenaSmashShopInfo, List<ItemResultInfo> priceResultInfoList, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> shopBuyInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestArenaSmashShopRewardOKDelegate(HostID remote, RmiContext rmiContext, byte shopRewardID, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult);

        public delegate bool CG_RequestArenaSmashShopResetOKDelegate(HostID remote, RmiContext rmiContext, ArenaSmashShopInfo arenaSmashShopInfo);

        public delegate bool CG_RequestEvolutionExchangeOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> buyItemResultInfo, List<ItemResultInfo> priceReslutInfoList);

        public delegate bool CG_RequestRandomShopVisitRewardOKDelegate(HostID remote, RmiContext rmiContext, int basepointID, ItemResultInfo useItemResultInfo);

        public delegate bool CG_RequestRandomShopScheduleInfoOKDelegate(HostID remote, RmiContext rmiContext, LobbyRandomShopInfo lobbyRandomShopInfo);

        public delegate bool CG_RequestPackageBuyOKDelegate(HostID remote, RmiContext rmiContext, int shopMoneyID, List<UserPackageInfo> userPackageInfoList, List<ItemResultInfo> getItemResultInfoList, List<UserDiaBuyEventInfo> userDiaBuyEventInfoList, List<ClientSeasonPassRankRewardInfo> seasonPassClientSendList, List<UserPackageMissionInfo> userPackageMissionInfoList, int firstDiaBuyItemID, UserBuffInfo userBuffInfo);

        public delegate bool CG_RequestBuyDiaOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> getItemResultInfoList);

        public delegate bool CG_RequestBuyGoldOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult);

        public delegate bool CG_RequestBuyStaminaOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, APInfo apInfo, MissionResult missionResult);

        public delegate bool CG_RequestCostumeShopPackageBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, List<ShopBuyInfo> shopBuyInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestFinalBossShopInfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendFinalBossSeasonShopInfo clientSendFinalBossSeasonShopInfo, List<ItemResultInfo> remoteItemResultInfoList);

        public delegate bool CG_RequestFinalBossShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, FinalBossSeasonShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestBingoGambleShopInfoOKDelegate(HostID remote, RmiContext rmiContext, UserBingoGachaEventInfo userBingoGachaEventInfo);

        public delegate bool CG_RequestBingoGambleShopResetOKDelegate(HostID remote, RmiContext rmiContext, UserBingoGachaEventInfo userBingoGachaEventInfo, List<ItemResultInfo> useItemResultinfoList);

        public delegate bool CG_RequestBingoGambleShopRewardOKDelegate(HostID remote, RmiContext rmiContext, UserBingoGachaEventInfo userBingoGachaEventInfo, List<ItemResultInfo> itemResultInfoList, MissionResult missionResult);

        public delegate bool CG_RequestDiaShopPackageBuyOKDelegate(HostID remote, RmiContext rmiContext, int productItemID, List<UserPackageInfo> userPackageInfoList, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestGambleChoiceShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> itemResultInfoList, int gambleType, int gambleEventSEQ, UserBingoGachaEventInfo userBingoGachaEventInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<UpgradeUserSkin> upgradeSkinResultInfoList);

        public delegate bool CG_RequestFreePackageRewardOKDelegate(HostID remote, RmiContext rmiContext, long freePackageReward, List<ItemResultInfo> getItemResultInfoList, MissionResult missionResult);

        public delegate bool CG_RequestPackageMissionCloseOKDelegate(HostID remote, RmiContext rmiContext, List<UserPackageMissionInfo> userPackageMissionInfoList);

        public delegate bool CG_RequestStepupGambleShopBuyOKDelegate(HostID remote, RmiContext rmiContext, UserStepupGachaEventInfo stepupInfo, List<ItemResultInfo> priceItemResultInfoList, List<ItemResultInfo> gambleResultInfoList, ItemResultInfo gambleRewardResultInfo, List<ItemResultInfo> bonusResultInfoList, MissionResult missionResult, UserBingoGachaEventInfo userBingoGachaEventInfo, PaybackEventResultInfo paybackEventresultInfo, PaybackEventResultInfo gamblePaybackEventResultInfo, List<UpgradeUserSkin> upgradeSkinList);

        public delegate bool CG_RequestStepupGambleMileageRewardOKDelegate(HostID remote, RmiContext rmiContext, UserStepupGachaEventInfo stepupInfo, List<ItemResultInfo> rewardItemInfoList, MissionResult missionResult, List<UpgradeUserSkin> upgradeSkinList);

        public delegate bool CG_RequestLobbyHousingShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList);

        public delegate bool CG_RequestLobbyHousingShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestYggdrasilTowerShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, int remainResetTimeSec);

        public delegate bool CG_RequestYggdrasilTowerShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestEventCoinShopBuyOKDelegate(HostID remote, RmiContext rmiContext, int shopID, ShopBuyInfo buyInfo, List<ItemResultInfo> useItemResultInfoList, ItemResultInfo getItemResultInfo, ApRewardInfo apRewardInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestEventMazeSeasonShopInfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendEventMazeSeasonShopInfo clientSendEventMazeSeasonShopInfo, List<ItemResultInfo> itemResultInfoList);

        public delegate bool CG_RequestEventMazeSeasonShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, EventMazeSeasonShopBuyInfo shopBuyInfo, int seasonShopBuyPoint, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestHeroLeagueSeasonShopInfoOKDelegate(HostID remote, RmiContext rmiContext, ClientSendHeroLeagueSeasonShopInfo clientSendHeroLeagueSeasonShopInfo);

        public delegate bool CG_RequestHeroLeagueSeasonShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, HeroLeagueSeasonShopBuyInfo shopBuyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestCreatureColosseumShopInfoOKDelegate(HostID remote, RmiContext rmiContext, List<ShopBuyInfo> shopBuyInfoList, CreatureNestColosseumSeasonInfo seasonInfo);

        public delegate bool CG_RequestCreatureColosseumShopBuyOKDelegate(HostID remote, RmiContext rmiContext, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> getItemResultInfoList, ShopBuyInfo buyInfo, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);
    }
}