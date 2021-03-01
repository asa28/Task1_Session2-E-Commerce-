using Domain_DataLayer.CommonModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain_DataLayer.Models.Products
{
    public class Product: BasicModel
    {
        public string Product_Name { get; set; }

        public int Category_Id { get; set; }
        [ForeignKey("Id")]
        public Category category { get; set; }
    }
}
