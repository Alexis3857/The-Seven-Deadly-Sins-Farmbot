public class BillingVerifyResultInfo
{
    public BillingResCode resCode;
    public BillingResultCode resultCode;
    public long transactionID;
    public string resultString = string.Empty;
    public bool isPurchase;
    public bool promoFlag;
    public bool gppFlag;
    public string pcTransactionID = string.Empty;
}