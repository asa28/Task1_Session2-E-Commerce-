using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain_DataLayer;
using BusinessLayer;

namespace Task1_Session2_E_Commerce_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly UserService _Service = new UserService(); 


        // respond to GET api/User
        [HttpGet]
        public ActionResult<Task> GetAllUsers()
        {


            return;
        }



        // respond to GET api/User/Id=? 
        [HttpGet("{Id}")]
        public ActionResult<Task> GetUserById(int id)
        {


            return; 
        }



        // respond to POST api/User
        [HttpPost]
        public ActionResult<Task> InsertModel(User Model)
        {

            return;
        }



        // respond to PUT api/User
        [HttpPut]
        public ActionResult<Task> UpdateModel(User Model)
        {

            return;
        }


        // respond to DELETE api/User
        [HttpDelete("{Id}")]
        public void RemoveModel(int Id)
        { 
                        
        }
    }
}
