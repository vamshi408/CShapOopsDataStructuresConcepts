﻿using CShapOopsDataStructures.Collections;
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
       private static object _locker=new object();
       static ManualResetEvent resetEvent= new ManualResetEvent(false);
        static AutoResetEvent autoResetEvent= new AutoResetEvent(true);
        public static void Main(string[] args)
        {
            //ConcurrencyDemo();
            //ParallisamDemo();
            //TaskAwaiterCallBackDemo();
            //NormalThreadExample();

            /////////Manual Reset//////////////
            //new Thread(writeThread).Start();

            //for (int i=0; i<5; i++)
            //{
            //    new Thread(readingThread).Start();
            //}



            /////////Auto Reset//////////////
            for (int i = 0; i < 5; i++)
            {
                new Thread(writeAutoThread).Start();
            }

            new Thread(readingAutoThread).Start();

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




        #region awaiter with OnCompleted call back function
        //Task with awaiter call back function

        public static void TaskAwaiterCallBackDemo()
        {
            Console.WriteLine("Call Back Demo");


           var task1= Task.Run(() =>
            {
                Download1();
            });
           var task2= Task.Run(() =>
            {
              return  Download2();
            });

            var awaiter2 = task2.GetAwaiter();
            awaiter2.OnCompleted(async ()=>{

                Console.WriteLine("OnCompleted call back for Download2");
                var result2=awaiter2.GetResult();
                Download3(result2);
            });




            //Task.WaitAll(task1,task2);

            //var awaiter1=task1.GetAwaiter();
            //var awaiter2=task2.GetAwaiter();

            //var result2 = awaiter2.GetResult();
            //Download3(result2);



        }

        public static void Download1()
        {
            Console.WriteLine("Downloading 1");
            Task.Delay(100000);
        }

        public static string Download2()
        {
            Console.WriteLine("Downloading 2");
            Task.Delay(100000);
            Console.WriteLine("25MB");
            return "25MB";
        }

        public static string Download3(string download2)
        {
            Console.WriteLine("Downloading 3");
            Task.Delay(10000);
            Console.WriteLine("Download2 =+" + download2 + " Download3= 500MB");
            return "Download2 =+" + download2 + " Download3= 500MB";
        }

        #endregion awaiter with OnCompleted call back function



        #region Lock Monitor mutex & Semaphore

        //Thread Example
        public static void NormalThreadExample()
        {
            for(int i=0; i < 5; i++)
            {
              new Thread(DoSomeTaskNormal).Start();
            }
        }

       
        public static void DoSomeTaskNormal()
        {
           
                Console.WriteLine("Start " + Thread.CurrentThread.ManagedThreadId.ToString() + " Started");
                Thread.Sleep(200);
                Console.WriteLine("End " + Thread.CurrentThread.ManagedThreadId.ToString() + " Completed");
           
        }


        //Lock Example
        public static void LockExample()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(DoSomeTaskLock).Start();
            }
        }

        public static void DoSomeTaskLock()
        {
            lock (_locker) {
                Console.WriteLine("Start " + Thread.CurrentThread.ManagedThreadId.ToString() + " Started");
                Thread.Sleep(200);
                Console.WriteLine("End " + Thread.CurrentThread.ManagedThreadId.ToString() + " Completed");
            }
        }


        //Monitor Example
        public static void MonitorExample()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(DoSomeTaskMonitor).Start();
            }
        }

        public static void DoSomeTaskMonitor()
        {
            try
            {
                Monitor.Enter(_locker);

                Console.WriteLine("Start " + Thread.CurrentThread.ManagedThreadId.ToString() + " Started");
                Thread.Sleep(200);
                Console.WriteLine("End " + Thread.CurrentThread.ManagedThreadId.ToString() + " Completed");

            }
            catch (Exception ex)
            {
                //log error
            }
            finally
            {
                Monitor.Exit(_locker);
            }
        }
        #endregion Lock Monitor mutex & Semaphore

        #region ManualReset

        
        public static void writeThread()
        {
            resetEvent.Reset();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId+ " Writing Started");
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Writing End");
            resetEvent.Set();

        }

        public static void readingThread()
        {
            
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Reading Started by waiting");
            resetEvent.WaitOne();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Reading End");

        }

        #endregion ManualReset


        #region AutoReset


        public static void writeAutoThread()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " WAITING ......");
            autoResetEvent.WaitOne();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Writing Started");
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Writing End");
            autoResetEvent.Set();

        }

        public static void readingAutoThread()
        {

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Reading Started by waiting");        
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Reading End");

        }

        #endregion AutoReset
    }
}
