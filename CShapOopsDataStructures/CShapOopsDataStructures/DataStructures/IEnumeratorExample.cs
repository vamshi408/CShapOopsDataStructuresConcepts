using CShapOopsDataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public class IEnumeratorExample
    {
        /// <summary>
        /// IEnumerator Example
        /// 1. GetEnumerator() method to convert collection into Enumerator list
        /// 2. MoveNext() loops the collection list
        /// 3. Current returns the current element of the loop in a collection
        /// </summary>
        public void GetIEnumeratorData()
        {
            CollectionsClass collectionsClass = new CollectionsClass(); 

            IEnumerator<EmployeeModel> enumerator = collectionsClass.GetEmpList().GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.EmpID);
                Console.WriteLine(enumerator.Current.EmpName);
                Console.WriteLine(enumerator.Current.Phone);
                Console.WriteLine(enumerator.Current.Email);
                Console.WriteLine("--------------------------");
            }

        }

    }
}
