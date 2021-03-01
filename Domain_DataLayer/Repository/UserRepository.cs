using Domain_DataLayer.Models.Person;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain_DataLayer.Repository
{
    public class UserRepository : IRepository<User>
    {
        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
