﻿
namespace MangoPay.Core
{
    /// <summary>Method key enumeration.</summary>
    public enum MethodKey
    {
        AuthenticationBase,
        AuthenticationOAuth,
        CardGet,
        CardSave,
        CardRegistrationCreate,
        CardRegistrationGet,
        CardRegistrationSave,
        EventsAll,
        EventsGetHookCallbacks,
        HooksAll,
        HooksCreate,
        HooksGet,
        HooksSave,
        InfoGet,
        InfoGetFeeWallets,
        InfoGetMeansOfPayment,
        PayinsBankwireDirectCreate,
        PayinsBankwirePayinDirectCreate,
        PayinsBankwirePayinPreauthorizedCreate,
        PayinsBankwirePayinRecurrentExecutionCreate,
        PayinsBankwirePayinWebCreate,
        PayinsCardDirectCreate,
        PayinsCardPreauthorizedCreate,
        PayinsCardRecurrentExecutionCreate,
        PayinsCardWebCreate,
        PayinsCreateRefunds,
        PayinsGetRefunds,
        PayinsDirectCreditDirectCreate,
        PayinsDirectCreditPreauthorizedCreate,
        PayinsDirectCreditRecurrentExecutionCreate,
        PayinsDirectCreditWebCreate,
        PayinsGet,
        PayinsPreauthorizedDirectCreate,
        PayinsRegisteredCardDirectCreate,
        PayinsRegisteredCardPreauthorizedCreate,
        PayinsRegisteredCardRecurrentExecutionCreate,
        PayinsRegisteredCardWebCreate,
        PayoutsAmazonGiftcardCreate,
        PayoutsBankwireCreate,
        PayoutsCreateRefunds,
        PayoutsGet,
        PayoutsGetRefunds,
        PayoutsMerchantExpenseCreate,
        PreauthorizationCreate,
        PreauthorizationGet,
        PreauthorizationSave,
        ReccurringPayinOrdersCreate,
        ReccurringPayinOrdersGet,
        ReccurringPayinOrdersGetTransactions,
        RefundsGet,
        RepudiationsGet,
        TransfersCreate,
        TransfersCreateRefunds,
        TransfersGet,
        TransfersGetRefunds,
        UsersAll,
        UsersAllBankAccount,
        UsersAllCards,
        UsersAllKyc,
        UsersAllKycRequests,
        UsersAllPaymentCards,
        UsersAllTransactions,
        UsersAllWallets,
        UsersCreateBankAccountsCa,
        UsersCreateBankAccountsGb,
        UsersCreateBankAccountsIban,
        UsersCreateBankAccountsOther,
        UsersCreateBankAccountsUs,
        UsersCreateKycDocument,
        UsersCreateKycPage,
        UsersCreateKycRequests,
        UsersCreateLegals,
        UsersCreateNaturals,
        UsersGet,
        UsersGetBankAccount,
        UsersGetKycDocument,
        UsersGetKycRequests,
        UsersGetLegals,
        UsersGetNaturals,
        UsersGetPaymentCards,
        UsersGetProofOfAddress,
        UsersGetProofOfIdentity,
        UsersGetProofOfRegistration,
        UsersGetShareholderDeclaration,
        UsersSaveKycDocument,
        UsersSaveLegals,
        UsersSaveNaturals,
        WalletsAllRecurringPayinOrders,
        WalletsAllTransactions,
        WalletsAllTransactionsPage,
        WalletsCreate,
        WalletsGet,
        WalletsSave
    }
}
