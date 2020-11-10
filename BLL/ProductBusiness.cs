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
        public bool Create(ProductModel model)
        {
            return _res.Create(model);
        }
        public ProductModel GetProID(int IDproduct)
        {
            return _res.GetProID(IDproduct);
        }
        public List<ProductModel> Get5MenuProAll(int IDmenu)
        {
            return _res.Get5MenuProAll(IDmenu);
        }
        public List<ProductModel> GetMenuProAll(int IDmenu)
        {
            return _res.GetMenuProAll(IDmenu);
        }
    }
}
