using CShapOopsDataStructures.DataStructures;
using CShapOopsDataStructures.Models;
using CShapOopsDataStructures.Oops;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures
{
    internal class Program : MethodOverridingExample
    {
        //Ovverriding

        public override void GetData()
        {
            Console.WriteLine("Derivide Class");
        }

        public class Derived2 : MethodOverridingExample
        {
            public override void GetData()
            {
                base.GetData();
            }
        }

        static void Main(string[] args)
        {
            //IEnumeratorExample enumerator= new IEnumeratorExample();
            //enumerator.GetIEnumeratorData();
            //Console.ReadKey();

            //IEnumerableExample enumerable = new IEnumerableExample();
            //enumerable.GetIEnumerableData();
            //Console.ReadKey();

            //IQueryableExample queryable = new IQueryableExample();
            //queryable.GetIQueryableData();
            //Console.ReadKey();

            //ArrayExample copyToExamp = new ArrayExample();
            //copyToExamp.CopyTOArrayConcept();
            //Console.ReadKey();

            //ArrayExample concatArrayExamp = new ArrayExample();
            //concatArrayExamp.ConCatArrayConcept();
            //Console.ReadKey();

            //YieldExample yieldexample = new YieldExample();
            //yieldexample.Loop3();
            //yieldexample.Loop33();
            //Console.ReadKey();


            //string serverpath = "C://user//vamshi//bandi//data//row";
            //Console.WriteLine("Loacl Path : " + serverpath);
            //string convertedpath = ExtensionMethodExample.ExtensionString(serverpath);
            //Console.WriteLine("Server Path : " + convertedpath);
            //Console.ReadKey();

            //CollectionsClass collectionsClass = new CollectionsClass();
            //foreach(var data in collectionsClass.ExtendToCustomer())
            //{
            //    Console.WriteLine(data.CustomerID);
            //    Console.WriteLine(data.Name);
            //}
            //Console.ReadKey();


            //RefOutExample refOutExample = new RefOutExample();

            //List<EmployeeModel> obj2 = new List<EmployeeModel>();
            //obj2 = refOutExample.GetDataWIthOutREF();

            //foreach (EmployeeModel emp in obj2)
            //{
            //    Console.WriteLine(emp.EmpID);
            //    Console.WriteLine(emp.EmpName);
            //}

            //Console.WriteLine("BREAK POINT A");

            //List<EmployeeModel> obj = new List<EmployeeModel>();

            //obj = refOutExample.GetDataWIthREF();

            //foreach (EmployeeModel emp in obj)
            //{
            //    Console.WriteLine(emp.EmpID);
            //    Console.WriteLine(emp.EmpName);
            //}

            //int a;int b;
            //refOutExample.GetDataByOut(101, 202, out a, out b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.ReadKey();


            //ConstReadonlyExample constReadonlyExample = new ConstReadonlyExample("2%");
            //constReadonlyExample.GetConstReadOnlyValues();
            //Console.ReadKey();


            MethodOverridingExample methodOverridingExample = new MethodOverridingExample();
            methodOverridingExample.GetData();
            Program program = new Program();
            program.GetData();
            Derived2 derived2 = new Derived2();
            derived2.GetData();
            Console.ReadKey();

        }
    }
}
