using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public interface IRepository<T> where T : class
    {
        List<T> Add();
        List<T> Update();
        List<T> Delete(T entity);
        List<T> GetAll();
        T GetSingle(T entity);
        T GetSingleByID(string id);
        List<T> DeleteByID(string id);
    }
}
