using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.Oops
{
    public class ConstReadonlyExample
    {
        const string taxPercentage = "18%";
        const string GST = "5%";

        public readonly string serviceTax;

        //Constructor
        public ConstReadonlyExample(string _serviceTax) {
            serviceTax = _serviceTax;
        }


        public void GetConstReadOnlyValues()
        {
            Console.WriteLine("Tax Percentage ="+ taxPercentage);
            Console.WriteLine("GST =" + GST);
            Console.WriteLine("Service Tax =" + serviceTax);
        }
    }
}
