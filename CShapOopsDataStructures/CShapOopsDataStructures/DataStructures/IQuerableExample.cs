using CShapOopsDataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public class IQueryableExample
    {
        /// <summary>
        /// IQuerable Example
        /// Simplified to use filter in server side and render minimal data into client machine
        /// This is applicable only for data base object or other server side objects renderring
        /// </summary>
        public void GetIQueryableData()
        {
            CollectionsClass collectionsClass = new CollectionsClass();

            IQueryable<EmployeeModel> queryable =collectionsClass.GetEmpList().Where(s=>s.EmpName=="Vamshi").AsQueryable();

            foreach (var data in queryable)
            {
                Console.WriteLine(data.EmpID);
                Console.WriteLine(data.EmpName);
                Console.WriteLine(data.Phone);
                Console.WriteLine(data.Email);
                Console.WriteLine("--------------------------");
            }

        }
    }
}
