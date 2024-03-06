namespace DataContainer
{
    public class UserData  // Use this class to save user related data
    {
        public long Usn { get; set; }  // Unsure what Usn stands for but it's a unique number given to a player during the account creation

        // This value will be assigned to NetmarbleSDKInfo.sdkADID before sending CG_RequestLogin
        // If incorrect, the request will fail with the Under_Maintenance error
        public int AuthKey { get; set; }
    }
}
