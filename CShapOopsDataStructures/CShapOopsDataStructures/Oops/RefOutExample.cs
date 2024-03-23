using CShapOopsDataStructures.DataStructures;
using CShapOopsDataStructures.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.Oops
{
    public class RefOutExample
    {
        public List<EmployeeModel>  EmployeesEntity = new List<EmployeeModel>();

        public List<EmployeeModel> GetDataWIthREF()
        {
           
            CollectionsClass collectionsClass = new CollectionsClass();
            EmployeesEntity= collectionsClass.GetEmpList();
            ModifyData1(ref EmployeesEntity);
            return EmployeesEntity;
          

            
        }


        public void ModifyData1(ref List<EmployeeModel> obj)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            obj.ToList().ForEach(e => e.EmpName = "GASFVDHGASVFGHDVFASGHDVHGASVDHGASVDHGASVDHGAVSD");
            sw.Stop();
            Console.WriteLine("With REF={0}", sw.Elapsed);
        }





        public List<EmployeeModel> GetDataWIthOutREF()
        {
           
            CollectionsClass collectionsClass = new CollectionsClass();
            EmployeesEntity = collectionsClass.GetEmpList();
            ModifyData2(EmployeesEntity);
            return EmployeesEntity;
        }
       

        public void ModifyData2(List<EmployeeModel> obj)
        {
            Stopwatch sw1 = new Stopwatch();

            sw1.Start();
            obj.ToList().ForEach(e => e.EmpName = "GASFVDHGASVFGHDVFASGHDVHGASVDHGASVDHGASVDHGAVSD");
            sw1.Stop();
            Console.WriteLine("Without REF   ={0}", sw1.Elapsed);
        }





        public void GetDataByOut(int a1, int b1,out int a, out int b)
        {

            a = a1 * 100;
            b = b1 * 200;
        }
    }
}
