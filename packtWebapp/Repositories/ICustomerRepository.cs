using packtWebapp.Entities;
using System;
using System.Linq;

namespace packtWebapp.Repositories
{
    public interface ICustomerRepository
    {
        void Add(Customer item);
        void Delete(Guid id);
        IQueryable<Customer> GetAll();
        Customer GetSingle(Guid id);
        bool Save();
        void Update(Customer item);
    }
}