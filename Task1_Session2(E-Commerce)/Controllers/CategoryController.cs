using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_DataLayer.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Service_BusinessLayer.Services;

namespace Task1_Session2_E_Commerce_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _Service = new CategoryService();

        // respond to GET api/Category
        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllCategorys()
        {
            var x = _Service.GetAll();
            return x;
        }



        // respond to GET api/Category/Id=? 
        [HttpGet("{Id}")]
        public async Task<Category> GetCategoryById(int id)
        {
            var x = _Service.Get(id);
            return x;
        }



        // respond to POST api/Category
        [HttpPost]
        public async Task<Category> InsertModel(Category Model)
        {
            var x = _Service.Insert(Model);
            return x;
        }



        // respond to PUT api/Category
        [HttpPut]
        public async Task<Category> UpdateModel(Category Model)
        {
            var x = _Service.Update(Model);
            return x;
        }


        // respond to DELETE api/Category
        [HttpDelete("{Id}")]
        public void RemoveModel(int Id)
        {
            _Service.Delete(Id);
        }
    }
}
