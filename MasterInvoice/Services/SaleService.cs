using MasterInvoice.Data;
using MasterInvoice.Models;
using System.Linq.Expressions;

namespace MasterInvoice.Services
{
    public class SaleService : ISaleServices
    {
        public AppDbContext _context { get; set; }
        public SaleService(AppDbContext context)
        {
            _context = context;
        }
        public IResult<bool> Add(SaleMasterDTO model)
        {
            var cus = new ECustomer()
            {
                Id = 0,
                Address = model.Customer.Address,
                Name = model.Customer.Name,
                PhoneNo = model.Customer.PhoneNo
            };
            _context.Customers.Add(cus);
            _context.SaveChanges();
            var ItermList = (from item in model.Items
                             select new EItem()
                             {
                                 Id = 0,
                                 CustomerId = cus.Id,
                                 Discount = item.Discount,
                                 Name = item.Name,
                                 Price = item.Price,
                                 Quantity = item.Quantity,
                                 Total = item.Total
                             }).ToList();
            _context.Items.AddRange(ItermList);
            _context.SaveChanges();
            return new IResult<bool>()
            {
                Status = ResultStatus.success
            };
        }
    }
}
