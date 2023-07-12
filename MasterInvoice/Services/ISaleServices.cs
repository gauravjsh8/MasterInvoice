namespace MasterInvoice.Services
{
    public interface ISaleServices
    {
        IResult<bool> Add(SaleMasterDTO model);
    }
    public class CustomerDTO
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
    }
    public class ItemDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
    public class SaleMasterDTO
    {
        public CustomerDTO Customer { get; set; }
        public IList<ItemDTO> Items { get; set;}
    }
    public class IResult<t>
    {
        public t? Data { get; set; }
        public string? Message { get; set; }
        public ResultStatus Status{ get; set; }
    }
    public enum ResultStatus
    {
        success,failure
    }
}
