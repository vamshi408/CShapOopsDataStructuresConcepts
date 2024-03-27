using CShapOopsDataStructures.DataStructures;
using CShapOopsDataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.Design_Patterns
{
    public class EmployeeRepository : IRepository<EmployeeModel>
    {
        public List<EmployeeModel> Add()
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> Delete(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> DeleteByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetSingle(EmployeeModel entity)
        {
            throw new NotImplementedException();
        }

        public EmployeeModel GetSingleByID(string id)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> Update()
        {
            throw new NotImplementedException();
        }
    }
}
