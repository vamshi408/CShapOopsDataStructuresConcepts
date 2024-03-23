using CShapOopsDataStructures.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.Oops
{
    /// <summary>
    /// For extension methods we need to create static class
    /// In this we need to create a static method 
    /// with parameter this keyword and class name for which you want to create a extension method
    /// </summary>
    public static class ExtensionMethodExample
    {
        public static String ExtensionString( this String obj)
        {
            return obj.Replace("//","\\\\").ToString();
        }


        //Example 2 i am extending CollectionsClass
        public static List<CustomerCollectionModel> ExtendToCustomer(this CollectionsClass collectionsClass)
        {
            List<CustomerCollectionModel> customerCollectionModels = new List<CustomerCollectionModel>
            {
                new CustomerCollectionModel()
                {
                    CustomerID=1001,
                    Name="Vamshi",
                    Phone="+91 9999999999",
                    Email="Vamshi@gmail.com"
                },
                new CustomerCollectionModel()
                {
                    CustomerID=1002,
                    Name="Krishna",
                    Phone="+91 8888888888",
                    Email="Krishna@gmail.com"
                },
                new CustomerCollectionModel()
                {
                    CustomerID=1003,
                    Name="Bandi",
                    Phone="+91 3333333333",
                    Email="Bandi@gmail.com"
                },
            };
            return customerCollectionModels;

        }
    }
}
