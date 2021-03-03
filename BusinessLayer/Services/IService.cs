using System.Collections.Generic;

namespace Service_BusinessLayer.Services
{
    public interface IService<BasicModel>
    {
        // Basic Businesss Operations  between Business layer and Data-Access layer
        // CRUD operation based on Injected Repository

        public IEnumerable<BasicModel> GetAll();
        public BasicModel Get(int id);
        public BasicModel Insert(BasicModel entity);
        public BasicModel Update(BasicModel entity);
        public void Delete(int Id);
        public BasicModel SaveChanges();

    }
}
