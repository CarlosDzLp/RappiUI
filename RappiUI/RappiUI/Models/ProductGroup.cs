using System;
using System.Collections.Generic;

namespace RappiUI.Models
{
    public class ProductGroup : List<ProductModel>
    {
        public int IdCat { get; set; }
        public string NameCat { get; set; }

        public ProductGroup(int id,string nameCat,List<ProductModel> product)
            :base(product)
        {
            IdCat = id;
            NameCat = nameCat;
        }
    }
}
