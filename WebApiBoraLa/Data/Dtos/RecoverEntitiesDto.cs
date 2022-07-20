﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationServicesSO.Data.Dtos
{
    public class RecoverEntitiesDto
    {
        [Key]
        [Required]
        public int key { get; set; }
        public string Org { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ReportName { get; set; }
        public string SoldtoCode { get; set; }
        public string SoldtoName { get; set; }
        public string SoldtoReportName { get; set; }
        public string SoldtoState { get; set; }
        public string SoldtoTaxNumber { get; set; }
        public string SoldToType { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string OrderNumber { get; set; }
        public string OrderItem { get; set; }
        public string SalesDocDateCreated { get; set; }
        public string CreatedBy { get; set; }
        public string SalesDocType { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryBlockInSd { get; set; }
        public string DeliveryNumber { get; set; }
        public string Item { get; set; }
        public string Lote { get; set; }
        public string DeliveryNumberDateCreated { get; set; }
        public string BillingDocument { get; set; }
        public string BillingItem { get; set; }
        public string ReferenceDocNumber { get; set; }
        public string CfopCode { get; set; }
        public string BillingPostDate { get; set; }
        public string YourReference { get; set; }
        public string CustomerReqDeliveryDt { get; set; }
        public string DelivDateConfirmedSl { get; set; }
        public string PlanGoodsIssueDate { get; set; }
        public string LoadingDate { get; set; }
        public string MaterialAvailabilityDate { get; set; }
        public string TranspPlannDate { get; set; }
        public string TermsOfPayment { get; set; }
        public string TermsOfPaymentDescription { get; set; }
        public string BclReference { get; set; }
        public string Incoterms { get; set; }
        public string MaterialNumber { get; set; }
        public string MaterialShortText { get; set; }
        public string TradeProductCode { get; set; }
        public string TradeProductName { get; set; }
        public string LocalSegment { get; set; }
        public string PurchasingGroup { get; set; }
        public string Plant { get; set; }
        public decimal? SalesQtyInUom { get; set; }
        public string BaseUom { get; set; }
        public decimal? ItemConfirmedQtyUom { get; set; }
        public string ConfirmedQtyUom { get; set; }
        public decimal? TotalNetValueItemLc { get; set; }
        public decimal? TaxAmoutItemLc { get; set; }
        public decimal? TotalNetValueItemGc { get; set; }
        public decimal? TaxAmoutItemGc { get; set; }
        public string CurrRateOfMth { get; set; }
        public string CurrencyRateItem { get; set; }
        public string Campaign { get; set; }
        public string TerrOwner { get; set; }
        public string TerrOwnerName { get; set; }
        public string SalesRepIdOwner { get; set; }
        public string SalesRepOwnerName { get; set; }
        public string SalesDistrictOwner { get; set; }
        public string RslOwner { get; set; }
        public string CsrAlert { get; set; }
        public string ReasonPendingCredi { get; set; }
        public string DetailsPendingCred { get; set; }
        public string YrAndMthInvoiceDate { get; set; }
        public string SoldToStateTaxNumber { get; set; }
        public string SoldToCity { get; set; }
        public string EmailGerente { get; set; }
        public string EmailFranq { get; set; }
        public string YrAndMthTransportDate { get; set; }
        public string FixedDate { get; set; }
        public string ProfitCenter { get; set; }
        public string Zreserve { get; set; }
        public string StorageLocation { get; set; }
        public decimal? NetPrice { get; set; }
        public string ChangeOn { get; set; }
        public string CreditStatus { get; set; }
        public string DeliveryDate { get; set; }
        public decimal? DaysDatabase { get; set; }
        public string ReceivablesDate { get; set; }
        public string PaymentMethodDescr { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}