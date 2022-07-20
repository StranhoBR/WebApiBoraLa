namespace ApplicationServicesSO.Models
{
    public class VMModel
    {
        public string key { get; set; }
        public string OrderNumber { get; set; }
        public string Item { get; set; }
        public string MaterialNumber { get; set; }
        public string MaterialShortText { get; set; }
        public string Plant { get; set; }
        public string PlanGoodsIssueDate { get; set; }
        public decimal? SalesQtyInUom { get; set; }
        public string BaseUom { get; set; }
        public string SalesRepOwnerName { get; set; }
        public string SalesDistrictOwner { get; set; }
        public decimal? TotalNetValueItemLc { get; set; }
        public decimal? TaxAmoutItemLc { get; set; }
        public string OrderStatus { get; set; }
        public string SoldtoCode { get; set; }
        public string SoldtoName { get; set; }
        public string SoldtoState { get; set; }
        public string TermsOfPayment { get; set; }
        public string PaymentDesc { get; set; }
        public string EmailGerente { get; set; }
        public string EmailFranq { get; set; }
    }
}
