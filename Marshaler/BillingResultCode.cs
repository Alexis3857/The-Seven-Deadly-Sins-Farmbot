public enum BillingResultCode
{
    Success,
    DBError,
    AlreadyProcessed,
    VerifySuccess_DiffAccountSeq = 4,
    AlreadyProcessed_DiffAccountSeq,
    VerifyFailed,
    InvalidTIDorAlreadyConsumed = 8,
    DuplicatedMarketSerial = 10,
    Promotion = 200,
    InvalidParameter = 1001,
    InvalidStoreType,
    PurchaseDataParsingFailed,
    InvalidPurchaseData,
    NetmarbleIAPServerDBError = 2001,
    InvalidMarketVerifyKey,
    APIConnectionError,
    InvalidReceiptFormat,
    InvalidMarketResponseFormat,
    ReceiptCryptographyError,
    ErrorETC = 9999
}
