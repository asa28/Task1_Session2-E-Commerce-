using Domain_DataLayer.CommonModels;

namespace Service_BusinessLayer.Services
{
    public interface IService
    {
        // Basic Businesss Operations  between Business layer and Data-Access layer
        // CRUD operation based on Injected Repository

        public BasicModel GetAll();
        public BasicModel Get(int id);
        public BasicModel Insert(BasicModel entity);
        public BasicModel Update(BasicModel entity);
        public BasicModel Delete(BasicModel entity);
        public BasicModel SaveChanges();

    }
}
