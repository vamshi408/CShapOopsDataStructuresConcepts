﻿using CShapOopsDataStructures.Collections;
using CShapOopsDataStructures.DataStructures;
using CShapOopsDataStructures.Models;
using CShapOopsDataStructures.Oops;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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


            //MethodOverridingExample methodOverridingExample = new MethodOverridingExample();
            //methodOverridingExample.GetData();
            //Program program = new Program();
            //program.GetData();
            //Derived2 derived2 = new Derived2();
            //derived2.GetData();
            //Console.ReadKey();



            //CollectionsClass collectionsClass = new CollectionsClass();
            //List<EmployeeModel> employees = collectionsClass.GetEmpList();
            //List<CustomerCollectionModel> customerCollectionModels = collectionsClass.ExtendToCustomer();

            //var tuple = Tuple.Create(employees, customerCollectionModels);

            //tuple.Item1.ToList().ForEach(x => Console.WriteLine(x.EmpID +x.EmpName ));
            //tuple.Item2.ToList().ForEach(x => Console.WriteLine(x.CustomerID + x.Name));
            //Console.ReadKey();


            ////Generic Class
            //CollectionsClass collectionsClass = new CollectionsClass();
            //List<EmployeeModel> employees = collectionsClass.GetEmpList();
            //GenericClassMedthodExample<List<EmployeeModel>> genericClassMedthodExample =
            //    new DataStructures.GenericClassMedthodExample<List<EmployeeModel>>();
            //Console.WriteLine(genericClassMedthodExample.JSONConver(employees));
            //Console.ReadKey();

            ////Generic Method
            //GenericMethodExample genericMethodExample = new GenericMethodExample();
            //genericMethodExample.GetGmethod<int>("INTEGER", 100);
            //genericMethodExample.GetGmethod<double>("Decimal", 100.012);
            //genericMethodExample.GetGmethod<float>("Float", 100f);
            //genericMethodExample.GetGmethod<string>("String", "B VAMSHI KRISHNA");
            //Console.ReadKey();





            #region Array ArrayList


            ////Arry is for fixed length
            //int[] intArray= new int[10];
            //intArray.SetValue(0,0);
            //intArray.SetValue(1,1);
            //intArray.SetValue(2,2);
            //intArray.SetValue(3,3);
            //intArray.SetValue(4,4);
            //intArray.SetValue(5,5);
            //intArray.SetValue(6,6);
            //intArray.SetValue(7,7);
            //intArray.SetValue(8,8);
            //intArray.SetValue(9,9);




            //string[] strArray = new string[10];
            //strArray.SetValue("AAAA", 0);
            //strArray.SetValue("AAAB",1);
            //strArray.SetValue("CAAAA",2);
            //strArray.SetValue("DAAA",3);
            //strArray.SetValue("EAA",4);
            //strArray.SetValue("FAAAA",5);
            //strArray.SetValue("GAAA",6);
            //strArray.SetValue("HAA",7);
            //strArray.SetValue("IAAA",8);
            //strArray.SetValue("JAAA",9);
            //Console.WriteLine("String Array");
            //Console.WriteLine("Int Array");
            //for (int i = 0; i < 10; i++)
            //{

            //    Console.WriteLine(intArray[i]);
            //    Console.WriteLine(strArray[i]);
            //}

            //object[] objects = new object[10];

            ////ArrayList is dynamic in length

            //ArrayList array = new ArrayList();
            //array.Add(intArray);
            //array.Add(strArray);
            //CollectionsClass collectionsClass = new CollectionsClass();
            //List<EmployeeModel> employees = collectionsClass.GetEmpList();
            //array.Add(employees);
            //Console.WriteLine("Array List");

            //int j = 0;
            //foreach(var sobj in array)
            //{

            //    if (j == 0)
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {

            //            Console.WriteLine(((int[])sobj)[i]);
            //        }

            //    }

            //    if (j == 1)
            //    {
            //        for (int i = 0; i < 10; i++)
            //        {

            //            Console.WriteLine(((string[])sobj)[i]);
            //        }

            //    }


            //    if (j>1)
            //    {
            //        GenericClassMedthodExample<List<EmployeeModel>> genericClassMedthodExample =
            //            new DataStructures.GenericClassMedthodExample<List<EmployeeModel>>();
            //        Console.WriteLine(genericClassMedthodExample.JSONConver((List<EmployeeModel>)sobj));
            //    }
            //    j++;
            //}



            //Console.ReadKey();
            #endregion Array ArrayList


            ListExample example = new ListExample();
            Console.WriteLine("LIST");
            example.Getdata().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();

            Console.WriteLine("Queues START");
            QueueExample queue = new QueueExample();
            Queue<string> stringsQueue = new Queue<string>();
            stringsQueue = queue.Getdata();
            Console.WriteLine(stringsQueue.Dequeue());
            Console.ReadKey();
            Console.WriteLine(stringsQueue.Dequeue());
            Console.ReadKey();
            Console.WriteLine("Queues END");


            Console.WriteLine("STACK START");
            StackExample stackExample = new StackExample();
            Stack<string> stringsStack = new Stack<string>();
            stringsStack=stackExample.GetStack();
            Console.WriteLine(stringsStack.Pop());
            Console.ReadKey();
            Console.WriteLine(stringsStack.Pop());
            Console.ReadKey();
            Console.WriteLine("STACK END");
            Console.ReadKey();
        }
    }
}
