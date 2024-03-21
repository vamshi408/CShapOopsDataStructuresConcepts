using CShapOopsDataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public class CollectionsClass
    {
       public List<EmployeeModel> listEmp;

        public CollectionsClass()
        {
            listEmp = new List<EmployeeModel>
            {
                new EmployeeModel()
                {
                    EmpID = 1,
                    EmpName = "Vamshi",
                    Phone="+91 999999999",
                    Email="Vamshi@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 2,
                    EmpName = "Krishna",
                    Phone="+91 888888888",
                    Email="Krishna@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 3,
                    EmpName = "Bandi",
                    Phone="+91 777777777",
                    Email="Bandi@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 4,
                    EmpName = "Kabali",
                    Phone="+91 6666666666",
                    Email="Kabali@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 5,
                    EmpName = "Ankur",
                    Phone="+91 5555555555",
                    Email="Ankur@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 6,
                    EmpName = "Varun",
                    Phone="+91 4444444444",
                    Email="Varun@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 7,
                    EmpName = "Kader",
                    Phone="+91 3333333333",
                    Email="Kader@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 8,
                    EmpName = "Pandu",
                    Phone="+91 2222222222",
                    Email="Pandu@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 9,
                    EmpName = "Venkat",
                    Phone="+91 1111111111",
                    Email="Venkat@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 10,
                    EmpName = "Vamshi",
                    Phone="+91 999999999",
                    Email="Vamshi@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 11,
                    EmpName = "Krishna",
                    Phone="+91 999999999",
                    Email="Krishna@gmail.com"
                },
                new EmployeeModel()
                {
                    EmpID = 12,
                    EmpName = "Bandi",
                    Phone="+91 999999999",
                    Email="Bandi@gmail.com"
                }
            };
        }

        public List<EmployeeModel> GetEmpList(){
            return listEmp;
        }
    }
}
