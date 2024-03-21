using CShapOopsDataStructures.DataStructures;
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
            IEnumeratorExample enumerator= new IEnumeratorExample();
            enumerator.GetIEnumeratorData();
            Console.ReadKey();

        }
    }
}
