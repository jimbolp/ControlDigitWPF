//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlDigit
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerMasterData
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string NameLaw { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string TaxNo { get; set; }
        public string Bulstat { get; set; }
        public string MolName { get; set; }
        public string ReceiverName { get; set; }
        public string Licence { get; set; }
        public string DrugLicence { get; set; }
        public string ShipmentAddress { get; set; }
        public string Email { get; set; }
        public Nullable<long> InvoiceReceiveTypeID { get; set; }
        public Nullable<int> AppUserID { get; set; }
        public Nullable<int> CustomerGroupID { get; set; }
        public Nullable<int> PostCodeID { get; set; }
        public Nullable<int> AreaCodeID { get; set; }
        public string RZOKCode { get; set; }
        public Nullable<int> PaymentDaysFree { get; set; }
        public Nullable<int> PaymentDaysNZOK { get; set; }
        public Nullable<decimal> ArticleBGDiscountPercent { get; set; }
        public Nullable<decimal> ArticleForeignDiscountPercent { get; set; }
        public Nullable<decimal> ArticleNZOKDiscountPercent { get; set; }
        public Nullable<decimal> MaxCredit { get; set; }
        public Nullable<decimal> FixedProfitPercent { get; set; }
        public Nullable<decimal> FixedOverratePercent { get; set; }
        public Nullable<decimal> OverrateDecreasePercent { get; set; }
        public Nullable<int> PaymentTypeID { get; set; }
        public Nullable<int> PaymentTypeIDNZOK { get; set; }
        public Nullable<int> DiscountTypeIDFree { get; set; }
        public Nullable<int> DiscountTypeIDNZOK { get; set; }
        public Nullable<int> SaleDiscountTypeID { get; set; }
        public string Remark { get; set; }
        public Nullable<byte> isActive { get; set; }
        public Nullable<byte> isDiscountException { get; set; }
        public Nullable<byte> isSaleOrderAllowed { get; set; }
        public Nullable<byte> isDeleteAllowed { get; set; }
        public Nullable<byte> isVATRegistered { get; set; }
        public Nullable<byte> isDiscountInPrice { get; set; }
        public Nullable<byte> isPreferedFinanceRebate { get; set; }
        public Nullable<byte> isMathDiscountType { get; set; }
        public Nullable<byte> isClient { get; set; }
        public Nullable<int> PharmacyConsultantID { get; set; }
        public Nullable<decimal> StockCredit { get; set; }
        public Nullable<int> SoftwareID { get; set; }
        public Nullable<int> LibraEvent { get; set; }
        public Nullable<decimal> PartnerCapital { get; set; }
        public Nullable<int> PartnerStartDate { get; set; }
        public Nullable<int> PartnerEndDate { get; set; }
        public Nullable<byte> isPricing { get; set; }
        public Nullable<int> ContractType { get; set; }
        public Nullable<decimal> ContractSum { get; set; }
        public Nullable<decimal> BonusOborotPercent { get; set; }
        public Nullable<decimal> BonusOborot { get; set; }
        public Nullable<byte> isPriceWithoutRounding { get; set; }
        public string BankCountryCode { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string IBAN { get; set; }
        public Nullable<int> SoftwareConsultantID { get; set; }
        public string Status { get; set; }
        public Nullable<byte> isPrintDelayPayments { get; set; }
        public Nullable<byte> isRabatDenied { get; set; }
        public Nullable<decimal> BonusOborotPercent2 { get; set; }
        public Nullable<byte> isActionActavis { get; set; }
        public Nullable<int> AuctionStartDate { get; set; }
        public Nullable<int> AuctionEndDate { get; set; }
        public Nullable<int> AppUserID2 { get; set; }
        public Nullable<decimal> ContractMonthlyTax { get; set; }
        public Nullable<decimal> ContractInternetPercent { get; set; }
        public Nullable<decimal> ContractInternetSum { get; set; }
        public Nullable<byte> isPricingNZOK { get; set; }
        public Nullable<int> RetailerPriceCalcTypeID { get; set; }
        public Nullable<int> RetailerPriceCalcTypeIDNZOK { get; set; }
        public Nullable<byte> ShowWarningLabel { get; set; }
        public Nullable<byte> isDiscountInPriceNZOK { get; set; }
        public Nullable<int> MerchandiserID { get; set; }
        public Nullable<byte> isActionDenied { get; set; }
        public Nullable<byte> isSpecialOrder { get; set; }
        public Nullable<int> NationalCustomerGroupID { get; set; }
        public Nullable<int> PostCode { get; set; }
        public Nullable<byte> isProtocol5Allowed { get; set; }
        public Nullable<int> ContractDate { get; set; }
        public Nullable<int> ContractInstallationDate { get; set; }
        public Nullable<int> IMSGroup { get; set; }
        public Nullable<int> CustomerDeliveryGroup { get; set; }
        public Nullable<byte> isJoinInMyPharmacy { get; set; }
        public Nullable<byte> isJoinInAdvertisingShopWindows { get; set; }
        public Nullable<int> IMSCodeID { get; set; }
        public Nullable<byte> isNZOKHalfMargin { get; set; }
        public Nullable<long> SAPNumber { get; set; }
        public string LocationCode { get; set; }
        public Nullable<byte> isPharmacyOwner { get; set; }
        public Nullable<int> PaymentDaysList5 { get; set; }
        public long RecID { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public string ImportFile { get; set; }
        public Nullable<int> BranchNo { get; set; }
        public Nullable<decimal> FixedProfitPercentNZOK { get; set; }
        public Nullable<decimal> OverratePercent { get; set; }
        public Nullable<int> IDF { get; set; }
        public string ServiceCategory { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<decimal> MaxCreditK1 { get; set; }
        public Nullable<bool> isBlockDeliveryOnCash { get; set; }
    }
}
