using Domain_DataLayer.CommonModels;
using System.Collections.Generic;

namespace Domain_DataLayer.Models.Products
{
    public class Category:BasicModel
    {
        public string Category_Name { get; set; }

        public List<string> SubCategoryList { get; set; }
    }
}
