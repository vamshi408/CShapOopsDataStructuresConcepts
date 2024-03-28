using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.CShap
{
    public class AsyncAwaitTaskExample
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }

        public static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 2");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }






        public static async Task<int> FirstMethod()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for(int i= 0;i < 100; i++)
                {
                    Console.WriteLine("First Method");
                    count++;
                    Task.Delay(100).Wait();
                }
            });
            return count;
        }

        public static async Task SecondMethod(int count)
        {
            await Task.Run(() => {
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Second Method with FCount"+ count);
                    Task.Delay(100).Wait();
                }
            });
        }

        public static async Task ThirdMethod()
        {
            await Task.Run(() => {
                for (int x = 0; x < 20; x++)
                {
                    Console.WriteLine("Third Method");
                    Task.Delay(100).Wait();
                }
            });
        }
    }
}
