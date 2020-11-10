using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IProductBusiness
    {
        ProductModel GetProID(int IDproduct);
        bool Create(ProductModel model);
        List<ProductModel> GetProAll();
        List<ProductModel> Get5MenuProAll(int IDmenu);
        List<ProductModel> GetMenuProAll(int IDmenu);
    }
}