using System;
using System.Collections.Generic;


namespace Model
{
    public class ProductModel
    {
        public int Id_Product { get; set; }
        public int Id_Menu { get; set; }
        public string Name_Product { get; set; }
        public string Code { get; set; }
        public string Meta_Title { get; set; }
        public string Images { get; set; }
        public decimal? Listed_Price { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
