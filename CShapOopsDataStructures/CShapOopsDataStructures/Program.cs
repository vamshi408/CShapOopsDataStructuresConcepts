using CShapOopsDataStructures.DataStructures;
using CShapOopsDataStructures.Oops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures
{
    internal class Program
    {
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
            //Console.WriteLine("Loacl Path : "+serverpath);
            //string convertedpath = ExtensionMethodExample.ExtensionString(serverpath);
            //Console.WriteLine("Server Path : " + convertedpath);
            //Console.ReadKey();

            CollectionsClass collectionsClass = new CollectionsClass();
            foreach(var data in collectionsClass.ExtendToCustomer())
            {
                Console.WriteLine(data.CustomerID);
                Console.WriteLine(data.Name);
            }
            Console.ReadKey();
        }
    }
}
