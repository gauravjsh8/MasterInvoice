using MasterInvoice.Services;
using Microsoft.AspNetCore.Mvc;

namespace MasterInvoice.Api
{
    [Route("api/saleApi")]
    [ApiController]
    public class SaleApi:ControllerBase
    {
        
        private readonly ISaleServices _saleService;
        public SaleApi(ISaleServices saleService)
        {
            _saleService = saleService;
        }
        [HttpPost]
        public IResult<bool> AddSale([FromBody]SaleMasterDTO model)
        {
            return _saleService.Add(model);
        }
    }
}
