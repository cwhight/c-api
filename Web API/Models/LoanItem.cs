namespace Web_API.Models
{
    public class LoanItem
    {
        public long Id { get; set; }
        public string BorrowerName { get; set; }
        public long RepaymentAmount { get; set; }
        public long FundingAmount { get; set; }
    }
}
