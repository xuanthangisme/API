using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public partial class ProductBusiness : IProductBusiness
    {
        private IProductRepository _res;
        public ProductBusiness(IProductRepository ProGroupRes)
        {
            _res = ProGroupRes;
        }
        public List<ProductModel> GetProAll()
        {
            return _res.GetProAll();
        }
    }
}
