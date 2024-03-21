using CShapOopsDataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public class IEnumerableExample
    {
        /// <summary>
        /// IEnumerable Example
        /// Simplified to use foreach loop
        /// </summary>
        public void GetIEnumerableData()
        {
            CollectionsClass collectionsClass = new CollectionsClass();

            IEnumerable<EmployeeModel> enumerable = collectionsClass.GetEmpList();

            foreach (var data in enumerable)
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
