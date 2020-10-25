using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface IProductRepository
    {
        List<ProductModel> GetProAll();
        /*List<ProductModel> Search(int pageIndex, int pageSize, out long total, string item_group_id);*/
    }
}
