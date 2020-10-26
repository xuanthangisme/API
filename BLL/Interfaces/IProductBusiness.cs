using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IProductBusiness
    {
        ProductModel GetProID(string id);
        bool Create(ProductModel model);
        List<ProductModel> GetProAll();
    }
}