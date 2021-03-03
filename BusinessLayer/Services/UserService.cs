using Domain_DataLayer.Models.Person;
using System.Collections.Generic;

namespace Service_BusinessLayer.Services
{
    public class UserService : IService<User>
    {
        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            var Users_all = new List<User> { 
                new User { FirstName = "Ahmed", LastName = "Sabry", IdentityNumber = "01234567891234", MobilePhone="01119790023", Email= "ahmadsabry28@gmail.com" }, 
                new User { FirstName = "Mohamed", LastName = "Ahmed", IdentityNumber = "01234567891234", MobilePhone="01119790023", Email= "ahmadsabry28@gmail.com" }, 
                new User { FirstName = "Salam", LastName = "Ahmed", IdentityNumber = "01234567891234", MobilePhone="01119790023", Email= "ahmadsabry28@gmail.com" }, 
            };
            return Users_all;
        }

        public User Insert(User entity)
        {
            throw new System.NotImplementedException();
        }

        public User SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}
