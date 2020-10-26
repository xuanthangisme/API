using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface IProductRepository
    {
        ProductModel GetProID(string id);
        bool Create(ProductModel model);
        List<ProductModel> GetProAll();
        /*List<ProductModel> Search(int pageIndex, int pageSize, out long total, string NamePD, string IDmenu);*/
    }
}
