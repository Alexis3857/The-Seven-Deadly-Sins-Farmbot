using Nettention.Proud;

namespace SevenDSGameS2C_Weapon
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
                    case Common.CG_RequestWeaponEquipOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponEquipOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponUnEquipOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponUnEquipOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponSellOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponSellOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponGrindOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponGrindOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponUpgradeOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponUpgradeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponUpgradeRetryOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponUpgradeRetryOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponEvolutionOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponEvolutionOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponEvolutionRetryOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponEvolutionRetryOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponOptionEnhanceOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponOptionEnhanceOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponLockOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponLockOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponUnLockOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponUnLockOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponEquipExchangeOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponEquipExchangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponEquipExchangeAllOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponEquipExchangeAllOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponEquipRecommandOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponEquipRecommandOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponCarveOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponCarveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponCarveRemoveOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponCarveRemoveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponUpgradeAndEvolutionOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponUpgradeAndEvolutionOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CG_RequestWeaponAutoOptionChangeOK:
                        this.ProcessReceivedMessage_CG_RequestWeaponAutoOptionChangeOK(readOnlyMessage, pa, hostTag, remoteHostID);
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

        private void ProcessReceivedMessage_CG_RequestWeaponEquipOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserSkin skinInfo;
            CommonPacket.Marshaler.Read(__msg, out skinInfo);
            UserWeapon weaponInfo;
            CommonPacket.Marshaler.Read(__msg, out weaponInfo);
            int oldWeaponSerial;
            CommonPacket.Marshaler.Read(__msg, out oldWeaponSerial);
            bool isDeleteOldWeapon;
            CommonPacket.Marshaler.Read(__msg, out isDeleteOldWeapon);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponEquipOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipOK,
                    rmiName = RmiName_CG_RequestWeaponEquipOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponEquipOK(remote, rmiContext, skinInfo, weaponInfo, oldWeaponSerial, isDeleteOldWeapon, useItemResultInfoList, missionResult, questProgressInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponEquipOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipOK,
                    rmiName = RmiName_CG_RequestWeaponEquipOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponUnEquipOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserSkin skinInfo;
            CommonPacket.Marshaler.Read(__msg, out skinInfo);
            UserWeapon weaponInfo;
            CommonPacket.Marshaler.Read(__msg, out weaponInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponUnEquipOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUnEquipOK,
                    rmiName = RmiName_CG_RequestWeaponUnEquipOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponUnEquipOK(remote, rmiContext, skinInfo, weaponInfo, useItemResultInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponUnEquipOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUnEquipOK,
                    rmiName = RmiName_CG_RequestWeaponUnEquipOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponSellOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<int> selectWeaponSerialList;
            CommonPacket.Marshaler.Read(__msg, out selectWeaponSerialList);
            ItemResultInfo getItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponSellOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponSellOK,
                    rmiName = RmiName_CG_RequestWeaponSellOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponSellOK(remote, rmiContext, selectWeaponSerialList, getItemResultInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponSellOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponSellOK,
                    rmiName = RmiName_CG_RequestWeaponSellOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponGrindOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<int> selectWeaponSerialList;
            CommonPacket.Marshaler.Read(__msg, out selectWeaponSerialList);
            List<ItemResultInfo> getItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out getItemResultInfoList);
            List<SuccessInfo> successInfoList;
            CommonPacket.Marshaler.Read(__msg, out successInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponGrindOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponGrindOK,
                    rmiName = RmiName_CG_RequestWeaponGrindOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponGrindOK(remote, rmiContext, selectWeaponSerialList, getItemResultInfoList, successInfoList, missionResult, questProgressInfoList, userPlayCountEventInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponGrindOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponGrindOK,
                    rmiName = RmiName_CG_RequestWeaponGrindOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponUpgradeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            WeaponUpgradeFailGaugeInfo failGaugeInfo;
            CommonPacket.Marshaler.Read(__msg, out failGaugeInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponUpgradeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUpgradeOK,
                    rmiName = RmiName_CG_RequestWeaponUpgradeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponUpgradeOK(remote, rmiContext, userWeaponInfo, useItemResultInfoList, missionResult, questProgressInfoList, failGaugeInfo, paybackEventresultInfo, userPlayCountEventInfoList, userPackageMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponUpgradeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUpgradeOK,
                    rmiName = RmiName_CG_RequestWeaponUpgradeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponUpgradeRetryOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponUpgradeRetryOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUpgradeRetryOK,
                    rmiName = RmiName_CG_RequestWeaponUpgradeRetryOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponUpgradeRetryOK(remote, rmiContext, userWeaponInfo, useItemResultInfoList, paybackEventresultInfo, missionResult))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponUpgradeRetryOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUpgradeRetryOK,
                    rmiName = RmiName_CG_RequestWeaponUpgradeRetryOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponEvolutionOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeapon;
            CommonPacket.Marshaler.Read(__msg, out userWeapon);
            List<ItemResultInfo> itemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out itemResultInfoList);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            List<ItemResultInfo> bonusItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out bonusItemResultInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponEvolutionOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEvolutionOK,
                    rmiName = RmiName_CG_RequestWeaponEvolutionOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponEvolutionOK(remote, rmiContext, userWeapon, itemResultInfoList, questProgressInfoList, missionResult, paybackEventresultInfo, userPlayCountEventInfoList, bonusItemResultInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponEvolutionOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEvolutionOK,
                    rmiName = RmiName_CG_RequestWeaponEvolutionOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponEvolutionRetryOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponEvolutionRetryOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEvolutionRetryOK,
                    rmiName = RmiName_CG_RequestWeaponEvolutionRetryOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponEvolutionRetryOK(remote, rmiContext, userWeaponInfo, useItemResultInfoList, missionResult, paybackEventresultInfo, questProgressInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponEvolutionRetryOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEvolutionRetryOK,
                    rmiName = RmiName_CG_RequestWeaponEvolutionRetryOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponOptionEnhanceOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            WeaponOptionSuccessType successType;
            CommonPacket.Marshaler.Read(__msg, out successType);
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponOptionEnhanceOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponOptionEnhanceOK,
                    rmiName = RmiName_CG_RequestWeaponOptionEnhanceOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponOptionEnhanceOK(remote, rmiContext, successType, userWeaponInfo, useItemResultInfoList, paybackEventresultInfo, missionResult, questProgressInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponOptionEnhanceOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponOptionEnhanceOK,
                    rmiName = RmiName_CG_RequestWeaponOptionEnhanceOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponLockOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponLockOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponLockOK,
                    rmiName = RmiName_CG_RequestWeaponLockOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponLockOK(remote, rmiContext, userWeaponInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponLockOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponLockOK,
                    rmiName = RmiName_CG_RequestWeaponLockOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponUnLockOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponUnLockOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUnLockOK,
                    rmiName = RmiName_CG_RequestWeaponUnLockOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponUnLockOK(remote, rmiContext, userWeaponInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponUnLockOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUnLockOK,
                    rmiName = RmiName_CG_RequestWeaponUnLockOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponEquipExchangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserSkin targetSkin;
            CommonPacket.Marshaler.Read(__msg, out targetSkin);
            UserWeapon targetUserWeapon;
            CommonPacket.Marshaler.Read(__msg, out targetUserWeapon);
            UserSkin pickedSkin;
            CommonPacket.Marshaler.Read(__msg, out pickedSkin);
            bool isDelete;
            CommonPacket.Marshaler.Read(__msg, out isDelete);
            int oldWeaponSerial;
            CommonPacket.Marshaler.Read(__msg, out oldWeaponSerial);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> sendQuestProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out sendQuestProgressInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponEquipExchangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipExchangeOK,
                    rmiName = RmiName_CG_RequestWeaponEquipExchangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponEquipExchangeOK(remote, rmiContext, targetSkin, targetUserWeapon, pickedSkin, isDelete, oldWeaponSerial, useItemResultInfoList, missionResult, sendQuestProgressInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponEquipExchangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipExchangeOK,
                    rmiName = RmiName_CG_RequestWeaponEquipExchangeOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponEquipExchangeAllOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserSkin targetSkin;
            CommonPacket.Marshaler.Read(__msg, out targetSkin);
            UserSkin srcSkin;
            CommonPacket.Marshaler.Read(__msg, out srcSkin);
            List<UserWeapon> unequipedWeaoponList;
            CommonPacket.Marshaler.Read(__msg, out unequipedWeaoponList);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> sendQuestProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out sendQuestProgressInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponEquipExchangeAllOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipExchangeAllOK,
                    rmiName = RmiName_CG_RequestWeaponEquipExchangeAllOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponEquipExchangeAllOK(remote, rmiContext, targetSkin, srcSkin, unequipedWeaoponList, useItemResultInfoList, missionResult, sendQuestProgressInfoList, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponEquipExchangeAllOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipExchangeAllOK,
                    rmiName = RmiName_CG_RequestWeaponEquipExchangeAllOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponEquipRecommandOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserSkin targetSkin;
            CommonPacket.Marshaler.Read(__msg, out targetSkin);
            List<UserWeapon> userWeaponList;
            CommonPacket.Marshaler.Read(__msg, out userWeaponList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponEquipRecommandOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipRecommandOK,
                    rmiName = RmiName_CG_RequestWeaponEquipRecommandOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponEquipRecommandOK(remote, rmiContext, targetSkin, userWeaponList, missionResult, questProgressInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponEquipRecommandOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponEquipRecommandOK,
                    rmiName = RmiName_CG_RequestWeaponEquipRecommandOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponCarveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeapon;
            CommonPacket.Marshaler.Read(__msg, out userWeapon);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponCarveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponCarveOK,
                    rmiName = RmiName_CG_RequestWeaponCarveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponCarveOK(remote, rmiContext, userWeapon, useItemResultInfoList, questProgressInfoList, missionResult, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponCarveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponCarveOK,
                    rmiName = RmiName_CG_RequestWeaponCarveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponCarveRemoveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeapon;
            CommonPacket.Marshaler.Read(__msg, out userWeapon);
            ItemResultInfo useItemResultInfo;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfo);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponCarveRemoveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponCarveRemoveOK,
                    rmiName = RmiName_CG_RequestWeaponCarveRemoveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponCarveRemoveOK(remote, rmiContext, userWeapon, useItemResultInfo, paybackEventresultInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponCarveRemoveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponCarveRemoveOK,
                    rmiName = RmiName_CG_RequestWeaponCarveRemoveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponUpgradeAndEvolutionOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            List<ItemResultInfo> bonusItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out bonusItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponUpgradeAndEvolutionOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUpgradeAndEvolutionOK,
                    rmiName = RmiName_CG_RequestWeaponUpgradeAndEvolutionOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponUpgradeAndEvolutionOK(remote, rmiContext, userWeaponInfo, useItemResultInfoList, bonusItemResultInfoList, missionResult, questProgressInfoList, paybackEventresultInfo, userPlayCountEventInfoList, userPackageMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponUpgradeAndEvolutionOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponUpgradeAndEvolutionOK,
                    rmiName = RmiName_CG_RequestWeaponUpgradeAndEvolutionOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CG_RequestWeaponAutoOptionChangeOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            UserWeapon userWeaponInfo;
            CommonPacket.Marshaler.Read(__msg, out userWeaponInfo);
            List<ItemResultInfo> useItemResultInfoList;
            CommonPacket.Marshaler.Read(__msg, out useItemResultInfoList);
            MissionResult missionResult;
            CommonPacket.Marshaler.Read(__msg, out missionResult);
            List<QuestProgressInfo> questProgressInfoList;
            CommonPacket.Marshaler.Read(__msg, out questProgressInfoList);
            PaybackEventResultInfo paybackEventresultInfo;
            CommonPacket.Marshaler.Read(__msg, out paybackEventresultInfo);
            List<UserPlayCountEventInfo> userPlayCountEventInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPlayCountEventInfoList);
            List<UserPackageMissionInfo> userPackageMissionInfoList;
            CommonPacket.Marshaler.Read(__msg, out userPackageMissionInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CG_RequestWeaponAutoOptionChangeOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponAutoOptionChangeOK,
                    rmiName = RmiName_CG_RequestWeaponAutoOptionChangeOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CG_RequestWeaponAutoOptionChangeOK(remote, rmiContext, userWeaponInfo, useItemResultInfoList, missionResult, questProgressInfoList, paybackEventresultInfo, userPlayCountEventInfoList, userPackageMissionInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CG_RequestWeaponAutoOptionChangeOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CG_RequestWeaponAutoOptionChangeOK,
                    rmiName = RmiName_CG_RequestWeaponAutoOptionChangeOK,
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

        public Stub.CG_RequestWeaponEquipOKDelegate CG_RequestWeaponEquipOK = (HostID remote, RmiContext rmiContext, UserSkin skinInfo, UserWeapon weaponInfo, int oldWeaponSerial, bool isDeleteOldWeapon, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeaponUnEquipOKDelegate CG_RequestWeaponUnEquipOK = (HostID remote, RmiContext rmiContext, UserSkin skinInfo, UserWeapon weaponInfo, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeaponSellOKDelegate CG_RequestWeaponSellOK = (HostID remote, RmiContext rmiContext, List<int> selectWeaponSerialList, ItemResultInfo getItemResultInfo, MissionResult missionResult) => false;

        public Stub.CG_RequestWeaponGrindOKDelegate CG_RequestWeaponGrindOK = (HostID remote, RmiContext rmiContext, List<int> selectWeaponSerialList, List<ItemResultInfo> getItemResultInfoList, List<SuccessInfo> successInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, List<UserPlayCountEventInfo> userPlayCountEventInfoList) => false;

        public Stub.CG_RequestWeaponUpgradeOKDelegate CG_RequestWeaponUpgradeOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, WeaponUpgradeFailGaugeInfo failGaugeInfo, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList) => false;

        public Stub.CG_RequestWeaponUpgradeRetryOKDelegate CG_RequestWeaponUpgradeRetryOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo, MissionResult missionResult) => false;

        public Stub.CG_RequestWeaponEvolutionOKDelegate CG_RequestWeaponEvolutionOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeapon, List<ItemResultInfo> itemResultInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<ItemResultInfo> bonusItemResultInfoList) => false;

        public Stub.CG_RequestWeaponEvolutionRetryOKDelegate CG_RequestWeaponEvolutionRetryOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<QuestProgressInfo> questProgressInfoList) => false;

        public Stub.CG_RequestWeaponOptionEnhanceOKDelegate CG_RequestWeaponOptionEnhanceOK = (HostID remote, RmiContext rmiContext, WeaponOptionSuccessType successType, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList) => false;

        public Stub.CG_RequestWeaponLockOKDelegate CG_RequestWeaponLockOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo) => false;

        public Stub.CG_RequestWeaponUnLockOKDelegate CG_RequestWeaponUnLockOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo) => false;

        public Stub.CG_RequestWeaponEquipExchangeOKDelegate CG_RequestWeaponEquipExchangeOK = (HostID remote, RmiContext rmiContext, UserSkin targetSkin, UserWeapon targetUserWeapon, UserSkin pickedSkin, bool isDelete, int oldWeaponSerial, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> sendQuestProgressInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeaponEquipExchangeAllOKDelegate CG_RequestWeaponEquipExchangeAllOK = (HostID remote, RmiContext rmiContext, UserSkin targetSkin, UserSkin srcSkin, List<UserWeapon> unequipedWeaoponList, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> sendQuestProgressInfoList, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeaponEquipRecommandOKDelegate CG_RequestWeaponEquipRecommandOK = (HostID remote, RmiContext rmiContext, UserSkin targetSkin, List<UserWeapon> userWeaponList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList) => false;

        public Stub.CG_RequestWeaponCarveOKDelegate CG_RequestWeaponCarveOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeapon, List<ItemResultInfo> useItemResultInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeaponCarveRemoveOKDelegate CG_RequestWeaponCarveRemoveOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeapon, ItemResultInfo useItemResultInfo, PaybackEventResultInfo paybackEventresultInfo) => false;

        public Stub.CG_RequestWeaponUpgradeAndEvolutionOKDelegate CG_RequestWeaponUpgradeAndEvolutionOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> bonusItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList) => false;

        public Stub.CG_RequestWeaponAutoOptionChangeOKDelegate CG_RequestWeaponAutoOptionChangeOK = (HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList) => false;

        public const string RmiName_CG_RequestWeaponEquipOK = "CG_RequestWeaponEquipOK";

        public const string RmiName_CG_RequestWeaponUnEquipOK = "CG_RequestWeaponUnEquipOK";

        public const string RmiName_CG_RequestWeaponSellOK = "CG_RequestWeaponSellOK";

        public const string RmiName_CG_RequestWeaponGrindOK = "CG_RequestWeaponGrindOK";

        public const string RmiName_CG_RequestWeaponUpgradeOK = "CG_RequestWeaponUpgradeOK";

        public const string RmiName_CG_RequestWeaponUpgradeRetryOK = "CG_RequestWeaponUpgradeRetryOK";

        public const string RmiName_CG_RequestWeaponEvolutionOK = "CG_RequestWeaponEvolutionOK";

        public const string RmiName_CG_RequestWeaponEvolutionRetryOK = "CG_RequestWeaponEvolutionRetryOK";

        public const string RmiName_CG_RequestWeaponOptionEnhanceOK = "CG_RequestWeaponOptionEnhanceOK";

        public const string RmiName_CG_RequestWeaponLockOK = "CG_RequestWeaponLockOK";

        public const string RmiName_CG_RequestWeaponUnLockOK = "CG_RequestWeaponUnLockOK";

        public const string RmiName_CG_RequestWeaponEquipExchangeOK = "CG_RequestWeaponEquipExchangeOK";

        public const string RmiName_CG_RequestWeaponEquipExchangeAllOK = "CG_RequestWeaponEquipExchangeAllOK";

        public const string RmiName_CG_RequestWeaponEquipRecommandOK = "CG_RequestWeaponEquipRecommandOK";

        public const string RmiName_CG_RequestWeaponCarveOK = "CG_RequestWeaponCarveOK";

        public const string RmiName_CG_RequestWeaponCarveRemoveOK = "CG_RequestWeaponCarveRemoveOK";

        public const string RmiName_CG_RequestWeaponUpgradeAndEvolutionOK = "CG_RequestWeaponUpgradeAndEvolutionOK";

        public const string RmiName_CG_RequestWeaponAutoOptionChangeOK = "CG_RequestWeaponAutoOptionChangeOK";

        public const string RmiName_First = "CG_RequestWeaponEquipOK";

        public delegate bool CG_RequestWeaponEquipOKDelegate(HostID remote, RmiContext rmiContext, UserSkin skinInfo, UserWeapon weaponInfo, int oldWeaponSerial, bool isDeleteOldWeapon, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeaponUnEquipOKDelegate(HostID remote, RmiContext rmiContext, UserSkin skinInfo, UserWeapon weaponInfo, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeaponSellOKDelegate(HostID remote, RmiContext rmiContext, List<int> selectWeaponSerialList, ItemResultInfo getItemResultInfo, MissionResult missionResult);

        public delegate bool CG_RequestWeaponGrindOKDelegate(HostID remote, RmiContext rmiContext, List<int> selectWeaponSerialList, List<ItemResultInfo> getItemResultInfoList, List<SuccessInfo> successInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, List<UserPlayCountEventInfo> userPlayCountEventInfoList);

        public delegate bool CG_RequestWeaponUpgradeOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, WeaponUpgradeFailGaugeInfo failGaugeInfo, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList);

        public delegate bool CG_RequestWeaponUpgradeRetryOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo, MissionResult missionResult);

        public delegate bool CG_RequestWeaponEvolutionOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeapon, List<ItemResultInfo> itemResultInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<ItemResultInfo> bonusItemResultInfoList);

        public delegate bool CG_RequestWeaponEvolutionRetryOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo, List<QuestProgressInfo> questProgressInfoList);

        public delegate bool CG_RequestWeaponOptionEnhanceOKDelegate(HostID remote, RmiContext rmiContext, WeaponOptionSuccessType successType, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, PaybackEventResultInfo paybackEventresultInfo, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList);

        public delegate bool CG_RequestWeaponLockOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo);

        public delegate bool CG_RequestWeaponUnLockOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo);

        public delegate bool CG_RequestWeaponEquipExchangeOKDelegate(HostID remote, RmiContext rmiContext, UserSkin targetSkin, UserWeapon targetUserWeapon, UserSkin pickedSkin, bool isDelete, int oldWeaponSerial, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> sendQuestProgressInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeaponEquipExchangeAllOKDelegate(HostID remote, RmiContext rmiContext, UserSkin targetSkin, UserSkin srcSkin, List<UserWeapon> unequipedWeaoponList, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> sendQuestProgressInfoList, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeaponEquipRecommandOKDelegate(HostID remote, RmiContext rmiContext, UserSkin targetSkin, List<UserWeapon> userWeaponList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList);

        public delegate bool CG_RequestWeaponCarveOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeapon, List<ItemResultInfo> useItemResultInfoList, List<QuestProgressInfo> questProgressInfoList, MissionResult missionResult, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeaponCarveRemoveOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeapon, ItemResultInfo useItemResultInfo, PaybackEventResultInfo paybackEventresultInfo);

        public delegate bool CG_RequestWeaponUpgradeAndEvolutionOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, List<ItemResultInfo> bonusItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList);

        public delegate bool CG_RequestWeaponAutoOptionChangeOKDelegate(HostID remote, RmiContext rmiContext, UserWeapon userWeaponInfo, List<ItemResultInfo> useItemResultInfoList, MissionResult missionResult, List<QuestProgressInfo> questProgressInfoList, PaybackEventResultInfo paybackEventresultInfo, List<UserPlayCountEventInfo> userPlayCountEventInfoList, List<UserPackageMissionInfo> userPackageMissionInfoList);
    }
}