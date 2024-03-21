using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public class ArrayExample
    {
        int[] a = { 1, 2, 3 };
        int[] b = { 4, 5, 6 };


        /// <summary>
        /// Copy to has arguments/parameters as destination array & start index i.e. 
        /// from where we need to start copying the elements of source arry
        /// </summary>
        public void CopyTOArrayConcept()
        {
           
            int[] c = new int[a.Length + b.Length];

            a.CopyTo(c, 0);
            b.CopyTo(c, a.Length);

            foreach(var data in c)
            {
                Console.WriteLine( data);
            }
        }

    }
}
