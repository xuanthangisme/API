using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class ProductRepository: IProductRepository
    {
        private IDatabaseHelper _dbHelper;
        public ProductRepository(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<ProductModel> GetProAll()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_pro_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<ProductModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /* public bool Create(ProductRepository model)
         {
             string msgError = "";
             try
             {
                 var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_item_create",
                 "@item_id", model.item_id,
                 "@item_group_id", model.item_group_id,
                 "@item_image", model.item_image,
                 "@item_name", model.item_name,
                 "@item_price", model.item_price);
                 if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                 {
                     throw new Exception(Convert.ToString(result) + msgError);
                 }
                 return true;
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public ProductRepository GetDatabyID(string id)
         {
             string msgError = "";
             try
             {
                 var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_item_get_by_id",
                      "@item_id", id);
                 if (!string.IsNullOrEmpty(msgError))
                     throw new Exception(msgError);
                 return dt.ConvertTo<ProductRepository>().FirstOrDefault();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public List<ProductRepository> GetDataAll()
         {
             string msgError = "";
             try
             {
                 var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_item_all");
                 if (!string.IsNullOrEmpty(msgError))
                     throw new Exception(msgError);
                 return dt.ConvertTo<ProductRepository>().ToList();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }
         public List<ProductRepository> Search(int pageIndex, int pageSize, out long total, string item_group_id)
         {
             string msgError = "";
             total = 0;
             try
             {
                 var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_item_search",
                     "@page_index", pageIndex,
                     "@page_size", pageSize,
                     "@item_group_id", item_group_id);
                 if (!string.IsNullOrEmpty(msgError))
                     throw new Exception(msgError);
                 if (dt.Rows.Count > 0) total = (long)dt.Rows[0]["RecordCount"];
                 return dt.ConvertTo<ProductRepository>().ToList();
             }
             catch (Exception ex)
             {
                 throw ex;
             }
         }*/
    }
}

