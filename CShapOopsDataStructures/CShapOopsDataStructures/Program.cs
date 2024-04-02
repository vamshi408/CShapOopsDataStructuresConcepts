using CShapOopsDataStructures.Collections;
using CShapOopsDataStructures.CShap;
using CShapOopsDataStructures.DataStructures;
using CShapOopsDataStructures.Models;
using CShapOopsDataStructures.Oops;
using CShapOopsDataStructures.Threading;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CShapOopsDataStructures
{
    public class Program : APIcallFromCShapExapmle   
    {
       
        public static void Main(string[] args)
        {
            //ConcurrencyDemo();
            ParallisamDemo();
            Console.ReadKey(); ;
        }


        #region Concurancy
        public static void ConcurrencyDemo()
        {
            ConcurancyDownload1();
            ConcurancyDownload2();
            ConcurancyEnterData();
            Console.ReadKey();
        }


        public async static void ConcurancyDownload1()
        {
            Console.WriteLine("Downloading File1");
           await Task.Delay(10000);
        }

        public async static void ConcurancyDownload2()
        {
            Console.WriteLine("Downloading File2");
            await Task.Delay(10000);
        }


        public static void ConcurancyEnterData()
        {
            Console.WriteLine("Enter Data :");
           string s= Console.ReadLine();
            Console.WriteLine("You have enter data="+s);
        }

        #endregion Concurancy


        #region Parallisam
        //Parallism mean increase performance
        public static void ParallisamDemo()
        {

            Task.Factory.StartNew(() =>
            {
                ParallisamDownload1();
            });

            Task.Factory.StartNew(() =>
            {
                ParallisamDownload2();
            });

            Task.Factory.StartNew(() =>
            {
                ParallisamEnterData();
            });
            Console.ReadKey();
        }


        public static void ParallisamDownload1()
        {
            Console.WriteLine("Downloading File1");
            Task.Delay(10000);
        }

        public static void ParallisamDownload2()
        {
            Console.WriteLine("Downloading File2");
            Task.Delay(10000);
        }


        public static void ParallisamEnterData()
        {
            Console.WriteLine("Enter Data :");
            string s = Console.ReadLine();
            Console.WriteLine("You have enter data=" + s);
        }

        #endregion Parallisam

    }
}
