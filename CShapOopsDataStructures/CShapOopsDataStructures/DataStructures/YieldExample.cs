using CShapOopsDataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public class YieldExample
    {
        CollectionsClass collections = new CollectionsClass();

        int i = 0;
        public IEnumerable<EmployeeModel> Loop1()
        {
            foreach (var c in collections.GetEmpList())
            {
                i++;
                //First iteration state of count greater than 5
                if (i > 5)
                {
                    //Second iteration state of count greater than 10
                    if (i > 10)
                    {
                        //Second iteration state of count greater than 10 and returning the value
                        yield return Loop2(c);
                    }
                    else
                    {
                        //First iteration state of count greater than 5 and returning the value
                        yield return c;
                    }
                }
            }
        }

        public EmployeeModel Loop2(EmployeeModel emp)
        {
            emp.EmpName = "GREATER THAN 10" + i;
            return emp;
        }

        public void Loop3()
        {
            foreach (var c in Loop1())
            {
                Console.WriteLine(c.EmpID); ;
                Console.WriteLine(c.EmpName);
            }
        }



        public void Loop33()
        {
                foreach (int i in Integers())
                {
                    Console.WriteLine(i.ToString());
                }
        }
        public IEnumerable<int> Integers()
        {
            yield return 1;
            yield return 2;
            yield return 4;
            yield return 8;
            yield return 16;
            yield return 16777216;
        }
    }
}
