using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.Collections
{
    public class QueueExample
    {
        public Queue<string> GenericQueue()
        {
            //First In FIrs Out 
            //Token Systems in Banks,Ticktes,Orders etc
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2"); 
            queue.Enqueue("3");
                
            queue.Enqueue("4");
            queue.Enqueue("5");
            queue.Enqueue("6");
            return queue;
        }

        public Queue NonGenericQueue()
        {
            //First In FIrs Out 
            //Token Systems in Banks,Ticktes,Orders etc
            Queue queue = new Queue();
            queue.Enqueue("1");
            queue.Enqueue("2VSADVCF");
            queue.Enqueue("svsdv");

            queue.Enqueue("4.222");
            queue.Enqueue("vsdv");
            queue.Enqueue("6");
            return queue;
        }
    }
}
