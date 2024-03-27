using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.DataStructures
{
    public class GenericClassMedthodExample <T>
    {
   
        //model needs to convet to json
        public GenericClassMedthodExample() { 
        
        }

        public string JSONConver(T obj)
        {
            //TO DO : Some process
           return Newtonsoft.Json.JsonConvert.SerializeObject(obj);

        }

    }
}
