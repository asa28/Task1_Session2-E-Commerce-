using Domain_DataLayer.Models.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain_DataLayer.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public Task<IEnumerable<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
