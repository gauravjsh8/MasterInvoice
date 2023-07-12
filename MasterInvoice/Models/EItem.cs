namespace MasterInvoice.Models
{
    public class EItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get;set; }
    }
}
