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
    
    public partial class Article
    {
        public int ID { get; set; }
        public string CyrName { get; set; }
        public string LatName { get; set; }
        public int ArticleGroupID { get; set; }
        public int MeasureID { get; set; }
        public int ProducerID { get; set; }
        public int SaleDiscountTypeID { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public int NumberInBox { get; set; }
        public int SmallNumberInBox { get; set; }
        public int OverrateGroupID { get; set; }
        public decimal BasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal RetailerMaxPrice { get; set; }
        public Nullable<decimal> SaleDiscountPercent { get; set; }
        public Nullable<decimal> SaleDiscountWholesalePercent { get; set; }
        public string ProducerCode { get; set; }
        public decimal ProducerDiscountPercent { get; set; }
        public decimal ProducerRebatePercent { get; set; }
        public bool isDrug { get; set; }
        public bool isStrongDrug { get; set; }
        public bool isActive { get; set; }
        public string Barcode1 { get; set; }
        public string Barcode2 { get; set; }
        public Nullable<int> ArticlePharmGroupID { get; set; }
        public short NumberInPacking { get; set; }
        public Nullable<bool> ByOrder { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Depth { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<System.DateTime> InactivationDate { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<bool> isHospital { get; set; }
        public Nullable<bool> isDrugstoreAllowed { get; set; }
        public Nullable<bool> isForRefrigerator { get; set; }
        public string DeliveryContract { get; set; }
        public Nullable<int> DurabilityInMonths { get; set; }
        public Nullable<int> isMedicalPrescription { get; set; }
        public string GenericName { get; set; }
        public string Attributes { get; set; }
        public Nullable<decimal> ProducerAnnualDiscountPercent { get; set; }
        public Nullable<decimal> ProducerAnnualRebatePercent { get; set; }
        public Nullable<decimal> ProducerPrepayDiscountPercent { get; set; }
        public Nullable<decimal> ProducerPrepayRebatePercent { get; set; }
        public Nullable<decimal> CustomerDiscountDelta { get; set; }
        public Nullable<decimal> ArticleItemsCompensation { get; set; }
        public Nullable<bool> isInDailyInventarization { get; set; }
        public Nullable<int> LibraPromoProgramID { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<byte> InternetProhibition { get; set; }
        public Nullable<bool> isList5 { get; set; }
        public Nullable<decimal> NHIFPriceDifference { get; set; }
        public Nullable<decimal> ReservedDiscount1 { get; set; }
        public Nullable<bool> isRemovePrice { get; set; }
        public Nullable<decimal> ReservedDiscount2 { get; set; }
        public Nullable<decimal> HospitalCompensation { get; set; }
        public Nullable<short> HospitalCompensationType { get; set; }
        public string AdvertismentText { get; set; }
        public string AdvertismentTextWeb { get; set; }
        public string ATC_EU { get; set; }
        public string ATC_US { get; set; }
        public Nullable<byte> CatNo { get; set; }
        public string SubCatCode { get; set; }
        public string SubSubCatCode { get; set; }
        public string RxOTC { get; set; }
        public string OriginalGeneric { get; set; }
        public string IntrastatCode { get; set; }
        public string CountryCodeSender { get; set; }
        public string CountryCodeOrigin { get; set; }
        public string IntrastatTypeOfDeal { get; set; }
        public string IntrastatDeliveryTerms { get; set; }
        public string IntrastatTransportType { get; set; }
        public string CountryCodeSupplier { get; set; }
    }
}
