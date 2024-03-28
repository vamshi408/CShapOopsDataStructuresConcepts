using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.CShap
{
    public class APIcallFromCShapExapmle
    {

        public void GetPublic() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://dummyjson.com/products");
                Console.WriteLine(Environment.NewLine + result);
            }
        }
        private void GetPrivate() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://dummyjson.com/products");
                Console.WriteLine(Environment.NewLine + result);
            }
        }
        protected void GetProtected() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://dummyjson.com/products"); 
                Console.WriteLine(Environment.NewLine + result);
            }
        }

        internal void GetInternal() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://dummyjson.com/products");
                Console.WriteLine(Environment.NewLine + result);
            }
        }
        protected internal void GetProtectedInternal() //Get All Events Records  
        {
            using (var client = new WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://dummyjson.com/products");
                Console.WriteLine(Environment.NewLine + result);
            }
        }
    }
}
