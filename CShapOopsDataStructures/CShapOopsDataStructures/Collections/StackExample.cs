using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapOopsDataStructures.Collections
{
    public class StackExample
    {
        public Stack<string> GenericStack()
        {
            Stack<string> strings = new Stack<string>();
            strings.Push("1");
            strings.Push("2");
            strings.Push("3");
            strings.Push("4");
            strings.Push("5");
            strings.Push("6");
            return strings;
        }

        public Stack NonGenericStack()
        {
            Stack strings = new Stack();
            strings.Push("1");
            strings.Push("Vamshi");
            strings.Push("3.b");
            strings.Push("4adbv");
            strings.Push("5");
            strings.Push("asdasdasd");
            return strings;
        }
    }
}
