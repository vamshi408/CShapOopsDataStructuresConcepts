﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.CShap
{
    public class DynamicExample
    {
        public void ProcessDynamdata()
        {
            //ExampleClass ec = new ExampleClass();
            //// The following call to exampleMethod1 causes a compiler error
            //// if exampleMethod1 has only one parameter. Uncomment the line
            //// to see the error.
            ////ec.exampleMethod1(10, 4);

            //dynamic dynamic_ec = new ExampleClass();
            //// The following line is not identified as an error by the
            //// compiler, but it causes a run-time exception.
            //dynamic_ec.exampleMethod1(10, 4);

            //// The following calls also do not cause compiler errors, whether
            //// appropriate methods exist or not.
            //dynamic_ec.someMethod("some argument", 7, null);
            //dynamic_ec.nonexistentMethod();




            dynamic d1 = 7;
            dynamic d2 = "a string";
            dynamic d3 = System.DateTime.Today;
            dynamic d4 = System.Diagnostics.Process.GetProcesses();

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            System.Diagnostics.Process[] procs = d4;

            Console.WriteLine(i);
            Console.WriteLine(d1);
            Console.WriteLine(str);
            Console.WriteLine(d2);
            Console.WriteLine(dt);
            Console.WriteLine(d3);
            Console.WriteLine(procs);
            Console.WriteLine(d4);
        }
    }
    class ExampleClass
    {
        public ExampleClass() { }
        public ExampleClass(int v) { }

        public void exampleMethod1(int i) { }

        public void exampleMethod2(string str) { }
    }
}
