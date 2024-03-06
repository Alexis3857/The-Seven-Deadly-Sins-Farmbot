using Nettention.Proud;

namespace SevenDSWestC2S
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
                    case Common.CW_RequestJoinChannel:
                        this.ProcessReceivedMessage_CW_RequestJoinChannel(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestWestSideMove:
                        this.ProcessReceivedMessage_CW_RequestWestSideMove(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestChangeStatus:
                        this.ProcessReceivedMessage_CW_RequestChangeStatus(readOnlyMessage, pa, hostTag, remoteHostID);
                        break;
                    case Common.CW_RequestChannelUserInfo:
                        this.ProcessReceivedMessage_CW_RequestChannelUserInfo(readOnlyMessage, pa, hostTag, remoteHostID);
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

        private void ProcessReceivedMessage_CW_RequestJoinChannel(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            WestServerLoginInfo westServerLoginInfo;
            CommonPacket.Marshaler.Read(__msg, out westServerLoginInfo);
            WestSidePoint westSidePoint;
            CommonPacket.Marshaler.Read(__msg, out westSidePoint);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestJoinChannel);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestJoinChannel,
                    rmiName = RmiName_CW_RequestJoinChannel,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestJoinChannel(remote, rmiContext, westServerLoginInfo, westSidePoint))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestJoinChannel);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestJoinChannel,
                    rmiName = RmiName_CW_RequestJoinChannel,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestWestSideMove(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            WestSidePoint point;
            CommonPacket.Marshaler.Read(__msg, out point);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestWestSideMove);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestWestSideMove,
                    rmiName = RmiName_CW_RequestWestSideMove,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestWestSideMove(remote, rmiContext, point))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestWestSideMove);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestWestSideMove,
                    rmiName = RmiName_CW_RequestWestSideMove,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestChangeStatus(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestChangeStatus);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestChangeStatus,
                    rmiName = RmiName_CW_RequestChangeStatus,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestChangeStatus(remote, rmiContext))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestChangeStatus);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestChangeStatus,
                    rmiName = RmiName_CW_RequestChangeStatus,
                    hostID = remote,
                    hostTag = hostTag,
                    elapsedTime = PreciseCurrentTime.GetTimeMs() - timeMs
                };
                this.AfterRmiInvocation(afterRmiSummary);
            }
        }

        private void ProcessReceivedMessage_CW_RequestChannelUserInfo(Message __msg, ReceivedMessage pa, object hostTag, HostID remote)
        {
            RmiContext rmiContext = new RmiContext()
            {
                sentFrom = pa.RemoteHostID,
                relayed = pa.IsRelayed,
                hostTag = hostTag,
                encryptMode = pa.EncryptMode,
                compressMode = pa.CompressMode
            };
            long targetUSN;
            CommonPacket.Marshaler.Read(__msg, out targetUSN);
            base.core.PostCheckReadMessage(__msg, RmiName_CW_RequestChannelUserInfo);
            if (this.enableStubProfiling)
            {
                BeforeRmiSummary beforeRmiSummary = new BeforeRmiSummary()
                {
                    rmiID = Common.CW_RequestChannelUserInfo,
                    rmiName = RmiName_CW_RequestChannelUserInfo,
                    hostID = remote,
                    hostTag = hostTag
                };
                this.BeforeRmiInvocation(beforeRmiSummary);
            }
            long timeMs = PreciseCurrentTime.GetTimeMs();
            if (!this.CW_RequestChannelUserInfo(remote, rmiContext, targetUSN))
                base.core.ShowNotImplementedRmiWarning(RmiName_CW_RequestChannelUserInfo);
            if (this.enableStubProfiling)
            {
                AfterRmiSummary afterRmiSummary = new AfterRmiSummary()
                {
                    rmiID = Common.CW_RequestChannelUserInfo,
                    rmiName = RmiName_CW_RequestChannelUserInfo,
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

        public Stub.CW_RequestJoinChannelDelegate CW_RequestJoinChannel = (HostID remote, RmiContext rmiContext, WestServerLoginInfo westServerLoginInfo, WestSidePoint westSidePoint) => false;

        public Stub.CW_RequestWestSideMoveDelegate CW_RequestWestSideMove = (HostID remote, RmiContext rmiContext, WestSidePoint point) => false;

        public Stub.CW_RequestChangeStatusDelegate CW_RequestChangeStatus = (HostID remote, RmiContext rmiContext) => false;

        public Stub.CW_RequestChannelUserInfoDelegate CW_RequestChannelUserInfo = (HostID remote, RmiContext rmiContext, long targetUSN) => false;

        public const string RmiName_CW_RequestJoinChannel = "CW_RequestJoinChannel";

        public const string RmiName_CW_RequestWestSideMove = "CW_RequestWestSideMove";

        public const string RmiName_CW_RequestChangeStatus = "CW_RequestChangeStatus";

        public const string RmiName_CW_RequestChannelUserInfo = "CW_RequestChannelUserInfo";

        public const string RmiName_First = "CW_RequestJoinChannel";

        public delegate bool CW_RequestJoinChannelDelegate(HostID remote, RmiContext rmiContext, WestServerLoginInfo westServerLoginInfo, WestSidePoint westSidePoint);

        public delegate bool CW_RequestWestSideMoveDelegate(HostID remote, RmiContext rmiContext, WestSidePoint point);

        public delegate bool CW_RequestChangeStatusDelegate(HostID remote, RmiContext rmiContext);

        public delegate bool CW_RequestChannelUserInfoDelegate(HostID remote, RmiContext rmiContext, long targetUSN);
    }
}