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
        [Route("create-pro")]
        [HttpPost]
        public ProductModel CreateProduct([FromBody] ProductModel model)
        {
            /*if (model.IMG != null)
            {
                var arrData = model.IMG.Split(';');
                if (arrData.Length == 3)
                {
                    var savePath = $@"assets/images/{arrData[0]}";
                    model.IMG = $"{savePath}";
                    SaveFileFromBase64String(savePath, arrData[2]);
                }
            }
            model.IDproduct = Guid.NewGuid().ToString();*/
            _proBusiness.Create(model);
            return model;
        }
        [Route("get-pro-id/{id}")]
        [HttpGet]
        public ProductModel GetProID(string id)
        {
            return _proBusiness.GetProID(id);
        }
    }
}
