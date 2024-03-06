using Nettention.Proud;

namespace SevenDSWestS2C
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
                    case Common.CW_CommonCancel:
                        this.ProcessReceivedMessage_CW_CommonCancel(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestForceLogoutOK:
                        this.ProcessReceivedMessage_CW_RequestForceLogoutOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestJoinChannelOK:
                        this.ProcessReceivedMessage_CW_RequestJoinChannelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestWestSideMoveOK:
                        this.ProcessReceivedMessage_CW_RequestWestSideMoveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestChangeStatusOK:
                        this.ProcessReceivedMessage_CW_RequestChangeStatusOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestChannelUserInfoOK:
                        this.ProcessReceivedMessage_CW_RequestChannelUserInfoOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_BroadcastingJoinChannelOK:
                        this.ProcessReceivedMessage_CW_BroadcastingJoinChannelOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_BroadcastingWestSideMoveOK:
                        this.ProcessReceivedMessage_CW_BroadcastingWestSideMoveOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_BroadcastingChangeStatusOK:
                        this.ProcessReceivedMessage_CW_BroadcastingChangeStatusOK(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_BroadcastingLeaveUserOK:
                        this.ProcessReceivedMessage_CW_BroadcastingLeaveUserOK(readOnlyMessage, pa, hostTag, remoteHostID);
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

        private void ProcessReceivedMessage_CW_CommonCancel(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            RmiID packetID;
            CommonPacket.Marshaler.Read(__msg, out packetID);
            string packetName;
            CommonPacket.Marshaler.Read(__msg, out packetName);
            PacketError error;
            CommonPacket.Marshaler.Read(__msg, out error);
            InvalidRequestType invalidRequesttype;
            CommonPacket.Marshaler.Read(__msg, out invalidRequesttype);
            bool isSimpleMessageBox;
            CommonPacket.Marshaler.Read(__msg, out isSimpleMessageBox);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_CommonCancel);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_CommonCancel,
                    rmiName = RmiName_CW_CommonCancel,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_CommonCancel(remote, rmiContext, packetID, packetName, error, invalidRequesttype, isSimpleMessageBox))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_CommonCancel);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_CommonCancel,
                    rmiName = RmiName_CW_CommonCancel,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestForceLogoutOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            PacketError error;
            CommonPacket.Marshaler.Read(__msg, out error);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestForceLogoutOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestForceLogoutOK,
                    rmiName = RmiName_CW_RequestForceLogoutOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestForceLogoutOK(remote, rmiContext, error))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestForceLogoutOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestForceLogoutOK,
                    rmiName = RmiName_CW_RequestForceLogoutOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestJoinChannelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            int channelID;
            CommonPacket.Marshaler.Read(__msg, out channelID);
            List<WestSideUserInfo> westSideUserInfoList;
            CommonPacket.Marshaler.Read(__msg, out westSideUserInfoList);
            string talkWestsidePrefix;
            CommonPacket.Marshaler.Read(__msg, out talkWestsidePrefix);
            WestRoomType joinRoomType;
            CommonPacket.Marshaler.Read(__msg, out joinRoomType);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestJoinChannelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestJoinChannelOK,
                    rmiName = RmiName_CW_RequestJoinChannelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestJoinChannelOK(remote, rmiContext, channelID, westSideUserInfoList, talkWestsidePrefix, joinRoomType))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestJoinChannelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestJoinChannelOK,
                    rmiName = RmiName_CW_RequestJoinChannelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestWestSideMoveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestWestSideMoveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestWestSideMoveOK,
                    rmiName = RmiName_CW_RequestWestSideMoveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestWestSideMoveOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestWestSideMoveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestWestSideMoveOK,
                    rmiName = RmiName_CW_RequestWestSideMoveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestChangeStatusOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestChangeStatusOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestChangeStatusOK,
                    rmiName = RmiName_CW_RequestChangeStatusOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestChangeStatusOK(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestChangeStatusOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestChangeStatusOK,
                    rmiName = RmiName_CW_RequestChangeStatusOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestChannelUserInfoOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            WestSideUserInfo westSideUserInfo;
            CommonPacket.Marshaler.Read(__msg, out westSideUserInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestChannelUserInfoOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestChannelUserInfoOK,
                    rmiName = RmiName_CW_RequestChannelUserInfoOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestChannelUserInfoOK(remote, rmiContext, westSideUserInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestChannelUserInfoOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestChannelUserInfoOK,
                    rmiName = RmiName_CW_RequestChannelUserInfoOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_BroadcastingJoinChannelOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            WestSideUserInfo westSideUserInfo;
            CommonPacket.Marshaler.Read(__msg, out westSideUserInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_BroadcastingJoinChannelOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingJoinChannelOK,
                    rmiName = RmiName_CW_BroadcastingJoinChannelOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_BroadcastingJoinChannelOK(remote, rmiContext, westSideUserInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_BroadcastingJoinChannelOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingJoinChannelOK,
                    rmiName = RmiName_CW_BroadcastingJoinChannelOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_BroadcastingWestSideMoveOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            List<WestSideMoveInfo> westSideMoveInfoList;
            CommonPacket.Marshaler.Read(__msg, out westSideMoveInfoList);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_BroadcastingWestSideMoveOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingWestSideMoveOK,
                    rmiName = RmiName_CW_BroadcastingWestSideMoveOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_BroadcastingWestSideMoveOK(remote, rmiContext, westSideMoveInfoList))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_BroadcastingWestSideMoveOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingWestSideMoveOK,
                    rmiName = RmiName_CW_BroadcastingWestSideMoveOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_BroadcastingChangeStatusOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            WestSideUserInfo westSideUserInfo;
            CommonPacket.Marshaler.Read(__msg, out westSideUserInfo);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_BroadcastingChangeStatusOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingChangeStatusOK,
                    rmiName = RmiName_CW_BroadcastingChangeStatusOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_BroadcastingChangeStatusOK(remote, rmiContext, westSideUserInfo))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_BroadcastingChangeStatusOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingChangeStatusOK,
                    rmiName = RmiName_CW_BroadcastingChangeStatusOK,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_BroadcastingLeaveUserOK(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long usn;
            CommonPacket.Marshaler.Read(__msg, out usn);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_BroadcastingLeaveUserOK);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingLeaveUserOK,
                    rmiName = RmiName_CW_BroadcastingLeaveUserOK,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_BroadcastingLeaveUserOK(remote, rmiContext, usn))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_BroadcastingLeaveUserOK);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_BroadcastingLeaveUserOK,
                    rmiName = RmiName_CW_BroadcastingLeaveUserOK,
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

        public Stub.CW_CommonCancelDelegate CW_CommonCancel = (HostID remote, RmiContext rmiContext, RmiID packetID, string packetName, PacketError error, InvalidRequestType invalidRequesttype, bool isSimpleMessageBox) => false;

        public Stub.CW_RequestForceLogoutOKDelegate CW_RequestForceLogoutOK = (HostID remote, RmiContext rmiContext, PacketError error) => false;

        public Stub.CW_RequestJoinChannelOKDelegate CW_RequestJoinChannelOK = (HostID remote, RmiContext rmiContext, int channelID, List<WestSideUserInfo> westSideUserInfoList, string talkWestsidePrefix, WestRoomType joinRoomType) => false;

        public Stub.CW_RequestWestSideMoveOKDelegate CW_RequestWestSideMoveOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CW_RequestChangeStatusOKDelegate CW_RequestChangeStatusOK = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CW_RequestChannelUserInfoOKDelegate CW_RequestChannelUserInfoOK = (HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo) => false;

        public Stub.CW_BroadcastingJoinChannelOKDelegate CW_BroadcastingJoinChannelOK = (HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo) => false;

        public Stub.CW_BroadcastingWestSideMoveOKDelegate CW_BroadcastingWestSideMoveOK = (HostID remote, RmiContext rmiContext, List<WestSideMoveInfo> westSideMoveInfoList) => false;

        public Stub.CW_BroadcastingChangeStatusOKDelegate CW_BroadcastingChangeStatusOK = (HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo) => false;

        public Stub.CW_BroadcastingLeaveUserOKDelegate CW_BroadcastingLeaveUserOK = (HostID remote, RmiContext rmiContext, long usn) => false;

        public const string RmiName_CW_CommonCancel = "CW_CommonCancel";

        public const string RmiName_CW_RequestForceLogoutOK = "CW_RequestForceLogoutOK";

        public const string RmiName_CW_RequestJoinChannelOK = "CW_RequestJoinChannelOK";

        public const string RmiName_CW_RequestWestSideMoveOK = "CW_RequestWestSideMoveOK";

        public const string RmiName_CW_RequestChangeStatusOK = "CW_RequestChangeStatusOK";

        public const string RmiName_CW_RequestChannelUserInfoOK = "CW_RequestChannelUserInfoOK";

        public const string RmiName_CW_BroadcastingJoinChannelOK = "CW_BroadcastingJoinChannelOK";

        public const string RmiName_CW_BroadcastingWestSideMoveOK = "CW_BroadcastingWestSideMoveOK";

        public const string RmiName_CW_BroadcastingChangeStatusOK = "CW_BroadcastingChangeStatusOK";

        public const string RmiName_CW_BroadcastingLeaveUserOK = "CW_BroadcastingLeaveUserOK";

        public const string RmiName_First = "CW_CommonCancel";

        public delegate bool CW_CommonCancelDelegate(HostID remote, RmiContext rmiContext, RmiID packetID, string packetName, PacketError error, InvalidRequestType invalidRequesttype, bool isSimpleMessageBox);

        public delegate bool CW_RequestForceLogoutOKDelegate(HostID remote, RmiContext rmiContext, PacketError error);

        public delegate bool CW_RequestJoinChannelOKDelegate(HostID remote, RmiContext rmiContext, int channelID, List<WestSideUserInfo> westSideUserInfoList, string talkWestsidePrefix, WestRoomType joinRoomType);

        public delegate bool CW_RequestWestSideMoveOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CW_RequestChangeStatusOKDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CW_RequestChannelUserInfoOKDelegate(HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo);

        public delegate bool CW_BroadcastingJoinChannelOKDelegate(HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo);

        public delegate bool CW_BroadcastingWestSideMoveOKDelegate(HostID remote, RmiContext rmiContext, List<WestSideMoveInfo> westSideMoveInfoList);

        public delegate bool CW_BroadcastingChangeStatusOKDelegate(HostID remote, RmiContext rmiContext, WestSideUserInfo westSideUserInfo);

        public delegate bool CW_BroadcastingLeaveUserOKDelegate(HostID remote, RmiContext rmiContext, long usn);
    }
}