using System.Collections.Generic;
using System.Threading.Tasks;
using Domain_DataLayer.Models.Person;
using Microsoft.AspNetCore.Mvc;
using Service_BusinessLayer.Services;

namespace Task1_Session2_E_Commerce_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly UserService _Service = new UserService(); 


        // respond to GET api/User
        [HttpGet]
        public async Task<List<User>> GetAllUsers()
        {
            var x = _Service.GetAll();
            return x ;
        }



        // respond to GET api/User/Id=? 
        [HttpGet("{Id}")]
        public async Task<User> GetUserById(int id)
        {
            var x = _Service.Get(id);
            return x; 
        }



        // respond to POST api/User
        [HttpPost]
        public async Task<User> InsertModel(User Model)
        {
            var x = _Service.Insert(Model);
            return x;
        }



        // respond to PUT api/User
        [HttpPut]
        public async Task<User> UpdateModel(User Model)
        {
            var x = _Service.Update(Model);
            return x;
        }


        // respond to DELETE api/User
        [HttpDelete("{Id}")]
        public void RemoveModel(int Id)
        {
            _Service.Delete(Id);               
        }
    }
}
