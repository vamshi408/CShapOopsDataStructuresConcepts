using CShapOopsDataStructures.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.Design_Patterns
{
    internal class CustomerRepository : IRepository<CustomerCollectionModel>
    {
        public List<CustomerCollectionModel> Add()
        {
            throw new NotImplementedException();
        }

        public List<CustomerCollectionModel> Delete(CustomerCollectionModel entity)
        {
            throw new NotImplementedException();
        }

        public List<CustomerCollectionModel> DeleteByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerCollectionModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerCollectionModel GetSingle(CustomerCollectionModel entity)
        {
            throw new NotImplementedException();
        }

        public CustomerCollectionModel GetSingleByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerCollectionModel> Update()
        {
            throw new NotImplementedException();
        }
    }
}
