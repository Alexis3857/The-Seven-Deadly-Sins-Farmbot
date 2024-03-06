using DataContainer;
using Nettention.Proud;
using SevenDSGameS2C;

namespace GameClient.PacketHandler
{
    public class AuthPacketHandler
    {
        public AuthPacketHandler(Stub s2cStub)
        {
            s2cStub.CG_RequestSecurityTokenOK = new Stub.CG_RequestSecurityTokenOKDelegate(CG_RequestSecurityTokenOK);
            s2cStub.CG_RequestNetmarbleAuthOK = new Stub.CG_RequestNetmarbleAuthOKDelegate(CG_RequestNetmarbleAuthOK);
            s2cStub.CG_RequestLoginOK = new Stub.CG_RequestLoginOKDelegate(CG_RequestLoginOK);
        }

        // The "security token" is useless if we use CG_RequestNetmarbleAuth with the argument ClientDeviceType.Windows
        // The mobile versions pass the "security token" in their anti cheat (nmssa) to get another string "security cert value"
        // "security cert value" will be used in CG_RequestNetmarbleAuth (Windows just uses an empty string)
        private bool CG_RequestSecurityTokenOK(HostID remote, RmiContext rmiContext, string securityToken)
        {
            return true;
        }

        // In CG_RequestNetmarbleAuthOK the server sends 2 coordinates that correspond to a pixel on an image
        // This method returns the argb value of the color
        // This value will be required when sending CG_RequestLogin
        private int GetAuthKey(int x, int y)
        {
            // The image needs to be updates whenever there is a game version update
            // It can be found in 7dsgc_Data/resources.assets (on Windows)
            // In Unity the coordinate (0, 0) of an image is at the bottom-left whereas on Bitmap the coordinate (0, 0) is at the top-right.
            // So we need to adjust the y coordinate by subtracting it from its maximum value.
            return _7dsgcFarmbot.Properties.Resources.fx_vt.GetPixel(x, byte.MaxValue - y).ToArgb();
        }

        private bool CG_RequestNetmarbleAuthOK(HostID remote, RmiContext rmiContext, NetmarbleAccountInfo info)
        {
            if (info.banReason > 0 && info.banLimitSec > 0)
            {
                string exceptionMsg = $"The account is banned for {info.banLimitSec} seconds.";
                if (info.banLimitSec == 10000000)
                {
                    exceptionMsg = "The account is permanently banned.";
                }
                throw new Exception(exceptionMsg);
            }
            if (info.usn == 0 || info.netmarblePlayerID == string.Empty || info.needMobileConnect)
            {
                throw new Exception("You must connect at least once on mobile before using this account.");
            }
            GameDataContainer.Instance.UserData.Usn = info.usn;
            GameDataContainer.Instance.UserData.AuthKey = GetAuthKey(info.recommandHeroID, info.recommandSkinID);  // They really tried to hide coordinates names behind that
            return true;
        }

        private bool CG_RequestLoginOK(HostID remote, RmiContext rmiContext, LoginUserResultInfo userInfo, LoginServiceInfo loginServiceInfo)
        {
            GameDataContainer.Instance.CurrentServerTime = loginServiceInfo.currentServerTime;
            ConsoleWriter.WriteLine($"{{FC=Green}}Successfully logged into {userInfo.name}!");
            return true;
        }
    }
}