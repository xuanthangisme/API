using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductBusiness _proBusiness;
        public ProductController(IProductBusiness proBusiness)
        {
            _proBusiness = proBusiness;
        }
        [Route("get-all")]
        [HttpGet]
        public IEnumerable<ProductModel> GetProAll()
        {
            return _proBusiness.GetProAll();
        }
    }
}
